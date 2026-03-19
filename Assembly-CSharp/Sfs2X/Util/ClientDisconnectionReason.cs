using System;
using Il2CppDummyDll;

namespace Sfs2X.Util
{
	// Token: 0x02000A4F RID: 2639
	[Token(Token = "0x2000A4F")]
	public static class ClientDisconnectionReason
	{
		// Token: 0x0600643A RID: 25658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600643A")]
		[Address(RVA = "0x2DFAF48", Offset = "0x2DFAF48", VA = "0x2DFAF48")]
		public static string GetReason(int reasonId)
		{
			return null;
		}

		// Token: 0x0400285B RID: 10331
		[Token(Token = "0x400285B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string IDLE;

		// Token: 0x0400285C RID: 10332
		[Token(Token = "0x400285C")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string KICK;

		// Token: 0x0400285D RID: 10333
		[Token(Token = "0x400285D")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string BAN;

		// Token: 0x0400285E RID: 10334
		[Token(Token = "0x400285E")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string MANUAL;

		// Token: 0x0400285F RID: 10335
		[Token(Token = "0x400285F")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string UNKNOWN;

		// Token: 0x04002860 RID: 10336
		[Token(Token = "0x4002860")]
		[FieldOffset(Offset = "0x28")]
		private static string[] reasons;
	}
}
