using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000446 RID: 1094
	[Token(Token = "0x2000446")]
	public sealed class FightResLost : IMessage<FightResLost>, IMessage, IEquatable<FightResLost>, IDeepCloneable<FightResLost>
	{
		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06001E34 RID: 7732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D5")]
		[DebuggerNonUserCode]
		public static MessageParser<FightResLost> Parser
		{
			[Token(Token = "0x6001E34")]
			[Address(RVA = "0x259CAB4", Offset = "0x259CAB4", VA = "0x259CAB4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06001E35 RID: 7733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D6")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001E35")]
			[Address(RVA = "0x259CB0C", Offset = "0x259CB0C", VA = "0x259CB0C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06001E36 RID: 7734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D7")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001E36")]
			[Address(RVA = "0x259CC10", Offset = "0x259CC10", VA = "0x259CC10", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E37")]
		[Address(RVA = "0x259CC5C", Offset = "0x259CC5C", VA = "0x259CC5C")]
		[DebuggerNonUserCode]
		public FightResLost()
		{
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E38")]
		[Address(RVA = "0x259CC64", Offset = "0x259CC64", VA = "0x259CC64")]
		[DebuggerNonUserCode]
		public FightResLost(FightResLost other)
		{
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E39")]
		[Address(RVA = "0x259CCB0", Offset = "0x259CCB0", VA = "0x259CCB0", Slot = "10")]
		[DebuggerNonUserCode]
		public FightResLost Clone()
		{
			return null;
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06001E3A RID: 7738 RVA: 0x0000B838 File Offset: 0x00009A38
		// (set) Token: 0x06001E3B RID: 7739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003D8")]
		[DebuggerNonUserCode]
		public int Type
		{
			[Token(Token = "0x6001E3A")]
			[Address(RVA = "0x259CD10", Offset = "0x259CD10", VA = "0x259CD10")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001E3B")]
			[Address(RVA = "0x259CD18", Offset = "0x259CD18", VA = "0x259CD18")]
			set
			{
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06001E3C RID: 7740 RVA: 0x0000B850 File Offset: 0x00009A50
		// (set) Token: 0x06001E3D RID: 7741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003D9")]
		[DebuggerNonUserCode]
		public int Value
		{
			[Token(Token = "0x6001E3C")]
			[Address(RVA = "0x259CD20", Offset = "0x259CD20", VA = "0x259CD20")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001E3D")]
			[Address(RVA = "0x259CD28", Offset = "0x259CD28", VA = "0x259CD28")]
			set
			{
			}
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x0000B868 File Offset: 0x00009A68
		[Token(Token = "0x6001E3E")]
		[Address(RVA = "0x259CD30", Offset = "0x259CD30", VA = "0x259CD30", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x0000B880 File Offset: 0x00009A80
		[Token(Token = "0x6001E3F")]
		[Address(RVA = "0x259CD94", Offset = "0x259CD94", VA = "0x259CD94", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FightResLost other)
		{
			return default(bool);
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x0000B898 File Offset: 0x00009A98
		[Token(Token = "0x6001E40")]
		[Address(RVA = "0x259CDE0", Offset = "0x259CDE0", VA = "0x259CDE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E41")]
		[Address(RVA = "0x259CE58", Offset = "0x259CE58", VA = "0x259CE58", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E42")]
		[Address(RVA = "0x259CEB0", Offset = "0x259CEB0", VA = "0x259CEB0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x0000B8B0 File Offset: 0x00009AB0
		[Token(Token = "0x6001E43")]
		[Address(RVA = "0x259CF44", Offset = "0x259CF44", VA = "0x259CF44", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E44")]
		[Address(RVA = "0x259CFF8", Offset = "0x259CFF8", VA = "0x259CFF8", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FightResLost other)
		{
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E45")]
		[Address(RVA = "0x259D044", Offset = "0x259D044", VA = "0x259D044", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001DFA RID: 7674
		[Token(Token = "0x4001DFA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<FightResLost> _parser;

		// Token: 0x04001DFB RID: 7675
		[Token(Token = "0x4001DFB")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DFC RID: 7676
		[Token(Token = "0x4001DFC")]
		public const int TypeFieldNumber = 1;

		// Token: 0x04001DFD RID: 7677
		[Token(Token = "0x4001DFD")]
		[FieldOffset(Offset = "0x18")]
		private int type_;

		// Token: 0x04001DFE RID: 7678
		[Token(Token = "0x4001DFE")]
		public const int ValueFieldNumber = 2;

		// Token: 0x04001DFF RID: 7679
		[Token(Token = "0x4001DFF")]
		[FieldOffset(Offset = "0x1C")]
		private int value_;
	}
}
