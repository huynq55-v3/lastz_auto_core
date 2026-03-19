using System;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x02000521 RID: 1313
	[Token(Token = "0x2000521")]
	public abstract class LuaBase : IDisposable
	{
		// Token: 0x06002750 RID: 10064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002750")]
		[Address(RVA = "0x2B682F8", Offset = "0x2B682F8", VA = "0x2B682F8")]
		public LuaBase(int reference, LuaEnv luaenv)
		{
		}

		// Token: 0x06002751 RID: 10065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002751")]
		[Address(RVA = "0x2B6A56C", Offset = "0x2B6A56C", VA = "0x2B6A56C", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06002752 RID: 10066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002752")]
		[Address(RVA = "0x2B6A60C", Offset = "0x2B6A60C", VA = "0x2B6A60C", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06002753 RID: 10067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002753")]
		[Address(RVA = "0x2B6A678", Offset = "0x2B6A678", VA = "0x2B6A678", Slot = "5")]
		public virtual void Dispose(bool disposeManagedResources)
		{
		}

		// Token: 0x06002754 RID: 10068 RVA: 0x0000EE38 File Offset: 0x0000D038
		[Token(Token = "0x6002754")]
		[Address(RVA = "0x2B6A840", Offset = "0x2B6A840", VA = "0x2B6A840", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x0000EE50 File Offset: 0x0000D050
		[Token(Token = "0x6002755")]
		[Address(RVA = "0x2B6A9E4", Offset = "0x2B6A9E4", VA = "0x2B6A9E4", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002756")]
		[Address(RVA = "0x2B6AAAC", Offset = "0x2B6AAAC", VA = "0x2B6AAAC", Slot = "6")]
		internal virtual void push(IntPtr L)
		{
		}

		// Token: 0x04002355 RID: 9045
		[Token(Token = "0x4002355")]
		[FieldOffset(Offset = "0x10")]
		protected bool disposed;

		// Token: 0x04002356 RID: 9046
		[Token(Token = "0x4002356")]
		[FieldOffset(Offset = "0x14")]
		protected readonly int luaReference;

		// Token: 0x04002357 RID: 9047
		[Token(Token = "0x4002357")]
		[FieldOffset(Offset = "0x18")]
		protected readonly LuaEnv luaEnv;
	}
}
