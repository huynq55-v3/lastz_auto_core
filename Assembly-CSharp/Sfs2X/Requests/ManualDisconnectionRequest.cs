using System;
using Il2CppDummyDll;

namespace Sfs2X.Requests
{
	// Token: 0x02000A59 RID: 2649
	[Token(Token = "0x2000A59")]
	public class ManualDisconnectionRequest : BaseRequest
	{
		// Token: 0x0600646D RID: 25709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600646D")]
		[Address(RVA = "0x2DF577C", Offset = "0x2DF577C", VA = "0x2DF577C")]
		public ManualDisconnectionRequest()
		{
		}

		// Token: 0x0600646E RID: 25710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600646E")]
		[Address(RVA = "0x2DFD25C", Offset = "0x2DFD25C", VA = "0x2DFD25C", Slot = "11")]
		public override void Validate(SmartFox sfs)
		{
		}

		// Token: 0x0600646F RID: 25711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600646F")]
		[Address(RVA = "0x2DFD260", Offset = "0x2DFD260", VA = "0x2DFD260", Slot = "12")]
		public override void Execute(SmartFox sfs)
		{
		}
	}
}
