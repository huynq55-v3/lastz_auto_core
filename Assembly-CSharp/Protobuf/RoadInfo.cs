using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000477 RID: 1143
	[Token(Token = "0x2000477")]
	public sealed class RoadInfo : IMessage<RoadInfo>, IMessage, IEquatable<RoadInfo>, IDeepCloneable<RoadInfo>
	{
		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x060020AC RID: 8364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700048F")]
		[DebuggerNonUserCode]
		public static MessageParser<RoadInfo> Parser
		{
			[Token(Token = "0x60020AC")]
			[Address(RVA = "0x288C8B8", Offset = "0x288C8B8", VA = "0x288C8B8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x060020AD RID: 8365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000490")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x60020AD")]
			[Address(RVA = "0x288C910", Offset = "0x288C910", VA = "0x288C910")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x060020AE RID: 8366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000491")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x60020AE")]
			[Address(RVA = "0x288CA14", Offset = "0x288CA14", VA = "0x288CA14", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020AF")]
		[Address(RVA = "0x288CA60", Offset = "0x288CA60", VA = "0x288CA60")]
		[DebuggerNonUserCode]
		public RoadInfo()
		{
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020B0")]
		[Address(RVA = "0x288CAC8", Offset = "0x288CAC8", VA = "0x288CAC8")]
		[DebuggerNonUserCode]
		public RoadInfo(RoadInfo other)
		{
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B1")]
		[Address(RVA = "0x288CB40", Offset = "0x288CB40", VA = "0x288CB40", Slot = "10")]
		[DebuggerNonUserCode]
		public RoadInfo Clone()
		{
			return null;
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x060020B2 RID: 8370 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060020B3 RID: 8371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000492")]
		[DebuggerNonUserCode]
		public string OwnerUid
		{
			[Token(Token = "0x60020B2")]
			[Address(RVA = "0x288CBA0", Offset = "0x288CBA0", VA = "0x288CBA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60020B3")]
			[Address(RVA = "0x288CBA8", Offset = "0x288CBA8", VA = "0x288CBA8")]
			set
			{
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x060020B4 RID: 8372 RVA: 0x0000C7E0 File Offset: 0x0000A9E0
		// (set) Token: 0x060020B5 RID: 8373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000493")]
		[DebuggerNonUserCode]
		public long Uuid
		{
			[Token(Token = "0x60020B4")]
			[Address(RVA = "0x288CC24", Offset = "0x288CC24", VA = "0x288CC24")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60020B5")]
			[Address(RVA = "0x288CC2C", Offset = "0x288CC2C", VA = "0x288CC2C")]
			set
			{
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x060020B6 RID: 8374 RVA: 0x0000C7F8 File Offset: 0x0000A9F8
		// (set) Token: 0x060020B7 RID: 8375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000494")]
		[DebuggerNonUserCode]
		public int RoadState
		{
			[Token(Token = "0x60020B6")]
			[Address(RVA = "0x288CC34", Offset = "0x288CC34", VA = "0x288CC34")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60020B7")]
			[Address(RVA = "0x288CC3C", Offset = "0x288CC3C", VA = "0x288CC3C")]
			set
			{
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x060020B8 RID: 8376 RVA: 0x0000C810 File Offset: 0x0000AA10
		// (set) Token: 0x060020B9 RID: 8377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000495")]
		[DebuggerNonUserCode]
		public int Inside
		{
			[Token(Token = "0x60020B8")]
			[Address(RVA = "0x288CC44", Offset = "0x288CC44", VA = "0x288CC44")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60020B9")]
			[Address(RVA = "0x288CC4C", Offset = "0x288CC4C", VA = "0x288CC4C")]
			set
			{
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x060020BA RID: 8378 RVA: 0x0000C828 File Offset: 0x0000AA28
		// (set) Token: 0x060020BB RID: 8379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000496")]
		[DebuggerNonUserCode]
		public int CurrentHp
		{
			[Token(Token = "0x60020BA")]
			[Address(RVA = "0x288CC54", Offset = "0x288CC54", VA = "0x288CC54")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60020BB")]
			[Address(RVA = "0x288CC5C", Offset = "0x288CC5C", VA = "0x288CC5C")]
			set
			{
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x060020BC RID: 8380 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060020BD RID: 8381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000497")]
		[DebuggerNonUserCode]
		public string AllianceId
		{
			[Token(Token = "0x60020BC")]
			[Address(RVA = "0x288CC64", Offset = "0x288CC64", VA = "0x288CC64")]
			get
			{
				return null;
			}
			[Token(Token = "0x60020BD")]
			[Address(RVA = "0x288CC6C", Offset = "0x288CC6C", VA = "0x288CC6C")]
			set
			{
			}
		}

		// Token: 0x060020BE RID: 8382 RVA: 0x0000C840 File Offset: 0x0000AA40
		[Token(Token = "0x60020BE")]
		[Address(RVA = "0x288CCE8", Offset = "0x288CCE8", VA = "0x288CCE8", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x060020BF RID: 8383 RVA: 0x0000C858 File Offset: 0x0000AA58
		[Token(Token = "0x60020BF")]
		[Address(RVA = "0x288CD4C", Offset = "0x288CD4C", VA = "0x288CD4C", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(RoadInfo other)
		{
			return default(bool);
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x0000C870 File Offset: 0x0000AA70
		[Token(Token = "0x60020C0")]
		[Address(RVA = "0x288CE00", Offset = "0x288CE00", VA = "0x288CE00", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060020C1 RID: 8385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C1")]
		[Address(RVA = "0x288CEFC", Offset = "0x288CEFC", VA = "0x288CEFC", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060020C2 RID: 8386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C2")]
		[Address(RVA = "0x288CF54", Offset = "0x288CF54", VA = "0x288CF54", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060020C3 RID: 8387 RVA: 0x0000C888 File Offset: 0x0000AA88
		[Token(Token = "0x60020C3")]
		[Address(RVA = "0x288D0A8", Offset = "0x288D0A8", VA = "0x288D0A8", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060020C4 RID: 8388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C4")]
		[Address(RVA = "0x288D228", Offset = "0x288D228", VA = "0x288D228", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(RoadInfo other)
		{
		}

		// Token: 0x060020C5 RID: 8389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C5")]
		[Address(RVA = "0x288D2D4", Offset = "0x288D2D4", VA = "0x288D2D4", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001F36 RID: 7990
		[Token(Token = "0x4001F36")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<RoadInfo> _parser;

		// Token: 0x04001F37 RID: 7991
		[Token(Token = "0x4001F37")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F38 RID: 7992
		[Token(Token = "0x4001F38")]
		public const int OwnerUidFieldNumber = 1;

		// Token: 0x04001F39 RID: 7993
		[Token(Token = "0x4001F39")]
		[FieldOffset(Offset = "0x18")]
		private string ownerUid_;

		// Token: 0x04001F3A RID: 7994
		[Token(Token = "0x4001F3A")]
		public const int UuidFieldNumber = 2;

		// Token: 0x04001F3B RID: 7995
		[Token(Token = "0x4001F3B")]
		[FieldOffset(Offset = "0x20")]
		private long uuid_;

		// Token: 0x04001F3C RID: 7996
		[Token(Token = "0x4001F3C")]
		public const int RoadStateFieldNumber = 3;

		// Token: 0x04001F3D RID: 7997
		[Token(Token = "0x4001F3D")]
		[FieldOffset(Offset = "0x28")]
		private int roadState_;

		// Token: 0x04001F3E RID: 7998
		[Token(Token = "0x4001F3E")]
		public const int InsideFieldNumber = 4;

		// Token: 0x04001F3F RID: 7999
		[Token(Token = "0x4001F3F")]
		[FieldOffset(Offset = "0x2C")]
		private int inside_;

		// Token: 0x04001F40 RID: 8000
		[Token(Token = "0x4001F40")]
		public const int CurrentHpFieldNumber = 5;

		// Token: 0x04001F41 RID: 8001
		[Token(Token = "0x4001F41")]
		[FieldOffset(Offset = "0x30")]
		private int currentHp_;

		// Token: 0x04001F42 RID: 8002
		[Token(Token = "0x4001F42")]
		public const int AllianceIdFieldNumber = 6;

		// Token: 0x04001F43 RID: 8003
		[Token(Token = "0x4001F43")]
		[FieldOffset(Offset = "0x38")]
		private string allianceId_;
	}
}
