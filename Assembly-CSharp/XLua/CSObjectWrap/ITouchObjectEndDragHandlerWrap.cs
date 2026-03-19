using System;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x02000851 RID: 2129
	[Token(Token = "0x2000851")]
	[Il2CppSetOption(Option.NullChecks, false)]
	public class ITouchObjectEndDragHandlerWrap
	{
		// Token: 0x06003B3E RID: 15166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B3E")]
		[Address(RVA = "0x2B7E36C", Offset = "0x2B7E36C", VA = "0x2B7E36C")]
		public static void __Register(IntPtr L)
		{
		}

		// Token: 0x06003B3F RID: 15167 RVA: 0x00019500 File Offset: 0x00017700
		[Token(Token = "0x6003B3F")]
		[Address(RVA = "0x2B7E060", Offset = "0x2B7E060", VA = "0x2B7E060")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003B40 RID: 15168 RVA: 0x00019518 File Offset: 0x00017718
		[Token(Token = "0x6003B40")]
		[Address(RVA = "0x2B7E0D0", Offset = "0x2B7E0D0", VA = "0x2B7E0D0")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_OnEndDrag(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003B41 RID: 15169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B41")]
		[Address(RVA = "0x2B7E568", Offset = "0x2B7E568", VA = "0x2B7E568")]
		public ITouchObjectEndDragHandlerWrap()
		{
		}
	}
}
