using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x0200041A RID: 1050
	[Token(Token = "0x200041A")]
	public sealed class AllReportReward : IMessage<AllReportReward>, IMessage, IEquatable<AllReportReward>, IDeepCloneable<AllReportReward>
	{
		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06001BF0 RID: 7152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000333")]
		[DebuggerNonUserCode]
		public static MessageParser<AllReportReward> Parser
		{
			[Token(Token = "0x6001BF0")]
			[Address(RVA = "0x26F694C", Offset = "0x26F694C", VA = "0x26F694C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06001BF1 RID: 7153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000334")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001BF1")]
			[Address(RVA = "0x26F69A4", Offset = "0x26F69A4", VA = "0x26F69A4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06001BF2 RID: 7154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000335")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001BF2")]
			[Address(RVA = "0x26F6AA8", Offset = "0x26F6AA8", VA = "0x26F6AA8", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BF3")]
		[Address(RVA = "0x26F6AF4", Offset = "0x26F6AF4", VA = "0x26F6AF4")]
		[DebuggerNonUserCode]
		public AllReportReward()
		{
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BF4")]
		[Address(RVA = "0x26F6AFC", Offset = "0x26F6AFC", VA = "0x26F6AFC")]
		[DebuggerNonUserCode]
		public AllReportReward(AllReportReward other)
		{
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BF5")]
		[Address(RVA = "0x26F6B70", Offset = "0x26F6B70", VA = "0x26F6B70", Slot = "10")]
		[DebuggerNonUserCode]
		public AllReportReward Clone()
		{
			return null;
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06001BF6 RID: 7158 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BF7 RID: 7159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000336")]
		[DebuggerNonUserCode]
		public ReportReward Reward
		{
			[Token(Token = "0x6001BF6")]
			[Address(RVA = "0x26F6BD0", Offset = "0x26F6BD0", VA = "0x26F6BD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BF7")]
			[Address(RVA = "0x26F6BD8", Offset = "0x26F6BD8", VA = "0x26F6BD8")]
			set
			{
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06001BF8 RID: 7160 RVA: 0x0000AB60 File Offset: 0x00008D60
		// (set) Token: 0x06001BF9 RID: 7161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000337")]
		[DebuggerNonUserCode]
		public long Uuid
		{
			[Token(Token = "0x6001BF8")]
			[Address(RVA = "0x26F6BE0", Offset = "0x26F6BE0", VA = "0x26F6BE0")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6001BF9")]
			[Address(RVA = "0x26F6BE8", Offset = "0x26F6BE8", VA = "0x26F6BE8")]
			set
			{
			}
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x0000AB78 File Offset: 0x00008D78
		[Token(Token = "0x6001BFA")]
		[Address(RVA = "0x26F6BF0", Offset = "0x26F6BF0", VA = "0x26F6BF0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x0000AB90 File Offset: 0x00008D90
		[Token(Token = "0x6001BFB")]
		[Address(RVA = "0x26F6C54", Offset = "0x26F6C54", VA = "0x26F6C54", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(AllReportReward other)
		{
			return default(bool);
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x0000ABA8 File Offset: 0x00008DA8
		[Token(Token = "0x6001BFC")]
		[Address(RVA = "0x26F6CC4", Offset = "0x26F6CC4", VA = "0x26F6CC4", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BFD")]
		[Address(RVA = "0x26F6D38", Offset = "0x26F6D38", VA = "0x26F6D38", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BFE")]
		[Address(RVA = "0x26F6D90", Offset = "0x26F6D90", VA = "0x26F6D90", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x0000ABC0 File Offset: 0x00008DC0
		[Token(Token = "0x6001BFF")]
		[Address(RVA = "0x26F6E24", Offset = "0x26F6E24", VA = "0x26F6E24", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C00")]
		[Address(RVA = "0x26F6ED8", Offset = "0x26F6ED8", VA = "0x26F6ED8", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(AllReportReward other)
		{
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C01")]
		[Address(RVA = "0x26F6FAC", Offset = "0x26F6FAC", VA = "0x26F6FAC", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001CF0 RID: 7408
		[Token(Token = "0x4001CF0")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<AllReportReward> _parser;

		// Token: 0x04001CF1 RID: 7409
		[Token(Token = "0x4001CF1")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CF2 RID: 7410
		[Token(Token = "0x4001CF2")]
		public const int RewardFieldNumber = 1;

		// Token: 0x04001CF3 RID: 7411
		[Token(Token = "0x4001CF3")]
		[FieldOffset(Offset = "0x18")]
		private ReportReward reward_;

		// Token: 0x04001CF4 RID: 7412
		[Token(Token = "0x4001CF4")]
		public const int UuidFieldNumber = 2;

		// Token: 0x04001CF5 RID: 7413
		[Token(Token = "0x4001CF5")]
		[FieldOffset(Offset = "0x20")]
		private long uuid_;
	}
}
