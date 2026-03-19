using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000081 RID: 129
[Token(Token = "0x2000081")]
public class CameraAniHandler : MonoBehaviour
{
	// Token: 0x06000314 RID: 788 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000314")]
	[Address(RVA = "0x32104D8", Offset = "0x32104D8", VA = "0x32104D8")]
	private void Awake()
	{
	}

	// Token: 0x06000315 RID: 789 RVA: 0x00003048 File Offset: 0x00001248
	[Token(Token = "0x6000315")]
	[Address(RVA = "0x3210530", Offset = "0x3210530", VA = "0x3210530")]
	public bool Enter(string clipName, Transform reference, Action<bool> callback)
	{
		return default(bool);
	}

	// Token: 0x06000316 RID: 790 RVA: 0x00003060 File Offset: 0x00001260
	[Token(Token = "0x6000316")]
	[Address(RVA = "0x32107A8", Offset = "0x32107A8", VA = "0x32107A8")]
	public bool Exit(Transform reference, Action<bool> callback)
	{
		return default(bool);
	}

	// Token: 0x06000317 RID: 791 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000317")]
	[Address(RVA = "0x3210734", Offset = "0x3210734", VA = "0x3210734")]
	private IEnumerator ApplyAnimation()
	{
		return null;
	}

	// Token: 0x06000318 RID: 792 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000318")]
	[Address(RVA = "0x3210868", Offset = "0x3210868", VA = "0x3210868")]
	private IEnumerator RecoverAnimation()
	{
		return null;
	}

	// Token: 0x06000319 RID: 793 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000319")]
	[Address(RVA = "0x321092C", Offset = "0x321092C", VA = "0x321092C")]
	private void SampleOnce(AnimationClip clip, float time)
	{
	}

	// Token: 0x0600031A RID: 794 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600031A")]
	[Address(RVA = "0x32106AC", Offset = "0x32106AC", VA = "0x32106AC")]
	private AnimationClip GetClipByName(string clipName)
	{
		return null;
	}

	// Token: 0x0600031B RID: 795 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600031B")]
	[Address(RVA = "0x3210C80", Offset = "0x3210C80", VA = "0x3210C80")]
	public CameraAniHandler()
	{
	}

	// Token: 0x0400029E RID: 670
	[Token(Token = "0x400029E")]
	[FieldOffset(Offset = "0x18")]
	public bool pauseAtFirstFrame;

	// Token: 0x0400029F RID: 671
	[Token(Token = "0x400029F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AnimationClip[] ClipList;

	// Token: 0x040002A0 RID: 672
	[Token(Token = "0x40002A0")]
	[FieldOffset(Offset = "0x28")]
	private Camera camera;

	// Token: 0x040002A1 RID: 673
	[Token(Token = "0x40002A1")]
	[FieldOffset(Offset = "0x30")]
	private Coroutine _coroutine;

	// Token: 0x040002A2 RID: 674
	[Token(Token = "0x40002A2")]
	[FieldOffset(Offset = "0x38")]
	private AnimationClip _curClip;

	// Token: 0x040002A3 RID: 675
	[Token(Token = "0x40002A3")]
	[FieldOffset(Offset = "0x40")]
	private Transform _reference;

	// Token: 0x040002A4 RID: 676
	[Token(Token = "0x40002A4")]
	[FieldOffset(Offset = "0x48")]
	private Action<bool> _callback;

	// Token: 0x040002A5 RID: 677
	[Token(Token = "0x40002A5")]
	[FieldOffset(Offset = "0x50")]
	private CameraAniHandler.State _curState;

	// Token: 0x040002A6 RID: 678
	[Token(Token = "0x40002A6")]
	[FieldOffset(Offset = "0x54")]
	private Matrix4x4 originMatrix;

	// Token: 0x040002A7 RID: 679
	[Token(Token = "0x40002A7")]
	[FieldOffset(Offset = "0x94")]
	private float timeCounter;

	// Token: 0x02000082 RID: 130
	[Token(Token = "0x2000082")]
	private enum State
	{
		// Token: 0x040002A9 RID: 681
		[Token(Token = "0x40002A9")]
		Idle,
		// Token: 0x040002AA RID: 682
		[Token(Token = "0x40002AA")]
		Apply,
		// Token: 0x040002AB RID: 683
		[Token(Token = "0x40002AB")]
		Recover
	}
}
