using System;
using System.Collections;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000111 RID: 273
[Token(Token = "0x2000111")]
public class NumberRoller : MonoBehaviour
{
	// Token: 0x060007B7 RID: 1975 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B7")]
	[Address(RVA = "0x347BF58", Offset = "0x347BF58", VA = "0x347BF58")]
	public void StartRoll(int new_targetNumber, float new_duration)
	{
	}

	// Token: 0x060007B8 RID: 1976 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B8")]
	[Address(RVA = "0x347C0D8", Offset = "0x347C0D8", VA = "0x347C0D8")]
	private void OnDisable()
	{
	}

	// Token: 0x060007B9 RID: 1977 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007B9")]
	[Address(RVA = "0x347C044", Offset = "0x347C044", VA = "0x347C044")]
	private IEnumerator CountToNumber(int target, float duration)
	{
		return null;
	}

	// Token: 0x060007BA RID: 1978 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007BA")]
	[Address(RVA = "0x347C114", Offset = "0x347C114", VA = "0x347C114")]
	public NumberRoller()
	{
	}

	// Token: 0x040005A1 RID: 1441
	[Token(Token = "0x40005A1")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI numberText;

	// Token: 0x040005A2 RID: 1442
	[Token(Token = "0x40005A2")]
	[FieldOffset(Offset = "0x20")]
	public int targetNumber;

	// Token: 0x040005A3 RID: 1443
	[Token(Token = "0x40005A3")]
	[FieldOffset(Offset = "0x24")]
	public float duration;

	// Token: 0x040005A4 RID: 1444
	[Token(Token = "0x40005A4")]
	[FieldOffset(Offset = "0x0")]
	private static string TipsPreWord;

	// Token: 0x040005A5 RID: 1445
	[Token(Token = "0x40005A5")]
	[FieldOffset(Offset = "0x28")]
	private Coroutine countingCoroutine;
}
