# Unity Project for Schedule One

All script methods/etc have been stripped, but scriptable objects and prefabs etc still work fine at runtime if loaded with a mod loader like BepInEx or MelonLoader.

Only works with Unity Editor version 2022.3.32.

## First time setup instructions

First of all, this project is only tested and verified to work with the mono branches of the game (aka alternate and alternate-beta).

1. Make sure your game and the version you download of this repository matches (git branch 'alternate' requires 'alternate' game branch on Steam).
2. Open the game's directory and open the `Schedule I_Managed` folder.
3. In a new window, also open this project's `Assets/Plugins/ScheduleOne` folder.
4. Inside the game folder, drag the `Managed` folder onto the `DropManagedFolderHere.bat` file from this project. This will copy all required dlls into the unity project.
5. Now you can open the project in Unity and there shouldn't be any errors. There will be MANY warnings but they can be ignored.

If you are copying dependencies manually without using the bat file: **DONT copy all files from the game's Managed folder**, just the ones that have a meta file in the `Assets/Plugins/ScheduleOne` folder.

## Acknowledgements

- The credit for fixing shaders goes to @cheger32 on discord. I only edited some stuff to make it work with Schedule I's game scripts and dependencies and removed Beautify from the render pipeline so the renderer in editor works correctly.
- Thanks to [@chloelcdev](https://github.com/chloelcdev) for making a bat script that copies the game's dependencies automatically.
