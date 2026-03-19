using System;
using Il2CppDummyDll;

namespace LuaScriptInterface
{
	// Token: 0x020003B6 RID: 950
	[Token(Token = "0x20003B6")]
	public interface UIManager
	{
		// Token: 0x060017F2 RID: 6130
		[Token(Token = "0x60017F2")]
		void OpenWindow(string uiName, params object[] args);

		// Token: 0x060017F3 RID: 6131
		[Token(Token = "0x60017F3")]
		void DestroyWindow(string uiName, params object[] args);

		// Token: 0x060017F4 RID: 6132
		[Token(Token = "0x60017F4")]
		bool IsWindowOpen(string uiName);
	}
}
