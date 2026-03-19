using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

// Token: 0x020002FD RID: 765
[Token(Token = "0x20002FD")]
public class EdenAreaOuterPoint
{
	// Token: 0x060013E1 RID: 5089 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013E1")]
	[Address(RVA = "0x1A50B98", Offset = "0x1A50B98", VA = "0x1A50B98")]
	public EdenAreaOuterPoint()
	{
	}

	// Token: 0x060013E2 RID: 5090 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013E2")]
	[Address(RVA = "0x1A50C50", Offset = "0x1A50C50", VA = "0x1A50C50")]
	public void Init(LuaTable template, bool trans, WorldScene scene)
	{
	}

	// Token: 0x060013E3 RID: 5091 RVA: 0x00007D40 File Offset: 0x00005F40
	[Token(Token = "0x60013E3")]
	[Address(RVA = "0x1A53944", Offset = "0x1A53944", VA = "0x1A53944")]
	public int GetPassId()
	{
		return 0;
	}

	// Token: 0x060013E4 RID: 5092 RVA: 0x00007D58 File Offset: 0x00005F58
	[Token(Token = "0x60013E4")]
	[Address(RVA = "0x1A5394C", Offset = "0x1A5394C", VA = "0x1A5394C")]
	public PassType GetPassType()
	{
		return PassType.DEFAULT;
	}

	// Token: 0x060013E5 RID: 5093 RVA: 0x00007D70 File Offset: 0x00005F70
	[Token(Token = "0x60013E5")]
	[Address(RVA = "0x1A53954", Offset = "0x1A53954", VA = "0x1A53954")]
	public int GetRelatedCityId()
	{
		return 0;
	}

	// Token: 0x060013E6 RID: 5094 RVA: 0x00007D88 File Offset: 0x00005F88
	[Token(Token = "0x60013E6")]
	[Address(RVA = "0x1A5395C", Offset = "0x1A5395C", VA = "0x1A5395C")]
	public int GetAreaId()
	{
		return 0;
	}

	// Token: 0x060013E7 RID: 5095 RVA: 0x00007DA0 File Offset: 0x00005FA0
	[Token(Token = "0x60013E7")]
	[Address(RVA = "0x1A53964", Offset = "0x1A53964", VA = "0x1A53964")]
	public int GetOuterAreaId()
	{
		return 0;
	}

	// Token: 0x060013E8 RID: 5096 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013E8")]
	[Address(RVA = "0x1A5396C", Offset = "0x1A5396C", VA = "0x1A5396C")]
	public List<Vector2Int> GetInnerPointList()
	{
		return null;
	}

	// Token: 0x060013E9 RID: 5097 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013E9")]
	[Address(RVA = "0x1A53974", Offset = "0x1A53974", VA = "0x1A53974")]
	public List<Vector2Int> GetOuterPointList()
	{
		return null;
	}

	// Token: 0x040016B4 RID: 5812
	[Token(Token = "0x40016B4")]
	[FieldOffset(Offset = "0x10")]
	private int passId;

	// Token: 0x040016B5 RID: 5813
	[Token(Token = "0x40016B5")]
	[FieldOffset(Offset = "0x14")]
	private PassType passType;

	// Token: 0x040016B6 RID: 5814
	[Token(Token = "0x40016B6")]
	[FieldOffset(Offset = "0x18")]
	private int relatedCityId;

	// Token: 0x040016B7 RID: 5815
	[Token(Token = "0x40016B7")]
	[FieldOffset(Offset = "0x1C")]
	private int areaId;

	// Token: 0x040016B8 RID: 5816
	[Token(Token = "0x40016B8")]
	[FieldOffset(Offset = "0x20")]
	private int outerAreaId;

	// Token: 0x040016B9 RID: 5817
	[Token(Token = "0x40016B9")]
	[FieldOffset(Offset = "0x28")]
	private List<Vector2Int> innerPointList;

	// Token: 0x040016BA RID: 5818
	[Token(Token = "0x40016BA")]
	[FieldOffset(Offset = "0x30")]
	private List<Vector2Int> outerPointList;
}
