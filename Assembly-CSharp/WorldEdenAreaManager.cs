using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002F7 RID: 759
[Token(Token = "0x20002F7")]
public class WorldEdenAreaManager : WorldManagerBase
{
	// Token: 0x060013BE RID: 5054 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013BE")]
	[Address(RVA = "0x1A503E0", Offset = "0x1A503E0", VA = "0x1A503E0")]
	public WorldEdenAreaManager(WorldScene scene)
	{
	}

	// Token: 0x060013BF RID: 5055 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013BF")]
	[Address(RVA = "0x1A50484", Offset = "0x1A50484", VA = "0x1A50484", Slot = "4")]
	public override void Init()
	{
	}

	// Token: 0x060013C0 RID: 5056 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013C0")]
	[Address(RVA = "0x1A50670", Offset = "0x1A50670", VA = "0x1A50670")]
	private void LoadMapDataFromFile(Action callback)
	{
	}

	// Token: 0x060013C1 RID: 5057 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013C1")]
	[Address(RVA = "0x1A50888", Offset = "0x1A50888", VA = "0x1A50888")]
	private void InitPassData()
	{
	}

	// Token: 0x060013C2 RID: 5058 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013C2")]
	[Address(RVA = "0x1A51404", Offset = "0x1A51404", VA = "0x1A51404", Slot = "5")]
	public override void UnInit()
	{
	}

	// Token: 0x060013C3 RID: 5059 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013C3")]
	[Address(RVA = "0x1A5154C", Offset = "0x1A5154C", VA = "0x1A5154C", Slot = "6")]
	public override void OnUpdate(float deltaTime)
	{
	}

	// Token: 0x060013C4 RID: 5060 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013C4")]
	[Address(RVA = "0x1A51550", Offset = "0x1A51550", VA = "0x1A51550")]
	private void OnPassOwnerInfoReceived([Optional] object o)
	{
	}

	// Token: 0x060013C5 RID: 5061 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013C5")]
	[Address(RVA = "0x1A51554", Offset = "0x1A51554", VA = "0x1A51554")]
	private void OnPassOwnerInfoChanged([Optional] object o)
	{
	}

	// Token: 0x060013C6 RID: 5062 RVA: 0x00007CB0 File Offset: 0x00005EB0
	[Token(Token = "0x60013C6")]
	[Address(RVA = "0x1A517E4", Offset = "0x1A517E4", VA = "0x1A517E4")]
	public int GetAreaIdByPosId(int pointId)
	{
		return 0;
	}

	// Token: 0x060013C7 RID: 5063 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013C7")]
	[Address(RVA = "0x1A51840", Offset = "0x1A51840", VA = "0x1A51840")]
	public EdenAreaInfo GetEdenAreaInfo(int areaId)
	{
		return null;
	}

	// Token: 0x060013C8 RID: 5064 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013C8")]
	[Address(RVA = "0x1A518C8", Offset = "0x1A518C8", VA = "0x1A518C8")]
	public string FindingPath(int startIndex, int endIndex)
	{
		return null;
	}

	// Token: 0x060013C9 RID: 5065 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013C9")]
	[Address(RVA = "0x1A523EC", Offset = "0x1A523EC", VA = "0x1A523EC")]
	private EdenAreaOuterPoint FindWalkableNearestPass(int nextArea, Vector2Int startPoint, string allianceId, EdenAreaInfo curArea)
	{
		return null;
	}

	// Token: 0x060013CA RID: 5066 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013CA")]
	[Address(RVA = "0x1A528B8", Offset = "0x1A528B8", VA = "0x1A528B8")]
	private Tuple<float, Vector2Int> CalGCost(Vector2Int startPoint, EdenAreaOuterPoint nextPass)
	{
		return null;
	}

	// Token: 0x060013CB RID: 5067 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013CB")]
	[Address(RVA = "0x1A529E0", Offset = "0x1A529E0", VA = "0x1A529E0")]
	private List<Vector2Int> GenPath(EdenPathFindNode node, Vector2Int end, Vector2Int start)
	{
		return null;
	}

	// Token: 0x040016A3 RID: 5795
	[Token(Token = "0x40016A3")]
	[FieldOffset(Offset = "0x18")]
	private WorldAreaMapData _areaMapData;

	// Token: 0x040016A4 RID: 5796
	[Token(Token = "0x40016A4")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<int, string> _alliancePassDic;
}
