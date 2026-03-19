using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000436 RID: 1078
	[Token(Token = "0x2000436")]
	public sealed class DesertArmyResult : IMessage<DesertArmyResult>, IMessage, IEquatable<DesertArmyResult>, IDeepCloneable<DesertArmyResult>
	{
		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06001D4D RID: 7501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038F")]
		[DebuggerNonUserCode]
		public static MessageParser<DesertArmyResult> Parser
		{
			[Token(Token = "0x6001D4D")]
			[Address(RVA = "0x27009E8", Offset = "0x27009E8", VA = "0x27009E8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06001D4E RID: 7502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000390")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001D4E")]
			[Address(RVA = "0x2700A40", Offset = "0x2700A40", VA = "0x2700A40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06001D4F RID: 7503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000391")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001D4F")]
			[Address(RVA = "0x2700B44", Offset = "0x2700B44", VA = "0x2700B44", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D50 RID: 7504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D50")]
		[Address(RVA = "0x2700B90", Offset = "0x2700B90", VA = "0x2700B90")]
		[DebuggerNonUserCode]
		public DesertArmyResult()
		{
		}

		// Token: 0x06001D51 RID: 7505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D51")]
		[Address(RVA = "0x2700B98", Offset = "0x2700B98", VA = "0x2700B98")]
		[DebuggerNonUserCode]
		public DesertArmyResult(DesertArmyResult other)
		{
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D52")]
		[Address(RVA = "0x2700C0C", Offset = "0x2700C0C", VA = "0x2700C0C", Slot = "10")]
		[DebuggerNonUserCode]
		public DesertArmyResult Clone()
		{
			return null;
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06001D53 RID: 7507 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D54 RID: 7508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000392")]
		[DebuggerNonUserCode]
		public ArmyResultBase Base
		{
			[Token(Token = "0x6001D53")]
			[Address(RVA = "0x2700C6C", Offset = "0x2700C6C", VA = "0x2700C6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D54")]
			[Address(RVA = "0x2700C74", Offset = "0x2700C74", VA = "0x2700C74")]
			set
			{
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06001D55 RID: 7509 RVA: 0x0000B340 File Offset: 0x00009540
		// (set) Token: 0x06001D56 RID: 7510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000393")]
		[DebuggerNonUserCode]
		public int DesertId
		{
			[Token(Token = "0x6001D55")]
			[Address(RVA = "0x2700C7C", Offset = "0x2700C7C", VA = "0x2700C7C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001D56")]
			[Address(RVA = "0x2700C84", Offset = "0x2700C84", VA = "0x2700C84")]
			set
			{
			}
		}

		// Token: 0x06001D57 RID: 7511 RVA: 0x0000B358 File Offset: 0x00009558
		[Token(Token = "0x6001D57")]
		[Address(RVA = "0x2700C8C", Offset = "0x2700C8C", VA = "0x2700C8C", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001D58 RID: 7512 RVA: 0x0000B370 File Offset: 0x00009570
		[Token(Token = "0x6001D58")]
		[Address(RVA = "0x2700CF0", Offset = "0x2700CF0", VA = "0x2700CF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DesertArmyResult other)
		{
			return default(bool);
		}

		// Token: 0x06001D59 RID: 7513 RVA: 0x0000B388 File Offset: 0x00009588
		[Token(Token = "0x6001D59")]
		[Address(RVA = "0x2700D60", Offset = "0x2700D60", VA = "0x2700D60", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001D5A RID: 7514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D5A")]
		[Address(RVA = "0x2700DD4", Offset = "0x2700DD4", VA = "0x2700DD4", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001D5B RID: 7515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D5B")]
		[Address(RVA = "0x2700E2C", Offset = "0x2700E2C", VA = "0x2700E2C", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001D5C RID: 7516 RVA: 0x0000B3A0 File Offset: 0x000095A0
		[Token(Token = "0x6001D5C")]
		[Address(RVA = "0x2700EC0", Offset = "0x2700EC0", VA = "0x2700EC0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001D5D RID: 7517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D5D")]
		[Address(RVA = "0x2700F74", Offset = "0x2700F74", VA = "0x2700F74", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DesertArmyResult other)
		{
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D5E")]
		[Address(RVA = "0x2701048", Offset = "0x2701048", VA = "0x2701048", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001D81 RID: 7553
		[Token(Token = "0x4001D81")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<DesertArmyResult> _parser;

		// Token: 0x04001D82 RID: 7554
		[Token(Token = "0x4001D82")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D83 RID: 7555
		[Token(Token = "0x4001D83")]
		public const int BaseFieldNumber = 1;

		// Token: 0x04001D84 RID: 7556
		[Token(Token = "0x4001D84")]
		[FieldOffset(Offset = "0x18")]
		private ArmyResultBase base_;

		// Token: 0x04001D85 RID: 7557
		[Token(Token = "0x4001D85")]
		public const int DesertIdFieldNumber = 2;

		// Token: 0x04001D86 RID: 7558
		[Token(Token = "0x4001D86")]
		[FieldOffset(Offset = "0x20")]
		private int desertId_;
	}
}
