using System;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Scripting;

namespace XLua
{
	// Token: 0x02000527 RID: 1319
	[Token(Token = "0x2000527")]
	[Il2CppSetOption(Option.NullChecks, false)]
	[Preserve]
	public class LuaFunction : LuaBase
	{
		// Token: 0x0600277A RID: 10106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600277A")]
		[Address(RVA = "0x2B6CA48", Offset = "0x2B6CA48", VA = "0x2B6CA48")]
		public LuaFunction(int reference, LuaEnv luaenv)
		{
		}

		// Token: 0x0600277B RID: 10107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600277B")]
		public void Action<T>(T a)
		{
		}

		// Token: 0x0600277C RID: 10108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600277C")]
		public TResult Func<T, TResult>(T a)
		{
			return null;
		}

		// Token: 0x0600277D RID: 10109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600277D")]
		public void Action<T1, T2>(T1 a1, T2 a2)
		{
		}

		// Token: 0x0600277E RID: 10110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600277E")]
		public TResult Func<T1, T2, TResult>(T1 a1, T2 a2)
		{
			return null;
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600277F")]
		[Address(RVA = "0x2B6CA80", Offset = "0x2B6CA80", VA = "0x2B6CA80")]
		public object[] Call(object[] args, Type[] returnTypes)
		{
			return null;
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002780")]
		[Address(RVA = "0x2B6CC2C", Offset = "0x2B6CC2C", VA = "0x2B6CC2C")]
		public object[] Call(params object[] args)
		{
			return null;
		}

		// Token: 0x06002781 RID: 10113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002781")]
		public T Cast<T>()
		{
			return null;
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002782")]
		[Address(RVA = "0x2B6CC34", Offset = "0x2B6CC34", VA = "0x2B6CC34")]
		public void SetEnv(LuaTable env)
		{
		}

		// Token: 0x06002783 RID: 10115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002783")]
		[Address(RVA = "0x2B6CCF4", Offset = "0x2B6CCF4", VA = "0x2B6CCF4", Slot = "6")]
		internal override void push(IntPtr L)
		{
		}

		// Token: 0x06002784 RID: 10116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002784")]
		[Address(RVA = "0x2B6CD60", Offset = "0x2B6CD60", VA = "0x2B6CD60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002785 RID: 10117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002785")]
		[Address(RVA = "0x2B6CDBC", Offset = "0x2B6CDBC", VA = "0x2B6CDBC")]
		public Delegate Cast(Type delType)
		{
			return null;
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002786")]
		[Address(RVA = "0x2B6CFA4", Offset = "0x2B6CFA4", VA = "0x2B6CFA4")]
		public LuaBuildData CallReturnBuildingData(long uuid, int itemId)
		{
			return null;
		}

		// Token: 0x06002787 RID: 10119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002787")]
		[Address(RVA = "0x2B6D298", Offset = "0x2B6D298", VA = "0x2B6D298")]
		public void CallForPushTable(string cmd, LuaTable table)
		{
		}

		// Token: 0x06002788 RID: 10120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002788")]
		[Address(RVA = "0x2B6D450", Offset = "0x2B6D450", VA = "0x2B6D450")]
		public void CallForPushTable(string cmd, LuaStackTable table)
		{
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002789")]
		public T Call<T>(params object[] args)
		{
			return null;
		}
	}
}
