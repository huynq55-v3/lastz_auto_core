using System;
using Il2CppDummyDll;
using Sfs2X.Protocol;
using Sfs2X.Util;

namespace Sfs2X.Bitswarm
{
	// Token: 0x02000A9C RID: 2716
	[Token(Token = "0x2000A9C")]
	public interface IoHandler
	{
		// Token: 0x0600677F RID: 26495
		[Token(Token = "0x600677F")]
		void OnDataRead(ByteArray buffer);

		// Token: 0x06006780 RID: 26496
		[Token(Token = "0x6006780")]
		void OnDataRead(string jsonData);

		// Token: 0x06006781 RID: 26497
		[Token(Token = "0x6006781")]
		void OnDataWrite(IMessage message);

		// Token: 0x06006782 RID: 26498
		[Token(Token = "0x6006782")]
		void OnDataWrite(byte[] data, int dataLen);

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06006783 RID: 26499
		[Token(Token = "0x170006FE")]
		IProtocolCodec Codec
		{
			[Token(Token = "0x6006783")]
			get;
		}
	}
}
