## Star Wars Rebellion Editor .NET
* C# 11.0 project built with .NET 7 in Visual Studio 2022 : https://visualstudio.microsoft.com/vs/community/
* To find where to buy the game or get free fan mods, check : https://swrebellion.net/
  * I advise to go for GoG version of the game.

### Current Editor Features :
* Galaxy Map editor : can drag&drop sectors and systems
* Editor for : Sectors, Systems, Characters, Units, Building (all fields can be modified, unlimited names and encyclopedia descriptions lengths)
* Drag and drop a new System 37x37 BMP picture on current to update it
* Export : Systems
* Other features in testing accessible in menus only
* Patch : Star Wars Rebellion 25th Anniversary patch

### 25th Anniversary Patch Features :
* Game's 1.02 community update
* Dgvoodoo 2.81 directx libraries
* New Galaxy map using top 200 star wars planets (called systems in game) from 2023 canon mostly positioned as accurately as possible within game engine limits!
* 200/200 systems sprites (instead of 26 original sprites shared amongst 200 systems)
* 200/200 systems tactical sprites
* 200/200 systems encyclopedia pictures
* 200/200 encyclopedia descriptions
* 61/61 enhanced character sprites displaying their base average stats
* 24/29 high definition 3d models for capital ships
* 80 high definition sprites for space fighters (X-wing, ...)
* Screenshots :

![New Canon Galaxy map](https://i.ibb.co/c8XZD0j/1.png)

![New planets and sprites](https://i.ibb.co/LpdxfcR/2.png)

![New characters sprites with stats](https://i.ibb.co/cDMHwR1/3.png)

![New encyclopedia entries and hd pictures](https://i.ibb.co/KxVDTLc/4.png)

### 25th Anniversary Installation guide:
* Install the latest .NET Desktop runtime : https://dotnet.microsoft.com/en-us/download/dotnet
  * Direct link to latest version : https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-7.0.8-windows-x64-installer
* Reboot
* Install a fresh GoG or Steam Star Wars Rebellion game
* Download the latest editor release : https://github.com/MetasharpNet/StarWarsRebellionEditor.NET/releases
  * (the file : swr-editor.net-?.?.????.?????.zip)
* Extract the whole zip file content to a separate folder.
* Run : SwRebellionEditor.exe
  * If prompted, adjust the game folder.
* Click on the death star icon (the last icon) or through the menu : Editor / 25th Anniversary Patch
* Click on the patch button
  * The UI will freeze. Wait for the patch to complete. When done, the patch window will be closed automatically.
  * Close the editor
* Run the game.

If you have issues with full screen you can try to :
* Change settings with : dgVoodooCpl.exe from your game folder
* Read that page for more possible ways to fix your graphic issues : https://swrebellion.net/files/file/260-star-wars-rebellion-update/
  * The 1.02 patch is automatically installed when you install the patch. No need to do it twice.

### Current Roadmap:
* new high definition 3d models for all capital ships
* 0/61 new character sprites from LordLaForge including optimized base stats average display

### Final Roadmap (low chance i'll invest time on it):
* Cleanup code on rarely used windows
* Identify unknown fields usage
* Other features from RebEd
* etc.

### Statistics:
GitHub Downloads stats : https://hanadigital.github.io/grev/?user=MetasharpNet&repo=StarWarsRebellionEditor.NET

--

**Meta**
