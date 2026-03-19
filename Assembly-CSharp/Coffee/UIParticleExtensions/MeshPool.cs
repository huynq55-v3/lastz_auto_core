using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Coffee.UIParticleExtensions
{
	// Token: 0x02000A3F RID: 2623
	[Token(Token = "0x2000A3F")]
	internal static class MeshPool
	{
		// Token: 0x0600635B RID: 25435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600635B")]
		[Address(RVA = "0x3042AE4", Offset = "0x3042AE4", VA = "0x3042AE4")]
		public static void Init()
		{
		}

		// Token: 0x0600635D RID: 25437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600635D")]
		[Address(RVA = "0x3040A30", Offset = "0x3040A30", VA = "0x3040A30")]
		public static Mesh Rent()
		{
			return null;
		}

		// Token: 0x0600635E RID: 25438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600635E")]
		[Address(RVA = "0x3040E04", Offset = "0x3040E04", VA = "0x3040E04")]
		public static void Return(Mesh mesh)
		{
		}

		// Token: 0x04002802 RID: 10242
		[Token(Token = "0x4002802")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Stack<Mesh> s_Pool;
	}
}
