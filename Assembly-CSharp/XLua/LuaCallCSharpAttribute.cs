using System;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x02000512 RID: 1298
	[Token(Token = "0x2000512")]
	public class LuaCallCSharpAttribute : Attribute
	{
		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06002735 RID: 10037 RVA: 0x0000EDD8 File Offset: 0x0000CFD8
		[Token(Token = "0x170005D7")]
		public GenFlag Flag
		{
			[Token(Token = "0x6002735")]
			[Address(RVA = "0x2B68DC0", Offset = "0x2B68DC0", VA = "0x2B68DC0")]
			get
			{
				return GenFlag.No;
			}
		}

		// Token: 0x06002736 RID: 10038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002736")]
		[Address(RVA = "0x2B68DC8", Offset = "0x2B68DC8", VA = "0x2B68DC8")]
		public LuaCallCSharpAttribute(GenFlag flag = GenFlag.No)
		{
		}

		// Token: 0x0400233A RID: 9018
		[Token(Token = "0x400233A")]
		[FieldOffset(Offset = "0x10")]
		private GenFlag flag;
	}
}
