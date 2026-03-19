using System;
using System.Collections.Generic;
using Best.HTTP.Shared.PlatformSupport.Memory;
using Best.WebSockets;
using Il2CppDummyDll;

// Token: 0x02000209 RID: 521
[Token(Token = "0x2000209")]
public class WebSocketItem3 : WebSocketItemBase
{
	// Token: 0x06000DF5 RID: 3573 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DF5")]
	[Address(RVA = "0x121AA24", Offset = "0x121AA24", VA = "0x121AA24")]
	private string CalcSign(string appId, string uid, long time)
	{
		return null;
	}

	// Token: 0x06000DF6 RID: 3574 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DF6")]
	[Address(RVA = "0x121AA7C", Offset = "0x121AA7C", VA = "0x121AA7C", Slot = "4")]
	public override void SetCallBack(Action<string, string, int> cb)
	{
	}

	// Token: 0x06000DF7 RID: 3575 RVA: 0x00006420 File Offset: 0x00004620
	[Token(Token = "0x6000DF7")]
	[Address(RVA = "0x121AA84", Offset = "0x121AA84", VA = "0x121AA84", Slot = "5")]
	public override bool IsOpen()
	{
		return default(bool);
	}

	// Token: 0x06000DF8 RID: 3576 RVA: 0x00006438 File Offset: 0x00004638
	[Token(Token = "0x6000DF8")]
	[Address(RVA = "0x121AAB0", Offset = "0x121AAB0", VA = "0x121AAB0", Slot = "6")]
	public override bool Connect(string APP_ID, string protocol, string ip, int port, int code)
	{
		return default(bool);
	}

	// Token: 0x06000DF9 RID: 3577 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DF9")]
	[Address(RVA = "0x121B0CC", Offset = "0x121B0CC", VA = "0x121B0CC", Slot = "8")]
	public override void Send(string json)
	{
	}

	// Token: 0x06000DFA RID: 3578 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DFA")]
	[Address(RVA = "0x121B0E0", Offset = "0x121B0E0", VA = "0x121B0E0", Slot = "7")]
	public override void Process()
	{
	}

	// Token: 0x06000DFB RID: 3579 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DFB")]
	[Address(RVA = "0x121B324", Offset = "0x121B324", VA = "0x121B324", Slot = "9")]
	public override void Close()
	{
	}

	// Token: 0x06000DFC RID: 3580 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DFC")]
	[Address(RVA = "0x121B338", Offset = "0x121B338", VA = "0x121B338")]
	private void Socket_OnOpen(WebSocket webSocket)
	{
	}

	// Token: 0x06000DFD RID: 3581 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DFD")]
	[Address(RVA = "0x121B48C", Offset = "0x121B48C", VA = "0x121B48C")]
	private void Socket_OnMessage(WebSocket webSocket, string message)
	{
	}

	// Token: 0x06000DFE RID: 3582 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DFE")]
	[Address(RVA = "0x121B6B0", Offset = "0x121B6B0", VA = "0x121B6B0")]
	private void Socket_OnBinary(WebSocket webSocket, BufferSegment data)
	{
	}

	// Token: 0x06000DFF RID: 3583 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DFF")]
	[Address(RVA = "0x121B6B4", Offset = "0x121B6B4", VA = "0x121B6B4")]
	private void Socket_OnClosed(WebSocket webSocket, WebSocketStatusCodes code, string message)
	{
	}

	// Token: 0x06000E00 RID: 3584 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E00")]
	[Address(RVA = "0x121B7F4", Offset = "0x121B7F4", VA = "0x121B7F4")]
	private void Socket_OnError(WebSocket webSocket, string ex)
	{
	}

	// Token: 0x06000E01 RID: 3585 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E01")]
	[Address(RVA = "0x121BC9C", Offset = "0x121BC9C", VA = "0x121BC9C")]
	public WebSocketItem3()
	{
	}

	// Token: 0x0400114F RID: 4431
	[Token(Token = "0x400114F")]
	[FieldOffset(Offset = "0x10")]
	private Action<string, string, int> callback_;

	// Token: 0x04001150 RID: 4432
	[Token(Token = "0x4001150")]
	[FieldOffset(Offset = "0x18")]
	private WebSocket socket;

	// Token: 0x04001151 RID: 4433
	[Token(Token = "0x4001151")]
	[FieldOffset(Offset = "0x20")]
	private object locker;

	// Token: 0x04001152 RID: 4434
	[Token(Token = "0x4001152")]
	[FieldOffset(Offset = "0x28")]
	private Queue<WebSocketItemBase.MsgItem> msgQueue;

	// Token: 0x04001153 RID: 4435
	[Token(Token = "0x4001153")]
	[FieldOffset(Offset = "0x30")]
	private int msgItemNo;

	// Token: 0x04001154 RID: 4436
	[Token(Token = "0x4001154")]
	[FieldOffset(Offset = "0x34")]
	private float last_ping_time_;
}
