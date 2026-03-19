using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000341 RID: 833
[Token(Token = "0x2000341")]
public class NewEmojiTextHelper : MonoBehaviour, ITextPreprocessor
{
	// Token: 0x060015A9 RID: 5545 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015A9")]
	[Address(RVA = "0x1ED5378", Offset = "0x1ED5378", VA = "0x1ED5378")]
	public void Awake()
	{
	}

	// Token: 0x060015AA RID: 5546 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015AA")]
	[Address(RVA = "0x1ED53D0", Offset = "0x1ED53D0", VA = "0x1ED53D0")]
	public void OnEnable()
	{
	}

	// Token: 0x060015AB RID: 5547 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015AB")]
	[Address(RVA = "0x1ED5458", Offset = "0x1ED5458", VA = "0x1ED5458", Slot = "4")]
	public string PreprocessText(string text)
	{
		return null;
	}

	// Token: 0x060015AC RID: 5548 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015AC")]
	[Address(RVA = "0x1ED54B0", Offset = "0x1ED54B0", VA = "0x1ED54B0")]
	public NewEmojiTextHelper()
	{
	}

	// Token: 0x040018BE RID: 6334
	[Token(Token = "0x40018BE")]
	[FieldOffset(Offset = "0x18")]
	private TMP_Text _text;
}
