using System;
using Il2CppDummyDll;

namespace SuperScrollView
{
	// Token: 0x020004B6 RID: 1206
	[Token(Token = "0x20004B6")]
	public class ItemSizeGroup
	{
		// Token: 0x060023B9 RID: 9145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B9")]
		[Address(RVA = "0x2A05840", Offset = "0x2A05840", VA = "0x2A05840")]
		public ItemSizeGroup(int index, float itemDefaultSize)
		{
		}

		// Token: 0x060023BA RID: 9146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023BA")]
		[Address(RVA = "0x2A05884", Offset = "0x2A05884", VA = "0x2A05884")]
		public void Init()
		{
		}

		// Token: 0x060023BB RID: 9147 RVA: 0x0000D8A8 File Offset: 0x0000BAA8
		[Token(Token = "0x60023BB")]
		[Address(RVA = "0x2A0599C", Offset = "0x2A0599C", VA = "0x2A0599C")]
		public float GetItemStartPos(int index)
		{
			return 0f;
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x060023BC RID: 9148 RVA: 0x0000D8C0 File Offset: 0x0000BAC0
		[Token(Token = "0x17000551")]
		public bool IsDirty
		{
			[Token(Token = "0x60023BC")]
			[Address(RVA = "0x2A059D4", Offset = "0x2A059D4", VA = "0x2A059D4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060023BD RID: 9149 RVA: 0x0000D8D8 File Offset: 0x0000BAD8
		[Token(Token = "0x60023BD")]
		[Address(RVA = "0x2A059E4", Offset = "0x2A059E4", VA = "0x2A059E4")]
		public float SetItemSize(int index, float size)
		{
			return 0f;
		}

		// Token: 0x060023BE RID: 9150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023BE")]
		[Address(RVA = "0x2A05A48", Offset = "0x2A05A48", VA = "0x2A05A48")]
		public void SetItemCount(int count)
		{
		}

		// Token: 0x060023BF RID: 9151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023BF")]
		[Address(RVA = "0x2A05A60", Offset = "0x2A05A60", VA = "0x2A05A60")]
		public void RecalcGroupSize()
		{
		}

		// Token: 0x060023C0 RID: 9152 RVA: 0x0000D8F0 File Offset: 0x0000BAF0
		[Token(Token = "0x60023C0")]
		[Address(RVA = "0x2A05ABC", Offset = "0x2A05ABC", VA = "0x2A05ABC")]
		public int GetItemIndexByPos(float pos)
		{
			return 0;
		}

		// Token: 0x060023C1 RID: 9153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C1")]
		[Address(RVA = "0x2A05B78", Offset = "0x2A05B78", VA = "0x2A05B78")]
		public void UpdateAllItemStartPos()
		{
		}

		// Token: 0x040020FD RID: 8445
		[Token(Token = "0x40020FD")]
		[FieldOffset(Offset = "0x10")]
		public float[] mItemSizeArray;

		// Token: 0x040020FE RID: 8446
		[Token(Token = "0x40020FE")]
		[FieldOffset(Offset = "0x18")]
		public float[] mItemStartPosArray;

		// Token: 0x040020FF RID: 8447
		[Token(Token = "0x40020FF")]
		[FieldOffset(Offset = "0x20")]
		public int mItemCount;

		// Token: 0x04002100 RID: 8448
		[Token(Token = "0x4002100")]
		[FieldOffset(Offset = "0x24")]
		private int mDirtyBeginIndex;

		// Token: 0x04002101 RID: 8449
		[Token(Token = "0x4002101")]
		[FieldOffset(Offset = "0x28")]
		public float mGroupSize;

		// Token: 0x04002102 RID: 8450
		[Token(Token = "0x4002102")]
		[FieldOffset(Offset = "0x2C")]
		public float mGroupStartPos;

		// Token: 0x04002103 RID: 8451
		[Token(Token = "0x4002103")]
		[FieldOffset(Offset = "0x30")]
		public float mGroupEndPos;

		// Token: 0x04002104 RID: 8452
		[Token(Token = "0x4002104")]
		[FieldOffset(Offset = "0x34")]
		public int mGroupIndex;

		// Token: 0x04002105 RID: 8453
		[Token(Token = "0x4002105")]
		[FieldOffset(Offset = "0x38")]
		private float mItemDefaultSize;
	}
}
