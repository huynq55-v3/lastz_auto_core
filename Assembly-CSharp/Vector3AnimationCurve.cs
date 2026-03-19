using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000183 RID: 387
[Token(Token = "0x2000183")]
public class Vector3AnimationCurve
{
	// Token: 0x06000B0E RID: 2830 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B0E")]
	[Address(RVA = "0x3723DD4", Offset = "0x3723DD4", VA = "0x3723DD4")]
	public void AddKey(float time, Vector3 vec)
	{
	}

	// Token: 0x06000B0F RID: 2831 RVA: 0x00005718 File Offset: 0x00003918
	[Token(Token = "0x6000B0F")]
	[Address(RVA = "0x3723E40", Offset = "0x3723E40", VA = "0x3723E40")]
	public Vector3 Evaluate(float time)
	{
		return default(Vector3);
	}

	// Token: 0x06000B10 RID: 2832 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B10")]
	[Address(RVA = "0x3723EB4", Offset = "0x3723EB4", VA = "0x3723EB4")]
	public Vector3AnimationCurve()
	{
	}

	// Token: 0x040007D8 RID: 2008
	[Token(Token = "0x40007D8")]
	[FieldOffset(Offset = "0x10")]
	private AnimationCurve curveX;

	// Token: 0x040007D9 RID: 2009
	[Token(Token = "0x40007D9")]
	[FieldOffset(Offset = "0x18")]
	private AnimationCurve curveY;

	// Token: 0x040007DA RID: 2010
	[Token(Token = "0x40007DA")]
	[FieldOffset(Offset = "0x20")]
	private AnimationCurve curveZ;
}
