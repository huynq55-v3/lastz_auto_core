using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x0200043A RID: 1082
	[Token(Token = "0x200043A")]
	public sealed class NpcCityArmyResult : IMessage<NpcCityArmyResult>, IMessage, IEquatable<NpcCityArmyResult>, IDeepCloneable<NpcCityArmyResult>
	{
		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06001D81 RID: 7553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700039D")]
		[DebuggerNonUserCode]
		public static MessageParser<NpcCityArmyResult> Parser
		{
			[Token(Token = "0x6001D81")]
			[Address(RVA = "0x2701F7C", Offset = "0x2701F7C", VA = "0x2701F7C")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06001D82 RID: 7554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700039E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001D82")]
			[Address(RVA = "0x2701FD4", Offset = "0x2701FD4", VA = "0x2701FD4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06001D83 RID: 7555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700039F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001D83")]
			[Address(RVA = "0x27020D8", Offset = "0x27020D8", VA = "0x27020D8", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D84")]
		[Address(RVA = "0x2702124", Offset = "0x2702124", VA = "0x2702124")]
		[DebuggerNonUserCode]
		public NpcCityArmyResult()
		{
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D85")]
		[Address(RVA = "0x270212C", Offset = "0x270212C", VA = "0x270212C")]
		[DebuggerNonUserCode]
		public NpcCityArmyResult(NpcCityArmyResult other)
		{
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D86")]
		[Address(RVA = "0x27021DC", Offset = "0x27021DC", VA = "0x27021DC", Slot = "10")]
		[DebuggerNonUserCode]
		public NpcCityArmyResult Clone()
		{
			return null;
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06001D87 RID: 7559 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D88 RID: 7560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A0")]
		[DebuggerNonUserCode]
		public ArmyResultBase Base
		{
			[Token(Token = "0x6001D87")]
			[Address(RVA = "0x270223C", Offset = "0x270223C", VA = "0x270223C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D88")]
			[Address(RVA = "0x2702244", Offset = "0x2702244", VA = "0x2702244")]
			set
			{
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06001D89 RID: 7561 RVA: 0x0000B490 File Offset: 0x00009690
		// (set) Token: 0x06001D8A RID: 7562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A1")]
		[DebuggerNonUserCode]
		public int Health
		{
			[Token(Token = "0x6001D89")]
			[Address(RVA = "0x270224C", Offset = "0x270224C", VA = "0x270224C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001D8A")]
			[Address(RVA = "0x2702254", Offset = "0x2702254", VA = "0x2702254")]
			set
			{
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06001D8B RID: 7563 RVA: 0x0000B4A8 File Offset: 0x000096A8
		// (set) Token: 0x06001D8C RID: 7564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A2")]
		[DebuggerNonUserCode]
		public int InitHealth
		{
			[Token(Token = "0x6001D8B")]
			[Address(RVA = "0x270225C", Offset = "0x270225C", VA = "0x270225C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001D8C")]
			[Address(RVA = "0x2702264", Offset = "0x2702264", VA = "0x2702264")]
			set
			{
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06001D8D RID: 7565 RVA: 0x0000B4C0 File Offset: 0x000096C0
		// (set) Token: 0x06001D8E RID: 7566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A3")]
		[DebuggerNonUserCode]
		public int AfterHealth
		{
			[Token(Token = "0x6001D8D")]
			[Address(RVA = "0x270226C", Offset = "0x270226C", VA = "0x270226C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001D8E")]
			[Address(RVA = "0x2702274", Offset = "0x2702274", VA = "0x2702274")]
			set
			{
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06001D8F RID: 7567 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D90 RID: 7568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A4")]
		[DebuggerNonUserCode]
		public NpcPlayerInfo NpcPlayerInfo
		{
			[Token(Token = "0x6001D8F")]
			[Address(RVA = "0x270227C", Offset = "0x270227C", VA = "0x270227C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D90")]
			[Address(RVA = "0x2702284", Offset = "0x2702284", VA = "0x2702284")]
			set
			{
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06001D91 RID: 7569 RVA: 0x0000B4D8 File Offset: 0x000096D8
		// (set) Token: 0x06001D92 RID: 7570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A5")]
		[DebuggerNonUserCode]
		public bool IsDirect
		{
			[Token(Token = "0x6001D91")]
			[Address(RVA = "0x270228C", Offset = "0x270228C", VA = "0x270228C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001D92")]
			[Address(RVA = "0x2702294", Offset = "0x2702294", VA = "0x2702294")]
			set
			{
			}
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x0000B4F0 File Offset: 0x000096F0
		[Token(Token = "0x6001D93")]
		[Address(RVA = "0x27022A0", Offset = "0x27022A0", VA = "0x27022A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x0000B508 File Offset: 0x00009708
		[Token(Token = "0x6001D94")]
		[Address(RVA = "0x2702304", Offset = "0x2702304", VA = "0x2702304", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(NpcCityArmyResult other)
		{
			return default(bool);
		}

		// Token: 0x06001D95 RID: 7573 RVA: 0x0000B520 File Offset: 0x00009720
		[Token(Token = "0x6001D95")]
		[Address(RVA = "0x27023C8", Offset = "0x27023C8", VA = "0x27023C8", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D96")]
		[Address(RVA = "0x27024E8", Offset = "0x27024E8", VA = "0x27024E8", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D97")]
		[Address(RVA = "0x2702540", Offset = "0x2702540", VA = "0x2702540", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x0000B538 File Offset: 0x00009738
		[Token(Token = "0x6001D98")]
		[Address(RVA = "0x2702684", Offset = "0x2702684", VA = "0x2702684", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D99")]
		[Address(RVA = "0x27027D4", Offset = "0x27027D4", VA = "0x27027D4", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(NpcCityArmyResult other)
		{
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D9A")]
		[Address(RVA = "0x2702930", Offset = "0x2702930", VA = "0x2702930", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001D97 RID: 7575
		[Token(Token = "0x4001D97")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<NpcCityArmyResult> _parser;

		// Token: 0x04001D98 RID: 7576
		[Token(Token = "0x4001D98")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D99 RID: 7577
		[Token(Token = "0x4001D99")]
		public const int BaseFieldNumber = 1;

		// Token: 0x04001D9A RID: 7578
		[Token(Token = "0x4001D9A")]
		[FieldOffset(Offset = "0x18")]
		private ArmyResultBase base_;

		// Token: 0x04001D9B RID: 7579
		[Token(Token = "0x4001D9B")]
		public const int HealthFieldNumber = 2;

		// Token: 0x04001D9C RID: 7580
		[Token(Token = "0x4001D9C")]
		[FieldOffset(Offset = "0x20")]
		private int health_;

		// Token: 0x04001D9D RID: 7581
		[Token(Token = "0x4001D9D")]
		public const int InitHealthFieldNumber = 3;

		// Token: 0x04001D9E RID: 7582
		[Token(Token = "0x4001D9E")]
		[FieldOffset(Offset = "0x24")]
		private int initHealth_;

		// Token: 0x04001D9F RID: 7583
		[Token(Token = "0x4001D9F")]
		public const int AfterHealthFieldNumber = 4;

		// Token: 0x04001DA0 RID: 7584
		[Token(Token = "0x4001DA0")]
		[FieldOffset(Offset = "0x28")]
		private int afterHealth_;

		// Token: 0x04001DA1 RID: 7585
		[Token(Token = "0x4001DA1")]
		public const int NpcPlayerInfoFieldNumber = 5;

		// Token: 0x04001DA2 RID: 7586
		[Token(Token = "0x4001DA2")]
		[FieldOffset(Offset = "0x30")]
		private NpcPlayerInfo npcPlayerInfo_;

		// Token: 0x04001DA3 RID: 7587
		[Token(Token = "0x4001DA3")]
		public const int IsDirectFieldNumber = 6;

		// Token: 0x04001DA4 RID: 7588
		[Token(Token = "0x4001DA4")]
		[FieldOffset(Offset = "0x38")]
		private bool isDirect_;
	}
}
