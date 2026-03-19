using System;
using Il2CppDummyDll;
using Sfs2X.Util;

namespace Sfs2X.Core
{
	// Token: 0x02000A80 RID: 2688
	[Token(Token = "0x2000A80")]
	public interface IPacketEncrypter
	{
		// Token: 0x06006693 RID: 26259
		[Token(Token = "0x6006693")]
		void Encrypt(ByteArray data);

		// Token: 0x06006694 RID: 26260
		[Token(Token = "0x6006694")]
		void Decrypt(ByteArray data);
	}
}
