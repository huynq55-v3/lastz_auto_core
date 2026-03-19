using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EPOOutline;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

// Token: 0x02000303 RID: 771
[Token(Token = "0x2000303")]
public class WorldMapZoneManager : WorldManagerBase
{
	// Token: 0x1700021A RID: 538
	// (get) Token: 0x06001402 RID: 5122 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001403 RID: 5123 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700021A")]
	public Dictionary<int, WorldZone> WorldZones
	{
		[Token(Token = "0x6001402")]
		[Address(RVA = "0x1A54C98", Offset = "0x1A54C98", VA = "0x1A54C98")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001403")]
		[Address(RVA = "0x1A54CA0", Offset = "0x1A54CA0", VA = "0x1A54CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x1700021B RID: 539
	// (get) Token: 0x06001404 RID: 5124 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001405 RID: 5125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700021B")]
	public Transform EdgeRoot
	{
		[Token(Token = "0x6001404")]
		[Address(RVA = "0x1A54CA8", Offset = "0x1A54CA8", VA = "0x1A54CA8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001405")]
		[Address(RVA = "0x1A54CB0", Offset = "0x1A54CB0", VA = "0x1A54CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x1700021C RID: 540
	// (get) Token: 0x06001406 RID: 5126 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001407 RID: 5127 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700021C")]
	public Transform ZoneRoot
	{
		[Token(Token = "0x6001406")]
		[Address(RVA = "0x1A54CB8", Offset = "0x1A54CB8", VA = "0x1A54CB8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001407")]
		[Address(RVA = "0x1A54CC0", Offset = "0x1A54CC0", VA = "0x1A54CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06001408 RID: 5128 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001408")]
	[Address(RVA = "0x1A54CC8", Offset = "0x1A54CC8", VA = "0x1A54CC8")]
	public Material GetEdgeMaterial(int matIdx, Color color)
	{
		return null;
	}

	// Token: 0x06001409 RID: 5129 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001409")]
	[Address(RVA = "0x1A54E44", Offset = "0x1A54E44", VA = "0x1A54E44")]
	public Material GetZoneMaterial(GameObject go)
	{
		return null;
	}

	// Token: 0x0600140A RID: 5130 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600140A")]
	[Address(RVA = "0x1A54F9C", Offset = "0x1A54F9C", VA = "0x1A54F9C")]
	public WorldMapZoneManager(WorldScene scene)
	{
	}

	// Token: 0x0600140B RID: 5131 RVA: 0x00007DD0 File Offset: 0x00005FD0
	[Token(Token = "0x600140B")]
	[Address(RVA = "0x1A55300", Offset = "0x1A55300", VA = "0x1A55300")]
	private static bool IsFuncOpen()
	{
		return default(bool);
	}

	// Token: 0x0600140C RID: 5132 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600140C")]
	[Address(RVA = "0x1A55490", Offset = "0x1A55490", VA = "0x1A55490")]
	public void ShowZoneMap()
	{
	}

	// Token: 0x0600140D RID: 5133 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600140D")]
	[Address(RVA = "0x1A55568", Offset = "0x1A55568", VA = "0x1A55568")]
	public void HideZoneMap()
	{
	}

	// Token: 0x0600140E RID: 5134 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600140E")]
	[Address(RVA = "0x1A5563C", Offset = "0x1A5563C", VA = "0x1A5563C", Slot = "4")]
	public override void Init()
	{
	}

	// Token: 0x0600140F RID: 5135 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600140F")]
	[Address(RVA = "0x1A55E70", Offset = "0x1A55E70", VA = "0x1A55E70")]
	public void SetLoadCompleteCallback(Action callback)
	{
	}

	// Token: 0x06001410 RID: 5136 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001410")]
	[Address(RVA = "0x1A55E80", Offset = "0x1A55E80", VA = "0x1A55E80")]
	private void ToggleOutlinerComponent(bool t)
	{
	}

	// Token: 0x06001411 RID: 5137 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001411")]
	[Address(RVA = "0x1A55F18", Offset = "0x1A55F18", VA = "0x1A55F18")]
	private void DelayActive()
	{
	}

	// Token: 0x06001412 RID: 5138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001412")]
	[Address(RVA = "0x1A55FAC", Offset = "0x1A55FAC", VA = "0x1A55FAC", Slot = "5")]
	public override void UnInit()
	{
	}

	// Token: 0x06001413 RID: 5139 RVA: 0x00007DE8 File Offset: 0x00005FE8
	[Token(Token = "0x6001413")]
	[Address(RVA = "0x1A562AC", Offset = "0x1A562AC", VA = "0x1A562AC")]
	private bool IsInited()
	{
		return default(bool);
	}

	// Token: 0x06001414 RID: 5140 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001414")]
	[Address(RVA = "0x1A55AF4", Offset = "0x1A55AF4", VA = "0x1A55AF4")]
	private void LoadWorldCityColor()
	{
	}

	// Token: 0x06001415 RID: 5141 RVA: 0x00007E00 File Offset: 0x00006000
	[Token(Token = "0x6001415")]
	[Address(RVA = "0x1A562BC", Offset = "0x1A562BC", VA = "0x1A562BC")]
	public int GetZoneIdByPosId(int pointId)
	{
		return 0;
	}

	// Token: 0x06001416 RID: 5142 RVA: 0x00007E18 File Offset: 0x00006018
	[Token(Token = "0x6001416")]
	[Address(RVA = "0x1A562DC", Offset = "0x1A562DC", VA = "0x1A562DC")]
	public bool IsPointInAllianceCity(int pointId)
	{
		return default(bool);
	}

	// Token: 0x06001417 RID: 5143 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001417")]
	[Address(RVA = "0x1A56474", Offset = "0x1A56474", VA = "0x1A56474")]
	public WorldCityColor GetWorldCityColor(int index)
	{
		return null;
	}

	// Token: 0x06001418 RID: 5144 RVA: 0x00007E30 File Offset: 0x00006030
	[Token(Token = "0x6001418")]
	[Address(RVA = "0x1A564EC", Offset = "0x1A564EC", VA = "0x1A564EC")]
	public Vector4 GetZoneRect(int zoneIndex)
	{
		return default(Vector4);
	}

	// Token: 0x06001419 RID: 5145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001419")]
	[Address(RVA = "0x1A55CE0", Offset = "0x1A55CE0", VA = "0x1A55CE0")]
	private void LoadMapDataFromFile(Action callback)
	{
	}

	// Token: 0x0600141A RID: 5146 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600141A")]
	[Address(RVA = "0x1A565B0", Offset = "0x1A565B0", VA = "0x1A565B0")]
	private void OnCameraAfterUpdate()
	{
	}

	// Token: 0x0600141B RID: 5147 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600141B")]
	[Address(RVA = "0x1A56A94", Offset = "0x1A56A94", VA = "0x1A56A94")]
	private void OnBgClick()
	{
	}

	// Token: 0x0600141C RID: 5148 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600141C")]
	[Address(RVA = "0x1A565C4", Offset = "0x1A565C4", VA = "0x1A565C4")]
	private void OnClip([Optional] object sender)
	{
	}

	// Token: 0x0600141D RID: 5149 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600141D")]
	[Address(RVA = "0x1A57650", Offset = "0x1A57650", VA = "0x1A57650")]
	private void CalcClipData(RectInt rect, ref List<WorldZone> zones)
	{
	}

	// Token: 0x0600141E RID: 5150 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600141E")]
	[Address(RVA = "0x1A56B28", Offset = "0x1A56B28", VA = "0x1A56B28")]
	private void DoClipEdges(RectInt rect)
	{
	}

	// Token: 0x0600141F RID: 5151 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600141F")]
	[Address(RVA = "0x1A570B8", Offset = "0x1A570B8", VA = "0x1A570B8")]
	private void DoClipZones(RectInt rect, Vector3 camRot)
	{
	}

	// Token: 0x06001420 RID: 5152 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001420")]
	[Address(RVA = "0x1A5770C", Offset = "0x1A5770C", VA = "0x1A5770C")]
	private List<int> UpdateAllZoneOwner()
	{
		return null;
	}

	// Token: 0x06001421 RID: 5153 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001421")]
	[Address(RVA = "0x1A57EF8", Offset = "0x1A57EF8", VA = "0x1A57EF8")]
	private WorldZone GetWorldZoneInfoById(int zoneId)
	{
		return null;
	}

	// Token: 0x06001422 RID: 5154 RVA: 0x00007E48 File Offset: 0x00006048
	[Token(Token = "0x6001422")]
	[Address(RVA = "0x1A57D28", Offset = "0x1A57D28", VA = "0x1A57D28")]
	public bool GetZoneOwnerAllianceInfo(int zoneId, out string allianceId, out int color)
	{
		return default(bool);
	}

	// Token: 0x06001423 RID: 5155 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001423")]
	[Address(RVA = "0x1A57F70", Offset = "0x1A57F70", VA = "0x1A57F70")]
	private void OnCityOwnerInfoReceived(object o)
	{
	}

	// Token: 0x06001424 RID: 5156 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001424")]
	[Address(RVA = "0x1A57F80", Offset = "0x1A57F80", VA = "0x1A57F80")]
	private void OnCityOwnerInfoChanged([Optional] object o)
	{
	}

	// Token: 0x06001425 RID: 5157 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001425")]
	[Address(RVA = "0x1A580F0", Offset = "0x1A580F0", VA = "0x1A580F0")]
	private void DoCityColorChange(object o)
	{
	}

	// Token: 0x06001426 RID: 5158 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001426")]
	[Address(RVA = "0x1A582D8", Offset = "0x1A582D8", VA = "0x1A582D8")]
	public Texture2D[] GetTextures()
	{
		return null;
	}

	// Token: 0x06001427 RID: 5159 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001427")]
	[Address(RVA = "0x1A582F4", Offset = "0x1A582F4", VA = "0x1A582F4")]
	private void OnLodChanged(object userdata)
	{
	}

	// Token: 0x040016CF RID: 5839
	[Token(Token = "0x40016CF")]
	private const string ZoneMapPrefab = "Assets/Main/Scenes/Zone/Prefab/ZoneMapRoot.prefab";

	// Token: 0x040016D0 RID: 5840
	[Token(Token = "0x40016D0")]
	public const string EdgeMeshPath = "Assets/Main/Scenes/Zone/Edges/edge_{0}_{1}.asset";

	// Token: 0x040016D1 RID: 5841
	[Token(Token = "0x40016D1")]
	public const string WorldCityColorTable = "worldcity_color";

	// Token: 0x040016D2 RID: 5842
	[Token(Token = "0x40016D2")]
	[FieldOffset(Offset = "0x18")]
	private float _cityUiScaleUp;

	// Token: 0x040016D3 RID: 5843
	[Token(Token = "0x40016D3")]
	[FieldOffset(Offset = "0x20")]
	[NonSerialized]
	public Transform ZoneTemplate;

	// Token: 0x040016D4 RID: 5844
	[Token(Token = "0x40016D4")]
	[FieldOffset(Offset = "0x28")]
	private bool TestColor;

	// Token: 0x040016D5 RID: 5845
	[Token(Token = "0x40016D5")]
	private const float ZonePosToTilePos = 1f;

	// Token: 0x040016D6 RID: 5846
	[Token(Token = "0x40016D6")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 ShadowOffset;

	// Token: 0x040016D7 RID: 5847
	[Token(Token = "0x40016D7")]
	[FieldOffset(Offset = "0x0")]
	public static Color ZoneOutlineDefColor;

	// Token: 0x040016D8 RID: 5848
	[Token(Token = "0x40016D8")]
	[FieldOffset(Offset = "0x38")]
	private WorldMapZoneManager.LoadState _loadState;

	// Token: 0x040016D9 RID: 5849
	[Token(Token = "0x40016D9")]
	[FieldOffset(Offset = "0x40")]
	private WorldZoneTreeNode _findNode;

	// Token: 0x040016DB RID: 5851
	[Token(Token = "0x40016DB")]
	[FieldOffset(Offset = "0x50")]
	private WorldZoneMapData _zoneMapData;

	// Token: 0x040016DC RID: 5852
	[Token(Token = "0x40016DC")]
	[FieldOffset(Offset = "0x58")]
	private WorldZoneMapRoot _zoneMapRoot;

	// Token: 0x040016DF RID: 5855
	[Token(Token = "0x40016DF")]
	[FieldOffset(Offset = "0x70")]
	private Dictionary<int, Dictionary<int, GameObject>> _edgeEntities;

	// Token: 0x040016E0 RID: 5856
	[Token(Token = "0x40016E0")]
	[FieldOffset(Offset = "0x78")]
	private AutoAdjustLod adjuster;

	// Token: 0x040016E1 RID: 5857
	[Token(Token = "0x40016E1")]
	[FieldOffset(Offset = "0x80")]
	private Transform _smallMap;

	// Token: 0x040016E2 RID: 5858
	[Token(Token = "0x40016E2")]
	[FieldOffset(Offset = "0x88")]
	private readonly List<WorldZone> _lastClippedZones;

	// Token: 0x040016E3 RID: 5859
	[Token(Token = "0x40016E3")]
	[FieldOffset(Offset = "0x90")]
	private List<WorldZone> _clippedZones;

	// Token: 0x040016E4 RID: 5860
	[Token(Token = "0x40016E4")]
	[FieldOffset(Offset = "0x98")]
	private readonly List<WorldZone> _lastClippedEdges;

	// Token: 0x040016E5 RID: 5861
	[Token(Token = "0x40016E5")]
	[FieldOffset(Offset = "0xA0")]
	private List<WorldZone> _clippedEdges;

	// Token: 0x040016E6 RID: 5862
	[Token(Token = "0x40016E6")]
	[FieldOffset(Offset = "0xA8")]
	public Dictionary<int, Vector4> zonePos;

	// Token: 0x040016E7 RID: 5863
	[Token(Token = "0x40016E7")]
	[FieldOffset(Offset = "0xB0")]
	private int _worldCityColorCount;

	// Token: 0x040016E8 RID: 5864
	[Token(Token = "0x40016E8")]
	[FieldOffset(Offset = "0xB8")]
	private readonly Dictionary<int, WorldCityColor> _worldCityColors;

	// Token: 0x040016E9 RID: 5865
	[Token(Token = "0x40016E9")]
	[FieldOffset(Offset = "0xC0")]
	private LuaTable _allianceCityLuaTable;

	// Token: 0x040016EA RID: 5866
	[Token(Token = "0x40016EA")]
	[FieldOffset(Offset = "0xC8")]
	private LuaTable _iceZoneCityLuaTable;

	// Token: 0x040016EB RID: 5867
	[Token(Token = "0x40016EB")]
	[FieldOffset(Offset = "0xD0")]
	private bool _functionOn;

	// Token: 0x040016EC RID: 5868
	[Token(Token = "0x40016EC")]
	[FieldOffset(Offset = "0xD8")]
	private Material _edgeMaterial1;

	// Token: 0x040016ED RID: 5869
	[Token(Token = "0x40016ED")]
	[FieldOffset(Offset = "0xE0")]
	private Material _edgeMaterial2;

	// Token: 0x040016EE RID: 5870
	[Token(Token = "0x40016EE")]
	[FieldOffset(Offset = "0xE8")]
	private Material _zoneMaterial1;

	// Token: 0x040016EF RID: 5871
	[Token(Token = "0x40016EF")]
	[FieldOffset(Offset = "0xF0")]
	private Material _zoneMaterial2;

	// Token: 0x040016F0 RID: 5872
	[Token(Token = "0x40016F0")]
	[FieldOffset(Offset = "0x10")]
	private static readonly Dictionary<Color, Material> CacheEdgeMat1;

	// Token: 0x040016F1 RID: 5873
	[Token(Token = "0x40016F1")]
	[FieldOffset(Offset = "0x18")]
	private static readonly Dictionary<Color, Material> CacheEdgeMat2;

	// Token: 0x040016F2 RID: 5874
	[Token(Token = "0x40016F2")]
	[FieldOffset(Offset = "0x20")]
	private static readonly Dictionary<GameObject, Material> ZoneMaterialCache;

	// Token: 0x040016F3 RID: 5875
	[Token(Token = "0x40016F3")]
	[FieldOffset(Offset = "0xF8")]
	private Material _useMaterial;

	// Token: 0x040016F4 RID: 5876
	[Token(Token = "0x40016F4")]
	[FieldOffset(Offset = "0x100")]
	private int allianceCityCenterOffset;

	// Token: 0x040016F5 RID: 5877
	[Token(Token = "0x40016F5")]
	[FieldOffset(Offset = "0x104")]
	private int allianceCityRange;

	// Token: 0x040016F6 RID: 5878
	[Token(Token = "0x40016F6")]
	[FieldOffset(Offset = "0x108")]
	private Outliner _outlinerCom;

	// Token: 0x040016F7 RID: 5879
	[Token(Token = "0x40016F7")]
	[FieldOffset(Offset = "0x110")]
	private bool gameObjActive;

	// Token: 0x040016F8 RID: 5880
	[Token(Token = "0x40016F8")]
	[FieldOffset(Offset = "0x118")]
	private Action loadCompleteCallback;

	// Token: 0x040016F9 RID: 5881
	[Token(Token = "0x40016F9")]
	[FieldOffset(Offset = "0x120")]
	private Vector3 _p0;

	// Token: 0x040016FA RID: 5882
	[Token(Token = "0x40016FA")]
	[FieldOffset(Offset = "0x12C")]
	private Vector3 _p1;

	// Token: 0x040016FB RID: 5883
	[Token(Token = "0x40016FB")]
	[FieldOffset(Offset = "0x138")]
	private Vector3 _p2;

	// Token: 0x040016FC RID: 5884
	[Token(Token = "0x40016FC")]
	[FieldOffset(Offset = "0x144")]
	private Vector3 _p3;

	// Token: 0x040016FD RID: 5885
	[Token(Token = "0x40016FD")]
	[FieldOffset(Offset = "0x150")]
	private Vector3 _curPos;

	// Token: 0x040016FE RID: 5886
	[Token(Token = "0x40016FE")]
	[FieldOffset(Offset = "0x160")]
	private readonly Vector2Int[] _camVerts;

	// Token: 0x040016FF RID: 5887
	[Token(Token = "0x40016FF")]
	[FieldOffset(Offset = "0x168")]
	private Vector3 _lastCamPosition;

	// Token: 0x04001700 RID: 5888
	[Token(Token = "0x4001700")]
	[FieldOffset(Offset = "0x174")]
	private Rect _lastRect;

	// Token: 0x02000304 RID: 772
	[Token(Token = "0x2000304")]
	private enum LoadState
	{
		// Token: 0x04001702 RID: 5890
		[Token(Token = "0x4001702")]
		None,
		// Token: 0x04001703 RID: 5891
		[Token(Token = "0x4001703")]
		StartLoad,
		// Token: 0x04001704 RID: 5892
		[Token(Token = "0x4001704")]
		Update,
		// Token: 0x04001705 RID: 5893
		[Token(Token = "0x4001705")]
		Loaded
	}
}
