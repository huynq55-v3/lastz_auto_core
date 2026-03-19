using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace RTLTMPro
{
	// Token: 0x02000CC9 RID: 3273
	[Token(Token = "0x2000CC9")]
	public static class LigatureFixer
	{
		// Token: 0x06007BA1 RID: 31649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BA1")]
		[Address(RVA = "0x322B7F8", Offset = "0x322B7F8", VA = "0x322B7F8")]
		private static void FlushBufferToOutput(List<int> buffer, FastStringBuilder output)
		{
		}

		// Token: 0x06007BA2 RID: 31650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BA2")]
		[Address(RVA = "0x322B8B8", Offset = "0x322B8B8", VA = "0x322B8B8")]
		public static void Fix(FastStringBuilder input, FastStringBuilder output, bool farsi, bool fixTextTags, bool preserveNumbers)
		{
		}

		// Token: 0x040036BC RID: 14012
		[Token(Token = "0x40036BC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<char, char> MirroredCharsMap;

		// Token: 0x040036BD RID: 14013
		[Token(Token = "0x40036BD")]
		[FieldOffset(Offset = "0x8")]
		private static readonly HashSet<char> MirroredCharsSet;
	}
}
