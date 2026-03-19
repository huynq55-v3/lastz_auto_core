using System;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

// Token: 0x02000382 RID: 898
[Token(Token = "0x2000382")]
public class UIEventTrigger : EventTrigger
{
	// Token: 0x060016E2 RID: 5858 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016E2")]
	[Address(RVA = "0x1DAFD58", Offset = "0x1DAFD58", VA = "0x1DAFD58", Slot = "34")]
	public override void OnBeginDrag(PointerEventData data)
	{
	}

	// Token: 0x060016E3 RID: 5859 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016E3")]
	[Address(RVA = "0x1DAFD74", Offset = "0x1DAFD74", VA = "0x1DAFD74", Slot = "23")]
	public override void OnDrag(PointerEventData data)
	{
	}

	// Token: 0x060016E4 RID: 5860 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016E4")]
	[Address(RVA = "0x1DAFDA4", Offset = "0x1DAFDA4", VA = "0x1DAFDA4", Slot = "24")]
	public override void OnDrop(PointerEventData data)
	{
	}

	// Token: 0x060016E5 RID: 5861 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016E5")]
	[Address(RVA = "0x1DAFDC0", Offset = "0x1DAFDC0", VA = "0x1DAFDC0", Slot = "35")]
	public override void OnEndDrag(PointerEventData data)
	{
	}

	// Token: 0x060016E6 RID: 5862 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016E6")]
	[Address(RVA = "0x1DAFDDC", Offset = "0x1DAFDDC", VA = "0x1DAFDDC", Slot = "27")]
	public override void OnPointerClick(PointerEventData data)
	{
	}

	// Token: 0x060016E7 RID: 5863 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016E7")]
	[Address(RVA = "0x1DAFDF8", Offset = "0x1DAFDF8", VA = "0x1DAFDF8", Slot = "25")]
	public override void OnPointerDown(PointerEventData data)
	{
	}

	// Token: 0x060016E8 RID: 5864 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016E8")]
	[Address(RVA = "0x1DAFE58", Offset = "0x1DAFE58", VA = "0x1DAFE58", Slot = "32")]
	public override void OnUpdateSelected(BaseEventData data)
	{
	}

	// Token: 0x060016E9 RID: 5865 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016E9")]
	[Address(RVA = "0x1DAFEC4", Offset = "0x1DAFEC4", VA = "0x1DAFEC4", Slot = "21")]
	public override void OnPointerEnter(PointerEventData data)
	{
	}

	// Token: 0x060016EA RID: 5866 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016EA")]
	[Address(RVA = "0x1DAFEE0", Offset = "0x1DAFEE0", VA = "0x1DAFEE0", Slot = "22")]
	public override void OnPointerExit(PointerEventData data)
	{
	}

	// Token: 0x060016EB RID: 5867 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016EB")]
	[Address(RVA = "0x1DAFEFC", Offset = "0x1DAFEFC", VA = "0x1DAFEFC", Slot = "26")]
	public override void OnPointerUp(PointerEventData data)
	{
	}

	// Token: 0x060016EC RID: 5868 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016EC")]
	[Address(RVA = "0x1DAFF28", Offset = "0x1DAFF28", VA = "0x1DAFF28", Slot = "30")]
	public override void OnScroll(PointerEventData data)
	{
	}

	// Token: 0x060016ED RID: 5869 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016ED")]
	[Address(RVA = "0x1DAFF44", Offset = "0x1DAFF44", VA = "0x1DAFF44")]
	public UIEventTrigger()
	{
	}

	// Token: 0x040019F0 RID: 6640
	[Token(Token = "0x40019F0")]
	[FieldOffset(Offset = "0x20")]
	private bool mIsDown;

	// Token: 0x040019F1 RID: 6641
	[Token(Token = "0x40019F1")]
	[FieldOffset(Offset = "0x24")]
	private float mTimePressStarted;

	// Token: 0x040019F2 RID: 6642
	[Token(Token = "0x40019F2")]
	[FieldOffset(Offset = "0x28")]
	private PointerEventData mPointDownEventData;

	// Token: 0x040019F3 RID: 6643
	[Token(Token = "0x40019F3")]
	[FieldOffset(Offset = "0x30")]
	public float durationThreshold;

	// Token: 0x040019F4 RID: 6644
	[Token(Token = "0x40019F4")]
	[FieldOffset(Offset = "0x34")]
	private bool mLongPressTriggered;

	// Token: 0x040019F5 RID: 6645
	[Token(Token = "0x40019F5")]
	[FieldOffset(Offset = "0x35")]
	private bool mHasDragged;

	// Token: 0x040019F6 RID: 6646
	[Token(Token = "0x40019F6")]
	[FieldOffset(Offset = "0x38")]
	public Action<PointerEventData> onBeginDrag;

	// Token: 0x040019F7 RID: 6647
	[Token(Token = "0x40019F7")]
	[FieldOffset(Offset = "0x40")]
	public Action<PointerEventData> onDrag;

	// Token: 0x040019F8 RID: 6648
	[Token(Token = "0x40019F8")]
	[FieldOffset(Offset = "0x48")]
	public Action<PointerEventData> onDrop;

	// Token: 0x040019F9 RID: 6649
	[Token(Token = "0x40019F9")]
	[FieldOffset(Offset = "0x50")]
	public Action<PointerEventData> onEndDrag;

	// Token: 0x040019FA RID: 6650
	[Token(Token = "0x40019FA")]
	[FieldOffset(Offset = "0x58")]
	public Action<PointerEventData> onPointerClick;

	// Token: 0x040019FB RID: 6651
	[Token(Token = "0x40019FB")]
	[FieldOffset(Offset = "0x60")]
	public Action<PointerEventData> onPointerDown;

	// Token: 0x040019FC RID: 6652
	[Token(Token = "0x40019FC")]
	[FieldOffset(Offset = "0x68")]
	public Action<PointerEventData> onLongPress;

	// Token: 0x040019FD RID: 6653
	[Token(Token = "0x40019FD")]
	[FieldOffset(Offset = "0x70")]
	public Action<PointerEventData> onPointerEnter;

	// Token: 0x040019FE RID: 6654
	[Token(Token = "0x40019FE")]
	[FieldOffset(Offset = "0x78")]
	public Action<PointerEventData> onPointerExit;

	// Token: 0x040019FF RID: 6655
	[Token(Token = "0x40019FF")]
	[FieldOffset(Offset = "0x80")]
	public Action<PointerEventData> onPointerUp;

	// Token: 0x04001A00 RID: 6656
	[Token(Token = "0x4001A00")]
	[FieldOffset(Offset = "0x88")]
	public Action<PointerEventData> onScroll;
}
