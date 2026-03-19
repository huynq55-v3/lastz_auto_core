using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using SQLite4Unity3d;

// Token: 0x0200021A RID: 538
[Token(Token = "0x200021A")]
internal class ExecuteTask2 : DatabaseActionTask
{
	// Token: 0x06000E5E RID: 3678 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E5E")]
	[Address(RVA = "0x12236C0", Offset = "0x12236C0", VA = "0x12236C0")]
	public ExecuteTask2(SQLiteConnection dbConnection, string cmd, [Optional] Action<DBExecResult> callback)
	{
	}

	// Token: 0x06000E5F RID: 3679 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E5F")]
	[Address(RVA = "0x1225388", Offset = "0x1225388", VA = "0x1225388", Slot = "5")]
	public override void Process()
	{
	}

	// Token: 0x06000E60 RID: 3680 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E60")]
	[Address(RVA = "0x1225408", Offset = "0x1225408", VA = "0x1225408", Slot = "6")]
	protected internal override void CallBack()
	{
	}

	// Token: 0x04001191 RID: 4497
	[Token(Token = "0x4001191")]
	[FieldOffset(Offset = "0x20")]
	private Action<DBExecResult> callback;

	// Token: 0x04001192 RID: 4498
	[Token(Token = "0x4001192")]
	[FieldOffset(Offset = "0x28")]
	private string sql;

	// Token: 0x04001193 RID: 4499
	[Token(Token = "0x4001193")]
	[FieldOffset(Offset = "0x30")]
	private DBExecResult sql_result;
}
