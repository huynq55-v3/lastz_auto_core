using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Main.Scripts.UI
{
	// Token: 0x020004FF RID: 1279
	[Token(Token = "0x20004FF")]
	public class ClampedContentSizeFitter : ContentSizeFitter
	{
		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x060026AD RID: 9901 RVA: 0x0000E880 File Offset: 0x0000CA80
		// (set) Token: 0x060026AE RID: 9902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005CA")]
		public float maxWdith
		{
			[Token(Token = "0x60026AD")]
			[Address(RVA = "0x2B63224", Offset = "0x2B63224", VA = "0x2B63224")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60026AE")]
			[Address(RVA = "0x2B6322C", Offset = "0x2B6322C", VA = "0x2B6322C")]
			set
			{
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x060026AF RID: 9903 RVA: 0x0000E898 File Offset: 0x0000CA98
		// (set) Token: 0x060026B0 RID: 9904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005CB")]
		public float maxHeight
		{
			[Token(Token = "0x60026AF")]
			[Address(RVA = "0x2B63238", Offset = "0x2B63238", VA = "0x2B63238")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60026B0")]
			[Address(RVA = "0x2B63240", Offset = "0x2B63240", VA = "0x2B63240")]
			set
			{
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x060026B1 RID: 9905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005CC")]
		private RectTransform rectTransform
		{
			[Token(Token = "0x60026B1")]
			[Address(RVA = "0x2B6324C", Offset = "0x2B6324C", VA = "0x2B6324C")]
			get
			{
				return null;
			}
		}

		// Token: 0x060026B2 RID: 9906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B2")]
		[Address(RVA = "0x2B632F4", Offset = "0x2B632F4", VA = "0x2B632F4")]
		protected ClampedContentSizeFitter()
		{
		}

		// Token: 0x060026B3 RID: 9907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B3")]
		[Address(RVA = "0x2B63304", Offset = "0x2B63304", VA = "0x2B63304", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060026B4 RID: 9908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B4")]
		[Address(RVA = "0x2B63378", Offset = "0x2B63378", VA = "0x2B63378")]
		private void HandleSelfFittingAlongAxis(int axis)
		{
		}

		// Token: 0x060026B5 RID: 9909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B5")]
		[Address(RVA = "0x2B63470", Offset = "0x2B63470", VA = "0x2B63470", Slot = "19")]
		public override void SetLayoutHorizontal()
		{
		}

		// Token: 0x060026B6 RID: 9910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B6")]
		[Address(RVA = "0x2B63494", Offset = "0x2B63494", VA = "0x2B63494", Slot = "20")]
		public override void SetLayoutVertical()
		{
		}

		// Token: 0x040022F0 RID: 8944
		[Token(Token = "0x40022F0")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_MaxWidth;

		// Token: 0x040022F1 RID: 8945
		[Token(Token = "0x40022F1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_MaxHeight;

		// Token: 0x040022F2 RID: 8946
		[Token(Token = "0x40022F2")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		private RectTransform m_Rect;

		// Token: 0x040022F3 RID: 8947
		[Token(Token = "0x40022F3")]
		[FieldOffset(Offset = "0x40")]
		private DrivenRectTransformTracker m_Tracker;
	}
}
