using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000430 RID: 1072
	[Token(Token = "0x2000430")]
	public sealed class MonsterArmyResult : IMessage<MonsterArmyResult>, IMessage, IEquatable<MonsterArmyResult>, IDeepCloneable<MonsterArmyResult>
	{
		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06001D03 RID: 7427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700037C")]
		[DebuggerNonUserCode]
		public static MessageParser<MonsterArmyResult> Parser
		{
			[Token(Token = "0x6001D03")]
			[Address(RVA = "0x26FEA18", Offset = "0x26FEA18", VA = "0x26FEA18")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06001D04 RID: 7428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700037D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001D04")]
			[Address(RVA = "0x26FEA70", Offset = "0x26FEA70", VA = "0x26FEA70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06001D05 RID: 7429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700037E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001D05")]
			[Address(RVA = "0x26FEB74", Offset = "0x26FEB74", VA = "0x26FEB74", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D06")]
		[Address(RVA = "0x26FEBC0", Offset = "0x26FEBC0", VA = "0x26FEBC0")]
		[DebuggerNonUserCode]
		public MonsterArmyResult()
		{
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D07")]
		[Address(RVA = "0x26FEBC8", Offset = "0x26FEBC8", VA = "0x26FEBC8")]
		[DebuggerNonUserCode]
		public MonsterArmyResult(MonsterArmyResult other)
		{
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D08")]
		[Address(RVA = "0x26FEC3C", Offset = "0x26FEC3C", VA = "0x26FEC3C", Slot = "10")]
		[DebuggerNonUserCode]
		public MonsterArmyResult Clone()
		{
			return null;
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06001D09 RID: 7433 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D0A RID: 7434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700037F")]
		[DebuggerNonUserCode]
		public ArmyResultBase Base
		{
			[Token(Token = "0x6001D09")]
			[Address(RVA = "0x26FEC9C", Offset = "0x26FEC9C", VA = "0x26FEC9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D0A")]
			[Address(RVA = "0x26FECA4", Offset = "0x26FECA4", VA = "0x26FECA4")]
			set
			{
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06001D0B RID: 7435 RVA: 0x0000B190 File Offset: 0x00009390
		// (set) Token: 0x06001D0C RID: 7436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000380")]
		[DebuggerNonUserCode]
		public int MonsterId
		{
			[Token(Token = "0x6001D0B")]
			[Address(RVA = "0x26FECAC", Offset = "0x26FECAC", VA = "0x26FECAC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001D0C")]
			[Address(RVA = "0x26FECB4", Offset = "0x26FECB4", VA = "0x26FECB4")]
			set
			{
			}
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x0000B1A8 File Offset: 0x000093A8
		[Token(Token = "0x6001D0D")]
		[Address(RVA = "0x26FECBC", Offset = "0x26FECBC", VA = "0x26FECBC", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x0000B1C0 File Offset: 0x000093C0
		[Token(Token = "0x6001D0E")]
		[Address(RVA = "0x26FED20", Offset = "0x26FED20", VA = "0x26FED20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MonsterArmyResult other)
		{
			return default(bool);
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x0000B1D8 File Offset: 0x000093D8
		[Token(Token = "0x6001D0F")]
		[Address(RVA = "0x26FED90", Offset = "0x26FED90", VA = "0x26FED90", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D10")]
		[Address(RVA = "0x26FEE04", Offset = "0x26FEE04", VA = "0x26FEE04", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D11")]
		[Address(RVA = "0x26FEE5C", Offset = "0x26FEE5C", VA = "0x26FEE5C", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x0000B1F0 File Offset: 0x000093F0
		[Token(Token = "0x6001D12")]
		[Address(RVA = "0x26FEEF0", Offset = "0x26FEEF0", VA = "0x26FEEF0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D13")]
		[Address(RVA = "0x26FEFA4", Offset = "0x26FEFA4", VA = "0x26FEFA4", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MonsterArmyResult other)
		{
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D14")]
		[Address(RVA = "0x26FF078", Offset = "0x26FF078", VA = "0x26FF078", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001D64 RID: 7524
		[Token(Token = "0x4001D64")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<MonsterArmyResult> _parser;

		// Token: 0x04001D65 RID: 7525
		[Token(Token = "0x4001D65")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D66 RID: 7526
		[Token(Token = "0x4001D66")]
		public const int BaseFieldNumber = 1;

		// Token: 0x04001D67 RID: 7527
		[Token(Token = "0x4001D67")]
		[FieldOffset(Offset = "0x18")]
		private ArmyResultBase base_;

		// Token: 0x04001D68 RID: 7528
		[Token(Token = "0x4001D68")]
		public const int MonsterIdFieldNumber = 2;

		// Token: 0x04001D69 RID: 7529
		[Token(Token = "0x4001D69")]
		[FieldOffset(Offset = "0x20")]
		private int monsterId_;
	}
}
