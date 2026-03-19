using System;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x02000873 RID: 2163
	[Token(Token = "0x2000873")]
	[Il2CppSetOption(Option.NullChecks, false)]
	public class ParkourDynamicRootWrap
	{
		// Token: 0x06003CD0 RID: 15568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CD0")]
		[Address(RVA = "0x1BABF70", Offset = "0x1BABF70", VA = "0x1BABF70")]
		public static void __Register(IntPtr L)
		{
		}

		// Token: 0x06003CD1 RID: 15569 RVA: 0x0001B420 File Offset: 0x00019620
		[Token(Token = "0x6003CD1")]
		[Address(RVA = "0x1BABBA0", Offset = "0x1BABBA0", VA = "0x1BABBA0")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003CD2 RID: 15570 RVA: 0x0001B438 File Offset: 0x00019638
		[Token(Token = "0x6003CD2")]
		[Address(RVA = "0x1BABD90", Offset = "0x1BABD90", VA = "0x1BABD90")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SetParkourLogicLateUpdate(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003CD3 RID: 15571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CD3")]
		[Address(RVA = "0x1BAC16C", Offset = "0x1BAC16C", VA = "0x1BAC16C")]
		public ParkourDynamicRootWrap()
		{
		}
	}
}
