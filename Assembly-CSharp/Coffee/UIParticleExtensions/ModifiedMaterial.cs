using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Coffee.UIParticleExtensions
{
	// Token: 0x02000A3A RID: 2618
	[Token(Token = "0x2000A3A")]
	internal class ModifiedMaterial
	{
		// Token: 0x0600634D RID: 25421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600634D")]
		[Address(RVA = "0x3041DDC", Offset = "0x3041DDC", VA = "0x3041DDC")]
		public static Material Add(Material baseMat, Texture texture, int id)
		{
			return null;
		}

		// Token: 0x0600634E RID: 25422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600634E")]
		[Address(RVA = "0x30420E0", Offset = "0x30420E0", VA = "0x30420E0")]
		public static void Remove(Material customMat)
		{
		}

		// Token: 0x0600634F RID: 25423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600634F")]
		[Address(RVA = "0x30422B4", Offset = "0x30422B4", VA = "0x30422B4")]
		private static void DestroyImmediate(Object obj)
		{
		}

		// Token: 0x06006350 RID: 25424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006350")]
		[Address(RVA = "0x3042358", Offset = "0x3042358", VA = "0x3042358")]
		public ModifiedMaterial()
		{
		}

		// Token: 0x040027FB RID: 10235
		[Token(Token = "0x40027FB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<ModifiedMaterial.MatEntry> s_Entries;

		// Token: 0x02000A3B RID: 2619
		[Token(Token = "0x2000A3B")]
		private class MatEntry
		{
			// Token: 0x06006352 RID: 25426 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006352")]
			[Address(RVA = "0x30420D8", Offset = "0x30420D8", VA = "0x30420D8")]
			public MatEntry()
			{
			}

			// Token: 0x040027FC RID: 10236
			[Token(Token = "0x40027FC")]
			[FieldOffset(Offset = "0x10")]
			public Material baseMat;

			// Token: 0x040027FD RID: 10237
			[Token(Token = "0x40027FD")]
			[FieldOffset(Offset = "0x18")]
			public Material customMat;

			// Token: 0x040027FE RID: 10238
			[Token(Token = "0x40027FE")]
			[FieldOffset(Offset = "0x20")]
			public int count;

			// Token: 0x040027FF RID: 10239
			[Token(Token = "0x40027FF")]
			[FieldOffset(Offset = "0x28")]
			public Texture texture;

			// Token: 0x04002800 RID: 10240
			[Token(Token = "0x4002800")]
			[FieldOffset(Offset = "0x30")]
			public int id;
		}
	}
}
