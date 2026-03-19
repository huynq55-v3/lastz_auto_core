using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Coffee.UIParticleExtensions
{
	// Token: 0x02000A3D RID: 2621
	[Token(Token = "0x2000A3D")]
	internal static class ListExtensions
	{
		// Token: 0x06006354 RID: 25428 RVA: 0x0004BCF0 File Offset: 0x00049EF0
		[Token(Token = "0x6006354")]
		[Address(RVA = "0x3042478", Offset = "0x3042478", VA = "0x3042478")]
		public static bool SequenceEqualFast(this List<bool> self, List<bool> value)
		{
			return default(bool);
		}

		// Token: 0x06006355 RID: 25429 RVA: 0x0004BD08 File Offset: 0x00049F08
		[Token(Token = "0x6006355")]
		[Address(RVA = "0x3042540", Offset = "0x3042540", VA = "0x3042540")]
		public static int CountFast(this List<bool> self)
		{
			return 0;
		}

		// Token: 0x06006356 RID: 25430 RVA: 0x0004BD20 File Offset: 0x00049F20
		[Token(Token = "0x6006356")]
		public static bool AnyFast<T>(this List<T> self) where T : Object
		{
			return default(bool);
		}

		// Token: 0x06006357 RID: 25431 RVA: 0x0004BD38 File Offset: 0x00049F38
		[Token(Token = "0x6006357")]
		public static bool AnyFast<T>(this List<T> self, Predicate<T> predicate) where T : Object
		{
			return default(bool);
		}
	}
}
