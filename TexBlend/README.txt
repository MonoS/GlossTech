Caliente's Texture Blender version 0.9.1a

Table of Contents
  Introduction
  Usage
	Installation
	Blending Files
    Examples
    Hints
  Settings
  Adding Custom Files
    Folder Structure
    Texture Set Definition format
  Source Code
    License
    Library usage and licenses
      DevIL
      TinyXML
  Known Issues
  Revision History


--- INTRODUCTION ---

Welcome to Caliente's Texture Blender!  

This is a small tool designed to simplify the process of applying modifications to existing texture maps for use in games.  With only a few clicks, you can quickly apply a tatoo to your character's body, change the details on your favorite set of armor, or blend away an ugly texture seam between joined meshes. Please note modifications such as these require separate texture file packages to be installed.
Caliente's Texture Blender (TexBlend) is easily expandable by a user or by content authors who wish to provide a simple interface for providing options for their work.  A simple definition format (detailed later) allows nearly any sort of texture to be modified, and a clear file organization method allows each user to build a library of modifications that can be mix-and-matched at will. 
TexBlend is a C++ application written for Windows XP and above, requires no additional software to perform it's duties, and comes with complete source code that you're allowed to view and modify as you wish.  The image manipulation is done with a modified version of the Developer's Image Library (DevIL), and supports a very large array of input and output file formats.

Why use Caliente's Texture Blender?
TexBlend allows you to apply desired texture changes without having to download or use a more full featured image editing tool.  The various tasks of correctly loading files, matching sizes, and saving the files in the right place are automatically taken care of.  It also allows you to work with the files in a manner that reduces the tedium of keeping track of numerous files.

--- Usage ---

INSTALLATION

Installing TexBlend is a simple matter of extracting the program archive to a location on your hard drive.  From there, simply execute TexBlend.exe to use the program.
TexBlend comes with a small set of texture files (mainly for use with my Skyrim Female Body Mod), but be on the lookout for additional texture packages, from me or others, intended for use with the program.  See the section on adding custom files below to understand how these texture files should be stored.  For the most part, additional texture packs should be installed by extracting them to the TexBlend installation folder, but be sure to check the packages for any special instructions.

BLENDING FILES

Using TexBlend is essentially a matter of choosing a source image and a modification image, and having the tool superimpose the latter on the former.  

Before using TexBlend, it is recommended that you ensure that you have available backups of all files in your skyrim/data/textures folder.  Modified images are overwitten without warning!

First, you must choose a "texture set" to work with.  This is conceptually a grouping of texture files (ie, color map, normal map, specular map, etc.) and associated variants (eg character race variants for a face texture).  The topmost left selection box labled "Set:" will enable you to make this selection.

Next, you will need to choose which 'Type' to work with fron the selection labeled "Type". The types correspond to the texture channels used by models in a game to display various effects.  Typically, the types are: 
    Color for the actual color of the object
	Normal for the information that allows the object to interact with light (eg, shadows and small bump details)
	Specular for the shinyness of the surface
Other channels are possible, including Glow, Skin, Environment, etc.

Third, you will select the variant to modify from the list beneath the Type selection.  In many cases, this list will have only one available selection, such as 'Female' when modifying the body/color set included with TexBlend.  Other times this list will contain the names of potential variants, such as the race variants when viewing the included Head/Normal set.  You can think of this list as the list of variants that will be modified by the blending operation.  Normally, all available variants for the texture set are selected -- simply uncheck any that you wish to avoid updating when applying the modification.  In most cases you will leave all items selected.

Fourth, you will choose the source file itself that you wish to modify.  This appears in the tree in the bottom left of the application window.  By default, TexBlend will pull source textures from the ones currently installed with your game.  The checkbox in the lowest left of the window labled "Use Currently Installed Textures" allows you to change this behavior. 
NOTE: only textures in the Skyrim/Data folder are available; TexBlend does not extract images from the skyrim .BSA files.  If you wish to modify vanilla textures, please extract them first.
If you uncheck the use currently installed textures option, the tree view of available source textures becomes usable.  This list is filtered by the texture set and channel to only show appropriate choices, and the files themselves are the ones located in the TexBlend\Source subdirectories.  You can double click a file in this list to show a preview of the image.

Finally, you will choose what modification to apply over the source texture. To do this, select an available file from the tree view in the center column of the application.  This list is filtered to only show options that are appropriate for the current texture set and channel, and the files themselves are located in the TexBlend\Library subdirectories.  You can double click a file in this list to show a preview of the image.

Once your selections are complete, you can click the preview button (lower right of the window) to get a view of the source,modification,and destination image.  Double click on the preview boxes to get a larger view.  

When satisfied with your choices, click the Blend Texture button to generate the modfied textures and save them to disk.  As a
reminder, files are overwritten without any warning!  
Normally the source, destination, and final images are saved in memory after you click preview or blend.  A second press of the blend button will simply re-save the same image to the disk.  If you wish, you can Control+Click on the blend texture button to force TexBlend to reload the source and modification files and regenerate the final image.  This can allow you to re-apply the same modification more than once (as long as 'use currently installed textures is ON).  In the case of partially tranpsarent modifications, this will cause successively darker applications of the same image. 

If you have multiple variants selected in the variant list, the blend operation will attempt to modify all of those files with the modification image.  If the 'use currently installed textures' option is ON, each variant source will be loaded and modifed individually.  
If the 'use currently installed textures' option is OFF, the single source file and single modification file you have selected will be saved to ALL selected variants.  To avoid this, deselect all but one variant.

EXAMPLES

The following are step-by-step examples of using TexBlend with the included textures. 

[Adding a Tatoo] 
This process will add a simple tatoo design to the lower back of females in Skyrim when using Caliente's Body Mod.  The tatoo texture is a quick and dirty sample that isn't designed to work with any other skin texture than the one that I distribute with my body mod.  This assumes you've already installed a CBBE body mod and are using that mod's textures already in Skyrim.
  1. Install TexBlend and run TexBlend.exe to open the program.
  2. In the top leftmost selection box labled "Set", choose 'Body and Feet'  (note: bodies and feet are on the same texture file in skyrim) 
  3. In the selection box labeled "Type" choose "Color".  The variant list box (where it says "3. Choose what to change") will activate and have "Female" as a checked item.  Also the Library tree will activate (Labeled "Choose Texture Mod to Apply"), and will contain a number of files.  
  4. Verify 'Use Currently Installed Textures' is checked in the bottom left.  This will cause TexBlend to apply the modification directly to the texture already in your <Skyrim>/Data/textures folder.
  5. In the list labled "Choose Texture Mod To Apply", find the section labeled 'Tatoos'.  You can double click any file in the list to load a preview into the modification preview to the right, although in this case the tatoos are small enough that it's difficult to see what they look like.  Select 'tsHeartAngle.psd' by clicking on it.
  6. Click the Preview button to see the currently installed texture (top preview window) and the final result (bottom window). If any of the images do not appear, make sure you've got everything selected appropriately.
  7. Click 'Blend Images' to save the final result to your skyrim data folder.
  
  OPTIONAL:  In place of step 4, you can uncheck 'Use currently installed textures', and choose an available texture from the Source Texture list.  Double clicking on them will display the image in the Source Preview window on the right.  These textures are the Head, Hands, and Feet textures for use with CBBE and the Hands and Feet optional download.  Doing this will ensure you have a clean texture to apply the tatoo to.  Once you've selected a file, continue with step 5.
  
[Fixing CBBE Neck Seams]
This is a more complicated example that will lead you through the process of fixing a neck seam between a CBBE body and another author's head textures.  
Part 1:
  1. Install a CBBE body mod (Slim or standard).  Install a matching CBBE Hands, HEAD, and feet optional mod from the same download page. Install a face texture mod of your choice.  
  2. Open TexBlend
  3. Choose 'Head' from the Set selection.
  4. Choose 'Color' from the type selection.  
  5. Ensure the single variant option is checked. (Note: head color textures are the same across races in Skyrim, which is why there is only one variant, 'Female', which stands for Nord)
  6. By default, note that Source Texture window displays the message 'No Files found for This Set and Type'.  I'm not able to disribute head textures from other authors, so leave 'Use Currently installed textures' checked.
  7. In the Library view click on 'CalienteHeadColorBlend.psd' to choose it.
  8. Click Preview to see the currently installed head texture, the blend image, and the final result.  Ensure they're all present.
  9. Click Blend Images to modify the head texture and install the result.
Part 2:
  1. Leave 'Head' selected in the 'Set' selection, and change the Type to 'Normal'
  2. Note a longer list of available variants appears, corresponding to the humanoid races in Skyrim.  Ensure they are all checked.
  3. Ensure 'Use Currently installed textures' is selected.  If you were to turn this off and select a source texture locally, you would end up overwriting every head normal with the same file, which is certainly not what we want here.
  4. Choose "CalienteHeadNormalBlend.psd" from the Texture Mod To Apply list.  
  5. Click preview to verify the images are all accounted for.  With multiple variants selected, the source preview shows only the first selected item.
  6. Click Blend Images.  This will step through, loading each head normal file from the data folder, apply the modification, and save it back.  If you watch the source preview window carefully while the process is occuring, you may notice the different sources popping in.  There's also a simple progress message in the very bottom of the window, as the process might take a few seconds.
Part 3:
  1. Still with Head selected in the Set selection, choose 'Specular' from the Type.
  2. Verify only one item appears in the variants list,and that it is selected.  (all humanoid races share the specular file)
  3. Make sure 'Use Currently installed textures' is still selected.
  4. select 'CalienteHeadSpecBlend.psd' from the library of available mods.
  5. Click Preview -- Specular is hard to see, the preview windows will appear to be mostly black without very close inspection.  
  6. Click 'Blend Images' to apply the specular overlay and install the updated texture. 
  
HINTS
  - Double click a file in the source list or library view to load it into a preview window, then double click the preview window to see a larger view.
  - To overwrite just one variant (such as a race's head normal in example #2), deselect all other variants in the list.  At least one must be selected for anything to work, however. 
  - Copy your favorite textures from either a mod directory or the skyrim data directory to TexBlend's Source folder to keep an inventory of textures that you can easily swap in and out. See the section on Folder Structure below for details on what should go where. 
  - You can apply multiple mods to a single texture by selecting different mods one by one and Control+Clicking Blend Images button to add them together.  Warning, doing this with a compressed DDS file output might reduce the final quality. (since the compression tends to loose a little each time its saved).  Note, if don't Ctl+Click on the blend button, and you don't change the source (or toggle use currently installed textures), you'll simply replace the modified texture.
  - Similar to above, if you have a translucent mod image (like body hair or a tatoo) you can Ctl+Click blend repeatedly with the same texture mod selected, and successively darken the result.
  
--- SETTINGS ---

TexBlend is a fairly simple program, but there are a few settings available.  Generally you won't want to change any of these.  You can find them in the Config.xml file located in the same directory as TexBlend.exe

<GameDataPath>
	Game install path.  Normally this is harvested from the windows registry, but if that's not working
	or you want to work with a different game, uncomment/change this setting.  Paths must end in a trailing slash. 
	default is C:\steam\steamapps\common\skyrim\Data\.
<TexOutputPath>	
	Texture output path.  Normally this is the same as GameDataPath, but if you wish to specify an alternate
	location where to save textures after blending, uncomment this and set the path accordingly.  If you change GameDataPath,
	you do not need to change this as well.
	default is C:\steam\steamapps\common\skyrim\Data\
	
<DefUseInstalledSource>	
	use installed texture files as the source textures by default.  convenience setting.  set to 1 to 
	have TexBlend look in its local repository for source textures, set to 0 to get them from the game data folder.
	This setting is reflected by the 'Use Currently Installed Textures' checkbox in TexBlend, and the default is 1.
	
<AlphaMatteColor>
	Alpha matte for previewing modification textures with transparency.  The transparent parts will be set 
	to this color when the image is displayed on the preview.  Possible values: white or black. Default White

<NoStripPremultAlpha>
	PSD files save a white matte color with image data in areas of transparency.  This causes the actual color
    for partially transparent pixels to be shifted toward white.  By default, TexBlend strips this premultiplied
	alpha from the image data.  However, it does not verify that the file does indeed have premult alpha, 
	so this ends up adversely impacting images where the premult alpha has already been removed. (In photoshop,
	Layers->Matte->Strip White Matte can be used to save an image without premultiplied alpha)
	Normally, this value should be left at 0 (to remove this extra color data) but if you have files that
	have the matte removed, set this to 1 to preserve color quality.  Additionally, if this is already set at
	1 and you're seeing white halos around transparent blends, set this back to 0 to correct.
	Default 0.
<AutoHeadFix>
	Automatically applies head/color and head/normal fixes to reduce the visible seam for CBBE v3 bodies.  This is a 
	convenience function written for the CBBE v3 release, and as of yet uses hard coded file names. Setting this value
	to true will not show a user interface for texblend and will attempt to apply Library\head\color\CBBEv3_HeadNeckBlendColor.psd
	and Library\head\normal\CBBEv3_HeadNeckBlend.psd automatically.
	
--- ADDING CUSTOM FILES ---

TexBlend comes with a few textures for demonstration purposes (And also to facilitate the neck seam fix process), But it is very easy to install your own source textures and modifications, and even allow TexBlend to support more texture sets such as armor or environments.  

FOLDER STRUCTURE
There are three important folders in the TexBlend application directory.  These contain subdirectories that are searched by TexBlend to find files.  
\SetDefs
	This folder contains xml files that define where TexBlend finds game data, and how TexBlend deals with the files. 
	Any number of files can exist here, but authors should be cautious to avoid using filenames others might use to avoid
	conflicts.  More on this in the next section.

\Source
	Texture files that TexBlend can use instead of getting the data from the game data directory.  These are organized by Set
	and channel
	
\Library
	Texture files that TexBlend uses for modifying source files.  By and large, these will be images containing alpha 
	transparency that will be overlayed over a source file.  These are also organized by Set and Channel.
	
Beneath the Source and Library folders are subdirectories matching the following paradigm:
\Source\<Set Name>\<Channel>\*.*    or      \Library\<Set Name>\<Channel>\*.*

The <Set Name> directory Matches the 'Set' selection in TexBlend.  (Examples: 'Body and Feet', 'Head', 'Hands'). If the folder name doesn't match any set names, it will never appear in TexBlend.
The <Channel> directory matches the 'Type' selection in TexBlend.  (Examples: 'Color','Normal','Specular').  If the folder name doesn't match any type names, it will never appear in TexBlend.
The '*.*' indicates a list of files or additional folders.  Folders within a <channel> will all appear in the Source or Library tree view, and allow for categorization of texture files.  

To add Library files, Simply copy the files you wish to include into the appropriate Library Set Name and Channel folder.  Likewise for adding Source files.  The next time those lists are refreshed in TexBlend, the files will be available.

TEXTURE SET DEFINITIONS
in the \SetDefs folder in the TexBlend installation directory, XML files exist that define where TexBlend looks for and saves files, and how it does so. Some notes:
	1. Any number of XML files can exist within that folder, all are pulled in when TexBlend starts.
	2. Each file can contain one or more TextureSet definitions.
	3. TextureSet names within or across files DO NOT need to be unique -- this way, many different files can be installed 
	   and combine into a single texture set.  
	4. SubSets within a texture set correspond to folders in the game data directory. eg. 'female','bretonfemale'.
	5. A TextureSet/SubSet/Channel can be considered to refer to a single texture file in the game data directory.  having 
	   more than one entry with the same values for those three will have undefined results. (The last one loaded will take 
	   precidence, but the load order isn't guaranteed by any mechanism)
	
A TextureSet can be thought of as a container which holds a number of texture variants. For instance the Head textureset conceptually contains all variations of character head textures.  In the case of head textures, the variations are the male and female images for all the different races.  Each variation, or subset, contains the invividual files that are loaded by the game to display the object.  For most things in Skyrim, every subset contains at least a Color texture and a Normal texture.  In some cases, Heads for instance, the variations only exist for specific channels (Color, normal, etc).  heads are an example of this -- each humanoid race subset (apart from the Nord) only has a normal map image to set them apart.  
So, each textureset contains subset variations which in turn contain channels, which uniquely identify a specific file that
TexBlend can modify.

To explain the Textureset format, it might be easiest to simply pick apart a sample texture set:

First, define a texture set.  This requires a name of your choosing:

		<TextureSet Name="Body and Feet" > 				

The first item within a texture set is a path.  This path refers to the location where the variant folders are found, and 
starts in the game's data folder (as defined in the TexBlend options).  Note this path must not contain leading or trailing
slashes!!

			<Path>textures\actors\character</Path>  
		
Next comes a series of SubSets.  The data files that come with TexBlend only have one subset for Body and Feet.  Body textures for Males, Argonians, Khajiits, etc would be defined as different subsets.  The name of the subset corresponds directly to 
a directory name in the texture set path.
			
			<SubSet Name="Female">						
		
Within a subset comes a series of channels.  These are the different kinds of texture maps that have their own file.  Not all
subsets have all channels; many share channels with other subsets.  (The BaseHead.xml  has an example of many subsets sharing the color channel of one of their siblings.) The channel names are arbitrary, but are chosen in TexBlend with the "Type" selection, so consistency is a good idea.

				<Channel Name="Color">  

Channels contain the specific information for a single file.  The Filename is first, and must match the filename the game expects.  Note the extension is left off of the file name in this field.
 				
					<FileName>femalebody_1</FileName>  
					
TexBlend supports a large number of file formats through the DevIL library.  The file format here is both the extension for the file to be saved, as well as an indicator as to the image format to expect when loading and saving this file.  For skyrim, textures are usually saved as DDS files.
					
					<FileFormat>dds</FileFormat> 	   
					
The size of the texture is next.  This refers to the pixel count of the width and height of the texture (TexBlend only works with square textures).  Larger files are more expensive disk and memory wise for a game, and can cause slowness/gfx errors if they're too big. But they look nicer.  
					
					<Size>2048</Size>
					
DDS textures can be compressed, but that compression greatly impacts the quality (most noticeable on normal maps -- never compress normal maps).  For important textures or textures that seem to look bad unacceptably bad with compression, you can turn compression off at the cost of disk and memory space.  Set this to 0 to turn compression off, 1 to turn it on.  
					
					<CompressTex>0</CompressTex>
					
Most textures are opaque everywhere, and do not require an alpha channel to represent translucency.  Set this to 0 as long as a texture does not contain transparent areas.  set it to 1 otherwise.
					
					<HasAlpha>0</HasAlpha>

Don't forget to include the XML tag to end the channel definition!

				</Channel>
			
Below is another channel in the same subset (Body and Feet/Female). This one's the normal map definition.  Notice the differences in the values (Size and filename). 
				
				<Channel Name="Normal">					 
					<FileName>femalebody_1_msn</FileName>
					<FileFormat>dds</FileFormat>
					<Size>1024</Size>					
					<CompressTex>0</CompressTex>		 
					<HasAlpha>0</HasAlpha>
				</Channel>
... more channels can go here ...
			</SubSet>
... more subests can go here ...
		</TextureSet>

		
--- SOURCE CODE ---

TexBlend is a C++ application written to utilize the standard Win32 API.  The full source code is included in the package, under the MIT license (License is printed at the top of each source file).
The code itself is regrettably uncommented for the most part, but is included partly to allow others to expand/adopt the code if they like, and to allow them to see exactly what I'm doing in there.  The license allows you to do pretty much whatever you like with it :)
I did not include any makefiles or project files, but it should be simple enough to add all the source files to a basic project and compile if desired.
I'm happy to answer questions and/or accept critique and suggestions with respect to the code and application, but please note I won't have time to give anyone a programming course :)

LIBRARY USAGE

TexBlend makes use of two third party Libraries.  

TinyXML				http://www.grinninglizard.com/tinyxml/
   A small chunk of code written by Lee Thomason that performs non-validating parsing of an XML document.  This code is included right along side the rest of the TexBlend source files (they all start with tiny*), and is released under the MIT license as well.  I have made no changes to this library, and recommend it to anyone interested in a fast and easy to use XML library.  
   
DevIL				http://openil.sourceforge.net/
	A nicely featured image library called Developer's Image Library and written by Denton Woods.  The library is offered under
the Lesser GPL license (full license text available in the src/DevILChanges/DevIL-LICENSE(LGPL) file).  
	The library itself did not quite meet the needs of TexBlend, particularly in the handling of transparency from PSD files, so I've modified some of the library code to correct these issues.  I did not include the whole library with my distribution, but instead included the files that I changed.  To see what I changed, read TexBlend\src\DevILChanges\AboutThisFolder.txt, or look at the source files located within that folder.  To obtain the library itself, please visit http://openil.sourceforge.net/.  My changes are based on version 1.7.8, and should you need to rebuild the .Dlls, replacing the official library files with my changed ones should suffice.  
	My compilation of DevIL also included libSquish (For compression), libJpeg, libpng, and zlib. Any other external libraries supported by DevIL were disabled in the configuration and not used.  
	
--- KNOWN ISSUES --- 

None yet, but I'm sure I'll find some soon enough!  This is considered alpha/beta software by me, so be warned, there could be major issues!

--- REVISION HISTORY --- 

Jan 21, 2010	0.9.2
- Added files for Caliente's Body V3
- Added an autoheadfix function (enabled through config)

Jan 09, 2012	0.9.1	
- Corrected an issue that caused TexBlend to be unable to find files in the Library and source directories.

Jan 09, 2012	0.9a	Initial release.



