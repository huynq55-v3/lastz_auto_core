using System;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x02000868 RID: 2152
	[Token(Token = "0x2000868")]
	[Il2CppSetOption(Option.NullChecks, false)]
	public class MonoUtilsWrap
	{
		// Token: 0x06003C2F RID: 15407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C2F")]
		[Address(RVA = "0x1B968CC", Offset = "0x1B968CC", VA = "0x1B968CC")]
		public static void __Register(IntPtr L)
		{
		}

		// Token: 0x06003C30 RID: 15408 RVA: 0x0001A718 File Offset: 0x00018918
		[Token(Token = "0x6003C30")]
		[Address(RVA = "0x1B9685C", Offset = "0x1B9685C", VA = "0x1B9685C")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003C31 RID: 15409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C31")]
		[Address(RVA = "0x1B96A64", Offset = "0x1B96A64", VA = "0x1B96A64")]
		public MonoUtilsWrap()
		{
		}
	}
}
