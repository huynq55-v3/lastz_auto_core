using System;
using Il2CppDummyDll;

// Token: 0x02000324 RID: 804
[Token(Token = "0x2000324")]
[Serializable]
public class SingleMirrorObjectData
{
	// Token: 0x0600152C RID: 5420 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600152C")]
	[Address(RVA = "0x1992A50", Offset = "0x1992A50", VA = "0x1992A50")]
	public SingleMirrorObjectData()
	{
	}

	// Token: 0x04001837 RID: 6199
	[Token(Token = "0x4001837")]
	[FieldOffset(Offset = "0x10")]
	public MirrorPositionData mirrorData;

	// Token: 0x04001838 RID: 6200
	[Token(Token = "0x4001838")]
	[FieldOffset(Offset = "0x18")]
	public MirrorPositionData originalData;

	// Token: 0x04001839 RID: 6201
	[Token(Token = "0x4001839")]
	[FieldOffset(Offset = "0x20")]
	public bool isUsingMirrorData;
}
