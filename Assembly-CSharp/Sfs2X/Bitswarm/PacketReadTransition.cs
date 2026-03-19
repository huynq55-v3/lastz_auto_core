using System;
using Il2CppDummyDll;

namespace Sfs2X.Bitswarm
{
	// Token: 0x02000AA0 RID: 2720
	[Token(Token = "0x2000AA0")]
	public enum PacketReadTransition
	{
		// Token: 0x04002973 RID: 10611
		[Token(Token = "0x4002973")]
		HeaderReceived,
		// Token: 0x04002974 RID: 10612
		[Token(Token = "0x4002974")]
		SizeReceived,
		// Token: 0x04002975 RID: 10613
		[Token(Token = "0x4002975")]
		IncompleteSize,
		// Token: 0x04002976 RID: 10614
		[Token(Token = "0x4002976")]
		WholeSizeReceived,
		// Token: 0x04002977 RID: 10615
		[Token(Token = "0x4002977")]
		PacketFinished,
		// Token: 0x04002978 RID: 10616
		[Token(Token = "0x4002978")]
		InvalidData,
		// Token: 0x04002979 RID: 10617
		[Token(Token = "0x4002979")]
		InvalidDataFinished
	}
}
