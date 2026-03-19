using System;
using System.Collections;
using Il2CppDummyDll;
using Sfs2X.Core;

namespace Sfs2X.Bitswarm
{
	// Token: 0x02000A98 RID: 2712
	[Token(Token = "0x2000A98")]
	public class BitSwarmEvent : BaseEvent
	{
		// Token: 0x06006767 RID: 26471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006767")]
		[Address(RVA = "0x33C821C", Offset = "0x33C821C", VA = "0x33C821C")]
		public BitSwarmEvent(string type)
		{
		}

		// Token: 0x06006768 RID: 26472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006768")]
		[Address(RVA = "0x33C8BF0", Offset = "0x33C8BF0", VA = "0x33C8BF0")]
		public BitSwarmEvent(string type, Hashtable arguments)
		{
		}

		// Token: 0x04002958 RID: 10584
		[Token(Token = "0x4002958")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string CONNECT;

		// Token: 0x04002959 RID: 10585
		[Token(Token = "0x4002959")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string DISCONNECT;

		// Token: 0x0400295A RID: 10586
		[Token(Token = "0x400295A")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string RECONNECTION_TRY;

		// Token: 0x0400295B RID: 10587
		[Token(Token = "0x400295B")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string IO_ERROR;

		// Token: 0x0400295C RID: 10588
		[Token(Token = "0x400295C")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string SECURITY_ERROR;

		// Token: 0x0400295D RID: 10589
		[Token(Token = "0x400295D")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string DATA_ERROR;
	}
}
