using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200013E RID: 318
[Token(Token = "0x200013E")]
public class UIScrollBase<T> where T : class
{
	// Token: 0x0600094A RID: 2378 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600094A")]
	public GameObject GetFirstGameObjectByIndex()
	{
		return null;
	}

	// Token: 0x0600094B RID: 2379 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600094B")]
	public GameObject GetGameObjectByIndex(int idx)
	{
		return null;
	}

	// Token: 0x0600094C RID: 2380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600094C")]
	public virtual void InitArguments(List<T> data, ScrollRect sr, Transform content, GameObject itemPrefab, Vector2 rect, int numPerLine, int viewCount = 6, float cellPadiding = 10f)
	{
	}

	// Token: 0x0600094D RID: 2381 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600094D")]
	public virtual void SetItemPrefab(GameObject go)
	{
	}

	// Token: 0x0600094E RID: 2382 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600094E")]
	public List<T> GetDataList()
	{
		return null;
	}

	// Token: 0x0600094F RID: 2383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600094F")]
	public void ReSetDataList(List<T> newList)
	{
	}

	// Token: 0x06000950 RID: 2384 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000950")]
	public void SetArrangement(int type)
	{
	}

	// Token: 0x06000951 RID: 2385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000951")]
	public void Start()
	{
	}

	// Token: 0x06000952 RID: 2386 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000952")]
	public T GetDataByIndex(int index)
	{
		return null;
	}

	// Token: 0x06000953 RID: 2387 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000953")]
	public void ResetScrollList(List<T> newList)
	{
	}

	// Token: 0x06000954 RID: 2388 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000954")]
	public void ClearController()
	{
	}

	// Token: 0x06000955 RID: 2389 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000955")]
	public void TryRefreshShowUI()
	{
	}

	// Token: 0x06000956 RID: 2390 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000956")]
	public void InsertByIndex(int idx, T insertItem)
	{
	}

	// Token: 0x1700014C RID: 332
	// (get) Token: 0x06000957 RID: 2391 RVA: 0x00004F50 File Offset: 0x00003150
	[Token(Token = "0x1700014C")]
	public int GetCurrentPosIndex
	{
		[Token(Token = "0x6000957")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06000958 RID: 2392 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000958")]
	public void AppendInsert(List<T> insertList)
	{
	}

	// Token: 0x06000959 RID: 2393 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000959")]
	public void InsertByIndex(int startIdx, List<T> insertList)
	{
	}

	// Token: 0x0600095A RID: 2394 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600095A")]
	public void RemoveByIdx(int idx)
	{
	}

	// Token: 0x0600095B RID: 2395 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600095B")]
	public void RemoveByIdx(List<int> idxList)
	{
	}

	// Token: 0x0600095C RID: 2396 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600095C")]
	private void Remove(int idx)
	{
	}

	// Token: 0x0600095D RID: 2397 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600095D")]
	public void TryLocation(int idx)
	{
	}

	// Token: 0x0600095E RID: 2398 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600095E")]
	private void TryRefreshUIData(int startsWith, Transform content)
	{
	}

	// Token: 0x0600095F RID: 2399 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600095F")]
	private void SingeItemMap(int startIdxPerLine, UIScrollItem scrollItem, [Optional] List<GameObject> gos)
	{
	}

	// Token: 0x06000960 RID: 2400 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000960")]
	private void EntryContainer(UIScrollItem scrollItem, GameObject cellGo)
	{
	}

	// Token: 0x06000961 RID: 2401 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000961")]
	private void OnInitItem(List<UIScrollItem> items)
	{
	}

	// Token: 0x06000962 RID: 2402 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000962")]
	private void OnDelItem(UIScrollItem arg1)
	{
	}

	// Token: 0x06000963 RID: 2403 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000963")]
	private void OnAddItem(UIScrollItem arg1)
	{
	}

	// Token: 0x06000964 RID: 2404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000964")]
	private void OnRemoveItem(UIScrollItem arg1)
	{
	}

	// Token: 0x06000965 RID: 2405 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000965")]
	private void OnValueChanged(Vector2 pos)
	{
	}

	// Token: 0x06000966 RID: 2406 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000966")]
	public UIScrollBase()
	{
	}

	// Token: 0x040006F5 RID: 1781
	[Token(Token = "0x40006F5")]
	[FieldOffset(Offset = "0x0")]
	public Transform content;

	// Token: 0x040006F6 RID: 1782
	[Token(Token = "0x40006F6")]
	[FieldOffset(Offset = "0x0")]
	public UIScrollController uiScroController;

	// Token: 0x040006F7 RID: 1783
	[Token(Token = "0x40006F7")]
	[FieldOffset(Offset = "0x0")]
	protected Dictionary<UIScrollItem, List<GameObject>> gameObjectsPerLine;

	// Token: 0x040006F8 RID: 1784
	[Token(Token = "0x40006F8")]
	[FieldOffset(Offset = "0x0")]
	protected List<T> dataList;

	// Token: 0x040006F9 RID: 1785
	[Token(Token = "0x40006F9")]
	[FieldOffset(Offset = "0x0")]
	private ScrollRect scroRect;

	// Token: 0x040006FA RID: 1786
	[Token(Token = "0x40006FA")]
	[FieldOffset(Offset = "0x0")]
	private int numPerLine;

	// Token: 0x040006FB RID: 1787
	[Token(Token = "0x40006FB")]
	[FieldOffset(Offset = "0x0")]
	private int viewCount;

	// Token: 0x040006FC RID: 1788
	[Token(Token = "0x40006FC")]
	[FieldOffset(Offset = "0x0")]
	private float cellPadiding;

	// Token: 0x040006FD RID: 1789
	[Token(Token = "0x40006FD")]
	[FieldOffset(Offset = "0x0")]
	private float cellHeight;

	// Token: 0x040006FE RID: 1790
	[Token(Token = "0x40006FE")]
	[FieldOffset(Offset = "0x0")]
	private float cellWidth;

	// Token: 0x040006FF RID: 1791
	[Token(Token = "0x40006FF")]
	[FieldOffset(Offset = "0x0")]
	public Action<Vector2> onValueChanged;

	// Token: 0x04000700 RID: 1792
	[Token(Token = "0x4000700")]
	[FieldOffset(Offset = "0x0")]
	public Action<GameObject> addListenerEvent;

	// Token: 0x04000701 RID: 1793
	[Token(Token = "0x4000701")]
	[FieldOffset(Offset = "0x0")]
	public Action<T, GameObject> freshEvent;
}
