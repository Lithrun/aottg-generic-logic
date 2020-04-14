// Generic custom logic v10 by Erwin Smith#6637 / Lithrun
// This logic was made for the Expeditions Beyond the Walls community (https://discord.gg/Xd9sS8J)
// Made with love, patience and chocolate milk <3
// Latest version available at: https://github.com/Lithrun/aottg-generic-logic

// TERMS AND CONDITIONS
// 1. Do not alter the OnRoundStart message. The people worked hard on this logic, and removing their effort is disrespectfull.
// 2. You're free to modify this logic based on your needs. It is advised however to only modify the OnRoundStart and adding additional commands at the OnChatInput
// 3. For code improvements and new featuers, please pop a pull request at https://github.com/Lithrun/aottg-generic-logic

OnRoundStart()
{
// -- CONFIGURE THESE SETTINGS TO YOUR OWN PREFERENCE --

  // EXPEDITION DIFFICULTY - 0 = easy, 1 = normal, 2 = hard. See --Expedition Difficulty Settings-- to change factors.
  VariableInt.Set("ExpeditionDifficulty", 1);
  
  // -- TOGGABLE SETTINGS --
  VariableBool.Set("EnablePlayerScaling", false); // Default true
  VariableBool.Set("EnableRandomTitanAnimation", false); // Default false
  VariableBool.Set("EnableRandomTitanSpeed", true); // Default true
  VariableBool.Set("EnableRandomTitanSkins", true); // Default true
  VariableBool.Set("EnableTitanHealth", true); // Default true
  VariableBool.Set("EnableTitanRegeneration", false); // Default false
  VariableBool.Set("EnableTitanViewDistance", false); // Default false
  VariableBool.Set("EnableAntiSkating", true); // Default true
  VariableBool.Set("EnableWagonNuke", false); // While set to true, everyone will die once the MC dies

// Credits message. Do not alter.
  Game.PrintMessage("<size=15><color=#2ecc71>Generic logic v10 loaded</color></size>");
  Game.PrintMessage("<size=12><color=#123456>Created with passion and love by Erwin Smith#6637</color></size>");
  Game.PrintMessage("<size=12><color=#654321>Special thanks to Syeo Potato Axel Tic & Marazul</color></size>");   
 
// Timer message - Credits to Potato
  VariableString.Set("0", "<b><color=#00FF00>[Commander]</color>: Advance  In 10 Seconds!</b>");
  VariableString.Set("1", "<b>  10</b>");
  VariableString.Set("2", "<b>  9</b>");
  VariableString.Set("3", "<b>  8</b>");
  VariableString.Set("4", "<b>  7</b>");
  VariableString.Set("5", "<b>  6</b>");
  VariableString.Set("6", "<b>  5</b>");
  VariableString.Set("7", "<b>  4</b>");
  VariableString.Set("8", "<b>  3</b>");
  VariableString.Set("9", "<b>  2</b>");
  VariableString.Set("10", "<b>  1</b>");
  VariableString.Set("11", "<b><color=#00FF00>[Commander]</color>: All Soldiers! Advance!!!</b>"); 

  // -- TITAN SETTINGS --
  
  // TITAN TYPE: 0 = normie, 1 = abby, 2 = jumper, 3 = crawler, 4 = punk
  // TITAN CLASS: 0 = small, 1 = medium, 2 = large, 3 = extreme
  
  // TitanTypeX = The chance that this titan type spawns
  // TitanClassX_Chance = the chance for this class to spawn
  // Min size = the minumun size of this titan class
  // Max size = the maximun size of this titan class
  // HP Min = the minumun HP this class has
  // HP Max = the maximun HP this class has
  // Speed Min = Randomize how much less speed this class can have
  // Speed Max = Randomize how much more speed this class can have
  // Regen limit = the max HP this titan class can regenerate to
  // Regen ticks = the amount of HP this titan class will regenarate per second
  // Min Animation = the minumun Animation Speed this class has
  // Max Animation = the maximun Animation Speed this class has
  // Titan eye = A random eye skin that may be chosen
  // Titan skin = A random body skin that may be chosen
  
  // -- TITAN TYPE CHANCES --
  VariableInt.Set("TitanType0", 1); // Default 15 - 0 = 15 percentage chance
  VariableInt.Set("TitanType1", 50); // Default 50 - 15 = 35 percentage chance
  VariableInt.Set("TitanType2", 82); // Default 75 - 50 = 25 percentage chance
  VariableInt.Set("TitanType3", 83); // Default 83 - 75 = 8 percentage chance
  VariableInt.Set("TitanType4", 100); // Default 100 - 83 = 17 percentage chance
  
  // -- TITAN CLASS TYPES --
  VariableInt.Set("TitanClass_Chance0", 3); // Default 10 - 0 = 10 percentage chance
  VariableInt.Set("TitanClass_Chance1", 25); // Default 45 - 10 = 35 percentage chance
  VariableInt.Set("TitanClass_Chance2", 95); // Default 95 - 45 = 50 percentage chance
  VariableInt.Set("TitanClass_Chance3", 100); // Default 100 - 95 = 5 percentage chance
  
  // -- TITAN CLASS SMALL --  
  VariableFloat.Set("TitanClass_MinSize0", 1.5); // Default 1.5
  VariableFloat.Set("TitanClass_MaxSize0", 2.1); // Default 2.1
  
  VariableInt.Set("TitanClass_HPMin0", 200); // Default 200
  VariableInt.Set("TitanClass_HPMax0", 500); // Default 500
  
  VariableInt.Set("TitanClass_MinSpeed0", -5); // Default -5
  VariableInt.Set("TitanClass_MaxSpeed0", 5); // Default 5
  
  VariableInt.Set("TitanClass_RegenLimit0", 500); // Default 500
  VariableInt.Set("TitanClass_RegenTicks0", 1);  // Default 1
  
  VariableFloat.Set("TitanClass_MinAnimation0", 1.0); // Default 1.0
  VariableFloat.Set("TitanClass_MaxAnimation0", 1.0); // Default 1.0
  
  VariableInt.Set("TitanClass_ViewDistance0", 1250); // Default 1250
  
    // -- TITAN CLASS Medium --
  VariableFloat.Set("TitanClass_MinSize1", VariableFloat("TitanClass_MaxSize0"));
  VariableFloat.Set("TitanClass_MaxSize1", 3.5); // Default 3.5
  
  VariableInt.Set("TitanClass_HPMin1", 500); // Default 500
  VariableInt.Set("TitanClass_HPMax1", 700); // Default 700
  
  VariableInt.Set("TitanClass_MinSpeed1", -10); // Default -10
  VariableInt.Set("TitanClass_MaxSpeed1", 10); // Default 10
  
  VariableInt.Set("TitanClass_RegenLimit1", 1000); // Default 1000
  VariableInt.Set("TitanClass_RegenTicks1", 2); // Default 2
  
  VariableFloat.Set("TitanClass_MinAnimation1", 1.0); // Default 1.0
  VariableFloat.Set("TitanClass_MaxAnimation1", 1.0); // Default 1.0
  
  VariableInt.Set("TitanClass_ViewDistance1", 2500); // Default 2500
  
    // -- TITAN CLASS Large --
  VariableFloat.Set("TitanClass_MinSize2", VariableFloat("TitanClass_MaxSize1"));
  VariableFloat.Set("TitanClass_MaxSize2", 4.1); // Default 4.1
  
  VariableInt.Set("TitanClass_HPMin2", 700); // Default 700
  VariableInt.Set("TitanClass_HPMax2", 900); // Default 900
  
  VariableInt.Set("TitanClass_MinSpeed2", -10); // Default -10
  VariableInt.Set("TitanClass_MaxSpeed2", 10); // Default 10
  
  VariableInt.Set("TitanClass_RegenLimit2", 1500); // Default 1500
  VariableInt.Set("TitanClass_RegenTicks2", 5); // Default 5
  
  VariableFloat.Set("TitanClass_MinAnimation2", 1.0); // Default 1.0
  VariableFloat.Set("TitanClass_MaxAnimation2", 1.0); // Default 1.0
  
  VariableInt.Set("TitanClass_ViewDistance2", 4000); // Default 4000
  
    // -- TITAN CLASS Extreme --
  VariableFloat.Set("TitanClass_MinSize3", VariableFloat("TitanClass_MaxSize2"));
  VariableFloat.Set("TitanClass_MaxSize3", 6.0); // Default 6.0
  
  VariableInt.Set("TitanClass_HPMin3", 1000); // Default 1000
  VariableInt.Set("TitanClass_HPMax3", 1500); // Default 1500
  
  VariableInt.Set("TitanClass_MinSpeed3", -10); // Default -10
  VariableInt.Set("TitanClass_MaxSpeed3", 10); // Default 10
  
  VariableInt.Set("TitanClass_RegenLimit3", 5000); // Default 5000
  VariableInt.Set("TitanClass_RegenTicks3", 10); // Default 10
  
  VariableFloat.Set("TitanClass_MinAnimation3", 1.0); // Default 1.0
  VariableFloat.Set("TitanClass_MaxAnimation3", 1.0); // Default 1.0
  
  VariableInt.Set("TitanClass_ViewDistance3", 6000); // Default 6000
  
  // -- TITAN SKINS --
  
  // Titan Eyes
  VariableInt.Set("TitanEyes", 24); // total eye skins + 1
  VariableString.Set("Titan_Eye", "");
 
  VariableString.Set("TitanEye1", "https://i[d]imgur[d]com/M46iSTN[d]png");
  VariableString.Set("TitanEye2", "https://i[d]imgur[d]com/wWyInov[d]png");
  VariableString.Set("TitanEye3", "https://i[d]imgur[d]com/nsicIz4[d]png");
  VariableString.Set("TitanEye4", "https://i[d]imgur[d]com/yUfAQYj[d]png");
  VariableString.Set("TitanEye5", "https://i[d]imgur[d]com/qCw4nMn[d]png");
  VariableString.Set("TitanEye6", "https://i[d]imgur[d]com/gvb3sXU[d]png");
  VariableString.Set("TitanEye7", "https://i[d]imgur[d]com/oOHxljH[d]png");
  VariableString.Set("TitanEye8", "https://i[d]imgur[d]com/1P3OlhG[d]png");
  VariableString.Set("TitanEye9", "https://i[d]imgur[d]com/4uiRysJ[d]png");
  VariableString.Set("TitanEye10", "https://i[d]imgur[d]com/IMWBdYD[d]png");
  VariableString.Set("TitanEye11", "https://i[d]imgur[d]com/RLOsdR1[d]png");
  VariableString.Set("TitanEye12", "https://i[d]imgur[d]com/iuoGmvH[d]png");
  VariableString.Set("TitanEye13", "https://i[d]imgur[d]com/oCIx7eT[d]png");
  VariableString.Set("TitanEye14", "https://i[d]imgur[d]com/RZmgVUO[d]png");
  VariableString.Set("TitanEye15", "https://i[d]imgur[d]com/7OLuuAG[d]png");
  VariableString.Set("TitanEye16", "https://i[d]imgur[d]com/kexoLC3[d]png");
  VariableString.Set("TitanEye17", "https://i[d]imgur[d]com/zxyZIqs[d]png");
  VariableString.Set("TitanEye18", "https://i[d]imgur[d]com/Bdo948X[d]png");
  VariableString.Set("TitanEye19", "https://i[d]imgur[d]com/UnHQSzy[d]png");
  VariableString.Set("TitanEye20", "https://i[d]imgur[d]com/vehpqWR[d]png");
  VariableString.Set("TitanEye21", "https://i[d]imgur[d]com/tCoMbY1[d]png");
  VariableString.Set("TitanEye22", "https://i[d]imgur[d]com/RjjvCW8[d]png");
  VariableString.Set("TitanEye23", "https://i[d]imgur[d]com/gUnCyHr[d]png");
  VariableString.Set("TitanEye24", "");
  VariableString.Set("TitanEye25", "");

  // Titan bodies
  VariableInt.Set("TitanSkins", 14); // Total body skins + 1
  VariableString.Set("Titan_Skin", "");
  
  VariableString.Set("TitanSkin1", "https://i[d]imgur[d]com/C6pqM6h[d]png");
  VariableString.Set("TitanSkin2", "https://i[d]imgur[d]com/NmAlltS[d]png");
  VariableString.Set("TitanSkin3", "https://i[d]imgur[d]com/vJflnpT[d]png");
  VariableString.Set("TitanSkin4", "https://i[d]imgur[d]com/KoTo8O6[d]jpg");
  VariableString.Set("TitanSkin5", "https://i[d]imgur[d]com/EyQ7gQQ[d]jpg");
  VariableString.Set("TitanSkin6", "https://i[d]imgur[d]com/9jN6rBK[d]png");
  VariableString.Set("TitanSkin7", "https://i[d]imgur[d]com/xaBLbqC[d]jpg");
  VariableString.Set("TitanSkin8", "https://i[d]imgur[d]com/GPLE4hG[d]png");
  VariableString.Set("TitanSkin9", "https://i[d]imgur[d]com/Zz7CXR0[d]png");
  VariableString.Set("TitanSkin10", "https://i[d]imgur[d]com/BnMmaJN[d]png");
  VariableString.Set("TitanSkin11", "https://i[d]imgur[d]com/J3K2Cam[d]png");
  VariableString.Set("TitanSkin12", "https://i[d]imgur[d]com/B9ItWAb[d]png");
  VariableString.Set("TitanSkin13", "https://i[d]imgur[d]com/rpmDZvX[d]jpg");
  VariableString.Set("TitanSkin14", "");
  VariableString.Set("TitanSkin15", "");
  VariableString.Set("TitanSkin16", "");
  VariableString.Set("TitanSkin17", "");
  VariableString.Set("TitanSkin18", "");
  
  // -- OTHER TITAN SETTINGS --
  VariableInt.Set("SpawnTitansAtRegionAmount", 10); // How many titans will spawn at /titans command. Uses player scaling!
  
  // -- EXPEDITION DIFFICULTY SETTINGS --
   
  // -- Difficulty easy --
  VariableFloat.Set("HealthFactor0", 0.4);
  VariableFloat.Set("SpeedFactor0", 0.8);
  VariableFloat.Set("RegenSpeedFactor0", 0.5);
  VariableFloat.Set("RegenLimitFactor0", 0.7);
  VariableFloat.Set("TitanAmountFactor0", 0.8);
  VariableFloat.Set("ViewDistanceFactor0", 0.8);
  
    // -- Difficulty normal --
  VariableFloat.Set("HealthFactor1", 1.0);
  VariableFloat.Set("SpeedFactor1", 1.0);
  VariableFloat.Set("RegenSpeedFactor1", 1.0);
  VariableFloat.Set("RegenLimitFactor1", 1.0);
  VariableFloat.Set("TitanAmountFactor1", 1.0);
  VariableFloat.Set("ViewDistanceFactor1", 1.0);
  
    // -- Difficulty hard --
  VariableFloat.Set("HealthFactor2", 1.4);
  VariableFloat.Set("SpeedFactor2", 1.3);
  VariableFloat.Set("RegenSpeedFactor2", 4.0);
  VariableFloat.Set("RegenLimitFactor2", 1.7);
  VariableFloat.Set("TitanAmountFactor2", 1.2);
  VariableFloat.Set("ViewDistanceFactor2", 2.0);
  
  // Titan speed default values
  // Speed = X * size + Z
  VariableFloat.Set("TitanSpeedX0", 2.171); // Default 2.371
  VariableFloat.Set("TitanSpeedZ0", 6.900); // Default 6.900
  VariableFloat.Set("TitanSpeedX1", 7.054); // Default 7.254
  VariableFloat.Set("TitanSpeedZ1", 28.03); // Default 20.03
  VariableFloat.Set("TitanSpeedX2", 7.054); // Default 7.254
  VariableFloat.Set("TitanSpeedZ2", 28.03); // Default 20.03
  VariableFloat.Set("TitanSpeedX3", 10.22); // Default 14.22
  VariableFloat.Set("TitanSpeedZ3", 48.47); // Default 40.47
  VariableFloat.Set("TitanSpeedX4", 7.054); // Default 7.254
  VariableFloat.Set("TitanSpeedZ4", 28.03); // Default 20.03
  
  // -- SCORE VARIABLES --
  VariableInt.Set("TimePoints", -1); // -1 point / time
  VariableInt.Set("RevivePoints", -25); // -25 points / revive
  VariableInt.Set("KillPoints", 50); // 10 points / kill
  VariableInt.Set("DeathPoints", -25); // -25 points / death
  VariableInt.Set("ObjectivePoints", 1000); // 1000 points / objective
  VariableInt.Set("BonusObjectivePoints", 500); // 500 points / objective
  
  // -- PLAYER SCALING --
  VariableFloat.Set("PlayerFactorSmall", 0.7); // Less than 10 players
  VariableFloat.Set("PlayerFactorMedium", 1.0); // 10 to 15 players
  VariableFloat.Set("PlayerFactorLarge", 1.2); // 15 to 20 players
  VariableFloat.Set("PlayerFactorExtreme", 1.5); // 20+
  
  // END OF CONFIGURABLE SETTINGS IGNORE THE SETTINGS BELOW UNLESS YOU KNOW WHAT YOU ARE DOING
  
  VariableBool.Set("CountDown", false);
  
  VariablePlayer.Set("MCPlayer", VariablePlayer("null")); // MC player
  VariablePlayer.Set("EPlayer", VariablePlayer("null")); // Player Collection Variable 
  VariablePlayer.Set("CPlayer", VariablePlayer("null"));
  
  VariableInt.Set("Score", 0); // The total score
  
  VariableBool.Set("Timer", false);
  VariableInt.Set("Time", 0); // Total time
  VariableInt.Set("Revives", 0); // Total amount of revives
  VariableInt.Set("Kills", 0); // Total kills
  VariableInt.Set("Objectives", 0); // Total objectives completed
  VariableInt.Set("BonusObjectives", 0); // Total objectives completed
   
  // Revive cords
  VariableFloat.Set("Revive_X", 0.0); // used for /reviveatpos
  VariableFloat.Set("Revive_Y", 0.0); // used for /reviveatpos
  VariableFloat.Set("Revive_Z", 0.0); // used for /reviveatpos
  
  // Region cords
  VariableFloat.Set("X+", 2500.0); // positive X
  VariableFloat.Set("X-", -2500.0); // negative X
  VariableFloat.Set("Y+", 2500.0); // positive Y
  VariableFloat.Set("Y-", -2500.0); // negative Y
  
  // Safety region cords - no titans will spawn within this range
  VariableFloat.Set("SafetyX+", 400.0); // positive X
  VariableFloat.Set("SafetyX-", -400.0); // negative X
  VariableFloat.Set("SafetyY+", 400.0); // positive Y
  VariableFloat.Set("SafetyY-", -400.0); // negative Y
  
  // Titan variables - ommit default values otherwise NullReferrenceExceptions!
  VariableFloat.Set("Titan_X", 0.0); // titan X cord
  VariableFloat.Set("Titan_Y", 0.0); // titan Y cord
  VariableFloat.Set("Titan_Z", 0.0); // titan Z cord
  VariableInt.Set("Titan_Type", 0); // 0 - normie, 1 abby, 2 jump, 3 crawler, 4 punk
  VariableInt.Set("Titan_Class", 0); // 0 - small, 1 - medium, 2 - large, 3 - extreme
  VariableFloat.Set("Titan_Size", 1.0); // 1 - 1000
  VariableInt.Set("Titan_HP", 0);
  VariableInt.Set("Titan_Speed", 0);
  VariableFloat.Set("Titan_Animation", 1.0);
  VariableInt.Set("Titan_ViewDistance", 2500);
  VariableInt.Set("TitanAmount", 0);
  
  // Titan difficulty
  VariableFloat.Set("HealthFactor", 1.0);
  VariableFloat.Set("SpeedFactor", 1.0);
  VariableFloat.Set("RegenLimitFactor", 1.0);
  VariableFloat.Set("RegenSpeedFactor", 1.0);
  VariableFloat.Set("TitanAmountFactor", 1.0);
  VariableFloat.Set("ViewDistanceFactor", 1.0);
  
  VariableString.Set("Message", "");
  
  // Player balance
  VariableInt.Set("TotalPlayers", 0);
  VariableInt.Set("TotalPlayersTimer", 0);   
  VariableFloat.Set("PlayerFactor", 1.0); // Default 1.0
  
  // Auto player revive
  VariableBool.Set("AutoPosRevive", false);
  VariableInt.Set("AutoPosReviveTimer", 0);
  VariableInt.Set("AutoPosReviveTimeLimit", 30); // Auto revive every 30s
   
  // V6 additions
  
  VariableBool.Set("SetVariableNameValue", false);
  VariableBool.Set("SetVariableTypeValue", false);
  VariableBool.Set("SetVariable", false);
  VariableString.Set("SetVariableName", "");
  VariableInt.Set("SetVariableType", 0); // 0 = integer, 1 = boolean, 2 = string, 3 = float
  
  VariableString.Set("SetVariableName", "WhileCommand");
  
  VariableInt.Set("GateHeight", 60);
  
  // V8 additions 
  VariableFloat.Set("SpeedCounterLimit", 7.0);
  VariableFloat.Set("SpeedCounter", 0.0);
  
  VariableFloat.Set("SpeedMeter0", 0.0);
  VariableFloat.Set("HeightMeter0", 0.0);
  
    VariableFloat.Set("radius", 100.0);
    VariableInt.Set("revTime", 5);
    VariableInt.Set("deathTime", 120);
    VariableInt.Set("cooldown", 30);
    VariableInt.Set("counterMain", 0);
    VariableInt.Set("cooldown0", 0);
    VariableInt.Set("cooldown1", 0);
    VariableInt.Set("cooldown2", 0);
    VariableInt.Set("cooldown3", 0);
    VariableInt.Set("cooldown4", 0);
    VariableInt.Set("cooldown5", 0);
    VariableInt.Set("cooldown6", 0);
    VariableInt.Set("cooldown7", 0);
    VariableInt.Set("cooldown8", 0);
    VariableInt.Set("cooldown9", 0);
    VariableInt.Set("cooldown10", 0);
    VariableInt.Set("cooldown11", 0);
    VariableInt.Set("cooldown12", 0);
    VariableInt.Set("cooldown13", 0);
    VariableInt.Set("cooldown14", 0);
    VariableInt.Set("cooldown15", 0);
    VariableInt.Set("cooldown16", 0);
    VariableInt.Set("cooldown17", 0);
    VariableInt.Set("cooldown18", 0);
    VariableInt.Set("cooldown19", 0);
    VariableInt.Set("cooldown20", 0);
    VariableInt.Set("cooldown21", 0);
    VariableInt.Set("cooldown22", 0);
    VariableInt.Set("cooldown23", 0);
    VariableInt.Set("cooldown24", 0);
    VariableInt.Set("cooldown25", 0);
    VariableInt.Set("cooldown26", 0);
    VariableInt.Set("cooldown27", 0);
    VariableInt.Set("cooldown28", 0);
    VariableInt.Set("cooldown29", 0);
VariableInt.Set("cooldown30", 0);
VariableInt.Set("cooldown31", 0);
VariableInt.Set("cooldown32", 0);
VariableInt.Set("cooldown33", 0);
VariableInt.Set("cooldown34", 0);
VariableInt.Set("cooldown35", 0);
VariableInt.Set("cooldown36", 0);
VariableInt.Set("cooldown37", 0);
VariableInt.Set("cooldown38", 0);
VariableString.Concat("radiusWhat", "<size=10>revive</size><size=1>___</size><size=10>radius</size><size=1>___</size><size=10>is</size><size=1>___</size>","<size=12><color=#ff4444>", VariableFloat("radius").ConvertToString(),"</color></size>", "<size=1>___</size><size=10>meters</size>");
Game.PrintMessage(VariableString("radiusWhat"));
VariableString.Concat("revTimeWhat", "<size=10>revive</size><size=1>___</size><size=10>time</size><size=1>___</size><size=10>is</size><size=1>___</size>","<size=12><color=#ff4444>", VariableInt("revTime").ConvertToString(),"</color></size>", "<size=1>___</size><size=10>seconds</size>");
Game.PrintMessage(VariableString("revTimeWhat"));
VariableString.Concat("deathWhat", "<size=10>death</size><size=1>___</size><size=10>time</size><size=1>___</size><size=10>is</size><size=1>___</size>","<size=12><color=#ff4444>", VariableInt("deathTime").ConvertToString(),"</color></size>", "<size=1>___</size><size=10>seconds</size>");
Game.PrintMessage(VariableString("deathWhat"));
VariableString.Concat("cooldownWhat", "<size=10>cooldown</size><size=1>___</size><size=10>time</size><size=1>___</size><size=10>is</size><size=1>___</size>","<size=12><color=#ff4444>", VariableInt("cooldown").ConvertToString(),"</color></size>", "<size=1>___</size><size=10>seconds</size>");
Game.PrintMessage(VariableString("cooldownWhat"));

//V9 automatic titans
VariableBool.Set("EnableAutoTitans", false);
VariableInt.Set("AutoTitanLimit", 35); // limit of auto titans
VariableInt.Set("AutoTitanAmount", 3); // How many titans should spawn per interval
VariableInt.Set("AutoTitanInterval", 15); // AutoTitanAmount titans will spawn every X seconds
VariableInt.Set("AutoTitanCounter", 0);

//V10 boss update

VariableFloat.Set("UnkillableTitanSize", 4.50001);
VariableInt.Set("UnkillableTitanHealth", 3000);

VariableFloat.Set("SantaSize", 4.50002);
VariableInt.Set("SantaCounter", 0);

VariableFloat.Set("ColossalSize", 60.00001);
VariableInt.Set("ColossalCounter", 90);
VariableInt.Set("ColossalExplosionCounter", 0);
VariableInt.Set("ColossalExplosionCounterLimit", 120); // After how many seconds will the colossal explode
VariableInt.Set("ColossalExplosionLimit", 30); // How many explosions will the colossal cause

VariableFloat.Set("BeastSize", 4.50003);
VariableInt.Set("BeastCounter", 35);
VariableInt.Set("BeastCounterLimit", 60); // After how many seconds will the beast throw

VariableInt.Set("BeastRockCounter", 0);
VariableInt.Set("BeastRockLimit", 5); // After how many seconds will the beast do another volley

VariableInt.Set("BeastRockVolleyCounter", 0);
VariableInt.Set("BeastRockVolleyLimit", 4); // How many volleys will the beast titan do

VariableInt.Set("BeastRocks", 200); // How rocks will the beast throw per volley

VariableFloat.Set("SantaSize", 4.50002);
VariableInt.Set("SantaCounter", 0);

VariableInt.Set("WagonNukeCounter", 10);
VariableBool.Set("DestroyLife", false);

Game.PrintMessage("EM/Commands//startup"); // Execute a few commands on start up
}

// Titan kill count
OnTitanDie("DeadTitan", "MurdererPlayer")
{
VariableInt.Add("Kills", 1);
}

OnUpdate()
{

// Auto titan spawner
If(Bool.Equals(VariableBool("EnableAutoTitans"), true))
{
VariableInt.Add("AutoTitanCounter", 1);
If(VariableInt.GreaterThanOrEqual(VariableInt("AutoTitanCounter"), VariableInt("AutoTitanInterval")))
{
VariableInt.Set("TotalTitans", 0);
ForeachTitan("ATT")
{
VariableInt.Add("TotalTitans", 1);
}
If(VariableInt.LessThanOrEqual(VariableInt("TotalTitans"), VariableInt("AutoTitanLimit")))
{
VariableString.Concat("Command", "EM/Commands//titans", VariableInt("AutoTitanAmount").ConvertToString());
Game.PrintMessage(VariableString("Command"));
VariableInt.Set("AutoTitanCounter", 0);
}
}
}

// Titan regeneration
If(Bool.Equals(VariableBool("EnableTitanRegeneration"), true))
{

VariableString.Concat("RegenLimitF", "RegenLimitFactor", VariableInt("ExpeditionDifficulty").ConvertToString());
VariableString.Concat("RegenSpeedF", "RegenLimitFactor", VariableInt("ExpeditionDifficulty").ConvertToString());
ForeachTitan("RTitan")
{

VariableInt.Set("TitanHP", VariableTitan("RTitan").GetHealth());
VariableFloat.Set("TitanSize", VariableTitan("RTitan").GetSize());
// Titan class small
If(Float.LessThan(VariableFloat("TitanSize"), VariableFloat("TitanClass_MaxSize0")))
{

VariableFloat.Set("RegenLimitFactor", VariableFloat(VariableString("RegenLimitF")));
VariableFloat.Multiply("RegenLimitFactor", VariableInt("TitanClass_RegenLimit0").ConvertToFloat());
VariableInt.Set("TitanClass_RegenLimit", VariableFloat("RegenLimitFactor").ConvertToInt());

If(Int.LessThan(VariableInt("TitanHP"), VariableInt("TitanClass_RegenLimit")))
{
VariableInt.Set("TitanHP", VariableTitan("RTitan").GetHealth());

VariableFloat.Set("RegenSpeedFactor", VariableFloat(VariableString("RegenSpeedF")));
VariableFloat.Multiply("RegenSpeedFactor", VariableInt("TitanClass_RegenTicks0").ConvertToFloat());
VariableInt.Set("TitanClass_RegenTicks", VariableFloat("RegenSpeedFactor").ConvertToInt());

VariableInt.Add("TitanHP", VariableInt("TitanClass_RegenTicks"));
Titan.SetHealth(VariableTitan("RTitan"), VariableInt("TitanHP"));
}
}

// titan class medium
If(Float.GreaterThanOrEqual(VariableFloat("TitanSize"), VariableFloat("TitanClass_MinSize1")))
{
If(Float.LessThan(VariableFloat("TitanSize"), VariableFloat("TitanClass_MaxSize1")))
{

VariableFloat.Set("RegenLimitFactor", VariableFloat(VariableString("RegenLimitF")));
VariableFloat.Multiply("RegenLimitFactor", VariableInt("TitanClass_RegenLimit1").ConvertToFloat());
VariableInt.Set("TitanClass_RegenLimit", VariableFloat("RegenLimitFactor").ConvertToInt());

If(Int.LessThan(VariableInt("TitanHP"), VariableInt("TitanClass_RegenLimit")))
{
VariableInt.Set("TitanHP", VariableTitan("RTitan").GetHealth());

VariableFloat.Set("RegenSpeedFactor", VariableFloat(VariableString("RegenSpeedF")));
VariableFloat.Multiply("RegenSpeedFactor", VariableInt("TitanClass_RegenTicks1").ConvertToFloat());
VariableInt.Set("TitanClass_RegenTicks", VariableFloat("RegenSpeedFactor").ConvertToInt());

VariableInt.Add("TitanHP", VariableInt("TitanClass_RegenTicks"));
Titan.SetHealth(VariableTitan("RTitan"), VariableInt("TitanHP"));
}

}
}

// titan class large
If(Float.GreaterThanOrEqual(VariableFloat("TitanSize"), VariableFloat("TitanClass_MinSize2")))
{
If(Float.LessThan(VariableFloat("TitanSize"), VariableFloat("TitanClass_MaxSize2")))
{

VariableFloat.Set("RegenLimitFactor", VariableFloat(VariableString("RegenLimitF")));
VariableFloat.Multiply("RegenLimitFactor", VariableInt("TitanClass_RegenLimit2").ConvertToFloat());
VariableInt.Set("TitanClass_RegenLimit", VariableFloat("RegenLimitFactor").ConvertToInt());

If(Int.LessThan(VariableInt("TitanHP"), VariableInt("TitanClass_RegenLimit")))
{
VariableInt.Set("TitanHP", VariableTitan("RTitan").GetHealth());

VariableFloat.Set("RegenSpeedFactor", VariableFloat(VariableString("RegenSpeedF")));
VariableFloat.Multiply("RegenSpeedFactor", VariableInt("TitanClass_RegenTicks2").ConvertToFloat());
VariableInt.Set("TitanClass_RegenTicks", VariableFloat("RegenSpeedFactor").ConvertToInt());

VariableInt.Add("TitanHP", VariableInt("TitanClass_RegenTicks"));
Titan.SetHealth(VariableTitan("RTitan"), VariableInt("TitanHP"));
}

}
}

// titan class extreme
If(Float.GreaterThanOrEqual(VariableFloat("TitanSize"), VariableFloat("TitanClass_MinSize3")))
{

VariableFloat.Set("RegenLimitFactor", VariableFloat(VariableString("RegenLimitF")));
VariableFloat.Multiply("RegenLimitFactor", VariableInt("TitanClass_RegenLimit3").ConvertToFloat());
VariableInt.Set("TitanClass_RegenLimit", VariableFloat("RegenLimitFactor").ConvertToInt());

If(Int.LessThan(VariableInt("TitanHP"), VariableInt("TitanClass_RegenLimit")))
{
VariableInt.Set("TitanHP", VariableTitan("RTitan").GetHealth());

VariableFloat.Set("RegenSpeedFactor", VariableFloat(VariableString("RegenSpeedF")));
VariableFloat.Multiply("RegenSpeedFactor", VariableInt("TitanClass_RegenTicks3").ConvertToFloat());
VariableInt.Set("TitanClass_RegenTicks", VariableFloat("RegenSpeedFactor").ConvertToInt());

VariableInt.Add("TitanHP", VariableInt("TitanClass_RegenTicks"));
Titan.SetHealth(VariableTitan("RTitan"), VariableInt("TitanHP"));
}
}

}
}

// Time count
  If(Bool.Equals(VariableBool("Timer"), true))
  {  
    VariableInt.Add("Time", 1); // Add 1 / seconds
  }

  // Exp start counter
  If(Bool.Equals(VariableBool("CountDown"), true))
  {
    VariableString.Set("Temp", VariableInt("Count").ConvertToString());
    Game.PrintMessage(VariableString(VariableString("Temp")));
    VariableInt.Add("Count", 1);
    VariableInt.Add("GateHeight", 5);
    VariableString.Concat("GateMessage", "EM/Commands/moveobjects[-]Gate[-]-1620[-]", VariableInt("GateHeight").ConvertToString(), "[-]12522[-]0[-]90[-]0[-]-4[-]0[-]0");
    Game.PrintMessage(VariableString("GateMessage"));
    If(VariableInt.Equals(VariableInt("Count"), 12))
    {
      VariableBool.Set("CountDown", false);
    }
  }
  
  
  // Player scaling
If(Bool.Equals(VariableBool("EnablePlayerScaling"), true))
{
// Player balance. Check amount of players every 5 minutes for player balancing
If(VariableInt.GreaterThanOrEqual(VariableInt("TotalPlayersTimer"), 300))
{
VariableInt.Set("TotalPlayers", 0);
VariableInt.Set("TotalPlayersTimer", 0);
ForeachPlayer("EPlayer")
{
VariableInt.Add("TotalPlayers", 1);
}
Game.PrintMessage("EM/Commands//setplayerfactor");
}
VariableInt.Add("TotalPlayersTimer", 1);
}

// Auto player revive
If(Bool.Equals(VariableBool("AutoPosRevive"), true))
{
VariableInt.Add("AutoPosReviveTimer", 1);
If(VariableInt.GreaterThanOrEqual(VariableInt("AutoPosReviveTimer"), VariableInt("AutoPosReviveTimeLimit")))
{
Game.PrintMessage("EM/Commands//revpos");
VariableInt.Set("AutoPosReviveTimer", 0);
}

}


// Santa and Chaser
ForeachTitan("RTitan")
{
VariableInt.Set("TitanHP", VariableTitan("RTitan").GetHealth());
VariableFloat.Set("TitanSize", VariableTitan("RTitan").GetSize());

// Chaser
If(Float.Equals(VariableFloat("TitanSize"), VariableFloat("UnkillableTitanSize")))
{
Titan.SetHealth(VariableTitan("RTitan"), VariableInt("UnkillableTitanHealth"));
}

// Santa
If(Float.Equals(VariableFloat("TitanSize"), VariableFloat("SantaSize")))
{
VariableInt.Add("SantaCounter", 1);
If(Int.GreaterThanOrEqual(VariableInt("SantaCounter"), 30))
{
VariableInt.Set("SantaCounter", 0);
VariableFloat.Set("Titan_SX", VariableTitan("RTitan").GetPositionX());
VariableFloat.Set("Titan_SY", VariableTitan("RTitan").GetPositionY());
VariableFloat.Set("Titan_SZ", VariableTitan("RTitan").GetPositionZ());
Game.PrintMessage("Santa has a present for all");
VariableString.Concat("SantaMessage", "EM/Commands//explosion[-]",VariableFloat("Titan_SX").ConvertToString(),"[-]",VariableFloat("Titan_SY").ConvertToString(),"[-]",VariableFloat("Titan_SZ").ConvertToString(),"[-]5[-]5[-]5");
Game.PrintMessage(VariableString("SantaMessage"));
VariableFloat.Add("Titan_SY", 25.0);
VariableString.Concat("SantaMessage", "EM/Commands//explosion[-]",VariableFloat("Titan_SX").ConvertToString(),"[-]",VariableFloat("Titan_SY").ConvertToString(),"[-]",VariableFloat("Titan_SZ").ConvertToString(),"[-]5[-]5[-]5");
Game.PrintMessage(VariableString("SantaMessage"));
VariableFloat.Add("Titan_SY", 25.0);
VariableString.Concat("SantaMessage", "EM/Commands//explosion[-]",VariableFloat("Titan_SX").ConvertToString(),"[-]",VariableFloat("Titan_SY").ConvertToString(),"[-]",VariableFloat("Titan_SZ").ConvertToString(),"[-]5[-]5[-]5");
Game.PrintMessage(VariableString("SantaMessage"));
VariableFloat.Add("Titan_SY", 25.0);
VariableString.Concat("SantaMessage", "EM/Commands//explosion[-]",VariableFloat("Titan_SX").ConvertToString(),"[-]",VariableFloat("Titan_SY").ConvertToString(),"[-]",VariableFloat("Titan_SZ").ConvertToString(),"[-]10[-]10[-]10");
Game.PrintMessage(VariableString("SantaMessage"));
VariableFloat.Add("Titan_SX", 25.0);
VariableString.Concat("SantaMessage", "EM/Commands//explosion[-]",VariableFloat("Titan_SX").ConvertToString(),"[-]",VariableFloat("Titan_SY").ConvertToString(),"[-]",VariableFloat("Titan_SZ").ConvertToString(),"[-]5[-]5[-]5");
Game.PrintMessage(VariableString("SantaMessage"));
VariableFloat.Add("Titan_SZ", 25.0);
VariableString.Concat("SantaMessage", "EM/Commands//explosion[-]",VariableFloat("Titan_SX").ConvertToString(),"[-]",VariableFloat("Titan_SY").ConvertToString(),"[-]",VariableFloat("Titan_SZ").ConvertToString(),"[-]5[-]5[-]5");
Game.PrintMessage(VariableString("SantaMessage"));
VariableFloat.Add("Titan_SY", 25.0);
VariableString.Concat("SantaMessage", "EM/Commands//explosion[-]",VariableFloat("Titan_SX").ConvertToString(),"[-]",VariableFloat("Titan_SY").ConvertToString(),"[-]",VariableFloat("Titan_SZ").ConvertToString(),"[-]5[-]5[-]5");
Game.PrintMessage(VariableString("SantaMessage"));
VariableFloat.Add("Titan_SY", 25.0);
VariableString.Concat("SantaMessage", "EM/Commands//explosion[-]",VariableFloat("Titan_SX").ConvertToString(),"[-]",VariableFloat("Titan_SY").ConvertToString(),"[-]",VariableFloat("Titan_SZ").ConvertToString(),"[-]5[-]5[-]5");
Game.PrintMessage(VariableString("SantaMessage"));
VariableFloat.Add("Titan_SY", 25.0);
VariableString.Concat("SantaMessage", "EM/Commands//explosion[-]",VariableFloat("Titan_SX").ConvertToString(),"[-]",VariableFloat("Titan_SY").ConvertToString(),"[-]",VariableFloat("Titan_SZ").ConvertToString(),"[-]5[-]5[-]5");
Game.PrintMessage(VariableString("SantaMessage"));
VariableString.Concat("SantaMessage", "EM/Commands//titans3");
Game.PrintMessage(VariableString("SantaMessage"));
}
}

// Colossal
If(Float.Equals(VariableFloat("TitanSize"), VariableFloat("ColossalSize")))
{
VariableInt.Add("ColossalCounter", 1);
VariableInt.Set("ColossalExplosionWarning", VariableInt("ColossalExplosionCounterLimit"));
VariableInt.Subtract("ColossalExplosionWarning", 10);
If(Int.Equals(VariableInt("ColossalCounter"), VariableInt("ColossalExplosionWarning")))
{
Game.PrintMessage("<size=15><color=#903333>SCOUT:</color>DISENGAGE THE COLOSSAL!!!</size>");
}
If(Int.GreaterThanOrEqual(VariableInt("ColossalCounter"), VariableInt("ColossalExplosionCounterLimit")))
{
VariableInt.Add("ColossalExplosionCounter", 1);
If(Int.GreaterThanOrEqual(VariableInt("ColossalExplosionCounter"), VariableInt("ColossalExplosionLimit")))
{
VariableInt.Set("ColossalCounter", 0);
VariableInt.Set("ColossalExplosionCounter", 0);
}
VariableFloat.Set("Titan_SX", VariableTitan("RTitan").GetPositionX());
VariableFloat.Set("Titan_SY", VariableTitan("RTitan").GetPositionY());
VariableFloat.Set("Titan_SZ", VariableTitan("RTitan").GetPositionZ());

VariableInt.Set("ExplosionCount", 15);
While(Int.GreaterThan(VariableInt("ExplosionCount"), 0))
{
VariableString.Concat("ColossalMessage", "EM/Commands//explosion[-]",VariableFloat("Titan_SX").ConvertToString(),"[-]",VariableFloat("Titan_SY").ConvertToString(),"[-]",VariableFloat("Titan_SZ").ConvertToString(),"[-]100[-]100[-]100");
Game.PrintMessage(VariableString("ColossalMessage"));
VariableFloat.Add("Titan_SY", 50.0);
VariableInt.Subtract("ExplosionCount", 1);
}

}

}

// Beast
If(Float.Equals(VariableFloat("TitanSize"), VariableFloat("BeastSize")))
{
VariableInt.Add("BeastCounter", 1);
VariableInt.Set("BeastWarning", VariableInt("BeastCounterLimit"));
VariableInt.Subtract("BeastWarning", 10);
If(Int.Equals(VariableInt("BeastCounter"), VariableInt("BeastCounterLimit")))
{
VariableFloat.Set("Beast_X", VariableTitan("RTitan").GetPositionX());
VariableFloat.Set("Beast_Y", VariableTitan("RTitan").GetPositionY());
VariableFloat.Set("Beast_Z", VariableTitan("RTitan").GetPositionZ());
VariableFloat.Set("Beast_X_Min", VariableFloat("Beast_X"));
VariableFloat.Set("Beast_X_Max", VariableFloat("Beast_X"));
VariableFloat.Set("Beast_Z_Min", VariableFloat("Beast_Z"));
VariableFloat.Set("Beast_Z_Max", VariableFloat("Beast_Z"));
VariableFloat.Subtract("Beast_X_Min", 2000.0);
VariableFloat.Add("Beast_X_Max", 2000.0);
VariableFloat.Subtract("Beast_Z_Min", 2000.0);
VariableFloat.Add("Beast_Z_Max", 2000.0);
Game.PrintMessage("<size=15><color=#903333>SCOUT:</color>ROCKS INCOMING!!!</size>");
}
If(Int.GreaterThanOrEqual(VariableInt("BeastCounter"), VariableInt("BeastCounterLimit")))
{

VariableInt.Add("BeastRockCounter", 1);
If(Int.GreaterThanOrEqual(VariableInt("BeastRockCounter"), VariableInt("BeastRockLimit")))
{
VariableInt.Set("BeastRockCounter", 0);
VariableInt.Add("BeastRockVolleyCounter", 1);
// Do a volley
VariableInt.Set("RockCount", VariableInt("BeastRocks"));
While(Int.GreaterThan(VariableInt("RockCount"), 0))
{
VariableFloat.SetRandom("BeastX", VariableFloat("Beast_X_Min"), VariableFloat("Beast_X_Max"));
VariableFloat.Set("BeastY", VariableFloat("Beast_Y"));
VariableFloat.SetRandom("BeastZ", VariableFloat("Beast_Z_Min"), VariableFloat("Beast_Z_Max"));
VariableString.Concat("BeastMessage", "EM/Commands//explosion[-]",VariableFloat("BeastX").ConvertToString(),"[-]",VariableFloat("BeastY").ConvertToString(),"[-]",VariableFloat("BeastZ").ConvertToString(),"[-]20[-]20[-]20");
Game.PrintMessage(VariableString("BeastMessage"));
VariableInt.Subtract("RockCount", 1);
}
}

If(Int.GreaterThanOrEqual(VariableInt("BeastRockVolleyCounter"), VariableInt("BeastRockVolleyLimit")))
{
VariableInt.Set("BeastRockVolleyCounter", 0);
VariableInt.Set("BeastCounter", 0);
}


}
}




If(Bool.Equals(VariableBool("EnableAntiSkating"), true))
{
If(Float.LessThan(VariableFloat("SpeedCounter"), VariableFloat("SpeedCounterLimit")))
{
VariableFloat.Add("SpeedCounter", 1.0);
}
If(Float.Equals(VariableFloat("SpeedCounter"), VariableFloat("SpeedCounterLimit")))
{
VariableFloat.Set("SpeedCounter", 0.0);
}
}

If(Bool.Equals(VariableBool("EnableWagonNuke"), true))
{
If(Bool.Equals(VariableBool("DestroyLife"), false)) 
{
If(Bool.Equals(VariablePlayer("MCPlayer").GetIsAlive(), false)) 
{
Game.PrintMessage("<size=15><color=#903333>WAGON NUKE STABILIZER IS DESTROYED!!!</color></size>");
VariableBool.Set("DestroyLife", true);
}
}
If(Bool.Equals(VariableBool("DestroyLife"), true))
{
VariableInt.Subtract("WagonNukeCounter", 1);
Game.PrintMessage(VariableInt("WagonNukeCounter").ConvertToString());
If(Int.LessThanOrEqual(VariableInt("WagonNukeCounter"), 0))
{
ForeachPlayer("player")
{
VariableFloat.Set("x", VariablePlayer("player").GetPositionX());
VariableFloat.Set("y", VariablePlayer("player").GetPositionY());
VariableFloat.Set("z", VariablePlayer("player").GetPositionZ());
VariableString.Concat("NukeMessage", "EM/Commands//explosion[-]",VariableFloat("x").ConvertToString(),"[-]",VariableFloat("y").ConvertToString(),"[-]",VariableFloat("z").ConvertToString(),"[-]25[-]25[-]25");
Game.PrintMessage(VariableString("NukeMessage"));
}
Game.PrintMessage("EM/Commands//killtit");
Game.PrintMessage("EM/Commands//setdaylightcolor 10");
Game.PrintMessage("Kaboom");
VariableBool.Set("EnableWagonNuke", false);
}
}
}

VariableInt.Set("counterPlayer", 0);
    VariablePlayer.Set("player", VariablePlayer("null"));
    ForeachPlayer("player")
    {
        VariableString.Concat("xDir","x",VariableInt("counterPlayer").ConvertToString());
        VariableString.Concat("yDir","y",VariableInt("counterPlayer").ConvertToString());
        VariableString.Concat("zDir","z",VariableInt("counterPlayer").ConvertToString());
        VariableString.Concat("revDir","rev",VariableInt("counterPlayer").ConvertToString());
        VariableString.Concat("deathDir","death",VariableInt("counterPlayer").ConvertToString());
        VariableString.Concat("cooldownDirMain","cooldown",VariableInt("counterPlayer").ConvertToString());
        If(Bool.Equals(VariablePlayer("player").GetIsAlive(), true))
        {
            VariableFloat.Set("x", VariablePlayer("player").GetPositionX());
            VariableFloat.Set("y", VariablePlayer("player").GetPositionY());
            VariableFloat.Set("z", VariablePlayer("player").GetPositionZ());
            If(Float.NotEquals(VariableFloat("x"), 0.0))
            {
            VariableFloat.Set(VariableString("xDir"), VariableFloat("x"));
            }
            If(Float.NotEquals(VariableFloat("y"), 0.0))
            {
            VariableFloat.Set(VariableString("yDir"), VariableFloat("y"));
            }
            If(Float.NotEquals(VariableFloat("z"), 0.0))
            {
            VariableFloat.Set(VariableString("zDir"), VariableFloat("z"));
            }
            VariableInt.Set(VariableString("revDir"), 0);
            VariableInt.Set(VariableString("deathDir"), 0);
        }  
        If(Bool.Equals(VariablePlayer("player").GetIsAlive(), false))
        {
            If(Int.LessThan(VariableInt(VariableString("deathDir")), VariableInt("deathTime")))
            {
                VariableInt.Set("counterPlayerMedic", 0);
                VariablePlayer.Set("playerMedic", VariablePlayer("null"));
                ForeachPlayer("playerMedic")
                {
                    VariableString.Concat("cooldownDirSub","cooldown",VariableInt("counterPlayer").ConvertToString());
                    If(Player.NotEquals(VariablePlayer("player"), VariablePlayer("playerMedic")))
                    {
                        If(String.Equals(VariablePlayer("playerMedic").GetGuildName(), "[ffffff][ffffff]Medic"))
                        {
                            If(Bool.Equals(VariablePlayer("playerMedic").GetIsAlive(), true))
                            {
                                If(Int.LessThanOrEqual(VariableInt(VariableString("cooldownDirSub")), 0))
                                {
                                    VariableFloat.Set("xgreater", VariableFloat(VariableString("xDir")));
                                    VariableFloat.Add("xgreater", VariableFloat("radius"));
                                    If(Float.LessThan(VariablePlayer("playerMedic").GetPositionX(), VariableFloat("xgreater")))
                                    {
                                        VariableFloat.Set("xless", VariableFloat(VariableString("xDir")));
                                        VariableFloat.Subtract("xless", VariableFloat("radius"));
                                        If(Float.GreaterThan(VariablePlayer("playerMedic").GetPositionX(), VariableFloat("xless")))
                                        {
                                            VariableFloat.Set("zgreater", VariableFloat(VariableString("zDir")));
                                            VariableFloat.Add("zgreater", VariableFloat("radius"));
                                            If(Float.LessThan(VariablePlayer("playerMedic").GetPositionZ(), VariableFloat("zgreater")))
                                            {
                                                VariableFloat.Set("zless", VariableFloat(VariableString("zDir")));
                                                VariableFloat.Subtract("zless", VariableFloat("radius"));
                                                If(Float.GreaterThan(VariablePlayer("playerMedic").GetPositionZ(), VariableFloat("zless")))
                                                {
                                                    VariableInt.Add(VariableString("revDir"), 1);
                                                    If(Int.Equals(VariableInt(VariableString("revDir")), 1))
                                                    {
                                                        VariableString.Concat("reviveWho", "<size=10>reviving</size><size=1>___</size><size=10>player</size><size=1>___</size><size=10>wait</size><size=1>___</size>","<size=15><color=#ff0000>", VariableInt("revTime").ConvertToString(),"</color></size>", "<size=1>___</size><size=10>seconds</size>");
                                                        Game.PrintMessage(VariableString("reviveWho"));
                                                    }
                                                    If(Int.GreaterThanOrEqual(VariableInt(VariableString("revDir")), VariableInt("revTime")))
                                                    {
                                                        Player.SpawnPlayerAt(VariablePlayer("player"), VariablePlayer("playerMedic").GetPositionX(), VariablePlayer("playerMedic").GetPositionY(), VariablePlayer("playerMedic").GetPositionZ());
                                                        VariableInt.Set(VariableString("revDir"), 0);
                                                        VariableInt.Set(VariableString("cooldownDirSub"), VariableInt("cooldown"));
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    VariableInt.Add("counterPlayerMedic", 1);
                }  
            }
            If(Int.Equals(VariableInt(VariableString("deathDir")), VariableInt("deathTime")))
            {
            Game.PrintMessage("<size=10>a</size><size=1>___</size><size=10>soldier</size><size=1>___</size><size=10>has</size><size=1>___</size><size=10>been</size><size=1>___</size><size=10>lost</size>")
            }
            VariableInt.Add(VariableString("deathDir"), 1);
        }
        VariableInt.Add("counterPlayer", 1);
        VariableInt.Subtract(VariableString("cooldownDirMain"), 1);
    }
    VariableInt.Add("counterMain", 1);

}
}


// -- CHAT COMMANDS --        
OnChatInput("input")
{

// DONT EVER TOUCH THESE COMMANDS
If(String.StartsWith(VariableString("input"), "/"))
{

// Handle set variable logic. Needs to be at top.
If(Bool.Equals(VariableBool("SetVariable"), true))
{
Game.PrintMessage("Final");
VariableBool.Set("SetVariable", false);

If(Int.Equals(VariableInt("SetVariableType"), 0))
{
VariableInt.Set(VariableString("SetVariableName"), VariableString("input").ConvertToInt());
}

If(Int.Equals(VariableInt("SetVariableType"), 1))
{
VariableBool.Set(VariableString("SetVariableName"), VariableString("input").ConvertToBool());
}

If(Int.Equals(VariableInt("SetVariableType"), 2))
{
VariableString.Set(VariableString("SetVariableName"), VariableString("input"));
}

If(Int.Equals(VariableInt("SetVariableType"), 3))
{
VariableFloat.Set(VariableString("SetVariableName"), VariableString("input").ConvertToString());
}

}

// Set a variable type
If(Bool.Equals(VariableBool("SetVariableTypeValue"), true))
{
Game.PrintMessage("Type");
VariableBool.Set("SetVariableTypeValue", false);
VariableInt.Set("SetVariableType", VariableString("input").ConvertToInt());
VariableBool.Set("SetVariable", true);
Game.PrintMessage("<b><color=#D46565>[LOGIC]</color>: Enter a variable value:</b>");
}

// Set a variable name
If(Bool.Equals(VariableBool("SetVariableNameValue"), true))
{
Game.PrintMessage("Value");
VariableBool.Set("SetVariableNameValue", false);
VariableString.Set("SetVariableName", VariableString("input"));
VariableBool.Set("SetVariableTypeValue", true);
Game.PrintMessage("<b><color=#D46565>[LOGIC]</color>: Enter a variable type:</b>");
}

// Execute some commands on start up
If(String.Equals(VariableString("input"),"/startup"))
{
Game.PrintMessage("EM/Commands//ft");
Game.PrintMessage("EM/Commands//mcset");
Game.PrintMessage("EM/Commands//setplayerfactor");
}

If(String.StartsWith(VariableString("input"), "/init"))
{
VariableString.Set("char63", VariableString("input"));
VariableString.Replace("char63", "/init", "");
VariableBool.Set("runScript", true);
}

}

// Help commands
If(String.Equals(VariableString("input"),"/com"))
 {
Game.PrintMessage("<b><i><color=#000000>**List of commands:**</color></i></b>");
Game.PrintMessage("<color=#ffff00> /start          - to Start Expedition</color>");
Game.PrintMessage("<color=#ffff00> /stop           - to End Expedition</color>");
Game.PrintMessage("<color=#ffff00> /enableregen    - To Enable Titan Regeneration</color>");
Game.PrintMessage("<color=#ffff00> /disableregen   - To Disable Titan Regeneration</color>");
Game.PrintMessage("<color=#ffff00> /stats          - To Get Expedition Statistics</color>");
Game.PrintMessage("<color=#ffff00> /score          - To Get Expedition Score(WIP)</color>");
Game.PrintMessage("<color=#ffff00> /mcset          - Set Region Player To MC</color>");
Game.PrintMessage("<color=#ffff00> /setnewmc       - Set Region Player To Top Alive Player</color>");
Game.PrintMessage(" ");
Game.PrintMessage("<b><i><color=#000000>**Other list of commands:**</color></i></b>");
Game.PrintMessage("<color=#ffff00> /lrev   - List of Revive Commands</color>");
Game.PrintMessage("<color=#ffff00> /lreg   - List of Dynamic Region Commands</color>");
Game.PrintMessage("<color=#ffff00> /ltit   - List of Titan Commands</color>");

 }

 
// GENERIC COMMANDS
If(String.StartsWith(VariableString("input"), "/"))
{


// Set the MC. Last player is always the lowest ID, so in this case, the MC
If(String.Equals(VariableString("input"),"/mcset"))
{
ForeachPlayer("EPlayer")
{
VariablePlayer.Set("MCPlayer", VariablePlayer("EPlayer"));
}

}

// Select another player as MC if the current MC is dead. Useful to still spawn titans and/or revive points
If(String.Equals(VariableString("input"),"/setnewmc"))
{
ForeachPlayer("EPlayer")
{
VariablePlayer.Set("MCPlayer", VariablePlayer("EPlayer"));
}
VariableBool.Set("isMCAlive",VariablePlayer("MCPlayer").GetIsAlive());
If(Bool.Equals(VariableBool("isMCAlive"), false))
{
Game.PrintMessage("The_MC_is_dead!_Finding_another_player!");
VariableBool.Set("BackupMCFound", false);
ForeachPlayer("EPlayer")
{
If(Bool.Equals(VariableBool("BackupMCFound"), false))
{
VariableBool.Set("isAlive",VariablePlayer("EPlayer").GetIsAlive()); // is the current player alive?
If(Bool.Equals(VariableBool("isAlive"), true))
{
VariableString.Set("PlayerName", VariablePlayer("EPlayer").GetName());
VariableString.Concat("Message", "New Player: ", " ", VariableString("PlayerName"));
Game.PrintMessage(VariableString("Message"));
VariablePlayer.Set("MCPlayer", VariablePlayer("EPlayer"));
VariableBool.Set("BackupMCFound", true);
}
}
}
}
}


    If(String.Equals(VariableString("input"), "/start"))
    {
        VariableBool.Set("CountDown", true); // Count down variable
        VariableBool.Set("Timer", true);
        VariableInt.Set("Count", 0); // Amount of counts
        VariableInt.Set("Time", 0);
        VariableInt.Set("Revives", 0);
        VariableInt.Set("Kills", 0);
        VariableInt.Set("Objectives", 0);
        VariableInt.Set("BonusObjectives", 0);
    }

    If(String.Equals(VariableString("input"), "/timer"))
    {
        VariableBool.Set("CountDown", true); // Count down variable
        VariableInt.Set("Count", 0);
    }

    If(String.Equals(VariableString("input"), "/stop"))
    {
        Game.PrintMessage("Expedition has ended!");
        VariableBool.Set("Timer", false);
    }



    If(String.Equals(VariableString("input"), "/stats"))
    {
        VariableString.Concat("Message", "Kill: ", " ", VariableInt("Kills").ConvertToString());
        Game.PrintMessage(VariableString("Message"));
        VariableString.Concat("Message", "Revives: ", " ", VariableInt("Revives").ConvertToString());
        Game.PrintMessage(VariableString("Message"));
        VariableString.Concat("Message", "Times(seconds): ", " ", VariableInt("Time").ConvertToString());
        Game.PrintMessage(VariableString("Message"));
    }

    If(String.Equals(VariableString("input"), "/score"))
    {

        VariableInt.Set("Score", 0); // reset the score, otherwise total score would just add itself again after using this command multiple times

        // Kills calculation
        VariableInt.Set("KillScore", 0);
        VariableInt.Set("KillCount", VariableInt("Kills"));
        While(Int.GreaterThan(VariableInt("KillCount"), 0))
        {
            VariableInt.Add("KillScore", VariableInt("KillPoints"))
            VariableInt.Subtract("KillCount", 1);
        }

        VariableInt.Add("Score", VariableInt("KillScore"));

        // Revives calculation
        VariableInt.Set("ReviveScore", 0);
        VariableInt.Set("ReviveCount", VariableInt("Revives"));
        While(Int.GreaterThan(VariableInt("ReviveCount"), 0))
        {
            VariableInt.Add("ReviveScore", VariableInt("RevivePoints"))
            VariableInt.Subtract("ReviveCount", 1);
        }

        VariableInt.Add("Score", VariableInt("ReviveScore"));

        // Time calculation
        VariableInt.Set("TimeScore", 0);
        VariableInt.Set("TimeCount", VariableInt("Time"));
        While(Int.GreaterThan(VariableInt("TimeCount"), 0))
        {
            VariableInt.Add("TimeScore", VariableInt("TimePoints"))
            VariableInt.Subtract("TimeCount", 1);
        }

        VariableInt.Add("Score", VariableInt("TimeScore"));

        VariableString.Concat("Message", "Total Score: ", " ", VariableInt("Score").ConvertToString());
        Game.PrintMessage(VariableString("Message"));

    }
}


// OPTION COMMANDS
If(String.StartsWith(VariableString("input"), "/"))
{

If(String.Equals(VariableString("input"), "/hoption"))
{
Game.PrintMessage("<b><i><color=#000000>** --- Option commands --- **</color></i></b>");
Game.PrintMessage("<color=#ffff00> --- /coption > Check the current option values</color>");
Game.PrintMessage("<color=#ffff00> --- /setexpdifficulty[0/1/2] > Set expedition difficulty</color>");
Game.PrintMessage("<color=#ffff00> --- /tplayerscaling > Toggle player scaling</color>");
Game.PrintMessage("<color=#ffff00> --- /tanim  > Toggle random titan animation</color>");
Game.PrintMessage("<color=#ffff00> --- /tspeed  > Toggle random titan speed</color>");
Game.PrintMessage("<color=#ffff00> --- /tskin  > Toggle titan skins</color>");
Game.PrintMessage("<color=#ffff00> --- /thealth  > Toggle titan health</color>");
Game.PrintMessage("<color=#ffff00> --- /tregen  > Toggle titan regeneration</color>");
Game.PrintMessage("<color=#ffff00> --- /tview  > Toggle titan view distance</color>");
}

If(String.Equals(VariableString("input"), "/coption"))
{
Game.PrintMessage("<b><i><color=#000000>** --- Expedition Settings --- **</color></i></b>");

If(Int.Equals(VariableInt("ExpeditionDifficulty"), 0))
{
Game.PrintMessage("<color=#ffff00> --- Expedition difficulty: Easy --- </color>");
}

If(Int.Equals(VariableInt("ExpeditionDifficulty"), 1))
{
Game.PrintMessage("<color=#ffff00> --- Expedition difficulty: Normal --- </color>");
}

If(Int.Equals(VariableInt("ExpeditionDifficulty"), 2))
{
Game.PrintMessage("<color=#ffff00> --- Expedition difficulty: Hard --- </color>");
}

VariableString.Concat("Message", "<color=#ffff00> --- Player Scaling: ", VariableBool("EnablePlayerScaling").ConvertToString(), " --- </color>");
Game.PrintMessage(VariableString("Message"));
VariableString.Concat("Message", "<color=#ffff00> --- Random Titan Animation: ", VariableBool("EnableRandomTitanAnimation").ConvertToString(), " --- </color>");
Game.PrintMessage(VariableString("Message"));
VariableString.Concat("Message", "<color=#ffff00> --- Random Titan Speed: ", VariableBool("EnableRandomTitanSpeed").ConvertToString(), " --- </color>");
Game.PrintMessage(VariableString("Message"));
VariableString.Concat("Message", "<color=#ffff00> --- Titan Skins: ", VariableBool("EnableRandomTitanSkins").ConvertToString(), " --- </color>");
Game.PrintMessage(VariableString("Message"));
VariableString.Concat("Message", "<color=#ffff00> --- Titan HP: ", VariableBool("EnableTitanHealth").ConvertToString(), " --- </color>");
Game.PrintMessage(VariableString("Message"));
VariableString.Concat("Message", "<color=#ffff00> --- Titan Regeneration: ", VariableBool("EnableTitanRegeneration").ConvertToString(), " --- </color>");
Game.PrintMessage(VariableString("Message"));
VariableString.Concat("Message", "<color=#ffff00> --- Titan View Distance: ", VariableBool("EnableTitanViewDistance").ConvertToString(), " --- </color>");
Game.PrintMessage(VariableString("Message"));
VariableString.Concat("Message", "<color=#ffff00> --- Automatic Titans: ", VariableBool("EnableAutoTitans").ConvertToString(), " --- </color>");
Game.PrintMessage(VariableString("Message"));
}

// Exp difficulty
If(String.Equals(VariableString("input"), "/setexpdifficulty0"))
{
VariableInt.Set("ExpeditionDifficulty", 0);
Game.PrintMessage("<color=#ffff00> --- Expedition difficulty: Easy --- </color>");
}

If(String.Equals(VariableString("input"), "/setexpdifficulty1"))
{
VariableInt.Set("ExpeditionDifficulty", 1);
Game.PrintMessage("<color=#ffff00> --- Expedition difficulty: Normal --- </color>");
}

If(String.Equals(VariableString("input"), "/setexpdifficulty2"))
{
VariableInt.Set("ExpeditionDifficulty", 2);
Game.PrintMessage("<color=#ffff00> --- Expedition difficulty: Hard --- </color>");
}

//Player scaling
If(String.Equals(VariableString("input"), "/tplayerscaling"))
{
VariableBool.Set("Done", false);
If(Bool.Equals(VariableBool("EnablePlayerScaling"), false))
{
Game.PrintMessage("<color=#ffff00> --- Player scaling: Enabled --- </color>");
VariableBool.Set("EnablePlayerScaling", true);
VariableBool.Set("Done", true);
}
If(Bool.Equals(VariableBool("Done"), false))
{
Game.PrintMessage("<color=#ffff00> --- Player scaling: Disabled --- </color>");
VariableBool.Set("EnablePlayerScaling", false);
VariableFloat.Set("PlayerFactor", 1.0);
}
}

// Titan Animation
If(String.Equals(VariableString("input"), "/tanim"))
{
VariableBool.Set("Done", false);
If(Bool.Equals(VariableBool("EnableRandomTitanAnimation"), false))
{
Game.PrintMessage("<color=#ffff00> --- Random Titan Animation: Enabled --- </color>");
VariableBool.Set("EnableRandomTitanAnimation", true);
VariableBool.Set("Done", true);
}
If(Bool.Equals(VariableBool("Done"), false))
{
Game.PrintMessage("<color=#ffff00> --- Random Titan Animation: Disabled --- </color>");
VariableBool.Set("EnableRandomTitanAnimation", false);
}
}

// Titan Speed
If(String.Equals(VariableString("input"), "/tspeed"))
{
VariableBool.Set("Done", false);
If(Bool.Equals(VariableBool("EnableRandomTitanSpeed"), false))
{
Game.PrintMessage("<color=#ffff00> --- Random Titan Speed: Enabled --- </color>");
VariableBool.Set("EnableRandomTitanSpeed", true);
VariableBool.Set("Done", true);
}
If(Bool.Equals(VariableBool("Done"), false))
{
Game.PrintMessage("<color=#ffff00> --- Random Titan Speed: Disabled --- </color>");
VariableBool.Set("EnableRandomTitanSpeed", false);
}
}

// Titan Skins
If(String.Equals(VariableString("input"), "/tskin"))
{
VariableBool.Set("Done", false);
If(Bool.Equals(VariableBool("EnableRandomTitanSkins"), false))
{
Game.PrintMessage("<color=#ffff00> --- Titan Skins: Enabled --- </color>");
VariableBool.Set("EnableRandomTitanSkins", true);
VariableBool.Set("Done", true);
}
If(Bool.Equals(VariableBool("Done"), false))
{
Game.PrintMessage("<color=#ffff00> --- Titan Skins: Disabled --- </color>");
VariableBool.Set("EnableRandomTitanSkins", false);
}
}

// Titan Health
If(String.Equals(VariableString("input"), "/thealth"))
{
VariableBool.Set("Done", false);
If(Bool.Equals(VariableBool("EnableTitanHealth"), false))
{
Game.PrintMessage("<color=#ffff00> --- Titan HP: Enabled --- </color>");
VariableBool.Set("EnableTitanHealth", true);
VariableBool.Set("Done", true);
}
If(Bool.Equals(VariableBool("Done"), false))
{
Game.PrintMessage("<color=#ffff00> --- Titan HP: Disabled --- </color>");
VariableBool.Set("EnableTitanHealth", false);
}
}

// Titan Regeneration
If(String.Equals(VariableString("input"), "/tregen"))
{
VariableBool.Set("Done", false);
If(Bool.Equals(VariableBool("EnableTitanRegeneration"), false))
{
Game.PrintMessage("<color=#ffff00> --- Titan Regeneration: Enabled --- </color>");
VariableBool.Set("EnableTitanRegeneration", true);
VariableBool.Set("Done", true);
}
If(Bool.Equals(VariableBool("Done"), false))
{
Game.PrintMessage("<color=#ffff00> --- Titan Regeneration: Disabled --- </color>");
VariableBool.Set("EnableTitanRegeneration", false);
}
}

// Titan View Distance
If(String.Equals(VariableString("input"), "/tview"))
{
VariableBool.Set("Done", false);
If(Bool.Equals(VariableBool("EnableTitanViewDistance"), false))
{
Game.PrintMessage("<color=#ffff00> --- Titan View Distance: Enabled --- </color>");
VariableBool.Set("EnableTitanViewDistance", true);
VariableBool.Set("Done", true);
}
If(Bool.Equals(VariableBool("Done"), false))
{
Game.PrintMessage("<color=#ffff00> --- Titan View Distance: Disabled --- </color>");
VariableBool.Set("EnableTitanViewDistance", false);
}
}

// Automatic titan spawners
If(String.Equals(VariableString("input"), "/tauto"))
{
VariableBool.Set("Done", false);
If(Bool.Equals(VariableBool("EnableAutoTitans"), false))
{
Game.PrintMessage("<color=#ffff00> --- Automatic Titans: Enabled --- </color>");
VariableBool.Set("EnableAutoTitans", true);
VariableBool.Set("Done", true);
}
If(Bool.Equals(VariableBool("Done"), false))
{
Game.PrintMessage("<color=#ffff00> --- Automatic Titans: Disabled --- </color>");
VariableBool.Set("EnableAutoTitans", false);
}
}

// Wagon Nuke
If(String.Equals(VariableString("input"), "/tnuke"))
{
VariableBool.Set("Done", false);
If(Bool.Equals(VariableBool("EnableWagonNuke"), false))
{
Game.PrintMessage("<color=#ffff00> --- Wagon Nuke: Enabled --- </color>");
VariableBool.Set("EnableWagonNuke", true);
VariableBool.Set("Done", true);
}
If(Bool.Equals(VariableBool("Done"), false))
{
Game.PrintMessage("<color=#ffff00> --- Wagon Nuke : Disabled --- </color>");
VariableBool.Set("EnableWagonNuke", false);
}
}

}


// REVIVE COMMANDS
If(String.StartsWith(VariableString("input"), "/"))
{

If(String.Equals(VariableString("input"), "/hrevive"))
{
Game.PrintMessage("<b><i><color=#000000>** --- Revive commands --- **</color></i></b>");
Game.PrintMessage("<color=#ffff00> --- /setrev > Set a revive point at current location </color>");
Game.PrintMessage("<color=#ffff00> --- /rev > Revive at the /setrev location</color>");
Game.PrintMessage("<color=#ffff00> --- /setrevauto > Automatically revive players at current location every 30s</color>");
Game.PrintMessage("<color=#ffff00> --- /dsetrevauto  > Disable Auto Revive At Position</color>");
Game.PrintMessage("<color=#ffff00> --- /revmc  > Revive all at MC Player</color>");
}

If(String.Equals(VariableString("input"), "/revpos"))
{
ForeachPlayer("EPlayer")
{
VariableBool.Set("isAlive",VariablePlayer("EPlayer").GetIsAlive()); // is the current player alive?
If(Bool.Equals(VariableBool("isAlive"), false))
{
VariableInt.Add("Revives", 1);
Player.SpawnPlayerAt(VariablePlayer("EPlayer"), VariableFloat("Pos_X"), VariableFloat("Pos_Y"), VariableFloat("Pos_Z"));
}
}
If(Bool.Equals(VariableBool("AutoPosRevive"), false))
{
Game.PrintMessage("<b><color=#58a27c><size=15>Reinforcements have arrived at the camp!</size></color></b>");
}
}

If(String.Equals(VariableString("input"), "/setrev"))
{
VariableFloat.Set("Pos_X", VariablePlayer("MCPlayer").GetPositionX());
VariableFloat.Set("Pos_Y", VariablePlayer("MCPlayer").GetPositionY());
VariableFloat.Set("Pos_Z", VariablePlayer("MCPlayer").GetPositionZ());
Game.PrintMessage("<b><color=#58a27c><size=15>A camp has been established!</size></color></b>");
Game.PrintMessage("<b><color=#58a27c><size=15>Reinforcements can now arrive to this location!!</size></color></b>");
}

If(String.Equals(VariableString("input"), "/setrevauto"))
{
VariableBool.Set("AutoPosRevive", true);
VariableFloat.Set("Pos_X", VariablePlayer("MCPlayer").GetPositionX());
VariableFloat.Set("Pos_Y", VariablePlayer("MCPlayer").GetPositionY());
VariableFloat.Set("Pos_Z", VariablePlayer("MCPlayer").GetPositionZ());
Game.PrintMessage("<b><color=#58a27c><size=15>A camp has been established!</size></color></b>");
Game.PrintMessage("<b><color=#58a27c><size=15>Reinforcements will now arrive to this location every 30 seconds!!</size></color></b>");
}

If(String.Equals(VariableString("input"), "/dsetrevauto"))
{
VariableBool.Set("AutoPosRevive", false);
Game.PrintMessage("<b><color=#58a27c><size=15>A camp has been destroyed!</size></color></b>");
}

If(String.Equals(VariableString("input"), "/revmc"))
{

If(Player.NotEquals(VariablePlayer("MCPlayer"), VariablePlayer("null")))
{
// Get the last known location of the MC
VariableFloat.Set("MC_X", VariablePlayer("MCPlayer").GetPositionX());
VariableFloat.Set("MC_Y", VariablePlayer("MCPlayer").GetPositionY());
VariableFloat.Set("MC_Z", VariablePlayer("MCPlayer").GetPositionZ());
Game.PrintMessage("<b><color=#0066CC><size=15>Reinforcements have arrived at The MC</size></color></b>");

ForeachPlayer("EPlayer")
{
VariableBool.Set("isAlive",VariablePlayer("EPlayer").GetIsAlive()); // is the current player alive?
If(Bool.Equals(VariableBool("isAlive"), false))
{
VariableInt.Add("Revives", 1);
Player.SpawnPlayerAt(VariablePlayer("EPlayer"), VariableFloat("MC_X"), VariableFloat("MC_Y"), VariableFloat("MC_Z"));
}
}
}
}

}


// TITANS - these functions are used for titan spawning
If(String.StartsWith(VariableString("input"), "/"))
{

If(String.Equals(VariableString("input"), "/htitan"))
{
Game.PrintMessage("<b><i><color=#000000>** --- Titan commands --- **</color></i></b>");
Game.PrintMessage("<color=#ffff00> --- /titans[1-50] > Spawn titans at dynamic region</color>");
Game.PrintMessage("<color=#ffff00> --- /tptitans > Teleport all titans to dynamic region</color>");
}

// Random titans at the MC region
If(String.StartsWith(VariableString("input"), "/titans"))
{
VariableString.Remove("input", "/titans");
VariableInt.Set("TitanAmount", VariableString("input").ConvertToInt());

Game.PrintMessage("EM/Commands//settitanamount");
While(VariableInt.GreaterThan(VariableInt("TitanAmount"), 0))
{
Game.PrintMessage("EM/Commands//spawntitanmc");
VariableInt.Subtract("TitanAmount", 1);
}
}

// Random titans at the region
If(String.StartsWith(VariableString("input"), "/spawntitansatregion"))
{
VariableString.Remove("input", "/spawntitansatregion");
VariableInt.Set("TitanAmount", VariableString("input").ConvertToInt());

Game.PrintMessage("EM/Commands//settitanamount");
While(VariableInt.GreaterThan(VariableInt("TitanAmount"), 0))
{
Game.PrintMessage("EM/Commands//spawntitanregion");
VariableInt.Subtract("TitanAmount", 1);
}
}

// Teleport all titans to the MC region
If(String.Equals(VariableString("input"),"/tptitans"))
{
ForeachTitan("TitanMy")
{
Game.PrintMessage("EM/Commands//setrandomtitancordsfloat");
Titan.MoveTitan(VariableTitan("TitanMy"), VariableFloat("Titan_X"),VariableFloat("Titan_Y"),VariableFloat("Titan_Z"));
}
Game.PrintMessage("Titans TPed to Region!");
}

// Set random titan cords
If(String.Equals(VariableString("input"), "/setrandomtitancords"))
{
VariableFloat.Set("MC_X", VariablePlayer("MCPlayer").GetPositionX());
VariableFloat.Set("MC_Y", VariablePlayer("MCPlayer").GetPositionY());
VariableFloat.Set("MC_Z", VariablePlayer("MCPlayer").GetPositionZ());

VariableInt.Set("TitanY", VariableFloat("MC_Y").ConvertToInt());
VariableInt.Add("TitanY", 500);

VariableBool.Set("Titan_Safety", false);
While(Bool.Equals(VariableBool("Titan_Safety"), false))
{
VariableInt.SetRandom("TitanX", VariableFloat("X-").ConvertToInt(), VariableFloat("X+").ConvertToInt());
If(Int.GreaterThan(VariableInt("TitanX"), VariableFloat("SafetyX+").ConvertToInt()))
{
VariableBool.Set("Titan_Safety", true);
}
If(Int.LessThan(VariableInt("TitanX"), VariableFloat("SafetyX-").ConvertToInt()))
{
VariableBool.Set("Titan_Safety", true);
}
}
VariableInt.Add("TitanX", VariableFloat("MC_X").ConvertToInt());

VariableBool.Set("Titan_Safety", false);
While(Bool.Equals(VariableBool("Titan_Safety"), false))
{
VariableInt.SetRandom("TitanZ", VariableFloat("Y-").ConvertToInt(), VariableFloat("Y+").ConvertToInt());
If(Int.GreaterThan(VariableInt("TitanZ"), VariableFloat("SafetyY+").ConvertToInt()))
{
VariableBool.Set("Titan_Safety", true);
}
If(Int.LessThan(VariableInt("TitanZ"), VariableFloat("SafetyY-").ConvertToInt()))
{
VariableBool.Set("Titan_Safety", true);
}
}
VariableInt.Add("TitanZ", VariableFloat("MC_Z").ConvertToInt());



}

// Set random titan cords based on a float
If(String.Equals(VariableString("input"), "/setrandomtitancordsfloat"))
{
VariableFloat.Set("MC_X", VariablePlayer("MCPlayer").GetPositionX());
VariableFloat.Set("MC_Y", VariablePlayer("MCPlayer").GetPositionY());
VariableFloat.Set("MC_Z", VariablePlayer("MCPlayer").GetPositionZ());

VariableFloat.Set("Titan_Y", VariableFloat("MC_Y"));
VariableFloat.Add("Titan_Y", 500.0);

VariableBool.Set("Titan_Safety", false);
While(Bool.Equals(VariableBool("Titan_Safety"), false))
{
VariableFloat.SetRandom("Titan_X", VariableFloat("X-"), VariableFloat("X+"));
If(Float.GreaterThan(VariableFloat("Titan_X"), VariableFloat("SafetyX+")))
{
VariableBool.Set("Titan_Safety", true);
}
If(Float.LessThan(VariableFloat("Titan_X"), VariableFloat("SafetyX-")))
{
VariableBool.Set("Titan_Safety", true);
}
}
VariableFloat.Add("Titan_X", VariableFloat("MC_X"));

VariableBool.Set("Titan_Safety", false);
While(Bool.Equals(VariableBool("Titan_Safety"), false))
{
VariableFloat.SetRandom("Titan_Z", VariableFloat("Y-"), VariableFloat("Y+"));
If(Float.GreaterThan(VariableFloat("Titan_Z"), VariableFloat("SafetyY+")))
{
VariableBool.Set("Titan_Safety", true);
}
If(Float.LessThan(VariableFloat("Titan_Z"), VariableFloat("SafetyY-")))
{
VariableBool.Set("Titan_Safety", true);
}
}
VariableFloat.Add("Titan_Z", VariableFloat("MC_Z"));

}

// Determine the player factor. This is used for generic titan spawners to increase / reduce the amount of titans spawned because of the players
If(String.Equals(VariableString("input"), "/setplayerfactor"))
{
If(Int.LessThan(VariableInt("TotalPlayers"), 10))
{
VariableFloat.Set("PlayerFactor", VariableFloat("PlayerFactorSmall"));
}

If(Int.LessThan(VariableInt("TotalPlayers"), 15))
{
If(Int.GreaterThanOrEqual(VariableInt("TotalPlayers"), 10))
{
VariableFloat.Set("PlayerFactor", VariableFloat("PlayerFactorMedium"));
}
}

If(Int.LessThan(VariableInt("TotalPlayers"), 20))
{
If(Int.GreaterThanOrEqual(VariableInt("TotalPlayers"), 15))
{
VariableFloat.Set("PlayerFactor", VariableFloat("PlayerFactorLarge"));
}
}

If(Int.GreaterThan(VariableInt("TotalPlayers"), 20))
{
VariableFloat.Set("PlayerFactor", VariableFloat("PlayerFactorExtreme"));
}
}

// Determine the amount of titans that should be spawned, based on the player factor.
If(String.Equals(VariableString("input"), "/settitanamount"))
{
VariableFloat.Set("TitanAmountF", VariableInt("TitanAmount").ConvertToFloat());
VariableFloat.Multiply("TitanAmountF", VariableFloat("PlayerFactor"));
VariableInt.Set("TitanAmount", VariableFloat("TitanAmountF").ConvertToInt());

// Titan health
VariableString.Concat("VariableF", "TitanAmountFactor", VariableInt("ExpeditionDifficulty").ConvertToString());
VariableFloat.Set("TitanAmountFactor", VariableFloat(VariableString("VariableF")));
VariableFloat.Multiply("TitanAmountFactor", VariableInt("TitanAmount").ConvertToFloat());
VariableInt.Set("TitanAmount", VariableFloat("TitanAmountFactor").ConvertToInt());
}

// Determine the titan size based on class
If(String.Equals(VariableString("input"), "/setrandomtitanhealth"))
{
VariableString.Concat("TitanClassMinHPVar", "TitanClass_HPMin", VariableInt("Titan_Class").ConvertToString());
VariableString.Concat("TitanClassMaxHPVar", "TitanClass_HPMax", VariableInt("Titan_Class").ConvertToString());
VariableInt.SetRandom("Titan_HP", VariableInt(VariableString("TitanClassMinHPVar")), VariableInt(VariableString("TitanClassMaxHPVar")));
}

// Determine the titan size based on class
If(String.Equals(VariableString("input"), "/settitanviewdistance"))
{
VariableString.Concat("Variable", "TitanClass_ViewDistance", VariableInt("Titan_Class").ConvertToString());
VariableInt.Set("Titan_ViewDistance", VariableInt(VariableString("Variable")));
}

// Determine the animation speed based on class
If(String.Equals(VariableString("input"), "/setrandomtitananimationspeed"))
{
VariableString.Concat("TitanClassMinAnimationVar", "TitanClass_MinAnimation", VariableInt("Titan_Class").ConvertToString());
VariableString.Concat("TitanClassMaxAnimationVar", "TitanClass_MaxAnimation", VariableInt("Titan_Class").ConvertToString());
VariableFloat.SetRandom("Titan_Animation", VariableFloat(VariableString("TitanClassMinAnimationVar")), VariableFloat(VariableString("TitanClassMaxAnimationVar")));
}

// Determine the titan size based on class
If(String.Equals(VariableString("input"), "/setrandomtitansize"))
{
VariableString.Concat("TitanClassMinSizeVar", "TitanClass_MinSize", VariableInt("Titan_Class").ConvertToString());
VariableString.Concat("TitanClassMaxSizeVar", "TitanClass_MaxSize", VariableInt("Titan_Class").ConvertToString());
VariableFloat.SetRandom("Titan_Size", VariableFloat(VariableString("TitanClassMinSizeVar")), VariableFloat(VariableString("TitanClassMaxSizeVar")));
}

// Determine the titan speed based on class and type
If(String.Equals(VariableString("input"), "/setrandomtitanspeed"))
{
VariableString.Concat("TitanClassMinSpeedVar", "TitanClass_MinSpeed", VariableInt("Titan_Class").ConvertToString());
VariableString.Concat("TitanClassMaxSpeedVar", "TitanClass_MaxSpeed", VariableInt("Titan_Class").ConvertToString());
VariableInt.SetRandom("Titan_Speed_Random", VariableInt(VariableString("TitanClassMinSpeedVar")), VariableInt(VariableString("TitanClassMaxSpeedVar")));
VariableInt.Add("Titan_Speed", VariableInt("Titan_Speed_Random"));
}

// Determine the titan speed based on class and type
If(String.Equals(VariableString("input"), "/settitanspeedbysize"))
{
VariableString.Concat("TitanSpeedXVar", "TitanSpeedX", VariableInt("Titan_Type").ConvertToString());
VariableString.Concat("TitanSpeedZVar", "TitanSpeedZ", VariableInt("Titan_Type").ConvertToString());

VariableFloat.Set("TitanSpeedF", VariableFloat("Titan_Size"));
VariableFloat.Multiply("TitanSpeedF", VariableFloat(VariableString("TitanSpeedXVar")));
VariableFloat.Add("TitanSpeedF", VariableFloat(VariableString("TitanSpeedZVar")));
VariableInt.Set("Titan_Speed", VariableFloat("TitanSpeedF").ConvertToInt());
}

// Determine the titan class and set its stats
If(String.Equals(VariableString("input"), "/setrandomtitanclass"))
{
VariableInt.SetRandom("RandomTitanClass", 0, 100);

If(Int.LessThanOrEqual(VariableInt("RandomTitanClass"), VariableInt("TitanClass_Chance0")))
{
  VariableInt.Set("Titan_Class", 0);
}

If(Int.LessThanOrEqual(VariableInt("RandomTitanClass"), VariableInt("TitanClass_Chance1")))
{
If(Int.GreaterThan(VariableInt("RandomTitanClass"), VariableInt("TitanClass_Chance0")))
{
  VariableInt.Set("Titan_Class", 1);
}
}

If(Int.LessThanOrEqual(VariableInt("RandomTitanClass"), VariableInt("TitanClass_Chance2")))
{
If(Int.GreaterThan(VariableInt("RandomTitanClass"), VariableInt("TitanClass_Chance1")))
{
  VariableInt.Set("Titan_Class", 2);
}
}

If(Int.LessThanOrEqual(VariableInt("RandomTitanClass"), VariableInt("TitanClass_Chance3")))
{
If(Int.GreaterThan(VariableInt("RandomTitanClass"), VariableInt("TitanClass_Chance2")))
{
  VariableInt.Set("Titan_Class", 3);
}
}


}

// Set a random titan type
If(String.Equals(VariableString("input"), "/setrandomtitantype"))
{
VariableInt.SetRandom("RandomTitanType", 0, 100);

If(Int.LessThanOrEqual(VariableInt("RandomTitanClass"), VariableInt("TitanType0")))
{
VariableInt.Set("Titan_Type", 0);
}

If(Int.LessThanOrEqual(VariableInt("RandomTitanClass"), VariableInt("TitanType1")))
{
If(Int.GreaterThan(VariableInt("RandomTitanClass"), VariableInt("TitanType0")))
{
VariableInt.Set("Titan_Type", 1);
}
}

If(Int.LessThanOrEqual(VariableInt("RandomTitanClass"), VariableInt("TitanType2")))
{
If(Int.GreaterThan(VariableInt("RandomTitanClass"), VariableInt("TitanType1")))
{
VariableInt.Set("Titan_Type", 2);
}
}

If(Int.LessThanOrEqual(VariableInt("RandomTitanClass"), VariableInt("TitanType3")))
{
If(Int.GreaterThan(VariableInt("RandomTitanClass"), VariableInt("TitanType2")))
{
VariableInt.Set("Titan_Type", 3);
}
}

If(Int.LessThanOrEqual(VariableInt("RandomTitanClass"), VariableInt("TitanType4")))
{
If(Int.GreaterThan(VariableInt("RandomTitanClass"), VariableInt("TitanType3")))
{
VariableInt.Set("Titan_Type", 4);
}
}

}

// Set random titan skin
If(String.Equals(VariableString("input"), "/setrandomtitanskin"))
{
VariableInt.SetRandom("TitanEyeRandom", 1, VariableInt("TitanEyes"));
VariableString.Concat("Titan_Eye_Temp", "TitanEye", VariableInt("TitanEyeRandom").ConvertToString());
VariableString.Set("Titan_Eye", VariableString("Titan_Eye_Temp"));

VariableInt.SetRandom("TitanSkinRandom", 1, VariableInt("TitanSkins"));
VariableString.Concat("Titan_Skin_Temp", "TitanSkin", VariableInt("TitanSkinRandom").ConvertToString());
VariableString.Set("Titan_Skin", VariableString("Titan_Skin_Temp"));
}

// Set random titan skin
If(String.Equals(VariableString("input"), "/settitanattributesbyexpeditiondifficulty"))
{

// Titan health
VariableString.Concat("VariableF", "HealthFactor", VariableInt("ExpeditionDifficulty").ConvertToString());
VariableFloat.Set("HealthFactor", VariableFloat(VariableString("VariableF")));
VariableFloat.Multiply("HealthFactor", VariableInt("Titan_HP").ConvertToFloat());
VariableInt.Set("Titan_HP", VariableFloat("HealthFactor").ConvertToInt());

  // Titan speed
VariableString.Concat("VariableF", "SpeedFactor", VariableInt("ExpeditionDifficulty").ConvertToString());
VariableFloat.Set("SpeedFactor", VariableFloat(VariableString("VariableF")));
VariableFloat.Multiply("SpeedFactor", VariableInt("Titan_Speed").ConvertToFloat());
VariableInt.Set("Titan_Speed", VariableFloat("SpeedFactor").ConvertToInt());

// View distance
VariableString.Concat("VariableF", "ViewDistanceFactor", VariableInt("ExpeditionDifficulty").ConvertToString());
VariableFloat.Set("ViewDistanceFactor", VariableFloat(VariableString("VariableF")));
VariableFloat.Multiply("ViewDistanceFactor", VariableInt("Titan_ViewDistance").ConvertToFloat());
VariableInt.Set("Titan_ViewDistance", VariableFloat("ViewDistanceFactor").ConvertToInt());

}

// Set some default values again
If(String.Equals(VariableString("input"), "/resettitanvalues"))
{
VariableString.Set("Titan_Eye", "");
VariableString.Set("Titan_Skin", "");
VariableFloat.Set("Titan_Animation", 1.0);
}

// Spawn an EM titan
If(String.Equals(VariableString("input"), "/spawntitan"))
{
Game.PrintMessage("EM/Commands//setrandomtitanclass");
Game.PrintMessage("EM/Commands//setrandomtitantype");

If(Bool.Equals(VariableBool("EnableTitanHealth"), true))
{
Game.PrintMessage("EM/Commands//setrandomtitanhealth");
}

Game.PrintMessage("EM/Commands//setrandomtitansize");
Game.PrintMessage("EM/Commands//settitanspeedbysize");

If(Bool.Equals(VariableBool("EnableTitanViewDistance"), true))
{
Game.PrintMessage("EM/Commands//settitanviewdistance");
}

If(Bool.Equals(VariableBool("EnableRandomTitanSpeed"), true))
{
Game.PrintMessage("EM/Commands//setrandomtitanspeed");
}
If(Bool.Equals(VariableBool("EnableRandomTitanSkins"), true))
{
Game.PrintMessage("EM/Commands//setrandomtitanskin");
}
If(Bool.Equals(VariableBool("EnableRandomTitanAnimation"), true))
{
Game.PrintMessage("EM/Commands//setrandomtitananimationspeed");
}

Game.PrintMessage("EM/Commands//settitanattributesbyexpeditiondifficulty");

If(Bool.Equals(VariableBool("EnableTitanViewDistance"), false))
{
VariableInt.Set("Titan_ViewDistance", 99999);
}

If(Bool.Equals(VariableBool("EnableTitanHealth"), false))
{
VariableInt.Set("Titan_HP", 0); // setting this value to 0 makes titans follow the RC settings, so 10 is the lowest valid input
}

VariableString.Concat("TitanSpawner", "EM/Commands//sptit[-]", VariableInt("Titan_Type").ConvertToString() ,"[-]",VariableFloat("Titan_Size").ConvertToString(),"[-]", VariableInt("Titan_HP").ConvertToString(),"[-]", VariableInt("Titan_Speed").ConvertToString(),"[-]1[-]", VariableInt("Titan_ViewDistance").ConvertToString() ,"[-]0[-]", VariableInt("TitanX").ConvertToString(), "[-]", VariableInt("TitanY").ConvertToString(), " ", VariableInt("TitanZ").ConvertToString(), "[-]1[-]", VariableString(VariableString("Titan_Skin")), "[-]", VariableString(VariableString("Titan_Eye")), "[-]", VariableFloat("Titan_Animation").ConvertToString());
Game.PrintMessage(VariableString("TitanSpawner"));
Game.PrintMessage("EM/Commands//resettitanvalues");
}

// Set values specific for the region commands
If(String.Equals(VariableString("input"), "/spawntitanregion"))
{
VariableInt.Set("TitanX", RegionRandomX(VariableString("Region")).ConvertToInt());
VariableInt.Set("TitanY", RegionRandomY(VariableString("Region")).ConvertToInt());
VariableInt.Set("TitanZ", RegionRandomZ(VariableString("Region")).ConvertToInt());
Game.PrintMessage("EM/Commands//spawntitan");
}

// This is how to spawn a titan inside a mc region with the /sptit command
If(String.Equals(VariableString("input"), "/spawntitanmc"))
{
Game.PrintMessage("EM/Commands//setrandomtitancords");
Game.PrintMessage("EM/Commands//spawntitan");
}

}


// MISC - Other commands
If(String.StartsWith(VariableString("input"), "/"))
{
// Daylight
If(String.Equals(VariableString("input"),"/day"))
{
Game.PrintMessage("<b>[<color=#F2C00E>Time</color><color=#FFFFFF>]: Daylight has arrived!</color></b>");
Game.PrintMessage("EM/Commands//setdaylightcolor[-]0[d]6");
Game.PrintMessage("EM/Commands//skybox[-]https://cdn[d]discordapp[d]com/attachments/312353767074955266/513077338582548481/unknown[d]png[-]https://cdn[d]discordapp[d]com/attachments/312353767074955266/513077416344813591/unknown[d]png[-]https://cdn[d]discordapp[d]com/attachments/312353767074955266/513077451140890634/unknown[d]png[-]https://cdn[d]discordapp[d]com/attachments/312353767074955266/513077380630446090/unknown[d]png[-]https://cdn[d]discordapp[d]com/attachments/312353767074955266/513434233449218073/temp[d]jpg[-]https://cdn[d]discordapp[d]com/attachments/312353767074955266/513434233449218073/temp[d]jpg")
}

// Nighttime
If(String.Equals(VariableString("input"),"/night"))
{
Game.PrintMessage("<b>[<color=#F2C00E>Time</color><color=#FFFFFF>]: Darkness has arrived!</color></b>");
Game.PrintMessage("<b>[<color=#2ECC71>Command</color><color=#FFFFFF>]: Equip your flash flares!</color></b>");
Game.PrintMessage("EM/Commands//setdaylightcolor[-]0[d]02");
Game.PrintMessage("EM/Commands//skybox[-]http://t[d]motionelements[d]com/stock-video/nature/me2448083-stars-black-sky-hd-a0540-poster[d]jpg[-]http://t[d]motionelements[d]com/stock-video/nature/me2448083-stars-black-sky-hd-a0540-poster[d]jpg[-]http://t[d]motionelements[d]com/stock-video/nature/me2448083-stars-black-sky-hd-a0540-poster[d]jpg[-]http://t[d]motionelements[d]com/stock-video/nature/me2448083-stars-black-sky-hd-a0540-poster[d]jpg[-]http://t[d]motionelements[d]com/stock-video/nature/me2448083-stars-black-sky-hd-a0540-poster[d]jpg[-]http://t[d]motionelements[d]com/stock-video/nature/me2448083-stars-black-sky-hd-a0540-poster[d]jpg")
}

// Set generic variable
If(String.Equals(VariableString("input"),"/setvariable"))
{
VariableBool.Set("SetVariableNameValue", true);
Game.PrintMessage("<b><color=#D46565>[LOGIC]</color>: Enter a variable name:</b>");
}

}

// Generic regions - Generic region commands
If(String.StartsWith(VariableString("input"), "/"))
{

If(String.Equals(VariableString("input"), "/hregion"))
{
Game.PrintMessage("<b><i><color=#000000>** --- Dynamic region commands --- **</color></i></b>");
Game.PrintMessage("<i><color=#000000>--- Dynamic region allows you to spawn titans anywhere based on your location --- **</color></i>");
Game.PrintMessage("<color=#ffff00> --- /checkregion > Check current dynamic region cords</color>");
Game.PrintMessage("<color=#ffff00> --- /setxp[NUM] > Set the X+ cord</color>");
Game.PrintMessage("<color=#ffff00> --- /setxn[NUM] > Set the X- cord</color>");
Game.PrintMessage("<color=#ffff00> --- /setyp[NUM] > Set the Y+ cord</color>");
Game.PrintMessage("<color=#ffff00> --- /setyn[NUM] > Set the Y- cord</color>");
Game.PrintMessage("<color=#ffff00> --- /scheckregion > Check current dynamic safety region cords</color>");
Game.PrintMessage("<color=#ffff00> --- /ssetxp[NUM] > Set the Safety X+ cord</color>");
Game.PrintMessage("<color=#ffff00> --- /ssetxn[NUM] > Set the Safety X- cord</color>");
Game.PrintMessage("<color=#ffff00> --- /ssetyp[NUM] > Set the Safety Y+ cord</color>");
Game.PrintMessage("<color=#ffff00> --- /ssetyn[NUM] > Set the Safety Y- cord</color>");
}

// Check the current values of the regions
If(String.Equals(VariableString("input"), "/checkregion"))
{
VariableInt.Set("IntX+", VariableFloat("X+").ConvertToInt());
VariableInt.Set("IntX-", VariableFloat("X-").ConvertToInt());
VariableInt.Set("IntY+", VariableFloat("Y+").ConvertToInt());
VariableInt.Set("IntY-", VariableFloat("Y-").ConvertToInt());
VariableString.Concat("Message", "X   ", VariableInt("IntX-").ConvertToString(), " until ", VariableInt("IntX+").ConvertToString());
Game.PrintMessage(VariableString("Message"));
VariableString.Concat("Message", "Y   ", VariableInt("IntY-").ConvertToString(), " until ", VariableInt("IntY+").ConvertToString());
Game.PrintMessage(VariableString("Message"));
}

// Check the current values of the regions
If(String.Equals(VariableString("input"), "/scheckregion"))
{
VariableInt.Set("IntX+", VariableFloat("SafetyX+").ConvertToInt());
VariableInt.Set("IntX-", VariableFloat("SafetyX-").ConvertToInt());
VariableInt.Set("IntY+", VariableFloat("SafetyY+").ConvertToInt());
VariableInt.Set("IntY-", VariableFloat("SafetyY-").ConvertToInt());
VariableString.Concat("Message", "X   ", VariableInt("IntX-").ConvertToString(), " until ", VariableInt("IntX+").ConvertToString());
Game.PrintMessage(VariableString("Message"));
VariableString.Concat("Message", "Y   ", VariableInt("IntY-").ConvertToString(), " until ", VariableInt("IntY+").ConvertToString());
Game.PrintMessage(VariableString("Message"));
}

// Generic MC based region commands
If(String.StartsWith(VariableString("input"), "/setxp"))
{
VariableString.Remove("input", "/setxp");
VariableFloat.Set("X+", VariableString("input").ConvertToFloat());
}

If(String.StartsWith(VariableString("input"), "/setxn"))
{
VariableString.Remove("input", "/setxn");
VariableFloat.Set("X-", VariableString("input").ConvertToFloat());
}

If(String.StartsWith(VariableString("input"), "/setyp"))
{
VariableString.Remove("input", "/setyp");
VariableFloat.Set("Y+", VariableString("input").ConvertToFloat());
}

If(String.StartsWith(VariableString("input"), "/setyn"))
{
VariableString.Remove("input", "/setyn");
VariableFloat.Set("Y-", VariableString("input").ConvertToFloat());
}

// SS = Set Safetyzone
If(String.StartsWith(VariableString("input"), "/ssetxp"))
{
VariableString.Remove("input", "/ssetxp");
VariableFloat.Set("SafetyX+", VariableString("input").ConvertToFloat());
}

If(String.StartsWith(VariableString("input"), "/ssetxn"))
{
VariableString.Remove("input", "/ssetxn");
VariableFloat.Set("SafetyX-", VariableString("input").ConvertToFloat());
}

If(String.StartsWith(VariableString("input"), "/ssetyp"))
{
VariableString.Remove("input", "/ssetyp");
VariableFloat.Set("SafetyY+", VariableString("input").ConvertToFloat());
}

If(String.StartsWith(VariableString("input"), "/ssetyn"))
{
VariableString.Remove("input", "/ssetyn");
VariableFloat.Set("SafetyY-", VariableString("input").ConvertToFloat());
}

}


// Commander Commands
If(String.StartsWith(VariableString("input"), "/"))
{


If(String.Equals(VariableString("input"),"/ready"))
{
Game.PrintMessage("<size=16>[<color=#86d493>COMMAND</color>]: Section Commanders deploy <color=#2881ff>Blue Flare</color> when your position is ready!</size>");
}

If(String.Equals(VariableString("input"),"/b"))
{
Game.PrintMessage("<size=20>[<color=#2881ff>BLUE FLARE</color>]: Fall back!</size>");
}

If(String.Equals(VariableString("input"),"/fl"))
{
Game.PrintMessage("<size=16><color=#86d493>COMMAND</color>: Fire green flares to the <b>LEFT</b>!</size>");
}

If(String.Equals(VariableString("input"),"/fr"))
{
Game.PrintMessage("<size=16><color=#86d493>COMMAND</color>: Fire green flares to the <b>RIGHT</b>!</size>");
}

If(String.Equals(VariableString("input"),"/ff"))
{
Game.PrintMessage("<size=16><color=#86d493>COMMAND</color>: Fire green flares FORWARD!</size>");
}

If(String.Equals(VariableString("input"),"/y"))
{
Game.PrintMessage("<size=18>[<color=#f4e129>YELLOW FLARE</color>]: Mission succes!</size>");
}

If(String.Equals(VariableString("input"),"/lf"))
{
Game.PrintMessage("[<color=#0061e7>LW</color>]: Move further from the center!");
}

If(String.Equals(VariableString("input"),"/lc"))
{
Game.PrintMessage("[<color=#0061e7>LW</color>]: Get Closer To Center!");
}

If(String.Equals(VariableString("input"),"/le"))
{
Game.PrintMessage("[<color=#0061e7>LW</color>]: Engage!");
}

If(String.Equals(VariableString("input"),"/lce"))
{
Game.PrintMessage("[<color=#0061e7>LW</color>]: Engage_Titans At Center!");
}

If(String.Equals(VariableString("input"),"/rf"))
{
Game.PrintMessage("[<color=#cc2e71>RW</color>]: Move further from the center!");
}

If(String.Equals(VariableString("input"),"/rc"))
{
Game.PrintMessage("[<color=#cc2e71>RW</color>]: Get Closer To Center!");
}

If(String.Equals(VariableString("input"),"/re"))
{
Game.PrintMessage("[<color=#cc2e71>RW</color>]: Engage!");
}

If(String.Equals(VariableString("input"),"/rce"))
{
Game.PrintMessage("[<color=#cc2e71>RW</color>]: Engage Titans At Center!");
}

If(String.Equals(VariableString("input"),"/ve"))
{
Game.PrintMessage("[<color=#d8bb0c>VANGUARD</color>]: <size=15>Engage</size>!");
}

If(String.Equals(VariableString("input"),"/vr"))
{
Game.PrintMessage("[<color=#d8bb0c>VANGUARD</color>]: <size=15>Regroup</size>!");
}

If(String.Equals(VariableString("input"),"/vf"))
{
Game.PrintMessage("[<color=#d8bb0c>VANGUARD</color>]: Move further from the center!!");
}

If(String.Equals(VariableString("input"),"/vc"))
{
Game.PrintMessage("[<color=#d8bb0c>VANGUARD</color>]: Move close to the center!");
}

If(String.Equals(VariableString("input"),"/sr"))
{
Game.PrintMessage("[<color=#ff6400>SUPPORT</color>]: Right Wing!");
}

If(String.Equals(VariableString("input"),"/sl"))
{
Game.PrintMessage("[<color=#ff6400>SUPPORT</color>]: Left Wing!");
}

If(String.Equals(VariableString("input"),"/sv"))
{
Game.PrintMessage("[<color=#ff6400>SUPPORT</color>]: Vanguard");
}

If(String.Equals(VariableString("input"),"/g"))
{
Game.PrintMessage("[<color=#ff6400>COMMAND</color>]: ALL FIRE <color=#00ff00>GREEN</color> FLARES");
}

If(String.Equals(VariableString("input"),"/sg"))
{
Game.PrintMessage("[<color=#ff6400>SUPPORT</color>]: Rear Guard!");
}

If(String.Equals(VariableString("input"),"/sce"))
{
Game.PrintMessage("[<color=#ff6400>SUPPORT</color>]: Engage Titans At Center!");
}

If(String.Equals(VariableString("input"),"/sc"))
{
Game.PrintMessage("[<color=#ff6400>SUPPORT</color>]: Move to center!");
}

If(String.Equals(VariableString("input"),"/gr"))
{
Game.PrintMessage("[<color=#7e1b75>REAR GUARD</color>]: Help the Right Wing!");
}

If(String.Equals(VariableString("input"),"/gl"))
{
Game.PrintMessage("[<color=#7e1b75>REAR GUARD</color>]: Help the Left Wing!");
}

If(String.Equals(VariableString("input"),"/gc"))
{
Game.PrintMessage("[<color=#7e1b75>REAR GUARD</color>]: Help the Center!");
}

If(String.Equals(VariableString("input"),"/lrf"))
{
Game.PrintMessage("<color=#2ecc71><size=20>Form Long Range Formation!</size></color>");
}

If(String.Equals(VariableString("input"),"/crf"))
{
Game.PrintMessage("<color=#2ecc71><size=20>Form Close Range Formation!</size></color>");
}

}


If(String.Equals(VariableString("input"),"/move"))
{
Game.PrintMessage("EM/Commands/moveobjects[-]Gate[-]-1620[-]60[-]12522[-]0[-]90[-]0[-]-4[-]0[-]0");
Game.PrintMessage("EM/Commands/moveobjects[-]Bells[-]-2004[-]60[-]9298[-]0[-]90[-]0[-]-4[-]0[-]0");
}

If(String.Equals(VariableString("input"),"/rocks"))
{
Game.PrintMessage("EM/Commands/moveobjects[-]RockTrap[-]-8085[-]1200[-]56316[-]0[-]90[-]0[-]-4[-]0[-]0");
}


// Medic
    If(String.StartsWith(VariableString("input"), "/medic"))
    {
        VariableString.Remove("input", "/medic");
        VariablePlayer.Set("player", VariablePlayer("null"));
        ForeachPlayer("player")
        {
            VariableBool.Set("passNotMedic", false);
            If(String.Contains(VariablePlayer("player").GetName(), VariableString("input")))
            {
                If(String.NotEquals(VariablePlayer("player").GetGuildName(), "[ffffff][ffffff]Medic"))
                {
                    Player.SetGuildName(VariablePlayer("player"), "[ffffff][ffffff]Medic");
                    VariableString.Concat("AM", VariableString("input"), "_is_now_medic");
                    Game.PrintMessage(VariableString("AM"));
                    VariableBool.Set("passNotMedic", true);
                }
                If(Bool.Equals(VariableBool("passNotMedic"), false))
                {
                    If(String.Equals(VariablePlayer("player").GetGuildName(), "[ffffff][ffffff]Medic"))
                    {
                        Player.SetGuildName(VariablePlayer("player"), "");
                        VariableString.Concat("ANM", VariableString("input"), "_is_not_medic");
                        Game.PrintMessage(VariableString("ANM"));
                    }
                }  
            }  
        }
    }

// ADD MAP SPECIFIC LOGIC HERE
// Here are a few examples

// Spawn annie by command
If(String.Equals(VariableString("input"),"/annie"))
{
Game.PrintMessage("EM/Commands//annie[-]5467[-]0[-]7941[-]3666[-]5[-]80[-]180[-]20[-]0[-]60");
VariableString.Set("Message", "EM/Commands//pm[-]1[-]Annie[-]is[-]spawned[-]");
Game.PrintMessage("EM/Commands//pm[-]1[-]Annie[-]is[-]spawned[-]");
}

If(String.Equals(VariableString("input"),"/swamp"))
{

  // -- TITAN CLASS TYPES --
  VariableInt.Set("TitanClass_Chance0", 100); // 10
  VariableInt.Set("TitanClass_Chance1", 101); // 45
  VariableInt.Set("TitanClass_Chance2", 102); // 95
  VariableInt.Set("TitanClass_Chance3", 103); // 100
  
Game.PrintMessage("EM/Commands//titans15");

  VariableInt.Set("TitanClass_Chance0", 10); // 10
  VariableInt.Set("TitanClass_Chance1", 45); // 45
  VariableInt.Set("TitanClass_Chance2", 95); // 95
  VariableInt.Set("TitanClass_Chance3", 100); // 100

}

If(String.Equals(VariableString("input"),"/forest"))
{
VariableFloat.Set("TitanSpeedZ0", 30.900); // Default 6.900
VariableFloat.Set("TitanSpeedZ1", 40.03); // Default 20.03
VariableFloat.Set("TitanSpeedZ2", 40.03); // Default 20.03
VariableFloat.Set("TitanSpeedZ3", 70.47); // Default 40.47
VariableFloat.Set("TitanSpeedZ4", 50.03); // Default 20.03
  
Game.PrintMessage("EM/Commands//titans15");
  
VariableFloat.Set("TitanSpeedZ0", 6.900); // Default 6.900
VariableFloat.Set("TitanSpeedZ1", 20.03); // Default 20.03
VariableFloat.Set("TitanSpeedZ2", 20.03); // Default 20.03
VariableFloat.Set("TitanSpeedZ3", 40.47); // Default 40.47
VariableFloat.Set("TitanSpeedZ4", 20.03); // Default 20.03
}

If(String.Equals(VariableString("input"),"/hell"))
{
VariableString.Concat("TSP", "EM/Commands//sptit[-]4[-]4[-]500[-]10[-]1[-]99999[-]0[-]37288[-]2000[-]77712[-]1");
Game.PrintMessage(VariableString("TSP"));
VariableString.Concat("TSP", "EM/Commands//sptit[-]4[-]4[-]500[-]10[-]1[-]99999[-]0[-]37288[-]2000[-]77212[-]1");
Game.PrintMessage(VariableString("TSP"));
VariableString.Concat("TSP", "EM/Commands//sptit[-]4[-]4[-]500[-]10[-]1[-]99999[-]0[-]37288[-]2000[-]76712[-]1");
Game.PrintMessage(VariableString("TSP"));
VariableString.Concat("TSP", "EM/Commands//sptit[-]4[-]4[-]500[-]10[-]1[-]99999[-]0[-]37288[-]2000[-]78712[-]1");
Game.PrintMessage(VariableString("TSP"));
VariableString.Concat("TSP", "EM/Commands//sptit[-]4[-]4[-]500[-]10[-]1[-]99999[-]0[-]37288[-]2000[-]76712[-]1");
Game.PrintMessage(VariableString("TSP"));

VariableString.Concat("TSP", "EM/Commands//sptit[-]4[-]4[-]500[-]10[-]1[-]99999[-]0[-]35288[-]2000[-]77712[-]1");
Game.PrintMessage(VariableString("TSP"));
VariableString.Concat("TSP", "EM/Commands//sptit[-]4[-]4[-]500[-]10[-]1[-]99999[-]0[-]35288[-]2000[-]77212[-]1");
Game.PrintMessage(VariableString("TSP"));
VariableString.Concat("TSP", "EM/Commands//sptit[-]4[-]4[-]500[-]10[-]1[-]99999[-]0[-]35288[-]2000[-]76712[-]1");
Game.PrintMessage(VariableString("TSP"));
VariableString.Concat("TSP", "EM/Commands//sptit[-]4[-]4[-]500[-]10[-]1[-]99999[-]0[-]35288[-]2000[-]78712[-]1");
Game.PrintMessage(VariableString("TSP"));
VariableString.Concat("TSP", "EM/Commands//sptit[-]4[-]4[-]500[-]10[-]1[-]99999[-]0[-]35288[-]2000[-]76712[-]1");
Game.PrintMessage(VariableString("TSP"));

VariableString.Concat("TSP", "EM/Commands//sptit[-]4[-]4[-]500[-]5[-]1[-]99999[-]0[-]36288[-]2000[-]78712[-]1");
Game.PrintMessage(VariableString("TSP"));
VariableString.Concat("TSP", "EM/Commands//sptit[-]4[-]4[-]500[-]5[-]1[-]99999[-]0[-]36288[-]2000[-]76712[-]1");
Game.PrintMessage(VariableString("TSP"));
}

If(String.Equals(VariableString("input"),"/ft"))
{
Game.PrintMessage("EM/Commands/moveobjects[-]Snowfall[-]-5563[-]-1000[-]105963[-]0[-]0[-]0[-]0[-]0[-]0");
Game.PrintMessage("EM/Commands/moveobjects[-]FT[-]36288[-]1000[-]77712[-]0[-]90[-]0[-]-4[-]0[-]0");
}

If(String.Equals(VariableString("input"),"/dft"))
{
Game.PrintMessage("EM/Commands/moveobjects[-]FT[-]0[-]10000[-]0[-]0[-]90[-]0[-]-4[-]0[-]0");
}

// DESERT
If(String.Equals(VariableString("input"),"/setflashall"))
{
VariableInt.Set("hsloop", 100);
While(VariableInt.GreaterThan(VariableInt("hsloop"), 0))
{
VariableString.Concat("hsz", "EM/Commands//givelight[-]", VariableInt("hsloop").ConvertToString(),"[-]1");
Game.PrintMessage(VariableString("hsz"));
VariableInt.Subtract("hsloop", 1);
}
}

If(String.Equals(VariableString("input"),"/setdark"))
{
Game.PrintMessage("EM/Commands//night");
Game.PrintMessage("EM/Commands//setflashall");
}

// BOSSES UPDATE

If(String.Equals(VariableString("input"),"/crawler"))
{
Game.PrintMessage("<size=15><color=#2ecc71>Welcome to the Expeditions Beyond the Walls!</color></size>");
ForeachPlayer("CPlayer")
{
VariableFloat.Set("CP_X", VariablePlayer("CPlayer").GetPositionX());
VariableFloat.Set("CP_Y", VariablePlayer("CPlayer").GetPositionY());
VariableFloat.Set("CP_Z", VariablePlayer("CPlayer").GetPositionZ());
VariableFloat.Add("CP_Y", 500.0);
Titan.SpawnTitanAt(3, 2.0, VariableInt("TitanClass_HPMax0"), 1, VariableFloat("CP_X"),VariableFloat("CP_Y"),VariableFloat("CP_Z"));
}
}

If(String.Equals(VariableString("input"),"/chaser"))
{
Game.PrintMessage("EM/Commands//setrandomtitancords");
VariableString.Concat("TitanSpawner", "EM/Commands//sptit[-]1[-]", VariableFloat("UnkillableTitanSize").ConvertToString(),"[-]", VariableInt("UnkillableTitanHealth").ConvertToString(),"[-]35[-]1[-]", VariableInt("Titan_ViewDistance").ConvertToString() ,"[-]0[-]", VariableInt("TitanX").ConvertToString(), "[-]", VariableInt("TitanY").ConvertToString(), " ", VariableInt("TitanZ").ConvertToString(), "[-]1[-]https://i[d]imgur[d]com/b4Rsfxz[d]jpg[-]https://i[d]imgur[d]com/gUnCyHr[d]png");
Game.PrintMessage(VariableString("TitanSpawner"));
Game.PrintMessage("EM/Commands//resettitanvalues");
}

If(String.Equals(VariableString("input"),"/santa"))
{
Game.PrintMessage("EM/Commands//setrandomtitancords");
VariableString.Concat("TitanSpawner", "EM/Commands//sptit[-]4[-]", VariableFloat("SantaSize").ConvertToString(),"[-]50000[-]35[-]1[-]", VariableInt("Titan_ViewDistance").ConvertToString() ,"[-]0[-]", VariableInt("TitanX").ConvertToString(), "[-]", VariableInt("TitanY").ConvertToString(), " ", VariableInt("TitanZ").ConvertToString(), "[-]1[-]http://i[d]imgur[d]com/mUGtBT6[d]jpg[-]https://i[d]imgur[d]com/gUnCyHr[d]png[-]1[d]5");
Game.PrintMessage(VariableString("TitanSpawner"));
Game.PrintMessage("EM/Commands//resettitanvalues");
}

If(String.Equals(VariableString("input"),"/colossal"))
{
Game.PrintMessage("EM/Commands//setrandomtitancords");
VariableString.Concat("TitanSpawner", "EM/Commands//sptit[-]0[-]", VariableFloat("ColossalSize").ConvertToString(),"[-]99999[-]6[-]1[-]", VariableInt("Titan_ViewDistance").ConvertToString() ,"[-]0[-]", VariableInt("TitanX").ConvertToString(), "[-]", VariableInt("TitanY").ConvertToString(), " ", VariableInt("TitanZ").ConvertToString(), "[-]1[-]http://i[d]imgur[d]com/uiv1No3[d]jpg[-]https://i[d]imgur[d]com/1U6Gg2Y[d]png[-]0[d]5");
Game.PrintMessage(VariableString("TitanSpawner"));
Game.PrintMessage("EM/Commands//resettitanvalues");
}

If(String.Equals(VariableString("input"),"/beast"))
{
Game.PrintMessage("EM/Commands//setrandomtitancords");
VariableString.Concat("TitanSpawner", "EM/Commands//sptit[-]4[-]", VariableFloat("BeastSize").ConvertToString(),"[-]66666[-]60[-]1[-]", VariableInt("Titan_ViewDistance").ConvertToString() ,"[-]0[-]", VariableInt("TitanX").ConvertToString(), "[-]", VariableInt("TitanY").ConvertToString(), " ", VariableInt("TitanZ").ConvertToString(), "[-]1[-]http://i[d]imgur[d]com/hQ7nt16[d]png[-]https://i[d]imgur[d]com/SaO6Gze[d]png[-]1[d]5");
Game.PrintMessage(VariableString("TitanSpawner"));
Game.PrintMessage("EM/Commands//resettitanvalues");
}

}
