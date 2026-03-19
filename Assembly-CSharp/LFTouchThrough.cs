using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x0200008F RID: 143
[Token(Token = "0x200008F")]
[DisallowMultipleComponent]
public class LFTouchThrough : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
	// Token: 0x0600036B RID: 875 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600036B")]
	private void PassEvent<T>(PointerEventData data, ExecuteEvents.EventFunction<T> function) where T : IEventSystemHandler
	{
	}

	// Token: 0x0600036C RID: 876 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600036C")]
	[Address(RVA = "0x32146BC", Offset = "0x32146BC", VA = "0x32146BC", Slot = "4")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	// Token: 0x0600036D RID: 877 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600036D")]
	[Address(RVA = "0x321478C", Offset = "0x321478C", VA = "0x321478C", Slot = "5")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	// Token: 0x0600036E RID: 878 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600036E")]
	[Address(RVA = "0x321485C", Offset = "0x321485C", VA = "0x321485C", Slot = "6")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	// Token: 0x0600036F RID: 879 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600036F")]
	[Address(RVA = "0x321492C", Offset = "0x321492C", VA = "0x321492C", Slot = "7")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06000370 RID: 880 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000370")]
	[Address(RVA = "0x32149FC", Offset = "0x32149FC", VA = "0x32149FC")]
	public void ToggleThrough(bool t)
	{
	}

	// Token: 0x06000371 RID: 881 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000371")]
	[Address(RVA = "0x3214A08", Offset = "0x3214A08", VA = "0x3214A08")]
	public void ToggleDrag(bool t)
	{
	}

	// Token: 0x06000372 RID: 882 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000372")]
	[Address(RVA = "0x3214A14", Offset = "0x3214A14", VA = "0x3214A14")]
	public LFTouchThrough()
	{
	}

	// Token: 0x040002FA RID: 762
	[Token(Token = "0x40002FA")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool _passClick;

	// Token: 0x040002FB RID: 763
	[Token(Token = "0x40002FB")]
	[FieldOffset(Offset = "0x19")]
	private bool _passDrag;
}
