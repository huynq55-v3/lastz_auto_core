using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Coffee.UIParticleExtensions
{
	// Token: 0x02000A40 RID: 2624
	[Token(Token = "0x2000A40")]
	internal static class CombineInstanceArrayPool
	{
		// Token: 0x0600635F RID: 25439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600635F")]
		[Address(RVA = "0x3042C00", Offset = "0x3042C00", VA = "0x3042C00")]
		public static void Init()
		{
		}

		// Token: 0x06006361 RID: 25441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006361")]
		[Address(RVA = "0x30407D0", Offset = "0x30407D0", VA = "0x30407D0")]
		public static CombineInstance[] Get(List<CombineInstance> src)
		{
			return null;
		}

		// Token: 0x06006362 RID: 25442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006362")]
		[Address(RVA = "0x3041BDC", Offset = "0x3041BDC", VA = "0x3041BDC")]
		public static CombineInstance[] Get(List<CombineInstanceEx> src, int count)
		{
			return null;
		}

		// Token: 0x04002803 RID: 10243
		[Token(Token = "0x4002803")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<int, CombineInstance[]> s_Pool;
	}
}
