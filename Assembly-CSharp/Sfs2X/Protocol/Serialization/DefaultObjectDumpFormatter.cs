using System;
using Il2CppDummyDll;
using Sfs2X.Util;

namespace Sfs2X.Protocol.Serialization
{
	// Token: 0x02000A5D RID: 2653
	[Token(Token = "0x2000A5D")]
	public class DefaultObjectDumpFormatter
	{
		// Token: 0x06006479 RID: 25721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006479")]
		[Address(RVA = "0x2DFD2C4", Offset = "0x2DFD2C4", VA = "0x2DFD2C4")]
		public static string PrettyPrintDump(string rawDump)
		{
			return null;
		}

		// Token: 0x0600647A RID: 25722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600647A")]
		[Address(RVA = "0x2DFD530", Offset = "0x2DFD530", VA = "0x2DFD530")]
		private static string GetFormatTabs(int howMany)
		{
			return null;
		}

		// Token: 0x0600647B RID: 25723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600647B")]
		[Address(RVA = "0x2DFD5F8", Offset = "0x2DFD5F8", VA = "0x2DFD5F8")]
		private static string StrFill(char ch, int howMany)
		{
			return null;
		}

		// Token: 0x0600647C RID: 25724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600647C")]
		[Address(RVA = "0x2DFD68C", Offset = "0x2DFD68C", VA = "0x2DFD68C")]
		public static string HexDump(ByteArray ba)
		{
			return null;
		}

		// Token: 0x0600647D RID: 25725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600647D")]
		[Address(RVA = "0x2DFD6EC", Offset = "0x2DFD6EC", VA = "0x2DFD6EC")]
		public static string HexDump(ByteArray ba, int bytesPerLine)
		{
			return null;
		}

		// Token: 0x0600647E RID: 25726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600647E")]
		[Address(RVA = "0x2DFDC8C", Offset = "0x2DFDC8C", VA = "0x2DFDC8C")]
		public DefaultObjectDumpFormatter()
		{
		}

		// Token: 0x04002888 RID: 10376
		[Token(Token = "0x4002888")]
		[FieldOffset(Offset = "0x0")]
		public static readonly char TOKEN_INDENT_OPEN;

		// Token: 0x04002889 RID: 10377
		[Token(Token = "0x4002889")]
		[FieldOffset(Offset = "0x2")]
		public static readonly char TOKEN_INDENT_CLOSE;

		// Token: 0x0400288A RID: 10378
		[Token(Token = "0x400288A")]
		[FieldOffset(Offset = "0x4")]
		public static readonly char TOKEN_DIVIDER;

		// Token: 0x0400288B RID: 10379
		[Token(Token = "0x400288B")]
		[FieldOffset(Offset = "0x6")]
		public static readonly char NEW_LINE;

		// Token: 0x0400288C RID: 10380
		[Token(Token = "0x400288C")]
		[FieldOffset(Offset = "0x8")]
		public static readonly char TAB;

		// Token: 0x0400288D RID: 10381
		[Token(Token = "0x400288D")]
		[FieldOffset(Offset = "0xA")]
		public static readonly char DOT;

		// Token: 0x0400288E RID: 10382
		[Token(Token = "0x400288E")]
		[FieldOffset(Offset = "0xC")]
		public static readonly int HEX_BYTES_PER_LINE;

		// Token: 0x0400288F RID: 10383
		[Token(Token = "0x400288F")]
		[FieldOffset(Offset = "0x10")]
		public static int MAX_DUMP_LENGTH;
	}
}
