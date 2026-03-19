using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x0200046B RID: 1131
	[Token(Token = "0x200046B")]
	public sealed class EffectRoundReportPush : IMessage<EffectRoundReportPush>, IMessage, IEquatable<EffectRoundReportPush>, IDeepCloneable<EffectRoundReportPush>
	{
		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06001FED RID: 8173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700044C")]
		[DebuggerNonUserCode]
		public static MessageParser<EffectRoundReportPush> Parser
		{
			[Token(Token = "0x6001FED")]
			[Address(RVA = "0x25ABC28", Offset = "0x25ABC28", VA = "0x25ABC28")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06001FEE RID: 8174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700044D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001FEE")]
			[Address(RVA = "0x25ABC80", Offset = "0x25ABC80", VA = "0x25ABC80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06001FEF RID: 8175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700044E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001FEF")]
			[Address(RVA = "0x25ABD84", Offset = "0x25ABD84", VA = "0x25ABD84", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FF0")]
		[Address(RVA = "0x25ABDD0", Offset = "0x25ABDD0", VA = "0x25ABDD0")]
		[DebuggerNonUserCode]
		public EffectRoundReportPush()
		{
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FF1")]
		[Address(RVA = "0x25ABDD8", Offset = "0x25ABDD8", VA = "0x25ABDD8")]
		[DebuggerNonUserCode]
		public EffectRoundReportPush(EffectRoundReportPush other)
		{
		}

		// Token: 0x06001FF2 RID: 8178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF2")]
		[Address(RVA = "0x25ABE50", Offset = "0x25ABE50", VA = "0x25ABE50", Slot = "10")]
		[DebuggerNonUserCode]
		public EffectRoundReportPush Clone()
		{
			return null;
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06001FF3 RID: 8179 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FF4 RID: 8180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700044F")]
		[DebuggerNonUserCode]
		public EffectRoundReport RoundReport
		{
			[Token(Token = "0x6001FF3")]
			[Address(RVA = "0x25ABEB0", Offset = "0x25ABEB0", VA = "0x25ABEB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FF4")]
			[Address(RVA = "0x25ABEB8", Offset = "0x25ABEB8", VA = "0x25ABEB8")]
			set
			{
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06001FF5 RID: 8181 RVA: 0x0000C2A0 File Offset: 0x0000A4A0
		// (set) Token: 0x06001FF6 RID: 8182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000450")]
		[DebuggerNonUserCode]
		public long TriggerUuid
		{
			[Token(Token = "0x6001FF5")]
			[Address(RVA = "0x25ABEC0", Offset = "0x25ABEC0", VA = "0x25ABEC0")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6001FF6")]
			[Address(RVA = "0x25ABEC8", Offset = "0x25ABEC8", VA = "0x25ABEC8")]
			set
			{
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06001FF7 RID: 8183 RVA: 0x0000C2B8 File Offset: 0x0000A4B8
		// (set) Token: 0x06001FF8 RID: 8184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000451")]
		[DebuggerNonUserCode]
		public long TargetUuid
		{
			[Token(Token = "0x6001FF7")]
			[Address(RVA = "0x25ABED0", Offset = "0x25ABED0", VA = "0x25ABED0")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6001FF8")]
			[Address(RVA = "0x25ABED8", Offset = "0x25ABED8", VA = "0x25ABED8")]
			set
			{
			}
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x0000C2D0 File Offset: 0x0000A4D0
		[Token(Token = "0x6001FF9")]
		[Address(RVA = "0x25ABEE0", Offset = "0x25ABEE0", VA = "0x25ABEE0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x0000C2E8 File Offset: 0x0000A4E8
		[Token(Token = "0x6001FFA")]
		[Address(RVA = "0x25ABF44", Offset = "0x25ABF44", VA = "0x25ABF44", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(EffectRoundReportPush other)
		{
			return default(bool);
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x0000C300 File Offset: 0x0000A500
		[Token(Token = "0x6001FFB")]
		[Address(RVA = "0x25ABFC4", Offset = "0x25ABFC4", VA = "0x25ABFC4", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FFC")]
		[Address(RVA = "0x25AC054", Offset = "0x25AC054", VA = "0x25AC054", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FFD")]
		[Address(RVA = "0x25AC0AC", Offset = "0x25AC0AC", VA = "0x25AC0AC", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001FFE RID: 8190 RVA: 0x0000C318 File Offset: 0x0000A518
		[Token(Token = "0x6001FFE")]
		[Address(RVA = "0x25AC16C", Offset = "0x25AC16C", VA = "0x25AC16C", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FFF")]
		[Address(RVA = "0x25AC24C", Offset = "0x25AC24C", VA = "0x25AC24C", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(EffectRoundReportPush other)
		{
		}

		// Token: 0x06002000 RID: 8192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002000")]
		[Address(RVA = "0x25AC334", Offset = "0x25AC334", VA = "0x25AC334", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001EBE RID: 7870
		[Token(Token = "0x4001EBE")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<EffectRoundReportPush> _parser;

		// Token: 0x04001EBF RID: 7871
		[Token(Token = "0x4001EBF")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EC0 RID: 7872
		[Token(Token = "0x4001EC0")]
		public const int RoundReportFieldNumber = 1;

		// Token: 0x04001EC1 RID: 7873
		[Token(Token = "0x4001EC1")]
		[FieldOffset(Offset = "0x18")]
		private EffectRoundReport roundReport_;

		// Token: 0x04001EC2 RID: 7874
		[Token(Token = "0x4001EC2")]
		public const int TriggerUuidFieldNumber = 2;

		// Token: 0x04001EC3 RID: 7875
		[Token(Token = "0x4001EC3")]
		[FieldOffset(Offset = "0x20")]
		private long triggerUuid_;

		// Token: 0x04001EC4 RID: 7876
		[Token(Token = "0x4001EC4")]
		public const int TargetUuidFieldNumber = 3;

		// Token: 0x04001EC5 RID: 7877
		[Token(Token = "0x4001EC5")]
		[FieldOffset(Offset = "0x28")]
		private long targetUuid_;
	}
}
