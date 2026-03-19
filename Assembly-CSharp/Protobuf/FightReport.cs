using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x0200043E RID: 1086
	[Token(Token = "0x200043E")]
	public sealed class FightReport : IMessage<FightReport>, IMessage, IEquatable<FightReport>, IDeepCloneable<FightReport>
	{
		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06001DCB RID: 7627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B6")]
		[DebuggerNonUserCode]
		public static MessageParser<FightReport> Parser
		{
			[Token(Token = "0x6001DCB")]
			[Address(RVA = "0x2599398", Offset = "0x2599398", VA = "0x2599398")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06001DCC RID: 7628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B7")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001DCC")]
			[Address(RVA = "0x25993F0", Offset = "0x25993F0", VA = "0x25993F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06001DCD RID: 7629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B8")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001DCD")]
			[Address(RVA = "0x25994F4", Offset = "0x25994F4", VA = "0x25994F4", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DCE")]
		[Address(RVA = "0x2599540", Offset = "0x2599540", VA = "0x2599540")]
		[DebuggerNonUserCode]
		public FightReport()
		{
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DCF")]
		[Address(RVA = "0x2599668", Offset = "0x2599668", VA = "0x2599668")]
		[DebuggerNonUserCode]
		public FightReport(FightReport other)
		{
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DD0")]
		[Address(RVA = "0x2599838", Offset = "0x2599838", VA = "0x2599838", Slot = "10")]
		[DebuggerNonUserCode]
		public FightReport Clone()
		{
			return null;
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06001DD1 RID: 7633 RVA: 0x0000B5E0 File Offset: 0x000097E0
		// (set) Token: 0x06001DD2 RID: 7634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B9")]
		[DebuggerNonUserCode]
		public long Uuid
		{
			[Token(Token = "0x6001DD1")]
			[Address(RVA = "0x2599898", Offset = "0x2599898", VA = "0x2599898")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6001DD2")]
			[Address(RVA = "0x25998A0", Offset = "0x25998A0", VA = "0x25998A0")]
			set
			{
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06001DD3 RID: 7635 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001DD4 RID: 7636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003BA")]
		[DebuggerNonUserCode]
		public ReportPlayerInfo SelfInfo
		{
			[Token(Token = "0x6001DD3")]
			[Address(RVA = "0x25998A8", Offset = "0x25998A8", VA = "0x25998A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DD4")]
			[Address(RVA = "0x25998B0", Offset = "0x25998B0", VA = "0x25998B0")]
			set
			{
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06001DD5 RID: 7637 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001DD6 RID: 7638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003BB")]
		[DebuggerNonUserCode]
		public ReportPlayerInfo OtherInfo
		{
			[Token(Token = "0x6001DD5")]
			[Address(RVA = "0x25998B8", Offset = "0x25998B8", VA = "0x25998B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DD6")]
			[Address(RVA = "0x25998C0", Offset = "0x25998C0", VA = "0x25998C0")]
			set
			{
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06001DD7 RID: 7639 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001DD8 RID: 7640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003BC")]
		[DebuggerNonUserCode]
		public ArmyResult SelfArmyResult
		{
			[Token(Token = "0x6001DD7")]
			[Address(RVA = "0x25998C8", Offset = "0x25998C8", VA = "0x25998C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DD8")]
			[Address(RVA = "0x25998D0", Offset = "0x25998D0", VA = "0x25998D0")]
			set
			{
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06001DD9 RID: 7641 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001DDA RID: 7642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003BD")]
		[DebuggerNonUserCode]
		public ArmyResult OtherArmyResult
		{
			[Token(Token = "0x6001DD9")]
			[Address(RVA = "0x25998D8", Offset = "0x25998D8", VA = "0x25998D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DDA")]
			[Address(RVA = "0x25998E0", Offset = "0x25998E0", VA = "0x25998E0")]
			set
			{
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06001DDB RID: 7643 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001DDC RID: 7644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003BE")]
		[DebuggerNonUserCode]
		public ReportReward Reward
		{
			[Token(Token = "0x6001DDB")]
			[Address(RVA = "0x25998E8", Offset = "0x25998E8", VA = "0x25998E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DDC")]
			[Address(RVA = "0x25998F0", Offset = "0x25998F0", VA = "0x25998F0")]
			set
			{
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06001DDD RID: 7645 RVA: 0x0000B5F8 File Offset: 0x000097F8
		// (set) Token: 0x06001DDE RID: 7646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003BF")]
		[DebuggerNonUserCode]
		public int FightResult
		{
			[Token(Token = "0x6001DDD")]
			[Address(RVA = "0x25998F8", Offset = "0x25998F8", VA = "0x25998F8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001DDE")]
			[Address(RVA = "0x2599900", Offset = "0x2599900", VA = "0x2599900")]
			set
			{
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06001DDF RID: 7647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C0")]
		[DebuggerNonUserCode]
		public RepeatedField<BattleEffectGroup> OtherBattleEffectGroups
		{
			[Token(Token = "0x6001DDF")]
			[Address(RVA = "0x2599908", Offset = "0x2599908", VA = "0x2599908")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001DE0 RID: 7648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C1")]
		[DebuggerNonUserCode]
		public RepeatedField<UnitAttrInfo> UnitAttrInfo
		{
			[Token(Token = "0x6001DE0")]
			[Address(RVA = "0x2599910", Offset = "0x2599910", VA = "0x2599910")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001DE1 RID: 7649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C2")]
		[DebuggerNonUserCode]
		public RepeatedField<AllReportReward> AllRewards
		{
			[Token(Token = "0x6001DE1")]
			[Address(RVA = "0x2599918", Offset = "0x2599918", VA = "0x2599918")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x0000B610 File Offset: 0x00009810
		[Token(Token = "0x6001DE2")]
		[Address(RVA = "0x2599920", Offset = "0x2599920", VA = "0x2599920", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x0000B628 File Offset: 0x00009828
		[Token(Token = "0x6001DE3")]
		[Address(RVA = "0x2599984", Offset = "0x2599984", VA = "0x2599984", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FightReport other)
		{
			return default(bool);
		}

		// Token: 0x06001DE4 RID: 7652 RVA: 0x0000B640 File Offset: 0x00009840
		[Token(Token = "0x6001DE4")]
		[Address(RVA = "0x2599AF0", Offset = "0x2599AF0", VA = "0x2599AF0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DE5")]
		[Address(RVA = "0x2599C48", Offset = "0x2599C48", VA = "0x2599C48", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DE6")]
		[Address(RVA = "0x2599CA0", Offset = "0x2599CA0", VA = "0x2599CA0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001DE7 RID: 7655 RVA: 0x0000B658 File Offset: 0x00009858
		[Token(Token = "0x6001DE7")]
		[Address(RVA = "0x2599EF4", Offset = "0x2599EF4", VA = "0x2599EF4", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001DE8 RID: 7656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DE8")]
		[Address(RVA = "0x259A164", Offset = "0x259A164", VA = "0x259A164", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FightReport other)
		{
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DE9")]
		[Address(RVA = "0x259A42C", Offset = "0x259A42C", VA = "0x259A42C", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001DC3 RID: 7619
		[Token(Token = "0x4001DC3")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<FightReport> _parser;

		// Token: 0x04001DC4 RID: 7620
		[Token(Token = "0x4001DC4")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DC5 RID: 7621
		[Token(Token = "0x4001DC5")]
		public const int UuidFieldNumber = 1;

		// Token: 0x04001DC6 RID: 7622
		[Token(Token = "0x4001DC6")]
		[FieldOffset(Offset = "0x18")]
		private long uuid_;

		// Token: 0x04001DC7 RID: 7623
		[Token(Token = "0x4001DC7")]
		public const int SelfInfoFieldNumber = 2;

		// Token: 0x04001DC8 RID: 7624
		[Token(Token = "0x4001DC8")]
		[FieldOffset(Offset = "0x20")]
		private ReportPlayerInfo selfInfo_;

		// Token: 0x04001DC9 RID: 7625
		[Token(Token = "0x4001DC9")]
		public const int OtherInfoFieldNumber = 3;

		// Token: 0x04001DCA RID: 7626
		[Token(Token = "0x4001DCA")]
		[FieldOffset(Offset = "0x28")]
		private ReportPlayerInfo otherInfo_;

		// Token: 0x04001DCB RID: 7627
		[Token(Token = "0x4001DCB")]
		public const int SelfArmyResultFieldNumber = 4;

		// Token: 0x04001DCC RID: 7628
		[Token(Token = "0x4001DCC")]
		[FieldOffset(Offset = "0x30")]
		private ArmyResult selfArmyResult_;

		// Token: 0x04001DCD RID: 7629
		[Token(Token = "0x4001DCD")]
		public const int OtherArmyResultFieldNumber = 5;

		// Token: 0x04001DCE RID: 7630
		[Token(Token = "0x4001DCE")]
		[FieldOffset(Offset = "0x38")]
		private ArmyResult otherArmyResult_;

		// Token: 0x04001DCF RID: 7631
		[Token(Token = "0x4001DCF")]
		public const int RewardFieldNumber = 6;

		// Token: 0x04001DD0 RID: 7632
		[Token(Token = "0x4001DD0")]
		[FieldOffset(Offset = "0x40")]
		private ReportReward reward_;

		// Token: 0x04001DD1 RID: 7633
		[Token(Token = "0x4001DD1")]
		public const int FightResultFieldNumber = 7;

		// Token: 0x04001DD2 RID: 7634
		[Token(Token = "0x4001DD2")]
		[FieldOffset(Offset = "0x48")]
		private int fightResult_;

		// Token: 0x04001DD3 RID: 7635
		[Token(Token = "0x4001DD3")]
		public const int OtherBattleEffectGroupsFieldNumber = 8;

		// Token: 0x04001DD4 RID: 7636
		[Token(Token = "0x4001DD4")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<BattleEffectGroup> _repeated_otherBattleEffectGroups_codec;

		// Token: 0x04001DD5 RID: 7637
		[Token(Token = "0x4001DD5")]
		[FieldOffset(Offset = "0x50")]
		private readonly RepeatedField<BattleEffectGroup> otherBattleEffectGroups_;

		// Token: 0x04001DD6 RID: 7638
		[Token(Token = "0x4001DD6")]
		public const int UnitAttrInfoFieldNumber = 9;

		// Token: 0x04001DD7 RID: 7639
		[Token(Token = "0x4001DD7")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FieldCodec<UnitAttrInfo> _repeated_unitAttrInfo_codec;

		// Token: 0x04001DD8 RID: 7640
		[Token(Token = "0x4001DD8")]
		[FieldOffset(Offset = "0x58")]
		private readonly RepeatedField<UnitAttrInfo> unitAttrInfo_;

		// Token: 0x04001DD9 RID: 7641
		[Token(Token = "0x4001DD9")]
		public const int AllRewardsFieldNumber = 10;

		// Token: 0x04001DDA RID: 7642
		[Token(Token = "0x4001DDA")]
		[FieldOffset(Offset = "0x18")]
		private static readonly FieldCodec<AllReportReward> _repeated_allRewards_codec;

		// Token: 0x04001DDB RID: 7643
		[Token(Token = "0x4001DDB")]
		[FieldOffset(Offset = "0x60")]
		private readonly RepeatedField<AllReportReward> allRewards_;
	}
}
