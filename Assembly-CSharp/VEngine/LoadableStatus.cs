using System;
using Il2CppDummyDll;

namespace VEngine
{
	// Token: 0x020009DB RID: 2523
	[Token(Token = "0x20009DB")]
	public enum LoadableStatus
	{
		// Token: 0x0400256A RID: 9578
		[Token(Token = "0x400256A")]
		Wait,
		// Token: 0x0400256B RID: 9579
		[Token(Token = "0x400256B")]
		Loading,
		// Token: 0x0400256C RID: 9580
		[Token(Token = "0x400256C")]
		DependentLoading,
		// Token: 0x0400256D RID: 9581
		[Token(Token = "0x400256D")]
		SuccessToLoad,
		// Token: 0x0400256E RID: 9582
		[Token(Token = "0x400256E")]
		FailedToLoad,
		// Token: 0x0400256F RID: 9583
		[Token(Token = "0x400256F")]
		Unloaded,
		// Token: 0x04002570 RID: 9584
		[Token(Token = "0x4002570")]
		CheckVersion,
		// Token: 0x04002571 RID: 9585
		[Token(Token = "0x4002571")]
		Downloading
	}
}
