using System;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Scripting;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x020007F1 RID: 2033
	[Token(Token = "0x20007F1")]
	[Preserve]
	[Il2CppSetOption(Option.NullChecks, false)]
	public class UnityEngineSpaceWrap
	{
		// Token: 0x0600389F RID: 14495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600389F")]
		[Address(RVA = "0x286CB68", Offset = "0x286CB68", VA = "0x286CB68")]
		public static void __Register(IntPtr L)
		{
		}

		// Token: 0x060038A0 RID: 14496 RVA: 0x00016818 File Offset: 0x00014A18
		[Token(Token = "0x60038A0")]
		[Address(RVA = "0x286C8D4", Offset = "0x286C8D4", VA = "0x286C8D4")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CastFrom(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060038A1 RID: 14497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038A1")]
		[Address(RVA = "0x286CDF0", Offset = "0x286CDF0", VA = "0x286CDF0")]
		public UnityEngineSpaceWrap()
		{
		}
	}
}
