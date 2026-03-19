using System;
using Il2CppDummyDll;
using Sfs2X.Bitswarm;

namespace Sfs2X.Requests
{
	// Token: 0x02000A56 RID: 2646
	[Token(Token = "0x2000A56")]
	public interface IRequest
	{
		// Token: 0x0600645B RID: 25691
		[Token(Token = "0x600645B")]
		void Validate(SmartFox sfs);

		// Token: 0x0600645C RID: 25692
		[Token(Token = "0x600645C")]
		void Execute(SmartFox sfs);

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x0600645D RID: 25693
		// (set) Token: 0x0600645E RID: 25694
		[Token(Token = "0x170006A7")]
		int TargetController
		{
			[Token(Token = "0x600645D")]
			get;
			[Token(Token = "0x600645E")]
			set;
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x0600645F RID: 25695
		// (set) Token: 0x06006460 RID: 25696
		[Token(Token = "0x170006A8")]
		bool IsEncrypted
		{
			[Token(Token = "0x600645F")]
			get;
			[Token(Token = "0x6006460")]
			set;
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06006461 RID: 25697
		[Token(Token = "0x170006A9")]
		IMessage Message
		{
			[Token(Token = "0x6006461")]
			get;
		}
	}
}
