using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000249 RID: 585
[Token(Token = "0x2000249")]
public class AnimationEffectTrigger : MonoBehaviour
{
	// Token: 0x06000FB1 RID: 4017 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FB1")]
	[Address(RVA = "0x1BE74B8", Offset = "0x1BE74B8", VA = "0x1BE74B8")]
	private void Awake()
	{
	}

	// Token: 0x06000FB2 RID: 4018 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FB2")]
	[Address(RVA = "0x1BE74DC", Offset = "0x1BE74DC", VA = "0x1BE74DC")]
	private GameObject GetOrCacheEffect(string path)
	{
		return null;
	}

	// Token: 0x06000FB3 RID: 4019 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FB3")]
	[Address(RVA = "0x1BE75FC", Offset = "0x1BE75FC", VA = "0x1BE75FC")]
	private string[] GetStringArray(string path)
	{
		return null;
	}

	// Token: 0x06000FB4 RID: 4020 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FB4")]
	[Address(RVA = "0x1BE7654", Offset = "0x1BE7654", VA = "0x1BE7654")]
	private void SetLoop(GameObject effect, bool onlyOnces = false)
	{
	}

	// Token: 0x06000FB5 RID: 4021 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FB5")]
	[Address(RVA = "0x1BE7748", Offset = "0x1BE7748", VA = "0x1BE7748")]
	private void OnPlayEffect(string path)
	{
	}

	// Token: 0x06000FB6 RID: 4022 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FB6")]
	[Address(RVA = "0x1BE7898", Offset = "0x1BE7898", VA = "0x1BE7898")]
	private IEnumerator DelayCall(GameObject obj)
	{
		return null;
	}

	// Token: 0x06000FB7 RID: 4023 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FB7")]
	[Address(RVA = "0x1BE7934", Offset = "0x1BE7934", VA = "0x1BE7934")]
	private void OnPlayEffectNoLoop(string path)
	{
	}

	// Token: 0x06000FB8 RID: 4024 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FB8")]
	[Address(RVA = "0x1BE79D8", Offset = "0x1BE79D8", VA = "0x1BE79D8")]
	private void OnPlayEffectLoop(string path)
	{
	}

	// Token: 0x06000FB9 RID: 4025 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FB9")]
	[Address(RVA = "0x1BE7A7C", Offset = "0x1BE7A7C", VA = "0x1BE7A7C")]
	private void OnPauseEffect(string path)
	{
	}

	// Token: 0x06000FBA RID: 4026 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FBA")]
	[Address(RVA = "0x1BE7B10", Offset = "0x1BE7B10", VA = "0x1BE7B10")]
	private void OnPlayMaterial(string aniName)
	{
	}

	// Token: 0x06000FBB RID: 4027 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FBB")]
	[Address(RVA = "0x1BE7BA4", Offset = "0x1BE7BA4", VA = "0x1BE7BA4")]
	private void OnEndMaterial()
	{
	}

	// Token: 0x06000FBC RID: 4028 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FBC")]
	[Address(RVA = "0x1BE7BA8", Offset = "0x1BE7BA8", VA = "0x1BE7BA8")]
	public AnimationEffectTrigger()
	{
	}

	// Token: 0x0400123B RID: 4667
	[Token(Token = "0x400123B")]
	[FieldOffset(Offset = "0x18")]
	private Transform tran;

	// Token: 0x0400123C RID: 4668
	[Token(Token = "0x400123C")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<string, GameObject> effectDic;

	// Token: 0x0400123D RID: 4669
	[Token(Token = "0x400123D")]
	[FieldOffset(Offset = "0x28")]
	public Animation ani;
}
