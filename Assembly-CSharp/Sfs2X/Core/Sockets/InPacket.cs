using System;
using System.Net.Sockets;
using Il2CppDummyDll;
using Sfs2X.Util;

namespace Sfs2X.Core.Sockets
{
	// Token: 0x02000A92 RID: 2706
	[Token(Token = "0x2000A92")]
	public struct InPacket
	{
		// Token: 0x06006719 RID: 26393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006719")]
		[Address(RVA = "0x33C464C", Offset = "0x33C464C", VA = "0x33C464C")]
		public void Execute()
		{
		}

		// Token: 0x04002934 RID: 10548
		[Token(Token = "0x4002934")]
		[FieldOffset(Offset = "0x0")]
		public Delegate Callback;

		// Token: 0x04002935 RID: 10549
		[Token(Token = "0x4002935")]
		[FieldOffset(Offset = "0x8")]
		public ByteArray Data;

		// Token: 0x04002936 RID: 10550
		[Token(Token = "0x4002936")]
		[FieldOffset(Offset = "0x10")]
		public string StrError;

		// Token: 0x04002937 RID: 10551
		[Token(Token = "0x4002937")]
		[FieldOffset(Offset = "0x18")]
		public SocketError SocketError;
	}
}
