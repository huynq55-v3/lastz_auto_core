using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SuperScrollView
{
	// Token: 0x020004B5 RID: 1205
	[Token(Token = "0x20004B5")]
	public class ClickEventListener : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler
	{
		// Token: 0x060023AF RID: 9135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023AF")]
		[Address(RVA = "0x2A05680", Offset = "0x2A05680", VA = "0x2A05680")]
		public static ClickEventListener Get(GameObject obj)
		{
			return null;
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x060023B0 RID: 9136 RVA: 0x0000D890 File Offset: 0x0000BA90
		[Token(Token = "0x17000550")]
		public bool IsPressd
		{
			[Token(Token = "0x60023B0")]
			[Address(RVA = "0x2A05740", Offset = "0x2A05740", VA = "0x2A05740")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060023B1 RID: 9137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B1")]
		[Address(RVA = "0x2A05748", Offset = "0x2A05748", VA = "0x2A05748", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x060023B2 RID: 9138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B2")]
		[Address(RVA = "0x2A0579C", Offset = "0x2A0579C", VA = "0x2A0579C")]
		public void SetClickEventHandler(Action<GameObject> handler)
		{
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B3")]
		[Address(RVA = "0x2A057A4", Offset = "0x2A057A4", VA = "0x2A057A4")]
		public void SetDoubleClickEventHandler(Action<GameObject> handler)
		{
		}

		// Token: 0x060023B4 RID: 9140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B4")]
		[Address(RVA = "0x2A057AC", Offset = "0x2A057AC", VA = "0x2A057AC")]
		public void SetPointerDownHandler(Action<GameObject> handler)
		{
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B5")]
		[Address(RVA = "0x2A057B4", Offset = "0x2A057B4", VA = "0x2A057B4")]
		public void SetPointerUpHandler(Action<GameObject> handler)
		{
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B6")]
		[Address(RVA = "0x2A057BC", Offset = "0x2A057BC", VA = "0x2A057BC", Slot = "5")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x060023B7 RID: 9143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B7")]
		[Address(RVA = "0x2A057FC", Offset = "0x2A057FC", VA = "0x2A057FC", Slot = "6")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x060023B8 RID: 9144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B8")]
		[Address(RVA = "0x2A05838", Offset = "0x2A05838", VA = "0x2A05838")]
		public ClickEventListener()
		{
		}

		// Token: 0x040020F8 RID: 8440
		[Token(Token = "0x40020F8")]
		[FieldOffset(Offset = "0x18")]
		private Action<GameObject> mClickedHandler;

		// Token: 0x040020F9 RID: 8441
		[Token(Token = "0x40020F9")]
		[FieldOffset(Offset = "0x20")]
		private Action<GameObject> mDoubleClickedHandler;

		// Token: 0x040020FA RID: 8442
		[Token(Token = "0x40020FA")]
		[FieldOffset(Offset = "0x28")]
		private Action<GameObject> mOnPointerDownHandler;

		// Token: 0x040020FB RID: 8443
		[Token(Token = "0x40020FB")]
		[FieldOffset(Offset = "0x30")]
		private Action<GameObject> mOnPointerUpHandler;

		// Token: 0x040020FC RID: 8444
		[Token(Token = "0x40020FC")]
		[FieldOffset(Offset = "0x38")]
		private bool mIsPressed;
	}
}
