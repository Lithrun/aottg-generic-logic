Welcome to the basics of the Generic Custom logic. Here it will be explained how the basics of the custom logic work. Configuration and the available commands will be discussed. If you wish to learn more advanced stuff, please check out the: https://github.com/Nickernator/aottg-generic-logic/blob/master/ADVANCED.md page.

# Understanding the variables

Within custom logic there are several types. It is very important that you understand those correctly, as the slighest mistake will break your logic.

* VariableString - A variable string is a string, which means that you place some text between quotes " ".
* VariableInt - An int (integer) is a number. This number cannot have any decimals in it.
* VariableFloat - A float is a decimal. A float must always have a decimal in it. A float with the value of 10 will break your logic, while 10.0 will not.
* VariableBool - A bool stands for boolean, and this is a type that is either true or false.
* VariablePlayer - Player data is saved within this variable
* VariableTitan - Titan data is saved within this variable

**Variables names are case sensitive, so keep that in mind!**

# Configuration

The generic custom logic has a lot of configuration available for you. It consists of multiple sections marked with // -- in the comments of the file. All configuration is within the OnRoundStart() method.


## Expedition Difficulty

Expedition difficulty increases several factors of titans that are spawned. There are three difficulties: Easy (0), Normal (1) and Hard (2). The default is Normal.

These factors are: Titan Health, Speed, Regen Speed, Regen Limit, Amount of titans that are spawned and the view distance of titans. With difficulty normal, the settings defined as in the configuration are used. With Easy and Hard, some factors are applied.

The variables have a number behind their name, this number represents the difficulty.
HealthFactor0, 0.4 means that titans on Easy Difficulty only have 40% of their normal HP
HealthFactor2, 1.5 means that ttans on Hard Difficulty have 50% extra HP.

## Toggable settings

Toggable settings are settings that can be enabled / disabled while you are within game. You can modify these however to change their default value.

* EnablePlayerScaling - Player scaling is an advanced technique that increases the amount of titans based on the total amount of players
* EnableRandomTitanAnimation - Within the latest Expedition Mod update, it became possible to modify the animation speed of titans. With enabling this setting, every titan will have a random animation speed.
* EnableRandomTitanSpeed - With this setting enabled, titans will have a randomized speed instead of a fixed one
* EnableRandomTitanSkins - Titans will have a random body & eye skin combination. It's recommended to enable this feature as it allows unique titans
* EnableTitanHealth - With this setting titans will have health.
* EnableTitanRegeneration - In combination with Health enabled, if a titan loses health, it will regenerate it's health back until a fixed amount.
* EnableTitanViewDistance - This enables titan view distance. It's only of use if you don't play on wave modes.

## Start message

At start message you can define some messages that you want to show to your players. A welcome message, map and logic version as well with some credits are often placed here.

## Timer message

These values influence the /timer and /start message. Every second, a message get's displayed in order of lowest to highest.

## Titan Settings

Within the configuration, the most settings are ofcourse related to the titans.

TITAN TYPE: 0 = normie, 1 = abby, 2 = jumper, 3 = crawler, 4 = punk
TITAN CLASS: 0 = small, 1 = medium, 2 = large, 3 = extreme

TitanTypeX = The chance that this titan type spawns
TitanClass_ChanceX = the chance for this class to spawn

*After the following variables is a numer. This number represents the titan class*
Min size = the minumun size of this titan class
Max size = the maximun size of this titan class
HP Min = the minumun HP this class has
HP Max = the maximun HP this class has
Speed Min = Randomize how much less speed this class can have
Speed Max = Randomize how much more speed this class can have
Regen limit = the max HP this titan class can regenerate to
Regen ticks = the amount of HP this titan class will regenarate per second
Min Animation = the minumun Animation Speed this class has
Max Animation = the maximun Animation Speed this class has
View Distance = the view distance this class has

Titan eye = A random eye skin that may be chosen
Titan skin = A random body skin that may be chosen
