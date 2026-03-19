using System;
using Il2CppDummyDll;

// Token: 0x02000326 RID: 806
[Token(Token = "0x2000326")]
public static class MirrorVersionConfig
{
	// Token: 0x06001530 RID: 5424 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001530")]
	[Address(RVA = "0x1992B4C", Offset = "0x1992B4C", VA = "0x1992B4C")]
	public static void RefreshOpenFlag()
	{
	}

	// Token: 0x17000240 RID: 576
	// (get) Token: 0x06001531 RID: 5425 RVA: 0x00008490 File Offset: 0x00006690
	[Token(Token = "0x17000240")]
	public static bool IsMirrorVersionOpen
	{
		[Token(Token = "0x6001531")]
		[Address(RVA = "0x1992C54", Offset = "0x1992C54", VA = "0x1992C54")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x04001841 RID: 6209
	[Token(Token = "0x4001841")]
	[FieldOffset(Offset = "0x0")]
	private static bool _isAutoMirrorVersionOpen;
}
