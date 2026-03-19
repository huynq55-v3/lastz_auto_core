using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000416 RID: 1046
	[Token(Token = "0x2000416")]
	public sealed class ReportRewardHeroExp : IMessage<ReportRewardHeroExp>, IMessage, IEquatable<ReportRewardHeroExp>, IDeepCloneable<ReportRewardHeroExp>
	{
		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06001BBA RID: 7098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000322")]
		[DebuggerNonUserCode]
		public static MessageParser<ReportRewardHeroExp> Parser
		{
			[Token(Token = "0x6001BBA")]
			[Address(RVA = "0x26F4D00", Offset = "0x26F4D00", VA = "0x26F4D00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06001BBB RID: 7099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000323")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001BBB")]
			[Address(RVA = "0x26F4D58", Offset = "0x26F4D58", VA = "0x26F4D58")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06001BBC RID: 7100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000324")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001BBC")]
			[Address(RVA = "0x26F4E5C", Offset = "0x26F4E5C", VA = "0x26F4E5C", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BBD")]
		[Address(RVA = "0x26F4EA8", Offset = "0x26F4EA8", VA = "0x26F4EA8")]
		[DebuggerNonUserCode]
		public ReportRewardHeroExp()
		{
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BBE")]
		[Address(RVA = "0x26F4EB0", Offset = "0x26F4EB0", VA = "0x26F4EB0")]
		[DebuggerNonUserCode]
		public ReportRewardHeroExp(ReportRewardHeroExp other)
		{
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BBF")]
		[Address(RVA = "0x26F4F0C", Offset = "0x26F4F0C", VA = "0x26F4F0C", Slot = "10")]
		[DebuggerNonUserCode]
		public ReportRewardHeroExp Clone()
		{
			return null;
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06001BC0 RID: 7104 RVA: 0x0000A9F8 File Offset: 0x00008BF8
		// (set) Token: 0x06001BC1 RID: 7105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000325")]
		[DebuggerNonUserCode]
		public int HeroId
		{
			[Token(Token = "0x6001BC0")]
			[Address(RVA = "0x26F4F6C", Offset = "0x26F4F6C", VA = "0x26F4F6C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001BC1")]
			[Address(RVA = "0x26F4F74", Offset = "0x26F4F74", VA = "0x26F4F74")]
			set
			{
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06001BC2 RID: 7106 RVA: 0x0000AA10 File Offset: 0x00008C10
		// (set) Token: 0x06001BC3 RID: 7107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000326")]
		[DebuggerNonUserCode]
		public int Level
		{
			[Token(Token = "0x6001BC2")]
			[Address(RVA = "0x26F4F7C", Offset = "0x26F4F7C", VA = "0x26F4F7C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001BC3")]
			[Address(RVA = "0x26F4F84", Offset = "0x26F4F84", VA = "0x26F4F84")]
			set
			{
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06001BC4 RID: 7108 RVA: 0x0000AA28 File Offset: 0x00008C28
		// (set) Token: 0x06001BC5 RID: 7109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000327")]
		[DebuggerNonUserCode]
		public int ExpAdd
		{
			[Token(Token = "0x6001BC4")]
			[Address(RVA = "0x26F4F8C", Offset = "0x26F4F8C", VA = "0x26F4F8C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001BC5")]
			[Address(RVA = "0x26F4F94", Offset = "0x26F4F94", VA = "0x26F4F94")]
			set
			{
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06001BC6 RID: 7110 RVA: 0x0000AA40 File Offset: 0x00008C40
		// (set) Token: 0x06001BC7 RID: 7111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000328")]
		[DebuggerNonUserCode]
		public int NowExp
		{
			[Token(Token = "0x6001BC6")]
			[Address(RVA = "0x26F4F9C", Offset = "0x26F4F9C", VA = "0x26F4F9C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001BC7")]
			[Address(RVA = "0x26F4FA4", Offset = "0x26F4FA4", VA = "0x26F4FA4")]
			set
			{
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06001BC8 RID: 7112 RVA: 0x0000AA58 File Offset: 0x00008C58
		// (set) Token: 0x06001BC9 RID: 7113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000329")]
		[DebuggerNonUserCode]
		public int OldExp
		{
			[Token(Token = "0x6001BC8")]
			[Address(RVA = "0x26F4FAC", Offset = "0x26F4FAC", VA = "0x26F4FAC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001BC9")]
			[Address(RVA = "0x26F4FB4", Offset = "0x26F4FB4", VA = "0x26F4FB4")]
			set
			{
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06001BCA RID: 7114 RVA: 0x0000AA70 File Offset: 0x00008C70
		// (set) Token: 0x06001BCB RID: 7115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700032A")]
		[DebuggerNonUserCode]
		public long HeroUuid
		{
			[Token(Token = "0x6001BCA")]
			[Address(RVA = "0x26F4FBC", Offset = "0x26F4FBC", VA = "0x26F4FBC")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6001BCB")]
			[Address(RVA = "0x26F4FC4", Offset = "0x26F4FC4", VA = "0x26F4FC4")]
			set
			{
			}
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x0000AA88 File Offset: 0x00008C88
		[Token(Token = "0x6001BCC")]
		[Address(RVA = "0x26F4FCC", Offset = "0x26F4FCC", VA = "0x26F4FCC", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x0000AAA0 File Offset: 0x00008CA0
		[Token(Token = "0x6001BCD")]
		[Address(RVA = "0x26F5030", Offset = "0x26F5030", VA = "0x26F5030", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ReportRewardHeroExp other)
		{
			return default(bool);
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x0000AAB8 File Offset: 0x00008CB8
		[Token(Token = "0x6001BCE")]
		[Address(RVA = "0x26F50BC", Offset = "0x26F50BC", VA = "0x26F50BC", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BCF")]
		[Address(RVA = "0x26F51AC", Offset = "0x26F51AC", VA = "0x26F51AC", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BD0")]
		[Address(RVA = "0x26F5204", Offset = "0x26F5204", VA = "0x26F5204", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x0000AAD0 File Offset: 0x00008CD0
		[Token(Token = "0x6001BD1")]
		[Address(RVA = "0x26F5348", Offset = "0x26F5348", VA = "0x26F5348", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BD2")]
		[Address(RVA = "0x26F54AC", Offset = "0x26F54AC", VA = "0x26F54AC", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ReportRewardHeroExp other)
		{
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BD3")]
		[Address(RVA = "0x26F5528", Offset = "0x26F5528", VA = "0x26F5528", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001CD0 RID: 7376
		[Token(Token = "0x4001CD0")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<ReportRewardHeroExp> _parser;

		// Token: 0x04001CD1 RID: 7377
		[Token(Token = "0x4001CD1")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CD2 RID: 7378
		[Token(Token = "0x4001CD2")]
		public const int HeroIdFieldNumber = 1;

		// Token: 0x04001CD3 RID: 7379
		[Token(Token = "0x4001CD3")]
		[FieldOffset(Offset = "0x18")]
		private int heroId_;

		// Token: 0x04001CD4 RID: 7380
		[Token(Token = "0x4001CD4")]
		public const int LevelFieldNumber = 2;

		// Token: 0x04001CD5 RID: 7381
		[Token(Token = "0x4001CD5")]
		[FieldOffset(Offset = "0x1C")]
		private int level_;

		// Token: 0x04001CD6 RID: 7382
		[Token(Token = "0x4001CD6")]
		public const int ExpAddFieldNumber = 3;

		// Token: 0x04001CD7 RID: 7383
		[Token(Token = "0x4001CD7")]
		[FieldOffset(Offset = "0x20")]
		private int expAdd_;

		// Token: 0x04001CD8 RID: 7384
		[Token(Token = "0x4001CD8")]
		public const int NowExpFieldNumber = 4;

		// Token: 0x04001CD9 RID: 7385
		[Token(Token = "0x4001CD9")]
		[FieldOffset(Offset = "0x24")]
		private int nowExp_;

		// Token: 0x04001CDA RID: 7386
		[Token(Token = "0x4001CDA")]
		public const int OldExpFieldNumber = 5;

		// Token: 0x04001CDB RID: 7387
		[Token(Token = "0x4001CDB")]
		[FieldOffset(Offset = "0x28")]
		private int oldExp_;

		// Token: 0x04001CDC RID: 7388
		[Token(Token = "0x4001CDC")]
		public const int HeroUuidFieldNumber = 6;

		// Token: 0x04001CDD RID: 7389
		[Token(Token = "0x4001CDD")]
		[FieldOffset(Offset = "0x30")]
		private long heroUuid_;
	}
}
