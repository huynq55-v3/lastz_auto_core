using System;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x02000AE6 RID: 2790
	[Token(Token = "0x2000AE6")]
	internal enum ParserToken
	{
		// Token: 0x04002AE6 RID: 10982
		[Token(Token = "0x4002AE6")]
		None = 65536,
		// Token: 0x04002AE7 RID: 10983
		[Token(Token = "0x4002AE7")]
		Number,
		// Token: 0x04002AE8 RID: 10984
		[Token(Token = "0x4002AE8")]
		True,
		// Token: 0x04002AE9 RID: 10985
		[Token(Token = "0x4002AE9")]
		False,
		// Token: 0x04002AEA RID: 10986
		[Token(Token = "0x4002AEA")]
		Null,
		// Token: 0x04002AEB RID: 10987
		[Token(Token = "0x4002AEB")]
		CharSeq,
		// Token: 0x04002AEC RID: 10988
		[Token(Token = "0x4002AEC")]
		Char,
		// Token: 0x04002AED RID: 10989
		[Token(Token = "0x4002AED")]
		Text,
		// Token: 0x04002AEE RID: 10990
		[Token(Token = "0x4002AEE")]
		Object,
		// Token: 0x04002AEF RID: 10991
		[Token(Token = "0x4002AEF")]
		ObjectPrime,
		// Token: 0x04002AF0 RID: 10992
		[Token(Token = "0x4002AF0")]
		Pair,
		// Token: 0x04002AF1 RID: 10993
		[Token(Token = "0x4002AF1")]
		PairRest,
		// Token: 0x04002AF2 RID: 10994
		[Token(Token = "0x4002AF2")]
		Array,
		// Token: 0x04002AF3 RID: 10995
		[Token(Token = "0x4002AF3")]
		ArrayPrime,
		// Token: 0x04002AF4 RID: 10996
		[Token(Token = "0x4002AF4")]
		Value,
		// Token: 0x04002AF5 RID: 10997
		[Token(Token = "0x4002AF5")]
		ValueRest,
		// Token: 0x04002AF6 RID: 10998
		[Token(Token = "0x4002AF6")]
		String,
		// Token: 0x04002AF7 RID: 10999
		[Token(Token = "0x4002AF7")]
		End,
		// Token: 0x04002AF8 RID: 11000
		[Token(Token = "0x4002AF8")]
		Epsilon
	}
}
