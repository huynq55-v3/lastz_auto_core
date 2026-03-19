using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SuperScrollView
{
	// Token: 0x020004C4 RID: 1220
	[Token(Token = "0x20004C4")]
	public class LoopListView2 : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler, IPointerClickHandler
	{
		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06002464 RID: 9316 RVA: 0x0000DC80 File Offset: 0x0000BE80
		// (set) Token: 0x06002465 RID: 9317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700057A")]
		public ListItemArrangeType ArrangeType
		{
			[Token(Token = "0x6002464")]
			[Address(RVA = "0x2CA2D2C", Offset = "0x2CA2D2C", VA = "0x2CA2D2C")]
			get
			{
				return ListItemArrangeType.TopToBottom;
			}
			[Token(Token = "0x6002465")]
			[Address(RVA = "0x2CA2D34", Offset = "0x2CA2D34", VA = "0x2CA2D34")]
			set
			{
			}
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002466")]
		[Address(RVA = "0x2CA2D3C", Offset = "0x2CA2D3C", VA = "0x2CA2D3C")]
		public void SetOnBeginDragAction(Action callback)
		{
		}

		// Token: 0x06002467 RID: 9319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002467")]
		[Address(RVA = "0x2CA2D44", Offset = "0x2CA2D44", VA = "0x2CA2D44")]
		public void SetOnDragingAction(Action callback)
		{
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002468")]
		[Address(RVA = "0x2CA2D4C", Offset = "0x2CA2D4C", VA = "0x2CA2D4C")]
		public void SetOnEndDragAction(Action callback)
		{
		}

		// Token: 0x06002469 RID: 9321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002469")]
		[Address(RVA = "0x2CA2D54", Offset = "0x2CA2D54", VA = "0x2CA2D54")]
		public void SetOnListClickAction(Action callback)
		{
		}

		// Token: 0x1700057B RID: 1403
		// (set) Token: 0x0600246A RID: 9322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700057B")]
		public Func<LoopListView2, int, LoopListViewItem2> OnGetItemByIndex
		{
			[Token(Token = "0x600246A")]
			[Address(RVA = "0x2CA2D5C", Offset = "0x2CA2D5C", VA = "0x2CA2D5C")]
			set
			{
			}
		}

		// Token: 0x1700057C RID: 1404
		// (set) Token: 0x0600246B RID: 9323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700057C")]
		public Func<LoopListView2, int, string> OnGetItemNameByIndex
		{
			[Token(Token = "0x600246B")]
			[Address(RVA = "0x2CA2D64", Offset = "0x2CA2D64", VA = "0x2CA2D64")]
			set
			{
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x0600246C RID: 9324 RVA: 0x0000DC98 File Offset: 0x0000BE98
		[Token(Token = "0x1700057D")]
		public bool IsVertList
		{
			[Token(Token = "0x600246C")]
			[Address(RVA = "0x2CA2D6C", Offset = "0x2CA2D6C", VA = "0x2CA2D6C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x0600246D RID: 9325 RVA: 0x0000DCB0 File Offset: 0x0000BEB0
		[Token(Token = "0x1700057E")]
		public int ItemTotalCount
		{
			[Token(Token = "0x600246D")]
			[Address(RVA = "0x2CA2D74", Offset = "0x2CA2D74", VA = "0x2CA2D74")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x0600246E RID: 9326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700057F")]
		public RectTransform ContainerTrans
		{
			[Token(Token = "0x600246E")]
			[Address(RVA = "0x2CA2D7C", Offset = "0x2CA2D7C", VA = "0x2CA2D7C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x0600246F RID: 9327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000580")]
		public ScrollRect ScrollRect
		{
			[Token(Token = "0x600246F")]
			[Address(RVA = "0x2CA2D84", Offset = "0x2CA2D84", VA = "0x2CA2D84")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06002470 RID: 9328 RVA: 0x0000DCC8 File Offset: 0x0000BEC8
		[Token(Token = "0x17000581")]
		public bool IsDraging
		{
			[Token(Token = "0x6002470")]
			[Address(RVA = "0x2CA2D8C", Offset = "0x2CA2D8C", VA = "0x2CA2D8C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06002471 RID: 9329 RVA: 0x0000DCE0 File Offset: 0x0000BEE0
		// (set) Token: 0x06002472 RID: 9330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000582")]
		public bool ItemSnapEnable
		{
			[Token(Token = "0x6002471")]
			[Address(RVA = "0x2CA2D94", Offset = "0x2CA2D94", VA = "0x2CA2D94")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002472")]
			[Address(RVA = "0x2CA2D9C", Offset = "0x2CA2D9C", VA = "0x2CA2D9C")]
			set
			{
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06002473 RID: 9331 RVA: 0x0000DCF8 File Offset: 0x0000BEF8
		// (set) Token: 0x06002474 RID: 9332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000583")]
		public bool SupportScrollBar
		{
			[Token(Token = "0x6002473")]
			[Address(RVA = "0x2CA2DA8", Offset = "0x2CA2DA8", VA = "0x2CA2DA8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002474")]
			[Address(RVA = "0x2CA2DB0", Offset = "0x2CA2DB0", VA = "0x2CA2DB0")]
			set
			{
			}
		}

		// Token: 0x06002475 RID: 9333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002475")]
		[Address(RVA = "0x2CA2DBC", Offset = "0x2CA2DBC", VA = "0x2CA2DBC", Slot = "7")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06002476 RID: 9334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002476")]
		[Address(RVA = "0x2CA2DD8", Offset = "0x2CA2DD8", VA = "0x2CA2DD8")]
		public ItemPrefabConfData GetItemPrefabConfData(string prefabName)
		{
			return null;
		}

		// Token: 0x06002477 RID: 9335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002477")]
		[Address(RVA = "0x2CA3018", Offset = "0x2CA3018", VA = "0x2CA3018")]
		public void OnItemPrefabChanged(string prefabName)
		{
		}

		// Token: 0x06002478 RID: 9336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002478")]
		[Address(RVA = "0x2CA3668", Offset = "0x2CA3668", VA = "0x2CA3668")]
		public void InitListView(int itemTotalCount, Func<LoopListView2, int, LoopListViewItem2> onGetItemByIndex, [Optional] LoopListViewInitParam initParam, [Optional] Func<LoopListView2, int, string> onGetItemNameByIndex)
		{
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002479")]
		[Address(RVA = "0x2CA45D0", Offset = "0x2CA45D0", VA = "0x2CA45D0")]
		public void SetMoveType(int type)
		{
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600247A")]
		[Address(RVA = "0x2CA3B48", Offset = "0x2CA3B48", VA = "0x2CA3B48")]
		private void SetScrollbarListener()
		{
		}

		// Token: 0x0600247B RID: 9339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600247B")]
		[Address(RVA = "0x2CA4638", Offset = "0x2CA4638", VA = "0x2CA4638")]
		private void OnPointerDownInScrollBar(GameObject obj)
		{
		}

		// Token: 0x0600247C RID: 9340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600247C")]
		[Address(RVA = "0x2CA4658", Offset = "0x2CA4658", VA = "0x2CA4658")]
		private void OnPointerUpInScrollBar(GameObject obj)
		{
		}

		// Token: 0x0600247D RID: 9341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600247D")]
		[Address(RVA = "0x2CA43C8", Offset = "0x2CA43C8", VA = "0x2CA43C8")]
		public void ResetListView()
		{
		}

		// Token: 0x0600247E RID: 9342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600247E")]
		[Address(RVA = "0x2CA4458", Offset = "0x2CA4458", VA = "0x2CA4458")]
		public void SetListItemCount(int itemCount, bool resetPos = true, bool needMoveToIndex = true)
		{
		}

		// Token: 0x0600247F RID: 9343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600247F")]
		[Address(RVA = "0x2CA4FCC", Offset = "0x2CA4FCC", VA = "0x2CA4FCC")]
		public LoopListViewItem2 GetShownItemByItemIndex(int itemIndex)
		{
			return null;
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06002480 RID: 9344 RVA: 0x0000DD10 File Offset: 0x0000BF10
		[Token(Token = "0x17000584")]
		public int ShownItemCount
		{
			[Token(Token = "0x6002480")]
			[Address(RVA = "0x2CA50BC", Offset = "0x2CA50BC", VA = "0x2CA50BC")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06002481 RID: 9345 RVA: 0x0000DD28 File Offset: 0x0000BF28
		[Token(Token = "0x17000585")]
		public float ViewPortSize
		{
			[Token(Token = "0x6002481")]
			[Address(RVA = "0x2CA5104", Offset = "0x2CA5104", VA = "0x2CA5104")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06002482 RID: 9346 RVA: 0x0000DD40 File Offset: 0x0000BF40
		[Token(Token = "0x17000586")]
		public float ViewPortWidth
		{
			[Token(Token = "0x6002482")]
			[Address(RVA = "0x2CA5158", Offset = "0x2CA5158", VA = "0x2CA5158")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06002483 RID: 9347 RVA: 0x0000DD58 File Offset: 0x0000BF58
		[Token(Token = "0x17000587")]
		public float ViewPortHeight
		{
			[Token(Token = "0x6002483")]
			[Address(RVA = "0x2CA5198", Offset = "0x2CA5198", VA = "0x2CA5198")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06002484 RID: 9348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002484")]
		[Address(RVA = "0x2CA51D8", Offset = "0x2CA51D8", VA = "0x2CA51D8")]
		public LoopListViewItem2 GetShownItemByIndex(int index)
		{
			return null;
		}

		// Token: 0x06002485 RID: 9349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002485")]
		[Address(RVA = "0x2CA525C", Offset = "0x2CA525C", VA = "0x2CA525C")]
		public LoopListViewItem2 GetShownItemByIndexWithoutCheck(int index)
		{
			return null;
		}

		// Token: 0x06002486 RID: 9350 RVA: 0x0000DD70 File Offset: 0x0000BF70
		[Token(Token = "0x6002486")]
		[Address(RVA = "0x2CA52B4", Offset = "0x2CA52B4", VA = "0x2CA52B4")]
		public int GetIndexInShownItemList(LoopListViewItem2 item)
		{
			return 0;
		}

		// Token: 0x06002487 RID: 9351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002487")]
		[Address(RVA = "0x2CA53BC", Offset = "0x2CA53BC", VA = "0x2CA53BC")]
		public void DoActionForEachShownItem(Action<LoopListViewItem2, object> action, object param)
		{
		}

		// Token: 0x06002488 RID: 9352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002488")]
		[Address(RVA = "0x2CA547C", Offset = "0x2CA547C", VA = "0x2CA547C")]
		public LoopListViewItem2 NewListViewItem(string itemPrefabName)
		{
			return null;
		}

		// Token: 0x06002489 RID: 9353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002489")]
		[Address(RVA = "0x2CA560C", Offset = "0x2CA560C", VA = "0x2CA560C")]
		public void OnItemSizeChanged(int itemIndex)
		{
		}

		// Token: 0x0600248A RID: 9354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600248A")]
		[Address(RVA = "0x2CA5758", Offset = "0x2CA5758", VA = "0x2CA5758")]
		public void RefreshItemByItemIndex(int itemIndex)
		{
		}

		// Token: 0x0600248B RID: 9355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600248B")]
		[Address(RVA = "0x2CA5D64", Offset = "0x2CA5D64", VA = "0x2CA5D64")]
		public void FinishSnapImmediately()
		{
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600248C")]
		[Address(RVA = "0x2CA5D90", Offset = "0x2CA5D90", VA = "0x2CA5D90")]
		public List<int> GetCurShowIndexes()
		{
			return null;
		}

		// Token: 0x0600248D RID: 9357 RVA: 0x0000DD88 File Offset: 0x0000BF88
		[Token(Token = "0x600248D")]
		[Address(RVA = "0x2CA5F40", Offset = "0x2CA5F40", VA = "0x2CA5F40")]
		public Vector3 GetMovePanelToIndexPos(int itemIndex, float offset)
		{
			return default(Vector3);
		}

		// Token: 0x0600248E RID: 9358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600248E")]
		[Address(RVA = "0x2CA4730", Offset = "0x2CA4730", VA = "0x2CA4730")]
		public void MovePanelToItemIndex(int itemIndex, float offset)
		{
		}

		// Token: 0x0600248F RID: 9359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600248F")]
		[Address(RVA = "0x2CA6A18", Offset = "0x2CA6A18", VA = "0x2CA6A18")]
		public void RefreshAllShownItem()
		{
		}

		// Token: 0x06002490 RID: 9360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002490")]
		[Address(RVA = "0x2CA5B24", Offset = "0x2CA5B24", VA = "0x2CA5B24")]
		public void RefreshAllShownItemWithFirstIndex(int firstItemIndex)
		{
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002491")]
		[Address(RVA = "0x2CA348C", Offset = "0x2CA348C", VA = "0x2CA348C")]
		public void RefreshAllShownItemWithFirstIndexAndPos(int firstItemIndex, Vector3 pos)
		{
		}

		// Token: 0x06002492 RID: 9362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002492")]
		[Address(RVA = "0x2CA597C", Offset = "0x2CA597C", VA = "0x2CA597C")]
		private void RecycleItemTmp(LoopListViewItem2 item)
		{
		}

		// Token: 0x06002493 RID: 9363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002493")]
		[Address(RVA = "0x2CA33F4", Offset = "0x2CA33F4", VA = "0x2CA33F4")]
		private void ClearAllTmpRecycledItem()
		{
		}

		// Token: 0x06002494 RID: 9364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002494")]
		[Address(RVA = "0x2CA327C", Offset = "0x2CA327C", VA = "0x2CA327C")]
		private void RecycleAllItem()
		{
		}

		// Token: 0x06002495 RID: 9365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002495")]
		[Address(RVA = "0x2CA3E94", Offset = "0x2CA3E94", VA = "0x2CA3E94")]
		private void AdjustContainerPivot(RectTransform rtf)
		{
		}

		// Token: 0x06002496 RID: 9366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002496")]
		[Address(RVA = "0x2CA3D54", Offset = "0x2CA3D54", VA = "0x2CA3D54")]
		private void AdjustPivot(RectTransform rtf)
		{
		}

		// Token: 0x06002497 RID: 9367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002497")]
		[Address(RVA = "0x2CA6A9C", Offset = "0x2CA6A9C", VA = "0x2CA6A9C")]
		private void AdjustContainerAnchor(RectTransform rtf)
		{
		}

		// Token: 0x06002498 RID: 9368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002498")]
		[Address(RVA = "0x2CA3DC8", Offset = "0x2CA3DC8", VA = "0x2CA3DC8")]
		private void AdjustAnchor(RectTransform rtf)
		{
		}

		// Token: 0x06002499 RID: 9369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002499")]
		[Address(RVA = "0x2CA3F08", Offset = "0x2CA3F08", VA = "0x2CA3F08")]
		private void InitItemPool()
		{
		}

		// Token: 0x0600249A RID: 9370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600249A")]
		[Address(RVA = "0x2CA6B68", Offset = "0x2CA6B68", VA = "0x2CA6B68", Slot = "8")]
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0600249B RID: 9371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600249B")]
		[Address(RVA = "0x2CA6ECC", Offset = "0x2CA6ECC", VA = "0x2CA6ECC", Slot = "9")]
		public virtual void OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0600249C RID: 9372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600249C")]
		[Address(RVA = "0x2CA6F38", Offset = "0x2CA6F38", VA = "0x2CA6F38", Slot = "10")]
		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0600249D RID: 9373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600249D")]
		[Address(RVA = "0x2CA6BD0", Offset = "0x2CA6BD0", VA = "0x2CA6BD0")]
		private void CacheDragPointerEventData(PointerEventData eventData)
		{
		}

		// Token: 0x0600249E RID: 9374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600249E")]
		[Address(RVA = "0x2CA5A4C", Offset = "0x2CA5A4C", VA = "0x2CA5A4C")]
		private LoopListViewItem2 GetNewItemByIndex(int index)
		{
			return null;
		}

		// Token: 0x0600249F RID: 9375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600249F")]
		[Address(RVA = "0x2CA5704", Offset = "0x2CA5704", VA = "0x2CA5704")]
		private void SetItemSize(int itemIndex, float itemSize, float padding)
		{
		}

		// Token: 0x060024A0 RID: 9376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A0")]
		[Address(RVA = "0x2CA6F78", Offset = "0x2CA6F78", VA = "0x2CA6F78")]
		private void GetPlusItemIndexAndPosAtGivenPos(float pos, ref int index, ref float itemPos)
		{
		}

		// Token: 0x060024A1 RID: 9377 RVA: 0x0000DDA0 File Offset: 0x0000BFA0
		[Token(Token = "0x60024A1")]
		[Address(RVA = "0x2CA6F94", Offset = "0x2CA6F94", VA = "0x2CA6F94")]
		private float GetItemPos(int itemIndex)
		{
			return 0f;
		}

		// Token: 0x060024A2 RID: 9378 RVA: 0x0000DDB8 File Offset: 0x0000BFB8
		[Token(Token = "0x60024A2")]
		[Address(RVA = "0x2CA6FB0", Offset = "0x2CA6FB0", VA = "0x2CA6FB0")]
		public Vector3 GetItemCornerPosInViewPort(LoopListViewItem2 item, ItemCornerEnum corner = ItemCornerEnum.LeftBottom)
		{
			return default(Vector3);
		}

		// Token: 0x060024A3 RID: 9379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A3")]
		[Address(RVA = "0x2CA6320", Offset = "0x2CA6320", VA = "0x2CA6320")]
		private void AdjustPanelPos()
		{
		}

		// Token: 0x060024A4 RID: 9380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A4")]
		[Address(RVA = "0x2CA731C", Offset = "0x2CA731C", VA = "0x2CA731C")]
		private void Update()
		{
		}

		// Token: 0x060024A5 RID: 9381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A5")]
		[Address(RVA = "0x2CA7544", Offset = "0x2CA7544", VA = "0x2CA7544")]
		public void ForceUpdate()
		{
		}

		// Token: 0x060024A6 RID: 9382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A6")]
		[Address(RVA = "0x2CA5D6C", Offset = "0x2CA5D6C", VA = "0x2CA5D6C")]
		private void UpdateSnapMove(bool immediate = false)
		{
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A7")]
		[Address(RVA = "0x2CA8244", Offset = "0x2CA8244", VA = "0x2CA8244")]
		public void UpdateAllShownItemSnapData()
		{
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A8")]
		[Address(RVA = "0x2CA7548", Offset = "0x2CA7548", VA = "0x2CA7548")]
		private void UpdateSnapVertical(bool immediate = false)
		{
		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A9")]
		[Address(RVA = "0x2CA8B94", Offset = "0x2CA8B94", VA = "0x2CA8B94")]
		private void UpdateCurSnapData()
		{
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024AA")]
		[Address(RVA = "0x2CA8B74", Offset = "0x2CA8B74", VA = "0x2CA8B74")]
		public void ClearSnapData()
		{
		}

		// Token: 0x060024AB RID: 9387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024AB")]
		[Address(RVA = "0x2CA8D14", Offset = "0x2CA8D14", VA = "0x2CA8D14")]
		public void SetSnapTargetItemIndex(int itemIndex)
		{
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x060024AC RID: 9388 RVA: 0x0000DDD0 File Offset: 0x0000BFD0
		[Token(Token = "0x17000588")]
		public int CurSnapNearestItemIndex
		{
			[Token(Token = "0x60024AC")]
			[Address(RVA = "0x2CA8D38", Offset = "0x2CA8D38", VA = "0x2CA8D38")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024AD")]
		[Address(RVA = "0x2CA4674", Offset = "0x2CA4674", VA = "0x2CA4674")]
		public void ForceSnapUpdateCheck()
		{
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024AE")]
		[Address(RVA = "0x2CA7BA0", Offset = "0x2CA7BA0", VA = "0x2CA7BA0")]
		private void UpdateSnapHorizontal(bool immediate = false)
		{
		}

		// Token: 0x060024AF RID: 9391 RVA: 0x0000DDE8 File Offset: 0x0000BFE8
		[Token(Token = "0x60024AF")]
		[Address(RVA = "0x2CA887C", Offset = "0x2CA887C", VA = "0x2CA887C")]
		private bool CanSnap()
		{
			return default(bool);
		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024B0")]
		[Address(RVA = "0x2CA6178", Offset = "0x2CA6178", VA = "0x2CA6178")]
		public void UpdateListView(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
		{
		}

		// Token: 0x060024B1 RID: 9393 RVA: 0x0000DE00 File Offset: 0x0000C000
		[Token(Token = "0x60024B1")]
		[Address(RVA = "0x2CA8D40", Offset = "0x2CA8D40", VA = "0x2CA8D40")]
		private bool UpdateForVertList(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
		{
			return default(bool);
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x0000DE18 File Offset: 0x0000C018
		[Token(Token = "0x60024B2")]
		[Address(RVA = "0x2CA9B44", Offset = "0x2CA9B44", VA = "0x2CA9B44")]
		private bool UpdateForHorizontalList(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
		{
			return default(bool);
		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x0000DE30 File Offset: 0x0000C030
		[Token(Token = "0x60024B3")]
		[Address(RVA = "0x2CA7024", Offset = "0x2CA7024", VA = "0x2CA7024")]
		private float GetContentPanelSize()
		{
			return 0f;
		}

		// Token: 0x060024B4 RID: 9396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024B4")]
		[Address(RVA = "0x2CAA92C", Offset = "0x2CAA92C", VA = "0x2CAA92C")]
		private void CheckIfNeedUpdataItemPos()
		{
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024B5")]
		[Address(RVA = "0x2CA4A5C", Offset = "0x2CA4A5C", VA = "0x2CA4A5C")]
		private void UpdateAllShownItemsPos()
		{
		}

		// Token: 0x060024B6 RID: 9398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024B6")]
		[Address(RVA = "0x2CA4690", Offset = "0x2CA4690", VA = "0x2CA4690")]
		private void UpdateContentSize()
		{
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024B7")]
		[Address(RVA = "0x2CA6D18", Offset = "0x2CA6D18", VA = "0x2CA6D18")]
		private void CanCleItemClickAnimation()
		{
		}

		// Token: 0x060024B8 RID: 9400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024B8")]
		[Address(RVA = "0x2CAB020", Offset = "0x2CAB020", VA = "0x2CAB020")]
		public void ClearAllItems()
		{
		}

		// Token: 0x060024B9 RID: 9401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024B9")]
		[Address(RVA = "0x2CA719C", Offset = "0x2CA719C", VA = "0x2CA719C")]
		private void SetContainerLocalPosY(float y)
		{
		}

		// Token: 0x060024BA RID: 9402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024BA")]
		[Address(RVA = "0x2CA73EC", Offset = "0x2CA73EC", VA = "0x2CA73EC")]
		private void SetVelocity(Vector2 velocity)
		{
		}

		// Token: 0x060024BB RID: 9403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024BB")]
		[Address(RVA = "0x2CAB2D8", Offset = "0x2CAB2D8", VA = "0x2CAB2D8")]
		public LoopListView2()
		{
		}

		// Token: 0x0400219E RID: 8606
		[Token(Token = "0x400219E")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, ItemPool> mItemPoolDict;

		// Token: 0x0400219F RID: 8607
		[Token(Token = "0x400219F")]
		[FieldOffset(Offset = "0x20")]
		private List<ItemPool> mItemPoolList;

		// Token: 0x040021A0 RID: 8608
		[Token(Token = "0x40021A0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<ItemPrefabConfData> mItemPrefabDataList;

		// Token: 0x040021A1 RID: 8609
		[Token(Token = "0x40021A1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ListItemArrangeType mArrangeType;

		// Token: 0x040021A2 RID: 8610
		[Token(Token = "0x40021A2")]
		[FieldOffset(Offset = "0x38")]
		private List<LoopListViewItem2> mItemList;

		// Token: 0x040021A3 RID: 8611
		[Token(Token = "0x40021A3")]
		[FieldOffset(Offset = "0x40")]
		private RectTransform mContainerTrans;

		// Token: 0x040021A4 RID: 8612
		[Token(Token = "0x40021A4")]
		[FieldOffset(Offset = "0x48")]
		private ScrollRect mScrollRect;

		// Token: 0x040021A5 RID: 8613
		[Token(Token = "0x40021A5")]
		[FieldOffset(Offset = "0x50")]
		private RectTransform mScrollRectTransform;

		// Token: 0x040021A6 RID: 8614
		[Token(Token = "0x40021A6")]
		[FieldOffset(Offset = "0x58")]
		private RectTransform mViewPortRectTransform;

		// Token: 0x040021A7 RID: 8615
		[Token(Token = "0x40021A7")]
		[FieldOffset(Offset = "0x60")]
		private float mItemDefaultWithPaddingSize;

		// Token: 0x040021A8 RID: 8616
		[Token(Token = "0x40021A8")]
		[FieldOffset(Offset = "0x64")]
		private int mItemTotalCount;

		// Token: 0x040021A9 RID: 8617
		[Token(Token = "0x40021A9")]
		[FieldOffset(Offset = "0x68")]
		private bool mIsVertList;

		// Token: 0x040021AA RID: 8618
		[Token(Token = "0x40021AA")]
		[FieldOffset(Offset = "0x70")]
		private Func<LoopListView2, int, LoopListViewItem2> mOnGetItemByIndex;

		// Token: 0x040021AB RID: 8619
		[Token(Token = "0x40021AB")]
		[FieldOffset(Offset = "0x78")]
		private Func<LoopListView2, int, string> mOnGetItemNameByIndex;

		// Token: 0x040021AC RID: 8620
		[Token(Token = "0x40021AC")]
		[FieldOffset(Offset = "0x80")]
		private Vector3[] mItemWorldCorners;

		// Token: 0x040021AD RID: 8621
		[Token(Token = "0x40021AD")]
		[FieldOffset(Offset = "0x88")]
		private Vector3[] mViewPortRectLocalCorners;

		// Token: 0x040021AE RID: 8622
		[Token(Token = "0x40021AE")]
		[FieldOffset(Offset = "0x90")]
		private int mCurReadyMinItemIndex;

		// Token: 0x040021AF RID: 8623
		[Token(Token = "0x40021AF")]
		[FieldOffset(Offset = "0x94")]
		private int mCurReadyMaxItemIndex;

		// Token: 0x040021B0 RID: 8624
		[Token(Token = "0x40021B0")]
		[FieldOffset(Offset = "0x98")]
		private bool mNeedCheckNextMinItem;

		// Token: 0x040021B1 RID: 8625
		[Token(Token = "0x40021B1")]
		[FieldOffset(Offset = "0x99")]
		private bool mNeedCheckNextMaxItem;

		// Token: 0x040021B2 RID: 8626
		[Token(Token = "0x40021B2")]
		[FieldOffset(Offset = "0xA0")]
		private ItemPosMgr mItemPosMgr;

		// Token: 0x040021B3 RID: 8627
		[Token(Token = "0x40021B3")]
		[FieldOffset(Offset = "0xA8")]
		private float mDistanceForRecycle0;

		// Token: 0x040021B4 RID: 8628
		[Token(Token = "0x40021B4")]
		[FieldOffset(Offset = "0xAC")]
		private float mDistanceForNew0;

		// Token: 0x040021B5 RID: 8629
		[Token(Token = "0x40021B5")]
		[FieldOffset(Offset = "0xB0")]
		private float mDistanceForRecycle1;

		// Token: 0x040021B6 RID: 8630
		[Token(Token = "0x40021B6")]
		[FieldOffset(Offset = "0xB4")]
		private float mDistanceForNew1;

		// Token: 0x040021B7 RID: 8631
		[Token(Token = "0x40021B7")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Tooltip("这个表示在Y轴上超过多少会创建新的cell,现在默认偏移量是viewport的Y")]
		private int mOffsetY;

		// Token: 0x040021B8 RID: 8632
		[Token(Token = "0x40021B8")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private bool mSupportScrollBar;

		// Token: 0x040021B9 RID: 8633
		[Token(Token = "0x40021B9")]
		[FieldOffset(Offset = "0xBD")]
		[SerializeField]
		private bool mItemInterruptAnim;

		// Token: 0x040021BA RID: 8634
		[Token(Token = "0x40021BA")]
		[FieldOffset(Offset = "0xBE")]
		private bool mIsDraging;

		// Token: 0x040021BB RID: 8635
		[Token(Token = "0x40021BB")]
		[FieldOffset(Offset = "0xC0")]
		private PointerEventData mPointerEventData;

		// Token: 0x040021BC RID: 8636
		[Token(Token = "0x40021BC")]
		[FieldOffset(Offset = "0xC8")]
		public Action mOnBeginDragAction;

		// Token: 0x040021BD RID: 8637
		[Token(Token = "0x40021BD")]
		[FieldOffset(Offset = "0xD0")]
		public Action mOnDragingAction;

		// Token: 0x040021BE RID: 8638
		[Token(Token = "0x40021BE")]
		[FieldOffset(Offset = "0xD8")]
		public Action mOnEndDragAction;

		// Token: 0x040021BF RID: 8639
		[Token(Token = "0x40021BF")]
		[FieldOffset(Offset = "0xE0")]
		public Action mOnListClickAction;

		// Token: 0x040021C0 RID: 8640
		[Token(Token = "0x40021C0")]
		[FieldOffset(Offset = "0xE8")]
		private int mLastItemIndex;

		// Token: 0x040021C1 RID: 8641
		[Token(Token = "0x40021C1")]
		[FieldOffset(Offset = "0xEC")]
		private float mLastItemPadding;

		// Token: 0x040021C2 RID: 8642
		[Token(Token = "0x40021C2")]
		[FieldOffset(Offset = "0xF0")]
		private float mSmoothDumpVel;

		// Token: 0x040021C3 RID: 8643
		[Token(Token = "0x40021C3")]
		[FieldOffset(Offset = "0xF4")]
		private float mSmoothDumpRate;

		// Token: 0x040021C4 RID: 8644
		[Token(Token = "0x40021C4")]
		[FieldOffset(Offset = "0xF8")]
		private float mSnapFinishThreshold;

		// Token: 0x040021C5 RID: 8645
		[Token(Token = "0x40021C5")]
		[FieldOffset(Offset = "0xFC")]
		private float mSnapVecThreshold;

		// Token: 0x040021C6 RID: 8646
		[Token(Token = "0x40021C6")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private bool mItemSnapEnable;

		// Token: 0x040021C7 RID: 8647
		[Token(Token = "0x40021C7")]
		[FieldOffset(Offset = "0x104")]
		private Vector3 mLastFrameContainerPos;

		// Token: 0x040021C8 RID: 8648
		[Token(Token = "0x40021C8")]
		[FieldOffset(Offset = "0x110")]
		public Action<LoopListView2, LoopListViewItem2> mOnSnapItemFinished;

		// Token: 0x040021C9 RID: 8649
		[Token(Token = "0x40021C9")]
		[FieldOffset(Offset = "0x118")]
		public Action<LoopListView2, LoopListViewItem2> mOnSnapNearestChanged;

		// Token: 0x040021CA RID: 8650
		[Token(Token = "0x40021CA")]
		[FieldOffset(Offset = "0x120")]
		private int mCurSnapNearestItemIndex;

		// Token: 0x040021CB RID: 8651
		[Token(Token = "0x40021CB")]
		[FieldOffset(Offset = "0x124")]
		private Vector2 mAdjustedVec;

		// Token: 0x040021CC RID: 8652
		[Token(Token = "0x40021CC")]
		[FieldOffset(Offset = "0x12C")]
		private bool mNeedAdjustVec;

		// Token: 0x040021CD RID: 8653
		[Token(Token = "0x40021CD")]
		[FieldOffset(Offset = "0x130")]
		private int mLeftSnapUpdateExtraCount;

		// Token: 0x040021CE RID: 8654
		[Token(Token = "0x40021CE")]
		[FieldOffset(Offset = "0x134")]
		[SerializeField]
		private Vector2 mViewPortSnapPivot;

		// Token: 0x040021CF RID: 8655
		[Token(Token = "0x40021CF")]
		[FieldOffset(Offset = "0x13C")]
		[SerializeField]
		private Vector2 mItemSnapPivot;

		// Token: 0x040021D0 RID: 8656
		[Token(Token = "0x40021D0")]
		[FieldOffset(Offset = "0x148")]
		private ClickEventListener mScrollBarClickEventListener;

		// Token: 0x040021D1 RID: 8657
		[Token(Token = "0x40021D1")]
		[FieldOffset(Offset = "0x150")]
		private LoopListView2.SnapData mCurSnapData;

		// Token: 0x040021D2 RID: 8658
		[Token(Token = "0x40021D2")]
		[FieldOffset(Offset = "0x158")]
		private Vector3 mLastSnapCheckPos;

		// Token: 0x040021D3 RID: 8659
		[Token(Token = "0x40021D3")]
		[FieldOffset(Offset = "0x164")]
		private bool mListViewInited;

		// Token: 0x040021D4 RID: 8660
		[Token(Token = "0x40021D4")]
		[FieldOffset(Offset = "0x168")]
		private int mListUpdateCheckFrameCount;

		// Token: 0x040021D5 RID: 8661
		[Token(Token = "0x40021D5")]
		[FieldOffset(Offset = "0x16C")]
		private bool _isOccurError;

		// Token: 0x020004C5 RID: 1221
		[Token(Token = "0x20004C5")]
		private class SnapData
		{
			// Token: 0x060024BC RID: 9404 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60024BC")]
			[Address(RVA = "0x2CA3B3C", Offset = "0x2CA3B3C", VA = "0x2CA3B3C")]
			public void Clear()
			{
			}

			// Token: 0x060024BD RID: 9405 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60024BD")]
			[Address(RVA = "0x2CAB5EC", Offset = "0x2CAB5EC", VA = "0x2CAB5EC")]
			public SnapData()
			{
			}

			// Token: 0x040021D6 RID: 8662
			[Token(Token = "0x40021D6")]
			[FieldOffset(Offset = "0x10")]
			public SnapStatus mSnapStatus;

			// Token: 0x040021D7 RID: 8663
			[Token(Token = "0x40021D7")]
			[FieldOffset(Offset = "0x14")]
			public int mSnapTargetIndex;

			// Token: 0x040021D8 RID: 8664
			[Token(Token = "0x40021D8")]
			[FieldOffset(Offset = "0x18")]
			public float mTargetSnapVal;

			// Token: 0x040021D9 RID: 8665
			[Token(Token = "0x40021D9")]
			[FieldOffset(Offset = "0x1C")]
			public float mCurSnapVal;

			// Token: 0x040021DA RID: 8666
			[Token(Token = "0x40021DA")]
			[FieldOffset(Offset = "0x20")]
			public bool mIsForceSnapTo;
		}
	}
}
