using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Scripting;
using XLua;

// Token: 0x02000187 RID: 391
[Token(Token = "0x2000187")]
[Preserve]
public class DCBuilding : BaseDataContainer
{
	// Token: 0x06000B1F RID: 2847 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B1F")]
	[Address(RVA = "0x372413C", Offset = "0x372413C", VA = "0x372413C")]
	private void init()
	{
	}

	// Token: 0x06000B20 RID: 2848 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B20")]
	[Address(RVA = "0x37242B8", Offset = "0x37242B8", VA = "0x37242B8")]
	public LuaBuildData GetBuildingDataByUuid(long uuid)
	{
		return null;
	}

	// Token: 0x06000B21 RID: 2849 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B21")]
	[Address(RVA = "0x3724304", Offset = "0x3724304", VA = "0x3724304")]
	public LuaBuildData GetBuildingDataByBuildId(int buildId)
	{
		return null;
	}

	// Token: 0x06000B22 RID: 2850 RVA: 0x00005760 File Offset: 0x00003960
	[Token(Token = "0x6000B22")]
	[Address(RVA = "0x3724350", Offset = "0x3724350", VA = "0x3724350")]
	public bool IsInMyBaseInsideRange(int pointIndex)
	{
		return default(bool);
	}

	// Token: 0x06000B23 RID: 2851 RVA: 0x00005778 File Offset: 0x00003978
	[Token(Token = "0x6000B23")]
	[Address(RVA = "0x37243EC", Offset = "0x37243EC", VA = "0x37243EC")]
	public int GetMainLv()
	{
		return 0;
	}

	// Token: 0x06000B24 RID: 2852 RVA: 0x00005790 File Offset: 0x00003990
	[Token(Token = "0x6000B24")]
	[Address(RVA = "0x3724478", Offset = "0x3724478", VA = "0x3724478")]
	public Vector2Int GetMainPos()
	{
		return default(Vector2Int);
	}

	// Token: 0x06000B25 RID: 2853 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B25")]
	[Address(RVA = "0x3724570", Offset = "0x3724570", VA = "0x3724570")]
	public void SetMainPos()
	{
	}

	// Token: 0x06000B26 RID: 2854 RVA: 0x000057A8 File Offset: 0x000039A8
	[Token(Token = "0x6000B26")]
	[Address(RVA = "0x37245E8", Offset = "0x37245E8", VA = "0x37245E8")]
	public int GetWorldMainPos()
	{
		return 0;
	}

	// Token: 0x06000B27 RID: 2855 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B27")]
	[Address(RVA = "0x3724674", Offset = "0x3724674", VA = "0x3724674")]
	public DCBuilding()
	{
	}

	// Token: 0x040007DB RID: 2011
	[Token(Token = "0x40007DB")]
	[FieldOffset(Offset = "0x10")]
	private LuaTable CSharpCallLuaInterface_;

	// Token: 0x040007DC RID: 2012
	[Token(Token = "0x40007DC")]
	[FieldOffset(Offset = "0x18")]
	private LuaFunction luafunc_GetBuildingDataParamByUuid;

	// Token: 0x040007DD RID: 2013
	[Token(Token = "0x40007DD")]
	[FieldOffset(Offset = "0x20")]
	private LuaFunction luafunc_GetBuildingDataParamByBuildId;

	// Token: 0x040007DE RID: 2014
	[Token(Token = "0x40007DE")]
	[FieldOffset(Offset = "0x28")]
	private Vector2Int _cityCenterPos;
}
