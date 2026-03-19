using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200032C RID: 812
[Token(Token = "0x200032C")]
[AddComponentMenu("Layout/Bidirectional Horizontal Layout Group", 153)]
public class BidirectionalHorizontalLayoutGroup : HorizontalOrVerticalLayoutGroup
{
	// Token: 0x17000241 RID: 577
	// (get) Token: 0x06001550 RID: 5456 RVA: 0x00008520 File Offset: 0x00006720
	// (set) Token: 0x06001551 RID: 5457 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000241")]
	public bool IsReverse
	{
		[Token(Token = "0x6001550")]
		[Address(RVA = "0x1ED0008", Offset = "0x1ED0008", VA = "0x1ED0008")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001551")]
		[Address(RVA = "0x1ED0010", Offset = "0x1ED0010", VA = "0x1ED0010")]
		set
		{
		}
	}

	// Token: 0x06001552 RID: 5458 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001552")]
	[Address(RVA = "0x1ED006C", Offset = "0x1ED006C", VA = "0x1ED006C")]
	protected BidirectionalHorizontalLayoutGroup()
	{
	}

	// Token: 0x06001553 RID: 5459 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001553")]
	[Address(RVA = "0x1ED0074", Offset = "0x1ED0074", VA = "0x1ED0074", Slot = "28")]
	public override void CalculateLayoutInputHorizontal()
	{
	}

	// Token: 0x06001554 RID: 5460 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001554")]
	[Address(RVA = "0x1ED009C", Offset = "0x1ED009C", VA = "0x1ED009C", Slot = "29")]
	public override void CalculateLayoutInputVertical()
	{
	}

	// Token: 0x06001555 RID: 5461 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001555")]
	[Address(RVA = "0x1ED00AC", Offset = "0x1ED00AC", VA = "0x1ED00AC", Slot = "37")]
	public override void SetLayoutHorizontal()
	{
	}

	// Token: 0x06001556 RID: 5462 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001556")]
	[Address(RVA = "0x1ED06B4", Offset = "0x1ED06B4", VA = "0x1ED06B4", Slot = "38")]
	public override void SetLayoutVertical()
	{
	}

	// Token: 0x06001557 RID: 5463 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001557")]
	[Address(RVA = "0x1ED06C4", Offset = "0x1ED06C4", VA = "0x1ED06C4")]
	private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible)
	{
	}

	// Token: 0x06001558 RID: 5464 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001558")]
	[Address(RVA = "0x1ED00BC", Offset = "0x1ED00BC", VA = "0x1ED00BC")]
	protected void SetChildrenAlongAxisWithReverse(int axis, bool isVertical, bool isReverse)
	{
	}

	// Token: 0x06001559 RID: 5465 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001559")]
	[Address(RVA = "0x1ED0930", Offset = "0x1ED0930", VA = "0x1ED0930")]
	protected void SetChildAlongAxisWithScaleAndDirection(RectTransform rect, int axis, bool reverse, float pos, float size, float scaleFactor)
	{
	}

	// Token: 0x0600155A RID: 5466 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600155A")]
	[Address(RVA = "0x1ED0C08", Offset = "0x1ED0C08", VA = "0x1ED0C08")]
	protected void SetChildAlongAxisWithScaleAndDirection(RectTransform rect, int axis, bool isReverse, float pos, float scaleFactor)
	{
	}

	// Token: 0x0600155B RID: 5467 RVA: 0x00008538 File Offset: 0x00006738
	[Token(Token = "0x600155B")]
	[Address(RVA = "0x1ED07D0", Offset = "0x1ED07D0", VA = "0x1ED07D0")]
	protected float GetStartOffsetWithReverse(int axis, bool isReverse, float requiredSpaceWithoutPadding)
	{
		return 0f;
	}

	// Token: 0x04001852 RID: 6226
	[Token(Token = "0x4001852")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Vector2 TopLeft;

	// Token: 0x04001853 RID: 6227
	[Token(Token = "0x4001853")]
	[FieldOffset(Offset = "0x8")]
	private static readonly Vector2 BottomLeft;

	// Token: 0x04001854 RID: 6228
	[Token(Token = "0x4001854")]
	[FieldOffset(Offset = "0x10")]
	private static readonly Vector2 TopRight;

	// Token: 0x04001855 RID: 6229
	[Token(Token = "0x4001855")]
	[FieldOffset(Offset = "0x18")]
	private static readonly Vector2 BottomRight;

	// Token: 0x04001856 RID: 6230
	[Token(Token = "0x4001856")]
	[FieldOffset(Offset = "0x63")]
	[SerializeField]
	protected bool m_IsReverse;
}
