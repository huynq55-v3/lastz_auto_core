using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000372 RID: 882
[Token(Token = "0x2000372")]
[Serializable]
public class WorldGoTransAdjCurve
{
	// Token: 0x06001685 RID: 5765 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001685")]
	[Address(RVA = "0x1EE10B0", Offset = "0x1EE10B0", VA = "0x1EE10B0")]
	public WorldGoTransAdjCurve()
	{
	}

	// Token: 0x040019C2 RID: 6594
	[Token(Token = "0x40019C2")]
	[FieldOffset(Offset = "0x10")]
	public string CurveName;

	// Token: 0x040019C3 RID: 6595
	[Token(Token = "0x40019C3")]
	[FieldOffset(Offset = "0x18")]
	public AnimationCurve Curve;
}
