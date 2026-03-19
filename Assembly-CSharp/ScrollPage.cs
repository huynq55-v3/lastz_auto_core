using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000116 RID: 278
[Token(Token = "0x2000116")]
public class ScrollPage : MonoBehaviour
{
	// Token: 0x17000102 RID: 258
	// (get) Token: 0x060007DB RID: 2011 RVA: 0x000047A0 File Offset: 0x000029A0
	[Token(Token = "0x17000102")]
	public int Count
	{
		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x347E210", Offset = "0x347E210", VA = "0x347E210")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000103 RID: 259
	// (get) Token: 0x060007DC RID: 2012 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060007DD RID: 2013 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000103")]
	public Action<GameObject> OnCreateItemEvent
	{
		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x347E218", Offset = "0x347E218", VA = "0x347E218")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x347E220", Offset = "0x347E220", VA = "0x347E220")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000104 RID: 260
	// (get) Token: 0x060007DE RID: 2014 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060007DF RID: 2015 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000104")]
	public Action<GameObject> OnRemoveItemEvent
	{
		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x347E228", Offset = "0x347E228", VA = "0x347E228")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x347E230", Offset = "0x347E230", VA = "0x347E230")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000105 RID: 261
	// (get) Token: 0x060007E0 RID: 2016 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060007E1 RID: 2017 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000105")]
	public Action<int, int, bool> OnChangeEvent
	{
		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x347E238", Offset = "0x347E238", VA = "0x347E238")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x347E240", Offset = "0x347E240", VA = "0x347E240")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000106 RID: 262
	// (get) Token: 0x060007E2 RID: 2018 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060007E3 RID: 2019 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000106")]
	public Action<int> OnScrollEndEvent
	{
		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x347E248", Offset = "0x347E248", VA = "0x347E248")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x347E250", Offset = "0x347E250", VA = "0x347E250")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x060007E4 RID: 2020 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E4")]
	[Address(RVA = "0x347E258", Offset = "0x347E258", VA = "0x347E258", Slot = "4")]
	public virtual void Initialize(int count, GameObject scroll, GridLayoutGroup gridLayoutGroup, GameObject adItem)
	{
	}

	// Token: 0x060007E5 RID: 2021 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E5")]
	[Address(RVA = "0x347E40C", Offset = "0x347E40C", VA = "0x347E40C", Slot = "5")]
	public virtual void Initialize(int count, GameObject scroll, GridLayoutGroup adGridLayoutGroup, GameObject adItem, GridLayoutGroup pageGridLayoutGroup, GameObject pageItem)
	{
	}

	// Token: 0x060007E6 RID: 2022 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E6")]
	[Address(RVA = "0x347E600", Offset = "0x347E600", VA = "0x347E600", Slot = "6")]
	public virtual void SetDragEventObj(GameObject go)
	{
	}

	// Token: 0x060007E7 RID: 2023 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E7")]
	[Address(RVA = "0x347E6E8", Offset = "0x347E6E8", VA = "0x347E6E8", Slot = "7")]
	public virtual void RemoveAll()
	{
	}

	// Token: 0x060007E8 RID: 2024 RVA: 0x000047B8 File Offset: 0x000029B8
	[Token(Token = "0x60007E8")]
	[Address(RVA = "0x347E738", Offset = "0x347E738", VA = "0x347E738", Slot = "8")]
	public virtual int RemovePageByIdx(int idx, bool countAutoSubtract = true)
	{
		return 0;
	}

	// Token: 0x060007E9 RID: 2025 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E9")]
	[Address(RVA = "0x347EB70", Offset = "0x347EB70", VA = "0x347EB70", Slot = "9")]
	public virtual void OnChange(int preIdx, int curIdx)
	{
	}

	// Token: 0x060007EA RID: 2026 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007EA")]
	[Address(RVA = "0x347EB74", Offset = "0x347EB74", VA = "0x347EB74", Slot = "10")]
	public virtual void SetTarget()
	{
	}

	// Token: 0x060007EB RID: 2027 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007EB")]
	[Address(RVA = "0x347EBBC", Offset = "0x347EBBC", VA = "0x347EBBC", Slot = "11")]
	public virtual void OnCreateItem(GameObject obj)
	{
	}

	// Token: 0x060007EC RID: 2028 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007EC")]
	[Address(RVA = "0x347EBC0", Offset = "0x347EBC0", VA = "0x347EBC0", Slot = "12")]
	public virtual void OnRemoveItem(GameObject obj)
	{
	}

	// Token: 0x060007ED RID: 2029 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007ED")]
	[Address(RVA = "0x347EBC4", Offset = "0x347EBC4", VA = "0x347EBC4", Slot = "13")]
	public virtual void SpawnOnePageItem()
	{
	}

	// Token: 0x060007EE RID: 2030 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007EE")]
	[Address(RVA = "0x347EECC", Offset = "0x347EECC", VA = "0x347EECC", Slot = "14")]
	public virtual GameObject SpawnOnePage()
	{
		return null;
	}

	// Token: 0x060007EF RID: 2031 RVA: 0x000047D0 File Offset: 0x000029D0
	[Token(Token = "0x60007EF")]
	[Address(RVA = "0x347F0FC", Offset = "0x347F0FC", VA = "0x347F0FC")]
	public int GetNextIndex()
	{
		return 0;
	}

	// Token: 0x060007F0 RID: 2032 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F0")]
	[Address(RVA = "0x347F114", Offset = "0x347F114", VA = "0x347F114", Slot = "15")]
	public virtual void SpawnPage()
	{
	}

	// Token: 0x060007F1 RID: 2033 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F1")]
	[Address(RVA = "0x347F158", Offset = "0x347F158", VA = "0x347F158", Slot = "16")]
	public virtual void ChangePage(int idx)
	{
	}

	// Token: 0x060007F2 RID: 2034 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F2")]
	[Address(RVA = "0x347F278", Offset = "0x347F278", VA = "0x347F278", Slot = "17")]
	public virtual void SetPageState(GameObject go, bool state)
	{
	}

	// Token: 0x060007F3 RID: 2035 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F3")]
	[Address(RVA = "0x347F2F8", Offset = "0x347F2F8", VA = "0x347F2F8", Slot = "18")]
	public virtual void OnBeginDrag(GameObject arg1, Vector2 arg2, Vector2 arg3)
	{
	}

	// Token: 0x060007F4 RID: 2036 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F4")]
	[Address(RVA = "0x347F314", Offset = "0x347F314", VA = "0x347F314", Slot = "19")]
	public virtual void OnEndDrag(GameObject arg1, Vector2 arg2, Vector2 arg3)
	{
	}

	// Token: 0x060007F5 RID: 2037 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F5")]
	[Address(RVA = "0x347F4BC", Offset = "0x347F4BC", VA = "0x347F4BC", Slot = "20")]
	public virtual void CheckLoop(int idx)
	{
	}

	// Token: 0x060007F6 RID: 2038 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F6")]
	[Address(RVA = "0x347F530", Offset = "0x347F530", VA = "0x347F530", Slot = "21")]
	public virtual void IdxLogic()
	{
	}

	// Token: 0x060007F7 RID: 2039 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F7")]
	[Address(RVA = "0x347F6A4", Offset = "0x347F6A4", VA = "0x347F6A4", Slot = "22")]
	public virtual void OnScrollEnd(int curIdx)
	{
	}

	// Token: 0x060007F8 RID: 2040 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F8")]
	[Address(RVA = "0x347F6A8", Offset = "0x347F6A8", VA = "0x347F6A8", Slot = "23")]
	public virtual void TryChangeToTarget()
	{
	}

	// Token: 0x060007F9 RID: 2041 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F9")]
	[Address(RVA = "0x347F6B8", Offset = "0x347F6B8", VA = "0x347F6B8")]
	private void EndLogic()
	{
	}

	// Token: 0x060007FA RID: 2042 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007FA")]
	[Address(RVA = "0x347F7C0", Offset = "0x347F7C0", VA = "0x347F7C0", Slot = "24")]
	public virtual void Update()
	{
	}

	// Token: 0x060007FB RID: 2043 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007FB")]
	[Address(RVA = "0x347F884", Offset = "0x347F884", VA = "0x347F884")]
	public ScrollPage()
	{
	}

	// Token: 0x040005D4 RID: 1492
	[Token(Token = "0x40005D4")]
	[FieldOffset(Offset = "0x18")]
	protected int count;

	// Token: 0x040005D5 RID: 1493
	[Token(Token = "0x40005D5")]
	[FieldOffset(Offset = "0x20")]
	protected GameObject adItemPrefab;

	// Token: 0x040005D6 RID: 1494
	[Token(Token = "0x40005D6")]
	[FieldOffset(Offset = "0x28")]
	protected Transform adItemParent;

	// Token: 0x040005D7 RID: 1495
	[Token(Token = "0x40005D7")]
	[FieldOffset(Offset = "0x30")]
	protected GameObject adPageItemPrefab;

	// Token: 0x040005D8 RID: 1496
	[Token(Token = "0x40005D8")]
	[FieldOffset(Offset = "0x38")]
	protected Transform adPageItemParent;

	// Token: 0x040005D9 RID: 1497
	[Token(Token = "0x40005D9")]
	[FieldOffset(Offset = "0x40")]
	protected bool isDraged;

	// Token: 0x040005DA RID: 1498
	[Token(Token = "0x40005DA")]
	[FieldOffset(Offset = "0x48")]
	protected GameObject scroll;

	// Token: 0x040005DB RID: 1499
	[Token(Token = "0x40005DB")]
	[FieldOffset(Offset = "0x50")]
	protected RectTransform gridLayoutGroupRect;

	// Token: 0x040005DC RID: 1500
	[Token(Token = "0x40005DC")]
	[FieldOffset(Offset = "0x58")]
	protected GridLayoutGroup cellSize;

	// Token: 0x040005DD RID: 1501
	[Token(Token = "0x40005DD")]
	[FieldOffset(Offset = "0x60")]
	protected List<GameObject> pageItems;

	// Token: 0x040005DE RID: 1502
	[Token(Token = "0x40005DE")]
	[FieldOffset(Offset = "0x68")]
	protected List<GameObject> adItems;

	// Token: 0x040005DF RID: 1503
	[Token(Token = "0x40005DF")]
	[FieldOffset(Offset = "0x70")]
	public float speed;

	// Token: 0x040005E0 RID: 1504
	[Token(Token = "0x40005E0")]
	[FieldOffset(Offset = "0x74")]
	public float autoSpeed;

	// Token: 0x040005E1 RID: 1505
	[Token(Token = "0x40005E1")]
	[FieldOffset(Offset = "0x78")]
	public float scrollSpeed;

	// Token: 0x040005E2 RID: 1506
	[Token(Token = "0x40005E2")]
	[FieldOffset(Offset = "0x7C")]
	protected float lerp;

	// Token: 0x040005E3 RID: 1507
	[Token(Token = "0x40005E3")]
	[FieldOffset(Offset = "0x80")]
	protected Vector2 beginPos;

	// Token: 0x040005E4 RID: 1508
	[Token(Token = "0x40005E4")]
	[FieldOffset(Offset = "0x88")]
	public int curIdx;

	// Token: 0x040005E5 RID: 1509
	[Token(Token = "0x40005E5")]
	[FieldOffset(Offset = "0x8C")]
	public int preIdx;

	// Token: 0x040005E6 RID: 1510
	[Token(Token = "0x40005E6")]
	[FieldOffset(Offset = "0x90")]
	public Vector2 targetPos;

	// Token: 0x040005E7 RID: 1511
	[Token(Token = "0x40005E7")]
	[FieldOffset(Offset = "0x98")]
	public bool change;

	// Token: 0x040005E8 RID: 1512
	[Token(Token = "0x40005E8")]
	[FieldOffset(Offset = "0x9C")]
	public float dis;

	// Token: 0x040005ED RID: 1517
	[Token(Token = "0x40005ED")]
	[FieldOffset(Offset = "0xC0")]
	public bool idxLoop;

	// Token: 0x040005EE RID: 1518
	[Token(Token = "0x40005EE")]
	[FieldOffset(Offset = "0xC4")]
	public float scorllDis;
}
