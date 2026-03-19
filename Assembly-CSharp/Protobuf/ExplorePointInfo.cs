using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x0200047D RID: 1149
	[Token(Token = "0x200047D")]
	public sealed class ExplorePointInfo : IMessage<ExplorePointInfo>, IMessage, IEquatable<ExplorePointInfo>, IDeepCloneable<ExplorePointInfo>
	{
		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x060020FC RID: 8444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A5")]
		[DebuggerNonUserCode]
		public static MessageParser<ExplorePointInfo> Parser
		{
			[Token(Token = "0x60020FC")]
			[Address(RVA = "0x288E860", Offset = "0x288E860", VA = "0x288E860")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x060020FD RID: 8445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A6")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x60020FD")]
			[Address(RVA = "0x288E8B8", Offset = "0x288E8B8", VA = "0x288E8B8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x060020FE RID: 8446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A7")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x60020FE")]
			[Address(RVA = "0x288E9BC", Offset = "0x288E9BC", VA = "0x288E9BC", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020FF")]
		[Address(RVA = "0x288EA08", Offset = "0x288EA08", VA = "0x288EA08")]
		[DebuggerNonUserCode]
		public ExplorePointInfo()
		{
		}

		// Token: 0x06002100 RID: 8448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002100")]
		[Address(RVA = "0x288EA70", Offset = "0x288EA70", VA = "0x288EA70")]
		[DebuggerNonUserCode]
		public ExplorePointInfo(ExplorePointInfo other)
		{
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002101")]
		[Address(RVA = "0x288EAD8", Offset = "0x288EAD8", VA = "0x288EAD8", Slot = "10")]
		[DebuggerNonUserCode]
		public ExplorePointInfo Clone()
		{
			return null;
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06002102 RID: 8450 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002103 RID: 8451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004A8")]
		[DebuggerNonUserCode]
		public string OwnerUid
		{
			[Token(Token = "0x6002102")]
			[Address(RVA = "0x288EB38", Offset = "0x288EB38", VA = "0x288EB38")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002103")]
			[Address(RVA = "0x288EB40", Offset = "0x288EB40", VA = "0x288EB40")]
			set
			{
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06002104 RID: 8452 RVA: 0x0000CA08 File Offset: 0x0000AC08
		// (set) Token: 0x06002105 RID: 8453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004A9")]
		[DebuggerNonUserCode]
		public long Uuid
		{
			[Token(Token = "0x6002104")]
			[Address(RVA = "0x288EBBC", Offset = "0x288EBBC", VA = "0x288EBBC")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6002105")]
			[Address(RVA = "0x288EBC4", Offset = "0x288EBC4", VA = "0x288EBC4")]
			set
			{
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06002106 RID: 8454 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002107 RID: 8455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004AA")]
		[DebuggerNonUserCode]
		public string EventId
		{
			[Token(Token = "0x6002106")]
			[Address(RVA = "0x288EBCC", Offset = "0x288EBCC", VA = "0x288EBCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002107")]
			[Address(RVA = "0x288EBD4", Offset = "0x288EBD4", VA = "0x288EBD4")]
			set
			{
			}
		}

		// Token: 0x06002108 RID: 8456 RVA: 0x0000CA20 File Offset: 0x0000AC20
		[Token(Token = "0x6002108")]
		[Address(RVA = "0x288EC50", Offset = "0x288EC50", VA = "0x288EC50", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x0000CA38 File Offset: 0x0000AC38
		[Token(Token = "0x6002109")]
		[Address(RVA = "0x288ECB4", Offset = "0x288ECB4", VA = "0x288ECB4", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ExplorePointInfo other)
		{
			return default(bool);
		}

		// Token: 0x0600210A RID: 8458 RVA: 0x0000CA50 File Offset: 0x0000AC50
		[Token(Token = "0x600210A")]
		[Address(RVA = "0x288ED38", Offset = "0x288ED38", VA = "0x288ED38", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600210B RID: 8459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600210B")]
		[Address(RVA = "0x288EDD8", Offset = "0x288EDD8", VA = "0x288EDD8", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600210C RID: 8460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600210C")]
		[Address(RVA = "0x288EE30", Offset = "0x288EE30", VA = "0x288EE30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600210D RID: 8461 RVA: 0x0000CA68 File Offset: 0x0000AC68
		[Token(Token = "0x600210D")]
		[Address(RVA = "0x288EF00", Offset = "0x288EF00", VA = "0x288EF00", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600210E")]
		[Address(RVA = "0x288EFFC", Offset = "0x288EFFC", VA = "0x288EFFC", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ExplorePointInfo other)
		{
		}

		// Token: 0x0600210F RID: 8463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600210F")]
		[Address(RVA = "0x288F084", Offset = "0x288F084", VA = "0x288F084", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001F59 RID: 8025
		[Token(Token = "0x4001F59")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<ExplorePointInfo> _parser;

		// Token: 0x04001F5A RID: 8026
		[Token(Token = "0x4001F5A")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F5B RID: 8027
		[Token(Token = "0x4001F5B")]
		public const int OwnerUidFieldNumber = 1;

		// Token: 0x04001F5C RID: 8028
		[Token(Token = "0x4001F5C")]
		[FieldOffset(Offset = "0x18")]
		private string ownerUid_;

		// Token: 0x04001F5D RID: 8029
		[Token(Token = "0x4001F5D")]
		public const int UuidFieldNumber = 2;

		// Token: 0x04001F5E RID: 8030
		[Token(Token = "0x4001F5E")]
		[FieldOffset(Offset = "0x20")]
		private long uuid_;

		// Token: 0x04001F5F RID: 8031
		[Token(Token = "0x4001F5F")]
		public const int EventIdFieldNumber = 3;

		// Token: 0x04001F60 RID: 8032
		[Token(Token = "0x4001F60")]
		[FieldOffset(Offset = "0x28")]
		private string eventId_;
	}
}
