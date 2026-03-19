using System;
using Il2CppDummyDll;

// Token: 0x02000358 RID: 856
[Token(Token = "0x2000358")]
public abstract class BaseAutoDoMovePosState
{
	// Token: 0x0600160C RID: 5644 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600160C")]
	[Address(RVA = "0x1ED9B7C", Offset = "0x1ED9B7C", VA = "0x1ED9B7C")]
	public BaseAutoDoMovePosState(AutoDoMovePos autoDo, AutoDoMovePosMachine autoMachine)
	{
	}

	// Token: 0x0600160D RID: 5645
	[Token(Token = "0x600160D")]
	public abstract void OnEnter();

	// Token: 0x0600160E RID: 5646
	[Token(Token = "0x600160E")]
	public abstract void OnUpdate(float deltaTime);

	// Token: 0x0600160F RID: 5647
	[Token(Token = "0x600160F")]
	public abstract void OnLeave();

	// Token: 0x0400192F RID: 6447
	[Token(Token = "0x400192F")]
	[FieldOffset(Offset = "0x10")]
	public AutoDoMovePos autoDoMovePos;

	// Token: 0x04001930 RID: 6448
	[Token(Token = "0x4001930")]
	[FieldOffset(Offset = "0x18")]
	public AutoDoMovePosMachine machine;
}
