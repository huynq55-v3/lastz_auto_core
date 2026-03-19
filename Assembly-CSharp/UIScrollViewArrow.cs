using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200035B RID: 859
[Token(Token = "0x200035B")]
public class UIScrollViewArrow : MonoBehaviour
{
	// Token: 0x0600161A RID: 5658 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600161A")]
	[Address(RVA = "0x1EDAE20", Offset = "0x1EDAE20", VA = "0x1EDAE20")]
	private void Awake()
	{
	}

	// Token: 0x0600161B RID: 5659 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600161B")]
	[Address(RVA = "0x1EDAF08", Offset = "0x1EDAF08", VA = "0x1EDAF08")]
	private void ResetSize()
	{
	}

	// Token: 0x0600161C RID: 5660 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600161C")]
	[Address(RVA = "0x1EDB298", Offset = "0x1EDB298", VA = "0x1EDB298")]
	private void Update()
	{
	}

	// Token: 0x0600161D RID: 5661 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600161D")]
	[Address(RVA = "0x1EDB4FC", Offset = "0x1EDB4FC", VA = "0x1EDB4FC")]
	public UIScrollViewArrow()
	{
	}

	// Token: 0x0400193F RID: 6463
	[Token(Token = "0x400193F")]
	[FieldOffset(Offset = "0x18")]
	public GameObject upTarget;

	// Token: 0x04001940 RID: 6464
	[Token(Token = "0x4001940")]
	[FieldOffset(Offset = "0x20")]
	public GameObject downTarget;

	// Token: 0x04001941 RID: 6465
	[Token(Token = "0x4001941")]
	[FieldOffset(Offset = "0x28")]
	private ScrollView scroll;

	// Token: 0x04001942 RID: 6466
	[Token(Token = "0x4001942")]
	[FieldOffset(Offset = "0x30")]
	private RectTransform scrollrect;

	// Token: 0x04001943 RID: 6467
	[Token(Token = "0x4001943")]
	[FieldOffset(Offset = "0x38")]
	private float max;

	// Token: 0x04001944 RID: 6468
	[Token(Token = "0x4001944")]
	[FieldOffset(Offset = "0x3C")]
	private float min;

	// Token: 0x04001945 RID: 6469
	[Token(Token = "0x4001945")]
	[FieldOffset(Offset = "0x40")]
	private float cachedsize;
}
