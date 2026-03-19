using System;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x0200085A RID: 2138
	[Token(Token = "0x200085A")]
	[Il2CppSetOption(Option.NullChecks, false)]
	public class LuaMonoConfigWrap
	{
		// Token: 0x06003B9C RID: 15260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B9C")]
		[Address(RVA = "0x2B89D38", Offset = "0x2B89D38", VA = "0x2B89D38")]
		public static void __Register(IntPtr L)
		{
		}

		// Token: 0x06003B9D RID: 15261 RVA: 0x00019C20 File Offset: 0x00017E20
		[Token(Token = "0x6003B9D")]
		[Address(RVA = "0x2B89B48", Offset = "0x2B89B48", VA = "0x2B89B48")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003B9E RID: 15262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B9E")]
		[Address(RVA = "0x2B89ED0", Offset = "0x2B89ED0", VA = "0x2B89ED0")]
		public LuaMonoConfigWrap()
		{
		}
	}
}
