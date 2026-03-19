using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200028D RID: 653
[Token(Token = "0x200028D")]
[RequireComponent(typeof(CanvasRenderer))]
public class MeshImage : MaskableGraphic
{
	// Token: 0x170001F5 RID: 501
	// (get) Token: 0x06001148 RID: 4424 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001F5")]
	public override Texture mainTexture
	{
		[Token(Token = "0x6001148")]
		[Address(RVA = "0x1C4ECC4", Offset = "0x1C4ECC4", VA = "0x1C4ECC4", Slot = "35")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001149 RID: 4425 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001149")]
	[Address(RVA = "0x1C4ECCC", Offset = "0x1C4ECCC", VA = "0x1C4ECCC", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}

	// Token: 0x0600114A RID: 4426 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600114A")]
	[Address(RVA = "0x1C4F2E4", Offset = "0x1C4F2E4", VA = "0x1C4F2E4")]
	public MeshImage()
	{
	}

	// Token: 0x04001408 RID: 5128
	[Token(Token = "0x4001408")]
	[FieldOffset(Offset = "0xD0")]
	public Vector3 overridePostion;

	// Token: 0x04001409 RID: 5129
	[Token(Token = "0x4001409")]
	[FieldOffset(Offset = "0xDC")]
	public Vector3 overrideRotation;

	// Token: 0x0400140A RID: 5130
	[Token(Token = "0x400140A")]
	[FieldOffset(Offset = "0xE8")]
	public Vector3 overrideScale;

	// Token: 0x0400140B RID: 5131
	[Token(Token = "0x400140B")]
	[FieldOffset(Offset = "0xF8")]
	public Texture texture;

	// Token: 0x0400140C RID: 5132
	[Token(Token = "0x400140C")]
	[FieldOffset(Offset = "0x100")]
	public Mesh mesh;
}
