using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SuperScrollView
{
	// Token: 0x020004BB RID: 1211
	[Token(Token = "0x20004BB")]
	public class LoopListLazyView2 : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler, IPointerClickHandler
	{
		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x060023D4 RID: 9172 RVA: 0x0000D920 File Offset: 0x0000BB20
		// (set) Token: 0x060023D5 RID: 9173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000553")]
		public ListItemArrangeType ArrangeType
		{
			[Token(Token = "0x60023D4")]
			[Address(RVA = "0x2A06E64", Offset = "0x2A06E64", VA = "0x2A06E64")]
			get
			{
				return ListItemArrangeType.TopToBottom;
			}
			[Token(Token = "0x60023D5")]
			[Address(RVA = "0x2A06E6C", Offset = "0x2A06E6C", VA = "0x2A06E6C")]
			set
			{
			}
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D6")]
		[Address(RVA = "0x2A06E74", Offset = "0x2A06E74", VA = "0x2A06E74")]
		public void SetOnBeginDragAction(Action callback)
		{
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D7")]
		[Address(RVA = "0x2A06E7C", Offset = "0x2A06E7C", VA = "0x2A06E7C")]
		public void SetOnDragingAction(Action callback)
		{
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D8")]
		[Address(RVA = "0x2A06E84", Offset = "0x2A06E84", VA = "0x2A06E84")]
		public void SetOnEndDragAction(Action callback)
		{
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D9")]
		[Address(RVA = "0x2A06E8C", Offset = "0x2A06E8C", VA = "0x2A06E8C")]
		public void SetOnListClickAction(Action callback)
		{
		}

		// Token: 0x17000554 RID: 1364
		// (set) Token: 0x060023DA RID: 9178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000554")]
		public Func<LoopListLazyView2, int, LoopListLazyViewItem2> OnGetItemByIndex
		{
			[Token(Token = "0x60023DA")]
			[Address(RVA = "0x2A06E94", Offset = "0x2A06E94", VA = "0x2A06E94")]
			set
			{
			}
		}

		// Token: 0x17000555 RID: 1365
		// (set) Token: 0x060023DB RID: 9179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000555")]
		public Func<LoopListLazyView2, int, string> OnGetItemNameByIndex
		{
			[Token(Token = "0x60023DB")]
			[Address(RVA = "0x2A06E9C", Offset = "0x2A06E9C", VA = "0x2A06E9C")]
			set
			{
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x060023DC RID: 9180 RVA: 0x0000D938 File Offset: 0x0000BB38
		[Token(Token = "0x17000556")]
		public bool IsVertList
		{
			[Token(Token = "0x60023DC")]
			[Address(RVA = "0x2A06EA4", Offset = "0x2A06EA4", VA = "0x2A06EA4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x060023DD RID: 9181 RVA: 0x0000D950 File Offset: 0x0000BB50
		[Token(Token = "0x17000557")]
		public int ItemTotalCount
		{
			[Token(Token = "0x60023DD")]
			[Address(RVA = "0x2A06EAC", Offset = "0x2A06EAC", VA = "0x2A06EAC")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x060023DE RID: 9182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000558")]
		public RectTransform ContainerTrans
		{
			[Token(Token = "0x60023DE")]
			[Address(RVA = "0x2A06EB4", Offset = "0x2A06EB4", VA = "0x2A06EB4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x060023DF RID: 9183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000559")]
		public ScrollRect ScrollRect
		{
			[Token(Token = "0x60023DF")]
			[Address(RVA = "0x2A06EBC", Offset = "0x2A06EBC", VA = "0x2A06EBC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x060023E0 RID: 9184 RVA: 0x0000D968 File Offset: 0x0000BB68
		[Token(Token = "0x1700055A")]
		public bool IsDraging
		{
			[Token(Token = "0x60023E0")]
			[Address(RVA = "0x2A06EC4", Offset = "0x2A06EC4", VA = "0x2A06EC4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x060023E1 RID: 9185 RVA: 0x0000D980 File Offset: 0x0000BB80
		// (set) Token: 0x060023E2 RID: 9186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700055B")]
		public float PriorityLastItemPadding
		{
			[Token(Token = "0x60023E1")]
			[Address(RVA = "0x2A06ECC", Offset = "0x2A06ECC", VA = "0x2A06ECC")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60023E2")]
			[Address(RVA = "0x2A06ED4", Offset = "0x2A06ED4", VA = "0x2A06ED4")]
			set
			{
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x060023E3 RID: 9187 RVA: 0x0000D998 File Offset: 0x0000BB98
		// (set) Token: 0x060023E4 RID: 9188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700055C")]
		public bool ItemSnapEnable
		{
			[Token(Token = "0x60023E3")]
			[Address(RVA = "0x2A06EDC", Offset = "0x2A06EDC", VA = "0x2A06EDC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60023E4")]
			[Address(RVA = "0x2A06EE4", Offset = "0x2A06EE4", VA = "0x2A06EE4")]
			set
			{
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x060023E5 RID: 9189 RVA: 0x0000D9B0 File Offset: 0x0000BBB0
		// (set) Token: 0x060023E6 RID: 9190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700055D")]
		public bool SupportScrollBar
		{
			[Token(Token = "0x60023E5")]
			[Address(RVA = "0x2A06EF0", Offset = "0x2A06EF0", VA = "0x2A06EF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60023E6")]
			[Address(RVA = "0x2A06EF8", Offset = "0x2A06EF8", VA = "0x2A06EF8")]
			set
			{
			}
		}

		// Token: 0x060023E7 RID: 9191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E7")]
		[Address(RVA = "0x2A06F04", Offset = "0x2A06F04", VA = "0x2A06F04", Slot = "7")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x060023E8 RID: 9192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E8")]
		[Address(RVA = "0x2A06F20", Offset = "0x2A06F20", VA = "0x2A06F20")]
		public void InitListView(int itemTotalCount, Func<LoopListLazyView2, int, LoopListLazyViewItem2> onGetItemByIndex, [Optional] LoopListViewInitParam initParam, [Optional] Func<LoopListLazyView2, int, string> onGetItemNameByIndex)
		{
		}

		// Token: 0x060023E9 RID: 9193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E9")]
		[Address(RVA = "0x2A07CE0", Offset = "0x2A07CE0", VA = "0x2A07CE0")]
		public void SetMoveType(int type)
		{
		}

		// Token: 0x060023EA RID: 9194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023EA")]
		[Address(RVA = "0x2A073F0", Offset = "0x2A073F0", VA = "0x2A073F0")]
		private void SetScrollbarListener()
		{
		}

		// Token: 0x060023EB RID: 9195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023EB")]
		[Address(RVA = "0x2A07D48", Offset = "0x2A07D48", VA = "0x2A07D48")]
		private void OnPointerDownInScrollBar(GameObject obj)
		{
		}

		// Token: 0x060023EC RID: 9196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023EC")]
		[Address(RVA = "0x2A07D64", Offset = "0x2A07D64", VA = "0x2A07D64")]
		private void OnPointerUpInScrollBar(GameObject obj)
		{
		}

		// Token: 0x060023ED RID: 9197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023ED")]
		[Address(RVA = "0x2A07ADC", Offset = "0x2A07ADC", VA = "0x2A07ADC")]
		public void ResetListView()
		{
		}

		// Token: 0x060023EE RID: 9198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023EE")]
		[Address(RVA = "0x2A07B6C", Offset = "0x2A07B6C", VA = "0x2A07B6C")]
		public void SetListItemCount(int itemCount, bool resetPos = true, bool needMoveToIndex = true)
		{
		}

		// Token: 0x060023EF RID: 9199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023EF")]
		[Address(RVA = "0x2A08910", Offset = "0x2A08910", VA = "0x2A08910")]
		public LoopListLazyViewItem2 GetShownItemByItemIndex(int itemIndex)
		{
			return null;
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x060023F0 RID: 9200 RVA: 0x0000D9C8 File Offset: 0x0000BBC8
		[Token(Token = "0x1700055E")]
		public int ShownItemCount
		{
			[Token(Token = "0x60023F0")]
			[Address(RVA = "0x2A08A00", Offset = "0x2A08A00", VA = "0x2A08A00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x060023F1 RID: 9201 RVA: 0x0000D9E0 File Offset: 0x0000BBE0
		[Token(Token = "0x1700055F")]
		public float ViewPortSize
		{
			[Token(Token = "0x60023F1")]
			[Address(RVA = "0x2A08A48", Offset = "0x2A08A48", VA = "0x2A08A48")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x060023F2 RID: 9202 RVA: 0x0000D9F8 File Offset: 0x0000BBF8
		[Token(Token = "0x17000560")]
		public float ViewPortWidth
		{
			[Token(Token = "0x60023F2")]
			[Address(RVA = "0x2A08A9C", Offset = "0x2A08A9C", VA = "0x2A08A9C")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x060023F3 RID: 9203 RVA: 0x0000DA10 File Offset: 0x0000BC10
		[Token(Token = "0x17000561")]
		public float ViewPortHeight
		{
			[Token(Token = "0x60023F3")]
			[Address(RVA = "0x2A08ADC", Offset = "0x2A08ADC", VA = "0x2A08ADC")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060023F4 RID: 9204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023F4")]
		[Address(RVA = "0x2A08B1C", Offset = "0x2A08B1C", VA = "0x2A08B1C")]
		public LoopListLazyViewItem2 GetShownItemByIndex(int index)
		{
			return null;
		}

		// Token: 0x060023F5 RID: 9205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023F5")]
		[Address(RVA = "0x2A08BA0", Offset = "0x2A08BA0", VA = "0x2A08BA0")]
		public LoopListLazyViewItem2 GetShownItemByIndexWithoutCheck(int index)
		{
			return null;
		}

		// Token: 0x060023F6 RID: 9206 RVA: 0x0000DA28 File Offset: 0x0000BC28
		[Token(Token = "0x60023F6")]
		[Address(RVA = "0x2A08BF8", Offset = "0x2A08BF8", VA = "0x2A08BF8")]
		public int GetIndexInShownItemList(LoopListLazyViewItem2 item)
		{
			return 0;
		}

		// Token: 0x060023F7 RID: 9207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F7")]
		[Address(RVA = "0x2A08D00", Offset = "0x2A08D00", VA = "0x2A08D00")]
		public void DoActionForEachShownItem(Action<LoopListLazyViewItem2, object> action, object param)
		{
		}

		// Token: 0x060023F8 RID: 9208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023F8")]
		[Address(RVA = "0x2A08DC0", Offset = "0x2A08DC0", VA = "0x2A08DC0")]
		public LoopListLazyViewItem2 NewListViewItem(string itemPrefabName)
		{
			return null;
		}

		// Token: 0x060023F9 RID: 9209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F9")]
		[Address(RVA = "0x2A08F50", Offset = "0x2A08F50", VA = "0x2A08F50")]
		public void OnItemSizeChanged(int itemIndex)
		{
		}

		// Token: 0x060023FA RID: 9210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FA")]
		[Address(RVA = "0x2A0909C", Offset = "0x2A0909C", VA = "0x2A0909C")]
		public void RefreshItemByItemIndex(int itemIndex)
		{
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FB")]
		[Address(RVA = "0x2A096BC", Offset = "0x2A096BC", VA = "0x2A096BC")]
		public void FinishSnapImmediately()
		{
		}

		// Token: 0x060023FC RID: 9212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023FC")]
		[Address(RVA = "0x2A096E8", Offset = "0x2A096E8", VA = "0x2A096E8")]
		public List<int> GetCurShowIndexes()
		{
			return null;
		}

		// Token: 0x060023FD RID: 9213 RVA: 0x0000DA40 File Offset: 0x0000BC40
		[Token(Token = "0x60023FD")]
		[Address(RVA = "0x2A09898", Offset = "0x2A09898", VA = "0x2A09898")]
		public Vector3 GetMovePanelToIndexPos(int itemIndex, float offset)
		{
			return default(Vector3);
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FE")]
		[Address(RVA = "0x2A0804C", Offset = "0x2A0804C", VA = "0x2A0804C")]
		public void MovePanelToItemIndex(int itemIndex, float offset)
		{
		}

		// Token: 0x060023FF RID: 9215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FF")]
		[Address(RVA = "0x2A0A35C", Offset = "0x2A0A35C", VA = "0x2A0A35C")]
		public void RefreshAllShownItem()
		{
		}

		// Token: 0x06002400 RID: 9216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002400")]
		[Address(RVA = "0x2A09470", Offset = "0x2A09470", VA = "0x2A09470")]
		public void RefreshAllShownItemWithFirstIndex(int firstItemIndex)
		{
		}

		// Token: 0x06002401 RID: 9217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002401")]
		[Address(RVA = "0x2A0A3E0", Offset = "0x2A0A3E0", VA = "0x2A0A3E0")]
		public void RefreshAllShownItemWithFirstIndexAndPos(int firstItemIndex, Vector3 pos)
		{
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002402")]
		[Address(RVA = "0x2A092C8", Offset = "0x2A092C8", VA = "0x2A092C8")]
		private void RecycleItemTmp(LoopListLazyViewItem2 item)
		{
		}

		// Token: 0x06002403 RID: 9219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002403")]
		[Address(RVA = "0x2A07F14", Offset = "0x2A07F14", VA = "0x2A07F14")]
		private void ClearAllTmpRecycledItem()
		{
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002404")]
		[Address(RVA = "0x2A07D9C", Offset = "0x2A07D9C", VA = "0x2A07D9C")]
		private void RecycleAllItem()
		{
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002405")]
		[Address(RVA = "0x2A07738", Offset = "0x2A07738", VA = "0x2A07738")]
		private void AdjustContainerPivot(RectTransform rtf)
		{
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002406")]
		[Address(RVA = "0x2A075F8", Offset = "0x2A075F8", VA = "0x2A075F8")]
		private void AdjustPivot(RectTransform rtf)
		{
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002407")]
		[Address(RVA = "0x2A0A5C4", Offset = "0x2A0A5C4", VA = "0x2A0A5C4")]
		private void AdjustContainerAnchor(RectTransform rtf)
		{
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002408")]
		[Address(RVA = "0x2A0766C", Offset = "0x2A0766C", VA = "0x2A0766C")]
		private void AdjustAnchor(RectTransform rtf)
		{
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002409")]
		[Address(RVA = "0x2A077AC", Offset = "0x2A077AC", VA = "0x2A077AC")]
		private void InitItemPool()
		{
		}

		// Token: 0x0600240A RID: 9226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600240A")]
		[Address(RVA = "0x2A0A690", Offset = "0x2A0A690", VA = "0x2A0A690", Slot = "8")]
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0600240B RID: 9227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600240B")]
		[Address(RVA = "0x2A0A9F8", Offset = "0x2A0A9F8", VA = "0x2A0A9F8", Slot = "9")]
		public virtual void OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0600240C RID: 9228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600240C")]
		[Address(RVA = "0x2A0AA64", Offset = "0x2A0AA64", VA = "0x2A0AA64", Slot = "10")]
		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0600240D RID: 9229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600240D")]
		[Address(RVA = "0x2A0A6F8", Offset = "0x2A0A6F8", VA = "0x2A0A6F8")]
		private void CacheDragPointerEventData(PointerEventData eventData)
		{
		}

		// Token: 0x0600240E RID: 9230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600240E")]
		[Address(RVA = "0x2A09398", Offset = "0x2A09398", VA = "0x2A09398")]
		private LoopListLazyViewItem2 GetNewItemByIndex(int index)
		{
			return null;
		}

		// Token: 0x0600240F RID: 9231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600240F")]
		[Address(RVA = "0x2A0904C", Offset = "0x2A0904C", VA = "0x2A0904C")]
		private void SetItemSize(int itemIndex, float itemSize, float padding)
		{
		}

		// Token: 0x06002410 RID: 9232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002410")]
		[Address(RVA = "0x2A0AAA4", Offset = "0x2A0AAA4", VA = "0x2A0AAA4")]
		private void GetPlusItemIndexAndPosAtGivenPos(float pos, ref int index, ref float itemPos)
		{
		}

		// Token: 0x06002411 RID: 9233 RVA: 0x0000DA58 File Offset: 0x0000BC58
		[Token(Token = "0x6002411")]
		[Address(RVA = "0x2A0AABC", Offset = "0x2A0AABC", VA = "0x2A0AABC")]
		private float GetItemPos(int itemIndex)
		{
			return 0f;
		}

		// Token: 0x06002412 RID: 9234 RVA: 0x0000DA70 File Offset: 0x0000BC70
		[Token(Token = "0x6002412")]
		[Address(RVA = "0x2A0AAD4", Offset = "0x2A0AAD4", VA = "0x2A0AAD4")]
		public Vector3 GetItemCornerPosInViewPort(LoopListLazyViewItem2 item, ItemCornerEnum corner = ItemCornerEnum.LeftBottom)
		{
			return default(Vector3);
		}

		// Token: 0x06002413 RID: 9235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002413")]
		[Address(RVA = "0x2A09C1C", Offset = "0x2A09C1C", VA = "0x2A09C1C")]
		private void AdjustPanelPos()
		{
		}

		// Token: 0x06002414 RID: 9236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002414")]
		[Address(RVA = "0x2A0AE44", Offset = "0x2A0AE44", VA = "0x2A0AE44")]
		private void Update()
		{
		}

		// Token: 0x06002415 RID: 9237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002415")]
		[Address(RVA = "0x2A0B068", Offset = "0x2A0B068", VA = "0x2A0B068")]
		public void ForceUpdate()
		{
		}

		// Token: 0x06002416 RID: 9238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002416")]
		[Address(RVA = "0x2A096C4", Offset = "0x2A096C4", VA = "0x2A096C4")]
		private void UpdateSnapMove(bool immediate = false)
		{
		}

		// Token: 0x06002417 RID: 9239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002417")]
		[Address(RVA = "0x2A0BD44", Offset = "0x2A0BD44", VA = "0x2A0BD44")]
		public void UpdateAllShownItemSnapData()
		{
		}

		// Token: 0x06002418 RID: 9240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002418")]
		[Address(RVA = "0x2A0B06C", Offset = "0x2A0B06C", VA = "0x2A0B06C")]
		private void UpdateSnapVertical(bool immediate = false)
		{
		}

		// Token: 0x06002419 RID: 9241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002419")]
		[Address(RVA = "0x2A0C610", Offset = "0x2A0C610", VA = "0x2A0C610")]
		private void UpdateCurSnapData()
		{
		}

		// Token: 0x0600241A RID: 9242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600241A")]
		[Address(RVA = "0x2A0C5F4", Offset = "0x2A0C5F4", VA = "0x2A0C5F4")]
		public void ClearSnapData()
		{
		}

		// Token: 0x0600241B RID: 9243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600241B")]
		[Address(RVA = "0x2A0C794", Offset = "0x2A0C794", VA = "0x2A0C794")]
		public void SetSnapTargetItemIndex(int itemIndex)
		{
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x0600241C RID: 9244 RVA: 0x0000DA88 File Offset: 0x0000BC88
		[Token(Token = "0x17000562")]
		public int CurSnapNearestItemIndex
		{
			[Token(Token = "0x600241C")]
			[Address(RVA = "0x2A0C7B8", Offset = "0x2A0C7B8", VA = "0x2A0C7B8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600241D RID: 9245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600241D")]
		[Address(RVA = "0x2A07D80", Offset = "0x2A07D80", VA = "0x2A07D80")]
		public void ForceSnapUpdateCheck()
		{
		}

		// Token: 0x0600241E RID: 9246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600241E")]
		[Address(RVA = "0x2A0B6B8", Offset = "0x2A0B6B8", VA = "0x2A0B6B8")]
		private void UpdateSnapHorizontal(bool immediate = false)
		{
		}

		// Token: 0x0600241F RID: 9247 RVA: 0x0000DAA0 File Offset: 0x0000BCA0
		[Token(Token = "0x600241F")]
		[Address(RVA = "0x2A0C2FC", Offset = "0x2A0C2FC", VA = "0x2A0C2FC")]
		private bool CanSnap()
		{
			return default(bool);
		}

		// Token: 0x06002420 RID: 9248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002420")]
		[Address(RVA = "0x2A09A74", Offset = "0x2A09A74", VA = "0x2A09A74")]
		public void UpdateListView(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
		{
		}

		// Token: 0x06002421 RID: 9249 RVA: 0x0000DAB8 File Offset: 0x0000BCB8
		[Token(Token = "0x6002421")]
		[Address(RVA = "0x2A0C7C0", Offset = "0x2A0C7C0", VA = "0x2A0C7C0")]
		private bool UpdateForVertList(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
		{
			return default(bool);
		}

		// Token: 0x06002422 RID: 9250 RVA: 0x0000DAD0 File Offset: 0x0000BCD0
		[Token(Token = "0x6002422")]
		[Address(RVA = "0x2A0D604", Offset = "0x2A0D604", VA = "0x2A0D604")]
		private bool UpdateForHorizontalList(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
		{
			return default(bool);
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x0000DAE8 File Offset: 0x0000BCE8
		[Token(Token = "0x6002423")]
		[Address(RVA = "0x2A0AB4C", Offset = "0x2A0AB4C", VA = "0x2A0AB4C")]
		private float GetContentPanelSize()
		{
			return 0f;
		}

		// Token: 0x06002424 RID: 9252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002424")]
		[Address(RVA = "0x2A0E448", Offset = "0x2A0E448", VA = "0x2A0E448")]
		private void CheckIfNeedUpdataItemPos()
		{
		}

		// Token: 0x06002425 RID: 9253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002425")]
		[Address(RVA = "0x2A08380", Offset = "0x2A08380", VA = "0x2A08380")]
		private void UpdateAllShownItemsPos()
		{
		}

		// Token: 0x06002426 RID: 9254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002426")]
		[Address(RVA = "0x2A07FAC", Offset = "0x2A07FAC", VA = "0x2A07FAC")]
		private void UpdateContentSize()
		{
		}

		// Token: 0x06002427 RID: 9255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002427")]
		[Address(RVA = "0x2A0A840", Offset = "0x2A0A840", VA = "0x2A0A840")]
		private void CanCleItemClickAnimation()
		{
		}

		// Token: 0x06002428 RID: 9256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002428")]
		[Address(RVA = "0x2A0E7C0", Offset = "0x2A0E7C0", VA = "0x2A0E7C0")]
		public void ClearAllItems()
		{
		}

		// Token: 0x06002429 RID: 9257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002429")]
		[Address(RVA = "0x2A0ACC4", Offset = "0x2A0ACC4", VA = "0x2A0ACC4")]
		private void SetContainerLocalPosY(float y)
		{
		}

		// Token: 0x0600242A RID: 9258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600242A")]
		[Address(RVA = "0x2A0AF10", Offset = "0x2A0AF10", VA = "0x2A0AF10")]
		private void SetVelocity(Vector2 velocity)
		{
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600242B")]
		[Address(RVA = "0x2A0EA78", Offset = "0x2A0EA78", VA = "0x2A0EA78")]
		public void OnValidate()
		{
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600242C")]
		[Address(RVA = "0x2A0EA7C", Offset = "0x2A0EA7C", VA = "0x2A0EA7C")]
		private void ProcessLazyData()
		{
		}

		// Token: 0x0600242D RID: 9261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600242D")]
		[Address(RVA = "0x2A0EA80", Offset = "0x2A0EA80", VA = "0x2A0EA80")]
		public LoopListLazyView2()
		{
		}

		// Token: 0x04002127 RID: 8487
		[Token(Token = "0x4002127")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, ItemLazyPool> mItemPoolDict;

		// Token: 0x04002128 RID: 8488
		[Token(Token = "0x4002128")]
		[FieldOffset(Offset = "0x20")]
		private List<ItemLazyPool> mItemPoolList;

		// Token: 0x04002129 RID: 8489
		[Token(Token = "0x4002129")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<ItemPrefabLazyConfData> mItemPrefabDataList;

		// Token: 0x0400212A RID: 8490
		[Token(Token = "0x400212A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ListItemArrangeType mArrangeType;

		// Token: 0x0400212B RID: 8491
		[Token(Token = "0x400212B")]
		[FieldOffset(Offset = "0x38")]
		private List<LoopListLazyViewItem2> mItemList;

		// Token: 0x0400212C RID: 8492
		[Token(Token = "0x400212C")]
		[FieldOffset(Offset = "0x40")]
		private RectTransform mContainerTrans;

		// Token: 0x0400212D RID: 8493
		[Token(Token = "0x400212D")]
		[FieldOffset(Offset = "0x48")]
		private ScrollRect mScrollRect;

		// Token: 0x0400212E RID: 8494
		[Token(Token = "0x400212E")]
		[FieldOffset(Offset = "0x50")]
		private RectTransform mScrollRectTransform;

		// Token: 0x0400212F RID: 8495
		[Token(Token = "0x400212F")]
		[FieldOffset(Offset = "0x58")]
		private RectTransform mViewPortRectTransform;

		// Token: 0x04002130 RID: 8496
		[Token(Token = "0x4002130")]
		[FieldOffset(Offset = "0x60")]
		private float mItemDefaultWithPaddingSize;

		// Token: 0x04002131 RID: 8497
		[Token(Token = "0x4002131")]
		[FieldOffset(Offset = "0x64")]
		private int mItemTotalCount;

		// Token: 0x04002132 RID: 8498
		[Token(Token = "0x4002132")]
		[FieldOffset(Offset = "0x68")]
		private bool mIsVertList;

		// Token: 0x04002133 RID: 8499
		[Token(Token = "0x4002133")]
		[FieldOffset(Offset = "0x70")]
		private Func<LoopListLazyView2, int, LoopListLazyViewItem2> mOnGetItemByIndex;

		// Token: 0x04002134 RID: 8500
		[Token(Token = "0x4002134")]
		[FieldOffset(Offset = "0x78")]
		private Func<LoopListLazyView2, int, string> mOnGetItemNameByIndex;

		// Token: 0x04002135 RID: 8501
		[Token(Token = "0x4002135")]
		[FieldOffset(Offset = "0x80")]
		private Vector3[] mItemWorldCorners;

		// Token: 0x04002136 RID: 8502
		[Token(Token = "0x4002136")]
		[FieldOffset(Offset = "0x88")]
		private Vector3[] mViewPortRectLocalCorners;

		// Token: 0x04002137 RID: 8503
		[Token(Token = "0x4002137")]
		[FieldOffset(Offset = "0x90")]
		private int mCurReadyMinItemIndex;

		// Token: 0x04002138 RID: 8504
		[Token(Token = "0x4002138")]
		[FieldOffset(Offset = "0x94")]
		private int mCurReadyMaxItemIndex;

		// Token: 0x04002139 RID: 8505
		[Token(Token = "0x4002139")]
		[FieldOffset(Offset = "0x98")]
		private bool mNeedCheckNextMinItem;

		// Token: 0x0400213A RID: 8506
		[Token(Token = "0x400213A")]
		[FieldOffset(Offset = "0x99")]
		private bool mNeedCheckNextMaxItem;

		// Token: 0x0400213B RID: 8507
		[Token(Token = "0x400213B")]
		[FieldOffset(Offset = "0xA0")]
		private ItemPosMgr mItemPosMgr;

		// Token: 0x0400213C RID: 8508
		[Token(Token = "0x400213C")]
		[FieldOffset(Offset = "0xA8")]
		private float mDistanceForRecycle0;

		// Token: 0x0400213D RID: 8509
		[Token(Token = "0x400213D")]
		[FieldOffset(Offset = "0xAC")]
		private float mDistanceForNew0;

		// Token: 0x0400213E RID: 8510
		[Token(Token = "0x400213E")]
		[FieldOffset(Offset = "0xB0")]
		private float mDistanceForRecycle1;

		// Token: 0x0400213F RID: 8511
		[Token(Token = "0x400213F")]
		[FieldOffset(Offset = "0xB4")]
		private float mDistanceForNew1;

		// Token: 0x04002140 RID: 8512
		[Token(Token = "0x4002140")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private bool mSupportScrollBar;

		// Token: 0x04002141 RID: 8513
		[Token(Token = "0x4002141")]
		[FieldOffset(Offset = "0xB9")]
		[SerializeField]
		private bool mItemInterruptAnim;

		// Token: 0x04002142 RID: 8514
		[Token(Token = "0x4002142")]
		[FieldOffset(Offset = "0xBA")]
		private bool mIsDraging;

		// Token: 0x04002143 RID: 8515
		[Token(Token = "0x4002143")]
		[FieldOffset(Offset = "0xC0")]
		private PointerEventData mPointerEventData;

		// Token: 0x04002144 RID: 8516
		[Token(Token = "0x4002144")]
		[FieldOffset(Offset = "0xC8")]
		public Action mOnBeginDragAction;

		// Token: 0x04002145 RID: 8517
		[Token(Token = "0x4002145")]
		[FieldOffset(Offset = "0xD0")]
		public Action mOnDragingAction;

		// Token: 0x04002146 RID: 8518
		[Token(Token = "0x4002146")]
		[FieldOffset(Offset = "0xD8")]
		public Action mOnEndDragAction;

		// Token: 0x04002147 RID: 8519
		[Token(Token = "0x4002147")]
		[FieldOffset(Offset = "0xE0")]
		public Action mOnListClickAction;

		// Token: 0x04002148 RID: 8520
		[Token(Token = "0x4002148")]
		[FieldOffset(Offset = "0xE8")]
		private int mLastItemIndex;

		// Token: 0x04002149 RID: 8521
		[Token(Token = "0x4002149")]
		[FieldOffset(Offset = "0xEC")]
		private float mLastItemPadding;

		// Token: 0x0400214A RID: 8522
		[Token(Token = "0x400214A")]
		[FieldOffset(Offset = "0xF0")]
		private float mPriorityLastItemPadding;

		// Token: 0x0400214B RID: 8523
		[Token(Token = "0x400214B")]
		[FieldOffset(Offset = "0xF4")]
		private float mSmoothDumpVel;

		// Token: 0x0400214C RID: 8524
		[Token(Token = "0x400214C")]
		[FieldOffset(Offset = "0xF8")]
		private float mSmoothDumpRate;

		// Token: 0x0400214D RID: 8525
		[Token(Token = "0x400214D")]
		[FieldOffset(Offset = "0xFC")]
		private float mSnapFinishThreshold;

		// Token: 0x0400214E RID: 8526
		[Token(Token = "0x400214E")]
		[FieldOffset(Offset = "0x100")]
		private float mSnapVecThreshold;

		// Token: 0x0400214F RID: 8527
		[Token(Token = "0x400214F")]
		[FieldOffset(Offset = "0x104")]
		[SerializeField]
		private bool mItemSnapEnable;

		// Token: 0x04002150 RID: 8528
		[Token(Token = "0x4002150")]
		[FieldOffset(Offset = "0x108")]
		private Vector3 mLastFrameContainerPos;

		// Token: 0x04002151 RID: 8529
		[Token(Token = "0x4002151")]
		[FieldOffset(Offset = "0x118")]
		public Action<LoopListLazyView2, LoopListLazyViewItem2> mOnSnapItemFinished;

		// Token: 0x04002152 RID: 8530
		[Token(Token = "0x4002152")]
		[FieldOffset(Offset = "0x120")]
		public Action<LoopListLazyView2, LoopListLazyViewItem2> mOnSnapNearestChanged;

		// Token: 0x04002153 RID: 8531
		[Token(Token = "0x4002153")]
		[FieldOffset(Offset = "0x128")]
		private int mCurSnapNearestItemIndex;

		// Token: 0x04002154 RID: 8532
		[Token(Token = "0x4002154")]
		[FieldOffset(Offset = "0x12C")]
		private Vector2 mAdjustedVec;

		// Token: 0x04002155 RID: 8533
		[Token(Token = "0x4002155")]
		[FieldOffset(Offset = "0x134")]
		private bool mNeedAdjustVec;

		// Token: 0x04002156 RID: 8534
		[Token(Token = "0x4002156")]
		[FieldOffset(Offset = "0x138")]
		private int mLeftSnapUpdateExtraCount;

		// Token: 0x04002157 RID: 8535
		[Token(Token = "0x4002157")]
		[FieldOffset(Offset = "0x13C")]
		[SerializeField]
		private Vector2 mViewPortSnapPivot;

		// Token: 0x04002158 RID: 8536
		[Token(Token = "0x4002158")]
		[FieldOffset(Offset = "0x144")]
		[SerializeField]
		private Vector2 mItemSnapPivot;

		// Token: 0x04002159 RID: 8537
		[Token(Token = "0x4002159")]
		[FieldOffset(Offset = "0x150")]
		private ClickEventListener mScrollBarClickEventListener;

		// Token: 0x0400215A RID: 8538
		[Token(Token = "0x400215A")]
		[FieldOffset(Offset = "0x158")]
		private LoopListLazyView2.SnapData mCurSnapData;

		// Token: 0x0400215B RID: 8539
		[Token(Token = "0x400215B")]
		[FieldOffset(Offset = "0x160")]
		private Vector3 mLastSnapCheckPos;

		// Token: 0x0400215C RID: 8540
		[Token(Token = "0x400215C")]
		[FieldOffset(Offset = "0x16C")]
		private bool mListViewInited;

		// Token: 0x0400215D RID: 8541
		[Token(Token = "0x400215D")]
		[FieldOffset(Offset = "0x170")]
		private int mListUpdateCheckFrameCount;

		// Token: 0x0400215E RID: 8542
		[Token(Token = "0x400215E")]
		[FieldOffset(Offset = "0x174")]
		private bool _isOccurError;

		// Token: 0x020004BC RID: 1212
		[Token(Token = "0x20004BC")]
		private class SnapData
		{
			// Token: 0x0600242E RID: 9262 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600242E")]
			[Address(RVA = "0x2CA1E68", Offset = "0x2CA1E68", VA = "0x2CA1E68")]
			public void Clear()
			{
			}

			// Token: 0x0600242F RID: 9263 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600242F")]
			[Address(RVA = "0x2CA1E74", Offset = "0x2CA1E74", VA = "0x2CA1E74")]
			public SnapData()
			{
			}

			// Token: 0x0400215F RID: 8543
			[Token(Token = "0x400215F")]
			[FieldOffset(Offset = "0x10")]
			public SnapStatus mSnapStatus;

			// Token: 0x04002160 RID: 8544
			[Token(Token = "0x4002160")]
			[FieldOffset(Offset = "0x14")]
			public int mSnapTargetIndex;

			// Token: 0x04002161 RID: 8545
			[Token(Token = "0x4002161")]
			[FieldOffset(Offset = "0x18")]
			public float mTargetSnapVal;

			// Token: 0x04002162 RID: 8546
			[Token(Token = "0x4002162")]
			[FieldOffset(Offset = "0x1C")]
			public float mCurSnapVal;

			// Token: 0x04002163 RID: 8547
			[Token(Token = "0x4002163")]
			[FieldOffset(Offset = "0x20")]
			public bool mIsForceSnapTo;
		}
	}
}
