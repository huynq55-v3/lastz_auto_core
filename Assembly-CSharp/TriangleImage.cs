using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000131 RID: 305
[Token(Token = "0x2000131")]
[AddComponentMenu("UI/Triangle Image")]
public class TriangleImage : BaseImage
{
	// Token: 0x060008E3 RID: 2275 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E3")]
	[Address(RVA = "0x33AB790", Offset = "0x33AB790", VA = "0x33AB790", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}

	// Token: 0x060008E4 RID: 2276 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E4")]
	[Address(RVA = "0x33AC114", Offset = "0x33AC114", VA = "0x33AC114")]
	public TriangleImage()
	{
	}

	// Token: 0x040006A5 RID: 1701
	[Token(Token = "0x40006A5")]
	[FieldOffset(Offset = "0xE0")]
	public Vector2 p1;

	// Token: 0x040006A6 RID: 1702
	[Token(Token = "0x40006A6")]
	[FieldOffset(Offset = "0xE8")]
	public Vector2 p2;

	// Token: 0x040006A7 RID: 1703
	[Token(Token = "0x40006A7")]
	[FieldOffset(Offset = "0xF0")]
	public Vector2 p3;

	// Token: 0x040006A8 RID: 1704
	[Token(Token = "0x40006A8")]
	[FieldOffset(Offset = "0xF8")]
	public Color color;
}
