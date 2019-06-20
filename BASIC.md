Welcome to the basics of the Generic Custom logic. Here it will be explained how the basics of the custom logic work. Configuration and the available commands will be discussed. If you wish to learn more advanced stuff, please check out the: https://github.com/Nickernator/aottg-generic-logic/blob/master/ADVANCED.md page.

# Understanding the variables

Within custom logic there are several types. It is very important that you understand those correctly, as the slighest mistake will break your logic.

VariableString - A variable string is a string, which means that you place some text between quotes " ".
VariableInt - An int (integer) is a number. This number cannot have any decimals in it.
VariableFloat - A float is a decimal. A float must always have a decimal in it. A float with the value of 10 will break your logic, while 10.0 will not.
VariableBool - A bool stands for boolean, and this is a type that is either true or false.
VariablePlayer - Player data is saved within this variable
VariableTitan - Titan data is saved within this variable

**Variables are case sensitive, so keep that in mind!**

# Configuration

The generic custom logic has a lot of configuration available for you. It consists of multiple sections marked with // -- in the comments of the file. All configuration is within the OnRoundStart() method.


## Expedition Difficulty

Expedition difficulty increases several factors of titans that are spawned. There are three difficulties: Easy (0), Normal (1) and Hard (2). The default is Normal.

These factors are: Titan Health, Speed, Regen Speed, Regen Limit, Amount of titans that are spawned and the view distance of titans. With difficulty normal, the settings defined as in the configuration are used. With Easy and Hard, some factors are applied.

The variables have a number behind their name, this number represents the difficulty.
HealthFactor0, 0.4 means that titans on Easy Difficulty only have 40% of their normal HP
HealthFactor2, 1.5 means that ttans on Hard Difficulty have 50% extra HP.
