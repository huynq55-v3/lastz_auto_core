using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000450 RID: 1104
	[Token(Token = "0x2000450")]
	public sealed class BattleReport : IMessage<BattleReport>, IMessage, IEquatable<BattleReport>, IDeepCloneable<BattleReport>
	{
		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06001EA1 RID: 7841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003EF")]
		[DebuggerNonUserCode]
		public static MessageParser<BattleReport> Parser
		{
			[Token(Token = "0x6001EA1")]
			[Address(RVA = "0x259FC18", Offset = "0x259FC18", VA = "0x259FC18")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06001EA2 RID: 7842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F0")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001EA2")]
			[Address(RVA = "0x259FC70", Offset = "0x259FC70", VA = "0x259FC70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06001EA3 RID: 7843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F1")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001EA3")]
			[Address(RVA = "0x259FD74", Offset = "0x259FD74", VA = "0x259FD74", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA4")]
		[Address(RVA = "0x259FDC0", Offset = "0x259FDC0", VA = "0x259FDC0")]
		[DebuggerNonUserCode]
		public BattleReport()
		{
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA5")]
		[Address(RVA = "0x259FEE8", Offset = "0x259FEE8", VA = "0x259FEE8")]
		[DebuggerNonUserCode]
		public BattleReport(BattleReport other)
		{
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EA6")]
		[Address(RVA = "0x25A0050", Offset = "0x25A0050", VA = "0x25A0050", Slot = "10")]
		[DebuggerNonUserCode]
		public BattleReport Clone()
		{
			return null;
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06001EA7 RID: 7847 RVA: 0x0000BAA8 File Offset: 0x00009CA8
		// (set) Token: 0x06001EA8 RID: 7848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F2")]
		[DebuggerNonUserCode]
		public int BattleResult
		{
			[Token(Token = "0x6001EA7")]
			[Address(RVA = "0x25A00B0", Offset = "0x25A00B0", VA = "0x25A00B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001EA8")]
			[Address(RVA = "0x25A00B8", Offset = "0x25A00B8", VA = "0x25A00B8")]
			set
			{
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06001EA9 RID: 7849 RVA: 0x0000BAC0 File Offset: 0x00009CC0
		// (set) Token: 0x06001EAA RID: 7850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F3")]
		[DebuggerNonUserCode]
		public long StartTime
		{
			[Token(Token = "0x6001EA9")]
			[Address(RVA = "0x25A00C0", Offset = "0x25A00C0", VA = "0x25A00C0")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6001EAA")]
			[Address(RVA = "0x25A00C8", Offset = "0x25A00C8", VA = "0x25A00C8")]
			set
			{
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06001EAB RID: 7851 RVA: 0x0000BAD8 File Offset: 0x00009CD8
		// (set) Token: 0x06001EAC RID: 7852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F4")]
		[DebuggerNonUserCode]
		public int StartRound
		{
			[Token(Token = "0x6001EAB")]
			[Address(RVA = "0x25A00D0", Offset = "0x25A00D0", VA = "0x25A00D0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001EAC")]
			[Address(RVA = "0x25A00D8", Offset = "0x25A00D8", VA = "0x25A00D8")]
			set
			{
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06001EAD RID: 7853 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001EAE RID: 7854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F5")]
		[DebuggerNonUserCode]
		public BattlePointInfo BattlePointInfo
		{
			[Token(Token = "0x6001EAD")]
			[Address(RVA = "0x25A00E0", Offset = "0x25A00E0", VA = "0x25A00E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EAE")]
			[Address(RVA = "0x25A00E8", Offset = "0x25A00E8", VA = "0x25A00E8")]
			set
			{
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06001EAF RID: 7855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F6")]
		[DebuggerNonUserCode]
		public RepeatedField<FightReport> FightReports
		{
			[Token(Token = "0x6001EAF")]
			[Address(RVA = "0x25A00F0", Offset = "0x25A00F0", VA = "0x25A00F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06001EB0 RID: 7856 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001EB1 RID: 7857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F7")]
		[DebuggerNonUserCode]
		public FightLost FightLost
		{
			[Token(Token = "0x6001EB0")]
			[Address(RVA = "0x25A00F8", Offset = "0x25A00F8", VA = "0x25A00F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EB1")]
			[Address(RVA = "0x25A0100", Offset = "0x25A0100", VA = "0x25A0100")]
			set
			{
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06001EB2 RID: 7858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F8")]
		[DebuggerNonUserCode]
		public RepeatedField<BattleEffectGroup> SelfBattleEffectGroups
		{
			[Token(Token = "0x6001EB2")]
			[Address(RVA = "0x25A0108", Offset = "0x25A0108", VA = "0x25A0108")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06001EB3 RID: 7859 RVA: 0x0000BAF0 File Offset: 0x00009CF0
		// (set) Token: 0x06001EB4 RID: 7860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F9")]
		[DebuggerNonUserCode]
		public int Version
		{
			[Token(Token = "0x6001EB3")]
			[Address(RVA = "0x25A0110", Offset = "0x25A0110", VA = "0x25A0110")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001EB4")]
			[Address(RVA = "0x25A0118", Offset = "0x25A0118", VA = "0x25A0118")]
			set
			{
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06001EB5 RID: 7861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003FA")]
		[DebuggerNonUserCode]
		public RepeatedField<AllFightLost> AllFightLost
		{
			[Token(Token = "0x6001EB5")]
			[Address(RVA = "0x25A0120", Offset = "0x25A0120", VA = "0x25A0120")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06001EB6 RID: 7862 RVA: 0x0000BB08 File Offset: 0x00009D08
		// (set) Token: 0x06001EB7 RID: 7863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003FB")]
		[DebuggerNonUserCode]
		public int MarchType
		{
			[Token(Token = "0x6001EB6")]
			[Address(RVA = "0x25A0128", Offset = "0x25A0128", VA = "0x25A0128")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001EB7")]
			[Address(RVA = "0x25A0130", Offset = "0x25A0130", VA = "0x25A0130")]
			set
			{
			}
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x0000BB20 File Offset: 0x00009D20
		[Token(Token = "0x6001EB8")]
		[Address(RVA = "0x25A0138", Offset = "0x25A0138", VA = "0x25A0138", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x0000BB38 File Offset: 0x00009D38
		[Token(Token = "0x6001EB9")]
		[Address(RVA = "0x25A019C", Offset = "0x25A019C", VA = "0x25A019C", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BattleReport other)
		{
			return default(bool);
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x0000BB50 File Offset: 0x00009D50
		[Token(Token = "0x6001EBA")]
		[Address(RVA = "0x25A02FC", Offset = "0x25A02FC", VA = "0x25A02FC", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EBB")]
		[Address(RVA = "0x25A0450", Offset = "0x25A0450", VA = "0x25A0450", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EBC")]
		[Address(RVA = "0x25A04A8", Offset = "0x25A04A8", VA = "0x25A04A8", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x0000BB68 File Offset: 0x00009D68
		[Token(Token = "0x6001EBD")]
		[Address(RVA = "0x25A0724", Offset = "0x25A0724", VA = "0x25A0724", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EBE")]
		[Address(RVA = "0x25A09AC", Offset = "0x25A09AC", VA = "0x25A09AC", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BattleReport other)
		{
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EBF")]
		[Address(RVA = "0x25A0B88", Offset = "0x25A0B88", VA = "0x25A0B88", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001E22 RID: 7714
		[Token(Token = "0x4001E22")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<BattleReport> _parser;

		// Token: 0x04001E23 RID: 7715
		[Token(Token = "0x4001E23")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E24 RID: 7716
		[Token(Token = "0x4001E24")]
		public const int BattleResultFieldNumber = 1;

		// Token: 0x04001E25 RID: 7717
		[Token(Token = "0x4001E25")]
		[FieldOffset(Offset = "0x18")]
		private int battleResult_;

		// Token: 0x04001E26 RID: 7718
		[Token(Token = "0x4001E26")]
		public const int StartTimeFieldNumber = 2;

		// Token: 0x04001E27 RID: 7719
		[Token(Token = "0x4001E27")]
		[FieldOffset(Offset = "0x20")]
		private long startTime_;

		// Token: 0x04001E28 RID: 7720
		[Token(Token = "0x4001E28")]
		public const int StartRoundFieldNumber = 3;

		// Token: 0x04001E29 RID: 7721
		[Token(Token = "0x4001E29")]
		[FieldOffset(Offset = "0x28")]
		private int startRound_;

		// Token: 0x04001E2A RID: 7722
		[Token(Token = "0x4001E2A")]
		public const int BattlePointInfoFieldNumber = 4;

		// Token: 0x04001E2B RID: 7723
		[Token(Token = "0x4001E2B")]
		[FieldOffset(Offset = "0x30")]
		private BattlePointInfo battlePointInfo_;

		// Token: 0x04001E2C RID: 7724
		[Token(Token = "0x4001E2C")]
		public const int FightReportsFieldNumber = 5;

		// Token: 0x04001E2D RID: 7725
		[Token(Token = "0x4001E2D")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<FightReport> _repeated_fightReports_codec;

		// Token: 0x04001E2E RID: 7726
		[Token(Token = "0x4001E2E")]
		[FieldOffset(Offset = "0x38")]
		private readonly RepeatedField<FightReport> fightReports_;

		// Token: 0x04001E2F RID: 7727
		[Token(Token = "0x4001E2F")]
		public const int FightLostFieldNumber = 6;

		// Token: 0x04001E30 RID: 7728
		[Token(Token = "0x4001E30")]
		[FieldOffset(Offset = "0x40")]
		private FightLost fightLost_;

		// Token: 0x04001E31 RID: 7729
		[Token(Token = "0x4001E31")]
		public const int SelfBattleEffectGroupsFieldNumber = 7;

		// Token: 0x04001E32 RID: 7730
		[Token(Token = "0x4001E32")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FieldCodec<BattleEffectGroup> _repeated_selfBattleEffectGroups_codec;

		// Token: 0x04001E33 RID: 7731
		[Token(Token = "0x4001E33")]
		[FieldOffset(Offset = "0x48")]
		private readonly RepeatedField<BattleEffectGroup> selfBattleEffectGroups_;

		// Token: 0x04001E34 RID: 7732
		[Token(Token = "0x4001E34")]
		public const int VersionFieldNumber = 8;

		// Token: 0x04001E35 RID: 7733
		[Token(Token = "0x4001E35")]
		[FieldOffset(Offset = "0x50")]
		private int version_;

		// Token: 0x04001E36 RID: 7734
		[Token(Token = "0x4001E36")]
		public const int AllFightLostFieldNumber = 9;

		// Token: 0x04001E37 RID: 7735
		[Token(Token = "0x4001E37")]
		[FieldOffset(Offset = "0x18")]
		private static readonly FieldCodec<AllFightLost> _repeated_allFightLost_codec;

		// Token: 0x04001E38 RID: 7736
		[Token(Token = "0x4001E38")]
		[FieldOffset(Offset = "0x58")]
		private readonly RepeatedField<AllFightLost> allFightLost_;

		// Token: 0x04001E39 RID: 7737
		[Token(Token = "0x4001E39")]
		public const int MarchTypeFieldNumber = 10;

		// Token: 0x04001E3A RID: 7738
		[Token(Token = "0x4001E3A")]
		[FieldOffset(Offset = "0x60")]
		private int marchType_;
	}
}
