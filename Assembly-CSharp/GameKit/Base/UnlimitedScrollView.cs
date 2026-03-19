using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace GameKit.Base
{
	// Token: 0x020004E5 RID: 1253
	[Token(Token = "0x20004E5")]
	[RequireComponent(typeof(ScrollRect))]
	public class UnlimitedScrollView : MonoBehaviour
	{
		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x060025ED RID: 9709 RVA: 0x0000E610 File Offset: 0x0000C810
		[Token(Token = "0x170005B8")]
		public int HeadIndex
		{
			[Token(Token = "0x60025ED")]
			[Address(RVA = "0x2B598C0", Offset = "0x2B598C0", VA = "0x2B598C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x060025EE RID: 9710 RVA: 0x0000E628 File Offset: 0x0000C828
		[Token(Token = "0x170005B9")]
		public int TailIndex
		{
			[Token(Token = "0x60025EE")]
			[Address(RVA = "0x2B598C8", Offset = "0x2B598C8", VA = "0x2B598C8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005BA RID: 1466
		// (set) Token: 0x060025EF RID: 9711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005BA")]
		public bool ToHead
		{
			[Token(Token = "0x60025EF")]
			[Address(RVA = "0x2B598D0", Offset = "0x2B598D0", VA = "0x2B598D0")]
			set
			{
			}
		}

		// Token: 0x170005BB RID: 1467
		// (set) Token: 0x060025F0 RID: 9712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005BB")]
		public bool ToTail
		{
			[Token(Token = "0x60025F0")]
			[Address(RVA = "0x2B598EC", Offset = "0x2B598EC", VA = "0x2B598EC")]
			set
			{
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x060025F1 RID: 9713 RVA: 0x0000E640 File Offset: 0x0000C840
		[Token(Token = "0x170005BC")]
		public Vector2 ViewportSize
		{
			[Token(Token = "0x60025F1")]
			[Address(RVA = "0x2B59908", Offset = "0x2B59908", VA = "0x2B59908")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x060025F2 RID: 9714 RVA: 0x0000E658 File Offset: 0x0000C858
		[Token(Token = "0x170005BD")]
		public Vector2 ContentSize
		{
			[Token(Token = "0x60025F2")]
			[Address(RVA = "0x2B59950", Offset = "0x2B59950", VA = "0x2B59950")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x060025F3 RID: 9715 RVA: 0x0000E670 File Offset: 0x0000C870
		// (set) Token: 0x060025F4 RID: 9716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005BE")]
		public Vector2 ContentPosition
		{
			[Token(Token = "0x60025F3")]
			[Address(RVA = "0x2B59998", Offset = "0x2B59998", VA = "0x2B59998")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60025F4")]
			[Address(RVA = "0x2B599BC", Offset = "0x2B599BC", VA = "0x2B599BC")]
			set
			{
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x060025F5 RID: 9717 RVA: 0x0000E688 File Offset: 0x0000C888
		// (set) Token: 0x060025F6 RID: 9718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005BF")]
		public Vector2 Velocity
		{
			[Token(Token = "0x60025F5")]
			[Address(RVA = "0x2B599E0", Offset = "0x2B599E0", VA = "0x2B599E0")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60025F6")]
			[Address(RVA = "0x2B599FC", Offset = "0x2B599FC", VA = "0x2B599FC")]
			set
			{
			}
		}

		// Token: 0x060025F7 RID: 9719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F7")]
		[Address(RVA = "0x2B59A18", Offset = "0x2B59A18", VA = "0x2B59A18")]
		private void Update()
		{
		}

		// Token: 0x060025F8 RID: 9720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F8")]
		[Address(RVA = "0x2B59E18", Offset = "0x2B59E18", VA = "0x2B59E18")]
		private void Awake()
		{
		}

		// Token: 0x060025F9 RID: 9721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F9")]
		[Address(RVA = "0x2B5A094", Offset = "0x2B5A094", VA = "0x2B5A094")]
		private void OnEnable()
		{
		}

		// Token: 0x060025FA RID: 9722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025FA")]
		[Address(RVA = "0x2B5A13C", Offset = "0x2B5A13C", VA = "0x2B5A13C")]
		private void OnDisable()
		{
		}

		// Token: 0x060025FB RID: 9723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025FB")]
		[Address(RVA = "0x2B5A460", Offset = "0x2B5A460", VA = "0x2B5A460")]
		private void OnPointerDown()
		{
		}

		// Token: 0x060025FC RID: 9724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025FC")]
		[Address(RVA = "0x2B5A47C", Offset = "0x2B5A47C", VA = "0x2B5A47C")]
		private void OnDragBegin()
		{
		}

		// Token: 0x060025FD RID: 9725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025FD")]
		[Address(RVA = "0x2B5A4D0", Offset = "0x2B5A4D0", VA = "0x2B5A4D0")]
		private void OnDragEnd()
		{
		}

		// Token: 0x060025FE RID: 9726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025FE")]
		[Address(RVA = "0x2B59C7C", Offset = "0x2B59C7C", VA = "0x2B59C7C")]
		private void Initialize()
		{
		}

		// Token: 0x060025FF RID: 9727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025FF")]
		[Address(RVA = "0x2B5AD9C", Offset = "0x2B5AD9C", VA = "0x2B5AD9C")]
		private void InitVertical()
		{
		}

		// Token: 0x06002600 RID: 9728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002600")]
		[Address(RVA = "0x2B5B038", Offset = "0x2B5B038", VA = "0x2B5B038")]
		private void InitHorizontal()
		{
		}

		// Token: 0x06002601 RID: 9729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002601")]
		[Address(RVA = "0x2B5A1EC", Offset = "0x2B5A1EC", VA = "0x2B5A1EC")]
		public void Clear()
		{
		}

		// Token: 0x06002602 RID: 9730 RVA: 0x0000E6A0 File Offset: 0x0000C8A0
		[Token(Token = "0x6002602")]
		[Address(RVA = "0x2B5B2D8", Offset = "0x2B5B2D8", VA = "0x2B5B2D8")]
		public int GetItemWrapCount()
		{
			return 0;
		}

		// Token: 0x06002603 RID: 9731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002603")]
		[Address(RVA = "0x2B5B320", Offset = "0x2B5B320", VA = "0x2B5B320")]
		public GameObject GetItem(ItemWrap wrap)
		{
			return null;
		}

		// Token: 0x06002604 RID: 9732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002604")]
		[Address(RVA = "0x2B5B398", Offset = "0x2B5B398", VA = "0x2B5B398")]
		public ItemWrap GetItemWrap(object userdata)
		{
			return null;
		}

		// Token: 0x06002605 RID: 9733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002605")]
		[Address(RVA = "0x2B5B488", Offset = "0x2B5B488", VA = "0x2B5B488")]
		public ItemWrap GetItemWrap(int index)
		{
			return null;
		}

		// Token: 0x06002606 RID: 9734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002606")]
		[Address(RVA = "0x2B5B50C", Offset = "0x2B5B50C", VA = "0x2B5B50C")]
		public void AddItemWrap(GameObject prefab, object userdata)
		{
		}

		// Token: 0x06002607 RID: 9735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002607")]
		[Address(RVA = "0x2B5B618", Offset = "0x2B5B618", VA = "0x2B5B618")]
		public void InsertItemWrap(int index, GameObject prefab, object userdata)
		{
		}

		// Token: 0x06002608 RID: 9736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002608")]
		[Address(RVA = "0x2B5B724", Offset = "0x2B5B724", VA = "0x2B5B724")]
		public void RemoveItemWrap(object userdata)
		{
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002609")]
		[Address(RVA = "0x2B5B7E4", Offset = "0x2B5B7E4", VA = "0x2B5B7E4")]
		public void RemoveItemWrap(int index)
		{
		}

		// Token: 0x0600260A RID: 9738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600260A")]
		[Address(RVA = "0x2B59D38", Offset = "0x2B59D38", VA = "0x2B59D38")]
		private GameObject CreateItem(ItemWrap wrap)
		{
			return null;
		}

		// Token: 0x0600260B RID: 9739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600260B")]
		[Address(RVA = "0x2B5B884", Offset = "0x2B5B884", VA = "0x2B5B884")]
		private void DeleteItem(ItemWrap wrap)
		{
		}

		// Token: 0x0600260C RID: 9740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600260C")]
		[Address(RVA = "0x2B5B94C", Offset = "0x2B5B94C", VA = "0x2B5B94C")]
		public void AddItemToTail(GameObject prefab, object userdata)
		{
		}

		// Token: 0x0600260D RID: 9741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600260D")]
		[Address(RVA = "0x2B5A6B0", Offset = "0x2B5A6B0", VA = "0x2B5A6B0")]
		private void OnValueChanged(Vector2 vector2)
		{
		}

		// Token: 0x0600260E RID: 9742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600260E")]
		[Address(RVA = "0x2B5BA1C", Offset = "0x2B5BA1C", VA = "0x2B5BA1C")]
		public UnlimitedScrollView()
		{
		}

		// Token: 0x0400227D RID: 8829
		[Token(Token = "0x400227D")]
		[FieldOffset(Offset = "0x18")]
		private ScrollRect scroll;

		// Token: 0x0400227E RID: 8830
		[Token(Token = "0x400227E")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<ItemWrap> wraps;

		// Token: 0x0400227F RID: 8831
		[Token(Token = "0x400227F")]
		[FieldOffset(Offset = "0x28")]
		private readonly Dictionary<ItemWrap, GameObject> items;

		// Token: 0x04002280 RID: 8832
		[Token(Token = "0x4002280")]
		[FieldOffset(Offset = "0x30")]
		private HorizontalOrVerticalLayoutGroup group;

		// Token: 0x04002281 RID: 8833
		[Token(Token = "0x4002281")]
		[FieldOffset(Offset = "0x38")]
		private float spacing;

		// Token: 0x04002282 RID: 8834
		[Token(Token = "0x4002282")]
		[FieldOffset(Offset = "0x3C")]
		private bool inited;

		// Token: 0x04002283 RID: 8835
		[Token(Token = "0x4002283")]
		[FieldOffset(Offset = "0x3D")]
		private bool beginDrag;

		// Token: 0x04002284 RID: 8836
		[Token(Token = "0x4002284")]
		[FieldOffset(Offset = "0x40")]
		private Vector2 beginDragPosition;

		// Token: 0x04002285 RID: 8837
		[Token(Token = "0x4002285")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private int headIndex;

		// Token: 0x04002286 RID: 8838
		[Token(Token = "0x4002286")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private int tailIndex;

		// Token: 0x04002287 RID: 8839
		[Token(Token = "0x4002287")]
		[FieldOffset(Offset = "0x50")]
		private bool toHead;

		// Token: 0x04002288 RID: 8840
		[Token(Token = "0x4002288")]
		[FieldOffset(Offset = "0x51")]
		private bool toTail;

		// Token: 0x04002289 RID: 8841
		[Token(Token = "0x4002289")]
		[FieldOffset(Offset = "0x58")]
		public UnlimitedScrollView.DragOnHeadOrTailOfTheScrollViewDelegate DragOnHeadOrTailOfTheScrollView;

		// Token: 0x0400228A RID: 8842
		[Token(Token = "0x400228A")]
		[FieldOffset(Offset = "0x60")]
		public UnlimitedScrollView.OnPointerDownScrollViewDelegate OnPointerDownScrollView;

		// Token: 0x0400228B RID: 8843
		[Token(Token = "0x400228B")]
		[FieldOffset(Offset = "0x68")]
		public UnlimitedScrollView.BeginDragDelegate OnBeginDrag;

		// Token: 0x0400228C RID: 8844
		[Token(Token = "0x400228C")]
		[FieldOffset(Offset = "0x70")]
		public UnlimitedScrollView.ItemMoveInDelegate OnItemMoveIn;

		// Token: 0x0400228D RID: 8845
		[Token(Token = "0x400228D")]
		[FieldOffset(Offset = "0x78")]
		public UnlimitedScrollView.ItemMoveOutDelegate OnItemMoveOut;

		// Token: 0x020004E6 RID: 1254
		// (Invoke) Token: 0x06002610 RID: 9744
		[Token(Token = "0x20004E6")]
		public delegate void DragOnHeadOrTailOfTheScrollViewDelegate(int d);

		// Token: 0x020004E7 RID: 1255
		// (Invoke) Token: 0x06002614 RID: 9748
		[Token(Token = "0x20004E7")]
		public delegate void OnPointerDownScrollViewDelegate();

		// Token: 0x020004E8 RID: 1256
		// (Invoke) Token: 0x06002618 RID: 9752
		[Token(Token = "0x20004E8")]
		public delegate void BeginDragDelegate(int head, int tail);

		// Token: 0x020004E9 RID: 1257
		// (Invoke) Token: 0x0600261C RID: 9756
		[Token(Token = "0x20004E9")]
		public delegate void ItemMoveInDelegate(GameObject itemObj, object userData);

		// Token: 0x020004EA RID: 1258
		// (Invoke) Token: 0x06002620 RID: 9760
		[Token(Token = "0x20004EA")]
		public delegate void ItemMoveOutDelegate(GameObject itemObj, object userData);
	}
}
