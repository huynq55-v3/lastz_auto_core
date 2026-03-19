using System;
using Il2CppDummyDll;

namespace RTLTMPro
{
	// Token: 0x02000CCA RID: 3274
	[Token(Token = "0x2000CCA")]
	public static class RichTextFixer
	{
		// Token: 0x06007BA4 RID: 31652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BA4")]
		[Address(RVA = "0x319168C", Offset = "0x319168C", VA = "0x319168C")]
		public static void Fix(FastStringBuilder text)
		{
		}

		// Token: 0x06007BA5 RID: 31653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BA5")]
		[Address(RVA = "0x3191704", Offset = "0x3191704", VA = "0x3191704")]
		public static void FindTag(FastStringBuilder str, int start, out RichTextFixer.Tag tag)
		{
		}

		// Token: 0x02000CCB RID: 3275
		[Token(Token = "0x2000CCB")]
		public enum TagType
		{
			// Token: 0x040036BF RID: 14015
			[Token(Token = "0x40036BF")]
			None,
			// Token: 0x040036C0 RID: 14016
			[Token(Token = "0x40036C0")]
			Opening,
			// Token: 0x040036C1 RID: 14017
			[Token(Token = "0x40036C1")]
			Closing,
			// Token: 0x040036C2 RID: 14018
			[Token(Token = "0x40036C2")]
			SelfContained
		}

		// Token: 0x02000CCC RID: 3276
		[Token(Token = "0x2000CCC")]
		public struct Tag
		{
			// Token: 0x06007BA6 RID: 31654 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BA6")]
			[Address(RVA = "0x31918F0", Offset = "0x31918F0", VA = "0x31918F0")]
			public Tag(int start, int end, RichTextFixer.TagType type, int hashCode)
			{
			}

			// Token: 0x040036C3 RID: 14019
			[Token(Token = "0x40036C3")]
			[FieldOffset(Offset = "0x0")]
			public int Start;

			// Token: 0x040036C4 RID: 14020
			[Token(Token = "0x40036C4")]
			[FieldOffset(Offset = "0x4")]
			public int End;

			// Token: 0x040036C5 RID: 14021
			[Token(Token = "0x40036C5")]
			[FieldOffset(Offset = "0x8")]
			public int HashCode;

			// Token: 0x040036C6 RID: 14022
			[Token(Token = "0x40036C6")]
			[FieldOffset(Offset = "0xC")]
			public RichTextFixer.TagType Type;
		}
	}
}
