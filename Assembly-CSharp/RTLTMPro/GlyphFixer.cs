using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace RTLTMPro
{
	// Token: 0x02000CC7 RID: 3271
	[Token(Token = "0x2000CC7")]
	public static class GlyphFixer
	{
		// Token: 0x06007B96 RID: 31638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B96")]
		[Address(RVA = "0x322A438", Offset = "0x322A438", VA = "0x322A438")]
		public static void Fix(FastStringBuilder input, FastStringBuilder output, bool preserveNumbers, bool farsi, bool fixTextTags)
		{
		}

		// Token: 0x06007B97 RID: 31639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B97")]
		[Address(RVA = "0x322A768", Offset = "0x322A768", VA = "0x322A768")]
		public static void FixYah(FastStringBuilder text, bool farsi)
		{
		}

		// Token: 0x06007B98 RID: 31640 RVA: 0x000543D8 File Offset: 0x000525D8
		[Token(Token = "0x6007B98")]
		[Address(RVA = "0x322A7F8", Offset = "0x322A7F8", VA = "0x322A7F8")]
		private static bool HandleSpecialLam(FastStringBuilder input, FastStringBuilder output, int i)
		{
			return default(bool);
		}

		// Token: 0x06007B99 RID: 31641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B99")]
		[Address(RVA = "0x322B17C", Offset = "0x322B17C", VA = "0x322B17C")]
		public static void FixNumbers(FastStringBuilder text, bool farsi)
		{
		}

		// Token: 0x06007B9A RID: 31642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B9A")]
		[Address(RVA = "0x322AF40", Offset = "0x322AF40", VA = "0x322AF40")]
		public static void FixNumbersOutsideOfTags(FastStringBuilder text, bool farsi)
		{
		}

		// Token: 0x06007B9B RID: 31643 RVA: 0x000543F0 File Offset: 0x000525F0
		[Token(Token = "0x6007B9B")]
		[Address(RVA = "0x322AD20", Offset = "0x322AD20", VA = "0x322AD20")]
		private static bool IsLeadingLetter(FastStringBuilder letters, int index)
		{
			return default(bool);
		}

		// Token: 0x06007B9C RID: 31644 RVA: 0x00054408 File Offset: 0x00052608
		[Token(Token = "0x6007B9C")]
		[Address(RVA = "0x322ABE0", Offset = "0x322ABE0", VA = "0x322ABE0")]
		private static bool IsFinishingLetter(FastStringBuilder letters, int index)
		{
			return default(bool);
		}

		// Token: 0x06007B9D RID: 31645 RVA: 0x00054420 File Offset: 0x00052620
		[Token(Token = "0x6007B9D")]
		[Address(RVA = "0x322A998", Offset = "0x322A998", VA = "0x322A998")]
		private static bool IsMiddleLetter(FastStringBuilder letters, int index)
		{
			return default(bool);
		}

		// Token: 0x040036B9 RID: 14009
		[Token(Token = "0x40036B9")]
		[FieldOffset(Offset = "0x0")]
		public static Dictionary<char, char> EnglishToFarsiNumberMap;

		// Token: 0x040036BA RID: 14010
		[Token(Token = "0x40036BA")]
		[FieldOffset(Offset = "0x8")]
		public static Dictionary<char, char> EnglishToHinduNumberMap;
	}
}
