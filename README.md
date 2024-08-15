# FC2SMG - Far Cry 2 Server Mod Generator
![FC2SMG_Weapons](https://github.com/user-attachments/assets/77831202-8d69-490c-b3d8-846fa3ae2ce1)
## Features:
- Replace or disable weapons in loadouts (this includes SinglePlayer and Fortunes weapons);
- Change supported settings by adding 1 or more values and pick default value (most are <a href="https://www.dropbox.com/s/nh3d5efbfo51p51/FEARIV%20ServerLauncher%20User%20Guide.pdf?raw=1">FSL</a> supported);
- Some available options to automatically make/generate big changes (like setting no/1 weapon or add all daytime hours);
- Generates optional separate ServerLauncher with support for custom host-/patchname;
- Automatically unpacks patchfiles, applies changes and repacks with the press of a button;
- Option to load previously generated patchfile Reports to make (small) changes or use as base for another;
- Install button that copies the files of selected Generated Mod to the FC2 Game folder added in settings;

With the "***Single Weapon only***" dropdowns you can control all loadouts at once.<br>
Add 1 primary and/or secondary instantly in all loadouts to play with a single weapon, disable all for a NoWeapon mod or separately set any of the primary or secondary weapons instantly in all loadouts (e.g. when you only want to allow 1 class)
## Overview of current supported settings:
![FC2SMG_Collections](https://github.com/user-attachments/assets/255d8772-7d6b-4371-8a5e-92587327322c)<br>
Here you can add values split by ';' which are automatically added to the dropdown behind the textbox,
so you can select a default value to use when the mod is loaded.<br>
> [!NOTE]
> Settings which depend on values and linked names are not supported yet (including the DayTime setting, marked gray)
## Usage:
![FC2SMG_Settings](https://github.com/user-attachments/assets/cfc8e601-2995-4a40-87d8-54674b3089fe)<br>
When you run the application for the first time, open the **settings** and set the paths for every option, so all FC2SMG features can be used without problems.
Create or set an export directory which would hold all subfolders with generated mods/launchers and set the paths for the original FC2 serverlauncher/patchfiles you want to use.<br>
Set the Game Folder (root) to be able to use the install button to automatically copy selected Generated Modfiles to the correct location.
> [!IMPORTANT]
> Make sure the target *FC2 serverlauncher* is an **MP Patched R2** serverlauncher.<br>
> If you don't have **Gibbed** files (required for unpacking/repacking), same as R2 serverlauncher:<br>
you can find a download link in the <a href="https://www.dropbox.com/s/nh3d5efbfo51p51/FEARIV%20ServerLauncher%20User%20Guide.pdf?raw=1">FSL User Guide</a> (Requirements section).

This project makes use of the <b>FC2modHandler.dll</b>, which I made to support modtasks like unpacking/repacking patchfiles, getting indexes of setting-lines in <i>gamemodesconfig.xml</i> and writing new/extra values to supported settings. It also can work with the <i>FC2ServerLauncher.exe</i>.<br>
This dll is used in both FSL and this tool, but maybe future modders or tool creators could use it for other purposes.
