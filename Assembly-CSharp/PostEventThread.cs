using System;
using System.Collections.Generic;
using System.Threading;
using Il2CppDummyDll;

// Token: 0x020000BC RID: 188
[Token(Token = "0x20000BC")]
internal class PostEventThread
{
	// Token: 0x06000454 RID: 1108 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000454")]
	[Address(RVA = "0x2F6C1AC", Offset = "0x2F6C1AC", VA = "0x2F6C1AC")]
	public void Start()
	{
	}

	// Token: 0x06000455 RID: 1109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000455")]
	[Address(RVA = "0x2F6C50C", Offset = "0x2F6C50C", VA = "0x2F6C50C")]
	public void Stop()
	{
	}

	// Token: 0x06000456 RID: 1110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000456")]
	[Address(RVA = "0x2F6E210", Offset = "0x2F6E210", VA = "0x2F6E210")]
	public void AddTask(PostEventThreadTask task)
	{
	}

	// Token: 0x06000457 RID: 1111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000457")]
	[Address(RVA = "0x2F70E34", Offset = "0x2F70E34", VA = "0x2F70E34")]
	private void Sleep()
	{
	}

	// Token: 0x06000458 RID: 1112 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000458")]
	[Address(RVA = "0x2F70E18", Offset = "0x2F70E18", VA = "0x2F70E18")]
	private void Wakeup()
	{
	}

	// Token: 0x06000459 RID: 1113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000459")]
	[Address(RVA = "0x2F70E54", Offset = "0x2F70E54", VA = "0x2F70E54")]
	private void ThreadProc()
	{
	}

	// Token: 0x0600045A RID: 1114 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600045A")]
	[Address(RVA = "0x2F6F570", Offset = "0x2F6F570", VA = "0x2F6F570")]
	public PostEventThread()
	{
	}

	// Token: 0x0400042E RID: 1070
	[Token(Token = "0x400042E")]
	[FieldOffset(Offset = "0x10")]
	private Thread thread;

	// Token: 0x0400042F RID: 1071
	[Token(Token = "0x400042F")]
	[FieldOffset(Offset = "0x18")]
	private AutoResetEvent wakeupEvent;

	// Token: 0x04000430 RID: 1072
	[Token(Token = "0x4000430")]
	[FieldOffset(Offset = "0x20")]
	private bool stop;

	// Token: 0x04000431 RID: 1073
	[Token(Token = "0x4000431")]
	[FieldOffset(Offset = "0x28")]
	private Queue<PostEventThreadTask> tasks;

	// Token: 0x04000432 RID: 1074
	[Token(Token = "0x4000432")]
	[FieldOffset(Offset = "0x30")]
	private PostEventThreadTask currentTask;

	// Token: 0x04000433 RID: 1075
	[Token(Token = "0x4000433")]
	[FieldOffset(Offset = "0x38")]
	private byte[] buffer;
}
