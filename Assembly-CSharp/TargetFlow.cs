using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200036F RID: 879
[Token(Token = "0x200036F")]
public class TargetFlow : MonoBehaviour
{
	// Token: 0x06001679 RID: 5753 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001679")]
	[Address(RVA = "0x1EDFDE0", Offset = "0x1EDFDE0", VA = "0x1EDFDE0")]
	private void Awake()
	{
	}

	// Token: 0x0600167A RID: 5754 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600167A")]
	[Address(RVA = "0x1EDFE04", Offset = "0x1EDFE04", VA = "0x1EDFE04")]
	private void Start()
	{
	}

	// Token: 0x0600167B RID: 5755 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600167B")]
	[Address(RVA = "0x1EDFE08", Offset = "0x1EDFE08", VA = "0x1EDFE08")]
	private void DoFlow()
	{
	}

	// Token: 0x0600167C RID: 5756 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600167C")]
	[Address(RVA = "0x1EE0168", Offset = "0x1EE0168", VA = "0x1EE0168")]
	public void DoFlowAnim(float deltaTime)
	{
	}

	// Token: 0x0600167D RID: 5757 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600167D")]
	[Address(RVA = "0x1EE025C", Offset = "0x1EE025C", VA = "0x1EE025C")]
	private void SetRotation(float percent)
	{
	}

	// Token: 0x0600167E RID: 5758 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600167E")]
	[Address(RVA = "0x1EE05C0", Offset = "0x1EE05C0", VA = "0x1EE05C0")]
	public void Update()
	{
	}

	// Token: 0x0600167F RID: 5759 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600167F")]
	[Address(RVA = "0x1EE0628", Offset = "0x1EE0628", VA = "0x1EE0628")]
	public TargetFlow()
	{
	}

	// Token: 0x040019A6 RID: 6566
	[Token(Token = "0x40019A6")]
	[FieldOffset(Offset = "0x18")]
	public GameObject drawPoint;

	// Token: 0x040019A7 RID: 6567
	[Token(Token = "0x40019A7")]
	[FieldOffset(Offset = "0x20")]
	public LineRenderer render;

	// Token: 0x040019A8 RID: 6568
	[Token(Token = "0x40019A8")]
	[FieldOffset(Offset = "0x28")]
	public Transform target;

	// Token: 0x040019A9 RID: 6569
	[Token(Token = "0x40019A9")]
	[FieldOffset(Offset = "0x30")]
	public float zOffset;

	// Token: 0x040019AA RID: 6570
	[Token(Token = "0x40019AA")]
	[FieldOffset(Offset = "0x34")]
	public float xOffset;

	// Token: 0x040019AB RID: 6571
	[Token(Token = "0x40019AB")]
	[FieldOffset(Offset = "0x38")]
	public Color lineColor;

	// Token: 0x040019AC RID: 6572
	[Token(Token = "0x40019AC")]
	[FieldOffset(Offset = "0x48")]
	public float maxYoffset;

	// Token: 0x040019AD RID: 6573
	[Token(Token = "0x40019AD")]
	[FieldOffset(Offset = "0x4C")]
	public float minYoffset;

	// Token: 0x040019AE RID: 6574
	[Token(Token = "0x40019AE")]
	[FieldOffset(Offset = "0x50")]
	private bool toggleShowLine;

	// Token: 0x040019AF RID: 6575
	[Token(Token = "0x40019AF")]
	[FieldOffset(Offset = "0x58")]
	private Transform tran;

	// Token: 0x040019B0 RID: 6576
	[Token(Token = "0x40019B0")]
	[FieldOffset(Offset = "0x60")]
	public Transform _a;

	// Token: 0x040019B1 RID: 6577
	[Token(Token = "0x40019B1")]
	[FieldOffset(Offset = "0x68")]
	public Transform _b;

	// Token: 0x040019B2 RID: 6578
	[Token(Token = "0x40019B2")]
	[FieldOffset(Offset = "0x70")]
	private bool doAnim;

	// Token: 0x040019B3 RID: 6579
	[Token(Token = "0x40019B3")]
	[FieldOffset(Offset = "0x74")]
	private float startTime;

	// Token: 0x040019B4 RID: 6580
	[Token(Token = "0x40019B4")]
	[FieldOffset(Offset = "0x78")]
	private float continueTime;
}
