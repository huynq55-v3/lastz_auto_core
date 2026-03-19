using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000144 RID: 324
[Token(Token = "0x2000144")]
[RequireComponent(typeof(Image))]
public class UISpriteAnimation : MonoBehaviour
{
	// Token: 0x17000155 RID: 341
	// (get) Token: 0x0600098E RID: 2446 RVA: 0x00004FF8 File Offset: 0x000031F8
	[Token(Token = "0x17000155")]
	public int FrameCount
	{
		[Token(Token = "0x600098E")]
		[Address(RVA = "0x33B3934", Offset = "0x33B3934", VA = "0x33B3934")]
		get
		{
			return 0;
		}
	}

	// Token: 0x0600098F RID: 2447 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600098F")]
	[Address(RVA = "0x33B397C", Offset = "0x33B397C", VA = "0x33B397C")]
	private void Awake()
	{
	}

	// Token: 0x06000990 RID: 2448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000990")]
	[Address(RVA = "0x33B39D4", Offset = "0x33B39D4", VA = "0x33B39D4")]
	private void Start()
	{
	}

	// Token: 0x06000991 RID: 2449 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000991")]
	[Address(RVA = "0x33B39FC", Offset = "0x33B39FC", VA = "0x33B39FC")]
	private void SetSprite(int idx)
	{
	}

	// Token: 0x06000992 RID: 2450 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000992")]
	[Address(RVA = "0x33B39F0", Offset = "0x33B39F0", VA = "0x33B39F0")]
	public void Play()
	{
	}

	// Token: 0x06000993 RID: 2451 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000993")]
	[Address(RVA = "0x33B3A6C", Offset = "0x33B3A6C", VA = "0x33B3A6C")]
	public void PlayReverse()
	{
	}

	// Token: 0x06000994 RID: 2452 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000994")]
	[Address(RVA = "0x33B3A78", Offset = "0x33B3A78", VA = "0x33B3A78")]
	private void Update()
	{
	}

	// Token: 0x06000995 RID: 2453 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000995")]
	[Address(RVA = "0x33B3B44", Offset = "0x33B3B44", VA = "0x33B3B44")]
	public void Pause()
	{
	}

	// Token: 0x06000996 RID: 2454 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000996")]
	[Address(RVA = "0x33B3B4C", Offset = "0x33B3B4C", VA = "0x33B3B4C")]
	public void Resume()
	{
	}

	// Token: 0x06000997 RID: 2455 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000997")]
	[Address(RVA = "0x33B3B64", Offset = "0x33B3B64", VA = "0x33B3B64")]
	public void Stop()
	{
	}

	// Token: 0x06000998 RID: 2456 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000998")]
	[Address(RVA = "0x33B3B84", Offset = "0x33B3B84", VA = "0x33B3B84")]
	public void Rewind()
	{
	}

	// Token: 0x06000999 RID: 2457 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000999")]
	[Address(RVA = "0x33B3BA8", Offset = "0x33B3BA8", VA = "0x33B3BA8")]
	public UISpriteAnimation()
	{
	}

	// Token: 0x04000724 RID: 1828
	[Token(Token = "0x4000724")]
	[FieldOffset(Offset = "0x18")]
	private Image ImageSource;

	// Token: 0x04000725 RID: 1829
	[Token(Token = "0x4000725")]
	[FieldOffset(Offset = "0x20")]
	private int mCurFrame;

	// Token: 0x04000726 RID: 1830
	[Token(Token = "0x4000726")]
	[FieldOffset(Offset = "0x24")]
	private float mDelta;

	// Token: 0x04000727 RID: 1831
	[Token(Token = "0x4000727")]
	[FieldOffset(Offset = "0x28")]
	public float FPS;

	// Token: 0x04000728 RID: 1832
	[Token(Token = "0x4000728")]
	[FieldOffset(Offset = "0x30")]
	public List<Sprite> SpriteFrames;

	// Token: 0x04000729 RID: 1833
	[Token(Token = "0x4000729")]
	[FieldOffset(Offset = "0x38")]
	public bool IsPlaying;

	// Token: 0x0400072A RID: 1834
	[Token(Token = "0x400072A")]
	[FieldOffset(Offset = "0x39")]
	public bool Foward;

	// Token: 0x0400072B RID: 1835
	[Token(Token = "0x400072B")]
	[FieldOffset(Offset = "0x3A")]
	public bool AutoPlay;

	// Token: 0x0400072C RID: 1836
	[Token(Token = "0x400072C")]
	[FieldOffset(Offset = "0x3B")]
	public bool Loop;
}
