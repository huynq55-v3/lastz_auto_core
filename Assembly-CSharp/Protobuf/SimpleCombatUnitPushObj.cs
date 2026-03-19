using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000463 RID: 1123
	[Token(Token = "0x2000463")]
	public sealed class SimpleCombatUnitPushObj : IMessage<SimpleCombatUnitPushObj>, IMessage, IEquatable<SimpleCombatUnitPushObj>, IDeepCloneable<SimpleCombatUnitPushObj>
	{
		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06001F81 RID: 8065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700042D")]
		[DebuggerNonUserCode]
		public static MessageParser<SimpleCombatUnitPushObj> Parser
		{
			[Token(Token = "0x6001F81")]
			[Address(RVA = "0x25A88E0", Offset = "0x25A88E0", VA = "0x25A88E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06001F82 RID: 8066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700042E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001F82")]
			[Address(RVA = "0x25A8938", Offset = "0x25A8938", VA = "0x25A8938")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06001F83 RID: 8067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700042F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001F83")]
			[Address(RVA = "0x25A8A3C", Offset = "0x25A8A3C", VA = "0x25A8A3C", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F84 RID: 8068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F84")]
		[Address(RVA = "0x25A8A88", Offset = "0x25A8A88", VA = "0x25A8A88")]
		[DebuggerNonUserCode]
		public SimpleCombatUnitPushObj()
		{
		}

		// Token: 0x06001F85 RID: 8069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F85")]
		[Address(RVA = "0x25A8A90", Offset = "0x25A8A90", VA = "0x25A8A90")]
		[DebuggerNonUserCode]
		public SimpleCombatUnitPushObj(SimpleCombatUnitPushObj other)
		{
		}

		// Token: 0x06001F86 RID: 8070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F86")]
		[Address(RVA = "0x25A8B18", Offset = "0x25A8B18", VA = "0x25A8B18", Slot = "10")]
		[DebuggerNonUserCode]
		public SimpleCombatUnitPushObj Clone()
		{
			return null;
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001F87 RID: 8071 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F88 RID: 8072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000430")]
		[DebuggerNonUserCode]
		public SimpleCombatUnit ArmyInfo
		{
			[Token(Token = "0x6001F87")]
			[Address(RVA = "0x25A8B78", Offset = "0x25A8B78", VA = "0x25A8B78")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F88")]
			[Address(RVA = "0x25A8B80", Offset = "0x25A8B80", VA = "0x25A8B80")]
			set
			{
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001F89 RID: 8073 RVA: 0x0000C000 File Offset: 0x0000A200
		// (set) Token: 0x06001F8A RID: 8074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000431")]
		[DebuggerNonUserCode]
		public int Type
		{
			[Token(Token = "0x6001F89")]
			[Address(RVA = "0x25A8B88", Offset = "0x25A8B88", VA = "0x25A8B88")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001F8A")]
			[Address(RVA = "0x25A8B90", Offset = "0x25A8B90", VA = "0x25A8B90")]
			set
			{
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001F8B RID: 8075 RVA: 0x0000C018 File Offset: 0x0000A218
		// (set) Token: 0x06001F8C RID: 8076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000432")]
		[DebuggerNonUserCode]
		public long TopUuid
		{
			[Token(Token = "0x6001F8B")]
			[Address(RVA = "0x25A8B98", Offset = "0x25A8B98", VA = "0x25A8B98")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6001F8C")]
			[Address(RVA = "0x25A8BA0", Offset = "0x25A8BA0", VA = "0x25A8BA0")]
			set
			{
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06001F8D RID: 8077 RVA: 0x0000C030 File Offset: 0x0000A230
		// (set) Token: 0x06001F8E RID: 8078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000433")]
		[DebuggerNonUserCode]
		public int TopPointId
		{
			[Token(Token = "0x6001F8D")]
			[Address(RVA = "0x25A8BA8", Offset = "0x25A8BA8", VA = "0x25A8BA8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001F8E")]
			[Address(RVA = "0x25A8BB0", Offset = "0x25A8BB0", VA = "0x25A8BB0")]
			set
			{
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06001F8F RID: 8079 RVA: 0x0000C048 File Offset: 0x0000A248
		// (set) Token: 0x06001F90 RID: 8080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000434")]
		[DebuggerNonUserCode]
		public int SpecialArmyType
		{
			[Token(Token = "0x6001F8F")]
			[Address(RVA = "0x25A8BB8", Offset = "0x25A8BB8", VA = "0x25A8BB8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001F90")]
			[Address(RVA = "0x25A8BC0", Offset = "0x25A8BC0", VA = "0x25A8BC0")]
			set
			{
			}
		}

		// Token: 0x06001F91 RID: 8081 RVA: 0x0000C060 File Offset: 0x0000A260
		[Token(Token = "0x6001F91")]
		[Address(RVA = "0x25A8BC8", Offset = "0x25A8BC8", VA = "0x25A8BC8", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x0000C078 File Offset: 0x0000A278
		[Token(Token = "0x6001F92")]
		[Address(RVA = "0x25A8C2C", Offset = "0x25A8C2C", VA = "0x25A8C2C", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SimpleCombatUnitPushObj other)
		{
			return default(bool);
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x0000C090 File Offset: 0x0000A290
		[Token(Token = "0x6001F93")]
		[Address(RVA = "0x25A8CCC", Offset = "0x25A8CCC", VA = "0x25A8CCC", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F94")]
		[Address(RVA = "0x25A8D9C", Offset = "0x25A8D9C", VA = "0x25A8D9C", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F95")]
		[Address(RVA = "0x25A8DF4", Offset = "0x25A8DF4", VA = "0x25A8DF4", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x0000C0A8 File Offset: 0x0000A2A8
		[Token(Token = "0x6001F96")]
		[Address(RVA = "0x25A8F0C", Offset = "0x25A8F0C", VA = "0x25A8F0C", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F97")]
		[Address(RVA = "0x25A9044", Offset = "0x25A9044", VA = "0x25A9044", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SimpleCombatUnitPushObj other)
		{
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F98")]
		[Address(RVA = "0x25A9144", Offset = "0x25A9144", VA = "0x25A9144", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001E8A RID: 7818
		[Token(Token = "0x4001E8A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<SimpleCombatUnitPushObj> _parser;

		// Token: 0x04001E8B RID: 7819
		[Token(Token = "0x4001E8B")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E8C RID: 7820
		[Token(Token = "0x4001E8C")]
		public const int ArmyInfoFieldNumber = 1;

		// Token: 0x04001E8D RID: 7821
		[Token(Token = "0x4001E8D")]
		[FieldOffset(Offset = "0x18")]
		private SimpleCombatUnit armyInfo_;

		// Token: 0x04001E8E RID: 7822
		[Token(Token = "0x4001E8E")]
		public const int TypeFieldNumber = 2;

		// Token: 0x04001E8F RID: 7823
		[Token(Token = "0x4001E8F")]
		[FieldOffset(Offset = "0x20")]
		private int type_;

		// Token: 0x04001E90 RID: 7824
		[Token(Token = "0x4001E90")]
		public const int TopUuidFieldNumber = 3;

		// Token: 0x04001E91 RID: 7825
		[Token(Token = "0x4001E91")]
		[FieldOffset(Offset = "0x28")]
		private long topUuid_;

		// Token: 0x04001E92 RID: 7826
		[Token(Token = "0x4001E92")]
		public const int TopPointIdFieldNumber = 4;

		// Token: 0x04001E93 RID: 7827
		[Token(Token = "0x4001E93")]
		[FieldOffset(Offset = "0x30")]
		private int topPointId_;

		// Token: 0x04001E94 RID: 7828
		[Token(Token = "0x4001E94")]
		public const int SpecialArmyTypeFieldNumber = 5;

		// Token: 0x04001E95 RID: 7829
		[Token(Token = "0x4001E95")]
		[FieldOffset(Offset = "0x34")]
		private int specialArmyType_;
	}
}
