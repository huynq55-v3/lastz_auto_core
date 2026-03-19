using System;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Scripting;
using XLua.LuaDLL;

namespace XLua
{
	// Token: 0x02000556 RID: 1366
	[Token(Token = "0x2000556")]
	[Il2CppSetOption(Option.NullChecks, false)]
	[Preserve]
	public class StaticLuaCallbacks
	{
		// Token: 0x060028CB RID: 10443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028CB")]
		[Address(RVA = "0x26B8750", Offset = "0x26B8750", VA = "0x26B8750")]
		public StaticLuaCallbacks()
		{
		}

		// Token: 0x060028CC RID: 10444 RVA: 0x0000F558 File Offset: 0x0000D758
		[Token(Token = "0x60028CC")]
		[Address(RVA = "0x26BF97C", Offset = "0x26BF97C", VA = "0x26BF97C")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int EnumAnd(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x0000F570 File Offset: 0x0000D770
		[Token(Token = "0x60028CD")]
		[Address(RVA = "0x26BFC68", Offset = "0x26BFC68", VA = "0x26BFC68")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int EnumOr(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x0000F588 File Offset: 0x0000D788
		[Token(Token = "0x60028CE")]
		[Address(RVA = "0x26BFF54", Offset = "0x26BFF54", VA = "0x26BFF54")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int StaticCSFunction(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060028CF RID: 10447 RVA: 0x0000F5A0 File Offset: 0x0000D7A0
		[Token(Token = "0x60028CF")]
		[Address(RVA = "0x26C0118", Offset = "0x26C0118", VA = "0x26C0118")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int FixCSFunction(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060028D0 RID: 10448 RVA: 0x0000F5B8 File Offset: 0x0000D7B8
		[Token(Token = "0x60028D0")]
		[Address(RVA = "0x26C02C0", Offset = "0x26C02C0", VA = "0x26C02C0")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int DelegateCall(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060028D1 RID: 10449 RVA: 0x0000F5D0 File Offset: 0x0000D7D0
		[Token(Token = "0x60028D1")]
		[Address(RVA = "0x26C04D4", Offset = "0x26C04D4", VA = "0x26C04D4")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LuaGC(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060028D2 RID: 10450 RVA: 0x0000F5E8 File Offset: 0x0000D7E8
		[Token(Token = "0x60028D2")]
		[Address(RVA = "0x26C065C", Offset = "0x26C065C", VA = "0x26C065C")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ToString(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060028D3 RID: 10451 RVA: 0x0000F600 File Offset: 0x0000D800
		[Token(Token = "0x60028D3")]
		[Address(RVA = "0x26C084C", Offset = "0x26C084C", VA = "0x26C084C")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int DelegateCombine(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x0000F618 File Offset: 0x0000D818
		[Token(Token = "0x60028D4")]
		[Address(RVA = "0x26C0B14", Offset = "0x26C0B14", VA = "0x26C0B14")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int DelegateRemove(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x0000F630 File Offset: 0x0000D830
		[Token(Token = "0x60028D5")]
		[Address(RVA = "0x26C5BEC", Offset = "0x26C5BEC", VA = "0x26C5BEC")]
		private static bool tryPrimitiveArrayGet(Type type, IntPtr L, object obj, int index)
		{
			return default(bool);
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x0000F648 File Offset: 0x0000D848
		[Token(Token = "0x60028D6")]
		[Address(RVA = "0x26C0DBC", Offset = "0x26C0DBC", VA = "0x26C0DBC")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ArrayIndexer(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x0000F660 File Offset: 0x0000D860
		[Token(Token = "0x60028D7")]
		[Address(RVA = "0x26B42BC", Offset = "0x26B42BC", VA = "0x26B42BC")]
		public static bool TryPrimitiveArraySet(Type type, IntPtr L, object obj, int array_idx, int obj_idx)
		{
			return default(bool);
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x0000F678 File Offset: 0x0000D878
		[Token(Token = "0x60028D8")]
		[Address(RVA = "0x26C12A8", Offset = "0x26C12A8", VA = "0x26C12A8")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ArrayNewIndexer(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x0000F690 File Offset: 0x0000D890
		[Token(Token = "0x60028D9")]
		[Address(RVA = "0x26C17BC", Offset = "0x26C17BC", VA = "0x26C17BC")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ArrayLength(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x0000F6A8 File Offset: 0x0000D8A8
		[Token(Token = "0x60028DA")]
		[Address(RVA = "0x26C1988", Offset = "0x26C1988", VA = "0x26C1988")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int MetaFuncIndex(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060028DB RID: 10459 RVA: 0x0000F6C0 File Offset: 0x0000D8C0
		[Token(Token = "0x60028DB")]
		[Address(RVA = "0x26C1C00", Offset = "0x26C1C00", VA = "0x26C1C00")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int Panic(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060028DC RID: 10460 RVA: 0x0000F6D8 File Offset: 0x0000D8D8
		[Token(Token = "0x60028DC")]
		[Address(RVA = "0x26C1C84", Offset = "0x26C1C84", VA = "0x26C1C84")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int Print(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060028DD RID: 10461 RVA: 0x0000F6F0 File Offset: 0x0000D8F0
		[Token(Token = "0x60028DD")]
		[Address(RVA = "0x26C2064", Offset = "0x26C2064", VA = "0x26C2064")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadSocketCore(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060028DE RID: 10462 RVA: 0x0000F708 File Offset: 0x0000D908
		[Token(Token = "0x60028DE")]
		[Address(RVA = "0x26C20BC", Offset = "0x26C20BC", VA = "0x26C20BC")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadCS(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060028DF RID: 10463 RVA: 0x0000F720 File Offset: 0x0000D920
		[Token(Token = "0x60028DF")]
		[Address(RVA = "0x26C2148", Offset = "0x26C2148", VA = "0x26C2148")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadBuiltinLib(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060028E0 RID: 10464 RVA: 0x0000F738 File Offset: 0x0000D938
		[Token(Token = "0x60028E0")]
		[Address(RVA = "0x26C2370", Offset = "0x26C2370", VA = "0x26C2370")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadFromResource(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060028E1 RID: 10465 RVA: 0x0000F750 File Offset: 0x0000D950
		[Token(Token = "0x60028E1")]
		[Address(RVA = "0x26C2704", Offset = "0x26C2704", VA = "0x26C2704")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadFromStreamingAssetsPath(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060028E2 RID: 10466 RVA: 0x0000F768 File Offset: 0x0000D968
		[Token(Token = "0x60028E2")]
		[Address(RVA = "0x26C2C80", Offset = "0x26C2C80", VA = "0x26C2C80")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadFromCustomLoaders(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060028E3 RID: 10467 RVA: 0x0000F780 File Offset: 0x0000D980
		[Token(Token = "0x60028E3")]
		[Address(RVA = "0x26C32E0", Offset = "0x26C32E0", VA = "0x26C32E0")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LoadAssembly(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060028E4 RID: 10468 RVA: 0x0000F798 File Offset: 0x0000D998
		[Token(Token = "0x60028E4")]
		[Address(RVA = "0x26C35E8", Offset = "0x26C35E8", VA = "0x26C35E8")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ImportType(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060028E5 RID: 10469 RVA: 0x0000F7B0 File Offset: 0x0000D9B0
		[Token(Token = "0x60028E5")]
		[Address(RVA = "0x26C38A8", Offset = "0x26C38A8", VA = "0x26C38A8")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ImportGenericType(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060028E6 RID: 10470 RVA: 0x0000F7C8 File Offset: 0x0000D9C8
		[Token(Token = "0x60028E6")]
		[Address(RVA = "0x26C3D50", Offset = "0x26C3D50", VA = "0x26C3D50")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int Cast(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060028E7 RID: 10471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028E7")]
		[Address(RVA = "0x26C64B8", Offset = "0x26C64B8", VA = "0x26C64B8")]
		private static Type getType(IntPtr L, ObjectTranslator translator, int idx)
		{
			return null;
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x0000F7E0 File Offset: 0x0000D9E0
		[Token(Token = "0x60028E8")]
		[Address(RVA = "0x26C406C", Offset = "0x26C406C", VA = "0x26C406C")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int XLuaAccess(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060028E9 RID: 10473 RVA: 0x0000F7F8 File Offset: 0x0000D9F8
		[Token(Token = "0x60028E9")]
		[Address(RVA = "0x26C4590", Offset = "0x26C4590", VA = "0x26C4590")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int XLuaPrivateAccessible(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x0000F810 File Offset: 0x0000DA10
		[Token(Token = "0x60028EA")]
		[Address(RVA = "0x26C47E8", Offset = "0x26C47E8", VA = "0x26C47E8")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int XLuaMetatableOperation(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060028EB RID: 10475 RVA: 0x0000F828 File Offset: 0x0000DA28
		[Token(Token = "0x60028EB")]
		[Address(RVA = "0x26C4B94", Offset = "0x26C4B94", VA = "0x26C4B94")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int DelegateConstructor(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060028EC RID: 10476 RVA: 0x0000F840 File Offset: 0x0000DA40
		[Token(Token = "0x60028EC")]
		[Address(RVA = "0x26C4E00", Offset = "0x26C4E00", VA = "0x26C4E00")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ToFunction(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x0000F858 File Offset: 0x0000DA58
		[Token(Token = "0x60028ED")]
		[Address(RVA = "0x26C5108", Offset = "0x26C5108", VA = "0x26C5108")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int GenericMethodWraper(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060028EE RID: 10478 RVA: 0x0000F870 File Offset: 0x0000DA70
		[Token(Token = "0x60028EE")]
		[Address(RVA = "0x26C5598", Offset = "0x26C5598", VA = "0x26C5598")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int GetGenericMethod(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060028EF RID: 10479 RVA: 0x0000F888 File Offset: 0x0000DA88
		[Token(Token = "0x60028EF")]
		[Address(RVA = "0x26C5AC0", Offset = "0x26C5AC0", VA = "0x26C5AC0")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ReleaseCsObject(IntPtr L)
		{
			return 0;
		}

		// Token: 0x04002432 RID: 9266
		[Token(Token = "0x4002432")]
		[FieldOffset(Offset = "0x10")]
		internal lua_CSFunction GcMeta;

		// Token: 0x04002433 RID: 9267
		[Token(Token = "0x4002433")]
		[FieldOffset(Offset = "0x18")]
		internal lua_CSFunction ToStringMeta;

		// Token: 0x04002434 RID: 9268
		[Token(Token = "0x4002434")]
		[FieldOffset(Offset = "0x20")]
		internal lua_CSFunction EnumAndMeta;

		// Token: 0x04002435 RID: 9269
		[Token(Token = "0x4002435")]
		[FieldOffset(Offset = "0x28")]
		internal lua_CSFunction EnumOrMeta;

		// Token: 0x04002436 RID: 9270
		[Token(Token = "0x4002436")]
		[FieldOffset(Offset = "0x30")]
		internal lua_CSFunction StaticCSFunctionWraper;

		// Token: 0x04002437 RID: 9271
		[Token(Token = "0x4002437")]
		[FieldOffset(Offset = "0x38")]
		internal lua_CSFunction FixCSFunctionWraper;

		// Token: 0x04002438 RID: 9272
		[Token(Token = "0x4002438")]
		[FieldOffset(Offset = "0x40")]
		internal lua_CSFunction DelegateCtor;
	}
}
