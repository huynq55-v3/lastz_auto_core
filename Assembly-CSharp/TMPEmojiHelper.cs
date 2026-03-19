using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Il2CppDummyDll;

// Token: 0x0200017F RID: 383
[Token(Token = "0x200017F")]
public static class TMPEmojiHelper
{
	// Token: 0x06000AF5 RID: 2805 RVA: 0x000055F8 File Offset: 0x000037F8
	[Token(Token = "0x6000AF5")]
	[Address(RVA = "0x372243C", Offset = "0x372243C", VA = "0x372243C")]
	public static uint GetMultipleEmojiCode(string name)
	{
		return 0U;
	}

	// Token: 0x06000AF6 RID: 2806 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AF6")]
	[Address(RVA = "0x37225E8", Offset = "0x37225E8", VA = "0x37225E8")]
	public static string ProcessEmojiText(string text)
	{
		return null;
	}

	// Token: 0x06000AF7 RID: 2807 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AF7")]
	[Address(RVA = "0x3722B00", Offset = "0x3722B00", VA = "0x3722B00")]
	private static void AddToCache(string source, string target)
	{
	}

	// Token: 0x040007CB RID: 1995
	[Token(Token = "0x40007CB")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, string> mutiple_emoji_dict;

	// Token: 0x040007CC RID: 1996
	[Token(Token = "0x40007CC")]
	[FieldOffset(Offset = "0x8")]
	private static uint MULTIPLE_EMOJI_FLAG;

	// Token: 0x040007CD RID: 1997
	[Token(Token = "0x40007CD")]
	[FieldOffset(Offset = "0x10")]
	private static Regex emoji_reg;

	// Token: 0x040007CE RID: 1998
	[Token(Token = "0x40007CE")]
	[FieldOffset(Offset = "0x18")]
	private static bool hasChanged;

	// Token: 0x040007CF RID: 1999
	[Token(Token = "0x40007CF")]
	[FieldOffset(Offset = "0x20")]
	private static StringBuilder sb;

	// Token: 0x040007D0 RID: 2000
	[Token(Token = "0x40007D0")]
	[FieldOffset(Offset = "0x28")]
	private static LinkedList<string> MatchOrderList;

	// Token: 0x040007D1 RID: 2001
	[Token(Token = "0x40007D1")]
	[FieldOffset(Offset = "0x30")]
	private static Dictionary<string, string> MatchResultDict;

	// Token: 0x040007D2 RID: 2002
	[Token(Token = "0x40007D2")]
	private const int MAX_CACHE_SIZE = 100;
}
