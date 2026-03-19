using System;
using Il2CppDummyDll;
using RTLTMPro;
using TMPro;
using UnityEngine;

// Token: 0x02000343 RID: 835
[Token(Token = "0x2000343")]
public class NewTMP3DText : TextMeshPro
{
	// Token: 0x17000246 RID: 582
	// (get) Token: 0x060015B6 RID: 5558 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060015B7 RID: 5559 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000246")]
	public override string text
	{
		[Token(Token = "0x60015B6")]
		[Address(RVA = "0x1ED6580", Offset = "0x1ED6580", VA = "0x1ED6580", Slot = "65")]
		get
		{
			return null;
		}
		[Token(Token = "0x60015B7")]
		[Address(RVA = "0x1ED6588", Offset = "0x1ED6588", VA = "0x1ED6588", Slot = "66")]
		set
		{
		}
	}

	// Token: 0x060015B8 RID: 5560 RVA: 0x000085E0 File Offset: 0x000067E0
	[Token(Token = "0x60015B8")]
	[Address(RVA = "0x1ED69A4", Offset = "0x1ED69A4", VA = "0x1ED69A4")]
	public static TextAlignmentOptions ConvertAlignFormat(TextAnchor anchor, bool alignByGeometry)
	{
		return default(TextAlignmentOptions);
	}

	// Token: 0x060015B9 RID: 5561 RVA: 0x000085F8 File Offset: 0x000067F8
	[Token(Token = "0x60015B9")]
	[Address(RVA = "0x1ED66FC", Offset = "0x1ED66FC", VA = "0x1ED66FC")]
	public bool HasArabic(string str, out int arabicCount)
	{
		return default(bool);
	}

	// Token: 0x060015BA RID: 5562 RVA: 0x00008610 File Offset: 0x00006810
	[Token(Token = "0x60015BA")]
	[Address(RVA = "0x1ED6A50", Offset = "0x1ED6A50", VA = "0x1ED6A50")]
	public static bool CheckArabicByChar(string str, out int arabicCount)
	{
		return default(bool);
	}

	// Token: 0x060015BB RID: 5563 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015BB")]
	[Address(RVA = "0x1ED6908", Offset = "0x1ED6908", VA = "0x1ED6908")]
	private void SetRtlAlign(TextAlignmentOptions targetAlign, bool auto)
	{
	}

	// Token: 0x060015BC RID: 5564 RVA: 0x00008628 File Offset: 0x00006828
	[Token(Token = "0x60015BC")]
	[Address(RVA = "0x1ED6B58", Offset = "0x1ED6B58", VA = "0x1ED6B58")]
	public static bool isArabic(char c)
	{
		return default(bool);
	}

	// Token: 0x060015BD RID: 5565 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015BD")]
	[Address(RVA = "0x1ED67C0", Offset = "0x1ED67C0", VA = "0x1ED67C0")]
	private string GetFixedText(string input, bool isReverse = true)
	{
		return null;
	}

	// Token: 0x060015BE RID: 5566 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015BE")]
	[Address(RVA = "0x1ED6BA0", Offset = "0x1ED6BA0", VA = "0x1ED6BA0")]
	public void SetColorMode(ColorMode mode)
	{
	}

	// Token: 0x17000247 RID: 583
	// (get) Token: 0x060015BF RID: 5567 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000247")]
	public TMPTeletypeComponent Teletype
	{
		[Token(Token = "0x60015BF")]
		[Address(RVA = "0x1ED6BA8", Offset = "0x1ED6BA8", VA = "0x1ED6BA8")]
		get
		{
			return null;
		}
	}

	// Token: 0x060015C0 RID: 5568 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015C0")]
	[Address(RVA = "0x1ED6C4C", Offset = "0x1ED6C4C", VA = "0x1ED6C4C")]
	public void SetCodeEffectText(string str, Action callback, int startIndex = 0, float speed = 0.1f)
	{
	}

	// Token: 0x060015C1 RID: 5569 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015C1")]
	[Address(RVA = "0x1ED6E9C", Offset = "0x1ED6E9C", VA = "0x1ED6E9C")]
	public void SetCodeSpeed(float delta)
	{
	}

	// Token: 0x060015C2 RID: 5570 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015C2")]
	[Address(RVA = "0x1ED6F30", Offset = "0x1ED6F30", VA = "0x1ED6F30")]
	public void ShowCodeTextEffDirect()
	{
	}

	// Token: 0x060015C3 RID: 5571 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015C3")]
	[Address(RVA = "0x1ED706C", Offset = "0x1ED706C", VA = "0x1ED706C")]
	public NewTMP3DText()
	{
	}

	// Token: 0x040018C9 RID: 6345
	[Token(Token = "0x40018C9")]
	[FieldOffset(Offset = "0x759")]
	private bool arabicFontSizeProcessFlag;

	// Token: 0x040018CA RID: 6346
	[Token(Token = "0x40018CA")]
	[FieldOffset(Offset = "0x75A")]
	public bool ArabicAutoRight;

	// Token: 0x040018CB RID: 6347
	[Token(Token = "0x40018CB")]
	[FieldOffset(Offset = "0x75C")]
	public int ArabicFontSize;

	// Token: 0x040018CC RID: 6348
	[Token(Token = "0x40018CC")]
	[FieldOffset(Offset = "0x0")]
	private static FastStringBuilder RTLFixedText;

	// Token: 0x040018CD RID: 6349
	[Token(Token = "0x40018CD")]
	[FieldOffset(Offset = "0x760")]
	private int startIndex;

	// Token: 0x040018CE RID: 6350
	[Token(Token = "0x40018CE")]
	[FieldOffset(Offset = "0x764")]
	private int endIndex;

	// Token: 0x040018CF RID: 6351
	[Token(Token = "0x40018CF")]
	[FieldOffset(Offset = "0x768")]
	private int length;

	// Token: 0x040018D0 RID: 6352
	[Token(Token = "0x40018D0")]
	[FieldOffset(Offset = "0x770")]
	private TMPTeletypeComponent m_teletypeCom;

	// Token: 0x02000344 RID: 836
	[Token(Token = "0x2000344")]
	public enum HorizontalAlignmentOptions
	{
		// Token: 0x040018D2 RID: 6354
		[Token(Token = "0x40018D2")]
		Left = 1,
		// Token: 0x040018D3 RID: 6355
		[Token(Token = "0x40018D3")]
		Center,
		// Token: 0x040018D4 RID: 6356
		[Token(Token = "0x40018D4")]
		Right = 4,
		// Token: 0x040018D5 RID: 6357
		[Token(Token = "0x40018D5")]
		Justified = 8,
		// Token: 0x040018D6 RID: 6358
		[Token(Token = "0x40018D6")]
		Flush = 16,
		// Token: 0x040018D7 RID: 6359
		[Token(Token = "0x40018D7")]
		Geometry = 32
	}

	// Token: 0x02000345 RID: 837
	[Token(Token = "0x2000345")]
	public enum VerticalAlignmentOptions
	{
		// Token: 0x040018D9 RID: 6361
		[Token(Token = "0x40018D9")]
		Top = 256,
		// Token: 0x040018DA RID: 6362
		[Token(Token = "0x40018DA")]
		Middle = 512,
		// Token: 0x040018DB RID: 6363
		[Token(Token = "0x40018DB")]
		Bottom = 1024,
		// Token: 0x040018DC RID: 6364
		[Token(Token = "0x40018DC")]
		Baseline = 2048,
		// Token: 0x040018DD RID: 6365
		[Token(Token = "0x40018DD")]
		Geometry = 4096,
		// Token: 0x040018DE RID: 6366
		[Token(Token = "0x40018DE")]
		Capline = 8192
	}
}
