using System;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x02000999 RID: 2457
	[Token(Token = "0x2000999")]
	[Il2CppSetOption(Option.NullChecks, false)]
	public class UnityExtension_CommonWrap
	{
		// Token: 0x06005D04 RID: 23812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D04")]
		[Address(RVA = "0x135C4C8", Offset = "0x135C4C8", VA = "0x135C4C8")]
		public static void __Register(IntPtr L)
		{
		}

		// Token: 0x06005D05 RID: 23813 RVA: 0x000481E0 File Offset: 0x000463E0
		[Token(Token = "0x6005D05")]
		[Address(RVA = "0x135C458", Offset = "0x135C458", VA = "0x135C458")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06005D06 RID: 23814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D06")]
		[Address(RVA = "0x135C660", Offset = "0x135C660", VA = "0x135C660")]
		public UnityExtension_CommonWrap()
		{
		}
	}
}
