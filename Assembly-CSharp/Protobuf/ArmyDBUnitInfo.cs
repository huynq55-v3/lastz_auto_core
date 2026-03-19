using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000405 RID: 1029
	[Token(Token = "0x2000405")]
	public sealed class ArmyDBUnitInfo : IMessage<ArmyDBUnitInfo>, IMessage, IEquatable<ArmyDBUnitInfo>, IDeepCloneable<ArmyDBUnitInfo>
	{
		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06001ADC RID: 6876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E1")]
		[DebuggerNonUserCode]
		public static MessageParser<ArmyDBUnitInfo> Parser
		{
			[Token(Token = "0x6001ADC")]
			[Address(RVA = "0x20E9804", Offset = "0x20E9804", VA = "0x20E9804")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06001ADD RID: 6877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E2")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001ADD")]
			[Address(RVA = "0x20E985C", Offset = "0x20E985C", VA = "0x20E985C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06001ADE RID: 6878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E3")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001ADE")]
			[Address(RVA = "0x20E9960", Offset = "0x20E9960", VA = "0x20E9960", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ADF")]
		[Address(RVA = "0x20E99AC", Offset = "0x20E99AC", VA = "0x20E99AC")]
		[DebuggerNonUserCode]
		public ArmyDBUnitInfo()
		{
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AE0")]
		[Address(RVA = "0x20E9B00", Offset = "0x20E9B00", VA = "0x20E9B00")]
		[DebuggerNonUserCode]
		public ArmyDBUnitInfo(ArmyDBUnitInfo other)
		{
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE1")]
		[Address(RVA = "0x20E9C34", Offset = "0x20E9C34", VA = "0x20E9C34", Slot = "10")]
		[DebuggerNonUserCode]
		public ArmyDBUnitInfo Clone()
		{
			return null;
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06001AE2 RID: 6882 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001AE3 RID: 6883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002E4")]
		[DebuggerNonUserCode]
		public string Uid
		{
			[Token(Token = "0x6001AE2")]
			[Address(RVA = "0x20E9C94", Offset = "0x20E9C94", VA = "0x20E9C94")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AE3")]
			[Address(RVA = "0x20E9C9C", Offset = "0x20E9C9C", VA = "0x20E9C9C")]
			set
			{
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06001AE4 RID: 6884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E5")]
		[DebuggerNonUserCode]
		public RepeatedField<SoldierProto> Soldiers
		{
			[Token(Token = "0x6001AE4")]
			[Address(RVA = "0x20E9D18", Offset = "0x20E9D18", VA = "0x20E9D18")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06001AE5 RID: 6885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E6")]
		[DebuggerNonUserCode]
		public RepeatedField<HeroInfoProto> Heroes
		{
			[Token(Token = "0x6001AE5")]
			[Address(RVA = "0x20E9D20", Offset = "0x20E9D20", VA = "0x20E9D20")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06001AE6 RID: 6886 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001AE7 RID: 6887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002E7")]
		[DebuggerNonUserCode]
		public ArmyUnitEffectInfoProto EffectInfo
		{
			[Token(Token = "0x6001AE6")]
			[Address(RVA = "0x20E9D28", Offset = "0x20E9D28", VA = "0x20E9D28")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AE7")]
			[Address(RVA = "0x20E9D30", Offset = "0x20E9D30", VA = "0x20E9D30")]
			set
			{
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06001AE8 RID: 6888 RVA: 0x0000A4D0 File Offset: 0x000086D0
		// (set) Token: 0x06001AE9 RID: 6889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002E8")]
		[DebuggerNonUserCode]
		public int FormationIndex
		{
			[Token(Token = "0x6001AE8")]
			[Address(RVA = "0x20E9D38", Offset = "0x20E9D38", VA = "0x20E9D38")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001AE9")]
			[Address(RVA = "0x20E9D40", Offset = "0x20E9D40", VA = "0x20E9D40")]
			set
			{
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06001AEA RID: 6890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E9")]
		[DebuggerNonUserCode]
		public RepeatedField<SuitInfoProto> Suits
		{
			[Token(Token = "0x6001AEA")]
			[Address(RVA = "0x20E9D48", Offset = "0x20E9D48", VA = "0x20E9D48")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x0000A4E8 File Offset: 0x000086E8
		[Token(Token = "0x6001AEB")]
		[Address(RVA = "0x20E9D50", Offset = "0x20E9D50", VA = "0x20E9D50", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x0000A500 File Offset: 0x00008700
		[Token(Token = "0x6001AEC")]
		[Address(RVA = "0x20E9DB4", Offset = "0x20E9DB4", VA = "0x20E9DB4", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ArmyDBUnitInfo other)
		{
			return default(bool);
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x0000A518 File Offset: 0x00008718
		[Token(Token = "0x6001AED")]
		[Address(RVA = "0x20E9ED4", Offset = "0x20E9ED4", VA = "0x20E9ED4", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AEE")]
		[Address(RVA = "0x20E9FC0", Offset = "0x20E9FC0", VA = "0x20E9FC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AEF")]
		[Address(RVA = "0x20EA018", Offset = "0x20EA018", VA = "0x20EA018", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x0000A530 File Offset: 0x00008730
		[Token(Token = "0x6001AF0")]
		[Address(RVA = "0x20EA1D8", Offset = "0x20EA1D8", VA = "0x20EA1D8", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF1")]
		[Address(RVA = "0x20EA3AC", Offset = "0x20EA3AC", VA = "0x20EA3AC", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ArmyDBUnitInfo other)
		{
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF2")]
		[Address(RVA = "0x20EA510", Offset = "0x20EA510", VA = "0x20EA510", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001C63 RID: 7267
		[Token(Token = "0x4001C63")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<ArmyDBUnitInfo> _parser;

		// Token: 0x04001C64 RID: 7268
		[Token(Token = "0x4001C64")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C65 RID: 7269
		[Token(Token = "0x4001C65")]
		public const int UidFieldNumber = 1;

		// Token: 0x04001C66 RID: 7270
		[Token(Token = "0x4001C66")]
		[FieldOffset(Offset = "0x18")]
		private string uid_;

		// Token: 0x04001C67 RID: 7271
		[Token(Token = "0x4001C67")]
		public const int SoldiersFieldNumber = 2;

		// Token: 0x04001C68 RID: 7272
		[Token(Token = "0x4001C68")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<SoldierProto> _repeated_soldiers_codec;

		// Token: 0x04001C69 RID: 7273
		[Token(Token = "0x4001C69")]
		[FieldOffset(Offset = "0x20")]
		private readonly RepeatedField<SoldierProto> soldiers_;

		// Token: 0x04001C6A RID: 7274
		[Token(Token = "0x4001C6A")]
		public const int HeroesFieldNumber = 3;

		// Token: 0x04001C6B RID: 7275
		[Token(Token = "0x4001C6B")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FieldCodec<HeroInfoProto> _repeated_heroes_codec;

		// Token: 0x04001C6C RID: 7276
		[Token(Token = "0x4001C6C")]
		[FieldOffset(Offset = "0x28")]
		private readonly RepeatedField<HeroInfoProto> heroes_;

		// Token: 0x04001C6D RID: 7277
		[Token(Token = "0x4001C6D")]
		public const int EffectInfoFieldNumber = 4;

		// Token: 0x04001C6E RID: 7278
		[Token(Token = "0x4001C6E")]
		[FieldOffset(Offset = "0x30")]
		private ArmyUnitEffectInfoProto effectInfo_;

		// Token: 0x04001C6F RID: 7279
		[Token(Token = "0x4001C6F")]
		public const int FormationIndexFieldNumber = 5;

		// Token: 0x04001C70 RID: 7280
		[Token(Token = "0x4001C70")]
		[FieldOffset(Offset = "0x38")]
		private int formationIndex_;

		// Token: 0x04001C71 RID: 7281
		[Token(Token = "0x4001C71")]
		public const int SuitsFieldNumber = 6;

		// Token: 0x04001C72 RID: 7282
		[Token(Token = "0x4001C72")]
		[FieldOffset(Offset = "0x18")]
		private static readonly FieldCodec<SuitInfoProto> _repeated_suits_codec;

		// Token: 0x04001C73 RID: 7283
		[Token(Token = "0x4001C73")]
		[FieldOffset(Offset = "0x40")]
		private readonly RepeatedField<SuitInfoProto> suits_;
	}
}
