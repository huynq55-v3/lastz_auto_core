using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000FB RID: 251
[Token(Token = "0x20000FB")]
[AddComponentMenu("UI/HorizontalInfinityScrollView")]
public class HorizontalInfinityScrollView : InfinityScrollViewBase
{
	// Token: 0x0600070E RID: 1806 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600070E")]
	[Address(RVA = "0x3475CD4", Offset = "0x3475CD4", VA = "0x3475CD4", Slot = "4")]
	public override void Init(Action<GameObject, int> onInit, Action<GameObject, int, int> onUpdate, Action<GameObject, int> onDestroy)
	{
	}

	// Token: 0x0600070F RID: 1807 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600070F")]
	[Address(RVA = "0x3475CD8", Offset = "0x3475CD8", VA = "0x3475CD8", Slot = "17")]
	public override void MoveItemByIndex(int index, float delay)
	{
	}

	// Token: 0x06000710 RID: 1808 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000710")]
	[Address(RVA = "0x3475EF4", Offset = "0x3475EF4", VA = "0x3475EF4", Slot = "7")]
	public override void ForceUpdate()
	{
	}

	// Token: 0x06000711 RID: 1809 RVA: 0x00004560 File Offset: 0x00002760
	[Token(Token = "0x6000711")]
	[Address(RVA = "0x3475EF8", Offset = "0x3475EF8", VA = "0x3475EF8", Slot = "16")]
	protected override int CalculationItemCount()
	{
		return 0;
	}

	// Token: 0x06000712 RID: 1810 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000712")]
	[Address(RVA = "0x3475F74", Offset = "0x3475F74", VA = "0x3475F74", Slot = "5")]
	public override void Dispose()
	{
	}

	// Token: 0x06000713 RID: 1811 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000713")]
	[Address(RVA = "0x3475F78", Offset = "0x3475F78", VA = "0x3475F78", Slot = "6")]
	public override void SetItemCount(int itemCount)
	{
	}

	// Token: 0x06000714 RID: 1812 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000714")]
	[Address(RVA = "0x3475F7C", Offset = "0x3475F7C", VA = "0x3475F7C", Slot = "11")]
	public override InfinityItem GetInfinityItemByIndex(int index)
	{
		return null;
	}

	// Token: 0x06000715 RID: 1813 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000715")]
	[Address(RVA = "0x3475FD8", Offset = "0x3475FD8", VA = "0x3475FD8")]
	public void SetScrollRectHorizontal(bool enable)
	{
	}

	// Token: 0x06000716 RID: 1814 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000716")]
	[Address(RVA = "0x3475FF8", Offset = "0x3475FF8", VA = "0x3475FF8", Slot = "12")]
	protected override void UpdateDynmicRects(int itemCount)
	{
	}

	// Token: 0x06000717 RID: 1815 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000717")]
	[Address(RVA = "0x3476158", Offset = "0x3476158", VA = "0x3476158", Slot = "13")]
	protected override void SetRenderListSize(int itemCount)
	{
	}

	// Token: 0x06000718 RID: 1816 RVA: 0x00004578 File Offset: 0x00002778
	[Token(Token = "0x6000718")]
	[Address(RVA = "0x34761E0", Offset = "0x34761E0", VA = "0x34761E0", Slot = "18")]
	protected override Vector2 GetItemAnchoredPos(int index)
	{
		return default(Vector2);
	}

	// Token: 0x06000719 RID: 1817 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000719")]
	[Address(RVA = "0x3476318", Offset = "0x3476318", VA = "0x3476318", Slot = "14")]
	protected override void UpdateItemTransformPos(GameObject item, int index)
	{
	}

	// Token: 0x0600071A RID: 1818 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600071A")]
	[Address(RVA = "0x3476424", Offset = "0x3476424", VA = "0x3476424", Slot = "15")]
	protected override void UpdateMaskRect()
	{
	}

	// Token: 0x0600071B RID: 1819 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600071B")]
	[Address(RVA = "0x3476458", Offset = "0x3476458", VA = "0x3476458")]
	public HorizontalInfinityScrollView()
	{
	}
}
