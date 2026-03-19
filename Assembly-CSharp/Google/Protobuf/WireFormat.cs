using System;
using Il2CppDummyDll;

namespace Google.Protobuf
{
	// Token: 0x02000B2F RID: 2863
	[Token(Token = "0x2000B2F")]
	public static class WireFormat
	{
		// Token: 0x06006D2A RID: 27946 RVA: 0x0004EC18 File Offset: 0x0004CE18
		[Token(Token = "0x6006D2A")]
		[Address(RVA = "0x36F35B0", Offset = "0x36F35B0", VA = "0x36F35B0")]
		public static WireFormat.WireType GetTagWireType(uint tag)
		{
			return WireFormat.WireType.Varint;
		}

		// Token: 0x06006D2B RID: 27947 RVA: 0x0004EC30 File Offset: 0x0004CE30
		[Token(Token = "0x6006D2B")]
		[Address(RVA = "0x36D7A74", Offset = "0x36D7A74", VA = "0x36D7A74")]
		public static int GetTagFieldNumber(uint tag)
		{
			return 0;
		}

		// Token: 0x06006D2C RID: 27948 RVA: 0x0004EC48 File Offset: 0x0004CE48
		[Token(Token = "0x6006D2C")]
		[Address(RVA = "0x36D6240", Offset = "0x36D6240", VA = "0x36D6240")]
		public static uint MakeTag(int fieldNumber, WireFormat.WireType wireType)
		{
			return 0U;
		}

		// Token: 0x04002BDE RID: 11230
		[Token(Token = "0x4002BDE")]
		private const int TagTypeBits = 3;

		// Token: 0x04002BDF RID: 11231
		[Token(Token = "0x4002BDF")]
		private const uint TagTypeMask = 7U;

		// Token: 0x02000B30 RID: 2864
		[Token(Token = "0x2000B30")]
		public enum WireType : uint
		{
			// Token: 0x04002BE1 RID: 11233
			[Token(Token = "0x4002BE1")]
			Varint,
			// Token: 0x04002BE2 RID: 11234
			[Token(Token = "0x4002BE2")]
			Fixed64,
			// Token: 0x04002BE3 RID: 11235
			[Token(Token = "0x4002BE3")]
			LengthDelimited,
			// Token: 0x04002BE4 RID: 11236
			[Token(Token = "0x4002BE4")]
			StartGroup,
			// Token: 0x04002BE5 RID: 11237
			[Token(Token = "0x4002BE5")]
			EndGroup,
			// Token: 0x04002BE6 RID: 11238
			[Token(Token = "0x4002BE6")]
			Fixed32
		}
	}
}
