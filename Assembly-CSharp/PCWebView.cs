using System;
using Il2CppDummyDll;
using UnityEngine;
using Vuplex.WebView;

// Token: 0x02000093 RID: 147
[Token(Token = "0x2000093")]
public class PCWebView : MonoBehaviour
{
	// Token: 0x0600037D RID: 893 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600037D")]
	[Address(RVA = "0x3214ED8", Offset = "0x3214ED8", VA = "0x3214ED8")]
	private void Awake()
	{
	}

	// Token: 0x0600037E RID: 894 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600037E")]
	[Address(RVA = "0x3214EDC", Offset = "0x3214EDC", VA = "0x3214EDC")]
	public void LoadUrl(string url)
	{
	}

	// Token: 0x0600037F RID: 895 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600037F")]
	[Address(RVA = "0x3214EE0", Offset = "0x3214EE0", VA = "0x3214EE0")]
	public PCWebView()
	{
	}

	// Token: 0x04000308 RID: 776
	[Token(Token = "0x4000308")]
	[FieldOffset(Offset = "0x18")]
	private BaseWebViewPrefab _canvasWebView;

	// Token: 0x04000309 RID: 777
	[Token(Token = "0x4000309")]
	[FieldOffset(Offset = "0x0")]
	private static bool _firstInit;
}
