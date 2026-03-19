using System;
using Il2CppDummyDll;

namespace VEngine
{
	// Token: 0x020009E4 RID: 2532
	[Token(Token = "0x20009E4")]
	public static class Logger
	{
		// Token: 0x0600611B RID: 24859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600611B")]
		[Address(RVA = "0x140D480", Offset = "0x140D480", VA = "0x140D480")]
		public static void E(string format, params object[] args)
		{
		}

		// Token: 0x0600611C RID: 24860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600611C")]
		[Address(RVA = "0x13FE270", Offset = "0x13FE270", VA = "0x13FE270")]
		public static void W(string format, params object[] args)
		{
		}

		// Token: 0x0600611D RID: 24861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600611D")]
		[Address(RVA = "0x1404260", Offset = "0x1404260", VA = "0x1404260")]
		public static void I(string format, params object[] args)
		{
		}

		// Token: 0x0400259E RID: 9630
		[Token(Token = "0x400259E")]
		[FieldOffset(Offset = "0x0")]
		public static bool Loggable;
	}
}
