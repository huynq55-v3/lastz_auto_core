using System;
using Il2CppDummyDll;

// Token: 0x02000207 RID: 519
[Token(Token = "0x2000207")]
public abstract class WebSocketItemBase
{
	// Token: 0x06000DED RID: 3565
	[Token(Token = "0x6000DED")]
	public abstract void SetCallBack(Action<string, string, int> cb);

	// Token: 0x06000DEE RID: 3566
	[Token(Token = "0x6000DEE")]
	public abstract bool IsOpen();

	// Token: 0x06000DEF RID: 3567
	[Token(Token = "0x6000DEF")]
	public abstract bool Connect(string APP_ID, string protocol, string ip, int port, int code);

	// Token: 0x06000DF0 RID: 3568
	[Token(Token = "0x6000DF0")]
	public abstract void Process();

	// Token: 0x06000DF1 RID: 3569
	[Token(Token = "0x6000DF1")]
	public abstract void Send(string json);

	// Token: 0x06000DF2 RID: 3570
	[Token(Token = "0x6000DF2")]
	public abstract void Close();

	// Token: 0x06000DF3 RID: 3571 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DF3")]
	[Address(RVA = "0x121A9EC", Offset = "0x121A9EC", VA = "0x121A9EC")]
	protected WebSocketItemBase()
	{
	}

	// Token: 0x02000208 RID: 520
	[Token(Token = "0x2000208")]
	public struct MsgItem
	{
		// Token: 0x06000DF4 RID: 3572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DF4")]
		[Address(RVA = "0x121A9F4", Offset = "0x121A9F4", VA = "0x121A9F4")]
		public MsgItem(string _k, string _v)
		{
		}

		// Token: 0x0400114D RID: 4429
		[Token(Token = "0x400114D")]
		[FieldOffset(Offset = "0x0")]
		public string k;

		// Token: 0x0400114E RID: 4430
		[Token(Token = "0x400114E")]
		[FieldOffset(Offset = "0x8")]
		public string v;
	}
}
