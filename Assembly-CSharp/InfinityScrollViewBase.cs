using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000FF RID: 255
[Token(Token = "0x20000FF")]
public abstract class InfinityScrollViewBase : MonoBehaviour
{
	// Token: 0x0600072B RID: 1835 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600072B")]
	[Address(RVA = "0x347429C", Offset = "0x347429C", VA = "0x347429C", Slot = "4")]
	public virtual void Init(Action<GameObject, int> onInit, Action<GameObject, int, int> onUpdate, Action<GameObject, int> onDestroy)
	{
	}

	// Token: 0x0600072C RID: 1836 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600072C")]
	[Address(RVA = "0x3477874", Offset = "0x3477874", VA = "0x3477874")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600072D RID: 1837 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600072D")]
	[Address(RVA = "0x347496C", Offset = "0x347496C", VA = "0x347496C", Slot = "5")]
	public virtual void Dispose()
	{
	}

	// Token: 0x0600072E RID: 1838 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600072E")]
	[Address(RVA = "0x34748F8", Offset = "0x34748F8", VA = "0x34748F8", Slot = "6")]
	public virtual void SetItemCount(int itemCount)
	{
	}

	// Token: 0x0600072F RID: 1839 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600072F")]
	[Address(RVA = "0x3474870", Offset = "0x3474870", VA = "0x3474870", Slot = "7")]
	public virtual void ForceUpdate()
	{
	}

	// Token: 0x06000730 RID: 1840 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000730")]
	[Address(RVA = "0x34748B4", Offset = "0x34748B4", VA = "0x34748B4", Slot = "8")]
	public virtual void ForceUpdateCell()
	{
	}

	// Token: 0x06000731 RID: 1841 RVA: 0x00004590 File Offset: 0x00002790
	[Token(Token = "0x6000731")]
	[Address(RVA = "0x3477970", Offset = "0x3477970", VA = "0x3477970", Slot = "9")]
	public virtual int GetColumnCount()
	{
		return 0;
	}

	// Token: 0x06000732 RID: 1842 RVA: 0x000045A8 File Offset: 0x000027A8
	[Token(Token = "0x6000732")]
	[Address(RVA = "0x3477978", Offset = "0x3477978", VA = "0x3477978", Slot = "10")]
	public virtual int GetRenderCount()
	{
		return 0;
	}

	// Token: 0x06000733 RID: 1843 RVA: 0x000045C0 File Offset: 0x000027C0
	[Token(Token = "0x6000733")]
	[Address(RVA = "0x347428C", Offset = "0x347428C", VA = "0x347428C")]
	protected float GetItemSizeX()
	{
		return 0f;
	}

	// Token: 0x06000734 RID: 1844 RVA: 0x000045D8 File Offset: 0x000027D8
	[Token(Token = "0x6000734")]
	[Address(RVA = "0x3474B74", Offset = "0x3474B74", VA = "0x3474B74")]
	protected float GetItemSizeY()
	{
		return 0f;
	}

	// Token: 0x06000735 RID: 1845 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000735")]
	[Address(RVA = "0x34779C8", Offset = "0x34779C8", VA = "0x34779C8")]
	protected InfinityItem GetInfinityItem(InfinityRect rect)
	{
		return null;
	}

	// Token: 0x06000736 RID: 1846 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000736")]
	[Address(RVA = "0x3475F80", Offset = "0x3475F80", VA = "0x3475F80", Slot = "11")]
	public virtual InfinityItem GetInfinityItemByIndex(int index)
	{
		return null;
	}

	// Token: 0x06000737 RID: 1847 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000737")]
	[Address(RVA = "0x3477A80", Offset = "0x3477A80", VA = "0x3477A80")]
	protected InfinityItem GetNullInfinityItem()
	{
		return null;
	}

	// Token: 0x06000738 RID: 1848 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000738")]
	[Address(RVA = "0x347788C", Offset = "0x347788C", VA = "0x347788C")]
	protected void ClearAllRender()
	{
	}

	// Token: 0x06000739 RID: 1849
	[Token(Token = "0x6000739")]
	protected abstract void UpdateDynmicRects(int itemCount);

	// Token: 0x0600073A RID: 1850
	[Token(Token = "0x600073A")]
	protected abstract void SetRenderListSize(int itemCount);

	// Token: 0x0600073B RID: 1851
	[Token(Token = "0x600073B")]
	protected abstract void UpdateItemTransformPos(GameObject item, int index);

	// Token: 0x0600073C RID: 1852
	[Token(Token = "0x600073C")]
	protected abstract void UpdateMaskRect();

	// Token: 0x0600073D RID: 1853
	[Token(Token = "0x600073D")]
	protected abstract int CalculationItemCount();

	// Token: 0x0600073E RID: 1854
	[Token(Token = "0x600073E")]
	public abstract void MoveItemByIndex(int index, float delay);

	// Token: 0x0600073F RID: 1855
	[Token(Token = "0x600073F")]
	protected abstract Vector2 GetItemAnchoredPos(int index);

	// Token: 0x06000740 RID: 1856 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000740")]
	[Address(RVA = "0x3477BF8", Offset = "0x3477BF8", VA = "0x3477BF8", Slot = "19")]
	public virtual void StopLocateCoroutine()
	{
	}

	// Token: 0x06000741 RID: 1857 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000741")]
	[Address(RVA = "0x3477C24", Offset = "0x3477C24", VA = "0x3477C24")]
	private void OnScrollChange(Vector2 pos)
	{
	}

	// Token: 0x06000742 RID: 1858 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000742")]
	[Address(RVA = "0x3474C30", Offset = "0x3474C30", VA = "0x3474C30")]
	protected void UpdateRender(Vector2 pos, bool isForce = false)
	{
	}

	// Token: 0x06000743 RID: 1859 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000743")]
	[Address(RVA = "0x3474B84", Offset = "0x3474B84", VA = "0x3474B84")]
	protected IEnumerator TweenMoveToPos(Vector2 pos, Vector2 toPos, float delay)
	{
		return null;
	}

	// Token: 0x06000744 RID: 1860 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000744")]
	[Address(RVA = "0x34752E0", Offset = "0x34752E0", VA = "0x34752E0")]
	protected IEnumerator TweenUpdateToPoss(int index, float delay)
	{
		return null;
	}

	// Token: 0x06000745 RID: 1861 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000745")]
	[Address(RVA = "0x3477C94", Offset = "0x3477C94", VA = "0x3477C94")]
	private void Update()
	{
	}

	// Token: 0x06000746 RID: 1862 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000746")]
	[Address(RVA = "0x34759B0", Offset = "0x34759B0", VA = "0x34759B0")]
	protected InfinityScrollViewBase()
	{
	}

	// Token: 0x0400054E RID: 1358
	[Token(Token = "0x400054E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private protected Vector2 cellSize;

	// Token: 0x0400054F RID: 1359
	[Token(Token = "0x400054F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private protected Vector2 spacingSize;

	// Token: 0x04000550 RID: 1360
	[Token(Token = "0x4000550")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject itemTemplate;

	// Token: 0x04000551 RID: 1361
	[Token(Token = "0x4000551")]
	[FieldOffset(Offset = "0x30")]
	protected RectTransform rectTransform;

	// Token: 0x04000552 RID: 1362
	[Token(Token = "0x4000552")]
	[FieldOffset(Offset = "0x38")]
	protected ScrollRect scrollRect;

	// Token: 0x04000553 RID: 1363
	[Token(Token = "0x4000553")]
	[FieldOffset(Offset = "0x40")]
	protected int itemCount;

	// Token: 0x04000554 RID: 1364
	[Token(Token = "0x4000554")]
	[FieldOffset(Offset = "0x44")]
	protected Vector2 maskSize;

	// Token: 0x04000555 RID: 1365
	[Token(Token = "0x4000555")]
	[FieldOffset(Offset = "0x4C")]
	protected Rect maskRect;

	// Token: 0x04000556 RID: 1366
	[Token(Token = "0x4000556")]
	[FieldOffset(Offset = "0x60")]
	protected List<InfinityItem> infinityItems;

	// Token: 0x04000557 RID: 1367
	[Token(Token = "0x4000557")]
	[FieldOffset(Offset = "0x68")]
	protected Dictionary<int, InfinityRect> rectDic;

	// Token: 0x04000558 RID: 1368
	[Token(Token = "0x4000558")]
	[FieldOffset(Offset = "0x70")]
	protected bool inited;

	// Token: 0x04000559 RID: 1369
	[Token(Token = "0x4000559")]
	[FieldOffset(Offset = "0x78")]
	public Action<GameObject, int, int> onUpdate;

	// Token: 0x0400055A RID: 1370
	[Token(Token = "0x400055A")]
	[FieldOffset(Offset = "0x80")]
	public Action<GameObject, int> onDestroy;

	// Token: 0x0400055B RID: 1371
	[Token(Token = "0x400055B")]
	[FieldOffset(Offset = "0x88")]
	private Dictionary<int, InfinityRect> inOverlaps;

	// Token: 0x0400055C RID: 1372
	[Token(Token = "0x400055C")]
	[FieldOffset(Offset = "0x90")]
	private int lastNumber;

	// Token: 0x0400055D RID: 1373
	[Token(Token = "0x400055D")]
	[FieldOffset(Offset = "0x94")]
	private int lastKey;

	// Token: 0x0400055E RID: 1374
	[Token(Token = "0x400055E")]
	[FieldOffset(Offset = "0x98")]
	private bool isMove;

	// Token: 0x0400055F RID: 1375
	[Token(Token = "0x400055F")]
	[FieldOffset(Offset = "0xA0")]
	protected Coroutine _coroutine;
}
