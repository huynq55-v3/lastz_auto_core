using System;
using Il2CppDummyDll;

namespace Sfs2X.Util
{
	// Token: 0x02000A50 RID: 2640
	[Token(Token = "0x2000A50")]
	public class CryptoKey
	{
		// Token: 0x0600643C RID: 25660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600643C")]
		[Address(RVA = "0x2DFB20C", Offset = "0x2DFB20C", VA = "0x2DFB20C")]
		public CryptoKey(ByteArray iv, ByteArray key)
		{
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x0600643D RID: 25661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700069F")]
		public ByteArray IV
		{
			[Token(Token = "0x600643D")]
			[Address(RVA = "0x2DFB250", Offset = "0x2DFB250", VA = "0x2DFB250")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x0600643E RID: 25662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006A0")]
		public ByteArray Key
		{
			[Token(Token = "0x600643E")]
			[Address(RVA = "0x2DFB258", Offset = "0x2DFB258", VA = "0x2DFB258")]
			get
			{
				return null;
			}
		}

		// Token: 0x04002861 RID: 10337
		[Token(Token = "0x4002861")]
		[FieldOffset(Offset = "0x10")]
		private ByteArray iv;

		// Token: 0x04002862 RID: 10338
		[Token(Token = "0x4002862")]
		[FieldOffset(Offset = "0x18")]
		private ByteArray key;
	}
}
