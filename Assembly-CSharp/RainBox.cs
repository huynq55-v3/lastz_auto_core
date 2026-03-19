using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000049 RID: 73
[Token(Token = "0x2000049")]
public class RainBox : MonoBehaviour
{
	// Token: 0x060000F6 RID: 246 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x15ECFE0", Offset = "0x15ECFE0", VA = "0x15ECFE0")]
	private void Start()
	{
	}

	// Token: 0x060000F7 RID: 247 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x15ED1E4", Offset = "0x15ED1E4", VA = "0x15ED1E4")]
	private void OnBecameVisible()
	{
	}

	// Token: 0x060000F8 RID: 248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x15ED1F0", Offset = "0x15ED1F0", VA = "0x15ED1F0")]
	private void OnBecameInvisible()
	{
	}

	// Token: 0x060000F9 RID: 249 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x15ED1FC", Offset = "0x15ED1FC", VA = "0x15ED1FC")]
	private void Update()
	{
	}

	// Token: 0x060000FA RID: 250 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x15ED384", Offset = "0x15ED384", VA = "0x15ED384")]
	private void OnDrawGizmos()
	{
	}

	// Token: 0x060000FB RID: 251 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x15ED524", Offset = "0x15ED524", VA = "0x15ED524")]
	public RainBox()
	{
	}

	// Token: 0x0400017E RID: 382
	[Token(Token = "0x400017E")]
	[FieldOffset(Offset = "0x18")]
	private MeshFilter mf;

	// Token: 0x0400017F RID: 383
	[Token(Token = "0x400017F")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 defaultPosition;

	// Token: 0x04000180 RID: 384
	[Token(Token = "0x4000180")]
	[FieldOffset(Offset = "0x2C")]
	private Bounds bounds;

	// Token: 0x04000181 RID: 385
	[Token(Token = "0x4000181")]
	[FieldOffset(Offset = "0x48")]
	private RainManager manager;

	// Token: 0x04000182 RID: 386
	[Token(Token = "0x4000182")]
	[FieldOffset(Offset = "0x50")]
	private Transform cachedTransform;

	// Token: 0x04000183 RID: 387
	[Token(Token = "0x4000183")]
	[FieldOffset(Offset = "0x58")]
	private float cachedMinY;

	// Token: 0x04000184 RID: 388
	[Token(Token = "0x4000184")]
	[FieldOffset(Offset = "0x5C")]
	private float cachedAreaHeight;

	// Token: 0x04000185 RID: 389
	[Token(Token = "0x4000185")]
	[FieldOffset(Offset = "0x60")]
	public float cachedFallingSpeed;
}
