using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x020003F5 RID: 1013
	[Token(Token = "0x20003F5")]
	public sealed class SuitInfoProto : IMessage<SuitInfoProto>, IMessage, IEquatable<SuitInfoProto>, IDeepCloneable<SuitInfoProto>
	{
		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06001A11 RID: 6673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A3")]
		[DebuggerNonUserCode]
		public static MessageParser<SuitInfoProto> Parser
		{
			[Token(Token = "0x6001A11")]
			[Address(RVA = "0x20E21FC", Offset = "0x20E21FC", VA = "0x20E21FC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06001A12 RID: 6674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A4")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001A12")]
			[Address(RVA = "0x20E2254", Offset = "0x20E2254", VA = "0x20E2254")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06001A13 RID: 6675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A5")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001A13")]
			[Address(RVA = "0x20E2358", Offset = "0x20E2358", VA = "0x20E2358", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A14")]
		[Address(RVA = "0x20E23A4", Offset = "0x20E23A4", VA = "0x20E23A4")]
		[DebuggerNonUserCode]
		public SuitInfoProto()
		{
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A15")]
		[Address(RVA = "0x20E247C", Offset = "0x20E247C", VA = "0x20E247C")]
		[DebuggerNonUserCode]
		public SuitInfoProto(SuitInfoProto other)
		{
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A16")]
		[Address(RVA = "0x20E2544", Offset = "0x20E2544", VA = "0x20E2544", Slot = "10")]
		[DebuggerNonUserCode]
		public SuitInfoProto Clone()
		{
			return null;
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06001A17 RID: 6679 RVA: 0x0000A020 File Offset: 0x00008220
		// (set) Token: 0x06001A18 RID: 6680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002A6")]
		[DebuggerNonUserCode]
		public int CarIndex
		{
			[Token(Token = "0x6001A17")]
			[Address(RVA = "0x20E25A4", Offset = "0x20E25A4", VA = "0x20E25A4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001A18")]
			[Address(RVA = "0x20E25AC", Offset = "0x20E25AC", VA = "0x20E25AC")]
			set
			{
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06001A19 RID: 6681 RVA: 0x0000A038 File Offset: 0x00008238
		// (set) Token: 0x06001A1A RID: 6682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002A7")]
		[DebuggerNonUserCode]
		public int SuitType
		{
			[Token(Token = "0x6001A19")]
			[Address(RVA = "0x20E25B4", Offset = "0x20E25B4", VA = "0x20E25B4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001A1A")]
			[Address(RVA = "0x20E25BC", Offset = "0x20E25BC", VA = "0x20E25BC")]
			set
			{
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06001A1B RID: 6683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A8")]
		[DebuggerNonUserCode]
		public RepeatedField<EquipInfoProto> EquipInfos
		{
			[Token(Token = "0x6001A1B")]
			[Address(RVA = "0x20E25C4", Offset = "0x20E25C4", VA = "0x20E25C4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06001A1C RID: 6684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A9")]
		[DebuggerNonUserCode]
		public RepeatedField<HeroSkillInfoProto> SkillInfos
		{
			[Token(Token = "0x6001A1C")]
			[Address(RVA = "0x20E25CC", Offset = "0x20E25CC", VA = "0x20E25CC")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x0000A050 File Offset: 0x00008250
		[Token(Token = "0x6001A1D")]
		[Address(RVA = "0x20E25D4", Offset = "0x20E25D4", VA = "0x20E25D4", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x0000A068 File Offset: 0x00008268
		[Token(Token = "0x6001A1E")]
		[Address(RVA = "0x20E2638", Offset = "0x20E2638", VA = "0x20E2638", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SuitInfoProto other)
		{
			return default(bool);
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x0000A080 File Offset: 0x00008280
		[Token(Token = "0x6001A1F")]
		[Address(RVA = "0x20E2714", Offset = "0x20E2714", VA = "0x20E2714", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A20")]
		[Address(RVA = "0x20E27C8", Offset = "0x20E27C8", VA = "0x20E27C8", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A21")]
		[Address(RVA = "0x20E2820", Offset = "0x20E2820", VA = "0x20E2820", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x0000A098 File Offset: 0x00008298
		[Token(Token = "0x6001A22")]
		[Address(RVA = "0x20E2964", Offset = "0x20E2964", VA = "0x20E2964", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A23")]
		[Address(RVA = "0x20E2ABC", Offset = "0x20E2ABC", VA = "0x20E2ABC", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SuitInfoProto other)
		{
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A24")]
		[Address(RVA = "0x20E2B84", Offset = "0x20E2B84", VA = "0x20E2B84", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001BEE RID: 7150
		[Token(Token = "0x4001BEE")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<SuitInfoProto> _parser;

		// Token: 0x04001BEF RID: 7151
		[Token(Token = "0x4001BEF")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001BF0 RID: 7152
		[Token(Token = "0x4001BF0")]
		public const int CarIndexFieldNumber = 1;

		// Token: 0x04001BF1 RID: 7153
		[Token(Token = "0x4001BF1")]
		[FieldOffset(Offset = "0x18")]
		private int carIndex_;

		// Token: 0x04001BF2 RID: 7154
		[Token(Token = "0x4001BF2")]
		public const int SuitTypeFieldNumber = 2;

		// Token: 0x04001BF3 RID: 7155
		[Token(Token = "0x4001BF3")]
		[FieldOffset(Offset = "0x1C")]
		private int suitType_;

		// Token: 0x04001BF4 RID: 7156
		[Token(Token = "0x4001BF4")]
		public const int EquipInfosFieldNumber = 3;

		// Token: 0x04001BF5 RID: 7157
		[Token(Token = "0x4001BF5")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<EquipInfoProto> _repeated_equipInfos_codec;

		// Token: 0x04001BF6 RID: 7158
		[Token(Token = "0x4001BF6")]
		[FieldOffset(Offset = "0x20")]
		private readonly RepeatedField<EquipInfoProto> equipInfos_;

		// Token: 0x04001BF7 RID: 7159
		[Token(Token = "0x4001BF7")]
		public const int SkillInfosFieldNumber = 4;

		// Token: 0x04001BF8 RID: 7160
		[Token(Token = "0x4001BF8")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FieldCodec<HeroSkillInfoProto> _repeated_skillInfos_codec;

		// Token: 0x04001BF9 RID: 7161
		[Token(Token = "0x4001BF9")]
		[FieldOffset(Offset = "0x28")]
		private readonly RepeatedField<HeroSkillInfoProto> skillInfos_;
	}
}
