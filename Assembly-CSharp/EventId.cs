using System;
using Il2CppDummyDll;

// Token: 0x02000189 RID: 393
[Token(Token = "0x2000189")]
public enum EventId
{
	// Token: 0x040007E3 RID: 2019
	[Token(Token = "0x40007E3")]
	APP_APPLICATION_PAUSE = -1000,
	// Token: 0x040007E4 RID: 2020
	[Token(Token = "0x40007E4")]
	SCREEN_TOUCH_DOWN = -3000,
	// Token: 0x040007E5 RID: 2021
	[Token(Token = "0x40007E5")]
	SCREEN_TOUCH_DOWN_IGNORE_UI = -3001,
	// Token: 0x040007E6 RID: 2022
	[Token(Token = "0x40007E6")]
	SCREEN_TOUCH_UP = -3002,
	// Token: 0x040007E7 RID: 2023
	[Token(Token = "0x40007E7")]
	SCREEN_TOUCH_UP_IGNORE_UI = -3003,
	// Token: 0x040007E8 RID: 2024
	[Token(Token = "0x40007E8")]
	SCREEN_TOUCH_CLICK = -3004,
	// Token: 0x040007E9 RID: 2025
	[Token(Token = "0x40007E9")]
	SCREEN_TOUCH_CLICK_IGNORE_UI = -3005,
	// Token: 0x040007EA RID: 2026
	[Token(Token = "0x40007EA")]
	SCREEN_TOUCH_MOVE = -3006,
	// Token: 0x040007EB RID: 2027
	[Token(Token = "0x40007EB")]
	UIPrivacy_Cancel = -4000,
	// Token: 0x040007EC RID: 2028
	[Token(Token = "0x40007EC")]
	UIPrivacy_Confirm = -4001,
	// Token: 0x040007ED RID: 2029
	[Token(Token = "0x40007ED")]
	None = 0,
	// Token: 0x040007EE RID: 2030
	[Token(Token = "0x40007EE")]
	ResourceUpdated,
	// Token: 0x040007EF RID: 2031
	[Token(Token = "0x40007EF")]
	OpenUIFormSuccess,
	// Token: 0x040007F0 RID: 2032
	[Token(Token = "0x40007F0")]
	OpenUIFormFail,
	// Token: 0x040007F1 RID: 2033
	[Token(Token = "0x40007F1")]
	CloseUIForm,
	// Token: 0x040007F2 RID: 2034
	[Token(Token = "0x40007F2")]
	ElectricityLack,
	// Token: 0x040007F3 RID: 2035
	[Token(Token = "0x40007F3")]
	PlayerInfoUpdated,
	// Token: 0x040007F4 RID: 2036
	[Token(Token = "0x40007F4")]
	UpdateFiveStarReward,
	// Token: 0x040007F5 RID: 2037
	[Token(Token = "0x40007F5")]
	UpdateBankruptcy,
	// Token: 0x040007F6 RID: 2038
	[Token(Token = "0x40007F6")]
	DoneBankruptcy,
	// Token: 0x040007F7 RID: 2039
	[Token(Token = "0x40007F7")]
	PlayerPowerInfoUpdated,
	// Token: 0x040007F8 RID: 2040
	[Token(Token = "0x40007F8")]
	ServerError,
	// Token: 0x040007F9 RID: 2041
	[Token(Token = "0x40007F9")]
	BuildPlace,
	// Token: 0x040007FA RID: 2042
	[Token(Token = "0x40007FA")]
	BuildUpgradeStart,
	// Token: 0x040007FB RID: 2043
	[Token(Token = "0x40007FB")]
	BuildUpgradeFinish,
	// Token: 0x040007FC RID: 2044
	[Token(Token = "0x40007FC")]
	TransportFinish,
	// Token: 0x040007FD RID: 2045
	[Token(Token = "0x40007FD")]
	CheckActivityRedPoint,
	// Token: 0x040007FE RID: 2046
	[Token(Token = "0x40007FE")]
	BuildResources,
	// Token: 0x040007FF RID: 2047
	[Token(Token = "0x40007FF")]
	PushCreateBuildingOneHeart,
	// Token: 0x04000800 RID: 2048
	[Token(Token = "0x4000800")]
	TrainArmyData,
	// Token: 0x04000801 RID: 2049
	[Token(Token = "0x4000801")]
	TrainingArmy,
	// Token: 0x04000802 RID: 2050
	[Token(Token = "0x4000802")]
	TrainingArmyFinish,
	// Token: 0x04000803 RID: 2051
	[Token(Token = "0x4000803")]
	ResourceTransport,
	// Token: 0x04000804 RID: 2052
	[Token(Token = "0x4000804")]
	HeroicRecruitmentData,
	// Token: 0x04000805 RID: 2053
	[Token(Token = "0x4000805")]
	WorldMarchFormatiomData,
	// Token: 0x04000806 RID: 2054
	[Token(Token = "0x4000806")]
	WorldMarchCount,
	// Token: 0x04000807 RID: 2055
	[Token(Token = "0x4000807")]
	WorldMarchChristmas,
	// Token: 0x04000808 RID: 2056
	[Token(Token = "0x4000808")]
	HospitaiStart,
	// Token: 0x04000809 RID: 2057
	[Token(Token = "0x4000809")]
	HospitalHelp,
	// Token: 0x0400080A RID: 2058
	[Token(Token = "0x400080A")]
	HospitalFinish,
	// Token: 0x0400080B RID: 2059
	[Token(Token = "0x400080B")]
	HospitalTimeEnd,
	// Token: 0x0400080C RID: 2060
	[Token(Token = "0x400080C")]
	HospitalUpdate,
	// Token: 0x0400080D RID: 2061
	[Token(Token = "0x400080D")]
	DesertHospitalShowSpeedBtn,
	// Token: 0x0400080E RID: 2062
	[Token(Token = "0x400080E")]
	HospitalEffectEnd,
	// Token: 0x0400080F RID: 2063
	[Token(Token = "0x400080F")]
	ModeReward,
	// Token: 0x04000810 RID: 2064
	[Token(Token = "0x4000810")]
	RepairNeedMessage,
	// Token: 0x04000811 RID: 2065
	[Token(Token = "0x4000811")]
	ArmyFormationSave,
	// Token: 0x04000812 RID: 2066
	[Token(Token = "0x4000812")]
	ChapterTask,
	// Token: 0x04000813 RID: 2067
	[Token(Token = "0x4000813")]
	QuestNoteBookRedCount,
	// Token: 0x04000814 RID: 2068
	[Token(Token = "0x4000814")]
	LineSpine,
	// Token: 0x04000815 RID: 2069
	[Token(Token = "0x4000815")]
	ActiveGuide,
	// Token: 0x04000816 RID: 2070
	[Token(Token = "0x4000816")]
	BuyAndUseItemSuccess,
	// Token: 0x04000817 RID: 2071
	[Token(Token = "0x4000817")]
	forgingSuccess,
	// Token: 0x04000818 RID: 2072
	[Token(Token = "0x4000818")]
	UseItemSuccess,
	// Token: 0x04000819 RID: 2073
	[Token(Token = "0x4000819")]
	AddSpeedSuccess,
	// Token: 0x0400081A RID: 2074
	[Token(Token = "0x400081A")]
	AllianceHelpAddSpeed,
	// Token: 0x0400081B RID: 2075
	[Token(Token = "0x400081B")]
	DailyQuestSuccess,
	// Token: 0x0400081C RID: 2076
	[Token(Token = "0x400081C")]
	MainTaskSuccess,
	// Token: 0x0400081D RID: 2077
	[Token(Token = "0x400081D")]
	AllianceChangeNameSuccess,
	// Token: 0x0400081E RID: 2078
	[Token(Token = "0x400081E")]
	AllianceChangeAbbrSuccess,
	// Token: 0x0400081F RID: 2079
	[Token(Token = "0x400081F")]
	SearchAllianceSuccess,
	// Token: 0x04000820 RID: 2080
	[Token(Token = "0x4000820")]
	AllianceMember,
	// Token: 0x04000821 RID: 2081
	[Token(Token = "0x4000821")]
	KingSearchPlayerList,
	// Token: 0x04000822 RID: 2082
	[Token(Token = "0x4000822")]
	PlayerMessageInfo,
	// Token: 0x04000823 RID: 2083
	[Token(Token = "0x4000823")]
	AllianceHelp,
	// Token: 0x04000824 RID: 2084
	[Token(Token = "0x4000824")]
	AllianceHelpSever,
	// Token: 0x04000825 RID: 2085
	[Token(Token = "0x4000825")]
	AllianceShopShow,
	// Token: 0x04000826 RID: 2086
	[Token(Token = "0x4000826")]
	AllianceMemberRedPoint,
	// Token: 0x04000827 RID: 2087
	[Token(Token = "0x4000827")]
	AllianceInfoRefresh,
	// Token: 0x04000828 RID: 2088
	[Token(Token = "0x4000828")]
	AllianceApplySuccess,
	// Token: 0x04000829 RID: 2089
	[Token(Token = "0x4000829")]
	AllianceCreateSuccess,
	// Token: 0x0400082A RID: 2090
	[Token(Token = "0x400082A")]
	AllianceApplyCancel,
	// Token: 0x0400082B RID: 2091
	[Token(Token = "0x400082B")]
	AllianceTechnology,
	// Token: 0x0400082C RID: 2092
	[Token(Token = "0x400082C")]
	AllianceScienceDonate,
	// Token: 0x0400082D RID: 2093
	[Token(Token = "0x400082D")]
	KickOutAllianceMember,
	// Token: 0x0400082E RID: 2094
	[Token(Token = "0x400082E")]
	AllianceSettingUpdate,
	// Token: 0x0400082F RID: 2095
	[Token(Token = "0x400082F")]
	AllianceAcceptInvite,
	// Token: 0x04000830 RID: 2096
	[Token(Token = "0x4000830")]
	AllianceEvent,
	// Token: 0x04000831 RID: 2097
	[Token(Token = "0x4000831")]
	AllianceWarUpdate,
	// Token: 0x04000832 RID: 2098
	[Token(Token = "0x4000832")]
	ShowTruckIcon,
	// Token: 0x04000833 RID: 2099
	[Token(Token = "0x4000833")]
	ShowMainUIPart,
	// Token: 0x04000834 RID: 2100
	[Token(Token = "0x4000834")]
	RefreshPieceInterface,
	// Token: 0x04000835 RID: 2101
	[Token(Token = "0x4000835")]
	CloseActiveSkillUseUI,
	// Token: 0x04000836 RID: 2102
	[Token(Token = "0x4000836")]
	CloseGarrisonTip,
	// Token: 0x04000837 RID: 2103
	[Token(Token = "0x4000837")]
	OpenInvestmentPanel,
	// Token: 0x04000838 RID: 2104
	[Token(Token = "0x4000838")]
	MarchTimeSync,
	// Token: 0x04000839 RID: 2105
	[Token(Token = "0x4000839")]
	ActiveSkillNode,
	// Token: 0x0400083A RID: 2106
	[Token(Token = "0x400083A")]
	RefreshSkillUseUI,
	// Token: 0x0400083B RID: 2107
	[Token(Token = "0x400083B")]
	RefreshActiveSkillUseUI,
	// Token: 0x0400083C RID: 2108
	[Token(Token = "0x400083C")]
	PlayFragBuySuccessAnim,
	// Token: 0x0400083D RID: 2109
	[Token(Token = "0x400083D")]
	PlayShopBuySuccessAnim,
	// Token: 0x0400083E RID: 2110
	[Token(Token = "0x400083E")]
	ShopBuyAnimEnd,
	// Token: 0x0400083F RID: 2111
	[Token(Token = "0x400083F")]
	MoveUpFragShopPanel,
	// Token: 0x04000840 RID: 2112
	[Token(Token = "0x4000840")]
	ZombieUnLockAddTransporter,
	// Token: 0x04000841 RID: 2113
	[Token(Token = "0x4000841")]
	NewUserAreaUnLock,
	// Token: 0x04000842 RID: 2114
	[Token(Token = "0x4000842")]
	UserAreaUnLock,
	// Token: 0x04000843 RID: 2115
	[Token(Token = "0x4000843")]
	CenterDailyReward,
	// Token: 0x04000844 RID: 2116
	[Token(Token = "0x4000844")]
	CenterDailyRewardRedDot,
	// Token: 0x04000845 RID: 2117
	[Token(Token = "0x4000845")]
	CargoReward,
	// Token: 0x04000846 RID: 2118
	[Token(Token = "0x4000846")]
	CloseAlliancePanel,
	// Token: 0x04000847 RID: 2119
	[Token(Token = "0x4000847")]
	MoveWorldCity,
	// Token: 0x04000848 RID: 2120
	[Token(Token = "0x4000848")]
	WorldScoutDetail,
	// Token: 0x04000849 RID: 2121
	[Token(Token = "0x4000849")]
	WorldPointDetail,
	// Token: 0x0400084A RID: 2122
	[Token(Token = "0x400084A")]
	WorldOccupiedTroops,
	// Token: 0x0400084B RID: 2123
	[Token(Token = "0x400084B")]
	WorldCollectPointDetail,
	// Token: 0x0400084C RID: 2124
	[Token(Token = "0x400084C")]
	WorldOccupiedKick,
	// Token: 0x0400084D RID: 2125
	[Token(Token = "0x400084D")]
	WorldMarchGetDetail,
	// Token: 0x0400084E RID: 2126
	[Token(Token = "0x400084E")]
	RefreshBookmark,
	// Token: 0x0400084F RID: 2127
	[Token(Token = "0x400084F")]
	ChangeBookmarkItemState,
	// Token: 0x04000850 RID: 2128
	[Token(Token = "0x4000850")]
	GuidePreloadFinish,
	// Token: 0x04000851 RID: 2129
	[Token(Token = "0x4000851")]
	RequestWorldMarchDetail,
	// Token: 0x04000852 RID: 2130
	[Token(Token = "0x4000852")]
	ArmyUpgrade,
	// Token: 0x04000853 RID: 2131
	[Token(Token = "0x4000853")]
	ArmyUpgradeStart,
	// Token: 0x04000854 RID: 2132
	[Token(Token = "0x4000854")]
	ArmyFormatUpdate,
	// Token: 0x04000855 RID: 2133
	[Token(Token = "0x4000855")]
	GetAllianceWarArrayEvent,
	// Token: 0x04000856 RID: 2134
	[Token(Token = "0x4000856")]
	GetAllianceWarAtkInfoEvent,
	// Token: 0x04000857 RID: 2135
	[Token(Token = "0x4000857")]
	GetAllianceWarDefInfoEvent,
	// Token: 0x04000858 RID: 2136
	[Token(Token = "0x4000858")]
	AllianceWarCancelEvent,
	// Token: 0x04000859 RID: 2137
	[Token(Token = "0x4000859")]
	AllianceWarIgnore,
	// Token: 0x0400085A RID: 2138
	[Token(Token = "0x400085A")]
	AllianceWarLogEvent,
	// Token: 0x0400085B RID: 2139
	[Token(Token = "0x400085B")]
	RefreshAllianceGift,
	// Token: 0x0400085C RID: 2140
	[Token(Token = "0x400085C")]
	UpdateAllianceGiftNum,
	// Token: 0x0400085D RID: 2141
	[Token(Token = "0x400085D")]
	UpdateAllianceHelpNum,
	// Token: 0x0400085E RID: 2142
	[Token(Token = "0x400085E")]
	RetGetRewardEvent,
	// Token: 0x0400085F RID: 2143
	[Token(Token = "0x400085F")]
	AllianceGiftShowChangeAni,
	// Token: 0x04000860 RID: 2144
	[Token(Token = "0x4000860")]
	RetGiftInfoEvent,
	// Token: 0x04000861 RID: 2145
	[Token(Token = "0x4000861")]
	TerritoryUpdateInfo,
	// Token: 0x04000862 RID: 2146
	[Token(Token = "0x4000862")]
	TerritoryContri,
	// Token: 0x04000863 RID: 2147
	[Token(Token = "0x4000863")]
	TerritoryStateChange,
	// Token: 0x04000864 RID: 2148
	[Token(Token = "0x4000864")]
	ShowUseResTool,
	// Token: 0x04000865 RID: 2149
	[Token(Token = "0x4000865")]
	TerritoryDetail,
	// Token: 0x04000866 RID: 2150
	[Token(Token = "0x4000866")]
	OccupiedMarchKick,
	// Token: 0x04000867 RID: 2151
	[Token(Token = "0x4000867")]
	AlliancebuildEditor,
	// Token: 0x04000868 RID: 2152
	[Token(Token = "0x4000868")]
	ChangeTerritoryInfo,
	// Token: 0x04000869 RID: 2153
	[Token(Token = "0x4000869")]
	GetAllianceComments,
	// Token: 0x0400086A RID: 2154
	[Token(Token = "0x400086A")]
	AllianceSendComment,
	// Token: 0x0400086B RID: 2155
	[Token(Token = "0x400086B")]
	TalentPointChange,
	// Token: 0x0400086C RID: 2156
	[Token(Token = "0x400086C")]
	MsgDesertSkillUseRefresh,
	// Token: 0x0400086D RID: 2157
	[Token(Token = "0x400086D")]
	EndStudyTalent,
	// Token: 0x0400086E RID: 2158
	[Token(Token = "0x400086E")]
	HidePutWorldBuildUI,
	// Token: 0x0400086F RID: 2159
	[Token(Token = "0x400086F")]
	RefreshUpdateStone,
	// Token: 0x04000870 RID: 2160
	[Token(Token = "0x4000870")]
	DomainDefenceValue,
	// Token: 0x04000871 RID: 2161
	[Token(Token = "0x4000871")]
	UpdateCrossServerPermission,
	// Token: 0x04000872 RID: 2162
	[Token(Token = "0x4000872")]
	DomainFightRewardInfo,
	// Token: 0x04000873 RID: 2163
	[Token(Token = "0x4000873")]
	DomainBuildInfo,
	// Token: 0x04000874 RID: 2164
	[Token(Token = "0x4000874")]
	WBProductNeedTime,
	// Token: 0x04000875 RID: 2165
	[Token(Token = "0x4000875")]
	FactorySelectEvent,
	// Token: 0x04000876 RID: 2166
	[Token(Token = "0x4000876")]
	WorldBuildInfoUpdate,
	// Token: 0x04000877 RID: 2167
	[Token(Token = "0x4000877")]
	WorldBuildRepair,
	// Token: 0x04000878 RID: 2168
	[Token(Token = "0x4000878")]
	WorldBuildFinishRepair,
	// Token: 0x04000879 RID: 2169
	[Token(Token = "0x4000879")]
	WorldBuildRepairInfo,
	// Token: 0x0400087A RID: 2170
	[Token(Token = "0x400087A")]
	WorldMarchRepeat,
	// Token: 0x0400087B RID: 2171
	[Token(Token = "0x400087B")]
	EnemyInfoListChange,
	// Token: 0x0400087C RID: 2172
	[Token(Token = "0x400087C")]
	CityDefend,
	// Token: 0x0400087D RID: 2173
	[Token(Token = "0x400087D")]
	CityDefendIndex,
	// Token: 0x0400087E RID: 2174
	[Token(Token = "0x400087E")]
	TroopAssistance,
	// Token: 0x0400087F RID: 2175
	[Token(Token = "0x400087F")]
	UIRefreshAssistanceDetailInfo,
	// Token: 0x04000880 RID: 2176
	[Token(Token = "0x4000880")]
	FightToMonster,
	// Token: 0x04000881 RID: 2177
	[Token(Token = "0x4000881")]
	BuildingAppointhero,
	// Token: 0x04000882 RID: 2178
	[Token(Token = "0x4000882")]
	UpdateMarchEntityInfo,
	// Token: 0x04000883 RID: 2179
	[Token(Token = "0x4000883")]
	UpdateWorldMapInfo,
	// Token: 0x04000884 RID: 2180
	[Token(Token = "0x4000884")]
	UpdateMarchSpeedUp,
	// Token: 0x04000885 RID: 2181
	[Token(Token = "0x4000885")]
	BuyItemSuccess,
	// Token: 0x04000886 RID: 2182
	[Token(Token = "0x4000886")]
	UpdateNewChatInfo,
	// Token: 0x04000887 RID: 2183
	[Token(Token = "0x4000887")]
	FightReport,
	// Token: 0x04000888 RID: 2184
	[Token(Token = "0x4000888")]
	RequestAllianceSoldier,
	// Token: 0x04000889 RID: 2185
	[Token(Token = "0x4000889")]
	GetUserInfo,
	// Token: 0x0400088A RID: 2186
	[Token(Token = "0x400088A")]
	PushWorldMarchInfo,
	// Token: 0x0400088B RID: 2187
	[Token(Token = "0x400088B")]
	PaymentCompleted,
	// Token: 0x0400088C RID: 2188
	[Token(Token = "0x400088C")]
	PaySuccess,
	// Token: 0x0400088D RID: 2189
	[Token(Token = "0x400088D")]
	HeroGrowReward,
	// Token: 0x0400088E RID: 2190
	[Token(Token = "0x400088E")]
	RequestWeekCardData,
	// Token: 0x0400088F RID: 2191
	[Token(Token = "0x400088F")]
	WEEK_REFRESH_VIEW,
	// Token: 0x04000890 RID: 2192
	[Token(Token = "0x4000890")]
	BattleStartOver,
	// Token: 0x04000891 RID: 2193
	[Token(Token = "0x4000891")]
	BattleBeAttackPost,
	// Token: 0x04000892 RID: 2194
	[Token(Token = "0x4000892")]
	BattleAddAttackEffect,
	// Token: 0x04000893 RID: 2195
	[Token(Token = "0x4000893")]
	BattleAddBulletAttackEffect,
	// Token: 0x04000894 RID: 2196
	[Token(Token = "0x4000894")]
	BattleAddMissileAttackEffect,
	// Token: 0x04000895 RID: 2197
	[Token(Token = "0x4000895")]
	BattleAddPoisonEffect,
	// Token: 0x04000896 RID: 2198
	[Token(Token = "0x4000896")]
	BattleUpdateSodierNum,
	// Token: 0x04000897 RID: 2199
	[Token(Token = "0x4000897")]
	BattleAddMaraleEffect,
	// Token: 0x04000898 RID: 2200
	[Token(Token = "0x4000898")]
	BattleWarningTipFinish,
	// Token: 0x04000899 RID: 2201
	[Token(Token = "0x4000899")]
	BattleShackScreen,
	// Token: 0x0400089A RID: 2202
	[Token(Token = "0x400089A")]
	BattleAddSkillState,
	// Token: 0x0400089B RID: 2203
	[Token(Token = "0x400089B")]
	BattleAddSkillEffect,
	// Token: 0x0400089C RID: 2204
	[Token(Token = "0x400089C")]
	BattleAddStateIdEffect,
	// Token: 0x0400089D RID: 2205
	[Token(Token = "0x400089D")]
	BattleShowTroopSkill,
	// Token: 0x0400089E RID: 2206
	[Token(Token = "0x400089E")]
	BattleMoveForward,
	// Token: 0x0400089F RID: 2207
	[Token(Token = "0x400089F")]
	BattleOfficerCellShine,
	// Token: 0x040008A0 RID: 2208
	[Token(Token = "0x40008A0")]
	BattleOfficerCellCancelShine,
	// Token: 0x040008A1 RID: 2209
	[Token(Token = "0x40008A1")]
	BattleShowGlow,
	// Token: 0x040008A2 RID: 2210
	[Token(Token = "0x40008A2")]
	BattleAddPoisonIcon,
	// Token: 0x040008A3 RID: 2211
	[Token(Token = "0x40008A3")]
	MSG_ADD_STATE,
	// Token: 0x040008A4 RID: 2212
	[Token(Token = "0x40008A4")]
	MSG_SHOW_AOE_EFFECT,
	// Token: 0x040008A5 RID: 2213
	[Token(Token = "0x40008A5")]
	MSG_UPDATE_STATE,
	// Token: 0x040008A6 RID: 2214
	[Token(Token = "0x40008A6")]
	MSG_SHOW_AOE_MASK,
	// Token: 0x040008A7 RID: 2215
	[Token(Token = "0x40008A7")]
	MSG_SHOW_STATUS_EFFECT,
	// Token: 0x040008A8 RID: 2216
	[Token(Token = "0x40008A8")]
	MSG_ADD_POISON_ICON,
	// Token: 0x040008A9 RID: 2217
	[Token(Token = "0x40008A9")]
	AccountBindEvent,
	// Token: 0x040008AA RID: 2218
	[Token(Token = "0x40008AA")]
	AccountBindOKEvent,
	// Token: 0x040008AB RID: 2219
	[Token(Token = "0x40008AB")]
	AccountChangeEvent,
	// Token: 0x040008AC RID: 2220
	[Token(Token = "0x40008AC")]
	AccountChangePwdEvent,
	// Token: 0x040008AD RID: 2221
	[Token(Token = "0x40008AD")]
	AccountResendMailEvent,
	// Token: 0x040008AE RID: 2222
	[Token(Token = "0x40008AE")]
	AccountChangeMailEvent,
	// Token: 0x040008AF RID: 2223
	[Token(Token = "0x40008AF")]
	AccountNewEvent,
	// Token: 0x040008B0 RID: 2224
	[Token(Token = "0x40008B0")]
	NickNameChackEvent,
	// Token: 0x040008B1 RID: 2225
	[Token(Token = "0x40008B1")]
	NickNameChangeEvent,
	// Token: 0x040008B2 RID: 2226
	[Token(Token = "0x40008B2")]
	MoodInfoChangeEvent,
	// Token: 0x040008B3 RID: 2227
	[Token(Token = "0x40008B3")]
	PinInputReset,
	// Token: 0x040008B4 RID: 2228
	[Token(Token = "0x40008B4")]
	PinInputClose,
	// Token: 0x040008B5 RID: 2229
	[Token(Token = "0x40008B5")]
	PinInputNext,
	// Token: 0x040008B6 RID: 2230
	[Token(Token = "0x40008B6")]
	PinForgetPwd,
	// Token: 0x040008B7 RID: 2231
	[Token(Token = "0x40008B7")]
	PinInitFinish,
	// Token: 0x040008B8 RID: 2232
	[Token(Token = "0x40008B8")]
	MSG_INIT_ACTIVITY_EVENT,
	// Token: 0x040008B9 RID: 2233
	[Token(Token = "0x40008B9")]
	DayChange,
	// Token: 0x040008BA RID: 2234
	[Token(Token = "0x40008BA")]
	GetActivityDetail,
	// Token: 0x040008BB RID: 2235
	[Token(Token = "0x40008BB")]
	ActivityCellRefresh,
	// Token: 0x040008BC RID: 2236
	[Token(Token = "0x40008BC")]
	MsgFreshSingleScoreView,
	// Token: 0x040008BD RID: 2237
	[Token(Token = "0x40008BD")]
	MsgFreshSingleScoreRankView,
	// Token: 0x040008BE RID: 2238
	[Token(Token = "0x40008BE")]
	RefreshDataSingleScore,
	// Token: 0x040008BF RID: 2239
	[Token(Token = "0x40008BF")]
	RefreshRwdData,
	// Token: 0x040008C0 RID: 2240
	[Token(Token = "0x40008C0")]
	RefreshSingleScoreUI,
	// Token: 0x040008C1 RID: 2241
	[Token(Token = "0x40008C1")]
	MsgScoreRankHistoryView,
	// Token: 0x040008C2 RID: 2242
	[Token(Token = "0x40008C2")]
	DesertMummyRankData,
	// Token: 0x040008C3 RID: 2243
	[Token(Token = "0x40008C3")]
	GetRewardInfo,
	// Token: 0x040008C4 RID: 2244
	[Token(Token = "0x40008C4")]
	MsgUpdateActivityEvent,
	// Token: 0x040008C5 RID: 2245
	[Token(Token = "0x40008C5")]
	MsgAllianceMigrationRefreshData,
	// Token: 0x040008C6 RID: 2246
	[Token(Token = "0x40008C6")]
	MsgAllianceMigrationPopupRefreshData,
	// Token: 0x040008C7 RID: 2247
	[Token(Token = "0x40008C7")]
	MsgGetAllianceArmsDifficulty,
	// Token: 0x040008C8 RID: 2248
	[Token(Token = "0x40008C8")]
	MsgUpdateAllianceArmsUI,
	// Token: 0x040008C9 RID: 2249
	[Token(Token = "0x40008C9")]
	MsgUpdateAllianceArmsRankUI,
	// Token: 0x040008CA RID: 2250
	[Token(Token = "0x40008CA")]
	MsgRefreshChampBattleView,
	// Token: 0x040008CB RID: 2251
	[Token(Token = "0x40008CB")]
	EliteNewAddbet,
	// Token: 0x040008CC RID: 2252
	[Token(Token = "0x40008CC")]
	EliteNewBetInfo,
	// Token: 0x040008CD RID: 2253
	[Token(Token = "0x40008CD")]
	EliteNewAllocateUpdate,
	// Token: 0x040008CE RID: 2254
	[Token(Token = "0x40008CE")]
	MsgChampBattleAllocateCell,
	// Token: 0x040008CF RID: 2255
	[Token(Token = "0x40008CF")]
	MsgKingGiftUserList,
	// Token: 0x040008D0 RID: 2256
	[Token(Token = "0x40008D0")]
	MsgKingGiftUpdateContact,
	// Token: 0x040008D1 RID: 2257
	[Token(Token = "0x40008D1")]
	MsgOfficerPosition,
	// Token: 0x040008D2 RID: 2258
	[Token(Token = "0x40008D2")]
	MsgOfficerCellUpdate,
	// Token: 0x040008D3 RID: 2259
	[Token(Token = "0x40008D3")]
	MsgUpdateKingdomFlag,
	// Token: 0x040008D4 RID: 2260
	[Token(Token = "0x40008D4")]
	MsgUpdatePresidentHistory,
	// Token: 0x040008D5 RID: 2261
	[Token(Token = "0x40008D5")]
	MsgUpdateLaunchBoxHistory,
	// Token: 0x040008D6 RID: 2262
	[Token(Token = "0x40008D6")]
	DRAW_VIEW_UPDATE,
	// Token: 0x040008D7 RID: 2263
	[Token(Token = "0x40008D7")]
	DRAW_SELF_VIEW_UPDATE,
	// Token: 0x040008D8 RID: 2264
	[Token(Token = "0x40008D8")]
	DRAW_RESULT_VIEW_UPDATE,
	// Token: 0x040008D9 RID: 2265
	[Token(Token = "0x40008D9")]
	DRAW_RESULT_VIEW_UPDATE_1,
	// Token: 0x040008DA RID: 2266
	[Token(Token = "0x40008DA")]
	ZONE_REWARD_RED_POINT,
	// Token: 0x040008DB RID: 2267
	[Token(Token = "0x40008DB")]
	DRAW_VS_VIEW_UPDATE,
	// Token: 0x040008DC RID: 2268
	[Token(Token = "0x40008DC")]
	ZONE_CONTRIBUTE_RANK_UPDATE,
	// Token: 0x040008DD RID: 2269
	[Token(Token = "0x40008DD")]
	CountryTodayViewcheckReward,
	// Token: 0x040008DE RID: 2270
	[Token(Token = "0x40008DE")]
	ZONE_INSIDE_RANK_VIEW,
	// Token: 0x040008DF RID: 2271
	[Token(Token = "0x40008DF")]
	ACTIVITY_THEME_CHANGE,
	// Token: 0x040008E0 RID: 2272
	[Token(Token = "0x40008E0")]
	REFRESH_SINGLE_HEAD_VIEW,
	// Token: 0x040008E1 RID: 2273
	[Token(Token = "0x40008E1")]
	ZONE_OUT_LOOK_REFRESH,
	// Token: 0x040008E2 RID: 2274
	[Token(Token = "0x40008E2")]
	ZONE_WARMUPTODAT_RANK,
	// Token: 0x040008E3 RID: 2275
	[Token(Token = "0x40008E3")]
	ZONE_WARMUPACCUMULATE_RANK,
	// Token: 0x040008E4 RID: 2276
	[Token(Token = "0x40008E4")]
	ZONE_HISTORY_RANK,
	// Token: 0x040008E5 RID: 2277
	[Token(Token = "0x40008E5")]
	ALLIANCE_ACTIVITY_INFO,
	// Token: 0x040008E6 RID: 2278
	[Token(Token = "0x40008E6")]
	ALLIANCE_ACTIVITY_REWARD,
	// Token: 0x040008E7 RID: 2279
	[Token(Token = "0x40008E7")]
	ALLIANCE_REWARD_RANK,
	// Token: 0x040008E8 RID: 2280
	[Token(Token = "0x40008E8")]
	PERSONAL_REWARD_RANK,
	// Token: 0x040008E9 RID: 2281
	[Token(Token = "0x40008E9")]
	DRAW_PIRZE_VIEW_UPDATE,
	// Token: 0x040008EA RID: 2282
	[Token(Token = "0x40008EA")]
	MSG_FRESH_SINGLE_SCORE_RANK_VIEW,
	// Token: 0x040008EB RID: 2283
	[Token(Token = "0x40008EB")]
	ZONE_GET_CHOOSE_REFRESH,
	// Token: 0x040008EC RID: 2284
	[Token(Token = "0x40008EC")]
	ZONE_GET_CHOOSEINFO_REFRESH,
	// Token: 0x040008ED RID: 2285
	[Token(Token = "0x40008ED")]
	ZONE_ACTIVITY_DETAIL_EXTEND,
	// Token: 0x040008EE RID: 2286
	[Token(Token = "0x40008EE")]
	ZONE_VIEW_CHOOSE_STATE,
	// Token: 0x040008EF RID: 2287
	[Token(Token = "0x40008EF")]
	ZONE_WARMUP_RANKING_PRIZE_REFRESH,
	// Token: 0x040008F0 RID: 2288
	[Token(Token = "0x40008F0")]
	MsgKingdomOfficers,
	// Token: 0x040008F1 RID: 2289
	[Token(Token = "0x40008F1")]
	MsgUpdateCommendationView,
	// Token: 0x040008F2 RID: 2290
	[Token(Token = "0x40008F2")]
	MsgUpdateGiftSelectMemTop,
	// Token: 0x040008F3 RID: 2291
	[Token(Token = "0x40008F3")]
	MsgUpdateGiftSelectMems,
	// Token: 0x040008F4 RID: 2292
	[Token(Token = "0x40008F4")]
	MsgHeroLimitedRecruitBoxInit,
	// Token: 0x040008F5 RID: 2293
	[Token(Token = "0x40008F5")]
	MsgHeroCardInfoEnd,
	// Token: 0x040008F6 RID: 2294
	[Token(Token = "0x40008F6")]
	MsgHeroSelectHero,
	// Token: 0x040008F7 RID: 2295
	[Token(Token = "0x40008F7")]
	UPDATE_CHRISTMAS_TREE,
	// Token: 0x040008F8 RID: 2296
	[Token(Token = "0x40008F8")]
	INFO_CHANGE_COLORFUL_CHRISTMAS_TREE,
	// Token: 0x040008F9 RID: 2297
	[Token(Token = "0x40008F9")]
	GET_COLORFUL_CHRISTMAS_TREE,
	// Token: 0x040008FA RID: 2298
	[Token(Token = "0x40008FA")]
	INFO_CHANGE_CHRISTMAS_GIFT,
	// Token: 0x040008FB RID: 2299
	[Token(Token = "0x40008FB")]
	INFO_CHANGE_CONGRATULATION_CRAD,
	// Token: 0x040008FC RID: 2300
	[Token(Token = "0x40008FC")]
	CONGRATULATION_CRAD_REWARD,
	// Token: 0x040008FD RID: 2301
	[Token(Token = "0x40008FD")]
	MsgServerListBack,
	// Token: 0x040008FE RID: 2302
	[Token(Token = "0x40008FE")]
	MsgRepayInfoInit,
	// Token: 0x040008FF RID: 2303
	[Token(Token = "0x40008FF")]
	MsgRepayViewShowDes,
	// Token: 0x04000900 RID: 2304
	[Token(Token = "0x4000900")]
	MonthCardGetReward,
	// Token: 0x04000901 RID: 2305
	[Token(Token = "0x4000901")]
	BuyMonthCardSucess,
	// Token: 0x04000902 RID: 2306
	[Token(Token = "0x4000902")]
	MONTHCARD_REFRESH,
	// Token: 0x04000903 RID: 2307
	[Token(Token = "0x4000903")]
	SelectMonthCardReward,
	// Token: 0x04000904 RID: 2308
	[Token(Token = "0x4000904")]
	CLICK_WELFARE_CELL,
	// Token: 0x04000905 RID: 2309
	[Token(Token = "0x4000905")]
	AccConsumeGetReward,
	// Token: 0x04000906 RID: 2310
	[Token(Token = "0x4000906")]
	RefreshActivityCommonView,
	// Token: 0x04000907 RID: 2311
	[Token(Token = "0x4000907")]
	RefreshActivity7View,
	// Token: 0x04000908 RID: 2312
	[Token(Token = "0x4000908")]
	BattlePassChangeData,
	// Token: 0x04000909 RID: 2313
	[Token(Token = "0x4000909")]
	MonthBattlePassChangeData,
	// Token: 0x0400090A RID: 2314
	[Token(Token = "0x400090A")]
	SeasonBattlePassChangeData,
	// Token: 0x0400090B RID: 2315
	[Token(Token = "0x400090B")]
	AllianceConsumeChangeData,
	// Token: 0x0400090C RID: 2316
	[Token(Token = "0x400090C")]
	AllianceConsumeRankList,
	// Token: 0x0400090D RID: 2317
	[Token(Token = "0x400090D")]
	MSG_HOLIDAY_AWARD_INFO,
	// Token: 0x0400090E RID: 2318
	[Token(Token = "0x400090E")]
	NightChange,
	// Token: 0x0400090F RID: 2319
	[Token(Token = "0x400090F")]
	LightChange,
	// Token: 0x04000910 RID: 2320
	[Token(Token = "0x4000910")]
	SkillUpgradeEnd,
	// Token: 0x04000911 RID: 2321
	[Token(Token = "0x4000911")]
	RefreshUnlockSkillCondition,
	// Token: 0x04000912 RID: 2322
	[Token(Token = "0x4000912")]
	HeroMedalSelectEnd,
	// Token: 0x04000913 RID: 2323
	[Token(Token = "0x4000913")]
	CloseHeroUnlockPanels,
	// Token: 0x04000914 RID: 2324
	[Token(Token = "0x4000914")]
	UpdateHeroMedalPanel,
	// Token: 0x04000915 RID: 2325
	[Token(Token = "0x4000915")]
	MsgHeroesInit,
	// Token: 0x04000916 RID: 2326
	[Token(Token = "0x4000916")]
	MsgHeroesUpdate,
	// Token: 0x04000917 RID: 2327
	[Token(Token = "0x4000917")]
	HeroBeDecomposedEnd,
	// Token: 0x04000918 RID: 2328
	[Token(Token = "0x4000918")]
	HeroLevelUpgrade,
	// Token: 0x04000919 RID: 2329
	[Token(Token = "0x4000919")]
	HeroRecruitRefreashFree,
	// Token: 0x0400091A RID: 2330
	[Token(Token = "0x400091A")]
	HeroRecruitRefreashActivity,
	// Token: 0x0400091B RID: 2331
	[Token(Token = "0x400091B")]
	OpenHeroPage,
	// Token: 0x0400091C RID: 2332
	[Token(Token = "0x400091C")]
	CloseJiBanPanel,
	// Token: 0x0400091D RID: 2333
	[Token(Token = "0x400091D")]
	HeroUnLockSkill,
	// Token: 0x0400091E RID: 2334
	[Token(Token = "0x400091E")]
	MerchantItemRefresh,
	// Token: 0x0400091F RID: 2335
	[Token(Token = "0x400091F")]
	MerchantBuyItemSucess,
	// Token: 0x04000920 RID: 2336
	[Token(Token = "0x4000920")]
	ChipCollectSucces,
	// Token: 0x04000921 RID: 2337
	[Token(Token = "0x4000921")]
	CR_UPDATE_SHOW,
	// Token: 0x04000922 RID: 2338
	[Token(Token = "0x4000922")]
	DesertThroneDataBack,
	// Token: 0x04000923 RID: 2339
	[Token(Token = "0x4000923")]
	CrossThroneDataBack,
	// Token: 0x04000924 RID: 2340
	[Token(Token = "0x4000924")]
	ThroneFightInfoDataBack,
	// Token: 0x04000925 RID: 2341
	[Token(Token = "0x4000925")]
	ThroneUIClose,
	// Token: 0x04000926 RID: 2342
	[Token(Token = "0x4000926")]
	WorldTrebuchetAtt,
	// Token: 0x04000927 RID: 2343
	[Token(Token = "0x4000927")]
	UpdateBuildingProtectTime,
	// Token: 0x04000928 RID: 2344
	[Token(Token = "0x4000928")]
	UpdateBuildingResProtectTime,
	// Token: 0x04000929 RID: 2345
	[Token(Token = "0x4000929")]
	UpdateMarchItem,
	// Token: 0x0400092A RID: 2346
	[Token(Token = "0x400092A")]
	AllianceExchangeOptRefresh,
	// Token: 0x0400092B RID: 2347
	[Token(Token = "0x400092B")]
	AllianceExchangeRefresh,
	// Token: 0x0400092C RID: 2348
	[Token(Token = "0x400092C")]
	AllianceSetRankName,
	// Token: 0x0400092D RID: 2349
	[Token(Token = "0x400092D")]
	AllianceDonateRankDay,
	// Token: 0x0400092E RID: 2350
	[Token(Token = "0x400092E")]
	AllianceDonateRankWeek,
	// Token: 0x0400092F RID: 2351
	[Token(Token = "0x400092F")]
	AllianceDonateRankAll,
	// Token: 0x04000930 RID: 2352
	[Token(Token = "0x4000930")]
	GoldBoxRefresh,
	// Token: 0x04000931 RID: 2353
	[Token(Token = "0x4000931")]
	ChangeWorldScene,
	// Token: 0x04000932 RID: 2354
	[Token(Token = "0x4000932")]
	WorldMapCameraChangeZoom,
	// Token: 0x04000933 RID: 2355
	[Token(Token = "0x4000933")]
	RefreshWorldMapUI,
	// Token: 0x04000934 RID: 2356
	[Token(Token = "0x4000934")]
	PlayerRank,
	// Token: 0x04000935 RID: 2357
	[Token(Token = "0x4000935")]
	AllianceRank,
	// Token: 0x04000936 RID: 2358
	[Token(Token = "0x4000936")]
	ResetPositionCity,
	// Token: 0x04000937 RID: 2359
	[Token(Token = "0x4000937")]
	UpdateClonceData,
	// Token: 0x04000938 RID: 2360
	[Token(Token = "0x4000938")]
	UpdateCloneSoldier,
	// Token: 0x04000939 RID: 2361
	[Token(Token = "0x4000939")]
	UpdateCloneDonate,
	// Token: 0x0400093A RID: 2362
	[Token(Token = "0x400093A")]
	CloneDonateListBack,
	// Token: 0x0400093B RID: 2363
	[Token(Token = "0x400093B")]
	CloseDonatePlayerInfoList,
	// Token: 0x0400093C RID: 2364
	[Token(Token = "0x400093C")]
	SearchUserAlliance,
	// Token: 0x0400093D RID: 2365
	[Token(Token = "0x400093D")]
	BuildLandscapeList,
	// Token: 0x0400093E RID: 2366
	[Token(Token = "0x400093E")]
	BuildLandscapeUnLock,
	// Token: 0x0400093F RID: 2367
	[Token(Token = "0x400093F")]
	BuildLandscapeUnDown,
	// Token: 0x04000940 RID: 2368
	[Token(Token = "0x4000940")]
	MissleCostUpdate,
	// Token: 0x04000941 RID: 2369
	[Token(Token = "0x4000941")]
	TrainMissile,
	// Token: 0x04000942 RID: 2370
	[Token(Token = "0x4000942")]
	BeginTrainMissile,
	// Token: 0x04000943 RID: 2371
	[Token(Token = "0x4000943")]
	MSG_FINISH_TRAINING_MISSILE,
	// Token: 0x04000944 RID: 2372
	[Token(Token = "0x4000944")]
	FINISH_TRAINING_MISSILE,
	// Token: 0x04000945 RID: 2373
	[Token(Token = "0x4000945")]
	MSG_MISSILE_DEFENCE_RECORD,
	// Token: 0x04000946 RID: 2374
	[Token(Token = "0x4000946")]
	OpenMissleFromSilo,
	// Token: 0x04000947 RID: 2375
	[Token(Token = "0x4000947")]
	EquipMaterialSceleted,
	// Token: 0x04000948 RID: 2376
	[Token(Token = "0x4000948")]
	PartsEquipMakeStart,
	// Token: 0x04000949 RID: 2377
	[Token(Token = "0x4000949")]
	BuildPartsEquipMakeStart,
	// Token: 0x0400094A RID: 2378
	[Token(Token = "0x400094A")]
	BuildPartsMaterialMakeStart,
	// Token: 0x0400094B RID: 2379
	[Token(Token = "0x400094B")]
	PartsEquipMakeFinished,
	// Token: 0x0400094C RID: 2380
	[Token(Token = "0x400094C")]
	PartsMaterialMergeSuccess,
	// Token: 0x0400094D RID: 2381
	[Token(Token = "0x400094D")]
	EquipMergeComplete,
	// Token: 0x0400094E RID: 2382
	[Token(Token = "0x400094E")]
	Equip_Harvest,
	// Token: 0x0400094F RID: 2383
	[Token(Token = "0x400094F")]
	Material_Harvest,
	// Token: 0x04000950 RID: 2384
	[Token(Token = "0x4000950")]
	EquipPutOnMsg,
	// Token: 0x04000951 RID: 2385
	[Token(Token = "0x4000951")]
	EquipDeleteMsg,
	// Token: 0x04000952 RID: 2386
	[Token(Token = "0x4000952")]
	EquipTakeOffMsg,
	// Token: 0x04000953 RID: 2387
	[Token(Token = "0x4000953")]
	EquipSplitMsg,
	// Token: 0x04000954 RID: 2388
	[Token(Token = "0x4000954")]
	EquipSuitSkillUpdate,
	// Token: 0x04000955 RID: 2389
	[Token(Token = "0x4000955")]
	DestroyMaterial,
	// Token: 0x04000956 RID: 2390
	[Token(Token = "0x4000956")]
	SpineCarUpdate,
	// Token: 0x04000957 RID: 2391
	[Token(Token = "0x4000957")]
	ActiveBg,
	// Token: 0x04000958 RID: 2392
	[Token(Token = "0x4000958")]
	RefreshTruckInfo,
	// Token: 0x04000959 RID: 2393
	[Token(Token = "0x4000959")]
	MailReceiveServerBack,
	// Token: 0x0400095A RID: 2394
	[Token(Token = "0x400095A")]
	MailSaveBack,
	// Token: 0x0400095B RID: 2395
	[Token(Token = "0x400095B")]
	MailPush,
	// Token: 0x0400095C RID: 2396
	[Token(Token = "0x400095C")]
	GetStatusItemSuccess,
	// Token: 0x0400095D RID: 2397
	[Token(Token = "0x400095D")]
	GetProtectBuffRecordSuccess,
	// Token: 0x0400095E RID: 2398
	[Token(Token = "0x400095E")]
	ClashBattleStateUpdate,
	// Token: 0x0400095F RID: 2399
	[Token(Token = "0x400095F")]
	ClashBattleBuildUpdate,
	// Token: 0x04000960 RID: 2400
	[Token(Token = "0x4000960")]
	ClashInfoUpdate,
	// Token: 0x04000961 RID: 2401
	[Token(Token = "0x4000961")]
	ClashBattleBuildUpdateClose,
	// Token: 0x04000962 RID: 2402
	[Token(Token = "0x4000962")]
	ClashInfoPush,
	// Token: 0x04000963 RID: 2403
	[Token(Token = "0x4000963")]
	MsgRefreshExploitShopView,
	// Token: 0x04000964 RID: 2404
	[Token(Token = "0x4000964")]
	MsgRefreshFragmentShopView,
	// Token: 0x04000965 RID: 2405
	[Token(Token = "0x4000965")]
	MsgRefreshOneFragmentInfo,
	// Token: 0x04000966 RID: 2406
	[Token(Token = "0x4000966")]
	RefreshItems,
	// Token: 0x04000967 RID: 2407
	[Token(Token = "0x4000967")]
	ChangeServer,
	// Token: 0x04000968 RID: 2408
	[Token(Token = "0x4000968")]
	DesertSeasonDataBack,
	// Token: 0x04000969 RID: 2409
	[Token(Token = "0x4000969")]
	FBVipUnlock,
	// Token: 0x0400096A RID: 2410
	[Token(Token = "0x400096A")]
	FBVipSlotValue,
	// Token: 0x0400096B RID: 2411
	[Token(Token = "0x400096B")]
	VipStoreRefrsh,
	// Token: 0x0400096C RID: 2412
	[Token(Token = "0x400096C")]
	VipPrivilegeRefrsh,
	// Token: 0x0400096D RID: 2413
	[Token(Token = "0x400096D")]
	MsgVipstoreUpdateExp,
	// Token: 0x0400096E RID: 2414
	[Token(Token = "0x400096E")]
	UpdateVipUpdateLV,
	// Token: 0x0400096F RID: 2415
	[Token(Token = "0x400096F")]
	MsgBuyConfirmOK,
	// Token: 0x04000970 RID: 2416
	[Token(Token = "0x4000970")]
	ItemBuyConfirm,
	// Token: 0x04000971 RID: 2417
	[Token(Token = "0x4000971")]
	ItemBuyAndUseConfirm,
	// Token: 0x04000972 RID: 2418
	[Token(Token = "0x4000972")]
	ItemUseConfirm,
	// Token: 0x04000973 RID: 2419
	[Token(Token = "0x4000973")]
	RefreshFBPrivelege,
	// Token: 0x04000974 RID: 2420
	[Token(Token = "0x4000974")]
	RefreshFBStore,
	// Token: 0x04000975 RID: 2421
	[Token(Token = "0x4000975")]
	ALContributionDataBack,
	// Token: 0x04000976 RID: 2422
	[Token(Token = "0x4000976")]
	ALSetAvoidTimeBack,
	// Token: 0x04000977 RID: 2423
	[Token(Token = "0x4000977")]
	ALGetAvoidTimeBack,
	// Token: 0x04000978 RID: 2424
	[Token(Token = "0x4000978")]
	MSG_QUEUE_REMOVE,
	// Token: 0x04000979 RID: 2425
	[Token(Token = "0x4000979")]
	MSG_UPDATE_MSG_BALL,
	// Token: 0x0400097A RID: 2426
	[Token(Token = "0x400097A")]
	GetMemberPointBack,
	// Token: 0x0400097B RID: 2427
	[Token(Token = "0x400097B")]
	HerolotterRewarInfo,
	// Token: 0x0400097C RID: 2428
	[Token(Token = "0x400097C")]
	MsgAllianceBattleActInfo,
	// Token: 0x0400097D RID: 2429
	[Token(Token = "0x400097D")]
	MsgFreshDoomsView,
	// Token: 0x0400097E RID: 2430
	[Token(Token = "0x400097E")]
	DeclareWar_RefreshData,
	// Token: 0x0400097F RID: 2431
	[Token(Token = "0x400097F")]
	DeclareWar_DeclareWarRetData,
	// Token: 0x04000980 RID: 2432
	[Token(Token = "0x4000980")]
	DeclareWar_BeginDeclareWar,
	// Token: 0x04000981 RID: 2433
	[Token(Token = "0x4000981")]
	DeclareWar_AlWarResult,
	// Token: 0x04000982 RID: 2434
	[Token(Token = "0x4000982")]
	DeclareWar_History,
	// Token: 0x04000983 RID: 2435
	[Token(Token = "0x4000983")]
	DeclareWar_Search,
	// Token: 0x04000984 RID: 2436
	[Token(Token = "0x4000984")]
	materialCreateEnd,
	// Token: 0x04000985 RID: 2437
	[Token(Token = "0x4000985")]
	TalentViewRefreshInfo,
	// Token: 0x04000986 RID: 2438
	[Token(Token = "0x4000986")]
	MsgDomainGiveUpPointsBack,
	// Token: 0x04000987 RID: 2439
	[Token(Token = "0x4000987")]
	MsgMapUpdate,
	// Token: 0x04000988 RID: 2440
	[Token(Token = "0x4000988")]
	MsgDomainCollectEnd,
	// Token: 0x04000989 RID: 2441
	[Token(Token = "0x4000989")]
	MsgMyDomainDataBack,
	// Token: 0x0400098A RID: 2442
	[Token(Token = "0x400098A")]
	UIDesertTileRedDot,
	// Token: 0x0400098B RID: 2443
	[Token(Token = "0x400098B")]
	MsgDomainMineArmyBack,
	// Token: 0x0400098C RID: 2444
	[Token(Token = "0x400098C")]
	WBCrashStatus,
	// Token: 0x0400098D RID: 2445
	[Token(Token = "0x400098D")]
	FBTileSeasonDeclareHisListViewNewData,
	// Token: 0x0400098E RID: 2446
	[Token(Token = "0x400098E")]
	MsgDeclareWarDetail,
	// Token: 0x0400098F RID: 2447
	[Token(Token = "0x400098F")]
	GetUserDomainWarHistory,
	// Token: 0x04000990 RID: 2448
	[Token(Token = "0x4000990")]
	DesertRewardViewRefresh,
	// Token: 0x04000991 RID: 2449
	[Token(Token = "0x4000991")]
	ALBattleEvent,
	// Token: 0x04000992 RID: 2450
	[Token(Token = "0x4000992")]
	DomainForceRankDataBack,
	// Token: 0x04000993 RID: 2451
	[Token(Token = "0x4000993")]
	RefreashBuildUpGrade,
	// Token: 0x04000994 RID: 2452
	[Token(Token = "0x4000994")]
	PartsMaterialTimeDone,
	// Token: 0x04000995 RID: 2453
	[Token(Token = "0x4000995")]
	MsgMakeProductEnd,
	// Token: 0x04000996 RID: 2454
	[Token(Token = "0x4000996")]
	UnBuildUpgradeFinish,
	// Token: 0x04000997 RID: 2455
	[Token(Token = "0x4000997")]
	MsgStopProductEnd,
	// Token: 0x04000998 RID: 2456
	[Token(Token = "0x4000998")]
	MsgColloectProductEnd,
	// Token: 0x04000999 RID: 2457
	[Token(Token = "0x4000999")]
	RelicBuildRebuildSuccess,
	// Token: 0x0400099A RID: 2458
	[Token(Token = "0x400099A")]
	CountryFlagChanged,
	// Token: 0x0400099B RID: 2459
	[Token(Token = "0x400099B")]
	BuyHeroCard,
	// Token: 0x0400099C RID: 2460
	[Token(Token = "0x400099C")]
	AllianceCombineList,
	// Token: 0x0400099D RID: 2461
	[Token(Token = "0x400099D")]
	alliance_combine_details_refresh,
	// Token: 0x0400099E RID: 2462
	[Token(Token = "0x400099E")]
	MsgArmyUserRefresh,
	// Token: 0x0400099F RID: 2463
	[Token(Token = "0x400099F")]
	ResetTreatNum,
	// Token: 0x040009A0 RID: 2464
	[Token(Token = "0x40009A0")]
	GoToHealthing,
	// Token: 0x040009A1 RID: 2465
	[Token(Token = "0x40009A1")]
	MsgQueueRemove,
	// Token: 0x040009A2 RID: 2466
	[Token(Token = "0x40009A2")]
	MsgQueueAdd,
	// Token: 0x040009A3 RID: 2467
	[Token(Token = "0x40009A3")]
	ArmyNumChange,
	// Token: 0x040009A4 RID: 2468
	[Token(Token = "0x40009A4")]
	TreatNumChange,
	// Token: 0x040009A5 RID: 2469
	[Token(Token = "0x40009A5")]
	MsgTroopsChange,
	// Token: 0x040009A6 RID: 2470
	[Token(Token = "0x40009A6")]
	RefreshCarRepairInterface,
	// Token: 0x040009A7 RID: 2471
	[Token(Token = "0x40009A7")]
	MsgSpecialSolderUpdate,
	// Token: 0x040009A8 RID: 2472
	[Token(Token = "0x40009A8")]
	CollectSoldierAddPower,
	// Token: 0x040009A9 RID: 2473
	[Token(Token = "0x40009A9")]
	UICommonHelpTipsClose,
	// Token: 0x040009AA RID: 2474
	[Token(Token = "0x40009AA")]
	UpdateTradingCenterData,
	// Token: 0x040009AB RID: 2475
	[Token(Token = "0x40009AB")]
	UpdateTradingCenterCallPlane,
	// Token: 0x040009AC RID: 2476
	[Token(Token = "0x40009AC")]
	GetHeadImgUrl,
	// Token: 0x040009AD RID: 2477
	[Token(Token = "0x40009AD")]
	UpdateHeadImg,
	// Token: 0x040009AE RID: 2478
	[Token(Token = "0x40009AE")]
	LoadGiftFinish,
	// Token: 0x040009AF RID: 2479
	[Token(Token = "0x40009AF")]
	GiftBoxRefresh,
	// Token: 0x040009B0 RID: 2480
	[Token(Token = "0x40009B0")]
	SELECT_USER_GIVE,
	// Token: 0x040009B1 RID: 2481
	[Token(Token = "0x40009B1")]
	SearchUserGiftBox,
	// Token: 0x040009B2 RID: 2482
	[Token(Token = "0x40009B2")]
	GiftBoxPeopleSelected,
	// Token: 0x040009B3 RID: 2483
	[Token(Token = "0x40009B3")]
	OnBuildQueueFinish,
	// Token: 0x040009B4 RID: 2484
	[Token(Token = "0x40009B4")]
	OnScienceQueueFinish,
	// Token: 0x040009B5 RID: 2485
	[Token(Token = "0x40009B5")]
	OnScienceQueueResearch,
	// Token: 0x040009B6 RID: 2486
	[Token(Token = "0x40009B6")]
	Update_Alliance_Gift_Num,
	// Token: 0x040009B7 RID: 2487
	[Token(Token = "0x40009B7")]
	Translate_Normal,
	// Token: 0x040009B8 RID: 2488
	[Token(Token = "0x40009B8")]
	Translate_Mail,
	// Token: 0x040009B9 RID: 2489
	[Token(Token = "0x40009B9")]
	UI_RESOURCE_VISIBLE,
	// Token: 0x040009BA RID: 2490
	[Token(Token = "0x40009BA")]
	CHANGE_UIRESOURCE_TYPE_PUSH,
	// Token: 0x040009BB RID: 2491
	[Token(Token = "0x40009BB")]
	CHANGE_UIRESOURCE_TYPE_POP,
	// Token: 0x040009BC RID: 2492
	[Token(Token = "0x40009BC")]
	CHANGE_UIRESOURCE_TYPE_ALLPOP,
	// Token: 0x040009BD RID: 2493
	[Token(Token = "0x40009BD")]
	BuildPowerAdd,
	// Token: 0x040009BE RID: 2494
	[Token(Token = "0x40009BE")]
	UpdateGold,
	// Token: 0x040009BF RID: 2495
	[Token(Token = "0x40009BF")]
	CLOSE_UIPOPGETHERO,
	// Token: 0x040009C0 RID: 2496
	[Token(Token = "0x40009C0")]
	MSG_WORLD_BUILD_FREE_NUMBER_CHANGE,
	// Token: 0x040009C1 RID: 2497
	[Token(Token = "0x40009C1")]
	ClickStateIcon,
	// Token: 0x040009C2 RID: 2498
	[Token(Token = "0x40009C2")]
	BuildChangeState,
	// Token: 0x040009C3 RID: 2499
	[Token(Token = "0x40009C3")]
	BUILD_PRODUCE_FAST,
	// Token: 0x040009C4 RID: 2500
	[Token(Token = "0x40009C4")]
	BUILD_PRODUCE_FAST_BACK,
	// Token: 0x040009C5 RID: 2501
	[Token(Token = "0x40009C5")]
	BUILD_PRODUCE_FAST_END,
	// Token: 0x040009C6 RID: 2502
	[Token(Token = "0x40009C6")]
	BUILDING_TURBO_MODE_GET,
	// Token: 0x040009C7 RID: 2503
	[Token(Token = "0x40009C7")]
	BUILDING_TURBO_MODE_USED,
	// Token: 0x040009C8 RID: 2504
	[Token(Token = "0x40009C8")]
	BUILD_REPAIR,
	// Token: 0x040009C9 RID: 2505
	[Token(Token = "0x40009C9")]
	ITEM_COMPOSE_SUCCESS,
	// Token: 0x040009CA RID: 2506
	[Token(Token = "0x40009CA")]
	MSG_ITME_STATUS_TIME_CHANGE,
	// Token: 0x040009CB RID: 2507
	[Token(Token = "0x40009CB")]
	MSG_FRESH_SURVIVAL_VIEW_GET,
	// Token: 0x040009CC RID: 2508
	[Token(Token = "0x40009CC")]
	MSG_FRESH_SURVIVAL_VIEW,
	// Token: 0x040009CD RID: 2509
	[Token(Token = "0x40009CD")]
	MSG_FRESH_SURVIVAL_VIEW_MARK,
	// Token: 0x040009CE RID: 2510
	[Token(Token = "0x40009CE")]
	MSG_RESPONSED3RDPLATFORM,
	// Token: 0x040009CF RID: 2511
	[Token(Token = "0x40009CF")]
	MSG_USER_BIND_CANCEL,
	// Token: 0x040009D0 RID: 2512
	[Token(Token = "0x40009D0")]
	MSG_USER_BIND_OK,
	// Token: 0x040009D1 RID: 2513
	[Token(Token = "0x40009D1")]
	RES_TOOL_EXCHANGE_MSG,
	// Token: 0x040009D2 RID: 2514
	[Token(Token = "0x40009D2")]
	RES_SELL_MSG,
	// Token: 0x040009D3 RID: 2515
	[Token(Token = "0x40009D3")]
	Immediately_Back_Carport,
	// Token: 0x040009D4 RID: 2516
	[Token(Token = "0x40009D4")]
	City_Truck_Create,
	// Token: 0x040009D5 RID: 2517
	[Token(Token = "0x40009D5")]
	City_Truck_Hide,
	// Token: 0x040009D6 RID: 2518
	[Token(Token = "0x40009D6")]
	ZOMBIE_CLICK_REWARD,
	// Token: 0x040009D7 RID: 2519
	[Token(Token = "0x40009D7")]
	GOLDEXCHANGE_LIST_CHANGE,
	// Token: 0x040009D8 RID: 2520
	[Token(Token = "0x40009D8")]
	GOLDEXCHANGE_LIST_CHANGE_RAND,
	// Token: 0x040009D9 RID: 2521
	[Token(Token = "0x40009D9")]
	PAYMENT_COMMAND_RETURN,
	// Token: 0x040009DA RID: 2522
	[Token(Token = "0x40009DA")]
	CityBattleZombiePreloadFinish,
	// Token: 0x040009DB RID: 2523
	[Token(Token = "0x40009DB")]
	ResetMailState,
	// Token: 0x040009DC RID: 2524
	[Token(Token = "0x40009DC")]
	OtherPlayInfo,
	// Token: 0x040009DD RID: 2525
	[Token(Token = "0x40009DD")]
	GUIDE_INDEX_CHANGE,
	// Token: 0x040009DE RID: 2526
	[Token(Token = "0x40009DE")]
	BREAK_SOFT_GUIDE,
	// Token: 0x040009DF RID: 2527
	[Token(Token = "0x40009DF")]
	MergeChatMessage,
	// Token: 0x040009E0 RID: 2528
	[Token(Token = "0x40009E0")]
	ShowMailChatTips,
	// Token: 0x040009E1 RID: 2529
	[Token(Token = "0x40009E1")]
	Translate_Dialog,
	// Token: 0x040009E2 RID: 2530
	[Token(Token = "0x40009E2")]
	GUIDE_GOTO_ATTACK_WORKER,
	// Token: 0x040009E3 RID: 2531
	[Token(Token = "0x40009E3")]
	SendMailDone,
	// Token: 0x040009E4 RID: 2532
	[Token(Token = "0x40009E4")]
	MailRemoveInChannel,
	// Token: 0x040009E5 RID: 2533
	[Token(Token = "0x40009E5")]
	REFRESH_MONSTERACTIVITY,
	// Token: 0x040009E6 RID: 2534
	[Token(Token = "0x40009E6")]
	REFRESH_BASEBUILD,
	// Token: 0x040009E7 RID: 2535
	[Token(Token = "0x40009E7")]
	REFRESH_BROKEFENCE,
	// Token: 0x040009E8 RID: 2536
	[Token(Token = "0x40009E8")]
	ShowDialogOriginallan,
	// Token: 0x040009E9 RID: 2537
	[Token(Token = "0x40009E9")]
	WarTroppShowExplain,
	// Token: 0x040009EA RID: 2538
	[Token(Token = "0x40009EA")]
	LoadCityBuildingFinsh,
	// Token: 0x040009EB RID: 2539
	[Token(Token = "0x40009EB")]
	PlayerCareerChanged,
	// Token: 0x040009EC RID: 2540
	[Token(Token = "0x40009EC")]
	CareerInfoUpdate,
	// Token: 0x040009ED RID: 2541
	[Token(Token = "0x40009ED")]
	UpdateQuickSaveStr,
	// Token: 0x040009EE RID: 2542
	[Token(Token = "0x40009EE")]
	RunOutReousrceChipEnergy,
	// Token: 0x040009EF RID: 2543
	[Token(Token = "0x40009EF")]
	BackToBaseCar,
	// Token: 0x040009F0 RID: 2544
	[Token(Token = "0x40009F0")]
	GetReward,
	// Token: 0x040009F1 RID: 2545
	[Token(Token = "0x40009F1")]
	ClearPolt,
	// Token: 0x040009F2 RID: 2546
	[Token(Token = "0x40009F2")]
	PLAY_MP4,
	// Token: 0x040009F3 RID: 2547
	[Token(Token = "0x40009F3")]
	GetRewardAniPlayEnd,
	// Token: 0x040009F4 RID: 2548
	[Token(Token = "0x40009F4")]
	CloseUIBuilding,
	// Token: 0x040009F5 RID: 2549
	[Token(Token = "0x40009F5")]
	PUSH_CLASHEVENT_COMMAND,
	// Token: 0x040009F6 RID: 2550
	[Token(Token = "0x40009F6")]
	CHAT_TRANSLATE_COMMAND,
	// Token: 0x040009F7 RID: 2551
	[Token(Token = "0x40009F7")]
	CHAT_BLOCK_COMMAND,
	// Token: 0x040009F8 RID: 2552
	[Token(Token = "0x40009F8")]
	CHAT_UNBLOCK_COMMAND,
	// Token: 0x040009F9 RID: 2553
	[Token(Token = "0x40009F9")]
	CHAT_RECIEVE_ROOM_MSG_COMMAND,
	// Token: 0x040009FA RID: 2554
	[Token(Token = "0x40009FA")]
	CHAT_UPDATE_ROOM_MSG_COMMAND,
	// Token: 0x040009FB RID: 2555
	[Token(Token = "0x40009FB")]
	CHAT_UPDATE_ALLIANCE_ROOM_COMMAND,
	// Token: 0x040009FC RID: 2556
	[Token(Token = "0x40009FC")]
	REDPACK_VIEWLOG_COMMAND,
	// Token: 0x040009FD RID: 2557
	[Token(Token = "0x40009FD")]
	REDPACK_SELECT_GP_COMMAND,
	// Token: 0x040009FE RID: 2558
	[Token(Token = "0x40009FE")]
	REDPACK_BUY_GP_SUCCESS,
	// Token: 0x040009FF RID: 2559
	[Token(Token = "0x40009FF")]
	CHAT_SHOW_CONTENT_TIPS_COMMAND,
	// Token: 0x04000A00 RID: 2560
	[Token(Token = "0x4000A00")]
	CHAT_HIDE_CONTENT_TIPS_COMMAND,
	// Token: 0x04000A01 RID: 2561
	[Token(Token = "0x4000A01")]
	GOTO_WORLD_POSITION,
	// Token: 0x04000A02 RID: 2562
	[Token(Token = "0x4000A02")]
	CLOSE_CHAT_UI_COMMAND,
	// Token: 0x04000A03 RID: 2563
	[Token(Token = "0x4000A03")]
	REDPACK_SHOW_COMMAND,
	// Token: 0x04000A04 RID: 2564
	[Token(Token = "0x4000A04")]
	CHAT_KEYBOARD_ADJUST_COMMAND,
	// Token: 0x04000A05 RID: 2565
	[Token(Token = "0x4000A05")]
	CHAT_REQUEST_HISTORY_MSG_RESULT,
	// Token: 0x04000A06 RID: 2566
	[Token(Token = "0x4000A06")]
	CHAT_SEND_ROOM_MSG_COMMAND,
	// Token: 0x04000A07 RID: 2567
	[Token(Token = "0x4000A07")]
	CHAT_SEND_ROOM_MSG_SUCCESS,
	// Token: 0x04000A08 RID: 2568
	[Token(Token = "0x4000A08")]
	CHAT_SEND_ROOM_MSG_FAILURE,
	// Token: 0x04000A09 RID: 2569
	[Token(Token = "0x4000A09")]
	CHAT_REQUEST_HISTORY_MSG_COMMAND,
	// Token: 0x04000A0A RID: 2570
	[Token(Token = "0x4000A0A")]
	CHAT_ROOM_CREATE_COMMAND,
	// Token: 0x04000A0B RID: 2571
	[Token(Token = "0x4000A0B")]
	CHAT_LEAVE_ROOM_MSG_COMMAND,
	// Token: 0x04000A0C RID: 2572
	[Token(Token = "0x4000A0C")]
	CHAT_ROOM_CHANGE_NAME_COMMAND,
	// Token: 0x04000A0D RID: 2573
	[Token(Token = "0x4000A0D")]
	CHAT_ROOM_OPEN_INVITE,
	// Token: 0x04000A0E RID: 2574
	[Token(Token = "0x4000A0E")]
	CHAT_ROOM_ENABLE_REMOVE,
	// Token: 0x04000A0F RID: 2575
	[Token(Token = "0x4000A0F")]
	CHAT_ROOM_UPDATE_MEMBER,
	// Token: 0x04000A10 RID: 2576
	[Token(Token = "0x4000A10")]
	CHAT_ROOM_DELETE_MEMBER,
	// Token: 0x04000A11 RID: 2577
	[Token(Token = "0x4000A11")]
	CHAT_ROOM_INVITE_SHOW_ALLIES_RANK,
	// Token: 0x04000A12 RID: 2578
	[Token(Token = "0x4000A12")]
	CHAT_ROOM_INVITE_HIDE_ALLIES_RANK,
	// Token: 0x04000A13 RID: 2579
	[Token(Token = "0x4000A13")]
	CHAT_ROOM_INVITE_USER_TOGGLE_ON,
	// Token: 0x04000A14 RID: 2580
	[Token(Token = "0x4000A14")]
	CHAT_ROOM_INVITE_USER_TOGGLE_OFF,
	// Token: 0x04000A15 RID: 2581
	[Token(Token = "0x4000A15")]
	CHAT_ROOM_INVITE_SEARCH_PLAYER_RESULT,
	// Token: 0x04000A16 RID: 2582
	[Token(Token = "0x4000A16")]
	CHAT_ROOM_INVITE_PLAYER_RESULT,
	// Token: 0x04000A17 RID: 2583
	[Token(Token = "0x4000A17")]
	CHAT_ROOM_OPEN_BY_GROUP,
	// Token: 0x04000A18 RID: 2584
	[Token(Token = "0x4000A18")]
	CHAT_ROOM_OPEN_BY_ID,
	// Token: 0x04000A19 RID: 2585
	[Token(Token = "0x4000A19")]
	CHAT_SEND_VOICE_MSG,
	// Token: 0x04000A1A RID: 2586
	[Token(Token = "0x4000A1A")]
	CHAT_VOICE_PLAY,
	// Token: 0x04000A1B RID: 2587
	[Token(Token = "0x4000A1B")]
	CHAT_VOICE_QUEUE,
	// Token: 0x04000A1C RID: 2588
	[Token(Token = "0x4000A1C")]
	CHAT_RESEND_ROOM_MSG_COMMAND,
	// Token: 0x04000A1D RID: 2589
	[Token(Token = "0x4000A1D")]
	CHAT_REMOVE_ROOM_MSG_COMMAND,
	// Token: 0x04000A1E RID: 2590
	[Token(Token = "0x4000A1E")]
	CloseUIBookMarkAlliance,
	// Token: 0x04000A1F RID: 2591
	[Token(Token = "0x4000A1F")]
	CloseWorldBuildMoving,
	// Token: 0x04000A20 RID: 2592
	[Token(Token = "0x4000A20")]
	WORLD_MOVE_UP_EFFECT,
	// Token: 0x04000A21 RID: 2593
	[Token(Token = "0x4000A21")]
	SCIENCECENTERNEW_CHANGE_INDEX,
	// Token: 0x04000A22 RID: 2594
	[Token(Token = "0x4000A22")]
	CLOSE_SCIENCE_UPGRADE,
	// Token: 0x04000A23 RID: 2595
	[Token(Token = "0x4000A23")]
	UpdateWorldMark,
	// Token: 0x04000A24 RID: 2596
	[Token(Token = "0x4000A24")]
	MSG_DRAWRESULT_BACK,
	// Token: 0x04000A25 RID: 2597
	[Token(Token = "0x4000A25")]
	MSG_AZ_TERRITORY_DETAIL,
	// Token: 0x04000A26 RID: 2598
	[Token(Token = "0x4000A26")]
	ALLIANCE_ARMYGROUP_DOMAIN_CHECK,
	// Token: 0x04000A27 RID: 2599
	[Token(Token = "0x4000A27")]
	CloseOtherTerritoryArmyInfoDetail,
	// Token: 0x04000A28 RID: 2600
	[Token(Token = "0x4000A28")]
	OnEndGarrisonTroopCallBack,
	// Token: 0x04000A29 RID: 2601
	[Token(Token = "0x4000A29")]
	UpdateTerritoryCenterBuildInfoPage,
	// Token: 0x04000A2A RID: 2602
	[Token(Token = "0x4000A2A")]
	UpdateLegionSettingPage,
	// Token: 0x04000A2B RID: 2603
	[Token(Token = "0x4000A2B")]
	SendChosenLegionTroopForSetting,
	// Token: 0x04000A2C RID: 2604
	[Token(Token = "0x4000A2C")]
	ARMYGROUP_LEADER_MEMBER_REFREH,
	// Token: 0x04000A2D RID: 2605
	[Token(Token = "0x4000A2D")]
	ARMYGROUP_DISPATCH_VIEW,
	// Token: 0x04000A2E RID: 2606
	[Token(Token = "0x4000A2E")]
	ALLIANCE_ARMYGROUP_SELECT_ARMYID,
	// Token: 0x04000A2F RID: 2607
	[Token(Token = "0x4000A2F")]
	ALLIANCE_ARMYGROUP_SELECT_ARMYID_EMPTY,
	// Token: 0x04000A30 RID: 2608
	[Token(Token = "0x4000A30")]
	MSG_DOMAINSEASONREWARDCELLITEM,
	// Token: 0x04000A31 RID: 2609
	[Token(Token = "0x4000A31")]
	UI_DOMAIN_PLAYER_RANK_SELECT,
	// Token: 0x04000A32 RID: 2610
	[Token(Token = "0x4000A32")]
	UI_DOMAIN_PLAYER_RANK,
	// Token: 0x04000A33 RID: 2611
	[Token(Token = "0x4000A33")]
	DESERTSENDREWARDLISTMESSAGE,
	// Token: 0x04000A34 RID: 2612
	[Token(Token = "0x4000A34")]
	DECORATE_DRESSBASECITY_REFRESH,
	// Token: 0x04000A35 RID: 2613
	[Token(Token = "0x4000A35")]
	DECORATE_INFONODE_REFRESH,
	// Token: 0x04000A36 RID: 2614
	[Token(Token = "0x4000A36")]
	ScavengePointFinsh,
	// Token: 0x04000A37 RID: 2615
	[Token(Token = "0x4000A37")]
	UIMissileLaunchItemSelect,
	// Token: 0x04000A38 RID: 2616
	[Token(Token = "0x4000A38")]
	FbMissileAlliance,
	// Token: 0x04000A39 RID: 2617
	[Token(Token = "0x4000A39")]
	Combine_Select_Index,
	// Token: 0x04000A3A RID: 2618
	[Token(Token = "0x4000A3A")]
	Close_Item_Combine_Panel,
	// Token: 0x04000A3B RID: 2619
	[Token(Token = "0x4000A3B")]
	Close_UIBuildMenu_Panel,
	// Token: 0x04000A3C RID: 2620
	[Token(Token = "0x4000A3C")]
	CLOSE_LOADEDITORBUILD,
	// Token: 0x04000A3D RID: 2621
	[Token(Token = "0x4000A3D")]
	UPDATE_BUILD_DATA,
	// Token: 0x04000A3E RID: 2622
	[Token(Token = "0x4000A3E")]
	LOAD_COMPLETE = 594,
	// Token: 0x04000A3F RID: 2623
	[Token(Token = "0x4000A3F")]
	COLLECT_OBJECT_SHOW,
	// Token: 0x04000A40 RID: 2624
	[Token(Token = "0x4000A40")]
	COLLECT_OBJECT_HIDE,
	// Token: 0x04000A41 RID: 2625
	[Token(Token = "0x4000A41")]
	UIMAIN_BOTTOM_SELECT_BUILD,
	// Token: 0x04000A42 RID: 2626
	[Token(Token = "0x4000A42")]
	UIMAIN_BOTTOM_SELECT_BUILDTYPE,
	// Token: 0x04000A43 RID: 2627
	[Token(Token = "0x4000A43")]
	UIMAIN_BOTTOM_SELECT_RESOURCE,
	// Token: 0x04000A44 RID: 2628
	[Token(Token = "0x4000A44")]
	GOTO_BUILD,
	// Token: 0x04000A45 RID: 2629
	[Token(Token = "0x4000A45")]
	UIMAIN_BOTTOM_RESET_BUILDTYPE,
	// Token: 0x04000A46 RID: 2630
	[Token(Token = "0x4000A46")]
	UIMAIN_BOTTOM_RESET_BUILDTYPE_INFO,
	// Token: 0x04000A47 RID: 2631
	[Token(Token = "0x4000A47")]
	REGET_MAIN_POSITION,
	// Token: 0x04000A48 RID: 2632
	[Token(Token = "0x4000A48")]
	UPDATE_POINTS_DATA,
	// Token: 0x04000A49 RID: 2633
	[Token(Token = "0x4000A49")]
	UIMAIN_VISIBLE,
	// Token: 0x04000A4A RID: 2634
	[Token(Token = "0x4000A4A")]
	UIMAIN_BOTTOM_CHANGE_BUILD_TYPE,
	// Token: 0x04000A4B RID: 2635
	[Token(Token = "0x4000A4B")]
	UIMAIN_BOTTOM_CHANGE_BUILD_SELECTS,
	// Token: 0x04000A4C RID: 2636
	[Token(Token = "0x4000A4C")]
	UIMAIN_BOTTOM_CHANGE_BUILD_TYPE_INFO,
	// Token: 0x04000A4D RID: 2637
	[Token(Token = "0x4000A4D")]
	UIMAIN_BOTTOM_CHANGE_BUILD_TYPE_SELECT,
	// Token: 0x04000A4E RID: 2638
	[Token(Token = "0x4000A4E")]
	UIMAIN_BOTTOM_CHANGE_MIDDLE_RESOURCE_STATE,
	// Token: 0x04000A4F RID: 2639
	[Token(Token = "0x4000A4F")]
	WORLD_CAMERA_CHANGE_POINT,
	// Token: 0x04000A50 RID: 2640
	[Token(Token = "0x4000A50")]
	UIITEM_SELECT,
	// Token: 0x04000A51 RID: 2641
	[Token(Token = "0x4000A51")]
	CLICK_MAIL_ITEM,
	// Token: 0x04000A52 RID: 2642
	[Token(Token = "0x4000A52")]
	REFRESH_MAIL_TABLE,
	// Token: 0x04000A53 RID: 2643
	[Token(Token = "0x4000A53")]
	REFRESH_RESOURCE_BAG,
	// Token: 0x04000A54 RID: 2644
	[Token(Token = "0x4000A54")]
	CLICK_RESOURCE_ITEM,
	// Token: 0x04000A55 RID: 2645
	[Token(Token = "0x4000A55")]
	UPDATE_SCIENCE_DATA,
	// Token: 0x04000A56 RID: 2646
	[Token(Token = "0x4000A56")]
	CLICK_ALLIANCE_ITEM,
	// Token: 0x04000A57 RID: 2647
	[Token(Token = "0x4000A57")]
	END_SEARCH,
	// Token: 0x04000A58 RID: 2648
	[Token(Token = "0x4000A58")]
	ALLIANCE_WAR_DELETE,
	// Token: 0x04000A59 RID: 2649
	[Token(Token = "0x4000A59")]
	CLICK_FORMATION_ITEM,
	// Token: 0x04000A5A RID: 2650
	[Token(Token = "0x4000A5A")]
	BUILD_IN_VIEW,
	// Token: 0x04000A5B RID: 2651
	[Token(Token = "0x4000A5B")]
	BUILD_OUT_VIEW,
	// Token: 0x04000A5C RID: 2652
	[Token(Token = "0x4000A5C")]
	QUEUE_TIME_END,
	// Token: 0x04000A5D RID: 2653
	[Token(Token = "0x4000A5D")]
	AddBuildSpeedSuccess,
	// Token: 0x04000A5E RID: 2654
	[Token(Token = "0x4000A5E")]
	AllianceQueueHelpNew,
	// Token: 0x04000A5F RID: 2655
	[Token(Token = "0x4000A5F")]
	AllianceBuildHelpNew,
	// Token: 0x04000A60 RID: 2656
	[Token(Token = "0x4000A60")]
	MonsterMoveStart,
	// Token: 0x04000A61 RID: 2657
	[Token(Token = "0x4000A61")]
	MonsterMoveEnd,
	// Token: 0x04000A62 RID: 2658
	[Token(Token = "0x4000A62")]
	PUSH_NOTICE,
	// Token: 0x04000A63 RID: 2659
	[Token(Token = "0x4000A63")]
	CLICK_ALLIANCE_SHOP_ITEM,
	// Token: 0x04000A64 RID: 2660
	[Token(Token = "0x4000A64")]
	AllianceNameChange,
	// Token: 0x04000A65 RID: 2661
	[Token(Token = "0x4000A65")]
	AllianceAbbrChange,
	// Token: 0x04000A66 RID: 2662
	[Token(Token = "0x4000A66")]
	AllianceLanguage,
	// Token: 0x04000A67 RID: 2663
	[Token(Token = "0x4000A67")]
	UIMAIN_CHANGE_BUILD_ENTER,
	// Token: 0x04000A68 RID: 2664
	[Token(Token = "0x4000A68")]
	UIMAIN_CHANGE_BUILD_OUT,
	// Token: 0x04000A69 RID: 2665
	[Token(Token = "0x4000A69")]
	CHAT_LOGIN_SUCCESS,
	// Token: 0x04000A6A RID: 2666
	[Token(Token = "0x4000A6A")]
	CHAT_REFRESH_CHANNEL,
	// Token: 0x04000A6B RID: 2667
	[Token(Token = "0x4000A6B")]
	ROOM_KICK_PLAYER_RESULT,
	// Token: 0x04000A6C RID: 2668
	[Token(Token = "0x4000A6C")]
	UPDATE_MSG_USERINFO,
	// Token: 0x04000A6D RID: 2669
	[Token(Token = "0x4000A6D")]
	CHAT_UPDATE_ROOM_LIST_LASTMSG,
	// Token: 0x04000A6E RID: 2670
	[Token(Token = "0x4000A6E")]
	CHAT_CHANGE_CURRENT_ROOM,
	// Token: 0x04000A6F RID: 2671
	[Token(Token = "0x4000A6F")]
	BuildResourcesStart,
	// Token: 0x04000A70 RID: 2672
	[Token(Token = "0x4000A70")]
	BuildResourcesSecond,
	// Token: 0x04000A71 RID: 2673
	[Token(Token = "0x4000A71")]
	ClickFarmBuildShow,
	// Token: 0x04000A72 RID: 2674
	[Token(Token = "0x4000A72")]
	ClickFarmBuildHide,
	// Token: 0x04000A73 RID: 2675
	[Token(Token = "0x4000A73")]
	BuildConnect,
	// Token: 0x04000A74 RID: 2676
	[Token(Token = "0x4000A74")]
	BuildLackConnect,
	// Token: 0x04000A75 RID: 2677
	[Token(Token = "0x4000A75")]
	RefreshResidentOrder,
	// Token: 0x04000A76 RID: 2678
	[Token(Token = "0x4000A76")]
	RefreshResourceItem,
	// Token: 0x04000A77 RID: 2679
	[Token(Token = "0x4000A77")]
	DelayRefreshResource,
	// Token: 0x04000A78 RID: 2680
	[Token(Token = "0x4000A78")]
	BuildUpgradeAnimationFinish,
	// Token: 0x04000A79 RID: 2681
	[Token(Token = "0x4000A79")]
	EffectNumChange,
	// Token: 0x04000A7A RID: 2682
	[Token(Token = "0x4000A7A")]
	OnWorldInputDragBegin,
	// Token: 0x04000A7B RID: 2683
	[Token(Token = "0x4000A7B")]
	OnWorldInputDragEnd,
	// Token: 0x04000A7C RID: 2684
	[Token(Token = "0x4000A7C")]
	RefreshUIWorldTileUI,
	// Token: 0x04000A7D RID: 2685
	[Token(Token = "0x4000A7D")]
	RefreshFarmUI,
	// Token: 0x04000A7E RID: 2686
	[Token(Token = "0x4000A7E")]
	ShowCapacity,
	// Token: 0x04000A7F RID: 2687
	[Token(Token = "0x4000A7F")]
	RewardItemAdd,
	// Token: 0x04000A80 RID: 2688
	[Token(Token = "0x4000A80")]
	FarmDragEnd,
	// Token: 0x04000A81 RID: 2689
	[Token(Token = "0x4000A81")]
	ChangeCameraLod,
	// Token: 0x04000A82 RID: 2690
	[Token(Token = "0x4000A82")]
	ShowResourceUpdate,
	// Token: 0x04000A83 RID: 2691
	[Token(Token = "0x4000A83")]
	ShowCapacitySecond,
	// Token: 0x04000A84 RID: 2692
	[Token(Token = "0x4000A84")]
	RefreshEarthOrder,
	// Token: 0x04000A85 RID: 2693
	[Token(Token = "0x4000A85")]
	GetNewEarthOrder,
	// Token: 0x04000A86 RID: 2694
	[Token(Token = "0x4000A86")]
	EndEarthOrder,
	// Token: 0x04000A87 RID: 2695
	[Token(Token = "0x4000A87")]
	ViewEndEarthOrder,
	// Token: 0x04000A88 RID: 2696
	[Token(Token = "0x4000A88")]
	GetFactoryData,
	// Token: 0x04000A89 RID: 2697
	[Token(Token = "0x4000A89")]
	GatherFactoryItem,
	// Token: 0x04000A8A RID: 2698
	[Token(Token = "0x4000A8A")]
	AddFactoryBox,
	// Token: 0x04000A8B RID: 2699
	[Token(Token = "0x4000A8B")]
	AddFactoryProduct,
	// Token: 0x04000A8C RID: 2700
	[Token(Token = "0x4000A8C")]
	OnMeteoriteHitGlass,
	// Token: 0x04000A8D RID: 2701
	[Token(Token = "0x4000A8D")]
	UIMainWarningShow,
	// Token: 0x04000A8E RID: 2702
	[Token(Token = "0x4000A8E")]
	UIMainWarningHide,
	// Token: 0x04000A8F RID: 2703
	[Token(Token = "0x4000A8F")]
	FoldUpBuilding,
	// Token: 0x04000A90 RID: 2704
	[Token(Token = "0x4000A90")]
	LOAD_PLAY_VIDEO,
	// Token: 0x04000A91 RID: 2705
	[Token(Token = "0x4000A91")]
	FarmSecondProduct,
	// Token: 0x04000A92 RID: 2706
	[Token(Token = "0x4000A92")]
	Guide_video_Play,
	// Token: 0x04000A93 RID: 2707
	[Token(Token = "0x4000A93")]
	AllianceAnnounce,
	// Token: 0x04000A94 RID: 2708
	[Token(Token = "0x4000A94")]
	AllianceRestriction,
	// Token: 0x04000A95 RID: 2709
	[Token(Token = "0x4000A95")]
	GET_INVITE_USERS_SUCCESS,
	// Token: 0x04000A96 RID: 2710
	[Token(Token = "0x4000A96")]
	GOTO_SCIENCE,
	// Token: 0x04000A97 RID: 2711
	[Token(Token = "0x4000A97")]
	LF_AccountListView_Close,
	// Token: 0x04000A98 RID: 2712
	[Token(Token = "0x4000A98")]
	LF_AccountListView_Refresh,
	// Token: 0x04000A99 RID: 2713
	[Token(Token = "0x4000A99")]
	LF_Account_History,
	// Token: 0x04000A9A RID: 2714
	[Token(Token = "0x4000A9A")]
	MessageBallChange,
	// Token: 0x04000A9B RID: 2715
	[Token(Token = "0x4000A9B")]
	GatherResourceItemFinish,
	// Token: 0x04000A9C RID: 2716
	[Token(Token = "0x4000A9C")]
	SoldResourceItem = 689,
	// Token: 0x04000A9D RID: 2717
	[Token(Token = "0x4000A9D")]
	LUA_BUILD_INIT_END,
	// Token: 0x04000A9E RID: 2718
	[Token(Token = "0x4000A9E")]
	CanGetProduct,
	// Token: 0x04000A9F RID: 2719
	[Token(Token = "0x4000A9F")]
	GetAllProduct,
	// Token: 0x04000AA0 RID: 2720
	[Token(Token = "0x4000AA0")]
	RefreshUIBuildQueue,
	// Token: 0x04000AA1 RID: 2721
	[Token(Token = "0x4000AA1")]
	RefreshFarmGatherUI,
	// Token: 0x04000AA2 RID: 2722
	[Token(Token = "0x4000AA2")]
	HeroAdvanceSuccess,
	// Token: 0x04000AA3 RID: 2723
	[Token(Token = "0x4000AA3")]
	HeroLvUpSuccess,
	// Token: 0x04000AA4 RID: 2724
	[Token(Token = "0x4000AA4")]
	ClickFarmBuildShowEffect,
	// Token: 0x04000AA5 RID: 2725
	[Token(Token = "0x4000AA5")]
	ClickFarmBuildHideEffect,
	// Token: 0x04000AA6 RID: 2726
	[Token(Token = "0x4000AA6")]
	ShowMainUIExtraResource,
	// Token: 0x04000AA7 RID: 2727
	[Token(Token = "0x4000AA7")]
	HideMainUIExtraResource,
	// Token: 0x04000AA8 RID: 2728
	[Token(Token = "0x4000AA8")]
	TouchPastureAnimal,
	// Token: 0x04000AA9 RID: 2729
	[Token(Token = "0x4000AA9")]
	RefreshPastureUI,
	// Token: 0x04000AAA RID: 2730
	[Token(Token = "0x4000AAA")]
	SetNewAnimal,
	// Token: 0x04000AAB RID: 2731
	[Token(Token = "0x4000AAB")]
	HeroResetSuccess,
	// Token: 0x04000AAC RID: 2732
	[Token(Token = "0x4000AAC")]
	OnCancelHeroSelect,
	// Token: 0x04000AAD RID: 2733
	[Token(Token = "0x4000AAD")]
	AllianceInitOK,
	// Token: 0x04000AAE RID: 2734
	[Token(Token = "0x4000AAE")]
	AllianceQuitOK,
	// Token: 0x04000AAF RID: 2735
	[Token(Token = "0x4000AAF")]
	ReturnTimeFromCurPosToTargetPos,
	// Token: 0x04000AB0 RID: 2736
	[Token(Token = "0x4000AB0")]
	Mail_DeleteMailDone,
	// Token: 0x04000AB1 RID: 2737
	[Token(Token = "0x4000AB1")]
	Mail_DeleteBatchMailDone,
	// Token: 0x04000AB2 RID: 2738
	[Token(Token = "0x4000AB2")]
	Mail_Select_Channel,
	// Token: 0x04000AB3 RID: 2739
	[Token(Token = "0x4000AB3")]
	OnSelectHeroSelect,
	// Token: 0x04000AB4 RID: 2740
	[Token(Token = "0x4000AB4")]
	UIResourceCostChangeState,
	// Token: 0x04000AB5 RID: 2741
	[Token(Token = "0x4000AB5")]
	RecruitCampChange,
	// Token: 0x04000AB6 RID: 2742
	[Token(Token = "0x4000AB6")]
	AllianceIntro,
	// Token: 0x04000AB7 RID: 2743
	[Token(Token = "0x4000AB7")]
	AllianceMemberNeedHelp,
	// Token: 0x04000AB8 RID: 2744
	[Token(Token = "0x4000AB8")]
	COLLECT_OBJECT_SHOWNew,
	// Token: 0x04000AB9 RID: 2745
	[Token(Token = "0x4000AB9")]
	COLLECT_OBJECT_HIDENew,
	// Token: 0x04000ABA RID: 2746
	[Token(Token = "0x4000ABA")]
	ChangeNameIcon_Select,
	// Token: 0x04000ABB RID: 2747
	[Token(Token = "0x4000ABB")]
	UpdatePlayerHeadIcon,
	// Token: 0x04000ABC RID: 2748
	[Token(Token = "0x4000ABC")]
	UpdateCollectPos,
	// Token: 0x04000ABD RID: 2749
	[Token(Token = "0x4000ABD")]
	GetAssistanceData,
	// Token: 0x04000ABE RID: 2750
	[Token(Token = "0x4000ABE")]
	FakeBuildingSelectLocation,
	// Token: 0x04000ABF RID: 2751
	[Token(Token = "0x4000ABF")]
	UpdateFakeBuildingPos,
	// Token: 0x04000AC0 RID: 2752
	[Token(Token = "0x4000AC0")]
	ShowIsOnFire,
	// Token: 0x04000AC1 RID: 2753
	[Token(Token = "0x4000AC1")]
	UpdateRankPreview,
	// Token: 0x04000AC2 RID: 2754
	[Token(Token = "0x4000AC2")]
	GetAllDetectInfo,
	// Token: 0x04000AC3 RID: 2755
	[Token(Token = "0x4000AC3")]
	UpgradeDetectPower,
	// Token: 0x04000AC4 RID: 2756
	[Token(Token = "0x4000AC4")]
	DetectInfoChange,
	// Token: 0x04000AC5 RID: 2757
	[Token(Token = "0x4000AC5")]
	HeroMedalExchanged,
	// Token: 0x04000AC6 RID: 2758
	[Token(Token = "0x4000AC6")]
	OnClickWorld,
	// Token: 0x04000AC7 RID: 2759
	[Token(Token = "0x4000AC7")]
	OnClickMarch,
	// Token: 0x04000AC8 RID: 2760
	[Token(Token = "0x4000AC8")]
	CheckDomeOpen,
	// Token: 0x04000AC9 RID: 2761
	[Token(Token = "0x4000AC9")]
	CollectAnimEnd,
	// Token: 0x04000ACA RID: 2762
	[Token(Token = "0x4000ACA")]
	MailScoutReposition,
	// Token: 0x04000ACB RID: 2763
	[Token(Token = "0x4000ACB")]
	MailDetailReport_ClickItem,
	// Token: 0x04000ACC RID: 2764
	[Token(Token = "0x4000ACC")]
	RefreshArrow,
	// Token: 0x04000ACD RID: 2765
	[Token(Token = "0x4000ACD")]
	OnGoodsRedState,
	// Token: 0x04000ACE RID: 2766
	[Token(Token = "0x4000ACE")]
	LoginCommandError,
	// Token: 0x04000ACF RID: 2767
	[Token(Token = "0x4000ACF")]
	LoginInitError,
	// Token: 0x04000AD0 RID: 2768
	[Token(Token = "0x4000AD0")]
	Net_Connect_Error,
	// Token: 0x04000AD1 RID: 2769
	[Token(Token = "0x4000AD1")]
	Net_Server_Status,
	// Token: 0x04000AD2 RID: 2770
	[Token(Token = "0x4000AD2")]
	CloseDisconnectView,
	// Token: 0x04000AD3 RID: 2771
	[Token(Token = "0x4000AD3")]
	WorldTroopGameObjectCreateFinish,
	// Token: 0x04000AD4 RID: 2772
	[Token(Token = "0x4000AD4")]
	CheckShowMainBuildLabel,
	// Token: 0x04000AD5 RID: 2773
	[Token(Token = "0x4000AD5")]
	ShowTroopHeadNotBattle,
	// Token: 0x04000AD6 RID: 2774
	[Token(Token = "0x4000AD6")]
	ShowTroopHeadInBattle,
	// Token: 0x04000AD7 RID: 2775
	[Token(Token = "0x4000AD7")]
	ShowTroopBattleValue,
	// Token: 0x04000AD8 RID: 2776
	[Token(Token = "0x4000AD8")]
	HideTroopHead,
	// Token: 0x04000AD9 RID: 2777
	[Token(Token = "0x4000AD9")]
	DetectEventRewardGet,
	// Token: 0x04000ADA RID: 2778
	[Token(Token = "0x4000ADA")]
	Event_ShowBattleReportDetail,
	// Token: 0x04000ADB RID: 2779
	[Token(Token = "0x4000ADB")]
	BundleDownloadProgress,
	// Token: 0x04000ADC RID: 2780
	[Token(Token = "0x4000ADC")]
	RefreshDataPersonalArms,
	// Token: 0x04000ADD RID: 2781
	[Token(Token = "0x4000ADD")]
	CheckPubBubble,
	// Token: 0x04000ADE RID: 2782
	[Token(Token = "0x4000ADE")]
	AlGiftHideNameStateUpdate,
	// Token: 0x04000ADF RID: 2783
	[Token(Token = "0x4000ADF")]
	RefreshTopResByPickUp,
	// Token: 0x04000AE0 RID: 2784
	[Token(Token = "0x4000AE0")]
	DailyQuestReward,
	// Token: 0x04000AE1 RID: 2785
	[Token(Token = "0x4000AE1")]
	OnAdvanceSuccessClosed,
	// Token: 0x04000AE2 RID: 2786
	[Token(Token = "0x4000AE2")]
	UpdateRoadData,
	// Token: 0x04000AE3 RID: 2787
	[Token(Token = "0x4000AE3")]
	ShowTroopName,
	// Token: 0x04000AE4 RID: 2788
	[Token(Token = "0x4000AE4")]
	HideTroopName,
	// Token: 0x04000AE5 RID: 2789
	[Token(Token = "0x4000AE5")]
	CheckTroopStateIcon,
	// Token: 0x04000AE6 RID: 2790
	[Token(Token = "0x4000AE6")]
	UpdateCityPoint,
	// Token: 0x04000AE7 RID: 2791
	[Token(Token = "0x4000AE7")]
	Queue_Add,
	// Token: 0x04000AE8 RID: 2792
	[Token(Token = "0x4000AE8")]
	CityTroopMove,
	// Token: 0x04000AE9 RID: 2793
	[Token(Token = "0x4000AE9")]
	CityGarbageResult,
	// Token: 0x04000AEA RID: 2794
	[Token(Token = "0x4000AEA")]
	OpenUI,
	// Token: 0x04000AEB RID: 2795
	[Token(Token = "0x4000AEB")]
	RefreshGuide,
	// Token: 0x04000AEC RID: 2796
	[Token(Token = "0x4000AEC")]
	QuestRewardSuccess,
	// Token: 0x04000AED RID: 2797
	[Token(Token = "0x4000AED")]
	Build_Time_End,
	// Token: 0x04000AEE RID: 2798
	[Token(Token = "0x4000AEE")]
	Nofity_Alliance_Battle_Week_Rusult_VS,
	// Token: 0x04000AEF RID: 2799
	[Token(Token = "0x4000AEF")]
	AllianceCompeteRankListUpdated,
	// Token: 0x04000AF0 RID: 2800
	[Token(Token = "0x4000AF0")]
	AllianceCompeteRewardsReposition,
	// Token: 0x04000AF1 RID: 2801
	[Token(Token = "0x4000AF1")]
	AllianceCompeteWeeklySummaryUpdated,
	// Token: 0x04000AF2 RID: 2802
	[Token(Token = "0x4000AF2")]
	AllianceArms_OpenBox,
	// Token: 0x04000AF3 RID: 2803
	[Token(Token = "0x4000AF3")]
	RefreshAllianceArmsUI,
	// Token: 0x04000AF4 RID: 2804
	[Token(Token = "0x4000AF4")]
	StopSvAutoToCell,
	// Token: 0x04000AF5 RID: 2805
	[Token(Token = "0x4000AF5")]
	PlayGetReward,
	// Token: 0x04000AF6 RID: 2806
	[Token(Token = "0x4000AF6")]
	CreatedResidentOrder,
	// Token: 0x04000AF7 RID: 2807
	[Token(Token = "0x4000AF7")]
	CameraFollowCityTroop,
	// Token: 0x04000AF8 RID: 2808
	[Token(Token = "0x4000AF8")]
	OnWorldInputPointDown,
	// Token: 0x04000AF9 RID: 2809
	[Token(Token = "0x4000AF9")]
	TroopRotation,
	// Token: 0x04000AFA RID: 2810
	[Token(Token = "0x4000AFA")]
	SevenDayGetReward,
	// Token: 0x04000AFB RID: 2811
	[Token(Token = "0x4000AFB")]
	SkipFactoryAni,
	// Token: 0x04000AFC RID: 2812
	[Token(Token = "0x4000AFC")]
	ShowDomeHideEffect,
	// Token: 0x04000AFD RID: 2813
	[Token(Token = "0x4000AFD")]
	ShowDomeShowEffect,
	// Token: 0x04000AFE RID: 2814
	[Token(Token = "0x4000AFE")]
	OpenFogSuccess,
	// Token: 0x04000AFF RID: 2815
	[Token(Token = "0x4000AFF")]
	OnTaskForceRefreshFinish,
	// Token: 0x04000B00 RID: 2816
	[Token(Token = "0x4000B00")]
	OnSpecialTaskUpdate,
	// Token: 0x04000B01 RID: 2817
	[Token(Token = "0x4000B01")]
	AttackExploreStart,
	// Token: 0x04000B02 RID: 2818
	[Token(Token = "0x4000B02")]
	AttackExploreEnd,
	// Token: 0x04000B03 RID: 2819
	[Token(Token = "0x4000B03")]
	WorldMarchDelete,
	// Token: 0x04000B04 RID: 2820
	[Token(Token = "0x4000B04")]
	GuideTimelineMarker,
	// Token: 0x04000B05 RID: 2821
	[Token(Token = "0x4000B05")]
	ContentLayoutReposition,
	// Token: 0x04000B06 RID: 2822
	[Token(Token = "0x4000B06")]
	ShowExploreHeadInBattle,
	// Token: 0x04000B07 RID: 2823
	[Token(Token = "0x4000B07")]
	ShowExploreBattleValue,
	// Token: 0x04000B08 RID: 2824
	[Token(Token = "0x4000B08")]
	HideExploreHead,
	// Token: 0x04000B09 RID: 2825
	[Token(Token = "0x4000B09")]
	CityFightResult,
	// Token: 0x04000B0A RID: 2826
	[Token(Token = "0x4000B0A")]
	CreateFormationUuid,
	// Token: 0x04000B0B RID: 2827
	[Token(Token = "0x4000B0B")]
	RefreshCityTroopPeopleNum,
	// Token: 0x04000B0C RID: 2828
	[Token(Token = "0x4000B0C")]
	BuildMainZeroUpgradeSuccess,
	// Token: 0x04000B0D RID: 2829
	[Token(Token = "0x4000B0D")]
	FirstPayStatusChange,
	// Token: 0x04000B0E RID: 2830
	[Token(Token = "0x4000B0E")]
	FarmGuideFakePlant,
	// Token: 0x04000B0F RID: 2831
	[Token(Token = "0x4000B0F")]
	GetSingleGarbageInfoSuccess,
	// Token: 0x04000B10 RID: 2832
	[Token(Token = "0x4000B10")]
	FarmGuideFakePlantShowState,
	// Token: 0x04000B11 RID: 2833
	[Token(Token = "0x4000B11")]
	ChapterTaskGetReward,
	// Token: 0x04000B12 RID: 2834
	[Token(Token = "0x4000B12")]
	GarbageCollectStart,
	// Token: 0x04000B13 RID: 2835
	[Token(Token = "0x4000B13")]
	SingleGarbageCollectStart,
	// Token: 0x04000B14 RID: 2836
	[Token(Token = "0x4000B14")]
	GuideMoveArrowPlayAnim,
	// Token: 0x04000B15 RID: 2837
	[Token(Token = "0x4000B15")]
	WorldArmyCollectAnimEnd,
	// Token: 0x04000B16 RID: 2838
	[Token(Token = "0x4000B16")]
	ShowLoadEditorBuild,
	// Token: 0x04000B17 RID: 2839
	[Token(Token = "0x4000B17")]
	VipDataRefresh,
	// Token: 0x04000B18 RID: 2840
	[Token(Token = "0x4000B18")]
	VipRefreshFree,
	// Token: 0x04000B19 RID: 2841
	[Token(Token = "0x4000B19")]
	VipRefreshPayGift,
	// Token: 0x04000B1A RID: 2842
	[Token(Token = "0x4000B1A")]
	ShowPower,
	// Token: 0x04000B1B RID: 2843
	[Token(Token = "0x4000B1B")]
	DailyQuestLs,
	// Token: 0x04000B1C RID: 2844
	[Token(Token = "0x4000B1C")]
	ShowAllGuideObject,
	// Token: 0x04000B1D RID: 2845
	[Token(Token = "0x4000B1D")]
	UnlockFogAnim,
	// Token: 0x04000B1E RID: 2846
	[Token(Token = "0x4000B1E")]
	ReadOneMailRespond,
	// Token: 0x04000B1F RID: 2847
	[Token(Token = "0x4000B1F")]
	WelfareStatusChange,
	// Token: 0x04000B20 RID: 2848
	[Token(Token = "0x4000B20")]
	CloseUI,
	// Token: 0x04000B21 RID: 2849
	[Token(Token = "0x4000B21")]
	UpdateGiftPackData,
	// Token: 0x04000B22 RID: 2850
	[Token(Token = "0x4000B22")]
	ToggleRecruitScene,
	// Token: 0x04000B23 RID: 2851
	[Token(Token = "0x4000B23")]
	BeginDownloadUpdate,
	// Token: 0x04000B24 RID: 2852
	[Token(Token = "0x4000B24")]
	EndDownloadUpdate,
	// Token: 0x04000B25 RID: 2853
	[Token(Token = "0x4000B25")]
	NetworkRetry,
	// Token: 0x04000B26 RID: 2854
	[Token(Token = "0x4000B26")]
	UINoInput = 828,
	// Token: 0x04000B27 RID: 2855
	[Token(Token = "0x4000B27")]
	UIMainShowMailTips,
	// Token: 0x04000B28 RID: 2856
	[Token(Token = "0x4000B28")]
	AllianceWarNewStatusChanged,
	// Token: 0x04000B29 RID: 2857
	[Token(Token = "0x4000B29")]
	ShowHeroIconByUseSkill,
	// Token: 0x04000B2A RID: 2858
	[Token(Token = "0x4000B2A")]
	RefreshGuideAnim,
	// Token: 0x04000B2B RID: 2859
	[Token(Token = "0x4000B2B")]
	ShowHeroHitedUiEffect = 834,
	// Token: 0x04000B2C RID: 2860
	[Token(Token = "0x4000B2C")]
	BuildBoxOpenFinish,
	// Token: 0x04000B2D RID: 2861
	[Token(Token = "0x4000B2D")]
	ShowCanBuildEffect,
	// Token: 0x04000B2E RID: 2862
	[Token(Token = "0x4000B2E")]
	HideCanBuildEffect,
	// Token: 0x04000B2F RID: 2863
	[Token(Token = "0x4000B2F")]
	ShowUIMainSearch,
	// Token: 0x04000B30 RID: 2864
	[Token(Token = "0x4000B30")]
	CityDomeShow,
	// Token: 0x04000B31 RID: 2865
	[Token(Token = "0x4000B31")]
	CityDomeHide,
	// Token: 0x04000B32 RID: 2866
	[Token(Token = "0x4000B32")]
	ShowDomeGlass,
	// Token: 0x04000B33 RID: 2867
	[Token(Token = "0x4000B33")]
	ShowBuildTopUI,
	// Token: 0x04000B34 RID: 2868
	[Token(Token = "0x4000B34")]
	HideBuildTopUI,
	// Token: 0x04000B35 RID: 2869
	[Token(Token = "0x4000B35")]
	GuideNoOpenUI,
	// Token: 0x04000B36 RID: 2870
	[Token(Token = "0x4000B36")]
	LowFps,
	// Token: 0x04000B37 RID: 2871
	[Token(Token = "0x4000B37")]
	GuideWaitMessage,
	// Token: 0x04000B38 RID: 2872
	[Token(Token = "0x4000B38")]
	GetNewGroceryStoreOrder,
	// Token: 0x04000B39 RID: 2873
	[Token(Token = "0x4000B39")]
	RefreshGroceryStoreOrder,
	// Token: 0x04000B3A RID: 2874
	[Token(Token = "0x4000B3A")]
	EndGroceryStoreOrder,
	// Token: 0x04000B3B RID: 2875
	[Token(Token = "0x4000B3B")]
	OnAnyViewClosed,
	// Token: 0x04000B3C RID: 2876
	[Token(Token = "0x4000B3C")]
	OnPackageInfoUpdated,
	// Token: 0x04000B3D RID: 2877
	[Token(Token = "0x4000B3D")]
	WorldAllianceCityDetail,
	// Token: 0x04000B3E RID: 2878
	[Token(Token = "0x4000B3E")]
	UIPlaceBuildChangePos,
	// Token: 0x04000B3F RID: 2879
	[Token(Token = "0x4000B3F")]
	FormationInfoUpdate,
	// Token: 0x04000B40 RID: 2880
	[Token(Token = "0x4000B40")]
	UICreateFakePlaceBuild,
	// Token: 0x04000B41 RID: 2881
	[Token(Token = "0x4000B41")]
	GetOneAllianceGift,
	// Token: 0x04000B42 RID: 2882
	[Token(Token = "0x4000B42")]
	AllianceOrderRank,
	// Token: 0x04000B43 RID: 2883
	[Token(Token = "0x4000B43")]
	ShowAllianceCitySoldierBlood,
	// Token: 0x04000B44 RID: 2884
	[Token(Token = "0x4000B44")]
	HideAllianceCitySoliderBlood,
	// Token: 0x04000B45 RID: 2885
	[Token(Token = "0x4000B45")]
	AllianceOrderGetInfo,
	// Token: 0x04000B46 RID: 2886
	[Token(Token = "0x4000B46")]
	AllianceOrderGetRank,
	// Token: 0x04000B47 RID: 2887
	[Token(Token = "0x4000B47")]
	AllianceOrderReceive,
	// Token: 0x04000B48 RID: 2888
	[Token(Token = "0x4000B48")]
	AllianceOrderGiveUp,
	// Token: 0x04000B49 RID: 2889
	[Token(Token = "0x4000B49")]
	AllianceOrderFill,
	// Token: 0x04000B4A RID: 2890
	[Token(Token = "0x4000B4A")]
	AllianceOrderGetReward,
	// Token: 0x04000B4B RID: 2891
	[Token(Token = "0x4000B4B")]
	WorldCityOwnerInfoReceived,
	// Token: 0x04000B4C RID: 2892
	[Token(Token = "0x4000B4C")]
	WorldCityOwnerInfoChanged,
	// Token: 0x04000B4D RID: 2893
	[Token(Token = "0x4000B4D")]
	RefreshUIWorldPointView,
	// Token: 0x04000B4E RID: 2894
	[Token(Token = "0x4000B4E")]
	OnWorldInputPointClick,
	// Token: 0x04000B4F RID: 2895
	[Token(Token = "0x4000B4F")]
	OnWorldInputPointDrag,
	// Token: 0x04000B50 RID: 2896
	[Token(Token = "0x4000B50")]
	OnWorldInputPointUp,
	// Token: 0x04000B51 RID: 2897
	[Token(Token = "0x4000B51")]
	RefreshTopResSuc,
	// Token: 0x04000B52 RID: 2898
	[Token(Token = "0x4000B52")]
	AlLeaderElectStatusChange,
	// Token: 0x04000B53 RID: 2899
	[Token(Token = "0x4000B53")]
	AlLeaderVoteStatusChange,
	// Token: 0x04000B54 RID: 2900
	[Token(Token = "0x4000B54")]
	AlSysStateChange,
	// Token: 0x04000B55 RID: 2901
	[Token(Token = "0x4000B55")]
	AlLeaderCandidateUpdate,
	// Token: 0x04000B56 RID: 2902
	[Token(Token = "0x4000B56")]
	UserResSynNew = 878,
	// Token: 0x04000B57 RID: 2903
	[Token(Token = "0x4000B57")]
	RefreshUIGuideHeadTalk,
	// Token: 0x04000B58 RID: 2904
	[Token(Token = "0x4000B58")]
	AllianceOrderUpdateStage,
	// Token: 0x04000B59 RID: 2905
	[Token(Token = "0x4000B59")]
	UnlockBuilding,
	// Token: 0x04000B5A RID: 2906
	[Token(Token = "0x4000B5A")]
	RefreshMonsterRewardBag,
	// Token: 0x04000B5B RID: 2907
	[Token(Token = "0x4000B5B")]
	MarchEndWithReward,
	// Token: 0x04000B5C RID: 2908
	[Token(Token = "0x4000B5C")]
	MarchFail,
	// Token: 0x04000B5D RID: 2909
	[Token(Token = "0x4000B5D")]
	ShowTroopAction,
	// Token: 0x04000B5E RID: 2910
	[Token(Token = "0x4000B5E")]
	HideTroopAction,
	// Token: 0x04000B5F RID: 2911
	[Token(Token = "0x4000B5F")]
	ShowCityTroopObject,
	// Token: 0x04000B60 RID: 2912
	[Token(Token = "0x4000B60")]
	RefreshActivityRedDot,
	// Token: 0x04000B61 RID: 2913
	[Token(Token = "0x4000B61")]
	ShowUnlockBtn,
	// Token: 0x04000B62 RID: 2914
	[Token(Token = "0x4000B62")]
	UpdateDayActInfo,
	// Token: 0x04000B63 RID: 2915
	[Token(Token = "0x4000B63")]
	HideMarchTip,
	// Token: 0x04000B64 RID: 2916
	[Token(Token = "0x4000B64")]
	MonthCardInfoUpdated,
	// Token: 0x04000B65 RID: 2917
	[Token(Token = "0x4000B65")]
	ShowGolloesMonthCardRewards,
	// Token: 0x04000B66 RID: 2918
	[Token(Token = "0x4000B66")]
	GolloesNumChange,
	// Token: 0x04000B67 RID: 2919
	[Token(Token = "0x4000B67")]
	GolloesFreeSpeedTimeChange,
	// Token: 0x04000B68 RID: 2920
	[Token(Token = "0x4000B68")]
	GolloesExplorerRewardStateChange,
	// Token: 0x04000B69 RID: 2921
	[Token(Token = "0x4000B69")]
	GolloesTraderRewardStateChange,
	// Token: 0x04000B6A RID: 2922
	[Token(Token = "0x4000B6A")]
	GolloesDataChange,
	// Token: 0x04000B6B RID: 2923
	[Token(Token = "0x4000B6B")]
	ScrollViewContentChange,
	// Token: 0x04000B6C RID: 2924
	[Token(Token = "0x4000B6C")]
	ShowCityTroopHead,
	// Token: 0x04000B6D RID: 2925
	[Token(Token = "0x4000B6D")]
	HideCityTroopHead,
	// Token: 0x04000B6E RID: 2926
	[Token(Token = "0x4000B6E")]
	RefreshTerrainDecoration,
	// Token: 0x04000B6F RID: 2927
	[Token(Token = "0x4000B6F")]
	AllianceCityInView,
	// Token: 0x04000B70 RID: 2928
	[Token(Token = "0x4000B70")]
	AllianceCityOutView,
	// Token: 0x04000B71 RID: 2929
	[Token(Token = "0x4000B71")]
	UI_SHOWNOTICE,
	// Token: 0x04000B72 RID: 2930
	[Token(Token = "0x4000B72")]
	UpdatePlayerExp = 910,
	// Token: 0x04000B73 RID: 2931
	[Token(Token = "0x4000B73")]
	ReceiveLevelReward,
	// Token: 0x04000B74 RID: 2932
	[Token(Token = "0x4000B74")]
	PasturePanelStateChange,
	// Token: 0x04000B75 RID: 2933
	[Token(Token = "0x4000B75")]
	CloseGuideMoveArrow,
	// Token: 0x04000B76 RID: 2934
	[Token(Token = "0x4000B76")]
	RefreshRecommendShow,
	// Token: 0x04000B77 RID: 2935
	[Token(Token = "0x4000B77")]
	UpdateMyAlCities,
	// Token: 0x04000B78 RID: 2936
	[Token(Token = "0x4000B78")]
	MyAlCityListChanged,
	// Token: 0x04000B79 RID: 2937
	[Token(Token = "0x4000B79")]
	AllianceBaseDataUpdated = 918,
	// Token: 0x04000B7A RID: 2938
	[Token(Token = "0x4000B7A")]
	RefreshDataAllianceArms = 923,
	// Token: 0x04000B7B RID: 2939
	[Token(Token = "0x4000B7B")]
	ShowBattleRedName,
	// Token: 0x04000B7C RID: 2940
	[Token(Token = "0x4000B7C")]
	HideSkillHeadEffect,
	// Token: 0x04000B7D RID: 2941
	[Token(Token = "0x4000B7D")]
	ShowPickGarbageResource,
	// Token: 0x04000B7E RID: 2942
	[Token(Token = "0x4000B7E")]
	MarchAdd,
	// Token: 0x04000B7F RID: 2943
	[Token(Token = "0x4000B7F")]
	MarchDelete,
	// Token: 0x04000B80 RID: 2944
	[Token(Token = "0x4000B80")]
	ReInitLoadingLuaState,
	// Token: 0x04000B81 RID: 2945
	[Token(Token = "0x4000B81")]
	MarchItemTargetMeUpdate = 932,
	// Token: 0x04000B82 RID: 2946
	[Token(Token = "0x4000B82")]
	MarchItemUpdateSelf = 935,
	// Token: 0x04000B83 RID: 2947
	[Token(Token = "0x4000B83")]
	ShowTroopAtkBuildIcon,
	// Token: 0x04000B84 RID: 2948
	[Token(Token = "0x4000B84")]
	HideTroopAtkBuildIcon,
	// Token: 0x04000B85 RID: 2949
	[Token(Token = "0x4000B85")]
	LoadingState = 948,
	// Token: 0x04000B86 RID: 2950
	[Token(Token = "0x4000B86")]
	WORLD_BUILD_IN_VIEW = 958,
	// Token: 0x04000B87 RID: 2951
	[Token(Token = "0x4000B87")]
	WORLD_BUILD_OUT_VIEW,
	// Token: 0x04000B88 RID: 2952
	[Token(Token = "0x4000B88")]
	ShowBuildAttackHeadUI = 1002,
	// Token: 0x04000B89 RID: 2953
	[Token(Token = "0x4000B89")]
	HideBuildAttackHeadUI,
	// Token: 0x04000B8A RID: 2954
	[Token(Token = "0x4000B8A")]
	ShowBuildDestroyEffect = 1011,
	// Token: 0x04000B8B RID: 2955
	[Token(Token = "0x4000B8B")]
	ShowBuildFixEffect,
	// Token: 0x04000B8C RID: 2956
	[Token(Token = "0x4000B8C")]
	LandUnlock = 1041,
	// Token: 0x04000B8D RID: 2957
	[Token(Token = "0x4000B8D")]
	ShowBattleBuff = 1051,
	// Token: 0x04000B8E RID: 2958
	[Token(Token = "0x4000B8E")]
	HideBattleBuff,
	// Token: 0x04000B8F RID: 2959
	[Token(Token = "0x4000B8F")]
	ShowWorldZoneChangeColor,
	// Token: 0x04000B90 RID: 2960
	[Token(Token = "0x4000B90")]
	ChangeShowFarmState = 1055,
	// Token: 0x04000B91 RID: 2961
	[Token(Token = "0x4000B91")]
	ChangeShowAnimalState,
	// Token: 0x04000B92 RID: 2962
	[Token(Token = "0x4000B92")]
	SetCityLabelShow = 1060,
	// Token: 0x04000B93 RID: 2963
	[Token(Token = "0x4000B93")]
	ShowDesertAttackHeadUI,
	// Token: 0x04000B94 RID: 2964
	[Token(Token = "0x4000B94")]
	DesertInView,
	// Token: 0x04000B95 RID: 2965
	[Token(Token = "0x4000B95")]
	DesertOutView,
	// Token: 0x04000B96 RID: 2966
	[Token(Token = "0x4000B96")]
	ShowActBossBattleValue,
	// Token: 0x04000B97 RID: 2967
	[Token(Token = "0x4000B97")]
	LandLockInView = 1072,
	// Token: 0x04000B98 RID: 2968
	[Token(Token = "0x4000B98")]
	LandLockOutView,
	// Token: 0x04000B99 RID: 2969
	[Token(Token = "0x4000B99")]
	LandLockStateUpdate,
	// Token: 0x04000B9A RID: 2970
	[Token(Token = "0x4000B9A")]
	WorldZoneChangeColorFinish = 1088,
	// Token: 0x04000B9B RID: 2971
	[Token(Token = "0x4000B9B")]
	ShowMarchTrans = 1098,
	// Token: 0x04000B9C RID: 2972
	[Token(Token = "0x4000B9C")]
	HideMarchTrans,
	// Token: 0x04000B9D RID: 2973
	[Token(Token = "0x4000B9D")]
	ShowWorldMarchByType = 1124,
	// Token: 0x04000B9E RID: 2974
	[Token(Token = "0x4000B9E")]
	HideWorldMarchByType,
	// Token: 0x04000B9F RID: 2975
	[Token(Token = "0x4000B9F")]
	SetCityPeopleAndCarVisible,
	// Token: 0x04000BA0 RID: 2976
	[Token(Token = "0x4000BA0")]
	OnKeyCodeEscape = 1138,
	// Token: 0x04000BA1 RID: 2977
	[Token(Token = "0x4000BA1")]
	WorldCollectPointInView = 1162,
	// Token: 0x04000BA2 RID: 2978
	[Token(Token = "0x4000BA2")]
	WorldCollectPointOutView,
	// Token: 0x04000BA3 RID: 2979
	[Token(Token = "0x4000BA3")]
	LandLockCreate = 1168,
	// Token: 0x04000BA4 RID: 2980
	[Token(Token = "0x4000BA4")]
	LandLockDestroy,
	// Token: 0x04000BA5 RID: 2981
	[Token(Token = "0x4000BA5")]
	MiniMapDataRefresh = 1195,
	// Token: 0x04000BA6 RID: 2982
	[Token(Token = "0x4000BA6")]
	UICreateFakePlaceAllianceBuild = 1208,
	// Token: 0x04000BA7 RID: 2983
	[Token(Token = "0x4000BA7")]
	UIPlaceAllianceBuildChangePos,
	// Token: 0x04000BA8 RID: 2984
	[Token(Token = "0x4000BA8")]
	HideDesertAttackHeadUI = 1216,
	// Token: 0x04000BA9 RID: 2985
	[Token(Token = "0x4000BA9")]
	ChangeShowTroopAttackEffectState = 1224,
	// Token: 0x04000BAA RID: 2986
	[Token(Token = "0x4000BAA")]
	ChangeShowTroopBloodNumState,
	// Token: 0x04000BAB RID: 2987
	[Token(Token = "0x4000BAB")]
	ChangeShowTroopDestroyIconState,
	// Token: 0x04000BAC RID: 2988
	[Token(Token = "0x4000BAC")]
	ChangeShowTroopHeadState,
	// Token: 0x04000BAD RID: 2989
	[Token(Token = "0x4000BAD")]
	ChangeShowTroopNameState,
	// Token: 0x04000BAE RID: 2990
	[Token(Token = "0x4000BAE")]
	ShowAllianceBuildAttackHeadUI = 1246,
	// Token: 0x04000BAF RID: 2991
	[Token(Token = "0x4000BAF")]
	HideAllianceBuildAttackHeadUI,
	// Token: 0x04000BB0 RID: 2992
	[Token(Token = "0x4000BB0")]
	ChangeShowTroopGunAttackEffectState,
	// Token: 0x04000BB1 RID: 2993
	[Token(Token = "0x4000BB1")]
	ChangeShowTroopDamageAttackEffectState,
	// Token: 0x04000BB2 RID: 2994
	[Token(Token = "0x4000BB2")]
	ShowNPCBuildAttackHeadUI = 1251,
	// Token: 0x04000BB3 RID: 2995
	[Token(Token = "0x4000BB3")]
	HideNPCBuildAttackHeadUI,
	// Token: 0x04000BB4 RID: 2996
	[Token(Token = "0x4000BB4")]
	DesertEffectInView = 1270,
	// Token: 0x04000BB5 RID: 2997
	[Token(Token = "0x4000BB5")]
	DesertEffectOutView,
	// Token: 0x04000BB6 RID: 2998
	[Token(Token = "0x4000BB6")]
	DesertMineInView = 1309,
	// Token: 0x04000BB7 RID: 2999
	[Token(Token = "0x4000BB7")]
	DesertMineOutView,
	// Token: 0x04000BB8 RID: 3000
	[Token(Token = "0x4000BB8")]
	ShowSiegeAttack = 1314,
	// Token: 0x04000BB9 RID: 3001
	[Token(Token = "0x4000BB9")]
	HideSiegeAttack,
	// Token: 0x04000BBA RID: 3002
	[Token(Token = "0x4000BBA")]
	ShowActAllianceBuildAttackHeadUI = 1358,
	// Token: 0x04000BBB RID: 3003
	[Token(Token = "0x4000BBB")]
	HideActAllianceBuildAttackHeadUI,
	// Token: 0x04000BBC RID: 3004
	[Token(Token = "0x4000BBC")]
	ShowBattleDamageType = 1363,
	// Token: 0x04000BBD RID: 3005
	[Token(Token = "0x4000BBD")]
	ShowDragonBuildAttackHeadUI = 1366,
	// Token: 0x04000BBE RID: 3006
	[Token(Token = "0x4000BBE")]
	HideDragonBuildAttackHeadUI,
	// Token: 0x04000BBF RID: 3007
	[Token(Token = "0x4000BBF")]
	DragonMapDataRefresh,
	// Token: 0x04000BC0 RID: 3008
	[Token(Token = "0x4000BC0")]
	DragonBuildInView,
	// Token: 0x04000BC1 RID: 3009
	[Token(Token = "0x4000BC1")]
	DragonBuildOutView,
	// Token: 0x04000BC2 RID: 3010
	[Token(Token = "0x4000BC2")]
	DragonSecretShow = 1418,
	// Token: 0x04000BC3 RID: 3011
	[Token(Token = "0x4000BC3")]
	WorldPassOwnerInfoReceived = 1422,
	// Token: 0x04000BC4 RID: 3012
	[Token(Token = "0x4000BC4")]
	WorldPassOwnerInfoChanged,
	// Token: 0x04000BC5 RID: 3013
	[Token(Token = "0x4000BC5")]
	CrossThroneBuildInView = 1435,
	// Token: 0x04000BC6 RID: 3014
	[Token(Token = "0x4000BC6")]
	CrossThroneBuildOutView,
	// Token: 0x04000BC7 RID: 3015
	[Token(Token = "0x4000BC7")]
	ShowCrossThroneAttackHeadUI,
	// Token: 0x04000BC8 RID: 3016
	[Token(Token = "0x4000BC8")]
	HideCrossThroneAttackHeadUI,
	// Token: 0x04000BC9 RID: 3017
	[Token(Token = "0x4000BC9")]
	DesertUpdateLevelInView = 1447,
	// Token: 0x04000BCA RID: 3018
	[Token(Token = "0x4000BCA")]
	DesertUpdateLevelOutView,
	// Token: 0x04000BCB RID: 3019
	[Token(Token = "0x4000BCB")]
	ShowTroopMineDamage,
	// Token: 0x04000BCC RID: 3020
	[Token(Token = "0x4000BCC")]
	GoogleAdsUserEarnedReward = 1453,
	// Token: 0x04000BCD RID: 3021
	[Token(Token = "0x4000BCD")]
	GoogleAdsUserExitReward,
	// Token: 0x04000BCE RID: 3022
	[Token(Token = "0x4000BCE")]
	GoogleAdsUserCreateRewardedAdFail,
	// Token: 0x04000BCF RID: 3023
	[Token(Token = "0x4000BCF")]
	GoogleAdsUserCreateRewardedAdSuccess,
	// Token: 0x04000BD0 RID: 3024
	[Token(Token = "0x4000BD0")]
	GoogleAdsUserClickAd,
	// Token: 0x04000BD1 RID: 3025
	[Token(Token = "0x4000BD1")]
	UnityAdsUserEarnedReward = 1459,
	// Token: 0x04000BD2 RID: 3026
	[Token(Token = "0x4000BD2")]
	UnityAdsUserSkipReward,
	// Token: 0x04000BD3 RID: 3027
	[Token(Token = "0x4000BD3")]
	UnityAdsUserCreateRewardedAdFail,
	// Token: 0x04000BD4 RID: 3028
	[Token(Token = "0x4000BD4")]
	UnityAdsUserCreateRewardedAdSuccess,
	// Token: 0x04000BD5 RID: 3029
	[Token(Token = "0x4000BD5")]
	UnityAdsUserClickAd,
	// Token: 0x04000BD6 RID: 3030
	[Token(Token = "0x4000BD6")]
	OnTroopDragonUpdatePos = 1483,
	// Token: 0x04000BD7 RID: 3031
	[Token(Token = "0x4000BD7")]
	ShowCollectBattleValue = 2028,
	// Token: 0x04000BD8 RID: 3032
	[Token(Token = "0x4000BD8")]
	CollectPointOut,
	// Token: 0x04000BD9 RID: 3033
	[Token(Token = "0x4000BD9")]
	NpcCityInView = 2042,
	// Token: 0x04000BDA RID: 3034
	[Token(Token = "0x4000BDA")]
	NpcCityOutView,
	// Token: 0x04000BDB RID: 3035
	[Token(Token = "0x4000BDB")]
	MonsterLockInView = 2111,
	// Token: 0x04000BDC RID: 3036
	[Token(Token = "0x4000BDC")]
	MonsterLockOutView,
	// Token: 0x04000BDD RID: 3037
	[Token(Token = "0x4000BDD")]
	MonsterLockStateUpdate,
	// Token: 0x04000BDE RID: 3038
	[Token(Token = "0x4000BDE")]
	ShowCityDome = 2333,
	// Token: 0x04000BDF RID: 3039
	[Token(Token = "0x4000BDF")]
	HideCityDome,
	// Token: 0x04000BE0 RID: 3040
	[Token(Token = "0x4000BE0")]
	RefreshCityRoadArr = 2336,
	// Token: 0x04000BE1 RID: 3041
	[Token(Token = "0x4000BE1")]
	DeleteCityRoadArr,
	// Token: 0x04000BE2 RID: 3042
	[Token(Token = "0x4000BE2")]
	SetBuildCanDoAnim = 2342,
	// Token: 0x04000BE3 RID: 3043
	[Token(Token = "0x4000BE3")]
	SetBuildNoDoAnim,
	// Token: 0x04000BE4 RID: 3044
	[Token(Token = "0x4000BE4")]
	OnTouchPinchStart,
	// Token: 0x04000BE5 RID: 3045
	[Token(Token = "0x4000BE5")]
	OnTouchPinchEnd,
	// Token: 0x04000BE6 RID: 3046
	[Token(Token = "0x4000BE6")]
	OnEditorTouchPinch,
	// Token: 0x04000BE7 RID: 3047
	[Token(Token = "0x4000BE7")]
	SetBuildCanShowLevel,
	// Token: 0x04000BE8 RID: 3048
	[Token(Token = "0x4000BE8")]
	SetBuildNoShowLevel,
	// Token: 0x04000BE9 RID: 3049
	[Token(Token = "0x4000BE9")]
	OnInputLongTapStart,
	// Token: 0x04000BEA RID: 3050
	[Token(Token = "0x4000BEA")]
	OnInputLongTapEnd,
	// Token: 0x04000BEB RID: 3051
	[Token(Token = "0x4000BEB")]
	UserCitySkinUpdate = 2361,
	// Token: 0x04000BEC RID: 3052
	[Token(Token = "0x4000BEC")]
	ChangeCameraInitZoom = 1253,
	// Token: 0x04000BED RID: 3053
	[Token(Token = "0x4000BED")]
	CheckShowGovPos = 1304,
	// Token: 0x04000BEE RID: 3054
	[Token(Token = "0x4000BEE")]
	ShowThroneArmyHeadUI,
	// Token: 0x04000BEF RID: 3055
	[Token(Token = "0x4000BEF")]
	HideThroneArmyHeadUI,
	// Token: 0x04000BF0 RID: 3056
	[Token(Token = "0x4000BF0")]
	ShowAllianceBossBattleValue = 1352,
	// Token: 0x04000BF1 RID: 3057
	[Token(Token = "0x4000BF1")]
	RefreshBauble = 1400,
	// Token: 0x04000BF2 RID: 3058
	[Token(Token = "0x4000BF2")]
	RemoveBauble = 1402,
	// Token: 0x04000BF3 RID: 3059
	[Token(Token = "0x4000BF3")]
	BaubleInView,
	// Token: 0x04000BF4 RID: 3060
	[Token(Token = "0x4000BF4")]
	BaubleOutView,
	// Token: 0x04000BF5 RID: 3061
	[Token(Token = "0x4000BF5")]
	RefreshBuildBreak = 1284,
	// Token: 0x04000BF6 RID: 3062
	[Token(Token = "0x4000BF6")]
	BridgeLevelCarFallIntoWater = 2496,
	// Token: 0x04000BF7 RID: 3063
	[Token(Token = "0x4000BF7")]
	BridgeLevelElementFallIntoWater,
	// Token: 0x04000BF8 RID: 3064
	[Token(Token = "0x4000BF8")]
	BridgeLevelExitFinish,
	// Token: 0x04000BF9 RID: 3065
	[Token(Token = "0x4000BF9")]
	BridgeLevelChangeStageFinish,
	// Token: 0x04000BFA RID: 3066
	[Token(Token = "0x4000BFA")]
	BridgeLevelVictory,
	// Token: 0x04000BFB RID: 3067
	[Token(Token = "0x4000BFB")]
	BridgeLevelFailed,
	// Token: 0x04000BFC RID: 3068
	[Token(Token = "0x4000BFC")]
	BridgeLevelUpdateTools,
	// Token: 0x04000BFD RID: 3069
	[Token(Token = "0x4000BFD")]
	BridgeLevelChangeStage,
	// Token: 0x04000BFE RID: 3070
	[Token(Token = "0x4000BFE")]
	BridgeLevelPickToolBack,
	// Token: 0x04000BFF RID: 3071
	[Token(Token = "0x4000BFF")]
	BridgeLevelEdit,
	// Token: 0x04000C00 RID: 3072
	[Token(Token = "0x4000C00")]
	BridgeLevelPlay,
	// Token: 0x04000C01 RID: 3073
	[Token(Token = "0x4000C01")]
	BridgeLevelPause,
	// Token: 0x04000C02 RID: 3074
	[Token(Token = "0x4000C02")]
	BridgeLevelEnter,
	// Token: 0x04000C03 RID: 3075
	[Token(Token = "0x4000C03")]
	BridgeLevelExit,
	// Token: 0x04000C04 RID: 3076
	[Token(Token = "0x4000C04")]
	BridgeLevelPlaceElement,
	// Token: 0x04000C05 RID: 3077
	[Token(Token = "0x4000C05")]
	BridgeLevelPickElement,
	// Token: 0x04000C06 RID: 3078
	[Token(Token = "0x4000C06")]
	BridgeLevelBreak,
	// Token: 0x04000C07 RID: 3079
	[Token(Token = "0x4000C07")]
	BridgeLevelEnterZone,
	// Token: 0x04000C08 RID: 3080
	[Token(Token = "0x4000C08")]
	BridgeLevelStartDragElement,
	// Token: 0x04000C09 RID: 3081
	[Token(Token = "0x4000C09")]
	BridgeLevelDragElement,
	// Token: 0x04000C0A RID: 3082
	[Token(Token = "0x4000C0A")]
	BridgeLevelEndDragElement,
	// Token: 0x04000C0B RID: 3083
	[Token(Token = "0x4000C0B")]
	RefreshBuildDataArr,
	// Token: 0x04000C0C RID: 3084
	[Token(Token = "0x4000C0C")]
	DeleteBuildDataArr,
	// Token: 0x04000C0D RID: 3085
	[Token(Token = "0x4000C0D")]
	PaintEnter = 2627,
	// Token: 0x04000C0E RID: 3086
	[Token(Token = "0x4000C0E")]
	PaintExit,
	// Token: 0x04000C0F RID: 3087
	[Token(Token = "0x4000C0F")]
	PaintLoading,
	// Token: 0x04000C10 RID: 3088
	[Token(Token = "0x4000C10")]
	PaintEdit,
	// Token: 0x04000C11 RID: 3089
	[Token(Token = "0x4000C11")]
	PaintPlay,
	// Token: 0x04000C12 RID: 3090
	[Token(Token = "0x4000C12")]
	PaintVictory,
	// Token: 0x04000C13 RID: 3091
	[Token(Token = "0x4000C13")]
	PaintDefeat,
	// Token: 0x04000C14 RID: 3092
	[Token(Token = "0x4000C14")]
	ShootEnter = 2700,
	// Token: 0x04000C15 RID: 3093
	[Token(Token = "0x4000C15")]
	ShootExit,
	// Token: 0x04000C16 RID: 3094
	[Token(Token = "0x4000C16")]
	ShootStart,
	// Token: 0x04000C17 RID: 3095
	[Token(Token = "0x4000C17")]
	ShootPause,
	// Token: 0x04000C18 RID: 3096
	[Token(Token = "0x4000C18")]
	ShootResume,
	// Token: 0x04000C19 RID: 3097
	[Token(Token = "0x4000C19")]
	ShootDie,
	// Token: 0x04000C1A RID: 3098
	[Token(Token = "0x4000C1A")]
	ShootVictory,
	// Token: 0x04000C1B RID: 3099
	[Token(Token = "0x4000C1B")]
	ShootCollectTreasure,
	// Token: 0x04000C1C RID: 3100
	[Token(Token = "0x4000C1C")]
	ShootVictoryCollectEnough,
	// Token: 0x04000C1D RID: 3101
	[Token(Token = "0x4000C1D")]
	QualityChange = 2644,
	// Token: 0x04000C1E RID: 3102
	[Token(Token = "0x4000C1E")]
	Btn_LongPress = 5001,
	// Token: 0x04000C1F RID: 3103
	[Token(Token = "0x4000C1F")]
	SDK_PermissionRecv = 6046,
	// Token: 0x04000C20 RID: 3104
	[Token(Token = "0x4000C20")]
	SU_TimeOfDayChange = 6060,
	// Token: 0x04000C21 RID: 3105
	[Token(Token = "0x4000C21")]
	OnCameraEnterMoveTo = 8001,
	// Token: 0x04000C22 RID: 3106
	[Token(Token = "0x4000C22")]
	OnCameraExitMoveTo,
	// Token: 0x04000C23 RID: 3107
	[Token(Token = "0x4000C23")]
	OnCameraEnterIdle,
	// Token: 0x04000C24 RID: 3108
	[Token(Token = "0x4000C24")]
	OnCameraExitIdle,
	// Token: 0x04000C25 RID: 3109
	[Token(Token = "0x4000C25")]
	OnCameraEnterFollow,
	// Token: 0x04000C26 RID: 3110
	[Token(Token = "0x4000C26")]
	OnCameraExitFollow,
	// Token: 0x04000C27 RID: 3111
	[Token(Token = "0x4000C27")]
	HideZendeskWindow = 9001,
	// Token: 0x04000C28 RID: 3112
	[Token(Token = "0x4000C28")]
	OnGameCenterOpenSuccess = 271111,
	// Token: 0x04000C29 RID: 3113
	[Token(Token = "0x4000C29")]
	OnGameCenterConnectSuccess,
	// Token: 0x04000C2A RID: 3114
	[Token(Token = "0x4000C2A")]
	OnGameCenterOpenError,
	// Token: 0x04000C2B RID: 3115
	[Token(Token = "0x4000C2B")]
	OnGameCenterConnectError,
	// Token: 0x04000C2C RID: 3116
	[Token(Token = "0x4000C2C")]
	OnGooglePlaySignInSuccess = 271116,
	// Token: 0x04000C2D RID: 3117
	[Token(Token = "0x4000C2D")]
	AnimatorStateEnter = 280001,
	// Token: 0x04000C2E RID: 3118
	[Token(Token = "0x4000C2E")]
	ClickGiftInfo = 99999999
}
