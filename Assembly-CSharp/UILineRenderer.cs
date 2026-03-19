using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000138 RID: 312
[Token(Token = "0x2000138")]
public class UILineRenderer : MaskableGraphic
{
	// Token: 0x1700013B RID: 315
	// (get) Token: 0x0600090B RID: 2315 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700013B")]
	public override Texture mainTexture
	{
		[Token(Token = "0x600090B")]
		[Address(RVA = "0x33ADEAC", Offset = "0x33ADEAC", VA = "0x33ADEAC", Slot = "35")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700013C RID: 316
	// (get) Token: 0x0600090C RID: 2316 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600090D RID: 2317 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700013C")]
	public Texture texture
	{
		[Token(Token = "0x600090C")]
		[Address(RVA = "0x33ADF48", Offset = "0x33ADF48", VA = "0x33ADF48")]
		get
		{
			return null;
		}
		[Token(Token = "0x600090D")]
		[Address(RVA = "0x33ADF50", Offset = "0x33ADF50", VA = "0x33ADF50")]
		set
		{
		}
	}

	// Token: 0x1700013D RID: 317
	// (get) Token: 0x0600090E RID: 2318 RVA: 0x00004DE8 File Offset: 0x00002FE8
	// (set) Token: 0x0600090F RID: 2319 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700013D")]
	public Rect uvRect
	{
		[Token(Token = "0x600090E")]
		[Address(RVA = "0x33AE00C", Offset = "0x33AE00C", VA = "0x33AE00C")]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x600090F")]
		[Address(RVA = "0x33AE018", Offset = "0x33AE018", VA = "0x33AE018")]
		set
		{
		}
	}

	// Token: 0x06000910 RID: 2320 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000910")]
	[Address(RVA = "0x33AE098", Offset = "0x33AE098", VA = "0x33AE098", Slot = "43")]
	protected override void OnPopulateMesh(Mesh toFill)
	{
	}

	// Token: 0x06000911 RID: 2321 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000911")]
	[Address(RVA = "0x33AEBF4", Offset = "0x33AEBF4", VA = "0x33AEBF4")]
	protected UIVertex[] SetVbo(VertexHelper vbo, Vector2[] vertices, Vector2[] uvs)
	{
		return null;
	}

	// Token: 0x06000912 RID: 2322 RVA: 0x00004E00 File Offset: 0x00003000
	[Token(Token = "0x6000912")]
	[Address(RVA = "0x33AEB74", Offset = "0x33AEB74", VA = "0x33AEB74")]
	public Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 angles)
	{
		return default(Vector3);
	}

	// Token: 0x06000913 RID: 2323 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000913")]
	[Address(RVA = "0x33AF064", Offset = "0x33AF064", VA = "0x33AF064")]
	public UILineRenderer()
	{
	}

	// Token: 0x040006C9 RID: 1737
	[Token(Token = "0x40006C9")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private Texture m_Texture;

	// Token: 0x040006CA RID: 1738
	[Token(Token = "0x40006CA")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private Rect m_UVRect;

	// Token: 0x040006CB RID: 1739
	[Token(Token = "0x40006CB")]
	[FieldOffset(Offset = "0xE8")]
	public float LineThickness;

	// Token: 0x040006CC RID: 1740
	[Token(Token = "0x40006CC")]
	[FieldOffset(Offset = "0xEC")]
	public bool UseMargins;

	// Token: 0x040006CD RID: 1741
	[Token(Token = "0x40006CD")]
	[FieldOffset(Offset = "0xF0")]
	public Vector2 Margin;

	// Token: 0x040006CE RID: 1742
	[Token(Token = "0x40006CE")]
	[FieldOffset(Offset = "0xF8")]
	public Vector2[] Points;

	// Token: 0x040006CF RID: 1743
	[Token(Token = "0x40006CF")]
	[FieldOffset(Offset = "0x100")]
	public bool relativeSize;
}
