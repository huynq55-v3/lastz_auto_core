using System;
using Il2CppDummyDll;

// Token: 0x02000357 RID: 855
[Token(Token = "0x2000357")]
public class AutoDoMovePosUpAnimState : BaseAutoDoMovePosState
{
	// Token: 0x06001608 RID: 5640 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001608")]
	[Address(RVA = "0x1ED9FE0", Offset = "0x1ED9FE0", VA = "0x1ED9FE0")]
	public AutoDoMovePosUpAnimState(AutoDoMovePos autoDo, AutoDoMovePosMachine autoMachine)
	{
	}

	// Token: 0x06001609 RID: 5641 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001609")]
	[Address(RVA = "0x1EDA28C", Offset = "0x1EDA28C", VA = "0x1EDA28C", Slot = "4")]
	public override void OnEnter()
	{
	}

	// Token: 0x0600160A RID: 5642 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600160A")]
	[Address(RVA = "0x1EDA30C", Offset = "0x1EDA30C", VA = "0x1EDA30C", Slot = "5")]
	public override void OnUpdate(float deltaTime)
	{
	}

	// Token: 0x0600160B RID: 5643 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600160B")]
	[Address(RVA = "0x1EDA408", Offset = "0x1EDA408", VA = "0x1EDA408", Slot = "6")]
	public override void OnLeave()
	{
	}

	// Token: 0x0400192C RID: 6444
	[Token(Token = "0x400192C")]
	[FieldOffset(Offset = "0x20")]
	private float _time;

	// Token: 0x0400192D RID: 6445
	[Token(Token = "0x400192D")]
	[FieldOffset(Offset = "0x24")]
	private float _allTime;

	// Token: 0x0400192E RID: 6446
	[Token(Token = "0x400192E")]
	[FieldOffset(Offset = "0x28")]
	private float _doAnimTime;
}
