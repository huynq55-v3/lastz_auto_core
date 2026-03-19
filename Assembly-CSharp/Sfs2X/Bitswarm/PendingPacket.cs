using System;
using Il2CppDummyDll;
using Sfs2X.Core;
using Sfs2X.Util;

namespace Sfs2X.Bitswarm
{
	// Token: 0x02000AA1 RID: 2721
	[Token(Token = "0x2000AA1")]
	public struct PendingPacket
	{
		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x060067BB RID: 26555 RVA: 0x0004C980 File Offset: 0x0004AB80
		// (set) Token: 0x060067BC RID: 26556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000719")]
		public PacketHeader Header
		{
			[Token(Token = "0x60067BB")]
			[Address(RVA = "0x33C94E8", Offset = "0x33C94E8", VA = "0x33C94E8")]
			get
			{
				return default(PacketHeader);
			}
			[Token(Token = "0x60067BC")]
			[Address(RVA = "0x33C94F0", Offset = "0x33C94F0", VA = "0x33C94F0")]
			set
			{
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x060067BD RID: 26557 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060067BE RID: 26558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700071A")]
		public ByteArray Buffer
		{
			[Token(Token = "0x60067BD")]
			[Address(RVA = "0x33C94F8", Offset = "0x33C94F8", VA = "0x33C94F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60067BE")]
			[Address(RVA = "0x33C9500", Offset = "0x33C9500", VA = "0x33C9500")]
			set
			{
			}
		}

		// Token: 0x0400297A RID: 10618
		[Token(Token = "0x400297A")]
		[FieldOffset(Offset = "0x0")]
		private PacketHeader header;

		// Token: 0x0400297B RID: 10619
		[Token(Token = "0x400297B")]
		[FieldOffset(Offset = "0x8")]
		private ByteArray buffer;
	}
}
