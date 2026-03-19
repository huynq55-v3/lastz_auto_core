using System;
using Il2CppDummyDll;
using UnityEngine;

namespace SuperScrollView
{
	// Token: 0x020004C1 RID: 1217
	[Token(Token = "0x20004C1")]
	[Serializable]
	public class ItemPrefabConfData
	{
		// Token: 0x06002461 RID: 9313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002461")]
		[Address(RVA = "0x2CA2C40", Offset = "0x2CA2C40", VA = "0x2CA2C40")]
		public ItemPrefabConfData()
		{
		}

		// Token: 0x0400218A RID: 8586
		[Token(Token = "0x400218A")]
		[FieldOffset(Offset = "0x10")]
		public GameObject mItemPrefab;

		// Token: 0x0400218B RID: 8587
		[Token(Token = "0x400218B")]
		[FieldOffset(Offset = "0x18")]
		public float mPadding;

		// Token: 0x0400218C RID: 8588
		[Token(Token = "0x400218C")]
		[FieldOffset(Offset = "0x1C")]
		public int mInitCreateCount;

		// Token: 0x0400218D RID: 8589
		[Token(Token = "0x400218D")]
		[FieldOffset(Offset = "0x20")]
		public float mStartPosOffset;

		// Token: 0x0400218E RID: 8590
		[Token(Token = "0x400218E")]
		[FieldOffset(Offset = "0x24")]
		public float mItemHeight;

		// Token: 0x0400218F RID: 8591
		[Token(Token = "0x400218F")]
		[FieldOffset(Offset = "0x28")]
		public bool mAnimationCancle;

		// Token: 0x04002190 RID: 8592
		[Token(Token = "0x4002190")]
		[FieldOffset(Offset = "0x30")]
		public string mAnimatorPath;
	}
}
