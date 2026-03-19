using System;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x02000541 RID: 1345
	[Token(Token = "0x2000541")]
	public enum LuaThreadStatus
	{
		// Token: 0x040023DF RID: 9183
		[Token(Token = "0x40023DF")]
		LUA_RESUME_ERROR = -1,
		// Token: 0x040023E0 RID: 9184
		[Token(Token = "0x40023E0")]
		LUA_OK,
		// Token: 0x040023E1 RID: 9185
		[Token(Token = "0x40023E1")]
		LUA_YIELD,
		// Token: 0x040023E2 RID: 9186
		[Token(Token = "0x40023E2")]
		LUA_ERRRUN,
		// Token: 0x040023E3 RID: 9187
		[Token(Token = "0x40023E3")]
		LUA_ERRSYNTAX,
		// Token: 0x040023E4 RID: 9188
		[Token(Token = "0x40023E4")]
		LUA_ERRMEM,
		// Token: 0x040023E5 RID: 9189
		[Token(Token = "0x40023E5")]
		LUA_ERRERR
	}
}
