using System;
using Il2CppDummyDll;

namespace Sfs2X.Requests
{
	// Token: 0x02000A5A RID: 2650
	[Token(Token = "0x2000A5A")]
	public class PingPongRequest : BaseRequest
	{
		// Token: 0x06006470 RID: 25712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006470")]
		[Address(RVA = "0x2DFD264", Offset = "0x2DFD264", VA = "0x2DFD264")]
		public PingPongRequest()
		{
		}

		// Token: 0x06006471 RID: 25713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006471")]
		[Address(RVA = "0x2DFD2BC", Offset = "0x2DFD2BC", VA = "0x2DFD2BC", Slot = "11")]
		public override void Validate(SmartFox sfs)
		{
		}

		// Token: 0x06006472 RID: 25714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006472")]
		[Address(RVA = "0x2DFD2C0", Offset = "0x2DFD2C0", VA = "0x2DFD2C0", Slot = "12")]
		public override void Execute(SmartFox sfs)
		{
		}
	}
}
