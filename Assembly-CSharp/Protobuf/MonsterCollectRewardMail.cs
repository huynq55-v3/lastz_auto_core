using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x0200045E RID: 1118
	[Token(Token = "0x200045E")]
	public sealed class MonsterCollectRewardMail : IMessage<MonsterCollectRewardMail>, IMessage, IEquatable<MonsterCollectRewardMail>, IDeepCloneable<MonsterCollectRewardMail>
	{
		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06001F51 RID: 8017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000421")]
		[DebuggerNonUserCode]
		public static MessageParser<MonsterCollectRewardMail> Parser
		{
			[Token(Token = "0x6001F51")]
			[Address(RVA = "0x25A5878", Offset = "0x25A5878", VA = "0x25A5878")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06001F52 RID: 8018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000422")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001F52")]
			[Address(RVA = "0x25A58D0", Offset = "0x25A58D0", VA = "0x25A58D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06001F53 RID: 8019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000423")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001F53")]
			[Address(RVA = "0x25A59D4", Offset = "0x25A59D4", VA = "0x25A59D4", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F54 RID: 8020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F54")]
		[Address(RVA = "0x25A5A20", Offset = "0x25A5A20", VA = "0x25A5A20")]
		[DebuggerNonUserCode]
		public MonsterCollectRewardMail()
		{
		}

		// Token: 0x06001F55 RID: 8021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F55")]
		[Address(RVA = "0x25A5A28", Offset = "0x25A5A28", VA = "0x25A5A28")]
		[DebuggerNonUserCode]
		public MonsterCollectRewardMail(MonsterCollectRewardMail other)
		{
		}

		// Token: 0x06001F56 RID: 8022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F56")]
		[Address(RVA = "0x25A5AA0", Offset = "0x25A5AA0", VA = "0x25A5AA0", Slot = "10")]
		[DebuggerNonUserCode]
		public MonsterCollectRewardMail Clone()
		{
			return null;
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001F57 RID: 8023 RVA: 0x0000BEE0 File Offset: 0x0000A0E0
		// (set) Token: 0x06001F58 RID: 8024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000424")]
		[DebuggerNonUserCode]
		public long StartTime
		{
			[Token(Token = "0x6001F57")]
			[Address(RVA = "0x25A5B00", Offset = "0x25A5B00", VA = "0x25A5B00")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6001F58")]
			[Address(RVA = "0x25A5B08", Offset = "0x25A5B08", VA = "0x25A5B08")]
			set
			{
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06001F59 RID: 8025 RVA: 0x0000BEF8 File Offset: 0x0000A0F8
		// (set) Token: 0x06001F5A RID: 8026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000425")]
		[DebuggerNonUserCode]
		public int MonsterId
		{
			[Token(Token = "0x6001F59")]
			[Address(RVA = "0x25A5B10", Offset = "0x25A5B10", VA = "0x25A5B10")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001F5A")]
			[Address(RVA = "0x25A5B18", Offset = "0x25A5B18", VA = "0x25A5B18")]
			set
			{
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06001F5B RID: 8027 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F5C RID: 8028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000426")]
		[DebuggerNonUserCode]
		public ReportRewardNeedCollect NeedCollectReward
		{
			[Token(Token = "0x6001F5B")]
			[Address(RVA = "0x25A5B20", Offset = "0x25A5B20", VA = "0x25A5B20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F5C")]
			[Address(RVA = "0x25A5B28", Offset = "0x25A5B28", VA = "0x25A5B28")]
			set
			{
			}
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x0000BF10 File Offset: 0x0000A110
		[Token(Token = "0x6001F5D")]
		[Address(RVA = "0x25A5B30", Offset = "0x25A5B30", VA = "0x25A5B30", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x0000BF28 File Offset: 0x0000A128
		[Token(Token = "0x6001F5E")]
		[Address(RVA = "0x25A5B94", Offset = "0x25A5B94", VA = "0x25A5B94", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MonsterCollectRewardMail other)
		{
			return default(bool);
		}

		// Token: 0x06001F5F RID: 8031 RVA: 0x0000BF40 File Offset: 0x0000A140
		[Token(Token = "0x6001F5F")]
		[Address(RVA = "0x25A5C14", Offset = "0x25A5C14", VA = "0x25A5C14", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001F60 RID: 8032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F60")]
		[Address(RVA = "0x25A5CAC", Offset = "0x25A5CAC", VA = "0x25A5CAC", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F61")]
		[Address(RVA = "0x25A5D04", Offset = "0x25A5D04", VA = "0x25A5D04", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x0000BF58 File Offset: 0x0000A158
		[Token(Token = "0x6001F62")]
		[Address(RVA = "0x25A5DC4", Offset = "0x25A5DC4", VA = "0x25A5DC4", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001F63 RID: 8035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F63")]
		[Address(RVA = "0x25A5EA4", Offset = "0x25A5EA4", VA = "0x25A5EA4", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MonsterCollectRewardMail other)
		{
		}

		// Token: 0x06001F64 RID: 8036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F64")]
		[Address(RVA = "0x25A5F88", Offset = "0x25A5F88", VA = "0x25A5F88", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001E79 RID: 7801
		[Token(Token = "0x4001E79")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<MonsterCollectRewardMail> _parser;

		// Token: 0x04001E7A RID: 7802
		[Token(Token = "0x4001E7A")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E7B RID: 7803
		[Token(Token = "0x4001E7B")]
		public const int StartTimeFieldNumber = 1;

		// Token: 0x04001E7C RID: 7804
		[Token(Token = "0x4001E7C")]
		[FieldOffset(Offset = "0x18")]
		private long startTime_;

		// Token: 0x04001E7D RID: 7805
		[Token(Token = "0x4001E7D")]
		public const int MonsterIdFieldNumber = 2;

		// Token: 0x04001E7E RID: 7806
		[Token(Token = "0x4001E7E")]
		[FieldOffset(Offset = "0x20")]
		private int monsterId_;

		// Token: 0x04001E7F RID: 7807
		[Token(Token = "0x4001E7F")]
		public const int NeedCollectRewardFieldNumber = 3;

		// Token: 0x04001E80 RID: 7808
		[Token(Token = "0x4001E80")]
		[FieldOffset(Offset = "0x28")]
		private ReportRewardNeedCollect needCollectReward_;
	}
}
