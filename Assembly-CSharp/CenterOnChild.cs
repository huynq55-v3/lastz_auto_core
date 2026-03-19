using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000159 RID: 345
[Token(Token = "0x2000159")]
public class CenterOnChild : MonoBehaviour, IEndDragHandler, IEventSystemHandler, IDragHandler
{
	// Token: 0x14000007 RID: 7
	// (add) Token: 0x060009F0 RID: 2544 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x060009F1 RID: 2545 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000007")]
	public event CenterOnChild.OnCenterHandler onCenter
	{
		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x33B7F6C", Offset = "0x33B7F6C", VA = "0x33B7F6C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x33B8008", Offset = "0x33B8008", VA = "0x33B8008")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x060009F2 RID: 2546 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009F2")]
	[Address(RVA = "0x33B80A4", Offset = "0x33B80A4", VA = "0x33B80A4")]
	private void Awake()
	{
	}

	// Token: 0x060009F3 RID: 2547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009F3")]
	[Address(RVA = "0x33B83A4", Offset = "0x33B83A4", VA = "0x33B83A4")]
	private void Update()
	{
	}

	// Token: 0x060009F4 RID: 2548 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009F4")]
	[Address(RVA = "0x33B847C", Offset = "0x33B847C", VA = "0x33B847C", Slot = "4")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	// Token: 0x060009F5 RID: 2549 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009F5")]
	[Address(RVA = "0x33B85B4", Offset = "0x33B85B4", VA = "0x33B85B4", Slot = "5")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	// Token: 0x060009F6 RID: 2550 RVA: 0x000050E8 File Offset: 0x000032E8
	[Token(Token = "0x60009F6")]
	[Address(RVA = "0x33B84B4", Offset = "0x33B84B4", VA = "0x33B84B4")]
	private float FindClosestPos(float currentPos)
	{
		return 0f;
	}

	// Token: 0x060009F7 RID: 2551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009F7")]
	[Address(RVA = "0x33B85BC", Offset = "0x33B85BC", VA = "0x33B85BC")]
	public CenterOnChild()
	{
	}

	// Token: 0x0400075E RID: 1886
	[Token(Token = "0x400075E")]
	[FieldOffset(Offset = "0x18")]
	public float centerSpeed;

	// Token: 0x04000760 RID: 1888
	[Token(Token = "0x4000760")]
	[FieldOffset(Offset = "0x28")]
	private ScrollRect _scrollView;

	// Token: 0x04000761 RID: 1889
	[Token(Token = "0x4000761")]
	[FieldOffset(Offset = "0x30")]
	private Transform _container;

	// Token: 0x04000762 RID: 1890
	[Token(Token = "0x4000762")]
	[FieldOffset(Offset = "0x38")]
	private List<float> _childrenPos;

	// Token: 0x04000763 RID: 1891
	[Token(Token = "0x4000763")]
	[FieldOffset(Offset = "0x40")]
	private float _targetPos;

	// Token: 0x04000764 RID: 1892
	[Token(Token = "0x4000764")]
	[FieldOffset(Offset = "0x44")]
	private bool _centering;

	// Token: 0x0200015A RID: 346
	// (Invoke) Token: 0x060009F9 RID: 2553
	[Token(Token = "0x200015A")]
	public delegate void OnCenterHandler(GameObject centerChild);
}
