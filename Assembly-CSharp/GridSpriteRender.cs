using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200025B RID: 603
[Token(Token = "0x200025B")]
public class GridSpriteRender : MonoBehaviour
{
	// Token: 0x06001006 RID: 4102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001006")]
	[Address(RVA = "0x1BE9FCC", Offset = "0x1BE9FCC", VA = "0x1BE9FCC")]
	private void Awake()
	{
	}

	// Token: 0x06001007 RID: 4103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001007")]
	[Address(RVA = "0x1BE9FD0", Offset = "0x1BE9FD0", VA = "0x1BE9FD0")]
	private void DrawGrid()
	{
	}

	// Token: 0x06001008 RID: 4104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001008")]
	[Address(RVA = "0x1BEA078", Offset = "0x1BEA078", VA = "0x1BEA078")]
	private void CreateLine(Vector3 start, Vector3 end)
	{
	}

	// Token: 0x06001009 RID: 4105 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001009")]
	[Address(RVA = "0x1BEA248", Offset = "0x1BEA248", VA = "0x1BEA248")]
	public GridSpriteRender()
	{
	}

	// Token: 0x04001289 RID: 4745
	[Token(Token = "0x4001289")]
	[FieldOffset(Offset = "0x18")]
	public float gridSize;

	// Token: 0x0400128A RID: 4746
	[Token(Token = "0x400128A")]
	[FieldOffset(Offset = "0x1C")]
	public int gridCount;

	// Token: 0x0400128B RID: 4747
	[Token(Token = "0x400128B")]
	[FieldOffset(Offset = "0x20")]
	public Material lineMaterial;
}
