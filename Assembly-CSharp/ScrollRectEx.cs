using System;
using Il2CppDummyDll;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000119 RID: 281
[Token(Token = "0x2000119")]
public class ScrollRectEx : ScrollRect
{
	// Token: 0x06000800 RID: 2048 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000800")]
	private void DoForParents<T>(Action<T> action, bool onlyForFirstParent = false) where T : IEventSystemHandler
	{
	}

	// Token: 0x06000801 RID: 2049 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000801")]
	[Address(RVA = "0x347F9F0", Offset = "0x347F9F0", VA = "0x347F9F0", Slot = "43")]
	public override void OnInitializePotentialDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06000802 RID: 2050 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000802")]
	[Address(RVA = "0x347FAEC", Offset = "0x347FAEC", VA = "0x347FAEC", Slot = "46")]
	public override void OnDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06000803 RID: 2051 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000803")]
	[Address(RVA = "0x347FC00", Offset = "0x347FC00", VA = "0x347FC00", Slot = "44")]
	public override void OnBeginDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06000804 RID: 2052 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000804")]
	[Address(RVA = "0x347FDB8", Offset = "0x347FDB8", VA = "0x347FDB8", Slot = "45")]
	public override void OnEndDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06000805 RID: 2053 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000805")]
	[Address(RVA = "0x347FECC", Offset = "0x347FECC", VA = "0x347FECC")]
	public ScrollRectEx()
	{
	}

	// Token: 0x040005F3 RID: 1523
	[Token(Token = "0x40005F3")]
	[FieldOffset(Offset = "0x128")]
	private bool routeToParent;
}
