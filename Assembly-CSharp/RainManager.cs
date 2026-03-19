using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200004A RID: 74
[Token(Token = "0x200004A")]
public class RainManager : MonoBehaviour
{
	// Token: 0x060000FC RID: 252 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x15ED534", Offset = "0x15ED534", VA = "0x15ED534")]
	public void Awake()
	{
	}

	// Token: 0x060000FD RID: 253 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x15ED1A0", Offset = "0x15ED1A0", VA = "0x15ED1A0")]
	public Mesh GetPreGennedMesh()
	{
		return null;
	}

	// Token: 0x060000FE RID: 254 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x15ED538", Offset = "0x15ED538", VA = "0x15ED538")]
	private Mesh CreateMesh()
	{
		return null;
	}

	// Token: 0x060000FF RID: 255 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x15EDC40", Offset = "0x15EDC40", VA = "0x15EDC40")]
	public RainManager()
	{
	}

	// Token: 0x04000186 RID: 390
	[Token(Token = "0x4000186")]
	[FieldOffset(Offset = "0x18")]
	public float minYPosition;

	// Token: 0x04000187 RID: 391
	[Token(Token = "0x4000187")]
	[FieldOffset(Offset = "0x1C")]
	public float areaSize;

	// Token: 0x04000188 RID: 392
	[Token(Token = "0x4000188")]
	[FieldOffset(Offset = "0x20")]
	public float areaHeight;

	// Token: 0x04000189 RID: 393
	[Token(Token = "0x4000189")]
	[FieldOffset(Offset = "0x24")]
	public float fallingSpeed;

	// Token: 0x0400018A RID: 394
	[Token(Token = "0x400018A")]
	[FieldOffset(Offset = "0x28")]
	public Mesh[] preGennedMeshes;

	// Token: 0x0400018B RID: 395
	[Token(Token = "0x400018B")]
	[FieldOffset(Offset = "0x30")]
	private int preGennedIndex;

	// Token: 0x0400018C RID: 396
	[Token(Token = "0x400018C")]
	[FieldOffset(Offset = "0x34")]
	public int numberOfParticles;

	// Token: 0x0400018D RID: 397
	[Token(Token = "0x400018D")]
	[FieldOffset(Offset = "0x38")]
	public float particleSize;

	// Token: 0x0400018E RID: 398
	[Token(Token = "0x400018E")]
	[FieldOffset(Offset = "0x3C")]
	public float flakeRandom;
}
