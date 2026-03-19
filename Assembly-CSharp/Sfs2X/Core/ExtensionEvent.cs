using System;
using Il2CppDummyDll;

namespace Sfs2X.Core
{
	// Token: 0x02000A7E RID: 2686
	[Token(Token = "0x2000A7E")]
	public class ExtensionEvent : BaseEvent
	{
		// Token: 0x06006690 RID: 26256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006690")]
		[Address(RVA = "0x33BDACC", Offset = "0x33BDACC", VA = "0x33BDACC")]
		public ExtensionEvent(string type, string c, object rd)
		{
		}

		// Token: 0x040028E4 RID: 10468
		[Token(Token = "0x40028E4")]
		[FieldOffset(Offset = "0x28")]
		public string cmd;

		// Token: 0x040028E5 RID: 10469
		[Token(Token = "0x40028E5")]
		[FieldOffset(Offset = "0x30")]
		public object rawData;
	}
}
