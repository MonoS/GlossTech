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
#include "AppControl.h"

#include "Commctrl.h"
#include <string.h>

#include "tinyxml.h"



AppControl::AppControl(void)
{
	mTexController = NULL;
	previewWnd = NULL;
	sourceSelDirty = modSelDirty = true;
	AutoPilot = false;
}

AppControl::AppControl(HWND mainWnd, HINSTANCE appInstance) {
	hMainWnd = mainWnd;
	hAppInstance = appInstance;
	mTexController = NULL;
	previewWnd = NULL;
	sourceSelDirty = modSelDirty = true;
	INITCOMMONCONTROLSEX ccinit;
	ccinit.dwICC = ICC_LISTVIEW_CLASSES;
	ccinit.dwSize = sizeof(INITCOMMONCONTROLSEX);
	InitCommonControlsEx(&ccinit);
	AutoPilot = false;
	LoadConfig();
	//beginDebug();
}

AppControl::~AppControl(void)
{
	if(mTexController) delete mTexController;
	if(previewWnd) delete previewWnd;
	//endDebug();
}

void AppControl::LoadConfig() {
	HKEY skyrimRegKey;
	char installPath[256];
	DWORD pathSize = 256;
	string buildpath;

	long result = RegOpenKeyEx(HKEY_LOCAL_MACHINE,"SOFTWARE\\Bethesda Softworks\\Skyrim",0,KEY_READ,&skyrimRegKey);
	if(result == ERROR_SUCCESS) {
		RegQueryValueEx(skyrimRegKey,"Installed Path",0,0,(BYTE*)installPath,&pathSize);
		buildpath = installPath;
		buildpath += "Data\\";
		config["SkyrimDataPath"] = buildpath;
	}

	TiXmlDocument doc("Config.xml");
	TiXmlElement* root;
	TiXmlElement* e;
	if(doc.LoadFile()) {
		root = doc.FirstChildElement("TexBlendConfig");
		if(!root) return;
		
		e = root->FirstChildElement("GameDataPath");
		if(e) {
			config["SkyrimDataPath"] = e->GetText();
		}

		e = root->FirstChildElement("TexOutputPath");
		if(e) {
			config["SkyrimOutPath"] = e->GetText();
		} else {
			config["SkyrimOutPath"] = config["SkyrimDataPath"];
		}
		 

		e = root->FirstChildElement("DefUseInstalledSource");
		if(e) {
			config["DefUseInstalledSource"] = e->GetText();
		}

		e = root->FirstChildElement("AlphaMatteColor");
		if(e) {
			config["AlphaMatteColor"] = e->GetText();
		}
		e = root->FirstChildElement("NoStripPremultAlpha");
		if(e) {
			config["NoStripPremultAlpha"] = e->GetText();
		}

		e = root->FirstChildElement("AutoHeadFix");
		if(e) {
			string s = e->GetText();
			if(s == "true") {
				AutoPilot = true;
			}
		}
	}
}

void AppControl::InitTextureController() {
	mTexController = new TextureControl();
	mTexController->InitImageLibrary();
	mTexController->LoadSupportedSets();	
	if(config.find("AlphaMatteColor") != config.end()) {
		if(config["AlphaMatteColor"] == "black") {
			mTexController->SetAlphaMatte(ALPHA_MATTE_BLACK);
		} else {		
			mTexController->SetAlphaMatte(ALPHA_MATTE_WHITE);
		}
	}	
	if(config.find("NoStripPremultAlpha") != config.end()) {
		if(config["NoStripPremultAlpha"] == "1") {
			mTexController->SetStripPremultAlpha(false);
		} else {		
			mTexController->SetStripPremultAlpha(true);
		}
	}
}

int AppControl::CreateControls() {

	HWND setlistlabel = CreateWindow("STATIC","Set:", WS_CHILD | WS_VISIBLE, 10, 13, 40, 30, hMainWnd, 0,hAppInstance,NULL);
	SendMessage(setlistlabel,WM_SETFONT,(WPARAM)hAppFont,0);

    mSetsList = CreateWindow("ComboBox","SetsList",WS_CHILD | WS_VISIBLE | CBS_DROPDOWNLIST , 50,10,180,500,hMainWnd,(HMENU)ID_SETSLIST,hAppInstance,NULL);
    SendMessage(mSetsList,WM_SETFONT, (WPARAM)hAppFont,0);
    ResetSetList();

	HWND typelistlabel = CreateWindow("STATIC","Type:", WS_CHILD | WS_VISIBLE, 10, 43, 40, 30, hMainWnd, 0,hAppInstance,NULL);
	SendMessage(typelistlabel,WM_SETFONT,(WPARAM)hAppFont,0);

	mChannelList = CreateWindow("ComboBox","ChannelList",WS_CHILD | WS_VISIBLE | WS_DISABLED | CBS_DROPDOWNLIST , 50,40,180,500,hMainWnd,(HMENU)ID_CHANNELLIST,hAppInstance,NULL);
	SendMessage(mChannelList,WM_SETFONT, (WPARAM)hAppFont,0);
	ResetChannelList();

	createSubSetsList();

	mCheckUseCurrent = CreateWindow("BUTTON","Use Currently installed textures", WS_CHILD | WS_VISIBLE | BS_AUTOCHECKBOX, 15, 555, 220, 30, hMainWnd, (HMENU)ID_CHECKUSECURRENT,hAppInstance,NULL);
	SendMessage(mCheckUseCurrent,WM_SETFONT,(WPARAM)hAppFont,0);
	if(config.find("DefUseInstalledSource") != config.end()) 
		if(config["DefUseInstalledSource"] == "1") {
			SendMessage(mCheckUseCurrent,BM_SETCHECK,(WPARAM) BST_CHECKED,0);
	}
  
	HWND sourceViewLabel = CreateWindow("STATIC","4. Choose Source Texture", WS_CHILD | WS_VISIBLE, 10, 315, 220, 30, hMainWnd, 0,hAppInstance,NULL);
	SendMessage(sourceViewLabel,WM_SETFONT,(WPARAM)hAppFont,0);
   
	createTextureSourceView();
	
    HWND treeViewLabel = CreateWindow("STATIC","5. Choose Texture Mod to Apply", WS_CHILD | WS_VISIBLE, 250, 10, 200, 30, hMainWnd, 0,hAppInstance,NULL);
	SendMessage(treeViewLabel,WM_SETFONT,(WPARAM)hAppFont,0);
   

	createLibraryView();

	HWND sourcePreviewLabel = CreateWindow("STATIC","Source Preview", WS_CHILD | WS_VISIBLE, 570, 10, 200, 30, hMainWnd, 0,hAppInstance,NULL);
	SendMessage(sourcePreviewLabel,WM_SETFONT,(WPARAM)hAppFont,0);
   

	 mSrcPreview = CreateWindow("STATIC","Source Preview",WS_CHILD|WS_VISIBLE|SS_BITMAP|SS_SUNKEN|SS_NOTIFY, 570,25, 128, 128,hMainWnd,(HMENU)ID_SRCPREVIEW,hAppInstance,NULL);
	
	
    HWND modPreviewLabel = CreateWindow("STATIC","Modification Preview", WS_CHILD | WS_VISIBLE, 570, 160, 200, 30, hMainWnd, 0,hAppInstance,NULL);
	SendMessage(modPreviewLabel,WM_SETFONT,(WPARAM)hAppFont,0);
   
	mModPreview =CreateWindow("STATIC","bm",WS_CHILD|WS_VISIBLE|SS_BITMAP|SS_REALSIZECONTROL|SS_SUNKEN|SS_NOTIFY, 570,175, 128, 128,hMainWnd,(HMENU)ID_MODPREVIEW,hAppInstance,NULL);
    
	HWND destPreviewLabel = CreateWindow("STATIC","Destination Preview", WS_CHILD | WS_VISIBLE, 570, 310, 200, 30, hMainWnd,0,hAppInstance,NULL);
	SendMessage(destPreviewLabel,WM_SETFONT,(WPARAM)hAppFont,0);
   
	mDestPreview =CreateWindow("STATIC","bm",WS_CHILD|WS_VISIBLE|SS_BITMAP|SS_REALSIZECONTROL|SS_SUNKEN|SS_NOTIFY, 570,325, 128, 128,hMainWnd,(HMENU)ID_DESTPREVIEW,hAppInstance,NULL);
    
	mPreviewButton = CreateWindow("BUTTON","Preview", WS_CHILD | WS_VISIBLE, 570, 460, 128, 25, hMainWnd, (HMENU)ID_PREVIEW,hAppInstance,NULL);
	SendMessage(mPreviewButton,WM_SETFONT,(WPARAM)hAppFont,0);

	mBlendImageButton = CreateWindow("BUTTON","Blend Images", WS_CHILD | WS_VISIBLE, 570, 510, 128, 50, hMainWnd, (HMENU)ID_BLENDIMAGE,hAppInstance,NULL);
	SendMessage(mBlendImageButton,WM_SETFONT,(WPARAM)hAppFont,0);

	mMessageView = CreateWindow("STATIC","  Ready", WS_CHILD | WS_VISIBLE | SS_SUNKEN, 0, 595, 714,17, hMainWnd,0,hAppInstance,NULL);
	SendMessage(mMessageView,WM_SETFONT,(WPARAM)hAppFont,0);
   
   return 0;

}

void AppControl::SetBlankPreview(unsigned int which) {
	if(mTexController == NULL) 
		return;
	HDC dc = GetDC(hMainWnd);
	HBITMAP bm = mTexController->GetBlankBitmap(dc);
	SetPreview(which,bm);
}
	
void AppControl::SetPreview(unsigned int which, string imgName, bool refresh) {
	HBITMAP srcBM=mTexController->GetBitmap(imgName,GetDC(hMainWnd),refresh);
	if(srcBM == NULL)
		SetBlankPreview(which);
	else
		SetPreview(which,srcBM);
}

void AppControl::SetPreview(unsigned int which, HBITMAP img) {	
	HBITMAP bmOld;
	if(which & PREVIEW_SOURCE) {
		bmOld = (HBITMAP)SendMessage(mSrcPreview,STM_SETIMAGE,IMAGE_BITMAP,(LPARAM)img);
		//if(bmOld != img) 
		//	DeleteObject(bmOld);
	}
	if(which & PREVIEW_MOD) {
		bmOld = (HBITMAP)SendMessage(mModPreview,STM_SETIMAGE,IMAGE_BITMAP,(LPARAM)img);
		//if(bmOld != img) 
		//	DeleteObject(bmOld);
	}
		
	if(which & PREVIEW_FINAL) {
		bmOld = (HBITMAP)SendMessage(mDestPreview,STM_SETIMAGE,IMAGE_BITMAP,(LPARAM)img);
		//if(bmOld != img) 
		//	DeleteObject(bmOld);
	}
}

void AppControl::ResetSetList() {

   SendMessageA(mSetsList,CB_RESETCONTENT,0,0);
   SendMessage(mSetsList,CB_ADDSTRING,0,(LPARAM)"[1. Select Texture Set]");
   SendMessage(mSetsList,CB_SETCURSEL,(WPARAM)0,0);
   curSetName = "";
}

void AppControl::ResetChannelList() {

   SendMessageA(mChannelList,CB_RESETCONTENT,0,0);
   SendMessage(mChannelList,CB_ADDSTRING,0,(LPARAM)"[2. Select Texture Type]");
   SendMessage(mChannelList,CB_SETCURSEL,(WPARAM)0,0);

   curChannel = "";
}
void AppControl::ResetSubSetList() {
   ListView_DeleteAllItems(mSubSetsList);
}

void AppControl::ResetSourceView() {
   TreeView_DeleteAllItems(mTextureSourceList);
}

void AppControl::ResetLibraryView() {
	TreeView_DeleteAllItems(mLibraryView);
	
	//TVINSERTSTRUCT tvis;
	//tvis.hInsertAfter = TVI_FIRST;
	//tvis.hParent = TVI_ROOT;
	//tvis.item.mask = TVIF_TEXT;
	//tvis.item.pszText = "5. Choose Texture Mod";
	//
	//TreeView_InsertItem(mLibraryView,&tvis);
	
}

int AppControl::createSubSetsList() {
	LVCOLUMN lvc;
	lvc.mask = LVCF_WIDTH | LVCF_TEXT | LVCF_SUBITEM;
	lvc.iSubItem = 0;
	lvc.pszText = "3. Choose What to Change";
	lvc.cx = 216;
	mSubSetsList = CreateWindowExA(WS_EX_CLIENTEDGE,"SysListView32","",WS_CHILD | WS_VISIBLE | WS_DISABLED | LVS_REPORT | LVS_NOSORTHEADER | LVS_SINGLESEL, 10,70, lvc.cx+4, 240, hMainWnd,(HMENU) ID_SUBSETSLIST,hAppInstance,NULL);
	SendMessage(mSubSetsList,WM_SETFONT, (WPARAM)hAppFont,0);
	ListView_SetExtendedListViewStyle(mSubSetsList,LVS_EX_CHECKBOXES | LVS_EX_GRIDLINES | LVS_EX_FULLROWSELECT);
	ListView_InsertColumn(mSubSetsList,0,&lvc);

	ResetSubSetList();

   
	return 0;
}

int AppControl::createTextureSourceView() {
	
   	mTextureSourceList = CreateWindowExA(WS_EX_CLIENTEDGE,WC_TREEVIEWA,"",WS_CHILD | WS_VISIBLE |WS_DISABLED|TVS_FULLROWSELECT|TVS_HASBUTTONS|TVS_SHOWSELALWAYS|TVS_LINESATROOT , 10,330, 220, 230, hMainWnd,(HMENU) ID_TEXTURESOURCELIST,hAppInstance,NULL);
	SendMessage(mTextureSourceList,WM_SETFONT, (WPARAM)hAppFont,0);

	ResetSourceView();


	return 0;
}
int AppControl::createLibraryView() {

	mLibraryView = CreateWindowExA(WS_EX_CLIENTEDGE,WC_TREEVIEWA,"",WS_CHILD | WS_VISIBLE |TVS_FULLROWSELECT|TVS_HASBUTTONS|TVS_SHOWSELALWAYS|TVS_LINESATROOT , 250,30, 300, 550, hMainWnd,(HMENU) ID_LibraryView,hAppInstance,NULL);
	SendMessage(mLibraryView,WM_SETFONT, (WPARAM)hAppFont,0);

	ResetLibraryView();

   
	return 0;
}

int AppControl::addFilesInFolderToTree(HWND hTreeView, string folderName, HTREEITEM parent) {
	WIN32_FIND_DATA findData;
	HANDLE findHandle;
	HTREEITEM dirItem;
	HTREEITEM item;
	int nAdded = 0;
	int count = 0;

		
	TVINSERTSTRUCT tvis;
	DWORD searchStatus = 0;
	string searchPath = folderName + "\\*.*";
	string subdir;
	findHandle = FindFirstFile(searchPath.c_str(),&findData);
	
	if(findHandle == INVALID_HANDLE_VALUE) {
		return 0;
	}
	while(searchStatus != ERROR_NO_MORE_FILES) {
		if(findData.dwFileAttributes & FILE_ATTRIBUTE_DIRECTORY) {
			if(_strnicmp(findData.cFileName, ".",1) != 0) {				
				subdir = folderName + "\\"; 
				subdir += findData.cFileName;
				tvis.hInsertAfter = TVI_LAST;
				tvis.hParent = parent;
				tvis.item.mask = TVIF_TEXT;
				tvis.item.pszText = findData.cFileName;			
				dirItem = TreeView_InsertItem(hTreeView,&tvis);
				
				count ++;
				nAdded = addFilesInFolderToTree(hTreeView,subdir, dirItem);
				if(nAdded < 1) {
					TreeView_DeleteItem(hTreeView,dirItem);
					nAdded --;
				} else {
					TreeView_Expand(hTreeView,dirItem,TVE_EXPAND);
					count += nAdded;
				}
			}
		} else {			
			tvis.hInsertAfter = TVI_LAST;
			tvis.hParent = parent;
			tvis.item.mask = TVIF_TEXT;
			tvis.item.pszText = findData.cFileName;	
			
					
			item = TreeView_InsertItem(hTreeView,&tvis);
			count ++;
		}
		if(!FindNextFile(findHandle, &findData)) {
			searchStatus = GetLastError();
		} else searchStatus = 0;
	}
	FindClose(findHandle);

	return count;

}
bool AppControl::treeSelectionToPath(HWND hTreeView, string& outPath) {
	TVITEM curItem;
	char itembuf[256];
	vector<string> itemstack;

	HTREEITEM selID = TreeView_GetSelection(hTreeView);
	if(selID == NULL) 
		return false;
	curItem.mask = TVIF_TEXT | TVIF_HANDLE;
	curItem.pszText = itembuf;
	curItem.cchTextMax = 256;
	curItem.hItem = selID;
	if(!TreeView_GetItem (hTreeView,&curItem)) {
		int e = GetLastError();
		return false;
	}

	itemstack.push_back(string(curItem.pszText));

	while((selID = TreeView_GetParent(hTreeView,selID))) {
		curItem.hItem = selID;
		TreeView_GetItem (hTreeView,&curItem);
		itemstack.push_back(string(curItem.pszText));
	}

	if(itemstack.size() == 0) {
		return false;
	}

	for(int i = itemstack.size()-1; i>=0; i--) {
		outPath += itemstack[i];
		if(i > 0) outPath += "\\";
	}

	return true;

}

void AppControl::PopulateSetList() {
	if(!mTexController || mTexController->NumSets() == 0) {
		return ;
	}

	vector<string> setlist;
	mTexController->GetSetNameList(setlist);

	for(size_t i = 0;i<setlist.size();i++) {
		SendMessageA(mSetsList,CB_ADDSTRING,0,(LPARAM)setlist[i].c_str());
	}
}

void AppControl::PopulateChannelList(string forSet) {
	if(!mTexController || mTexController->NumSets() == 0) {
		return;
	}

	ResetChannelList();

	vector<string> channels;
	mTexController->GetSetChannels(forSet,channels);
	for(size_t i = 0;i<channels.size();i++) {
		SendMessageA(mChannelList,CB_ADDSTRING,0,(LPARAM)channels[i].c_str());
	}
}

void AppControl::PopulateSubSetList(string forSet, string forChannel) {
	
	LVITEM lvi;
	if(!mTexController || mTexController->NumSets() == 0) {
		return;
	}
	
	ResetSubSetList();

	vector<string> subsets;
	mTexController->GetSubSetsForChannel(forSet, forChannel, subsets);

	for(size_t i = 0;i<subsets.size();i++) {
		lvi.mask = LVIF_TEXT;
		lvi.iItem = i;
		lvi.iSubItem = 0;
		lvi.pszText = (LPSTR) subsets[i].c_str();
		ListView_InsertItem(mSubSetsList,&lvi);
		ListView_SetCheckState(mSubSetsList,i,BST_CHECKED);
	}

}

void AppControl::PopulateLibraryView(string forSet, string forChannel) {
	
	TVINSERTSTRUCT tvis;
	tvis.hInsertAfter = TVI_LAST;
	tvis.hParent = TVI_ROOT;
	tvis.item.mask = TVIF_TEXT;
	tvis.item.pszText = (LPSTR) forSet.c_str();	

	HTREEITEM setID;
	HTREEITEM channelID;

	setID = TreeView_InsertItem(mLibraryView, &tvis);
	TreeView_Expand(mLibraryView,setID,TVE_EXPAND);
	tvis.hParent = setID;
	tvis.hInsertAfter = setID;
	tvis.item.pszText = (LPSTR) forChannel.c_str();

	channelID = TreeView_InsertItem(mLibraryView,&tvis);

	string sourceFolder = "Library\\";
	sourceFolder += forSet;
	sourceFolder += "\\";
	sourceFolder += forChannel;
	debugOutput << "*** ADDING FILES TO LIBRARY VIEW ***" << endl;
	int n = addFilesInFolderToTree(mLibraryView,sourceFolder, channelID);
	debugOutput << "*** DONE ADDING (" << n << ") FILES TO LIBRARY VIEW ***" << endl;
	if(n==0) {		// no files were found
		ResetLibraryView();
		TVINSERTSTRUCT tvis;
		tvis.hInsertAfter = TVI_FIRST;
		tvis.hParent = TVI_ROOT;
		tvis.item.mask = TVIF_TEXT;
		tvis.item.pszText = "No Files Found for This Set and Type";
		
		TreeView_InsertItem(mLibraryView,&tvis);
	} else {
		TreeView_Expand(mLibraryView,setID,TVE_EXPAND);
		TreeView_Expand(mLibraryView,channelID,TVE_EXPAND);
	}
}


void AppControl::PopulateSourceView(string forSet, string forChannel) {
	
	TVINSERTSTRUCT tvis;
	tvis.hInsertAfter = TVI_LAST;
	tvis.hParent = TVI_ROOT;
	tvis.item.mask = TVIF_TEXT;
	tvis.item.pszText = (LPSTR) forSet.c_str();	

	HTREEITEM setID;
	HTREEITEM channelID;

	setID = TreeView_InsertItem(mTextureSourceList, &tvis);
	TreeView_Expand(mTextureSourceList,setID,TVE_EXPAND);
	tvis.hParent = setID;
	tvis.hInsertAfter = setID;
	tvis.item.pszText = (LPSTR) forChannel.c_str();

	channelID = TreeView_InsertItem(mTextureSourceList,&tvis);

	string sourceFolder = "Source\\";
	sourceFolder += forSet;
	sourceFolder += "\\";
	sourceFolder += forChannel;

	debugOutput << "*** ADDING FILES TO SOURCE VIEW ***" << endl;
	int n = addFilesInFolderToTree(mTextureSourceList,sourceFolder, channelID);
	debugOutput << "*** DONE ADDING (" << n << ") FILES TO SOURCE VIEW ***" << endl;
	if(n==0) {
		ResetSourceView();
		TVINSERTSTRUCT tvis;
		tvis.hInsertAfter = TVI_FIRST;
		tvis.hParent = TVI_ROOT;
		tvis.item.mask = TVIF_TEXT;
		tvis.item.pszText = "No Files Found for This Set and Type";
		
		TreeView_InsertItem(mTextureSourceList,&tvis);
	} else {
		TreeView_Expand(mTextureSourceList,setID,TVE_EXPAND);
		TreeView_Expand(mTextureSourceList,channelID,TVE_EXPAND);
	}
}

int AppControl::GetSelectedSubSets(vector<string>& selection) {
	int setcount;
	char subsetname[256];

	setcount = ListView_GetItemCount(mSubSetsList);
	if(setcount == 0)
		return 0;

	selection.clear();
	for (int i=0;i<setcount;i++) {
		if(ListView_GetCheckState(mSubSetsList,i)) {
			ListView_GetItemText(mSubSetsList,i,0,subsetname,256);
			selection.push_back(string(subsetname));	
		}
	}
	return selection.size();
}


void AppControl::PreviewSelectedSource(bool clear, int selIndex){
	string path;
	int setcount;
	HCURSOR origcursor = SetCursor(LoadCursor(NULL,IDC_WAIT));
	if(clear) {
		SetBlankPreview(PREVIEW_SOURCE);
		SetCursor(origcursor);
		return;
	}
	if(SendMessage(mCheckUseCurrent,BM_GETCHECK,0,0)==BST_CHECKED) {
		vector<string> selection;
		setcount = GetSelectedSubSets(selection);
		if(setcount == 0) {
			SetBlankPreview(PREVIEW_SOURCE);
			SetCursor(origcursor);
			return;
		}
		path  = config["SkyrimDataPath"];
		path += mTexController->FilePathForTexSet(curSetName,curChannel,selection[selIndex]);
		
	} else {
		string o;
		treeSelectionToPath(mTextureSourceList,o);	
		path = "Source\\";
		path += o;
	}
	
	SetMessage("Loading Source Image...");
	if(mTexController->OpenImage("Source",path,sourceSelDirty)) {
		SetPreview(PREVIEW_SOURCE,"Source",true);
	}
	SetCursor(origcursor);
	SetMessage("Ready");
}
void AppControl::PreviewSelectedMod(bool clear) {
	
	HCURSOR origcursor = SetCursor(LoadCursor(NULL,IDC_WAIT));
	string path;
	if(clear) {
		SetBlankPreview(PREVIEW_MOD);
		SetCursor(origcursor);
		return;
	} else {
		string o;
		treeSelectionToPath(mLibraryView,o);	
		path = "Library\\";
		path += o;
	}
	
	SetMessage("Loading Modification Image...");
	if(mTexController->OpenImage("Mod",path,modSelDirty)) {
		SetPreview(PREVIEW_MOD,"Mod",true);
	}
	SetCursor(origcursor);
	SetMessage("Ready");
}
void AppControl::PreviewFinal(bool clear, int selIndex) {

	HCURSOR origcursor = SetCursor(LoadCursor(NULL,IDC_WAIT));
	PreviewSelectedSource(clear, selIndex);
	PreviewSelectedMod(clear);
	
	if(clear) {
		SetBlankPreview(PREVIEW_FINAL);
		SetCursor(origcursor);
		return;
	}
	vector<string> selection;
	GetSelectedSubSets(selection);
	if(selection.size() == 0)  {
		SetBlankPreview(PREVIEW_FINAL);
		SetCursor(origcursor);
		SetMessage("No Sub Set selected, composite not generated.");
		return;
	}
	SetMessage("Generating Blended Destination Image...");
	unsigned int FinalSize = mTexController->GetSizeForTexSet(curSetName,curChannel,selection[selIndex]);
	if(mTexController->GenerateComposite("Source","Mod","Final",FinalSize)) {
		SetPreview(PREVIEW_FINAL,"Final",true);
	}
	SetCursor(origcursor);
	SetMessage("Ready");
}

void AppControl::SetMessage(string msg) {
	string postmsg = "  " + msg + " " + msgAppend;
	SendMessage(mMessageView,WM_SETTEXT,0,(LPARAM)postmsg.c_str());
}

LRESULT AppControl::ProcessNotify(NMHDR* nmHdr, WPARAM wParam) {
	switch(nmHdr->idFrom) {
		case ID_SUBSETSLIST:
			switch(nmHdr->code) {				// make sure we're ready to reload the source image if the selected subset changes --
				case LVN_ITEMCHANGED:			//  but only if we're using the subsets as the source! texblend source folder doesn't change with this selection	
					if(((NMLISTVIEW*)nmHdr)->uChanged & LVIF_STATE  && ((NMLISTVIEW*)nmHdr)->uNewState & 0x3000 ) {
						if(SendMessage(mCheckUseCurrent,BM_GETCHECK,0,0)==BST_CHECKED)
							sourceSelDirty = true;
					}
					break;

			}
			break;
		case ID_TEXTURESOURCELIST:
			switch(nmHdr->code){
				case NM_DBLCLK:
					PreviewSelectedSource();					
					sourceSelDirty = false;
					break;
				case TVN_SELCHANGED:
					sourceSelDirty = true;
					break;
			}
			break;
		case ID_LibraryView:
			switch(nmHdr->code){
				case NM_DBLCLK:
					PreviewSelectedMod();
					modSelDirty = false;
					break;
				case TVN_SELCHANGED:
					modSelDirty = true;
					break;
			}
			break;
	}
	return TRUE;
}

LRESULT AppControl::ProcessCommand(int controlID, int evt, LPARAM lParam) {
	char buffer[256];
	HBITMAP bm = NULL;
	string selPath;
	int selcount;
	int response;
	bool failedsave = false;
	vector<string> selection;
	switch(controlID) {
		case ID_SETSLIST:
			if(evt == CBN_SELCHANGE) {
				GetWindowTextA(mSetsList,buffer,256);
				curSetName=buffer;
				PopulateChannelList(curSetName);
				EnableWindow(mChannelList,TRUE);
				ResetSubSetList();
				EnableWindow(mSubSetsList,FALSE);
				ResetSourceView();
				EnableWindow(mTextureSourceList,FALSE);
				if(config.find("DefUseInstalledSource") != config.end()) 
					if(config["DefUseInstalledSource"] == "1") {
						SendMessage(mCheckUseCurrent,BM_SETCHECK,(WPARAM) BST_CHECKED,0);
				}
				//SendMessage(mCheckUseCurrent,BM_SETCHECK,(WPARAM)BST_CHECKED,0);
				ResetLibraryView();
				SetBlankPreview();
				modSelDirty = true;
				sourceSelDirty = true;
			}
			break;
		case ID_CHANNELLIST:
			if(evt == CBN_SELCHANGE) {
				GetWindowTextA(mChannelList,buffer,256);
				curChannel = buffer;
				PopulateSubSetList(curSetName,curChannel);
				EnableWindow(mSubSetsList,TRUE);
				if(SendMessage(mCheckUseCurrent,BM_GETCHECK,0,0)!=BST_CHECKED) {
						EnableWindow(mTextureSourceList,TRUE);
				}
				ResetSourceView();
				PopulateSourceView(curSetName,curChannel);
				ResetLibraryView();
				PopulateLibraryView(curSetName,curChannel);
				SetBlankPreview();
				modSelDirty = true;
				sourceSelDirty = true;
			}
			break;
		case ID_CHECKUSECURRENT:
			if(evt == BN_CLICKED) {
				if(SendMessage(mCheckUseCurrent,BM_GETCHECK,0,0)==BST_CHECKED) {
					EnableWindow(mTextureSourceList,FALSE);
					sourceSelDirty = true;
				} else {
					EnableWindow(mTextureSourceList,TRUE);
					sourceSelDirty = true;
				}
			}
			break;
		case ID_PREVIEW:
			PreviewFinal();
			sourceSelDirty = false;
			modSelDirty = false;
			break;
		case ID_BLENDIMAGE:
			if(evt == BN_CLICKED) {	
				if(GetKeyState(VK_CONTROL)) {
					sourceSelDirty = true;
					modSelDirty = true;
				}
				selcount = GetSelectedSubSets(selection);
				if(selcount == 0) {
					break;
				} if(selcount == 1) {
					PreviewFinal();
					sourceSelDirty = false;
					modSelDirty = false;
					SetMessage("Saving Blended Texture...");
					if(!mTexController->SaveToTexSet("Final",config["SkyrimOutPath"],curSetName,curChannel,selection[0]))
						MessageBox(hMainWnd, "Failed to save file", "Error",MB_OK | MB_ICONERROR);
					else
						MessageBox(hMainWnd, "File saved successfully!", "Success",MB_OK | MB_ICONINFORMATION);
					SetMessage("Ready");
				} else {					
					if(SendMessage(mCheckUseCurrent,BM_GETCHECK,0,0)!=BST_CHECKED) {
						response = MessageBox(hMainWnd,"You have chosen a library source file and multiple destination files. This will overwrite ALL selected destination files with the SAME generated output file.\r\n\r\nAre you sure?","Overwrite Multiple Files?",MB_YESNO | MB_ICONWARNING);
						if(response == IDNO) {
							break;
						} 
						PreviewFinal();
						sourceSelDirty = false;
						modSelDirty = false;
						for(int i=0;i<selcount;i++) {
							_snprintf_s(buffer,256,256,"Saving Blended Texture (%d of %d)...",i+1,selcount);

							SetMessage(buffer);
							if(!mTexController->SaveToTexSet("Final",config["SkyrimOutPath"],curSetName,curChannel,selection[i])) {
								MessageBox(hMainWnd, "Failed to save file", "Error",MB_OK | MB_ICONERROR);
								failedsave = true;
								break;
							}
						}
					} else {
						response = MessageBox(hMainWnd,"You have selected multiple destination files. This will modify all selected destination files with chosen library modification file.\r\n\r\nAre you sure?","Overwrite Multiple Files?",MB_YESNO | MB_ICONINFORMATION);
						if(response == IDNO) {
							break;
						} 
						for(int i=0;i<selcount;i++) {
							_snprintf_s(buffer,256,256,"(%d of %d)",i+1,selcount);
							msgAppend=buffer;
							sourceSelDirty = true;
							PreviewFinal(false, i);
							sourceSelDirty = false;
							modSelDirty = false;
							SetMessage("Saving Blended Texture...");
							if(!mTexController->SaveToTexSet("Final",config["SkyrimOutPath"],curSetName,curChannel,selection[i])) {
								MessageBox(hMainWnd, "Failed to save file", "Error",MB_OK | MB_ICONERROR);
								SetMessage("Failed while saving blended texture ");
								failedsave = true;
								break;
							}
						}
					} 
					msgAppend="";
					if(!failedsave) {
						MessageBox(hMainWnd, "Files saved successfully!", "Success",MB_OK | MB_ICONINFORMATION);
						SetMessage("Ready");
					}
				}
			}
			break;			
		case ID_SRCPREVIEW:
			if(evt == STN_DBLCLK) {
				bm = mTexController->GetBitmap("Source",GetDC(hMainWnd),true,768,768);
				previewWnd = new PreviewWindow(hMainWnd,bm);
			}	
			break;		
		case ID_MODPREVIEW:
			if(evt == STN_DBLCLK) {
				bm = mTexController->GetBitmap("Mod",GetDC(hMainWnd),true,768,768);
				previewWnd = new PreviewWindow(hMainWnd,bm);
			}		
			break;	
		case ID_DESTPREVIEW:
			if(evt == STN_DBLCLK) {
				bm = mTexController->GetBitmap("Final",GetDC(hMainWnd),true,768,768);
				previewWnd = new PreviewWindow(hMainWnd,bm);
			}
			break;	
	}
	return TRUE;
}


int AppControl::AutoHeadFix(){
	curSetName = "Head";
	curChannel = "Color";

	vector<string> subsets;
	string path;
	unsigned int FinalSize ;
	int i;

	if(!mTexController->OpenImage("Mod","Library\\Head\\Color\\CBBEv3_HeadNeckBlendColor.psd",true))  {
		MessageBox(NULL,"Failed to open Color Mod Image","Error",MB_OK);
		return 1;
	}

	mTexController->GetSubSetsForChannel(curSetName, curChannel, subsets);

	for(i=0;i<subsets.size();i++) {
		path  = config["SkyrimDataPath"];
		path += mTexController->FilePathForTexSet(curSetName,curChannel,subsets[i]);
		if(!mTexController->OpenImage("Source",path,true)) {
			MessageBox(NULL,path.c_str(),"Failed to open Color Source",MB_OK);
			return 2;
		}
		FinalSize = mTexController->GetSizeForTexSet(curSetName,curChannel,subsets[i]);
		if(!mTexController->GenerateComposite("Source","Mod","Final",FinalSize)) {
			MessageBox(NULL,"Failed to generate color composite","Error",MB_OK);
			return 3;
		}
		if(!mTexController->SaveToTexSet("Final",config["SkyrimOutPath"],curSetName,curChannel,subsets[i])) {
			MessageBox(NULL,"Failed to save Color output file","Error",MB_OK);
			return 4;
		}
	}
	
	curChannel = "Normal";

	if(!mTexController->OpenImage("Mod","Library\\Head\\Normal\\CBBEv3_HeadNeckBlend.psd",true))  {
		MessageBox(NULL,"Failed to open Normal Mod Image","Error",MB_OK);
		return 5;
	}

	mTexController->GetSubSetsForChannel(curSetName, curChannel, subsets);

	for(i=0;i<subsets.size();i++) {
		path  = config["SkyrimDataPath"];
		path += mTexController->FilePathForTexSet(curSetName,curChannel,subsets[i]);
		if(!mTexController->OpenImage("Source",path,true)) {
			MessageBox(NULL,path.c_str(),"Failed to open Normal map Source",MB_OK);
			return 6;
		}
		FinalSize = mTexController->GetSizeForTexSet(curSetName,curChannel,subsets[i]);
		if(!mTexController->GenerateComposite("Source","Mod","Final",FinalSize)) {
			MessageBox(NULL,"Failed to generate Normal map composite","Error",MB_OK);
			return 7;
		}
		if(!mTexController->SaveToTexSet("Final",config["SkyrimOutPath"],curSetName,curChannel,subsets[i])) {
			MessageBox(NULL,"Failed to save Normal map output file","Error",MB_OK);
			return 8;
		}
	}

	
	curChannel = "Specular";

	if(!mTexController->OpenImage("Mod","Library\\Head\\Specular\\CalienteHeadSpecBlend.psd",true))  {
		MessageBox(NULL,"Failed to open Specular Mod Image","Error",MB_OK);
		return 9;
	}

	mTexController->GetSubSetsForChannel(curSetName, curChannel, subsets);

	for(i=0;i<subsets.size();i++) {
		path  = config["SkyrimDataPath"];
		path += mTexController->FilePathForTexSet(curSetName,curChannel,subsets[i]);
		if(!mTexController->OpenImage("Source",path,true)) {
			MessageBox(NULL,path.c_str(),"Failed to open Specular Source",MB_OK);
			return 10;
		}
		FinalSize = mTexController->GetSizeForTexSet(curSetName,curChannel,subsets[i]);
		if(!mTexController->GenerateComposite("Source","Mod","Final",FinalSize)) {
			MessageBox(NULL,"Failed to generate specular map composite","Error",MB_OK);
			return 11;
		}
		if(!mTexController->SaveToTexSet("Final",config["SkyrimOutPath"],curSetName,curChannel,subsets[i])) {
			MessageBox(NULL,"Failed to save specular map output file","Error",MB_OK);
			return 12;
		}
	}

	MessageBox(NULL,"Automatic Neck Seam fix Successful!","Caliente's TexBlend",MB_OK | MB_ICONINFORMATION);
	
	return 0;

}