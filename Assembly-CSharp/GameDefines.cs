using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200018A RID: 394
[Token(Token = "0x200018A")]
public static class GameDefines
{
	// Token: 0x04000C2F RID: 3119
	[Token(Token = "0x4000C2F")]
	public const string DefaultDialog = "Assets/Main/DataTable/Localization/English/Dictionaries/Dialog.txt";

	// Token: 0x04000C30 RID: 3120
	[Token(Token = "0x4000C30")]
	public const int QualityLevel_Off = 0;

	// Token: 0x04000C31 RID: 3121
	[Token(Token = "0x4000C31")]
	public const int QualityLevel_Low = 1;

	// Token: 0x04000C32 RID: 3122
	[Token(Token = "0x4000C32")]
	public const int QualityLevel_Middle = 2;

	// Token: 0x04000C33 RID: 3123
	[Token(Token = "0x4000C33")]
	public const int QualityLevel_High = 3;

	// Token: 0x04000C34 RID: 3124
	[Token(Token = "0x4000C34")]
	public const string GrayMaterialName = "SpriteGray";

	// Token: 0x04000C35 RID: 3125
	[Token(Token = "0x4000C35")]
	public const float LookAtFocusTime = 0.4f;

	// Token: 0x04000C36 RID: 3126
	[Token(Token = "0x4000C36")]
	public const int Int32Bit = 32;

	// Token: 0x04000C37 RID: 3127
	[Token(Token = "0x4000C37")]
	public const int ByteSize = 8;

	// Token: 0x0200018B RID: 395
	[Token(Token = "0x200018B")]
	public class EntityAssets
	{
		// Token: 0x06000B31 RID: 2865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x3724754", Offset = "0x3724754", VA = "0x3724754")]
		public EntityAssets()
		{
		}

		// Token: 0x04000C38 RID: 3128
		[Token(Token = "0x4000C38")]
		public const string Building = "Assets/Main/Prefabs/Building/{0}.prefab";

		// Token: 0x04000C39 RID: 3129
		[Token(Token = "0x4000C39")]
		public const string AllianceBuilding = "Assets/Main/Prefabs/AllianceBuilding/{0}.prefab";

		// Token: 0x04000C3A RID: 3130
		[Token(Token = "0x4000C3A")]
		public const string WorldRoadRobot = "Assets/Main/Prefabs/World/WorldRoadRobot.prefab";

		// Token: 0x04000C3B RID: 3131
		[Token(Token = "0x4000C3B")]
		public const string WorldBuildingRobot = "Assets/Main/Prefabs/World/WorldBuildingRobot.prefab";

		// Token: 0x04000C3C RID: 3132
		[Token(Token = "0x4000C3C")]
		public const string TouchTerrainEffect = "Assets/Main/Prefabs/World/TouchTerrainEffect.prefab";

		// Token: 0x04000C3D RID: 3133
		[Token(Token = "0x4000C3D")]
		public const string HexTouchEffect = "Assets/Main/Prefabs/World/HexTouchEffect.prefab";

		// Token: 0x04000C3E RID: 3134
		[Token(Token = "0x4000C3E")]
		public const string WorldCityGrass = "Assets/Main/Prefabs/World/WorldCityGrass.prefab";

		// Token: 0x04000C3F RID: 3135
		[Token(Token = "0x4000C3F")]
		public const string BatteryAttackRange = "Assets/_Art/Effect/prefab/scene/Build/V_paota_fanwei.prefab";

		// Token: 0x04000C40 RID: 3136
		[Token(Token = "0x4000C40")]
		public const string QuanEffectRange = "Assets/Main/Prefabs/BuildEffect/V_zdbx_quan.prefab";

		// Token: 0x04000C41 RID: 3137
		[Token(Token = "0x4000C41")]
		public const string LandLock = "Assets/_Art/Models/Environment/Interactive/Massif/prefab/{0}";

		// Token: 0x04000C42 RID: 3138
		[Token(Token = "0x4000C42")]
		public const string World = "Assets/Main/Prefabs/World/Scene_World.prefab";

		// Token: 0x04000C43 RID: 3139
		[Token(Token = "0x4000C43")]
		public const string City = "Assets/Main/Prefabs/World/Scene_City.prefab";

		// Token: 0x04000C44 RID: 3140
		[Token(Token = "0x4000C44")]
		public const string WorldSceneDesc = "Assets/Main/Scenes/WorldSceneDesc.bytes";

		// Token: 0x04000C45 RID: 3141
		[Token(Token = "0x4000C45")]
		public const string WorldSceneAllianceCityDesc = "Assets/Main/Scenes/WorldSceneAllianceCityDesc.bytes";

		// Token: 0x04000C46 RID: 3142
		[Token(Token = "0x4000C46")]
		public const string LandLockDesc = "Assets/Main/Scenes/LandLockDesc.bytes";

		// Token: 0x04000C47 RID: 3143
		[Token(Token = "0x4000C47")]
		public const string WorldMapZone = "Assets/Main/Scenes/Zone/zone.bytes";

		// Token: 0x04000C48 RID: 3144
		[Token(Token = "0x4000C48")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Dictionary<int, string> WorldEdenMapArea;

		// Token: 0x04000C49 RID: 3145
		[Token(Token = "0x4000C49")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Dictionary<int, string> WorldEdenMapZone;

		// Token: 0x04000C4A RID: 3146
		[Token(Token = "0x4000C4A")]
		[FieldOffset(Offset = "0x10")]
		public static readonly Dictionary<int, string> WorldEdenSceneDesc;

		// Token: 0x04000C4B RID: 3147
		[Token(Token = "0x4000C4B")]
		public const string Terrain_World0_Low = "Assets/Main/Prefabs/World/Terrain_0.prefab";

		// Token: 0x04000C4C RID: 3148
		[Token(Token = "0x4000C4C")]
		public const string Terrain_World0_High = "Assets/Main/Prefabs/World/Terrain_0_High.prefab";

		// Token: 0x04000C4D RID: 3149
		[Token(Token = "0x4000C4D")]
		public const string TroopLine = "Assets/Main/Prefabs/March/TroopLine.prefab";

		// Token: 0x04000C4E RID: 3150
		[Token(Token = "0x4000C4E")]
		public const string TroopDestinationSignal = "Assets/Main/Prefabs/March/TroopDestinationSignal.prefab";

		// Token: 0x04000C4F RID: 3151
		[Token(Token = "0x4000C4F")]
		public const string TroopLineDrag = "Assets/Main/Prefabs/March/TroopLineDrag.prefab";

		// Token: 0x04000C50 RID: 3152
		[Token(Token = "0x4000C50")]
		public const string WorldTroop = "Assets/Main/Prefabs/March/WorldTroop.prefab";

		// Token: 0x04000C51 RID: 3153
		[Token(Token = "0x4000C51")]
		public const string MonsterActBoss = "Assets/Main/Prefabs/Monsters/MonsterActBoss.prefab";

		// Token: 0x04000C52 RID: 3154
		[Token(Token = "0x4000C52")]
		public const string WorldTroopAlliance = "Assets/Main/Prefabs/March/WorldTroopAlliance.prefab";

		// Token: 0x04000C53 RID: 3155
		[Token(Token = "0x4000C53")]
		public const string WorldTroopOther = "Assets/Main/Prefabs/March/WorldTroopOther.prefab";

		// Token: 0x04000C54 RID: 3156
		[Token(Token = "0x4000C54")]
		public const string WorldVirtualTroop = "Assets/Main/Prefabs/March/WorldVirtualTroop.prefab";

		// Token: 0x04000C55 RID: 3157
		[Token(Token = "0x4000C55")]
		public const string ScoutTroop = "Assets/Main/Prefabs/March/WorldRallyTroop.prefab";

		// Token: 0x04000C56 RID: 3158
		[Token(Token = "0x4000C56")]
		public const string ResTransTroop = "Assets/Main/Prefabs/March/WorldTroop.prefab";

		// Token: 0x04000C57 RID: 3159
		[Token(Token = "0x4000C57")]
		public const string GolloesExploreTroop = "Assets/Main/Prefabs/March/GolloesExploreTroop.prefab";

		// Token: 0x04000C58 RID: 3160
		[Token(Token = "0x4000C58")]
		public const string GolloesTradeTroop = "Assets/Main/Prefabs/March/WorldTroopScout.prefab";

		// Token: 0x04000C59 RID: 3161
		[Token(Token = "0x4000C59")]
		public const string WorldRallyTroop = "Assets/Main/Prefabs/March/WorldTroop.prefab";

		// Token: 0x04000C5A RID: 3162
		[Token(Token = "0x4000C5A")]
		public const string FieldMonster = "Assets/Main/Prefabs/Monsters/FieldMonster.prefab";

		// Token: 0x04000C5B RID: 3163
		[Token(Token = "0x4000C5B")]
		public const string FieldBoss = "Assets/Main/Prefabs/Monsters/FieldBoss.prefab";

		// Token: 0x04000C5C RID: 3164
		[Token(Token = "0x4000C5C")]
		public const string ConstructMaterial = "Assets/Main/Material/building_construct.mat";

		// Token: 0x04000C5D RID: 3165
		[Token(Token = "0x4000C5D")]
		public const string MonsterPath = "Assets/Main/Prefabs/Monsters/{0}.prefab";

		// Token: 0x04000C5E RID: 3166
		[Token(Token = "0x4000C5E")]
		public const string BuildBlock = "Assets/Main/Prefabs/Building/BuildBlock.prefab";

		// Token: 0x04000C5F RID: 3167
		[Token(Token = "0x4000C5F")]
		public const string WorldTroopSoldier = "Assets/Main/Prefabs/March/WorldTroopSoldier.prefab";

		// Token: 0x04000C60 RID: 3168
		[Token(Token = "0x4000C60")]
		public const string WorldTroopTank = "Assets/Main/Prefabs/March/WorldTroopTank.prefab";

		// Token: 0x04000C61 RID: 3169
		[Token(Token = "0x4000C61")]
		public const string WorldTroopPlane = "Assets/Main/Prefabs/March/WorldTroopPlane.prefab";

		// Token: 0x04000C62 RID: 3170
		[Token(Token = "0x4000C62")]
		public const string WorldTroopJunkman = "Assets/Main/Prefabs/March/WorldTroopJunkman.prefab";

		// Token: 0x04000C63 RID: 3171
		[Token(Token = "0x4000C63")]
		public const string CollectAnimalModel = "Assets/Main/Prefabs/CollectResource/CollectAnimalModel.prefab";

		// Token: 0x04000C64 RID: 3172
		[Token(Token = "0x4000C64")]
		public const string CollectArmyAnimalModel = "Assets/Main/Prefabs/CollectResource/CollectArmyAnimalModel.prefab";

		// Token: 0x04000C65 RID: 3173
		[Token(Token = "0x4000C65")]
		public const string CollectArmyAnimalModelAlliance = "Assets/Main/Prefabs/CollectResource/CollectArmyAnimalModelAlliance.prefab";

		// Token: 0x04000C66 RID: 3174
		[Token(Token = "0x4000C66")]
		public const string CollectArmyAnimalModelEnemy = "Assets/Main/Prefabs/CollectResource/CollectArmyAnimalModelEnemy.prefab";

		// Token: 0x04000C67 RID: 3175
		[Token(Token = "0x4000C67")]
		public const string BuildMetalFew = "Assets/Main/Prefabs/Building/BuildMetalFew.prefab";

		// Token: 0x04000C68 RID: 3176
		[Token(Token = "0x4000C68")]
		public const string BuildMetalMiddle = "Assets/Main/Prefabs/Building/BuildMetalMiddle.prefab";

		// Token: 0x04000C69 RID: 3177
		[Token(Token = "0x4000C69")]
		public const string BuildMetalMax = "Assets/Main/Prefabs/Building/BuildMetalMax.prefab";

		// Token: 0x04000C6A RID: 3178
		[Token(Token = "0x4000C6A")]
		public const string BuildWoodFew = "Assets/Main/Prefabs/Building/BuildWoodFew.prefab";

		// Token: 0x04000C6B RID: 3179
		[Token(Token = "0x4000C6B")]
		public const string BuildWoodMiddle = "Assets/Main/Prefabs/Building/BuildWoodMiddle.prefab";

		// Token: 0x04000C6C RID: 3180
		[Token(Token = "0x4000C6C")]
		public const string BuildWoodMax = "Assets/Main/Prefabs/Building/BuildWoodMax.prefab";

		// Token: 0x04000C6D RID: 3181
		[Token(Token = "0x4000C6D")]
		public const string DetectEventUI = "Assets/Main/Prefabs/March/WorldDetectInfo.prefab";

		// Token: 0x04000C6E RID: 3182
		[Token(Token = "0x4000C6E")]
		public const string CityGarbagePath = "Assets/Main/Prefabs/Garbage/{0}.prefab";

		// Token: 0x04000C6F RID: 3183
		[Token(Token = "0x4000C6F")]
		public const string CityTroop = "Assets/Main/Prefabs/March/CityTroop.prefab";

		// Token: 0x04000C70 RID: 3184
		[Token(Token = "0x4000C70")]
		public const string CollectGarbageUI = "Assets/Main/Prefabs/March/CollectGarbageUI.prefab";

		// Token: 0x04000C71 RID: 3185
		[Token(Token = "0x4000C71")]
		public const string CityWorkMan = "Assets/Main/Prefabs/CityScene/CityWorkMan.prefab";

		// Token: 0x04000C72 RID: 3186
		[Token(Token = "0x4000C72")]
		public const string FogPath = "Assets/Main/Prefabs/FogOfWar/{0}.prefab";

		// Token: 0x04000C73 RID: 3187
		[Token(Token = "0x4000C73")]
		public const string CityCameraSand = "Assets/Main/Prefabs/CityScene/CityCameraSand.prefab";

		// Token: 0x04000C74 RID: 3188
		[Token(Token = "0x4000C74")]
		public const string WorldCityTreeHigh = "Assets/Main/Prefabs/World/WorldCityTreeHigh{0}.prefab";

		// Token: 0x04000C75 RID: 3189
		[Token(Token = "0x4000C75")]
		public const string WorldCityTree = "Assets/Main/Prefabs/World/WorldCityTree{0}.prefab";

		// Token: 0x04000C76 RID: 3190
		[Token(Token = "0x4000C76")]
		public const string FocusCurve = "Assets/Main/Prefabs/CityScene/FocusCurve{0}.prefab";

		// Token: 0x04000C77 RID: 3191
		[Token(Token = "0x4000C77")]
		public const string LandLockFadeOut = "Assets/Main/Prefabs/World/LandLockFadeOut.prefab";

		// Token: 0x04000C78 RID: 3192
		[Token(Token = "0x4000C78")]
		public const string AllianceBossModel = "Assets/Main/Prefabs/Monsters/AllianceBoss.prefab";

		// Token: 0x04000C79 RID: 3193
		[Token(Token = "0x4000C79")]
		public const string normalWordPath = "Assets/Main/Prefabs/UI/BattleWord/BattleNormalBloodTip.prefab";
	}

	// Token: 0x0200018C RID: 396
	[Token(Token = "0x200018C")]
	public class UIAssets
	{
		// Token: 0x06000B33 RID: 2867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B33")]
		[Address(RVA = "0x3724960", Offset = "0x3724960", VA = "0x3724960")]
		public UIAssets()
		{
		}

		// Token: 0x04000C7A RID: 3194
		[Token(Token = "0x4000C7A")]
		public const string ProfileGraphy = "Assets/Main/Prefabs/Debug_Graphy/Graphy.prefab";

		// Token: 0x04000C7B RID: 3195
		[Token(Token = "0x4000C7B")]
		public const string GFXConsole = "Assets/Main/Prefabs/Debug_Graphy/GFXConsole.prefab";
	}

	// Token: 0x0200018D RID: 397
	[Token(Token = "0x200018D")]
	public class SettingKeys
	{
		// Token: 0x06000B34 RID: 2868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B34")]
		[Address(RVA = "0x3724968", Offset = "0x3724968", VA = "0x3724968")]
		public SettingKeys()
		{
		}

		// Token: 0x04000C7C RID: 3196
		[Token(Token = "0x4000C7C")]
		public const string LAST_SERVER_KEY = "DEBUG_LAST_SERVERID";

		// Token: 0x04000C7D RID: 3197
		[Token(Token = "0x4000C7D")]
		public const string GAME_UID = "Setting.GAME_UID";

		// Token: 0x04000C7E RID: 3198
		[Token(Token = "0x4000C7E")]
		public const string GM_FLAG = "Setting.GM_FLAG";

		// Token: 0x04000C7F RID: 3199
		[Token(Token = "0x4000C7F")]
		public const string UUID = "Setting.UUID";

		// Token: 0x04000C80 RID: 3200
		[Token(Token = "0x4000C80")]
		public const string DEVICE_ID = "DEVICE_ID";

		// Token: 0x04000C81 RID: 3201
		[Token(Token = "0x4000C81")]
		public const string SERVER_IP = "SERVER_IP";

		// Token: 0x04000C82 RID: 3202
		[Token(Token = "0x4000C82")]
		public const string SERVER_PORT = "SERVER_PORT";

		// Token: 0x04000C83 RID: 3203
		[Token(Token = "0x4000C83")]
		public const string SERVER_ZONE = "SERVER_ZONE";

		// Token: 0x04000C84 RID: 3204
		[Token(Token = "0x4000C84")]
		public const string USER_LANGUAGE = "Setting.USER_LANGUAGE";

		// Token: 0x04000C85 RID: 3205
		[Token(Token = "0x4000C85")]
		public const string USER_LANGUAGE_NAME = "Setting.USER_LANGUAGE_NAME";

		// Token: 0x04000C86 RID: 3206
		[Token(Token = "0x4000C86")]
		public const string RESOURCE_LOGGER = "Setting.Resource.Logger";

		// Token: 0x04000C87 RID: 3207
		[Token(Token = "0x4000C87")]
		public const string SCENE_GRAPHIC_LEVEL = "SCENE_GRAPHIC_LEVEL";

		// Token: 0x04000C88 RID: 3208
		[Token(Token = "0x4000C88")]
		public const string CITY_TROOP_POSITION = "CITY_TROOP_POSITION";
	}

	// Token: 0x0200018E RID: 398
	[Token(Token = "0x200018E")]
	public class BuildingTypes
	{
		// Token: 0x06000B35 RID: 2869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x3724970", Offset = "0x3724970", VA = "0x3724970")]
		public BuildingTypes()
		{
		}

		// Token: 0x04000C89 RID: 3209
		[Token(Token = "0x4000C89")]
		public const int FUN_BUILD_MAIN = 400000;

		// Token: 0x04000C8A RID: 3210
		[Token(Token = "0x4000C8A")]
		public const int FUN_BUILD_BUSINESS_CENTER = 401000;

		// Token: 0x04000C8B RID: 3211
		[Token(Token = "0x4000C8B")]
		public const int FUN_BUILD_STABLE = 402000;

		// Token: 0x04000C8C RID: 3212
		[Token(Token = "0x4000C8C")]
		public const int FUN_BUILD_SCIENE = 403000;

		// Token: 0x04000C8D RID: 3213
		[Token(Token = "0x4000C8D")]
		public const int FUN_BUILD_SMITHY = 407000;

		// Token: 0x04000C8E RID: 3214
		[Token(Token = "0x4000C8E")]
		public const int FUN_BUILD_CONDOMINIUM = 409000;

		// Token: 0x04000C8F RID: 3215
		[Token(Token = "0x4000C8F")]
		public const int FUN_BUILD_HOSPITAL = 411000;

		// Token: 0x04000C90 RID: 3216
		[Token(Token = "0x4000C90")]
		public const int FUN_BUILD_STONE = 412000;

		// Token: 0x04000C91 RID: 3217
		[Token(Token = "0x4000C91")]
		public const int FUN_BUILD_OIL = 413000;

		// Token: 0x04000C92 RID: 3218
		[Token(Token = "0x4000C92")]
		public const int FUN_BUILD_ARROW_TOWER = 418000;

		// Token: 0x04000C93 RID: 3219
		[Token(Token = "0x4000C93")]
		public const int FUN_BUILD_CAR_BARRACK = 423000;

		// Token: 0x04000C94 RID: 3220
		[Token(Token = "0x4000C94")]
		public const int FUN_BUILD_INFANTRY_BARRACK = 424000;

		// Token: 0x04000C95 RID: 3221
		[Token(Token = "0x4000C95")]
		public const int FUN_BUILD_AIRCRAFT_BARRACK = 425000;

		// Token: 0x04000C96 RID: 3222
		[Token(Token = "0x4000C96")]
		public const int FUN_BUILD_TRAINFIELD_1 = 427000;

		// Token: 0x04000C97 RID: 3223
		[Token(Token = "0x4000C97")]
		public const int FUN_BUILD_TRAINFIELD_2 = 793000;

		// Token: 0x04000C98 RID: 3224
		[Token(Token = "0x4000C98")]
		public const int FUN_BUILD_TRAINFIELD_3 = 794000;

		// Token: 0x04000C99 RID: 3225
		[Token(Token = "0x4000C99")]
		public const int FUN_BUILD_TRAINFIELD_4 = 795000;

		// Token: 0x04000C9A RID: 3226
		[Token(Token = "0x4000C9A")]
		public const int FUN_BUILD_WATER = 432000;

		// Token: 0x04000C9B RID: 3227
		[Token(Token = "0x4000C9B")]
		public const int FUN_BUILD_MARKET = 435000;

		// Token: 0x04000C9C RID: 3228
		[Token(Token = "0x4000C9C")]
		public const int FUN_BUILD_ROAD = 436000;

		// Token: 0x04000C9D RID: 3229
		[Token(Token = "0x4000C9D")]
		public const int FUN_BUILD_ELECTRICITY_STORAGE = 437000;

		// Token: 0x04000C9E RID: 3230
		[Token(Token = "0x4000C9E")]
		public const int FUN_BUILD_WATER_STORAGE = 438000;

		// Token: 0x04000C9F RID: 3231
		[Token(Token = "0x4000C9F")]
		public const int FUN_BUILD_OIL_STORAGE = 439000;

		// Token: 0x04000CA0 RID: 3232
		[Token(Token = "0x4000CA0")]
		public const int FUN_BUILD_IRON_STORAGE = 441000;

		// Token: 0x04000CA1 RID: 3233
		[Token(Token = "0x4000CA1")]
		public const int FUN_BUILD_WIND_TURBINE = 444000;

		// Token: 0x04000CA2 RID: 3234
		[Token(Token = "0x4000CA2")]
		public const int FUN_BUILD_SOLAR_POWER_STATION = 447000;

		// Token: 0x04000CA3 RID: 3235
		[Token(Token = "0x4000CA3")]
		public const int FUN_BUILD_DRONE = 477000;

		// Token: 0x04000CA4 RID: 3236
		[Token(Token = "0x4000CA4")]
		public const int FUN_BUILD_VILLA = 700000;

		// Token: 0x04000CA5 RID: 3237
		[Token(Token = "0x4000CA5")]
		public const int APS_BUILD_FARM = 701000;

		// Token: 0x04000CA6 RID: 3238
		[Token(Token = "0x4000CA6")]
		public const int APS_BUILD_FARM_FIELD = 702000;

		// Token: 0x04000CA7 RID: 3239
		[Token(Token = "0x4000CA7")]
		public const int APS_BUILD_PASTURE = 703000;

		// Token: 0x04000CA8 RID: 3240
		[Token(Token = "0x4000CA8")]
		public const int APS_BUILD_PASTURE_FIELD = 704000;

		// Token: 0x04000CA9 RID: 3241
		[Token(Token = "0x4000CA9")]
		public const int FUN_BUILD_OXYGEN = 705000;

		// Token: 0x04000CAA RID: 3242
		[Token(Token = "0x4000CAA")]
		public const int FUN_BUILD_METALLURGY = 706000;

		// Token: 0x04000CAB RID: 3243
		[Token(Token = "0x4000CAB")]
		public const int FUN_BUILD_FOOD = 707000;

		// Token: 0x04000CAC RID: 3244
		[Token(Token = "0x4000CAC")]
		public const int FUN_BUILD_OIL_REFINERY = 708000;

		// Token: 0x04000CAD RID: 3245
		[Token(Token = "0x4000CAD")]
		public const int FUN_BUILD_INTEGRATED_FACTORY = 709000;

		// Token: 0x04000CAE RID: 3246
		[Token(Token = "0x4000CAE")]
		public const int FUN_BUILD_TRADING_CENTER = 710000;

		// Token: 0x04000CAF RID: 3247
		[Token(Token = "0x4000CAF")]
		public const int FUN_BUILD_FOODSHOP = 711000;

		// Token: 0x04000CB0 RID: 3248
		[Token(Token = "0x4000CB0")]
		public const int FUN_BUILD_PRINT_FACTORY = 712000;

		// Token: 0x04000CB1 RID: 3249
		[Token(Token = "0x4000CB1")]
		public const int FUN_BUILD_INFORMATION_CENTER = 713000;

		// Token: 0x04000CB2 RID: 3250
		[Token(Token = "0x4000CB2")]
		public const int FUN_BUILD_COLD_STORAGE = 714000;

		// Token: 0x04000CB3 RID: 3251
		[Token(Token = "0x4000CB3")]
		public const int FUN_BUILD_COMPREHENSIVE_STORAGE = 715000;

		// Token: 0x04000CB4 RID: 3252
		[Token(Token = "0x4000CB4")]
		public const int FUN_BUILD_DEFENCE_CENTER = 716000;

		// Token: 0x04000CB5 RID: 3253
		[Token(Token = "0x4000CB5")]
		public const int FUN_BUILD_DOME = 449000;

		// Token: 0x04000CB6 RID: 3254
		[Token(Token = "0x4000CB6")]
		public const int FUN_BUILD_FORGE = 429000;

		// Token: 0x04000CB7 RID: 3255
		[Token(Token = "0x4000CB7")]
		public const int FUN_BUILD_ELECTRICITY = 431000;

		// Token: 0x04000CB8 RID: 3256
		[Token(Token = "0x4000CB8")]
		public const int FUN_BUILD_RECHARGE_GARAGE = 445000;

		// Token: 0x04000CB9 RID: 3257
		[Token(Token = "0x4000CB9")]
		public const int FUN_BUILD_HONOR_HALL = 446000;

		// Token: 0x04000CBA RID: 3258
		[Token(Token = "0x4000CBA")]
		public const int FUN_BUILD_BUILDING_CENTER = 448000;

		// Token: 0x04000CBB RID: 3259
		[Token(Token = "0x4000CBB")]
		public const int FUN_BUILD_OFFICER = 483000;

		// Token: 0x04000CBC RID: 3260
		[Token(Token = "0x4000CBC")]
		public const int APS_BUILD_PASTURE_OSTRICH = 719000;

		// Token: 0x04000CBD RID: 3261
		[Token(Token = "0x4000CBD")]
		public const int APS_BUILD_PASTURE_CATTLE = 720000;

		// Token: 0x04000CBE RID: 3262
		[Token(Token = "0x4000CBE")]
		public const int APS_BUILD_PASTURE_SANDWORM = 721000;

		// Token: 0x04000CBF RID: 3263
		[Token(Token = "0x4000CBF")]
		public const int APS_BUILD_WORMHOLE_MAIN = 791000;

		// Token: 0x04000CC0 RID: 3264
		[Token(Token = "0x4000CC0")]
		public const int APS_BUILD_WORMHOLE_SUB = 792000;

		// Token: 0x04000CC1 RID: 3265
		[Token(Token = "0x4000CC1")]
		public const int WORM_HOLE_CROSS = 735000;

		// Token: 0x04000CC2 RID: 3266
		[Token(Token = "0x4000CC2")]
		public const int FUN_BUILD_RADAR_CENTER = 417000;

		// Token: 0x04000CC3 RID: 3267
		[Token(Token = "0x4000CC3")]
		public const int FUN_BUILD_TEMP_WIND_POWER_PLANT = 796000;

		// Token: 0x04000CC4 RID: 3268
		[Token(Token = "0x4000CC4")]
		public const int FUN_BUILD_OUT_WOOD = 736000;

		// Token: 0x04000CC5 RID: 3269
		[Token(Token = "0x4000CC5")]
		public const int FUN_BUILD_OUT_STONE = 737000;

		// Token: 0x04000CC6 RID: 3270
		[Token(Token = "0x4000CC6")]
		public const int EDEN_WORM_HOLE_1 = 757000;

		// Token: 0x04000CC7 RID: 3271
		[Token(Token = "0x4000CC7")]
		public const int EDEN_WORM_HOLE_2 = 758000;

		// Token: 0x04000CC8 RID: 3272
		[Token(Token = "0x4000CC8")]
		public const int EDEN_WORM_HOLE_3 = 759000;
	}

	// Token: 0x0200018F RID: 399
	[Token(Token = "0x200018F")]
	public class TableName
	{
		// Token: 0x06000B36 RID: 2870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B36")]
		[Address(RVA = "0x3724978", Offset = "0x3724978", VA = "0x3724978")]
		public TableName()
		{
		}

		// Token: 0x04000CC9 RID: 3273
		[Token(Token = "0x4000CC9")]
		public const string APSMonster = "APS_monster";

		// Token: 0x04000CCA RID: 3274
		[Token(Token = "0x4000CCA")]
		public const string APSHeros = "aps_new_heroes";

		// Token: 0x04000CCB RID: 3275
		[Token(Token = "0x4000CCB")]
		public const string GuideTab = "guide";

		// Token: 0x04000CCC RID: 3276
		[Token(Token = "0x4000CCC")]
		public const string PlotTab = "plot";

		// Token: 0x04000CCD RID: 3277
		[Token(Token = "0x4000CCD")]
		public const string FieldMonster = "field_monster";

		// Token: 0x04000CCE RID: 3278
		[Token(Token = "0x4000CCE")]
		public const string HeroTab = "new_heroes";

		// Token: 0x04000CCF RID: 3279
		[Token(Token = "0x4000CCF")]
		public const string GoodsTab = "goods";

		// Token: 0x04000CD0 RID: 3280
		[Token(Token = "0x4000CD0")]
		public const string SkillTab = "skill";

		// Token: 0x04000CD1 RID: 3281
		[Token(Token = "0x4000CD1")]
		public const string BattleAnimation = "battle_animation";

		// Token: 0x04000CD2 RID: 3282
		[Token(Token = "0x4000CD2")]
		public const string StatusTab = "status";

		// Token: 0x04000CD3 RID: 3283
		[Token(Token = "0x4000CD3")]
		public const string EquipRandomEffect = "equip_random_effect";

		// Token: 0x04000CD4 RID: 3284
		[Token(Token = "0x4000CD4")]
		public const string AllianceGift = "alliance_gift";

		// Token: 0x04000CD5 RID: 3285
		[Token(Token = "0x4000CD5")]
		public const string AllianceGiftGroup = "alliance_gift_group";

		// Token: 0x04000CD6 RID: 3286
		[Token(Token = "0x4000CD6")]
		public const string AllianceItemWarehouse = "alliance_item_warehouse";

		// Token: 0x04000CD7 RID: 3287
		[Token(Token = "0x4000CD7")]
		public const string Territory = "territory";

		// Token: 0x04000CD8 RID: 3288
		[Token(Token = "0x4000CD8")]
		public const string TerritoryEffect = "territory_effect";

		// Token: 0x04000CD9 RID: 3289
		[Token(Token = "0x4000CD9")]
		public const string GoldrushBuilding = "goldrush_building";

		// Token: 0x04000CDA RID: 3290
		[Token(Token = "0x4000CDA")]
		public const string ServerPos = "serverpos";

		// Token: 0x04000CDB RID: 3291
		[Token(Token = "0x4000CDB")]
		public const string SiegeNPC = "siegeNPC";

		// Token: 0x04000CDC RID: 3292
		[Token(Token = "0x4000CDC")]
		public const string Diary = "diary";

		// Token: 0x04000CDD RID: 3293
		[Token(Token = "0x4000CDD")]
		public const string ActivityShow = "activity_show";

		// Token: 0x04000CDE RID: 3294
		[Token(Token = "0x4000CDE")]
		public const string RightsEffectLevel = "rights_effect_level";

		// Token: 0x04000CDF RID: 3295
		[Token(Token = "0x4000CDF")]
		public const string RightsEffect = "rights_effect";

		// Token: 0x04000CE0 RID: 3296
		[Token(Token = "0x4000CE0")]
		public const string VipStoreUnlock = "vip_store_unlock";

		// Token: 0x04000CE1 RID: 3297
		[Token(Token = "0x4000CE1")]
		public const string VipDetails = "vipdetails";

		// Token: 0x04000CE2 RID: 3298
		[Token(Token = "0x4000CE2")]
		public const string WorldSeason = "world_season";

		// Token: 0x04000CE3 RID: 3299
		[Token(Token = "0x4000CE3")]
		public const string WorldBuilding = "building_world";

		// Token: 0x04000CE4 RID: 3300
		[Token(Token = "0x4000CE4")]
		public const string DesertTalent = "DesertTalent_DesertTalent";

		// Token: 0x04000CE5 RID: 3301
		[Token(Token = "0x4000CE5")]
		public const string TalentShading = "DesertTalent_Shading";

		// Token: 0x04000CE6 RID: 3302
		[Token(Token = "0x4000CE6")]
		public const string TalentHome = "talentHome";

		// Token: 0x04000CE7 RID: 3303
		[Token(Token = "0x4000CE7")]
		public const string DesertGoldmineWar = "DesertGoldmineWar";

		// Token: 0x04000CE8 RID: 3304
		[Token(Token = "0x4000CE8")]
		public const string DesertTalentStats = "DesertTalentStats";

		// Token: 0x04000CE9 RID: 3305
		[Token(Token = "0x4000CE9")]
		public const string Decompose = "decompose";

		// Token: 0x04000CEA RID: 3306
		[Token(Token = "0x4000CEA")]
		public const string Missile = "missile";

		// Token: 0x04000CEB RID: 3307
		[Token(Token = "0x4000CEB")]
		public const string LoadingTips = "loadingTips";

		// Token: 0x04000CEC RID: 3308
		[Token(Token = "0x4000CEC")]
		public const string Mail_ChannelID = "Mail_ChannelID";

		// Token: 0x04000CED RID: 3309
		[Token(Token = "0x4000CED")]
		public const string PlayerCareerXml = "player_career";

		// Token: 0x04000CEE RID: 3310
		[Token(Token = "0x4000CEE")]
		public const string QuestXml = "quest";

		// Token: 0x04000CEF RID: 3311
		[Token(Token = "0x4000CEF")]
		public const string DesertSkillXml = "desertSkill";

		// Token: 0x04000CF0 RID: 3312
		[Token(Token = "0x4000CF0")]
		public const string GuideStep = "guide_step_GuideStep";

		// Token: 0x04000CF1 RID: 3313
		[Token(Token = "0x4000CF1")]
		public const string GuideStepContentInfo = "guide_step_ContentInfo";

		// Token: 0x04000CF2 RID: 3314
		[Token(Token = "0x4000CF2")]
		public const string Office = "office";

		// Token: 0x04000CF3 RID: 3315
		[Token(Token = "0x4000CF3")]
		public const string DoomsDayNote = "doomsdaynote_doomsdaynote";

		// Token: 0x04000CF4 RID: 3316
		[Token(Token = "0x4000CF4")]
		public const string DD_Season_Group = "DD_season_group";

		// Token: 0x04000CF5 RID: 3317
		[Token(Token = "0x4000CF5")]
		public const string Building = "building";

		// Token: 0x04000CF6 RID: 3318
		[Token(Token = "0x4000CF6")]
		public const string Chapter = "chapter_1";

		// Token: 0x04000CF7 RID: 3319
		[Token(Token = "0x4000CF7")]
		public const string EffectName = "APS_effect_name";

		// Token: 0x04000CF8 RID: 3320
		[Token(Token = "0x4000CF8")]
		public const string Global = "APS_global";

		// Token: 0x04000CF9 RID: 3321
		[Token(Token = "0x4000CF9")]
		public const string Talent = "APS_talent";

		// Token: 0x04000CFA RID: 3322
		[Token(Token = "0x4000CFA")]
		public const string ResourceItem = "aps_resource_item";

		// Token: 0x04000CFB RID: 3323
		[Token(Token = "0x4000CFB")]
		public const string Farming = "aps_farming";

		// Token: 0x04000CFC RID: 3324
		[Token(Token = "0x4000CFC")]
		public const string BaseExpansion = "aps_base_expansion";

		// Token: 0x04000CFD RID: 3325
		[Token(Token = "0x4000CFD")]
		public const string GatherResource = "aps_gather_resource";

		// Token: 0x04000CFE RID: 3326
		[Token(Token = "0x4000CFE")]
		public const string WorldCity = "worldcity";

		// Token: 0x04000CFF RID: 3327
		[Token(Token = "0x4000CFF")]
		public const string CityJunk = "aps_singlemap_junk";

		// Token: 0x04000D00 RID: 3328
		[Token(Token = "0x4000D00")]
		public const string LandLock = "aps_landlock";

		// Token: 0x04000D01 RID: 3329
		[Token(Token = "0x4000D01")]
		public const string Item = "item";

		// Token: 0x04000D02 RID: 3330
		[Token(Token = "0x4000D02")]
		public const string Decoration = "decoration";

		// Token: 0x04000D03 RID: 3331
		[Token(Token = "0x4000D03")]
		public const string Desert = "desert";
	}

	// Token: 0x02000190 RID: 400
	[Token(Token = "0x2000190")]
	public static class SpritePath
	{
		// Token: 0x04000D04 RID: 3332
		[Token(Token = "0x4000D04")]
		public const string HeroIconSmall = "Assets/Main/Sprites/HeroIconsSmall/";

		// Token: 0x04000D05 RID: 3333
		[Token(Token = "0x4000D05")]
		public const string UITitleTag = "Assets/Main/Sprites/UI/UITitleTag/";
	}

	// Token: 0x02000191 RID: 401
	[Token(Token = "0x2000191")]
	public static class QualitySetting
	{
		// Token: 0x04000D06 RID: 3334
		[Token(Token = "0x4000D06")]
		public const string PostProcess_Bloom = "QualitySetting.PostProcess.Bloom";

		// Token: 0x04000D07 RID: 3335
		[Token(Token = "0x4000D07")]
		public const string PostProcess_ColorAdjustments = "QualitySetting.PostProcess.ColorAdjustments";

		// Token: 0x04000D08 RID: 3336
		[Token(Token = "0x4000D08")]
		public const string PostProcess_Vignette = "QualitySetting.PostProcess.Vignette";

		// Token: 0x04000D09 RID: 3337
		[Token(Token = "0x4000D09")]
		public const string PostProcess_Tonemapping = "QualitySetting.PostProcess.Tonemapping";

		// Token: 0x04000D0A RID: 3338
		[Token(Token = "0x4000D0A")]
		public const string PostProcess_LiftGammaGain = "QualitySetting.PostProcess.LiftGammaGain";

		// Token: 0x04000D0B RID: 3339
		[Token(Token = "0x4000D0B")]
		public const string PostProcess_DepthOfField = "QualitySetting.PostProcess.DepthOfField";

		// Token: 0x04000D0C RID: 3340
		[Token(Token = "0x4000D0C")]
		public const string Resolution = "QualitySetting.Resolution";

		// Token: 0x04000D0D RID: 3341
		[Token(Token = "0x4000D0D")]
		public const string FPS = "QualitySetting.FPS";

		// Token: 0x04000D0E RID: 3342
		[Token(Token = "0x4000D0E")]
		public const string Terrain = "QualitySetting.Terrain";
	}

	// Token: 0x02000192 RID: 402
	[Token(Token = "0x2000192")]
	public static class GuideType
	{
		// Token: 0x04000D0F RID: 3343
		[Token(Token = "0x4000D0F")]
		public const int BuildPlace = 4;
	}
}
