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
#include "TextureControl.h"
#include "shlobj.h"

TextureControl::TextureControl(void)
{
	alphaMatte = 0;
	stripPremultAlpha = true;
}

TextureControl::~TextureControl(void)
{
	
	map<string, HBITMAP>::iterator itr_bmp;
	for(itr_bmp=namedBitmaps.begin(); itr_bmp!=namedBitmaps.end(); ++itr_bmp) {
		DeleteObject(itr_bmp->second);
	}
	namedBitmaps.clear();

	map<string, ILuint>::iterator itr_imgID;
	for(itr_imgID=namedImages.begin(); itr_imgID!=namedImages.end(); ++itr_imgID) {
		ilDeleteImage(itr_imgID->second);
	}
	namedImages.clear();

	ClearSupportedSets();
}

int TextureControl::InitImageLibrary() {
	ilInit();
	iluInit();
	ilutRenderer(ILUT_WIN32);
	return 0;
}

ILuint TextureControl::getImageHandle() {
	ILuint newImageHandle;
	ilGenImages(1,&newImageHandle);
	if(!selectImage(newImageHandle)) 
		return 0;
	return newImageHandle;
}

bool TextureControl::selectImage(ILuint hImage) {
	ilBindImage(hImage);
	if(ilGetError() != IL_NO_ERROR) {
		return false;
	}
	return true;
}


HBITMAP TextureControl::GetBlankBitmap(HDC destDC) {
	if(namedBitmaps.find("Blank") != namedBitmaps.end()) 
		return namedBitmaps["Blank"];
	ILuint img = getImageHandle();
	ilDefaultImage();
	iluImageParameter(ILU_FILTER, ILU_BILINEAR);
	iluScale(126,126,1);
	namedBitmaps["Blank"] = ilutConvertToHBitmap(destDC);
	ilDeleteImage(img);
	return namedBitmaps["Blank"];
}

HBITMAP TextureControl::GetBitmap(string name, HDC destDC, bool refresh, unsigned int w, unsigned int h) {
	if(refresh == false && namedBitmaps.find(name) != namedBitmaps.end())
		return namedBitmaps[name];
	// else bitmap doesn't exist.
	if(namedImages.find(name) == namedImages.end())
		return NULL;	//img not loaded

	ILuint tmp = getImageHandle();
	ilCopyImage(namedImages[name]);	
	iluImageParameter(ILU_FILTER, ILU_SCALE_BSPLINE);
	iluScale(w,h,1);

	if(alphaMatte) 
		ilEnable(IL_BMP_MATTEALPHAB);
	else
		ilEnable(IL_BMP_MATTEALPHA);
	namedBitmaps[name] = ilutConvertToHBitmap(destDC);

	ilDeleteImage(tmp);

	return namedBitmaps[name];
}


void TextureControl::ClearSupportedSets() {
	for(size_t i=0; i<supportedSets.size(); i++) {
		delete supportedSets[i];
	}
	supportedSets.clear();
}

void TextureControl::LoadSupportedSets() {
	TiXmlDocument* doc;
	TiXmlElement* setElem;
	TiXmlElement* subSetElem;
	TiXmlElement* chanElem;
	TiXmlElement* elem;
	TiXmlNode* prevChan;
	TiXmlNode* prevSubSet;
	
	string fileSetName;
	string setName;
	string subSetName;
	string chanName;
	string setPath;
	string fileName;
	string fileFormat;
	string buf;
	int size;
	int compress;
	int alpha;
	unsigned int Flags;
	TargetTextureSet* ptts;

	WIN32_FIND_DATA findData;
	HANDLE hFind;
	hFind = FindFirstFile("SetDefs\\*.xml",&findData);
	do {
		fileSetName = "SetDefs\\";
		fileSetName += findData.cFileName;	

		doc = new TiXmlDocument(fileSetName.c_str());
		bool loadOkay = doc->LoadFile();
		if(!loadOkay) {
			delete doc;
			continue;
		}

		setElem = doc->FirstChildElement("TextureSet");
		while(setElem) {
			setName = setElem->Attribute("Name");
			elem = setElem->FirstChildElement("Path");
			if(elem) setPath = elem->GetText();

			ptts = new TargetTextureSet(setName,setPath);

			prevSubSet = NULL;
			while(prevSubSet = setElem->IterateChildren("SubSet",prevSubSet)) {
				subSetElem = prevSubSet->ToElement();
				subSetName = subSetElem->Attribute("Name");

				prevChan = NULL;
				while( prevChan = subSetElem->IterateChildren("Channel",prevChan) ){
					chanElem = prevChan->ToElement();
					chanName = chanElem->Attribute("Name");

					elem = chanElem->FirstChildElement("FileName");
					if(elem) fileName = elem->GetText();
					elem = chanElem->FirstChildElement("FileFormat");
					if(elem) fileFormat = elem->GetText();
					elem = chanElem->FirstChildElement("Size");
					if(elem) size = atoi(elem->GetText());

					Flags = 0; compress = 0; alpha = 0;
					elem = chanElem->FirstChildElement("CompressTex");
					if(elem) compress = atoi(elem->GetText());
					if(!compress) 
						Flags = TTS_FLAG_DDSUNCOMPRESSED;
					elem = chanElem->FirstChildElement("HasAlpha");
					if(elem) alpha = atoi(elem->GetText());
					if(alpha)
						Flags |= TTS_FLAG_HASALPHA;

					ptts->AddSetFile(subSetName, chanName, fileName,fileFormat,size,Flags);
				}
			}
			supportedSets.push_back(ptts);
			setElem = setElem->NextSiblingElement("TextureSet");
		}
		delete doc;
	} while(FindNextFile(hFind,&findData)) ;
}

TargetTextureSet* TextureControl::TexSetFromName(string& setName) {
	for(size_t i=0;i<supportedSets.size();i++) {
		if(supportedSets[i]->GetName() == setName)
			return supportedSets[i];
	} 
	return NULL;
}

void TextureControl::GetSetNameList(vector<string> & outList) {
	outList.clear();
	for(size_t i=0;i<supportedSets.size();i++) {
		outList.push_back(supportedSets[i]->GetName());
	}
}	

void TextureControl::GetSetChannels (string setName, vector<string>& outChannels) {
	outChannels.clear();
	TargetTextureSet* tts = TexSetFromName(setName);

	if(tts) {
		tts->GetChannels(outChannels);
	}

}


void TextureControl::GetSubSetsForChannel (string setName, string channel, vector<string>& outSubSets) {
	outSubSets.clear();
	TargetTextureSet* tts = TexSetFromName(setName);

	if(tts) {
		tts->GetSubSetsForChannel (channel, outSubSets);
	}
}


string  TextureControl::FilePathForTexSet(string setName, string channel, string subset) {
	string output;
	TargetTextureSet* tts = TexSetFromName(setName);
	if(!tts) return output;
	output = tts->FilenameFromChannelAndSubset(channel, subset);
	return output;

}

unsigned int TextureControl::GetSizeForTexSet(string setName, string channel, string subset) {
	unsigned int output;
	TargetTextureSet* tts = TexSetFromName(setName);
	if(!tts) return 0;
	output = tts->SizeFromChannelAndSubset(channel, subset);
	return output;
}

ILuint TextureControl::OpenImage(string newImageName, string filename, bool refresh) {
	ILenum err;
	if(refresh == false && namedImages.find(newImageName) != namedImages.end())
		return namedImages[newImageName];

	if(namedImages.find(newImageName) != namedImages.end()) {
		ilDeleteImage(namedImages[newImageName]);
	}

	namedImages[newImageName] = getImageHandle();
	if(!stripPremultAlpha) {
		ilEnable(IL_USE_PREMULTALPHA);
	}
	wstring hackfilename = wstring(filename.begin(),filename.end());
	if(!ilLoadImage((const ILstring) filename.c_str())) {
		err = ilGetError();
		return 0;	
	}

	return namedImages[newImageName];

	return 0;

}


bool TextureControl::GenerateComposite(string sourceName,string modName,string outputName, unsigned int destSize, unsigned int mode ) {
	
	ILuint srctex = 0;
	ILuint modtex = 0;
	ILuint canvas = 0;
		
	if(namedImages.find(modName) == namedImages.end())				// mod not selected?
		return false;
	modtex = namedImages[modName];
	ilBindImage(modtex);
	


	ILuint mW = ilGetInteger(IL_IMAGE_WIDTH);
	ILuint mH = ilGetInteger(IL_IMAGE_HEIGHT);

	if(destSize && (mW != destSize)) {		
		iluImageParameter(ILU_FILTER, ILU_SCALE_BSPLINE);
		iluScale(destSize,destSize,1);
		mW = mH = destSize;
	}

	if(namedImages.find(sourceName) == namedImages.end())				// source not selected?
		return false;
	srctex = namedImages[sourceName];
	ilBindImage(srctex);
	
	ILuint sW = ilGetInteger(IL_IMAGE_WIDTH);
	ILuint sH = ilGetInteger(IL_IMAGE_HEIGHT);

	if(destSize && (sW != destSize)) {		
		iluImageParameter(ILU_FILTER, ILU_SCALE_BSPLINE);
		iluScale(destSize,destSize,1);
		sW = sH = destSize;
	}

	if(namedImages.find(outputName) != namedImages.end())				// already have an output?  
		ilDeleteImage(namedImages[outputName]);							

	if(sW < mW) {
		ilBindImage(modtex);
		iluImageParameter(ILU_FILTER, ILU_SCALE_BSPLINE);
		iluScale(sW,sH,1);
		ilBindImage(srctex);
	} else if(sW > mW){
		iluImageParameter(ILU_FILTER, ILU_SCALE_BSPLINE);
		iluScale(mW,mH,1);
		sW=mW; sH=mH;
	}

	namedImages[outputName] = getImageHandle();
	ilTexImage(sW,sH,1,4,IL_RGBA,IL_UNSIGNED_BYTE,NULL);

	ilBlit(srctex,0,0,0,0,0,0,sW,sH,1);
	
	ilEnable(IL_BLIT_BLEND);
	ilBlit(modtex,0,0,0,0,0,0,sW,sH,1);


	return true;
}


bool TextureControl::SaveToTexSet(string imageName, string basepath, string setName, string channel, string subset) {
	TargetTextureSet* tts = TexSetFromName(setName);
	if(!tts) 
		return false;

	if(namedImages.find(imageName) == namedImages.end())				
		return false;
	
	ilBindImage(namedImages[imageName]);

	string outputPath = FilePathForTexSet(setName, channel, subset);
	outputPath = basepath + outputPath;

	ilEnable(IL_FILE_OVERWRITE);
	bool hasAlpha = tts->SubSetHasAlpha(channel,subset);
	string format = tts->SubSetFormat(channel, subset);

	if(format == "DXT1") {
		ilEnable(IL_SQUISH_COMPRESS);
		ilSetInteger(IL_DXTC_FORMAT, IL_DXT1);
	} else if(format == "DXT5") {
		ilEnable(IL_SQUISH_COMPRESS);
		ilSetInteger(IL_DXTC_FORMAT, IL_DXT5);
	} else if(format == "RGB") {
		ilSetInteger(IL_DXTC_FORMAT, IL_DXT_NO_COMP);
		if(ilGetInteger(IL_IMAGE_FORMAT) == IL_RGBA)
			ilConvertImage(IL_RGB,ilGetInteger(IL_IMAGE_TYPE));
	} else if(format == "RGBA") {
		ilSetInteger(IL_DXTC_FORMAT, IL_DXT_NO_COMP);

	}

	size_t pos= outputPath.rfind("\\");
	if(pos != string::npos) {
		SHCreateDirectoryEx(NULL,outputPath.substr(0,pos).c_str(),NULL);
	}	
	if(!ilSaveImage((const ILstring)outputPath.c_str())) {
		return false;
	}
	return true;
}