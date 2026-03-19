using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x0200050E RID: 1294
	[Token(Token = "0x200050E")]
	public abstract class DelegateBridgeBase : LuaBase
	{
		// Token: 0x06002720 RID: 10016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002720")]
		[Address(RVA = "0x2B682AC", Offset = "0x2B682AC", VA = "0x2B682AC")]
		public DelegateBridgeBase(int reference, LuaEnv luaenv)
		{
		}

		// Token: 0x06002721 RID: 10017 RVA: 0x0000ED90 File Offset: 0x0000CF90
		[Token(Token = "0x6002721")]
		[Address(RVA = "0x2B68330", Offset = "0x2B68330", VA = "0x2B68330")]
		public bool TryGetDelegate(Type key, out Delegate value)
		{
			return default(bool);
		}

		// Token: 0x06002722 RID: 10018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002722")]
		[Address(RVA = "0x2B6840C", Offset = "0x2B6840C", VA = "0x2B6840C")]
		public void AddDelegate(Type key, Delegate value)
		{
		}

		// Token: 0x06002723 RID: 10019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002723")]
		[Address(RVA = "0x2B68634", Offset = "0x2B68634", VA = "0x2B68634", Slot = "7")]
		public virtual Delegate GetDelegateByType(Type type)
		{
			return null;
		}

		// Token: 0x04002332 RID: 9010
		[Token(Token = "0x4002332")]
		[FieldOffset(Offset = "0x20")]
		private Type firstKey;

		// Token: 0x04002333 RID: 9011
		[Token(Token = "0x4002333")]
		[FieldOffset(Offset = "0x28")]
		private Delegate firstValue;

		// Token: 0x04002334 RID: 9012
		[Token(Token = "0x4002334")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<Type, Delegate> bindTo;

		// Token: 0x04002335 RID: 9013
		[Token(Token = "0x4002335")]
		[FieldOffset(Offset = "0x38")]
		protected int errorFuncRef;
	}
}
