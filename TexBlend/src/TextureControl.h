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
#include "TargetTextureSet.h"
#include "IL/il.h"
#include "IL/ilu.h"
#include "IL/ilut.h"
#include "tinyxml.h"

using namespace std;

#define BLEND_MODE_OVERLAY 1
#define ALPHA_MATTE_WHITE 0
#define ALPHA_MATTE_BLACK 1

class TextureControl
{

	unsigned short alphaMatte;
	bool stripPremultAlpha;

	vector<TargetTextureSet*> supportedSets;

	// Generate and select a single DevIL image handle (does not load data), and returns the bound handle
	ILuint getImageHandle();

	// Select an image for active manipulation.
	bool selectImage (ILuint hImage);


	map<string, ILuint> namedImages;			// loaded image library images by associated name
	map<string, HBITMAP> namedBitmaps;			// loaded win32 bitmap images by associated name
public:

	TextureControl(void);

	int InitImageLibrary();
	void SetAlphaMatte(unsigned short matte) { alphaMatte = matte; }
	void SetStripPremultAlpha(bool newSetting) { stripPremultAlpha = newSetting; }

	// Gets a default image bitmap, creating it if necessary
	HBITMAP GetBlankBitmap(HDC destDC);
	// Gets a named bitmap handle, if the bitmap name doesn't exist, the image list is checked for a matching name and a dc compatible bitmap is generated
	// default size is 126x126 (For including in a 128x128 sunken window) 
	HBITMAP GetBitmap(string name,HDC destDC, bool refresh = false, unsigned int w=126, unsigned int h=126);
	
	void ClearSupportedSets();
	void LoadSupportedSets();	

	int NumSets() { return supportedSets.size(); }
	TargetTextureSet* TexSetFromName(string& setName);

	void GetSetNameList (vector<string>& outList);
	void GetSetChannels (string setName, vector<string>& outChannels);
	void GetSubSetsForChannel (string setName, string channel, vector<string>& outSubSets);

	string FilePathForTexSet(string setName, string channel, string subset);
	unsigned int GetSizeForTexSet(string setName, string channel, string subset);

	ILuint OpenImage(string newImageName, string filename, bool refresh = false);

	bool GenerateComposite(string sourceName,string modName,string outputName, unsigned int destSize = 0, unsigned int mode = BLEND_MODE_OVERLAY );

	bool SaveToTexSet(string imageName, string basepath, string setName, string channel, string subset);

	~TextureControl(void);
};
