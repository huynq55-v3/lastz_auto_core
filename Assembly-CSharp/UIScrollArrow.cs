using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200035A RID: 858
[Token(Token = "0x200035A")]
public class UIScrollArrow : MonoBehaviour
{
	// Token: 0x06001616 RID: 5654 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001616")]
	[Address(RVA = "0x1EDA728", Offset = "0x1EDA728", VA = "0x1EDA728")]
	private void Awake()
	{
	}

	// Token: 0x06001617 RID: 5655 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001617")]
	[Address(RVA = "0x1EDA810", Offset = "0x1EDA810", VA = "0x1EDA810")]
	private void ResetSize()
	{
	}

	// Token: 0x06001618 RID: 5656 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001618")]
	[Address(RVA = "0x1EDABA4", Offset = "0x1EDABA4", VA = "0x1EDABA4")]
	private void Update()
	{
	}

	// Token: 0x06001619 RID: 5657 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001619")]
	[Address(RVA = "0x1EDAE18", Offset = "0x1EDAE18", VA = "0x1EDAE18")]
	public UIScrollArrow()
	{
	}

	// Token: 0x04001938 RID: 6456
	[Token(Token = "0x4001938")]
	[FieldOffset(Offset = "0x18")]
	public GameObject upTarget;

	// Token: 0x04001939 RID: 6457
	[Token(Token = "0x4001939")]
	[FieldOffset(Offset = "0x20")]
	public GameObject downTarget;

	// Token: 0x0400193A RID: 6458
	[Token(Token = "0x400193A")]
	[FieldOffset(Offset = "0x28")]
	private ScrollRect scroll;

	// Token: 0x0400193B RID: 6459
	[Token(Token = "0x400193B")]
	[FieldOffset(Offset = "0x30")]
	private RectTransform scrollrect;

	// Token: 0x0400193C RID: 6460
	[Token(Token = "0x400193C")]
	[FieldOffset(Offset = "0x38")]
	private float max;

	// Token: 0x0400193D RID: 6461
	[Token(Token = "0x400193D")]
	[FieldOffset(Offset = "0x3C")]
	private float min;

	// Token: 0x0400193E RID: 6462
	[Token(Token = "0x400193E")]
	[FieldOffset(Offset = "0x40")]
	private float cachedsize;
}
