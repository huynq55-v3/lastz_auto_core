using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x0200041E RID: 1054
	[Token(Token = "0x200041E")]
	public sealed class CombineCombatUnit : IMessage<CombineCombatUnit>, IMessage, IEquatable<CombineCombatUnit>, IDeepCloneable<CombineCombatUnit>
	{
		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06001C26 RID: 7206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000342")]
		[DebuggerNonUserCode]
		public static MessageParser<CombineCombatUnit> Parser
		{
			[Token(Token = "0x6001C26")]
			[Address(RVA = "0x26F83B8", Offset = "0x26F83B8", VA = "0x26F83B8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06001C27 RID: 7207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000343")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001C27")]
			[Address(RVA = "0x26F8410", Offset = "0x26F8410", VA = "0x26F8410")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06001C28 RID: 7208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000344")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001C28")]
			[Address(RVA = "0x26F8514", Offset = "0x26F8514", VA = "0x26F8514", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C29")]
		[Address(RVA = "0x26F8560", Offset = "0x26F8560", VA = "0x26F8560")]
		[DebuggerNonUserCode]
		public CombineCombatUnit()
		{
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C2A")]
		[Address(RVA = "0x26F85E8", Offset = "0x26F85E8", VA = "0x26F85E8")]
		[DebuggerNonUserCode]
		public CombineCombatUnit(CombineCombatUnit other)
		{
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C2B")]
		[Address(RVA = "0x26F86A0", Offset = "0x26F86A0", VA = "0x26F86A0", Slot = "10")]
		[DebuggerNonUserCode]
		public CombineCombatUnit Clone()
		{
			return null;
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06001C2C RID: 7212 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C2D RID: 7213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000345")]
		[DebuggerNonUserCode]
		public SimpleCombatUnit SimpleCombatUnit
		{
			[Token(Token = "0x6001C2C")]
			[Address(RVA = "0x26F8700", Offset = "0x26F8700", VA = "0x26F8700")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C2D")]
			[Address(RVA = "0x26F8708", Offset = "0x26F8708", VA = "0x26F8708")]
			set
			{
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06001C2E RID: 7214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000346")]
		[DebuggerNonUserCode]
		public RepeatedField<ArmyCombatUnit> Members
		{
			[Token(Token = "0x6001C2E")]
			[Address(RVA = "0x26F8710", Offset = "0x26F8710", VA = "0x26F8710")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x0000AC98 File Offset: 0x00008E98
		[Token(Token = "0x6001C2F")]
		[Address(RVA = "0x26F8718", Offset = "0x26F8718", VA = "0x26F8718", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x0000ACB0 File Offset: 0x00008EB0
		[Token(Token = "0x6001C30")]
		[Address(RVA = "0x26F877C", Offset = "0x26F877C", VA = "0x26F877C", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CombineCombatUnit other)
		{
			return default(bool);
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x0000ACC8 File Offset: 0x00008EC8
		[Token(Token = "0x6001C31")]
		[Address(RVA = "0x26F8820", Offset = "0x26F8820", VA = "0x26F8820", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C32")]
		[Address(RVA = "0x26F8894", Offset = "0x26F8894", VA = "0x26F8894", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C33")]
		[Address(RVA = "0x26F88EC", Offset = "0x26F88EC", VA = "0x26F88EC", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x0000ACE0 File Offset: 0x00008EE0
		[Token(Token = "0x6001C34")]
		[Address(RVA = "0x26F89D0", Offset = "0x26F89D0", VA = "0x26F89D0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C35")]
		[Address(RVA = "0x26F8AC4", Offset = "0x26F8AC4", VA = "0x26F8AC4", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CombineCombatUnit other)
		{
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C36")]
		[Address(RVA = "0x26F8BB4", Offset = "0x26F8BB4", VA = "0x26F8BB4", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001D08 RID: 7432
		[Token(Token = "0x4001D08")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<CombineCombatUnit> _parser;

		// Token: 0x04001D09 RID: 7433
		[Token(Token = "0x4001D09")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D0A RID: 7434
		[Token(Token = "0x4001D0A")]
		public const int SimpleCombatUnitFieldNumber = 1;

		// Token: 0x04001D0B RID: 7435
		[Token(Token = "0x4001D0B")]
		[FieldOffset(Offset = "0x18")]
		private SimpleCombatUnit simpleCombatUnit_;

		// Token: 0x04001D0C RID: 7436
		[Token(Token = "0x4001D0C")]
		public const int MembersFieldNumber = 2;

		// Token: 0x04001D0D RID: 7437
		[Token(Token = "0x4001D0D")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<ArmyCombatUnit> _repeated_members_codec;

		// Token: 0x04001D0E RID: 7438
		[Token(Token = "0x4001D0E")]
		[FieldOffset(Offset = "0x20")]
		private readonly RepeatedField<ArmyCombatUnit> members_;
	}
}
