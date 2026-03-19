using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

// Token: 0x020002FF RID: 767
[Token(Token = "0x20002FF")]
public class WorldAreaMapData
{
	// Token: 0x060013EF RID: 5103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013EF")]
	[Address(RVA = "0x1A536A8", Offset = "0x1A536A8", VA = "0x1A536A8")]
	public void Load(BinaryReader br)
	{
	}

	// Token: 0x060013F0 RID: 5104 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013F0")]
	[Address(RVA = "0x1A51850", Offset = "0x1A51850", VA = "0x1A51850")]
	public EdenAreaInfo GetAreaData(int zoneId)
	{
		return null;
	}

	// Token: 0x060013F1 RID: 5105 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013F1")]
	[Address(RVA = "0x1A51804", Offset = "0x1A51804", VA = "0x1A51804")]
	public EdenAreaInfo GetAreaByPosId(int pointId)
	{
		return null;
	}

	// Token: 0x060013F2 RID: 5106 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013F2")]
	[Address(RVA = "0x1A5361C", Offset = "0x1A5361C", VA = "0x1A5361C")]
	public WorldAreaMapData()
	{
	}

	// Token: 0x040016BD RID: 5821
	[Token(Token = "0x40016BD")]
	private const float gridRange = 1f;

	// Token: 0x040016BE RID: 5822
	[Token(Token = "0x40016BE")]
	[FieldOffset(Offset = "0x10")]
	public int width;

	// Token: 0x040016BF RID: 5823
	[Token(Token = "0x40016BF")]
	[FieldOffset(Offset = "0x14")]
	public int height;

	// Token: 0x040016C0 RID: 5824
	[Token(Token = "0x40016C0")]
	[FieldOffset(Offset = "0x18")]
	public int scale;

	// Token: 0x040016C1 RID: 5825
	[Token(Token = "0x40016C1")]
	private const int gridSize = 1001;

	// Token: 0x040016C2 RID: 5826
	[Token(Token = "0x40016C2")]
	[FieldOffset(Offset = "0x20")]
	private short[] gridToArea;

	// Token: 0x040016C3 RID: 5827
	[Token(Token = "0x40016C3")]
	[FieldOffset(Offset = "0x28")]
	public Dictionary<int, EdenAreaInfo> areas;
}
