using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000135 RID: 309
[Token(Token = "0x2000135")]
public class UIEventListener : EventTrigger
{
	// Token: 0x060008EB RID: 2283 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008EB")]
	[Address(RVA = "0x33AC450", Offset = "0x33AC450", VA = "0x33AC450")]
	public static UIEventListener Get(GameObject go)
	{
		return null;
	}

	// Token: 0x060008EC RID: 2284 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008EC")]
	[Address(RVA = "0x33AC510", Offset = "0x33AC510", VA = "0x33AC510", Slot = "23")]
	public override void OnDrag(PointerEventData eventData)
	{
	}

	// Token: 0x060008ED RID: 2285 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008ED")]
	[Address(RVA = "0x33AC56C", Offset = "0x33AC56C", VA = "0x33AC56C", Slot = "35")]
	public override void OnEndDrag(PointerEventData eventData)
	{
	}

	// Token: 0x060008EE RID: 2286 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008EE")]
	[Address(RVA = "0x33AC5C8", Offset = "0x33AC5C8", VA = "0x33AC5C8", Slot = "34")]
	public override void OnBeginDrag(PointerEventData eventData)
	{
	}

	// Token: 0x060008EF RID: 2287 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008EF")]
	[Address(RVA = "0x33AC624", Offset = "0x33AC624", VA = "0x33AC624", Slot = "27")]
	public override void OnPointerClick(PointerEventData eventData)
	{
	}

	// Token: 0x060008F0 RID: 2288 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F0")]
	[Address(RVA = "0x33AC65C", Offset = "0x33AC65C", VA = "0x33AC65C", Slot = "25")]
	public override void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x060008F1 RID: 2289 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F1")]
	[Address(RVA = "0x33AC694", Offset = "0x33AC694", VA = "0x33AC694", Slot = "21")]
	public override void OnPointerEnter(PointerEventData eventData)
	{
	}

	// Token: 0x060008F2 RID: 2290 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F2")]
	[Address(RVA = "0x33AC6CC", Offset = "0x33AC6CC", VA = "0x33AC6CC", Slot = "22")]
	public override void OnPointerExit(PointerEventData eventData)
	{
	}

	// Token: 0x060008F3 RID: 2291 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F3")]
	[Address(RVA = "0x33AC704", Offset = "0x33AC704", VA = "0x33AC704", Slot = "26")]
	public override void OnPointerUp(PointerEventData eventData)
	{
	}

	// Token: 0x060008F4 RID: 2292 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F4")]
	[Address(RVA = "0x33AC73C", Offset = "0x33AC73C", VA = "0x33AC73C", Slot = "28")]
	public override void OnSelect(BaseEventData eventData)
	{
	}

	// Token: 0x060008F5 RID: 2293 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F5")]
	[Address(RVA = "0x33AC774", Offset = "0x33AC774", VA = "0x33AC774", Slot = "32")]
	public override void OnUpdateSelected(BaseEventData eventData)
	{
	}

	// Token: 0x060008F6 RID: 2294 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F6")]
	[Address(RVA = "0x33AC7AC", Offset = "0x33AC7AC", VA = "0x33AC7AC")]
	public UIEventListener()
	{
	}

	// Token: 0x040006B4 RID: 1716
	[Token(Token = "0x40006B4")]
	[FieldOffset(Offset = "0x20")]
	public Action<GameObject> onClick;

	// Token: 0x040006B5 RID: 1717
	[Token(Token = "0x40006B5")]
	[FieldOffset(Offset = "0x28")]
	public Action<GameObject> onDown;

	// Token: 0x040006B6 RID: 1718
	[Token(Token = "0x40006B6")]
	[FieldOffset(Offset = "0x30")]
	public Action<GameObject> onEnter;

	// Token: 0x040006B7 RID: 1719
	[Token(Token = "0x40006B7")]
	[FieldOffset(Offset = "0x38")]
	public Action<GameObject> onExit;

	// Token: 0x040006B8 RID: 1720
	[Token(Token = "0x40006B8")]
	[FieldOffset(Offset = "0x40")]
	public Action<GameObject> onUp;

	// Token: 0x040006B9 RID: 1721
	[Token(Token = "0x40006B9")]
	[FieldOffset(Offset = "0x48")]
	public Action<GameObject> onSelect;

	// Token: 0x040006BA RID: 1722
	[Token(Token = "0x40006BA")]
	[FieldOffset(Offset = "0x50")]
	public Action<GameObject> onUpdateSelect;

	// Token: 0x040006BB RID: 1723
	[Token(Token = "0x40006BB")]
	[FieldOffset(Offset = "0x58")]
	public Action<GameObject, Vector2, Vector2> onDrag;

	// Token: 0x040006BC RID: 1724
	[Token(Token = "0x40006BC")]
	[FieldOffset(Offset = "0x60")]
	public Action<GameObject, Vector2, Vector2> onEndDrag;

	// Token: 0x040006BD RID: 1725
	[Token(Token = "0x40006BD")]
	[FieldOffset(Offset = "0x68")]
	public Action<GameObject, Vector2, Vector2> onBeginDrag;
}
