using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

// Token: 0x02000226 RID: 550
[Token(Token = "0x2000226")]
public class LuaDatabaseManager
{
	// Token: 0x06000EAF RID: 3759 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EAF")]
	[Address(RVA = "0x1229D4C", Offset = "0x1229D4C", VA = "0x1229D4C")]
	public static void InitDataBase(string dbFileName, Action<bool> callback)
	{
	}

	// Token: 0x06000EB0 RID: 3760 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EB0")]
	[Address(RVA = "0x1229E8C", Offset = "0x1229E8C", VA = "0x1229E8C")]
	public static void UninitDatabase()
	{
	}

	// Token: 0x06000EB1 RID: 3761 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EB1")]
	[Address(RVA = "0x1229EE4", Offset = "0x1229EE4", VA = "0x1229EE4")]
	private static LuaTable DBExecResult2LuaTable(DBExecResult r)
	{
		return null;
	}

	// Token: 0x06000EB2 RID: 3762 RVA: 0x00006810 File Offset: 0x00004A10
	[Token(Token = "0x6000EB2")]
	[Address(RVA = "0x122A4A4", Offset = "0x122A4A4", VA = "0x122A4A4")]
	private static int ValueTableToRow(List<DBAnyValue> row, string format, int stack)
	{
		return 0;
	}

	// Token: 0x06000EB3 RID: 3763 RVA: 0x00006828 File Offset: 0x00004A28
	[Token(Token = "0x6000EB3")]
	[Address(RVA = "0x122A87C", Offset = "0x122A87C", VA = "0x122A87C")]
	private static int ValueTableToRows(List<List<DBAnyValue>> rows, string format, int stack)
	{
		return 0;
	}

	// Token: 0x06000EB4 RID: 3764 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EB4")]
	[Address(RVA = "0x122AC3C", Offset = "0x122AC3C", VA = "0x122AC3C")]
	public static void ExecuteMultiSQL(List<string> cmdStr, [Optional] Action<LuaTable> callback)
	{
	}

	// Token: 0x06000EB5 RID: 3765 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EB5")]
	[Address(RVA = "0x122AD44", Offset = "0x122AD44", VA = "0x122AD44")]
	public static void ExecuteSTMT()
	{
	}

	// Token: 0x06000EB6 RID: 3766 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EB6")]
	[Address(RVA = "0x122B03C", Offset = "0x122B03C", VA = "0x122B03C")]
	public static void ExecuteSQL(string cmdStr, [Optional] Action<LuaTable> callback)
	{
	}

	// Token: 0x06000EB7 RID: 3767 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EB7")]
	[Address(RVA = "0x122B144", Offset = "0x122B144", VA = "0x122B144")]
	public LuaDatabaseManager()
	{
	}

	// Token: 0x040011C6 RID: 4550
	[Token(Token = "0x40011C6")]
	[FieldOffset(Offset = "0x0")]
	public static bool isEncrypt;
}
