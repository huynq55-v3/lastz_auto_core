using System;
using Il2CppDummyDll;

namespace VEngine
{
	// Token: 0x020009D0 RID: 2512
	[Token(Token = "0x20009D0")]
	public enum DownloadStatus
	{
		// Token: 0x04002541 RID: 9537
		[Token(Token = "0x4002541")]
		Wait,
		// Token: 0x04002542 RID: 9538
		[Token(Token = "0x4002542")]
		Progressing,
		// Token: 0x04002543 RID: 9539
		[Token(Token = "0x4002543")]
		DownloadFinish,
		// Token: 0x04002544 RID: 9540
		[Token(Token = "0x4002544")]
		Success,
		// Token: 0x04002545 RID: 9541
		[Token(Token = "0x4002545")]
		Failed
	}
}
