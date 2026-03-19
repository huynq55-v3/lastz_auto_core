using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using VEngine;
using World.LFTerrain;

// Token: 0x020002D5 RID: 725
[Token(Token = "0x20002D5")]
public class LFTerrain
{
	// Token: 0x060012B8 RID: 4792 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012B8")]
	[Address(RVA = "0x1C6016C", Offset = "0x1C6016C", VA = "0x1C6016C")]
	public LFTerrain(WorldScene scene)
	{
	}

	// Token: 0x060012B9 RID: 4793 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012B9")]
	[Address(RVA = "0x1C6021C", Offset = "0x1C6021C", VA = "0x1C6021C")]
	public void InitAsset(Action callback)
	{
	}

	// Token: 0x060012BA RID: 4794 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012BA")]
	[Address(RVA = "0x1C6051C", Offset = "0x1C6051C", VA = "0x1C6051C")]
	public void CleanAsset()
	{
	}

	// Token: 0x060012BB RID: 4795 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012BB")]
	[Address(RVA = "0x1C605C4", Offset = "0x1C605C4", VA = "0x1C605C4")]
	private void CheckLoadFinish()
	{
	}

	// Token: 0x060012BC RID: 4796 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012BC")]
	[Address(RVA = "0x1C605F0", Offset = "0x1C605F0", VA = "0x1C605F0")]
	public void OnUpdate()
	{
	}

	// Token: 0x0400157D RID: 5501
	[Token(Token = "0x400157D")]
	[FieldOffset(Offset = "0x10")]
	private TerrainDataScriptableObject _terrainData;

	// Token: 0x0400157E RID: 5502
	[Token(Token = "0x400157E")]
	[FieldOffset(Offset = "0x18")]
	private Asset _dataReq;

	// Token: 0x0400157F RID: 5503
	[Token(Token = "0x400157F")]
	[FieldOffset(Offset = "0x20")]
	private Mesh _quadMesh;

	// Token: 0x04001580 RID: 5504
	[Token(Token = "0x4001580")]
	[FieldOffset(Offset = "0x28")]
	private Asset _meshReq;

	// Token: 0x04001581 RID: 5505
	[Token(Token = "0x4001581")]
	[FieldOffset(Offset = "0x30")]
	private bool _meshLoaded;

	// Token: 0x04001582 RID: 5506
	[Token(Token = "0x4001582")]
	[FieldOffset(Offset = "0x31")]
	private bool _dataLoaded;

	// Token: 0x04001583 RID: 5507
	[Token(Token = "0x4001583")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Vector3 MapCenter;

	// Token: 0x04001584 RID: 5508
	[Token(Token = "0x4001584")]
	[FieldOffset(Offset = "0xC")]
	private static Vector3 MapScale;

	// Token: 0x04001585 RID: 5509
	[Token(Token = "0x4001585")]
	[FieldOffset(Offset = "0x38")]
	private WorldScene _worldScene;

	// Token: 0x04001586 RID: 5510
	[Token(Token = "0x4001586")]
	[FieldOffset(Offset = "0x40")]
	private readonly List<LFTerrain.RenderData> _renderDataList;

	// Token: 0x04001587 RID: 5511
	[Token(Token = "0x4001587")]
	[FieldOffset(Offset = "0x48")]
	private Action _loadCallback;

	// Token: 0x04001588 RID: 5512
	[Token(Token = "0x4001588")]
	[FieldOffset(Offset = "0x50")]
	private int _graphicLevel;

	// Token: 0x020002D6 RID: 726
	[Token(Token = "0x20002D6")]
	private class RenderData
	{
		// Token: 0x060012C0 RID: 4800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012C0")]
		[Address(RVA = "0x1C60BC0", Offset = "0x1C60BC0", VA = "0x1C60BC0")]
		public RenderData(Material m, Vector3 localPos, Vector3 euler, Vector3 localScale)
		{
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012C1")]
		[Address(RVA = "0x1C60DE4", Offset = "0x1C60DE4", VA = "0x1C60DE4")]
		public void OnDraw(Mesh quad)
		{
		}

		// Token: 0x04001589 RID: 5513
		[Token(Token = "0x4001589")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 Pos;

		// Token: 0x0400158A RID: 5514
		[Token(Token = "0x400158A")]
		[FieldOffset(Offset = "0x1C")]
		public readonly Matrix4x4 Matrix;

		// Token: 0x0400158B RID: 5515
		[Token(Token = "0x400158B")]
		[FieldOffset(Offset = "0x60")]
		public Material Mat;
	}
}
