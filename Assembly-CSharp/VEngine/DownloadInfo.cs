using System;
using Il2CppDummyDll;

namespace VEngine
{
	// Token: 0x020009CF RID: 2511
	[Token(Token = "0x20009CF")]
	[Serializable]
	public class DownloadInfo
	{
		// Token: 0x0600603D RID: 24637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600603D")]
		[Address(RVA = "0x13FDF8C", Offset = "0x13FDF8C", VA = "0x13FDF8C")]
		public DownloadInfo()
		{
		}

		// Token: 0x0400253B RID: 9531
		[Token(Token = "0x400253B")]
		[FieldOffset(Offset = "0x10")]
		public uint crc;

		// Token: 0x0400253C RID: 9532
		[Token(Token = "0x400253C")]
		[FieldOffset(Offset = "0x18")]
		public string savePath;

		// Token: 0x0400253D RID: 9533
		[Token(Token = "0x400253D")]
		[FieldOffset(Offset = "0x20")]
		public ulong size;

		// Token: 0x0400253E RID: 9534
		[Token(Token = "0x400253E")]
		[FieldOffset(Offset = "0x28")]
		public string url;

		// Token: 0x0400253F RID: 9535
		[Token(Token = "0x400253F")]
		[FieldOffset(Offset = "0x30")]
		public int resMode;
	}
}
