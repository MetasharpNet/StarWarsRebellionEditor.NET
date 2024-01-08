## Star Wars Rebellion Editor .NET
* Need some help, talk with us on :
  * Discord : https://swrebellion.link/discord
  * Steam : https://steamcommunity.com/app/441550/discussions/0/5913829825701729169/
  * GoG : https://www.gog.com/forum/star_wars_rebellion/star_wars_rebellion_in_2023_25th_anniv_patch_fix_fr_patch_guides
* C# 11.0 project built with .NET 7 in Visual Studio 2022 : https://visualstudio.microsoft.com/vs/community/
* To find where to buy the game or get free fan mods, check : https://swrebellion.net/
  * I advise to go for GoG version of the game.

### Current Editor Features :
* Galaxy Map editor : can drag&drop sectors and systems
* Editor for : Sectors, Systems, Characters, Units, Building (all fields can be modified, unlimited names and encyclopedia descriptions lengths)
* Drag and drop a new System 37x37 BMP picture on current to update it
* Export : Systems
* Other features in testing accessible in menus only
* Extract : Export in 1 click game resources in an export folder (bitmaps and 3d models and data in CSV for now)
* Patch : Star Wars Rebellion 25th Anniversary patch
* Test Patch : Patch your custom content from the CSV folder. It can be anything from the export modified to your taste.

### 25th Anniversary Patch Features :
* Game's 1.02 community update
* Dgvoodoo 2.82.2 (2023-12-26) directx libraries : http://dege.fw.hu/dgVoodoo2/dgVoodoo2/
  * Forum : https://www.vogons.org/viewforum.php?f=58 and https://www.vogons.org/viewtopic.php?f=59&t=97303
* New Galaxy map using top 200 star wars planets (called systems in game) from 2023 canon mostly positioned as accurately as possible within game engine limits!
* 200/200 systems sprites (instead of 26 original sprites shared amongst 200 systems)
* 200/200 systems tactical sprites
* 200/200 systems encyclopedia pictures
* 200/200 encyclopedia descriptions
* 61/61 new character sprites from LordLaForge to be closer to canon/lgends character faces
* 61/61 enhanced character sprites displaying their base average stats
* 7/29 HD 3d models for capital ships + (22 mid definition 3d models)
* 16/16 HD background musics (44KHz vs 11KHz)
* 80 HD sprites for space fighters (X-wing, ...)
* Savegame Test Pack (broken, will need to redo) : https://github.com/MetasharpNet/StarWarsRebellionEditor.NET/releases/tag/swr-editor.net-savegame-20231015
* Screenshots :

![New Canon Galaxy map](https://i.ibb.co/c8XZD0j/1.png)

![New planets and sprites](https://i.ibb.co/LpdxfcR/2.png)

![image](https://github.com/MetasharpNet/StarWarsRebellionEditor.NET/assets/70144948/0b8d8986-482f-4b87-ab49-339a8ef13a7e)

![image](https://github.com/MetasharpNet/StarWarsRebellionEditor.NET/assets/70144948/b2391190-872f-402f-a700-675739e0f056)

![New encyclopedia entries and hd pictures](https://i.ibb.co/KxVDTLc/4.png)

3D Ships Before/After comparison (not completely updated):

![image](https://github.com/MetasharpNet/StarWarsRebellionEditor.NET/assets/70144948/d2a09e53-8278-4073-ab99-b2821cea182d)

![image](https://github.com/MetasharpNet/StarWarsRebellionEditor.NET/assets/70144948/1f2461fe-576f-4d91-9321-0f6791c2378e)

### 25th Anniversary Installation guide:
* Install the latest .NET Desktop runtime : https://dotnet.microsoft.com/en-us/download/dotnet
  * Direct link to latest version : https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-7.0.14-windows-x64-installer
* Reboot
* Install a fresh GoG or Steam Star Wars Rebellion game
* Download the latest editor release : https://github.com/MetasharpNet/StarWarsRebellionEditor.NET/releases
  * (the file : swr-editor.net-?.?.????.?????.zip)
* Extract the whole zip file content to a separate folder (not in the game folder directly! you can however create an editor subfolder in the game folder if you want, this is ok)
* Run : SwRebellionEditor.exe
  * If prompted, adjust the game folder.
* Click on the death star icon (the last icon) or through the menu : Editor / 25th Anniversary Patch
* Click on the patch button
  * The UI will freeze. Wait for the patch to complete. When done, the patch window will be closed automatically.
  * Close the editor
* Run the game.

### Fast game start
* rename ALBRIEF.DLL to ALBRIEF.DLL.OLD
* rename EMBRIEF.DLL to EMBRIEF.DLL.OLD
* This will skip new game's 5 minute briefings.

### If you have issues with full screen
* Use Display Port cable instead of HDMI
* Make sure your shortcut to run the game has the -w option
* Change settings with : dgVoodooCpl.exe from your game folder

If you have an Nvidia Card:
* Open Nvidia Control Panel (right click on desktop and click on Nvidia icon)
* Change resolution
  * Customize
  * Check Enable Resolutions not exposed by the display
  * Add all resolutions
  * OK
  * Apply
* Adjust Desktop size and Position
  * Click on Scaling
  * Check Aspect ratio
  * Choose Perform scaling on : GPU
  * Check Override the scaling mode set by games and programs
  * Apply

If you have another GPU brand than Nvidia, do the same as above and get some more info here:
* https://www.pcgamingwiki.com/wiki/Glossary:Custom_resolution

### Current Roadmap:
* new high definition 3d models for all capital ships

### Final Roadmap (low chance i'll invest time on it):
* Cleanup code on rarely used windows
* Identify unknown fields usage
* Other features from RebEd
* etc.

### Statistics:
GitHub Downloads stats : https://hanadigital.github.io/grev/?user=MetasharpNet&repo=StarWarsRebellionEditor.NET

--

**Meta**
