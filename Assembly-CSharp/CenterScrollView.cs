using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020000E4 RID: 228
[Token(Token = "0x20000E4")]
[AddComponentMenu("UI/CenterScrollView", 51)]
[DisallowMultipleComponent]
[RequireComponent(typeof(RectTransform))]
public class CenterScrollView : UIBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup, ILayoutController, IPointerDownHandler
{
	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x0600062E RID: 1582 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000B8")]
	private static Transform ObjectPoolRoot
	{
		[Token(Token = "0x600062E")]
		[Address(RVA = "0x2E7A1B4", Offset = "0x2E7A1B4", VA = "0x2E7A1B4")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600062F RID: 1583 RVA: 0x00003E40 File Offset: 0x00002040
	[Token(Token = "0x600062F")]
	[Address(RVA = "0x2E7A2F0", Offset = "0x2E7A2F0", VA = "0x2E7A2F0")]
	public float GetPreferredWidth(RectTransform item)
	{
		return 0f;
	}

	// Token: 0x06000630 RID: 1584 RVA: 0x00003E58 File Offset: 0x00002058
	[Token(Token = "0x6000630")]
	[Address(RVA = "0x2E7A3D4", Offset = "0x2E7A3D4", VA = "0x2E7A3D4")]
	public float GetPreferredHeight(RectTransform item)
	{
		return 0f;
	}

	// Token: 0x06000631 RID: 1585 RVA: 0x00003E70 File Offset: 0x00002070
	[Token(Token = "0x6000631")]
	[Address(RVA = "0x2E7A4BC", Offset = "0x2E7A4BC", VA = "0x2E7A4BC")]
	protected float GetSize(RectTransform item)
	{
		return 0f;
	}

	// Token: 0x06000632 RID: 1586 RVA: 0x00003E88 File Offset: 0x00002088
	[Token(Token = "0x6000632")]
	[Address(RVA = "0x2E7A6EC", Offset = "0x2E7A6EC", VA = "0x2E7A6EC")]
	protected float GetDimension(Vector2 vector)
	{
		return 0f;
	}

	// Token: 0x06000633 RID: 1587 RVA: 0x00003EA0 File Offset: 0x000020A0
	[Token(Token = "0x6000633")]
	[Address(RVA = "0x2E7A700", Offset = "0x2E7A700", VA = "0x2E7A700")]
	protected Vector2 GetVector(float value)
	{
		return default(Vector2);
	}

	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x06000634 RID: 1588 RVA: 0x00003EB8 File Offset: 0x000020B8
	[Token(Token = "0x170000B9")]
	protected float contentSpacing
	{
		[Token(Token = "0x6000634")]
		[Address(RVA = "0x2E7A58C", Offset = "0x2E7A58C", VA = "0x2E7A58C")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000BA RID: 186
	// (get) Token: 0x06000635 RID: 1589 RVA: 0x00003ED0 File Offset: 0x000020D0
	[Token(Token = "0x170000BA")]
	protected int contentConstraintCount
	{
		[Token(Token = "0x6000635")]
		[Address(RVA = "0x2E7A71C", Offset = "0x2E7A71C", VA = "0x2E7A71C")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000BB RID: 187
	// (get) Token: 0x06000636 RID: 1590 RVA: 0x00003EE8 File Offset: 0x000020E8
	[Token(Token = "0x170000BB")]
	private int StartLine
	{
		[Token(Token = "0x6000636")]
		[Address(RVA = "0x2E7A848", Offset = "0x2E7A848", VA = "0x2E7A848")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000BC RID: 188
	// (get) Token: 0x06000637 RID: 1591 RVA: 0x00003F00 File Offset: 0x00002100
	[Token(Token = "0x170000BC")]
	private int CurrentLines
	{
		[Token(Token = "0x6000637")]
		[Address(RVA = "0x2E7A8C4", Offset = "0x2E7A8C4", VA = "0x2E7A8C4")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000BD RID: 189
	// (get) Token: 0x06000638 RID: 1592 RVA: 0x00003F18 File Offset: 0x00002118
	[Token(Token = "0x170000BD")]
	private int TotalLines
	{
		[Token(Token = "0x6000638")]
		[Address(RVA = "0x2E7A94C", Offset = "0x2E7A94C", VA = "0x2E7A94C")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06000639 RID: 1593 RVA: 0x00003F30 File Offset: 0x00002130
	[Token(Token = "0x6000639")]
	[Address(RVA = "0x2E7A9C8", Offset = "0x2E7A9C8", VA = "0x2E7A9C8", Slot = "39")]
	protected virtual bool UpdateItems(Bounds viewBounds, Bounds contentBounds)
	{
		return default(bool);
	}

	// Token: 0x170000BE RID: 190
	// (get) Token: 0x0600063A RID: 1594 RVA: 0x00003F48 File Offset: 0x00002148
	[Token(Token = "0x170000BE")]
	public CenterScrollView.ScrollViewLayoutType LayoutType
	{
		[Token(Token = "0x600063A")]
		[Address(RVA = "0x2E7B6B8", Offset = "0x2E7B6B8", VA = "0x2E7B6B8")]
		get
		{
			return CenterScrollView.ScrollViewLayoutType.Horizontal;
		}
	}

	// Token: 0x170000BF RID: 191
	// (get) Token: 0x0600063B RID: 1595 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600063C RID: 1596 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000BF")]
	public RectTransform content
	{
		[Token(Token = "0x600063B")]
		[Address(RVA = "0x2E7B6C0", Offset = "0x2E7B6C0", VA = "0x2E7B6C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600063C")]
		[Address(RVA = "0x2E7B6C8", Offset = "0x2E7B6C8", VA = "0x2E7B6C8")]
		set
		{
		}
	}

	// Token: 0x170000C0 RID: 192
	// (get) Token: 0x0600063D RID: 1597 RVA: 0x00003F60 File Offset: 0x00002160
	// (set) Token: 0x0600063E RID: 1598 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000C0")]
	public CenterScrollView.MovementType movementType
	{
		[Token(Token = "0x600063D")]
		[Address(RVA = "0x2E7B6D0", Offset = "0x2E7B6D0", VA = "0x2E7B6D0")]
		get
		{
			return CenterScrollView.MovementType.Unrestricted;
		}
		[Token(Token = "0x600063E")]
		[Address(RVA = "0x2E7B6D8", Offset = "0x2E7B6D8", VA = "0x2E7B6D8")]
		set
		{
		}
	}

	// Token: 0x170000C1 RID: 193
	// (get) Token: 0x0600063F RID: 1599 RVA: 0x00003F78 File Offset: 0x00002178
	// (set) Token: 0x06000640 RID: 1600 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000C1")]
	public float elasticity
	{
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x2E7B6E0", Offset = "0x2E7B6E0", VA = "0x2E7B6E0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000640")]
		[Address(RVA = "0x2E7B6E8", Offset = "0x2E7B6E8", VA = "0x2E7B6E8")]
		set
		{
		}
	}

	// Token: 0x170000C2 RID: 194
	// (get) Token: 0x06000641 RID: 1601 RVA: 0x00003F90 File Offset: 0x00002190
	// (set) Token: 0x06000642 RID: 1602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000C2")]
	public bool inertia
	{
		[Token(Token = "0x6000641")]
		[Address(RVA = "0x2E7B6F0", Offset = "0x2E7B6F0", VA = "0x2E7B6F0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000642")]
		[Address(RVA = "0x2E7B6F8", Offset = "0x2E7B6F8", VA = "0x2E7B6F8")]
		set
		{
		}
	}

	// Token: 0x170000C3 RID: 195
	// (get) Token: 0x06000643 RID: 1603 RVA: 0x00003FA8 File Offset: 0x000021A8
	// (set) Token: 0x06000644 RID: 1604 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000C3")]
	public float decelerationRate
	{
		[Token(Token = "0x6000643")]
		[Address(RVA = "0x2E7B704", Offset = "0x2E7B704", VA = "0x2E7B704")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000644")]
		[Address(RVA = "0x2E7B70C", Offset = "0x2E7B70C", VA = "0x2E7B70C")]
		set
		{
		}
	}

	// Token: 0x170000C4 RID: 196
	// (get) Token: 0x06000645 RID: 1605 RVA: 0x00003FC0 File Offset: 0x000021C0
	// (set) Token: 0x06000646 RID: 1606 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000C4")]
	public float scrollSensitivity
	{
		[Token(Token = "0x6000645")]
		[Address(RVA = "0x2E7B714", Offset = "0x2E7B714", VA = "0x2E7B714")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000646")]
		[Address(RVA = "0x2E7B71C", Offset = "0x2E7B71C", VA = "0x2E7B71C")]
		set
		{
		}
	}

	// Token: 0x170000C5 RID: 197
	// (get) Token: 0x06000647 RID: 1607 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000648 RID: 1608 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000C5")]
	public RectTransform viewport
	{
		[Token(Token = "0x6000647")]
		[Address(RVA = "0x2E7B724", Offset = "0x2E7B724", VA = "0x2E7B724")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000648")]
		[Address(RVA = "0x2E7B72C", Offset = "0x2E7B72C", VA = "0x2E7B72C")]
		set
		{
		}
	}

	// Token: 0x170000C6 RID: 198
	// (get) Token: 0x06000649 RID: 1609 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600064A RID: 1610 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000C6")]
	public Scrollbar horizontalScrollbar
	{
		[Token(Token = "0x6000649")]
		[Address(RVA = "0x2E7B800", Offset = "0x2E7B800", VA = "0x2E7B800")]
		get
		{
			return null;
		}
		[Token(Token = "0x600064A")]
		[Address(RVA = "0x2E7B808", Offset = "0x2E7B808", VA = "0x2E7B808")]
		set
		{
		}
	}

	// Token: 0x170000C7 RID: 199
	// (get) Token: 0x0600064B RID: 1611 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600064C RID: 1612 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000C7")]
	public Scrollbar verticalScrollbar
	{
		[Token(Token = "0x600064B")]
		[Address(RVA = "0x2E7B998", Offset = "0x2E7B998", VA = "0x2E7B998")]
		get
		{
			return null;
		}
		[Token(Token = "0x600064C")]
		[Address(RVA = "0x2E7B9A0", Offset = "0x2E7B9A0", VA = "0x2E7B9A0")]
		set
		{
		}
	}

	// Token: 0x170000C8 RID: 200
	// (get) Token: 0x0600064D RID: 1613 RVA: 0x00003FD8 File Offset: 0x000021D8
	// (set) Token: 0x0600064E RID: 1614 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000C8")]
	public CenterScrollView.ScrollbarVisibility horizontalScrollbarVisibility
	{
		[Token(Token = "0x600064D")]
		[Address(RVA = "0x2E7BB30", Offset = "0x2E7BB30", VA = "0x2E7BB30")]
		get
		{
			return CenterScrollView.ScrollbarVisibility.Permanent;
		}
		[Token(Token = "0x600064E")]
		[Address(RVA = "0x2E7BB38", Offset = "0x2E7BB38", VA = "0x2E7BB38")]
		set
		{
		}
	}

	// Token: 0x170000C9 RID: 201
	// (get) Token: 0x0600064F RID: 1615 RVA: 0x00003FF0 File Offset: 0x000021F0
	// (set) Token: 0x06000650 RID: 1616 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000C9")]
	public CenterScrollView.ScrollbarVisibility verticalScrollbarVisibility
	{
		[Token(Token = "0x600064F")]
		[Address(RVA = "0x2E7BB40", Offset = "0x2E7BB40", VA = "0x2E7BB40")]
		get
		{
			return CenterScrollView.ScrollbarVisibility.Permanent;
		}
		[Token(Token = "0x6000650")]
		[Address(RVA = "0x2E7BB48", Offset = "0x2E7BB48", VA = "0x2E7BB48")]
		set
		{
		}
	}

	// Token: 0x170000CA RID: 202
	// (get) Token: 0x06000651 RID: 1617 RVA: 0x00004008 File Offset: 0x00002208
	// (set) Token: 0x06000652 RID: 1618 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000CA")]
	public float horizontalScrollbarSpacing
	{
		[Token(Token = "0x6000651")]
		[Address(RVA = "0x2E7BB50", Offset = "0x2E7BB50", VA = "0x2E7BB50")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000652")]
		[Address(RVA = "0x2E7BB58", Offset = "0x2E7BB58", VA = "0x2E7BB58")]
		set
		{
		}
	}

	// Token: 0x170000CB RID: 203
	// (get) Token: 0x06000653 RID: 1619 RVA: 0x00004020 File Offset: 0x00002220
	// (set) Token: 0x06000654 RID: 1620 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000CB")]
	public float verticalScrollbarSpacing
	{
		[Token(Token = "0x6000653")]
		[Address(RVA = "0x2E7BBE8", Offset = "0x2E7BBE8", VA = "0x2E7BBE8")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000654")]
		[Address(RVA = "0x2E7BBF0", Offset = "0x2E7BBF0", VA = "0x2E7BBF0")]
		set
		{
		}
	}

	// Token: 0x170000CC RID: 204
	// (get) Token: 0x06000655 RID: 1621 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000656 RID: 1622 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000CC")]
	public CenterScrollView.ScrollRectEvent onValueChanged
	{
		[Token(Token = "0x6000655")]
		[Address(RVA = "0x2E7BBF8", Offset = "0x2E7BBF8", VA = "0x2E7BBF8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000656")]
		[Address(RVA = "0x2E7BC00", Offset = "0x2E7BC00", VA = "0x2E7BC00")]
		set
		{
		}
	}

	// Token: 0x170000CD RID: 205
	// (get) Token: 0x06000657 RID: 1623 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000CD")]
	protected RectTransform viewRect
	{
		[Token(Token = "0x6000657")]
		[Address(RVA = "0x2E7BC08", Offset = "0x2E7BC08", VA = "0x2E7BC08")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000CE RID: 206
	// (get) Token: 0x06000658 RID: 1624 RVA: 0x00004038 File Offset: 0x00002238
	// (set) Token: 0x06000659 RID: 1625 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000CE")]
	public Vector2 velocity
	{
		[Token(Token = "0x6000658")]
		[Address(RVA = "0x2E7BD18", Offset = "0x2E7BD18", VA = "0x2E7BD18")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000659")]
		[Address(RVA = "0x2E7BD20", Offset = "0x2E7BD20", VA = "0x2E7BD20")]
		set
		{
		}
	}

	// Token: 0x170000CF RID: 207
	// (get) Token: 0x0600065A RID: 1626 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000CF")]
	private RectTransform rectTransform
	{
		[Token(Token = "0x600065A")]
		[Address(RVA = "0x2E7BD28", Offset = "0x2E7BD28", VA = "0x2E7BD28")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600065B RID: 1627 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600065B")]
	[Address(RVA = "0x2E7BDC8", Offset = "0x2E7BDC8", VA = "0x2E7BDC8", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x0600065C RID: 1628 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600065C")]
	[Address(RVA = "0x2E7C348", Offset = "0x2E7C348", VA = "0x2E7C348", Slot = "8")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x0600065D RID: 1629 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600065D")]
	[Address(RVA = "0x2E7C4F4", Offset = "0x2E7C4F4", VA = "0x2E7C4F4")]
	public void ClearCells()
	{
	}

	// Token: 0x0600065E RID: 1630 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600065E")]
	[Address(RVA = "0x2E7C6AC", Offset = "0x2E7C6AC", VA = "0x2E7C6AC")]
	public void ScrollToCell(int index, float speed)
	{
	}

	// Token: 0x0600065F RID: 1631 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600065F")]
	[Address(RVA = "0x2E7C960", Offset = "0x2E7C960", VA = "0x2E7C960")]
	public void StopScrollToCell(object obj)
	{
	}

	// Token: 0x06000660 RID: 1632 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000660")]
	[Address(RVA = "0x2E7C8CC", Offset = "0x2E7C8CC", VA = "0x2E7C8CC")]
	private IEnumerator ScrollToCellCoroutine(int index, float speed)
	{
		return null;
	}

	// Token: 0x06000661 RID: 1633 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000661")]
	[Address(RVA = "0x2E7C990", Offset = "0x2E7C990", VA = "0x2E7C990")]
	public void ScrollToCellCenter(int index, float speed)
	{
	}

	// Token: 0x06000662 RID: 1634 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000662")]
	[Address(RVA = "0x2E7CBC4", Offset = "0x2E7CBC4", VA = "0x2E7CBC4")]
	private IEnumerator ScrollToCellCenterCoroutine(int index, float speed)
	{
		return null;
	}

	// Token: 0x06000663 RID: 1635 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000663")]
	[Address(RVA = "0x2E7CC80", Offset = "0x2E7CC80", VA = "0x2E7CC80")]
	public void RefreshCells()
	{
	}

	// Token: 0x06000664 RID: 1636 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000664")]
	[Address(RVA = "0x2E7CE60", Offset = "0x2E7CE60", VA = "0x2E7CE60")]
	public void RefillCellsFromEnd(int offset = 0)
	{
	}

	// Token: 0x06000665 RID: 1637 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000665")]
	[Address(RVA = "0x2E7D0C0", Offset = "0x2E7D0C0", VA = "0x2E7D0C0")]
	public void SetExtraFillSize(float extraSizeX, float extraSizeY)
	{
	}

	// Token: 0x06000666 RID: 1638 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000666")]
	[Address(RVA = "0x2E7BFB0", Offset = "0x2E7BFB0", VA = "0x2E7BFB0")]
	public void RefillCells(int offset = 0, bool fillViewRect = false)
	{
	}

	// Token: 0x06000667 RID: 1639 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000667")]
	[Address(RVA = "0x2E7D0C8", Offset = "0x2E7D0C8", VA = "0x2E7D0C8")]
	public void RefillCellsByFloatOffset(float offset, bool fillViewRect = false)
	{
	}

	// Token: 0x06000668 RID: 1640 RVA: 0x00004050 File Offset: 0x00002250
	[Token(Token = "0x6000668")]
	[Address(RVA = "0x2E7B094", Offset = "0x2E7B094", VA = "0x2E7B094")]
	protected float NewItemAtStart()
	{
		return 0f;
	}

	// Token: 0x06000669 RID: 1641 RVA: 0x00004068 File Offset: 0x00002268
	[Token(Token = "0x6000669")]
	[Address(RVA = "0x2E7B474", Offset = "0x2E7B474", VA = "0x2E7B474")]
	protected float DeleteItemAtStart()
	{
		return 0f;
	}

	// Token: 0x0600066A RID: 1642 RVA: 0x00004080 File Offset: 0x00002280
	[Token(Token = "0x600066A")]
	[Address(RVA = "0x2E7AEEC", Offset = "0x2E7AEEC", VA = "0x2E7AEEC")]
	protected float NewItemAtEnd()
	{
		return 0f;
	}

	// Token: 0x0600066B RID: 1643 RVA: 0x00004098 File Offset: 0x00002298
	[Token(Token = "0x600066B")]
	[Address(RVA = "0x2E7B208", Offset = "0x2E7B208", VA = "0x2E7B208")]
	protected float DeleteItemAtEnd()
	{
		return 0f;
	}

	// Token: 0x0600066C RID: 1644 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600066C")]
	[Address(RVA = "0x2E7D524", Offset = "0x2E7D524", VA = "0x2E7D524")]
	private RectTransform InstantiateNextItem(int itemIdx)
	{
		return null;
	}

	// Token: 0x0600066D RID: 1645 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600066D")]
	[Address(RVA = "0x2E7D918", Offset = "0x2E7D918", VA = "0x2E7D918", Slot = "40")]
	public virtual void Rebuild(CanvasUpdate executing)
	{
	}

	// Token: 0x0600066E RID: 1646 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600066E")]
	[Address(RVA = "0x2E7E408", Offset = "0x2E7E408", VA = "0x2E7E408", Slot = "41")]
	public virtual void LayoutComplete()
	{
	}

	// Token: 0x0600066F RID: 1647 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600066F")]
	[Address(RVA = "0x2E7E40C", Offset = "0x2E7E40C", VA = "0x2E7E40C", Slot = "42")]
	public virtual void GraphicUpdateComplete()
	{
	}

	// Token: 0x06000670 RID: 1648 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000670")]
	[Address(RVA = "0x2E7D9A8", Offset = "0x2E7D9A8", VA = "0x2E7D9A8")]
	private void UpdateCachedData()
	{
	}

	// Token: 0x06000671 RID: 1649 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000671")]
	[Address(RVA = "0x2E7E410", Offset = "0x2E7E410", VA = "0x2E7E410", Slot = "5")]
	protected override void OnEnable()
	{
	}

	// Token: 0x06000672 RID: 1650 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000672")]
	[Address(RVA = "0x2E7E648", Offset = "0x2E7E648", VA = "0x2E7E648", Slot = "7")]
	protected override void OnDisable()
	{
	}

	// Token: 0x06000673 RID: 1651 RVA: 0x000040B0 File Offset: 0x000022B0
	[Token(Token = "0x6000673")]
	[Address(RVA = "0x2E7E908", Offset = "0x2E7E908", VA = "0x2E7E908", Slot = "9")]
	public override bool IsActive()
	{
		return default(bool);
	}

	// Token: 0x06000674 RID: 1652 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000674")]
	[Address(RVA = "0x2E7E988", Offset = "0x2E7E988", VA = "0x2E7E988")]
	private void EnsureLayoutHasRebuilt()
	{
	}

	// Token: 0x06000675 RID: 1653 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000675")]
	[Address(RVA = "0x2E7E9FC", Offset = "0x2E7E9FC", VA = "0x2E7E9FC", Slot = "43")]
	public virtual void StopMovement()
	{
	}

	// Token: 0x06000676 RID: 1654 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000676")]
	[Address(RVA = "0x2E7EA4C", Offset = "0x2E7EA4C", VA = "0x2E7EA4C", Slot = "44")]
	public virtual void OnScroll(PointerEventData data)
	{
	}

	// Token: 0x06000677 RID: 1655 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000677")]
	[Address(RVA = "0x2E7EDAC", Offset = "0x2E7EDAC", VA = "0x2E7EDAC", Slot = "45")]
	public virtual void OnInitializePotentialDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06000678 RID: 1656 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000678")]
	[Address(RVA = "0x2E7EE0C", Offset = "0x2E7EE0C", VA = "0x2E7EE0C", Slot = "38")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x06000679 RID: 1657 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000679")]
	private void RoutePointerEvent<T>(PointerEventData eventData, ExecuteEvents.EventFunction<T> functor) where T : IEventSystemHandler
	{
	}

	// Token: 0x0600067A RID: 1658 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600067A")]
	[Address(RVA = "0x2E7C4DC", Offset = "0x2E7C4DC", VA = "0x2E7C4DC")]
	private void ClearRoute()
	{
	}

	// Token: 0x0600067B RID: 1659 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600067B")]
	[Address(RVA = "0x2E7EE14", Offset = "0x2E7EE14", VA = "0x2E7EE14", Slot = "46")]
	public virtual void OnBeginDrag(PointerEventData eventData)
	{
	}

	// Token: 0x0600067C RID: 1660 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600067C")]
	[Address(RVA = "0x2E7F084", Offset = "0x2E7F084", VA = "0x2E7F084", Slot = "47")]
	public virtual void OnEndDrag(PointerEventData eventData)
	{
	}

	// Token: 0x0600067D RID: 1661 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600067D")]
	[Address(RVA = "0x2E7F170", Offset = "0x2E7F170", VA = "0x2E7F170", Slot = "48")]
	public virtual void OnDrag(PointerEventData eventData)
	{
	}

	// Token: 0x0600067E RID: 1662 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600067E")]
	[Address(RVA = "0x2E7F44C", Offset = "0x2E7F44C", VA = "0x2E7F44C", Slot = "49")]
	protected virtual void SetContentAnchoredPosition(Vector2 position)
	{
	}

	// Token: 0x0600067F RID: 1663 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600067F")]
	[Address(RVA = "0x2E7F50C", Offset = "0x2E7F50C", VA = "0x2E7F50C", Slot = "50")]
	protected virtual void LateUpdate()
	{
	}

	// Token: 0x06000680 RID: 1664 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000680")]
	[Address(RVA = "0x2E7E31C", Offset = "0x2E7E31C", VA = "0x2E7E31C")]
	private void UpdatePrevData()
	{
	}

	// Token: 0x06000681 RID: 1665 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000681")]
	[Address(RVA = "0x2E7E0C4", Offset = "0x2E7E0C4", VA = "0x2E7E0C4")]
	private void UpdateScrollbars(Vector2 offset)
	{
	}

	// Token: 0x170000D0 RID: 208
	// (get) Token: 0x06000682 RID: 1666 RVA: 0x000040C8 File Offset: 0x000022C8
	// (set) Token: 0x06000683 RID: 1667 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000D0")]
	public Vector2 normalizedPosition
	{
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x2E7FBB4", Offset = "0x2E7FBB4", VA = "0x2E7FBB4")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x2E7FDE4", Offset = "0x2E7FDE4", VA = "0x2E7FDE4")]
		set
		{
		}
	}

	// Token: 0x170000D1 RID: 209
	// (get) Token: 0x06000684 RID: 1668 RVA: 0x000040E0 File Offset: 0x000022E0
	// (set) Token: 0x06000685 RID: 1669 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000D1")]
	public float horizontalNormalizedPosition
	{
		[Token(Token = "0x6000684")]
		[Address(RVA = "0x2E7FBE4", Offset = "0x2E7FBE4", VA = "0x2E7FBE4")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x2E80148", Offset = "0x2E80148", VA = "0x2E80148")]
		set
		{
		}
	}

	// Token: 0x170000D2 RID: 210
	// (get) Token: 0x06000686 RID: 1670 RVA: 0x000040F8 File Offset: 0x000022F8
	// (set) Token: 0x06000687 RID: 1671 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000D2")]
	public float verticalNormalizedPosition
	{
		[Token(Token = "0x6000686")]
		[Address(RVA = "0x2E7FCE4", Offset = "0x2E7FCE4", VA = "0x2E7FCE4")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x2E80150", Offset = "0x2E80150", VA = "0x2E80150")]
		set
		{
		}
	}

	// Token: 0x06000688 RID: 1672 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000688")]
	[Address(RVA = "0x2E80158", Offset = "0x2E80158", VA = "0x2E80158")]
	private void SetHorizontalNormalizedPosition(float value)
	{
	}

	// Token: 0x06000689 RID: 1673 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000689")]
	[Address(RVA = "0x2E80160", Offset = "0x2E80160", VA = "0x2E80160")]
	private void SetVerticalNormalizedPosition(float value)
	{
	}

	// Token: 0x0600068A RID: 1674 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600068A")]
	[Address(RVA = "0x2E7FE14", Offset = "0x2E7FE14", VA = "0x2E7FE14")]
	private void SetNormalizedPosition(float value, int axis)
	{
	}

	// Token: 0x0600068B RID: 1675 RVA: 0x00004110 File Offset: 0x00002310
	[Token(Token = "0x600068B")]
	[Address(RVA = "0x2E7F410", Offset = "0x2E7F410", VA = "0x2E7F410")]
	private static float RubberDelta(float overStretching, float viewSize)
	{
		return 0f;
	}

	// Token: 0x0600068C RID: 1676 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600068C")]
	[Address(RVA = "0x2E80168", Offset = "0x2E80168", VA = "0x2E80168", Slot = "10")]
	protected override void OnRectTransformDimensionsChange()
	{
	}

	// Token: 0x170000D3 RID: 211
	// (get) Token: 0x0600068D RID: 1677 RVA: 0x00004128 File Offset: 0x00002328
	[Token(Token = "0x170000D3")]
	private bool hScrollingNeeded
	{
		[Token(Token = "0x600068D")]
		[Address(RVA = "0x2E8016C", Offset = "0x2E8016C", VA = "0x2E8016C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000D4 RID: 212
	// (get) Token: 0x0600068E RID: 1678 RVA: 0x00004140 File Offset: 0x00002340
	[Token(Token = "0x170000D4")]
	private bool vScrollingNeeded
	{
		[Token(Token = "0x600068E")]
		[Address(RVA = "0x2E801C8", Offset = "0x2E801C8", VA = "0x2E801C8")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600068F RID: 1679 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600068F")]
	[Address(RVA = "0x2E80224", Offset = "0x2E80224", VA = "0x2E80224", Slot = "51")]
	public virtual void CalculateLayoutInputHorizontal()
	{
	}

	// Token: 0x06000690 RID: 1680 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000690")]
	[Address(RVA = "0x2E80228", Offset = "0x2E80228", VA = "0x2E80228", Slot = "52")]
	public virtual void CalculateLayoutInputVertical()
	{
	}

	// Token: 0x170000D5 RID: 213
	// (get) Token: 0x06000691 RID: 1681 RVA: 0x00004158 File Offset: 0x00002358
	[Token(Token = "0x170000D5")]
	public virtual float minWidth
	{
		[Token(Token = "0x6000691")]
		[Address(RVA = "0x2E8022C", Offset = "0x2E8022C", VA = "0x2E8022C", Slot = "53")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000D6 RID: 214
	// (get) Token: 0x06000692 RID: 1682 RVA: 0x00004170 File Offset: 0x00002370
	[Token(Token = "0x170000D6")]
	public virtual float preferredWidth
	{
		[Token(Token = "0x6000692")]
		[Address(RVA = "0x2E80234", Offset = "0x2E80234", VA = "0x2E80234", Slot = "54")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000D7 RID: 215
	// (get) Token: 0x06000693 RID: 1683 RVA: 0x00004188 File Offset: 0x00002388
	// (set) Token: 0x06000694 RID: 1684 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000D7")]
	public virtual float flexibleWidth
	{
		[Token(Token = "0x6000693")]
		[Address(RVA = "0x2E8023C", Offset = "0x2E8023C", VA = "0x2E8023C", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000694")]
		[Address(RVA = "0x2E80244", Offset = "0x2E80244", VA = "0x2E80244")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170000D8 RID: 216
	// (get) Token: 0x06000695 RID: 1685 RVA: 0x000041A0 File Offset: 0x000023A0
	[Token(Token = "0x170000D8")]
	public virtual float minHeight
	{
		[Token(Token = "0x6000695")]
		[Address(RVA = "0x2E8024C", Offset = "0x2E8024C", VA = "0x2E8024C", Slot = "56")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000D9 RID: 217
	// (get) Token: 0x06000696 RID: 1686 RVA: 0x000041B8 File Offset: 0x000023B8
	[Token(Token = "0x170000D9")]
	public virtual float preferredHeight
	{
		[Token(Token = "0x6000696")]
		[Address(RVA = "0x2E80254", Offset = "0x2E80254", VA = "0x2E80254", Slot = "57")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000DA RID: 218
	// (get) Token: 0x06000697 RID: 1687 RVA: 0x000041D0 File Offset: 0x000023D0
	[Token(Token = "0x170000DA")]
	public virtual float flexibleHeight
	{
		[Token(Token = "0x6000697")]
		[Address(RVA = "0x2E8025C", Offset = "0x2E8025C", VA = "0x2E8025C", Slot = "58")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000DB RID: 219
	// (get) Token: 0x06000698 RID: 1688 RVA: 0x000041E8 File Offset: 0x000023E8
	[Token(Token = "0x170000DB")]
	public virtual int layoutPriority
	{
		[Token(Token = "0x6000698")]
		[Address(RVA = "0x2E80264", Offset = "0x2E80264", VA = "0x2E80264", Slot = "59")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06000699 RID: 1689 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000699")]
	[Address(RVA = "0x2E8026C", Offset = "0x2E8026C", VA = "0x2E8026C", Slot = "60")]
	public virtual void SetLayoutHorizontal()
	{
	}

	// Token: 0x0600069A RID: 1690 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600069A")]
	[Address(RVA = "0x2E80A1C", Offset = "0x2E80A1C", VA = "0x2E80A1C", Slot = "61")]
	public virtual void SetLayoutVertical()
	{
	}

	// Token: 0x0600069B RID: 1691 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600069B")]
	[Address(RVA = "0x2E7FA50", Offset = "0x2E7FA50", VA = "0x2E7FA50")]
	private void UpdateScrollbarVisibility()
	{
	}

	// Token: 0x0600069C RID: 1692 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600069C")]
	[Address(RVA = "0x2E80AF8", Offset = "0x2E80AF8", VA = "0x2E80AF8")]
	private void UpdateScrollbarLayout()
	{
	}

	// Token: 0x0600069D RID: 1693 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600069D")]
	[Address(RVA = "0x2E7DD40", Offset = "0x2E7DD40", VA = "0x2E7DD40")]
	private void UpdateBounds(bool updateItems = false, bool checkBounds = false)
	{
	}

	// Token: 0x0600069E RID: 1694 RVA: 0x00004200 File Offset: 0x00002400
	[Token(Token = "0x600069E")]
	[Address(RVA = "0x2E807BC", Offset = "0x2E807BC", VA = "0x2E807BC")]
	private Bounds GetBounds()
	{
		return default(Bounds);
	}

	// Token: 0x0600069F RID: 1695 RVA: 0x00004218 File Offset: 0x00002418
	[Token(Token = "0x600069F")]
	[Address(RVA = "0x2E80D4C", Offset = "0x2E80D4C", VA = "0x2E80D4C")]
	private Bounds GetBounds4Item(int index)
	{
		return default(Bounds);
	}

	// Token: 0x060006A0 RID: 1696 RVA: 0x00004230 File Offset: 0x00002430
	[Token(Token = "0x60006A0")]
	[Address(RVA = "0x2E7EB94", Offset = "0x2E7EB94", VA = "0x2E7EB94")]
	private Vector2 CalculateOffset(Vector2 delta)
	{
		return default(Vector2);
	}

	// Token: 0x060006A1 RID: 1697 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006A1")]
	[Address(RVA = "0x2E7BB60", Offset = "0x2E7BB60", VA = "0x2E7BB60")]
	protected void SetDirty()
	{
	}

	// Token: 0x060006A2 RID: 1698 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006A2")]
	[Address(RVA = "0x2E7B748", Offset = "0x2E7B748", VA = "0x2E7B748")]
	protected void SetDirtyCaching()
	{
	}

	// Token: 0x060006A3 RID: 1699 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006A3")]
	[Address(RVA = "0x2E7D5FC", Offset = "0x2E7D5FC", VA = "0x2E7D5FC")]
	private GameObject GetItemObject(Transform parent, bool worldPositionStays)
	{
		return null;
	}

	// Token: 0x060006A4 RID: 1700 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006A4")]
	[Address(RVA = "0x2E7C570", Offset = "0x2E7C570", VA = "0x2E7C570")]
	private void ReturnItemObject(GameObject go)
	{
	}

	// Token: 0x060006A5 RID: 1701 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006A5")]
	[Address(RVA = "0x2E7CE44", Offset = "0x2E7CE44", VA = "0x2E7CE44")]
	private void OnItemMoveIn(GameObject itemObj, int index)
	{
	}

	// Token: 0x060006A6 RID: 1702 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006A6")]
	[Address(RVA = "0x2E7CE28", Offset = "0x2E7CE28", VA = "0x2E7CE28")]
	private void OnItemMoveOut(GameObject itemObj, int index)
	{
	}

	// Token: 0x060006A7 RID: 1703 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006A7")]
	[Address(RVA = "0x2E7BEB0", Offset = "0x2E7BEB0", VA = "0x2E7BEB0")]
	private void CheckComponentConflict()
	{
	}

	// Token: 0x060006A8 RID: 1704 RVA: 0x00004248 File Offset: 0x00002448
	[Token(Token = "0x60006A8")]
	[Address(RVA = "0x2E80FFC", Offset = "0x2E80FFC", VA = "0x2E80FFC")]
	private Vector2 CalculateCenterClampedOffset(Vector2 delta)
	{
		return default(Vector2);
	}

	// Token: 0x060006A9 RID: 1705 RVA: 0x00004260 File Offset: 0x00002460
	[Token(Token = "0x60006A9")]
	[Address(RVA = "0x2E811A4", Offset = "0x2E811A4", VA = "0x2E811A4")]
	private float GetFirstItemHalfSize()
	{
		return 0f;
	}

	// Token: 0x060006AA RID: 1706 RVA: 0x00004278 File Offset: 0x00002478
	[Token(Token = "0x60006AA")]
	[Address(RVA = "0x2E8135C", Offset = "0x2E8135C", VA = "0x2E8135C")]
	private float GetLastItemHalfSize()
	{
		return 0f;
	}

	// Token: 0x060006AB RID: 1707 RVA: 0x00004290 File Offset: 0x00002490
	[Token(Token = "0x60006AB")]
	[Address(RVA = "0x2E8153C", Offset = "0x2E8153C", VA = "0x2E8153C")]
	private Bounds GetBoundsForTransform(RectTransform rt)
	{
		return default(Bounds);
	}

	// Token: 0x060006AC RID: 1708 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006AC")]
	[Address(RVA = "0x2E81774", Offset = "0x2E81774", VA = "0x2E81774")]
	public CenterScrollView()
	{
	}

	// Token: 0x060006AD RID: 1709 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006AD")]
	[Address(RVA = "0x2E8196C", Offset = "0x2E8196C", VA = "0x2E8196C", Slot = "23")]
	private Transform UnityEngine.UI.ICanvasElement.get_transform()
	{
		return null;
	}

	// Token: 0x040004AD RID: 1197
	[Token(Token = "0x40004AD")]
	[FieldOffset(Offset = "0x0")]
	private static GameObject objectPoolRoot;

	// Token: 0x040004AE RID: 1198
	[Token(Token = "0x40004AE")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject itemTemplate;

	// Token: 0x040004AF RID: 1199
	[Token(Token = "0x40004AF")]
	[FieldOffset(Offset = "0x20")]
	private List<CenterScrollView.ItemObject> itemObjectPool;

	// Token: 0x040004B0 RID: 1200
	[Token(Token = "0x40004B0")]
	[FieldOffset(Offset = "0x28")]
	[Tooltip("Total count, negative means INFINITE mode")]
	public int totalCount;

	// Token: 0x040004B1 RID: 1201
	[Token(Token = "0x40004B1")]
	[FieldOffset(Offset = "0x2C")]
	protected float threshold;

	// Token: 0x040004B2 RID: 1202
	[Token(Token = "0x40004B2")]
	[FieldOffset(Offset = "0x30")]
	[Tooltip("Reverse direction for dragging")]
	public bool reverseDirection;

	// Token: 0x040004B3 RID: 1203
	[Token(Token = "0x40004B3")]
	[FieldOffset(Offset = "0x34")]
	[Tooltip("Rubber scale for outside")]
	public float rubberScale;

	// Token: 0x040004B4 RID: 1204
	[Token(Token = "0x40004B4")]
	[FieldOffset(Offset = "0x38")]
	protected int itemTypeStart;

	// Token: 0x040004B5 RID: 1205
	[Token(Token = "0x40004B5")]
	[FieldOffset(Offset = "0x3C")]
	protected int itemTypeEnd;

	// Token: 0x040004B6 RID: 1206
	[Token(Token = "0x40004B6")]
	[FieldOffset(Offset = "0x40")]
	private Vector2 extraFillSize;

	// Token: 0x040004B7 RID: 1207
	[Token(Token = "0x40004B7")]
	[FieldOffset(Offset = "0x48")]
	protected int directionSign;

	// Token: 0x040004B8 RID: 1208
	[Token(Token = "0x40004B8")]
	[FieldOffset(Offset = "0x4C")]
	private float m_ContentSpacing;

	// Token: 0x040004B9 RID: 1209
	[Token(Token = "0x40004B9")]
	[FieldOffset(Offset = "0x50")]
	protected GridLayoutGroup m_GridLayout;

	// Token: 0x040004BA RID: 1210
	[Token(Token = "0x40004BA")]
	[FieldOffset(Offset = "0x58")]
	public int m_ContentConstraintCount;

	// Token: 0x040004BB RID: 1211
	[Token(Token = "0x40004BB")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private CenterScrollView.ScrollViewLayoutType layoutType;

	// Token: 0x040004BC RID: 1212
	[Token(Token = "0x40004BC")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private RectTransform m_Content;

	// Token: 0x040004BD RID: 1213
	[Token(Token = "0x40004BD")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private CenterScrollView.MovementType m_MovementType;

	// Token: 0x040004BE RID: 1214
	[Token(Token = "0x40004BE")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private float m_Elasticity;

	// Token: 0x040004BF RID: 1215
	[Token(Token = "0x40004BF")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private bool m_Inertia;

	// Token: 0x040004C0 RID: 1216
	[Token(Token = "0x40004C0")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	private float m_DecelerationRate;

	// Token: 0x040004C1 RID: 1217
	[Token(Token = "0x40004C1")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private float m_ScrollSensitivity;

	// Token: 0x040004C2 RID: 1218
	[Token(Token = "0x40004C2")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private RectTransform m_Viewport;

	// Token: 0x040004C3 RID: 1219
	[Token(Token = "0x40004C3")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Scrollbar m_HorizontalScrollbar;

	// Token: 0x040004C4 RID: 1220
	[Token(Token = "0x40004C4")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Scrollbar m_VerticalScrollbar;

	// Token: 0x040004C5 RID: 1221
	[Token(Token = "0x40004C5")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private CenterScrollView.ScrollbarVisibility m_HorizontalScrollbarVisibility;

	// Token: 0x040004C6 RID: 1222
	[Token(Token = "0x40004C6")]
	[FieldOffset(Offset = "0x9C")]
	[SerializeField]
	private CenterScrollView.ScrollbarVisibility m_VerticalScrollbarVisibility;

	// Token: 0x040004C7 RID: 1223
	[Token(Token = "0x40004C7")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private float m_HorizontalScrollbarSpacing;

	// Token: 0x040004C8 RID: 1224
	[Token(Token = "0x40004C8")]
	[FieldOffset(Offset = "0xA4")]
	[SerializeField]
	private float m_VerticalScrollbarSpacing;

	// Token: 0x040004C9 RID: 1225
	[Token(Token = "0x40004C9")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private CenterScrollView.ScrollRectEvent m_OnValueChanged;

	// Token: 0x040004CA RID: 1226
	[Token(Token = "0x40004CA")]
	[FieldOffset(Offset = "0xB0")]
	private Vector2 m_PointerStartLocalCursor;

	// Token: 0x040004CB RID: 1227
	[Token(Token = "0x40004CB")]
	[FieldOffset(Offset = "0xB8")]
	private Vector2 m_ContentStartPosition;

	// Token: 0x040004CC RID: 1228
	[Token(Token = "0x40004CC")]
	[FieldOffset(Offset = "0xC0")]
	private RectTransform m_ViewRect;

	// Token: 0x040004CD RID: 1229
	[Token(Token = "0x40004CD")]
	[FieldOffset(Offset = "0xC8")]
	private Bounds m_ContentBounds;

	// Token: 0x040004CE RID: 1230
	[Token(Token = "0x40004CE")]
	[FieldOffset(Offset = "0xE0")]
	private Bounds m_ViewBounds;

	// Token: 0x040004CF RID: 1231
	[Token(Token = "0x40004CF")]
	[FieldOffset(Offset = "0xF8")]
	private Vector2 m_Velocity;

	// Token: 0x040004D0 RID: 1232
	[Token(Token = "0x40004D0")]
	[FieldOffset(Offset = "0x100")]
	private bool m_Dragging;

	// Token: 0x040004D1 RID: 1233
	[Token(Token = "0x40004D1")]
	[FieldOffset(Offset = "0x101")]
	private bool m_viewportChanged;

	// Token: 0x040004D2 RID: 1234
	[Token(Token = "0x40004D2")]
	[FieldOffset(Offset = "0x104")]
	private Vector2 m_PrevPosition;

	// Token: 0x040004D3 RID: 1235
	[Token(Token = "0x40004D3")]
	[FieldOffset(Offset = "0x10C")]
	private Bounds m_PrevContentBounds;

	// Token: 0x040004D4 RID: 1236
	[Token(Token = "0x40004D4")]
	[FieldOffset(Offset = "0x124")]
	private Bounds m_PrevViewBounds;

	// Token: 0x040004D5 RID: 1237
	[Token(Token = "0x40004D5")]
	[FieldOffset(Offset = "0x13C")]
	[NonSerialized]
	private bool m_HasRebuiltLayout;

	// Token: 0x040004D6 RID: 1238
	[Token(Token = "0x40004D6")]
	[FieldOffset(Offset = "0x13D")]
	private bool m_HSliderExpand;

	// Token: 0x040004D7 RID: 1239
	[Token(Token = "0x40004D7")]
	[FieldOffset(Offset = "0x13E")]
	private bool m_VSliderExpand;

	// Token: 0x040004D8 RID: 1240
	[Token(Token = "0x40004D8")]
	[FieldOffset(Offset = "0x140")]
	private float m_HSliderHeight;

	// Token: 0x040004D9 RID: 1241
	[Token(Token = "0x40004D9")]
	[FieldOffset(Offset = "0x144")]
	private float m_VSliderWidth;

	// Token: 0x040004DA RID: 1242
	[Token(Token = "0x40004DA")]
	[FieldOffset(Offset = "0x148")]
	[NonSerialized]
	private RectTransform m_Rect;

	// Token: 0x040004DB RID: 1243
	[Token(Token = "0x40004DB")]
	[FieldOffset(Offset = "0x150")]
	private RectTransform m_HorizontalScrollbarRect;

	// Token: 0x040004DC RID: 1244
	[Token(Token = "0x40004DC")]
	[FieldOffset(Offset = "0x158")]
	private RectTransform m_VerticalScrollbarRect;

	// Token: 0x040004DD RID: 1245
	[Token(Token = "0x40004DD")]
	[FieldOffset(Offset = "0x160")]
	private DrivenRectTransformTracker m_Tracker;

	// Token: 0x040004DE RID: 1246
	[Token(Token = "0x40004DE")]
	[FieldOffset(Offset = "0x161")]
	public bool nestedScrolling;

	// Token: 0x040004DF RID: 1247
	[Token(Token = "0x40004DF")]
	[FieldOffset(Offset = "0x162")]
	private bool _routing;

	// Token: 0x040004E0 RID: 1248
	[Token(Token = "0x40004E0")]
	[FieldOffset(Offset = "0x168")]
	private GameObject _routeObject;

	// Token: 0x040004E2 RID: 1250
	[Token(Token = "0x40004E2")]
	[FieldOffset(Offset = "0x178")]
	private readonly Vector3[] m_Corners;

	// Token: 0x040004E3 RID: 1251
	[Token(Token = "0x40004E3")]
	[FieldOffset(Offset = "0x180")]
	public CenterScrollView.MoveItemDelegate onItemMoveIn;

	// Token: 0x040004E4 RID: 1252
	[Token(Token = "0x40004E4")]
	[FieldOffset(Offset = "0x188")]
	public CenterScrollView.MoveItemDelegate onItemMoveOut;

	// Token: 0x020000E5 RID: 229
	[Token(Token = "0x20000E5")]
	private class ItemObject
	{
		// Token: 0x060006AE RID: 1710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x2E81194", Offset = "0x2E81194", VA = "0x2E81194")]
		public ItemObject()
		{
		}

		// Token: 0x040004E5 RID: 1253
		[Token(Token = "0x40004E5")]
		[FieldOffset(Offset = "0x10")]
		public bool used;

		// Token: 0x040004E6 RID: 1254
		[Token(Token = "0x40004E6")]
		[FieldOffset(Offset = "0x18")]
		public GameObject gameObject;
	}

	// Token: 0x020000E6 RID: 230
	[Token(Token = "0x20000E6")]
	public enum MovementType
	{
		// Token: 0x040004E8 RID: 1256
		[Token(Token = "0x40004E8")]
		Unrestricted,
		// Token: 0x040004E9 RID: 1257
		[Token(Token = "0x40004E9")]
		Elastic,
		// Token: 0x040004EA RID: 1258
		[Token(Token = "0x40004EA")]
		Clamped,
		// Token: 0x040004EB RID: 1259
		[Token(Token = "0x40004EB")]
		CenterClamped
	}

	// Token: 0x020000E7 RID: 231
	[Token(Token = "0x20000E7")]
	public enum ScrollbarVisibility
	{
		// Token: 0x040004ED RID: 1261
		[Token(Token = "0x40004ED")]
		Permanent,
		// Token: 0x040004EE RID: 1262
		[Token(Token = "0x40004EE")]
		AutoHide,
		// Token: 0x040004EF RID: 1263
		[Token(Token = "0x40004EF")]
		AutoHideAndExpandViewport
	}

	// Token: 0x020000E8 RID: 232
	[Token(Token = "0x20000E8")]
	public enum ScrollViewLayoutType
	{
		// Token: 0x040004F1 RID: 1265
		[Token(Token = "0x40004F1")]
		Horizontal,
		// Token: 0x040004F2 RID: 1266
		[Token(Token = "0x40004F2")]
		Vertical
	}

	// Token: 0x020000E9 RID: 233
	[Token(Token = "0x20000E9")]
	[Serializable]
	public class ScrollRectEvent : UnityEvent<Vector2>
	{
		// Token: 0x060006AF RID: 1711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x2E81924", Offset = "0x2E81924", VA = "0x2E81924")]
		public ScrollRectEvent()
		{
		}
	}

	// Token: 0x020000EA RID: 234
	// (Invoke) Token: 0x060006B1 RID: 1713
	[Token(Token = "0x20000EA")]
	public delegate void MoveItemDelegate(GameObject itemObj, int index);
}
