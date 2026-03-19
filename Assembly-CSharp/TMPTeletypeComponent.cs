using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200034D RID: 845
[Token(Token = "0x200034D")]
public class TMPTeletypeComponent : MonoBehaviour
{
	// Token: 0x060015E3 RID: 5603 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015E3")]
	[Address(RVA = "0x1ED92F8", Offset = "0x1ED92F8", VA = "0x1ED92F8")]
	public void Awake()
	{
	}

	// Token: 0x060015E4 RID: 5604 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015E4")]
	[Address(RVA = "0x1ED6D20", Offset = "0x1ED6D20", VA = "0x1ED6D20")]
	public void SetCodeEffectText(string str, Action callback, int startIndex = 0, float speed = 0.1f)
	{
	}

	// Token: 0x060015E5 RID: 5605 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015E5")]
	[Address(RVA = "0x1ED9350", Offset = "0x1ED9350", VA = "0x1ED9350")]
	public void SetCodeSpeed(float delta)
	{
	}

	// Token: 0x060015E6 RID: 5606 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015E6")]
	[Address(RVA = "0x1ED6FC0", Offset = "0x1ED6FC0", VA = "0x1ED6FC0")]
	public void ShowCodeTextEffDirect()
	{
	}

	// Token: 0x060015E7 RID: 5607 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015E7")]
	[Address(RVA = "0x1ED9358", Offset = "0x1ED9358", VA = "0x1ED9358")]
	private void Update()
	{
	}

	// Token: 0x060015E8 RID: 5608 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015E8")]
	[Address(RVA = "0x1ED93EC", Offset = "0x1ED93EC", VA = "0x1ED93EC")]
	public TMPTeletypeComponent()
	{
	}

	// Token: 0x04001906 RID: 6406
	[Token(Token = "0x4001906")]
	[FieldOffset(Offset = "0x18")]
	private TMP_Text _textMeshPro;

	// Token: 0x04001907 RID: 6407
	[Token(Token = "0x4001907")]
	[FieldOffset(Offset = "0x20")]
	private int m_codeCurTextIdx;

	// Token: 0x04001908 RID: 6408
	[Token(Token = "0x4001908")]
	[FieldOffset(Offset = "0x24")]
	private int m_codeTotalCnt;

	// Token: 0x04001909 RID: 6409
	[Token(Token = "0x4001909")]
	[FieldOffset(Offset = "0x28")]
	private float m_codeDeltaT;

	// Token: 0x0400190A RID: 6410
	[Token(Token = "0x400190A")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_isStartCodingEffect;

	// Token: 0x0400190B RID: 6411
	[Token(Token = "0x400190B")]
	[FieldOffset(Offset = "0x30")]
	private Action m_codeCallback;

	// Token: 0x0400190C RID: 6412
	[Token(Token = "0x400190C")]
	[FieldOffset(Offset = "0x38")]
	private float m_tmpDeltaT;
}
