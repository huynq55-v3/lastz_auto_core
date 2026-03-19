using System;
using System.Collections.Concurrent;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Sfs2X.Util
{
	// Token: 0x02000A4E RID: 2638
	[Token(Token = "0x2000A4E")]
	[Il2CppEagerStaticClassConstruction]
	public static class ByteArrayPool
	{
		// Token: 0x06006437 RID: 25655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006437")]
		[Address(RVA = "0x2DFACB8", Offset = "0x2DFACB8", VA = "0x2DFACB8")]
		public static ByteArray Rent(int size = 128)
		{
			return null;
		}

		// Token: 0x06006438 RID: 25656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006438")]
		[Address(RVA = "0x2DFAD84", Offset = "0x2DFAD84", VA = "0x2DFAD84")]
		public static void Recycle(ByteArray b)
		{
		}

		// Token: 0x0400285A RID: 10330
		[Token(Token = "0x400285A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ConcurrentBag<ByteArray> Pool;
	}
}
