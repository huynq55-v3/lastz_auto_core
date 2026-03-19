using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200002D RID: 45
[Token(Token = "0x200002D")]
public class FPD_SuffixAttribute : PropertyAttribute
{
	// Token: 0x06000079 RID: 121 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000079")]
	[Address(RVA = "0x15E5FC0", Offset = "0x15E5FC0", VA = "0x15E5FC0")]
	public FPD_SuffixAttribute(float min, float max, FPD_SuffixAttribute.SuffixMode mode = FPD_SuffixAttribute.SuffixMode.From0to100, string suffix = "%", bool editable = true, int wider = 0)
	{
	}

	// Token: 0x040000ED RID: 237
	[Token(Token = "0x40000ED")]
	[FieldOffset(Offset = "0x10")]
	public readonly float Min;

	// Token: 0x040000EE RID: 238
	[Token(Token = "0x40000EE")]
	[FieldOffset(Offset = "0x14")]
	public readonly float Max;

	// Token: 0x040000EF RID: 239
	[Token(Token = "0x40000EF")]
	[FieldOffset(Offset = "0x18")]
	public readonly FPD_SuffixAttribute.SuffixMode Mode;

	// Token: 0x040000F0 RID: 240
	[Token(Token = "0x40000F0")]
	[FieldOffset(Offset = "0x20")]
	public readonly string Suffix;

	// Token: 0x040000F1 RID: 241
	[Token(Token = "0x40000F1")]
	[FieldOffset(Offset = "0x28")]
	public readonly bool editableValue;

	// Token: 0x040000F2 RID: 242
	[Token(Token = "0x40000F2")]
	[FieldOffset(Offset = "0x2C")]
	public readonly int widerField;

	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	public enum SuffixMode
	{
		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		From0to100,
		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		PercentageUnclamped,
		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		FromMinToMax,
		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		FromMinToMaxRounded
	}
}
