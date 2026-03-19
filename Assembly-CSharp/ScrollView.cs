using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000120 RID: 288
[Token(Token = "0x2000120")]
[RequireComponent(typeof(RectTransform))]
[DisallowMultipleComponent]
[AddComponentMenu("UI/ScrollView", 51)]
public class ScrollView : UIBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup, ILayoutController, IPointerDownHandler
{
	// Token: 0x17000107 RID: 263
	// (get) Token: 0x06000814 RID: 2068 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000107")]
	private static Transform ObjectPoolRoot
	{
		[Token(Token = "0x6000814")]
		[Address(RVA = "0x348034C", Offset = "0x348034C", VA = "0x348034C")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000815 RID: 2069 RVA: 0x00004800 File Offset: 0x00002A00
	[Token(Token = "0x6000815")]
	[Address(RVA = "0x3480488", Offset = "0x3480488", VA = "0x3480488")]
	public float GetPreferredWidth(RectTransform item)
	{
		return 0f;
	}

	// Token: 0x06000816 RID: 2070 RVA: 0x00004818 File Offset: 0x00002A18
	[Token(Token = "0x6000816")]
	[Address(RVA = "0x348056C", Offset = "0x348056C", VA = "0x348056C")]
	public float GetPreferredHeight(RectTransform item)
	{
		return 0f;
	}

	// Token: 0x06000817 RID: 2071 RVA: 0x00004830 File Offset: 0x00002A30
	[Token(Token = "0x6000817")]
	[Address(RVA = "0x3480654", Offset = "0x3480654", VA = "0x3480654")]
	protected float GetSize(RectTransform item)
	{
		return 0f;
	}

	// Token: 0x06000818 RID: 2072 RVA: 0x00004848 File Offset: 0x00002A48
	[Token(Token = "0x6000818")]
	[Address(RVA = "0x3480884", Offset = "0x3480884", VA = "0x3480884")]
	protected float GetDimension(Vector2 vector)
	{
		return 0f;
	}

	// Token: 0x06000819 RID: 2073 RVA: 0x00004860 File Offset: 0x00002A60
	[Token(Token = "0x6000819")]
	[Address(RVA = "0x3480898", Offset = "0x3480898", VA = "0x3480898")]
	protected Vector2 GetVector(float value)
	{
		return default(Vector2);
	}

	// Token: 0x17000108 RID: 264
	// (get) Token: 0x0600081A RID: 2074 RVA: 0x00004878 File Offset: 0x00002A78
	[Token(Token = "0x17000108")]
	protected float contentSpacing
	{
		[Token(Token = "0x600081A")]
		[Address(RVA = "0x3480724", Offset = "0x3480724", VA = "0x3480724")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000109 RID: 265
	// (get) Token: 0x0600081B RID: 2075 RVA: 0x00004890 File Offset: 0x00002A90
	[Token(Token = "0x17000109")]
	protected int contentConstraintCount
	{
		[Token(Token = "0x600081B")]
		[Address(RVA = "0x34808B4", Offset = "0x34808B4", VA = "0x34808B4")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700010A RID: 266
	// (get) Token: 0x0600081C RID: 2076 RVA: 0x000048A8 File Offset: 0x00002AA8
	[Token(Token = "0x1700010A")]
	private int StartLine
	{
		[Token(Token = "0x600081C")]
		[Address(RVA = "0x34809E0", Offset = "0x34809E0", VA = "0x34809E0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700010B RID: 267
	// (get) Token: 0x0600081D RID: 2077 RVA: 0x000048C0 File Offset: 0x00002AC0
	[Token(Token = "0x1700010B")]
	private int CurrentLines
	{
		[Token(Token = "0x600081D")]
		[Address(RVA = "0x3480A5C", Offset = "0x3480A5C", VA = "0x3480A5C")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700010C RID: 268
	// (get) Token: 0x0600081E RID: 2078 RVA: 0x000048D8 File Offset: 0x00002AD8
	[Token(Token = "0x1700010C")]
	private int TotalLines
	{
		[Token(Token = "0x600081E")]
		[Address(RVA = "0x3480AE4", Offset = "0x3480AE4", VA = "0x3480AE4")]
		get
		{
			return 0;
		}
	}

	// Token: 0x0600081F RID: 2079 RVA: 0x000048F0 File Offset: 0x00002AF0
	[Token(Token = "0x600081F")]
	[Address(RVA = "0x3480B60", Offset = "0x3480B60", VA = "0x3480B60", Slot = "39")]
	protected virtual bool UpdateItems(Bounds viewBounds, Bounds contentBounds)
	{
		return default(bool);
	}

	// Token: 0x1700010D RID: 269
	// (get) Token: 0x06000820 RID: 2080 RVA: 0x00004908 File Offset: 0x00002B08
	[Token(Token = "0x1700010D")]
	public ScrollView.ScrollViewLayoutType LayoutType
	{
		[Token(Token = "0x6000820")]
		[Address(RVA = "0x3481850", Offset = "0x3481850", VA = "0x3481850")]
		get
		{
			return ScrollView.ScrollViewLayoutType.Horizontal;
		}
	}

	// Token: 0x1700010E RID: 270
	// (get) Token: 0x06000821 RID: 2081 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000822 RID: 2082 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700010E")]
	public RectTransform content
	{
		[Token(Token = "0x6000821")]
		[Address(RVA = "0x3481858", Offset = "0x3481858", VA = "0x3481858")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000822")]
		[Address(RVA = "0x3481860", Offset = "0x3481860", VA = "0x3481860")]
		set
		{
		}
	}

	// Token: 0x1700010F RID: 271
	// (get) Token: 0x06000823 RID: 2083 RVA: 0x00004920 File Offset: 0x00002B20
	// (set) Token: 0x06000824 RID: 2084 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700010F")]
	public ScrollView.MovementType movementType
	{
		[Token(Token = "0x6000823")]
		[Address(RVA = "0x3481868", Offset = "0x3481868", VA = "0x3481868")]
		get
		{
			return ScrollView.MovementType.Unrestricted;
		}
		[Token(Token = "0x6000824")]
		[Address(RVA = "0x3481870", Offset = "0x3481870", VA = "0x3481870")]
		set
		{
		}
	}

	// Token: 0x17000110 RID: 272
	// (get) Token: 0x06000825 RID: 2085 RVA: 0x00004938 File Offset: 0x00002B38
	// (set) Token: 0x06000826 RID: 2086 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000110")]
	public float elasticity
	{
		[Token(Token = "0x6000825")]
		[Address(RVA = "0x3481878", Offset = "0x3481878", VA = "0x3481878")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000826")]
		[Address(RVA = "0x3481880", Offset = "0x3481880", VA = "0x3481880")]
		set
		{
		}
	}

	// Token: 0x17000111 RID: 273
	// (get) Token: 0x06000827 RID: 2087 RVA: 0x00004950 File Offset: 0x00002B50
	// (set) Token: 0x06000828 RID: 2088 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000111")]
	public bool inertia
	{
		[Token(Token = "0x6000827")]
		[Address(RVA = "0x3481888", Offset = "0x3481888", VA = "0x3481888")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000828")]
		[Address(RVA = "0x3481890", Offset = "0x3481890", VA = "0x3481890")]
		set
		{
		}
	}

	// Token: 0x17000112 RID: 274
	// (get) Token: 0x06000829 RID: 2089 RVA: 0x00004968 File Offset: 0x00002B68
	// (set) Token: 0x0600082A RID: 2090 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000112")]
	public float decelerationRate
	{
		[Token(Token = "0x6000829")]
		[Address(RVA = "0x348189C", Offset = "0x348189C", VA = "0x348189C")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600082A")]
		[Address(RVA = "0x34818A4", Offset = "0x34818A4", VA = "0x34818A4")]
		set
		{
		}
	}

	// Token: 0x17000113 RID: 275
	// (get) Token: 0x0600082B RID: 2091 RVA: 0x00004980 File Offset: 0x00002B80
	// (set) Token: 0x0600082C RID: 2092 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000113")]
	public float scrollSensitivity
	{
		[Token(Token = "0x600082B")]
		[Address(RVA = "0x34818AC", Offset = "0x34818AC", VA = "0x34818AC")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600082C")]
		[Address(RVA = "0x34818B4", Offset = "0x34818B4", VA = "0x34818B4")]
		set
		{
		}
	}

	// Token: 0x17000114 RID: 276
	// (get) Token: 0x0600082D RID: 2093 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600082E RID: 2094 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000114")]
	public RectTransform viewport
	{
		[Token(Token = "0x600082D")]
		[Address(RVA = "0x34818BC", Offset = "0x34818BC", VA = "0x34818BC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600082E")]
		[Address(RVA = "0x34818C4", Offset = "0x34818C4", VA = "0x34818C4")]
		set
		{
		}
	}

	// Token: 0x17000115 RID: 277
	// (get) Token: 0x0600082F RID: 2095 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000830 RID: 2096 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000115")]
	public Scrollbar horizontalScrollbar
	{
		[Token(Token = "0x600082F")]
		[Address(RVA = "0x3481998", Offset = "0x3481998", VA = "0x3481998")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000830")]
		[Address(RVA = "0x34819A0", Offset = "0x34819A0", VA = "0x34819A0")]
		set
		{
		}
	}

	// Token: 0x17000116 RID: 278
	// (get) Token: 0x06000831 RID: 2097 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000832 RID: 2098 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000116")]
	public Scrollbar verticalScrollbar
	{
		[Token(Token = "0x6000831")]
		[Address(RVA = "0x3481B30", Offset = "0x3481B30", VA = "0x3481B30")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000832")]
		[Address(RVA = "0x3481B38", Offset = "0x3481B38", VA = "0x3481B38")]
		set
		{
		}
	}

	// Token: 0x17000117 RID: 279
	// (get) Token: 0x06000833 RID: 2099 RVA: 0x00004998 File Offset: 0x00002B98
	// (set) Token: 0x06000834 RID: 2100 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000117")]
	public ScrollView.ScrollbarVisibility horizontalScrollbarVisibility
	{
		[Token(Token = "0x6000833")]
		[Address(RVA = "0x3481CC8", Offset = "0x3481CC8", VA = "0x3481CC8")]
		get
		{
			return ScrollView.ScrollbarVisibility.Permanent;
		}
		[Token(Token = "0x6000834")]
		[Address(RVA = "0x3481CD0", Offset = "0x3481CD0", VA = "0x3481CD0")]
		set
		{
		}
	}

	// Token: 0x17000118 RID: 280
	// (get) Token: 0x06000835 RID: 2101 RVA: 0x000049B0 File Offset: 0x00002BB0
	// (set) Token: 0x06000836 RID: 2102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000118")]
	public ScrollView.ScrollbarVisibility verticalScrollbarVisibility
	{
		[Token(Token = "0x6000835")]
		[Address(RVA = "0x3481CD8", Offset = "0x3481CD8", VA = "0x3481CD8")]
		get
		{
			return ScrollView.ScrollbarVisibility.Permanent;
		}
		[Token(Token = "0x6000836")]
		[Address(RVA = "0x3481CE0", Offset = "0x3481CE0", VA = "0x3481CE0")]
		set
		{
		}
	}

	// Token: 0x17000119 RID: 281
	// (get) Token: 0x06000837 RID: 2103 RVA: 0x000049C8 File Offset: 0x00002BC8
	// (set) Token: 0x06000838 RID: 2104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000119")]
	public float horizontalScrollbarSpacing
	{
		[Token(Token = "0x6000837")]
		[Address(RVA = "0x3481CE8", Offset = "0x3481CE8", VA = "0x3481CE8")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000838")]
		[Address(RVA = "0x3481CF0", Offset = "0x3481CF0", VA = "0x3481CF0")]
		set
		{
		}
	}

	// Token: 0x1700011A RID: 282
	// (get) Token: 0x06000839 RID: 2105 RVA: 0x000049E0 File Offset: 0x00002BE0
	// (set) Token: 0x0600083A RID: 2106 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700011A")]
	public float verticalScrollbarSpacing
	{
		[Token(Token = "0x6000839")]
		[Address(RVA = "0x3481D80", Offset = "0x3481D80", VA = "0x3481D80")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600083A")]
		[Address(RVA = "0x3481D88", Offset = "0x3481D88", VA = "0x3481D88")]
		set
		{
		}
	}

	// Token: 0x1700011B RID: 283
	// (get) Token: 0x0600083B RID: 2107 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600083C RID: 2108 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700011B")]
	public ScrollView.ScrollRectEvent onValueChanged
	{
		[Token(Token = "0x600083B")]
		[Address(RVA = "0x3481D90", Offset = "0x3481D90", VA = "0x3481D90")]
		get
		{
			return null;
		}
		[Token(Token = "0x600083C")]
		[Address(RVA = "0x3481D98", Offset = "0x3481D98", VA = "0x3481D98")]
		set
		{
		}
	}

	// Token: 0x1700011C RID: 284
	// (get) Token: 0x0600083D RID: 2109 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700011C")]
	protected RectTransform viewRect
	{
		[Token(Token = "0x600083D")]
		[Address(RVA = "0x3481DA0", Offset = "0x3481DA0", VA = "0x3481DA0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700011D RID: 285
	// (get) Token: 0x0600083E RID: 2110 RVA: 0x000049F8 File Offset: 0x00002BF8
	// (set) Token: 0x0600083F RID: 2111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700011D")]
	public Vector2 velocity
	{
		[Token(Token = "0x600083E")]
		[Address(RVA = "0x3481EC0", Offset = "0x3481EC0", VA = "0x3481EC0")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x600083F")]
		[Address(RVA = "0x3481EC8", Offset = "0x3481EC8", VA = "0x3481EC8")]
		set
		{
		}
	}

	// Token: 0x1700011E RID: 286
	// (get) Token: 0x06000840 RID: 2112 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700011E")]
	private RectTransform rectTransform
	{
		[Token(Token = "0x6000840")]
		[Address(RVA = "0x3481ED0", Offset = "0x3481ED0", VA = "0x3481ED0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000841 RID: 2113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000841")]
	[Address(RVA = "0x3481F70", Offset = "0x3481F70", VA = "0x3481F70", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06000842 RID: 2114 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000842")]
	[Address(RVA = "0x34824F0", Offset = "0x34824F0", VA = "0x34824F0", Slot = "8")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x06000843 RID: 2115 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000843")]
	[Address(RVA = "0x348269C", Offset = "0x348269C", VA = "0x348269C")]
	public void ClearCells()
	{
	}

	// Token: 0x06000844 RID: 2116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000844")]
	[Address(RVA = "0x3482854", Offset = "0x3482854", VA = "0x3482854")]
	public void ScrollToCell(int index, float speed)
	{
	}

	// Token: 0x06000845 RID: 2117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000845")]
	[Address(RVA = "0x3482B08", Offset = "0x3482B08", VA = "0x3482B08")]
	public void StopScrollToCell(object obj)
	{
	}

	// Token: 0x06000846 RID: 2118 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000846")]
	[Address(RVA = "0x3482A74", Offset = "0x3482A74", VA = "0x3482A74")]
	private IEnumerator ScrollToCellCoroutine(int index, float speed)
	{
		return null;
	}

	// Token: 0x06000847 RID: 2119 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000847")]
	[Address(RVA = "0x3482B10", Offset = "0x3482B10", VA = "0x3482B10")]
	public void ScrollToCellCenter(int index, float speed)
	{
	}

	// Token: 0x06000848 RID: 2120 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000848")]
	[Address(RVA = "0x3482D30", Offset = "0x3482D30", VA = "0x3482D30")]
	private IEnumerator ScrollToCellCenterCoroutine(int index, float speed)
	{
		return null;
	}

	// Token: 0x06000849 RID: 2121 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000849")]
	[Address(RVA = "0x3482DC4", Offset = "0x3482DC4", VA = "0x3482DC4")]
	public void RefreshCells()
	{
	}

	// Token: 0x0600084A RID: 2122 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600084A")]
	[Address(RVA = "0x3482F34", Offset = "0x3482F34", VA = "0x3482F34")]
	public void RefillCellsFromEnd(int offset = 0)
	{
	}

	// Token: 0x0600084B RID: 2123 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600084B")]
	[Address(RVA = "0x3483194", Offset = "0x3483194", VA = "0x3483194")]
	public void SetExtraFillSize(float extraSizeX, float extraSizeY)
	{
	}

	// Token: 0x0600084C RID: 2124 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600084C")]
	[Address(RVA = "0x3482158", Offset = "0x3482158", VA = "0x3482158")]
	public void RefillCells(int offset = 0, bool fillViewRect = false)
	{
	}

	// Token: 0x0600084D RID: 2125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600084D")]
	[Address(RVA = "0x348319C", Offset = "0x348319C", VA = "0x348319C")]
	public void RefillCellsByFloatOffset(float offset, bool fillViewRect = false)
	{
	}

	// Token: 0x0600084E RID: 2126 RVA: 0x00004A10 File Offset: 0x00002C10
	[Token(Token = "0x600084E")]
	[Address(RVA = "0x348122C", Offset = "0x348122C", VA = "0x348122C")]
	protected float NewItemAtStart()
	{
		return 0f;
	}

	// Token: 0x0600084F RID: 2127 RVA: 0x00004A28 File Offset: 0x00002C28
	[Token(Token = "0x600084F")]
	[Address(RVA = "0x348160C", Offset = "0x348160C", VA = "0x348160C")]
	protected float DeleteItemAtStart()
	{
		return 0f;
	}

	// Token: 0x06000850 RID: 2128 RVA: 0x00004A40 File Offset: 0x00002C40
	[Token(Token = "0x6000850")]
	[Address(RVA = "0x3481084", Offset = "0x3481084", VA = "0x3481084")]
	protected float NewItemAtEnd()
	{
		return 0f;
	}

	// Token: 0x06000851 RID: 2129 RVA: 0x00004A58 File Offset: 0x00002C58
	[Token(Token = "0x6000851")]
	[Address(RVA = "0x34813A0", Offset = "0x34813A0", VA = "0x34813A0")]
	protected float DeleteItemAtEnd()
	{
		return 0f;
	}

	// Token: 0x06000852 RID: 2130 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000852")]
	[Address(RVA = "0x34835F8", Offset = "0x34835F8", VA = "0x34835F8")]
	private RectTransform InstantiateNextItem(int itemIdx)
	{
		return null;
	}

	// Token: 0x06000853 RID: 2131 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000853")]
	[Address(RVA = "0x34839EC", Offset = "0x34839EC", VA = "0x34839EC", Slot = "40")]
	public virtual void Rebuild(CanvasUpdate executing)
	{
	}

	// Token: 0x06000854 RID: 2132 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000854")]
	[Address(RVA = "0x34844DC", Offset = "0x34844DC", VA = "0x34844DC", Slot = "41")]
	public virtual void LayoutComplete()
	{
	}

	// Token: 0x06000855 RID: 2133 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000855")]
	[Address(RVA = "0x34844E0", Offset = "0x34844E0", VA = "0x34844E0", Slot = "42")]
	public virtual void GraphicUpdateComplete()
	{
	}

	// Token: 0x06000856 RID: 2134 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000856")]
	[Address(RVA = "0x3483A7C", Offset = "0x3483A7C", VA = "0x3483A7C")]
	private void UpdateCachedData()
	{
	}

	// Token: 0x06000857 RID: 2135 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000857")]
	[Address(RVA = "0x34844E4", Offset = "0x34844E4", VA = "0x34844E4", Slot = "5")]
	protected override void OnEnable()
	{
	}

	// Token: 0x06000858 RID: 2136 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000858")]
	[Address(RVA = "0x348471C", Offset = "0x348471C", VA = "0x348471C", Slot = "7")]
	protected override void OnDisable()
	{
	}

	// Token: 0x06000859 RID: 2137 RVA: 0x00004A70 File Offset: 0x00002C70
	[Token(Token = "0x6000859")]
	[Address(RVA = "0x34849DC", Offset = "0x34849DC", VA = "0x34849DC", Slot = "9")]
	public override bool IsActive()
	{
		return default(bool);
	}

	// Token: 0x0600085A RID: 2138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600085A")]
	[Address(RVA = "0x3484A5C", Offset = "0x3484A5C", VA = "0x3484A5C")]
	private void EnsureLayoutHasRebuilt()
	{
	}

	// Token: 0x0600085B RID: 2139 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600085B")]
	[Address(RVA = "0x3484AD0", Offset = "0x3484AD0", VA = "0x3484AD0", Slot = "43")]
	public virtual void StopMovement()
	{
	}

	// Token: 0x0600085C RID: 2140 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600085C")]
	[Address(RVA = "0x3484B20", Offset = "0x3484B20", VA = "0x3484B20", Slot = "44")]
	public virtual void OnScroll(PointerEventData data)
	{
	}

	// Token: 0x0600085D RID: 2141 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600085D")]
	[Address(RVA = "0x3484E1C", Offset = "0x3484E1C", VA = "0x3484E1C", Slot = "45")]
	public virtual void OnInitializePotentialDrag(PointerEventData eventData)
	{
	}

	// Token: 0x0600085E RID: 2142 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600085E")]
	[Address(RVA = "0x3484E7C", Offset = "0x3484E7C", VA = "0x3484E7C", Slot = "38")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x0600085F RID: 2143 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600085F")]
	private void RoutePointerEvent<T>(PointerEventData eventData, ExecuteEvents.EventFunction<T> functor) where T : IEventSystemHandler
	{
	}

	// Token: 0x06000860 RID: 2144 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000860")]
	[Address(RVA = "0x3482684", Offset = "0x3482684", VA = "0x3482684")]
	private void ClearRoute()
	{
	}

	// Token: 0x06000861 RID: 2145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000861")]
	[Address(RVA = "0x3484E84", Offset = "0x3484E84", VA = "0x3484E84", Slot = "46")]
	public virtual void OnBeginDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06000862 RID: 2146 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000862")]
	[Address(RVA = "0x34850F4", Offset = "0x34850F4", VA = "0x34850F4", Slot = "47")]
	public virtual void OnEndDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06000863 RID: 2147 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000863")]
	[Address(RVA = "0x34851E0", Offset = "0x34851E0", VA = "0x34851E0", Slot = "48")]
	public virtual void OnDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06000864 RID: 2148 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000864")]
	[Address(RVA = "0x34854B8", Offset = "0x34854B8", VA = "0x34854B8", Slot = "49")]
	protected virtual void SetContentAnchoredPosition(Vector2 position)
	{
	}

	// Token: 0x06000865 RID: 2149 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000865")]
	[Address(RVA = "0x3485578", Offset = "0x3485578", VA = "0x3485578", Slot = "50")]
	protected virtual void LateUpdate()
	{
	}

	// Token: 0x06000866 RID: 2150 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000866")]
	[Address(RVA = "0x34843F0", Offset = "0x34843F0", VA = "0x34843F0")]
	private void UpdatePrevData()
	{
	}

	// Token: 0x06000867 RID: 2151 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000867")]
	[Address(RVA = "0x3484198", Offset = "0x3484198", VA = "0x3484198")]
	private void UpdateScrollbars(Vector2 offset)
	{
	}

	// Token: 0x1700011F RID: 287
	// (get) Token: 0x06000868 RID: 2152 RVA: 0x00004A88 File Offset: 0x00002C88
	// (set) Token: 0x06000869 RID: 2153 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700011F")]
	public Vector2 normalizedPosition
	{
		[Token(Token = "0x6000868")]
		[Address(RVA = "0x3485C1C", Offset = "0x3485C1C", VA = "0x3485C1C")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000869")]
		[Address(RVA = "0x3485E4C", Offset = "0x3485E4C", VA = "0x3485E4C")]
		set
		{
		}
	}

	// Token: 0x17000120 RID: 288
	// (get) Token: 0x0600086A RID: 2154 RVA: 0x00004AA0 File Offset: 0x00002CA0
	// (set) Token: 0x0600086B RID: 2155 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000120")]
	public float horizontalNormalizedPosition
	{
		[Token(Token = "0x600086A")]
		[Address(RVA = "0x3485C4C", Offset = "0x3485C4C", VA = "0x3485C4C")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600086B")]
		[Address(RVA = "0x34861B0", Offset = "0x34861B0", VA = "0x34861B0")]
		set
		{
		}
	}

	// Token: 0x17000121 RID: 289
	// (get) Token: 0x0600086C RID: 2156 RVA: 0x00004AB8 File Offset: 0x00002CB8
	// (set) Token: 0x0600086D RID: 2157 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000121")]
	public float verticalNormalizedPosition
	{
		[Token(Token = "0x600086C")]
		[Address(RVA = "0x3485D4C", Offset = "0x3485D4C", VA = "0x3485D4C")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600086D")]
		[Address(RVA = "0x34861B8", Offset = "0x34861B8", VA = "0x34861B8")]
		set
		{
		}
	}

	// Token: 0x0600086E RID: 2158 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600086E")]
	[Address(RVA = "0x34861C0", Offset = "0x34861C0", VA = "0x34861C0")]
	private void SetHorizontalNormalizedPosition(float value)
	{
	}

	// Token: 0x0600086F RID: 2159 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600086F")]
	[Address(RVA = "0x34861C8", Offset = "0x34861C8", VA = "0x34861C8")]
	private void SetVerticalNormalizedPosition(float value)
	{
	}

	// Token: 0x06000870 RID: 2160 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000870")]
	[Address(RVA = "0x3485E7C", Offset = "0x3485E7C", VA = "0x3485E7C")]
	private void SetNormalizedPosition(float value, int axis)
	{
	}

	// Token: 0x06000871 RID: 2161 RVA: 0x00004AD0 File Offset: 0x00002CD0
	[Token(Token = "0x6000871")]
	[Address(RVA = "0x348547C", Offset = "0x348547C", VA = "0x348547C")]
	private static float RubberDelta(float overStretching, float viewSize)
	{
		return 0f;
	}

	// Token: 0x06000872 RID: 2162 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000872")]
	[Address(RVA = "0x34861D0", Offset = "0x34861D0", VA = "0x34861D0", Slot = "10")]
	protected override void OnRectTransformDimensionsChange()
	{
	}

	// Token: 0x17000122 RID: 290
	// (get) Token: 0x06000873 RID: 2163 RVA: 0x00004AE8 File Offset: 0x00002CE8
	[Token(Token = "0x17000122")]
	private bool hScrollingNeeded
	{
		[Token(Token = "0x6000873")]
		[Address(RVA = "0x34861D4", Offset = "0x34861D4", VA = "0x34861D4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000123 RID: 291
	// (get) Token: 0x06000874 RID: 2164 RVA: 0x00004B00 File Offset: 0x00002D00
	[Token(Token = "0x17000123")]
	private bool vScrollingNeeded
	{
		[Token(Token = "0x6000874")]
		[Address(RVA = "0x3486230", Offset = "0x3486230", VA = "0x3486230")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000875 RID: 2165 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000875")]
	[Address(RVA = "0x348628C", Offset = "0x348628C", VA = "0x348628C", Slot = "51")]
	public virtual void CalculateLayoutInputHorizontal()
	{
	}

	// Token: 0x06000876 RID: 2166 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000876")]
	[Address(RVA = "0x3486290", Offset = "0x3486290", VA = "0x3486290", Slot = "52")]
	public virtual void CalculateLayoutInputVertical()
	{
	}

	// Token: 0x17000124 RID: 292
	// (get) Token: 0x06000877 RID: 2167 RVA: 0x00004B18 File Offset: 0x00002D18
	[Token(Token = "0x17000124")]
	public virtual float minWidth
	{
		[Token(Token = "0x6000877")]
		[Address(RVA = "0x3486294", Offset = "0x3486294", VA = "0x3486294", Slot = "53")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000125 RID: 293
	// (get) Token: 0x06000878 RID: 2168 RVA: 0x00004B30 File Offset: 0x00002D30
	[Token(Token = "0x17000125")]
	public virtual float preferredWidth
	{
		[Token(Token = "0x6000878")]
		[Address(RVA = "0x348629C", Offset = "0x348629C", VA = "0x348629C", Slot = "54")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000126 RID: 294
	// (get) Token: 0x06000879 RID: 2169 RVA: 0x00004B48 File Offset: 0x00002D48
	// (set) Token: 0x0600087A RID: 2170 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000126")]
	public virtual float flexibleWidth
	{
		[Token(Token = "0x6000879")]
		[Address(RVA = "0x34862A4", Offset = "0x34862A4", VA = "0x34862A4", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600087A")]
		[Address(RVA = "0x34862AC", Offset = "0x34862AC", VA = "0x34862AC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000127 RID: 295
	// (get) Token: 0x0600087B RID: 2171 RVA: 0x00004B60 File Offset: 0x00002D60
	[Token(Token = "0x17000127")]
	public virtual float minHeight
	{
		[Token(Token = "0x600087B")]
		[Address(RVA = "0x34862B4", Offset = "0x34862B4", VA = "0x34862B4", Slot = "56")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000128 RID: 296
	// (get) Token: 0x0600087C RID: 2172 RVA: 0x00004B78 File Offset: 0x00002D78
	[Token(Token = "0x17000128")]
	public virtual float preferredHeight
	{
		[Token(Token = "0x600087C")]
		[Address(RVA = "0x34862BC", Offset = "0x34862BC", VA = "0x34862BC", Slot = "57")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000129 RID: 297
	// (get) Token: 0x0600087D RID: 2173 RVA: 0x00004B90 File Offset: 0x00002D90
	[Token(Token = "0x17000129")]
	public virtual float flexibleHeight
	{
		[Token(Token = "0x600087D")]
		[Address(RVA = "0x34862C4", Offset = "0x34862C4", VA = "0x34862C4", Slot = "58")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700012A RID: 298
	// (get) Token: 0x0600087E RID: 2174 RVA: 0x00004BA8 File Offset: 0x00002DA8
	[Token(Token = "0x1700012A")]
	public virtual int layoutPriority
	{
		[Token(Token = "0x600087E")]
		[Address(RVA = "0x34862CC", Offset = "0x34862CC", VA = "0x34862CC", Slot = "59")]
		get
		{
			return 0;
		}
	}

	// Token: 0x0600087F RID: 2175 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600087F")]
	[Address(RVA = "0x34862D4", Offset = "0x34862D4", VA = "0x34862D4", Slot = "60")]
	public virtual void SetLayoutHorizontal()
	{
	}

	// Token: 0x06000880 RID: 2176 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000880")]
	[Address(RVA = "0x3486A84", Offset = "0x3486A84", VA = "0x3486A84", Slot = "61")]
	public virtual void SetLayoutVertical()
	{
	}

	// Token: 0x06000881 RID: 2177 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000881")]
	[Address(RVA = "0x3485AB8", Offset = "0x3485AB8", VA = "0x3485AB8")]
	private void UpdateScrollbarVisibility()
	{
	}

	// Token: 0x06000882 RID: 2178 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000882")]
	[Address(RVA = "0x3486B60", Offset = "0x3486B60", VA = "0x3486B60")]
	private void UpdateScrollbarLayout()
	{
	}

	// Token: 0x06000883 RID: 2179 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000883")]
	[Address(RVA = "0x3483E14", Offset = "0x3483E14", VA = "0x3483E14")]
	private void UpdateBounds(bool updateItems = false, bool checkBounds = false)
	{
	}

	// Token: 0x06000884 RID: 2180 RVA: 0x00004BC0 File Offset: 0x00002DC0
	[Token(Token = "0x6000884")]
	[Address(RVA = "0x3486824", Offset = "0x3486824", VA = "0x3486824")]
	private Bounds GetBounds()
	{
		return default(Bounds);
	}

	// Token: 0x06000885 RID: 2181 RVA: 0x00004BD8 File Offset: 0x00002DD8
	[Token(Token = "0x6000885")]
	[Address(RVA = "0x3486DB4", Offset = "0x3486DB4", VA = "0x3486DB4")]
	private Bounds GetBounds4Item(int index)
	{
		return default(Bounds);
	}

	// Token: 0x06000886 RID: 2182 RVA: 0x00004BF0 File Offset: 0x00002DF0
	[Token(Token = "0x6000886")]
	[Address(RVA = "0x3484C68", Offset = "0x3484C68", VA = "0x3484C68")]
	private Vector2 CalculateOffset(Vector2 delta)
	{
		return default(Vector2);
	}

	// Token: 0x06000887 RID: 2183 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000887")]
	[Address(RVA = "0x3481CF8", Offset = "0x3481CF8", VA = "0x3481CF8")]
	protected void SetDirty()
	{
	}

	// Token: 0x06000888 RID: 2184 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000888")]
	[Address(RVA = "0x34818E0", Offset = "0x34818E0", VA = "0x34818E0")]
	protected void SetDirtyCaching()
	{
	}

	// Token: 0x06000889 RID: 2185 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000889")]
	[Address(RVA = "0x34836D0", Offset = "0x34836D0", VA = "0x34836D0")]
	private GameObject GetItemObject(Transform parent, bool worldPositionStays)
	{
		return null;
	}

	// Token: 0x0600088A RID: 2186 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600088A")]
	[Address(RVA = "0x3482718", Offset = "0x3482718", VA = "0x3482718")]
	private void ReturnItemObject(GameObject go)
	{
	}

	// Token: 0x0600088B RID: 2187 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600088B")]
	[Address(RVA = "0x3482F18", Offset = "0x3482F18", VA = "0x3482F18")]
	private void OnItemMoveIn(GameObject itemObj, int index)
	{
	}

	// Token: 0x0600088C RID: 2188 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600088C")]
	[Address(RVA = "0x3482EFC", Offset = "0x3482EFC", VA = "0x3482EFC")]
	private void OnItemMoveOut(GameObject itemObj, int index)
	{
	}

	// Token: 0x0600088D RID: 2189 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600088D")]
	[Address(RVA = "0x3482058", Offset = "0x3482058", VA = "0x3482058")]
	private void CheckComponentConflict()
	{
	}

	// Token: 0x0600088E RID: 2190 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600088E")]
	[Address(RVA = "0x3487064", Offset = "0x3487064", VA = "0x3487064")]
	public ScrollView()
	{
	}

	// Token: 0x0600088F RID: 2191 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600088F")]
	[Address(RVA = "0x3487218", Offset = "0x3487218", VA = "0x3487218", Slot = "23")]
	private Transform UnityEngine.UI.ICanvasElement.get_transform()
	{
		return null;
	}

	// Token: 0x04000600 RID: 1536
	[Token(Token = "0x4000600")]
	[FieldOffset(Offset = "0x0")]
	private static GameObject objectPoolRoot;

	// Token: 0x04000601 RID: 1537
	[Token(Token = "0x4000601")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject itemTemplate;

	// Token: 0x04000602 RID: 1538
	[Token(Token = "0x4000602")]
	[FieldOffset(Offset = "0x20")]
	private List<ScrollView.ItemObject> itemObjectPool;

	// Token: 0x04000603 RID: 1539
	[Token(Token = "0x4000603")]
	[FieldOffset(Offset = "0x28")]
	[Tooltip("Total count, negative means INFINITE mode")]
	public int totalCount;

	// Token: 0x04000604 RID: 1540
	[Token(Token = "0x4000604")]
	[FieldOffset(Offset = "0x2C")]
	protected float threshold;

	// Token: 0x04000605 RID: 1541
	[Token(Token = "0x4000605")]
	[FieldOffset(Offset = "0x30")]
	[Tooltip("Reverse direction for dragging")]
	public bool reverseDirection;

	// Token: 0x04000606 RID: 1542
	[Token(Token = "0x4000606")]
	[FieldOffset(Offset = "0x34")]
	[Tooltip("Rubber scale for outside")]
	public float rubberScale;

	// Token: 0x04000607 RID: 1543
	[Token(Token = "0x4000607")]
	[FieldOffset(Offset = "0x38")]
	protected int itemTypeStart;

	// Token: 0x04000608 RID: 1544
	[Token(Token = "0x4000608")]
	[FieldOffset(Offset = "0x3C")]
	protected int itemTypeEnd;

	// Token: 0x04000609 RID: 1545
	[Token(Token = "0x4000609")]
	[FieldOffset(Offset = "0x40")]
	private Vector2 extraFillSize;

	// Token: 0x0400060A RID: 1546
	[Token(Token = "0x400060A")]
	[FieldOffset(Offset = "0x48")]
	protected int directionSign;

	// Token: 0x0400060B RID: 1547
	[Token(Token = "0x400060B")]
	[FieldOffset(Offset = "0x4C")]
	private float m_ContentSpacing;

	// Token: 0x0400060C RID: 1548
	[Token(Token = "0x400060C")]
	[FieldOffset(Offset = "0x50")]
	protected GridLayoutGroup m_GridLayout;

	// Token: 0x0400060D RID: 1549
	[Token(Token = "0x400060D")]
	[FieldOffset(Offset = "0x58")]
	public int m_ContentConstraintCount;

	// Token: 0x0400060E RID: 1550
	[Token(Token = "0x400060E")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private ScrollView.ScrollViewLayoutType layoutType;

	// Token: 0x0400060F RID: 1551
	[Token(Token = "0x400060F")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private RectTransform m_Content;

	// Token: 0x04000610 RID: 1552
	[Token(Token = "0x4000610")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private ScrollView.MovementType m_MovementType;

	// Token: 0x04000611 RID: 1553
	[Token(Token = "0x4000611")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private float m_Elasticity;

	// Token: 0x04000612 RID: 1554
	[Token(Token = "0x4000612")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private bool m_Inertia;

	// Token: 0x04000613 RID: 1555
	[Token(Token = "0x4000613")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	private float m_DecelerationRate;

	// Token: 0x04000614 RID: 1556
	[Token(Token = "0x4000614")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private float m_ScrollSensitivity;

	// Token: 0x04000615 RID: 1557
	[Token(Token = "0x4000615")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private RectTransform m_Viewport;

	// Token: 0x04000616 RID: 1558
	[Token(Token = "0x4000616")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Scrollbar m_HorizontalScrollbar;

	// Token: 0x04000617 RID: 1559
	[Token(Token = "0x4000617")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Scrollbar m_VerticalScrollbar;

	// Token: 0x04000618 RID: 1560
	[Token(Token = "0x4000618")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private ScrollView.ScrollbarVisibility m_HorizontalScrollbarVisibility;

	// Token: 0x04000619 RID: 1561
	[Token(Token = "0x4000619")]
	[FieldOffset(Offset = "0x9C")]
	[SerializeField]
	private ScrollView.ScrollbarVisibility m_VerticalScrollbarVisibility;

	// Token: 0x0400061A RID: 1562
	[Token(Token = "0x400061A")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private float m_HorizontalScrollbarSpacing;

	// Token: 0x0400061B RID: 1563
	[Token(Token = "0x400061B")]
	[FieldOffset(Offset = "0xA4")]
	[SerializeField]
	private float m_VerticalScrollbarSpacing;

	// Token: 0x0400061C RID: 1564
	[Token(Token = "0x400061C")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private ScrollView.ScrollRectEvent m_OnValueChanged;

	// Token: 0x0400061D RID: 1565
	[Token(Token = "0x400061D")]
	[FieldOffset(Offset = "0xB0")]
	private Vector2 m_PointerStartLocalCursor;

	// Token: 0x0400061E RID: 1566
	[Token(Token = "0x400061E")]
	[FieldOffset(Offset = "0xB8")]
	private Vector2 m_ContentStartPosition;

	// Token: 0x0400061F RID: 1567
	[Token(Token = "0x400061F")]
	[FieldOffset(Offset = "0xC0")]
	private RectTransform m_ViewRect;

	// Token: 0x04000620 RID: 1568
	[Token(Token = "0x4000620")]
	[FieldOffset(Offset = "0xC8")]
	private Bounds m_ContentBounds;

	// Token: 0x04000621 RID: 1569
	[Token(Token = "0x4000621")]
	[FieldOffset(Offset = "0xE0")]
	private Bounds m_ViewBounds;

	// Token: 0x04000622 RID: 1570
	[Token(Token = "0x4000622")]
	[FieldOffset(Offset = "0xF8")]
	private Vector2 m_Velocity;

	// Token: 0x04000623 RID: 1571
	[Token(Token = "0x4000623")]
	[FieldOffset(Offset = "0x100")]
	private bool m_Dragging;

	// Token: 0x04000624 RID: 1572
	[Token(Token = "0x4000624")]
	[FieldOffset(Offset = "0x101")]
	private bool m_viewportChanged;

	// Token: 0x04000625 RID: 1573
	[Token(Token = "0x4000625")]
	[FieldOffset(Offset = "0x104")]
	private Vector2 m_PrevPosition;

	// Token: 0x04000626 RID: 1574
	[Token(Token = "0x4000626")]
	[FieldOffset(Offset = "0x10C")]
	private Bounds m_PrevContentBounds;

	// Token: 0x04000627 RID: 1575
	[Token(Token = "0x4000627")]
	[FieldOffset(Offset = "0x124")]
	private Bounds m_PrevViewBounds;

	// Token: 0x04000628 RID: 1576
	[Token(Token = "0x4000628")]
	[FieldOffset(Offset = "0x13C")]
	[NonSerialized]
	private bool m_HasRebuiltLayout;

	// Token: 0x04000629 RID: 1577
	[Token(Token = "0x4000629")]
	[FieldOffset(Offset = "0x13D")]
	private bool m_HSliderExpand;

	// Token: 0x0400062A RID: 1578
	[Token(Token = "0x400062A")]
	[FieldOffset(Offset = "0x13E")]
	private bool m_VSliderExpand;

	// Token: 0x0400062B RID: 1579
	[Token(Token = "0x400062B")]
	[FieldOffset(Offset = "0x140")]
	private float m_HSliderHeight;

	// Token: 0x0400062C RID: 1580
	[Token(Token = "0x400062C")]
	[FieldOffset(Offset = "0x144")]
	private float m_VSliderWidth;

	// Token: 0x0400062D RID: 1581
	[Token(Token = "0x400062D")]
	[FieldOffset(Offset = "0x148")]
	[NonSerialized]
	private RectTransform m_Rect;

	// Token: 0x0400062E RID: 1582
	[Token(Token = "0x400062E")]
	[FieldOffset(Offset = "0x150")]
	private RectTransform m_HorizontalScrollbarRect;

	// Token: 0x0400062F RID: 1583
	[Token(Token = "0x400062F")]
	[FieldOffset(Offset = "0x158")]
	private RectTransform m_VerticalScrollbarRect;

	// Token: 0x04000630 RID: 1584
	[Token(Token = "0x4000630")]
	[FieldOffset(Offset = "0x160")]
	private DrivenRectTransformTracker m_Tracker;

	// Token: 0x04000631 RID: 1585
	[Token(Token = "0x4000631")]
	[FieldOffset(Offset = "0x161")]
	public bool nestedScrolling;

	// Token: 0x04000632 RID: 1586
	[Token(Token = "0x4000632")]
	[FieldOffset(Offset = "0x162")]
	private bool _routing;

	// Token: 0x04000633 RID: 1587
	[Token(Token = "0x4000633")]
	[FieldOffset(Offset = "0x168")]
	private GameObject _routeObject;

	// Token: 0x04000635 RID: 1589
	[Token(Token = "0x4000635")]
	[FieldOffset(Offset = "0x178")]
	private readonly Vector3[] m_Corners;

	// Token: 0x04000636 RID: 1590
	[Token(Token = "0x4000636")]
	[FieldOffset(Offset = "0x180")]
	public ScrollView.MoveItemDelegate onItemMoveIn;

	// Token: 0x04000637 RID: 1591
	[Token(Token = "0x4000637")]
	[FieldOffset(Offset = "0x188")]
	public ScrollView.MoveItemDelegate onItemMoveOut;

	// Token: 0x02000121 RID: 289
	[Token(Token = "0x2000121")]
	private class ItemObject
	{
		// Token: 0x06000890 RID: 2192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000890")]
		[Address(RVA = "0x33A56B0", Offset = "0x33A56B0", VA = "0x33A56B0")]
		public ItemObject()
		{
		}

		// Token: 0x04000638 RID: 1592
		[Token(Token = "0x4000638")]
		[FieldOffset(Offset = "0x10")]
		public bool used;

		// Token: 0x04000639 RID: 1593
		[Token(Token = "0x4000639")]
		[FieldOffset(Offset = "0x18")]
		public GameObject gameObject;
	}

	// Token: 0x02000122 RID: 290
	[Token(Token = "0x2000122")]
	public enum MovementType
	{
		// Token: 0x0400063B RID: 1595
		[Token(Token = "0x400063B")]
		Unrestricted,
		// Token: 0x0400063C RID: 1596
		[Token(Token = "0x400063C")]
		Elastic,
		// Token: 0x0400063D RID: 1597
		[Token(Token = "0x400063D")]
		Clamped
	}

	// Token: 0x02000123 RID: 291
	[Token(Token = "0x2000123")]
	public enum ScrollbarVisibility
	{
		// Token: 0x0400063F RID: 1599
		[Token(Token = "0x400063F")]
		Permanent,
		// Token: 0x04000640 RID: 1600
		[Token(Token = "0x4000640")]
		AutoHide,
		// Token: 0x04000641 RID: 1601
		[Token(Token = "0x4000641")]
		AutoHideAndExpandViewport
	}

	// Token: 0x02000124 RID: 292
	[Token(Token = "0x2000124")]
	public enum ScrollViewLayoutType
	{
		// Token: 0x04000643 RID: 1603
		[Token(Token = "0x4000643")]
		Horizontal,
		// Token: 0x04000644 RID: 1604
		[Token(Token = "0x4000644")]
		Vertical
	}

	// Token: 0x02000125 RID: 293
	[Token(Token = "0x2000125")]
	[Serializable]
	public class ScrollRectEvent : UnityEvent<Vector2>
	{
		// Token: 0x06000891 RID: 2193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000891")]
		[Address(RVA = "0x33A56B8", Offset = "0x33A56B8", VA = "0x33A56B8")]
		public ScrollRectEvent()
		{
		}
	}

	// Token: 0x02000126 RID: 294
	// (Invoke) Token: 0x06000893 RID: 2195
	[Token(Token = "0x2000126")]
	public delegate void MoveItemDelegate(GameObject itemObj, int index);
}
