using System;
using Il2CppDummyDll;

// Token: 0x020001F1 RID: 497
[Token(Token = "0x20001F1")]
public interface ITimer
{
	// Token: 0x170001A5 RID: 421
	// (get) Token: 0x06000D5F RID: 3423
	[Token(Token = "0x170001A5")]
	bool isCompleted
	{
		[Token(Token = "0x6000D5F")]
		get;
	}

	// Token: 0x170001A6 RID: 422
	// (get) Token: 0x06000D60 RID: 3424
	[Token(Token = "0x170001A6")]
	bool isCancelled
	{
		[Token(Token = "0x6000D60")]
		get;
	}

	// Token: 0x170001A7 RID: 423
	// (get) Token: 0x06000D61 RID: 3425
	[Token(Token = "0x170001A7")]
	bool isDone
	{
		[Token(Token = "0x6000D61")]
		get;
	}
}
