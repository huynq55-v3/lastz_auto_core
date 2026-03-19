using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000065 RID: 101
[Token(Token = "0x2000065")]
public class WallControll : MonoBehaviour
{
	// Token: 0x0600026C RID: 620 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600026C")]
	[Address(RVA = "0x32058C4", Offset = "0x32058C4", VA = "0x32058C4")]
	public static WallControll GetInstance()
	{
		return null;
	}

	// Token: 0x0600026D RID: 621 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600026D")]
	[Address(RVA = "0x320590C", Offset = "0x320590C", VA = "0x320590C")]
	private void Awake()
	{
	}

	// Token: 0x0600026E RID: 622 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600026E")]
	[Address(RVA = "0x32059A4", Offset = "0x32059A4", VA = "0x32059A4")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600026F RID: 623 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600026F")]
	[Address(RVA = "0x32059F8", Offset = "0x32059F8", VA = "0x32059F8")]
	private void Start()
	{
	}

	// Token: 0x06000270 RID: 624 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000270")]
	[Address(RVA = "0x3205A00", Offset = "0x3205A00", VA = "0x3205A00")]
	private void UpdateMaterial()
	{
	}

	// Token: 0x06000271 RID: 625 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000271")]
	[Address(RVA = "0x32059FC", Offset = "0x32059FC", VA = "0x32059FC")]
	private void OnUpdate()
	{
	}

	// Token: 0x06000272 RID: 626 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000272")]
	[Address(RVA = "0x3205A68", Offset = "0x3205A68", VA = "0x3205A68")]
	private void Update()
	{
	}

	// Token: 0x06000273 RID: 627 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000273")]
	[Address(RVA = "0x3205ABC", Offset = "0x3205ABC", VA = "0x3205ABC")]
	private void OnApplicationQuit()
	{
	}

	// Token: 0x06000274 RID: 628 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000274")]
	[Address(RVA = "0x3205AC0", Offset = "0x3205AC0", VA = "0x3205AC0")]
	public WallControll()
	{
	}

	// Token: 0x04000213 RID: 531
	[Token(Token = "0x4000213")]
	[FieldOffset(Offset = "0x0")]
	private static WallControll instance;

	// Token: 0x04000214 RID: 532
	[Token(Token = "0x4000214")]
	[FieldOffset(Offset = "0x18")]
	public float wallSphereRadius;

	// Token: 0x04000215 RID: 533
	[Token(Token = "0x4000215")]
	[FieldOffset(Offset = "0x20")]
	public Texture2D wallNoise;

	// Token: 0x04000216 RID: 534
	[Token(Token = "0x4000216")]
	[FieldOffset(Offset = "0x28")]
	public float borderHigh;

	// Token: 0x04000217 RID: 535
	[Token(Token = "0x4000217")]
	[FieldOffset(Offset = "0x2C")]
	public float borderScale;

	// Token: 0x04000218 RID: 536
	[Token(Token = "0x4000218")]
	[FieldOffset(Offset = "0x30")]
	public float noisePower;

	// Token: 0x04000219 RID: 537
	[Token(Token = "0x4000219")]
	[FieldOffset(Offset = "0x34")]
	public Vector2 noiseTilingScale;

	// Token: 0x0400021A RID: 538
	[Token(Token = "0x400021A")]
	[FieldOffset(Offset = "0x40")]
	private Camera camera;

	// Token: 0x0400021B RID: 539
	[Token(Token = "0x400021B")]
	[FieldOffset(Offset = "0x48")]
	private int _WallNoise;

	// Token: 0x0400021C RID: 540
	[Token(Token = "0x400021C")]
	[FieldOffset(Offset = "0x4C")]
	private int _CameraPosition;

	// Token: 0x0400021D RID: 541
	[Token(Token = "0x400021D")]
	[FieldOffset(Offset = "0x50")]
	private int _WallSphereRadius;

	// Token: 0x0400021E RID: 542
	[Token(Token = "0x400021E")]
	[FieldOffset(Offset = "0x54")]
	private int _BorderHigh;

	// Token: 0x0400021F RID: 543
	[Token(Token = "0x400021F")]
	[FieldOffset(Offset = "0x58")]
	private int _BorderScale;

	// Token: 0x04000220 RID: 544
	[Token(Token = "0x4000220")]
	[FieldOffset(Offset = "0x5C")]
	private int _NoisePower;

	// Token: 0x04000221 RID: 545
	[Token(Token = "0x4000221")]
	[FieldOffset(Offset = "0x60")]
	private int _NoiseTilingScale;

	// Token: 0x04000222 RID: 546
	[Token(Token = "0x4000222")]
	[FieldOffset(Offset = "0x64")]
	public bool needUpdate;
}
