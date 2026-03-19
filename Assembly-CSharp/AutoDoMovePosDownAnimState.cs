using System;
using Il2CppDummyDll;

// Token: 0x02000353 RID: 851
[Token(Token = "0x2000353")]
public class AutoDoMovePosDownAnimState : BaseAutoDoMovePosState
{
	// Token: 0x060015F7 RID: 5623 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015F7")]
	[Address(RVA = "0x1ED9B78", Offset = "0x1ED9B78", VA = "0x1ED9B78")]
	public AutoDoMovePosDownAnimState(AutoDoMovePos autoDo, AutoDoMovePosMachine autoMachine)
	{
	}

	// Token: 0x060015F8 RID: 5624 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015F8")]
	[Address(RVA = "0x1ED9BC0", Offset = "0x1ED9BC0", VA = "0x1ED9BC0", Slot = "4")]
	public override void OnEnter()
	{
	}

	// Token: 0x060015F9 RID: 5625 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015F9")]
	[Address(RVA = "0x1ED9C40", Offset = "0x1ED9C40", VA = "0x1ED9C40", Slot = "5")]
	public override void OnUpdate(float deltaTime)
	{
	}

	// Token: 0x060015FA RID: 5626 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015FA")]
	[Address(RVA = "0x1ED9D90", Offset = "0x1ED9D90", VA = "0x1ED9D90", Slot = "6")]
	public override void OnLeave()
	{
	}

	// Token: 0x0400191D RID: 6429
	[Token(Token = "0x400191D")]
	[FieldOffset(Offset = "0x20")]
	private float _time;

	// Token: 0x0400191E RID: 6430
	[Token(Token = "0x400191E")]
	[FieldOffset(Offset = "0x24")]
	private float _allTime;

	// Token: 0x0400191F RID: 6431
	[Token(Token = "0x400191F")]
	[FieldOffset(Offset = "0x28")]
	private float _doAnimTime;
}
