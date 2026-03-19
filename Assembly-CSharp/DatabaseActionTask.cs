using System;
using Il2CppDummyDll;
using SQLite4Unity3d;

// Token: 0x02000215 RID: 533
[Token(Token = "0x2000215")]
internal abstract class DatabaseActionTask : IQueuedThreadTask
{
	// Token: 0x06000E56 RID: 3670 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E56")]
	[Address(RVA = "0x1223EC4", Offset = "0x1223EC4", VA = "0x1223EC4")]
	protected internal DatabaseActionTask(SQLiteConnection dbConnection)
	{
	}

	// Token: 0x06000E57 RID: 3671 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E57")]
	[Address(RVA = "0x1223EF4", Offset = "0x1223EF4", VA = "0x1223EF4", Slot = "5")]
	public virtual void Process()
	{
	}

	// Token: 0x06000E58 RID: 3672
	[Token(Token = "0x6000E58")]
	protected internal abstract void CallBack();

	// Token: 0x0400117F RID: 4479
	[Token(Token = "0x400117F")]
	[FieldOffset(Offset = "0x10")]
	protected SQLiteConnection dbConnection;

	// Token: 0x04001180 RID: 4480
	[Token(Token = "0x4001180")]
	[FieldOffset(Offset = "0x18")]
	public bool Processed;
}
