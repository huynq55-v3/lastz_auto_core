using System;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using XLua;

// Token: 0x0200037E RID: 894
[Token(Token = "0x200037E")]
[Il2CppEagerStaticClassConstruction]
public static class EventNotify
{
	// Token: 0x060016B1 RID: 5809 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016B1")]
	[Address(RVA = "0x1EE27D4", Offset = "0x1EE27D4", VA = "0x1EE27D4")]
	public static void Fire(EventId eventId)
	{
	}

	// Token: 0x060016B2 RID: 5810 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016B2")]
	[Address(RVA = "0x1EE2834", Offset = "0x1EE2834", VA = "0x1EE2834")]
	public static void FireLong(EventId eventId, long userData)
	{
	}

	// Token: 0x060016B3 RID: 5811 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016B3")]
	[Address(RVA = "0x1EE28E0", Offset = "0x1EE28E0", VA = "0x1EE28E0")]
	public static void FireBool(EventId eventId, bool userData)
	{
	}

	// Token: 0x060016B4 RID: 5812 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016B4")]
	[Address(RVA = "0x1EE298C", Offset = "0x1EE298C", VA = "0x1EE298C")]
	public static void FireString(EventId eventId, string userData)
	{
	}

	// Token: 0x060016B5 RID: 5813 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016B5")]
	[Address(RVA = "0x1EE29F0", Offset = "0x1EE29F0", VA = "0x1EE29F0")]
	public static void FireLuaTable(EventId eventId, LuaTable userData)
	{
	}
}
