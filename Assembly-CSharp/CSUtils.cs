using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000377 RID: 887
[Token(Token = "0x2000377")]
public class CSUtils
{
	// Token: 0x0600168D RID: 5773 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600168D")]
	[Address(RVA = "0x1EE123C", Offset = "0x1EE123C", VA = "0x1EE123C")]
	public static void SetPositionFromInput(Transform tf)
	{
	}

	// Token: 0x0600168E RID: 5774 RVA: 0x00008898 File Offset: 0x00006A98
	[Token(Token = "0x600168E")]
	[Address(RVA = "0x1EE1264", Offset = "0x1EE1264", VA = "0x1EE1264")]
	public static Vector3 WorldPositionToUISpacePosition(Vector3 worldPosition)
	{
		return default(Vector3);
	}

	// Token: 0x0600168F RID: 5775 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600168F")]
	[Address(RVA = "0x1EE1324", Offset = "0x1EE1324", VA = "0x1EE1324")]
	public static void DOTweenTo_RectTransformPos_X(RectTransform _rectTransform, float endX, float time, [Optional] Action callback)
	{
	}

	// Token: 0x06001690 RID: 5776 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001690")]
	[Address(RVA = "0x1EE1508", Offset = "0x1EE1508", VA = "0x1EE1508")]
	public static void DOTweenTo_RectTransformPos_Y(RectTransform _rectTransform, float endY, float time, [Optional] Action callback)
	{
	}

	// Token: 0x06001691 RID: 5777 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001691")]
	[Address(RVA = "0x1EE16EC", Offset = "0x1EE16EC", VA = "0x1EE16EC")]
	public static void DOTweenTo_MinWidth(LayoutElement _rectTransform, float endValue, float time, [Optional] Action callback)
	{
	}

	// Token: 0x06001692 RID: 5778 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001692")]
	[Address(RVA = "0x1EE18B8", Offset = "0x1EE18B8", VA = "0x1EE18B8")]
	public static void DOTweenTo_ScrollRect_Horizontal(ScrollRect _scrollRect, float endValue, float time, [Optional] Action callback)
	{
	}

	// Token: 0x06001693 RID: 5779 RVA: 0x000088B0 File Offset: 0x00006AB0
	[Token(Token = "0x6001693")]
	[Address(RVA = "0x1EE1A84", Offset = "0x1EE1A84", VA = "0x1EE1A84")]
	public static bool Hit(Transform transform, float radius, float speed, out Vector3 oritation)
	{
		return default(bool);
	}

	// Token: 0x06001694 RID: 5780 RVA: 0x000088C8 File Offset: 0x00006AC8
	[Token(Token = "0x6001694")]
	[Address(RVA = "0x1EE1E84", Offset = "0x1EE1E84", VA = "0x1EE1E84")]
	public static bool Hit2(Vector3 pos, Vector3 forward, float radius, float speed, out Vector3 oritation)
	{
		return default(bool);
	}

	// Token: 0x06001695 RID: 5781 RVA: 0x000088E0 File Offset: 0x00006AE0
	[Token(Token = "0x6001695")]
	[Address(RVA = "0x1EE213C", Offset = "0x1EE213C", VA = "0x1EE213C")]
	public static bool HitPlane(Vector3 pos, Vector3 forward, float maxDis, out Vector3 hitPoint)
	{
		return default(bool);
	}

	// Token: 0x06001696 RID: 5782 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001696")]
	[Address(RVA = "0x1EE2358", Offset = "0x1EE2358", VA = "0x1EE2358")]
	public CSUtils()
	{
	}

	// Token: 0x040019D9 RID: 6617
	[Token(Token = "0x40019D9")]
	[FieldOffset(Offset = "0x0")]
	private static Vector3 topVec;

	// Token: 0x040019DA RID: 6618
	[Token(Token = "0x40019DA")]
	[FieldOffset(Offset = "0xC")]
	private static Vector3 downVec;

	// Token: 0x040019DB RID: 6619
	[Token(Token = "0x40019DB")]
	[FieldOffset(Offset = "0x18")]
	private static Collider[] colliders;
}
