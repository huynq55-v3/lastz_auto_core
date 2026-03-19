using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000461 RID: 1121
	[Token(Token = "0x2000461")]
	public sealed class RoundStatusInfo : IMessage<RoundStatusInfo>, IMessage, IEquatable<RoundStatusInfo>, IDeepCloneable<RoundStatusInfo>
	{
		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06001F6B RID: 8043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000428")]
		[DebuggerNonUserCode]
		public static MessageParser<RoundStatusInfo> Parser
		{
			[Token(Token = "0x6001F6B")]
			[Address(RVA = "0x25A80D4", Offset = "0x25A80D4", VA = "0x25A80D4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06001F6C RID: 8044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000429")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001F6C")]
			[Address(RVA = "0x25A812C", Offset = "0x25A812C", VA = "0x25A812C")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06001F6D RID: 8045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700042A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001F6D")]
			[Address(RVA = "0x25A8230", Offset = "0x25A8230", VA = "0x25A8230", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F6E RID: 8046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F6E")]
		[Address(RVA = "0x25A827C", Offset = "0x25A827C", VA = "0x25A827C")]
		[DebuggerNonUserCode]
		public RoundStatusInfo()
		{
		}

		// Token: 0x06001F6F RID: 8047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F6F")]
		[Address(RVA = "0x25A8284", Offset = "0x25A8284", VA = "0x25A8284")]
		[DebuggerNonUserCode]
		public RoundStatusInfo(RoundStatusInfo other)
		{
		}

		// Token: 0x06001F70 RID: 8048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F70")]
		[Address(RVA = "0x25A82D0", Offset = "0x25A82D0", VA = "0x25A82D0", Slot = "10")]
		[DebuggerNonUserCode]
		public RoundStatusInfo Clone()
		{
			return null;
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06001F71 RID: 8049 RVA: 0x0000BF70 File Offset: 0x0000A170
		// (set) Token: 0x06001F72 RID: 8050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700042B")]
		[DebuggerNonUserCode]
		public int StatusId
		{
			[Token(Token = "0x6001F71")]
			[Address(RVA = "0x25A8330", Offset = "0x25A8330", VA = "0x25A8330")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001F72")]
			[Address(RVA = "0x25A8338", Offset = "0x25A8338", VA = "0x25A8338")]
			set
			{
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06001F73 RID: 8051 RVA: 0x0000BF88 File Offset: 0x0000A188
		// (set) Token: 0x06001F74 RID: 8052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700042C")]
		[DebuggerNonUserCode]
		public int Time
		{
			[Token(Token = "0x6001F73")]
			[Address(RVA = "0x25A8340", Offset = "0x25A8340", VA = "0x25A8340")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001F74")]
			[Address(RVA = "0x25A8348", Offset = "0x25A8348", VA = "0x25A8348")]
			set
			{
			}
		}

		// Token: 0x06001F75 RID: 8053 RVA: 0x0000BFA0 File Offset: 0x0000A1A0
		[Token(Token = "0x6001F75")]
		[Address(RVA = "0x25A8350", Offset = "0x25A8350", VA = "0x25A8350", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x0000BFB8 File Offset: 0x0000A1B8
		[Token(Token = "0x6001F76")]
		[Address(RVA = "0x25A83B4", Offset = "0x25A83B4", VA = "0x25A83B4", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(RoundStatusInfo other)
		{
			return default(bool);
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x0000BFD0 File Offset: 0x0000A1D0
		[Token(Token = "0x6001F77")]
		[Address(RVA = "0x25A8400", Offset = "0x25A8400", VA = "0x25A8400", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001F78 RID: 8056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F78")]
		[Address(RVA = "0x25A8478", Offset = "0x25A8478", VA = "0x25A8478", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001F79 RID: 8057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F79")]
		[Address(RVA = "0x25A84D0", Offset = "0x25A84D0", VA = "0x25A84D0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001F7A RID: 8058 RVA: 0x0000BFE8 File Offset: 0x0000A1E8
		[Token(Token = "0x6001F7A")]
		[Address(RVA = "0x25A8564", Offset = "0x25A8564", VA = "0x25A8564", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001F7B RID: 8059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F7B")]
		[Address(RVA = "0x25A8618", Offset = "0x25A8618", VA = "0x25A8618", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(RoundStatusInfo other)
		{
		}

		// Token: 0x06001F7C RID: 8060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F7C")]
		[Address(RVA = "0x25A8664", Offset = "0x25A8664", VA = "0x25A8664", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001E83 RID: 7811
		[Token(Token = "0x4001E83")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<RoundStatusInfo> _parser;

		// Token: 0x04001E84 RID: 7812
		[Token(Token = "0x4001E84")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E85 RID: 7813
		[Token(Token = "0x4001E85")]
		public const int StatusIdFieldNumber = 1;

		// Token: 0x04001E86 RID: 7814
		[Token(Token = "0x4001E86")]
		[FieldOffset(Offset = "0x18")]
		private int statusId_;

		// Token: 0x04001E87 RID: 7815
		[Token(Token = "0x4001E87")]
		public const int TimeFieldNumber = 2;

		// Token: 0x04001E88 RID: 7816
		[Token(Token = "0x4001E88")]
		[FieldOffset(Offset = "0x1C")]
		private int time_;
	}
}
