using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using VEngine;

// Token: 0x020000DC RID: 220
[Token(Token = "0x20000DC")]
public class SubtitleDisplayer : MonoBehaviour
{
	// Token: 0x060005FD RID: 1533 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005FD")]
	[Address(RVA = "0x2E787C4", Offset = "0x2E787C4", VA = "0x2E787C4")]
	public void ChangePause()
	{
	}

	// Token: 0x060005FE RID: 1534 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005FE")]
	[Address(RVA = "0x2E787D4", Offset = "0x2E787D4", VA = "0x2E787D4")]
	private void OnDestroy()
	{
	}

	// Token: 0x060005FF RID: 1535 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005FF")]
	[Address(RVA = "0x2E78894", Offset = "0x2E78894", VA = "0x2E78894")]
	public IEnumerator Begin()
	{
		return null;
	}

	// Token: 0x06000600 RID: 1536 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000600")]
	[Address(RVA = "0x2E78930", Offset = "0x2E78930", VA = "0x2E78930")]
	public void PlayTextAsset(string path)
	{
	}

	// Token: 0x06000601 RID: 1537 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000601")]
	[Address(RVA = "0x2E78A60", Offset = "0x2E78A60", VA = "0x2E78A60")]
	private void OnLoadAssets(Asset request)
	{
	}

	// Token: 0x06000602 RID: 1538 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000602")]
	[Address(RVA = "0x2E78BA0", Offset = "0x2E78BA0", VA = "0x2E78BA0")]
	private IEnumerator FadeTextOut(TextMeshProUGUI text)
	{
		return null;
	}

	// Token: 0x06000603 RID: 1539 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000603")]
	[Address(RVA = "0x2E78C58", Offset = "0x2E78C58", VA = "0x2E78C58")]
	private IEnumerator FadeTextIn(TextMeshProUGUI text)
	{
		return null;
	}

	// Token: 0x06000604 RID: 1540 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000604")]
	[Address(RVA = "0x2E78D10", Offset = "0x2E78D10", VA = "0x2E78D10")]
	private IEnumerator Fade(TextMeshProUGUI text, Color toColor, Ease ease)
	{
		return null;
	}

	// Token: 0x06000605 RID: 1541 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000605")]
	[Address(RVA = "0x2E78DF8", Offset = "0x2E78DF8", VA = "0x2E78DF8")]
	public SubtitleDisplayer()
	{
	}

	// Token: 0x0400047F RID: 1151
	[Token(Token = "0x400047F")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI Text;

	// Token: 0x04000480 RID: 1152
	[Token(Token = "0x4000480")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI Text2;

	// Token: 0x04000481 RID: 1153
	[Token(Token = "0x4000481")]
	[FieldOffset(Offset = "0x28")]
	private TextAsset Subtitle;

	// Token: 0x04000482 RID: 1154
	[Token(Token = "0x4000482")]
	[FieldOffset(Offset = "0x30")]
	[Range(0f, 1f)]
	public float FadeTime;

	// Token: 0x04000483 RID: 1155
	[Token(Token = "0x4000483")]
	[FieldOffset(Offset = "0x34")]
	private bool _isPaused;

	// Token: 0x04000484 RID: 1156
	[Token(Token = "0x4000484")]
	[FieldOffset(Offset = "0x35")]
	private bool _isPausedTimeSet;

	// Token: 0x04000485 RID: 1157
	[Token(Token = "0x4000485")]
	[FieldOffset(Offset = "0x38")]
	private float _pausedTime;

	// Token: 0x04000486 RID: 1158
	[Token(Token = "0x4000486")]
	[FieldOffset(Offset = "0x40")]
	private Stack<Coroutine> myCoroutineStack;

	// Token: 0x04000487 RID: 1159
	[Token(Token = "0x4000487")]
	[FieldOffset(Offset = "0x48")]
	private Tweener tween;
}
