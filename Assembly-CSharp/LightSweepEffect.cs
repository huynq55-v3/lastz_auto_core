using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000090 RID: 144
[Token(Token = "0x2000090")]
public class LightSweepEffect : MonoBehaviour
{
	// Token: 0x06000373 RID: 883 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000373")]
	[Address(RVA = "0x3214A24", Offset = "0x3214A24", VA = "0x3214A24")]
	private void Awake()
	{
	}

	// Token: 0x06000374 RID: 884 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000374")]
	[Address(RVA = "0x3214BBC", Offset = "0x3214BBC", VA = "0x3214BBC")]
	private void Update()
	{
	}

	// Token: 0x06000375 RID: 885 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000375")]
	[Address(RVA = "0x3214C8C", Offset = "0x3214C8C", VA = "0x3214C8C")]
	public LightSweepEffect()
	{
	}

	// Token: 0x040002FC RID: 764
	[Token(Token = "0x40002FC")]
	[FieldOffset(Offset = "0x18")]
	private int propertyId;

	// Token: 0x040002FD RID: 765
	[Token(Token = "0x40002FD")]
	[FieldOffset(Offset = "0x20")]
	private Material lightSweepMat;

	// Token: 0x040002FE RID: 766
	[Token(Token = "0x40002FE")]
	[FieldOffset(Offset = "0x28")]
	private Vector4 _UV;

	// Token: 0x040002FF RID: 767
	[Token(Token = "0x40002FF")]
	[FieldOffset(Offset = "0x38")]
	public float speed;

	// Token: 0x04000300 RID: 768
	[Token(Token = "0x4000300")]
	[FieldOffset(Offset = "0x3C")]
	public Vector2 range;

	// Token: 0x04000301 RID: 769
	[Token(Token = "0x4000301")]
	[FieldOffset(Offset = "0x44")]
	private float curOffset;
}
