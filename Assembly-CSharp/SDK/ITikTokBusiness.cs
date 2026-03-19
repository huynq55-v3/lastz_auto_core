using System;
using Il2CppDummyDll;

namespace SDK
{
	// Token: 0x02000CE6 RID: 3302
	[Token(Token = "0x2000CE6")]
	public interface ITikTokBusiness
	{
		// Token: 0x06007C24 RID: 31780
		[Token(Token = "0x6007C24")]
		void InitializeSdk(TikTokConfig config);

		// Token: 0x06007C25 RID: 31781
		[Token(Token = "0x6007C25")]
		void InitializeSdk(TikTokConfig config, Action<bool, int, string> completionHandler);

		// Token: 0x06007C26 RID: 31782
		[Token(Token = "0x6007C26")]
		void FetchDeferredDeeplink(Action<string, int, string> completionHandler);

		// Token: 0x06007C27 RID: 31783
		[Token(Token = "0x6007C27")]
		void Identify(string externalId, string externalUserName, string phoneNumber, string email);

		// Token: 0x06007C28 RID: 31784
		[Token(Token = "0x6007C28")]
		void Logout();

		// Token: 0x06007C29 RID: 31785
		[Token(Token = "0x6007C29")]
		void TrackTTEvent(TikTokBaseEvent baseEvent);

		// Token: 0x06007C2A RID: 31786
		[Token(Token = "0x6007C2A")]
		void StartTrack();

		// Token: 0x06007C2B RID: 31787
		[Token(Token = "0x6007C2B")]
		void IOS_requestTrackingAuthorization(Action<ulong> completionHandler);

		// Token: 0x06007C2C RID: 31788
		[Token(Token = "0x6007C2C")]
		string IOS_GetAdvertisingIdentifier();
	}
}
