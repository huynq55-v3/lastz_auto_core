using System;
using Il2CppDummyDll;

namespace VEngine
{
	// Token: 0x020009E6 RID: 2534
	[Token(Token = "0x20009E6")]
	public class BundleInfo
	{
		// Token: 0x0600611E RID: 24862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600611E")]
		[Address(RVA = "0x140D4E8", Offset = "0x140D4E8", VA = "0x140D4E8")]
		public BundleInfo()
		{
		}

		// Token: 0x040025A1 RID: 9633
		[Token(Token = "0x40025A1")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x040025A2 RID: 9634
		[Token(Token = "0x40025A2")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x040025A3 RID: 9635
		[Token(Token = "0x40025A3")]
		[FieldOffset(Offset = "0x20")]
		public uint crc;

		// Token: 0x040025A4 RID: 9636
		[Token(Token = "0x40025A4")]
		[FieldOffset(Offset = "0x28")]
		public ulong size;

		// Token: 0x040025A5 RID: 9637
		[Token(Token = "0x40025A5")]
		[FieldOffset(Offset = "0x30")]
		public int resMode;

		// Token: 0x040025A6 RID: 9638
		[Token(Token = "0x40025A6")]
		[FieldOffset(Offset = "0x38")]
		public int[] assets;

		// Token: 0x040025A7 RID: 9639
		[Token(Token = "0x40025A7")]
		[FieldOffset(Offset = "0x40")]
		public int[] deps;
	}
}
