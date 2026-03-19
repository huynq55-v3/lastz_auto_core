using System;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x02000AE1 RID: 2785
	[Token(Token = "0x2000AE1")]
	internal class WriterContext
	{
		// Token: 0x06006A2A RID: 27178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A2A")]
		[Address(RVA = "0x34991F8", Offset = "0x34991F8", VA = "0x34991F8")]
		public WriterContext()
		{
		}

		// Token: 0x04002AC2 RID: 10946
		[Token(Token = "0x4002AC2")]
		[FieldOffset(Offset = "0x10")]
		public int Count;

		// Token: 0x04002AC3 RID: 10947
		[Token(Token = "0x4002AC3")]
		[FieldOffset(Offset = "0x14")]
		public bool InArray;

		// Token: 0x04002AC4 RID: 10948
		[Token(Token = "0x4002AC4")]
		[FieldOffset(Offset = "0x15")]
		public bool InObject;

		// Token: 0x04002AC5 RID: 10949
		[Token(Token = "0x4002AC5")]
		[FieldOffset(Offset = "0x16")]
		public bool ExpectingValue;

		// Token: 0x04002AC6 RID: 10950
		[Token(Token = "0x4002AC6")]
		[FieldOffset(Offset = "0x18")]
		public int Padding;
	}
}
