using System;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x0200084D RID: 2125
	[Token(Token = "0x200084D")]
	[Il2CppSetOption(Option.NullChecks, false)]
	public class ITouchObjectBeginDragHandlerWrap
	{
		// Token: 0x06003B2E RID: 15150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B2E")]
		[Address(RVA = "0x2B7CFBC", Offset = "0x2B7CFBC", VA = "0x2B7CFBC")]
		public static void __Register(IntPtr L)
		{
		}

		// Token: 0x06003B2F RID: 15151 RVA: 0x00019440 File Offset: 0x00017640
		[Token(Token = "0x6003B2F")]
		[Address(RVA = "0x2B7CCB0", Offset = "0x2B7CCB0", VA = "0x2B7CCB0")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003B30 RID: 15152 RVA: 0x00019458 File Offset: 0x00017658
		[Token(Token = "0x6003B30")]
		[Address(RVA = "0x2B7CD20", Offset = "0x2B7CD20", VA = "0x2B7CD20")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_OnBeginDrag(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003B31 RID: 15153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B31")]
		[Address(RVA = "0x2B7D1B8", Offset = "0x2B7D1B8", VA = "0x2B7D1B8")]
		public ITouchObjectBeginDragHandlerWrap()
		{
		}
	}
}
