using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000355 RID: 853
[Token(Token = "0x2000355")]
public class AutoDoMovePosMachine
{
	// Token: 0x060015FB RID: 5627 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015FB")]
	[Address(RVA = "0x1ED96E0", Offset = "0x1ED96E0", VA = "0x1ED96E0")]
	public AutoDoMovePosMachine(AutoDoMovePos autoDo)
	{
	}

	// Token: 0x060015FC RID: 5628 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015FC")]
	[Address(RVA = "0x1ED9FB8", Offset = "0x1ED9FB8", VA = "0x1ED9FB8")]
	public void UnInit()
	{
	}

	// Token: 0x060015FD RID: 5629 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015FD")]
	[Address(RVA = "0x1ED9D3C", Offset = "0x1ED9D3C", VA = "0x1ED9D3C")]
	public void ChangeState(AutoDoMovePosState state)
	{
	}

	// Token: 0x060015FE RID: 5630 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015FE")]
	[Address(RVA = "0x1ED9D94", Offset = "0x1ED9D94", VA = "0x1ED9D94")]
	private void InitAllState()
	{
	}

	// Token: 0x060015FF RID: 5631 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015FF")]
	[Address(RVA = "0x1ED9F28", Offset = "0x1ED9F28", VA = "0x1ED9F28")]
	public BaseAutoDoMovePosState GetCurState()
	{
		return null;
	}

	// Token: 0x06001600 RID: 5632 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001600")]
	[Address(RVA = "0x1ED978C", Offset = "0x1ED978C", VA = "0x1ED978C")]
	public void OnUpdate(float deltaTime)
	{
	}

	// Token: 0x04001924 RID: 6436
	[Token(Token = "0x4001924")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<AutoDoMovePosState, BaseAutoDoMovePosState> _allState;

	// Token: 0x04001925 RID: 6437
	[Token(Token = "0x4001925")]
	[FieldOffset(Offset = "0x18")]
	private AutoDoMovePosState _curState;

	// Token: 0x04001926 RID: 6438
	[Token(Token = "0x4001926")]
	[FieldOffset(Offset = "0x20")]
	private AutoDoMovePos _autoDo;
}
