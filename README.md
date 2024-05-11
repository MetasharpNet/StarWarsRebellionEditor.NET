## Star Wars Rebellion Editor .NET
* Need some help, talk with us on :
  * Discord : https://swrebellion.link/discord ([#game-midd](https://discord.com/channels/263439494508707840/789989647761145907)
    * Contact Metasharp user 
  * Steam : https://steamcommunity.com/app/441550/discussions/0/5913829825701729169/
  * GoG : https://www.gog.com/forum/star_wars_rebellion/star_wars_rebellion_in_2023_25th_anniv_patch_fix_fr_patch_guides
* C# 12.0 project built with .NET 8 in Visual Studio 2022 : https://visualstudio.microsoft.com/vs/community/
* To find where to buy the game or get free fan mods, check : https://swrebellion.net/
  * I advise to go for GoG version of the game (Steam version should work as well).

### Current Editor Features :
* Galaxy Map editor : can drag&drop sectors and systems
* Editor for : Sectors, Systems, Characters, Units, Building (all fields can be modified, unlimited names and encyclopedia descriptions lengths)
* Drag and drop a new System 37x37 BMP picture on current to update it
* Export in 1 click game resources in an export folder (bitmaps, sounds, videos, 3d models and data in CSV for now)
* Patch : Star Wars Rebellion 25th Anniversary patch
* Test Patch : Patch your custom content from the test folder. It can be anything from the export modified to your taste. By default it contains 25th anniv patch content still in testing phase such as the new capital ships.

### 25th Anniversary Patch Features :
* Game version: 1.02 (includes various community fixes)
* DirectX libraries: DgVoodoo 2.82.5 (2024-04-16)
* New Galaxy map using Top 200 Star Wars planets (using 2023 canon & positioned as accurately as possible)
  * 2 modes: compatible with base game or accurate positions (savegames/multi not compatible with base game ones)
* 20/20 new Sector names
* 200/200 new Planets including:
  * Names & encyclopedia (picture, name, position, area, connections, geology, species, economy, history, sources)
  * Individual Planets sprites (instead of only 26 base game sprites reused for 200 planets)
* 61/61 new Character sprites (closer to canon/legends character real faces)
* 118/118 sprites displaying base stats (optional)
  * 10/10 troops, 9/9 special forces, 8/8 fighters, 30/30 capital ships, 61/61 characters
* 30/30 new Capital Ships Encyclopedia (picture, faction, full name, size, easy stats, company, history)
* 8 Capital Ships changed to use more known ones (+ 7 names improved)
  * [Alliance] Mon Calamari Cruiser → MC80 Liberty Cruiser (name change)
  * [Alliance] Bulk Transport → Bulk Freighter (name change)
  * [Alliance] Alliance Dreadnaught → MC40a Light Cruiser (ship change)
  * [Alliance] CC-9600 Frigate → MC30c Frigate (ship change)
  * [Alliance] Bulwark Battlecruiser → Viscount Star Defender (ship change)
  * [Alliance] Dauntless Cruiser → MC80a HomeOne Cruiser (ship change)
  * [Empire] Strike Cruiser → Vindicator Heavy Cruiser (ship change)
  * [Empire] Interdictor Cruiser → Immobilizer Cruiser (name change)
  * [Empire] Carrack Light Cruiser → Arquitens Light Cruiser (ship change)
  * [Empire] Victory Destroyer → Victory I Star Destroyer (name change)
  * [Empire] Imperial Star Destroyer → Imperial I Star Destroyer (name change)
  * [Empire] Assault Transport → Gladiator Star Destroyer (ship change)
  * [Empire] Galleon → Acclamator Drop Ship (ship change)
  * [Empire] Star Galleon → Star Galleon Frigate (name change)
  * [Empire] Imperial Dreadnaught → Imperial Dreadnought (name change)
* 15/29 new Capital Ships 3D models  (+14 other 3d models still to redo)
  * 2024-01-02 [Alliance] Action 6 Transport Bulk Freighter
  * 2024-01-02 [Empire] Executor Super Star Destroyer
  * 2024-01-02 [Empire] Immobilizer 418 Cruiser
  * 2024-01-02 [Empire] Imperial Dreadnought Class Heavy Cruiser
  * 2024-01-08 [Empire] Vindicator Heavy Cruiser
  * 2024-01-08 [Empire] Victory Class Start Destroyher Mark 1
  * 2024-01-18 [Alliance] CR90 Corellian Corvette
  * 2024-02-11 [Alliance] MC80 Liberty Type Star Cruiser
  * 2024-02-11 [Alliance] Assault Frigate Mark 1
  * 2024-03-17 [Alliance] CC-7700 Frigate
  * 2024-03-17 [Alliance] DP20 Frigate Correlian Gunship
  * 2024-04-19 [Empire] Acclamator-Class Dropship
  * 2024-04-19 [Empire] Arquitens Light Cruiser
  * 2024-04-28 [Alliance] GR-75 Medium Transport
  * 2024-04-28 [Alliance] MC30C Frigate
* 80/80 new Space Fighters sprites for 3D battles (X-wing, ...)
* 16/16 HD background musics (44KHz vs 11KHz rebuilt from CDs and completed with AI remasters)
* Savegame Test Pack (broken, will need to redo) : https://github.com/MetasharpNet/StarWarsRebellionEditor.NET/releases/tag/swr-editor.net-savegame-20231015
* Screenshots :

![image](https://github.com/MetasharpNet/StarWarsRebellionEditor.NET/assets/70144948/9eab72f8-4d48-4293-9c77-c73d4f9baa7f)

![New Canon Galaxy map](https://i.ibb.co/c8XZD0j/1.png)

![New planets and sprites](https://i.ibb.co/LpdxfcR/2.png)

![image](https://github.com/MetasharpNet/StarWarsRebellionEditor.NET/assets/70144948/0b8d8986-482f-4b87-ab49-339a8ef13a7e)

![image](https://github.com/MetasharpNet/StarWarsRebellionEditor.NET/assets/70144948/b2391190-872f-402f-a700-675739e0f056)

![New encyclopedia entries and hd pictures](https://i.ibb.co/KxVDTLc/4.png)

3D Ships Before/After comparison (not completely updated):

![image](https://github.com/MetasharpNet/StarWarsRebellionEditor.NET/assets/70144948/d2a09e53-8278-4073-ab99-b2821cea182d)

![image](https://github.com/MetasharpNet/StarWarsRebellionEditor.NET/assets/70144948/1f2461fe-576f-4d91-9321-0f6791c2378e)

### Star Wars Rebellion Original Game install/update:
* Avoid all extra software (GOG Galaxy, etc.) by getting a clean installer if available.
  * GOG direct offline installer : https://www.gog.com/downloads/star_wars_rebellion/en1installer0  (link works if logged in and game already bought)
  * Steam : I don't know
* Install the game
* If you want to play in french, download from swrebellion.net the french patch and extract it into your Star Wars Rebellion folder. This will overwrite 28 files and add 1 file. If you want to go back to english, do the same with the english-patch from swrebellion.net and overwrite these same file with original english ones.
  * FR patch: https://swrebellion.net/files/file/258-star-wars-rebellion-patch-francais-officiel/?do=getNewComment
  * EN patch: https://swrebellion.net/files/file/259-star-wars-rebellion-english-patch-official/?do=getNewComment
* Copy "game update" folder content into your game's folder (you can skip this step if you patch with the 25th anniversary patch, since it's going to be done automatically). This will overwrite 2 files and add 12 new files.
* Optional: In your Star Wars Rebellion folder, right-click REBEXE.EXE
  * Properties
    * Compatibility tab
      * Change settings for all users
      * Uncheck all boxes
      * Apply
      * OK
* Create a shortcut on your desktop to REBEXE.EXE
* Right-click the shortcut file you've just created
  * Properties
    * Shortcut
      * In Target, add a space then -w at the end: "C:\?????????\REBEXE.EXE" -w
      * Apply
      * OK
* Run the game from that shortcut

### 25th Anniversary Installation guide:
* Install the latest .NET Desktop runtime : https://dotnet.microsoft.com/en-us/download/dotnet
  * Direct link to latest version : https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-desktop-8.0.4-windows-x64-installer
* Reboot
* Install a fresh GoG or Steam Star Wars Rebellion game
* Download the latest editor release : https://github.com/MetasharpNet/StarWarsRebellionEditor.NET/releases
  * (the file : swr-editor.net-?.?.????.?????.zip)
* Extract the whole zip file content to a separate folder (not in the game folder directly! you can however create an editor subfolder in the game folder if you want, this is ok)
* If the editor windows seem to show overlapping fields, you probably have activated Font or Icons zoom factor in Windows. Try to set it back to 100%. (https://community.microcenter.com/kb/articles/746-how-to-adjust-display-scaling-in-windows-11)
* Disable Antivirus such as Norton: they might silently block the patching process and make the resulting game bugged (Windows Defender seems fine, try with your Antivirus on first and see if you experience in game bugs)
* Run : SwRebellionEditor.exe
  * If prompted, adjust the game folder.
* Click on the death star icon (the last icon) or through the menu : Editor / 25th Anniversary Patch
* Click on the patch button
  * The UI will pop a window detailling in real time what is being patched. Wait for the patch to complete.
  * To get the latest features, also patch with the Patch Test button.
  * Close the editor
* Enable again your antivirus if you had to disable it
* Run the game.

### Fast game start
* rename ALBRIEF.DLL to ALBRIEF.DLL.OLD
* rename EMBRIEF.DLL to EMBRIEF.DLL.OLD
* This will skip new game's 5 minute briefings.

### If you have issues with full screen
* Try pressing Alr Gr + F11 to go in/out of full screen mode
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

For AMD (Radeon, ...) GPU, you can try this link: https://www.amd.com/en/support/kb/faq/dh-019#:~:text=To%20enable%20GPU%20Scaling%2C%20follow,GPU%20Scaling%20option%20to%20On

If you have another GPU brand than Nvidia or AMD, do the same as above and get some more info here:
* https://www.pcgamingwiki.com/wiki/Glossary:Custom_resolution

### Other issues
* If you get: "The pixel format was invalid as specified." error when entering tactical battle, ... it shouldn't bother the game working, but I have no known solution as of now. Try googling and share if you find a solution. This problem happens on base game install as well and is not related to 25th anniversary patch.

### Current Roadmap:
* new high definition 3d models for all capital ships

### Final Roadmap (low chance i'll invest time on it):
* Identify unknown fields usage
* Other features from RebEd
* etc.

### Statistics:
GitHub Downloads stats : https://hanadigital.github.io/grev/?user=MetasharpNet&repo=StarWarsRebellionEditor.NET

--

**Meta**
