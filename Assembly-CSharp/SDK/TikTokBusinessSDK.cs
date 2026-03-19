using System;
using Il2CppDummyDll;

namespace SDK
{
	// Token: 0x02000CEA RID: 3306
	[Token(Token = "0x2000CEA")]
	public static class TikTokBusinessSDK
	{
		// Token: 0x06007C34 RID: 31796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C34")]
		[Address(RVA = "0x3199924", Offset = "0x3199924", VA = "0x3199924")]
		public static void InitializeSdk(TikTokConfig config)
		{
		}

		// Token: 0x06007C35 RID: 31797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C35")]
		[Address(RVA = "0x3199A18", Offset = "0x3199A18", VA = "0x3199A18")]
		public static void InitializeSdk(TikTokConfig config, Action<bool, int, string> completionHandler)
		{
		}

		// Token: 0x06007C36 RID: 31798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C36")]
		[Address(RVA = "0x3199BB0", Offset = "0x3199BB0", VA = "0x3199BB0")]
		public static void FetchDeferredDeeplink(Action<string, int, string> completionHandler)
		{
		}

		// Token: 0x06007C37 RID: 31799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C37")]
		[Address(RVA = "0x3199CA8", Offset = "0x3199CA8", VA = "0x3199CA8")]
		public static void Identify(string externalId, string externalUserName, string phoneNumber, string email)
		{
		}

		// Token: 0x06007C38 RID: 31800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C38")]
		[Address(RVA = "0x319A07C", Offset = "0x319A07C", VA = "0x319A07C")]
		public static void Logout()
		{
		}

		// Token: 0x06007C39 RID: 31801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C39")]
		[Address(RVA = "0x319A164", Offset = "0x319A164", VA = "0x319A164")]
		public static void TrackTTEvent(TikTokBaseEvent baseEvent)
		{
		}

		// Token: 0x06007C3A RID: 31802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C3A")]
		[Address(RVA = "0x319A25C", Offset = "0x319A25C", VA = "0x319A25C")]
		public static void StartTrack()
		{
		}

		// Token: 0x06007C3B RID: 31803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C3B")]
		[Address(RVA = "0x319A344", Offset = "0x319A344", VA = "0x319A344")]
		public static void IOS_requestTrackingAuthorization(Action<ulong> completionHandler)
		{
		}

		// Token: 0x06007C3C RID: 31804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007C3C")]
		[Address(RVA = "0x319A434", Offset = "0x319A434", VA = "0x319A434")]
		public static string IOS_GetAdvertisingIdentifier()
		{
			return null;
		}

		// Token: 0x06007C3D RID: 31805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C3D")]
		[Address(RVA = "0x319A51C", Offset = "0x319A51C", VA = "0x319A51C")]
		public static void TikTokInit(string iosPackageName, string iosID, string androidPackageName, string androidID, bool disableSKAd)
		{
		}

		// Token: 0x06007C3E RID: 31806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C3E")]
		[Address(RVA = "0x319A784", Offset = "0x319A784", VA = "0x319A784")]
		public static void TikTokTrackEvent(string eventName, string eventParams)
		{
		}

		// Token: 0x040037F8 RID: 14328
		[Token(Token = "0x40037F8")]
		[FieldOffset(Offset = "0x0")]
		public static string TikTokUnitySDKVersion;
	}
}
