using System;
using Il2CppDummyDll;

namespace UnityGameFramework.Runtime
{
	// Token: 0x020004B0 RID: 1200
	[Token(Token = "0x20004B0")]
	public enum EventPoolMode
	{
		// Token: 0x040020ED RID: 8429
		[Token(Token = "0x40020ED")]
		Default,
		// Token: 0x040020EE RID: 8430
		[Token(Token = "0x40020EE")]
		AllowNoHandler,
		// Token: 0x040020EF RID: 8431
		[Token(Token = "0x40020EF")]
		AllowMultiHandler,
		// Token: 0x040020F0 RID: 8432
		[Token(Token = "0x40020F0")]
		AllowDuplicateHandler = 4
	}
}
