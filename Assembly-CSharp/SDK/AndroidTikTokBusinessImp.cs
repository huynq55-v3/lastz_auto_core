using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace SDK
{
	// Token: 0x02000CE3 RID: 3299
	[Token(Token = "0x2000CE3")]
	public class AndroidTikTokBusinessImp : ITikTokBusiness
	{
		// Token: 0x06007BF1 RID: 31729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BF1")]
		[Address(RVA = "0x3196C7C", Offset = "0x3196C7C", VA = "0x3196C7C", Slot = "5")]
		public void InitializeSdk(TikTokConfig config, Action<bool, int, string> completionHandler)
		{
		}

		// Token: 0x06007BF2 RID: 31730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BF2")]
		[Address(RVA = "0x3196C80", Offset = "0x3196C80", VA = "0x3196C80", Slot = "4")]
		public void InitializeSdk(TikTokConfig config)
		{
		}

		// Token: 0x06007BF3 RID: 31731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BF3")]
		[Address(RVA = "0x3196C84", Offset = "0x3196C84", VA = "0x3196C84")]
		private static void initTikTokBusinessSdk()
		{
		}

		// Token: 0x06007BF4 RID: 31732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BF4")]
		[Address(RVA = "0x3196C88", Offset = "0x3196C88", VA = "0x3196C88", Slot = "6")]
		public void FetchDeferredDeeplink(Action<string, int, string> completionHandler)
		{
		}

		// Token: 0x06007BF5 RID: 31733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BF5")]
		[Address(RVA = "0x3196C8C", Offset = "0x3196C8C", VA = "0x3196C8C", Slot = "7")]
		public void Identify(string externalId, string externalUserName, string phoneNumber, string email)
		{
		}

		// Token: 0x06007BF6 RID: 31734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BF6")]
		[Address(RVA = "0x3196C90", Offset = "0x3196C90", VA = "0x3196C90", Slot = "8")]
		public void Logout()
		{
		}

		// Token: 0x06007BF7 RID: 31735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BF7")]
		[Address(RVA = "0x3196C94", Offset = "0x3196C94", VA = "0x3196C94", Slot = "9")]
		public void TrackTTEvent(TikTokBaseEvent baseEvent)
		{
		}

		// Token: 0x06007BF8 RID: 31736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BF8")]
		[Address(RVA = "0x3196C98", Offset = "0x3196C98", VA = "0x3196C98", Slot = "10")]
		public void StartTrack()
		{
		}

		// Token: 0x06007BF9 RID: 31737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BF9")]
		[Address(RVA = "0x3196C9C", Offset = "0x3196C9C", VA = "0x3196C9C", Slot = "11")]
		public void IOS_requestTrackingAuthorization(Action<ulong> completionHandler)
		{
		}

		// Token: 0x06007BFA RID: 31738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BFA")]
		[Address(RVA = "0x3196CA0", Offset = "0x3196CA0", VA = "0x3196CA0", Slot = "12")]
		public string IOS_GetAdvertisingIdentifier()
		{
			return null;
		}

		// Token: 0x06007BFB RID: 31739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BFB")]
		[Address(RVA = "0x3196CE0", Offset = "0x3196CE0", VA = "0x3196CE0")]
		public static AndroidJavaObject GetGameActivity()
		{
			return null;
		}

		// Token: 0x06007BFC RID: 31740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BFC")]
		[Address(RVA = "0x3196D84", Offset = "0x3196D84", VA = "0x3196D84")]
		private static string getAppId(Dictionary<string, string> configParams)
		{
			return null;
		}

		// Token: 0x06007BFD RID: 31741 RVA: 0x000546C0 File Offset: 0x000528C0
		[Token(Token = "0x6007BFD")]
		[Address(RVA = "0x3196DC4", Offset = "0x3196DC4", VA = "0x3196DC4")]
		private static bool disableLaunchTrack(Dictionary<string, string> configParams)
		{
			return default(bool);
		}

		// Token: 0x06007BFE RID: 31742 RVA: 0x000546D8 File Offset: 0x000528D8
		[Token(Token = "0x6007BFE")]
		[Address(RVA = "0x3196DCC", Offset = "0x3196DCC", VA = "0x3196DCC")]
		private static bool disableAutoTrack(Dictionary<string, string> configParams)
		{
			return default(bool);
		}

		// Token: 0x06007BFF RID: 31743 RVA: 0x000546F0 File Offset: 0x000528F0
		[Token(Token = "0x6007BFF")]
		[Address(RVA = "0x3196DD4", Offset = "0x3196DD4", VA = "0x3196DD4")]
		private static bool disableTrack(Dictionary<string, string> configParams)
		{
			return default(bool);
		}

		// Token: 0x06007C00 RID: 31744 RVA: 0x00054708 File Offset: 0x00052908
		[Token(Token = "0x6007C00")]
		[Address(RVA = "0x3196DDC", Offset = "0x3196DDC", VA = "0x3196DDC")]
		private static bool disableRetentionTrack(Dictionary<string, string> configParams)
		{
			return default(bool);
		}

		// Token: 0x06007C01 RID: 31745 RVA: 0x00054720 File Offset: 0x00052920
		[Token(Token = "0x6007C01")]
		[Address(RVA = "0x3196DE4", Offset = "0x3196DE4", VA = "0x3196DE4")]
		private static bool disablePayTrack(Dictionary<string, string> configParams)
		{
			return default(bool);
		}

		// Token: 0x06007C02 RID: 31746 RVA: 0x00054738 File Offset: 0x00052938
		[Token(Token = "0x6007C02")]
		[Address(RVA = "0x3196DEC", Offset = "0x3196DEC", VA = "0x3196DEC")]
		private static bool openDebugMode(Dictionary<string, string> configParams)
		{
			return default(bool);
		}

		// Token: 0x06007C03 RID: 31747 RVA: 0x00054750 File Offset: 0x00052950
		[Token(Token = "0x6007C03")]
		[Address(RVA = "0x3196DF4", Offset = "0x3196DF4", VA = "0x3196DF4")]
		private static bool OpenLimitedDataUse(Dictionary<string, string> configParams)
		{
			return default(bool);
		}

		// Token: 0x06007C04 RID: 31748 RVA: 0x00054768 File Offset: 0x00052968
		[Token(Token = "0x6007C04")]
		[Address(RVA = "0x3196DFC", Offset = "0x3196DFC", VA = "0x3196DFC")]
		private static bool disableEDPTrack(Dictionary<string, string> configParams)
		{
			return default(bool);
		}

		// Token: 0x06007C05 RID: 31749 RVA: 0x00054780 File Offset: 0x00052980
		[Token(Token = "0x6007C05")]
		[Address(RVA = "0x3196E04", Offset = "0x3196E04", VA = "0x3196E04")]
		private static bool isLowPerformanceDevice(Dictionary<string, string> configParams)
		{
			return default(bool);
		}

		// Token: 0x06007C06 RID: 31750 RVA: 0x00054798 File Offset: 0x00052998
		[Token(Token = "0x6007C06")]
		[Address(RVA = "0x3196E0C", Offset = "0x3196E0C", VA = "0x3196E0C")]
		private static bool disableAppAdTrack(Dictionary<string, string> configParams)
		{
			return default(bool);
		}

		// Token: 0x06007C07 RID: 31751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007C07")]
		[Address(RVA = "0x3196E14", Offset = "0x3196E14", VA = "0x3196E14")]
		private static string getLogLevel(Dictionary<string, string> configParams)
		{
			return null;
		}

		// Token: 0x06007C08 RID: 31752 RVA: 0x000547B0 File Offset: 0x000529B0
		[Token(Token = "0x6007C08")]
		[Address(RVA = "0x3196E74", Offset = "0x3196E74", VA = "0x3196E74")]
		private static bool disableInstallTrack(Dictionary<string, string> configParams)
		{
			return default(bool);
		}

		// Token: 0x06007C09 RID: 31753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007C09")]
		[Address(RVA = "0x3196E7C", Offset = "0x3196E7C", VA = "0x3196E7C")]
		private static string getAcceceToken(Dictionary<string, string> configParams)
		{
			return null;
		}

		// Token: 0x06007C0A RID: 31754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007C0A")]
		[Address(RVA = "0x3196EBC", Offset = "0x3196EBC", VA = "0x3196EBC")]
		private static string getTTAppId(Dictionary<string, string> configParams)
		{
			return null;
		}

		// Token: 0x06007C0B RID: 31755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C0B")]
		[Address(RVA = "0x3196EFC", Offset = "0x3196EFC", VA = "0x3196EFC")]
		public AndroidTikTokBusinessImp()
		{
		}

		// Token: 0x040037EC RID: 14316
		[Token(Token = "0x40037EC")]
		[FieldOffset(Offset = "0x0")]
		private static AndroidJavaObject tikTokBusinessSdk;
	}
}
