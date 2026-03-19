using System;
using DG.Tweening;
using Il2CppDummyDll;
using VEngine;

// Token: 0x0200033E RID: 830
[Token(Token = "0x200033E")]
public class DefaultNewButtonCurve
{
	// Token: 0x0600159B RID: 5531 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600159B")]
	[Address(RVA = "0x1ED41CC", Offset = "0x1ED41CC", VA = "0x1ED41CC")]
	public static void LoadDefaultCurve(string curvePath)
	{
	}

	// Token: 0x0600159C RID: 5532 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600159C")]
	[Address(RVA = "0x1ED43A0", Offset = "0x1ED43A0", VA = "0x1ED43A0")]
	public static void ReleaseDefaultCurve()
	{
	}

	// Token: 0x0600159D RID: 5533 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600159D")]
	[Address(RVA = "0x1ED4410", Offset = "0x1ED4410", VA = "0x1ED4410")]
	public DefaultNewButtonCurve()
	{
	}

	// Token: 0x040018B4 RID: 6324
	[Token(Token = "0x40018B4")]
	[FieldOffset(Offset = "0x0")]
	public static UIButtonCurve defaultButtonCurve;

	// Token: 0x040018B5 RID: 6325
	[Token(Token = "0x40018B5")]
	[FieldOffset(Offset = "0x8")]
	public static EaseFunction defaultPressedEase;

	// Token: 0x040018B6 RID: 6326
	[Token(Token = "0x40018B6")]
	[FieldOffset(Offset = "0x10")]
	public static EaseFunction defaultOtherEase;

	// Token: 0x040018B7 RID: 6327
	[Token(Token = "0x40018B7")]
	[FieldOffset(Offset = "0x18")]
	public static Asset reqAsset;
}
