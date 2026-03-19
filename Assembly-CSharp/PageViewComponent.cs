using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000113 RID: 275
[Token(Token = "0x2000113")]
public class PageViewComponent : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler
{
	// Token: 0x060007C1 RID: 1985 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C1")]
	[Address(RVA = "0x347C334", Offset = "0x347C334", VA = "0x347C334")]
	public void Refresh(Action<int> onUpdate)
	{
	}

	// Token: 0x060007C2 RID: 1986 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C2")]
	[Address(RVA = "0x347C63C", Offset = "0x347C63C", VA = "0x347C63C")]
	public void RefreshByCell(Action<int> OnUpdate)
	{
	}

	// Token: 0x060007C3 RID: 1987 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C3")]
	[Address(RVA = "0x347CA18", Offset = "0x347CA18", VA = "0x347CA18")]
	private void Update()
	{
	}

	// Token: 0x060007C4 RID: 1988 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C4")]
	[Address(RVA = "0x347CABC", Offset = "0x347CABC", VA = "0x347CABC")]
	private void OnDestroy()
	{
	}

	// Token: 0x060007C5 RID: 1989 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C5")]
	[Address(RVA = "0x347CAC8", Offset = "0x347CAC8", VA = "0x347CAC8")]
	public void pageTo(int index)
	{
	}

	// Token: 0x060007C6 RID: 1990 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C6")]
	[Address(RVA = "0x347CB88", Offset = "0x347CB88", VA = "0x347CB88")]
	private void SetPageIndex(int index)
	{
	}

	// Token: 0x060007C7 RID: 1991 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C7")]
	[Address(RVA = "0x347CBB4", Offset = "0x347CBB4", VA = "0x347CBB4", Slot = "4")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	// Token: 0x060007C8 RID: 1992 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C8")]
	[Address(RVA = "0x347CBE4", Offset = "0x347CBE4", VA = "0x347CBE4", Slot = "5")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	// Token: 0x060007C9 RID: 1993 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C9")]
	[Address(RVA = "0x347CE04", Offset = "0x347CE04", VA = "0x347CE04")]
	public PageViewComponent()
	{
	}

	// Token: 0x040005AC RID: 1452
	[Token(Token = "0x40005AC")]
	[FieldOffset(Offset = "0x18")]
	private ScrollRect rect;

	// Token: 0x040005AD RID: 1453
	[Token(Token = "0x40005AD")]
	[FieldOffset(Offset = "0x20")]
	private float targethorizontal;

	// Token: 0x040005AE RID: 1454
	[Token(Token = "0x40005AE")]
	[FieldOffset(Offset = "0x24")]
	private bool isDrag;

	// Token: 0x040005AF RID: 1455
	[Token(Token = "0x40005AF")]
	[FieldOffset(Offset = "0x28")]
	private List<float> posList;

	// Token: 0x040005B0 RID: 1456
	[Token(Token = "0x40005B0")]
	[FieldOffset(Offset = "0x30")]
	private int currentPageIndex;

	// Token: 0x040005B1 RID: 1457
	[Token(Token = "0x40005B1")]
	[FieldOffset(Offset = "0x38")]
	public Action<int> onPageChanged;

	// Token: 0x040005B2 RID: 1458
	[Token(Token = "0x40005B2")]
	[FieldOffset(Offset = "0x40")]
	public RectTransform item;

	// Token: 0x040005B3 RID: 1459
	[Token(Token = "0x40005B3")]
	[FieldOffset(Offset = "0x48")]
	public RectTransform Content;

	// Token: 0x040005B4 RID: 1460
	[Token(Token = "0x40005B4")]
	[FieldOffset(Offset = "0x50")]
	private bool stopMove;

	// Token: 0x040005B5 RID: 1461
	[Token(Token = "0x40005B5")]
	[FieldOffset(Offset = "0x54")]
	public float smooting;

	// Token: 0x040005B6 RID: 1462
	[Token(Token = "0x40005B6")]
	[FieldOffset(Offset = "0x58")]
	public float sensitivity;

	// Token: 0x040005B7 RID: 1463
	[Token(Token = "0x40005B7")]
	[FieldOffset(Offset = "0x5C")]
	private float startTime;

	// Token: 0x040005B8 RID: 1464
	[Token(Token = "0x40005B8")]
	[FieldOffset(Offset = "0x60")]
	public bool _forceOneByOne;

	// Token: 0x040005B9 RID: 1465
	[Token(Token = "0x40005B9")]
	[FieldOffset(Offset = "0x61")]
	public bool _emptyEnds;

	// Token: 0x040005BA RID: 1466
	[Token(Token = "0x40005BA")]
	[FieldOffset(Offset = "0x64")]
	private float startDragHorizontal;
}
