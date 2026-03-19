using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace SDK
{
	// Token: 0x02000CF3 RID: 3315
	[Token(Token = "0x2000CF3")]
	public class TikTokAddToWishlistEvent : TikTokContentsEvent
	{
		// Token: 0x06007C5F RID: 31839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C5F")]
		[Address(RVA = "0x319BFB8", Offset = "0x319BFB8", VA = "0x319BFB8")]
		public TikTokAddToWishlistEvent(string eventName, Dictionary<string, object> properties, string eventId)
		{
		}

		// Token: 0x06007C60 RID: 31840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C60")]
		[Address(RVA = "0x319BFBC", Offset = "0x319BFBC", VA = "0x319BFBC")]
		public TikTokAddToWishlistEvent(string eventID)
		{
		}
	}
}
