using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200010D RID: 269
[Token(Token = "0x200010D")]
public class DynamicInfinityListRenderer : MonoBehaviour
{
	// Token: 0x06000793 RID: 1939 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000793")]
	[Address(RVA = "0x3479B34", Offset = "0x3479B34", VA = "0x3479B34", Slot = "4")]
	public virtual void InitRendererList(DynamicInfinityItem.OnSelect OnSelect, DynamicInfinityItem.OnUpdateData OnUpdate, [Optional] Action<int> cb)
	{
	}

	// Token: 0x06000794 RID: 1940 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000794")]
	[Address(RVA = "0x347A438", Offset = "0x347A438", VA = "0x347A438")]
	private void _SetListRenderSize(int count)
	{
	}

	// Token: 0x06000795 RID: 1941 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000795")]
	[Address(RVA = "0x347A2C4", Offset = "0x347A2C4", VA = "0x347A2C4")]
	private void _UpdateChildTransformPos(GameObject child, int index)
	{
	}

	// Token: 0x06000796 RID: 1942 RVA: 0x000046F8 File Offset: 0x000028F8
	[Token(Token = "0x6000796")]
	[Address(RVA = "0x347A0E0", Offset = "0x347A0E0", VA = "0x347A0E0")]
	protected float GetBlockSizeY()
	{
		return 0f;
	}

	// Token: 0x06000797 RID: 1943 RVA: 0x00004710 File Offset: 0x00002910
	[Token(Token = "0x6000797")]
	[Address(RVA = "0x347A0F0", Offset = "0x347A0F0", VA = "0x347A0F0")]
	protected float GetBlockSizeX()
	{
		return 0f;
	}

	// Token: 0x06000798 RID: 1944 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000798")]
	[Address(RVA = "0x347A100", Offset = "0x347A100", VA = "0x347A100")]
	private void _UpdateDynmicRects(int count)
	{
	}

	// Token: 0x06000799 RID: 1945 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000799")]
	[Address(RVA = "0x347A5FC", Offset = "0x347A5FC", VA = "0x347A5FC")]
	public void SetDataProvider(IList datas)
	{
	}

	// Token: 0x0600079A RID: 1946 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600079A")]
	[Address(RVA = "0x347A72C", Offset = "0x347A72C", VA = "0x347A72C")]
	private void ClearAllListRenderDr()
	{
	}

	// Token: 0x0600079B RID: 1947 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600079B")]
	[Address(RVA = "0x347A7C8", Offset = "0x347A7C8", VA = "0x347A7C8")]
	public IList GetDataProvider()
	{
		return null;
	}

	// Token: 0x0600079C RID: 1948 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600079C")]
	[Address(RVA = "0x347A7D0", Offset = "0x347A7D0", VA = "0x347A7D0")]
	[ContextMenu("RefreshDataProvider")]
	public void RefreshDataProvider()
	{
	}

	// Token: 0x0600079D RID: 1949 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600079D")]
	[Address(RVA = "0x347A944", Offset = "0x347A944", VA = "0x347A944", Slot = "5")]
	public virtual void LocateRenderItemAtTarget(object target, float delay)
	{
	}

	// Token: 0x0600079E RID: 1950 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600079E")]
	[Address(RVA = "0x347AA14", Offset = "0x347AA14", VA = "0x347AA14", Slot = "6")]
	public virtual void LocateRenderItemAtIndex(int index, float delay)
	{
	}

	// Token: 0x0600079F RID: 1951 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600079F")]
	[Address(RVA = "0x347AC9C", Offset = "0x347AC9C", VA = "0x347AC9C")]
	protected IEnumerator TweenMoveToPos(Vector2 pos, Vector2 v2Pos, float delay)
	{
		return null;
	}

	// Token: 0x060007A0 RID: 1952 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A0")]
	[Address(RVA = "0x347AD70", Offset = "0x347AD70", VA = "0x347AD70")]
	protected void UpdateRender()
	{
	}

	// Token: 0x060007A1 RID: 1953 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007A1")]
	[Address(RVA = "0x347B400", Offset = "0x347B400", VA = "0x347B400")]
	private DynamicInfinityItem GetNullDynmicItem()
	{
		return null;
	}

	// Token: 0x060007A2 RID: 1954 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007A2")]
	[Address(RVA = "0x347B348", Offset = "0x347B348", VA = "0x347B348")]
	private DynamicInfinityItem GetDynmicItem(DynamicRect rect)
	{
		return null;
	}

	// Token: 0x060007A3 RID: 1955 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A3")]
	[Address(RVA = "0x347B4E8", Offset = "0x347B4E8", VA = "0x347B4E8")]
	private void Update()
	{
	}

	// Token: 0x060007A4 RID: 1956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A4")]
	[Address(RVA = "0x347B4F8", Offset = "0x347B4F8", VA = "0x347B4F8")]
	public DynamicInfinityListRenderer()
	{
	}

	// Token: 0x04000582 RID: 1410
	[Token(Token = "0x4000582")]
	[FieldOffset(Offset = "0x18")]
	public bool IsVertical;

	// Token: 0x04000583 RID: 1411
	[Token(Token = "0x4000583")]
	[FieldOffset(Offset = "0x1C")]
	public Vector2 CellSize;

	// Token: 0x04000584 RID: 1412
	[Token(Token = "0x4000584")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 SpacingSize;

	// Token: 0x04000585 RID: 1413
	[Token(Token = "0x4000585")]
	[FieldOffset(Offset = "0x2C")]
	public int ColumnCount;

	// Token: 0x04000586 RID: 1414
	[Token(Token = "0x4000586")]
	[FieldOffset(Offset = "0x30")]
	public GameObject RenderGO;

	// Token: 0x04000587 RID: 1415
	[Token(Token = "0x4000587")]
	[FieldOffset(Offset = "0x38")]
	protected int mRendererCount;

	// Token: 0x04000588 RID: 1416
	[Token(Token = "0x4000588")]
	[FieldOffset(Offset = "0x3C")]
	private Vector2 mMaskSize;

	// Token: 0x04000589 RID: 1417
	[Token(Token = "0x4000589")]
	[FieldOffset(Offset = "0x44")]
	private Rect mRectMask;

	// Token: 0x0400058A RID: 1418
	[Token(Token = "0x400058A")]
	[FieldOffset(Offset = "0x58")]
	protected ScrollRect mScrollRect;

	// Token: 0x0400058B RID: 1419
	[Token(Token = "0x400058B")]
	[FieldOffset(Offset = "0x60")]
	protected RectTransform mRectTransformContainer;

	// Token: 0x0400058C RID: 1420
	[Token(Token = "0x400058C")]
	[FieldOffset(Offset = "0x68")]
	protected List<DynamicInfinityItem> mList_items;

	// Token: 0x0400058D RID: 1421
	[Token(Token = "0x400058D")]
	[FieldOffset(Offset = "0x70")]
	private Dictionary<int, DynamicRect> mDict_dRect;

	// Token: 0x0400058E RID: 1422
	[Token(Token = "0x400058E")]
	[FieldOffset(Offset = "0x78")]
	protected IList mDataProviders;

	// Token: 0x0400058F RID: 1423
	[Token(Token = "0x400058F")]
	[FieldOffset(Offset = "0x80")]
	protected bool mHasInited;

	// Token: 0x04000590 RID: 1424
	[Token(Token = "0x4000590")]
	[FieldOffset(Offset = "0x88")]
	public Action<int> Callback;

	// Token: 0x04000591 RID: 1425
	[Token(Token = "0x4000591")]
	[FieldOffset(Offset = "0x90")]
	protected Coroutine m_Coroutine;
}
