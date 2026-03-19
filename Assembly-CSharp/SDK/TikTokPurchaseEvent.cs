using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace SDK
{
	// Token: 0x02000CF5 RID: 3317
	[Token(Token = "0x2000CF5")]
	public class TikTokPurchaseEvent : TikTokContentsEvent
	{
		// Token: 0x06007C63 RID: 31843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C63")]
		[Address(RVA = "0x319C078", Offset = "0x319C078", VA = "0x319C078")]
		public TikTokPurchaseEvent(string eventName, Dictionary<string, object> properties, string eventId)
		{
		}

		// Token: 0x06007C64 RID: 31844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C64")]
		[Address(RVA = "0x319C07C", Offset = "0x319C07C", VA = "0x319C07C")]
		public TikTokPurchaseEvent(string eventID)
		{
		}
	}
}
