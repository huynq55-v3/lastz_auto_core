using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200002B RID: 43
[Token(Token = "0x200002B")]
public class FPD_HeaderAttribute : PropertyAttribute
{
	// Token: 0x06000077 RID: 119 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000077")]
	[Address(RVA = "0x15E5F64", Offset = "0x15E5F64", VA = "0x15E5F64")]
	public FPD_HeaderAttribute(string headerText, float upperPadding = 6f, float bottomPadding = 4f, int addHeight = 2)
	{
	}

	// Token: 0x040000E9 RID: 233
	[Token(Token = "0x40000E9")]
	[FieldOffset(Offset = "0x10")]
	public string HeaderText;

	// Token: 0x040000EA RID: 234
	[Token(Token = "0x40000EA")]
	[FieldOffset(Offset = "0x18")]
	public float UpperPadding;

	// Token: 0x040000EB RID: 235
	[Token(Token = "0x40000EB")]
	[FieldOffset(Offset = "0x1C")]
	public float BottomPadding;

	// Token: 0x040000EC RID: 236
	[Token(Token = "0x40000EC")]
	[FieldOffset(Offset = "0x20")]
	public float Height;
}
