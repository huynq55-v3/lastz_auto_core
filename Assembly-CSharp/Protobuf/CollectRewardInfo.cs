using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000485 RID: 1157
	[Token(Token = "0x2000485")]
	public sealed class CollectRewardInfo : IMessage<CollectRewardInfo>, IMessage, IEquatable<CollectRewardInfo>, IDeepCloneable<CollectRewardInfo>
	{
		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x0600216E RID: 8558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C6")]
		[DebuggerNonUserCode]
		public static MessageParser<CollectRewardInfo> Parser
		{
			[Token(Token = "0x600216E")]
			[Address(RVA = "0x2891BF4", Offset = "0x2891BF4", VA = "0x2891BF4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x0600216F RID: 8559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C7")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x600216F")]
			[Address(RVA = "0x2891C4C", Offset = "0x2891C4C", VA = "0x2891C4C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06002170 RID: 8560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C8")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6002170")]
			[Address(RVA = "0x2891D50", Offset = "0x2891D50", VA = "0x2891D50", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002171")]
		[Address(RVA = "0x2891D9C", Offset = "0x2891D9C", VA = "0x2891D9C")]
		[DebuggerNonUserCode]
		public CollectRewardInfo()
		{
		}

		// Token: 0x06002172 RID: 8562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002172")]
		[Address(RVA = "0x2891DF4", Offset = "0x2891DF4", VA = "0x2891DF4")]
		[DebuggerNonUserCode]
		public CollectRewardInfo(CollectRewardInfo other)
		{
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002173")]
		[Address(RVA = "0x2891E54", Offset = "0x2891E54", VA = "0x2891E54", Slot = "10")]
		[DebuggerNonUserCode]
		public CollectRewardInfo Clone()
		{
			return null;
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06002174 RID: 8564 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002175 RID: 8565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004C9")]
		[DebuggerNonUserCode]
		public string OwnerUid
		{
			[Token(Token = "0x6002174")]
			[Address(RVA = "0x2891EB4", Offset = "0x2891EB4", VA = "0x2891EB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002175")]
			[Address(RVA = "0x2891EBC", Offset = "0x2891EBC", VA = "0x2891EBC")]
			set
			{
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06002176 RID: 8566 RVA: 0x0000CC90 File Offset: 0x0000AE90
		// (set) Token: 0x06002177 RID: 8567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004CA")]
		[DebuggerNonUserCode]
		public long Uuid
		{
			[Token(Token = "0x6002176")]
			[Address(RVA = "0x2891F38", Offset = "0x2891F38", VA = "0x2891F38")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6002177")]
			[Address(RVA = "0x2891F40", Offset = "0x2891F40", VA = "0x2891F40")]
			set
			{
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06002178 RID: 8568 RVA: 0x0000CCA8 File Offset: 0x0000AEA8
		// (set) Token: 0x06002179 RID: 8569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004CB")]
		[DebuggerNonUserCode]
		public long ExpireTime
		{
			[Token(Token = "0x6002178")]
			[Address(RVA = "0x2891F48", Offset = "0x2891F48", VA = "0x2891F48")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6002179")]
			[Address(RVA = "0x2891F50", Offset = "0x2891F50", VA = "0x2891F50")]
			set
			{
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x0600217A RID: 8570 RVA: 0x0000CCC0 File Offset: 0x0000AEC0
		// (set) Token: 0x0600217B RID: 8571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004CC")]
		[DebuggerNonUserCode]
		public int ContentId
		{
			[Token(Token = "0x600217A")]
			[Address(RVA = "0x2891F58", Offset = "0x2891F58", VA = "0x2891F58")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600217B")]
			[Address(RVA = "0x2891F60", Offset = "0x2891F60", VA = "0x2891F60")]
			set
			{
			}
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x0000CCD8 File Offset: 0x0000AED8
		[Token(Token = "0x600217C")]
		[Address(RVA = "0x2891F68", Offset = "0x2891F68", VA = "0x2891F68", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x0600217D RID: 8573 RVA: 0x0000CCF0 File Offset: 0x0000AEF0
		[Token(Token = "0x600217D")]
		[Address(RVA = "0x2891FCC", Offset = "0x2891FCC", VA = "0x2891FCC", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CollectRewardInfo other)
		{
			return default(bool);
		}

		// Token: 0x0600217E RID: 8574 RVA: 0x0000CD08 File Offset: 0x0000AF08
		[Token(Token = "0x600217E")]
		[Address(RVA = "0x289205C", Offset = "0x289205C", VA = "0x289205C", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600217F RID: 8575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600217F")]
		[Address(RVA = "0x289211C", Offset = "0x289211C", VA = "0x289211C", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002180 RID: 8576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002180")]
		[Address(RVA = "0x2892174", Offset = "0x2892174", VA = "0x2892174", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002181 RID: 8577 RVA: 0x0000CD20 File Offset: 0x0000AF20
		[Token(Token = "0x6002181")]
		[Address(RVA = "0x2892268", Offset = "0x2892268", VA = "0x2892268", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002182 RID: 8578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002182")]
		[Address(RVA = "0x2892388", Offset = "0x2892388", VA = "0x2892388", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CollectRewardInfo other)
		{
		}

		// Token: 0x06002183 RID: 8579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002183")]
		[Address(RVA = "0x2892410", Offset = "0x2892410", VA = "0x2892410", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001F8F RID: 8079
		[Token(Token = "0x4001F8F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<CollectRewardInfo> _parser;

		// Token: 0x04001F90 RID: 8080
		[Token(Token = "0x4001F90")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F91 RID: 8081
		[Token(Token = "0x4001F91")]
		public const int OwnerUidFieldNumber = 1;

		// Token: 0x04001F92 RID: 8082
		[Token(Token = "0x4001F92")]
		[FieldOffset(Offset = "0x18")]
		private string ownerUid_;

		// Token: 0x04001F93 RID: 8083
		[Token(Token = "0x4001F93")]
		public const int UuidFieldNumber = 2;

		// Token: 0x04001F94 RID: 8084
		[Token(Token = "0x4001F94")]
		[FieldOffset(Offset = "0x20")]
		private long uuid_;

		// Token: 0x04001F95 RID: 8085
		[Token(Token = "0x4001F95")]
		public const int ExpireTimeFieldNumber = 3;

		// Token: 0x04001F96 RID: 8086
		[Token(Token = "0x4001F96")]
		[FieldOffset(Offset = "0x28")]
		private long expireTime_;

		// Token: 0x04001F97 RID: 8087
		[Token(Token = "0x4001F97")]
		public const int ContentIdFieldNumber = 4;

		// Token: 0x04001F98 RID: 8088
		[Token(Token = "0x4001F98")]
		[FieldOffset(Offset = "0x30")]
		private int contentId_;
	}
}
