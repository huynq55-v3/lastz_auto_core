using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000F2 RID: 242
[Token(Token = "0x20000F2")]
public class EmojiText : Text
{
	// Token: 0x170000EB RID: 235
	// (get) Token: 0x060006E4 RID: 1764 RVA: 0x00004458 File Offset: 0x00002658
	[Token(Token = "0x170000EB")]
	public override float preferredWidth
	{
		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x2E84B64", Offset = "0x2E84B64", VA = "0x2E84B64", Slot = "79")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000EC RID: 236
	// (get) Token: 0x060006E5 RID: 1765 RVA: 0x00004470 File Offset: 0x00002670
	[Token(Token = "0x170000EC")]
	public override float preferredHeight
	{
		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x2E84D1C", Offset = "0x2E84D1C", VA = "0x2E84D1C", Slot = "82")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000ED RID: 237
	// (get) Token: 0x060006E6 RID: 1766 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000ED")]
	public string emojiText
	{
		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x2E84C44", Offset = "0x2E84C44", VA = "0x2E84C44")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000EE RID: 238
	// (get) Token: 0x060006E7 RID: 1767 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060006E8 RID: 1768 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000EE")]
	public override string text
	{
		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x2E84DFC", Offset = "0x2E84DFC", VA = "0x2E84DFC", Slot = "74")]
		get
		{
			return null;
		}
		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x2E84E04", Offset = "0x2E84E04", VA = "0x2E84E04", Slot = "75")]
		set
		{
		}
	}

	// Token: 0x060006E9 RID: 1769 RVA: 0x00004488 File Offset: 0x00002688
	[Token(Token = "0x60006E9")]
	[Address(RVA = "0x2E85470", Offset = "0x2E85470", VA = "0x2E85470")]
	private int AppendString(int lastIndex, string value, int startIndex, string appendStr)
	{
		return 0;
	}

	// Token: 0x060006EA RID: 1770 RVA: 0x000044A0 File Offset: 0x000026A0
	[Token(Token = "0x60006EA")]
	[Address(RVA = "0x2E853F0", Offset = "0x2E853F0", VA = "0x2E853F0")]
	private bool IsRtl(string str)
	{
		return default(bool);
	}

	// Token: 0x060006EB RID: 1771 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006EB")]
	[Address(RVA = "0x2E84F40", Offset = "0x2E84F40", VA = "0x2E84F40")]
	private string GetRealValue(string value)
	{
		return null;
	}

	// Token: 0x060006EC RID: 1772 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006EC")]
	[Address(RVA = "0x2E85844", Offset = "0x2E85844", VA = "0x2E85844")]
	private string GetEmojiByIndex(int index)
	{
		return null;
	}

	// Token: 0x060006ED RID: 1773 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006ED")]
	[Address(RVA = "0x2E855A8", Offset = "0x2E855A8", VA = "0x2E855A8")]
	private string GetTextWithEllipsis(string value)
	{
		return null;
	}

	// Token: 0x060006EE RID: 1774 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006EE")]
	[Address(RVA = "0x2E858D8", Offset = "0x2E858D8", VA = "0x2E858D8", Slot = "28")]
	public override void SetVerticesDirty()
	{
	}

	// Token: 0x060006EF RID: 1775 RVA: 0x000044B8 File Offset: 0x000026B8
	[Token(Token = "0x60006EF")]
	[Address(RVA = "0x2E858E8", Offset = "0x2E858E8", VA = "0x2E858E8")]
	public bool IsContainsEmoji()
	{
		return default(bool);
	}

	// Token: 0x060006F0 RID: 1776 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006F0")]
	[Address(RVA = "0x2E85D08", Offset = "0x2E85D08", VA = "0x2E85D08")]
	public static void initEmoji()
	{
	}

	// Token: 0x060006F1 RID: 1777 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006F1")]
	[Address(RVA = "0x2E85F40", Offset = "0x2E85F40", VA = "0x2E85F40", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}

	// Token: 0x060006F2 RID: 1778 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006F2")]
	[Address(RVA = "0x2E87058", Offset = "0x2E87058", VA = "0x2E87058")]
	private string ByteToBinStr(byte b)
	{
		return null;
	}

	// Token: 0x060006F3 RID: 1779 RVA: 0x000044D0 File Offset: 0x000026D0
	[Token(Token = "0x60006F3")]
	[Address(RVA = "0x2E8710C", Offset = "0x2E8710C", VA = "0x2E8710C")]
	private bool DoFirstParse_UTF32(string match_string, out string key)
	{
		return default(bool);
	}

	// Token: 0x060006F4 RID: 1780 RVA: 0x000044E8 File Offset: 0x000026E8
	[Token(Token = "0x60006F4")]
	[Address(RVA = "0x2E858EC", Offset = "0x2E858EC", VA = "0x2E858EC")]
	private bool ParseText()
	{
		return default(bool);
	}

	// Token: 0x060006F5 RID: 1781 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006F5")]
	[Address(RVA = "0x2E876C4", Offset = "0x2E876C4", VA = "0x2E876C4")]
	public EmojiText()
	{
	}

	// Token: 0x0400050D RID: 1293
	[Token(Token = "0x400050D")]
	private const string regex1 = "[#*0-9]\\uFE0F?\\u20E3|©\\uFE0F?|[®\\u203C\\u2049\\u2122\\u2139\\u2194-\\u2199\\u21A9\\u21AA]\\uFE0F?|[\\u231A\\u231B]|[\\u2328\\u23CF]\\uFE0F?|[\\u23E9-\\u23EC]|[\\u23ED-\\u23EF]\\uFE0F?|\\u23F0|[\\u23F1\\u23F2]\\uFE0F?|\\u23F3|[\\u23F8-\\u23FA\\u24C2\\u25AA\\u25AB\\u25B6\\u25C0\\u25FB\\u25FC]\\uFE0F?|[\\u25FD\\u25FE]|[\\u2600-\\u2604\\u260E\\u2611]\\uFE0F?|[\\u2614\\u2615]|\\u2618\\uFE0F?|\\u261D(?:\\uD83C[\\uDFFB-\\uDFFF]|\\uFE0F)?|[\\u2620\\u2622\\u2623\\u2626\\u262A\\u262E\\u262F\\u2638-\\u263A\\u2640\\u2642]\\uFE0F?|[\\u2648-\\u2653]|[\\u265F\\u2660\\u2663\\u2665\\u2666\\u2668\\u267B\\u267E]\\uFE0F?|\\u267F|\\u2692\\uFE0F?|\\u2693|[\\u2694-\\u2697\\u2699\\u269B\\u269C\\u26A0]\\uFE0F?|\\u26A1|\\u26A7\\uFE0F?|[\\u26AA\\u26AB]|[\\u26B0\\u26B1]\\uFE0F?|[\\u26BD\\u26BE\\u26C4\\u26C5]|\\u26C8\\uFE0F?|\\u26CE|[\\u26CF\\u26D1\\u26D3]\\uFE0F?|\\u26D4|\\u26E9\\uFE0F?|\\u26EA|[\\u26F0\\u26F1]\\uFE0F?|[\\u26F2\\u26F3]|\\u26F4\\uFE0F?|\\u26F5|[\\u26F7\\u26F8]\\uFE0F?|\\u26F9(?:\\u200D[\\u2640\\u2642]\\uFE0F?|\\uD83C[\\uDFFB-\\uDFFF](?:\\u200D[\\u2640\\u2642]\\uFE0F?)?|\\uFE0F(?:\\u200D[\\u2640\\u2642]\\uFE0F?)?)?|[\\u26FA\\u26FD]|\\u2702\\uFE0F?|\\u2705|[\\u2708\\u2709]\\uFE0F?|[\\u270A\\u270B](?:\\uD83C[\\uDFFB-\\uDFFF])?|[\\u270C\\u270D](?:\\uD83C[\\uDFFB-\\uDFFF]|\\uFE0F)?|\\u270F\\uFE0F?|[\\u2712\\u2714\\u2716\\u271D\\u2721]\\uFE0F?|\\u2728|[\\u2733\\u2734\\u2744\\u2747]\\uFE0F?|[\\u274C\\u274E\\u2753-\\u2755\\u2757]|\\u2763\\uFE0F?|\\u2764(?:\\u200D(?:\\uD83D\\uDD25|\\uD83E\\uDE79)|\\uFE0F(?:\\u200D(?:\\uD83D\\uDD25|\\uD83E\\uDE79))?)?|[\\u2795-\\u2797]|\\u27A1\\uFE0F?|[\\u27B0\\u27BF]|[\\u2934\\u2935\\u2B05-\\u2B07]\\uFE0F?|[\\u2B1B\\u2B1C\\u2B50\\u2B55]|[\\u3030\\u303D\\u3297\\u3299]\\uFE0F?|\\uD83C(?:[\\uDC04\\uDCCF]|[\\uDD70\\uDD71\\uDD7E\\uDD7F]\\uFE0F?|[\\uDD8E\\uDD91-\\uDD9A]|\\uDDE6\\uD83C[\\uDDE8-\\uDDEC\\uDDEE\\uDDF1\\uDDF2\\uDDF4\\uDDF6-\\uDDFA\\uDDFC\\uDDFD\\uDDFF]|\\uDDE7\\uD83C[\\uDDE6\\uDDE7\\uDDE9-\\uDDEF\\uDDF1-\\uDDF4\\uDDF6-\\uDDF9\\uDDFB\\uDDFC\\uDDFE\\uDDFF]|\\uDDE8\\uD83C[\\uDDE6\\uDDE8\\uDDE9\\uDDEB-\\uDDEE\\uDDF0-\\uDDF5\\uDDF7\\uDDFA-\\uDDFF]|\\uDDE9\\uD83C[\\uDDEA\\uDDEC\\uDDEF\\uDDF0\\uDDF2\\uDDF4\\uDDFF]|\\uDDEA\\uD83C[\\uDDE6\\uDDE8\\uDDEA\\uDDEC\\uDDED\\uDDF7-\\uDDFA]|\\uDDEB\\uD83C[\\uDDEE-\\uDDF0\\uDDF2\\uDDF4\\uDDF7]|\\uDDEC\\uD83C[\\uDDE6\\uDDE7\\uDDE9-\\uDDEE\\uDDF1-\\uDDF3\\uDDF5-\\uDDFA\\uDDFC\\uDDFE]|\\uDDED\\uD83C[\\uDDF0\\uDDF2\\uDDF3\\uDDF7\\uDDF9\\uDDFA]|\\uDDEE\\uD83C[\\uDDE8-\\uDDEA\\uDDF1-\\uDDF4\\uDDF6-\\uDDF9]|\\uDDEF\\uD83C[\\uDDEA\\uDDF2\\uDDF4\\uDDF5]|\\uDDF0\\uD83C[\\uDDEA\\uDDEC-\\uDDEE\\uDDF2\\uDDF3\\uDDF5\\uDDF7\\uDDFC\\uDDFE\\uDDFF]|\\uDDF1\\uD83C[\\uDDE6-\\uDDE8\\uDDEE\\uDDF0\\uDDF7-\\uDDFB\\uDDFE]|\\uDDF2\\uD83C[\\uDDE6\\uDDE8-\\uDDED\\uDDF0-\\uDDFF]|\\uDDF3\\uD83C[\\uDDE6\\uDDE8\\uDDEA-\\uDDEC\\uDDEE\\uDDF1\\uDDF4\\uDDF5\\uDDF7\\uDDFA\\uDDFF]|\\uDDF4\\uD83C\\uDDF2|\\uDDF5\\uD83C[\\uDDE6\\uDDEA-\\uDDED\\uDDF0-\\uDDF3\\uDDF7-\\uDDF9\\uDDFC\\uDDFE]|\\uDDF6\\uD83C\\uDDE6|\\uDDF7\\uD83C[\\uDDEA\\uDDF4\\uDDF8\\uDDFA\\uDDFC]|\\uDDF8\\uD83C[\\uDDE6-\\uDDEA\\uDDEC-\\uDDF4\\uDDF7-\\uDDF9\\uDDFB\\uDDFD-\\uDDFF]|\\uDDF9\\uD83C[\\uDDE6\\uDDE8\\uDDE9\\uDDEB-\\uDDED\\uDDEF-\\uDDF4\\uDDF7\\uDDF9\\uDDFB\\uDDFC\\uDDFF]|\\uDDFA\\uD83C[\\uDDE6\\uDDEC\\uDDF2\\uDDF3\\uDDF8\\uDDFE\\uDDFF]|\\uDDFB\\uD83C[\\uDDE6\\uDDE8\\uDDEA\\uDDEC\\uDDEE\\uDDF3\\uDDFA]|\\uDDFC\\uD83C[\\uDDEB\\uDDF8]|\\uDDFD\\uD83C\\uDDF0|\\uDDFE\\uD83C[\\uDDEA\\uDDF9]|\\uDDFF\\uD83C[\\uDDE6\\uDDF2\\uDDFC]|\\uDE01|\\uDE02\\uFE0F?|[\\uDE1A\\uDE2F\\uDE32-\\uDE36]|\\uDE37\\uFE0F?|[\\uDE38-\\uDE3A\\uDE50\\uDE51\\uDF00-\\uDF20]|[\\uDF21\\uDF24-\\uDF2C]\\uFE0F?|[\\uDF2D-\\uDF35]|\\uDF36\\uFE0F?|[\\uDF37-\\uDF7C]|\\uDF7D\\uFE0F?|[\\uDF7E-\\uDF84]|\\uDF85(?:\\uD83C[\\uDFFB-\\uDFFF])?|[\\uDF86-\\uDF93]|[\\uDF96\\uDF97\\uDF99-\\uDF9B\\uDF9E\\uDF9F]\\uFE0F?|[\\uDFA0-\\uDFC1]|\\uDFC2(?:\\uD83C[\\uDFFB-\\uDFFF])?|[\\uDFC3\\uDFC4](?:\\u200D[\\u2640\\u2642]\\uFE0F?|\\uD83C[\\uDFFB-\\uDFFF](?:\\u200D[\\u2640\\u2642]\\uFE0F?)?)?|[\\uDFC5\\uDFC6]|\\uDFC7(?:\\uD83C[\\uDFFB-\\uDFFF])?|[\\uDFC8\\uDFC9]|\\uDFCA(?:\\u200D[\\u2640\\u2642]\\uFE0F?|\\uD83C[\\uDFFB-\\uDFFF](?:\\u200D[\\u2640\\u2642]\\uFE0F?)?)?|[\\uDFCB\\uDFCC](?:\\u200D[\\u2640\\u2642]\\uFE0F?|\\uD83C[\\uDFFB-\\uDFFF](?:\\u200D[\\u2640\\u2642]\\uFE0F?)?|\\uFE0F(?:\\u200D[\\u2640\\u2642]\\uFE0F?)?)?|[\\uDFCD\\uDFCE]\\uFE0F?|[\\uDFCF-\\uDFD3]|[\\uDFD4-\\uDFDF]\\uFE0F?|[\\uDFE0-\\uDFF0]|\\uDFF3(?:\\u200D(?:\\u26A7\\uFE0F?|\\uD83C\\uDF08)|\\uFE0F(?:\\u200D(?:\\u26A7\\uFE0F?|\\uD83C\\uDF08))?)?|\\uDFF4(?:\\u200D\\u2620\\uFE0F?|\\uDB40\\uDC67\\uDB40\\uDC62\\uDB40(?:\\uDC65\\uDB40\\uDC6E\\uDB40\\uDC67|\\uDC73\\uDB40\\uDC63\\uDB40\\uDC74|\\uDC77\\uDB40\\uDC6C\\uDB40\\uDC73)\\uDB40\\uDC7F)?|[\\uDFF5\\uDFF7]\\uFE0F?|[\\uDFF8-\\uDFFF])|\\uD83D(?:[\\uDC00-\\uDC07]|\\uDC08(?:\\u200D\\u2B1B)?|[\\uDC09-\\uDC14]|\\uDC15(?:\\u200D\\uD83E\\uDDBA)?|[\\uDC16-\\uDC3A]|\\uDC3B(?:\\u200D\\u2744\\uFE0F?)?|[\\uDC3C-\\uDC3E]|\\uDC3F\\uFE0F?|\\uDC40|\\uDC41(?:\\u200D\\uD83D\\uDDE8\\uFE0F?|\\uFE0F(?:\\u200D\\uD83D\\uDDE8\\uFE0F?)?)?|[\\uDC42\\uDC43](?:\\uD83C[\\uDFFB-\\uDFFF])?|[\\uDC44\\uDC45]|[\\uDC46-\\uDC50](?:\\uD83C[\\uDFFB-\\uDFFF])?|[\\uDC51-\\uDC65]|[\\uDC66\\uDC67](?:\\uD83C[\\uDFFB-\\uDFFF])?|\\uDC68(?:\\u200D(?:[\\u2695\\u2696\\u2708]\\uFE0F?|\\u2764\\uFE0F?\\u200D\\uD83D(?:\\uDC8B\\u200D\\uD83D)?\\uDC68|\\uD83C[\\uDF3E\\uDF73\\uDF7C\\uDF93\\uDFA4\\uDFA8\\uDFEB\\uDFED]|\\uD83D(?:\\uDC66(?:\\u200D\\uD83D\\uDC66)?|\\uDC67(?:\\u200D\\uD83D[\\uDC66\\uDC67])?|[\\uDC68\\uDC69]\\u200D\\uD83D(?:\\uDC66(?:\\u200D\\uD83D\\uDC66)?|\\uDC67(?:\\u200D\\uD83D[\\uDC66\\uDC67])?)|[\\uDCBB\\uDCBC\\uDD27\\uDD2C\\uDE80\\uDE92])|\\uD83E[\\uDDAF-\\uDDB3\\uDDBC\\uDDBD])|\\uD83C(?:\\uDFFB(?:\\u200D(?:[\\u2695\\u2696\\u2708]\\uFE0F?|\\u2764\\uFE0F?\\u200D\\uD83D(?:\\uDC8B\\u200D\\uD83D)?\\uDC68\\uD83C[\\uDFFB-\\uDFFF]|\\uD83C[\\uDF3E\\uDF73\\uDF7C\\uDF93\\uDFA4\\uDFA8\\uDFEB\\uDFED]|\\uD83D[\\uDCBB\\uDCBC\\uDD27\\uDD2C\\uDE80\\uDE92]|\\uD83E(?:\\uDD1D\\u200D\\uD83D\\uDC68\\uD83C[\\uDFFC-\\uDFFF]|[\\uDDAF-\\uDDB3\\uDDBC\\uDDBD])))?|\\uDFFC(?:\\u200D(?:[\\u2695\\u2696\\u2708]\\uFE0F?|\\u2764\\uFE0F?\\u200D\\uD83D(?:\\uDC8B\\u200D\\uD83D)?\\uDC68\\uD83C[\\uDFFB-\\uDFFF]|\\uD83C[\\uDF3E\\uDF73\\uDF7C\\uDF93\\uDFA4\\uDFA8\\uDFEB\\uDFED]|\\uD83D[\\uDCBB\\uDCBC\\uDD27\\uDD2C\\uDE80\\uDE92]|\\uD83E(?:\\uDD1D\\u200D\\uD83D\\uDC68\\uD83C[\\uDFFB\\uDFFD-\\uDFFF]|[\\uDDAF-\\uDDB3\\uDDBC\\uDDBD])))?|\\uDFFD(?:\\u200D(?:[\\u2695\\u2696\\u2708]\\uFE0F?|\\u2764\\uFE0F?\\u200D\\uD83D(?:\\uDC8B\\u200D\\uD83D)?\\uDC68\\uD83C[\\uDFFB-\\uDFFF]|\\uD83C[\\uDF3E\\uDF73\\uDF7C\\uDF93\\uDFA4\\uDFA8\\uDFEB\\uDFED]|\\uD83D[\\uDCBB\\uDCBC\\uDD27\\uDD2C\\uDE80\\uDE92]|\\uD83E(?:\\uDD1D\\u200D\\uD83D\\uDC68\\uD83C[\\uDFFB\\uDFFC\\uDFFE\\uDFFF]|[\\uDDAF-\\uDDB3\\uDDBC\\uDDBD])))?|\\uDFFE(?:\\u200D(?:[\\u2695\\u2696\\u2708]\\uFE0F?|\\u2764\\uFE0F?\\u200D\\uD83D(?:\\uDC8B\\u200D\\uD83D)?\\uDC68\\uD83C[\\uDFFB-\\uDFFF]|\\uD83C[\\uDF3E\\uDF73\\uDF7C\\uDF93\\uDFA4\\uDFA8\\uDFEB\\uDFED]|\\uD83D[\\uDCBB\\uDCBC\\uDD27\\uDD2C\\uDE80\\uDE92]|\\uD83E(?:\\uDD1D\\u200D\\uD83D\\uDC68\\uD83C[\\uDFFB-\\uDFFD\\uDFFF]|[\\uDDAF-\\uDDB3\\uDDBC\\uDDBD])))?|\\uDFFF(?:\\u200D(?:[\\u2695\\u2696\\u2708]\\uFE0F?|\\u2764\\uFE0F?\\u200D\\uD83D(?:\\uDC8B\\u200D\\uD83D)?\\uDC68\\uD83C[\\uDFFB-\\uDFFF]|\\uD83C[\\uDF3E\\uDF73\\uDF7C\\uDF93\\uDFA4\\uDFA8\\uDFEB\\uDFED]|\\uD83D[\\uDCBB\\uDCBC\\uDD27\\uDD2C\\uDE80\\uDE92]|\\uD83E(?:\\uDD1D\\u200D\\uD83D\\uDC68\\uD83C[\\uDFFB-\\uDFFE]|[\\uDDAF-\\uDDB3\\uDDBC\\uDDBD])))?))?|\\uDC69(?:\\u200D(?:[\\u2695\\u2696\\u2708]\\uFE0F?|\\u2764\\uFE0F?\\u200D\\uD83D(?:\\uDC8B\\u200D\\uD83D)?[\\uDC68\\uDC69]|\\uD83C[\\uDF3E\\uDF73\\uDF7C\\uDF93\\uDFA4\\uDFA8\\uDFEB\\uDFED]|\\uD83D(?:\\uDC66(?:\\u200D\\uD83D\\uDC66)?|\\uDC67(?:\\u200D\\uD83D[\\uDC66\\uDC67])?|\\uDC69\\u200D\\uD83D(?:\\uDC66(?:\\u200D\\uD83D\\uDC66)?|\\uDC67(?:\\u200D\\uD83D[\\uDC66\\uDC67])?)|[\\uDCBB\\uDCBC\\uDD27\\uDD2C\\uDE80\\uDE92])|\\uD83E[\\uDDAF-\\uDDB3\\uDDBC\\uDDBD])|\\uD83C(?:\\uDFFB(?:\\u200D(?:[\\u2695\\u2696\\u2708]\\uFE0F?|\\u2764\\uFE0F?\\u200D\\uD83D(?:[\\uDC68\\uDC69]\\uD83C[\\uDFFB-\\uDFFF]|\\uDC8B\\u200D\\uD83D[\\uDC68\\uDC69]\\uD83C[\\uDFFB-\\uDFFF])|\\uD83C[\\uDF3E\\uDF73\\uDF7C\\uDF93\\uDFA4\\uDFA8\\uDFEB\\uDFED]|\\uD83D[\\uDCBB\\uDCBC\\uDD27\\uDD2C\\uDE80\\uDE92]|\\uD83E(?:\\uDD1D\\u200D\\uD83D[\\uDC68\\uDC69]\\uD83C[\\uDFFC-\\uDFFF]|[\\uDDAF-\\uDDB3\\uDDBC\\uDDBD])))?|\\uDFFC(?:\\u200D(?:[\\u2695\\u2696\\u2708]\\uFE0F?|\\u2764\\uFE0F?\\u200D\\uD83D(?:[\\uDC68\\uDC69]\\uD83C[\\uDFFB-\\uDFFF]|\\uDC8B\\u200D\\uD83D[\\uDC68\\uDC69]\\uD83C[\\uDFFB-\\uDFFF])|\\uD83C[\\uDF3E\\uDF73\\uDF7C\\uDF93\\uDFA4\\uDFA8\\uDFEB\\uDFED]|\\uD83D[\\uDCBB\\uDCBC\\uDD27\\uDD2C\\uDE80\\uDE92]|\\uD83E(?:\\uDD1D\\u200D\\uD83D[\\uDC68\\uDC69]\\uD83C[\\uDFFB\\uDFFD-\\uDFFF]|[\\uDDAF-\\uDDB3\\uDDBC\\uDDBD])))?|\\uDFFD(?:\\u200D(?:[\\u2695\\u2696\\u2708]\\uFE0F?|\\u2764\\uFE0F?\\u200D\\uD83D(?:[\\uDC68\\uDC69]\\uD83C[\\uDFFB-\\uDFFF]|\\uDC8B\\u200D\\uD83D[\\uDC68\\uDC69]\\uD83C[\\uDFFB-\\uDFFF])|\\uD83C[\\uDF3E\\uDF73\\uDF7C\\uDF93\\uDFA4\\uDFA8\\uDFEB\\uDFED]|\\uD83D[\\uDCBB\\uDCBC\\uDD27\\uDD2C\\uDE80\\uDE92]|\\uD83E(?:\\uDD1D\\u200D\\uD83D[\\uDC68\\uDC69]\\uD83C[\\uDFFB\\uDFFC\\uDFFE\\uDFFF]|[\\uDDAF-\\uDDB3\\uDDBC\\uDDBD])))?|\\uDFFE(?:\\u200D(?:[\\u2695\\u2696\\u2708]\\uFE0F?|\\u2764\\uFE0F?\\u200D\\uD83D(?:[\\uDC68\\uDC69]\\uD83C[\\uDFFB-\\uDFFF]|\\uDC8B\\u200D\\uD83D[\\uDC68\\uDC69]\\uD83C[\\uDFFB-\\uDFFF])|\\uD83C[\\uDF3E\\uDF73\\uDF7C\\uDF93\\uDFA4\\uDFA8\\uDFEB\\uDFED]|\\uD83D[\\uDCBB\\uDCBC\\uDD27\\uDD2C\\uDE80\\uDE92]|\\uD83E(?:\\uDD1D\\u200D\\uD83D[\\uDC68\\uDC69]\\uD83C[\\uDFFB-\\uDFFD\\uDFFF]|[\\uDDAF-\\uDDB3\\uDDBC\\uDDBD])))?|\\uDFFF(?:\\u200D(?:[\\u2695\\u2696\\u2708]\\uFE0F?|\\u2764\\uFE0F?\\u200D\\uD83D(?:[\\uDC68\\uDC69]\\uD83C[\\uDFFB-\\uDFFF]|\\uDC8B\\u200D\\uD83D[\\uDC68\\uDC69]\\uD83C[\\uDFFB-\\uDFFF])|\\uD83C[\\uDF3E\\uDF73\\uDF7C\\uDF93\\uDFA4\\uDFA8\\uDFEB\\uDFED]|\\uD83D[\\uDCBB\\uDCBC\\uDD27\\uDD2C\\uDE80\\uDE92]|\\uD83E(?:\\uDD1D\\u200D\\uD83D[\\uDC68\\uDC69]\\uD83C[\\uDFFB-\\uDFFE]|[\\uDDAF-\\uDDB3\\uDDBC\\uDDBD])))?))?|\\uDC6A|[\\uDC6B-\\uDC6D](?:\\uD83C[\\uDFFB-\\uDFFF])?|\\uDC6E(?:\\u200D[\\u2640\\u2642]\\uFE0F?|\\uD83C[\\uDFFB-\\uDFFF](?:\\u200D[\\u2640\\u2642]\\uFE0F?)?)?|\\uDC6F(?:\\u200D[\\u2640\\u2642]\\uFE0F?)?|[\\uDC70\\uDC71](?:\\u200D[\\u2640\\u2642]\\uFE0F?|\\uD83C[\\uDFFB-\\uDFFF](?:\\u200D[\\u2640\\u2642]\\uFE0F?)?)?|\\uDC72(?:\\uD83C[\\uDFFB-\\uDFFF])?|\\uDC73(?:\\u200D[\\u2640\\u2642]\\uFE0F?|\\uD83C[\\uDFFB-\\uDFFF](?:\\u200D[\\u2640\\u2642]\\uFE0F?)?)?|[\\uDC74-\\uDC76](?:\\uD83C[\\uDFFB-\\uDFFF])?|\\uDC77(?:\\u200D[\\u2640\\u2642]\\uFE0F?|\\uD83C[\\uDFFB-\\uDFFF](?:\\u200D[\\u2640\\u2642]\\uFE0F?)?)?|\\uDC78(?:\\uD83C[\\uDFFB-\\uDFFF])?|[\\uDC79-\\uDC7B]|\\uDC7C(?:\\uD83C[\\uDFFB-\\uDFFF])?|[\\uDC7D-\\uDC80]|[\\uDC81\\uDC82](?:\\u200D[\\u2640\\u2642]\\uFE0F?|\\uD83C[\\uDFFB-\\uDFFF](?:\\u200D[\\u2640\\u2642]\\uFE0F?)?)?|\\uDC83(?:\\uD83C[\\uDFFB-\\uDFFF])?|\\uDC84|\\uDC85(?:\\uD83C[\\uDFFB-\\uDFFF])?|[\\uDC86\\uDC87](?:\\u200D[\\u2640\\u2642]\\uFE0F?|\\uD83C[\\uDFFB-\\uDFFF](?:\\u200D[\\u2640\\u2642]\\uFE0F?)?)?|[\\uDC88-\\uDC8E]|\\uDC8F(?:\\uD83C[\\uDFFB-\\uDFFF])?|\\uDC90|\\uDC91(?:\\uD83C[\\uDFFB-\\uDFFF])?|[\\uDC92-\\uDCA9]|\\uDCAA(?:\\uD83C[\\uDFFB-\\uDFFF])?|[\\uDCAB-\\uDCFC]|\\uDCFD\\uFE0F?|[\\uDCFF-\\uDD3D]|[\\uDD49\\uDD4A]\\uFE0F?|[\\uDD4B-\\uDD4E\\uDD50-\\uDD67]|[\\uDD6F\\uDD70\\uDD73]\\uFE0F?|\\uDD74(?:\\uD83C[\\uDFFB-\\uDFFF]|\\uFE0F)?|\\uDD75(?:\\u200D[\\u2640\\u2642]\\uFE0F?|\\uD83C[\\uDFFB-\\uDFFF](?:\\u200D[\\u2640\\u2642]\\uFE0F?)?|\\uFE0F(?:\\u200D[\\u2640\\u2642]\\uFE0F?)?)?|[\\uDD76-\\uDD79]\\uFE0F?|\\uDD7A(?:\\uD83C[\\uDFFB-\\uDFFF])?|[\\uDD87\\uDD8A-\\uDD8D]\\uFE0F?|\\uDD90(?:\\uD83C[\\uDFFB-\\uDFFF]|\\uFE0F)?|[\\uDD95\\uDD96](?:\\uD83C[\\uDFFB-\\uDFFF])?|\\uDDA4|[\\uDDA5\\uDDA8\\uDDB1\\uDDB2\\uDDBC\\uDDC2-\\uDDC4\\uDDD1-\\uDDD3\\uDDDC-\\uDDDE\\uDDE1\\uDDE3\\uDDE8\\uDDEF\\uDDF3\\uDDFA]\\uFE0F?|[\\uDDFB-\\uDE2D]|\\uDE2E(?:\\u200D\\uD83D\\uDCA8)?|[\\uDE2F-\\uDE34]|\\uDE35(?:\\u200D\\uD83D\\uDCAB)?|\\uDE36(?:\\u200D\\uD83C\\uDF2B\\uFE0F?)?|[\\uDE37-\\uDE44]|[\\uDE45-\\uDE47](?:\\u200D[\\u2640\\u2642]\\uFE0F?|\\uD83C[\\uDFFB-\\uDFFF](?:\\u200D[\\u2640\\u2642]\\uFE0F?)?)?|[\\uDE48-\\uDE4A]|\\uDE4B(?:\\u200D[\\u2640\\u2642]\\uFE0F?|\\uD83C[\\uDFFB-\\uDFFF](?:\\u200D[\\u2640\\u2642]\\uFE0F?)?)?|\\uDE4C(?:\\uD83C[\\uDFFB-\\uDFFF])?|[\\uDE4D\\uDE4E](?:\\u200D[\\u2640\\u2642]\\uFE0F?|\\uD83C[\\uDFFB-\\uDFFF](?:\\u200D[\\u2640\\u2642]\\uFE0F?)?)?|\\uDE4F(?:\\uD83C[\\uDFFB-\\uDFFF])?|[\\uDE80-\\uDEA2]|\\uDEA3(?:\\u200D[\\u2640\\u2642]\\uFE0F?|\\uD83C[\\uDFFB-\\uDFFF](?:\\u200D[\\u2640\\u2642]\\uFE0F?)?)?|[\\uDEA4-\\uDEB3]|[\\uDEB4-\\uDEB6](?:\\u200D[\\u2640\\u2642]\\uFE0F?|\\uD83C[\\uDFFB-\\uDFFF](?:\\u200D[\\u2640\\u2642]\\uFE0F?)?)?|[\\uDEB7-\\uDEBF]|\\uDEC0(?:\\uD83C[\\uDFFB-\\uDFFF])?|[\\uDEC1-\\uDEC5]|\\uDECB\\uFE0F?|\\uDECC(?:\\uD83C[\\uDFFB-\\uDFFF])?|[\\uDECD-\\uDECF]\\uFE0F?|[\\uDED0-\\uDED2\\uDED5-\\uDED7]|[\\uDEE0-\\uDEE5\\uDEE9]\\uFE0F?|[\\uDEEB\\uDEEC]|[\\uDEF0\\uDEF3]\\uFE0F?|[\\uDEF4-\\uDEFC\\uDFE0-\\uDFEB])|\\uD83E(?:\\uDD0C(?:\\uD83C[\\uDFFB-\\uDFFF])?|[\\uDD0D\\uDD0E]|\\uDD0F(?:\\uD83C[\\uDFFB-\\uDFFF])?|[\\uDD10-\\uDD17]|[\\uDD18-\\uDD1C](?:\\uD83C[\\uDFFB-\\uDFFF])?|\\uDD1D|[\\uDD1E\\uDD1F](?:\\uD83C[\\uDFFB-\\uDFFF])?|[\\uDD20-\\uDD25]|\\uDD26(?:\\u200D[\\u2640\\u2642]\\uFE0F?|\\uD83C[\\uDFFB-\\uDFFF](?:\\u200D[\\u2640\\u2642]\\uFE0F?)?)?|[\\uDD27-\\uDD2F]|[\\uDD30-\\uDD34](?:\\uD83C[\\uDFFB-\\uDFFF])?|\\uDD35(?:\\u200D[\\u2640\\u2642]\\uFE0F?|\\uD83C[\\uDFFB-\\uDFFF](?:\\u200D[\\u2640\\u2642]\\uFE0F?)?)?|\\uDD36(?:\\uD83C[\\uDFFB-\\uDFFF])?|[\\uDD37-\\uDD39](?:\\u200D[\\u2640\\u2642]\\uFE0F?|\\uD83C[\\uDFFB-\\uDFFF](?:\\u200D[\\u2640\\u2642]\\uFE0F?)?)?|\\uDD3A|\\uDD3C(?:\\u200D[\\u2640\\u2642]\\uFE0F?)?|[\\uDD3D\\uDD3E](?:\\u200D[\\u2640\\u2642]\\uFE0F?|\\uD83C[\\uDFFB-\\uDFFF](?:\\u200D[\\u2640\\u2642]\\uFE0F?)?)?|[\\uDD3F-\\uDD45\\uDD47-\\uDD76]|\\uDD77(?:\\uD83C[\\uDFFB-\\uDFFF])?|[\\uDD78\\uDD7A-\\uDDB4]|[\\uDDB5\\uDDB6](?:\\uD83C[\\uDFFB-\\uDFFF])?|\\uDDB7|[\\uDDB8\\uDDB9](?:\\u200D[\\u2640\\u2642]\\uFE0F?|\\uD83C[\\uDFFB-\\uDFFF](?:\\u200D[\\u2640\\u2642]\\uFE0F?)?)?|\\uDDBA|\\uDDBB(?:\\uD83C[\\uDFFB-\\uDFFF])?|[\\uDDBC-\\uDDCB]|[\\uDDCD-\\uDDCF](?:\\u200D[\\u2640\\u2642]\\uFE0F?|\\uD83C[\\uDFFB-\\uDFFF](?:\\u200D[\\u2640\\u2642]\\uFE0F?)?)?|\\uDDD0|\\uDDD1(?:\\u200D(?:[\\u2695\\u2696\\u2708]\\uFE0F?|\\uD83C[\\uDF3E\\uDF73\\uDF7C\\uDF84\\uDF93\\uDFA4\\uDFA8\\uDFEB\\uDFED]|\\uD83D[\\uDCBB\\uDCBC\\uDD27\\uDD2C\\uDE80\\uDE92]|\\uD83E(?:\\uDD1D\\u200D\\uD83E\\uDDD1|[\\uDDAF-\\uDDB3\\uDDBC\\uDDBD]))|\\uD83C(?:\\uDFFB(?:\\u200D(?:[\\u2695\\u2696\\u2708]\\uFE0F?|\\u2764\\uFE0F?\\u200D(?:\\uD83D\\uDC8B\\u200D)?\\uD83E\\uDDD1\\uD83C[\\uDFFC-\\uDFFF]|\\uD83C[\\uDF3E\\uDF73\\uDF7C\\uDF84\\uDF93\\uDFA4\\uDFA8\\uDFEB\\uDFED]|\\uD83D[\\uDCBB\\uDCBC\\uDD27\\uDD2C\\uDE80\\uDE92]|\\uD83E(?:\\uDD1D\\u200D\\uD83E\\uDDD1\\uD83C[\\uDFFB-\\uDFFF]|[\\uDDAF-\\uDDB3\\uDDBC\\uDDBD])))?|\\uDFFC(?:\\u200D(?:[\\u2695\\u2696\\u2708]\\uFE0F?|\\u2764\\uFE0F?\\u200D(?:\\uD83D\\uDC8B\\u200D)?\\uD83E\\uDDD1\\uD83C[\\uDFFB\\uDFFD-\\uDFFF]|\\uD83C[\\uDF3E\\uDF73\\uDF7C\\uDF84\\uDF93\\uDFA4\\uDFA8\\uDFEB\\uDFED]|\\uD83D[\\uDCBB\\uDCBC\\uDD27\\uDD2C\\uDE80\\uDE92]|\\uD83E(?:\\uDD1D\\u200D\\uD83E\\uDDD1\\uD83C[\\uDFFB-\\uDFFF]|[\\uDDAF-\\uDDB3\\uDDBC\\uDDBD])))?|\\uDFFD(?:\\u200D(?:[\\u2695\\u2696\\u2708]\\uFE0F?|\\u2764\\uFE0F?\\u200D(?:\\uD83D\\uDC8B\\u200D)?\\uD83E\\uDDD1\\uD83C[\\uDFFB\\uDFFC\\uDFFE\\uDFFF]|\\uD83C[\\uDF3E\\uDF73\\uDF7C\\uDF84\\uDF93\\uDFA4\\uDFA8\\uDFEB\\uDFED]|\\uD83D[\\uDCBB\\uDCBC\\uDD27\\uDD2C\\uDE80\\uDE92]|\\uD83E(?:\\uDD1D\\u200D\\uD83E\\uDDD1\\uD83C[\\uDFFB-\\uDFFF]|[\\uDDAF-\\uDDB3\\uDDBC\\uDDBD])))?|\\uDFFE(?:\\u200D(?:[\\u2695\\u2696\\u2708]\\uFE0F?|\\u2764\\uFE0F?\\u200D(?:\\uD83D\\uDC8B\\u200D)?\\uD83E\\uDDD1\\uD83C[\\uDFFB-\\uDFFD\\uDFFF]|\\uD83C[\\uDF3E\\uDF73\\uDF7C\\uDF84\\uDF93\\uDFA4\\uDFA8\\uDFEB\\uDFED]|\\uD83D[\\uDCBB\\uDCBC\\uDD27\\uDD2C\\uDE80\\uDE92]|\\uD83E(?:\\uDD1D\\u200D\\uD83E\\uDDD1\\uD83C[\\uDFFB-\\uDFFF]|[\\uDDAF-\\uDDB3\\uDDBC\\uDDBD])))?|\\uDFFF(?:\\u200D(?:[\\u2695\\u2696\\u2708]\\uFE0F?|\\u2764\\uFE0F?\\u200D(?:\\uD83D\\uDC8B\\u200D)?\\uD83E\\uDDD1\\uD83C[\\uDFFB-\\uDFFE]|\\uD83C[\\uDF3E\\uDF73\\uDF7C\\uDF84\\uDF93\\uDFA4\\uDFA8\\uDFEB\\uDFED]|\\uD83D[\\uDCBB\\uDCBC\\uDD27\\uDD2C\\uDE80\\uDE92]|\\uD83E(?:\\uDD1D\\u200D\\uD83E\\uDDD1\\uD83C[\\uDFFB-\\uDFFF]|[\\uDDAF-\\uDDB3\\uDDBC\\uDDBD])))?))?|[\\uDDD2\\uDDD3](?:\\uD83C[\\uDFFB-\\uDFFF])?|\\uDDD4(?:\\u200D[\\u2640\\u2642]\\uFE0F?|\\uD83C[\\uDFFB-\\uDFFF](?:\\u200D[\\u2640\\u2642]\\uFE0F?)?)?|\\uDDD5(?:\\uD83C[\\uDFFB-\\uDFFF])?|[\\uDDD6-\\uDDDD](?:\\u200D[\\u2640\\u2642]\\uFE0F?|\\uD83C[\\uDFFB-\\uDFFF](?:\\u200D[\\u2640\\u2642]\\uFE0F?)?)?|[\\uDDDE\\uDDDF](?:\\u200D[\\u2640\\u2642]\\uFE0F?)?|[\\uDDE0-\\uDDFF\\uDE70-\\uDE74\\uDE78-\\uDE7A\\uDE80-\\uDE86\\uDE90-\\uDEA8\\uDEB0-\\uDEB6\\uDEC0-\\uDEC2\\uDED0-\\uDED6])";

	// Token: 0x0400050E RID: 1294
	[Token(Token = "0x400050E")]
	private const string regex2 = "<sprite=([a-z0-9A-Z]+)>";

	// Token: 0x0400050F RID: 1295
	[Token(Token = "0x400050F")]
	private const string regex3 = "<\\|>";

	// Token: 0x04000510 RID: 1296
	[Token(Token = "0x4000510")]
	private const string regex4 = "<color=#[a-z0-9A-Z]+>|</color>";

	// Token: 0x04000511 RID: 1297
	[Token(Token = "0x4000511")]
	[FieldOffset(Offset = "0x0")]
	private static Regex Regex1;

	// Token: 0x04000512 RID: 1298
	[Token(Token = "0x4000512")]
	[FieldOffset(Offset = "0x8")]
	private static Regex Regex2;

	// Token: 0x04000513 RID: 1299
	[Token(Token = "0x4000513")]
	[FieldOffset(Offset = "0x10")]
	private static Regex Regex3;

	// Token: 0x04000514 RID: 1300
	[Token(Token = "0x4000514")]
	[FieldOffset(Offset = "0x18")]
	private static Regex Regex4;

	// Token: 0x04000515 RID: 1301
	[Token(Token = "0x4000515")]
	[FieldOffset(Offset = "0x20")]
	private static Regex RegexWhitespace;

	// Token: 0x04000516 RID: 1302
	[Token(Token = "0x4000516")]
	[FieldOffset(Offset = "0x28")]
	private static TextGenerator _generator;

	// Token: 0x04000517 RID: 1303
	[Token(Token = "0x4000517")]
	[FieldOffset(Offset = "0x100")]
	private List<string> emojiHolderList;

	// Token: 0x04000518 RID: 1304
	[Token(Token = "0x4000518")]
	private const string emojiPlaceHolder = "<|>";

	// Token: 0x04000519 RID: 1305
	[Token(Token = "0x4000519")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	private bool m_useTextWithEllipsis;

	// Token: 0x0400051A RID: 1306
	[Token(Token = "0x400051A")]
	[FieldOffset(Offset = "0x30")]
	private static Dictionary<int, EmojiFrame2> emojiDic;

	// Token: 0x0400051B RID: 1307
	[Token(Token = "0x400051B")]
	[FieldOffset(Offset = "0x38")]
	private static readonly Dictionary<string, EmojiFrame2> emojiFrames;

	// Token: 0x0400051C RID: 1308
	[Token(Token = "0x400051C")]
	[FieldOffset(Offset = "0x40")]
	private static readonly Dictionary<string, string> emojiFastSearch;

	// Token: 0x0400051D RID: 1309
	[Token(Token = "0x400051D")]
	[FieldOffset(Offset = "0x48")]
	private static bool isLoadingEmoji;

	// Token: 0x0400051E RID: 1310
	[Token(Token = "0x400051E")]
	[FieldOffset(Offset = "0x50")]
	private static StringBuilder sb_;

	// Token: 0x0400051F RID: 1311
	[Token(Token = "0x400051F")]
	[FieldOffset(Offset = "0x58")]
	private static byte[] utf32_bytes_;

	// Token: 0x04000520 RID: 1312
	[Token(Token = "0x4000520")]
	[FieldOffset(Offset = "0x60")]
	private static StringBuilder utf32_sb_;

	// Token: 0x04000521 RID: 1313
	[Token(Token = "0x4000521")]
	[FieldOffset(Offset = "0x68")]
	private static string[] b2str_;

	// Token: 0x04000522 RID: 1314
	[Token(Token = "0x4000522")]
	[FieldOffset(Offset = "0x109")]
	public bool supportEmoji;

	// Token: 0x04000523 RID: 1315
	[Token(Token = "0x4000523")]
	[FieldOffset(Offset = "0x10C")]
	private float m_IconScaleOfDoubleSymbole;

	// Token: 0x04000524 RID: 1316
	[Token(Token = "0x4000524")]
	[FieldOffset(Offset = "0x110")]
	private bool m_EmojiParsingRequired;

	// Token: 0x04000525 RID: 1317
	[Token(Token = "0x4000525")]
	[FieldOffset(Offset = "0x118")]
	private string m_EmojiText;

	// Token: 0x04000526 RID: 1318
	[Token(Token = "0x4000526")]
	[FieldOffset(Offset = "0x120")]
	private readonly UIVertex[] m_TempVerts;

	// Token: 0x04000527 RID: 1319
	[Token(Token = "0x4000527")]
	[FieldOffset(Offset = "0x128")]
	private StringBuilder _stringBuilder;

	// Token: 0x04000528 RID: 1320
	[Token(Token = "0x4000528")]
	[FieldOffset(Offset = "0x130")]
	private bool _lock;

	// Token: 0x04000529 RID: 1321
	[Token(Token = "0x4000529")]
	[FieldOffset(Offset = "0x138")]
	private string _compareValue;

	// Token: 0x0400052A RID: 1322
	[Token(Token = "0x400052A")]
	[FieldOffset(Offset = "0x140")]
	private string[] FixedText;

	// Token: 0x0400052B RID: 1323
	[Token(Token = "0x400052B")]
	[FieldOffset(Offset = "0x148")]
	private string[] Holder;

	// Token: 0x0400052C RID: 1324
	[Token(Token = "0x400052C")]
	[FieldOffset(Offset = "0x150")]
	private string TextHolder;

	// Token: 0x0400052D RID: 1325
	[Token(Token = "0x400052D")]
	[FieldOffset(Offset = "0x158")]
	private int startIndex;

	// Token: 0x0400052E RID: 1326
	[Token(Token = "0x400052E")]
	[FieldOffset(Offset = "0x15C")]
	private int endIndex;

	// Token: 0x0400052F RID: 1327
	[Token(Token = "0x400052F")]
	[FieldOffset(Offset = "0x160")]
	private int length;
}
