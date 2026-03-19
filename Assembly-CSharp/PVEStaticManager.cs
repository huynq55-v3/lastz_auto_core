using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Main.Scripts.Scene.PVE;
using UnityEngine;
using VEngine;

// Token: 0x020002AC RID: 684
[Token(Token = "0x20002AC")]
public class PVEStaticManager
{
	// Token: 0x170001FB RID: 507
	// (get) Token: 0x060011CC RID: 4556 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060011CD RID: 4557 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001FB")]
	public FIGridManager GridMgr
	{
		[Token(Token = "0x60011CC")]
		[Address(RVA = "0x1C549E0", Offset = "0x1C549E0", VA = "0x1C549E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60011CD")]
		[Address(RVA = "0x1C549E8", Offset = "0x1C549E8", VA = "0x1C549E8")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x060011CE RID: 4558 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011CE")]
	[Address(RVA = "0x1C549F0", Offset = "0x1C549F0", VA = "0x1C549F0")]
	public void SetSceneObj(GameObject obj)
	{
	}

	// Token: 0x060011CF RID: 4559 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011CF")]
	[Address(RVA = "0x1C549F8", Offset = "0x1C549F8", VA = "0x1C549F8")]
	public void Init(string descPath, int tileCountPerChunk, int createCountPerFrame, Action callback)
	{
	}

	// Token: 0x060011D0 RID: 4560 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011D0")]
	[Address(RVA = "0x1C54C98", Offset = "0x1C54C98", VA = "0x1C54C98")]
	public void UnInit()
	{
	}

	// Token: 0x060011D1 RID: 4561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011D1")]
	[Address(RVA = "0x1C54F70", Offset = "0x1C54F70", VA = "0x1C54F70")]
	public void OnUpdate(int viewX, int viewY)
	{
	}

	// Token: 0x060011D2 RID: 4562 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011D2")]
	[Address(RVA = "0x1C54F74", Offset = "0x1C54F74", VA = "0x1C54F74")]
	private void UpdateView(int viewX, int viewY)
	{
	}

	// Token: 0x060011D3 RID: 4563 RVA: 0x00006FC0 File Offset: 0x000051C0
	[Token(Token = "0x60011D3")]
	[Address(RVA = "0x1C55604", Offset = "0x1C55604", VA = "0x1C55604")]
	private Vector2Int TilePosToChunkCoord(Vector2Int tilePos)
	{
		return default(Vector2Int);
	}

	// Token: 0x060011D4 RID: 4564 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011D4")]
	[Address(RVA = "0x1C5561C", Offset = "0x1C5561C", VA = "0x1C5561C")]
	private List<WorldSceneDesc.ObjectDesc> GetChunkObjList(Vector2Int chunkCoord)
	{
		return null;
	}

	// Token: 0x060011D5 RID: 4565 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011D5")]
	[Address(RVA = "0x1C55694", Offset = "0x1C55694", VA = "0x1C55694")]
	public void SetVisibleChunk(int range)
	{
	}

	// Token: 0x060011D6 RID: 4566 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011D6")]
	[Address(RVA = "0x1C5569C", Offset = "0x1C5569C", VA = "0x1C5569C")]
	public PVEStaticManager()
	{
	}

	// Token: 0x040014AD RID: 5293
	[Token(Token = "0x40014AD")]
	[FieldOffset(Offset = "0x10")]
	private int _createCountPerFrame;

	// Token: 0x040014AE RID: 5294
	[Token(Token = "0x40014AE")]
	[FieldOffset(Offset = "0x14")]
	private int _tileCountPerChunk;

	// Token: 0x040014AF RID: 5295
	[Token(Token = "0x40014AF")]
	[FieldOffset(Offset = "0x18")]
	private Transform _parentNode;

	// Token: 0x040014B0 RID: 5296
	[Token(Token = "0x40014B0")]
	[FieldOffset(Offset = "0x20")]
	private WorldSceneDesc _sceneDesc;

	// Token: 0x040014B1 RID: 5297
	[Token(Token = "0x40014B1")]
	[FieldOffset(Offset = "0x28")]
	private Asset _descAsset;

	// Token: 0x040014B2 RID: 5298
	[Token(Token = "0x40014B2")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<int, PVEStaticManager.StaticObject> _objsDict;

	// Token: 0x040014B3 RID: 5299
	[Token(Token = "0x40014B3")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<int, WorldSceneDesc.ObjectDesc> _createList;

	// Token: 0x040014B4 RID: 5300
	[Token(Token = "0x40014B4")]
	[FieldOffset(Offset = "0x40")]
	private List<WorldSceneDesc.ObjectDesc> createTempList;

	// Token: 0x040014B5 RID: 5301
	[Token(Token = "0x40014B5")]
	[FieldOffset(Offset = "0x48")]
	private List<int> objsToRemove;

	// Token: 0x040014B6 RID: 5302
	[Token(Token = "0x40014B6")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<Vector2Int, List<WorldSceneDesc.ObjectDesc>> _chunks;

	// Token: 0x040014B7 RID: 5303
	[Token(Token = "0x40014B7")]
	[FieldOffset(Offset = "0x58")]
	private bool isLoadFinish;

	// Token: 0x040014B8 RID: 5304
	[Token(Token = "0x40014B8")]
	[FieldOffset(Offset = "0x5C")]
	private Vector2Int _lastViewChunk;

	// Token: 0x040014B9 RID: 5305
	[Token(Token = "0x40014B9")]
	[FieldOffset(Offset = "0x64")]
	private int _visibleChunkRange;

	// Token: 0x040014BA RID: 5306
	[Token(Token = "0x40014BA")]
	[FieldOffset(Offset = "0x68")]
	private int _lastVisibleChunkRange;

	// Token: 0x040014BC RID: 5308
	[Token(Token = "0x40014BC")]
	[FieldOffset(Offset = "0x78")]
	private GameObject sceneObj;

	// Token: 0x020002AD RID: 685
	[Token(Token = "0x20002AD")]
	private class StaticObject
	{
		// Token: 0x060011D7 RID: 4567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011D7")]
		[Address(RVA = "0x1C55430", Offset = "0x1C55430", VA = "0x1C55430")]
		public StaticObject(WorldSceneDesc.ObjectDesc desc, Vector3 pos)
		{
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011D8")]
		[Address(RVA = "0x1C554C0", Offset = "0x1C554C0", VA = "0x1C554C0")]
		public void Load(Transform parent)
		{
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011D9")]
		[Address(RVA = "0x1C54F3C", Offset = "0x1C54F3C", VA = "0x1C54F3C")]
		public void Unload()
		{
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011DA")]
		[Address(RVA = "0x1C55910", Offset = "0x1C55910", VA = "0x1C55910")]
		public void SetVisible(bool v)
		{
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060011DB RID: 4571 RVA: 0x00006FD8 File Offset: 0x000051D8
		[Token(Token = "0x170001FC")]
		public bool IsVisible
		{
			[Token(Token = "0x60011DB")]
			[Address(RVA = "0x1C559B0", Offset = "0x1C559B0", VA = "0x1C559B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060011DC RID: 4572 RVA: 0x00006FF0 File Offset: 0x000051F0
		[Token(Token = "0x170001FD")]
		public int Id
		{
			[Token(Token = "0x60011DC")]
			[Address(RVA = "0x1C554A4", Offset = "0x1C554A4", VA = "0x1C554A4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060011DD RID: 4573 RVA: 0x00007008 File Offset: 0x00005208
		[Token(Token = "0x170001FE")]
		public Vector2Int TilePos
		{
			[Token(Token = "0x60011DD")]
			[Address(RVA = "0x1C559B8", Offset = "0x1C559B8", VA = "0x1C559B8")]
			get
			{
				return default(Vector2Int);
			}
		}

		// Token: 0x040014BD RID: 5309
		[Token(Token = "0x40014BD")]
		[FieldOffset(Offset = "0x10")]
		private InstanceRequest request;

		// Token: 0x040014BE RID: 5310
		[Token(Token = "0x40014BE")]
		[FieldOffset(Offset = "0x18")]
		private WorldSceneDesc.ObjectDesc desc;

		// Token: 0x040014BF RID: 5311
		[Token(Token = "0x40014BF")]
		[FieldOffset(Offset = "0x20")]
		private GameObject gameObject;

		// Token: 0x040014C0 RID: 5312
		[Token(Token = "0x40014C0")]
		[FieldOffset(Offset = "0x28")]
		private bool isVisible;

		// Token: 0x040014C1 RID: 5313
		[Token(Token = "0x40014C1")]
		[FieldOffset(Offset = "0x2C")]
		private Vector2Int tilePos;

		// Token: 0x040014C2 RID: 5314
		[Token(Token = "0x40014C2")]
		[FieldOffset(Offset = "0x34")]
		private Vector3 position;
	}
}
