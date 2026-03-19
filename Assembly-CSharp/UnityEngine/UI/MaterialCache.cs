using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	// Token: 0x02000CB9 RID: 3257
	[Token(Token = "0x2000CB9")]
	internal static class MaterialCache
	{
		// Token: 0x06007B0F RID: 31503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007B0F")]
		[Address(RVA = "0x3220D30", Offset = "0x3220D30", VA = "0x3220D30")]
		public static Material Register(Material material, Hash128 hash, Action<Material> onModify)
		{
			return null;
		}

		// Token: 0x06007B10 RID: 31504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B10")]
		[Address(RVA = "0x3220EE8", Offset = "0x3220EE8", VA = "0x3220EE8")]
		public static void Unregister(Hash128 hash)
		{
		}

		// Token: 0x0400362D RID: 13869
		[Token(Token = "0x400362D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Hash128, MaterialEntry> s_MaterialMap;
	}
}
