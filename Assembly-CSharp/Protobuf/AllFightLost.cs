using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x0200044E RID: 1102
	[Token(Token = "0x200044E")]
	public sealed class AllFightLost : IMessage<AllFightLost>, IMessage, IEquatable<AllFightLost>, IDeepCloneable<AllFightLost>
	{
		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06001E8B RID: 7819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003EA")]
		[DebuggerNonUserCode]
		public static MessageParser<AllFightLost> Parser
		{
			[Token(Token = "0x6001E8B")]
			[Address(RVA = "0x259F2D4", Offset = "0x259F2D4", VA = "0x259F2D4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06001E8C RID: 7820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003EB")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001E8C")]
			[Address(RVA = "0x259F32C", Offset = "0x259F32C", VA = "0x259F32C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06001E8D RID: 7821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003EC")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001E8D")]
			[Address(RVA = "0x259F430", Offset = "0x259F430", VA = "0x259F430", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E8E RID: 7822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E8E")]
		[Address(RVA = "0x259F47C", Offset = "0x259F47C", VA = "0x259F47C")]
		[DebuggerNonUserCode]
		public AllFightLost()
		{
		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E8F")]
		[Address(RVA = "0x259F484", Offset = "0x259F484", VA = "0x259F484")]
		[DebuggerNonUserCode]
		public AllFightLost(AllFightLost other)
		{
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E90")]
		[Address(RVA = "0x259F4F8", Offset = "0x259F4F8", VA = "0x259F4F8", Slot = "10")]
		[DebuggerNonUserCode]
		public AllFightLost Clone()
		{
			return null;
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06001E91 RID: 7825 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001E92 RID: 7826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003ED")]
		[DebuggerNonUserCode]
		public FightLost Lost
		{
			[Token(Token = "0x6001E91")]
			[Address(RVA = "0x259F558", Offset = "0x259F558", VA = "0x259F558")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E92")]
			[Address(RVA = "0x259F560", Offset = "0x259F560", VA = "0x259F560")]
			set
			{
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06001E93 RID: 7827 RVA: 0x0000BA30 File Offset: 0x00009C30
		// (set) Token: 0x06001E94 RID: 7828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003EE")]
		[DebuggerNonUserCode]
		public long Uuid
		{
			[Token(Token = "0x6001E93")]
			[Address(RVA = "0x259F568", Offset = "0x259F568", VA = "0x259F568")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6001E94")]
			[Address(RVA = "0x259F570", Offset = "0x259F570", VA = "0x259F570")]
			set
			{
			}
		}

		// Token: 0x06001E95 RID: 7829 RVA: 0x0000BA48 File Offset: 0x00009C48
		[Token(Token = "0x6001E95")]
		[Address(RVA = "0x259F578", Offset = "0x259F578", VA = "0x259F578", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001E96 RID: 7830 RVA: 0x0000BA60 File Offset: 0x00009C60
		[Token(Token = "0x6001E96")]
		[Address(RVA = "0x259F5DC", Offset = "0x259F5DC", VA = "0x259F5DC", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(AllFightLost other)
		{
			return default(bool);
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x0000BA78 File Offset: 0x00009C78
		[Token(Token = "0x6001E97")]
		[Address(RVA = "0x259F64C", Offset = "0x259F64C", VA = "0x259F64C", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E98")]
		[Address(RVA = "0x259F6C0", Offset = "0x259F6C0", VA = "0x259F6C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E99")]
		[Address(RVA = "0x259F718", Offset = "0x259F718", VA = "0x259F718", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x0000BA90 File Offset: 0x00009C90
		[Token(Token = "0x6001E9A")]
		[Address(RVA = "0x259F7AC", Offset = "0x259F7AC", VA = "0x259F7AC", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E9B")]
		[Address(RVA = "0x259F860", Offset = "0x259F860", VA = "0x259F860", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(AllFightLost other)
		{
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E9C")]
		[Address(RVA = "0x259F934", Offset = "0x259F934", VA = "0x259F934", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001E1B RID: 7707
		[Token(Token = "0x4001E1B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<AllFightLost> _parser;

		// Token: 0x04001E1C RID: 7708
		[Token(Token = "0x4001E1C")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E1D RID: 7709
		[Token(Token = "0x4001E1D")]
		public const int LostFieldNumber = 1;

		// Token: 0x04001E1E RID: 7710
		[Token(Token = "0x4001E1E")]
		[FieldOffset(Offset = "0x18")]
		private FightLost lost_;

		// Token: 0x04001E1F RID: 7711
		[Token(Token = "0x4001E1F")]
		public const int UuidFieldNumber = 2;

		// Token: 0x04001E20 RID: 7712
		[Token(Token = "0x4001E20")]
		[FieldOffset(Offset = "0x20")]
		private long uuid_;
	}
}
