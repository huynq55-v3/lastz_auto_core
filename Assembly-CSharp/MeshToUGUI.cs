using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000260 RID: 608
[Token(Token = "0x2000260")]
[RequireComponent(typeof(CanvasRenderer))]
public class MeshToUGUI : MaskableGraphic
{
	// Token: 0x06001029 RID: 4137 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001029")]
	[Address(RVA = "0x1BEB0FC", Offset = "0x1BEB0FC", VA = "0x1BEB0FC", Slot = "5")]
	protected override void OnEnable()
	{
	}

	// Token: 0x170001DF RID: 479
	// (get) Token: 0x0600102A RID: 4138 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600102B RID: 4139 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001DF")]
	public override Material material
	{
		[Token(Token = "0x600102A")]
		[Address(RVA = "0x1BEB100", Offset = "0x1BEB100", VA = "0x1BEB100", Slot = "32")]
		get
		{
			return null;
		}
		[Token(Token = "0x600102B")]
		[Address(RVA = "0x1BEB108", Offset = "0x1BEB108", VA = "0x1BEB108", Slot = "33")]
		set
		{
		}
	}

	// Token: 0x170001E0 RID: 480
	// (get) Token: 0x0600102C RID: 4140 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001E0")]
	public override Texture mainTexture
	{
		[Token(Token = "0x600102C")]
		[Address(RVA = "0x1BEB110", Offset = "0x1BEB110", VA = "0x1BEB110", Slot = "35")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600102D RID: 4141 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600102D")]
	[Address(RVA = "0x1BEB118", Offset = "0x1BEB118", VA = "0x1BEB118", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}

	// Token: 0x0600102E RID: 4142 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600102E")]
	[Address(RVA = "0x1BEB7F0", Offset = "0x1BEB7F0", VA = "0x1BEB7F0")]
	public MeshToUGUI()
	{
	}

	// Token: 0x040012A2 RID: 4770
	[Token(Token = "0x40012A2")]
	[FieldOffset(Offset = "0xD0")]
	public Vector3 overridePostion;

	// Token: 0x040012A3 RID: 4771
	[Token(Token = "0x40012A3")]
	[FieldOffset(Offset = "0xDC")]
	public Vector3 overrideRotation;

	// Token: 0x040012A4 RID: 4772
	[Token(Token = "0x40012A4")]
	[FieldOffset(Offset = "0xE8")]
	public Vector3 overrideScale;

	// Token: 0x040012A5 RID: 4773
	[Token(Token = "0x40012A5")]
	[FieldOffset(Offset = "0xF8")]
	public Texture texture;

	// Token: 0x040012A6 RID: 4774
	[Token(Token = "0x40012A6")]
	[FieldOffset(Offset = "0x100")]
	public Mesh mesh;
}
