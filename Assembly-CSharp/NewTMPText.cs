using System;
using Il2CppDummyDll;
using RTLTMPro;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000346 RID: 838
[Token(Token = "0x2000346")]
public class NewTMPText : TextMeshProUGUI, IPointerClickHandler, IEventSystemHandler
{
	// Token: 0x060015C5 RID: 5573 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015C5")]
	[Address(RVA = "0x1ED714C", Offset = "0x1ED714C", VA = "0x1ED714C", Slot = "143")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	// Token: 0x17000248 RID: 584
	// (get) Token: 0x060015C6 RID: 5574 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060015C7 RID: 5575 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000248")]
	public override string text
	{
		[Token(Token = "0x60015C6")]
		[Address(RVA = "0x1ED7168", Offset = "0x1ED7168", VA = "0x1ED7168", Slot = "65")]
		get
		{
			return null;
		}
		[Token(Token = "0x60015C7")]
		[Address(RVA = "0x1ED7170", Offset = "0x1ED7170", VA = "0x1ED7170", Slot = "66")]
		set
		{
		}
	}

	// Token: 0x060015C8 RID: 5576 RVA: 0x00008640 File Offset: 0x00006840
	[Token(Token = "0x60015C8")]
	[Address(RVA = "0x1ED7B8C", Offset = "0x1ED7B8C", VA = "0x1ED7B8C")]
	public static TextAlignmentOptions ConvertAlignFormat(TextAnchor anchor, bool alignByGeometry)
	{
		return default(TextAlignmentOptions);
	}

	// Token: 0x060015C9 RID: 5577 RVA: 0x00008658 File Offset: 0x00006858
	[Token(Token = "0x60015C9")]
	[Address(RVA = "0x1ED78E4", Offset = "0x1ED78E4", VA = "0x1ED78E4")]
	public bool HasArabic(string str, out int arabicCount)
	{
		return default(bool);
	}

	// Token: 0x060015CA RID: 5578 RVA: 0x00008670 File Offset: 0x00006870
	[Token(Token = "0x60015CA")]
	[Address(RVA = "0x1ED7C38", Offset = "0x1ED7C38", VA = "0x1ED7C38")]
	public static bool CheckArabicByChar(string str, out int arabicCount)
	{
		return default(bool);
	}

	// Token: 0x060015CB RID: 5579 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015CB")]
	[Address(RVA = "0x1ED7AF0", Offset = "0x1ED7AF0", VA = "0x1ED7AF0")]
	private void SetRtlAlign(TextAlignmentOptions targetAlign, bool auto)
	{
	}

	// Token: 0x060015CC RID: 5580 RVA: 0x00008688 File Offset: 0x00006888
	[Token(Token = "0x60015CC")]
	[Address(RVA = "0x1ED7D40", Offset = "0x1ED7D40", VA = "0x1ED7D40")]
	public static bool isArabic(char c)
	{
		return default(bool);
	}

	// Token: 0x060015CD RID: 5581 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015CD")]
	[Address(RVA = "0x1ED79A8", Offset = "0x1ED79A8", VA = "0x1ED79A8")]
	private string GetFixedText(string input, bool isReverse = true)
	{
		return null;
	}

	// Token: 0x060015CE RID: 5582 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015CE")]
	[Address(RVA = "0x1ED7D88", Offset = "0x1ED7D88", VA = "0x1ED7D88")]
	public void SetColorMode(ColorMode mode)
	{
	}

	// Token: 0x17000249 RID: 585
	// (get) Token: 0x060015CF RID: 5583 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000249")]
	public TMPTeletypeComponent Teletype
	{
		[Token(Token = "0x60015CF")]
		[Address(RVA = "0x1ED7D90", Offset = "0x1ED7D90", VA = "0x1ED7D90")]
		get
		{
			return null;
		}
	}

	// Token: 0x060015D0 RID: 5584 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015D0")]
	[Address(RVA = "0x1ED7E34", Offset = "0x1ED7E34", VA = "0x1ED7E34")]
	public void SetCodeEffectText(string str, Action callback, int startIndex = 0, float speed = 0.1f)
	{
	}

	// Token: 0x060015D1 RID: 5585 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015D1")]
	[Address(RVA = "0x1ED7F08", Offset = "0x1ED7F08", VA = "0x1ED7F08")]
	public void SetCodeSpeed(float delta)
	{
	}

	// Token: 0x060015D2 RID: 5586 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015D2")]
	[Address(RVA = "0x1ED7F9C", Offset = "0x1ED7F9C", VA = "0x1ED7F9C")]
	public void ShowCodeTextEffDirect()
	{
	}

	// Token: 0x060015D3 RID: 5587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015D3")]
	[Address(RVA = "0x1ED802C", Offset = "0x1ED802C", VA = "0x1ED802C")]
	public NewTMPText()
	{
	}

	// Token: 0x040018DF RID: 6367
	[Token(Token = "0x40018DF")]
	[FieldOffset(Offset = "0x795")]
	private bool arabicFontSizeProcessFlag;

	// Token: 0x040018E0 RID: 6368
	[Token(Token = "0x40018E0")]
	[FieldOffset(Offset = "0x798")]
	public Action<PointerEventData> onPointerClick;

	// Token: 0x040018E1 RID: 6369
	[Token(Token = "0x40018E1")]
	[FieldOffset(Offset = "0x7A0")]
	public bool ArabicAutoRight;

	// Token: 0x040018E2 RID: 6370
	[Token(Token = "0x40018E2")]
	[FieldOffset(Offset = "0x7A4")]
	public int ArabicFontSize;

	// Token: 0x040018E3 RID: 6371
	[Token(Token = "0x40018E3")]
	[FieldOffset(Offset = "0x0")]
	public static int IncfontSizeMax;

	// Token: 0x040018E4 RID: 6372
	[Token(Token = "0x40018E4")]
	[FieldOffset(Offset = "0x4")]
	public static int IncfontSizeMin;

	// Token: 0x040018E5 RID: 6373
	[Token(Token = "0x40018E5")]
	[FieldOffset(Offset = "0x8")]
	public static int IncfontSize;

	// Token: 0x040018E6 RID: 6374
	[Token(Token = "0x40018E6")]
	[FieldOffset(Offset = "0x10")]
	private static FastStringBuilder RTLFixedText;

	// Token: 0x040018E7 RID: 6375
	[Token(Token = "0x40018E7")]
	[FieldOffset(Offset = "0x7A8")]
	private int startIndex;

	// Token: 0x040018E8 RID: 6376
	[Token(Token = "0x40018E8")]
	[FieldOffset(Offset = "0x7AC")]
	private int endIndex;

	// Token: 0x040018E9 RID: 6377
	[Token(Token = "0x40018E9")]
	[FieldOffset(Offset = "0x7B0")]
	private int length;

	// Token: 0x040018EA RID: 6378
	[Token(Token = "0x40018EA")]
	[FieldOffset(Offset = "0x7B8")]
	private TMPTeletypeComponent m_teletypeCom;

	// Token: 0x02000347 RID: 839
	[Token(Token = "0x2000347")]
	public enum HorizontalAlignmentOptions
	{
		// Token: 0x040018EC RID: 6380
		[Token(Token = "0x40018EC")]
		Left = 1,
		// Token: 0x040018ED RID: 6381
		[Token(Token = "0x40018ED")]
		Center,
		// Token: 0x040018EE RID: 6382
		[Token(Token = "0x40018EE")]
		Right = 4,
		// Token: 0x040018EF RID: 6383
		[Token(Token = "0x40018EF")]
		Justified = 8,
		// Token: 0x040018F0 RID: 6384
		[Token(Token = "0x40018F0")]
		Flush = 16,
		// Token: 0x040018F1 RID: 6385
		[Token(Token = "0x40018F1")]
		Geometry = 32
	}

	// Token: 0x02000348 RID: 840
	[Token(Token = "0x2000348")]
	public enum VerticalAlignmentOptions
	{
		// Token: 0x040018F3 RID: 6387
		[Token(Token = "0x40018F3")]
		Top = 256,
		// Token: 0x040018F4 RID: 6388
		[Token(Token = "0x40018F4")]
		Middle = 512,
		// Token: 0x040018F5 RID: 6389
		[Token(Token = "0x40018F5")]
		Bottom = 1024,
		// Token: 0x040018F6 RID: 6390
		[Token(Token = "0x40018F6")]
		Baseline = 2048,
		// Token: 0x040018F7 RID: 6391
		[Token(Token = "0x40018F7")]
		Geometry = 4096,
		// Token: 0x040018F8 RID: 6392
		[Token(Token = "0x40018F8")]
		Capline = 8192
	}
}
