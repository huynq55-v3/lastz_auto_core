using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000410 RID: 1040
	[Token(Token = "0x2000410")]
	public sealed class EffectRoundReport : IMessage<EffectRoundReport>, IMessage, IEquatable<EffectRoundReport>, IDeepCloneable<EffectRoundReport>
	{
		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06001B78 RID: 7032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000313")]
		[DebuggerNonUserCode]
		public static MessageParser<EffectRoundReport> Parser
		{
			[Token(Token = "0x6001B78")]
			[Address(RVA = "0x26F3264", Offset = "0x26F3264", VA = "0x26F3264")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06001B79 RID: 7033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000314")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001B79")]
			[Address(RVA = "0x26F32BC", Offset = "0x26F32BC", VA = "0x26F32BC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06001B7A RID: 7034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000315")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001B7A")]
			[Address(RVA = "0x26F33C0", Offset = "0x26F33C0", VA = "0x26F33C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B7B")]
		[Address(RVA = "0x26F340C", Offset = "0x26F340C", VA = "0x26F340C")]
		[DebuggerNonUserCode]
		public EffectRoundReport()
		{
		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B7C")]
		[Address(RVA = "0x26F3414", Offset = "0x26F3414", VA = "0x26F3414")]
		[DebuggerNonUserCode]
		public EffectRoundReport(EffectRoundReport other)
		{
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B7D")]
		[Address(RVA = "0x26F3488", Offset = "0x26F3488", VA = "0x26F3488", Slot = "10")]
		[DebuggerNonUserCode]
		public EffectRoundReport Clone()
		{
			return null;
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06001B7E RID: 7038 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001B7F RID: 7039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000316")]
		[DebuggerNonUserCode]
		public BaseRoundReport BaseReport
		{
			[Token(Token = "0x6001B7E")]
			[Address(RVA = "0x26F34E8", Offset = "0x26F34E8", VA = "0x26F34E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B7F")]
			[Address(RVA = "0x26F34F0", Offset = "0x26F34F0", VA = "0x26F34F0")]
			set
			{
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06001B80 RID: 7040 RVA: 0x0000A878 File Offset: 0x00008A78
		// (set) Token: 0x06001B81 RID: 7041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000317")]
		[DebuggerNonUserCode]
		public int Time
		{
			[Token(Token = "0x6001B80")]
			[Address(RVA = "0x26F34F8", Offset = "0x26F34F8", VA = "0x26F34F8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001B81")]
			[Address(RVA = "0x26F3500", Offset = "0x26F3500", VA = "0x26F3500")]
			set
			{
			}
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x0000A890 File Offset: 0x00008A90
		[Token(Token = "0x6001B82")]
		[Address(RVA = "0x26F3508", Offset = "0x26F3508", VA = "0x26F3508", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x0000A8A8 File Offset: 0x00008AA8
		[Token(Token = "0x6001B83")]
		[Address(RVA = "0x26F356C", Offset = "0x26F356C", VA = "0x26F356C", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(EffectRoundReport other)
		{
			return default(bool);
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x0000A8C0 File Offset: 0x00008AC0
		[Token(Token = "0x6001B84")]
		[Address(RVA = "0x26F35DC", Offset = "0x26F35DC", VA = "0x26F35DC", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B85")]
		[Address(RVA = "0x26F3650", Offset = "0x26F3650", VA = "0x26F3650", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B86")]
		[Address(RVA = "0x26F36A8", Offset = "0x26F36A8", VA = "0x26F36A8", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x0000A8D8 File Offset: 0x00008AD8
		[Token(Token = "0x6001B87")]
		[Address(RVA = "0x26F373C", Offset = "0x26F373C", VA = "0x26F373C", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B88")]
		[Address(RVA = "0x26F37F0", Offset = "0x26F37F0", VA = "0x26F37F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(EffectRoundReport other)
		{
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B89")]
		[Address(RVA = "0x26F38C4", Offset = "0x26F38C4", VA = "0x26F38C4", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001CBB RID: 7355
		[Token(Token = "0x4001CBB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<EffectRoundReport> _parser;

		// Token: 0x04001CBC RID: 7356
		[Token(Token = "0x4001CBC")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CBD RID: 7357
		[Token(Token = "0x4001CBD")]
		public const int BaseReportFieldNumber = 1;

		// Token: 0x04001CBE RID: 7358
		[Token(Token = "0x4001CBE")]
		[FieldOffset(Offset = "0x18")]
		private BaseRoundReport baseReport_;

		// Token: 0x04001CBF RID: 7359
		[Token(Token = "0x4001CBF")]
		public const int TimeFieldNumber = 2;

		// Token: 0x04001CC0 RID: 7360
		[Token(Token = "0x4001CC0")]
		[FieldOffset(Offset = "0x20")]
		private int time_;
	}
}
