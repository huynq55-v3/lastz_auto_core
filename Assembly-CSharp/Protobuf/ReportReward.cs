using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000418 RID: 1048
	[Token(Token = "0x2000418")]
	public sealed class ReportReward : IMessage<ReportReward>, IMessage, IEquatable<ReportReward>, IDeepCloneable<ReportReward>
	{
		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06001BD8 RID: 7128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700032B")]
		[DebuggerNonUserCode]
		public static MessageParser<ReportReward> Parser
		{
			[Token(Token = "0x6001BD8")]
			[Address(RVA = "0x26F5828", Offset = "0x26F5828", VA = "0x26F5828")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06001BD9 RID: 7129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700032C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001BD9")]
			[Address(RVA = "0x26F5880", Offset = "0x26F5880", VA = "0x26F5880")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06001BDA RID: 7130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700032D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001BDA")]
			[Address(RVA = "0x26F5984", Offset = "0x26F5984", VA = "0x26F5984", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BDB")]
		[Address(RVA = "0x26F59D0", Offset = "0x26F59D0", VA = "0x26F59D0")]
		[DebuggerNonUserCode]
		public ReportReward()
		{
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BDC")]
		[Address(RVA = "0x26F5B28", Offset = "0x26F5B28", VA = "0x26F5B28")]
		[DebuggerNonUserCode]
		public ReportReward(ReportReward other)
		{
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BDD")]
		[Address(RVA = "0x26F5C44", Offset = "0x26F5C44", VA = "0x26F5C44", Slot = "10")]
		[DebuggerNonUserCode]
		public ReportReward Clone()
		{
			return null;
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06001BDE RID: 7134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700032E")]
		[DebuggerNonUserCode]
		public RepeatedField<ReportRewardItem> RewardItems
		{
			[Token(Token = "0x6001BDE")]
			[Address(RVA = "0x26F5CA4", Offset = "0x26F5CA4", VA = "0x26F5CA4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06001BDF RID: 7135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700032F")]
		[DebuggerNonUserCode]
		public RepeatedField<ReportRewardItem> RewardResourceItems
		{
			[Token(Token = "0x6001BDF")]
			[Address(RVA = "0x26F5CAC", Offset = "0x26F5CAC", VA = "0x26F5CAC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06001BE0 RID: 7136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000330")]
		[DebuggerNonUserCode]
		public RepeatedField<ReportRewardHeroExp> RewardHeroExps
		{
			[Token(Token = "0x6001BE0")]
			[Address(RVA = "0x26F5CB4", Offset = "0x26F5CB4", VA = "0x26F5CB4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06001BE1 RID: 7137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000331")]
		[DebuggerNonUserCode]
		public RepeatedField<ReportRewardResource> RewardResources
		{
			[Token(Token = "0x6001BE1")]
			[Address(RVA = "0x26F5CBC", Offset = "0x26F5CBC", VA = "0x26F5CBC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06001BE2 RID: 7138 RVA: 0x0000AAE8 File Offset: 0x00008CE8
		// (set) Token: 0x06001BE3 RID: 7139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000332")]
		[DebuggerNonUserCode]
		public int PlunderResRate
		{
			[Token(Token = "0x6001BE2")]
			[Address(RVA = "0x26F5CC4", Offset = "0x26F5CC4", VA = "0x26F5CC4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001BE3")]
			[Address(RVA = "0x26F5CCC", Offset = "0x26F5CCC", VA = "0x26F5CCC")]
			set
			{
			}
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x0000AB00 File Offset: 0x00008D00
		[Token(Token = "0x6001BE4")]
		[Address(RVA = "0x26F5CD4", Offset = "0x26F5CD4", VA = "0x26F5CD4", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x0000AB18 File Offset: 0x00008D18
		[Token(Token = "0x6001BE5")]
		[Address(RVA = "0x26F5D38", Offset = "0x26F5D38", VA = "0x26F5D38", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ReportReward other)
		{
			return default(bool);
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x0000AB30 File Offset: 0x00008D30
		[Token(Token = "0x6001BE6")]
		[Address(RVA = "0x26F5E48", Offset = "0x26F5E48", VA = "0x26F5E48", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BE7")]
		[Address(RVA = "0x26F5F1C", Offset = "0x26F5F1C", VA = "0x26F5F1C", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001BE8 RID: 7144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BE8")]
		[Address(RVA = "0x26F5F74", Offset = "0x26F5F74", VA = "0x26F5F74", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x0000AB48 File Offset: 0x00008D48
		[Token(Token = "0x6001BE9")]
		[Address(RVA = "0x26F60E0", Offset = "0x26F60E0", VA = "0x26F60E0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BEA")]
		[Address(RVA = "0x26F6264", Offset = "0x26F6264", VA = "0x26F6264", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ReportReward other)
		{
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BEB")]
		[Address(RVA = "0x26F635C", Offset = "0x26F635C", VA = "0x26F635C", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001CDF RID: 7391
		[Token(Token = "0x4001CDF")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<ReportReward> _parser;

		// Token: 0x04001CE0 RID: 7392
		[Token(Token = "0x4001CE0")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CE1 RID: 7393
		[Token(Token = "0x4001CE1")]
		public const int RewardItemsFieldNumber = 1;

		// Token: 0x04001CE2 RID: 7394
		[Token(Token = "0x4001CE2")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<ReportRewardItem> _repeated_rewardItems_codec;

		// Token: 0x04001CE3 RID: 7395
		[Token(Token = "0x4001CE3")]
		[FieldOffset(Offset = "0x18")]
		private readonly RepeatedField<ReportRewardItem> rewardItems_;

		// Token: 0x04001CE4 RID: 7396
		[Token(Token = "0x4001CE4")]
		public const int RewardResourceItemsFieldNumber = 2;

		// Token: 0x04001CE5 RID: 7397
		[Token(Token = "0x4001CE5")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FieldCodec<ReportRewardItem> _repeated_rewardResourceItems_codec;

		// Token: 0x04001CE6 RID: 7398
		[Token(Token = "0x4001CE6")]
		[FieldOffset(Offset = "0x20")]
		private readonly RepeatedField<ReportRewardItem> rewardResourceItems_;

		// Token: 0x04001CE7 RID: 7399
		[Token(Token = "0x4001CE7")]
		public const int RewardHeroExpsFieldNumber = 3;

		// Token: 0x04001CE8 RID: 7400
		[Token(Token = "0x4001CE8")]
		[FieldOffset(Offset = "0x18")]
		private static readonly FieldCodec<ReportRewardHeroExp> _repeated_rewardHeroExps_codec;

		// Token: 0x04001CE9 RID: 7401
		[Token(Token = "0x4001CE9")]
		[FieldOffset(Offset = "0x28")]
		private readonly RepeatedField<ReportRewardHeroExp> rewardHeroExps_;

		// Token: 0x04001CEA RID: 7402
		[Token(Token = "0x4001CEA")]
		public const int RewardResourcesFieldNumber = 4;

		// Token: 0x04001CEB RID: 7403
		[Token(Token = "0x4001CEB")]
		[FieldOffset(Offset = "0x20")]
		private static readonly FieldCodec<ReportRewardResource> _repeated_rewardResources_codec;

		// Token: 0x04001CEC RID: 7404
		[Token(Token = "0x4001CEC")]
		[FieldOffset(Offset = "0x30")]
		private readonly RepeatedField<ReportRewardResource> rewardResources_;

		// Token: 0x04001CED RID: 7405
		[Token(Token = "0x4001CED")]
		public const int PlunderResRateFieldNumber = 5;

		// Token: 0x04001CEE RID: 7406
		[Token(Token = "0x4001CEE")]
		[FieldOffset(Offset = "0x38")]
		private int plunderResRate_;
	}
}
