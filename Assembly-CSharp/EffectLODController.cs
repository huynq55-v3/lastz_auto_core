using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000253 RID: 595
[Token(Token = "0x2000253")]
[ExecuteAlways]
public class EffectLODController : MonoBehaviour
{
	// Token: 0x06000FE5 RID: 4069 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FE5")]
	[Address(RVA = "0x1BE8C94", Offset = "0x1BE8C94", VA = "0x1BE8C94")]
	private void Awake()
	{
	}

	// Token: 0x06000FE6 RID: 4070 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FE6")]
	[Address(RVA = "0x1BE8D34", Offset = "0x1BE8D34", VA = "0x1BE8D34")]
	private void Update()
	{
	}

	// Token: 0x06000FE7 RID: 4071 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FE7")]
	[Address(RVA = "0x1BE8E6C", Offset = "0x1BE8E6C", VA = "0x1BE8E6C")]
	private void ApplyLOD(int lod)
	{
	}

	// Token: 0x06000FE8 RID: 4072 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FE8")]
	[Address(RVA = "0x1BE8EB4", Offset = "0x1BE8EB4", VA = "0x1BE8EB4")]
	private static void SetNodesActive(GameObject[] nodes, bool active)
	{
	}

	// Token: 0x06000FE9 RID: 4073 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FE9")]
	[Address(RVA = "0x1BE8FAC", Offset = "0x1BE8FAC", VA = "0x1BE8FAC")]
	public EffectLODController()
	{
	}

	// Token: 0x04001256 RID: 4694
	[Token(Token = "0x4001256")]
	[FieldOffset(Offset = "0x18")]
	[Header("LOD Distance Thresholds")]
	public float LOD0Distance;

	// Token: 0x04001257 RID: 4695
	[Token(Token = "0x4001257")]
	[FieldOffset(Offset = "0x1C")]
	public float LOD1Distance;

	// Token: 0x04001258 RID: 4696
	[Token(Token = "0x4001258")]
	[FieldOffset(Offset = "0x20")]
	public float LOD2Distance;

	// Token: 0x04001259 RID: 4697
	[Token(Token = "0x4001259")]
	[FieldOffset(Offset = "0x28")]
	[Header("LOD Nodes")]
	public GameObject[] LOD0Nodes;

	// Token: 0x0400125A RID: 4698
	[Token(Token = "0x400125A")]
	[FieldOffset(Offset = "0x30")]
	public GameObject[] LOD1Nodes;

	// Token: 0x0400125B RID: 4699
	[Token(Token = "0x400125B")]
	[FieldOffset(Offset = "0x38")]
	public GameObject[] LOD2Nodes;

	// Token: 0x0400125C RID: 4700
	[Token(Token = "0x400125C")]
	[FieldOffset(Offset = "0x40")]
	private Transform camTransform;

	// Token: 0x0400125D RID: 4701
	[Token(Token = "0x400125D")]
	[FieldOffset(Offset = "0x48")]
	private int currentLOD;
}
