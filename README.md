# Nucleus Co-Op
Nucles Co-Op is a tool for Windows that allows split-screen play on many games that do not initially support it.

Support its development by helping on my Patreon! https://www.patreon.com/distro
Subscribe to our subreddit: https://www.reddit.com/r/nucleuscoop/


Currently Supported Games:

- Borderlands 2
- Borderlands: The Pre Sequel

Working but not with all features:
- Borderlands
	ALPHA5: Everything works if you're using gamepads, but not with a keyboard + mouse player


So close but not there yet:

- Saints Row 3
	Working: All instances open correctly using SmartSteamEmu, can control all instances freely
	Issue: Can't find the game on LAN. If from the Shift + Tab menu, the game says the session is no longer available.


# How does it work?
Starting from Alpha 4, all games use a generic handler that can handle pretty much all situations.
To add a new game, you can just create a new *.js file on the games folder, and describe what your game needs to run.
Now, what the GenericHandler actually does?

When the user hits play:
- If the game needs modifications to the save files, we backup them so when the splitscreen session ends we can return all the configurations back to normal.
- The app symlinks the entire game folder to the Data folder, so we can launch each instance of the game with custom DLLs.
- Runs the JavaScript engine, so any custom code that needs to be executed by player ID runs
- We copy a custom xinput dll specific for each gamepad: Each xinput passthroughs a specific gamepad input to the 1st gamepad (xinput1 just passtroughs, xinput2 passes to 2, i.e).
- If needed, we extract SmartSteamEmu and start the game using it.
- Now we keep track of the processes, looking for the launcher and the actual game window, so we can position it correctly on the screen.



Next on the List:

- Left 4 Dead 1
- Left 4 Dead 2
- Portal 2
- Call of Duty: Black Ops
- Call of Duty: Modern Warfare 2
- Saints Row 3
- Saints Row 4
- Team Fortress 2 (support for 64 players on 1 machine FTW)
- Unlimited Power mode (multiple keyboards + mouses + gamepads)

Games I want to add but I don't own:

- Call of Duty: World At War
- Call of Duty: Modern Warfare 3


A ton of games will be supported thank for the godsend tool called SmartSteamEmu, developed by syahmixp,  grabbed from http://cs.rin.ru/forum/viewtopic.php?f=10&t=62935 
Awesome application that emulates Steam and even enables LAN connections, so we can play everything easily!