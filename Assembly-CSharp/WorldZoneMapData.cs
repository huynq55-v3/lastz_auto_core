using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

// Token: 0x020002DE RID: 734
[Token(Token = "0x20002DE")]
public class WorldZoneMapData
{
	// Token: 0x06001300 RID: 4864 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001300")]
	[Address(RVA = "0x1A44090", Offset = "0x1A44090", VA = "0x1A44090")]
	public void Load(BinaryReader br)
	{
	}

	// Token: 0x06001301 RID: 4865 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001301")]
	[Address(RVA = "0x1A442E4", Offset = "0x1A442E4", VA = "0x1A442E4")]
	public void LoadByBytes(byte[] bt)
	{
	}

	// Token: 0x06001302 RID: 4866 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001302")]
	[Address(RVA = "0x1A443D4", Offset = "0x1A443D4", VA = "0x1A443D4")]
	public WorldZoneData GetZoneData(int zoneId)
	{
		return null;
	}

	// Token: 0x06001303 RID: 4867 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001303")]
	[Address(RVA = "0x1A4444C", Offset = "0x1A4444C", VA = "0x1A4444C")]
	public WorldZoneData GetZoneByPosId(int pointId)
	{
		return null;
	}

	// Token: 0x06001304 RID: 4868 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001304")]
	[Address(RVA = "0x1A4448C", Offset = "0x1A4448C", VA = "0x1A4448C")]
	public void DumpZones()
	{
	}

	// Token: 0x06001305 RID: 4869 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001305")]
	[Address(RVA = "0x1A44490", Offset = "0x1A44490", VA = "0x1A44490")]
	public WorldZoneMapData()
	{
	}

	// Token: 0x040015D6 RID: 5590
	[Token(Token = "0x40015D6")]
	[FieldOffset(Offset = "0x10")]
	public int width;

	// Token: 0x040015D7 RID: 5591
	[Token(Token = "0x40015D7")]
	[FieldOffset(Offset = "0x14")]
	public int height;

	// Token: 0x040015D8 RID: 5592
	[Token(Token = "0x40015D8")]
	[FieldOffset(Offset = "0x18")]
	public int scale;

	// Token: 0x040015D9 RID: 5593
	[Token(Token = "0x40015D9")]
	[FieldOffset(Offset = "0x20")]
	private short[] gridToZone;

	// Token: 0x040015DA RID: 5594
	[Token(Token = "0x40015DA")]
	[FieldOffset(Offset = "0x28")]
	public Dictionary<int, WorldZoneData> zones;
}
