using System;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x02000850 RID: 2128
	[Token(Token = "0x2000850")]
	[Il2CppSetOption(Option.NullChecks, false)]
	public class ITouchObjectDragHandlerWrap
	{
		// Token: 0x06003B3A RID: 15162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B3A")]
		[Address(RVA = "0x2B7DE5C", Offset = "0x2B7DE5C", VA = "0x2B7DE5C")]
		public static void __Register(IntPtr L)
		{
		}

		// Token: 0x06003B3B RID: 15163 RVA: 0x000194D0 File Offset: 0x000176D0
		[Token(Token = "0x6003B3B")]
		[Address(RVA = "0x2B7DB10", Offset = "0x2B7DB10", VA = "0x2B7DB10")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003B3C RID: 15164 RVA: 0x000194E8 File Offset: 0x000176E8
		[Token(Token = "0x6003B3C")]
		[Address(RVA = "0x2B7DB80", Offset = "0x2B7DB80", VA = "0x2B7DB80")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_OnDrag(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003B3D RID: 15165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B3D")]
		[Address(RVA = "0x2B7E058", Offset = "0x2B7E058", VA = "0x2B7E058")]
		public ITouchObjectDragHandlerWrap()
		{
		}
	}
}
