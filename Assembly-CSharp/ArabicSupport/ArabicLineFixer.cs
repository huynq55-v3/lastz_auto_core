using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Il2CppDummyDll;

namespace ArabicSupport
{
	// Token: 0x02000CDC RID: 3292
	[Token(Token = "0x2000CDC")]
	public class ArabicLineFixer
	{
		// Token: 0x06007BCD RID: 31693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BCD")]
		[Address(RVA = "0x3194708", Offset = "0x3194708", VA = "0x3194708")]
		private void Reset()
		{
		}

		// Token: 0x06007BCE RID: 31694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BCE")]
		[Address(RVA = "0x31947C8", Offset = "0x31947C8", VA = "0x31947C8")]
		private void PreFix(string line)
		{
		}

		// Token: 0x06007BCF RID: 31695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BCF")]
		[Address(RVA = "0x3194AA8", Offset = "0x3194AA8", VA = "0x3194AA8")]
		private string ReverseString(string str)
		{
			return null;
		}

		// Token: 0x06007BD0 RID: 31696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BD0")]
		[Address(RVA = "0x3194B34", Offset = "0x3194B34", VA = "0x3194B34")]
		private void ParseRichTokens()
		{
		}

		// Token: 0x06007BD1 RID: 31697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BD1")]
		[Address(RVA = "0x3194CA0", Offset = "0x3194CA0", VA = "0x3194CA0")]
		private void ProcessTempNumber()
		{
		}

		// Token: 0x06007BD2 RID: 31698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BD2")]
		[Address(RVA = "0x3194E3C", Offset = "0x3194E3C", VA = "0x3194E3C")]
		private string Fix()
		{
			return null;
		}

		// Token: 0x06007BD3 RID: 31699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BD3")]
		[Address(RVA = "0x31953AC", Offset = "0x31953AC", VA = "0x31953AC")]
		public string FixLine(string line)
		{
			return null;
		}

		// Token: 0x06007BD4 RID: 31700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BD4")]
		[Address(RVA = "0x31953E4", Offset = "0x31953E4", VA = "0x31953E4")]
		public static void Test()
		{
		}

		// Token: 0x06007BD5 RID: 31701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BD5")]
		[Address(RVA = "0x31953E8", Offset = "0x31953E8", VA = "0x31953E8")]
		public ArabicLineFixer()
		{
		}

		// Token: 0x040037D1 RID: 14289
		[Token(Token = "0x40037D1")]
		[FieldOffset(Offset = "0x10")]
		private readonly StringBuilder mOriginalContent;

		// Token: 0x040037D2 RID: 14290
		[Token(Token = "0x40037D2")]
		[FieldOffset(Offset = "0x18")]
		private readonly StringBuilder mPreFixedContent;

		// Token: 0x040037D3 RID: 14291
		[Token(Token = "0x40037D3")]
		[FieldOffset(Offset = "0x20")]
		private readonly StringBuilder mFixedContent;

		// Token: 0x040037D4 RID: 14292
		[Token(Token = "0x40037D4")]
		[FieldOffset(Offset = "0x28")]
		private readonly StringBuilder mTempNumberContent;

		// Token: 0x040037D5 RID: 14293
		[Token(Token = "0x40037D5")]
		[FieldOffset(Offset = "0x30")]
		private readonly StringBuilder mStringReverseBuilder;

		// Token: 0x040037D6 RID: 14294
		[Token(Token = "0x40037D6")]
		[FieldOffset(Offset = "0x38")]
		private readonly List<string> mRichTokens;

		// Token: 0x040037D7 RID: 14295
		[Token(Token = "0x40037D7")]
		[FieldOffset(Offset = "0x40")]
		private readonly Dictionary<string, string> mEndRichToken2StarRichTokenMapping;

		// Token: 0x040037D8 RID: 14296
		[Token(Token = "0x40037D8")]
		[FieldOffset(Offset = "0x48")]
		private readonly Regex mRichTokenMatcher;

		// Token: 0x040037D9 RID: 14297
		[Token(Token = "0x40037D9")]
		[FieldOffset(Offset = "0x50")]
		private readonly Regex mReverseRichTokenMatcher;

		// Token: 0x040037DA RID: 14298
		[Token(Token = "0x40037DA")]
		[FieldOffset(Offset = "0x58")]
		private int mReverseRichTokenCounter;
	}
}
