using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200009F RID: 159
[Token(Token = "0x200009F")]
[RequireComponent(typeof(SpriteMask))]
public class SpriteMaskSetUp : UIParticleSetUpBase
{
	// Token: 0x060003B1 RID: 945 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x3217360", Offset = "0x3217360", VA = "0x3217360")]
	private void Awake()
	{
	}

	// Token: 0x060003B2 RID: 946 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x32173B8", Offset = "0x32173B8", VA = "0x32173B8")]
	private void OnEnable()
	{
	}

	// Token: 0x060003B3 RID: 947 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x3217420", Offset = "0x3217420", VA = "0x3217420")]
	public new void Refresh()
	{
	}

	// Token: 0x060003B4 RID: 948 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x32176B8", Offset = "0x32176B8", VA = "0x32176B8")]
	public void AutoMatchByTarget()
	{
	}

	// Token: 0x060003B5 RID: 949 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x32178C0", Offset = "0x32178C0", VA = "0x32178C0")]
	public SpriteMaskSetUp()
	{
	}

	// Token: 0x0400034D RID: 845
	[Token(Token = "0x400034D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public bool AutoMatch;

	// Token: 0x0400034E RID: 846
	[Token(Token = "0x400034E")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform targetRectTransform;

	// Token: 0x0400034F RID: 847
	[Token(Token = "0x400034F")]
	[FieldOffset(Offset = "0x28")]
	public int parentSortingOrder;

	// Token: 0x04000350 RID: 848
	[Token(Token = "0x4000350")]
	[FieldOffset(Offset = "0x30")]
	private Canvas _parentCanvas;

	// Token: 0x04000351 RID: 849
	[Token(Token = "0x4000351")]
	[FieldOffset(Offset = "0x38")]
	public bool Local;

	// Token: 0x04000352 RID: 850
	[Token(Token = "0x4000352")]
	[FieldOffset(Offset = "0x3C")]
	public Vector2Int Range;

	// Token: 0x04000353 RID: 851
	[Token(Token = "0x4000353")]
	[FieldOffset(Offset = "0x48")]
	private SpriteMask _spriteMask;
}
