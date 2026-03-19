using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Main.Scripts.Scene;
using UnityEngine;
using VEngine;

// Token: 0x0200030F RID: 783
[Token(Token = "0x200030F")]
public class WorldStaticManager : WorldManagerBase
{
	// Token: 0x060014A7 RID: 5287 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014A7")]
	[Address(RVA = "0x198718C", Offset = "0x198718C", VA = "0x198718C")]
	public WorldStaticManager(WorldScene scene)
	{
	}

	// Token: 0x060014A8 RID: 5288 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014A8")]
	[Address(RVA = "0x19874D4", Offset = "0x19874D4", VA = "0x19874D4", Slot = "4")]
	public override void Init()
	{
	}

	// Token: 0x060014A9 RID: 5289 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014A9")]
	[Address(RVA = "0x1987784", Offset = "0x1987784", VA = "0x1987784", Slot = "5")]
	public override void UnInit()
	{
	}

	// Token: 0x060014AA RID: 5290 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014AA")]
	[Address(RVA = "0x1987E34", Offset = "0x1987E34", VA = "0x1987E34")]
	public void ShowStaticModel()
	{
	}

	// Token: 0x060014AB RID: 5291 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014AB")]
	[Address(RVA = "0x1987EC8", Offset = "0x1987EC8", VA = "0x1987EC8")]
	public void HideStaticModel()
	{
	}

	// Token: 0x060014AC RID: 5292 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014AC")]
	[Address(RVA = "0x1987908", Offset = "0x1987908", VA = "0x1987908")]
	public void OnRemoveObject()
	{
	}

	// Token: 0x060014AD RID: 5293 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014AD")]
	[Address(RVA = "0x1987680", Offset = "0x1987680", VA = "0x1987680")]
	public void OnInitObject()
	{
	}

	// Token: 0x060014AE RID: 5294 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014AE")]
	[Address(RVA = "0x19886A0", Offset = "0x19886A0", VA = "0x19886A0", Slot = "6")]
	public override void OnUpdate(float deltaTime)
	{
	}

	// Token: 0x060014AF RID: 5295 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014AF")]
	[Address(RVA = "0x1988118", Offset = "0x1988118", VA = "0x1988118")]
	public void RemoveBlackDesert()
	{
	}

	// Token: 0x060014B0 RID: 5296 RVA: 0x000082C8 File Offset: 0x000064C8
	[Token(Token = "0x60014B0")]
	[Address(RVA = "0x19886A4", Offset = "0x19886A4", VA = "0x19886A4")]
	public bool IsTileWalkable(Vector2Int tilePos)
	{
		return default(bool);
	}

	// Token: 0x060014B1 RID: 5297 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014B1")]
	[Address(RVA = "0x19886AC", Offset = "0x19886AC", VA = "0x19886AC")]
	public void AddOccupyPoints(Vector2Int p, Vector2Int size)
	{
	}

	// Token: 0x060014B2 RID: 5298 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014B2")]
	[Address(RVA = "0x19886B0", Offset = "0x19886B0", VA = "0x19886B0")]
	public void RemoveOccupyPoints(Vector2Int p, Vector2Int size)
	{
	}

	// Token: 0x060014B3 RID: 5299 RVA: 0x000082E0 File Offset: 0x000064E0
	[Token(Token = "0x60014B3")]
	[Address(RVA = "0x19889BC", Offset = "0x19889BC", VA = "0x19889BC")]
	public bool IsOccupied(Vector2Int p)
	{
		return default(bool);
	}

	// Token: 0x060014B4 RID: 5300 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014B4")]
	[Address(RVA = "0x1988A8C", Offset = "0x1988A8C", VA = "0x1988A8C")]
	private void CheckLoadFinish()
	{
	}

	// Token: 0x060014B5 RID: 5301 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014B5")]
	[Address(RVA = "0x1988BF0", Offset = "0x1988BF0", VA = "0x1988BF0")]
	private void HideObjectInRect(Vector2Int p, Vector2Int size)
	{
	}

	// Token: 0x060014B6 RID: 5302 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014B6")]
	[Address(RVA = "0x19887D4", Offset = "0x19887D4", VA = "0x19887D4")]
	private void ShowObjectsInRect(Vector2Int p, Vector2Int size)
	{
	}

	// Token: 0x060014B7 RID: 5303 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014B7")]
	[Address(RVA = "0x19881C0", Offset = "0x19881C0", VA = "0x19881C0")]
	private void InitViewChunk()
	{
	}

	// Token: 0x060014B8 RID: 5304 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014B8")]
	[Address(RVA = "0x1988EC4", Offset = "0x1988EC4", VA = "0x1988EC4")]
	public void LoadTerrainAssets(Action callback)
	{
	}

	// Token: 0x060014B9 RID: 5305 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014B9")]
	[Address(RVA = "0x1988EC8", Offset = "0x1988EC8", VA = "0x1988EC8")]
	private void ChangeTerrainSetting(TerrainSetting setting)
	{
	}

	// Token: 0x060014BA RID: 5306 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014BA")]
	[Address(RVA = "0x1987F94", Offset = "0x1987F94", VA = "0x1987F94")]
	private void UnloadTerrainAssets()
	{
	}

	// Token: 0x060014BB RID: 5307 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014BB")]
	[Address(RVA = "0x19881E8", Offset = "0x19881E8", VA = "0x19881E8")]
	private void InitWorldBlocks()
	{
	}

	// Token: 0x060014BC RID: 5308 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014BC")]
	[Address(RVA = "0x19883C8", Offset = "0x19883C8", VA = "0x19883C8")]
	public void InitBlackBlock()
	{
	}

	// Token: 0x060014BD RID: 5309 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014BD")]
	[Address(RVA = "0x1988FD4", Offset = "0x1988FD4", VA = "0x1988FD4")]
	public void CreateDragonLandRange()
	{
	}

	// Token: 0x060014BE RID: 5310 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014BE")]
	[Address(RVA = "0x198854C", Offset = "0x198854C", VA = "0x198854C")]
	public void CreateCrossThroneRange()
	{
	}

	// Token: 0x060014BF RID: 5311 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014BF")]
	[Address(RVA = "0x1988188", Offset = "0x1988188", VA = "0x1988188")]
	public void RemoveCrossThroneRange()
	{
	}

	// Token: 0x060014C0 RID: 5312 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014C0")]
	[Address(RVA = "0x1988150", Offset = "0x1988150", VA = "0x1988150")]
	public void RemoveDragonLandRange()
	{
	}

	// Token: 0x060014C1 RID: 5313 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014C1")]
	[Address(RVA = "0x1989128", Offset = "0x1989128", VA = "0x1989128")]
	private void InitAllianceCity()
	{
	}

	// Token: 0x060014C2 RID: 5314 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014C2")]
	[Address(RVA = "0x1989278", Offset = "0x1989278", VA = "0x1989278")]
	private void CheckChangeFinish()
	{
	}

	// Token: 0x060014C3 RID: 5315 RVA: 0x000082F8 File Offset: 0x000064F8
	[Token(Token = "0x60014C3")]
	[Address(RVA = "0x198AE58", Offset = "0x198AE58", VA = "0x198AE58")]
	private Vector2Int TilePosToChunkCoord(Vector2Int tilePos)
	{
		return default(Vector2Int);
	}

	// Token: 0x060014C4 RID: 5316 RVA: 0x00008310 File Offset: 0x00006510
	[Token(Token = "0x60014C4")]
	[Address(RVA = "0x198AE8C", Offset = "0x198AE8C", VA = "0x198AE8C")]
	private Vector2Int TilePosToBlockCoord(Vector2Int tilePos)
	{
		return default(Vector2Int);
	}

	// Token: 0x060014C5 RID: 5317 RVA: 0x00008328 File Offset: 0x00006528
	[Token(Token = "0x60014C5")]
	[Address(RVA = "0x198AEB8", Offset = "0x198AEB8", VA = "0x198AEB8")]
	private Vector2Int ChunkCoordToBlockCoord(Vector2Int chunkCoord)
	{
		return default(Vector2Int);
	}

	// Token: 0x060014C6 RID: 5318 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014C6")]
	[Address(RVA = "0x198AEE4", Offset = "0x198AEE4", VA = "0x198AEE4")]
	private void GetChunkObjList(Vector2Int chunkCoord, List<WorldSceneDesc.ObjectDesc> list)
	{
	}

	// Token: 0x060014C7 RID: 5319 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014C7")]
	[Address(RVA = "0x198AFE8", Offset = "0x198AFE8", VA = "0x198AFE8")]
	private WorldStaticManager.Block GetBlock(Vector2Int blockCoord)
	{
		return null;
	}

	// Token: 0x060014C8 RID: 5320 RVA: 0x00008340 File Offset: 0x00006540
	[Token(Token = "0x60014C8")]
	[Address(RVA = "0x1988E8C", Offset = "0x1988E8C", VA = "0x1988E8C")]
	private int GetVisibleChunkRange()
	{
		return 0;
	}

	// Token: 0x060014C9 RID: 5321 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014C9")]
	[Address(RVA = "0x19896A0", Offset = "0x19896A0", VA = "0x19896A0")]
	private void UpdateView()
	{
	}

	// Token: 0x060014CA RID: 5322 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014CA")]
	[Address(RVA = "0x198B314", Offset = "0x198B314", VA = "0x198B314")]
	private void OnLodChanged(object userdata)
	{
	}

	// Token: 0x060014CB RID: 5323 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014CB")]
	[Address(RVA = "0x198B5E4", Offset = "0x198B5E4", VA = "0x198B5E4")]
	private void OnTerrainClick()
	{
	}

	// Token: 0x060014CC RID: 5324 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014CC")]
	[Address(RVA = "0x198B694", Offset = "0x198B694", VA = "0x198B694")]
	public void OnDrawGizmos()
	{
	}

	// Token: 0x060014CD RID: 5325 RVA: 0x00008358 File Offset: 0x00006558
	[Token(Token = "0x60014CD")]
	[Address(RVA = "0x198B698", Offset = "0x198B698", VA = "0x198B698")]
	public bool GetProfileTerrainSwitch()
	{
		return default(bool);
	}

	// Token: 0x060014CE RID: 5326 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014CE")]
	[Address(RVA = "0x19850B0", Offset = "0x19850B0", VA = "0x19850B0")]
	public void ProfileToggleTerrain()
	{
	}

	// Token: 0x060014CF RID: 5327 RVA: 0x00008370 File Offset: 0x00006570
	[Token(Token = "0x60014CF")]
	[Address(RVA = "0x198B6A0", Offset = "0x198B6A0", VA = "0x198B6A0")]
	public bool GetProfileSwitch()
	{
		return default(bool);
	}

	// Token: 0x060014D0 RID: 5328 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014D0")]
	[Address(RVA = "0x198B6A8", Offset = "0x198B6A8", VA = "0x198B6A8")]
	public void ProfileToggle()
	{
	}

	// Token: 0x0400178B RID: 6027
	[Token(Token = "0x400178B")]
	private const int CreateCountPerFrame = 20;

	// Token: 0x0400178C RID: 6028
	[Token(Token = "0x400178C")]
	private const int TileCountPerChunk = 25;

	// Token: 0x0400178D RID: 6029
	[Token(Token = "0x400178D")]
	private const int ObjectExtents = 4;

	// Token: 0x0400178E RID: 6030
	[Token(Token = "0x400178E")]
	private const int DecorateLod = 5;

	// Token: 0x0400178F RID: 6031
	[Token(Token = "0x400178F")]
	private const int AllianceCityLod = 3;

	// Token: 0x04001790 RID: 6032
	[Token(Token = "0x4001790")]
	private const int TerrainLod = 80;

	// Token: 0x04001791 RID: 6033
	[Token(Token = "0x4001791")]
	private const int TerrainClickLod = 3;

	// Token: 0x04001792 RID: 6034
	[Token(Token = "0x4001792")]
	[FieldOffset(Offset = "0x18")]
	private Transform parentNode;

	// Token: 0x04001793 RID: 6035
	[Token(Token = "0x4001793")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int Prop_Control;

	// Token: 0x04001794 RID: 6036
	[Token(Token = "0x4001794")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int Prop_Splat0;

	// Token: 0x04001795 RID: 6037
	[Token(Token = "0x4001795")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int Prop_Splat1;

	// Token: 0x04001796 RID: 6038
	[Token(Token = "0x4001796")]
	[FieldOffset(Offset = "0xC")]
	private static readonly int Prop_Control_ST;

	// Token: 0x04001797 RID: 6039
	[Token(Token = "0x4001797")]
	[FieldOffset(Offset = "0x10")]
	private static readonly int Prop_Splat0_ST;

	// Token: 0x04001798 RID: 6040
	[Token(Token = "0x4001798")]
	[FieldOffset(Offset = "0x14")]
	private static readonly int Prop_Splat1_ST;

	// Token: 0x04001799 RID: 6041
	[Token(Token = "0x4001799")]
	[FieldOffset(Offset = "0x18")]
	private static readonly int Prop_TerrainBounds;

	// Token: 0x0400179A RID: 6042
	[Token(Token = "0x400179A")]
	[FieldOffset(Offset = "0x20")]
	private int chunkCountPerBlock;

	// Token: 0x0400179B RID: 6043
	[Token(Token = "0x400179B")]
	[FieldOffset(Offset = "0x28")]
	private List<Asset> terrainAssets;

	// Token: 0x0400179C RID: 6044
	[Token(Token = "0x400179C")]
	[FieldOffset(Offset = "0x30")]
	private List<Asset> terrainAssetsNew;

	// Token: 0x0400179D RID: 6045
	[Token(Token = "0x400179D")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<Vector2Int, GameObject> terrains;

	// Token: 0x0400179E RID: 6046
	[Token(Token = "0x400179E")]
	[FieldOffset(Offset = "0x40")]
	private HashSet<Vector2Int> tmpCalcTerrains;

	// Token: 0x0400179F RID: 6047
	[Token(Token = "0x400179F")]
	[FieldOffset(Offset = "0x48")]
	private List<Vector2Int> tmpForRemove;

	// Token: 0x040017A0 RID: 6048
	[Token(Token = "0x40017A0")]
	[FieldOffset(Offset = "0x50")]
	private Asset worldSceneDescAsset;

	// Token: 0x040017A1 RID: 6049
	[Token(Token = "0x40017A1")]
	[FieldOffset(Offset = "0x58")]
	private Asset worldSceneCityDescAsset;

	// Token: 0x040017A2 RID: 6050
	[Token(Token = "0x40017A2")]
	[FieldOffset(Offset = "0x60")]
	private List<WorldStaticManager.Block> blockTemplates;

	// Token: 0x040017A3 RID: 6051
	[Token(Token = "0x40017A3")]
	[FieldOffset(Offset = "0x68")]
	private WorldStaticManager.Block[][] worldBlocks;

	// Token: 0x040017A4 RID: 6052
	[Token(Token = "0x40017A4")]
	[FieldOffset(Offset = "0x70")]
	private WorldStaticManager.Block cityBlock;

	// Token: 0x040017A5 RID: 6053
	[Token(Token = "0x40017A5")]
	[FieldOffset(Offset = "0x78")]
	private Dictionary<int, WorldStaticManager.StaticObject> objsDict;

	// Token: 0x040017A6 RID: 6054
	[Token(Token = "0x40017A6")]
	[FieldOffset(Offset = "0x80")]
	private Dictionary<int, Tuple<Vector2Int, WorldSceneDesc.ObjectDesc>> createList;

	// Token: 0x040017A7 RID: 6055
	[Token(Token = "0x40017A7")]
	[FieldOffset(Offset = "0x88")]
	private List<int> objsToRemove;

	// Token: 0x040017A8 RID: 6056
	[Token(Token = "0x40017A8")]
	[FieldOffset(Offset = "0x90")]
	private List<WorldSceneDesc.ObjectDesc> chunkObjList;

	// Token: 0x040017A9 RID: 6057
	[Token(Token = "0x40017A9")]
	[FieldOffset(Offset = "0x98")]
	private int lastViewLevel;

	// Token: 0x040017AA RID: 6058
	[Token(Token = "0x40017AA")]
	[FieldOffset(Offset = "0x9C")]
	private Vector2Int lastViewChunk;

	// Token: 0x040017AB RID: 6059
	[Token(Token = "0x40017AB")]
	[FieldOffset(Offset = "0xA4")]
	private int lastViewRange;

	// Token: 0x040017AC RID: 6060
	[Token(Token = "0x40017AC")]
	[FieldOffset(Offset = "0xA8")]
	private InstanceRequest blackBlockRequest;

	// Token: 0x040017AD RID: 6061
	[Token(Token = "0x40017AD")]
	[FieldOffset(Offset = "0xB0")]
	private InstanceRequest dragonBlockRequest;

	// Token: 0x040017AE RID: 6062
	[Token(Token = "0x40017AE")]
	[FieldOffset(Offset = "0xB8")]
	private InstanceRequest crossThroneRequest;

	// Token: 0x040017AF RID: 6063
	[Token(Token = "0x40017AF")]
	[FieldOffset(Offset = "0xC0")]
	private Dictionary<Vector2Int, int> occupyPoints;

	// Token: 0x040017B0 RID: 6064
	[Token(Token = "0x40017B0")]
	[FieldOffset(Offset = "0xC8")]
	public bool isLoadFinish;

	// Token: 0x040017B1 RID: 6065
	[Token(Token = "0x40017B1")]
	[FieldOffset(Offset = "0xD0")]
	private string terrainPrefabName;

	// Token: 0x040017B2 RID: 6066
	[Token(Token = "0x40017B2")]
	[FieldOffset(Offset = "0xD8")]
	private Action loadTerrainCallback;

	// Token: 0x040017B3 RID: 6067
	[Token(Token = "0x40017B3")]
	[FieldOffset(Offset = "0xE0")]
	private bool profileTerrainSwitch;

	// Token: 0x040017B4 RID: 6068
	[Token(Token = "0x40017B4")]
	[FieldOffset(Offset = "0xE1")]
	private bool profileSwitch;

	// Token: 0x02000310 RID: 784
	[Token(Token = "0x2000310")]
	private enum StaticObjectType
	{
		// Token: 0x040017B6 RID: 6070
		[Token(Token = "0x40017B6")]
		Decorate,
		// Token: 0x040017B7 RID: 6071
		[Token(Token = "0x40017B7")]
		City
	}

	// Token: 0x02000311 RID: 785
	[Token(Token = "0x2000311")]
	private class Block
	{
		// Token: 0x060014D6 RID: 5334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014D6")]
		[Address(RVA = "0x198BDE0", Offset = "0x198BDE0", VA = "0x198BDE0")]
		public void Init(string terrainName, byte[] bytes, WorldStaticManager mgr)
		{
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014D7")]
		[Address(RVA = "0x1987F5C", Offset = "0x1987F5C", VA = "0x1987F5C")]
		public void Uninit()
		{
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014D8")]
		[Address(RVA = "0x198B088", Offset = "0x198B088", VA = "0x198B088")]
		public List<WorldSceneDesc.ObjectDesc> GetChunkObjList(Vector2Int chunkCoord)
		{
			return null;
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x00008388 File Offset: 0x00006588
		[Token(Token = "0x60014D9")]
		[Address(RVA = "0x198C144", Offset = "0x198C144", VA = "0x198C144")]
		public bool IsTileWalkable(Vector2Int tilePos)
		{
			return default(bool);
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060014DA RID: 5338 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060014DB RID: 5339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000237")]
		public string TerrainName
		{
			[Token(Token = "0x60014DA")]
			[Address(RVA = "0x198C19C", Offset = "0x198C19C", VA = "0x198C19C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60014DB")]
			[Address(RVA = "0x198C1A4", Offset = "0x198C1A4", VA = "0x198C1A4")]
			set
			{
			}
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014DC")]
		[Address(RVA = "0x198BD58", Offset = "0x198BD58", VA = "0x198BD58")]
		public Block()
		{
		}

		// Token: 0x040017B8 RID: 6072
		[Token(Token = "0x40017B8")]
		[FieldOffset(Offset = "0x10")]
		private string terrainName;

		// Token: 0x040017B9 RID: 6073
		[Token(Token = "0x40017B9")]
		[FieldOffset(Offset = "0x18")]
		private Asset assetReq;

		// Token: 0x040017BA RID: 6074
		[Token(Token = "0x40017BA")]
		[FieldOffset(Offset = "0x20")]
		private WorldSceneDesc blockTpl;

		// Token: 0x040017BB RID: 6075
		[Token(Token = "0x40017BB")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<Vector2Int, List<WorldSceneDesc.ObjectDesc>> chunks;
	}

	// Token: 0x02000312 RID: 786
	[Token(Token = "0x2000312")]
	private class StaticObject
	{
		// Token: 0x060014DD RID: 5341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014DD")]
		[Address(RVA = "0x198B11C", Offset = "0x198B11C", VA = "0x198B11C")]
		public StaticObject(WorldSceneDesc.ObjectDesc desc, Vector3 pos)
		{
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014DE")]
		[Address(RVA = "0x198B1D0", Offset = "0x198B1D0", VA = "0x198B1D0")]
		public void Load(Transform parent)
		{
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014DF")]
		[Address(RVA = "0x1987F60", Offset = "0x1987F60", VA = "0x1987F60")]
		public void Unload()
		{
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014E0")]
		[Address(RVA = "0x1988DEC", Offset = "0x1988DEC", VA = "0x1988DEC")]
		public void SetVisible(bool v)
		{
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060014E1 RID: 5345 RVA: 0x000083A0 File Offset: 0x000065A0
		[Token(Token = "0x17000238")]
		public bool IsVisible
		{
			[Token(Token = "0x60014E1")]
			[Address(RVA = "0x198C1B4", Offset = "0x198C1B4", VA = "0x198C1B4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060014E2 RID: 5346 RVA: 0x000083B8 File Offset: 0x000065B8
		[Token(Token = "0x17000239")]
		public WorldStaticManager.StaticObjectType Type
		{
			[Token(Token = "0x60014E2")]
			[Address(RVA = "0x1988DD0", Offset = "0x1988DD0", VA = "0x1988DD0")]
			get
			{
				return WorldStaticManager.StaticObjectType.Decorate;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060014E3 RID: 5347 RVA: 0x000083D0 File Offset: 0x000065D0
		[Token(Token = "0x1700023A")]
		public Vector2Int TilePos
		{
			[Token(Token = "0x60014E3")]
			[Address(RVA = "0x198C1BC", Offset = "0x198C1BC", VA = "0x198C1BC")]
			get
			{
				return default(Vector2Int);
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060014E4 RID: 5348 RVA: 0x000083E8 File Offset: 0x000065E8
		[Token(Token = "0x1700023B")]
		public int Id
		{
			[Token(Token = "0x60014E4")]
			[Address(RVA = "0x198B100", Offset = "0x198B100", VA = "0x198B100")]
			get
			{
				return 0;
			}
		}

		// Token: 0x040017BC RID: 6076
		[Token(Token = "0x40017BC")]
		[FieldOffset(Offset = "0x10")]
		private InstanceRequest request;

		// Token: 0x040017BD RID: 6077
		[Token(Token = "0x40017BD")]
		[FieldOffset(Offset = "0x18")]
		private WorldSceneDesc.ObjectDesc desc;

		// Token: 0x040017BE RID: 6078
		[Token(Token = "0x40017BE")]
		[FieldOffset(Offset = "0x20")]
		private GameObject gameObject;

		// Token: 0x040017BF RID: 6079
		[Token(Token = "0x40017BF")]
		[FieldOffset(Offset = "0x28")]
		private bool isVisible;

		// Token: 0x040017C0 RID: 6080
		[Token(Token = "0x40017C0")]
		[FieldOffset(Offset = "0x2C")]
		private Vector2Int tilePos;

		// Token: 0x040017C1 RID: 6081
		[Token(Token = "0x40017C1")]
		[FieldOffset(Offset = "0x34")]
		private Vector3 position;
	}
}
