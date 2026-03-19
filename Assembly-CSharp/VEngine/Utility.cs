using System;
using System.IO;
using Il2CppDummyDll;

namespace VEngine
{
	// Token: 0x020009FB RID: 2555
	[Token(Token = "0x20009FB")]
	public static class Utility
	{
		// Token: 0x060061A9 RID: 25001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061A9")]
		[Address(RVA = "0x14155E4", Offset = "0x14155E4", VA = "0x14155E4")]
		public static string GetPlatformName()
		{
			return null;
		}

		// Token: 0x060061AA RID: 25002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061AA")]
		[Address(RVA = "0x14156C0", Offset = "0x14156C0", VA = "0x14156C0")]
		public static string FormatBytes(ulong bytes)
		{
			return null;
		}

		// Token: 0x060061AB RID: 25003 RVA: 0x0004B708 File Offset: 0x00049908
		[Token(Token = "0x60061AB")]
		[Address(RVA = "0x140886C", Offset = "0x140886C", VA = "0x140886C")]
		public static uint ComputeCRC32(Stream stream)
		{
			return 0U;
		}

		// Token: 0x060061AC RID: 25004 RVA: 0x0004B720 File Offset: 0x00049920
		[Token(Token = "0x60061AC")]
		[Address(RVA = "0x13FFA70", Offset = "0x13FFA70", VA = "0x13FFA70")]
		public static uint ComputeCRC32(string filename)
		{
			return 0U;
		}

		// Token: 0x040025FF RID: 9727
		[Token(Token = "0x40025FF")]
		public const string buildPath = "AssetBundles";

		// Token: 0x04002600 RID: 9728
		[Token(Token = "0x4002600")]
		public const string unsupportedPlatform = "Unsupported";

		// Token: 0x04002601 RID: 9729
		[Token(Token = "0x4002601")]
		[FieldOffset(Offset = "0x0")]
		public static int[] IntArrayEmpty;

		// Token: 0x04002602 RID: 9730
		[Token(Token = "0x4002602")]
		[FieldOffset(Offset = "0x8")]
		private static readonly double[] byteUnits;

		// Token: 0x04002603 RID: 9731
		[Token(Token = "0x4002603")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string[] byteUnitsNames;

		// Token: 0x04002604 RID: 9732
		[Token(Token = "0x4002604")]
		[FieldOffset(Offset = "0x18")]
		private static readonly CRC32 _crc32;
	}
}
