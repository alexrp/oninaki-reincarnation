# Oninaki Reincarnation

[![Discord Server](https://discordapp.com/api/guilds/660373899388780546/widget.png)](https://discord.gg/kMWvXbd)

A combat and post-game overhaul mod for the [Steam version of
Oninaki](https://store.steampowered.com/app/987720/ONINAKI).

## Data Modding

The vast majority of the game is configurable through the data stored in the
`ONINAKI_Data\StreamingAssets\STEAM\common\masterdata` file. The contents of
this file have been dumped as JSON in the
[`Assets\common\masterdata`](Assets/common/masterdata) directory in this
repository, and this is where most modding takes place for this mod. You can
freely edit these files to experiment with modding the game's parameters.

When you want to actually test your changes in the game, you need to use the
[Unity Assets Bundle Extractor](UABE) tool as follows:

1. Select `File` -> `Open` and open the
   [`masterdata.decomp`](Assets/common/masterdata.decomp) file in this
   repository.
2. Press the `Info` button.
3. Select `Tools` -> `Get script information` and open the
   [`Assembly-CSharp.dll`](Code/Assembly-CSharp.dll) file in this repository.
4. Wait for the console window that appears to close.
5. Select all items in the `Assets` box.
6. Press `Import Dump` and open the [`masterdata`](Assets/common/masterdata)
   directory in this repository.
7. Press `OK` to start the import. (This can take a bit.)
8. Select `File` -> `Save`.
9. Close the `Assets info` window.
10. Select `File` -> `Save`, navigate to your game directory, and overwrite the
    `masterdata` file there. (You may want to create a backup first.)

You can now start the game and you should see the effect(s) of any changes you
have made.

## Script Modding

Those aspects of the game that cannot be changed through data modding can
almost certainly be changed by modifying the game's code (Unity scripts). These
are compiled into the `ONINAKI_Data\Managed\Assembly-CSharp.dll` file.

The modded version of this file is in the [`Code`](Code) directory in this
repository.

Modding this file is a bit trickier; it will require C# and possibly CIL
knowledge. You will need to use the [dnSpy](dnSpy) tool as follows:

1. Select `File` -> `Open` and open the
   [`Assembly-CSharp.dll`](Code/Assembly-CSharp.dll) file in this repository.
2. Make any modifications you wish.
3. Select `File` -> `Save Module...`, navigate to your game directory, and
   overwrite the `Assembly-CSharp.dll` file there. (You may want to create a
   backup first.)

You can now start the game and you should see the effect(s) of any changes you
have made.

## Script Debugging

Using the [dnSpy](dnSpy) tool, it is possible to debug the game's Unity
scripts.

To do this, you will need to overwrite the game's
`MonoBleedingEdge\EmbedRuntime\mono-2.0-bdwgc.dll` file with
[the file in this repository](dnSpy/mono-2.0-bdwgc.dll). (You may want to
create a backup first.)

Next, open up dnSpy and do the following:

* Make sure you have the version of `Assembly-CSharp.dll` that the game is
  actually using opened.
* Select `Debug` -> `Start Debugging...`.
* Set `Debug engine` to `Unity`, point `Executable` to `ONINAKI.exe`, and press
  `OK`.
* Wait for the game to get to the title screen.
* Select `Debug` -> `Start Debugging...`.
* Set `Debug engine` to `Unity (Connect)` and press `OK`.

If everything worked out, you should now be attached to the game. (If something
is not working, try running dnSpy as administrator.)
