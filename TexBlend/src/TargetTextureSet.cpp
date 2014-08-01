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
#include "TargetTextureSet.h"

TargetTextureSet::TargetTextureSet(void)
{
}

TargetTextureSet::TargetTextureSet(string newSetName, string newDataPath) {
	setName = newSetName;
	dataPath = newDataPath;
}

TargetTextureSet::~TargetTextureSet(void)
{
}


void TargetTextureSet::GetChannels (vector<string> & outChannels) {
	set<string>::iterator it = setChannels.begin();
	for(;it!=setChannels.end();++it) {
		outChannels.push_back(*it);
	}
}

void TargetTextureSet::GetSubSetsForChannel (string channel, vector<string>& outSubSets) {
	map<string, TargetTextureFormat>::iterator it;
	it = setFiles.begin();
	size_t p;

	for(;it!=setFiles.end(); ++it) {
		if(it->first.find(channel)!=string::npos) {
			p = it->first.find('-');
			if(p!=string::npos) {
				outSubSets.push_back(it->first.substr(p+1));
			}
		}
	}
	
}

string TargetTextureSet::FilenameFromChannelAndSubset(string channel, string subset) {
	string output = dataPath + "\\" + subset +"\\";
	string ChannelSubset = channel + "-" + subset;
	output += setFiles[ChannelSubset].fileName + "." + setFiles[ChannelSubset].fileExt;
	return output;
}

unsigned int TargetTextureSet::SizeFromChannelAndSubset(string channel, string subset) {
	string ChannelSubset = channel + "-" + subset;
	return setFiles[ChannelSubset].outputSize;
}

void TargetTextureSet::AddSetFile(string subSet, string fileChannel, string fileName, string fileExt, unsigned int outputSize, unsigned int flags) {
	TargetTextureFormat ttf;
	setChannels.insert(fileChannel);
	string ChannelSubset = fileChannel + "-" + subSet;
	ttf.fileName = fileName;
	if(flags & TTS_FLAG_DDSUNCOMPRESSED) {
		if(flags & TTS_FLAG_HASALPHA) {
			ttf.fileFormat = "RGBA";
		} else 
			ttf.fileFormat = "RGB";
	} else {
		if(flags& TTS_FLAG_HASALPHA) {
			ttf.fileFormat = "DXT5";
		} else {
			ttf.fileFormat = "DXT1";
		}

	}
	ttf.fileExt = fileExt;
	ttf.fileFlags = flags;
	ttf.outputSize = outputSize;
	setFiles[ChannelSubset] = ttf;
}

bool TargetTextureSet::SubSetIsCompressed(string channel, string subset) {
	string ChannelSubset = channel + "-" + subset;
	return setFiles[ChannelSubset].fileFlags & TTS_FLAG_DDSUNCOMPRESSED;
}
bool TargetTextureSet::SubSetHasAlpha (string channel, string subset) {
	string ChannelSubset = channel + "-" + subset;
	return (setFiles[ChannelSubset].fileFlags & TTS_FLAG_HASALPHA) > 0;

}
string TargetTextureSet::SubSetFormat (string channel, string subset) {
	string ChannelSubset = channel + "-" + subset;
	return setFiles[ChannelSubset].fileFormat;	
}

string TargetTextureSet::SetFileExtension(string channel, string subset) {
	string ChannelSubset = channel + "-" + subset;
	return setFiles[ChannelSubset].fileExt;
}