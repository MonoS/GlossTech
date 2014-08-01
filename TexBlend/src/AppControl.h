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

#pragma once

#include <vector>
#include <string>

#include "Commctrl.h"
#include <string.h>
#include "TextureControl.h"
#include "previewwindow.h"
#include <fstream>

#define ID_SETSLIST 500
#define ID_CHANNELLIST 501
#define ID_SUBSETSLIST 502
#define ID_CHECKUSECURRENT 503
#define ID_TEXTURESOURCELIST 504
#define ID_LibraryView 505
#define ID_BLENDIMAGE 506
#define ID_PREVIEW	507
#define ID_SRCPREVIEW	508
#define ID_MODPREVIEW	509
#define ID_DESTPREVIEW	510

#define PREVIEW_SOURCE  1
#define PREVIEW_MOD 	1<<1
#define PREVIEW_FINAL	1<<2

using namespace std;

class AppControl
{
	HFONT hAppFont;
	HWND hMainWnd;
	HINSTANCE hAppInstance;
	PreviewWindow* previewWnd;

	string curSetName;
	string curChannel;
	bool AutoPilot;

	HWND mMessageView;
	HWND mSetsList;
	HWND mChannelList;
	HWND mSubSetsList;
	HWND mCheckUseCurrent;
	HWND mTextureSourceList;
	HWND mLibraryView;
	HWND mBlendImageButton;
	HWND mPreviewButton;
	HWND mSrcPreview;	
	HWND mModPreview;
	HWND mDestPreview;

	TextureControl* mTexController;

	int createSubSetsList();
	int createTextureSourceView();
	int createLibraryView();
	
	int addFilesInFolderToTree(HWND hTreeView,string folderName, HTREEITEM parent);
	bool treeSelectionToPath(HWND hTreeView,string& outPath);

	bool modSelDirty;
	bool sourceSelDirty;

	fstream debugOutput;
	void beginDebug() { 
		debugOutput.open("dbgOut.log",ios_base::trunc |ios_base::out);
	}
	void endDebug() {
		debugOutput.close();
	}

	map<string, string> config;

	string msgAppend;
public:
	AppControl(void);
	AppControl(HWND mainWnd, HINSTANCE appInstance);
	void LoadConfig();

	void SetApplicationFont(HFONT font) { hAppFont = font; }

	void InitTextureController();
	void SetBlankPreview(unsigned int which = PREVIEW_MOD|PREVIEW_FINAL|PREVIEW_SOURCE);	
	void SetPreview(unsigned int which, string imgName, bool refresh = false);
	void SetPreview(unsigned int which, HBITMAP img);
	int CreateControls();

	void ResetSetList();
	void ResetChannelList();
	void ResetSubSetList();
	void ResetSourceView();
    void ResetLibraryView();


	void PopulateSetList();
	void PopulateChannelList(string forSet);
	void PopulateSubSetList(string forSet, string forChannel);
	void PopulateLibraryView(string forSet, string forChannel);
	void PopulateSourceView(string forSet, string forChannel);

	void PreviewSelectedSource(bool clear = false, int selIndex = 0);
	void PreviewSelectedMod(bool clear = false);
	void PreviewFinal(bool clear = false, int selIndex = 0);

	void NotifyPreviewClosing() {
		if(previewWnd) 
			delete previewWnd;
		previewWnd = NULL;
	}

	int GetSelectedSubSets(vector<string>& selection);

	LRESULT ProcessNotify(NMHDR* nmHdr,WPARAM wParam);
	LRESULT ProcessCommand(int controlID, int evt, LPARAM lParam);

	void SetMessage(string msg);

	bool OnAuto() { return AutoPilot; }
	int AutoHeadFix();

	~AppControl(void);
};
