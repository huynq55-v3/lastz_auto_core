using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000A5 RID: 165
[Token(Token = "0x20000A5")]
[DisallowMultipleComponent]
[RequireComponent(typeof(NewTMP3DText))]
public class Tmp3DLocalizeTextAutoSet : MonoBehaviour
{
	// Token: 0x060003D0 RID: 976 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x2F67070", Offset = "0x2F67070", VA = "0x2F67070")]
	private void Awake()
	{
	}

	// Token: 0x060003D1 RID: 977 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x2F670C8", Offset = "0x2F670C8", VA = "0x2F670C8")]
	private void OnEnable()
	{
	}

	// Token: 0x060003D2 RID: 978 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x2F670CC", Offset = "0x2F670CC", VA = "0x2F670CC")]
	public void Refresh()
	{
	}

	// Token: 0x060003D3 RID: 979 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x2F67200", Offset = "0x2F67200", VA = "0x2F67200")]
	public Tmp3DLocalizeTextAutoSet()
	{
	}

	// Token: 0x04000369 RID: 873
	[Token(Token = "0x4000369")]
	[FieldOffset(Offset = "0x18")]
	public string dialogId;

	// Token: 0x0400036A RID: 874
	[Token(Token = "0x400036A")]
	[FieldOffset(Offset = "0x20")]
	private NewTMP3DText _newText;
}
