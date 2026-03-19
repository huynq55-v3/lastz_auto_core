using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BitBenderGames;
using Il2CppDummyDll;
using Unity.Mathematics;
using UnityEngine;
using XLua;

// Token: 0x0200030B RID: 779
[Token(Token = "0x200030B")]
public class WorldScene : MonoBehaviour
{
	// Token: 0x1700021D RID: 541
	// (get) Token: 0x06001431 RID: 5169 RVA: 0x00007E78 File Offset: 0x00006078
	// (set) Token: 0x06001432 RID: 5170 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700021D")]
	public int CurTileCountXMin
	{
		[Token(Token = "0x6001431")]
		[Address(RVA = "0x1981FA4", Offset = "0x1981FA4", VA = "0x1981FA4")]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001432")]
		[Address(RVA = "0x1981FAC", Offset = "0x1981FAC", VA = "0x1981FAC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x1700021E RID: 542
	// (get) Token: 0x06001433 RID: 5171 RVA: 0x00007E90 File Offset: 0x00006090
	// (set) Token: 0x06001434 RID: 5172 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700021E")]
	public int CurTileCountXMax
	{
		[Token(Token = "0x6001433")]
		[Address(RVA = "0x1981FB4", Offset = "0x1981FB4", VA = "0x1981FB4")]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001434")]
		[Address(RVA = "0x1981FBC", Offset = "0x1981FBC", VA = "0x1981FBC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x1700021F RID: 543
	// (get) Token: 0x06001435 RID: 5173 RVA: 0x00007EA8 File Offset: 0x000060A8
	// (set) Token: 0x06001436 RID: 5174 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700021F")]
	public int CurTileCountYMin
	{
		[Token(Token = "0x6001435")]
		[Address(RVA = "0x1981FC4", Offset = "0x1981FC4", VA = "0x1981FC4")]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001436")]
		[Address(RVA = "0x1981FCC", Offset = "0x1981FCC", VA = "0x1981FCC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000220 RID: 544
	// (get) Token: 0x06001437 RID: 5175 RVA: 0x00007EC0 File Offset: 0x000060C0
	// (set) Token: 0x06001438 RID: 5176 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000220")]
	public int CurTileCountYMax
	{
		[Token(Token = "0x6001437")]
		[Address(RVA = "0x1981FD4", Offset = "0x1981FD4", VA = "0x1981FD4")]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001438")]
		[Address(RVA = "0x1981FDC", Offset = "0x1981FDC", VA = "0x1981FDC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000221 RID: 545
	// (get) Token: 0x06001439 RID: 5177 RVA: 0x00007ED8 File Offset: 0x000060D8
	// (set) Token: 0x0600143A RID: 5178 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000221")]
	public int WorldSize
	{
		[Token(Token = "0x6001439")]
		[Address(RVA = "0x1981FE4", Offset = "0x1981FE4", VA = "0x1981FE4")]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[Token(Token = "0x600143A")]
		[Address(RVA = "0x1981FEC", Offset = "0x1981FEC", VA = "0x1981FEC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000222 RID: 546
	// (get) Token: 0x0600143B RID: 5179 RVA: 0x00007EF0 File Offset: 0x000060F0
	[Token(Token = "0x17000222")]
	public Vector2Int BlockCount
	{
		[Token(Token = "0x600143B")]
		[Address(RVA = "0x1981FF4", Offset = "0x1981FF4", VA = "0x1981FF4")]
		get
		{
			return default(Vector2Int);
		}
	}

	// Token: 0x17000223 RID: 547
	// (get) Token: 0x0600143C RID: 5180 RVA: 0x00007F08 File Offset: 0x00006108
	// (set) Token: 0x0600143D RID: 5181 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000223")]
	public Vector2Int TileCount
	{
		[Token(Token = "0x600143C")]
		[Address(RVA = "0x1981FFC", Offset = "0x1981FFC", VA = "0x1981FFC")]
		[CompilerGenerated]
		get
		{
			return default(Vector2Int);
		}
		[Token(Token = "0x600143D")]
		[Address(RVA = "0x1982004", Offset = "0x1982004", VA = "0x1982004")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000224 RID: 548
	// (get) Token: 0x0600143E RID: 5182 RVA: 0x00007F20 File Offset: 0x00006120
	// (set) Token: 0x0600143F RID: 5183 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000224")]
	public float BlackLandSpeed
	{
		[Token(Token = "0x600143E")]
		[Address(RVA = "0x198200C", Offset = "0x198200C", VA = "0x198200C")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600143F")]
		[Address(RVA = "0x1982014", Offset = "0x1982014", VA = "0x1982014")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06001440 RID: 5184 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001440")]
	[Address(RVA = "0x198201C", Offset = "0x198201C", VA = "0x198201C")]
	public void RegisterPhysics(MonoBehaviour obj)
	{
	}

	// Token: 0x06001441 RID: 5185 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001441")]
	[Address(RVA = "0x1982020", Offset = "0x1982020", VA = "0x1982020")]
	public void UnregisterPhysics(MonoBehaviour obj)
	{
	}

	// Token: 0x06001442 RID: 5186 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001442")]
	[Address(RVA = "0x1982024", Offset = "0x1982024", VA = "0x1982024")]
	public void AddLodAdjuster(AutoAdjustLod adjuster)
	{
	}

	// Token: 0x06001443 RID: 5187 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001443")]
	[Address(RVA = "0x1982138", Offset = "0x1982138", VA = "0x1982138")]
	public void RemoveLodAdjuster(AutoAdjustLod adjuster)
	{
	}

	// Token: 0x06001444 RID: 5188 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001444")]
	[Address(RVA = "0x198215C", Offset = "0x198215C", VA = "0x198215C")]
	public Dictionary<string, LodConfig> GetLodConfigs(int lodType)
	{
		return null;
	}

	// Token: 0x06001445 RID: 5189 RVA: 0x00007F38 File Offset: 0x00006138
	[Token(Token = "0x6001445")]
	[Address(RVA = "0x1982180", Offset = "0x1982180", VA = "0x1982180")]
	public float TileDistance(Vector2Int a, Vector2Int b)
	{
		return 0f;
	}

	// Token: 0x06001446 RID: 5190 RVA: 0x00007F50 File Offset: 0x00006150
	[Token(Token = "0x6001446")]
	[Address(RVA = "0x19821A0", Offset = "0x19821A0", VA = "0x19821A0")]
	public int WorldToTileIndex(Vector3 pos)
	{
		return 0;
	}

	// Token: 0x06001447 RID: 5191 RVA: 0x00007F68 File Offset: 0x00006168
	[Token(Token = "0x6001447")]
	[Address(RVA = "0x19821AC", Offset = "0x19821AC", VA = "0x19821AC")]
	public Vector3 ScreenPointToWorld(Vector3 worldPos, float disPlane = 0f)
	{
		return default(Vector3);
	}

	// Token: 0x06001448 RID: 5192 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001448")]
	[Address(RVA = "0x198235C", Offset = "0x198235C", VA = "0x198235C")]
	public void SetLuaTable(LuaTable table, int edgeTileCnt, int tileX, int tileY, int blockSize, float tileSize)
	{
	}

	// Token: 0x17000225 RID: 549
	// (get) Token: 0x06001449 RID: 5193 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000225")]
	public Transform DynamicObjNode
	{
		[Token(Token = "0x6001449")]
		[Address(RVA = "0x19829C8", Offset = "0x19829C8", VA = "0x19829C8")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000226 RID: 550
	// (get) Token: 0x0600144A RID: 5194 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600144B RID: 5195 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000226")]
	public ITouchPickable SelectBuild
	{
		[Token(Token = "0x600144A")]
		[Address(RVA = "0x1982A90", Offset = "0x1982A90", VA = "0x1982A90")]
		get
		{
			return null;
		}
		[Token(Token = "0x600144B")]
		[Address(RVA = "0x1982AF8", Offset = "0x1982AF8", VA = "0x1982AF8")]
		set
		{
		}
	}

	// Token: 0x17000227 RID: 551
	// (get) Token: 0x0600144C RID: 5196 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600144D RID: 5197 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000227")]
	public List<int> touchPickablePos
	{
		[Token(Token = "0x600144C")]
		[Address(RVA = "0x1982B68", Offset = "0x1982B68", VA = "0x1982B68")]
		get
		{
			return null;
		}
		[Token(Token = "0x600144D")]
		[Address(RVA = "0x1982BF4", Offset = "0x1982BF4", VA = "0x1982BF4")]
		set
		{
		}
	}

	// Token: 0x17000228 RID: 552
	// (get) Token: 0x0600144E RID: 5198 RVA: 0x00007F80 File Offset: 0x00006180
	// (set) Token: 0x0600144F RID: 5199 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000228")]
	public float Zoom
	{
		[Token(Token = "0x600144E")]
		[Address(RVA = "0x1982C90", Offset = "0x1982C90", VA = "0x1982C90")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600144F")]
		[Address(RVA = "0x1982CF8", Offset = "0x1982CF8", VA = "0x1982CF8")]
		set
		{
		}
	}

	// Token: 0x17000229 RID: 553
	// (get) Token: 0x06001450 RID: 5200 RVA: 0x00007F98 File Offset: 0x00006198
	[Token(Token = "0x17000229")]
	public Vector3 CurTarget
	{
		[Token(Token = "0x6001450")]
		[Address(RVA = "0x1982D70", Offset = "0x1982D70", VA = "0x1982D70")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x06001451 RID: 5201 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001451")]
	[Address(RVA = "0x1982DD8", Offset = "0x1982DD8", VA = "0x1982DD8")]
	public void AddAutoScale(AutoAdjustScale autoScale)
	{
	}

	// Token: 0x06001452 RID: 5202 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001452")]
	[Address(RVA = "0x1982EEC", Offset = "0x1982EEC", VA = "0x1982EEC")]
	public void RemoveAutoScale(AutoAdjustScale autoScale)
	{
	}

	// Token: 0x06001453 RID: 5203 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001453")]
	[Address(RVA = "0x1982F10", Offset = "0x1982F10", VA = "0x1982F10")]
	private void Update()
	{
	}

	// Token: 0x06001454 RID: 5204 RVA: 0x00007FB0 File Offset: 0x000061B0
	[Token(Token = "0x6001454")]
	[Address(RVA = "0x1982FD0", Offset = "0x1982FD0", VA = "0x1982FD0")]
	private bool AddBullet(string prefabName, string hitPrefabName, float3 startPos, Quaternion rotation, int tType, int tileSize, Transform trans, bool isSelf, bool showHitEffect = true)
	{
		return default(bool);
	}

	// Token: 0x06001455 RID: 5205 RVA: 0x00007FC8 File Offset: 0x000061C8
	[Token(Token = "0x6001455")]
	[Address(RVA = "0x1983020", Offset = "0x1983020", VA = "0x1983020")]
	public bool AddBulletV2(string prefabName, string hitPrefabName, Vector3 startPos, Quaternion rotation, int tType, int tileSize, Transform trans, bool isSelf, bool showHitEffect = true, float height = 0f, float percent = 0f, float speed = 0f, float flyValue = 0f, BulletFlyType flyType = BulletFlyType.CStyle, float hitDestroyDelay = 0.5f)
	{
		return default(bool);
	}

	// Token: 0x06001456 RID: 5206 RVA: 0x00007FE0 File Offset: 0x000061E0
	[Token(Token = "0x6001456")]
	[Address(RVA = "0x198306C", Offset = "0x198306C", VA = "0x198306C")]
	public bool AddBulletV2_NonGC(int prefabNameId, int hitPrefabNameId, float startPosx, float startPosy, float startPosz, float rotationx, float rotationy, float rotationz, float rotationw, int tType, int tileSize, Transform trans, bool isSelf, bool showHitEffect = true, float height = 0f, float percent = 0f, float speed = 0f, float flyValue = 0f, int flyType = 0, float hitDestroyDelay = 0.5f)
	{
		return default(bool);
	}

	// Token: 0x14000009 RID: 9
	// (add) Token: 0x06001457 RID: 5207 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06001458 RID: 5208 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000009")]
	public event Action AfterUpdate
	{
		[Token(Token = "0x6001457")]
		[Address(RVA = "0x19831C4", Offset = "0x19831C4", VA = "0x19831C4")]
		add
		{
		}
		[Token(Token = "0x6001458")]
		[Address(RVA = "0x1983260", Offset = "0x1983260", VA = "0x1983260")]
		remove
		{
		}
	}

	// Token: 0x06001459 RID: 5209 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001459")]
	[Address(RVA = "0x19832FC", Offset = "0x19832FC", VA = "0x19832FC")]
	public void SetSelectedPickable(ITouchPickable pickable)
	{
	}

	// Token: 0x0600145A RID: 5210 RVA: 0x00007FF8 File Offset: 0x000061F8
	[Token(Token = "0x600145A")]
	[Address(RVA = "0x19833EC", Offset = "0x19833EC", VA = "0x19833EC")]
	public bool GetTouchInputControllerEnable()
	{
		return default(bool);
	}

	// Token: 0x0600145B RID: 5211 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600145B")]
	[Address(RVA = "0x19834B0", Offset = "0x19834B0", VA = "0x19834B0")]
	public void ShowLoad(Vector3 pos)
	{
	}

	// Token: 0x0600145C RID: 5212 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600145C")]
	[Address(RVA = "0x19835F0", Offset = "0x19835F0", VA = "0x19835F0")]
	public void SetFogVisible(bool visible)
	{
	}

	// Token: 0x0600145D RID: 5213 RVA: 0x00008010 File Offset: 0x00006210
	[Token(Token = "0x600145D")]
	[Address(RVA = "0x1983718", Offset = "0x1983718", VA = "0x1983718")]
	public Vector3 TileToWorld(int tilePosX, int tilePosY)
	{
		return default(Vector3);
	}

	// Token: 0x0600145E RID: 5214 RVA: 0x00008028 File Offset: 0x00006228
	[Token(Token = "0x600145E")]
	[Address(RVA = "0x198389C", Offset = "0x198389C", VA = "0x198389C")]
	public Vector3 TileToWorld(Vector2Int tilePos)
	{
		return default(Vector3);
	}

	// Token: 0x0600145F RID: 5215 RVA: 0x00008040 File Offset: 0x00006240
	[Token(Token = "0x600145F")]
	[Address(RVA = "0x19838A4", Offset = "0x19838A4", VA = "0x19838A4")]
	public Vector2Int IndexToTilePos(int index)
	{
		return default(Vector2Int);
	}

	// Token: 0x06001460 RID: 5216 RVA: 0x00008058 File Offset: 0x00006258
	[Token(Token = "0x6001460")]
	[Address(RVA = "0x19838B0", Offset = "0x19838B0", VA = "0x19838B0")]
	public Vector3 TileIndexToWorld(int index)
	{
		return default(Vector3);
	}

	// Token: 0x06001461 RID: 5217 RVA: 0x00008070 File Offset: 0x00006270
	[Token(Token = "0x6001461")]
	[Address(RVA = "0x19838C4", Offset = "0x19838C4", VA = "0x19838C4")]
	public Vector2Int GetTouchTilePos()
	{
		return default(Vector2Int);
	}

	// Token: 0x06001462 RID: 5218 RVA: 0x00008088 File Offset: 0x00006288
	[Token(Token = "0x6001462")]
	[Address(RVA = "0x19839EC", Offset = "0x19839EC", VA = "0x19839EC")]
	public int TilePosToIndex(Vector2Int tilePos)
	{
		return 0;
	}

	// Token: 0x06001463 RID: 5219 RVA: 0x000080A0 File Offset: 0x000062A0
	[Token(Token = "0x6001463")]
	[Address(RVA = "0x1983A00", Offset = "0x1983A00", VA = "0x1983A00")]
	public Vector3 WorldToScreenPoint(Vector3 worldPos)
	{
		return default(Vector3);
	}

	// Token: 0x06001464 RID: 5220 RVA: 0x000080B8 File Offset: 0x000062B8
	[Token(Token = "0x6001464")]
	[Address(RVA = "0x1983B74", Offset = "0x1983B74", VA = "0x1983B74")]
	public float GetMinLodDistance()
	{
		return 0f;
	}

	// Token: 0x06001465 RID: 5221 RVA: 0x000080D0 File Offset: 0x000062D0
	[Token(Token = "0x6001465")]
	[Address(RVA = "0x1983C38", Offset = "0x1983C38", VA = "0x1983C38")]
	public Quaternion GetRotation()
	{
		return default(Quaternion);
	}

	// Token: 0x06001466 RID: 5222 RVA: 0x000080E8 File Offset: 0x000062E8
	[Token(Token = "0x6001466")]
	[Address(RVA = "0x1983C60", Offset = "0x1983C60", VA = "0x1983C60")]
	public Vector3 GetPosition()
	{
		return default(Vector3);
	}

	// Token: 0x06001467 RID: 5223 RVA: 0x00008100 File Offset: 0x00006300
	[Token(Token = "0x6001467")]
	[Address(RVA = "0x1983C88", Offset = "0x1983C88", VA = "0x1983C88")]
	public Vector3 GetRaycastGroundPoint(Vector3 screenPos)
	{
		return default(Vector3);
	}

	// Token: 0x06001468 RID: 5224 RVA: 0x00008118 File Offset: 0x00006318
	[Token(Token = "0x6001468")]
	[Address(RVA = "0x198231C", Offset = "0x198231C", VA = "0x198231C")]
	public Ray ScreenPointToRay(Vector3 pos)
	{
		return default(Ray);
	}

	// Token: 0x06001469 RID: 5225 RVA: 0x00008130 File Offset: 0x00006330
	[Token(Token = "0x6001469")]
	[Address(RVA = "0x1983DF4", Offset = "0x1983DF4", VA = "0x1983DF4")]
	private Vector3 ConvertScreenPoint(Vector3 screenPos)
	{
		return default(Vector3);
	}

	// Token: 0x0600146A RID: 5226 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600146A")]
	[Address(RVA = "0x1983DF8", Offset = "0x1983DF8", VA = "0x1983DF8")]
	public void AutoLookat(Vector3 lookat, float zoom = -1f, float time = 0.2f, [Optional] Action onComplete)
	{
	}

	// Token: 0x0600146B RID: 5227 RVA: 0x00008148 File Offset: 0x00006348
	[Token(Token = "0x600146B")]
	[Address(RVA = "0x1984024", Offset = "0x1984024", VA = "0x1984024")]
	public Vector2Int WorldToTile(Vector3 worldPos)
	{
		return default(Vector2Int);
	}

	// Token: 0x1700022A RID: 554
	// (get) Token: 0x0600146C RID: 5228 RVA: 0x00008160 File Offset: 0x00006360
	[Token(Token = "0x1700022A")]
	public Vector2Int CurTilePos
	{
		[Token(Token = "0x600146C")]
		[Address(RVA = "0x198402C", Offset = "0x198402C", VA = "0x198402C")]
		get
		{
			return default(Vector2Int);
		}
	}

	// Token: 0x0600146D RID: 5229 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600146D")]
	[Address(RVA = "0x1984100", Offset = "0x1984100", VA = "0x1984100")]
	public void HideTouchEffect()
	{
	}

	// Token: 0x0600146E RID: 5230 RVA: 0x00008178 File Offset: 0x00006378
	[Token(Token = "0x600146E")]
	[Address(RVA = "0x19841B0", Offset = "0x19841B0", VA = "0x19841B0")]
	public int GetLodLevel()
	{
		return 0;
	}

	// Token: 0x0600146F RID: 5231 RVA: 0x00008190 File Offset: 0x00006390
	[Token(Token = "0x600146F")]
	[Address(RVA = "0x1984274", Offset = "0x1984274", VA = "0x1984274")]
	public Vector3 TileFloatToWorld(Vector2 tilePos)
	{
		return default(Vector3);
	}

	// Token: 0x06001470 RID: 5232 RVA: 0x000081A8 File Offset: 0x000063A8
	[Token(Token = "0x6001470")]
	[Address(RVA = "0x198427C", Offset = "0x198427C", VA = "0x198427C")]
	public Vector3 TileFloatToWorld(float x, float y)
	{
		return default(Vector3);
	}

	// Token: 0x06001471 RID: 5233 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001471")]
	[Address(RVA = "0x1984284", Offset = "0x1984284", VA = "0x1984284")]
	public void SetWorldSize(int size)
	{
	}

	// Token: 0x06001472 RID: 5234 RVA: 0x000081C0 File Offset: 0x000063C0
	[Token(Token = "0x6001472")]
	[Address(RVA = "0x19843D0", Offset = "0x19843D0", VA = "0x19843D0")]
	public bool IsInMap(Vector2Int pt)
	{
		return default(bool);
	}

	// Token: 0x06001473 RID: 5235 RVA: 0x000081D8 File Offset: 0x000063D8
	[Token(Token = "0x6001473")]
	[Address(RVA = "0x1984410", Offset = "0x1984410", VA = "0x1984410")]
	public float GetLodDistance()
	{
		return 0f;
	}

	// Token: 0x1700022B RID: 555
	// (get) Token: 0x06001474 RID: 5236 RVA: 0x000081F0 File Offset: 0x000063F0
	[Token(Token = "0x1700022B")]
	public float InitZoom
	{
		[Token(Token = "0x6001474")]
		[Address(RVA = "0x19844D4", Offset = "0x19844D4", VA = "0x19844D4")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700022C RID: 556
	// (get) Token: 0x06001475 RID: 5237 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001476 RID: 5238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700022C")]
	public FakeModelManager FakeModelManager
	{
		[Token(Token = "0x6001475")]
		[Address(RVA = "0x198453C", Offset = "0x198453C", VA = "0x198453C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001476")]
		[Address(RVA = "0x1984544", Offset = "0x1984544", VA = "0x1984544")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x1700022D RID: 557
	// (get) Token: 0x06001477 RID: 5239 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001478 RID: 5240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700022D")]
	private WorldCulling Culling
	{
		[Token(Token = "0x6001477")]
		[Address(RVA = "0x198454C", Offset = "0x198454C", VA = "0x198454C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001478")]
		[Address(RVA = "0x1984554", Offset = "0x1984554", VA = "0x1984554")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x1700022E RID: 558
	// (get) Token: 0x06001479 RID: 5241 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700022E")]
	private WorldStaticManager StaticManager
	{
		[Token(Token = "0x6001479")]
		[Address(RVA = "0x1984564", Offset = "0x1984564", VA = "0x1984564")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700022F RID: 559
	// (get) Token: 0x0600147A RID: 5242 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600147B RID: 5243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700022F")]
	private WorldMapZoneManager WorldMapZoneManager
	{
		[Token(Token = "0x600147A")]
		[Address(RVA = "0x1984654", Offset = "0x1984654", VA = "0x1984654")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600147B")]
		[Address(RVA = "0x198465C", Offset = "0x198465C", VA = "0x198465C")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000230 RID: 560
	// (get) Token: 0x0600147C RID: 5244 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600147D RID: 5245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000230")]
	private WorldEdenAreaManager WorldEdenAreaManager
	{
		[Token(Token = "0x600147C")]
		[Address(RVA = "0x198466C", Offset = "0x198466C", VA = "0x198466C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600147D")]
		[Address(RVA = "0x1984674", Offset = "0x1984674", VA = "0x1984674")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000231 RID: 561
	// (get) Token: 0x0600147E RID: 5246 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000231")]
	private WorldLodManager LodManager
	{
		[Token(Token = "0x600147E")]
		[Address(RVA = "0x1982048", Offset = "0x1982048", VA = "0x1982048")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000232 RID: 562
	// (get) Token: 0x0600147F RID: 5247 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000232")]
	private WorldAutoMonoManager AutoMonoManager
	{
		[Token(Token = "0x600147F")]
		[Address(RVA = "0x1982DFC", Offset = "0x1982DFC", VA = "0x1982DFC")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001480 RID: 5248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001480")]
	[Address(RVA = "0x1984684", Offset = "0x1984684", VA = "0x1984684")]
	public void UnInitSubModule()
	{
	}

	// Token: 0x06001481 RID: 5249 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001481")]
	[Address(RVA = "0x1984A74", Offset = "0x1984A74", VA = "0x1984A74")]
	public void Destroy()
	{
	}

	// Token: 0x06001482 RID: 5250 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001482")]
	[Address(RVA = "0x1984A78", Offset = "0x1984A78", VA = "0x1984A78")]
	private void SetPostProcessQuality()
	{
	}

	// Token: 0x06001483 RID: 5251 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001483")]
	[Address(RVA = "0x1984A7C", Offset = "0x1984A7C", VA = "0x1984A7C")]
	public void ChangeQualitySetting()
	{
	}

	// Token: 0x06001484 RID: 5252 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001484")]
	[Address(RVA = "0x1984A80", Offset = "0x1984A80", VA = "0x1984A80")]
	public void OnDrawGizmos()
	{
	}

	// Token: 0x06001485 RID: 5253 RVA: 0x00008208 File Offset: 0x00006408
	[Token(Token = "0x6001485")]
	[Address(RVA = "0x1984F78", Offset = "0x1984F78", VA = "0x1984F78")]
	public int GetGlobalShaderLOD()
	{
		return 0;
	}

	// Token: 0x06001486 RID: 5254 RVA: 0x00008220 File Offset: 0x00006420
	[Token(Token = "0x6001486")]
	[Address(RVA = "0x1984F80", Offset = "0x1984F80", VA = "0x1984F80")]
	public bool SetGlobalShaderLOD(int level)
	{
		return default(bool);
	}

	// Token: 0x06001487 RID: 5255 RVA: 0x00008238 File Offset: 0x00006438
	[Token(Token = "0x6001487")]
	[Address(RVA = "0x198507C", Offset = "0x198507C", VA = "0x198507C")]
	public bool GetProfileTerrainSwitch()
	{
		return default(bool);
	}

	// Token: 0x06001488 RID: 5256 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001488")]
	[Address(RVA = "0x1985098", Offset = "0x1985098", VA = "0x1985098")]
	public void ProfileToggleTerrain()
	{
	}

	// Token: 0x06001489 RID: 5257 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001489")]
	[Address(RVA = "0x1985264", Offset = "0x1985264", VA = "0x1985264")]
	public void ProfileToggleGlass()
	{
	}

	// Token: 0x0600148A RID: 5258 RVA: 0x00008250 File Offset: 0x00006450
	[Token(Token = "0x600148A")]
	[Address(RVA = "0x1985268", Offset = "0x1985268", VA = "0x1985268")]
	public bool GetProfileBuildingSwitch()
	{
		return default(bool);
	}

	// Token: 0x0600148B RID: 5259 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600148B")]
	[Address(RVA = "0x1985270", Offset = "0x1985270", VA = "0x1985270")]
	public void ProfileToggleBuilding()
	{
	}

	// Token: 0x0600148C RID: 5260 RVA: 0x00008268 File Offset: 0x00006468
	[Token(Token = "0x600148C")]
	[Address(RVA = "0x1985274", Offset = "0x1985274", VA = "0x1985274")]
	public bool GetProfileStaticSwitch()
	{
		return default(bool);
	}

	// Token: 0x0600148D RID: 5261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600148D")]
	[Address(RVA = "0x198527C", Offset = "0x198527C", VA = "0x198527C")]
	public void ProfileToggleStatic()
	{
	}

	// Token: 0x0600148E RID: 5262 RVA: 0x00008280 File Offset: 0x00006480
	[Token(Token = "0x600148E")]
	[Address(RVA = "0x1985280", Offset = "0x1985280", VA = "0x1985280")]
	public bool GetHeightFogSwitch()
	{
		return default(bool);
	}

	// Token: 0x0600148F RID: 5263 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600148F")]
	[Address(RVA = "0x1985288", Offset = "0x1985288", VA = "0x1985288")]
	public void ProfileToggleHeightFog()
	{
	}

	// Token: 0x17000233 RID: 563
	// (get) Token: 0x06001490 RID: 5264 RVA: 0x00008298 File Offset: 0x00006498
	[Token(Token = "0x17000233")]
	public int frameBufferWidth
	{
		[Token(Token = "0x6001490")]
		[Address(RVA = "0x198528C", Offset = "0x198528C", VA = "0x198528C")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000234 RID: 564
	// (get) Token: 0x06001491 RID: 5265 RVA: 0x000082B0 File Offset: 0x000064B0
	[Token(Token = "0x17000234")]
	public int frameBufferHeight
	{
		[Token(Token = "0x6001491")]
		[Address(RVA = "0x1985294", Offset = "0x1985294", VA = "0x1985294")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06001492 RID: 5266 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001492")]
	[Address(RVA = "0x198529C", Offset = "0x198529C", VA = "0x198529C")]
	public WorldScene()
	{
	}

	// Token: 0x04001742 RID: 5954
	[Token(Token = "0x4001742")]
	[FieldOffset(Offset = "0x18")]
	private LuaTable _luaTable;

	// Token: 0x04001743 RID: 5955
	[Token(Token = "0x4001743")]
	[FieldOffset(Offset = "0x20")]
	private LuaFunction _TileXYToWorld;

	// Token: 0x04001744 RID: 5956
	[Token(Token = "0x4001744")]
	[FieldOffset(Offset = "0x28")]
	private LuaFunction _HideTouchEffect;

	// Token: 0x04001745 RID: 5957
	[Token(Token = "0x4001745")]
	[FieldOffset(Offset = "0x30")]
	private LuaFunction _GetTouchTilePos;

	// Token: 0x04001746 RID: 5958
	[Token(Token = "0x4001746")]
	[FieldOffset(Offset = "0x38")]
	private LuaFunction _AutoLookat;

	// Token: 0x04001747 RID: 5959
	[Token(Token = "0x4001747")]
	[FieldOffset(Offset = "0x40")]
	private LuaFunction _GetLodDistance;

	// Token: 0x04001748 RID: 5960
	[Token(Token = "0x4001748")]
	[FieldOffset(Offset = "0x48")]
	private LuaFunction _GetLodLevel;

	// Token: 0x04001749 RID: 5961
	[Token(Token = "0x4001749")]
	[FieldOffset(Offset = "0x50")]
	private LuaFunction _InitZoom;

	// Token: 0x0400174A RID: 5962
	[Token(Token = "0x400174A")]
	[FieldOffset(Offset = "0x58")]
	private LuaFunction _SetFogVisible;

	// Token: 0x0400174B RID: 5963
	[Token(Token = "0x400174B")]
	[FieldOffset(Offset = "0x60")]
	private LuaFunction _SetSelectedPickable;

	// Token: 0x0400174C RID: 5964
	[Token(Token = "0x400174C")]
	[FieldOffset(Offset = "0x68")]
	private LuaFunction _GetTouchInputControllerEnable;

	// Token: 0x0400174D RID: 5965
	[Token(Token = "0x400174D")]
	[FieldOffset(Offset = "0x70")]
	private LuaFunction _ShowLoad;

	// Token: 0x0400174E RID: 5966
	[Token(Token = "0x400174E")]
	[FieldOffset(Offset = "0x78")]
	private LuaFunction _GetMinLodDistance;

	// Token: 0x0400174F RID: 5967
	[Token(Token = "0x400174F")]
	[FieldOffset(Offset = "0x80")]
	private LuaFunction _GetLodManager;

	// Token: 0x04001750 RID: 5968
	[Token(Token = "0x4001750")]
	[FieldOffset(Offset = "0x88")]
	private LuaFunction _GetStaticManager;

	// Token: 0x04001751 RID: 5969
	[Token(Token = "0x4001751")]
	[FieldOffset(Offset = "0x90")]
	private LuaFunction _GetAutoMonoManager;

	// Token: 0x04001752 RID: 5970
	[Token(Token = "0x4001752")]
	[FieldOffset(Offset = "0x98")]
	private BulletManager _bulletManager;

	// Token: 0x04001753 RID: 5971
	[Token(Token = "0x4001753")]
	[FieldOffset(Offset = "0xA0")]
	public bool InitDone;

	// Token: 0x04001754 RID: 5972
	[Token(Token = "0x4001754")]
	[FieldOffset(Offset = "0x0")]
	public static int EdgeTileCount;

	// Token: 0x04001755 RID: 5973
	[Token(Token = "0x4001755")]
	[FieldOffset(Offset = "0x4")]
	public static int TileCountX;

	// Token: 0x04001756 RID: 5974
	[Token(Token = "0x4001756")]
	[FieldOffset(Offset = "0x8")]
	public static int TileCountY;

	// Token: 0x04001757 RID: 5975
	[Token(Token = "0x4001757")]
	[FieldOffset(Offset = "0xA4")]
	public int BlockSize;

	// Token: 0x04001758 RID: 5976
	[Token(Token = "0x4001758")]
	[FieldOffset(Offset = "0xA8")]
	public float TileSize;

	// Token: 0x0400175E RID: 5982
	[Token(Token = "0x400175E")]
	[FieldOffset(Offset = "0xC0")]
	private Vector2Int kBlockCount;

	// Token: 0x04001761 RID: 5985
	[Token(Token = "0x4001761")]
	[FieldOffset(Offset = "0xD8")]
	private Camera mainCamera;

	// Token: 0x04001762 RID: 5986
	[Token(Token = "0x4001762")]
	[FieldOffset(Offset = "0xE0")]
	private MobileTouchCamera touchCamera;

	// Token: 0x04001763 RID: 5987
	[Token(Token = "0x4001763")]
	[FieldOffset(Offset = "0xE8")]
	private Transform _dynamicObjNode;

	// Token: 0x04001765 RID: 5989
	[Token(Token = "0x4001765")]
	[FieldOffset(Offset = "0xF8")]
	private List<WorldManagerBase> subModules;

	// Token: 0x04001767 RID: 5991
	[Token(Token = "0x4001767")]
	[FieldOffset(Offset = "0x108")]
	private WorldStaticManager _staticManager;

	// Token: 0x0400176A RID: 5994
	[Token(Token = "0x400176A")]
	[FieldOffset(Offset = "0x120")]
	private WorldLodManager _lodManager;

	// Token: 0x0400176B RID: 5995
	[Token(Token = "0x400176B")]
	[FieldOffset(Offset = "0x128")]
	private WorldAutoMonoManager _autoMonoManager;

	// Token: 0x0400176C RID: 5996
	[Token(Token = "0x400176C")]
	[FieldOffset(Offset = "0x10")]
	private static Dictionary<Type, string> PostprocessSettingKeys;

	// Token: 0x0400176D RID: 5997
	[Token(Token = "0x400176D")]
	[FieldOffset(Offset = "0x130")]
	private Vector3[] frustumPoints;
}
