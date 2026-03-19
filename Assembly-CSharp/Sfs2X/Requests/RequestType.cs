using System;
using Il2CppDummyDll;

namespace Sfs2X.Requests
{
	// Token: 0x02000A5B RID: 2651
	[Token(Token = "0x2000A5B")]
	public enum RequestType
	{
		// Token: 0x04002882 RID: 10370
		[Token(Token = "0x4002882")]
		Handshake,
		// Token: 0x04002883 RID: 10371
		[Token(Token = "0x4002883")]
		Login,
		// Token: 0x04002884 RID: 10372
		[Token(Token = "0x4002884")]
		Logout,
		// Token: 0x04002885 RID: 10373
		[Token(Token = "0x4002885")]
		CallExtension = 13,
		// Token: 0x04002886 RID: 10374
		[Token(Token = "0x4002886")]
		ManualDisconnection = 26,
		// Token: 0x04002887 RID: 10375
		[Token(Token = "0x4002887")]
		PingPong = 29
	}
}
