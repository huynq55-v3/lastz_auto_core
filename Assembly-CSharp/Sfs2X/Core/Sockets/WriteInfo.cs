using System;
using System.Net.Sockets;
using Il2CppDummyDll;

namespace Sfs2X.Core.Sockets
{
	// Token: 0x02000A85 RID: 2693
	[Token(Token = "0x2000A85")]
	public class WriteInfo
	{
		// Token: 0x060066C2 RID: 26306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066C2")]
		[Address(RVA = "0x33C1818", Offset = "0x33C1818", VA = "0x33C1818")]
		public WriteInfo()
		{
		}

		// Token: 0x04002914 RID: 10516
		[Token(Token = "0x4002914")]
		[FieldOffset(Offset = "0x10")]
		public byte[] data;

		// Token: 0x04002915 RID: 10517
		[Token(Token = "0x4002915")]
		[FieldOffset(Offset = "0x18")]
		public TcpClient writeClient;
	}
}
