using System;
using Il2CppDummyDll;
using Sfs2X.Bitswarm;
using Sfs2X.Entities.Data;
using Sfs2X.Util;

namespace Sfs2X.Protocol
{
	// Token: 0x02000A5C RID: 2652
	[Token(Token = "0x2000A5C")]
	public interface IProtocolCodec
	{
		// Token: 0x06006473 RID: 25715
		[Token(Token = "0x6006473")]
		void OnPacketRead(ISFSObject packet);

		// Token: 0x06006474 RID: 25716
		[Token(Token = "0x6006474")]
		void OnPacketRead(ByteArray packet);

		// Token: 0x06006475 RID: 25717
		[Token(Token = "0x6006475")]
		void OnPacketWrite(IMessage message);

		// Token: 0x06006476 RID: 25718
		[Token(Token = "0x6006476")]
		void OnPacketWrite(byte[] data, int dataLen);

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06006477 RID: 25719
		// (set) Token: 0x06006478 RID: 25720
		[Token(Token = "0x170006AA")]
		IoHandler IOHandler
		{
			[Token(Token = "0x6006477")]
			get;
			[Token(Token = "0x6006478")]
			set;
		}
	}
}
