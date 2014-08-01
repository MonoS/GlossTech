/*
Caliente's Texture Blender
by Caliente

This software is provided 'as-is', without any express or implied
warranty. In no event will the authors be held liable for any
damages arising from the use of this software.

Permission is granted to anyone to use this software for any
purpose, including commercial applications, and to alter it and
redistribute it freely, subject to the following restrictions:

1. The origin of this software must not be misrepresented; you must
not claim that you wrote the original software. If you use this
software in a product, an acknowledgment in the product documentation
would be appreciated but is not required.

2. Altered source versions must be plainly marked as such, and
must not be misrepresented as being the original software.

3. This notice may not be removed or altered from any source
distribution.
*/

#include "StdAfx.h"
#include "PreviewWindow.h"

bool PreviewWindow::has_registered = false;

PreviewWindow::PreviewWindow(void)
{
}

PreviewWindow::~PreviewWindow(void)
{
	SendMessage(mHwnd,WM_DESTROY,0,0);
}

PreviewWindow::PreviewWindow(HWND owner, HBITMAP bitmap) {
	if(!has_registered) 
		registerClass ();

	hOwner = owner;//WS_OVERLAPPEDWINDOW
	int sX = GetSystemMetrics(SM_CXDLGFRAME)*2;
	int sY = GetSystemMetrics(SM_CYDLGFRAME)*2;
	sY += GetSystemMetrics(SM_CYSMCAPTION);
	mHwnd = CreateWindowExA(WS_EX_PALETTEWINDOW,"TB_PREVIEW_WINDOW","Preview",WS_OVERLAPPED | WS_DLGFRAME | WS_SYSMENU ,CW_USEDEFAULT,0,768+sX, 768+sY,NULL,NULL,GetModuleHandle(NULL),NULL);
	SetWindowLong(mHwnd,GWL_USERDATA,(LONG) this);
	//GetSystemMetrics
	HWND PicWindow = CreateWindow("STATIC","IMage Preview",WS_CHILD|WS_VISIBLE|SS_BITMAP,0,0, 768, 768,mHwnd,0,GetModuleHandle(NULL),NULL);
	SendMessage(PicWindow,STM_SETIMAGE,IMAGE_BITMAP,(LPARAM)bitmap);

	ShowWindow(mHwnd, SW_SHOW);
	UpdateWindow(mHwnd);
}

void PreviewWindow::registerClass() {
	WNDCLASSEX wcex;
	HINSTANCE hinst = GetModuleHandle(NULL);

	wcex.cbSize = sizeof(WNDCLASSEX);

	wcex.style			= CS_HREDRAW | CS_VREDRAW;
	wcex.lpfnWndProc	= PreviewWindowWndProc;
	wcex.cbClsExtra		= 0;
	wcex.cbWndExtra		= 0;
	wcex.hInstance		= hinst;
	wcex.hIcon			= LoadIcon(NULL, MAKEINTRESOURCE(IDI_APPLICATION));
	wcex.hCursor		= LoadCursor(NULL, IDC_ARROW);
	wcex.hbrBackground	= (HBRUSH)(COLOR_BTNFACE+1);
	wcex.lpszMenuName	= NULL;
	wcex.lpszClassName	= "TB_PREVIEW_WINDOW";
	wcex.hIconSm		= LoadIcon(NULL, MAKEINTRESOURCE(IDI_APPLICATION));

	RegisterClassEx(&wcex);
	has_registered = true;
}

LRESULT CALLBACK PreviewWindowWndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam)
{
	PreviewWindow* p = (PreviewWindow*)GetWindowLong(hWnd,GWL_USERDATA);
	switch (message)
	{
		case WM_DESTROY:
			PostMessage(p->hOwner,MSG_PREVIEWCLOSING,0,0);
		default:
			return DefWindowProc(hWnd, message, wParam, lParam);
	}
	return 0;
}