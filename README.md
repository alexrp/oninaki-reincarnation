# Oninaki Reincarnation

A combat and post-game overhaul mod for the
[Steam version of Oninaki](https://store.steampowered.com/app/987720/ONINAKI).

The primary goal of this mod is to improve the overall pace and balance of
combat, as well as to improve and expand post-game activities. It also fixes a
number of technical and quality of life issues.

If you have played Oninaki before and thought that something was missing, or
that the potential of the game's systems was wasted, this mod is for you.

The full list of changes can be found in [`CHANGES.md`](CHANGES.md).

## Installation

To install the mod, grab the latest release from the
[releases](https://github.com/alexrp/oninaki-reincarnation/releases) page and
unzip it to `C:\Program Files (x86)\Steam\steamapps\common\ONINAKI` (or wherever
your Oninaki installation is located).

To uninstall the mod, simply instruct Steam to verify the game's files.

## Feedback & Help

Any kind of constructive feedback and/or help requests are very welcome on the
[issue tracker](https://github.com/alexrp/oninaki-reincarnation/issues) or on
our [Discord server](https://discord.gg/kMWvXbd).

## Known Issues

* Text throughout the game may have seemingly random `n` letters. This is due to
  a Unity Assets Bundle Extractor
  [bug](https://github.com/DerPopo/UABE/issues/314). This does not affect the
  game functionally.

## Modding

This section describes the process for developing Oninaki mods.

### Data Modding

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
8. Press `OK` to close the `Assets info` window.
9. Select `File` -> `Save`, navigate to your game directory, and overwrite the
   `masterdata` file there. (You may want to create a backup first.)

You can now start the game and you should see the effect(s) of any changes you
have made.

### Script Modding

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

### Script Debugging

Using the [dnSpy](dnSpy) tool, it is possible to debug the game's Unity
scripts.

To do this, you will need to overwrite the game's
`MonoBleedingEdge\EmbedRuntime\mono-2.0-bdwgc.dll` file with
[the file in this repository](dnSpy/mono-2.0-bdwgc.dll). (You may want to
create a backup first.)

Next, open up dnSpy and do the following:

1. Make sure you have the version of `Assembly-CSharp.dll` that the game is
   actually using opened.
2. Select `Debug` -> `Start Debugging...`.
3. Set `Debug engine` to `Unity`, point `Executable` to `ONINAKI.exe`, and press
   `OK`.
4. Wait for the game to get to the title screen.
5. Select `Debug` -> `Start Debugging...`.
6. Set `Debug engine` to `Unity (Connect)` and press `OK`.

If everything worked out, you should now be attached to the game. (If something
is not working, try running dnSpy as administrator.)

## Funding

I work on open source software projects such as this one in my spare time, and
make them available free of charge under permissive licenses. If you like my
work and would like to support me, you might consider [sponsoring
me](https://github.com/sponsors/alexrp). Please only donate if you want to and
have the means to do so; I want to be very clear that all open source software I
write will always be available for free and you should not feel obligated to
donate or pay for it in any way.
