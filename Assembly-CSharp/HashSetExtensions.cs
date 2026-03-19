using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

// Token: 0x020000C5 RID: 197
[Token(Token = "0x20000C5")]
public static class HashSetExtensions
{
	// Token: 0x06000491 RID: 1169 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000491")]
	public static void SetCapacity<T>(this HashSet<T> hs, int capacity)
	{
	}

	// Token: 0x06000492 RID: 1170 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000492")]
	public static HashSet<T> GetHashSet<T>(int capacity)
	{
		return null;
	}

	// Token: 0x020000C6 RID: 198
	[Token(Token = "0x20000C6")]
	private static class HashSetDelegateHolder<T>
	{
		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A0")]
		public static MethodInfo InitializeMethod
		{
			[Token(Token = "0x6000493")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x04000448 RID: 1096
		[Token(Token = "0x4000448")]
		private const BindingFlags Flags = 36;
	}
}
