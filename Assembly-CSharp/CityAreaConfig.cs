using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000005 RID: 5
[Token(Token = "0x2000005")]
public class CityAreaConfig : MonoBehaviour
{
	// Token: 0x06000012 RID: 18 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x15DF050", Offset = "0x15DF050", VA = "0x15DF050")]
	public CityAreaConfig()
	{
	}

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	public const int kTileCountX = 80;

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	public const int kTileCountY = 80;

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x0")]
	private static int FOG_TILE_COUNT;

	// Token: 0x0400000E RID: 14
	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x4")]
	private static float FOG_TILE_SIZE;

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x18")]
	public int Id;

	// Token: 0x04000010 RID: 16
	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x20")]
	public string NameLang;

	// Token: 0x04000011 RID: 17
	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x28")]
	public string EntranceNameLang;

	// Token: 0x04000012 RID: 18
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x30")]
	public string PveLevelId;

	// Token: 0x04000013 RID: 19
	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x38")]
	public string ContactAreaId;

	// Token: 0x04000014 RID: 20
	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x40")]
	public string StandPos;

	// Token: 0x04000015 RID: 21
	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x48")]
	public string LockType;

	// Token: 0x04000016 RID: 22
	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x50")]
	public int AreaType;

	// Token: 0x04000017 RID: 23
	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x54")]
	public int Order;

	// Token: 0x04000018 RID: 24
	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x58")]
	public string RewardIds;

	// Token: 0x04000019 RID: 25
	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x60")]
	public string ClientShowSmallPeople;
}
