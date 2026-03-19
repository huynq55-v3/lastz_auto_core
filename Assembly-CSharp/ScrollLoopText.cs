using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000115 RID: 277
[Token(Token = "0x2000115")]
public class ScrollLoopText : MonoBehaviour
{
	// Token: 0x060007D8 RID: 2008 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007D8")]
	[Address(RVA = "0x347DAE4", Offset = "0x347DAE4", VA = "0x347DAE4")]
	public void CheckCanRun()
	{
	}

	// Token: 0x060007D9 RID: 2009 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007D9")]
	[Address(RVA = "0x347DFD8", Offset = "0x347DFD8", VA = "0x347DFD8")]
	private void Update()
	{
	}

	// Token: 0x060007DA RID: 2010 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007DA")]
	[Address(RVA = "0x347E1FC", Offset = "0x347E1FC", VA = "0x347E1FC")]
	public ScrollLoopText()
	{
	}

	// Token: 0x040005CE RID: 1486
	[Token(Token = "0x40005CE")]
	[FieldOffset(Offset = "0x18")]
	public Text txt;

	// Token: 0x040005CF RID: 1487
	[Token(Token = "0x40005CF")]
	[FieldOffset(Offset = "0x20")]
	public List<Text> scrollTxt;

	// Token: 0x040005D0 RID: 1488
	[Token(Token = "0x40005D0")]
	[FieldOffset(Offset = "0x28")]
	public float offset;

	// Token: 0x040005D1 RID: 1489
	[Token(Token = "0x40005D1")]
	[FieldOffset(Offset = "0x2C")]
	public float speed;

	// Token: 0x040005D2 RID: 1490
	[Token(Token = "0x40005D2")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform scrollEndPos;

	// Token: 0x040005D3 RID: 1491
	[Token(Token = "0x40005D3")]
	[FieldOffset(Offset = "0x38")]
	private Vector2 endPos;
}
