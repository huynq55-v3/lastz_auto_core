using System;
using Il2CppDummyDll;

namespace Sfs2X.Bitswarm
{
	// Token: 0x02000A99 RID: 2713
	[Token(Token = "0x2000A99")]
	public class ConnectionModes
	{
		// Token: 0x0600676A RID: 26474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600676A")]
		[Address(RVA = "0x33C9190", Offset = "0x33C9190", VA = "0x33C9190")]
		public ConnectionModes()
		{
		}

		// Token: 0x0400295E RID: 10590
		[Token(Token = "0x400295E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string SOCKET;

		// Token: 0x0400295F RID: 10591
		[Token(Token = "0x400295F")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string HTTP;

		// Token: 0x04002960 RID: 10592
		[Token(Token = "0x4002960")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string WEBSOCKET_TEXT;

		// Token: 0x04002961 RID: 10593
		[Token(Token = "0x4002961")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string WEBSOCKET_BIN;

		// Token: 0x04002962 RID: 10594
		[Token(Token = "0x4002962")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string WEBSOCKET_SECURE_TEXT;

		// Token: 0x04002963 RID: 10595
		[Token(Token = "0x4002963")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string WEBSOCKET_SECURE_BIN;
	}
}
