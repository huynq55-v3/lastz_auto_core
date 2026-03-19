using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000327 RID: 807
[Token(Token = "0x2000327")]
public class ArabicMirror : MonoBehaviour
{
	// Token: 0x06001532 RID: 5426 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001532")]
	[Address(RVA = "0x1992CAC", Offset = "0x1992CAC", VA = "0x1992CAC")]
	private void EnsureDataListSize(int index)
	{
	}

	// Token: 0x06001533 RID: 5427 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001533")]
	[Address(RVA = "0x1992D9C", Offset = "0x1992D9C", VA = "0x1992D9C")]
	public void WriteData(int index, GameObject gameObject)
	{
	}

	// Token: 0x06001534 RID: 5428 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001534")]
	[Address(RVA = "0x1992EF4", Offset = "0x1992EF4", VA = "0x1992EF4")]
	public void RecordOriginalData(int index, GameObject gameObject)
	{
	}

	// Token: 0x06001535 RID: 5429 RVA: 0x000084A8 File Offset: 0x000066A8
	[Token(Token = "0x6001535")]
	[Address(RVA = "0x1993048", Offset = "0x1993048", VA = "0x1993048")]
	public bool SwitchData(int index, GameObject gameObject)
	{
		return default(bool);
	}

	// Token: 0x06001536 RID: 5430 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001536")]
	[Address(RVA = "0x1993284", Offset = "0x1993284", VA = "0x1993284")]
	public void ClearData(int index)
	{
	}

	// Token: 0x06001537 RID: 5431 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001537")]
	[Address(RVA = "0x1993158", Offset = "0x1993158", VA = "0x1993158")]
	private static void ApplyDataToGameObject(GameObject gameObject, MirrorPositionData data)
	{
	}

	// Token: 0x06001538 RID: 5432 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001538")]
	[Address(RVA = "0x1993338", Offset = "0x1993338", VA = "0x1993338")]
	public void Awake()
	{
	}

	// Token: 0x06001539 RID: 5433 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001539")]
	[Address(RVA = "0x199333C", Offset = "0x199333C", VA = "0x199333C")]
	private static void RecordAutoOriginalData(RectTransform rect, List<AutoMirrorPositionData> preOrderDataList, List<GameObject> cullingObjects)
	{
	}

	// Token: 0x0600153A RID: 5434 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600153A")]
	[Address(RVA = "0x1993824", Offset = "0x1993824", VA = "0x1993824")]
	private static void PreProcessInRecord(RectTransform rect, List<GameObject> cullingObjects)
	{
	}

	// Token: 0x0600153B RID: 5435 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600153B")]
	[Address(RVA = "0x1993AA8", Offset = "0x1993AA8", VA = "0x1993AA8")]
	private static void ChangePivot(RectTransform rect, float pivotX)
	{
	}

	// Token: 0x0600153C RID: 5436 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600153C")]
	[Address(RVA = "0x1993C10", Offset = "0x1993C10", VA = "0x1993C10")]
	private static void ProcessImageOrRawImage(RectTransform rect)
	{
	}

	// Token: 0x0600153D RID: 5437 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600153D")]
	[Address(RVA = "0x1993EF4", Offset = "0x1993EF4", VA = "0x1993EF4")]
	private static void ProcessSlider(RectTransform rect)
	{
	}

	// Token: 0x0600153E RID: 5438 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600153E")]
	[Address(RVA = "0x1993FC0", Offset = "0x1993FC0", VA = "0x1993FC0")]
	private static void ProcessTextAlign(RectTransform rect)
	{
	}

	// Token: 0x0600153F RID: 5439 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600153F")]
	[Address(RVA = "0x19941CC", Offset = "0x19941CC", VA = "0x19941CC")]
	private static void ProcessLayout(RectTransform rect)
	{
	}

	// Token: 0x06001540 RID: 5440 RVA: 0x000084C0 File Offset: 0x000066C0
	[Token(Token = "0x6001540")]
	[Address(RVA = "0x1994618", Offset = "0x1994618", VA = "0x1994618")]
	private static bool IsProcessChildPos(RectTransform rect)
	{
		return default(bool);
	}

	// Token: 0x06001541 RID: 5441 RVA: 0x000084D8 File Offset: 0x000066D8
	[Token(Token = "0x6001541")]
	[Address(RVA = "0x1993768", Offset = "0x1993768", VA = "0x1993768")]
	private static bool IsProcessSelf(RectTransform rect, List<GameObject> cullingObjects)
	{
		return default(bool);
	}

	// Token: 0x06001542 RID: 5442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001542")]
	[Address(RVA = "0x199479C", Offset = "0x199479C", VA = "0x199479C")]
	private static void ProcessAllGameObject(List<GameObject> objects, List<SingleMirrorObjectData> objectDatas)
	{
	}

	// Token: 0x06001543 RID: 5443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001543")]
	[Address(RVA = "0x19948CC", Offset = "0x19948CC", VA = "0x19948CC")]
	public ArabicMirror()
	{
	}

	// Token: 0x04001842 RID: 6210
	[Token(Token = "0x4001842")]
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public List<GameObject> mirrorObjects;

	// Token: 0x04001843 RID: 6211
	[Token(Token = "0x4001843")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[HideInInspector]
	private List<SingleMirrorObjectData> mirrorObjectDatas;

	// Token: 0x04001844 RID: 6212
	[Token(Token = "0x4001844")]
	[FieldOffset(Offset = "0x28")]
	public bool IsApplyAutoMirror;

	// Token: 0x04001845 RID: 6213
	[Token(Token = "0x4001845")]
	[FieldOffset(Offset = "0x29")]
	public bool IsNoLuaControl;

	// Token: 0x04001846 RID: 6214
	[Token(Token = "0x4001846")]
	[FieldOffset(Offset = "0x2A")]
	[Tooltip("以自身中心而不是以屏幕中心做镜像")]
	public bool IsInnerMirror;

	// Token: 0x04001847 RID: 6215
	[Token(Token = "0x4001847")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<GameObject> _autoMirrorCullObjects;
}
