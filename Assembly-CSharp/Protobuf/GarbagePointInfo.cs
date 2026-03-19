using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000481 RID: 1153
	[Token(Token = "0x2000481")]
	public sealed class GarbagePointInfo : IMessage<GarbagePointInfo>, IMessage, IEquatable<GarbagePointInfo>, IDeepCloneable<GarbagePointInfo>
	{
		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x0600212C RID: 8492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B1")]
		[DebuggerNonUserCode]
		public static MessageParser<GarbagePointInfo> Parser
		{
			[Token(Token = "0x600212C")]
			[Address(RVA = "0x288FE00", Offset = "0x288FE00", VA = "0x288FE00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x0600212D RID: 8493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B2")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x600212D")]
			[Address(RVA = "0x288FE58", Offset = "0x288FE58", VA = "0x288FE58")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x0600212E RID: 8494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B3")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x600212E")]
			[Address(RVA = "0x288FF5C", Offset = "0x288FF5C", VA = "0x288FF5C", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600212F RID: 8495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600212F")]
		[Address(RVA = "0x288FFA8", Offset = "0x288FFA8", VA = "0x288FFA8")]
		[DebuggerNonUserCode]
		public GarbagePointInfo()
		{
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002130")]
		[Address(RVA = "0x2890010", Offset = "0x2890010", VA = "0x2890010")]
		[DebuggerNonUserCode]
		public GarbagePointInfo(GarbagePointInfo other)
		{
		}

		// Token: 0x06002131 RID: 8497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002131")]
		[Address(RVA = "0x2890080", Offset = "0x2890080", VA = "0x2890080", Slot = "10")]
		[DebuggerNonUserCode]
		public GarbagePointInfo Clone()
		{
			return null;
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06002132 RID: 8498 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002133 RID: 8499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B4")]
		[DebuggerNonUserCode]
		public string OwnerUid
		{
			[Token(Token = "0x6002132")]
			[Address(RVA = "0x28900E0", Offset = "0x28900E0", VA = "0x28900E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002133")]
			[Address(RVA = "0x28900E8", Offset = "0x28900E8", VA = "0x28900E8")]
			set
			{
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06002134 RID: 8500 RVA: 0x0000CAF8 File Offset: 0x0000ACF8
		// (set) Token: 0x06002135 RID: 8501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B5")]
		[DebuggerNonUserCode]
		public long Uuid
		{
			[Token(Token = "0x6002134")]
			[Address(RVA = "0x2890164", Offset = "0x2890164", VA = "0x2890164")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6002135")]
			[Address(RVA = "0x289016C", Offset = "0x289016C", VA = "0x289016C")]
			set
			{
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06002136 RID: 8502 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002137 RID: 8503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B6")]
		[DebuggerNonUserCode]
		public string EventId
		{
			[Token(Token = "0x6002136")]
			[Address(RVA = "0x2890174", Offset = "0x2890174", VA = "0x2890174")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002137")]
			[Address(RVA = "0x289017C", Offset = "0x289017C", VA = "0x289017C")]
			set
			{
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06002138 RID: 8504 RVA: 0x0000CB10 File Offset: 0x0000AD10
		// (set) Token: 0x06002139 RID: 8505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B7")]
		[DebuggerNonUserCode]
		public long EndTime
		{
			[Token(Token = "0x6002138")]
			[Address(RVA = "0x28901F8", Offset = "0x28901F8", VA = "0x28901F8")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6002139")]
			[Address(RVA = "0x2890200", Offset = "0x2890200", VA = "0x2890200")]
			set
			{
			}
		}

		// Token: 0x0600213A RID: 8506 RVA: 0x0000CB28 File Offset: 0x0000AD28
		[Token(Token = "0x600213A")]
		[Address(RVA = "0x2890208", Offset = "0x2890208", VA = "0x2890208", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x0600213B RID: 8507 RVA: 0x0000CB40 File Offset: 0x0000AD40
		[Token(Token = "0x600213B")]
		[Address(RVA = "0x289026C", Offset = "0x289026C", VA = "0x289026C", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GarbagePointInfo other)
		{
			return default(bool);
		}

		// Token: 0x0600213C RID: 8508 RVA: 0x0000CB58 File Offset: 0x0000AD58
		[Token(Token = "0x600213C")]
		[Address(RVA = "0x2890300", Offset = "0x2890300", VA = "0x2890300", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600213D RID: 8509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600213D")]
		[Address(RVA = "0x28903BC", Offset = "0x28903BC", VA = "0x28903BC", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600213E RID: 8510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600213E")]
		[Address(RVA = "0x2890414", Offset = "0x2890414", VA = "0x2890414", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600213F RID: 8511 RVA: 0x0000CB70 File Offset: 0x0000AD70
		[Token(Token = "0x600213F")]
		[Address(RVA = "0x2890510", Offset = "0x2890510", VA = "0x2890510", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002140 RID: 8512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002140")]
		[Address(RVA = "0x2890638", Offset = "0x2890638", VA = "0x2890638", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GarbagePointInfo other)
		{
		}

		// Token: 0x06002141 RID: 8513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002141")]
		[Address(RVA = "0x28906CC", Offset = "0x28906CC", VA = "0x28906CC", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001F6B RID: 8043
		[Token(Token = "0x4001F6B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<GarbagePointInfo> _parser;

		// Token: 0x04001F6C RID: 8044
		[Token(Token = "0x4001F6C")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F6D RID: 8045
		[Token(Token = "0x4001F6D")]
		public const int OwnerUidFieldNumber = 1;

		// Token: 0x04001F6E RID: 8046
		[Token(Token = "0x4001F6E")]
		[FieldOffset(Offset = "0x18")]
		private string ownerUid_;

		// Token: 0x04001F6F RID: 8047
		[Token(Token = "0x4001F6F")]
		public const int UuidFieldNumber = 2;

		// Token: 0x04001F70 RID: 8048
		[Token(Token = "0x4001F70")]
		[FieldOffset(Offset = "0x20")]
		private long uuid_;

		// Token: 0x04001F71 RID: 8049
		[Token(Token = "0x4001F71")]
		public const int EventIdFieldNumber = 3;

		// Token: 0x04001F72 RID: 8050
		[Token(Token = "0x4001F72")]
		[FieldOffset(Offset = "0x28")]
		private string eventId_;

		// Token: 0x04001F73 RID: 8051
		[Token(Token = "0x4001F73")]
		public const int EndTimeFieldNumber = 4;

		// Token: 0x04001F74 RID: 8052
		[Token(Token = "0x4001F74")]
		[FieldOffset(Offset = "0x30")]
		private long endTime_;
	}
}
