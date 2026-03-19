using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Scripting;
using XLua.LuaDLL;

namespace XLua
{
	// Token: 0x0200052D RID: 1325
	[Token(Token = "0x200052D")]
	[Il2CppSetOption(Option.NullChecks, false)]
	[Preserve]
	public class MethodWrapsCache
	{
		// Token: 0x060027C6 RID: 10182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C6")]
		[Address(RVA = "0x26ACA88", Offset = "0x26ACA88", VA = "0x26ACA88")]
		public MethodWrapsCache(ObjectTranslator translator, ObjectCheckers objCheckers, ObjectCasters objCasters)
		{
		}

		// Token: 0x060027C7 RID: 10183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027C7")]
		[Address(RVA = "0x26ACBCC", Offset = "0x26ACBCC", VA = "0x26ACBCC")]
		public lua_CSFunction GetConstructorWrap(Type type)
		{
			return null;
		}

		// Token: 0x060027C8 RID: 10184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027C8")]
		[Address(RVA = "0x26AD404", Offset = "0x26AD404", VA = "0x26AD404")]
		public lua_CSFunction GetMethodWrap(Type type, string methodName)
		{
			return null;
		}

		// Token: 0x060027C9 RID: 10185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027C9")]
		[Address(RVA = "0x26AD648", Offset = "0x26AD648", VA = "0x26AD648")]
		public lua_CSFunction GetMethodWrapInCache(Type type, string methodName)
		{
			return null;
		}

		// Token: 0x060027CA RID: 10186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027CA")]
		[Address(RVA = "0x26AD7AC", Offset = "0x26AD7AC", VA = "0x26AD7AC")]
		public lua_CSFunction GetDelegateWrap(Type type)
		{
			return null;
		}

		// Token: 0x060027CB RID: 10187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027CB")]
		[Address(RVA = "0x26AD9EC", Offset = "0x26AD9EC", VA = "0x26AD9EC")]
		public lua_CSFunction GetEventWrap(Type type, string eventName)
		{
			return null;
		}

		// Token: 0x060027CC RID: 10188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027CC")]
		[Address(RVA = "0x26ACF38", Offset = "0x26ACF38", VA = "0x26ACF38")]
		public MethodWrap _GenMethodWrap(Type type, string methodName, IEnumerable<MemberInfo> methodBases, bool forceCheck = false)
		{
			return null;
		}

		// Token: 0x060027CD RID: 10189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027CD")]
		[Address(RVA = "0x26ADDE4", Offset = "0x26ADDE4", VA = "0x26ADDE4")]
		public MethodWrap _GenMethodWrap(Type type, string methodName, MemberInfo methodBase, bool forceCheck = false)
		{
			return null;
		}

		// Token: 0x060027CE RID: 10190 RVA: 0x0000EFD0 File Offset: 0x0000D1D0
		[Token(Token = "0x60027CE")]
		[Address(RVA = "0x26ADFD8", Offset = "0x26ADFD8", VA = "0x26ADFD8")]
		private static bool tryMakeGenericMethod(ref MethodBase method)
		{
			return default(bool);
		}

		// Token: 0x0400239C RID: 9116
		[Token(Token = "0x400239C")]
		[FieldOffset(Offset = "0x10")]
		private ObjectTranslator translator;

		// Token: 0x0400239D RID: 9117
		[Token(Token = "0x400239D")]
		[FieldOffset(Offset = "0x18")]
		private ObjectCheckers objCheckers;

		// Token: 0x0400239E RID: 9118
		[Token(Token = "0x400239E")]
		[FieldOffset(Offset = "0x20")]
		private ObjectCasters objCasters;

		// Token: 0x0400239F RID: 9119
		[Token(Token = "0x400239F")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<Type, lua_CSFunction> constructorCache;

		// Token: 0x040023A0 RID: 9120
		[Token(Token = "0x40023A0")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<Type, Dictionary<string, lua_CSFunction>> methodsCache;

		// Token: 0x040023A1 RID: 9121
		[Token(Token = "0x40023A1")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<Type, lua_CSFunction> delegateCache;
	}
}
