using System;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x0200053F RID: 1343
	[Token(Token = "0x200053F")]
	public enum LuaTypes
	{
		// Token: 0x040023CB RID: 9163
		[Token(Token = "0x40023CB")]
		LUA_TNONE = -1,
		// Token: 0x040023CC RID: 9164
		[Token(Token = "0x40023CC")]
		LUA_TNIL,
		// Token: 0x040023CD RID: 9165
		[Token(Token = "0x40023CD")]
		LUA_TNUMBER = 3,
		// Token: 0x040023CE RID: 9166
		[Token(Token = "0x40023CE")]
		LUA_TSTRING,
		// Token: 0x040023CF RID: 9167
		[Token(Token = "0x40023CF")]
		LUA_TBOOLEAN = 1,
		// Token: 0x040023D0 RID: 9168
		[Token(Token = "0x40023D0")]
		LUA_TTABLE = 5,
		// Token: 0x040023D1 RID: 9169
		[Token(Token = "0x40023D1")]
		LUA_TFUNCTION,
		// Token: 0x040023D2 RID: 9170
		[Token(Token = "0x40023D2")]
		LUA_TUSERDATA,
		// Token: 0x040023D3 RID: 9171
		[Token(Token = "0x40023D3")]
		LUA_TTHREAD,
		// Token: 0x040023D4 RID: 9172
		[Token(Token = "0x40023D4")]
		LUA_TLIGHTUSERDATA = 2
	}
}
