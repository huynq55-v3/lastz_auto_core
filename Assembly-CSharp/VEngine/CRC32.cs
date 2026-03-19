using System;
using System.IO;
using Il2CppDummyDll;

namespace VEngine
{
	// Token: 0x020009F9 RID: 2553
	[Token(Token = "0x20009F9")]
	public class CRC32
	{
		// Token: 0x06006198 RID: 24984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006198")]
		[Address(RVA = "0x1413BD0", Offset = "0x1413BD0", VA = "0x1413BD0")]
		internal CRC32()
		{
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06006199 RID: 24985 RVA: 0x0004B660 File Offset: 0x00049860
		[Token(Token = "0x17000633")]
		internal uint crc
		{
			[Token(Token = "0x6006199")]
			[Address(RVA = "0x1413EF8", Offset = "0x1413EF8", VA = "0x1413EF8")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x0600619A RID: 24986 RVA: 0x0004B678 File Offset: 0x00049878
		[Token(Token = "0x600619A")]
		[Address(RVA = "0x1413F04", Offset = "0x1413F04", VA = "0x1413F04")]
		internal uint Compute(Stream stream)
		{
			return 0U;
		}

		// Token: 0x0600619B RID: 24987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600619B")]
		[Address(RVA = "0x1413FDC", Offset = "0x1413FDC", VA = "0x1413FDC")]
		internal void Accumulate(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x0600619C RID: 24988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600619C")]
		[Address(RVA = "0x14140D8", Offset = "0x14140D8", VA = "0x14140D8")]
		internal void ClearCrc()
		{
		}

		// Token: 0x0600619D RID: 24989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600619D")]
		[Address(RVA = "0x1413D10", Offset = "0x1413D10", VA = "0x1413D10")]
		private static void PrepareTable()
		{
		}

		// Token: 0x0600619E RID: 24990 RVA: 0x0004B690 File Offset: 0x00049890
		[Token(Token = "0x600619E")]
		[Address(RVA = "0x14140E4", Offset = "0x14140E4", VA = "0x14140E4")]
		private static bool GetBit(byte bitOrdinal, uint data)
		{
			return default(bool);
		}

		// Token: 0x0600619F RID: 24991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600619F")]
		[Address(RVA = "0x14140F8", Offset = "0x14140F8", VA = "0x14140F8")]
		private static void SetBit(byte bitOrdinal, ref uint data, bool value)
		{
		}

		// Token: 0x040025FA RID: 9722
		[Token(Token = "0x40025FA")]
		private const uint _initialResidueValue = 4294967295U;

		// Token: 0x040025FB RID: 9723
		[Token(Token = "0x40025FB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly object _globalSync;

		// Token: 0x040025FC RID: 9724
		[Token(Token = "0x40025FC")]
		[FieldOffset(Offset = "0x8")]
		private static uint[] _crc32Table;

		// Token: 0x040025FD RID: 9725
		[Token(Token = "0x40025FD")]
		[FieldOffset(Offset = "0x10")]
		private static readonly byte[][] _maskingBitTable;

		// Token: 0x040025FE RID: 9726
		[Token(Token = "0x40025FE")]
		[FieldOffset(Offset = "0x10")]
		private uint _residue;
	}
}
