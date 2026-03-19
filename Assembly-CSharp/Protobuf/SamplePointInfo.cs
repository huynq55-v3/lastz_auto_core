using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x0200047F RID: 1151
	[Token(Token = "0x200047F")]
	public sealed class SamplePointInfo : IMessage<SamplePointInfo>, IMessage, IEquatable<SamplePointInfo>, IDeepCloneable<SamplePointInfo>
	{
		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06002114 RID: 8468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004AB")]
		[DebuggerNonUserCode]
		public static MessageParser<SamplePointInfo> Parser
		{
			[Token(Token = "0x6002114")]
			[Address(RVA = "0x288F330", Offset = "0x288F330", VA = "0x288F330")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06002115 RID: 8469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004AC")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6002115")]
			[Address(RVA = "0x288F388", Offset = "0x288F388", VA = "0x288F388")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06002116 RID: 8470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004AD")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6002116")]
			[Address(RVA = "0x288F48C", Offset = "0x288F48C", VA = "0x288F48C", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002117")]
		[Address(RVA = "0x288F4D8", Offset = "0x288F4D8", VA = "0x288F4D8")]
		[DebuggerNonUserCode]
		public SamplePointInfo()
		{
		}

		// Token: 0x06002118 RID: 8472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002118")]
		[Address(RVA = "0x288F540", Offset = "0x288F540", VA = "0x288F540")]
		[DebuggerNonUserCode]
		public SamplePointInfo(SamplePointInfo other)
		{
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002119")]
		[Address(RVA = "0x288F5A8", Offset = "0x288F5A8", VA = "0x288F5A8", Slot = "10")]
		[DebuggerNonUserCode]
		public SamplePointInfo Clone()
		{
			return null;
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x0600211A RID: 8474 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600211B RID: 8475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004AE")]
		[DebuggerNonUserCode]
		public string OwnerUid
		{
			[Token(Token = "0x600211A")]
			[Address(RVA = "0x288F608", Offset = "0x288F608", VA = "0x288F608")]
			get
			{
				return null;
			}
			[Token(Token = "0x600211B")]
			[Address(RVA = "0x288F610", Offset = "0x288F610", VA = "0x288F610")]
			set
			{
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x0600211C RID: 8476 RVA: 0x0000CA80 File Offset: 0x0000AC80
		// (set) Token: 0x0600211D RID: 8477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004AF")]
		[DebuggerNonUserCode]
		public long Uuid
		{
			[Token(Token = "0x600211C")]
			[Address(RVA = "0x288F68C", Offset = "0x288F68C", VA = "0x288F68C")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600211D")]
			[Address(RVA = "0x288F694", Offset = "0x288F694", VA = "0x288F694")]
			set
			{
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x0600211E RID: 8478 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600211F RID: 8479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B0")]
		[DebuggerNonUserCode]
		public string EventId
		{
			[Token(Token = "0x600211E")]
			[Address(RVA = "0x288F69C", Offset = "0x288F69C", VA = "0x288F69C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600211F")]
			[Address(RVA = "0x288F6A4", Offset = "0x288F6A4", VA = "0x288F6A4")]
			set
			{
			}
		}

		// Token: 0x06002120 RID: 8480 RVA: 0x0000CA98 File Offset: 0x0000AC98
		[Token(Token = "0x6002120")]
		[Address(RVA = "0x288F720", Offset = "0x288F720", VA = "0x288F720", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06002121 RID: 8481 RVA: 0x0000CAB0 File Offset: 0x0000ACB0
		[Token(Token = "0x6002121")]
		[Address(RVA = "0x288F784", Offset = "0x288F784", VA = "0x288F784", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SamplePointInfo other)
		{
			return default(bool);
		}

		// Token: 0x06002122 RID: 8482 RVA: 0x0000CAC8 File Offset: 0x0000ACC8
		[Token(Token = "0x6002122")]
		[Address(RVA = "0x288F808", Offset = "0x288F808", VA = "0x288F808", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002123 RID: 8483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002123")]
		[Address(RVA = "0x288F8A8", Offset = "0x288F8A8", VA = "0x288F8A8", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002124 RID: 8484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002124")]
		[Address(RVA = "0x288F900", Offset = "0x288F900", VA = "0x288F900", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002125 RID: 8485 RVA: 0x0000CAE0 File Offset: 0x0000ACE0
		[Token(Token = "0x6002125")]
		[Address(RVA = "0x288F9D0", Offset = "0x288F9D0", VA = "0x288F9D0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002126 RID: 8486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002126")]
		[Address(RVA = "0x288FACC", Offset = "0x288FACC", VA = "0x288FACC", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SamplePointInfo other)
		{
		}

		// Token: 0x06002127 RID: 8487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002127")]
		[Address(RVA = "0x288FB54", Offset = "0x288FB54", VA = "0x288FB54", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001F62 RID: 8034
		[Token(Token = "0x4001F62")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<SamplePointInfo> _parser;

		// Token: 0x04001F63 RID: 8035
		[Token(Token = "0x4001F63")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F64 RID: 8036
		[Token(Token = "0x4001F64")]
		public const int OwnerUidFieldNumber = 1;

		// Token: 0x04001F65 RID: 8037
		[Token(Token = "0x4001F65")]
		[FieldOffset(Offset = "0x18")]
		private string ownerUid_;

		// Token: 0x04001F66 RID: 8038
		[Token(Token = "0x4001F66")]
		public const int UuidFieldNumber = 2;

		// Token: 0x04001F67 RID: 8039
		[Token(Token = "0x4001F67")]
		[FieldOffset(Offset = "0x20")]
		private long uuid_;

		// Token: 0x04001F68 RID: 8040
		[Token(Token = "0x4001F68")]
		public const int EventIdFieldNumber = 3;

		// Token: 0x04001F69 RID: 8041
		[Token(Token = "0x4001F69")]
		[FieldOffset(Offset = "0x28")]
		private string eventId_;
	}
}
