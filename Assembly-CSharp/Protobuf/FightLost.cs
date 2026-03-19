using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x0200044C RID: 1100
	[Token(Token = "0x200044C")]
	public sealed class FightLost : IMessage<FightLost>, IMessage, IEquatable<FightLost>, IDeepCloneable<FightLost>
	{
		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06001E76 RID: 7798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E4")]
		[DebuggerNonUserCode]
		public static MessageParser<FightLost> Parser
		{
			[Token(Token = "0x6001E76")]
			[Address(RVA = "0x259E418", Offset = "0x259E418", VA = "0x259E418")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06001E77 RID: 7799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E5")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001E77")]
			[Address(RVA = "0x259E470", Offset = "0x259E470", VA = "0x259E470")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06001E78 RID: 7800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E6")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001E78")]
			[Address(RVA = "0x259E574", Offset = "0x259E574", VA = "0x259E574", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E79")]
		[Address(RVA = "0x259E5C0", Offset = "0x259E5C0", VA = "0x259E5C0")]
		[DebuggerNonUserCode]
		public FightLost()
		{
		}

		// Token: 0x06001E7A RID: 7802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E7A")]
		[Address(RVA = "0x259E6E8", Offset = "0x259E6E8", VA = "0x259E6E8")]
		[DebuggerNonUserCode]
		public FightLost(FightLost other)
		{
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E7B")]
		[Address(RVA = "0x259E7DC", Offset = "0x259E7DC", VA = "0x259E7DC", Slot = "10")]
		[DebuggerNonUserCode]
		public FightLost Clone()
		{
			return null;
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06001E7C RID: 7804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E7")]
		[DebuggerNonUserCode]
		public RepeatedField<FightResLost> ResLostArr
		{
			[Token(Token = "0x6001E7C")]
			[Address(RVA = "0x259E83C", Offset = "0x259E83C", VA = "0x259E83C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06001E7D RID: 7805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E8")]
		[DebuggerNonUserCode]
		public RepeatedField<FightResItemLost> ResItemLostArr
		{
			[Token(Token = "0x6001E7D")]
			[Address(RVA = "0x259E844", Offset = "0x259E844", VA = "0x259E844")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06001E7E RID: 7806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E9")]
		[DebuggerNonUserCode]
		public RepeatedField<FightItemLost> ItemLostArr
		{
			[Token(Token = "0x6001E7E")]
			[Address(RVA = "0x259E84C", Offset = "0x259E84C", VA = "0x259E84C")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x0000B9D0 File Offset: 0x00009BD0
		[Token(Token = "0x6001E7F")]
		[Address(RVA = "0x259E854", Offset = "0x259E854", VA = "0x259E854", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		[Token(Token = "0x6001E80")]
		[Address(RVA = "0x259E8B8", Offset = "0x259E8B8", VA = "0x259E8B8", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FightLost other)
		{
			return default(bool);
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x0000BA00 File Offset: 0x00009C00
		[Token(Token = "0x6001E81")]
		[Address(RVA = "0x259E9A0", Offset = "0x259E9A0", VA = "0x259E9A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E82")]
		[Address(RVA = "0x259EA30", Offset = "0x259EA30", VA = "0x259EA30", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E83")]
		[Address(RVA = "0x259EA88", Offset = "0x259EA88", VA = "0x259EA88", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001E84 RID: 7812 RVA: 0x0000BA18 File Offset: 0x00009C18
		[Token(Token = "0x6001E84")]
		[Address(RVA = "0x259EBA8", Offset = "0x259EBA8", VA = "0x259EBA8", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E85")]
		[Address(RVA = "0x259ECC0", Offset = "0x259ECC0", VA = "0x259ECC0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FightLost other)
		{
		}

		// Token: 0x06001E86 RID: 7814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E86")]
		[Address(RVA = "0x259ED98", Offset = "0x259ED98", VA = "0x259ED98", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001E0F RID: 7695
		[Token(Token = "0x4001E0F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<FightLost> _parser;

		// Token: 0x04001E10 RID: 7696
		[Token(Token = "0x4001E10")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E11 RID: 7697
		[Token(Token = "0x4001E11")]
		public const int ResLostArrFieldNumber = 1;

		// Token: 0x04001E12 RID: 7698
		[Token(Token = "0x4001E12")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<FightResLost> _repeated_resLostArr_codec;

		// Token: 0x04001E13 RID: 7699
		[Token(Token = "0x4001E13")]
		[FieldOffset(Offset = "0x18")]
		private readonly RepeatedField<FightResLost> resLostArr_;

		// Token: 0x04001E14 RID: 7700
		[Token(Token = "0x4001E14")]
		public const int ResItemLostArrFieldNumber = 2;

		// Token: 0x04001E15 RID: 7701
		[Token(Token = "0x4001E15")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FieldCodec<FightResItemLost> _repeated_resItemLostArr_codec;

		// Token: 0x04001E16 RID: 7702
		[Token(Token = "0x4001E16")]
		[FieldOffset(Offset = "0x20")]
		private readonly RepeatedField<FightResItemLost> resItemLostArr_;

		// Token: 0x04001E17 RID: 7703
		[Token(Token = "0x4001E17")]
		public const int ItemLostArrFieldNumber = 3;

		// Token: 0x04001E18 RID: 7704
		[Token(Token = "0x4001E18")]
		[FieldOffset(Offset = "0x18")]
		private static readonly FieldCodec<FightItemLost> _repeated_itemLostArr_codec;

		// Token: 0x04001E19 RID: 7705
		[Token(Token = "0x4001E19")]
		[FieldOffset(Offset = "0x28")]
		private readonly RepeatedField<FightItemLost> itemLostArr_;
	}
}
