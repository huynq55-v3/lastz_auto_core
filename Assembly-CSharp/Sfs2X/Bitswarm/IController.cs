using System;
using Il2CppDummyDll;

namespace Sfs2X.Bitswarm
{
	// Token: 0x02000A9A RID: 2714
	[Token(Token = "0x2000A9A")]
	public interface IController
	{
		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x0600676C RID: 26476
		// (set) Token: 0x0600676D RID: 26477
		[Token(Token = "0x170006F5")]
		int Id
		{
			[Token(Token = "0x600676C")]
			get;
			[Token(Token = "0x600676D")]
			set;
		}

		// Token: 0x0600676E RID: 26478
		[Token(Token = "0x600676E")]
		void HandleMessage(IMessage message);
	}
}
