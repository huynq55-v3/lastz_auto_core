using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000F8 RID: 248
[Token(Token = "0x20000F8")]
[AddComponentMenu("UI/GridInfinityScrollView")]
public class GridInfinityScrollView : InfinityScrollViewBase
{
	// Token: 0x060006FB RID: 1787 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006FB")]
	[Address(RVA = "0x3474070", Offset = "0x3474070", VA = "0x3474070", Slot = "4")]
	public override void Init(Action<GameObject, int> onInit, Action<GameObject, int, int> onUpdate, Action<GameObject, int> onDestroy)
	{
	}

	// Token: 0x060006FC RID: 1788 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006FC")]
	[Address(RVA = "0x347486C", Offset = "0x347486C", VA = "0x347486C", Slot = "7")]
	public override void ForceUpdate()
	{
	}

	// Token: 0x060006FD RID: 1789 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006FD")]
	[Address(RVA = "0x34748B0", Offset = "0x34748B0", VA = "0x34748B0", Slot = "8")]
	public override void ForceUpdateCell()
	{
	}

	// Token: 0x060006FE RID: 1790 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006FE")]
	[Address(RVA = "0x34748F4", Offset = "0x34748F4", VA = "0x34748F4", Slot = "6")]
	public override void SetItemCount(int itemCount)
	{
	}

	// Token: 0x060006FF RID: 1791 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006FF")]
	[Address(RVA = "0x3474968", Offset = "0x3474968", VA = "0x3474968", Slot = "5")]
	public override void Dispose()
	{
	}

	// Token: 0x06000700 RID: 1792 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000700")]
	[Address(RVA = "0x3474A24", Offset = "0x3474A24", VA = "0x3474A24", Slot = "17")]
	public override void MoveItemByIndex(int index, float delay)
	{
	}

	// Token: 0x06000701 RID: 1793 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000701")]
	[Address(RVA = "0x3475218", Offset = "0x3475218", VA = "0x3475218")]
	public void LaterItemByIndex(int index, float delay)
	{
	}

	// Token: 0x06000702 RID: 1794 RVA: 0x00004500 File Offset: 0x00002700
	[Token(Token = "0x6000702")]
	[Address(RVA = "0x3475374", Offset = "0x3475374", VA = "0x3475374", Slot = "18")]
	protected override Vector2 GetItemAnchoredPos(int index)
	{
		return default(Vector2);
	}

	// Token: 0x06000703 RID: 1795 RVA: 0x00004518 File Offset: 0x00002718
	[Token(Token = "0x6000703")]
	[Address(RVA = "0x347545C", Offset = "0x347545C", VA = "0x347545C", Slot = "9")]
	public override int GetColumnCount()
	{
		return 0;
	}

	// Token: 0x06000704 RID: 1796 RVA: 0x00004530 File Offset: 0x00002730
	[Token(Token = "0x6000704")]
	[Address(RVA = "0x3475464", Offset = "0x3475464", VA = "0x3475464", Slot = "16")]
	protected override int CalculationItemCount()
	{
		return 0;
	}

	// Token: 0x06000705 RID: 1797 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000705")]
	[Address(RVA = "0x34754F8", Offset = "0x34754F8", VA = "0x34754F8", Slot = "13")]
	protected override void SetRenderListSize(int itemCount)
	{
	}

	// Token: 0x06000706 RID: 1798 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000706")]
	[Address(RVA = "0x347561C", Offset = "0x347561C", VA = "0x347561C", Slot = "12")]
	protected override void UpdateDynmicRects(int itemCount)
	{
	}

	// Token: 0x06000707 RID: 1799 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000707")]
	[Address(RVA = "0x347581C", Offset = "0x347581C", VA = "0x347581C", Slot = "14")]
	protected override void UpdateItemTransformPos(GameObject item, int index)
	{
	}

	// Token: 0x06000708 RID: 1800 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000708")]
	[Address(RVA = "0x3475968", Offset = "0x3475968", VA = "0x3475968", Slot = "15")]
	protected override void UpdateMaskRect()
	{
	}

	// Token: 0x06000709 RID: 1801 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000709")]
	[Address(RVA = "0x34759AC", Offset = "0x34759AC", VA = "0x34759AC")]
	public GridInfinityScrollView()
	{
	}

	// Token: 0x0400053E RID: 1342
	[Token(Token = "0x400053E")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	public RectOffset padding;

	// Token: 0x0400053F RID: 1343
	[Token(Token = "0x400053F")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private int minColumnCount;

	// Token: 0x04000540 RID: 1344
	[Token(Token = "0x4000540")]
	[FieldOffset(Offset = "0xB4")]
	[SerializeField]
	private int maxColumnCount;

	// Token: 0x04000541 RID: 1345
	[Token(Token = "0x4000541")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private int columnCount;
}
