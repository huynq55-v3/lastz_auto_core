using System;
using Il2CppDummyDll;
using Sfs2X.Entities.Data;
using Sfs2X.Util;

namespace Sfs2X.Bitswarm
{
	// Token: 0x02000A9E RID: 2718
	[Token(Token = "0x2000A9E")]
	public class Message : IMessage
	{
		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x060067A9 RID: 26537 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060067AA RID: 26538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000711")]
		public ISFSObject Header
		{
			[Token(Token = "0x60067A9")]
			[Address(RVA = "0x33C92E4", Offset = "0x33C92E4", VA = "0x33C92E4", Slot = "16")]
			get
			{
				return null;
			}
			[Token(Token = "0x60067AA")]
			[Address(RVA = "0x33C92EC", Offset = "0x33C92EC", VA = "0x33C92EC", Slot = "17")]
			set
			{
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x060067AB RID: 26539 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060067AC RID: 26540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000712")]
		public ByteArray RawData
		{
			[Token(Token = "0x60067AB")]
			[Address(RVA = "0x33C92F4", Offset = "0x33C92F4", VA = "0x33C92F4", Slot = "18")]
			get
			{
				return null;
			}
			[Token(Token = "0x60067AC")]
			[Address(RVA = "0x33C92FC", Offset = "0x33C92FC", VA = "0x33C92FC", Slot = "19")]
			set
			{
			}
		}

		// Token: 0x060067AD RID: 26541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067AD")]
		[Address(RVA = "0x33C1624", Offset = "0x33C1624", VA = "0x33C1624")]
		public Message()
		{
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x060067AE RID: 26542 RVA: 0x0004C908 File Offset: 0x0004AB08
		// (set) Token: 0x060067AF RID: 26543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000713")]
		public int Id
		{
			[Token(Token = "0x60067AE")]
			[Address(RVA = "0x33C9304", Offset = "0x33C9304", VA = "0x33C9304", Slot = "4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60067AF")]
			[Address(RVA = "0x33C930C", Offset = "0x33C930C", VA = "0x33C930C", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x060067B0 RID: 26544 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060067B1 RID: 26545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000714")]
		public ISFSObject Content
		{
			[Token(Token = "0x60067B0")]
			[Address(RVA = "0x33C9314", Offset = "0x33C9314", VA = "0x33C9314", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60067B1")]
			[Address(RVA = "0x33C931C", Offset = "0x33C931C", VA = "0x33C931C", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x060067B2 RID: 26546 RVA: 0x0004C920 File Offset: 0x0004AB20
		// (set) Token: 0x060067B3 RID: 26547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000715")]
		public int TargetController
		{
			[Token(Token = "0x60067B2")]
			[Address(RVA = "0x33C9324", Offset = "0x33C9324", VA = "0x33C9324", Slot = "8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60067B3")]
			[Address(RVA = "0x33C932C", Offset = "0x33C932C", VA = "0x33C932C", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x060067B4 RID: 26548 RVA: 0x0004C938 File Offset: 0x0004AB38
		// (set) Token: 0x060067B5 RID: 26549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000716")]
		public bool IsEncrypted
		{
			[Token(Token = "0x60067B4")]
			[Address(RVA = "0x33C9334", Offset = "0x33C9334", VA = "0x33C9334", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60067B5")]
			[Address(RVA = "0x33C933C", Offset = "0x33C933C", VA = "0x33C933C", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x060067B6 RID: 26550 RVA: 0x0004C950 File Offset: 0x0004AB50
		// (set) Token: 0x060067B7 RID: 26551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000717")]
		public bool IsUDP
		{
			[Token(Token = "0x60067B6")]
			[Address(RVA = "0x33C9348", Offset = "0x33C9348", VA = "0x33C9348", Slot = "12")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60067B7")]
			[Address(RVA = "0x33C9350", Offset = "0x33C9350", VA = "0x33C9350", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x060067B8 RID: 26552 RVA: 0x0004C968 File Offset: 0x0004AB68
		// (set) Token: 0x060067B9 RID: 26553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000718")]
		public long PacketId
		{
			[Token(Token = "0x60067B8")]
			[Address(RVA = "0x33C935C", Offset = "0x33C935C", VA = "0x33C935C", Slot = "14")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60067B9")]
			[Address(RVA = "0x33C9364", Offset = "0x33C9364", VA = "0x33C9364", Slot = "15")]
			set
			{
			}
		}

		// Token: 0x060067BA RID: 26554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067BA")]
		[Address(RVA = "0x33C936C", Offset = "0x33C936C", VA = "0x33C936C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04002964 RID: 10596
		[Token(Token = "0x4002964")]
		[FieldOffset(Offset = "0x10")]
		private int id;

		// Token: 0x04002965 RID: 10597
		[Token(Token = "0x4002965")]
		[FieldOffset(Offset = "0x18")]
		private ISFSObject content;

		// Token: 0x04002966 RID: 10598
		[Token(Token = "0x4002966")]
		[FieldOffset(Offset = "0x20")]
		private int targetController;

		// Token: 0x04002967 RID: 10599
		[Token(Token = "0x4002967")]
		[FieldOffset(Offset = "0x24")]
		private bool isEncrypted;

		// Token: 0x04002968 RID: 10600
		[Token(Token = "0x4002968")]
		[FieldOffset(Offset = "0x25")]
		private bool isUDP;

		// Token: 0x04002969 RID: 10601
		[Token(Token = "0x4002969")]
		[FieldOffset(Offset = "0x28")]
		private long packetId;

		// Token: 0x0400296A RID: 10602
		[Token(Token = "0x400296A")]
		[FieldOffset(Offset = "0x30")]
		private ISFSObject header;

		// Token: 0x0400296B RID: 10603
		[Token(Token = "0x400296B")]
		[FieldOffset(Offset = "0x38")]
		private ByteArray rawData;
	}
}
