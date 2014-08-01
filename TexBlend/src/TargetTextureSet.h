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

#include <string>
#include <vector>
#include <set>
#include <map>

using namespace std;

#define TTS_FLAG_DDSUNCOMPRESSED	0x1		// if this is 0, DDS output uses a compressed  DXT1 format, otherwise an RGB 8 bit format
#define TTS_FLAG_HASALPHA			0x2		// if this is 1, DDS output uses a 4 byte RGB format or an alpha supporting compression format.

class TargetTextureFormat 
{
public:
	string fileName;
	string fileExt;							// currently only "dds"
	string fileFormat;						// RGB RGBA DXT1 DXT5  (.dds)
	unsigned int fileFlags;
	unsigned int outputSize;

};

class TargetTextureSet
{
	string setName;							// name of set, eg 'body','face','hands'
	string dataPath;							// path to set root relative to skyrim\data (eg textures\actors\character)
	map<string, TargetTextureFormat> setFiles;
	set<string> setChannels;
	vector<string> subSets;					// lookup for included subsets , eg head: female, imperial, briton,...	

public:
	TargetTextureSet(void);
	TargetTextureSet(string newSetName, string newDataPath);

	string GetName() { return setName; }
	void GetChannels (vector<string> & outChannels);
	void GetSubSetsForChannel (string channel, vector<string>& outSubSets);

	bool SubSetIsCompressed(string Channel, string subset);
	bool SubSetHasAlpha (string Channel, string subset);
	string SubSetFormat (string Channel, string subset);
	string SetFileExtension(string Channel, string subset);


	string FilenameFromChannelAndSubset(string channel, string subset);
	unsigned int SizeFromChannelAndSubset(string channel, string subset);

	void AddSetFile(string subSet, string fileChannel,  string fileName, string fileExt, unsigned int outputSize = 1024, unsigned int flags = TTS_FLAG_DDSUNCOMPRESSED);
	~TargetTextureSet(void);
};
