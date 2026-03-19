using System;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x0200084F RID: 2127
	[Token(Token = "0x200084F")]
	[Il2CppSetOption(Option.NullChecks, false)]
	public class ITouchObjectClickHandlerWrap
	{
		// Token: 0x06003B36 RID: 15158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B36")]
		[Address(RVA = "0x2B7D90C", Offset = "0x2B7D90C", VA = "0x2B7D90C")]
		public static void __Register(IntPtr L)
		{
		}

		// Token: 0x06003B37 RID: 15159 RVA: 0x000194A0 File Offset: 0x000176A0
		[Token(Token = "0x6003B37")]
		[Address(RVA = "0x2B7D668", Offset = "0x2B7D668", VA = "0x2B7D668")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003B38 RID: 15160 RVA: 0x000194B8 File Offset: 0x000176B8
		[Token(Token = "0x6003B38")]
		[Address(RVA = "0x2B7D6D8", Offset = "0x2B7D6D8", VA = "0x2B7D6D8")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_OnClick(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003B39 RID: 15161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B39")]
		[Address(RVA = "0x2B7DB08", Offset = "0x2B7DB08", VA = "0x2B7DB08")]
		public ITouchObjectClickHandlerWrap()
		{
		}
	}
}
