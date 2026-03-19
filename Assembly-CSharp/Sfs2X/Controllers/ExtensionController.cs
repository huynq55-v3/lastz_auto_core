using System;
using Il2CppDummyDll;
using Sfs2X.Bitswarm;
using Sfs2X.Util;

namespace Sfs2X.Controllers
{
	// Token: 0x02000A93 RID: 2707
	[Token(Token = "0x2000A93")]
	public class ExtensionController : BaseController
	{
		// Token: 0x0600671A RID: 26394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600671A")]
		[Address(RVA = "0x33C4734", Offset = "0x33C4734", VA = "0x33C4734")]
		public ExtensionController(ISocketClient socketClient)
		{
		}

		// Token: 0x0600671B RID: 26395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600671B")]
		[Address(RVA = "0x33C4884", Offset = "0x33C4884", VA = "0x33C4884", Slot = "7")]
		public override void HandleMessage(IMessage message)
		{
		}

		// Token: 0x0600671C RID: 26396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600671C")]
		[Address(RVA = "0x33C1640", Offset = "0x33C1640", VA = "0x33C1640")]
		public void HandleExtensionResponse(string cmd, ByteArray RawData)
		{
		}

		// Token: 0x04002938 RID: 10552
		[Token(Token = "0x4002938")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string KEY_CMD;

		// Token: 0x04002939 RID: 10553
		[Token(Token = "0x4002939")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string KEY_PARAMS;

		// Token: 0x0400293A RID: 10554
		[Token(Token = "0x400293A")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string KEY_ROOM;
	}
}
