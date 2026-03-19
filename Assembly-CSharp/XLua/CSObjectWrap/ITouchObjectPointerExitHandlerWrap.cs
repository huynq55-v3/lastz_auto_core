using System;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x02000853 RID: 2131
	[Token(Token = "0x2000853")]
	[Il2CppSetOption(Option.NullChecks, false)]
	public class ITouchObjectPointerExitHandlerWrap
	{
		// Token: 0x06003B46 RID: 15174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B46")]
		[Address(RVA = "0x2B7ECBC", Offset = "0x2B7ECBC", VA = "0x2B7ECBC")]
		public static void __Register(IntPtr L)
		{
		}

		// Token: 0x06003B47 RID: 15175 RVA: 0x00019560 File Offset: 0x00017760
		[Token(Token = "0x6003B47")]
		[Address(RVA = "0x2B7EA18", Offset = "0x2B7EA18", VA = "0x2B7EA18")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003B48 RID: 15176 RVA: 0x00019578 File Offset: 0x00017778
		[Token(Token = "0x6003B48")]
		[Address(RVA = "0x2B7EA88", Offset = "0x2B7EA88", VA = "0x2B7EA88")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_OnPointerExit(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003B49 RID: 15177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B49")]
		[Address(RVA = "0x2B7EEB8", Offset = "0x2B7EEB8", VA = "0x2B7EEB8")]
		public ITouchObjectPointerExitHandlerWrap()
		{
		}
	}
}
