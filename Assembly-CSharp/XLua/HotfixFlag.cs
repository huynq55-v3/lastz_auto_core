using System;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x0200051A RID: 1306
	[Token(Token = "0x200051A")]
	[Flags]
	public enum HotfixFlag
	{
		// Token: 0x04002340 RID: 9024
		[Token(Token = "0x4002340")]
		Stateless = 0,
		// Token: 0x04002341 RID: 9025
		[Token(Token = "0x4002341")]
		[Obsolete("use xlua.util.state instead!", true)]
		Stateful = 1,
		// Token: 0x04002342 RID: 9026
		[Token(Token = "0x4002342")]
		ValueTypeBoxing = 2,
		// Token: 0x04002343 RID: 9027
		[Token(Token = "0x4002343")]
		IgnoreProperty = 4,
		// Token: 0x04002344 RID: 9028
		[Token(Token = "0x4002344")]
		IgnoreNotPublic = 8,
		// Token: 0x04002345 RID: 9029
		[Token(Token = "0x4002345")]
		Inline = 16,
		// Token: 0x04002346 RID: 9030
		[Token(Token = "0x4002346")]
		IntKey = 32,
		// Token: 0x04002347 RID: 9031
		[Token(Token = "0x4002347")]
		AdaptByDelegate = 64,
		// Token: 0x04002348 RID: 9032
		[Token(Token = "0x4002348")]
		IgnoreCompilerGenerated = 128,
		// Token: 0x04002349 RID: 9033
		[Token(Token = "0x4002349")]
		NoBaseProxy = 256
	}
}
