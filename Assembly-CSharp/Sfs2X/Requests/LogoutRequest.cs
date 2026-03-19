using System;
using Il2CppDummyDll;

namespace Sfs2X.Requests
{
	// Token: 0x02000A58 RID: 2648
	[Token(Token = "0x2000A58")]
	public class LogoutRequest : BaseRequest
	{
		// Token: 0x0600646A RID: 25706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600646A")]
		[Address(RVA = "0x2DFD0D8", Offset = "0x2DFD0D8", VA = "0x2DFD0D8")]
		public LogoutRequest()
		{
		}

		// Token: 0x0600646B RID: 25707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600646B")]
		[Address(RVA = "0x2DFD130", Offset = "0x2DFD130", VA = "0x2DFD130", Slot = "11")]
		public override void Validate(SmartFox sfs)
		{
		}

		// Token: 0x04002880 RID: 10368
		[Token(Token = "0x4002880")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string KEY_ZONE_NAME;
	}
}
