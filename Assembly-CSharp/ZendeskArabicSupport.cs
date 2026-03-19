using System;
using Il2CppDummyDll;
using RTLTMPro;
using TMPro;
using UnityEngine;

// Token: 0x02000330 RID: 816
[Token(Token = "0x2000330")]
public static class ZendeskArabicSupport
{
	// Token: 0x06001565 RID: 5477 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001565")]
	[Address(RVA = "0x1ED1438", Offset = "0x1ED1438", VA = "0x1ED1438")]
	[RuntimeInitializeOnLoadMethod(0)]
	public static void Initialize()
	{
	}

	// Token: 0x06001566 RID: 5478 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001566")]
	[Address(RVA = "0x1ED1530", Offset = "0x1ED1530", VA = "0x1ED1530")]
	private static void SetTextWithArabicSupport(TMP_Text textComponent, string text)
	{
	}

	// Token: 0x06001567 RID: 5479 RVA: 0x00008550 File Offset: 0x00006750
	[Token(Token = "0x6001567")]
	[Address(RVA = "0x1ED16E4", Offset = "0x1ED16E4", VA = "0x1ED16E4")]
	private static bool HasArabicCharacter(string str)
	{
		return default(bool);
	}

	// Token: 0x06001568 RID: 5480 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001568")]
	[Address(RVA = "0x1ED1798", Offset = "0x1ED1798", VA = "0x1ED1798")]
	private static string GetFixedRTLText(string input, bool richText)
	{
		return null;
	}

	// Token: 0x0400185E RID: 6238
	[Token(Token = "0x400185E")]
	[FieldOffset(Offset = "0x0")]
	private static FastStringBuilder RTLFixedText;

	// Token: 0x0400185F RID: 6239
	[Token(Token = "0x400185F")]
	[FieldOffset(Offset = "0x8")]
	private static bool _initialized;
}
