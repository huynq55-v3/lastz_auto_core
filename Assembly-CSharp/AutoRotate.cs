using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000154 RID: 340
[Token(Token = "0x2000154")]
public class AutoRotate : MonoBehaviour
{
	// Token: 0x060009E5 RID: 2533 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E5")]
	[Address(RVA = "0x33B7430", Offset = "0x33B7430", VA = "0x33B7430")]
	private void Update()
	{
	}

	// Token: 0x060009E6 RID: 2534 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E6")]
	[Address(RVA = "0x33B76BC", Offset = "0x33B76BC", VA = "0x33B76BC")]
	public AutoRotate()
	{
	}

	// Token: 0x0400073E RID: 1854
	[Token(Token = "0x400073E")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 m_rotateSpeed;

	// Token: 0x0400073F RID: 1855
	[Token(Token = "0x400073F")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 m_startScale;

	// Token: 0x04000740 RID: 1856
	[Token(Token = "0x4000740")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 m_endScale;

	// Token: 0x04000741 RID: 1857
	[Token(Token = "0x4000741")]
	[FieldOffset(Offset = "0x3C")]
	public float m_scaleTime;

	// Token: 0x04000742 RID: 1858
	[Token(Token = "0x4000742")]
	[FieldOffset(Offset = "0x40")]
	private float m_scaleTimer;
}
