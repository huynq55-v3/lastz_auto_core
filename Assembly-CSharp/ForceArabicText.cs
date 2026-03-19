using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200032F RID: 815
[Token(Token = "0x200032F")]
public class ForceArabicText : MonoBehaviour
{
	// Token: 0x06001562 RID: 5474 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001562")]
	[Address(RVA = "0x1ED1420", Offset = "0x1ED1420", VA = "0x1ED1420")]
	private void Start()
	{
	}

	// Token: 0x06001563 RID: 5475 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001563")]
	[Address(RVA = "0x1ED1424", Offset = "0x1ED1424", VA = "0x1ED1424")]
	private void Update()
	{
	}

	// Token: 0x06001564 RID: 5476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001564")]
	[Address(RVA = "0x1ED1428", Offset = "0x1ED1428", VA = "0x1ED1428")]
	public ForceArabicText()
	{
	}

	// Token: 0x04001859 RID: 6233
	[Token(Token = "0x4001859")]
	[FieldOffset(Offset = "0x18")]
	public TextAnchor ArabicLangForceAlign;

	// Token: 0x0400185A RID: 6234
	[Token(Token = "0x400185A")]
	[FieldOffset(Offset = "0x1C")]
	public TextAnchor NonArabicLangForceAlign;

	// Token: 0x0400185B RID: 6235
	[Token(Token = "0x400185B")]
	[FieldOffset(Offset = "0x20")]
	public Material ArabicTMProFontMaterial;

	// Token: 0x0400185C RID: 6236
	[Token(Token = "0x400185C")]
	[FieldOffset(Offset = "0x28")]
	public bool IsArabicDisableBoldFont;

	// Token: 0x0400185D RID: 6237
	[Token(Token = "0x400185D")]
	[FieldOffset(Offset = "0x29")]
	public bool IsReverseImage;
}
