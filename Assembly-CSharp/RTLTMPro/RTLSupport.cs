using System;
using Il2CppDummyDll;

namespace RTLTMPro
{
	// Token: 0x02000CCE RID: 3278
	[Token(Token = "0x2000CCE")]
	public static class RTLSupport
	{
		// Token: 0x06007BAD RID: 31661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BAD")]
		[Address(RVA = "0x31919DC", Offset = "0x31919DC", VA = "0x31919DC")]
		public static void FixRTL(string input, FastStringBuilder output, bool farsi = true, bool fixTextTags = true, bool preserveNumbers = false)
		{
		}

		// Token: 0x06007BAE RID: 31662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BAE")]
		[Address(RVA = "0x31920E4", Offset = "0x31920E4", VA = "0x31920E4")]
		public static string InsertEoLToUguiText(string input, UGUITextLines[] linesInfo)
		{
			return null;
		}

		// Token: 0x040036C9 RID: 14025
		[Token(Token = "0x40036C9")]
		public const int DefaultBufferSize = 4096;

		// Token: 0x040036CA RID: 14026
		[Token(Token = "0x40036CA")]
		[FieldOffset(Offset = "0x0")]
		private static FastStringBuilder inputBuilder;

		// Token: 0x040036CB RID: 14027
		[Token(Token = "0x40036CB")]
		[FieldOffset(Offset = "0x8")]
		private static FastStringBuilder glyphFixerOutput;
	}
}
