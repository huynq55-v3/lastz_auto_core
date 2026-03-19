using System;
using Il2CppDummyDll;
using UnityEngine;

namespace SuperScrollView
{
	// Token: 0x020004BA RID: 1210
	[Token(Token = "0x20004BA")]
	[Serializable]
	public class ItemPrefabLazyConfData
	{
		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x060023D1 RID: 9169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000552")]
		public GameObject ItemPrefab
		{
			[Token(Token = "0x60023D1")]
			[Address(RVA = "0x2A06538", Offset = "0x2A06538", VA = "0x2A06538")]
			get
			{
				return null;
			}
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023D2")]
		[Address(RVA = "0x2A06DCC", Offset = "0x2A06DCC", VA = "0x2A06DCC")]
		private GameObject getItemPrfabInner()
		{
			return null;
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D3")]
		[Address(RVA = "0x2A06DD4", Offset = "0x2A06DD4", VA = "0x2A06DD4")]
		public ItemPrefabLazyConfData()
		{
		}

		// Token: 0x0400211D RID: 8477
		[Token(Token = "0x400211D")]
		[FieldOffset(Offset = "0x10")]
		[NonSerialized]
		private GameObject mItemPrefab;

		// Token: 0x0400211E RID: 8478
		[Token(Token = "0x400211E")]
		[FieldOffset(Offset = "0x18")]
		public float mPadding;

		// Token: 0x0400211F RID: 8479
		[Token(Token = "0x400211F")]
		[FieldOffset(Offset = "0x1C")]
		public int mInitCreateCount;

		// Token: 0x04002120 RID: 8480
		[Token(Token = "0x4002120")]
		[FieldOffset(Offset = "0x20")]
		public float mStartPosOffset;

		// Token: 0x04002121 RID: 8481
		[Token(Token = "0x4002121")]
		[FieldOffset(Offset = "0x24")]
		public float mItemHeight;

		// Token: 0x04002122 RID: 8482
		[Token(Token = "0x4002122")]
		[FieldOffset(Offset = "0x28")]
		public bool mAnimationCancle;

		// Token: 0x04002123 RID: 8483
		[Token(Token = "0x4002123")]
		[FieldOffset(Offset = "0x30")]
		public string mAnimatorPath;

		// Token: 0x04002124 RID: 8484
		[Token(Token = "0x4002124")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		public string mItemPrefabPath;

		// Token: 0x04002125 RID: 8485
		[Token(Token = "0x4002125")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public Rect mItemPrefabRect;

		// Token: 0x04002126 RID: 8486
		[Token(Token = "0x4002126")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		public string mItemPrefabName;
	}
}
