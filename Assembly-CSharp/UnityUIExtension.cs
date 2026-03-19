using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using VEngine;

// Token: 0x020001D4 RID: 468
[Token(Token = "0x20001D4")]
public static class UnityUIExtension
{
	// Token: 0x06000C45 RID: 3141 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C45")]
	[Address(RVA = "0x12C3490", Offset = "0x12C3490", VA = "0x12C3490")]
	public static void LoadSprite(this Image image, string spritePath, [Optional] string defaultSprite)
	{
	}

	// Token: 0x06000C46 RID: 3142 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C46")]
	[Address(RVA = "0x12C3800", Offset = "0x12C3800", VA = "0x12C3800")]
	public static void LoadSprite(this CircleImage image, string spritePath, [Optional] string defaultSprite)
	{
	}

	// Token: 0x06000C47 RID: 3143 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C47")]
	[Address(RVA = "0x12C39B8", Offset = "0x12C39B8", VA = "0x12C39B8")]
	public static void LoadSprite(this SpriteRenderer spriteRenderer, string spritePath, [Optional] string defaultSprite)
	{
	}

	// Token: 0x06000C48 RID: 3144 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C48")]
	[Address(RVA = "0x12C3B70", Offset = "0x12C3B70", VA = "0x12C3B70")]
	public static void LoadSprite(this SpriteMask spriteMask, string spritePath, [Optional] string defaultSprite)
	{
	}

	// Token: 0x06000C49 RID: 3145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C49")]
	[Address(RVA = "0x12C3D28", Offset = "0x12C3D28", VA = "0x12C3D28")]
	public static void LoadSprite(this SpriteMeshRenderer meshRenderer, string spritePath, [Optional] string defaultSprite)
	{
	}

	// Token: 0x06000C4A RID: 3146 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C4A")]
	[Address(RVA = "0x12C1848", Offset = "0x12C1848", VA = "0x12C1848")]
	public static void Update()
	{
	}

	// Token: 0x06000C4B RID: 3147 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C4B")]
	[Address(RVA = "0x12C3648", Offset = "0x12C3648", VA = "0x12C3648")]
	private static Asset LoadSprite(string spritePath, string defaultSprite)
	{
		return null;
	}

	// Token: 0x06000C4C RID: 3148 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C4C")]
	[Address(RVA = "0x12C3EE0", Offset = "0x12C3EE0", VA = "0x12C3EE0")]
	public static void SetHorizontalNormalizedPosition(this ScrollRect scrollRect, float ratio)
	{
	}

	// Token: 0x06000C4D RID: 3149 RVA: 0x00005B80 File Offset: 0x00003D80
	[Token(Token = "0x6000C4D")]
	[Address(RVA = "0x12C3EF4", Offset = "0x12C3EF4", VA = "0x12C3EF4")]
	public static float GetHorizontalNormalizedPosition(this ScrollRect scrollRect)
	{
		return 0f;
	}

	// Token: 0x04001059 RID: 4185
	[Token(Token = "0x4001059")]
	[FieldOffset(Offset = "0x0")]
	private static List<Object> keyToRemove;

	// Token: 0x0400105A RID: 4186
	[Token(Token = "0x400105A")]
	[FieldOffset(Offset = "0x8")]
	private static readonly Dictionary<Object, Asset> AllRefs;
}
