using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using Il2CppDummyDll;

// Token: 0x020000BB RID: 187
[Token(Token = "0x20000BB")]
public class PostEventThreadTask
{
	// Token: 0x17000099 RID: 153
	// (get) Token: 0x0600044A RID: 1098 RVA: 0x00003498 File Offset: 0x00001698
	// (set) Token: 0x0600044B RID: 1099 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000099")]
	public bool IsSuccess
	{
		[Token(Token = "0x600044A")]
		[Address(RVA = "0x2F6F6EC", Offset = "0x2F6F6EC", VA = "0x2F6F6EC")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600044B")]
		[Address(RVA = "0x2F6F6F4", Offset = "0x2F6F6F4", VA = "0x2F6F6F4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x1700009A RID: 154
	// (get) Token: 0x0600044C RID: 1100 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600044D RID: 1101 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700009A")]
	public Exception LastException
	{
		[Token(Token = "0x600044C")]
		[Address(RVA = "0x2F6F700", Offset = "0x2F6F700", VA = "0x2F6F700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600044D")]
		[Address(RVA = "0x2F6F708", Offset = "0x2F6F708", VA = "0x2F6F708")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x0600044E RID: 1102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600044E")]
	[Address(RVA = "0x2F6E12C", Offset = "0x2F6E12C", VA = "0x2F6E12C")]
	public PostEventThreadTask(string url, string para)
	{
	}

	// Token: 0x0600044F RID: 1103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600044F")]
	[Address(RVA = "0x2F6F710", Offset = "0x2F6F710", VA = "0x2F6F710")]
	public void Abort()
	{
	}

	// Token: 0x06000450 RID: 1104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000450")]
	[Address(RVA = "0x2F6F938", Offset = "0x2F6F938", VA = "0x2F6F938")]
	public void BeginProcess()
	{
	}

	// Token: 0x06000451 RID: 1105 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000451")]
	[Address(RVA = "0x2F6FE04", Offset = "0x2F6FE04", VA = "0x2F6FE04")]
	public void WaitProcessDone()
	{
	}

	// Token: 0x06000452 RID: 1106 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000452")]
	[Address(RVA = "0x2F6FF14", Offset = "0x2F6FF14", VA = "0x2F6FF14")]
	private static void GetRequestStreamCallback(IAsyncResult asyncResult)
	{
	}

	// Token: 0x06000453 RID: 1107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000453")]
	[Address(RVA = "0x2F703F8", Offset = "0x2F703F8", VA = "0x2F703F8")]
	private static void GetResponseCallback(IAsyncResult asyncResult)
	{
	}

	// Token: 0x04000425 RID: 1061
	[Token(Token = "0x4000425")]
	[FieldOffset(Offset = "0x10")]
	private readonly object requestLock;

	// Token: 0x04000426 RID: 1062
	[Token(Token = "0x4000426")]
	[FieldOffset(Offset = "0x18")]
	private WebRequest webrequest;

	// Token: 0x04000427 RID: 1063
	[Token(Token = "0x4000427")]
	[FieldOffset(Offset = "0x20")]
	private readonly ManualResetEvent allDone;

	// Token: 0x04000428 RID: 1064
	[Token(Token = "0x4000428")]
	[FieldOffset(Offset = "0x28")]
	private byte[] content;

	// Token: 0x04000429 RID: 1065
	[Token(Token = "0x4000429")]
	[FieldOffset(Offset = "0x30")]
	private int contentLen;

	// Token: 0x0400042A RID: 1066
	[Token(Token = "0x400042A")]
	[FieldOffset(Offset = "0x38")]
	public string uri;

	// Token: 0x0400042B RID: 1067
	[Token(Token = "0x400042B")]
	[FieldOffset(Offset = "0x40")]
	public string param;
}
