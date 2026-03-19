using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;

namespace ArabicSupport
{
	// Token: 0x02000CD9 RID: 3289
	[Token(Token = "0x2000CD9")]
	public class ArabicFixerSpec
	{
		// Token: 0x06007BC3 RID: 31683 RVA: 0x000545B8 File Offset: 0x000527B8
		[Token(Token = "0x6007BC3")]
		[Address(RVA = "0x3193004", Offset = "0x3193004", VA = "0x3193004")]
		public static bool IsCharTaskkeel(char ch)
		{
			return default(bool);
		}

		// Token: 0x06007BC4 RID: 31684 RVA: 0x000545D0 File Offset: 0x000527D0
		[Token(Token = "0x6007BC4")]
		[Address(RVA = "0x3193084", Offset = "0x3193084", VA = "0x3193084")]
		public static char GeneralArabicLetter2IsolatedArabicLetter(char generalArabicLetter)
		{
			return '\0';
		}

		// Token: 0x06007BC5 RID: 31685 RVA: 0x000545E8 File Offset: 0x000527E8
		[Token(Token = "0x6007BC5")]
		[Address(RVA = "0x3193124", Offset = "0x3193124", VA = "0x3193124")]
		public static bool IsIgnoredCharacter(char ch)
		{
			return default(bool);
		}

		// Token: 0x06007BC6 RID: 31686 RVA: 0x00054600 File Offset: 0x00052800
		[Token(Token = "0x6007BC6")]
		[Address(RVA = "0x3193280", Offset = "0x3193280", VA = "0x3193280")]
		public static bool IsLeadingLetter(StringBuilder letters, int index)
		{
			return default(bool);
		}

		// Token: 0x06007BC7 RID: 31687 RVA: 0x00054618 File Offset: 0x00052818
		[Token(Token = "0x6007BC7")]
		[Address(RVA = "0x31937F4", Offset = "0x31937F4", VA = "0x31937F4")]
		public static bool IsFinishingLetter(StringBuilder letters, int index)
		{
			return default(bool);
		}

		// Token: 0x06007BC8 RID: 31688 RVA: 0x00054630 File Offset: 0x00052830
		[Token(Token = "0x6007BC8")]
		[Address(RVA = "0x3193AB4", Offset = "0x3193AB4", VA = "0x3193AB4")]
		public static bool IsMiddleLetter(StringBuilder letters, int index)
		{
			return default(bool);
		}

		// Token: 0x06007BC9 RID: 31689 RVA: 0x00054648 File Offset: 0x00052848
		[Token(Token = "0x6007BC9")]
		[Address(RVA = "0x319405C", Offset = "0x319405C", VA = "0x319405C")]
		public static char ConvertNumberToHindu(char numberChar)
		{
			return '\0';
		}

		// Token: 0x06007BCA RID: 31690 RVA: 0x00054660 File Offset: 0x00052860
		[Token(Token = "0x6007BCA")]
		[Address(RVA = "0x31940D0", Offset = "0x31940D0", VA = "0x31940D0")]
		public static bool NeedForceBreak(char input, out char output)
		{
			return default(bool);
		}

		// Token: 0x06007BCB RID: 31691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BCB")]
		[Address(RVA = "0x3194160", Offset = "0x3194160", VA = "0x3194160")]
		public ArabicFixerSpec()
		{
		}

		// Token: 0x04003778 RID: 14200
		[Token(Token = "0x4003778")]
		[FieldOffset(Offset = "0x0")]
		private static readonly HashSet<char> sTashkeelSet;

		// Token: 0x04003779 RID: 14201
		[Token(Token = "0x4003779")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<char, char> sGeneralArabicLetters2IsolatedArabicLettersMapping;

		// Token: 0x0400377A RID: 14202
		[Token(Token = "0x400377A")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Dictionary<char, char> sForceBreakSymbols;

		// Token: 0x02000CDA RID: 3290
		[Token(Token = "0x2000CDA")]
		internal enum IsolatedArabicLetters
		{
			// Token: 0x0400377C RID: 14204
			[Token(Token = "0x400377C")]
			Hamza = 65152,
			// Token: 0x0400377D RID: 14205
			[Token(Token = "0x400377D")]
			Alef = 65165,
			// Token: 0x0400377E RID: 14206
			[Token(Token = "0x400377E")]
			AlefHamza = 65155,
			// Token: 0x0400377F RID: 14207
			[Token(Token = "0x400377F")]
			WawHamza = 65157,
			// Token: 0x04003780 RID: 14208
			[Token(Token = "0x4003780")]
			AlefMaksoor = 65159,
			// Token: 0x04003781 RID: 14209
			[Token(Token = "0x4003781")]
			AlefMaksora = 64508,
			// Token: 0x04003782 RID: 14210
			[Token(Token = "0x4003782")]
			HamzaNabera = 65161,
			// Token: 0x04003783 RID: 14211
			[Token(Token = "0x4003783")]
			Ba = 65167,
			// Token: 0x04003784 RID: 14212
			[Token(Token = "0x4003784")]
			Ta = 65173,
			// Token: 0x04003785 RID: 14213
			[Token(Token = "0x4003785")]
			Tha2 = 65177,
			// Token: 0x04003786 RID: 14214
			[Token(Token = "0x4003786")]
			Jeem = 65181,
			// Token: 0x04003787 RID: 14215
			[Token(Token = "0x4003787")]
			H7aa = 65185,
			// Token: 0x04003788 RID: 14216
			[Token(Token = "0x4003788")]
			Khaa2 = 65189,
			// Token: 0x04003789 RID: 14217
			[Token(Token = "0x4003789")]
			Dal = 65193,
			// Token: 0x0400378A RID: 14218
			[Token(Token = "0x400378A")]
			Thal = 65195,
			// Token: 0x0400378B RID: 14219
			[Token(Token = "0x400378B")]
			Ra2 = 65197,
			// Token: 0x0400378C RID: 14220
			[Token(Token = "0x400378C")]
			Zeen = 65199,
			// Token: 0x0400378D RID: 14221
			[Token(Token = "0x400378D")]
			Seen = 65201,
			// Token: 0x0400378E RID: 14222
			[Token(Token = "0x400378E")]
			Sheen = 65205,
			// Token: 0x0400378F RID: 14223
			[Token(Token = "0x400378F")]
			S9a = 65209,
			// Token: 0x04003790 RID: 14224
			[Token(Token = "0x4003790")]
			Dha = 65213,
			// Token: 0x04003791 RID: 14225
			[Token(Token = "0x4003791")]
			T6a = 65217,
			// Token: 0x04003792 RID: 14226
			[Token(Token = "0x4003792")]
			T6ha = 65221,
			// Token: 0x04003793 RID: 14227
			[Token(Token = "0x4003793")]
			Ain = 65225,
			// Token: 0x04003794 RID: 14228
			[Token(Token = "0x4003794")]
			Gain = 65229,
			// Token: 0x04003795 RID: 14229
			[Token(Token = "0x4003795")]
			Fa = 65233,
			// Token: 0x04003796 RID: 14230
			[Token(Token = "0x4003796")]
			Gaf = 65237,
			// Token: 0x04003797 RID: 14231
			[Token(Token = "0x4003797")]
			Kaf = 65241,
			// Token: 0x04003798 RID: 14232
			[Token(Token = "0x4003798")]
			Lam = 65245,
			// Token: 0x04003799 RID: 14233
			[Token(Token = "0x4003799")]
			Meem = 65249,
			// Token: 0x0400379A RID: 14234
			[Token(Token = "0x400379A")]
			Noon = 65253,
			// Token: 0x0400379B RID: 14235
			[Token(Token = "0x400379B")]
			Ha = 65257,
			// Token: 0x0400379C RID: 14236
			[Token(Token = "0x400379C")]
			Waw = 65261,
			// Token: 0x0400379D RID: 14237
			[Token(Token = "0x400379D")]
			Ya = 65265,
			// Token: 0x0400379E RID: 14238
			[Token(Token = "0x400379E")]
			AlefMad = 65153,
			// Token: 0x0400379F RID: 14239
			[Token(Token = "0x400379F")]
			TaMarboota = 65171,
			// Token: 0x040037A0 RID: 14240
			[Token(Token = "0x40037A0")]
			PersianPe = 64342,
			// Token: 0x040037A1 RID: 14241
			[Token(Token = "0x40037A1")]
			PersianChe = 64378,
			// Token: 0x040037A2 RID: 14242
			[Token(Token = "0x40037A2")]
			PersianZe = 64394,
			// Token: 0x040037A3 RID: 14243
			[Token(Token = "0x40037A3")]
			PersianGaf = 64402,
			// Token: 0x040037A4 RID: 14244
			[Token(Token = "0x40037A4")]
			PersianGaf2 = 64398,
			// Token: 0x040037A5 RID: 14245
			[Token(Token = "0x40037A5")]
			PersianYeh = 64508
		}

		// Token: 0x02000CDB RID: 3291
		[Token(Token = "0x2000CDB")]
		internal enum GeneralArabicLetters
		{
			// Token: 0x040037A7 RID: 14247
			[Token(Token = "0x40037A7")]
			Hamza = 1569,
			// Token: 0x040037A8 RID: 14248
			[Token(Token = "0x40037A8")]
			Alef = 1575,
			// Token: 0x040037A9 RID: 14249
			[Token(Token = "0x40037A9")]
			AlefHamza = 1571,
			// Token: 0x040037AA RID: 14250
			[Token(Token = "0x40037AA")]
			WawHamza,
			// Token: 0x040037AB RID: 14251
			[Token(Token = "0x40037AB")]
			AlefMaksoor,
			// Token: 0x040037AC RID: 14252
			[Token(Token = "0x40037AC")]
			AlefMagsora = 1609,
			// Token: 0x040037AD RID: 14253
			[Token(Token = "0x40037AD")]
			HamzaNabera = 1574,
			// Token: 0x040037AE RID: 14254
			[Token(Token = "0x40037AE")]
			Ba = 1576,
			// Token: 0x040037AF RID: 14255
			[Token(Token = "0x40037AF")]
			Ta = 1578,
			// Token: 0x040037B0 RID: 14256
			[Token(Token = "0x40037B0")]
			Tha2,
			// Token: 0x040037B1 RID: 14257
			[Token(Token = "0x40037B1")]
			Jeem,
			// Token: 0x040037B2 RID: 14258
			[Token(Token = "0x40037B2")]
			H7aa,
			// Token: 0x040037B3 RID: 14259
			[Token(Token = "0x40037B3")]
			Khaa2,
			// Token: 0x040037B4 RID: 14260
			[Token(Token = "0x40037B4")]
			Dal,
			// Token: 0x040037B5 RID: 14261
			[Token(Token = "0x40037B5")]
			Thal,
			// Token: 0x040037B6 RID: 14262
			[Token(Token = "0x40037B6")]
			Ra2,
			// Token: 0x040037B7 RID: 14263
			[Token(Token = "0x40037B7")]
			Zeen,
			// Token: 0x040037B8 RID: 14264
			[Token(Token = "0x40037B8")]
			Seen,
			// Token: 0x040037B9 RID: 14265
			[Token(Token = "0x40037B9")]
			Sheen,
			// Token: 0x040037BA RID: 14266
			[Token(Token = "0x40037BA")]
			S9a,
			// Token: 0x040037BB RID: 14267
			[Token(Token = "0x40037BB")]
			Dha,
			// Token: 0x040037BC RID: 14268
			[Token(Token = "0x40037BC")]
			T6a,
			// Token: 0x040037BD RID: 14269
			[Token(Token = "0x40037BD")]
			T6ha,
			// Token: 0x040037BE RID: 14270
			[Token(Token = "0x40037BE")]
			Ain,
			// Token: 0x040037BF RID: 14271
			[Token(Token = "0x40037BF")]
			Gain,
			// Token: 0x040037C0 RID: 14272
			[Token(Token = "0x40037C0")]
			Fa = 1601,
			// Token: 0x040037C1 RID: 14273
			[Token(Token = "0x40037C1")]
			Gaf,
			// Token: 0x040037C2 RID: 14274
			[Token(Token = "0x40037C2")]
			Kaf,
			// Token: 0x040037C3 RID: 14275
			[Token(Token = "0x40037C3")]
			Lam,
			// Token: 0x040037C4 RID: 14276
			[Token(Token = "0x40037C4")]
			Meem,
			// Token: 0x040037C5 RID: 14277
			[Token(Token = "0x40037C5")]
			Noon,
			// Token: 0x040037C6 RID: 14278
			[Token(Token = "0x40037C6")]
			Ha,
			// Token: 0x040037C7 RID: 14279
			[Token(Token = "0x40037C7")]
			Waw,
			// Token: 0x040037C8 RID: 14280
			[Token(Token = "0x40037C8")]
			Ya = 1610,
			// Token: 0x040037C9 RID: 14281
			[Token(Token = "0x40037C9")]
			AlefMad = 1570,
			// Token: 0x040037CA RID: 14282
			[Token(Token = "0x40037CA")]
			TaMarboota = 1577,
			// Token: 0x040037CB RID: 14283
			[Token(Token = "0x40037CB")]
			PersianPe = 1662,
			// Token: 0x040037CC RID: 14284
			[Token(Token = "0x40037CC")]
			PersianChe = 1670,
			// Token: 0x040037CD RID: 14285
			[Token(Token = "0x40037CD")]
			PersianZe = 1688,
			// Token: 0x040037CE RID: 14286
			[Token(Token = "0x40037CE")]
			PersianGaf = 1711,
			// Token: 0x040037CF RID: 14287
			[Token(Token = "0x40037CF")]
			PersianGaf2 = 1705,
			// Token: 0x040037D0 RID: 14288
			[Token(Token = "0x40037D0")]
			PersianYeh = 1740
		}
	}
}
