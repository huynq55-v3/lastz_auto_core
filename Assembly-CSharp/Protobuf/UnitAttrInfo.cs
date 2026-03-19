using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000440 RID: 1088
	[Token(Token = "0x2000440")]
	public sealed class UnitAttrInfo : IMessage<UnitAttrInfo>, IMessage, IEquatable<UnitAttrInfo>, IDeepCloneable<UnitAttrInfo>
	{
		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06001DEE RID: 7662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C3")]
		[DebuggerNonUserCode]
		public static MessageParser<UnitAttrInfo> Parser
		{
			[Token(Token = "0x6001DEE")]
			[Address(RVA = "0x259AB6C", Offset = "0x259AB6C", VA = "0x259AB6C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06001DEF RID: 7663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C4")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001DEF")]
			[Address(RVA = "0x259ABC4", Offset = "0x259ABC4", VA = "0x259ABC4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C5")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001DF0")]
			[Address(RVA = "0x259ACC8", Offset = "0x259ACC8", VA = "0x259ACC8", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DF1 RID: 7665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DF1")]
		[Address(RVA = "0x259AD14", Offset = "0x259AD14", VA = "0x259AD14")]
		[DebuggerNonUserCode]
		public UnitAttrInfo()
		{
		}

		// Token: 0x06001DF2 RID: 7666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DF2")]
		[Address(RVA = "0x259ADCC", Offset = "0x259ADCC", VA = "0x259ADCC")]
		[DebuggerNonUserCode]
		public UnitAttrInfo(UnitAttrInfo other)
		{
		}

		// Token: 0x06001DF3 RID: 7667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DF3")]
		[Address(RVA = "0x259AE80", Offset = "0x259AE80", VA = "0x259AE80", Slot = "10")]
		[DebuggerNonUserCode]
		public UnitAttrInfo Clone()
		{
			return null;
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06001DF4 RID: 7668 RVA: 0x0000B670 File Offset: 0x00009870
		// (set) Token: 0x06001DF5 RID: 7669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003C6")]
		[DebuggerNonUserCode]
		public long Uuid
		{
			[Token(Token = "0x6001DF4")]
			[Address(RVA = "0x259AEE0", Offset = "0x259AEE0", VA = "0x259AEE0")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6001DF5")]
			[Address(RVA = "0x259AEE8", Offset = "0x259AEE8", VA = "0x259AEE8")]
			set
			{
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06001DF6 RID: 7670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C7")]
		[DebuggerNonUserCode]
		public RepeatedField<ArmyAttrInfo> AtkInfo
		{
			[Token(Token = "0x6001DF6")]
			[Address(RVA = "0x259AEF0", Offset = "0x259AEF0", VA = "0x259AEF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06001DF7 RID: 7671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C8")]
		[DebuggerNonUserCode]
		public RepeatedField<ArmyAttrInfo> DefInfo
		{
			[Token(Token = "0x6001DF7")]
			[Address(RVA = "0x259AEF8", Offset = "0x259AEF8", VA = "0x259AEF8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x0000B688 File Offset: 0x00009888
		[Token(Token = "0x6001DF8")]
		[Address(RVA = "0x259AF00", Offset = "0x259AF00", VA = "0x259AF00", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001DF9 RID: 7673 RVA: 0x0000B6A0 File Offset: 0x000098A0
		[Token(Token = "0x6001DF9")]
		[Address(RVA = "0x259AF64", Offset = "0x259AF64", VA = "0x259AF64", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(UnitAttrInfo other)
		{
			return default(bool);
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x0000B6B8 File Offset: 0x000098B8
		[Token(Token = "0x6001DFA")]
		[Address(RVA = "0x259B01C", Offset = "0x259B01C", VA = "0x259B01C", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DFB")]
		[Address(RVA = "0x259B0B4", Offset = "0x259B0B4", VA = "0x259B0B4", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DFC")]
		[Address(RVA = "0x259B10C", Offset = "0x259B10C", VA = "0x259B10C", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x0000B6D0 File Offset: 0x000098D0
		[Token(Token = "0x6001DFD")]
		[Address(RVA = "0x259B210", Offset = "0x259B210", VA = "0x259B210", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001DFE RID: 7678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DFE")]
		[Address(RVA = "0x259B328", Offset = "0x259B328", VA = "0x259B328", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(UnitAttrInfo other)
		{
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DFF")]
		[Address(RVA = "0x259B3D0", Offset = "0x259B3D0", VA = "0x259B3D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001DDD RID: 7645
		[Token(Token = "0x4001DDD")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<UnitAttrInfo> _parser;

		// Token: 0x04001DDE RID: 7646
		[Token(Token = "0x4001DDE")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DDF RID: 7647
		[Token(Token = "0x4001DDF")]
		public const int UuidFieldNumber = 1;

		// Token: 0x04001DE0 RID: 7648
		[Token(Token = "0x4001DE0")]
		[FieldOffset(Offset = "0x18")]
		private long uuid_;

		// Token: 0x04001DE1 RID: 7649
		[Token(Token = "0x4001DE1")]
		public const int AtkInfoFieldNumber = 4;

		// Token: 0x04001DE2 RID: 7650
		[Token(Token = "0x4001DE2")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<ArmyAttrInfo> _repeated_atkInfo_codec;

		// Token: 0x04001DE3 RID: 7651
		[Token(Token = "0x4001DE3")]
		[FieldOffset(Offset = "0x20")]
		private readonly RepeatedField<ArmyAttrInfo> atkInfo_;

		// Token: 0x04001DE4 RID: 7652
		[Token(Token = "0x4001DE4")]
		public const int DefInfoFieldNumber = 5;

		// Token: 0x04001DE5 RID: 7653
		[Token(Token = "0x4001DE5")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FieldCodec<ArmyAttrInfo> _repeated_defInfo_codec;

		// Token: 0x04001DE6 RID: 7654
		[Token(Token = "0x4001DE6")]
		[FieldOffset(Offset = "0x28")]
		private readonly RepeatedField<ArmyAttrInfo> defInfo_;
	}
}
