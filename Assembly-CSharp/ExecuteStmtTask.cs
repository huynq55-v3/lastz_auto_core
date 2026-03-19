using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using SQLite4Unity3d;

// Token: 0x0200021B RID: 539
[Token(Token = "0x200021B")]
internal class ExecuteStmtTask : DatabaseActionTask
{
	// Token: 0x06000E61 RID: 3681 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E61")]
	[Address(RVA = "0x1223824", Offset = "0x1223824", VA = "0x1223824")]
	public ExecuteStmtTask(SQLiteConnection dbConnection, string cmd, List<List<DBAnyValue>> values, [Optional] Action<DBExecResult> callback)
	{
	}

	// Token: 0x06000E62 RID: 3682 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E62")]
	[Address(RVA = "0x1225428", Offset = "0x1225428", VA = "0x1225428", Slot = "5")]
	public override void Process()
	{
	}

	// Token: 0x06000E63 RID: 3683 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E63")]
	[Address(RVA = "0x12254B8", Offset = "0x12254B8", VA = "0x12254B8", Slot = "6")]
	protected internal override void CallBack()
	{
	}

	// Token: 0x04001194 RID: 4500
	[Token(Token = "0x4001194")]
	[FieldOffset(Offset = "0x20")]
	private Action<DBExecResult> callback;

	// Token: 0x04001195 RID: 4501
	[Token(Token = "0x4001195")]
	[FieldOffset(Offset = "0x28")]
	private string sql;

	// Token: 0x04001196 RID: 4502
	[Token(Token = "0x4001196")]
	[FieldOffset(Offset = "0x30")]
	private DBExecResult sql_result;

	// Token: 0x04001197 RID: 4503
	[Token(Token = "0x4001197")]
	[FieldOffset(Offset = "0x38")]
	private List<List<DBAnyValue>> values;
}
