using System;
using System.IO;
using Il2CppDummyDll;

namespace Google.Protobuf
{
	// Token: 0x02000B25 RID: 2853
	[Token(Token = "0x2000B25")]
	internal sealed class LimitedInputStream : Stream
	{
		// Token: 0x06006CCF RID: 27855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CCF")]
		[Address(RVA = "0x36EF544", Offset = "0x36EF544", VA = "0x36EF544")]
		internal LimitedInputStream(Stream proxied, int size)
		{
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06006CD0 RID: 27856 RVA: 0x0004EA20 File Offset: 0x0004CC20
		[Token(Token = "0x170007E2")]
		public override bool CanRead
		{
			[Token(Token = "0x6006CD0")]
			[Address(RVA = "0x36EF5C4", Offset = "0x36EF5C4", VA = "0x36EF5C4", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06006CD1 RID: 27857 RVA: 0x0004EA38 File Offset: 0x0004CC38
		[Token(Token = "0x170007E3")]
		public override bool CanSeek
		{
			[Token(Token = "0x6006CD1")]
			[Address(RVA = "0x36EF5CC", Offset = "0x36EF5CC", VA = "0x36EF5CC", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06006CD2 RID: 27858 RVA: 0x0004EA50 File Offset: 0x0004CC50
		[Token(Token = "0x170007E4")]
		public override bool CanWrite
		{
			[Token(Token = "0x6006CD2")]
			[Address(RVA = "0x36EF5D4", Offset = "0x36EF5D4", VA = "0x36EF5D4", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006CD3 RID: 27859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CD3")]
		[Address(RVA = "0x36EF5DC", Offset = "0x36EF5DC", VA = "0x36EF5DC", Slot = "22")]
		public override void Flush()
		{
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06006CD4 RID: 27860 RVA: 0x0004EA68 File Offset: 0x0004CC68
		[Token(Token = "0x170007E5")]
		public override long Length
		{
			[Token(Token = "0x6006CD4")]
			[Address(RVA = "0x36EF5E0", Offset = "0x36EF5E0", VA = "0x36EF5E0", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06006CD5 RID: 27861 RVA: 0x0004EA80 File Offset: 0x0004CC80
		// (set) Token: 0x06006CD6 RID: 27862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007E6")]
		public override long Position
		{
			[Token(Token = "0x6006CD5")]
			[Address(RVA = "0x36EF620", Offset = "0x36EF620", VA = "0x36EF620", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6006CD6")]
			[Address(RVA = "0x36EF660", Offset = "0x36EF660", VA = "0x36EF660", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x06006CD7 RID: 27863 RVA: 0x0004EA98 File Offset: 0x0004CC98
		[Token(Token = "0x6006CD7")]
		[Address(RVA = "0x36EF6A0", Offset = "0x36EF6A0", VA = "0x36EF6A0", Slot = "34")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x06006CD8 RID: 27864 RVA: 0x0004EAB0 File Offset: 0x0004CCB0
		[Token(Token = "0x6006CD8")]
		[Address(RVA = "0x36EF768", Offset = "0x36EF768", VA = "0x36EF768", Slot = "32")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x06006CD9 RID: 27865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CD9")]
		[Address(RVA = "0x36EF7A8", Offset = "0x36EF7A8", VA = "0x36EF7A8", Slot = "33")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x06006CDA RID: 27866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CDA")]
		[Address(RVA = "0x36EF7E8", Offset = "0x36EF7E8", VA = "0x36EF7E8", Slot = "37")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x04002BCC RID: 11212
		[Token(Token = "0x4002BCC")]
		[FieldOffset(Offset = "0x28")]
		private readonly Stream proxied;

		// Token: 0x04002BCD RID: 11213
		[Token(Token = "0x4002BCD")]
		[FieldOffset(Offset = "0x30")]
		private int bytesLeft;
	}
}
