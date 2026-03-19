using System;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x0200085B RID: 2139
	[Token(Token = "0x200085B")]
	[Il2CppSetOption(Option.NullChecks, false)]
	public class LuaMonoUpdateWrap
	{
		// Token: 0x06003B9F RID: 15263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B9F")]
		[Address(RVA = "0x2B8A0C8", Offset = "0x2B8A0C8", VA = "0x2B8A0C8")]
		public static void __Register(IntPtr L)
		{
		}

		// Token: 0x06003BA0 RID: 15264 RVA: 0x00019C38 File Offset: 0x00017E38
		[Token(Token = "0x6003BA0")]
		[Address(RVA = "0x2B89ED8", Offset = "0x2B89ED8", VA = "0x2B89ED8")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003BA1 RID: 15265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BA1")]
		[Address(RVA = "0x2B8A260", Offset = "0x2B8A260", VA = "0x2B8A260")]
		public LuaMonoUpdateWrap()
		{
		}
	}
}
