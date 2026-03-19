using System;
using Il2CppDummyDll;
using Sfs2X.Entities.Data;

namespace UnityGameFramework.SDK
{
	// Token: 0x020004AD RID: 1197
	[Token(Token = "0x20004AD")]
	public class AnalyticsEvent
	{
		// Token: 0x0600236A RID: 9066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600236A")]
		[Address(RVA = "0x2A02B48", Offset = "0x2A02B48", VA = "0x2A02B48")]
		public static void TutorialComplete(string data, int _type)
		{
		}

		// Token: 0x0600236B RID: 9067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600236B")]
		[Address(RVA = "0x2A02C94", Offset = "0x2A02C94", VA = "0x2A02C94")]
		public static void FirstOpenAppsflyer()
		{
		}

		// Token: 0x0600236C RID: 9068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600236C")]
		[Address(RVA = "0x2A02E6C", Offset = "0x2A02E6C", VA = "0x2A02E6C")]
		public static void Login(ISFSObject msg, string userId, string userName)
		{
		}

		// Token: 0x0600236D RID: 9069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600236D")]
		[Address(RVA = "0x2A031C4", Offset = "0x2A031C4", VA = "0x2A031C4")]
		public static void TriggerEventPurchase(string cost, string key, string orderId, string uid)
		{
		}

		// Token: 0x0600236E RID: 9070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600236E")]
		[Address(RVA = "0x2A03370", Offset = "0x2A03370", VA = "0x2A03370")]
		public static void LevelUp(string lv)
		{
		}

		// Token: 0x0600236F RID: 9071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600236F")]
		[Address(RVA = "0x2A034DC", Offset = "0x2A034DC", VA = "0x2A034DC")]
		public static void ClickBuyIn60m(string id, string name)
		{
		}

		// Token: 0x06002370 RID: 9072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002370")]
		[Address(RVA = "0x2A03688", Offset = "0x2A03688", VA = "0x2A03688")]
		public static void SpeedUp(int user_level, int castle_level, int type, int spend)
		{
		}

		// Token: 0x06002371 RID: 9073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002371")]
		[Address(RVA = "0x2A038A4", Offset = "0x2A038A4", VA = "0x2A038A4")]
		public static void GiftPackage(string entracnce, string name, int id, int user_castle, int user_level)
		{
		}

		// Token: 0x06002372 RID: 9074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002372")]
		[Address(RVA = "0x2A03AE4", Offset = "0x2A03AE4", VA = "0x2A03AE4")]
		public static void AllianceHonorExchange(string name, string id, int user_castle, int user_level, int rank)
		{
		}

		// Token: 0x06002373 RID: 9075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002373")]
		[Address(RVA = "0x2A03D24", Offset = "0x2A03D24", VA = "0x2A03D24")]
		public static void AllianceScoreUsage(string name, string id, int rank)
		{
		}

		// Token: 0x06002374 RID: 9076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002374")]
		[Address(RVA = "0x2A03EC4", Offset = "0x2A03EC4", VA = "0x2A03EC4")]
		public static void AllianceChat(string eventName)
		{
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002375")]
		[Address(RVA = "0x2A04170", Offset = "0x2A04170", VA = "0x2A04170")]
		public static void EventDone(string eventName, string data)
		{
		}

		// Token: 0x06002376 RID: 9078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002376")]
		[Address(RVA = "0x2A031C0", Offset = "0x2A031C0", VA = "0x2A031C0")]
		public static void SendAdjustTrack(string track, string eventValue = "")
		{
		}

		// Token: 0x06002377 RID: 9079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002377")]
		[Address(RVA = "0x2A042DC", Offset = "0x2A042DC", VA = "0x2A042DC")]
		public AnalyticsEvent()
		{
		}

		// Token: 0x040020C5 RID: 8389
		[Token(Token = "0x40020C5")]
		public const string first_open_new = "first open new";

		// Token: 0x040020C6 RID: 8390
		[Token(Token = "0x40020C6")]
		public const string app_launch = "app_launch";

		// Token: 0x040020C7 RID: 8391
		[Token(Token = "0x40020C7")]
		public const string trackAppLaunch = "trackAppLaunch";

		// Token: 0x040020C8 RID: 8392
		[Token(Token = "0x40020C8")]
		public const string EventPurchase = "purchase";

		// Token: 0x040020C9 RID: 8393
		[Token(Token = "0x40020C9")]
		public const string EventLevelUp = "LevelUp";

		// Token: 0x040020CA RID: 8394
		[Token(Token = "0x40020CA")]
		public const string click_buy_car_in_60m = "click_buy_car_in_60m";

		// Token: 0x040020CB RID: 8395
		[Token(Token = "0x40020CB")]
		public const string click_gifts = "click_gifts";

		// Token: 0x040020CC RID: 8396
		[Token(Token = "0x40020CC")]
		public const string click_gifts_in_30m = "click_gifts_in_30m";

		// Token: 0x040020CD RID: 8397
		[Token(Token = "0x40020CD")]
		public const string setCustomerUserID = "setCustomerUserID";

		// Token: 0x040020CE RID: 8398
		[Token(Token = "0x40020CE")]
		public const string tutorialComplete = "tutorialComplete";

		// Token: 0x040020CF RID: 8399
		[Token(Token = "0x40020CF")]
		public const string triggerEventLoginComplete = "triggerEventLoginComplete";

		// Token: 0x040020D0 RID: 8400
		[Token(Token = "0x40020D0")]
		public const string EventCompletedRegistration = "CompletedRegistration";

		// Token: 0x040020D1 RID: 8401
		[Token(Token = "0x40020D1")]
		public const string fbEventCompletedTutorial = "fbEventCompletedTutorial";

		// Token: 0x040020D2 RID: 8402
		[Token(Token = "0x40020D2")]
		public const string EventSpeedUp = "SpeedUp";

		// Token: 0x040020D3 RID: 8403
		[Token(Token = "0x40020D3")]
		public const string EventGiftPackage = "GiftPackage";

		// Token: 0x040020D4 RID: 8404
		[Token(Token = "0x40020D4")]
		public const string EventPurchaseItem = "Purchase_Item";

		// Token: 0x040020D5 RID: 8405
		[Token(Token = "0x40020D5")]
		public const string EventFBEntrance = "FacebookEntrance";

		// Token: 0x040020D6 RID: 8406
		[Token(Token = "0x40020D6")]
		public const string EventHireWorker = "HireWorker";

		// Token: 0x040020D7 RID: 8407
		[Token(Token = "0x40020D7")]
		public const string EventAllianceHonorExchange = "AllianceHonorExchange";

		// Token: 0x040020D8 RID: 8408
		[Token(Token = "0x40020D8")]
		public const string EventAllianceScoreUsage = "AllianceScoreUsage";

		// Token: 0x040020D9 RID: 8409
		[Token(Token = "0x40020D9")]
		public const string EventAllianceTalkMore = "alliance_talk_more";

		// Token: 0x040020DA RID: 8410
		[Token(Token = "0x40020DA")]
		public const string FBEventDone = "EventDone";

		// Token: 0x040020DB RID: 8411
		[Token(Token = "0x40020DB")]
		public const string battle_base = "battle_base";

		// Token: 0x040020DC RID: 8412
		[Token(Token = "0x40020DC")]
		public const string battle_resource = "battle_resource";

		// Token: 0x040020DD RID: 8413
		[Token(Token = "0x40020DD")]
		public const string battle_rein = "battle_rein";

		// Token: 0x040020DE RID: 8414
		[Token(Token = "0x40020DE")]
		public const string battle_scout = "battle_scout";

		// Token: 0x040020DF RID: 8415
		[Token(Token = "0x40020DF")]
		public const string social_chat_country = "social_chat_country";

		// Token: 0x040020E0 RID: 8416
		[Token(Token = "0x40020E0")]
		public const string social_chat_alliance = "social_chat_alliance";

		// Token: 0x040020E1 RID: 8417
		[Token(Token = "0x40020E1")]
		public const string social_send_gift = "social_send_gift";

		// Token: 0x040020E2 RID: 8418
		[Token(Token = "0x40020E2")]
		[FieldOffset(Offset = "0x0")]
		private static string preLv;
	}
}
