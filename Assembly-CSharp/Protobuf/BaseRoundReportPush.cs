using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000469 RID: 1129
	[Token(Token = "0x2000469")]
	public sealed class BaseRoundReportPush : IMessage<BaseRoundReportPush>, IMessage, IEquatable<BaseRoundReportPush>, IDeepCloneable<BaseRoundReportPush>
	{
		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06001FD5 RID: 8149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000446")]
		[DebuggerNonUserCode]
		public static MessageParser<BaseRoundReportPush> Parser
		{
			[Token(Token = "0x6001FD5")]
			[Address(RVA = "0x25AB210", Offset = "0x25AB210", VA = "0x25AB210")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06001FD6 RID: 8150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000447")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001FD6")]
			[Address(RVA = "0x25AB268", Offset = "0x25AB268", VA = "0x25AB268")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06001FD7 RID: 8151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000448")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001FD7")]
			[Address(RVA = "0x25AB36C", Offset = "0x25AB36C", VA = "0x25AB36C", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001FD8 RID: 8152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FD8")]
		[Address(RVA = "0x25AB3B8", Offset = "0x25AB3B8", VA = "0x25AB3B8")]
		[DebuggerNonUserCode]
		public BaseRoundReportPush()
		{
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FD9")]
		[Address(RVA = "0x25AB3C0", Offset = "0x25AB3C0", VA = "0x25AB3C0")]
		[DebuggerNonUserCode]
		public BaseRoundReportPush(BaseRoundReportPush other)
		{
		}

		// Token: 0x06001FDA RID: 8154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FDA")]
		[Address(RVA = "0x25AB438", Offset = "0x25AB438", VA = "0x25AB438", Slot = "10")]
		[DebuggerNonUserCode]
		public BaseRoundReportPush Clone()
		{
			return null;
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06001FDB RID: 8155 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FDC RID: 8156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000449")]
		[DebuggerNonUserCode]
		public BaseRoundReport RoundReport
		{
			[Token(Token = "0x6001FDB")]
			[Address(RVA = "0x25AB498", Offset = "0x25AB498", VA = "0x25AB498")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FDC")]
			[Address(RVA = "0x25AB4A0", Offset = "0x25AB4A0", VA = "0x25AB4A0")]
			set
			{
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06001FDD RID: 8157 RVA: 0x0000C210 File Offset: 0x0000A410
		// (set) Token: 0x06001FDE RID: 8158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700044A")]
		[DebuggerNonUserCode]
		public long TriggerUuid
		{
			[Token(Token = "0x6001FDD")]
			[Address(RVA = "0x25AB4A8", Offset = "0x25AB4A8", VA = "0x25AB4A8")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6001FDE")]
			[Address(RVA = "0x25AB4B0", Offset = "0x25AB4B0", VA = "0x25AB4B0")]
			set
			{
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06001FDF RID: 8159 RVA: 0x0000C228 File Offset: 0x0000A428
		// (set) Token: 0x06001FE0 RID: 8160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700044B")]
		[DebuggerNonUserCode]
		public long TargetUuid
		{
			[Token(Token = "0x6001FDF")]
			[Address(RVA = "0x25AB4B8", Offset = "0x25AB4B8", VA = "0x25AB4B8")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6001FE0")]
			[Address(RVA = "0x25AB4C0", Offset = "0x25AB4C0", VA = "0x25AB4C0")]
			set
			{
			}
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x0000C240 File Offset: 0x0000A440
		[Token(Token = "0x6001FE1")]
		[Address(RVA = "0x25AB4C8", Offset = "0x25AB4C8", VA = "0x25AB4C8", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x0000C258 File Offset: 0x0000A458
		[Token(Token = "0x6001FE2")]
		[Address(RVA = "0x25AB52C", Offset = "0x25AB52C", VA = "0x25AB52C", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BaseRoundReportPush other)
		{
			return default(bool);
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x0000C270 File Offset: 0x0000A470
		[Token(Token = "0x6001FE3")]
		[Address(RVA = "0x25AB5AC", Offset = "0x25AB5AC", VA = "0x25AB5AC", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE4")]
		[Address(RVA = "0x25AB63C", Offset = "0x25AB63C", VA = "0x25AB63C", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE5")]
		[Address(RVA = "0x25AB694", Offset = "0x25AB694", VA = "0x25AB694", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x0000C288 File Offset: 0x0000A488
		[Token(Token = "0x6001FE6")]
		[Address(RVA = "0x25AB754", Offset = "0x25AB754", VA = "0x25AB754", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE7")]
		[Address(RVA = "0x25AB834", Offset = "0x25AB834", VA = "0x25AB834", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BaseRoundReportPush other)
		{
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE8")]
		[Address(RVA = "0x25AB91C", Offset = "0x25AB91C", VA = "0x25AB91C", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001EB5 RID: 7861
		[Token(Token = "0x4001EB5")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<BaseRoundReportPush> _parser;

		// Token: 0x04001EB6 RID: 7862
		[Token(Token = "0x4001EB6")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EB7 RID: 7863
		[Token(Token = "0x4001EB7")]
		public const int RoundReportFieldNumber = 1;

		// Token: 0x04001EB8 RID: 7864
		[Token(Token = "0x4001EB8")]
		[FieldOffset(Offset = "0x18")]
		private BaseRoundReport roundReport_;

		// Token: 0x04001EB9 RID: 7865
		[Token(Token = "0x4001EB9")]
		public const int TriggerUuidFieldNumber = 2;

		// Token: 0x04001EBA RID: 7866
		[Token(Token = "0x4001EBA")]
		[FieldOffset(Offset = "0x20")]
		private long triggerUuid_;

		// Token: 0x04001EBB RID: 7867
		[Token(Token = "0x4001EBB")]
		public const int TargetUuidFieldNumber = 3;

		// Token: 0x04001EBC RID: 7868
		[Token(Token = "0x4001EBC")]
		[FieldOffset(Offset = "0x28")]
		private long targetUuid_;
	}
}
