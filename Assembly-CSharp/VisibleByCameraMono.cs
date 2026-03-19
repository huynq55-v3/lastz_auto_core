using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000297 RID: 663
[Token(Token = "0x2000297")]
public class VisibleByCameraMono : MonoBehaviour, IVisibleByCameraZoom
{
	// Token: 0x0600117E RID: 4478 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600117E")]
	[Address(RVA = "0x1C50E84", Offset = "0x1C50E84", VA = "0x1C50E84")]
	public void AddObjToList(GameObject o)
	{
	}

	// Token: 0x0600117F RID: 4479 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600117F")]
	[Address(RVA = "0x1C50F34", Offset = "0x1C50F34", VA = "0x1C50F34")]
	private void Awake()
	{
	}

	// Token: 0x06001180 RID: 4480 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001180")]
	[Address(RVA = "0x1C50F54", Offset = "0x1C50F54", VA = "0x1C50F54")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001181 RID: 4481 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001181")]
	[Address(RVA = "0x1C50F74", Offset = "0x1C50F74", VA = "0x1C50F74", Slot = "4")]
	public void SetVisible(bool visible)
	{
	}

	// Token: 0x06001182 RID: 4482 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001182")]
	[Address(RVA = "0x1C51070", Offset = "0x1C51070", VA = "0x1C51070")]
	public VisibleByCameraMono()
	{
	}

	// Token: 0x0400143B RID: 5179
	[Token(Token = "0x400143B")]
	[FieldOffset(Offset = "0x18")]
	public List<GameObject> objList;
}
