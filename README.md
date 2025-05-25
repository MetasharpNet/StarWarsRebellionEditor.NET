Welcome to the open-source editor for Star Wars Rebellion made in .NET. You will find here the 25th anniversary patch and solutions to most problems encounterred with the game.

# Table of Contents

- [Contact](#contact)
- [Star Wars Rebellion](#star-wars-rebellion)
  - [Install](#install)
  - [Language](#language)
  - [Update 1.02](#update-1.02)
  - [Fast Game Start](#fast-game-start)
  - [Issues and Fixes](#issues-and-fixes)
    - [Fullscreen](#fullscreen)
    - [Color Fringing](#color-fringing)
    - [Other](#other)
- [Star Wars Rebellion Editor .NET](#star-wars-rebellion-editor-.net)
  - [Setup](#setup)
  - [Features](#features)
  - [To Do](#to-do)
- [25th Anniversary Patch](#25th-anniversary-patch)
  - [Content](#content)
  - [Patching](#patching)
  - [Roadmap](#roadmap)
  - [Videos](#videos)
  - [Screenshots](#screenshots)
  - [Extras](#extras)
  - [Statistics](#statistics)
- [Links](#links)

---

# Contact

- You can talk with us on Discord : https://discord.gg/avwsecxtBb
  - Contact : Metasharp
- Steam : https://steamcommunity.com/app/441550/discussions/0/5913829825701729169/
- GoG : https://www.gog.com/forum/star_wars_rebellion/star_wars_rebellion_in_2023_25th_anniv_patch_fix_fr_patch_guides

---

# Star Wars Rebellion

- To buy the game
  - GoG : https://www.gog.com/en/game/star_wars_rebellion
  - Steam : https://store.steampowered.com/app/441550/STAR_WARS_Rebellion/
- Game Guides:
  - GameFaqs community guides : https://gamefaqs.gamespot.com/pc/198776-star-wars-rebellion/faqs
  - Official Prima guide available here : https://archive.org/details/star-wars-rebellion-guide/mode/2up

## Install

- Avoid all extra software (GOG Galaxy, etc.) by getting a clean installer if available.
  - GOG direct offline installer : https://www.gog.com/downloads/star_wars_rebellion/en1installer0 (link works if logged in and game already bought)
  - Steam : I don't know
- Install the game
- Optional: In your Star Wars Rebellion folder, right-click REBEXE.EXE
  - Properties
    - Compatibility tab
      - Change settings for all users
      - Uncheck all boxes
      - Apply
      - OK

## Language

- If you want to play in french
  - Extract language patch files into your Star Wars Rebellion folder. This will overwrite 28 files and add 1 file.
    - FR patch: https://github.com/MetasharpNet/StarWarsRebellionEditor.NET/releases/download/french-patch-2024-04-12/french-patch.zip
  - To go back to english, do the same with the english-patch and overwrite these same files with original english ones.
    - EN patch: https://github.com/MetasharpNet/StarWarsRebellionEditor.NET/releases/download/english-patch-2024-04-12/english-patch.zip

## Update 1.02

- Not needed if you use the 25th anniversary patch (since it's included in it already)
- Extract the zip into your game directory. This will overwrite 2 files and add 12 new files.
  - Update 1.02 zip : https://github.com/MetasharpNet/StarWarsRebellionEditor.NET/releases/download/update-1.02/update-1.02.zip
- This should fix upside down sprites or sprites with weird colors

## Fast game start

- rename ALBRIEF.DLL to ALBRIEF.DLL.OLD
- rename EMBRIEF.DLL to EMBRIEF.DLL.OLD
- This will skip new game's 5 minute briefings.

## Issues and Fixes

### Fullscreen

#### Shortcut with -w

- Create a shortcut on your desktop to REBEXE.EXE
- Right-click the shortcut file you've just created
  - Properties
    - Shortcut
      - In Target, add a space and -w at the end. It should look like this: "C:\?????????\REBEXE.EXE" -w
      - Apply
      - OK
- Make sure you use your shortcut to run the game has the -w option

#### ALT-GR + F11

- Try pressing Alr Gr + F11 to go in/out of full screen mode

#### Display Port Cable

- Use Display Port cable instead of HDMI

#### Video Scaling Settings

If you have an Nvidia Card:

- Open Nvidia Control Panel (right click on desktop and click on Nvidia icon)
- Change resolution
  - Customize
  - Check Enable Resolutions not exposed by the display
  - Add all resolutions
  - OK
  - Apply
- Adjust Desktop size and Position
  - Click on Scaling
  - Check Aspect ratio
  - Choose Perform scaling on : Display (not GPU, it's important)
  - Check Override the scaling mode set by games and programs
  - Apply

For AMD (Radeon, ...) GPU, you can try this link:

- https://www.amd.com/en/resources/support-articles/faqs/DH-019.html

If you have another GPU brand than Nvidia or AMD, do the same as above and get some more info here:

- https://www.pcgamingwiki.com/wiki/Glossary:Custom_resolution

#### DgVoodoo Settings

- Change settings with : dgVoodooCpl.exe from your game folder

### Color fringing

- If you get this issue (on the side of pixels, you can see a colored ghost of them in multiple places, red, black, ... The are invisible in screenshots and can only be captured with a photo), try to play in 60Hz. No other fix found yet.

### Other

- If you get: "The pixel format was invalid as specified." error when entering tactical battle, ... it shouldn't bother the game working, but we have no known solution as of now. Try googling and share if you find a solution. This problem is not related to 25th anniversary patch.

---

# Star Wars Rebellion Editor .NET

C# 13.0 project built with .NET 9 in Visual Studio 2022 : https://visualstudio.microsoft.com/vs/community/

## Setup

- Install the latest .NET Desktop runtime : https://dotnet.microsoft.com/en-us/download/dotnet
  - Direct link to latest version : https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-desktop-9.0.5-windows-x64-installer
- Reboot
- Install a fresh GoG or Steam Star Wars Rebellion game
- Download the latest editor release : https://github.com/MetasharpNet/StarWarsRebellionEditor.NET/releases
  - (the file : swr-editor.net-?.?.????.?????.zip)
- Extract the whole zip file content to a separate folder (not in the game folder directly! you can however create an editor subfolder in the game folder if you want, this is ok)
- If the editor windows seem to show overlapping fields, you probably have activated Font or Icons zoom factor in Windows.
  - Try to set it back to 100%. (https://community.microcenter.com/kb/articles/746-how-to-adjust-display-scaling-in-windows-11)
- Run : SwRebellionEditor.exe
  - If prompted, adjust the game folder.

## Features

- Galaxy Map editor : can drag&drop sectors and systems
- Editor for : Sectors, Systems, Characters, Units, Building (all fields can be modified, unlimited names and encyclopedia descriptions lengths)
  - Drag and drop a new System 37x37 BMP picture on current to update it
- Initial game setup, general and side parameters tables
- Export in 1 click game resources in an export folder (bitmaps, sounds, videos, 3d models and data in CSV for now)
- Patch : Star Wars Rebellion 25th Anniversary patch
  - Test Patch : Patch your custom content from the test folder. It can be anything from the export modified to your taste. By default it contains 25th anniv patch content still in testing phase such as the new capital ships.
- Pictures format converter

## To do

- Identify unknown fields usage
- Other features from RebEd
- etc

---

# 25th Anniversary Patch

The 25th anniversary patch aims to refresh the game experience with mostly cannon Star wars Universe content:

## Content

- Game version: 1.02 (includes various community fixes)
- DgVoodoo DirectX libraries v2.86.2 (2025-04-02) : http://dege.fw.hu/dgVoodoo2/dgVoodoo2/
  - Forum : https://www.vogons.org/viewforum.php?f=58 and https://www.vogons.org/viewtopic.php?f=59&t=97303
- Microsoft latest D3DRM.DLL 5.2.3790.0
- New Galaxy map using Top 200 Star Wars planets (using 2023 canon & positioned as accurately as possible)
  - 2 modes: compatible with base game or accurate positions (savegames/multi not compatible with base game ones)
- 20/20 new Sector names
- 200/200 new Planets including:
  - Names & encyclopedia (picture, name, position, area, connections, geology, species, economy, history, sources)
  - Individual Planets sprites (instead of only 26 base game sprites reused for 200 planets)
- 61/61 new Character sprites (closer to canon/legends character real faces)
- 118/118 sprites displaying base stats (optional)
  - 10/10 troops, 9/9 special forces, 8/8 fighters, 30/30 capital ships, 61/61 characters
- 30/30 new Capital Ships Encyclopedia (picture, faction, full name, size, easy stats, company, history)
- 161/217 Mission+Events sprites
- 8 Capital Ships changed to use more known ones (+ 7 names improved)
  - [Alliance] Mon Calamari Cruiser → MC80 Liberty Cruiser (name change)
  - [Alliance] Bulk Transport → Bulk Freighter (name change)
  - [Alliance] Alliance Dreadnaught → MC40a Light Cruiser (ship change)
  - [Alliance] CC-9600 Frigate → MC30c Frigate (ship change)
  - [Alliance] Bulwark Battlecruiser → Viscount Star Defender (ship change)
  - [Alliance] Dauntless Cruiser → MC80a HomeOne Cruiser (ship change)
  - [Empire] Strike Cruiser → Vindicator Heavy Cruiser (ship change)
  - [Empire] Interdictor Cruiser → Immobilizer Cruiser (name change)
  - [Empire] Carrack Light Cruiser → Arquitens Light Cruiser (ship change)
  - [Empire] Victory Destroyer → Victory I Star Destroyer (name change)
  - [Empire] Imperial Star Destroyer → Imperial I Star Destroyer (name change)
  - [Empire] Assault Transport → Gladiator Star Destroyer (ship change)
  - [Empire] Galleon → Acclamator Drop Ship (ship change)
  - [Empire] Star Galleon → Star Galleon Frigate (name change)
  - [Empire] Imperial Dreadnaught → Imperial Dreadnought (name change)
- 29/29 new Capital Ships 3D models
  - 2024-01-02 [Alliance] Action 6 Transport Bulk Freighter
  - 2024-01-02 [Empire] Executor Super Star Destroyer
  - 2024-01-02 [Empire] Imperial Dreadnought Class Heavy Cruiser
  - 2024-01-08 [Empire] Vindicator Heavy Cruiser
  - 2024-01-08 [Empire] Victory Class Star Destroyer Mark 1
  - 2024-01-18 [Alliance] CR90 Corellian Corvette
  - 2024-02-11 [Alliance] MC80 Liberty Type Star Cruiser
  - 2024-02-11 [Alliance] Assault Frigate Mark 1
  - 2024-03-17 [Alliance] CC-7700 Frigate
  - 2024-03-17 [Alliance] DP20 Frigate Correlian Gunship
  - 2024-04-19 [Empire] Acclamator-Class Dropship
  - 2024-04-19 [Empire] Arquitens Light Cruiser
  - 2024-04-28 [Alliance] GR-75 Medium Transport
  - 2024-04-28 [Alliance] MC30C Frigate
  - 2024-06-02 [Empire] Immobilizer 418 Cruiser
  - 2024-06-05 [Alliance] Alliance Escort Carrier
  - 2024-06-19 [Alliance] Viscount Star Defender
  - 2024-08-16 [Empire] Gladiator Star Destroyer
  - 2024-08-16 [Empire] Star Galleon Frigate
  - 2024-09-09 [Empire] Escort Carrier
  - 2024-09-09 [Empire] Lancer Frigate
  - 2024-09-25 [Empire] Imperial Star Destroyer
  - 2024-11-11 [Alliance] Bulk Cruiser
  - 2024-11-11 [Alliance] Nebulon B Frigate
  - 2024-11-11 [Empire] Imperial Star Destroyer 2
  - 2024-11-11 [Empire] Victory Star Destroyer 2
  - 2024-12-23 [Alliance] MC40A Light Cruiser
  - 2024-12-23 [Alliance] MC80A Home One Cruiser
  - 2024-12-23 [Alliance] Liberator Cruiser
- 80/80 new Space Fighters sprites for 3D battles (X-wing, ...)
- 16/16 HD background musics (44KHz vs 11KHz rebuilt from CDs and completed with AI remasters)

## Patching

- Disable Antivirus such as Norton: they might silently block the patching process and make the resulting game bugged
  - Windows Defender seems fine, try with your Antivirus on first and see if you experience in game bugs
- Run : SwRebellionEditor.exe
- Click on the death star icon (the last icon) or through the menu : Editor / 25th Anniversary Patch
- Check either :
  - compatible galaxy map : new sectors and planets keep original planet positions to keep compatibility with base game savegames and multiplayer
  - accurate galaxy map : new sectors and planets positions are changed to match as close as possible the real star war map
- Check either :
  - units with stats : units sprites display average base stats to give you a rough idea of their strenghts/weaknesses
  - units without stats : unit sprites display no stats, like in the base game
- Click on the patch my game button
  - The UI will pop a window detailling in real time what is being patched. Wait for the patch to complete (can take 15min+).
  - To get the latest preview features (ships in progress...), also patch with the Patch test folder only button.
  - Close the editor
- Enable again your antivirus if you had to disable it
- Run the game.

## Roadmap

- fix new high definition 3d models for all capital ships to avoid tactical crash (some tests needed)
- new capital ships sprites
- new units sprites
- new missions sprites
- new events sprites

## Videos

- 25th anniversary patch in video : https://www.youtube.com/watch?v=2QI-di2l4S8 (not made by us, and remember, patch is not final/completed)

## Screenshots

![image](https://github.com/MetasharpNet/StarWarsRebellionEditor.NET/assets/70144948/9eab72f8-4d48-4293-9c77-c73d4f9baa7f)

![New Canon Galaxy map](https://i.ibb.co/c8XZD0j/1.png)

![New planets and sprites](https://i.ibb.co/LpdxfcR/2.png)

![image](https://github.com/MetasharpNet/StarWarsRebellionEditor.NET/assets/70144948/0b8d8986-482f-4b87-ab49-339a8ef13a7e)

![image](https://github.com/MetasharpNet/StarWarsRebellionEditor.NET/assets/70144948/b2391190-872f-402f-a700-675739e0f056)

![New encyclopedia entries and hd pictures](https://i.ibb.co/KxVDTLc/4.png)

3D Ships Before/After comparison :

![image](https://github.com/user-attachments/assets/217edec7-4a4f-4f5f-b7b6-8f00d542c541)

![image](https://github.com/user-attachments/assets/2b987730-456d-4ac7-a3da-622da14de791)

## Extras

- Savegame Test Pack (broken, will need to redo) : https://github.com/MetasharpNet/StarWarsRebellionEditor.NET/releases/tag/swr-editor.net-savegame-20231015

## Statistics

GitHub Downloads stats : https://hanadigital.github.io/grev/?user=MetasharpNet&repo=StarWarsRebellionEditor.NET

---

# Links

- Youtube content about Star Wars Rebellion : https://www.youtube.com/channel/UC5i5AnRuz-czXmxYoAEkW_g
- Gamefaqs : https://gamefaqs.gamespot.com/pc/198776-star-wars-rebellion/faqs
- Pen and Paper Videos : https://www.youtube.com/watch?v=dPj-E28VwFQ&list=PLdyTWLFZyc8MQQcXmg4J2G49PJ1Nkm769
- Captain Katarn Videos : https://www.youtube.com/@IntrepidDawn/search?query=https%3A%2F%2Fwww.youtube.com%2Fwatch%3Fv%3D2QI-di2l4S8

--

**Metasharp**
