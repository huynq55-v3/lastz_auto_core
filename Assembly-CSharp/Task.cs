using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

// Token: 0x020000D3 RID: 211
[Token(Token = "0x20000D3")]
public class Task
{
	// Token: 0x170000A2 RID: 162
	// (get) Token: 0x060005CF RID: 1487 RVA: 0x00003CD8 File Offset: 0x00001ED8
	[Token(Token = "0x170000A2")]
	public bool Running
	{
		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x2F7D620", Offset = "0x2F7D620", VA = "0x2F7D620")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000A3 RID: 163
	// (get) Token: 0x060005D0 RID: 1488 RVA: 0x00003CF0 File Offset: 0x00001EF0
	[Token(Token = "0x170000A3")]
	public bool Paused
	{
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x2F7D63C", Offset = "0x2F7D63C", VA = "0x2F7D63C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x14000001 RID: 1
	// (add) Token: 0x060005D1 RID: 1489 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x060005D2 RID: 1490 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000001")]
	public event Task.FinishedHandler Finished
	{
		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x2F7D658", Offset = "0x2F7D658", VA = "0x2F7D658")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x2F7D6F4", Offset = "0x2F7D6F4", VA = "0x2F7D6F4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x060005D3 RID: 1491 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D3")]
	[Address(RVA = "0x2F7D790", Offset = "0x2F7D790", VA = "0x2F7D790")]
	public Task(IEnumerator c, bool autoStart = true)
	{
	}

	// Token: 0x060005D4 RID: 1492 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D4")]
	[Address(RVA = "0x2F7DB0C", Offset = "0x2F7DB0C", VA = "0x2F7DB0C")]
	public void Start()
	{
	}

	// Token: 0x060005D5 RID: 1493 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D5")]
	[Address(RVA = "0x2F7DB94", Offset = "0x2F7DB94", VA = "0x2F7DB94")]
	public void Stop()
	{
	}

	// Token: 0x060005D6 RID: 1494 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D6")]
	[Address(RVA = "0x2F7DBC8", Offset = "0x2F7DBC8", VA = "0x2F7DBC8")]
	public void Pause()
	{
	}

	// Token: 0x060005D7 RID: 1495 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D7")]
	[Address(RVA = "0x2F7DBF4", Offset = "0x2F7DBF4", VA = "0x2F7DBF4")]
	public void Unpause()
	{
	}

	// Token: 0x060005D8 RID: 1496 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D8")]
	[Address(RVA = "0x2F7DC18", Offset = "0x2F7DC18", VA = "0x2F7DC18")]
	private void TaskFinished(bool manual)
	{
	}

	// Token: 0x04000469 RID: 1129
	[Token(Token = "0x4000469")]
	[FieldOffset(Offset = "0x18")]
	private TaskManager.TaskState task;

	// Token: 0x020000D4 RID: 212
	// (Invoke) Token: 0x060005DA RID: 1498
	[Token(Token = "0x20000D4")]
	public delegate void FinishedHandler(bool manual);
}
