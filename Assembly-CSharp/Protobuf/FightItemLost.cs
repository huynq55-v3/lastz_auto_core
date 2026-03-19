using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x0200044A RID: 1098
	[Token(Token = "0x200044A")]
	public sealed class FightItemLost : IMessage<FightItemLost>, IMessage, IEquatable<FightItemLost>, IDeepCloneable<FightItemLost>
	{
		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06001E60 RID: 7776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003DF")]
		[DebuggerNonUserCode]
		public static MessageParser<FightItemLost> Parser
		{
			[Token(Token = "0x6001E60")]
			[Address(RVA = "0x259DACC", Offset = "0x259DACC", VA = "0x259DACC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001E61 RID: 7777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E0")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001E61")]
			[Address(RVA = "0x259DB24", Offset = "0x259DB24", VA = "0x259DB24")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001E62 RID: 7778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E1")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001E62")]
			[Address(RVA = "0x259DC28", Offset = "0x259DC28", VA = "0x259DC28", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E63")]
		[Address(RVA = "0x259DC74", Offset = "0x259DC74", VA = "0x259DC74")]
		[DebuggerNonUserCode]
		public FightItemLost()
		{
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E64")]
		[Address(RVA = "0x259DCCC", Offset = "0x259DCCC", VA = "0x259DCCC")]
		[DebuggerNonUserCode]
		public FightItemLost(FightItemLost other)
		{
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E65")]
		[Address(RVA = "0x259DD24", Offset = "0x259DD24", VA = "0x259DD24", Slot = "10")]
		[DebuggerNonUserCode]
		public FightItemLost Clone()
		{
			return null;
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06001E66 RID: 7782 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001E67 RID: 7783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003E2")]
		[DebuggerNonUserCode]
		public string ItemId
		{
			[Token(Token = "0x6001E66")]
			[Address(RVA = "0x259DD84", Offset = "0x259DD84", VA = "0x259DD84")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E67")]
			[Address(RVA = "0x259DD8C", Offset = "0x259DD8C", VA = "0x259DD8C")]
			set
			{
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06001E68 RID: 7784 RVA: 0x0000B958 File Offset: 0x00009B58
		// (set) Token: 0x06001E69 RID: 7785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003E3")]
		[DebuggerNonUserCode]
		public int Value
		{
			[Token(Token = "0x6001E68")]
			[Address(RVA = "0x259DE08", Offset = "0x259DE08", VA = "0x259DE08")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001E69")]
			[Address(RVA = "0x259DE10", Offset = "0x259DE10", VA = "0x259DE10")]
			set
			{
			}
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x0000B970 File Offset: 0x00009B70
		[Token(Token = "0x6001E6A")]
		[Address(RVA = "0x259DE18", Offset = "0x259DE18", VA = "0x259DE18", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x0000B988 File Offset: 0x00009B88
		[Token(Token = "0x6001E6B")]
		[Address(RVA = "0x259DE7C", Offset = "0x259DE7C", VA = "0x259DE7C", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FightItemLost other)
		{
			return default(bool);
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x0000B9A0 File Offset: 0x00009BA0
		[Token(Token = "0x6001E6C")]
		[Address(RVA = "0x259DEEC", Offset = "0x259DEEC", VA = "0x259DEEC", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E6D")]
		[Address(RVA = "0x259DF6C", Offset = "0x259DF6C", VA = "0x259DF6C", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E6E")]
		[Address(RVA = "0x259DFC4", Offset = "0x259DFC4", VA = "0x259DFC4", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x0000B9B8 File Offset: 0x00009BB8
		[Token(Token = "0x6001E6F")]
		[Address(RVA = "0x259E060", Offset = "0x259E060", VA = "0x259E060", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E70")]
		[Address(RVA = "0x259E128", Offset = "0x259E128", VA = "0x259E128", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FightItemLost other)
		{
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E71")]
		[Address(RVA = "0x259E198", Offset = "0x259E198", VA = "0x259E198", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001E08 RID: 7688
		[Token(Token = "0x4001E08")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<FightItemLost> _parser;

		// Token: 0x04001E09 RID: 7689
		[Token(Token = "0x4001E09")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E0A RID: 7690
		[Token(Token = "0x4001E0A")]
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04001E0B RID: 7691
		[Token(Token = "0x4001E0B")]
		[FieldOffset(Offset = "0x18")]
		private string itemId_;

		// Token: 0x04001E0C RID: 7692
		[Token(Token = "0x4001E0C")]
		public const int ValueFieldNumber = 2;

		// Token: 0x04001E0D RID: 7693
		[Token(Token = "0x4001E0D")]
		[FieldOffset(Offset = "0x20")]
		private int value_;
	}
}
