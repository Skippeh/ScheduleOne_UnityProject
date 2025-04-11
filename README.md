# Unity Project for Schedule One

All script methods/etc have been stripped, but scriptable objects and prefabs etc still work fine at runtime if loaded with a mod loader like BepInEx or MelonLoader.

Only works with Unity Editor version 2022.3.32.

**Before opening the project you need to copy dependencies from the game's Managed folder. Make sure you're on the correct beta branch on Steam, otherwise they'll be missing (alternate and alternate-beta branches use Mono, main branch uses IL2CPP).**

(The game branches have matching git branches in this repository)

**DONT copy all files from the game's Managed folder**, just the ones that have a meta file in the `Assets/Plugins/ScheduleOne` folder.

## Acknowledgements

The credit for fixing shaders goes to @cheger32 on discord. I only edited some stuff to make it work with Schedule I's game scripts and dependencies and removed Beautify from the render pipeline so the renderer in editor works correctly.
