using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace SDK
{
	// Token: 0x02000CE9 RID: 3305
	[Token(Token = "0x2000CE9")]
	public class TikTokBaseEvent
	{
		// Token: 0x06007C31 RID: 31793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C31")]
		[Address(RVA = "0x3199410", Offset = "0x3199410", VA = "0x3199410")]
		public TikTokBaseEvent(string eventName, Dictionary<string, object> properties, string eventId)
		{
		}

		// Token: 0x06007C32 RID: 31794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C32")]
		[Address(RVA = "0x319967C", Offset = "0x319967C", VA = "0x319967C")]
		public void AddProperty(string key, object value)
		{
		}

		// Token: 0x06007C33 RID: 31795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007C33")]
		[Address(RVA = "0x319991C", Offset = "0x319991C", VA = "0x319991C")]
		public Dictionary<string, string> getEventParams()
		{
			return null;
		}

		// Token: 0x040037F7 RID: 14327
		[Token(Token = "0x40037F7")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, string> EventParams;
	}
}
