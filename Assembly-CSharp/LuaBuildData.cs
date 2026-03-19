using System;
using Il2CppDummyDll;

// Token: 0x02000376 RID: 886
[Token(Token = "0x2000376")]
public class LuaBuildData
{
	// Token: 0x0600168A RID: 5770 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600168A")]
	[Address(RVA = "0x1EE11A8", Offset = "0x1EE11A8", VA = "0x1EE11A8")]
	public LuaBuildData(long uid, long updateTime, int point, int tempState, int itemId, int lv, int tempConnect)
	{
	}

	// Token: 0x0600168B RID: 5771 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600168B")]
	[Address(RVA = "0x1EE1210", Offset = "0x1EE1210", VA = "0x1EE1210")]
	public LuaBuildData()
	{
	}

	// Token: 0x0600168C RID: 5772 RVA: 0x00008880 File Offset: 0x00006A80
	[Token(Token = "0x600168C")]
	[Address(RVA = "0x1EE1218", Offset = "0x1EE1218", VA = "0x1EE1218")]
	public bool IsActive()
	{
		return default(bool);
	}

	// Token: 0x040019D2 RID: 6610
	[Token(Token = "0x40019D2")]
	[FieldOffset(Offset = "0x10")]
	public long uuid;

	// Token: 0x040019D3 RID: 6611
	[Token(Token = "0x40019D3")]
	[FieldOffset(Offset = "0x18")]
	public int pointId;

	// Token: 0x040019D4 RID: 6612
	[Token(Token = "0x40019D4")]
	[FieldOffset(Offset = "0x1C")]
	public int state;

	// Token: 0x040019D5 RID: 6613
	[Token(Token = "0x40019D5")]
	[FieldOffset(Offset = "0x20")]
	public int buildId;

	// Token: 0x040019D6 RID: 6614
	[Token(Token = "0x40019D6")]
	[FieldOffset(Offset = "0x24")]
	public int level;

	// Token: 0x040019D7 RID: 6615
	[Token(Token = "0x40019D7")]
	[FieldOffset(Offset = "0x28")]
	public int connect;

	// Token: 0x040019D8 RID: 6616
	[Token(Token = "0x40019D8")]
	[FieldOffset(Offset = "0x30")]
	public long buildUpdateTime;
}
