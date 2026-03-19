using System;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Scripting;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x02000821 RID: 2081
	[Token(Token = "0x2000821")]
	[Preserve]
	[Il2CppSetOption(Option.NullChecks, false)]
	public class MarchStatusWrap
	{
		// Token: 0x0600392F RID: 14639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600392F")]
		[Address(RVA = "0x28801AC", Offset = "0x28801AC", VA = "0x28801AC")]
		public static void __Register(IntPtr L)
		{
		}

		// Token: 0x06003930 RID: 14640 RVA: 0x00016C98 File Offset: 0x00014E98
		[Token(Token = "0x6003930")]
		[Address(RVA = "0x287FE3C", Offset = "0x287FE3C", VA = "0x287FE3C")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CastFrom(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003931 RID: 14641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003931")]
		[Address(RVA = "0x28803AC", Offset = "0x28803AC", VA = "0x28803AC")]
		public MarchStatusWrap()
		{
		}
	}
}
