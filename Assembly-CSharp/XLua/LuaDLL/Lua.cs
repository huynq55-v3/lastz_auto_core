using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace XLua.LuaDLL
{
	// Token: 0x020009CA RID: 2506
	[Token(Token = "0x20009CA")]
	public class Lua
	{
		// Token: 0x06005F5D RID: 24413
		[Token(Token = "0x6005F5D")]
		[Address(RVA = "0x16E0FA8", Offset = "0x16E0FA8", VA = "0x16E0FA8")]
		[PreserveSig]
		public static extern IntPtr lua_tothread(IntPtr L, int index);

		// Token: 0x06005F5E RID: 24414
		[Token(Token = "0x6005F5E")]
		[Address(RVA = "0x16E1028", Offset = "0x16E1028", VA = "0x16E1028")]
		[PreserveSig]
		public static extern int xlua_get_lib_version();

		// Token: 0x06005F5F RID: 24415
		[Token(Token = "0x6005F5F")]
		[Address(RVA = "0x16E1090", Offset = "0x16E1090", VA = "0x16E1090")]
		[PreserveSig]
		public static extern int lua_gc(IntPtr L, LuaGCOptions what, int data);

		// Token: 0x06005F60 RID: 24416
		[Token(Token = "0x6005F60")]
		[Address(RVA = "0x16E1124", Offset = "0x16E1124", VA = "0x16E1124")]
		[PreserveSig]
		public static extern IntPtr lua_getupvalue(IntPtr L, int funcindex, int n);

		// Token: 0x06005F61 RID: 24417
		[Token(Token = "0x6005F61")]
		[Address(RVA = "0x16E11B8", Offset = "0x16E11B8", VA = "0x16E11B8")]
		[PreserveSig]
		public static extern IntPtr lua_setupvalue(IntPtr L, int funcindex, int n);

		// Token: 0x06005F62 RID: 24418
		[Token(Token = "0x6005F62")]
		[Address(RVA = "0x16E124C", Offset = "0x16E124C", VA = "0x16E124C")]
		[PreserveSig]
		public static extern int lua_pushthread(IntPtr L);

		// Token: 0x06005F63 RID: 24419 RVA: 0x0004AF88 File Offset: 0x00049188
		[Token(Token = "0x6005F63")]
		[Address(RVA = "0x16E0074", Offset = "0x16E0074", VA = "0x16E0074")]
		public static bool lua_isfunction(IntPtr L, int stackPos)
		{
			return default(bool);
		}

		// Token: 0x06005F64 RID: 24420 RVA: 0x0004AFA0 File Offset: 0x000491A0
		[Token(Token = "0x6005F64")]
		[Address(RVA = "0x16E134C", Offset = "0x16E134C", VA = "0x16E134C")]
		public static bool lua_islightuserdata(IntPtr L, int stackPos)
		{
			return default(bool);
		}

		// Token: 0x06005F65 RID: 24421 RVA: 0x0004AFB8 File Offset: 0x000491B8
		[Token(Token = "0x6005F65")]
		[Address(RVA = "0x16E00E4", Offset = "0x16E00E4", VA = "0x16E00E4")]
		public static bool lua_istable(IntPtr L, int stackPos)
		{
			return default(bool);
		}

		// Token: 0x06005F66 RID: 24422 RVA: 0x0004AFD0 File Offset: 0x000491D0
		[Token(Token = "0x6005F66")]
		[Address(RVA = "0x16E13BC", Offset = "0x16E13BC", VA = "0x16E13BC")]
		public static bool lua_isthread(IntPtr L, int stackPos)
		{
			return default(bool);
		}

		// Token: 0x06005F67 RID: 24423 RVA: 0x0004AFE8 File Offset: 0x000491E8
		[Token(Token = "0x6005F67")]
		[Address(RVA = "0x16C633C", Offset = "0x16C633C", VA = "0x16C633C")]
		public static int luaL_error(IntPtr L, string message)
		{
			return 0;
		}

		// Token: 0x06005F68 RID: 24424
		[Token(Token = "0x6005F68")]
		[Address(RVA = "0x16E0154", Offset = "0x16E0154", VA = "0x16E0154")]
		[PreserveSig]
		public static extern int lua_setfenv(IntPtr L, int stackPos);

		// Token: 0x06005F69 RID: 24425
		[Token(Token = "0x6005F69")]
		[Address(RVA = "0x16E14CC", Offset = "0x16E14CC", VA = "0x16E14CC")]
		[PreserveSig]
		public static extern IntPtr luaL_newstate();

		// Token: 0x06005F6A RID: 24426
		[Token(Token = "0x6005F6A")]
		[Address(RVA = "0x16E1534", Offset = "0x16E1534", VA = "0x16E1534")]
		[PreserveSig]
		public static extern void lua_close(IntPtr L);

		// Token: 0x06005F6B RID: 24427
		[Token(Token = "0x6005F6B")]
		[Address(RVA = "0x16E15B0", Offset = "0x16E15B0", VA = "0x16E15B0")]
		[PreserveSig]
		public static extern void luaopen_xlua(IntPtr L);

		// Token: 0x06005F6C RID: 24428
		[Token(Token = "0x6005F6C")]
		[Address(RVA = "0x16E162C", Offset = "0x16E162C", VA = "0x16E162C")]
		[PreserveSig]
		public static extern void luaL_openlibs(IntPtr L);

		// Token: 0x06005F6D RID: 24429
		[Token(Token = "0x6005F6D")]
		[Address(RVA = "0x16E16A8", Offset = "0x16E16A8", VA = "0x16E16A8")]
		[PreserveSig]
		public static extern uint xlua_objlen(IntPtr L, int stackPos);

		// Token: 0x06005F6E RID: 24430
		[Token(Token = "0x6005F6E")]
		[Address(RVA = "0x16E172C", Offset = "0x16E172C", VA = "0x16E172C")]
		[PreserveSig]
		public static extern void lua_createtable(IntPtr L, int narr, int nrec);

		// Token: 0x06005F6F RID: 24431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F6F")]
		[Address(RVA = "0x16E03F0", Offset = "0x16E03F0", VA = "0x16E03F0")]
		public static void lua_newtable(IntPtr L)
		{
		}

		// Token: 0x06005F70 RID: 24432
		[Token(Token = "0x6005F70")]
		[Address(RVA = "0x16E17C0", Offset = "0x16E17C0", VA = "0x16E17C0")]
		[PreserveSig]
		public static extern int xlua_getglobal(IntPtr L, string name);

		// Token: 0x06005F71 RID: 24433
		[Token(Token = "0x6005F71")]
		[Address(RVA = "0x16E0728", Offset = "0x16E0728", VA = "0x16E0728")]
		[PreserveSig]
		public static extern int xlua_setglobal(IntPtr L, string name);

		// Token: 0x06005F72 RID: 24434
		[Token(Token = "0x6005F72")]
		[Address(RVA = "0x16E1860", Offset = "0x16E1860", VA = "0x16E1860")]
		[PreserveSig]
		public static extern void xlua_getloaders(IntPtr L);

		// Token: 0x06005F73 RID: 24435
		[Token(Token = "0x6005F73")]
		[Address(RVA = "0x16E18DC", Offset = "0x16E18DC", VA = "0x16E18DC")]
		[PreserveSig]
		public static extern void lua_settop(IntPtr L, int newTop);

		// Token: 0x06005F74 RID: 24436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F74")]
		[Address(RVA = "0x16E1960", Offset = "0x16E1960", VA = "0x16E1960")]
		public static void lua_pop(IntPtr L, int amount)
		{
		}

		// Token: 0x06005F75 RID: 24437
		[Token(Token = "0x6005F75")]
		[Address(RVA = "0x16E19C4", Offset = "0x16E19C4", VA = "0x16E19C4")]
		[PreserveSig]
		public static extern void lua_insert(IntPtr L, int newTop);

		// Token: 0x06005F76 RID: 24438
		[Token(Token = "0x6005F76")]
		[Address(RVA = "0x16E1A48", Offset = "0x16E1A48", VA = "0x16E1A48")]
		[PreserveSig]
		public static extern void lua_remove(IntPtr L, int index);

		// Token: 0x06005F77 RID: 24439
		[Token(Token = "0x6005F77")]
		[Address(RVA = "0x16E1ACC", Offset = "0x16E1ACC", VA = "0x16E1ACC")]
		[PreserveSig]
		public static extern int lua_rawget(IntPtr L, int index);

		// Token: 0x06005F78 RID: 24440
		[Token(Token = "0x6005F78")]
		[Address(RVA = "0x16E06A4", Offset = "0x16E06A4", VA = "0x16E06A4")]
		[PreserveSig]
		public static extern void lua_rawset(IntPtr L, int index);

		// Token: 0x06005F79 RID: 24441
		[Token(Token = "0x6005F79")]
		[Address(RVA = "0x16E1B50", Offset = "0x16E1B50", VA = "0x16E1B50")]
		[PreserveSig]
		public static extern int lua_setmetatable(IntPtr L, int objIndex);

		// Token: 0x06005F7A RID: 24442
		[Token(Token = "0x6005F7A")]
		[Address(RVA = "0x16E1BD4", Offset = "0x16E1BD4", VA = "0x16E1BD4")]
		[PreserveSig]
		public static extern int lua_rawequal(IntPtr L, int index1, int index2);

		// Token: 0x06005F7B RID: 24443
		[Token(Token = "0x6005F7B")]
		[Address(RVA = "0x16E1C68", Offset = "0x16E1C68", VA = "0x16E1C68")]
		[PreserveSig]
		public static extern void lua_pushvalue(IntPtr L, int index);

		// Token: 0x06005F7C RID: 24444
		[Token(Token = "0x6005F7C")]
		[Address(RVA = "0x16E1CEC", Offset = "0x16E1CEC", VA = "0x16E1CEC")]
		[PreserveSig]
		public static extern void lua_pushcclosure(IntPtr L, IntPtr fn, int n);

		// Token: 0x06005F7D RID: 24445
		[Token(Token = "0x6005F7D")]
		[Address(RVA = "0x16E1D80", Offset = "0x16E1D80", VA = "0x16E1D80")]
		[PreserveSig]
		public static extern void lua_replace(IntPtr L, int index);

		// Token: 0x06005F7E RID: 24446
		[Token(Token = "0x6005F7E")]
		[Address(RVA = "0x16C62C0", Offset = "0x16C62C0", VA = "0x16C62C0")]
		[PreserveSig]
		public static extern int lua_gettop(IntPtr L);

		// Token: 0x06005F7F RID: 24447
		[Token(Token = "0x6005F7F")]
		[Address(RVA = "0x16E12C8", Offset = "0x16E12C8", VA = "0x16E12C8")]
		[PreserveSig]
		public static extern LuaTypes lua_type(IntPtr L, int index);

		// Token: 0x06005F80 RID: 24448 RVA: 0x0004B000 File Offset: 0x00049200
		[Token(Token = "0x6005F80")]
		[Address(RVA = "0x16E1E04", Offset = "0x16E1E04", VA = "0x16E1E04")]
		public static bool lua_isnil(IntPtr L, int index)
		{
			return default(bool);
		}

		// Token: 0x06005F81 RID: 24449
		[Token(Token = "0x6005F81")]
		[Address(RVA = "0x16E1E74", Offset = "0x16E1E74", VA = "0x16E1E74")]
		[PreserveSig]
		public static extern bool lua_isnumber(IntPtr L, int index);

		// Token: 0x06005F82 RID: 24450 RVA: 0x0004B018 File Offset: 0x00049218
		[Token(Token = "0x6005F82")]
		[Address(RVA = "0x16E1EFC", Offset = "0x16E1EFC", VA = "0x16E1EFC")]
		public static bool lua_isboolean(IntPtr L, int index)
		{
			return default(bool);
		}

		// Token: 0x06005F83 RID: 24451
		[Token(Token = "0x6005F83")]
		[Address(RVA = "0x16E1F6C", Offset = "0x16E1F6C", VA = "0x16E1F6C")]
		[PreserveSig]
		public static extern int luaL_ref(IntPtr L, int registryIndex);

		// Token: 0x06005F84 RID: 24452 RVA: 0x0004B030 File Offset: 0x00049230
		[Token(Token = "0x6005F84")]
		[Address(RVA = "0x16E1FF0", Offset = "0x16E1FF0", VA = "0x16E1FF0")]
		public static int luaL_ref(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06005F85 RID: 24453
		[Token(Token = "0x6005F85")]
		[Address(RVA = "0x16E2058", Offset = "0x16E2058", VA = "0x16E2058")]
		[PreserveSig]
		public static extern void xlua_rawgeti(IntPtr L, int tableIndex, long index);

		// Token: 0x06005F86 RID: 24454
		[Token(Token = "0x6005F86")]
		[Address(RVA = "0x16E20EC", Offset = "0x16E20EC", VA = "0x16E20EC")]
		[PreserveSig]
		public static extern void xlua_rawseti(IntPtr L, int tableIndex, long index);

		// Token: 0x06005F87 RID: 24455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F87")]
		[Address(RVA = "0x16E2180", Offset = "0x16E2180", VA = "0x16E2180")]
		public static void lua_getref(IntPtr L, int reference)
		{
		}

		// Token: 0x06005F88 RID: 24456
		[Token(Token = "0x6005F88")]
		[Address(RVA = "0x16E21F8", Offset = "0x16E21F8", VA = "0x16E21F8")]
		[PreserveSig]
		public static extern int pcall_prepare(IntPtr L, int error_func_ref, int func_ref);

		// Token: 0x06005F89 RID: 24457
		[Token(Token = "0x6005F89")]
		[Address(RVA = "0x16E228C", Offset = "0x16E228C", VA = "0x16E228C")]
		[PreserveSig]
		public static extern void luaL_unref(IntPtr L, int registryIndex, int reference);

		// Token: 0x06005F8A RID: 24458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F8A")]
		[Address(RVA = "0x16E2320", Offset = "0x16E2320", VA = "0x16E2320")]
		public static void lua_unref(IntPtr L, int reference)
		{
		}

		// Token: 0x06005F8B RID: 24459
		[Token(Token = "0x6005F8B")]
		[Address(RVA = "0x16E2398", Offset = "0x16E2398", VA = "0x16E2398")]
		[PreserveSig]
		public static extern bool lua_isstring(IntPtr L, int index);

		// Token: 0x06005F8C RID: 24460
		[Token(Token = "0x6005F8C")]
		[Address(RVA = "0x16E2420", Offset = "0x16E2420", VA = "0x16E2420")]
		[PreserveSig]
		public static extern bool lua_isinteger(IntPtr L, int index);

		// Token: 0x06005F8D RID: 24461
		[Token(Token = "0x6005F8D")]
		[Address(RVA = "0x16E24AC", Offset = "0x16E24AC", VA = "0x16E24AC")]
		[PreserveSig]
		public static extern void lua_pushnil(IntPtr L);

		// Token: 0x06005F8E RID: 24462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F8E")]
		[Address(RVA = "0x16E05EC", Offset = "0x16E05EC", VA = "0x16E05EC")]
		public static void lua_pushstdcallcfunction(IntPtr L, lua_CSFunction function, int n = 0)
		{
		}

		// Token: 0x06005F8F RID: 24463
		[Token(Token = "0x6005F8F")]
		[Address(RVA = "0x16E25BC", Offset = "0x16E25BC", VA = "0x16E25BC")]
		[PreserveSig]
		public static extern int xlua_upvalueindex(int n);

		// Token: 0x06005F90 RID: 24464
		[Token(Token = "0x6005F90")]
		[Address(RVA = "0x16E01D8", Offset = "0x16E01D8", VA = "0x16E01D8")]
		[PreserveSig]
		public static extern int lua_pcall(IntPtr L, int nArgs, int nResults, int errfunc);

		// Token: 0x06005F91 RID: 24465
		[Token(Token = "0x6005F91")]
		[Address(RVA = "0x16C66F8", Offset = "0x16C66F8", VA = "0x16C66F8")]
		[PreserveSig]
		public static extern double lua_tonumber(IntPtr L, int index);

		// Token: 0x06005F92 RID: 24466
		[Token(Token = "0x6005F92")]
		[Address(RVA = "0x16C63A8", Offset = "0x16C63A8", VA = "0x16C63A8")]
		[PreserveSig]
		public static extern int xlua_tointeger(IntPtr L, int index);

		// Token: 0x06005F93 RID: 24467
		[Token(Token = "0x6005F93")]
		[Address(RVA = "0x16E2634", Offset = "0x16E2634", VA = "0x16E2634")]
		[PreserveSig]
		public static extern uint xlua_touint(IntPtr L, int index);

		// Token: 0x06005F94 RID: 24468
		[Token(Token = "0x6005F94")]
		[Address(RVA = "0x16C67FC", Offset = "0x16C67FC", VA = "0x16C67FC")]
		[PreserveSig]
		public static extern bool lua_toboolean(IntPtr L, int index);

		// Token: 0x06005F95 RID: 24469
		[Token(Token = "0x6005F95")]
		[Address(RVA = "0x16E26B8", Offset = "0x16E26B8", VA = "0x16E26B8")]
		[PreserveSig]
		public static extern IntPtr lua_topointer(IntPtr L, int index);

		// Token: 0x06005F96 RID: 24470
		[Token(Token = "0x6005F96")]
		[Address(RVA = "0x16E273C", Offset = "0x16E273C", VA = "0x16E273C")]
		[PreserveSig]
		public static extern IntPtr lua_tolstring(IntPtr L, int index, out IntPtr strLen);

		// Token: 0x06005F97 RID: 24471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F97")]
		[Address(RVA = "0x16C642C", Offset = "0x16C642C", VA = "0x16C642C")]
		public static string lua_tostring(IntPtr L, int index)
		{
			return null;
		}

		// Token: 0x06005F98 RID: 24472
		[Token(Token = "0x6005F98")]
		[Address(RVA = "0x16E27D0", Offset = "0x16E27D0", VA = "0x16E27D0")]
		[PreserveSig]
		public static extern IntPtr lua_atpanic(IntPtr L, lua_CSFunction panicf);

		// Token: 0x06005F99 RID: 24473
		[Token(Token = "0x6005F99")]
		[Address(RVA = "0x16DB550", Offset = "0x16DB550", VA = "0x16DB550")]
		[PreserveSig]
		public static extern void lua_pushnumber(IntPtr L, double number);

		// Token: 0x06005F9A RID: 24474
		[Token(Token = "0x6005F9A")]
		[Address(RVA = "0x16C9EB0", Offset = "0x16C9EB0", VA = "0x16C9EB0")]
		[PreserveSig]
		public static extern void lua_pushboolean(IntPtr L, bool value);

		// Token: 0x06005F9B RID: 24475
		[Token(Token = "0x6005F9B")]
		[Address(RVA = "0x16C9F34", Offset = "0x16C9F34", VA = "0x16C9F34")]
		[PreserveSig]
		public static extern void xlua_pushinteger(IntPtr L, int value);

		// Token: 0x06005F9C RID: 24476
		[Token(Token = "0x6005F9C")]
		[Address(RVA = "0x16E285C", Offset = "0x16E285C", VA = "0x16E285C")]
		[PreserveSig]
		public static extern void xlua_pushuint(IntPtr L, uint value);

		// Token: 0x06005F9D RID: 24477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F9D")]
		[Address(RVA = "0x16C9FB8", Offset = "0x16C9FB8", VA = "0x16C9FB8")]
		public static void lua_pushstring(IntPtr L, string str)
		{
		}

		// Token: 0x06005F9E RID: 24478
		[Token(Token = "0x6005F9E")]
		[Address(RVA = "0x16E28E0", Offset = "0x16E28E0", VA = "0x16E28E0")]
		[PreserveSig]
		public static extern void xlua_pushlstring(IntPtr L, byte[] str, int size);

		// Token: 0x06005F9F RID: 24479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F9F")]
		[Address(RVA = "0x16E044C", Offset = "0x16E044C", VA = "0x16E044C")]
		public static void xlua_pushasciistring(IntPtr L, string str)
		{
		}

		// Token: 0x06005FA0 RID: 24480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FA0")]
		[Address(RVA = "0x16DE304", Offset = "0x16DE304", VA = "0x16DE304")]
		public static void lua_pushstring(IntPtr L, byte[] str)
		{
		}

		// Token: 0x06005FA1 RID: 24481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FA1")]
		[Address(RVA = "0x16CC264", Offset = "0x16CC264", VA = "0x16CC264")]
		public static byte[] lua_tobytes(IntPtr L, int index)
		{
			return null;
		}

		// Token: 0x06005FA2 RID: 24482
		[Token(Token = "0x6005FA2")]
		[Address(RVA = "0x16E297C", Offset = "0x16E297C", VA = "0x16E297C")]
		[PreserveSig]
		public static extern int luaL_newmetatable(IntPtr L, string meta);

		// Token: 0x06005FA3 RID: 24483
		[Token(Token = "0x6005FA3")]
		[Address(RVA = "0x16E2A1C", Offset = "0x16E2A1C", VA = "0x16E2A1C")]
		[PreserveSig]
		public static extern int xlua_pgettable(IntPtr L, int idx);

		// Token: 0x06005FA4 RID: 24484
		[Token(Token = "0x6005FA4")]
		[Address(RVA = "0x16E2AA0", Offset = "0x16E2AA0", VA = "0x16E2AA0")]
		[PreserveSig]
		public static extern int xlua_psettable(IntPtr L, int idx);

		// Token: 0x06005FA5 RID: 24485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FA5")]
		[Address(RVA = "0x16E2B24", Offset = "0x16E2B24", VA = "0x16E2B24")]
		public static void luaL_getmetatable(IntPtr L, string meta)
		{
		}

		// Token: 0x06005FA6 RID: 24486
		[Token(Token = "0x6005FA6")]
		[Address(RVA = "0x16E2B9C", Offset = "0x16E2B9C", VA = "0x16E2B9C")]
		[PreserveSig]
		public static extern int xluaL_loadbuffer(IntPtr L, byte[] buff, int size, string name);

		// Token: 0x06005FA7 RID: 24487
		[Token(Token = "0x6005FA7")]
		[Address(RVA = "0x16E2C60", Offset = "0x16E2C60", VA = "0x16E2C60")]
		[PreserveSig]
		public static extern int xluaL_loadbuffer(IntPtr L, IntPtr buff, int size, string name);

		// Token: 0x06005FA8 RID: 24488
		[Token(Token = "0x6005FA8")]
		[Address(RVA = "0x16E2D18", Offset = "0x16E2D18", VA = "0x16E2D18")]
		[PreserveSig]
		public static extern int xluaL_loadfile(IntPtr L, string filePath, string name);

		// Token: 0x06005FA9 RID: 24489 RVA: 0x0004B048 File Offset: 0x00049248
		[Token(Token = "0x6005FA9")]
		[Address(RVA = "0x16DFF7C", Offset = "0x16DFF7C", VA = "0x16DFF7C")]
		public static int luaL_loadbuffer(IntPtr L, string buff, string name)
		{
			return 0;
		}

		// Token: 0x06005FAA RID: 24490
		[Token(Token = "0x6005FAA")]
		[Address(RVA = "0x16E2DDC", Offset = "0x16E2DDC", VA = "0x16E2DDC")]
		[PreserveSig]
		public static extern int xlua_tocsobj_safe(IntPtr L, int obj);

		// Token: 0x06005FAB RID: 24491
		[Token(Token = "0x6005FAB")]
		[Address(RVA = "0x16E2E60", Offset = "0x16E2E60", VA = "0x16E2E60")]
		[PreserveSig]
		public static extern int xlua_tocsobj_fast(IntPtr L, int obj);

		// Token: 0x06005FAC RID: 24492 RVA: 0x0004B060 File Offset: 0x00049260
		[Token(Token = "0x6005FAC")]
		[Address(RVA = "0x16E0018", Offset = "0x16E0018", VA = "0x16E0018")]
		public static int lua_error(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06005FAD RID: 24493
		[Token(Token = "0x6005FAD")]
		[Address(RVA = "0x16E2F60", Offset = "0x16E2F60", VA = "0x16E2F60")]
		[PreserveSig]
		public static extern bool lua_checkstack(IntPtr L, int extra);

		// Token: 0x06005FAE RID: 24494
		[Token(Token = "0x6005FAE")]
		[Address(RVA = "0x16E2FEC", Offset = "0x16E2FEC", VA = "0x16E2FEC")]
		[PreserveSig]
		public static extern int lua_next(IntPtr L, int index);

		// Token: 0x06005FAF RID: 24495
		[Token(Token = "0x6005FAF")]
		[Address(RVA = "0x16E3070", Offset = "0x16E3070", VA = "0x16E3070")]
		[PreserveSig]
		public static extern void lua_pushlightuserdata(IntPtr L, IntPtr udata);

		// Token: 0x06005FB0 RID: 24496
		[Token(Token = "0x6005FB0")]
		[Address(RVA = "0x16E30F4", Offset = "0x16E30F4", VA = "0x16E30F4")]
		[PreserveSig]
		public static extern IntPtr xlua_tag();

		// Token: 0x06005FB1 RID: 24497
		[Token(Token = "0x6005FB1")]
		[Address(RVA = "0x16E315C", Offset = "0x16E315C", VA = "0x16E315C")]
		[PreserveSig]
		public static extern void luaL_where(IntPtr L, int level);

		// Token: 0x06005FB2 RID: 24498
		[Token(Token = "0x6005FB2")]
		[Address(RVA = "0x16E31E0", Offset = "0x16E31E0", VA = "0x16E31E0")]
		[PreserveSig]
		public static extern int xlua_tryget_cachedud(IntPtr L, int key, int cache_ref);

		// Token: 0x06005FB3 RID: 24499
		[Token(Token = "0x6005FB3")]
		[Address(RVA = "0x16E3274", Offset = "0x16E3274", VA = "0x16E3274")]
		[PreserveSig]
		public static extern void xlua_pushcsobj(IntPtr L, int key, int meta_ref, bool need_cache, int cache_ref);

		// Token: 0x06005FB4 RID: 24500
		[Token(Token = "0x6005FB4")]
		[Address(RVA = "0x16E3320", Offset = "0x16E3320", VA = "0x16E3320")]
		[PreserveSig]
		public static extern int gen_obj_indexer(IntPtr L);

		// Token: 0x06005FB5 RID: 24501
		[Token(Token = "0x6005FB5")]
		[Address(RVA = "0x16E339C", Offset = "0x16E339C", VA = "0x16E339C")]
		[PreserveSig]
		public static extern int gen_obj_newindexer(IntPtr L);

		// Token: 0x06005FB6 RID: 24502
		[Token(Token = "0x6005FB6")]
		[Address(RVA = "0x16E3418", Offset = "0x16E3418", VA = "0x16E3418")]
		[PreserveSig]
		public static extern int gen_cls_indexer(IntPtr L);

		// Token: 0x06005FB7 RID: 24503
		[Token(Token = "0x6005FB7")]
		[Address(RVA = "0x16E3494", Offset = "0x16E3494", VA = "0x16E3494")]
		[PreserveSig]
		public static extern int gen_cls_newindexer(IntPtr L);

		// Token: 0x06005FB8 RID: 24504
		[Token(Token = "0x6005FB8")]
		[Address(RVA = "0x16E3510", Offset = "0x16E3510", VA = "0x16E3510")]
		[PreserveSig]
		public static extern int get_error_func_ref(IntPtr L);

		// Token: 0x06005FB9 RID: 24505
		[Token(Token = "0x6005FB9")]
		[Address(RVA = "0x16E358C", Offset = "0x16E358C", VA = "0x16E358C")]
		[PreserveSig]
		public static extern int load_error_func(IntPtr L, int Ref);

		// Token: 0x06005FBA RID: 24506
		[Token(Token = "0x6005FBA")]
		[Address(RVA = "0x16E3610", Offset = "0x16E3610", VA = "0x16E3610")]
		[PreserveSig]
		public static extern int luaopen_i64lib(IntPtr L);

		// Token: 0x06005FBB RID: 24507
		[Token(Token = "0x6005FBB")]
		[Address(RVA = "0x16E368C", Offset = "0x16E368C", VA = "0x16E368C")]
		[PreserveSig]
		public static extern int luaopen_socket_core(IntPtr L);

		// Token: 0x06005FBC RID: 24508
		[Token(Token = "0x6005FBC")]
		[Address(RVA = "0x16E3708", Offset = "0x16E3708", VA = "0x16E3708")]
		[PreserveSig]
		public static extern void lua_pushint64(IntPtr L, long n);

		// Token: 0x06005FBD RID: 24509
		[Token(Token = "0x6005FBD")]
		[Address(RVA = "0x16E378C", Offset = "0x16E378C", VA = "0x16E378C")]
		[PreserveSig]
		public static extern void lua_pushuint64(IntPtr L, ulong n);

		// Token: 0x06005FBE RID: 24510
		[Token(Token = "0x6005FBE")]
		[Address(RVA = "0x16E3810", Offset = "0x16E3810", VA = "0x16E3810")]
		[PreserveSig]
		public static extern bool lua_isint64(IntPtr L, int idx);

		// Token: 0x06005FBF RID: 24511
		[Token(Token = "0x6005FBF")]
		[Address(RVA = "0x16E389C", Offset = "0x16E389C", VA = "0x16E389C")]
		[PreserveSig]
		public static extern bool lua_isuint64(IntPtr L, int idx);

		// Token: 0x06005FC0 RID: 24512
		[Token(Token = "0x6005FC0")]
		[Address(RVA = "0x16C6778", Offset = "0x16C6778", VA = "0x16C6778")]
		[PreserveSig]
		public static extern long lua_toint64(IntPtr L, int idx);

		// Token: 0x06005FC1 RID: 24513
		[Token(Token = "0x6005FC1")]
		[Address(RVA = "0x16E3924", Offset = "0x16E3924", VA = "0x16E3924")]
		[PreserveSig]
		public static extern ulong lua_touint64(IntPtr L, int idx);

		// Token: 0x06005FC2 RID: 24514
		[Token(Token = "0x6005FC2")]
		[Address(RVA = "0x16E2528", Offset = "0x16E2528", VA = "0x16E2528")]
		[PreserveSig]
		public static extern void xlua_push_csharp_function(IntPtr L, IntPtr fn, int n);

		// Token: 0x06005FC3 RID: 24515
		[Token(Token = "0x6005FC3")]
		[Address(RVA = "0x16E142C", Offset = "0x16E142C", VA = "0x16E142C")]
		[PreserveSig]
		public static extern int xlua_csharp_str_error(IntPtr L, string message);

		// Token: 0x06005FC4 RID: 24516
		[Token(Token = "0x6005FC4")]
		[Address(RVA = "0x16E2EE4", Offset = "0x16E2EE4", VA = "0x16E2EE4")]
		[PreserveSig]
		public static extern int xlua_csharp_error(IntPtr L);

		// Token: 0x06005FC5 RID: 24517
		[Token(Token = "0x6005FC5")]
		[Address(RVA = "0x16E39A4", Offset = "0x16E39A4", VA = "0x16E39A4")]
		[PreserveSig]
		public static extern bool xlua_pack_int8_t(IntPtr buff, int offset, byte field);

		// Token: 0x06005FC6 RID: 24518
		[Token(Token = "0x6005FC6")]
		[Address(RVA = "0x16E3A3C", Offset = "0x16E3A3C", VA = "0x16E3A3C")]
		[PreserveSig]
		public static extern bool xlua_unpack_int8_t(IntPtr buff, int offset, out byte field);

		// Token: 0x06005FC7 RID: 24519
		[Token(Token = "0x6005FC7")]
		[Address(RVA = "0x16E3AD8", Offset = "0x16E3AD8", VA = "0x16E3AD8")]
		[PreserveSig]
		public static extern bool xlua_pack_int16_t(IntPtr buff, int offset, short field);

		// Token: 0x06005FC8 RID: 24520
		[Token(Token = "0x6005FC8")]
		[Address(RVA = "0x16E3B74", Offset = "0x16E3B74", VA = "0x16E3B74")]
		[PreserveSig]
		public static extern bool xlua_unpack_int16_t(IntPtr buff, int offset, out short field);

		// Token: 0x06005FC9 RID: 24521
		[Token(Token = "0x6005FC9")]
		[Address(RVA = "0x16E3C10", Offset = "0x16E3C10", VA = "0x16E3C10")]
		[PreserveSig]
		public static extern bool xlua_pack_int32_t(IntPtr buff, int offset, int field);

		// Token: 0x06005FCA RID: 24522
		[Token(Token = "0x6005FCA")]
		[Address(RVA = "0x16E3CAC", Offset = "0x16E3CAC", VA = "0x16E3CAC")]
		[PreserveSig]
		public static extern bool xlua_unpack_int32_t(IntPtr buff, int offset, out int field);

		// Token: 0x06005FCB RID: 24523
		[Token(Token = "0x6005FCB")]
		[Address(RVA = "0x16E3D48", Offset = "0x16E3D48", VA = "0x16E3D48")]
		[PreserveSig]
		public static extern bool xlua_pack_int64_t(IntPtr buff, int offset, long field);

		// Token: 0x06005FCC RID: 24524
		[Token(Token = "0x6005FCC")]
		[Address(RVA = "0x16E3DE4", Offset = "0x16E3DE4", VA = "0x16E3DE4")]
		[PreserveSig]
		public static extern bool xlua_unpack_int64_t(IntPtr buff, int offset, out long field);

		// Token: 0x06005FCD RID: 24525
		[Token(Token = "0x6005FCD")]
		[Address(RVA = "0x16E3E80", Offset = "0x16E3E80", VA = "0x16E3E80")]
		[PreserveSig]
		public static extern bool xlua_pack_float(IntPtr buff, int offset, float field);

		// Token: 0x06005FCE RID: 24526
		[Token(Token = "0x6005FCE")]
		[Address(RVA = "0x16E3F1C", Offset = "0x16E3F1C", VA = "0x16E3F1C")]
		[PreserveSig]
		public static extern bool xlua_unpack_float(IntPtr buff, int offset, out float field);

		// Token: 0x06005FCF RID: 24527
		[Token(Token = "0x6005FCF")]
		[Address(RVA = "0x16E3FB8", Offset = "0x16E3FB8", VA = "0x16E3FB8")]
		[PreserveSig]
		public static extern bool xlua_pack_double(IntPtr buff, int offset, double field);

		// Token: 0x06005FD0 RID: 24528
		[Token(Token = "0x6005FD0")]
		[Address(RVA = "0x16E4054", Offset = "0x16E4054", VA = "0x16E4054")]
		[PreserveSig]
		public static extern bool xlua_unpack_double(IntPtr buff, int offset, out double field);

		// Token: 0x06005FD1 RID: 24529
		[Token(Token = "0x6005FD1")]
		[Address(RVA = "0x16E40F0", Offset = "0x16E40F0", VA = "0x16E40F0")]
		[PreserveSig]
		public static extern IntPtr xlua_pushstruct(IntPtr L, uint size, int meta_ref);

		// Token: 0x06005FD2 RID: 24530
		[Token(Token = "0x6005FD2")]
		[Address(RVA = "0x16E4184", Offset = "0x16E4184", VA = "0x16E4184")]
		[PreserveSig]
		public static extern void xlua_pushcstable(IntPtr L, uint field_count, int meta_ref);

		// Token: 0x06005FD3 RID: 24531
		[Token(Token = "0x6005FD3")]
		[Address(RVA = "0x16E4214", Offset = "0x16E4214", VA = "0x16E4214")]
		[PreserveSig]
		public static extern IntPtr lua_touserdata(IntPtr L, int idx);

		// Token: 0x06005FD4 RID: 24532
		[Token(Token = "0x6005FD4")]
		[Address(RVA = "0x16E4298", Offset = "0x16E4298", VA = "0x16E4298")]
		[PreserveSig]
		public static extern int xlua_gettypeid(IntPtr L, int idx);

		// Token: 0x06005FD5 RID: 24533
		[Token(Token = "0x6005FD5")]
		[Address(RVA = "0x16E431C", Offset = "0x16E431C", VA = "0x16E431C")]
		[PreserveSig]
		public static extern int xlua_get_registry_index();

		// Token: 0x06005FD6 RID: 24534
		[Token(Token = "0x6005FD6")]
		[Address(RVA = "0x16E4384", Offset = "0x16E4384", VA = "0x16E4384")]
		[PreserveSig]
		public static extern int xlua_pgettable_bypath(IntPtr L, int idx, string path);

		// Token: 0x06005FD7 RID: 24535
		[Token(Token = "0x6005FD7")]
		[Address(RVA = "0x16E4434", Offset = "0x16E4434", VA = "0x16E4434")]
		[PreserveSig]
		public static extern int xlua_psettable_bypath(IntPtr L, int idx, string path);

		// Token: 0x06005FD8 RID: 24536
		[Token(Token = "0x6005FD8")]
		[Address(RVA = "0x16E44E4", Offset = "0x16E44E4", VA = "0x16E44E4")]
		[PreserveSig]
		public static extern bool xlua_pack_float2(IntPtr buff, int offset, float f1, float f2);

		// Token: 0x06005FD9 RID: 24537
		[Token(Token = "0x6005FD9")]
		[Address(RVA = "0x16E4588", Offset = "0x16E4588", VA = "0x16E4588")]
		[PreserveSig]
		public static extern bool xlua_unpack_float2(IntPtr buff, int offset, out float f1, out float f2);

		// Token: 0x06005FDA RID: 24538
		[Token(Token = "0x6005FDA")]
		[Address(RVA = "0x16E462C", Offset = "0x16E462C", VA = "0x16E462C")]
		[PreserveSig]
		public static extern bool xlua_pack_float3(IntPtr buff, int offset, float f1, float f2, float f3);

		// Token: 0x06005FDB RID: 24539
		[Token(Token = "0x6005FDB")]
		[Address(RVA = "0x16E46E0", Offset = "0x16E46E0", VA = "0x16E46E0")]
		[PreserveSig]
		public static extern bool xlua_unpack_float3(IntPtr buff, int offset, out float f1, out float f2, out float f3);

		// Token: 0x06005FDC RID: 24540
		[Token(Token = "0x6005FDC")]
		[Address(RVA = "0x16E4794", Offset = "0x16E4794", VA = "0x16E4794")]
		[PreserveSig]
		public static extern bool xlua_pack_float4(IntPtr buff, int offset, float f1, float f2, float f3, float f4);

		// Token: 0x06005FDD RID: 24541
		[Token(Token = "0x6005FDD")]
		[Address(RVA = "0x16E4850", Offset = "0x16E4850", VA = "0x16E4850")]
		[PreserveSig]
		public static extern bool xlua_unpack_float4(IntPtr buff, int offset, out float f1, out float f2, out float f3, out float f4);

		// Token: 0x06005FDE RID: 24542
		[Token(Token = "0x6005FDE")]
		[Address(RVA = "0x16E490C", Offset = "0x16E490C", VA = "0x16E490C")]
		[PreserveSig]
		public static extern bool xlua_pack_float5(IntPtr buff, int offset, float f1, float f2, float f3, float f4, float f5);

		// Token: 0x06005FDF RID: 24543
		[Token(Token = "0x6005FDF")]
		[Address(RVA = "0x16E49D8", Offset = "0x16E49D8", VA = "0x16E49D8")]
		[PreserveSig]
		public static extern bool xlua_unpack_float5(IntPtr buff, int offset, out float f1, out float f2, out float f3, out float f4, out float f5);

		// Token: 0x06005FE0 RID: 24544
		[Token(Token = "0x6005FE0")]
		[Address(RVA = "0x16E4AA4", Offset = "0x16E4AA4", VA = "0x16E4AA4")]
		[PreserveSig]
		public static extern bool xlua_pack_float6(IntPtr buff, int offset, float f1, float f2, float f3, float f4, float f5, float f6);

		// Token: 0x06005FE1 RID: 24545
		[Token(Token = "0x6005FE1")]
		[Address(RVA = "0x16E4B78", Offset = "0x16E4B78", VA = "0x16E4B78")]
		[PreserveSig]
		public static extern bool xlua_unpack_float6(IntPtr buff, int offset, out float f1, out float f2, out float f3, out float f4, out float f5, out float f6);

		// Token: 0x06005FE2 RID: 24546
		[Token(Token = "0x6005FE2")]
		[Address(RVA = "0x16E4C4C", Offset = "0x16E4C4C", VA = "0x16E4C4C")]
		[PreserveSig]
		public static extern bool xlua_pack_decimal(IntPtr buff, int offset, ref decimal dec);

		// Token: 0x06005FE3 RID: 24547
		[Token(Token = "0x6005FE3")]
		[Address(RVA = "0x16E4CE8", Offset = "0x16E4CE8", VA = "0x16E4CE8")]
		[PreserveSig]
		public static extern bool xlua_unpack_decimal(IntPtr buff, int offset, out byte scale, out byte sign, out int hi32, out ulong lo64);

		// Token: 0x06005FE4 RID: 24548 RVA: 0x0004B078 File Offset: 0x00049278
		[Token(Token = "0x6005FE4")]
		[Address(RVA = "0x16E4DA4", Offset = "0x16E4DA4", VA = "0x16E4DA4")]
		public static bool xlua_is_eq_str(IntPtr L, int index, string str)
		{
			return default(bool);
		}

		// Token: 0x06005FE5 RID: 24549
		[Token(Token = "0x6005FE5")]
		[Address(RVA = "0x16E4E20", Offset = "0x16E4E20", VA = "0x16E4E20")]
		[PreserveSig]
		public static extern bool xlua_is_eq_str(IntPtr L, int index, string str, int str_len);

		// Token: 0x06005FE6 RID: 24550
		[Token(Token = "0x6005FE6")]
		[Address(RVA = "0x16E4EDC", Offset = "0x16E4EDC", VA = "0x16E4EDC")]
		[PreserveSig]
		public static extern IntPtr xlua_gl(IntPtr L);

		// Token: 0x06005FE7 RID: 24551
		[Token(Token = "0x6005FE7")]
		[Address(RVA = "0x16E4F58", Offset = "0x16E4F58", VA = "0x16E4F58")]
		[PreserveSig]
		public static extern int luaopen_rapidjson(IntPtr L);

		// Token: 0x06005FE8 RID: 24552 RVA: 0x0004B090 File Offset: 0x00049290
		[Token(Token = "0x6005FE8")]
		[Address(RVA = "0x16E0CE0", Offset = "0x16E0CE0", VA = "0x16E0CE0")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LoadRapidJson(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06005FE9 RID: 24553
		[Token(Token = "0x6005FE9")]
		[Address(RVA = "0x16E4FD4", Offset = "0x16E4FD4", VA = "0x16E4FD4")]
		[PreserveSig]
		public static extern int luaopen_lpeg(IntPtr L);

		// Token: 0x06005FEA RID: 24554 RVA: 0x0004B0A8 File Offset: 0x000492A8
		[Token(Token = "0x6005FEA")]
		[Address(RVA = "0x16E0D34", Offset = "0x16E0D34", VA = "0x16E0D34")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LoadLpeg(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06005FEB RID: 24555
		[Token(Token = "0x6005FEB")]
		[Address(RVA = "0x16E5050", Offset = "0x16E5050", VA = "0x16E5050")]
		[PreserveSig]
		public static extern int luaopen_pb(IntPtr L);

		// Token: 0x06005FEC RID: 24556 RVA: 0x0004B0C0 File Offset: 0x000492C0
		[Token(Token = "0x6005FEC")]
		[Address(RVA = "0x16E0D88", Offset = "0x16E0D88", VA = "0x16E0D88")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LoadLuaProfobuf(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06005FED RID: 24557
		[Token(Token = "0x6005FED")]
		[Address(RVA = "0x16E50CC", Offset = "0x16E50CC", VA = "0x16E50CC")]
		[PreserveSig]
		public static extern int loadPbSchemeBinary(IntPtr L, byte[] pointer, int length);

		// Token: 0x06005FEE RID: 24558
		[Token(Token = "0x6005FEE")]
		[Address(RVA = "0x16E5168", Offset = "0x16E5168", VA = "0x16E5168")]
		[PreserveSig]
		public static extern int StackTopToBin(IntPtr L, byte[] buffer, int length);

		// Token: 0x06005FEF RID: 24559
		[Token(Token = "0x6005FEF")]
		[Address(RVA = "0x16E5204", Offset = "0x16E5204", VA = "0x16E5204")]
		[PreserveSig]
		public static extern IntPtr GetStackTopBufLen(IntPtr L, out IntPtr length);

		// Token: 0x06005FF0 RID: 24560
		[Token(Token = "0x6005FF0")]
		[Address(RVA = "0x16E5288", Offset = "0x16E5288", VA = "0x16E5288")]
		[PreserveSig]
		public static extern int CopyAndFreeStackTopBuf(IntPtr L, IntPtr baBytes, byte[] buffer, int length);

		// Token: 0x06005FF1 RID: 24561
		[Token(Token = "0x6005FF1")]
		[Address(RVA = "0x16E532C", Offset = "0x16E532C", VA = "0x16E532C")]
		[PreserveSig]
		public static extern int BinToStackTable(IntPtr L, byte[] buffer, int length);

		// Token: 0x06005FF2 RID: 24562
		[Token(Token = "0x6005FF2")]
		[Address(RVA = "0x16E53C8", Offset = "0x16E53C8", VA = "0x16E53C8")]
		[PreserveSig]
		public static extern int ZLibCompressBound(int level);

		// Token: 0x06005FF3 RID: 24563
		[Token(Token = "0x6005FF3")]
		[Address(RVA = "0x16E5440", Offset = "0x16E5440", VA = "0x16E5440")]
		[PreserveSig]
		public static extern int ZLibCompress(byte[] src, int srcLen, byte[] dst, int dstLen, int level);

		// Token: 0x06005FF4 RID: 24564
		[Token(Token = "0x6005FF4")]
		[Address(RVA = "0x16E54FC", Offset = "0x16E54FC", VA = "0x16E54FC")]
		[PreserveSig]
		public static extern int ZLibUnCompress(byte[] src, int srcLen, byte[] dst, int dstLen);

		// Token: 0x06005FF5 RID: 24565
		[Token(Token = "0x6005FF5")]
		[Address(RVA = "0x16E55A8", Offset = "0x16E55A8", VA = "0x16E55A8")]
		[PreserveSig]
		public static extern int WriteBufferToFile(string filePath, IntPtr buffer, int bufLen);

		// Token: 0x06005FF6 RID: 24566
		[Token(Token = "0x6005FF6")]
		[Address(RVA = "0x16E5654", Offset = "0x16E5654", VA = "0x16E5654")]
		[PreserveSig]
		public static extern int luaL_traceback(IntPtr L, IntPtr L1, byte[] msg, int level);

		// Token: 0x06005FF7 RID: 24567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FF7")]
		[Address(RVA = "0x16E56F8", Offset = "0x16E56F8", VA = "0x16E56F8")]
		public static string Traceback(IntPtr L)
		{
			return null;
		}

		// Token: 0x06005FF8 RID: 24568
		[Token(Token = "0x6005FF8")]
		[Address(RVA = "0x16E5840", Offset = "0x16E5840", VA = "0x16E5840")]
		[PreserveSig]
		private static extern void RegisterUnityLogger(Lua.UnityLogger logger);

		// Token: 0x06005FF9 RID: 24569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FF9")]
		[Address(RVA = "0x16E58C0", Offset = "0x16E58C0", VA = "0x16E58C0")]
		public static void RegisterUnityLogger()
		{
		}

		// Token: 0x06005FFA RID: 24570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FFA")]
		[Address(RVA = "0x16E0DDC", Offset = "0x16E0DDC", VA = "0x16E0DDC")]
		[MonoPInvokeCallback(typeof(Lua.UnityLogger))]
		private static void Unity_Log(int logLevel, IntPtr pointer)
		{
		}

		// Token: 0x06005FFB RID: 24571 RVA: 0x0004B0D8 File Offset: 0x000492D8
		[Token(Token = "0x6005FFB")]
		[Address(RVA = "0x16E0E8C", Offset = "0x16E0E8C", VA = "0x16E0E8C")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int Load_luaUtil(IntPtr L, byte[] pointer, int length)
		{
			return 0;
		}

		// Token: 0x06005FFC RID: 24572
		[Token(Token = "0x6005FFC")]
		[Address(RVA = "0x16E5A2C", Offset = "0x16E5A2C", VA = "0x16E5A2C")]
		[PreserveSig]
		public static extern int luaopen_split(IntPtr L);

		// Token: 0x06005FFD RID: 24573 RVA: 0x0004B0F0 File Offset: 0x000492F0
		[Token(Token = "0x6005FFD")]
		[Address(RVA = "0x16E0EF8", Offset = "0x16E0EF8", VA = "0x16E0EF8")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LoadStringExt(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06005FFE RID: 24574
		[Token(Token = "0x6005FFE")]
		[Address(RVA = "0x16E5AA8", Offset = "0x16E5AA8", VA = "0x16E5AA8")]
		[PreserveSig]
		public static extern int luaopen_native(IntPtr L);

		// Token: 0x06005FFF RID: 24575 RVA: 0x0004B108 File Offset: 0x00049308
		[Token(Token = "0x6005FFF")]
		[Address(RVA = "0x16E0F4C", Offset = "0x16E0F4C", VA = "0x16E0F4C")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LoadLuaCNativeCode(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06006000 RID: 24576
		[Token(Token = "0x6006000")]
		[Address(RVA = "0x16E5B24", Offset = "0x16E5B24", VA = "0x16E5B24")]
		[PreserveSig]
		public static extern int pbn_loadPbSchemeBinary(byte[] pointer, int length);

		// Token: 0x06006001 RID: 24577
		[Token(Token = "0x6006001")]
		[Address(RVA = "0x16E5BB0", Offset = "0x16E5BB0", VA = "0x16E5BB0")]
		[PreserveSig]
		public static extern int pbn_setPbTag(int tag, string protoName);

		// Token: 0x06006002 RID: 24578
		[Token(Token = "0x6006002")]
		[Address(RVA = "0x16E5C4C", Offset = "0x16E5C4C", VA = "0x16E5C4C")]
		[PreserveSig]
		public static extern int pbn_global_clear();

		// Token: 0x06006003 RID: 24579
		[Token(Token = "0x6006003")]
		[Address(RVA = "0x16E5CB4", Offset = "0x16E5CB4", VA = "0x16E5CB4")]
		[PreserveSig]
		public static extern IntPtr pbn_decode(byte[] data, int d_size, string type, int t_size);

		// Token: 0x06006004 RID: 24580
		[Token(Token = "0x6006004")]
		[Address(RVA = "0x16E5D78", Offset = "0x16E5D78", VA = "0x16E5D78")]
		[PreserveSig]
		public static extern int pbn_free(long root);

		// Token: 0x06006005 RID: 24581 RVA: 0x0004B120 File Offset: 0x00049320
		[Token(Token = "0x6006005")]
		[Address(RVA = "0x16E0FA0", Offset = "0x16E0FA0", VA = "0x16E0FA0")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LoadLuaPbNode(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06006006 RID: 24582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006006")]
		[Address(RVA = "0x16E5DF0", Offset = "0x16E5DF0", VA = "0x16E5DF0")]
		public Lua()
		{
		}

		// Token: 0x0400251F RID: 9503
		[Token(Token = "0x400251F")]
		private const string LUADLL = "xlua";

		// Token: 0x04002520 RID: 9504
		[Token(Token = "0x4002520")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<long, string> StrCache;

		// Token: 0x020009CB RID: 2507
		// (Invoke) Token: 0x06006009 RID: 24585
		[Token(Token = "0x20009CB")]
		private delegate void UnityLogger(int logLevel, IntPtr pointer);
	}
}
