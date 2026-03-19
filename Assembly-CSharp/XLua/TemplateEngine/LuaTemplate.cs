using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua.LuaDLL;

namespace XLua.TemplateEngine
{
	// Token: 0x020009BD RID: 2493
	[Token(Token = "0x20009BD")]
	public class LuaTemplate
	{
		// Token: 0x06005F44 RID: 24388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F44")]
		[Address(RVA = "0x16DFA48", Offset = "0x16DFA48", VA = "0x16DFA48")]
		public static string ComposeCode(List<Chunk> chunks)
		{
			return null;
		}

		// Token: 0x06005F45 RID: 24389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F45")]
		[Address(RVA = "0x16DFD38", Offset = "0x16DFD38", VA = "0x16DFD38")]
		public static LuaFunction Compile(LuaEnv luaenv, string snippet)
		{
			return null;
		}

		// Token: 0x06005F46 RID: 24390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F46")]
		[Address(RVA = "0x16DFE00", Offset = "0x16DFE00", VA = "0x16DFE00")]
		public static string Execute(LuaFunction compiledTemplate, LuaTable parameters)
		{
			return null;
		}

		// Token: 0x06005F47 RID: 24391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F47")]
		[Address(RVA = "0x16DFEC8", Offset = "0x16DFEC8", VA = "0x16DFEC8")]
		public static string Execute(LuaFunction compiledTemplate)
		{
			return null;
		}

		// Token: 0x06005F48 RID: 24392 RVA: 0x0004AF58 File Offset: 0x00049158
		[Token(Token = "0x6005F48")]
		[Address(RVA = "0x16DF748", Offset = "0x16DF748", VA = "0x16DF748")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int Compile(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06005F49 RID: 24393 RVA: 0x0004AF70 File Offset: 0x00049170
		[Token(Token = "0x6005F49")]
		[Address(RVA = "0x16DF94C", Offset = "0x16DF94C", VA = "0x16DF94C")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int Execute(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06005F4A RID: 24394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F4A")]
		[Address(RVA = "0x16E0274", Offset = "0x16E0274", VA = "0x16E0274")]
		public static void OpenLib(IntPtr L)
		{
		}

		// Token: 0x06005F4B RID: 24395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F4B")]
		[Address(RVA = "0x16E07C8", Offset = "0x16E07C8", VA = "0x16E07C8")]
		public LuaTemplate()
		{
		}

		// Token: 0x0400251C RID: 9500
		[Token(Token = "0x400251C")]
		[FieldOffset(Offset = "0x0")]
		private static lua_CSFunction templateCompileFunction;

		// Token: 0x0400251D RID: 9501
		[Token(Token = "0x400251D")]
		[FieldOffset(Offset = "0x8")]
		private static lua_CSFunction templateExecuteFunction;
	}
}
