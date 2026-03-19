using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sfs2X.Core;
using Sfs2X.Util;

// Token: 0x0200023F RID: 575
[Token(Token = "0x200023F")]
public class MessageFactory
{
	// Token: 0x170001C8 RID: 456
	// (get) Token: 0x06000F73 RID: 3955 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001C8")]
	public static MessageFactory Instance
	{
		[Token(Token = "0x6000F73")]
		[Address(RVA = "0x1BE28B4", Offset = "0x1BE28B4", VA = "0x1BE28B4")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000F74 RID: 3956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F74")]
	[Address(RVA = "0x1BE294C", Offset = "0x1BE294C", VA = "0x1BE294C")]
	public void InitMessageHandlers()
	{
	}

	// Token: 0x06000F75 RID: 3957 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F75")]
	[Address(RVA = "0x1BE2DE4", Offset = "0x1BE2DE4", VA = "0x1BE2DE4")]
	public void DispatchResponse(BaseEvent e)
	{
	}

	// Token: 0x06000F76 RID: 3958 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F76")]
	[Address(RVA = "0x1BE32EC", Offset = "0x1BE32EC", VA = "0x1BE32EC")]
	public void DispatchResponse(string cmd, ByteArray rawData)
	{
	}

	// Token: 0x06000F77 RID: 3959 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F77")]
	[Address(RVA = "0x1BE2944", Offset = "0x1BE2944", VA = "0x1BE2944")]
	public MessageFactory()
	{
	}

	// Token: 0x04001218 RID: 4632
	[Token(Token = "0x4001218")]
	[FieldOffset(Offset = "0x0")]
	private static MessageFactory _instance;

	// Token: 0x04001219 RID: 4633
	[Token(Token = "0x4001219")]
	[FieldOffset(Offset = "0x10")]
	public Dictionary<string, BaseMessage> mHandlers;
}
