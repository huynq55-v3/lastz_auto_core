using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Scripting;
using XLua.LuaDLL;

namespace XLua
{
	// Token: 0x0200051E RID: 1310
	[Token(Token = "0x200051E")]
	[Il2CppSetOption(Option.NullChecks, false)]
	[Preserve]
	internal class InternalGlobals
	{
		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06002743 RID: 10051 RVA: 0x0000EE20 File Offset: 0x0000D020
		[Token(Token = "0x170005DC")]
		internal static bool Gen_Flag
		{
			[Token(Token = "0x6002743")]
			[Address(RVA = "0x2B68988", Offset = "0x2B68988", VA = "0x2B68988")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002744")]
		[Address(RVA = "0x2B69AEC", Offset = "0x2B69AEC", VA = "0x2B69AEC")]
		internal static Delegate ConvertDelegate(Delegate sourceDelegate, Type targetType)
		{
			return null;
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002745")]
		[Address(RVA = "0x2B69790", Offset = "0x2B69790", VA = "0x2B69790")]
		internal static void Init()
		{
		}

		// Token: 0x06002746 RID: 10054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002746")]
		[Address(RVA = "0x2B69B20", Offset = "0x2B69B20", VA = "0x2B69B20")]
		public InternalGlobals()
		{
		}

		// Token: 0x0400234B RID: 9035
		[Token(Token = "0x400234B")]
		[FieldOffset(Offset = "0x0")]
		internal static byte[] strBuff;

		// Token: 0x0400234C RID: 9036
		[Token(Token = "0x400234C")]
		[FieldOffset(Offset = "0x8")]
		internal static InternalGlobals.TryArrayGet genTryArrayGetPtr;

		// Token: 0x0400234D RID: 9037
		[Token(Token = "0x400234D")]
		[FieldOffset(Offset = "0x10")]
		internal static InternalGlobals.TryArraySet genTryArraySetPtr;

		// Token: 0x0400234E RID: 9038
		[Token(Token = "0x400234E")]
		[FieldOffset(Offset = "0x18")]
		internal static ObjectTranslatorPool objectTranslatorPool;

		// Token: 0x0400234F RID: 9039
		[Token(Token = "0x400234F")]
		[FieldOffset(Offset = "0x20")]
		internal static int LUA_REGISTRYINDEX;

		// Token: 0x04002350 RID: 9040
		[Token(Token = "0x4002350")]
		[FieldOffset(Offset = "0x28")]
		internal static Dictionary<string, string> supportOp;

		// Token: 0x04002351 RID: 9041
		[Token(Token = "0x4002351")]
		[FieldOffset(Offset = "0x30")]
		internal static Dictionary<Type, IEnumerable<MethodInfo>> extensionMethodMap;

		// Token: 0x04002352 RID: 9042
		[Token(Token = "0x4002352")]
		[FieldOffset(Offset = "0x38")]
		internal static lua_CSFunction LazyReflectionWrap;

		// Token: 0x04002353 RID: 9043
		[Token(Token = "0x4002353")]
		[FieldOffset(Offset = "0x40")]
		internal static Type delegate_birdge_type;

		// Token: 0x04002354 RID: 9044
		[Token(Token = "0x4002354")]
		[FieldOffset(Offset = "0x48")]
		private static int initState;

		// Token: 0x0200051F RID: 1311
		// (Invoke) Token: 0x06002749 RID: 10057
		[Token(Token = "0x200051F")]
		internal delegate bool TryArrayGet(Type type, IntPtr L, ObjectTranslator translator, object obj, int index);

		// Token: 0x02000520 RID: 1312
		// (Invoke) Token: 0x0600274D RID: 10061
		[Token(Token = "0x2000520")]
		internal delegate bool TryArraySet(Type type, IntPtr L, ObjectTranslator translator, object obj, int array_idx, int obj_idx);
	}
}
