using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

// Token: 0x02000188 RID: 392
[Token(Token = "0x2000188")]
[Preserve]
public class DCPlayer : BaseDataContainer
{
	// Token: 0x06000B28 RID: 2856 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B28")]
	[Address(RVA = "0x372467C", Offset = "0x372467C", VA = "0x372467C")]
	public string GetUid()
	{
		return null;
	}

	// Token: 0x06000B29 RID: 2857 RVA: 0x000057C0 File Offset: 0x000039C0
	[Token(Token = "0x6000B29")]
	[Address(RVA = "0x3724684", Offset = "0x3724684", VA = "0x3724684")]
	public int GetSelfServerId()
	{
		return 0;
	}

	// Token: 0x06000B2A RID: 2858 RVA: 0x000057D8 File Offset: 0x000039D8
	[Token(Token = "0x6000B2A")]
	[Address(RVA = "0x372468C", Offset = "0x372468C", VA = "0x372468C")]
	public int GetCrossServerId()
	{
		return 0;
	}

	// Token: 0x06000B2B RID: 2859 RVA: 0x000057F0 File Offset: 0x000039F0
	[Token(Token = "0x6000B2B")]
	[Address(RVA = "0x3724694", Offset = "0x3724694", VA = "0x3724694")]
	public int GetCurServerId()
	{
		return 0;
	}

	// Token: 0x06000B2C RID: 2860 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B2C")]
	[Address(RVA = "0x37246B0", Offset = "0x37246B0", VA = "0x37246B0")]
	public string GetAllianceId()
	{
		return null;
	}

	// Token: 0x06000B2D RID: 2861 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B2D")]
	public T GetValue<T>(string strKey)
	{
		return null;
	}

	// Token: 0x06000B2E RID: 2862 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B2E")]
	public void SetValue<T>(string strKey, T value)
	{
	}

	// Token: 0x06000B2F RID: 2863 RVA: 0x00005808 File Offset: 0x00003A08
	[Token(Token = "0x6000B2F")]
	[Address(RVA = "0x372473C", Offset = "0x372473C", VA = "0x372473C")]
	public bool IsAllianceSelfCamp(string allianceId)
	{
		return default(bool);
	}

	// Token: 0x06000B30 RID: 2864 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B30")]
	[Address(RVA = "0x3724744", Offset = "0x3724744", VA = "0x3724744")]
	public DCPlayer()
	{
	}

	// Token: 0x040007DF RID: 2015
	[Token(Token = "0x40007DF")]
	[FieldOffset(Offset = "0x10")]
	public string Uid;

	// Token: 0x040007E0 RID: 2016
	[Token(Token = "0x40007E0")]
	[FieldOffset(Offset = "0x18")]
	public int serverId;

	// Token: 0x040007E1 RID: 2017
	[Token(Token = "0x40007E1")]
	[FieldOffset(Offset = "0x1C")]
	public int crossServerId;
}
