using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Il2CppDummyDll;

namespace ArabicSupport
{
	// Token: 0x02000CDD RID: 3293
	[Token(Token = "0x2000CDD")]
	public class ArabicFixer
	{
		// Token: 0x06007BD6 RID: 31702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BD6")]
		[Address(RVA = "0x3195630", Offset = "0x3195630", VA = "0x3195630")]
		private static string FixInternal(string str)
		{
			return null;
		}

		// Token: 0x06007BD7 RID: 31703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BD7")]
		[Address(RVA = "0x3195918", Offset = "0x3195918", VA = "0x3195918")]
		public static string ReverseTag(string input)
		{
			return null;
		}

		// Token: 0x06007BD8 RID: 31704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BD8")]
		[Address(RVA = "0x3196290", Offset = "0x3196290", VA = "0x3196290")]
		public static string Fix(string str)
		{
			return null;
		}

		// Token: 0x06007BD9 RID: 31705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BD9")]
		[Address(RVA = "0x31963A8", Offset = "0x31963A8", VA = "0x31963A8")]
		public ArabicFixer()
		{
		}

		// Token: 0x040037DB RID: 14299
		[Token(Token = "0x40037DB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Regex, Regex> mTagDic;

		// Token: 0x040037DC RID: 14300
		[Token(Token = "0x40037DC")]
		[FieldOffset(Offset = "0x8")]
		private static readonly ArabicLineFixer sLineFixer;
	}
}
