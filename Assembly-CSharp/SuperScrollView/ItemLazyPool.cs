using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using VEngine;

namespace SuperScrollView
{
	// Token: 0x020004B9 RID: 1209
	[Token(Token = "0x20004B9")]
	public class ItemLazyPool
	{
		// Token: 0x060023C8 RID: 9160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C8")]
		[Address(RVA = "0x2A062E4", Offset = "0x2A062E4", VA = "0x2A062E4")]
		public ItemLazyPool()
		{
		}

		// Token: 0x060023C9 RID: 9161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C9")]
		[Address(RVA = "0x2A063D8", Offset = "0x2A063D8", VA = "0x2A063D8")]
		public void Init(ItemPrefabLazyConfData data, RectTransform parent)
		{
		}

		// Token: 0x060023CA RID: 9162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023CA")]
		[Address(RVA = "0x2A06834", Offset = "0x2A06834", VA = "0x2A06834")]
		private void LoadPrefabObject()
		{
		}

		// Token: 0x060023CB RID: 9163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023CB")]
		[Address(RVA = "0x2A069C8", Offset = "0x2A069C8", VA = "0x2A069C8")]
		public LoopListLazyViewItem2 GetItem()
		{
			return null;
		}

		// Token: 0x060023CC RID: 9164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023CC")]
		[Address(RVA = "0x2A06B58", Offset = "0x2A06B58", VA = "0x2A06B58")]
		public void DestroyAllItem()
		{
		}

		// Token: 0x060023CD RID: 9165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023CD")]
		[Address(RVA = "0x2A06540", Offset = "0x2A06540", VA = "0x2A06540")]
		public LoopListLazyViewItem2 CreateItem()
		{
			return null;
		}

		// Token: 0x060023CE RID: 9166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023CE")]
		[Address(RVA = "0x2A067BC", Offset = "0x2A067BC", VA = "0x2A067BC")]
		private void RecycleItemReal(LoopListLazyViewItem2 item)
		{
		}

		// Token: 0x060023CF RID: 9167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023CF")]
		[Address(RVA = "0x2A06D74", Offset = "0x2A06D74", VA = "0x2A06D74")]
		public void RecycleItem(LoopListLazyViewItem2 item)
		{
		}

		// Token: 0x060023D0 RID: 9168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D0")]
		[Address(RVA = "0x2A06CB8", Offset = "0x2A06CB8", VA = "0x2A06CB8")]
		public void ClearTmpRecycledItem()
		{
		}

		// Token: 0x0400210F RID: 8463
		[Token(Token = "0x400210F")]
		[FieldOffset(Offset = "0x10")]
		private GameObject mPrefabObj;

		// Token: 0x04002110 RID: 8464
		[Token(Token = "0x4002110")]
		[FieldOffset(Offset = "0x18")]
		private string mPrefabName;

		// Token: 0x04002111 RID: 8465
		[Token(Token = "0x4002111")]
		[FieldOffset(Offset = "0x20")]
		private string mPrefabPath;

		// Token: 0x04002112 RID: 8466
		[Token(Token = "0x4002112")]
		[FieldOffset(Offset = "0x28")]
		private int mInitCreateCount;

		// Token: 0x04002113 RID: 8467
		[Token(Token = "0x4002113")]
		[FieldOffset(Offset = "0x2C")]
		private float mPadding;

		// Token: 0x04002114 RID: 8468
		[Token(Token = "0x4002114")]
		[FieldOffset(Offset = "0x30")]
		private float mStartPosOffset;

		// Token: 0x04002115 RID: 8469
		[Token(Token = "0x4002115")]
		[FieldOffset(Offset = "0x34")]
		private bool mAnimationCancle;

		// Token: 0x04002116 RID: 8470
		[Token(Token = "0x4002116")]
		[FieldOffset(Offset = "0x38")]
		private string mAnimatorPath;

		// Token: 0x04002117 RID: 8471
		[Token(Token = "0x4002117")]
		[FieldOffset(Offset = "0x40")]
		private Queue<LoopListLazyViewItem2> mTmpPooledItemList;

		// Token: 0x04002118 RID: 8472
		[Token(Token = "0x4002118")]
		[FieldOffset(Offset = "0x48")]
		private Queue<LoopListLazyViewItem2> mPooledItemList;

		// Token: 0x04002119 RID: 8473
		[Token(Token = "0x4002119")]
		[FieldOffset(Offset = "0x0")]
		private static int mCurItemIdCount;

		// Token: 0x0400211A RID: 8474
		[Token(Token = "0x400211A")]
		[FieldOffset(Offset = "0x50")]
		private RectTransform mItemParent;

		// Token: 0x0400211B RID: 8475
		[Token(Token = "0x400211B")]
		[FieldOffset(Offset = "0x58")]
		private ItemLazyAssetStatus mAssetStatus;

		// Token: 0x0400211C RID: 8476
		[Token(Token = "0x400211C")]
		[FieldOffset(Offset = "0x60")]
		private Asset mAsset;
	}
}
