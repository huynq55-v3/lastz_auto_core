using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace RTLTMPro
{
	// Token: 0x02000CCF RID: 3279
	[Token(Token = "0x2000CCF")]
	public static class TashkeelFixer
	{
		// Token: 0x06007BAF RID: 31663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BAF")]
		[Address(RVA = "0x3191BA0", Offset = "0x3191BA0", VA = "0x3191BA0")]
		public static void RemoveTashkeel(FastStringBuilder input)
		{
		}

		// Token: 0x06007BB0 RID: 31664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BB0")]
		[Address(RVA = "0x3191DA0", Offset = "0x3191DA0", VA = "0x3191DA0")]
		public static void RestoreTashkeel(FastStringBuilder letters)
		{
		}

		// Token: 0x06007BB1 RID: 31665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BB1")]
		[Address(RVA = "0x3191F34", Offset = "0x3191F34", VA = "0x3191F34")]
		public static void FixShaddaCombinations(FastStringBuilder input)
		{
		}

		// Token: 0x040036CC RID: 14028
		[Token(Token = "0x40036CC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<TashkeelLocation> TashkeelLocations;

		// Token: 0x040036CD RID: 14029
		[Token(Token = "0x40036CD")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string ShaddaDammatan;

		// Token: 0x040036CE RID: 14030
		[Token(Token = "0x40036CE")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string ShaddaKasratan;

		// Token: 0x040036CF RID: 14031
		[Token(Token = "0x40036CF")]
		[FieldOffset(Offset = "0x18")]
		private static readonly string ShaddaSuperscriptAlef;

		// Token: 0x040036D0 RID: 14032
		[Token(Token = "0x40036D0")]
		[FieldOffset(Offset = "0x20")]
		private static readonly string ShaddaFatha;

		// Token: 0x040036D1 RID: 14033
		[Token(Token = "0x40036D1")]
		[FieldOffset(Offset = "0x28")]
		private static readonly string ShaddaDamma;

		// Token: 0x040036D2 RID: 14034
		[Token(Token = "0x40036D2")]
		[FieldOffset(Offset = "0x30")]
		private static readonly string ShaddaKasra;

		// Token: 0x040036D3 RID: 14035
		[Token(Token = "0x40036D3")]
		[FieldOffset(Offset = "0x38")]
		private static readonly string ShaddaWithFathaIsolatedForm;

		// Token: 0x040036D4 RID: 14036
		[Token(Token = "0x40036D4")]
		[FieldOffset(Offset = "0x40")]
		private static readonly string ShaddaWithDammaIsolatedForm;

		// Token: 0x040036D5 RID: 14037
		[Token(Token = "0x40036D5")]
		[FieldOffset(Offset = "0x48")]
		private static readonly string ShaddaWithKasraIsolatedForm;

		// Token: 0x040036D6 RID: 14038
		[Token(Token = "0x40036D6")]
		[FieldOffset(Offset = "0x50")]
		private static readonly string ShaddaWithDammatanIsolatedForm;

		// Token: 0x040036D7 RID: 14039
		[Token(Token = "0x40036D7")]
		[FieldOffset(Offset = "0x58")]
		private static readonly string ShaddaWithKasratanIsolatedForm;

		// Token: 0x040036D8 RID: 14040
		[Token(Token = "0x40036D8")]
		[FieldOffset(Offset = "0x60")]
		private static readonly string ShaddaWithSuperscriptAlefIsolatedForm;

		// Token: 0x040036D9 RID: 14041
		[Token(Token = "0x40036D9")]
		[FieldOffset(Offset = "0x68")]
		private static readonly HashSet<char> TashkeelCharactersSet;

		// Token: 0x040036DA RID: 14042
		[Token(Token = "0x40036DA")]
		[FieldOffset(Offset = "0x70")]
		private static readonly Dictionary<char, char> ShaddaCombinationMap;
	}
}
