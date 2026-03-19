using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000091 RID: 145
[Token(Token = "0x2000091")]
[RequireComponent(typeof(NewText))]
[DisallowMultipleComponent]
public class LocalizeTextAutoSet : MonoBehaviour
{
	// Token: 0x06000376 RID: 886 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000376")]
	[Address(RVA = "0x3214CF0", Offset = "0x3214CF0", VA = "0x3214CF0")]
	private void Awake()
	{
	}

	// Token: 0x06000377 RID: 887 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000377")]
	[Address(RVA = "0x3214D48", Offset = "0x3214D48", VA = "0x3214D48")]
	private void OnEnable()
	{
	}

	// Token: 0x06000378 RID: 888 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000378")]
	[Address(RVA = "0x3214D4C", Offset = "0x3214D4C", VA = "0x3214D4C")]
	public void Refresh()
	{
	}

	// Token: 0x06000379 RID: 889 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000379")]
	[Address(RVA = "0x3214E80", Offset = "0x3214E80", VA = "0x3214E80")]
	public LocalizeTextAutoSet()
	{
	}

	// Token: 0x04000302 RID: 770
	[Token(Token = "0x4000302")]
	[FieldOffset(Offset = "0x18")]
	public string dialogId;

	// Token: 0x04000303 RID: 771
	[Token(Token = "0x4000303")]
	[FieldOffset(Offset = "0x20")]
	private NewText _newText;
}
