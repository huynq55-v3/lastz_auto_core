using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace SDK
{
	// Token: 0x02000CF2 RID: 3314
	[Token(Token = "0x2000CF2")]
	public class TikTokAddToCartEvent : TikTokContentsEvent
	{
		// Token: 0x06007C5D RID: 31837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C5D")]
		[Address(RVA = "0x319BF58", Offset = "0x319BF58", VA = "0x319BF58")]
		public TikTokAddToCartEvent(string eventName, Dictionary<string, object> properties, string eventId)
		{
		}

		// Token: 0x06007C5E RID: 31838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C5E")]
		[Address(RVA = "0x319BF5C", Offset = "0x319BF5C", VA = "0x319BF5C")]
		public TikTokAddToCartEvent(string eventID)
		{
		}
	}
}
