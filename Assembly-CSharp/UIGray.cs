using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000137 RID: 311
[Token(Token = "0x2000137")]
public static class UIGray
{
	// Token: 0x060008FF RID: 2303 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008FF")]
	[Address(RVA = "0x33ACAF0", Offset = "0x33ACAF0", VA = "0x33ACAF0")]
	private static Material GetGraySpriteRenderer()
	{
		return null;
	}

	// Token: 0x06000900 RID: 2304 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000900")]
	[Address(RVA = "0x33ACC94", Offset = "0x33ACC94", VA = "0x33ACC94")]
	private static Material GetNormalSpriteRenderer()
	{
		return null;
	}

	// Token: 0x06000901 RID: 2305 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000901")]
	[Address(RVA = "0x33ACE38", Offset = "0x33ACE38", VA = "0x33ACE38")]
	private static Material GetEtc1GrayMaterial()
	{
		return null;
	}

	// Token: 0x06000902 RID: 2306 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000902")]
	[Address(RVA = "0x33ACFD4", Offset = "0x33ACFD4", VA = "0x33ACFD4")]
	private static Material GetNormalGrayMaterial()
	{
		return null;
	}

	// Token: 0x06000903 RID: 2307 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000903")]
	[Address(RVA = "0x33AD200", Offset = "0x33AD200", VA = "0x33AD200")]
	public static void DoCheckAfterSetSprite(Image image)
	{
	}

	// Token: 0x06000904 RID: 2308 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000904")]
	[Address(RVA = "0x33AD4D8", Offset = "0x33AD4D8", VA = "0x33AD4D8")]
	public static void SetGray(Transform parent, bool bGray, bool canClick = false, bool withGraphic = false)
	{
	}

	// Token: 0x06000905 RID: 2309 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000905")]
	[Address(RVA = "0x33AD7E8", Offset = "0x33AD7E8", VA = "0x33AD7E8")]
	public static void SetGrayWithIgnore(Transform parent, bool bGray, string ignoreName)
	{
	}

	// Token: 0x06000906 RID: 2310 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000906")]
	[Address(RVA = "0x33AD998", Offset = "0x33AD998", VA = "0x33AD998")]
	public static void SetGraySpriteRender(Transform parent, bool bGray)
	{
	}

	// Token: 0x06000907 RID: 2311 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000907")]
	[Address(RVA = "0x33ADA94", Offset = "0x33ADA94", VA = "0x33ADA94")]
	public static void SetGrayNotRecursively(Image image, bool bGray)
	{
	}

	// Token: 0x06000908 RID: 2312 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000908")]
	[Address(RVA = "0x33ADBA4", Offset = "0x33ADBA4", VA = "0x33ADBA4")]
	private static void SetGraphicGray(Graphic graphic)
	{
	}

	// Token: 0x06000909 RID: 2313 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000909")]
	[Address(RVA = "0x33ADD50", Offset = "0x33ADD50", VA = "0x33ADD50")]
	public static void SetGraphicGrayRecursively(Transform parent)
	{
	}

	// Token: 0x0600090A RID: 2314 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600090A")]
	[Address(RVA = "0x33ADDE8", Offset = "0x33ADDE8", VA = "0x33ADDE8")]
	public static void SetGraphicGrayRecursivelyWithIgnore(Transform parent, string ignore)
	{
	}

	// Token: 0x040006C3 RID: 1731
	[Token(Token = "0x40006C3")]
	[FieldOffset(Offset = "0x0")]
	private static Material grayMat;

	// Token: 0x040006C4 RID: 1732
	[Token(Token = "0x40006C4")]
	[FieldOffset(Offset = "0x8")]
	private static Material etc1GrayMat;

	// Token: 0x040006C5 RID: 1733
	[Token(Token = "0x40006C5")]
	[FieldOffset(Offset = "0x10")]
	private static Material matSpriteRdGray;

	// Token: 0x040006C6 RID: 1734
	[Token(Token = "0x40006C6")]
	[FieldOffset(Offset = "0x18")]
	private static Material matSpriteRdNormal;

	// Token: 0x040006C7 RID: 1735
	[Token(Token = "0x40006C7")]
	private const string ETC1GrayShaderName = "UI/GrayETC1";

	// Token: 0x040006C8 RID: 1736
	[Token(Token = "0x40006C8")]
	private const string NormalGrayShaderName = "Custom/ImageGray";
}
