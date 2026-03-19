using System;
using Il2CppDummyDll;

namespace Sfs2X.Bitswarm
{
	// Token: 0x02000A9F RID: 2719
	[Token(Token = "0x2000A9F")]
	public enum PacketReadState
	{
		// Token: 0x0400296D RID: 10605
		[Token(Token = "0x400296D")]
		WAIT_NEW_PACKET,
		// Token: 0x0400296E RID: 10606
		[Token(Token = "0x400296E")]
		WAIT_DATA_SIZE,
		// Token: 0x0400296F RID: 10607
		[Token(Token = "0x400296F")]
		WAIT_DATA_SIZE_FRAGMENT,
		// Token: 0x04002970 RID: 10608
		[Token(Token = "0x4002970")]
		WAIT_DATA,
		// Token: 0x04002971 RID: 10609
		[Token(Token = "0x4002971")]
		INVALID_DATA
	}
}
