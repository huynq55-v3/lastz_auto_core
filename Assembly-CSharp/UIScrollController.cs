using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000141 RID: 321
[Token(Token = "0x2000141")]
public class UIScrollController : MonoBehaviour
{
	// Token: 0x1700014D RID: 333
	// (get) Token: 0x0600096D RID: 2413 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600096E RID: 2414 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700014D")]
	public Action<Vector2> OnValueChanged
	{
		[Token(Token = "0x600096D")]
		[Address(RVA = "0x33B266C", Offset = "0x33B266C", VA = "0x33B266C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600096E")]
		[Address(RVA = "0x33B2674", Offset = "0x33B2674", VA = "0x33B2674")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x1700014E RID: 334
	// (get) Token: 0x0600096F RID: 2415 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000970 RID: 2416 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700014E")]
	public Action<UIScrollItem> OnAddItem
	{
		[Token(Token = "0x600096F")]
		[Address(RVA = "0x33B267C", Offset = "0x33B267C", VA = "0x33B267C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000970")]
		[Address(RVA = "0x33B2684", Offset = "0x33B2684", VA = "0x33B2684")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x1700014F RID: 335
	// (get) Token: 0x06000971 RID: 2417 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000972 RID: 2418 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700014F")]
	public Action<UIScrollItem> OnRemoveItem
	{
		[Token(Token = "0x6000971")]
		[Address(RVA = "0x33B268C", Offset = "0x33B268C", VA = "0x33B268C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000972")]
		[Address(RVA = "0x33B2694", Offset = "0x33B2694", VA = "0x33B2694")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000150 RID: 336
	// (get) Token: 0x06000973 RID: 2419 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000974 RID: 2420 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000150")]
	public Action<UIScrollItem> OnDelItem
	{
		[Token(Token = "0x6000973")]
		[Address(RVA = "0x33B269C", Offset = "0x33B269C", VA = "0x33B269C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000974")]
		[Address(RVA = "0x33B26A4", Offset = "0x33B26A4", VA = "0x33B26A4")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000151 RID: 337
	// (get) Token: 0x06000975 RID: 2421 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000976 RID: 2422 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000151")]
	public Action<List<UIScrollItem>> OnInitItem
	{
		[Token(Token = "0x6000975")]
		[Address(RVA = "0x33B26AC", Offset = "0x33B26AC", VA = "0x33B26AC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000976")]
		[Address(RVA = "0x33B26B4", Offset = "0x33B26B4", VA = "0x33B26B4")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000152 RID: 338
	// (get) Token: 0x06000977 RID: 2423 RVA: 0x00004F98 File Offset: 0x00003198
	// (set) Token: 0x06000978 RID: 2424 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000152")]
	public int DataCount
	{
		[Token(Token = "0x6000977")]
		[Address(RVA = "0x33B26BC", Offset = "0x33B26BC", VA = "0x33B26BC")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000978")]
		[Address(RVA = "0x33B26C4", Offset = "0x33B26C4", VA = "0x33B26C4")]
		set
		{
		}
	}

	// Token: 0x06000979 RID: 2425 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000979")]
	[Address(RVA = "0x33B2788", Offset = "0x33B2788", VA = "0x33B2788")]
	private void Start()
	{
	}

	// Token: 0x0600097A RID: 2426 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600097A")]
	[Address(RVA = "0x33B2804", Offset = "0x33B2804", VA = "0x33B2804")]
	public void Init(int initCount, ScrollRect rect)
	{
	}

	// Token: 0x0600097B RID: 2427 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600097B")]
	[Address(RVA = "0x33B2CE0", Offset = "0x33B2CE0", VA = "0x33B2CE0")]
	public void RemoveScript()
	{
	}

	// Token: 0x0600097C RID: 2428 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600097C")]
	[Address(RVA = "0x33B29C8", Offset = "0x33B29C8", VA = "0x33B29C8")]
	public void OnValueChange(Vector2 pos)
	{
	}

	// Token: 0x0600097D RID: 2429 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600097D")]
	[Address(RVA = "0x33B320C", Offset = "0x33B320C", VA = "0x33B320C")]
	public UIScrollItem AddItem(int index)
	{
		return null;
	}

	// Token: 0x0600097E RID: 2430 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600097E")]
	[Address(RVA = "0x33B339C", Offset = "0x33B339C", VA = "0x33B339C")]
	public void DelItem(int index)
	{
	}

	// Token: 0x0600097F RID: 2431 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600097F")]
	[Address(RVA = "0x33B32F0", Offset = "0x33B32F0", VA = "0x33B32F0")]
	private UIScrollItem AddItemIntoPanel(int index)
	{
		return null;
	}

	// Token: 0x06000980 RID: 2432 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000980")]
	[Address(RVA = "0x33B3504", Offset = "0x33B3504", VA = "0x33B3504")]
	private void DelItemFromPanel(int index)
	{
	}

	// Token: 0x06000981 RID: 2433 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000981")]
	[Address(RVA = "0x33B2F60", Offset = "0x33B2F60", VA = "0x33B2F60")]
	private UIScrollItem CreateItem(int index)
	{
		return null;
	}

	// Token: 0x06000982 RID: 2434 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000982")]
	[Address(RVA = "0x33B2E14", Offset = "0x33B2E14", VA = "0x33B2E14")]
	private void RemoveItem(UIScrollItem item)
	{
	}

	// Token: 0x06000983 RID: 2435 RVA: 0x00004FB0 File Offset: 0x000031B0
	[Token(Token = "0x6000983")]
	[Address(RVA = "0x33B2D38", Offset = "0x33B2D38", VA = "0x33B2D38")]
	private int GetPosIndex()
	{
		return 0;
	}

	// Token: 0x06000984 RID: 2436 RVA: 0x00004FC8 File Offset: 0x000031C8
	[Token(Token = "0x6000984")]
	[Address(RVA = "0x33B37BC", Offset = "0x33B37BC", VA = "0x33B37BC")]
	public Vector3 GetPosition(int i)
	{
		return default(Vector3);
	}

	// Token: 0x06000985 RID: 2437 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000985")]
	[Address(RVA = "0x33B26CC", Offset = "0x33B26CC", VA = "0x33B26CC")]
	private void UpdateTotalWidth()
	{
	}

	// Token: 0x06000986 RID: 2438 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000986")]
	[Address(RVA = "0x33B3848", Offset = "0x33B3848", VA = "0x33B3848")]
	public UIScrollController()
	{
	}

	// Token: 0x04000706 RID: 1798
	[Token(Token = "0x4000706")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollController.Arrangement movement;

	// Token: 0x04000707 RID: 1799
	[Token(Token = "0x4000707")]
	[FieldOffset(Offset = "0x1C")]
	[Range(0f, 20f)]
	public float cellPadiding;

	// Token: 0x04000708 RID: 1800
	[Token(Token = "0x4000708")]
	[FieldOffset(Offset = "0x20")]
	public float cellWidth;

	// Token: 0x04000709 RID: 1801
	[Token(Token = "0x4000709")]
	[FieldOffset(Offset = "0x24")]
	public float cellHeight;

	// Token: 0x0400070A RID: 1802
	[Token(Token = "0x400070A")]
	[FieldOffset(Offset = "0x28")]
	[Range(0f, 20f)]
	public int viewCount;

	// Token: 0x0400070B RID: 1803
	[Token(Token = "0x400070B")]
	[FieldOffset(Offset = "0x30")]
	public GameObject itemPrefab;

	// Token: 0x0400070C RID: 1804
	[Token(Token = "0x400070C")]
	[FieldOffset(Offset = "0x38")]
	public RectTransform content;

	// Token: 0x0400070D RID: 1805
	[Token(Token = "0x400070D")]
	[FieldOffset(Offset = "0x40")]
	public int currentPosIndex;

	// Token: 0x0400070E RID: 1806
	[Token(Token = "0x400070E")]
	[FieldOffset(Offset = "0x44")]
	public float currentPosY;

	// Token: 0x0400070F RID: 1807
	[Token(Token = "0x400070F")]
	[FieldOffset(Offset = "0x48")]
	public float currentContentPosY;

	// Token: 0x04000710 RID: 1808
	[Token(Token = "0x4000710")]
	[FieldOffset(Offset = "0x4C")]
	public bool isUpwardScroll;

	// Token: 0x04000711 RID: 1809
	[Token(Token = "0x4000711")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 lastTimePos;

	// Token: 0x04000712 RID: 1810
	[Token(Token = "0x4000712")]
	[FieldOffset(Offset = "0x5C")]
	private int index;

	// Token: 0x04000713 RID: 1811
	[Token(Token = "0x4000713")]
	[FieldOffset(Offset = "0x60")]
	public List<UIScrollItem> itemList;

	// Token: 0x04000714 RID: 1812
	[Token(Token = "0x4000714")]
	[FieldOffset(Offset = "0x68")]
	public int dataCount;

	// Token: 0x04000715 RID: 1813
	[Token(Token = "0x4000715")]
	[FieldOffset(Offset = "0x70")]
	private Queue<UIScrollItem> unUsedQueue;

	// Token: 0x0400071B RID: 1819
	[Token(Token = "0x400071B")]
	[FieldOffset(Offset = "0xA0")]
	public bool test;

	// Token: 0x0400071C RID: 1820
	[Token(Token = "0x400071C")]
	[FieldOffset(Offset = "0xA4")]
	public int testCount;

	// Token: 0x02000142 RID: 322
	[Token(Token = "0x2000142")]
	public enum Arrangement
	{
		// Token: 0x0400071E RID: 1822
		[Token(Token = "0x400071E")]
		Horizontal,
		// Token: 0x0400071F RID: 1823
		[Token(Token = "0x400071F")]
		Vertical
	}
}
