using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Scripting;
using XLua.LuaDLL;

namespace XLua
{
	// Token: 0x0200055A RID: 1370
	[Token(Token = "0x200055A")]
	[Il2CppSetOption(Option.NullChecks, false)]
	[Preserve]
	public static class Utils
	{
		// Token: 0x06002900 RID: 10496 RVA: 0x0000F9A8 File Offset: 0x0000DBA8
		[Token(Token = "0x6002900")]
		[Address(RVA = "0x26C75BC", Offset = "0x26C75BC", VA = "0x26C75BC")]
		public static bool LoadField(IntPtr L, int idx, string field_name)
		{
			return default(bool);
		}

		// Token: 0x06002901 RID: 10497 RVA: 0x0000F9C0 File Offset: 0x0000DBC0
		[Token(Token = "0x6002901")]
		[Address(RVA = "0x26C7680", Offset = "0x26C7680", VA = "0x26C7680")]
		public static IntPtr GetMainState(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06002902 RID: 10498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002902")]
		[Address(RVA = "0x26C7768", Offset = "0x26C7768", VA = "0x26C7768")]
		public static List<Type> GetAllTypes(bool exclude_generic_definition = true)
		{
			return null;
		}

		// Token: 0x06002903 RID: 10499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002903")]
		[Address(RVA = "0x26C79B4", Offset = "0x26C79B4", VA = "0x26C79B4")]
		private static lua_CSFunction genFieldGetter(Type type, FieldInfo field)
		{
			return null;
		}

		// Token: 0x06002904 RID: 10500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002904")]
		[Address(RVA = "0x26C7AB8", Offset = "0x26C7AB8", VA = "0x26C7AB8")]
		private static lua_CSFunction genFieldSetter(Type type, FieldInfo field)
		{
			return null;
		}

		// Token: 0x06002905 RID: 10501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002905")]
		[Address(RVA = "0x26C7BBC", Offset = "0x26C7BBC", VA = "0x26C7BBC")]
		private static lua_CSFunction genItemGetter(Type type, PropertyInfo[] props)
		{
			return null;
		}

		// Token: 0x06002906 RID: 10502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002906")]
		[Address(RVA = "0x26C7EBC", Offset = "0x26C7EBC", VA = "0x26C7EBC")]
		private static lua_CSFunction genItemSetter(Type type, PropertyInfo[] props)
		{
			return null;
		}

		// Token: 0x06002907 RID: 10503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002907")]
		[Address(RVA = "0x26C81BC", Offset = "0x26C81BC", VA = "0x26C81BC")]
		private static lua_CSFunction genEnumCastFrom(Type type)
		{
			return null;
		}

		// Token: 0x06002908 RID: 10504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002908")]
		[Address(RVA = "0x26C8270", Offset = "0x26C8270", VA = "0x26C8270")]
		internal static IEnumerable<MethodInfo> GetExtensionMethodsOf(Type type_to_be_extend)
		{
			return null;
		}

		// Token: 0x06002909 RID: 10505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002909")]
		[Address(RVA = "0x26C9014", Offset = "0x26C9014", VA = "0x26C9014")]
		private static void makeReflectionWrap(IntPtr L, Type type, int cls_field, int cls_getter, int cls_setter, int obj_field, int obj_getter, int obj_setter, int obj_meta, out lua_CSFunction item_getter, out lua_CSFunction item_setter, BindingFlags access)
		{
		}

		// Token: 0x0600290A RID: 10506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600290A")]
		[Address(RVA = "0x26CAB98", Offset = "0x26CAB98", VA = "0x26CAB98")]
		public static void loadUpvalue(IntPtr L, Type type, string metafunc, int index)
		{
		}

		// Token: 0x0600290B RID: 10507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600290B")]
		[Address(RVA = "0x26CAD44", Offset = "0x26CAD44", VA = "0x26CAD44")]
		public static void RegisterEnumType(IntPtr L, Type type)
		{
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600290C")]
		[Address(RVA = "0x26BC484", Offset = "0x26BC484", VA = "0x26BC484")]
		public static void MakePrivateAccessible(IntPtr L, Type type)
		{
		}

		// Token: 0x0600290D RID: 10509 RVA: 0x0000F9D8 File Offset: 0x0000DBD8
		[Token(Token = "0x600290D")]
		[Address(RVA = "0x26C6778", Offset = "0x26C6778", VA = "0x26C6778")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LazyReflectionCall(IntPtr L)
		{
			return 0;
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600290E")]
		[Address(RVA = "0x26B6940", Offset = "0x26B6940", VA = "0x26B6940")]
		public static void ReflectionWrap(IntPtr L, Type type, bool privateAccessible)
		{
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600290F")]
		[Address(RVA = "0x26BA6F4", Offset = "0x26BA6F4", VA = "0x26BA6F4")]
		public static void BeginObjectRegister(Type type, IntPtr L, ObjectTranslator translator, int meta_count, int method_count, int getter_count, int setter_count, int type_id = -1)
		{
		}

		// Token: 0x06002910 RID: 10512 RVA: 0x0000F9F0 File Offset: 0x0000DBF0
		[Token(Token = "0x6002910")]
		[Address(RVA = "0x26CB690", Offset = "0x26CB690", VA = "0x26CB690")]
		private static int abs_idx(int top, int idx)
		{
			return 0;
		}

		// Token: 0x06002911 RID: 10513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002911")]
		[Address(RVA = "0x26BABC4", Offset = "0x26BABC4", VA = "0x26BABC4")]
		public static void EndObjectRegister(Type type, IntPtr L, ObjectTranslator translator, lua_CSFunction csIndexer, lua_CSFunction csNewIndexer, Type base_type, lua_CSFunction arrayIndexer, lua_CSFunction arrayNewIndexer)
		{
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002912")]
		[Address(RVA = "0x26BAAE4", Offset = "0x26BAAE4", VA = "0x26BAAE4")]
		public static void RegisterFunc(IntPtr L, int idx, string name, lua_CSFunction func)
		{
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002913")]
		[Address(RVA = "0x26CB6A0", Offset = "0x26CB6A0", VA = "0x26CB6A0")]
		public static void RegisterLazyFunc(IntPtr L, int idx, string name, Type type, LazyMemberTypes memberType, bool isStatic)
		{
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002914")]
		[Address(RVA = "0x26CAE78", Offset = "0x26CAE78", VA = "0x26CAE78")]
		public static void RegisterObject(IntPtr L, ObjectTranslator translator, int idx, string name, object obj)
		{
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002915")]
		[Address(RVA = "0x26CB80C", Offset = "0x26CB80C", VA = "0x26CB80C")]
		public static void BeginClassRegister(Type type, IntPtr L, lua_CSFunction creator, int class_field_count, int static_getter_count, int static_setter_count)
		{
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002916")]
		[Address(RVA = "0x26CBA58", Offset = "0x26CBA58", VA = "0x26CBA58")]
		public static void EndClassRegister(Type type, IntPtr L, ObjectTranslator translator)
		{
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002917")]
		[Address(RVA = "0x26CBD50", Offset = "0x26CBD50", VA = "0x26CBD50")]
		private static List<string> getPathOfType(Type type, List<string> path)
		{
			return null;
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002918")]
		[Address(RVA = "0x26CAF58", Offset = "0x26CAF58", VA = "0x26CAF58")]
		public static void LoadCSTable(IntPtr L, Type type)
		{
		}

		// Token: 0x06002919 RID: 10521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002919")]
		[Address(RVA = "0x26CB1A4", Offset = "0x26CB1A4", VA = "0x26CB1A4")]
		public static void SetCSTable(IntPtr L, Type type, int cls_table)
		{
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x0000FA08 File Offset: 0x0000DC08
		[Token(Token = "0x600291A")]
		[Address(RVA = "0x26B996C", Offset = "0x26B996C", VA = "0x26B996C")]
		public static bool IsParamsMatch(MethodInfo delegateMethod, MethodInfo bridgeMethod)
		{
			return default(bool);
		}

		// Token: 0x0600291B RID: 10523 RVA: 0x0000FA20 File Offset: 0x0000DC20
		[Token(Token = "0x600291B")]
		[Address(RVA = "0x26AE290", Offset = "0x26AE290", VA = "0x26AE290")]
		public static bool IsSupportedMethod(MethodInfo method)
		{
			return default(bool);
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600291C")]
		[Address(RVA = "0x26CBE34", Offset = "0x26CBE34", VA = "0x26CBE34")]
		public static MethodInfo MakeGenericMethodWithConstraints(MethodInfo method)
		{
			return null;
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600291D")]
		[Address(RVA = "0x26CBFF4", Offset = "0x26CBFF4", VA = "0x26CBFF4")]
		private static Type getExtendedType(MethodInfo method)
		{
			return null;
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x0000FA38 File Offset: 0x0000DC38
		[Token(Token = "0x600291E")]
		[Address(RVA = "0x26BD46C", Offset = "0x26BD46C", VA = "0x26BD46C")]
		public static bool IsStaticPInvokeCSFunction(lua_CSFunction csFunction)
		{
			return default(bool);
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x0000FA50 File Offset: 0x0000DC50
		[Token(Token = "0x600291F")]
		[Address(RVA = "0x26CC0C8", Offset = "0x26CC0C8", VA = "0x26CC0C8")]
		public static bool IsPublic(Type type)
		{
			return default(bool);
		}

		// Token: 0x04002442 RID: 9282
		[Token(Token = "0x4002442")]
		[FieldOffset(Offset = "0x0")]
		private static List<PropertyInfo> items;

		// Token: 0x04002443 RID: 9283
		[Token(Token = "0x4002443")]
		[FieldOffset(Offset = "0x8")]
		private static PropertyInfo[] EmptyPropertyArray;

		// Token: 0x04002444 RID: 9284
		[Token(Token = "0x4002444")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<Utils.MethodKey, List<MemberInfo>> pending_methods;

		// Token: 0x04002445 RID: 9285
		[Token(Token = "0x4002445")]
		public const int OBJ_META_IDX = -4;

		// Token: 0x04002446 RID: 9286
		[Token(Token = "0x4002446")]
		public const int METHOD_IDX = -3;

		// Token: 0x04002447 RID: 9287
		[Token(Token = "0x4002447")]
		public const int GETTER_IDX = -2;

		// Token: 0x04002448 RID: 9288
		[Token(Token = "0x4002448")]
		public const int SETTER_IDX = -1;

		// Token: 0x04002449 RID: 9289
		[Token(Token = "0x4002449")]
		public const int CLS_IDX = -4;

		// Token: 0x0400244A RID: 9290
		[Token(Token = "0x400244A")]
		public const int CLS_META_IDX = -3;

		// Token: 0x0400244B RID: 9291
		[Token(Token = "0x400244B")]
		public const int CLS_GETTER_IDX = -2;

		// Token: 0x0400244C RID: 9292
		[Token(Token = "0x400244C")]
		public const int CLS_SETTER_IDX = -1;

		// Token: 0x0400244D RID: 9293
		[Token(Token = "0x400244D")]
		[FieldOffset(Offset = "0x18")]
		private static readonly char[] SplitChars;

		// Token: 0x0400244E RID: 9294
		[Token(Token = "0x400244E")]
		[FieldOffset(Offset = "0x20")]
		private static readonly List<string> TempList;

		// Token: 0x0400244F RID: 9295
		[Token(Token = "0x400244F")]
		public const string LuaIndexsFieldName = "LuaIndexs";

		// Token: 0x04002450 RID: 9296
		[Token(Token = "0x4002450")]
		public const string LuaNewIndexsFieldName = "LuaNewIndexs";

		// Token: 0x04002451 RID: 9297
		[Token(Token = "0x4002451")]
		public const string LuaClassIndexsFieldName = "LuaClassIndexs";

		// Token: 0x04002452 RID: 9298
		[Token(Token = "0x4002452")]
		public const string LuaClassNewIndexsFieldName = "LuaClassNewIndexs";

		// Token: 0x0200055B RID: 1371
		[Token(Token = "0x200055B")]
		private struct MethodKey
		{
			// Token: 0x04002453 RID: 9299
			[Token(Token = "0x4002453")]
			[FieldOffset(Offset = "0x0")]
			public string Name;

			// Token: 0x04002454 RID: 9300
			[Token(Token = "0x4002454")]
			[FieldOffset(Offset = "0x8")]
			public bool IsStatic;
		}
	}
}
