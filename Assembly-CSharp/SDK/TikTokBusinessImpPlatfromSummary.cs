using System;
using Il2CppDummyDll;

namespace SDK
{
	// Token: 0x02000CE7 RID: 3303
	[Token(Token = "0x2000CE7")]
	public class TikTokBusinessImpPlatfromSummary
	{
		// Token: 0x06007C2D RID: 31789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C2D")]
		[Address(RVA = "0x31990C0", Offset = "0x31990C0", VA = "0x31990C0")]
		private TikTokBusinessImpPlatfromSummary()
		{
		}

		// Token: 0x06007C2E RID: 31790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007C2E")]
		[Address(RVA = "0x3199134", Offset = "0x3199134", VA = "0x3199134")]
		public static TikTokBusinessImpPlatfromSummary Instance()
		{
			return null;
		}

		// Token: 0x06007C2F RID: 31791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007C2F")]
		[Address(RVA = "0x31991B4", Offset = "0x31991B4", VA = "0x31991B4")]
		public ITikTokBusiness GetTiktokBusiness()
		{
			return null;
		}

		// Token: 0x040037F5 RID: 14325
		[Token(Token = "0x40037F5")]
		[FieldOffset(Offset = "0x0")]
		private static TikTokBusinessImpPlatfromSummary _instance;

		// Token: 0x040037F6 RID: 14326
		[Token(Token = "0x40037F6")]
		[FieldOffset(Offset = "0x10")]
		private ITikTokBusiness _iTikTokBusiness;
	}
}
