using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020000CF RID: 207
[Token(Token = "0x20000CF")]
public static class LuaClientProfiler
{
	// Token: 0x060005A5 RID: 1445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A5")]
	[Address(RVA = "0x2F7B21C", Offset = "0x2F7B21C", VA = "0x2F7B21C")]
	public static void BeginSample(int id)
	{
	}

	// Token: 0x060005A6 RID: 1446 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A6")]
	[Address(RVA = "0x2F7B300", Offset = "0x2F7B300", VA = "0x2F7B300")]
	public static void BeginSample(int id, string name)
	{
	}

	// Token: 0x060005A7 RID: 1447 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A7")]
	[Address(RVA = "0x2F7B3C4", Offset = "0x2F7B3C4", VA = "0x2F7B3C4")]
	internal static void BeginSample(string name)
	{
	}

	// Token: 0x060005A8 RID: 1448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A8")]
	[Address(RVA = "0x2F7B430", Offset = "0x2F7B430", VA = "0x2F7B430")]
	public static void EndSample()
	{
	}

	// Token: 0x060005A9 RID: 1449 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A9")]
	[Address(RVA = "0x2F7B4B0", Offset = "0x2F7B4B0", VA = "0x2F7B4B0")]
	public static void Attach()
	{
	}

	// Token: 0x060005AA RID: 1450 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005AA")]
	[Address(RVA = "0x2F7B600", Offset = "0x2F7B600", VA = "0x2F7B600")]
	public static void Detach()
	{
	}

	// Token: 0x170000A1 RID: 161
	// (get) Token: 0x060005AB RID: 1451 RVA: 0x00003B58 File Offset: 0x00001D58
	[Token(Token = "0x170000A1")]
	public static bool IsAttached
	{
		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x2F7B74C", Offset = "0x2F7B74C", VA = "0x2F7B74C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x04000451 RID: 1105
	[Token(Token = "0x4000451")]
	[FieldOffset(Offset = "0x0")]
	private static int _sampleDepth;

	// Token: 0x04000452 RID: 1106
	[Token(Token = "0x4000452")]
	[FieldOffset(Offset = "0x8")]
	private static readonly Dictionary<int, string> _showNames;

	// Token: 0x04000453 RID: 1107
	[Token(Token = "0x4000453")]
	[FieldOffset(Offset = "0x10")]
	private static bool _isAttached;
}
