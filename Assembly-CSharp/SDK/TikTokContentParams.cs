using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace SDK
{
	// Token: 0x02000CF0 RID: 3312
	[Token(Token = "0x2000CF0")]
	public class TikTokContentParams
	{
		// Token: 0x06007C54 RID: 31828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007C54")]
		[Address(RVA = "0x319BA0C", Offset = "0x319BA0C", VA = "0x319BA0C")]
		public Dictionary<string, object> DictionaryValue()
		{
			return null;
		}

		// Token: 0x06007C55 RID: 31829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C55")]
		[Address(RVA = "0x319BBF8", Offset = "0x319BBF8", VA = "0x319BBF8")]
		public TikTokContentParams()
		{
		}

		// Token: 0x0400385C RID: 14428
		[Token(Token = "0x400385C")]
		[FieldOffset(Offset = "0x10")]
		public double price;

		// Token: 0x0400385D RID: 14429
		[Token(Token = "0x400385D")]
		[FieldOffset(Offset = "0x18")]
		public long quantity;

		// Token: 0x0400385E RID: 14430
		[Token(Token = "0x400385E")]
		[FieldOffset(Offset = "0x20")]
		public string contentId;

		// Token: 0x0400385F RID: 14431
		[Token(Token = "0x400385F")]
		[FieldOffset(Offset = "0x28")]
		public string contentCategory;

		// Token: 0x04003860 RID: 14432
		[Token(Token = "0x4003860")]
		[FieldOffset(Offset = "0x30")]
		public string contentName;

		// Token: 0x04003861 RID: 14433
		[Token(Token = "0x4003861")]
		[FieldOffset(Offset = "0x38")]
		public string brand;
	}
}
