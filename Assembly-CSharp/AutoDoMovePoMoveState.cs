using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000356 RID: 854
[Token(Token = "0x2000356")]
public class AutoDoMovePoMoveState : BaseAutoDoMovePosState
{
	// Token: 0x06001601 RID: 5633 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001601")]
	[Address(RVA = "0x1ED9FDC", Offset = "0x1ED9FDC", VA = "0x1ED9FDC")]
	public AutoDoMovePoMoveState(AutoDoMovePos autoDo, AutoDoMovePosMachine autoMachine)
	{
	}

	// Token: 0x06001602 RID: 5634 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001602")]
	[Address(RVA = "0x1ED9FE4", Offset = "0x1ED9FE4", VA = "0x1ED9FE4", Slot = "4")]
	public override void OnEnter()
	{
	}

	// Token: 0x06001603 RID: 5635 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001603")]
	[Address(RVA = "0x1EDA12C", Offset = "0x1EDA12C", VA = "0x1EDA12C", Slot = "5")]
	public override void OnUpdate(float deltaTime)
	{
	}

	// Token: 0x06001604 RID: 5636 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001604")]
	[Address(RVA = "0x1EDA288", Offset = "0x1EDA288", VA = "0x1EDA288", Slot = "6")]
	public override void OnLeave()
	{
	}

	// Token: 0x06001605 RID: 5637 RVA: 0x00008790 File Offset: 0x00006990
	[Token(Token = "0x6001605")]
	[Address(RVA = "0x1EDA244", Offset = "0x1EDA244", VA = "0x1EDA244")]
	private Vector3 GetStartScreenPos()
	{
		return default(Vector3);
	}

	// Token: 0x06001606 RID: 5638 RVA: 0x000087A8 File Offset: 0x000069A8
	[Token(Token = "0x6001606")]
	[Address(RVA = "0x1EDA264", Offset = "0x1EDA264", VA = "0x1EDA264")]
	private Vector3 GetEndScreenPos()
	{
		return default(Vector3);
	}

	// Token: 0x06001607 RID: 5639 RVA: 0x000087C0 File Offset: 0x000069C0
	[Token(Token = "0x6001607")]
	[Address(RVA = "0x1EDA074", Offset = "0x1EDA074", VA = "0x1EDA074")]
	private float GetAllTime()
	{
		return 0f;
	}

	// Token: 0x04001927 RID: 6439
	[Token(Token = "0x4001927")]
	[FieldOffset(Offset = "0x20")]
	private float _time;

	// Token: 0x04001928 RID: 6440
	[Token(Token = "0x4001928")]
	[FieldOffset(Offset = "0x24")]
	private float _allTime;

	// Token: 0x04001929 RID: 6441
	[Token(Token = "0x4001929")]
	[FieldOffset(Offset = "0x28")]
	private int _useIndex;

	// Token: 0x0400192A RID: 6442
	[Token(Token = "0x400192A")]
	[FieldOffset(Offset = "0x2C")]
	private float _speed;

	// Token: 0x0400192B RID: 6443
	[Token(Token = "0x400192B")]
	[FieldOffset(Offset = "0x30")]
	private int _allCount;
}
