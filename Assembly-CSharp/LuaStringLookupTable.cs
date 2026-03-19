using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Scripting;
using XLua;

// Token: 0x020000BD RID: 189
[Token(Token = "0x20000BD")]
[Il2CppSetOption(Option.NullChecks, false)]
[Preserve]
public static class LuaStringLookupTable
{
	// Token: 0x0600045B RID: 1115 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600045B")]
	[Address(RVA = "0x2F71220", Offset = "0x2F71220", VA = "0x2F71220")]
	public static void Init(LuaTable luaTable)
	{
	}

	// Token: 0x0600045C RID: 1116 RVA: 0x000034B0 File Offset: 0x000016B0
	[Token(Token = "0x600045C")]
	[Address(RVA = "0x2F71320", Offset = "0x2F71320", VA = "0x2F71320")]
	public static int Add(string str)
	{
		return 0;
	}

	// Token: 0x0600045D RID: 1117 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600045D")]
	[Address(RVA = "0x2F6DD7C", Offset = "0x2F6DD7C", VA = "0x2F6DD7C")]
	public static string Get(int id)
	{
		return null;
	}

	// Token: 0x0600045E RID: 1118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600045E")]
	[Address(RVA = "0x2F713B0", Offset = "0x2F713B0", VA = "0x2F713B0")]
	public static void Clear()
	{
	}

	// Token: 0x04000434 RID: 1076
	[Token(Token = "0x4000434")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<int, string> _lookupTable;

	// Token: 0x04000435 RID: 1077
	[Token(Token = "0x4000435")]
	[FieldOffset(Offset = "0x8")]
	private static int _tableIndex;
}
