using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000155 RID: 341
[Token(Token = "0x2000155")]
[Serializable]
public class Bezier
{
	// Token: 0x060009E7 RID: 2535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E7")]
	[Address(RVA = "0x33B771C", Offset = "0x33B771C", VA = "0x33B771C")]
	public Bezier(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3)
	{
	}

	// Token: 0x060009E8 RID: 2536 RVA: 0x000050B8 File Offset: 0x000032B8
	[Token(Token = "0x60009E8")]
	[Address(RVA = "0x33B7834", Offset = "0x33B7834", VA = "0x33B7834")]
	public Vector3 GetPointAtTime(float t)
	{
		return default(Vector3);
	}

	// Token: 0x060009E9 RID: 2537 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E9")]
	[Address(RVA = "0x33B79E4", Offset = "0x33B79E4", VA = "0x33B79E4")]
	private void SetConstant()
	{
	}

	// Token: 0x060009EA RID: 2538 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009EA")]
	[Address(RVA = "0x33B78B4", Offset = "0x33B78B4", VA = "0x33B78B4")]
	private void CheckConstant()
	{
	}

	// Token: 0x04000743 RID: 1859
	[Token(Token = "0x4000743")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 p0;

	// Token: 0x04000744 RID: 1860
	[Token(Token = "0x4000744")]
	[FieldOffset(Offset = "0x1C")]
	public Vector3 p1;

	// Token: 0x04000745 RID: 1861
	[Token(Token = "0x4000745")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 p2;

	// Token: 0x04000746 RID: 1862
	[Token(Token = "0x4000746")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 p3;

	// Token: 0x04000747 RID: 1863
	[Token(Token = "0x4000747")]
	[FieldOffset(Offset = "0x40")]
	public float ti;

	// Token: 0x04000748 RID: 1864
	[Token(Token = "0x4000748")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 b0;

	// Token: 0x04000749 RID: 1865
	[Token(Token = "0x4000749")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 b1;

	// Token: 0x0400074A RID: 1866
	[Token(Token = "0x400074A")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 b2;

	// Token: 0x0400074B RID: 1867
	[Token(Token = "0x400074B")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 b3;

	// Token: 0x0400074C RID: 1868
	[Token(Token = "0x400074C")]
	[FieldOffset(Offset = "0x74")]
	private float Ax;

	// Token: 0x0400074D RID: 1869
	[Token(Token = "0x400074D")]
	[FieldOffset(Offset = "0x78")]
	private float Ay;

	// Token: 0x0400074E RID: 1870
	[Token(Token = "0x400074E")]
	[FieldOffset(Offset = "0x7C")]
	private float Az;

	// Token: 0x0400074F RID: 1871
	[Token(Token = "0x400074F")]
	[FieldOffset(Offset = "0x80")]
	private float Bx;

	// Token: 0x04000750 RID: 1872
	[Token(Token = "0x4000750")]
	[FieldOffset(Offset = "0x84")]
	private float By;

	// Token: 0x04000751 RID: 1873
	[Token(Token = "0x4000751")]
	[FieldOffset(Offset = "0x88")]
	private float Bz;

	// Token: 0x04000752 RID: 1874
	[Token(Token = "0x4000752")]
	[FieldOffset(Offset = "0x8C")]
	private float Cx;

	// Token: 0x04000753 RID: 1875
	[Token(Token = "0x4000753")]
	[FieldOffset(Offset = "0x90")]
	private float Cy;

	// Token: 0x04000754 RID: 1876
	[Token(Token = "0x4000754")]
	[FieldOffset(Offset = "0x94")]
	private float Cz;
}
