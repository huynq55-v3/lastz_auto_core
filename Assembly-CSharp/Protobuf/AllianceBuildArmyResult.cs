using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000438 RID: 1080
	[Token(Token = "0x2000438")]
	public sealed class AllianceBuildArmyResult : IMessage<AllianceBuildArmyResult>, IMessage, IEquatable<AllianceBuildArmyResult>, IDeepCloneable<AllianceBuildArmyResult>
	{
		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06001D63 RID: 7523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000394")]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceBuildArmyResult> Parser
		{
			[Token(Token = "0x6001D63")]
			[Address(RVA = "0x270132C", Offset = "0x270132C", VA = "0x270132C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06001D64 RID: 7524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000395")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001D64")]
			[Address(RVA = "0x2701384", Offset = "0x2701384", VA = "0x2701384")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06001D65 RID: 7525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000396")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001D65")]
			[Address(RVA = "0x2701488", Offset = "0x2701488", VA = "0x2701488", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D66 RID: 7526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D66")]
		[Address(RVA = "0x27014D4", Offset = "0x27014D4", VA = "0x27014D4")]
		[DebuggerNonUserCode]
		public AllianceBuildArmyResult()
		{
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D67")]
		[Address(RVA = "0x27014DC", Offset = "0x27014DC", VA = "0x27014DC")]
		[DebuggerNonUserCode]
		public AllianceBuildArmyResult(AllianceBuildArmyResult other)
		{
		}

		// Token: 0x06001D68 RID: 7528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D68")]
		[Address(RVA = "0x2701558", Offset = "0x2701558", VA = "0x2701558", Slot = "10")]
		[DebuggerNonUserCode]
		public AllianceBuildArmyResult Clone()
		{
			return null;
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06001D69 RID: 7529 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D6A RID: 7530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000397")]
		[DebuggerNonUserCode]
		public ArmyResultBase Base
		{
			[Token(Token = "0x6001D69")]
			[Address(RVA = "0x27015B8", Offset = "0x27015B8", VA = "0x27015B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D6A")]
			[Address(RVA = "0x27015C0", Offset = "0x27015C0", VA = "0x27015C0")]
			set
			{
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06001D6B RID: 7531 RVA: 0x0000B3B8 File Offset: 0x000095B8
		// (set) Token: 0x06001D6C RID: 7532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000398")]
		[DebuggerNonUserCode]
		public int BuildId
		{
			[Token(Token = "0x6001D6B")]
			[Address(RVA = "0x27015C8", Offset = "0x27015C8", VA = "0x27015C8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001D6C")]
			[Address(RVA = "0x27015D0", Offset = "0x27015D0", VA = "0x27015D0")]
			set
			{
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06001D6D RID: 7533 RVA: 0x0000B3D0 File Offset: 0x000095D0
		// (set) Token: 0x06001D6E RID: 7534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000399")]
		[DebuggerNonUserCode]
		public int Health
		{
			[Token(Token = "0x6001D6D")]
			[Address(RVA = "0x27015D8", Offset = "0x27015D8", VA = "0x27015D8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001D6E")]
			[Address(RVA = "0x27015E0", Offset = "0x27015E0", VA = "0x27015E0")]
			set
			{
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06001D6F RID: 7535 RVA: 0x0000B3E8 File Offset: 0x000095E8
		// (set) Token: 0x06001D70 RID: 7536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700039A")]
		[DebuggerNonUserCode]
		public int InitHealth
		{
			[Token(Token = "0x6001D6F")]
			[Address(RVA = "0x27015E8", Offset = "0x27015E8", VA = "0x27015E8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001D70")]
			[Address(RVA = "0x27015F0", Offset = "0x27015F0", VA = "0x27015F0")]
			set
			{
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06001D71 RID: 7537 RVA: 0x0000B400 File Offset: 0x00009600
		// (set) Token: 0x06001D72 RID: 7538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700039B")]
		[DebuggerNonUserCode]
		public int AfterHealth
		{
			[Token(Token = "0x6001D71")]
			[Address(RVA = "0x27015F8", Offset = "0x27015F8", VA = "0x27015F8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001D72")]
			[Address(RVA = "0x2701600", Offset = "0x2701600", VA = "0x2701600")]
			set
			{
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06001D73 RID: 7539 RVA: 0x0000B418 File Offset: 0x00009618
		// (set) Token: 0x06001D74 RID: 7540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700039C")]
		[DebuggerNonUserCode]
		public int BuildLevel
		{
			[Token(Token = "0x6001D73")]
			[Address(RVA = "0x2701608", Offset = "0x2701608", VA = "0x2701608")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001D74")]
			[Address(RVA = "0x2701610", Offset = "0x2701610", VA = "0x2701610")]
			set
			{
			}
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x0000B430 File Offset: 0x00009630
		[Token(Token = "0x6001D75")]
		[Address(RVA = "0x2701618", Offset = "0x2701618", VA = "0x2701618", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x0000B448 File Offset: 0x00009648
		[Token(Token = "0x6001D76")]
		[Address(RVA = "0x270167C", Offset = "0x270167C", VA = "0x270167C", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(AllianceBuildArmyResult other)
		{
			return default(bool);
		}

		// Token: 0x06001D77 RID: 7543 RVA: 0x0000B460 File Offset: 0x00009660
		[Token(Token = "0x6001D77")]
		[Address(RVA = "0x270172C", Offset = "0x270172C", VA = "0x270172C", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D78")]
		[Address(RVA = "0x2701810", Offset = "0x2701810", VA = "0x2701810", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D79")]
		[Address(RVA = "0x2701868", Offset = "0x2701868", VA = "0x2701868", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x0000B478 File Offset: 0x00009678
		[Token(Token = "0x6001D7A")]
		[Address(RVA = "0x27019AC", Offset = "0x27019AC", VA = "0x27019AC", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D7B")]
		[Address(RVA = "0x2701B10", Offset = "0x2701B10", VA = "0x2701B10", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(AllianceBuildArmyResult other)
		{
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D7C")]
		[Address(RVA = "0x2701C14", Offset = "0x2701C14", VA = "0x2701C14", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001D88 RID: 7560
		[Token(Token = "0x4001D88")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<AllianceBuildArmyResult> _parser;

		// Token: 0x04001D89 RID: 7561
		[Token(Token = "0x4001D89")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D8A RID: 7562
		[Token(Token = "0x4001D8A")]
		public const int BaseFieldNumber = 1;

		// Token: 0x04001D8B RID: 7563
		[Token(Token = "0x4001D8B")]
		[FieldOffset(Offset = "0x18")]
		private ArmyResultBase base_;

		// Token: 0x04001D8C RID: 7564
		[Token(Token = "0x4001D8C")]
		public const int BuildIdFieldNumber = 2;

		// Token: 0x04001D8D RID: 7565
		[Token(Token = "0x4001D8D")]
		[FieldOffset(Offset = "0x20")]
		private int buildId_;

		// Token: 0x04001D8E RID: 7566
		[Token(Token = "0x4001D8E")]
		public const int HealthFieldNumber = 3;

		// Token: 0x04001D8F RID: 7567
		[Token(Token = "0x4001D8F")]
		[FieldOffset(Offset = "0x24")]
		private int health_;

		// Token: 0x04001D90 RID: 7568
		[Token(Token = "0x4001D90")]
		public const int InitHealthFieldNumber = 4;

		// Token: 0x04001D91 RID: 7569
		[Token(Token = "0x4001D91")]
		[FieldOffset(Offset = "0x28")]
		private int initHealth_;

		// Token: 0x04001D92 RID: 7570
		[Token(Token = "0x4001D92")]
		public const int AfterHealthFieldNumber = 5;

		// Token: 0x04001D93 RID: 7571
		[Token(Token = "0x4001D93")]
		[FieldOffset(Offset = "0x2C")]
		private int afterHealth_;

		// Token: 0x04001D94 RID: 7572
		[Token(Token = "0x4001D94")]
		public const int BuildLevelFieldNumber = 6;

		// Token: 0x04001D95 RID: 7573
		[Token(Token = "0x4001D95")]
		[FieldOffset(Offset = "0x30")]
		private int buildLevel_;
	}
}
