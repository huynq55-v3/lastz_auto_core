using System;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000CB0 RID: 3248
	[Token(Token = "0x2000CB0")]
	public class Button_LongPress : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerClickHandler
	{
		// Token: 0x06007AD4 RID: 31444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AD4")]
		[Address(RVA = "0x321D7E8", Offset = "0x321D7E8", VA = "0x321D7E8")]
		public void SetTouchBgGray(bool gray)
		{
		}

		// Token: 0x06007AD5 RID: 31445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AD5")]
		[Address(RVA = "0x321D7F4", Offset = "0x321D7F4", VA = "0x321D7F4")]
		public void SetLongPressAction(Action _action)
		{
		}

		// Token: 0x06007AD6 RID: 31446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AD6")]
		[Address(RVA = "0x321D7FC", Offset = "0x321D7FC", VA = "0x321D7FC")]
		public void SetClickAction(Action action)
		{
		}

		// Token: 0x06007AD7 RID: 31447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AD7")]
		[Address(RVA = "0x321D804", Offset = "0x321D804", VA = "0x321D804")]
		private void Start()
		{
		}

		// Token: 0x06007AD8 RID: 31448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AD8")]
		[Address(RVA = "0x321D85C", Offset = "0x321D85C", VA = "0x321D85C")]
		private void OnEnable()
		{
		}

		// Token: 0x06007AD9 RID: 31449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AD9")]
		[Address(RVA = "0x321D8F8", Offset = "0x321D8F8", VA = "0x321D8F8")]
		private void OnDisable()
		{
		}

		// Token: 0x06007ADA RID: 31450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ADA")]
		[Address(RVA = "0x321D9A0", Offset = "0x321D9A0", VA = "0x321D9A0")]
		private void Update()
		{
		}

		// Token: 0x06007ADB RID: 31451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ADB")]
		[Address(RVA = "0x321DA18", Offset = "0x321DA18", VA = "0x321DA18", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x06007ADC RID: 31452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ADC")]
		[Address(RVA = "0x321DB64", Offset = "0x321DB64", VA = "0x321DB64", Slot = "5")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x06007ADD RID: 31453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ADD")]
		[Address(RVA = "0x321D860", Offset = "0x321D860", VA = "0x321D860")]
		public void ClearState()
		{
		}

		// Token: 0x06007ADE RID: 31454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ADE")]
		[Address(RVA = "0x321DC80", Offset = "0x321DC80", VA = "0x321DC80", Slot = "6")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06007ADF RID: 31455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ADF")]
		[Address(RVA = "0x321DCB4", Offset = "0x321DCB4", VA = "0x321DCB4")]
		public Button_LongPress()
		{
		}

		// Token: 0x04003612 RID: 13842
		[Token(Token = "0x4003612")]
		[FieldOffset(Offset = "0x18")]
		private Color32 gray;

		// Token: 0x04003613 RID: 13843
		[Token(Token = "0x4003613")]
		[FieldOffset(Offset = "0x1C")]
		public float pressDurationTime;

		// Token: 0x04003614 RID: 13844
		[Token(Token = "0x4003614")]
		[FieldOffset(Offset = "0x20")]
		public bool onceLongPress;

		// Token: 0x04003615 RID: 13845
		[Token(Token = "0x4003615")]
		[FieldOffset(Offset = "0x28")]
		private Action longPressAction;

		// Token: 0x04003616 RID: 13846
		[Token(Token = "0x4003616")]
		[FieldOffset(Offset = "0x30")]
		private Action clickAction;

		// Token: 0x04003617 RID: 13847
		[Token(Token = "0x4003617")]
		[FieldOffset(Offset = "0x38")]
		private Image[] bgImage;

		// Token: 0x04003618 RID: 13848
		[Token(Token = "0x4003618")]
		[FieldOffset(Offset = "0x40")]
		private bool _touchGray;

		// Token: 0x04003619 RID: 13849
		[Token(Token = "0x4003619")]
		[FieldOffset(Offset = "0x41")]
		private bool isDown;

		// Token: 0x0400361A RID: 13850
		[Token(Token = "0x400361A")]
		[FieldOffset(Offset = "0x44")]
		private float downTime;

		// Token: 0x0400361B RID: 13851
		[Token(Token = "0x400361B")]
		[FieldOffset(Offset = "0x48")]
		private bool donelongPressAction;
	}
}
