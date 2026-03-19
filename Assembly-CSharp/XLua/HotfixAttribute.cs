using System;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x0200051B RID: 1307
	[Token(Token = "0x200051B")]
	public class HotfixAttribute : Attribute
	{
		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x0600273E RID: 10046 RVA: 0x0000EE08 File Offset: 0x0000D008
		[Token(Token = "0x170005D9")]
		public HotfixFlag Flag
		{
			[Token(Token = "0x600273E")]
			[Address(RVA = "0x2B68E48", Offset = "0x2B68E48", VA = "0x2B68E48")]
			get
			{
				return HotfixFlag.Stateless;
			}
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600273F")]
		[Address(RVA = "0x2B68E50", Offset = "0x2B68E50", VA = "0x2B68E50")]
		public HotfixAttribute(HotfixFlag e = HotfixFlag.Stateless)
		{
		}

		// Token: 0x0400234A RID: 9034
		[Token(Token = "0x400234A")]
		[FieldOffset(Offset = "0x10")]
		private HotfixFlag flag;
	}
}
