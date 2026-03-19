using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200006C RID: 108
[Token(Token = "0x200006C")]
public static class LayoutHelper
{
	// Token: 0x060002B4 RID: 692 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x320622C", Offset = "0x320622C", VA = "0x320622C")]
	public static void CheckCurLayout()
	{
	}

	// Token: 0x060002B5 RID: 693 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x3206330", Offset = "0x3206330", VA = "0x3206330")]
	public static void SetRotation()
	{
	}

	// Token: 0x060002B6 RID: 694 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x3207160", Offset = "0x3207160", VA = "0x3207160")]
	public static void SetCanvas()
	{
	}

	// Token: 0x060002B7 RID: 695 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x32098B8", Offset = "0x32098B8", VA = "0x32098B8")]
	public static void SetDesignSize(Vector2 size)
	{
	}

	// Token: 0x060002B8 RID: 696 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x32099C8", Offset = "0x32099C8", VA = "0x32099C8")]
	private static void SetUICamera()
	{
	}

	// Token: 0x060002B9 RID: 697 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x3209B00", Offset = "0x3209B00", VA = "0x3209B00")]
	private static void AdjustCamera(Transform camera)
	{
	}

	// Token: 0x04000256 RID: 598
	[Token(Token = "0x4000256")]
	[FieldOffset(Offset = "0x0")]
	private static LayoutHelper.Layout m_layout;

	// Token: 0x04000257 RID: 599
	[Token(Token = "0x4000257")]
	[FieldOffset(Offset = "0x8")]
	private static string Client_isVertical;

	// Token: 0x04000258 RID: 600
	[Token(Token = "0x4000258")]
	[FieldOffset(Offset = "0x10")]
	private static string CACHE_KEY_vertical_version_guidance_switch;

	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200006D")]
	public enum Layout
	{
		// Token: 0x0400025A RID: 602
		[Token(Token = "0x400025A")]
		Landscape,
		// Token: 0x0400025B RID: 603
		[Token(Token = "0x400025B")]
		Portrait
	}
}
