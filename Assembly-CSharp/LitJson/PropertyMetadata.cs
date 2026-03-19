using System;
using System.Reflection;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x02000AD1 RID: 2769
	[Token(Token = "0x2000AD1")]
	internal struct PropertyMetadata
	{
		// Token: 0x04002A67 RID: 10855
		[Token(Token = "0x4002A67")]
		[FieldOffset(Offset = "0x0")]
		public MemberInfo Info;

		// Token: 0x04002A68 RID: 10856
		[Token(Token = "0x4002A68")]
		[FieldOffset(Offset = "0x8")]
		public bool IsField;

		// Token: 0x04002A69 RID: 10857
		[Token(Token = "0x4002A69")]
		[FieldOffset(Offset = "0x10")]
		public Type Type;
	}
}
