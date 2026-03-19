using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200016B RID: 363
[Token(Token = "0x200016B")]
public class LocalText : MonoBehaviour
{
	// Token: 0x06000A6E RID: 2670 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A6E")]
	[Address(RVA = "0x37147D4", Offset = "0x37147D4", VA = "0x37147D4")]
	public void ParseAndPopulateTips(string rawData)
	{
	}

	// Token: 0x06000A6F RID: 2671 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A6F")]
	[Address(RVA = "0x37149B4", Offset = "0x37149B4", VA = "0x37149B4")]
	private void Start()
	{
	}

	// Token: 0x06000A70 RID: 2672 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A70")]
	[Address(RVA = "0x3714C14", Offset = "0x3714C14", VA = "0x3714C14")]
	public void OnClickBtnInfo()
	{
	}

	// Token: 0x06000A71 RID: 2673 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A71")]
	[Address(RVA = "0x3714CE0", Offset = "0x3714CE0", VA = "0x3714CE0")]
	public LocalText()
	{
	}

	// Token: 0x04000784 RID: 1924
	[Token(Token = "0x4000784")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<string, string> allTips;

	// Token: 0x04000785 RID: 1925
	[Token(Token = "0x4000785")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI m_TextMeshPro;

	// Token: 0x04000786 RID: 1926
	[Token(Token = "0x4000786")]
	[FieldOffset(Offset = "0x28")]
	public string strCountry;

	// Token: 0x04000787 RID: 1927
	[Token(Token = "0x4000787")]
	[FieldOffset(Offset = "0x30")]
	private string the_dialogId;
}
