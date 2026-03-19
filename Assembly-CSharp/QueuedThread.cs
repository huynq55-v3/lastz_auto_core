using System;
using System.Collections.Generic;
using System.Threading;
using Il2CppDummyDll;

// Token: 0x020000D1 RID: 209
[Token(Token = "0x20000D1")]
public class QueuedThread
{
	// Token: 0x060005AE RID: 1454 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005AE")]
	[Address(RVA = "0x2F7B834", Offset = "0x2F7B834", VA = "0x2F7B834")]
	public QueuedThread()
	{
	}

	// Token: 0x060005AF RID: 1455 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005AF")]
	[Address(RVA = "0x2F7B900", Offset = "0x2F7B900", VA = "0x2F7B900")]
	public QueuedThread(string name)
	{
	}

	// Token: 0x060005B0 RID: 1456 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B0")]
	[Address(RVA = "0x2F7B9E8", Offset = "0x2F7B9E8", VA = "0x2F7B9E8")]
	public void Start()
	{
	}

	// Token: 0x060005B1 RID: 1457 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B1")]
	[Address(RVA = "0x2F7BAD4", Offset = "0x2F7BAD4", VA = "0x2F7BAD4")]
	public void Stop()
	{
	}

	// Token: 0x060005B2 RID: 1458 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B2")]
	[Address(RVA = "0x2F7BB80", Offset = "0x2F7BB80", VA = "0x2F7BB80")]
	public void AddTask(IQueuedThreadTask task)
	{
	}

	// Token: 0x060005B3 RID: 1459 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B3")]
	[Address(RVA = "0x2F7BC90", Offset = "0x2F7BC90", VA = "0x2F7BC90")]
	private void Sleep()
	{
	}

	// Token: 0x060005B4 RID: 1460 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B4")]
	[Address(RVA = "0x2F7BB64", Offset = "0x2F7BB64", VA = "0x2F7BB64")]
	private void Wakeup()
	{
	}

	// Token: 0x060005B5 RID: 1461 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B5")]
	[Address(RVA = "0x2F7BCB0", Offset = "0x2F7BCB0", VA = "0x2F7BCB0")]
	private void ThreadProc()
	{
	}

	// Token: 0x04000454 RID: 1108
	[Token(Token = "0x4000454")]
	[FieldOffset(Offset = "0x10")]
	private Thread thread;

	// Token: 0x04000455 RID: 1109
	[Token(Token = "0x4000455")]
	[FieldOffset(Offset = "0x18")]
	private AutoResetEvent wakeupEvent;

	// Token: 0x04000456 RID: 1110
	[Token(Token = "0x4000456")]
	[FieldOffset(Offset = "0x20")]
	private bool stop;

	// Token: 0x04000457 RID: 1111
	[Token(Token = "0x4000457")]
	[FieldOffset(Offset = "0x28")]
	private Queue<IQueuedThreadTask> tasks;

	// Token: 0x04000458 RID: 1112
	[Token(Token = "0x4000458")]
	[FieldOffset(Offset = "0x30")]
	private string name;
}
