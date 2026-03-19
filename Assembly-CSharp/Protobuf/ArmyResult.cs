using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x0200043C RID: 1084
	[Token(Token = "0x200043C")]
	public sealed class ArmyResult : IMessage<ArmyResult>, IMessage, IEquatable<ArmyResult>, IDeepCloneable<ArmyResult>
	{
		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06001D9F RID: 7583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A6")]
		[DebuggerNonUserCode]
		public static MessageParser<ArmyResult> Parser
		{
			[Token(Token = "0x6001D9F")]
			[Address(RVA = "0x2702CE0", Offset = "0x2702CE0", VA = "0x2702CE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06001DA0 RID: 7584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A7")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001DA0")]
			[Address(RVA = "0x2702D38", Offset = "0x2702D38", VA = "0x2702D38")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06001DA1 RID: 7585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A8")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001DA1")]
			[Address(RVA = "0x2702E3C", Offset = "0x2702E3C", VA = "0x2702E3C", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DA2")]
		[Address(RVA = "0x2702E88", Offset = "0x2702E88", VA = "0x2702E88")]
		[DebuggerNonUserCode]
		public ArmyResult()
		{
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DA3")]
		[Address(RVA = "0x2702E90", Offset = "0x2702E90", VA = "0x2702E90")]
		[DebuggerNonUserCode]
		public ArmyResult(ArmyResult other)
		{
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DA4")]
		[Address(RVA = "0x2703070", Offset = "0x2703070", VA = "0x2703070", Slot = "10")]
		[DebuggerNonUserCode]
		public ArmyResult Clone()
		{
			return null;
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06001DA5 RID: 7589 RVA: 0x0000B550 File Offset: 0x00009750
		// (set) Token: 0x06001DA6 RID: 7590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A9")]
		[DebuggerNonUserCode]
		public int Type
		{
			[Token(Token = "0x6001DA5")]
			[Address(RVA = "0x27030D0", Offset = "0x27030D0", VA = "0x27030D0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001DA6")]
			[Address(RVA = "0x27030D8", Offset = "0x27030D8", VA = "0x27030D8")]
			set
			{
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x0000B568 File Offset: 0x00009768
		// (set) Token: 0x06001DA8 RID: 7592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003AA")]
		[DebuggerNonUserCode]
		public bool IsDefeat
		{
			[Token(Token = "0x6001DA7")]
			[Address(RVA = "0x27030E0", Offset = "0x27030E0", VA = "0x27030E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001DA8")]
			[Address(RVA = "0x27030E8", Offset = "0x27030E8", VA = "0x27030E8")]
			set
			{
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06001DA9 RID: 7593 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001DAA RID: 7594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003AB")]
		[DebuggerNonUserCode]
		public BuildArmyResult BuildArmyResult
		{
			[Token(Token = "0x6001DA9")]
			[Address(RVA = "0x27030F4", Offset = "0x27030F4", VA = "0x27030F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DAA")]
			[Address(RVA = "0x27030FC", Offset = "0x27030FC", VA = "0x27030FC")]
			set
			{
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06001DAB RID: 7595 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001DAC RID: 7596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003AC")]
		[DebuggerNonUserCode]
		public CityArmyResult CityArmyResult
		{
			[Token(Token = "0x6001DAB")]
			[Address(RVA = "0x2703104", Offset = "0x2703104", VA = "0x2703104")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DAC")]
			[Address(RVA = "0x270310C", Offset = "0x270310C", VA = "0x270310C")]
			set
			{
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06001DAD RID: 7597 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001DAE RID: 7598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003AD")]
		[DebuggerNonUserCode]
		public ArmyResultBase SimpleArmyResult
		{
			[Token(Token = "0x6001DAD")]
			[Address(RVA = "0x2703114", Offset = "0x2703114", VA = "0x2703114")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DAE")]
			[Address(RVA = "0x270311C", Offset = "0x270311C", VA = "0x270311C")]
			set
			{
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06001DAF RID: 7599 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001DB0 RID: 7600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003AE")]
		[DebuggerNonUserCode]
		public MonsterArmyResult MonsterArmyResult
		{
			[Token(Token = "0x6001DAF")]
			[Address(RVA = "0x2703124", Offset = "0x2703124", VA = "0x2703124")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DB0")]
			[Address(RVA = "0x270312C", Offset = "0x270312C", VA = "0x270312C")]
			set
			{
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06001DB1 RID: 7601 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001DB2 RID: 7602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003AF")]
		[DebuggerNonUserCode]
		public AllianceCityArmyResult AllianceCityArmyResult
		{
			[Token(Token = "0x6001DB1")]
			[Address(RVA = "0x2703134", Offset = "0x2703134", VA = "0x2703134")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DB2")]
			[Address(RVA = "0x270313C", Offset = "0x270313C", VA = "0x270313C")]
			set
			{
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06001DB3 RID: 7603 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001DB4 RID: 7604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B0")]
		[DebuggerNonUserCode]
		public PveArmyResult PveArmyResult
		{
			[Token(Token = "0x6001DB3")]
			[Address(RVA = "0x2703144", Offset = "0x2703144", VA = "0x2703144")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DB4")]
			[Address(RVA = "0x270314C", Offset = "0x270314C", VA = "0x270314C")]
			set
			{
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06001DB5 RID: 7605 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001DB6 RID: 7606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B1")]
		[DebuggerNonUserCode]
		public DesertArmyResult DesertArmyResult
		{
			[Token(Token = "0x6001DB5")]
			[Address(RVA = "0x2703154", Offset = "0x2703154", VA = "0x2703154")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DB6")]
			[Address(RVA = "0x270315C", Offset = "0x270315C", VA = "0x270315C")]
			set
			{
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001DB7 RID: 7607 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001DB8 RID: 7608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B2")]
		[DebuggerNonUserCode]
		public AllianceBuildArmyResult AllianceBuildArmyResult
		{
			[Token(Token = "0x6001DB7")]
			[Address(RVA = "0x2703164", Offset = "0x2703164", VA = "0x2703164")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DB8")]
			[Address(RVA = "0x270316C", Offset = "0x270316C", VA = "0x270316C")]
			set
			{
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06001DB9 RID: 7609 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001DBA RID: 7610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B3")]
		[DebuggerNonUserCode]
		public NpcCityArmyResult NpcCityArmyResult
		{
			[Token(Token = "0x6001DB9")]
			[Address(RVA = "0x2703174", Offset = "0x2703174", VA = "0x2703174")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DBA")]
			[Address(RVA = "0x270317C", Offset = "0x270317C", VA = "0x270317C")]
			set
			{
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06001DBB RID: 7611 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001DBC RID: 7612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B4")]
		[DebuggerNonUserCode]
		public DragonBuildArmyResult DragonBuildingArmyResult
		{
			[Token(Token = "0x6001DBB")]
			[Address(RVA = "0x2703184", Offset = "0x2703184", VA = "0x2703184")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DBC")]
			[Address(RVA = "0x270318C", Offset = "0x270318C", VA = "0x270318C")]
			set
			{
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06001DBD RID: 7613 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001DBE RID: 7614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B5")]
		[DebuggerNonUserCode]
		public CrossThroneBuildArmyResult CrossThroneBuildArmyResult
		{
			[Token(Token = "0x6001DBD")]
			[Address(RVA = "0x2703194", Offset = "0x2703194", VA = "0x2703194")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DBE")]
			[Address(RVA = "0x270319C", Offset = "0x270319C", VA = "0x270319C")]
			set
			{
			}
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x0000B580 File Offset: 0x00009780
		[Token(Token = "0x6001DBF")]
		[Address(RVA = "0x27031A4", Offset = "0x27031A4", VA = "0x27031A4", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x0000B598 File Offset: 0x00009798
		[Token(Token = "0x6001DC0")]
		[Address(RVA = "0x2703208", Offset = "0x2703208", VA = "0x2703208", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ArmyResult other)
		{
			return default(bool);
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x0000B5B0 File Offset: 0x000097B0
		[Token(Token = "0x6001DC1")]
		[Address(RVA = "0x2703360", Offset = "0x2703360", VA = "0x2703360", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DC2")]
		[Address(RVA = "0x2703520", Offset = "0x2703520", VA = "0x2703520", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC3")]
		[Address(RVA = "0x2703578", Offset = "0x2703578", VA = "0x2703578", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x0000B5C8 File Offset: 0x000097C8
		[Token(Token = "0x6001DC4")]
		[Address(RVA = "0x27037F0", Offset = "0x27037F0", VA = "0x27037F0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC5")]
		[Address(RVA = "0x2703A74", Offset = "0x2703A74", VA = "0x2703A74", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ArmyResult other)
		{
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC6")]
		[Address(RVA = "0x2703F10", Offset = "0x2703F10", VA = "0x2703F10", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001DA6 RID: 7590
		[Token(Token = "0x4001DA6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<ArmyResult> _parser;

		// Token: 0x04001DA7 RID: 7591
		[Token(Token = "0x4001DA7")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DA8 RID: 7592
		[Token(Token = "0x4001DA8")]
		public const int TypeFieldNumber = 1;

		// Token: 0x04001DA9 RID: 7593
		[Token(Token = "0x4001DA9")]
		[FieldOffset(Offset = "0x18")]
		private int type_;

		// Token: 0x04001DAA RID: 7594
		[Token(Token = "0x4001DAA")]
		public const int IsDefeatFieldNumber = 2;

		// Token: 0x04001DAB RID: 7595
		[Token(Token = "0x4001DAB")]
		[FieldOffset(Offset = "0x1C")]
		private bool isDefeat_;

		// Token: 0x04001DAC RID: 7596
		[Token(Token = "0x4001DAC")]
		public const int BuildArmyResultFieldNumber = 3;

		// Token: 0x04001DAD RID: 7597
		[Token(Token = "0x4001DAD")]
		[FieldOffset(Offset = "0x20")]
		private BuildArmyResult buildArmyResult_;

		// Token: 0x04001DAE RID: 7598
		[Token(Token = "0x4001DAE")]
		public const int CityArmyResultFieldNumber = 4;

		// Token: 0x04001DAF RID: 7599
		[Token(Token = "0x4001DAF")]
		[FieldOffset(Offset = "0x28")]
		private CityArmyResult cityArmyResult_;

		// Token: 0x04001DB0 RID: 7600
		[Token(Token = "0x4001DB0")]
		public const int SimpleArmyResultFieldNumber = 5;

		// Token: 0x04001DB1 RID: 7601
		[Token(Token = "0x4001DB1")]
		[FieldOffset(Offset = "0x30")]
		private ArmyResultBase simpleArmyResult_;

		// Token: 0x04001DB2 RID: 7602
		[Token(Token = "0x4001DB2")]
		public const int MonsterArmyResultFieldNumber = 6;

		// Token: 0x04001DB3 RID: 7603
		[Token(Token = "0x4001DB3")]
		[FieldOffset(Offset = "0x38")]
		private MonsterArmyResult monsterArmyResult_;

		// Token: 0x04001DB4 RID: 7604
		[Token(Token = "0x4001DB4")]
		public const int AllianceCityArmyResultFieldNumber = 7;

		// Token: 0x04001DB5 RID: 7605
		[Token(Token = "0x4001DB5")]
		[FieldOffset(Offset = "0x40")]
		private AllianceCityArmyResult allianceCityArmyResult_;

		// Token: 0x04001DB6 RID: 7606
		[Token(Token = "0x4001DB6")]
		public const int PveArmyResultFieldNumber = 8;

		// Token: 0x04001DB7 RID: 7607
		[Token(Token = "0x4001DB7")]
		[FieldOffset(Offset = "0x48")]
		private PveArmyResult pveArmyResult_;

		// Token: 0x04001DB8 RID: 7608
		[Token(Token = "0x4001DB8")]
		public const int DesertArmyResultFieldNumber = 9;

		// Token: 0x04001DB9 RID: 7609
		[Token(Token = "0x4001DB9")]
		[FieldOffset(Offset = "0x50")]
		private DesertArmyResult desertArmyResult_;

		// Token: 0x04001DBA RID: 7610
		[Token(Token = "0x4001DBA")]
		public const int AllianceBuildArmyResultFieldNumber = 10;

		// Token: 0x04001DBB RID: 7611
		[Token(Token = "0x4001DBB")]
		[FieldOffset(Offset = "0x58")]
		private AllianceBuildArmyResult allianceBuildArmyResult_;

		// Token: 0x04001DBC RID: 7612
		[Token(Token = "0x4001DBC")]
		public const int NpcCityArmyResultFieldNumber = 11;

		// Token: 0x04001DBD RID: 7613
		[Token(Token = "0x4001DBD")]
		[FieldOffset(Offset = "0x60")]
		private NpcCityArmyResult npcCityArmyResult_;

		// Token: 0x04001DBE RID: 7614
		[Token(Token = "0x4001DBE")]
		public const int DragonBuildingArmyResultFieldNumber = 12;

		// Token: 0x04001DBF RID: 7615
		[Token(Token = "0x4001DBF")]
		[FieldOffset(Offset = "0x68")]
		private DragonBuildArmyResult dragonBuildingArmyResult_;

		// Token: 0x04001DC0 RID: 7616
		[Token(Token = "0x4001DC0")]
		public const int CrossThroneBuildArmyResultFieldNumber = 13;

		// Token: 0x04001DC1 RID: 7617
		[Token(Token = "0x4001DC1")]
		[FieldOffset(Offset = "0x70")]
		private CrossThroneBuildArmyResult crossThroneBuildArmyResult_;
	}
}
