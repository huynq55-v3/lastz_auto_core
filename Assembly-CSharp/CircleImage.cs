using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000F0 RID: 240
[Token(Token = "0x20000F0")]
[AddComponentMenu("UI/Circle Image")]
public class CircleImage : BaseImage
{
	// Token: 0x060006D9 RID: 1753 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D9")]
	[Address(RVA = "0x2E82E80", Offset = "0x2E82E80", VA = "0x2E82E80", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x060006DA RID: 1754 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006DA")]
	[Address(RVA = "0x2E82F2C", Offset = "0x2E82F2C", VA = "0x2E82F2C")]
	private void Update()
	{
	}

	// Token: 0x060006DB RID: 1755 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006DB")]
	[Address(RVA = "0x2E82FA0", Offset = "0x2E82FA0", VA = "0x2E82FA0", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}

	// Token: 0x060006DC RID: 1756 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006DC")]
	[Address(RVA = "0x2E84284", Offset = "0x2E84284", VA = "0x2E84284")]
	private void GenerateSprite(VertexHelper vh, bool lPreserveAspect)
	{
	}

	// Token: 0x060006DD RID: 1757 RVA: 0x000043E0 File Offset: 0x000025E0
	[Token(Token = "0x60006DD")]
	[Address(RVA = "0x2E84884", Offset = "0x2E84884", VA = "0x2E84884", Slot = "86")]
	public override bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
	{
		return default(bool);
	}

	// Token: 0x060006DE RID: 1758 RVA: 0x000043F8 File Offset: 0x000025F8
	[Token(Token = "0x60006DE")]
	[Address(RVA = "0x2E84988", Offset = "0x2E84988", VA = "0x2E84988")]
	private bool Contains(Vector2 p, List<Vector3> outterVertices, List<Vector3> innerVertices)
	{
		return default(bool);
	}

	// Token: 0x060006DF RID: 1759 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006DF")]
	[Address(RVA = "0x2E849E0", Offset = "0x2E849E0", VA = "0x2E849E0")]
	private void RayCrossing(Vector2 p, List<Vector3> vertices, ref int crossNumber)
	{
	}

	// Token: 0x060006E0 RID: 1760 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006E0")]
	[Address(RVA = "0x2E84AF4", Offset = "0x2E84AF4", VA = "0x2E84AF4")]
	public CircleImage()
	{
	}

	// Token: 0x04000506 RID: 1286
	[Token(Token = "0x4000506")]
	[FieldOffset(Offset = "0xE0")]
	[Range(0f, 1f)]
	[Tooltip("圆形或扇形填充比例")]
	public float fillPercent;

	// Token: 0x04000507 RID: 1287
	[Token(Token = "0x4000507")]
	[FieldOffset(Offset = "0xE4")]
	[Tooltip("是否填充圆形")]
	public bool fill;

	// Token: 0x04000508 RID: 1288
	[Token(Token = "0x4000508")]
	[FieldOffset(Offset = "0xE8")]
	[Tooltip("圆环宽度")]
	public float thickness;

	// Token: 0x04000509 RID: 1289
	[Token(Token = "0x4000509")]
	[FieldOffset(Offset = "0xEC")]
	[Range(3f, 100f)]
	[Tooltip("圆形")]
	public int segements;

	// Token: 0x0400050A RID: 1290
	[Token(Token = "0x400050A")]
	[FieldOffset(Offset = "0xF0")]
	public bool isCircle;

	// Token: 0x0400050B RID: 1291
	[Token(Token = "0x400050B")]
	[FieldOffset(Offset = "0xF8")]
	private List<Vector3> innerVertices;

	// Token: 0x0400050C RID: 1292
	[Token(Token = "0x400050C")]
	[FieldOffset(Offset = "0x100")]
	private List<Vector3> outterVertices;
}
