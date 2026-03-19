using System;
using Il2CppDummyDll;
using RVO;
using UnityEngine;

// Token: 0x020002B6 RID: 694
[Token(Token = "0x20002B6")]
public class LWBattleRVOAgent : MonoBehaviour
{
	// Token: 0x060011F7 RID: 4599 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011F7")]
	[Address(RVA = "0x1C56F94", Offset = "0x1C56F94", VA = "0x1C56F94")]
	private void Awake()
	{
	}

	// Token: 0x060011F8 RID: 4600 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011F8")]
	[Address(RVA = "0x1C56FB8", Offset = "0x1C56FB8", VA = "0x1C56FB8")]
	public void Update()
	{
	}

	// Token: 0x060011F9 RID: 4601 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011F9")]
	[Address(RVA = "0x1C57650", Offset = "0x1C57650", VA = "0x1C57650")]
	public void SetActive(bool active)
	{
	}

	// Token: 0x060011FA RID: 4602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011FA")]
	[Address(RVA = "0x1C5765C", Offset = "0x1C5765C", VA = "0x1C5765C")]
	private void OnDestroy()
	{
	}

	// Token: 0x060011FB RID: 4603 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011FB")]
	[Address(RVA = "0x1C57734", Offset = "0x1C57734", VA = "0x1C57734")]
	public void SetTargetPosition(float x, float z)
	{
	}

	// Token: 0x060011FC RID: 4604 RVA: 0x00007050 File Offset: 0x00005250
	[Token(Token = "0x60011FC")]
	[Address(RVA = "0x1C57744", Offset = "0x1C57744", VA = "0x1C57744")]
	public Vector2 GetTargetPosition()
	{
		return default(Vector2);
	}

	// Token: 0x060011FD RID: 4605 RVA: 0x00007068 File Offset: 0x00005268
	[Token(Token = "0x60011FD")]
	[Address(RVA = "0x1C57768", Offset = "0x1C57768", VA = "0x1C57768")]
	public bool SetCurPosition(float x, float z)
	{
		return default(bool);
	}

	// Token: 0x060011FE RID: 4606 RVA: 0x00007080 File Offset: 0x00005280
	[Token(Token = "0x60011FE")]
	[Address(RVA = "0x1C5793C", Offset = "0x1C5793C", VA = "0x1C5793C")]
	public Vector2 GetCurPosition()
	{
		return default(Vector2);
	}

	// Token: 0x060011FF RID: 4607 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011FF")]
	[Address(RVA = "0x1C57AE8", Offset = "0x1C57AE8", VA = "0x1C57AE8")]
	public LWBattleRVOAgent()
	{
	}

	// Token: 0x040014ED RID: 5357
	[Token(Token = "0x40014ED")]
	[FieldOffset(Offset = "0x18")]
	public int sid;

	// Token: 0x040014EE RID: 5358
	[Token(Token = "0x40014EE")]
	[FieldOffset(Offset = "0x20")]
	private Random m_random;

	// Token: 0x040014EF RID: 5359
	[Token(Token = "0x40014EF")]
	[FieldOffset(Offset = "0x28")]
	public LWBattleRVOManager mgr;

	// Token: 0x040014F0 RID: 5360
	[Token(Token = "0x40014F0")]
	[FieldOffset(Offset = "0x30")]
	public float speed;

	// Token: 0x040014F1 RID: 5361
	[Token(Token = "0x40014F1")]
	[FieldOffset(Offset = "0x34")]
	public bool active;

	// Token: 0x040014F2 RID: 5362
	[Token(Token = "0x40014F2")]
	[FieldOffset(Offset = "0x38")]
	private Vector2 _targetPosition;

	// Token: 0x040014F3 RID: 5363
	[Token(Token = "0x40014F3")]
	[FieldOffset(Offset = "0x40")]
	private Transform tran;
}
