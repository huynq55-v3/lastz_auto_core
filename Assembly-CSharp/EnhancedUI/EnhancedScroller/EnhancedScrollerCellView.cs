using System;
using Il2CppDummyDll;
using UnityEngine;

namespace EnhancedUI.EnhancedScroller
{
	// Token: 0x020004D8 RID: 1240
	[Token(Token = "0x20004D8")]
	public class EnhancedScrollerCellView : MonoBehaviour
	{
		// Token: 0x06002579 RID: 9593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002579")]
		[Address(RVA = "0x2B557CC", Offset = "0x2B557CC", VA = "0x2B557CC", Slot = "4")]
		public virtual void RefreshCellView()
		{
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600257A")]
		[Address(RVA = "0x2B557D0", Offset = "0x2B557D0", VA = "0x2B557D0")]
		public EnhancedScrollerCellView()
		{
		}

		// Token: 0x04002263 RID: 8803
		[Token(Token = "0x4002263")]
		[FieldOffset(Offset = "0x18")]
		public string cellIdentifier;

		// Token: 0x04002264 RID: 8804
		[Token(Token = "0x4002264")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public int cellIndex;

		// Token: 0x04002265 RID: 8805
		[Token(Token = "0x4002265")]
		[FieldOffset(Offset = "0x24")]
		[NonSerialized]
		public int dataIndex;

		// Token: 0x04002266 RID: 8806
		[Token(Token = "0x4002266")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public bool active;
	}
}
