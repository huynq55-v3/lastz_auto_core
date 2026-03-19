using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000109 RID: 265
[Token(Token = "0x2000109")]
public class DynamicRect
{
	// Token: 0x0600077F RID: 1919 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600077F")]
	[Address(RVA = "0x3479478", Offset = "0x3479478", VA = "0x3479478")]
	public DynamicRect(float x, float y, float width, float height, int index)
	{
	}

	// Token: 0x06000780 RID: 1920 RVA: 0x000046C8 File Offset: 0x000028C8
	[Token(Token = "0x6000780")]
	[Address(RVA = "0x34794F0", Offset = "0x34794F0", VA = "0x34794F0")]
	public bool Overlaps(DynamicRect otherRect)
	{
		return default(bool);
	}

	// Token: 0x06000781 RID: 1921 RVA: 0x000046E0 File Offset: 0x000028E0
	[Token(Token = "0x6000781")]
	[Address(RVA = "0x3479514", Offset = "0x3479514", VA = "0x3479514")]
	public bool Overlaps(Rect otherRect)
	{
		return default(bool);
	}

	// Token: 0x06000782 RID: 1922 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000782")]
	[Address(RVA = "0x3479520", Offset = "0x3479520", VA = "0x3479520", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x0400057C RID: 1404
	[Token(Token = "0x400057C")]
	[FieldOffset(Offset = "0x10")]
	private Rect mRect;

	// Token: 0x0400057D RID: 1405
	[Token(Token = "0x400057D")]
	[FieldOffset(Offset = "0x20")]
	public int Index;
}
