using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Coffee.UIParticleExtensions
{
	// Token: 0x02000A41 RID: 2625
	[Token(Token = "0x2000A41")]
	internal static class ParticleSystemExtensions
	{
		// Token: 0x06006363 RID: 25443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006363")]
		[Address(RVA = "0x3042D10", Offset = "0x3042D10", VA = "0x3042D10")]
		public static void SortForRendering(this List<ParticleSystem> self, Transform transform, bool sortByMaterial)
		{
		}

		// Token: 0x06006364 RID: 25444 RVA: 0x0004BD50 File Offset: 0x00049F50
		[Token(Token = "0x6006364")]
		[Address(RVA = "0x3042E20", Offset = "0x3042E20", VA = "0x3042E20")]
		private static int GetIndex(IList<ParticleSystem> list, Object ps)
		{
			return 0;
		}

		// Token: 0x06006365 RID: 25445 RVA: 0x0004BD68 File Offset: 0x00049F68
		[Token(Token = "0x6006365")]
		[Address(RVA = "0x3042F88", Offset = "0x3042F88", VA = "0x3042F88")]
		public static long GetMaterialHash(this ParticleSystem self, bool trail)
		{
			return 0L;
		}

		// Token: 0x06006366 RID: 25446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006366")]
		[Address(RVA = "0x30430E4", Offset = "0x30430E4", VA = "0x30430E4")]
		public static Texture2D GetTextureForSprite(this ParticleSystem self)
		{
			return null;
		}

		// Token: 0x06006367 RID: 25447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006367")]
		[Address(RVA = "0x3043218", Offset = "0x3043218", VA = "0x3043218")]
		public static void Exec(this List<ParticleSystem> self, Action<ParticleSystem> action)
		{
		}
	}
}
