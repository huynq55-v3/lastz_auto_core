using System;
using Il2CppDummyDll;

namespace EnhancedUI.EnhancedScroller
{
	// Token: 0x020004D9 RID: 1241
	[Token(Token = "0x20004D9")]
	public interface IEnhancedScrollerDelegate
	{
		// Token: 0x0600257B RID: 9595
		[Token(Token = "0x600257B")]
		int GetNumberOfCells(EnhancedScroller scroller);

		// Token: 0x0600257C RID: 9596
		[Token(Token = "0x600257C")]
		float GetCellViewSize(EnhancedScroller scroller, int dataIndex);

		// Token: 0x0600257D RID: 9597
		[Token(Token = "0x600257D")]
		EnhancedScrollerCellView GetCellView(EnhancedScroller scroller, int dataIndex, int cellIndex);
	}
}
