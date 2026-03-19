using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020000A6 RID: 166
[Token(Token = "0x20000A6")]
public class TouchObjectEventTrigger : MonoBehaviour, ITouchObjectPointerDownHandler, ITouchObject, ITouchObjectPointerUpHandler, ITouchObjectClickHandler, ITouchObjectDoubleClickHandler, ITouchObjectBeginDragHandler, ITouchObjectEndDragHandler, ITouchObjectDragHandler, ITouchObjectBeginLongTabHandler, ITouchObjectEndLongTabHandler, ITouchObjectPointerEnterHandler, ITouchObjectPointerExitHandler
{
	// Token: 0x17000094 RID: 148
	// (get) Token: 0x060003D5 RID: 981 RVA: 0x00003240 File Offset: 0x00001440
	// (set) Token: 0x060003D4 RID: 980 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000094")]
	public float Priority
	{
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x2F67210", Offset = "0x2F67210", VA = "0x2F67210", Slot = "5")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x2F67208", Offset = "0x2F67208", VA = "0x2F67208")]
		set
		{
		}
	}

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x060003D7 RID: 983 RVA: 0x00003258 File Offset: 0x00001458
	// (set) Token: 0x060003D6 RID: 982 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000095")]
	public float Distance
	{
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x2F67220", Offset = "0x2F67220", VA = "0x2F67220", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x2F67218", Offset = "0x2F67218", VA = "0x2F67218")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000096 RID: 150
	// (get) Token: 0x060003D8 RID: 984 RVA: 0x00003270 File Offset: 0x00001470
	[Token(Token = "0x17000096")]
	public Vector2Int TilePos
	{
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x2F67228", Offset = "0x2F67228", VA = "0x2F67228", Slot = "7")]
		get
		{
			return default(Vector2Int);
		}
	}

	// Token: 0x060003D9 RID: 985 RVA: 0x00003288 File Offset: 0x00001488
	[Token(Token = "0x60003D9")]
	[Address(RVA = "0x2F6729C", Offset = "0x2F6729C", VA = "0x2F6729C")]
	public int GetClickType()
	{
		return 0;
	}

	// Token: 0x060003DA RID: 986 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x2F672A4", Offset = "0x2F672A4", VA = "0x2F672A4")]
	public void SetClickType(int setType)
	{
	}

	// Token: 0x060003DB RID: 987 RVA: 0x000032A0 File Offset: 0x000014A0
	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x2F672AC", Offset = "0x2F672AC", VA = "0x2F672AC", Slot = "9")]
	public bool OnClick()
	{
		return default(bool);
	}

	// Token: 0x060003DC RID: 988 RVA: 0x000032B8 File Offset: 0x000014B8
	[Token(Token = "0x60003DC")]
	[Address(RVA = "0x2F672F0", Offset = "0x2F672F0", VA = "0x2F672F0", Slot = "10")]
	public bool OnDoubleClick()
	{
		return default(bool);
	}

	// Token: 0x060003DD RID: 989 RVA: 0x000032D0 File Offset: 0x000014D0
	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x2F67324", Offset = "0x2F67324", VA = "0x2F67324", Slot = "11")]
	public bool OnBeginDrag(Vector3 dragStartPos)
	{
		return default(bool);
	}

	// Token: 0x060003DE RID: 990 RVA: 0x000032E8 File Offset: 0x000014E8
	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x2F67358", Offset = "0x2F67358", VA = "0x2F67358", Slot = "12")]
	public bool OnEndDrag(Vector3 dragStopPos)
	{
		return default(bool);
	}

	// Token: 0x060003DF RID: 991 RVA: 0x00003300 File Offset: 0x00001500
	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x2F6738C", Offset = "0x2F6738C", VA = "0x2F6738C", Slot = "13")]
	public bool OnDrag(Vector3 dragStartPos, Vector3 dragCurrPos)
	{
		return default(bool);
	}

	// Token: 0x060003E0 RID: 992 RVA: 0x00003318 File Offset: 0x00001518
	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x2F673C0", Offset = "0x2F673C0", VA = "0x2F673C0", Slot = "14")]
	public bool OnBeginLongTap()
	{
		return default(bool);
	}

	// Token: 0x060003E1 RID: 993 RVA: 0x00003330 File Offset: 0x00001530
	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x2F673F4", Offset = "0x2F673F4", VA = "0x2F673F4", Slot = "15")]
	public bool OnEndLongTap()
	{
		return default(bool);
	}

	// Token: 0x060003E2 RID: 994 RVA: 0x00003348 File Offset: 0x00001548
	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x2F67428", Offset = "0x2F67428", VA = "0x2F67428", Slot = "16")]
	public bool OnPointerEnter()
	{
		return default(bool);
	}

	// Token: 0x060003E3 RID: 995 RVA: 0x00003360 File Offset: 0x00001560
	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x2F6745C", Offset = "0x2F6745C", VA = "0x2F6745C", Slot = "17")]
	public bool OnPointerExit()
	{
		return default(bool);
	}

	// Token: 0x060003E4 RID: 996 RVA: 0x00003378 File Offset: 0x00001578
	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x2F67490", Offset = "0x2F67490", VA = "0x2F67490", Slot = "4")]
	public bool OnPointerDown()
	{
		return default(bool);
	}

	// Token: 0x060003E5 RID: 997 RVA: 0x00003390 File Offset: 0x00001590
	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x2F674D4", Offset = "0x2F674D4", VA = "0x2F674D4", Slot = "8")]
	public bool OnPointerUp()
	{
		return default(bool);
	}

	// Token: 0x060003E6 RID: 998 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x2F67518", Offset = "0x2F67518", VA = "0x2F67518")]
	public void ClearAction()
	{
	}

	// Token: 0x060003E7 RID: 999 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E7")]
	[Address(RVA = "0x2F675D0", Offset = "0x2F675D0", VA = "0x2F675D0")]
	public TouchObjectEventTrigger()
	{
	}

	// Token: 0x0400036B RID: 875
	[Token(Token = "0x400036B")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float priority;

	// Token: 0x0400036D RID: 877
	[Token(Token = "0x400036D")]
	[FieldOffset(Offset = "0x20")]
	private int clickType;

	// Token: 0x0400036E RID: 878
	[Token(Token = "0x400036E")]
	[FieldOffset(Offset = "0x28")]
	public Action<Vector3> onBeginDrag;

	// Token: 0x0400036F RID: 879
	[Token(Token = "0x400036F")]
	[FieldOffset(Offset = "0x30")]
	public Action<Vector3, Vector3> onDrag;

	// Token: 0x04000370 RID: 880
	[Token(Token = "0x4000370")]
	[FieldOffset(Offset = "0x38")]
	public Action<Vector3> onEndDrag;

	// Token: 0x04000371 RID: 881
	[Token(Token = "0x4000371")]
	[FieldOffset(Offset = "0x40")]
	public Action onBeginLongTab;

	// Token: 0x04000372 RID: 882
	[Token(Token = "0x4000372")]
	[FieldOffset(Offset = "0x48")]
	public Action onEndLongTab;

	// Token: 0x04000373 RID: 883
	[Token(Token = "0x4000373")]
	[FieldOffset(Offset = "0x50")]
	public Action onPointerDown;

	// Token: 0x04000374 RID: 884
	[Token(Token = "0x4000374")]
	[FieldOffset(Offset = "0x58")]
	public Action onPointerClick;

	// Token: 0x04000375 RID: 885
	[Token(Token = "0x4000375")]
	[FieldOffset(Offset = "0x60")]
	public Action onPointerUp;

	// Token: 0x04000376 RID: 886
	[Token(Token = "0x4000376")]
	[FieldOffset(Offset = "0x68")]
	public Action onPointerDoubleClick;

	// Token: 0x04000377 RID: 887
	[Token(Token = "0x4000377")]
	[FieldOffset(Offset = "0x70")]
	public Action onPointerEnter;

	// Token: 0x04000378 RID: 888
	[Token(Token = "0x4000378")]
	[FieldOffset(Offset = "0x78")]
	public Action onPointerExit;

	// Token: 0x04000379 RID: 889
	[Token(Token = "0x4000379")]
	[FieldOffset(Offset = "0x80")]
	public UnityEvent onPointerClickEvent;

	// Token: 0x0400037A RID: 890
	[Token(Token = "0x400037A")]
	[FieldOffset(Offset = "0x88")]
	public UnityEvent onPointerUpEvent;

	// Token: 0x0400037B RID: 891
	[Token(Token = "0x400037B")]
	[FieldOffset(Offset = "0x90")]
	public UnityEvent onPointerDownEvent;
}
