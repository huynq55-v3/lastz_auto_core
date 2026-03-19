using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace SDK
{
	// Token: 0x02000CF4 RID: 3316
	[Token(Token = "0x2000CF4")]
	public class TikTokCheckoutEvent : TikTokContentsEvent
	{
		// Token: 0x06007C61 RID: 31841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C61")]
		[Address(RVA = "0x319C018", Offset = "0x319C018", VA = "0x319C018")]
		public TikTokCheckoutEvent(string eventName, Dictionary<string, object> properties, string eventId)
		{
		}

		// Token: 0x06007C62 RID: 31842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C62")]
		[Address(RVA = "0x319C01C", Offset = "0x319C01C", VA = "0x319C01C")]
		public TikTokCheckoutEvent(string eventID)
		{
		}
	}
}
