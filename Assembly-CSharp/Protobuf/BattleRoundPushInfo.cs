using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x0200046D RID: 1133
	[Token(Token = "0x200046D")]
	public sealed class BattleRoundPushInfo : IMessage<BattleRoundPushInfo>, IMessage, IEquatable<BattleRoundPushInfo>, IDeepCloneable<BattleRoundPushInfo>
	{
		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06002005 RID: 8197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000452")]
		[DebuggerNonUserCode]
		public static MessageParser<BattleRoundPushInfo> Parser
		{
			[Token(Token = "0x6002005")]
			[Address(RVA = "0x25AC640", Offset = "0x25AC640", VA = "0x25AC640")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06002006 RID: 8198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000453")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6002006")]
			[Address(RVA = "0x25AC698", Offset = "0x25AC698", VA = "0x25AC698")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06002007 RID: 8199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000454")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6002007")]
			[Address(RVA = "0x25AC79C", Offset = "0x25AC79C", VA = "0x25AC79C", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002008")]
		[Address(RVA = "0x25AC7E8", Offset = "0x25AC7E8", VA = "0x25AC7E8")]
		[DebuggerNonUserCode]
		public BattleRoundPushInfo()
		{
		}

		// Token: 0x06002009 RID: 8201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002009")]
		[Address(RVA = "0x25AC870", Offset = "0x25AC870", VA = "0x25AC870")]
		[DebuggerNonUserCode]
		public BattleRoundPushInfo(BattleRoundPushInfo other)
		{
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600200A")]
		[Address(RVA = "0x25AC968", Offset = "0x25AC968", VA = "0x25AC968", Slot = "10")]
		[DebuggerNonUserCode]
		public BattleRoundPushInfo Clone()
		{
			return null;
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x0600200B RID: 8203 RVA: 0x0000C330 File Offset: 0x0000A530
		// (set) Token: 0x0600200C RID: 8204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000455")]
		[DebuggerNonUserCode]
		public int Type
		{
			[Token(Token = "0x600200B")]
			[Address(RVA = "0x25AC9C8", Offset = "0x25AC9C8", VA = "0x25AC9C8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600200C")]
			[Address(RVA = "0x25AC9D0", Offset = "0x25AC9D0", VA = "0x25AC9D0")]
			set
			{
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x0600200D RID: 8205 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600200E RID: 8206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000456")]
		[DebuggerNonUserCode]
		public SimpleSelfArmyInfo SimpleArmyInfo
		{
			[Token(Token = "0x600200D")]
			[Address(RVA = "0x25AC9D8", Offset = "0x25AC9D8", VA = "0x25AC9D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600200E")]
			[Address(RVA = "0x25AC9E0", Offset = "0x25AC9E0", VA = "0x25AC9E0")]
			set
			{
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x0600200F RID: 8207 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002010 RID: 8208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000457")]
		[DebuggerNonUserCode]
		public CombineSelfArmyInfo CombineArmyInfo
		{
			[Token(Token = "0x600200F")]
			[Address(RVA = "0x25AC9E8", Offset = "0x25AC9E8", VA = "0x25AC9E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002010")]
			[Address(RVA = "0x25AC9F0", Offset = "0x25AC9F0", VA = "0x25AC9F0")]
			set
			{
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06002011 RID: 8209 RVA: 0x0000C348 File Offset: 0x0000A548
		// (set) Token: 0x06002012 RID: 8210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000458")]
		[DebuggerNonUserCode]
		public bool OutRange
		{
			[Token(Token = "0x6002011")]
			[Address(RVA = "0x25AC9F8", Offset = "0x25AC9F8", VA = "0x25AC9F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002012")]
			[Address(RVA = "0x25ACA00", Offset = "0x25ACA00", VA = "0x25ACA00")]
			set
			{
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06002013 RID: 8211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000459")]
		[DebuggerNonUserCode]
		public RepeatedField<BaseRoundReportPush> RoundReports
		{
			[Token(Token = "0x6002013")]
			[Address(RVA = "0x25ACA0C", Offset = "0x25ACA0C", VA = "0x25ACA0C")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06002014 RID: 8212 RVA: 0x0000C360 File Offset: 0x0000A560
		// (set) Token: 0x06002015 RID: 8213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700045A")]
		[DebuggerNonUserCode]
		public bool SelfBesieged
		{
			[Token(Token = "0x6002014")]
			[Address(RVA = "0x25ACA14", Offset = "0x25ACA14", VA = "0x25ACA14")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002015")]
			[Address(RVA = "0x25ACA1C", Offset = "0x25ACA1C", VA = "0x25ACA1C")]
			set
			{
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06002016 RID: 8214 RVA: 0x0000C378 File Offset: 0x0000A578
		// (set) Token: 0x06002017 RID: 8215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700045B")]
		[DebuggerNonUserCode]
		public bool TargetBesieged
		{
			[Token(Token = "0x6002016")]
			[Address(RVA = "0x25ACA28", Offset = "0x25ACA28", VA = "0x25ACA28")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002017")]
			[Address(RVA = "0x25ACA30", Offset = "0x25ACA30", VA = "0x25ACA30")]
			set
			{
			}
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x0000C390 File Offset: 0x0000A590
		[Token(Token = "0x6002018")]
		[Address(RVA = "0x25ACA3C", Offset = "0x25ACA3C", VA = "0x25ACA3C", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x0000C3A8 File Offset: 0x0000A5A8
		[Token(Token = "0x6002019")]
		[Address(RVA = "0x25ACAA0", Offset = "0x25ACAA0", VA = "0x25ACAA0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BattleRoundPushInfo other)
		{
			return default(bool);
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x0000C3C0 File Offset: 0x0000A5C0
		[Token(Token = "0x600201A")]
		[Address(RVA = "0x25ACBC8", Offset = "0x25ACBC8", VA = "0x25ACBC8", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600201B")]
		[Address(RVA = "0x25ACD34", Offset = "0x25ACD34", VA = "0x25ACD34", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600201C")]
		[Address(RVA = "0x25ACD8C", Offset = "0x25ACD8C", VA = "0x25ACD8C", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x0000C3D8 File Offset: 0x0000A5D8
		[Token(Token = "0x600201D")]
		[Address(RVA = "0x25ACF4C", Offset = "0x25ACF4C", VA = "0x25ACF4C", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600201E")]
		[Address(RVA = "0x25AD0C4", Offset = "0x25AD0C4", VA = "0x25AD0C4", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BattleRoundPushInfo other)
		{
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600201F")]
		[Address(RVA = "0x25AD240", Offset = "0x25AD240", VA = "0x25AD240", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001EC7 RID: 7879
		[Token(Token = "0x4001EC7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<BattleRoundPushInfo> _parser;

		// Token: 0x04001EC8 RID: 7880
		[Token(Token = "0x4001EC8")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EC9 RID: 7881
		[Token(Token = "0x4001EC9")]
		public const int TypeFieldNumber = 1;

		// Token: 0x04001ECA RID: 7882
		[Token(Token = "0x4001ECA")]
		[FieldOffset(Offset = "0x18")]
		private int type_;

		// Token: 0x04001ECB RID: 7883
		[Token(Token = "0x4001ECB")]
		public const int SimpleArmyInfoFieldNumber = 2;

		// Token: 0x04001ECC RID: 7884
		[Token(Token = "0x4001ECC")]
		[FieldOffset(Offset = "0x20")]
		private SimpleSelfArmyInfo simpleArmyInfo_;

		// Token: 0x04001ECD RID: 7885
		[Token(Token = "0x4001ECD")]
		public const int CombineArmyInfoFieldNumber = 3;

		// Token: 0x04001ECE RID: 7886
		[Token(Token = "0x4001ECE")]
		[FieldOffset(Offset = "0x28")]
		private CombineSelfArmyInfo combineArmyInfo_;

		// Token: 0x04001ECF RID: 7887
		[Token(Token = "0x4001ECF")]
		public const int OutRangeFieldNumber = 4;

		// Token: 0x04001ED0 RID: 7888
		[Token(Token = "0x4001ED0")]
		[FieldOffset(Offset = "0x30")]
		private bool outRange_;

		// Token: 0x04001ED1 RID: 7889
		[Token(Token = "0x4001ED1")]
		public const int RoundReportsFieldNumber = 5;

		// Token: 0x04001ED2 RID: 7890
		[Token(Token = "0x4001ED2")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<BaseRoundReportPush> _repeated_roundReports_codec;

		// Token: 0x04001ED3 RID: 7891
		[Token(Token = "0x4001ED3")]
		[FieldOffset(Offset = "0x38")]
		private readonly RepeatedField<BaseRoundReportPush> roundReports_;

		// Token: 0x04001ED4 RID: 7892
		[Token(Token = "0x4001ED4")]
		public const int SelfBesiegedFieldNumber = 6;

		// Token: 0x04001ED5 RID: 7893
		[Token(Token = "0x4001ED5")]
		[FieldOffset(Offset = "0x40")]
		private bool selfBesieged_;

		// Token: 0x04001ED6 RID: 7894
		[Token(Token = "0x4001ED6")]
		public const int TargetBesiegedFieldNumber = 7;

		// Token: 0x04001ED7 RID: 7895
		[Token(Token = "0x4001ED7")]
		[FieldOffset(Offset = "0x41")]
		private bool targetBesieged_;
	}
}
