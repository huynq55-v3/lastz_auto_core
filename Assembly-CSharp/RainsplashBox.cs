using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200004B RID: 75
[Token(Token = "0x200004B")]
public class RainsplashBox : MonoBehaviour
{
	// Token: 0x06000100 RID: 256 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000100")]
	[Address(RVA = "0x15EDC70", Offset = "0x15EDC70", VA = "0x15EDC70")]
	public void Start()
	{
	}

	// Token: 0x06000101 RID: 257 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000101")]
	[Address(RVA = "0x15EDE78", Offset = "0x15EDE78", VA = "0x15EDE78")]
	private void OnBecameVisible()
	{
	}

	// Token: 0x06000102 RID: 258 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000102")]
	[Address(RVA = "0x15EDE84", Offset = "0x15EDE84", VA = "0x15EDE84")]
	private void OnBecameInvisible()
	{
	}

	// Token: 0x06000103 RID: 259 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000103")]
	[Address(RVA = "0x15EDE90", Offset = "0x15EDE90", VA = "0x15EDE90")]
	private void OnDrawGizmos()
	{
	}

	// Token: 0x06000104 RID: 260 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000104")]
	[Address(RVA = "0x15EE03C", Offset = "0x15EE03C", VA = "0x15EE03C")]
	public RainsplashBox()
	{
	}

	// Token: 0x0400018F RID: 399
	[Token(Token = "0x400018F")]
	[FieldOffset(Offset = "0x18")]
	private MeshFilter mf;

	// Token: 0x04000190 RID: 400
	[Token(Token = "0x4000190")]
	[FieldOffset(Offset = "0x20")]
	private Bounds bounds;

	// Token: 0x04000191 RID: 401
	[Token(Token = "0x4000191")]
	[FieldOffset(Offset = "0x38")]
	private RainsplashManager manager;
}
