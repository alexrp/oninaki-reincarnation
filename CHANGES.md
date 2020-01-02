# Changes

This is a list of differences between the base Oninaki game and the latest
release of the Oninaki Reincarnation mod.

## Miscellaneous

* The game can now be launched without Steam running.
* Logo and DLC check screens are now skipped on startup.

## Settings

* Camera distance settings are now more pronounced, with medium now being
  equivalent to the old `Far`.
* The frame rate setting is now a choice between uncapped and 60 FPS.
* Anisotropic filtering is now enabled.
* Soft particles are now enabled.
* Max queued frames is now set to 0 for reduced input latency.
* Some minor graphics quality settings have been enabled.
* Default game settings have been changed to more sensible values.
    * Screen mode is windowed full screen.
    * Display size is 1080p.
    * Frame rate is uncapped.
    * Camera distance is medium.
    * Shadow quality is high.
    * Anti-aliasing is high.

## UI & HUD

* The location name label on the minimap is now enabled for all areas in the
  game.
* The scaling of the large minimap mode has been reduced to 2x from 3.5x in
  order to reduce screen clutter.
* Floor names in Sanctum of Rebirth are now displayed as e.g. `55F` instead of
  `Floor 55`, fixing a text overflow bug for floors over 99.
* All world locations are now accessible from the world map in Kagachi's
  timeline (after finishing the story).
* Precepts are now always displayed when crossing the veil, with the message
  duration reduced from 5s to 3s.

## Controls

* Completely removed the ability to walk in order to increase responsiveness of
  going from standing still to running.

## Loot

* The maximum number of weapons and shadestones that can be held in the
  inventory has been increased from 2000 to 10000.
* Loot collection radius has been increased from 5 to 7.5.
* Items are now lootable 0.5s after being dropped, down from 1.5s.
* Gravity of dropped items increased from 20 to 30.

## General Balance

* The arbitrary limit of 99999 on character stats (such as HP, attack, defense,
  etc) has been increased to 1000000000, which is unlikely to ever be exceeded.
* Animation speeds for staggers, knockdowns, knockbacks, etc have been tweaked
  to return control back to the player faster.
* Sheathed movement speed has been increased from 7 to 8.
* Maximum movement speed can now exceed sheathed movement speed, up to 11.
* Movement speed of party members has been increased from 6.5 to 7.5.
* Damage taken multiplier in dark veil areas has been reduced from 100x to 5x.

## Difficulty Modes

* Casual
    * Enemy attack multiplier decreased from 0.8x to 0.6x.
    * Enemy defense multiplier decreased from 1x to 0.5x.
    * Potion healing multiplier increased from 1.2x to 1.3x.
    * Item drop multiplier decreased from 1x to 0.7x.
    * AI delay multiplier decreased from 1.5x to 0.75x.
* Normal
    * AI delay multiplier decreased from 1x to 0.5x.
* Maniac
    * Enemy attack multiplier increased from 1.2x to 1.4x.
    * Potion healing multiplier decreased from 1x to 0.7x.
    * AI delay multiplier decreased from 0.8x to 0.25x.

## Daemons

* Skill costs have been overhauled.
    * Memories no longer cost soulstones.
    * Skills that used to cost 3 soulstones now cost 2.
    * Skills that used to cost 5 soulstones now cost 3.
* Normalized the movement speed multiplier to 1x for all daemons except Zephyr.
* Aisha
    * Cooldown of Dash has been reduced from 0.9s to 0.2s.
* Rigan
    * Cooldown of Roll has been reduced from 0.9s to 0.2s.
* Izana
    * Cooldown of Warp has been reduced from 1.1s to 0.4s.
* Lucika
    * Animation speed of Barrier has been increased by 2x.
* Zephyr
    * Increased the movement speed multiplier from 0.95x to 1.2x.

## Skill Awakening

* Awakening trigger cooldown reduced from 60s to 35s.
* Pinch potion amount threshold reduced from 50% to 30%.
* Pinch bonus has been increased from 2% to 3%.
* Boss bonus has been increased from 2% to 5%.
* Awakening time bonus thresholds have been changed from 2min, 5min, and 10min
  to 1min, 3min, and 5min.
* Awakening time bonuses have been changed from 0.5%, 1%, and 5% to 1%, 3%, and
  5%.

## Affinity & Manifestation

* The multiplier for damage taken that is added to the affinity gauge has been
  decreased from 0.3x to 0.1x.
* The manifestation gauge now decreases by 2% every 1s, 15s after manifesting.
* Manifestation character stats have been rebalanced to make manifestation a
  high risk, high reward action.
    * Defense multiplier decreased from 1.2x to 0.8x.
    * Healing multiplier decreased from 1.2x to 0.8x.
    * Movement speed multiplier has been increased from 1x to 1.2x.
* The leftover affinity multiplier after ending manifestation has been decreased
  from 0.5x to 0.3x.

## Weapons

* All pre-order weapons are now available in the general loot pool, and are not
  treated specially by the game.
    * Ouka-Setsugetsu
    * Emrys
    * Titan

## Bosses

* Finisher animations have been removed from all Sanctum of Rebirth bosses
  except for Tsukumo, as well as all mini-bosses such as Sight Stealers.
* Increased HP of all regular Sanctum of Rebirth bosses by 3x.
* Increased XP gain from all regular Sanctum of Rebirth bosses by 2x.
* Tsukumo
    * Increased HP by 5x.
    * Increased XP gain by 5x.
