using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000114 RID: 276
[Token(Token = "0x2000114")]
public class ScrollControl : MonoBehaviour
{
	// Token: 0x060007CA RID: 1994 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007CA")]
	[Address(RVA = "0x347CEA4", Offset = "0x347CEA4", VA = "0x347CEA4")]
	private void Awake()
	{
	}

	// Token: 0x17000100 RID: 256
	// (get) Token: 0x060007CB RID: 1995 RVA: 0x00004758 File Offset: 0x00002958
	[Token(Token = "0x17000100")]
	public int AllNum
	{
		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x347CF0C", Offset = "0x347CF0C", VA = "0x347CF0C")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000101 RID: 257
	// (get) Token: 0x060007CC RID: 1996 RVA: 0x00004770 File Offset: 0x00002970
	[Token(Token = "0x17000101")]
	public int CurPage
	{
		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x347CF14", Offset = "0x347CF14", VA = "0x347CF14")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060007CD RID: 1997 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007CD")]
	[Address(RVA = "0x347CF1C", Offset = "0x347CF1C", VA = "0x347CF1C")]
	public void Refresh()
	{
	}

	// Token: 0x060007CE RID: 1998 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007CE")]
	[Address(RVA = "0x347D478", Offset = "0x347D478", VA = "0x347D478")]
	private void OnPointerDown(Vector2 mousePosition)
	{
	}

	// Token: 0x060007CF RID: 1999 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007CF")]
	[Address(RVA = "0x347D4BC", Offset = "0x347D4BC", VA = "0x347D4BC")]
	private void OnDrag(Vector2 mousePosition)
	{
	}

	// Token: 0x060007D0 RID: 2000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007D0")]
	[Address(RVA = "0x347D62C", Offset = "0x347D62C", VA = "0x347D62C")]
	private void OnPointerUp(Vector2 mousePosition)
	{
	}

	// Token: 0x060007D1 RID: 2001 RVA: 0x00004788 File Offset: 0x00002988
	[Token(Token = "0x60007D1")]
	[Address(RVA = "0x347D1BC", Offset = "0x347D1BC", VA = "0x347D1BC")]
	private int GetCurrentIndex()
	{
		return 0;
	}

	// Token: 0x060007D2 RID: 2002 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007D2")]
	[Address(RVA = "0x347D33C", Offset = "0x347D33C", VA = "0x347D33C")]
	private ScrollRect GetTransformByIndex(int index)
	{
		return null;
	}

	// Token: 0x060007D3 RID: 2003 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007D3")]
	[Address(RVA = "0x347D52C", Offset = "0x347D52C", VA = "0x347D52C")]
	private void DragScreen(Vector2 pDragVector)
	{
	}

	// Token: 0x060007D4 RID: 2004 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007D4")]
	[Address(RVA = "0x347D6A8", Offset = "0x347D6A8", VA = "0x347D6A8")]
	private void Start()
	{
	}

	// Token: 0x060007D5 RID: 2005 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007D5")]
	[Address(RVA = "0x347D7E4", Offset = "0x347D7E4", VA = "0x347D7E4")]
	private void OnDestory()
	{
	}

	// Token: 0x060007D6 RID: 2006 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007D6")]
	[Address(RVA = "0x347D920", Offset = "0x347D920", VA = "0x347D920")]
	private void Update()
	{
	}

	// Token: 0x060007D7 RID: 2007 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007D7")]
	[Address(RVA = "0x347D9F0", Offset = "0x347D9F0", VA = "0x347D9F0")]
	public ScrollControl()
	{
	}

	// Token: 0x040005BB RID: 1467
	[Token(Token = "0x40005BB")]
	[FieldOffset(Offset = "0x18")]
	private bool mNeedCaculate;

	// Token: 0x040005BC RID: 1468
	[Token(Token = "0x40005BC")]
	[FieldOffset(Offset = "0x19")]
	private bool mIsScollV;

	// Token: 0x040005BD RID: 1469
	[Token(Token = "0x40005BD")]
	[FieldOffset(Offset = "0x1C")]
	public float m_Sensitive;

	// Token: 0x040005BE RID: 1470
	[Token(Token = "0x40005BE")]
	[FieldOffset(Offset = "0x20")]
	private ScrollRect rect;

	// Token: 0x040005BF RID: 1471
	[Token(Token = "0x40005BF")]
	[FieldOffset(Offset = "0x28")]
	private List<float> posList;

	// Token: 0x040005C0 RID: 1472
	[Token(Token = "0x40005C0")]
	[FieldOffset(Offset = "0x30")]
	private float m_HorizontalLength;

	// Token: 0x040005C1 RID: 1473
	[Token(Token = "0x40005C1")]
	[FieldOffset(Offset = "0x34")]
	private float mPageWidth;

	// Token: 0x040005C2 RID: 1474
	[Token(Token = "0x40005C2")]
	[FieldOffset(Offset = "0x38")]
	private ScrollRect m_CurTransform;

	// Token: 0x040005C3 RID: 1475
	[Token(Token = "0x40005C3")]
	[FieldOffset(Offset = "0x40")]
	private float targethorizontal;

	// Token: 0x040005C4 RID: 1476
	[Token(Token = "0x40005C4")]
	[FieldOffset(Offset = "0x44")]
	private bool isDrag;

	// Token: 0x040005C5 RID: 1477
	[Token(Token = "0x40005C5")]
	[FieldOffset(Offset = "0x45")]
	private bool stopMove;

	// Token: 0x040005C6 RID: 1478
	[Token(Token = "0x40005C6")]
	[FieldOffset(Offset = "0x48")]
	public float smooting;

	// Token: 0x040005C7 RID: 1479
	[Token(Token = "0x40005C7")]
	[FieldOffset(Offset = "0x4C")]
	private int m_Num;

	// Token: 0x040005C8 RID: 1480
	[Token(Token = "0x40005C8")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 mOldPosition;

	// Token: 0x040005C9 RID: 1481
	[Token(Token = "0x40005C9")]
	[FieldOffset(Offset = "0x5C")]
	private float startTime;

	// Token: 0x040005CA RID: 1482
	[Token(Token = "0x40005CA")]
	[FieldOffset(Offset = "0x60")]
	private float startDragHorizontal;

	// Token: 0x040005CB RID: 1483
	[Token(Token = "0x40005CB")]
	[FieldOffset(Offset = "0x64")]
	private int m_CurPage;

	// Token: 0x040005CC RID: 1484
	[Token(Token = "0x40005CC")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private InputControl inputControl;

	// Token: 0x040005CD RID: 1485
	[Token(Token = "0x40005CD")]
	[FieldOffset(Offset = "0x70")]
	private Dictionary<int, ScrollRect> catchScrollRect;
}
