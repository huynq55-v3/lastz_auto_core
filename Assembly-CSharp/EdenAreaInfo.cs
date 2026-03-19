using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

// Token: 0x020002FE RID: 766
[Token(Token = "0x20002FE")]
public class EdenAreaInfo
{
	// Token: 0x060013EA RID: 5098 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013EA")]
	[Address(RVA = "0x1A5397C", Offset = "0x1A5397C", VA = "0x1A5397C")]
	public EdenAreaInfo()
	{
	}

	// Token: 0x060013EB RID: 5099 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013EB")]
	[Address(RVA = "0x1A53A04", Offset = "0x1A53A04", VA = "0x1A53A04")]
	public void Load(BinaryReader br)
	{
	}

	// Token: 0x060013EC RID: 5100 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013EC")]
	[Address(RVA = "0x1A5128C", Offset = "0x1A5128C", VA = "0x1A5128C")]
	public void AddOuterPoint(EdenAreaOuterPoint outerPoint)
	{
	}

	// Token: 0x060013ED RID: 5101 RVA: 0x00007DB8 File Offset: 0x00005FB8
	[Token(Token = "0x60013ED")]
	[Address(RVA = "0x1A53E40", Offset = "0x1A53E40", VA = "0x1A53E40")]
	public int GetAreaId()
	{
		return 0;
	}

	// Token: 0x060013EE RID: 5102 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013EE")]
	[Address(RVA = "0x1A53E48", Offset = "0x1A53E48", VA = "0x1A53E48")]
	public Dictionary<int, List<EdenAreaOuterPoint>> GetOuterPointMap()
	{
		return null;
	}

	// Token: 0x040016BB RID: 5819
	[Token(Token = "0x40016BB")]
	[FieldOffset(Offset = "0x10")]
	private int areaId;

	// Token: 0x040016BC RID: 5820
	[Token(Token = "0x40016BC")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<int, List<EdenAreaOuterPoint>> outerPointMap;
}
