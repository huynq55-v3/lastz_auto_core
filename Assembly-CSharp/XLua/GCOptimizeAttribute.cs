using System;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x02000516 RID: 1302
	[Token(Token = "0x2000516")]
	public class GCOptimizeAttribute : Attribute
	{
		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06002739 RID: 10041 RVA: 0x0000EDF0 File Offset: 0x0000CFF0
		[Token(Token = "0x170005D8")]
		public OptimizeFlag Flag
		{
			[Token(Token = "0x6002739")]
			[Address(RVA = "0x2B68E00", Offset = "0x2B68E00", VA = "0x2B68E00")]
			get
			{
				return OptimizeFlag.Default;
			}
		}

		// Token: 0x0600273A RID: 10042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600273A")]
		[Address(RVA = "0x2B68E08", Offset = "0x2B68E08", VA = "0x2B68E08")]
		public GCOptimizeAttribute(OptimizeFlag flag = OptimizeFlag.Default)
		{
		}

		// Token: 0x0400233E RID: 9022
		[Token(Token = "0x400233E")]
		[FieldOffset(Offset = "0x10")]
		private OptimizeFlag flag;
	}
}
