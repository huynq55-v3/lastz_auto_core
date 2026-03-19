using System;
using Il2CppDummyDll;
using LuaScriptInterface;

namespace XLua.CSObjectWrap
{
	// Token: 0x0200085F RID: 2143
	[Token(Token = "0x200085F")]
	public class LuaScriptInterfaceUIManagerBridge : LuaBase, UIManager
	{
		// Token: 0x06003BC7 RID: 15303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BC7")]
		[Address(RVA = "0x2B8F384", Offset = "0x2B8F384", VA = "0x2B8F384")]
		public static LuaBase __Create(int reference, LuaEnv luaenv)
		{
			return null;
		}

		// Token: 0x06003BC8 RID: 15304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BC8")]
		[Address(RVA = "0x2B8F3F8", Offset = "0x2B8F3F8", VA = "0x2B8F3F8")]
		public LuaScriptInterfaceUIManagerBridge(int reference, LuaEnv luaenv)
		{
		}

		// Token: 0x06003BC9 RID: 15305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BC9")]
		[Address(RVA = "0x2B8F400", Offset = "0x2B8F400", VA = "0x2B8F400", Slot = "7")]
		private void LuaScriptInterface.UIManager.OpenWindow(string uiName, object[] args)
		{
		}

		// Token: 0x06003BCA RID: 15306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BCA")]
		[Address(RVA = "0x2B8F674", Offset = "0x2B8F674", VA = "0x2B8F674", Slot = "8")]
		private void LuaScriptInterface.UIManager.DestroyWindow(string uiName, object[] args)
		{
		}

		// Token: 0x06003BCB RID: 15307 RVA: 0x00019F38 File Offset: 0x00018138
		[Token(Token = "0x6003BCB")]
		[Address(RVA = "0x2B8F8E8", Offset = "0x2B8F8E8", VA = "0x2B8F8E8", Slot = "9")]
		private bool LuaScriptInterface.UIManager.IsWindowOpen(string uiName)
		{
			return default(bool);
		}
	}
}
