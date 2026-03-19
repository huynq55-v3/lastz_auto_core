using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace SuperScrollView
{
	// Token: 0x020004C0 RID: 1216
	[Token(Token = "0x20004C0")]
	public class ItemPool
	{
		// Token: 0x06002459 RID: 9305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002459")]
		[Address(RVA = "0x2CA247C", Offset = "0x2CA247C", VA = "0x2CA247C")]
		public ItemPool()
		{
		}

		// Token: 0x0600245A RID: 9306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600245A")]
		[Address(RVA = "0x2CA2568", Offset = "0x2CA2568", VA = "0x2CA2568")]
		public void Init(ItemPrefabConfData data, RectTransform parent)
		{
		}

		// Token: 0x0600245B RID: 9307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600245B")]
		[Address(RVA = "0x2CA2948", Offset = "0x2CA2948", VA = "0x2CA2948")]
		public LoopListViewItem2 GetItem()
		{
			return null;
		}

		// Token: 0x0600245C RID: 9308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600245C")]
		[Address(RVA = "0x2CA2A3C", Offset = "0x2CA2A3C", VA = "0x2CA2A3C")]
		public void DestroyAllItem()
		{
		}

		// Token: 0x0600245D RID: 9309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600245D")]
		[Address(RVA = "0x2CA2654", Offset = "0x2CA2654", VA = "0x2CA2654")]
		public LoopListViewItem2 CreateItem()
		{
			return null;
		}

		// Token: 0x0600245E RID: 9310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600245E")]
		[Address(RVA = "0x2CA28D0", Offset = "0x2CA28D0", VA = "0x2CA28D0")]
		private void RecycleItemReal(LoopListViewItem2 item)
		{
		}

		// Token: 0x0600245F RID: 9311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600245F")]
		[Address(RVA = "0x2CA2BE8", Offset = "0x2CA2BE8", VA = "0x2CA2BE8")]
		public void RecycleItem(LoopListViewItem2 item)
		{
		}

		// Token: 0x06002460 RID: 9312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002460")]
		[Address(RVA = "0x2CA2B2C", Offset = "0x2CA2B2C", VA = "0x2CA2B2C")]
		public void ClearTmpRecycledItem()
		{
		}

		// Token: 0x0400217F RID: 8575
		[Token(Token = "0x400217F")]
		[FieldOffset(Offset = "0x10")]
		private GameObject mPrefabObj;

		// Token: 0x04002180 RID: 8576
		[Token(Token = "0x4002180")]
		[FieldOffset(Offset = "0x18")]
		private string mPrefabName;

		// Token: 0x04002181 RID: 8577
		[Token(Token = "0x4002181")]
		[FieldOffset(Offset = "0x20")]
		private int mInitCreateCount;

		// Token: 0x04002182 RID: 8578
		[Token(Token = "0x4002182")]
		[FieldOffset(Offset = "0x24")]
		private float mPadding;

		// Token: 0x04002183 RID: 8579
		[Token(Token = "0x4002183")]
		[FieldOffset(Offset = "0x28")]
		private float mStartPosOffset;

		// Token: 0x04002184 RID: 8580
		[Token(Token = "0x4002184")]
		[FieldOffset(Offset = "0x2C")]
		private bool mAnimationCancle;

		// Token: 0x04002185 RID: 8581
		[Token(Token = "0x4002185")]
		[FieldOffset(Offset = "0x30")]
		private string mAnimatorPath;

		// Token: 0x04002186 RID: 8582
		[Token(Token = "0x4002186")]
		[FieldOffset(Offset = "0x38")]
		private Queue<LoopListViewItem2> mTmpPooledItemList;

		// Token: 0x04002187 RID: 8583
		[Token(Token = "0x4002187")]
		[FieldOffset(Offset = "0x40")]
		private Queue<LoopListViewItem2> mPooledItemList;

		// Token: 0x04002188 RID: 8584
		[Token(Token = "0x4002188")]
		[FieldOffset(Offset = "0x0")]
		private static int mCurItemIdCount;

		// Token: 0x04002189 RID: 8585
		[Token(Token = "0x4002189")]
		[FieldOffset(Offset = "0x48")]
		private RectTransform mItemParent;
	}
}
