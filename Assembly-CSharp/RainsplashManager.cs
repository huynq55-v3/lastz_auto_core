using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200004C RID: 76
[Token(Token = "0x200004C")]
public class RainsplashManager : MonoBehaviour
{
	// Token: 0x06000105 RID: 261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000105")]
	[Address(RVA = "0x15EE044", Offset = "0x15EE044", VA = "0x15EE044")]
	private void Awake()
	{
	}

	// Token: 0x06000106 RID: 262 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000106")]
	[Address(RVA = "0x15EDE34", Offset = "0x15EDE34", VA = "0x15EDE34")]
	public Mesh GetPreGennedMesh()
	{
		return null;
	}

	// Token: 0x06000107 RID: 263 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000107")]
	[Address(RVA = "0x15EE048", Offset = "0x15EE048", VA = "0x15EE048")]
	private Mesh CreateMesh()
	{
		return null;
	}

	// Token: 0x06000108 RID: 264 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000108")]
	[Address(RVA = "0x15EE850", Offset = "0x15EE850", VA = "0x15EE850")]
	public RainsplashManager()
	{
	}

	// Token: 0x04000192 RID: 402
	[Token(Token = "0x4000192")]
	[FieldOffset(Offset = "0x18")]
	public int numberOfParticles;

	// Token: 0x04000193 RID: 403
	[Token(Token = "0x4000193")]
	[FieldOffset(Offset = "0x1C")]
	public float areaSize;

	// Token: 0x04000194 RID: 404
	[Token(Token = "0x4000194")]
	[FieldOffset(Offset = "0x20")]
	public float areaHeight;

	// Token: 0x04000195 RID: 405
	[Token(Token = "0x4000195")]
	[FieldOffset(Offset = "0x24")]
	public float fallingSpeed;

	// Token: 0x04000196 RID: 406
	[Token(Token = "0x4000196")]
	[FieldOffset(Offset = "0x28")]
	public float flakeWidth;

	// Token: 0x04000197 RID: 407
	[Token(Token = "0x4000197")]
	[FieldOffset(Offset = "0x2C")]
	public float flakeHeight;

	// Token: 0x04000198 RID: 408
	[Token(Token = "0x4000198")]
	[FieldOffset(Offset = "0x30")]
	public float flakeRandom;

	// Token: 0x04000199 RID: 409
	[Token(Token = "0x4000199")]
	[FieldOffset(Offset = "0x38")]
	public Mesh[] preGennedMeshes;

	// Token: 0x0400019A RID: 410
	[Token(Token = "0x400019A")]
	[FieldOffset(Offset = "0x40")]
	private int preGennedIndex;
}
