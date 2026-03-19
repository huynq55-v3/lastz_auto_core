using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace DevTools
{
	// Token: 0x02000D02 RID: 3330
	[Token(Token = "0x2000D02")]
	[Preserve]
	public class Description
	{
		// Token: 0x06007C9F RID: 31903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C9F")]
		[Address(RVA = "0x319F454", Offset = "0x319F454", VA = "0x319F454")]
		public Description(string description, string callstack)
		{
		}

		// Token: 0x04003897 RID: 14487
		[Token(Token = "0x4003897")]
		[FieldOffset(Offset = "0x10")]
		public string description;

		// Token: 0x04003898 RID: 14488
		[Token(Token = "0x4003898")]
		[FieldOffset(Offset = "0x18")]
		public string callstack;
	}
}
