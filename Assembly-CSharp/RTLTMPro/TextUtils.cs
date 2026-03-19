using System;
using Il2CppDummyDll;

namespace RTLTMPro
{
	// Token: 0x02000CD1 RID: 3281
	[Token(Token = "0x2000CD1")]
	public static class TextUtils
	{
		// Token: 0x06007BB8 RID: 31672 RVA: 0x000544B0 File Offset: 0x000526B0
		[Token(Token = "0x6007BB8")]
		[Address(RVA = "0x31929EC", Offset = "0x31929EC", VA = "0x31929EC")]
		public static bool IsPunctuation(char ch)
		{
			return default(bool);
		}

		// Token: 0x06007BB9 RID: 31673 RVA: 0x000544C8 File Offset: 0x000526C8
		[Token(Token = "0x6007BB9")]
		[Address(RVA = "0x3192A2C", Offset = "0x3192A2C", VA = "0x3192A2C")]
		public static bool IsNumber(char ch, bool preserveNumbers, bool farsi)
		{
			return default(bool);
		}

		// Token: 0x06007BBA RID: 31674 RVA: 0x000544E0 File Offset: 0x000526E0
		[Token(Token = "0x6007BBA")]
		[Address(RVA = "0x3192A68", Offset = "0x3192A68", VA = "0x3192A68")]
		public static bool IsEnglishNumber(char ch)
		{
			return default(bool);
		}

		// Token: 0x06007BBB RID: 31675 RVA: 0x000544F8 File Offset: 0x000526F8
		[Token(Token = "0x6007BBB")]
		[Address(RVA = "0x3192A90", Offset = "0x3192A90", VA = "0x3192A90")]
		public static bool IsFarsiNumber(char ch)
		{
			return default(bool);
		}

		// Token: 0x06007BBC RID: 31676 RVA: 0x00054510 File Offset: 0x00052710
		[Token(Token = "0x6007BBC")]
		[Address(RVA = "0x3192A7C", Offset = "0x3192A7C", VA = "0x3192A7C")]
		public static bool IsHinduNumber(char ch)
		{
			return default(bool);
		}

		// Token: 0x06007BBD RID: 31677 RVA: 0x00054528 File Offset: 0x00052728
		[Token(Token = "0x6007BBD")]
		[Address(RVA = "0x3192AA4", Offset = "0x3192AA4", VA = "0x3192AA4")]
		public static bool IsEnglishLetter(char ch)
		{
			return default(bool);
		}

		// Token: 0x06007BBE RID: 31678 RVA: 0x00054540 File Offset: 0x00052740
		[Token(Token = "0x6007BBE")]
		[Address(RVA = "0x3192AD0", Offset = "0x3192AD0", VA = "0x3192AD0")]
		public static bool IsHebrewCharacter(char ch)
		{
			return default(bool);
		}

		// Token: 0x06007BBF RID: 31679 RVA: 0x00054558 File Offset: 0x00052758
		[Token(Token = "0x6007BBF")]
		[Address(RVA = "0x3192AE4", Offset = "0x3192AE4", VA = "0x3192AE4")]
		public static bool IsArabicCharacter(char ch)
		{
			return default(bool);
		}

		// Token: 0x06007BC0 RID: 31680 RVA: 0x00054570 File Offset: 0x00052770
		[Token(Token = "0x6007BC0")]
		[Address(RVA = "0x3192B3C", Offset = "0x3192B3C", VA = "0x3192B3C")]
		public static bool IsRTLCharacter(char ch)
		{
			return default(bool);
		}

		// Token: 0x06007BC1 RID: 31681 RVA: 0x00054588 File Offset: 0x00052788
		[Token(Token = "0x6007BC1")]
		[Address(RVA = "0x3192BA8", Offset = "0x3192BA8", VA = "0x3192BA8")]
		public static bool IsGlyphFixedArabicCharacter(char ch)
		{
			return default(bool);
		}

		// Token: 0x06007BC2 RID: 31682 RVA: 0x000545A0 File Offset: 0x000527A0
		[Token(Token = "0x6007BC2")]
		[Address(RVA = "0x3192F20", Offset = "0x3192F20", VA = "0x3192F20")]
		public static bool IsRTLInput(string input)
		{
			return default(bool);
		}

		// Token: 0x040036DD RID: 14045
		[Token(Token = "0x40036DD")]
		private const char LowerCaseA = 'a';

		// Token: 0x040036DE RID: 14046
		[Token(Token = "0x40036DE")]
		private const char UpperCaseA = 'A';

		// Token: 0x040036DF RID: 14047
		[Token(Token = "0x40036DF")]
		private const char LowerCaseZ = 'z';

		// Token: 0x040036E0 RID: 14048
		[Token(Token = "0x40036E0")]
		private const char UpperCaseZ = 'Z';

		// Token: 0x040036E1 RID: 14049
		[Token(Token = "0x40036E1")]
		private const char HebrewLow = '\u0591';

		// Token: 0x040036E2 RID: 14050
		[Token(Token = "0x40036E2")]
		private const char HebrewHigh = '״';

		// Token: 0x040036E3 RID: 14051
		[Token(Token = "0x40036E3")]
		private const char ArabicBaseBlockLow = '\u0600';

		// Token: 0x040036E4 RID: 14052
		[Token(Token = "0x40036E4")]
		private const char ArabicBaseBlockHigh = 'ۿ';

		// Token: 0x040036E5 RID: 14053
		[Token(Token = "0x40036E5")]
		private const char ArabicExtendedABlockLow = 'ࢠ';

		// Token: 0x040036E6 RID: 14054
		[Token(Token = "0x40036E6")]
		private const char ArabicExtendedABlockHigh = '\u08ff';

		// Token: 0x040036E7 RID: 14055
		[Token(Token = "0x40036E7")]
		private const char ArabicExtendedBBlockLow = 'ࡰ';

		// Token: 0x040036E8 RID: 14056
		[Token(Token = "0x40036E8")]
		private const char ArabicExtendedBBlockHigh = '\u089f';

		// Token: 0x040036E9 RID: 14057
		[Token(Token = "0x40036E9")]
		private const char ArabicPresentationFormsABlockLow = 'ﭐ';

		// Token: 0x040036EA RID: 14058
		[Token(Token = "0x40036EA")]
		private const char ArabicPresentationFormsABlockHigh = '﷿';

		// Token: 0x040036EB RID: 14059
		[Token(Token = "0x40036EB")]
		private const char ArabicPresentationFormsBBlockLow = 'ﹰ';

		// Token: 0x040036EC RID: 14060
		[Token(Token = "0x40036EC")]
		private const char ArabicPresentationFormsBBlockHigh = '\ufeff';
	}
}
