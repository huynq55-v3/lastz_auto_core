using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000218 RID: 536
[Token(Token = "0x2000218")]
public class DBExecResult
{
	// Token: 0x06000E59 RID: 3673 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E59")]
	[Address(RVA = "0x1223F10", Offset = "0x1223F10", VA = "0x1223F10")]
	public DBExecResult()
	{
	}

	// Token: 0x04001188 RID: 4488
	[Token(Token = "0x4001188")]
	[FieldOffset(Offset = "0x10")]
	public int error;

	// Token: 0x04001189 RID: 4489
	[Token(Token = "0x4001189")]
	[FieldOffset(Offset = "0x18")]
	public string errormsg;

	// Token: 0x0400118A RID: 4490
	[Token(Token = "0x400118A")]
	[FieldOffset(Offset = "0x20")]
	public string errorsql;

	// Token: 0x0400118B RID: 4491
	[Token(Token = "0x400118B")]
	[FieldOffset(Offset = "0x28")]
	public int change_rows;

	// Token: 0x0400118C RID: 4492
	[Token(Token = "0x400118C")]
	[FieldOffset(Offset = "0x30")]
	public long last_insertid;

	// Token: 0x0400118D RID: 4493
	[Token(Token = "0x400118D")]
	[FieldOffset(Offset = "0x38")]
	public int col_count;

	// Token: 0x0400118E RID: 4494
	[Token(Token = "0x400118E")]
	[FieldOffset(Offset = "0x40")]
	public DBColumn[] cols;

	// Token: 0x0400118F RID: 4495
	[Token(Token = "0x400118F")]
	[FieldOffset(Offset = "0x48")]
	public List<DBAnyValue[]> values;
}
