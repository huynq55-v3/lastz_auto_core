using System;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Scripting;

namespace XLua
{
	// Token: 0x02000510 RID: 1296
	[Token(Token = "0x2000510")]
	[Il2CppSetOption(Option.NullChecks, false)]
	[Preserve]
	public class DelegateBridge : DelegateBridgeBase
	{
		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06002727 RID: 10023 RVA: 0x0000EDC0 File Offset: 0x0000CFC0
		[Token(Token = "0x170005D6")]
		public static bool Gen_Flag
		{
			[Token(Token = "0x6002727")]
			[Address(RVA = "0x2B6893C", Offset = "0x2B6893C", VA = "0x2B6893C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002728 RID: 10024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002728")]
		[Address(RVA = "0x2B689F0", Offset = "0x2B689F0", VA = "0x2B689F0")]
		public DelegateBridge(int reference, LuaEnv luaenv)
		{
		}

		// Token: 0x06002729 RID: 10025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002729")]
		[Address(RVA = "0x2B689F4", Offset = "0x2B689F4", VA = "0x2B689F4")]
		public void PCall(IntPtr L, int nArgs, int nResults, int errFunc)
		{
		}

		// Token: 0x0600272A RID: 10026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600272A")]
		[Address(RVA = "0x2B68BB8", Offset = "0x2B68BB8", VA = "0x2B68BB8")]
		public void Action()
		{
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600272B")]
		public void Action<T1>(T1 p1)
		{
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600272C")]
		public void Action<T1, T2>(T1 p1, T2 p2)
		{
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600272D")]
		public void Action<T1, T2, T3>(T1 p1, T2 p2, T3 p3)
		{
		}

		// Token: 0x0600272E RID: 10030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600272E")]
		public void Action<T1, T2, T3, T4>(T1 p1, T2 p2, T3 p3, T4 p4)
		{
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600272F")]
		public TResult Func<TResult>()
		{
			return null;
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002730")]
		public TResult Func<T1, TResult>(T1 p1)
		{
			return null;
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002731")]
		public TResult Func<T1, T2, TResult>(T1 p1, T2 p2)
		{
			return null;
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002732")]
		public TResult Func<T1, T2, T3, TResult>(T1 p1, T2 p2, T3 p3)
		{
			return null;
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002733")]
		public TResult Func<T1, T2, T3, T4, TResult>(T1 p1, T2 p2, T3 p3, T4 p4)
		{
			return null;
		}

		// Token: 0x04002336 RID: 9014
		[Token(Token = "0x4002336")]
		[FieldOffset(Offset = "0x0")]
		internal static DelegateBridge[] DelegateBridgeList;
	}
}
