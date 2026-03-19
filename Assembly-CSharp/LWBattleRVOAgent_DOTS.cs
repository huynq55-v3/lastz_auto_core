using System;
using Il2CppDummyDll;
using RVO_DOTS;
using Unity.Mathematics;
using UnityEngine;

// Token: 0x020002B9 RID: 697
[Token(Token = "0x20002B9")]
public class LWBattleRVOAgent_DOTS : MonoBehaviour
{
	// Token: 0x06001209 RID: 4617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001209")]
	[Address(RVA = "0x1C58774", Offset = "0x1C58774", VA = "0x1C58774")]
	private void Awake()
	{
	}

	// Token: 0x0600120A RID: 4618 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600120A")]
	[Address(RVA = "0x1C58798", Offset = "0x1C58798", VA = "0x1C58798")]
	public void Update()
	{
	}

	// Token: 0x0600120B RID: 4619 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600120B")]
	[Address(RVA = "0x1C58BC4", Offset = "0x1C58BC4", VA = "0x1C58BC4")]
	public void SetActive(bool active)
	{
	}

	// Token: 0x0600120C RID: 4620 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600120C")]
	[Address(RVA = "0x1C58BD0", Offset = "0x1C58BD0", VA = "0x1C58BD0")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600120D RID: 4621 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600120D")]
	[Address(RVA = "0x1C58C74", Offset = "0x1C58C74", VA = "0x1C58C74")]
	public void SetTargetPosition(float x, float z)
	{
	}

	// Token: 0x0600120E RID: 4622 RVA: 0x000070B0 File Offset: 0x000052B0
	[Token(Token = "0x600120E")]
	[Address(RVA = "0x1C58C84", Offset = "0x1C58C84", VA = "0x1C58C84")]
	public Vector2 GetTargetPosition()
	{
		return default(Vector2);
	}

	// Token: 0x0600120F RID: 4623 RVA: 0x000070C8 File Offset: 0x000052C8
	[Token(Token = "0x600120F")]
	[Address(RVA = "0x1C58CA8", Offset = "0x1C58CA8", VA = "0x1C58CA8")]
	public bool SetCurPosition(float x, float z)
	{
		return default(bool);
	}

	// Token: 0x06001210 RID: 4624 RVA: 0x000070E0 File Offset: 0x000052E0
	[Token(Token = "0x6001210")]
	[Address(RVA = "0x1C58E1C", Offset = "0x1C58E1C", VA = "0x1C58E1C")]
	public Vector2 GetCurPosition()
	{
		return default(Vector2);
	}

	// Token: 0x06001211 RID: 4625 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001211")]
	[Address(RVA = "0x1C58F94", Offset = "0x1C58F94", VA = "0x1C58F94")]
	public LWBattleRVOAgent_DOTS()
	{
	}

	// Token: 0x040014F7 RID: 5367
	[Token(Token = "0x40014F7")]
	[FieldOffset(Offset = "0x18")]
	public int sid;

	// Token: 0x040014F8 RID: 5368
	[Token(Token = "0x40014F8")]
	[FieldOffset(Offset = "0x20")]
	public LWBattleRVOManager_DOTS mgr;

	// Token: 0x040014F9 RID: 5369
	[Token(Token = "0x40014F9")]
	[FieldOffset(Offset = "0x28")]
	public float speed;

	// Token: 0x040014FA RID: 5370
	[Token(Token = "0x40014FA")]
	[FieldOffset(Offset = "0x2C")]
	public bool active;

	// Token: 0x040014FB RID: 5371
	[Token(Token = "0x40014FB")]
	[FieldOffset(Offset = "0x30")]
	private float2 _targetPosition;

	// Token: 0x040014FC RID: 5372
	[Token(Token = "0x40014FC")]
	[FieldOffset(Offset = "0x38")]
	private Transform tran;
}
