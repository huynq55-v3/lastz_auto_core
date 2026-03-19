using System;
using Il2CppDummyDll;
using Sfs2X.Bitswarm;
using Sfs2X.FSM;
using Sfs2X.Logging;

namespace Sfs2X.Core.Sockets
{
	// Token: 0x02000A89 RID: 2697
	[Token(Token = "0x2000A89")]
	public class BaseSocketLayer
	{
		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x060066EE RID: 26350 RVA: 0x0004C800 File Offset: 0x0004AA00
		[Token(Token = "0x170006D9")]
		protected BaseSocketLayer.States State
		{
			[Token(Token = "0x60066EE")]
			[Address(RVA = "0x33C1EB4", Offset = "0x33C1EB4", VA = "0x33C1EB4")]
			get
			{
				return BaseSocketLayer.States.Disconnected;
			}
		}

		// Token: 0x060066EF RID: 26351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066EF")]
		[Address(RVA = "0x33C1A84", Offset = "0x33C1A84", VA = "0x33C1A84")]
		protected void InitStates()
		{
		}

		// Token: 0x060066F0 RID: 26352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066F0")]
		[Address(RVA = "0x33C1A08", Offset = "0x33C1A08", VA = "0x33C1A08")]
		public BaseSocketLayer()
		{
		}

		// Token: 0x04002927 RID: 10535
		[Token(Token = "0x4002927")]
		[FieldOffset(Offset = "0x10")]
		protected bool isDisconnecting;

		// Token: 0x04002928 RID: 10536
		[Token(Token = "0x4002928")]
		[FieldOffset(Offset = "0x18")]
		protected Logger log;

		// Token: 0x04002929 RID: 10537
		[Token(Token = "0x4002929")]
		[FieldOffset(Offset = "0x20")]
		protected ISocketClient socketClient;

		// Token: 0x0400292A RID: 10538
		[Token(Token = "0x400292A")]
		[FieldOffset(Offset = "0x28")]
		protected FiniteStateMachine fsm;

		// Token: 0x02000A8A RID: 2698
		[Token(Token = "0x2000A8A")]
		protected enum States
		{
			// Token: 0x0400292C RID: 10540
			[Token(Token = "0x400292C")]
			Disconnected,
			// Token: 0x0400292D RID: 10541
			[Token(Token = "0x400292D")]
			Connecting,
			// Token: 0x0400292E RID: 10542
			[Token(Token = "0x400292E")]
			Connected
		}

		// Token: 0x02000A8B RID: 2699
		[Token(Token = "0x2000A8B")]
		protected enum Transitions
		{
			// Token: 0x04002930 RID: 10544
			[Token(Token = "0x4002930")]
			StartConnect,
			// Token: 0x04002931 RID: 10545
			[Token(Token = "0x4002931")]
			ConnectionSuccess,
			// Token: 0x04002932 RID: 10546
			[Token(Token = "0x4002932")]
			ConnectionFailure,
			// Token: 0x04002933 RID: 10547
			[Token(Token = "0x4002933")]
			Disconnect
		}
	}
}
