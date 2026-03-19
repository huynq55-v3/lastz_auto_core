using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sfs2X.Bitswarm;

namespace Sfs2X.Controllers
{
	// Token: 0x02000A95 RID: 2709
	[Token(Token = "0x2000A95")]
	public class SystemController : BaseController
	{
		// Token: 0x06006722 RID: 26402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006722")]
		[Address(RVA = "0x33C4CF0", Offset = "0x33C4CF0", VA = "0x33C4CF0")]
		public SystemController(ISocketClient socketClient)
		{
		}

		// Token: 0x06006723 RID: 26403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006723")]
		[Address(RVA = "0x33C4D90", Offset = "0x33C4D90", VA = "0x33C4D90")]
		private void InitRequestHandlers()
		{
		}

		// Token: 0x06006724 RID: 26404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006724")]
		[Address(RVA = "0x33C4FB4", Offset = "0x33C4FB4", VA = "0x33C4FB4", Slot = "7")]
		public override void HandleMessage(IMessage message)
		{
		}

		// Token: 0x06006725 RID: 26405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006725")]
		[Address(RVA = "0x33C5538", Offset = "0x33C5538", VA = "0x33C5538")]
		private void FnHandshake(IMessage msg)
		{
		}

		// Token: 0x06006726 RID: 26406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006726")]
		[Address(RVA = "0x33C56C0", Offset = "0x33C56C0", VA = "0x33C56C0")]
		private void FnLogin(IMessage msg)
		{
		}

		// Token: 0x06006727 RID: 26407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006727")]
		[Address(RVA = "0x33C5D8C", Offset = "0x33C5D8C", VA = "0x33C5D8C")]
		private void FnLogout(IMessage msg)
		{
		}

		// Token: 0x06006728 RID: 26408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006728")]
		[Address(RVA = "0x33C5FC4", Offset = "0x33C5FC4", VA = "0x33C5FC4")]
		private void FnPingPong(IMessage msg)
		{
		}

		// Token: 0x06006729 RID: 26409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006729")]
		[Address(RVA = "0x33C6050", Offset = "0x33C6050", VA = "0x33C6050")]
		private void FnClientDisconnection(IMessage msg)
		{
		}

		// Token: 0x0600672A RID: 26410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600672A")]
		[Address(RVA = "0x33C61E0", Offset = "0x33C61E0", VA = "0x33C61E0")]
		private void FnReconnectionFailure(IMessage msg)
		{
		}

		// Token: 0x0400293B RID: 10555
		[Token(Token = "0x400293B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string KEY_PARAMS;

		// Token: 0x0400293C RID: 10556
		[Token(Token = "0x400293C")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<int, RequestDelegate> requestHandlers;
	}
}
