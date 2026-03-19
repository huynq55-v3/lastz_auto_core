using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace SuperScrollView
{
	// Token: 0x020004B7 RID: 1207
	[Token(Token = "0x20004B7")]
	public class ItemPosMgr
	{
		// Token: 0x060023C2 RID: 9154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C2")]
		[Address(RVA = "0x2A05C10", Offset = "0x2A05C10", VA = "0x2A05C10")]
		public ItemPosMgr(float itemDefaultSize)
		{
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C3")]
		[Address(RVA = "0x2A05CBC", Offset = "0x2A05CBC", VA = "0x2A05CBC")]
		public void SetItemMaxCount(int maxCount)
		{
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C4")]
		[Address(RVA = "0x2A05F34", Offset = "0x2A05F34", VA = "0x2A05F34")]
		public void SetItemSize(int itemIndex, float size)
		{
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x0000D908 File Offset: 0x0000BB08
		[Token(Token = "0x60023C5")]
		[Address(RVA = "0x2A05FEC", Offset = "0x2A05FEC", VA = "0x2A05FEC")]
		public float GetItemPos(int itemIndex)
		{
			return 0f;
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C6")]
		[Address(RVA = "0x2A061A0", Offset = "0x2A061A0", VA = "0x2A061A0")]
		public void GetItemIndexAndPosAtGivenPos(float pos, ref int index, ref float itemPos)
		{
		}

		// Token: 0x060023C7 RID: 9159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C7")]
		[Address(RVA = "0x2A06078", Offset = "0x2A06078", VA = "0x2A06078")]
		public void Update(bool updateAll)
		{
		}

		// Token: 0x04002106 RID: 8454
		[Token(Token = "0x4002106")]
		public const int mItemMaxCountPerGroup = 100;

		// Token: 0x04002107 RID: 8455
		[Token(Token = "0x4002107")]
		[FieldOffset(Offset = "0x10")]
		private List<ItemSizeGroup> mItemSizeGroupList;

		// Token: 0x04002108 RID: 8456
		[Token(Token = "0x4002108")]
		[FieldOffset(Offset = "0x18")]
		private int mDirtyBeginIndex;

		// Token: 0x04002109 RID: 8457
		[Token(Token = "0x4002109")]
		[FieldOffset(Offset = "0x1C")]
		public float mTotalSize;

		// Token: 0x0400210A RID: 8458
		[Token(Token = "0x400210A")]
		[FieldOffset(Offset = "0x20")]
		public float mItemDefaultSize;
	}
}
