using System;
using System.Buffers;
using Il2CppDummyDll;

namespace Sfs2X.Util
{
	// Token: 0x02000A4C RID: 2636
	[Token(Token = "0x2000A4C")]
	public static class ArrayPoolHelper
	{
		// Token: 0x060063FB RID: 25595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063FB")]
		[Address(RVA = "0x2DF898C", Offset = "0x2DF898C", VA = "0x2DF898C")]
		public static byte[] SpawnByteArrayFromPool(int size)
		{
			return null;
		}

		// Token: 0x060063FC RID: 25596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063FC")]
		[Address(RVA = "0x2DF89FC", Offset = "0x2DF89FC", VA = "0x2DF89FC")]
		public static void RecycleByteArrayToPool(byte[] array)
		{
		}

		// Token: 0x04002851 RID: 10321
		[Token(Token = "0x4002851")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ArrayPool<byte> ArrayPool_byte;
	}
}
