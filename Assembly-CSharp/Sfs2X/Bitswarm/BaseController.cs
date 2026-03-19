using System;
using Il2CppDummyDll;
using Sfs2X.Logging;

namespace Sfs2X.Bitswarm
{
	// Token: 0x02000A96 RID: 2710
	[Token(Token = "0x2000A96")]
	public abstract class BaseController : IController
	{
		// Token: 0x0600672C RID: 26412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600672C")]
		[Address(RVA = "0x33C4738", Offset = "0x33C4738", VA = "0x33C4738")]
		public BaseController(ISocketClient socketClient)
		{
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x0600672D RID: 26413 RVA: 0x0004C818 File Offset: 0x0004AA18
		// (set) Token: 0x0600672E RID: 26414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006E2")]
		public int Id
		{
			[Token(Token = "0x600672D")]
			[Address(RVA = "0x33C6268", Offset = "0x33C6268", VA = "0x33C6268", Slot = "4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600672E")]
			[Address(RVA = "0x33C6270", Offset = "0x33C6270", VA = "0x33C6270", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x0600672F RID: 26415
		[Token(Token = "0x600672F")]
		public abstract void HandleMessage(IMessage message);

		// Token: 0x0400293D RID: 10557
		[Token(Token = "0x400293D")]
		[FieldOffset(Offset = "0x10")]
		protected int id;

		// Token: 0x0400293E RID: 10558
		[Token(Token = "0x400293E")]
		[FieldOffset(Offset = "0x18")]
		protected SmartFox sfs;

		// Token: 0x0400293F RID: 10559
		[Token(Token = "0x400293F")]
		[FieldOffset(Offset = "0x20")]
		protected ISocketClient socketClient;

		// Token: 0x04002940 RID: 10560
		[Token(Token = "0x4002940")]
		[FieldOffset(Offset = "0x28")]
		protected Logger log;
	}
}
