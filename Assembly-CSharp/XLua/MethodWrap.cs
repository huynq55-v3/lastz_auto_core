using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x0200052C RID: 1324
	[Token(Token = "0x200052C")]
	public class MethodWrap
	{
		// Token: 0x060027C4 RID: 10180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C4")]
		[Address(RVA = "0x26AC6C8", Offset = "0x26AC6C8", VA = "0x26AC6C8")]
		public MethodWrap(string methodName, List<OverloadMethodWrap> overloads, bool forceCheck)
		{
		}

		// Token: 0x060027C5 RID: 10181 RVA: 0x0000EFB8 File Offset: 0x0000D1B8
		[Token(Token = "0x60027C5")]
		[Address(RVA = "0x26AC720", Offset = "0x26AC720", VA = "0x26AC720")]
		public int Call(IntPtr L)
		{
			return 0;
		}

		// Token: 0x04002399 RID: 9113
		[Token(Token = "0x4002399")]
		[FieldOffset(Offset = "0x10")]
		private string methodName;

		// Token: 0x0400239A RID: 9114
		[Token(Token = "0x400239A")]
		[FieldOffset(Offset = "0x18")]
		private List<OverloadMethodWrap> overloads;

		// Token: 0x0400239B RID: 9115
		[Token(Token = "0x400239B")]
		[FieldOffset(Offset = "0x20")]
		private bool forceCheck;
	}
}
