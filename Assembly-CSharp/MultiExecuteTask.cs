using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using SQLite4Unity3d;

// Token: 0x0200021C RID: 540
[Token(Token = "0x200021C")]
internal class MultiExecuteTask : DatabaseActionTask
{
	// Token: 0x06000E64 RID: 3684 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E64")]
	[Address(RVA = "0x1223984", Offset = "0x1223984", VA = "0x1223984")]
	public MultiExecuteTask(SQLiteConnection dbConnection, List<string> cmd, [Optional] Action<List<DBExecResult>> callback)
	{
	}

	// Token: 0x06000E65 RID: 3685 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E65")]
	[Address(RVA = "0x12254D8", Offset = "0x12254D8", VA = "0x12254D8", Slot = "5")]
	public override void Process()
	{
	}

	// Token: 0x06000E66 RID: 3686 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E66")]
	[Address(RVA = "0x1225694", Offset = "0x1225694", VA = "0x1225694", Slot = "6")]
	protected internal override void CallBack()
	{
	}

	// Token: 0x04001198 RID: 4504
	[Token(Token = "0x4001198")]
	[FieldOffset(Offset = "0x20")]
	private Action<List<DBExecResult>> callback;

	// Token: 0x04001199 RID: 4505
	[Token(Token = "0x4001199")]
	[FieldOffset(Offset = "0x28")]
	private List<string> sqls;

	// Token: 0x0400119A RID: 4506
	[Token(Token = "0x400119A")]
	[FieldOffset(Offset = "0x30")]
	private List<DBExecResult> sql_results;
}
