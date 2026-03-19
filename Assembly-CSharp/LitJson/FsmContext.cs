using System;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x02000AE3 RID: 2787
	[Token(Token = "0x2000AE3")]
	internal class FsmContext
	{
		// Token: 0x06006A50 RID: 27216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A50")]
		[Address(RVA = "0x3499B44", Offset = "0x3499B44", VA = "0x3499B44")]
		public FsmContext()
		{
		}

		// Token: 0x04002AD3 RID: 10963
		[Token(Token = "0x4002AD3")]
		[FieldOffset(Offset = "0x10")]
		public bool Return;

		// Token: 0x04002AD4 RID: 10964
		[Token(Token = "0x4002AD4")]
		[FieldOffset(Offset = "0x14")]
		public int NextState;

		// Token: 0x04002AD5 RID: 10965
		[Token(Token = "0x4002AD5")]
		[FieldOffset(Offset = "0x18")]
		public Lexer L;

		// Token: 0x04002AD6 RID: 10966
		[Token(Token = "0x4002AD6")]
		[FieldOffset(Offset = "0x20")]
		public int StateStack;
	}
}
