using System;
using Il2CppDummyDll;

namespace Sfs2X.Core
{
	// Token: 0x02000A81 RID: 2689
	[Token(Token = "0x2000A81")]
	public struct PacketHeader
	{
		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06006695 RID: 26261 RVA: 0x0004C6F8 File Offset: 0x0004A8F8
		// (set) Token: 0x06006696 RID: 26262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006C9")]
		public int ExpectedLength
		{
			[Token(Token = "0x6006695")]
			[Address(RVA = "0x33BDB10", Offset = "0x33BDB10", VA = "0x33BDB10")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006696")]
			[Address(RVA = "0x33BDB18", Offset = "0x33BDB18", VA = "0x33BDB18")]
			set
			{
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06006697 RID: 26263 RVA: 0x0004C710 File Offset: 0x0004A910
		// (set) Token: 0x06006698 RID: 26264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006CA")]
		public bool Encrypted
		{
			[Token(Token = "0x6006697")]
			[Address(RVA = "0x33BDB20", Offset = "0x33BDB20", VA = "0x33BDB20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006698")]
			[Address(RVA = "0x33BDB28", Offset = "0x33BDB28", VA = "0x33BDB28")]
			set
			{
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06006699 RID: 26265 RVA: 0x0004C728 File Offset: 0x0004A928
		// (set) Token: 0x0600669A RID: 26266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006CB")]
		public bool Compressed
		{
			[Token(Token = "0x6006699")]
			[Address(RVA = "0x33BDB34", Offset = "0x33BDB34", VA = "0x33BDB34")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600669A")]
			[Address(RVA = "0x33BDB3C", Offset = "0x33BDB3C", VA = "0x33BDB3C")]
			set
			{
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x0600669B RID: 26267 RVA: 0x0004C740 File Offset: 0x0004A940
		// (set) Token: 0x0600669C RID: 26268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006CC")]
		public bool Binary
		{
			[Token(Token = "0x600669B")]
			[Address(RVA = "0x33BDB48", Offset = "0x33BDB48", VA = "0x33BDB48")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600669C")]
			[Address(RVA = "0x33BDB50", Offset = "0x33BDB50", VA = "0x33BDB50")]
			set
			{
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x0600669D RID: 26269 RVA: 0x0004C758 File Offset: 0x0004A958
		// (set) Token: 0x0600669E RID: 26270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006CD")]
		public bool BigSized
		{
			[Token(Token = "0x600669D")]
			[Address(RVA = "0x33BDB5C", Offset = "0x33BDB5C", VA = "0x33BDB5C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600669E")]
			[Address(RVA = "0x33BDB64", Offset = "0x33BDB64", VA = "0x33BDB64")]
			set
			{
			}
		}

		// Token: 0x0600669F RID: 26271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600669F")]
		[Address(RVA = "0x33BDB70", Offset = "0x33BDB70", VA = "0x33BDB70")]
		public PacketHeader(bool encrypted, bool compressed, bool bigSized)
		{
		}

		// Token: 0x060066A0 RID: 26272 RVA: 0x0004C770 File Offset: 0x0004A970
		[Token(Token = "0x60066A0")]
		[Address(RVA = "0x33BDB9C", Offset = "0x33BDB9C", VA = "0x33BDB9C")]
		public static PacketHeader FromBinary(int headerByte)
		{
			return default(PacketHeader);
		}

		// Token: 0x060066A1 RID: 26273 RVA: 0x0004C788 File Offset: 0x0004A988
		[Token(Token = "0x60066A1")]
		[Address(RVA = "0x33BDBBC", Offset = "0x33BDBBC", VA = "0x33BDBBC")]
		public byte Encode()
		{
			return 0;
		}

		// Token: 0x060066A2 RID: 26274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066A2")]
		[Address(RVA = "0x33BDC04", Offset = "0x33BDC04", VA = "0x33BDC04", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040028E6 RID: 10470
		[Token(Token = "0x40028E6")]
		[FieldOffset(Offset = "0x0")]
		private int expectedLength;

		// Token: 0x040028E7 RID: 10471
		[Token(Token = "0x40028E7")]
		[FieldOffset(Offset = "0x4")]
		private bool binary;

		// Token: 0x040028E8 RID: 10472
		[Token(Token = "0x40028E8")]
		[FieldOffset(Offset = "0x5")]
		private bool compressed;

		// Token: 0x040028E9 RID: 10473
		[Token(Token = "0x40028E9")]
		[FieldOffset(Offset = "0x6")]
		private bool encrypted;

		// Token: 0x040028EA RID: 10474
		[Token(Token = "0x40028EA")]
		[FieldOffset(Offset = "0x7")]
		private bool bigSized;
	}
}
