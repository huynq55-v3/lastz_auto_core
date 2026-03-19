using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace EPOOutline
{
	// Token: 0x02000CA4 RID: 3236
	[Token(Token = "0x2000CA4")]
	public static class RendererFilteringUtility
	{
		// Token: 0x06007AA7 RID: 31399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AA7")]
		[Address(RVA = "0x321A57C", Offset = "0x321A57C", VA = "0x321A57C")]
		public static void Filter(Camera camera, OutlineParameters parameters)
		{
		}

		// Token: 0x040035F3 RID: 13811
		[Token(Token = "0x40035F3")]
		[FieldOffset(Offset = "0x0")]
		private static List<Outlinable> filteredOutlinables;
	}
}
