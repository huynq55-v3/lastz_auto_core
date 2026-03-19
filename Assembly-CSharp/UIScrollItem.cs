using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000143 RID: 323
[Token(Token = "0x2000143")]
public class UIScrollItem : MonoBehaviour
{
	// Token: 0x06000987 RID: 2439 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000987")]
	[Address(RVA = "0x33B3870", Offset = "0x33B3870", VA = "0x33B3870")]
	private void Awake()
	{
	}

	// Token: 0x06000988 RID: 2440 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000988")]
	[Address(RVA = "0x33B3874", Offset = "0x33B3874", VA = "0x33B3874")]
	private void Start()
	{
	}

	// Token: 0x17000153 RID: 339
	// (get) Token: 0x06000989 RID: 2441 RVA: 0x00004FE0 File Offset: 0x000031E0
	// (set) Token: 0x0600098A RID: 2442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000153")]
	public int Index
	{
		[Token(Token = "0x6000989")]
		[Address(RVA = "0x33B3878", Offset = "0x33B3878", VA = "0x33B3878")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600098A")]
		[Address(RVA = "0x33B36E0", Offset = "0x33B36E0", VA = "0x33B36E0")]
		set
		{
		}
	}

	// Token: 0x17000154 RID: 340
	// (set) Token: 0x0600098B RID: 2443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000154")]
	public UIScrollController Scroller
	{
		[Token(Token = "0x600098B")]
		[Address(RVA = "0x33B3880", Offset = "0x33B3880", VA = "0x33B3880")]
		set
		{
		}
	}

	// Token: 0x0600098C RID: 2444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600098C")]
	[Address(RVA = "0x33B3888", Offset = "0x33B3888", VA = "0x33B3888")]
	public void RefreshItem()
	{
	}

	// Token: 0x0600098D RID: 2445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600098D")]
	[Address(RVA = "0x33B3924", Offset = "0x33B3924", VA = "0x33B3924")]
	public UIScrollItem()
	{
	}

	// Token: 0x04000720 RID: 1824
	[Token(Token = "0x4000720")]
	[FieldOffset(Offset = "0x18")]
	public Text indexTxt;

	// Token: 0x04000721 RID: 1825
	[Token(Token = "0x4000721")]
	[FieldOffset(Offset = "0x20")]
	private UIScrollController scroller;

	// Token: 0x04000722 RID: 1826
	[Token(Token = "0x4000722")]
	[FieldOffset(Offset = "0x28")]
	public int index;

	// Token: 0x04000723 RID: 1827
	[Token(Token = "0x4000723")]
	[FieldOffset(Offset = "0x2C")]
	public int oldIndex;
}
