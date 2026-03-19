using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using VEngine;

// Token: 0x0200032A RID: 810
[Token(Token = "0x200032A")]
public static class AutoReverseImageNameList
{
	// Token: 0x06001547 RID: 5447 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001547")]
	[Address(RVA = "0x1ECF698", Offset = "0x1ECF698", VA = "0x1ECF698")]
	public static void Init()
	{
	}

	// Token: 0x06001548 RID: 5448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001548")]
	[Address(RVA = "0x1ECF728", Offset = "0x1ECF728", VA = "0x1ECF728")]
	private static void Load()
	{
	}

	// Token: 0x06001549 RID: 5449 RVA: 0x000084F0 File Offset: 0x000066F0
	[Token(Token = "0x6001549")]
	[Address(RVA = "0x1ECFA7C", Offset = "0x1ECFA7C", VA = "0x1ECFA7C")]
	public static bool IsAutoReverseImage(string name)
	{
		return default(bool);
	}

	// Token: 0x0600154A RID: 5450 RVA: 0x00008508 File Offset: 0x00006708
	[Token(Token = "0x600154A")]
	[Address(RVA = "0x1ECFB40", Offset = "0x1ECFB40", VA = "0x1ECFB40")]
	public static bool IsDontAutoReverseRawImage(string name)
	{
		return default(bool);
	}

	// Token: 0x0400184B RID: 6219
	[Token(Token = "0x400184B")]
	[FieldOffset(Offset = "0x0")]
	public static HashSet<string> AutoReverseImageName;

	// Token: 0x0400184C RID: 6220
	[Token(Token = "0x400184C")]
	[FieldOffset(Offset = "0x8")]
	public static HashSet<string> DontAutoReverseRawImageName;

	// Token: 0x0400184D RID: 6221
	[Token(Token = "0x400184D")]
	[FieldOffset(Offset = "0x10")]
	private static Asset dataListAsset1;

	// Token: 0x0400184E RID: 6222
	[Token(Token = "0x400184E")]
	[FieldOffset(Offset = "0x18")]
	private static Asset dataListAsset2;
}
