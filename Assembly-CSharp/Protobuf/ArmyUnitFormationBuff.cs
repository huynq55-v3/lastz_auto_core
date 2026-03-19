using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000401 RID: 1025
	[Token(Token = "0x2000401")]
	public sealed class ArmyUnitFormationBuff : IMessage<ArmyUnitFormationBuff>, IMessage, IEquatable<ArmyUnitFormationBuff>, IDeepCloneable<ArmyUnitFormationBuff>
	{
		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06001AAA RID: 6826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D3")]
		[DebuggerNonUserCode]
		public static MessageParser<ArmyUnitFormationBuff> Parser
		{
			[Token(Token = "0x6001AAA")]
			[Address(RVA = "0x20E7FF4", Offset = "0x20E7FF4", VA = "0x20E7FF4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06001AAB RID: 6827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D4")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001AAB")]
			[Address(RVA = "0x20E804C", Offset = "0x20E804C", VA = "0x20E804C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06001AAC RID: 6828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D5")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001AAC")]
			[Address(RVA = "0x20E8150", Offset = "0x20E8150", VA = "0x20E8150", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AAD")]
		[Address(RVA = "0x20E819C", Offset = "0x20E819C", VA = "0x20E819C")]
		[DebuggerNonUserCode]
		public ArmyUnitFormationBuff()
		{
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AAE")]
		[Address(RVA = "0x20E8274", Offset = "0x20E8274", VA = "0x20E8274")]
		[DebuggerNonUserCode]
		public ArmyUnitFormationBuff(ArmyUnitFormationBuff other)
		{
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AAF")]
		[Address(RVA = "0x20E834C", Offset = "0x20E834C", VA = "0x20E834C", Slot = "10")]
		[DebuggerNonUserCode]
		public ArmyUnitFormationBuff Clone()
		{
			return null;
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06001AB0 RID: 6832 RVA: 0x0000A380 File Offset: 0x00008580
		// (set) Token: 0x06001AB1 RID: 6833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002D6")]
		[DebuggerNonUserCode]
		public int BuffId
		{
			[Token(Token = "0x6001AB0")]
			[Address(RVA = "0x20E83AC", Offset = "0x20E83AC", VA = "0x20E83AC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001AB1")]
			[Address(RVA = "0x20E83B4", Offset = "0x20E83B4", VA = "0x20E83B4")]
			set
			{
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06001AB2 RID: 6834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D7")]
		[DebuggerNonUserCode]
		public RepeatedField<int> EffectId
		{
			[Token(Token = "0x6001AB2")]
			[Address(RVA = "0x20E83BC", Offset = "0x20E83BC", VA = "0x20E83BC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06001AB3 RID: 6835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D8")]
		[DebuggerNonUserCode]
		public RepeatedField<float> Value
		{
			[Token(Token = "0x6001AB3")]
			[Address(RVA = "0x20E83C4", Offset = "0x20E83C4", VA = "0x20E83C4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06001AB4 RID: 6836 RVA: 0x0000A398 File Offset: 0x00008598
		// (set) Token: 0x06001AB5 RID: 6837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002D9")]
		[DebuggerNonUserCode]
		public int ExpireTime
		{
			[Token(Token = "0x6001AB4")]
			[Address(RVA = "0x20E83CC", Offset = "0x20E83CC", VA = "0x20E83CC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001AB5")]
			[Address(RVA = "0x20E83D4", Offset = "0x20E83D4", VA = "0x20E83D4")]
			set
			{
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06001AB6 RID: 6838 RVA: 0x0000A3B0 File Offset: 0x000085B0
		// (set) Token: 0x06001AB7 RID: 6839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002DA")]
		[DebuggerNonUserCode]
		public int TimeType
		{
			[Token(Token = "0x6001AB6")]
			[Address(RVA = "0x20E83DC", Offset = "0x20E83DC", VA = "0x20E83DC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001AB7")]
			[Address(RVA = "0x20E83E4", Offset = "0x20E83E4", VA = "0x20E83E4")]
			set
			{
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06001AB8 RID: 6840 RVA: 0x0000A3C8 File Offset: 0x000085C8
		// (set) Token: 0x06001AB9 RID: 6841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002DB")]
		[DebuggerNonUserCode]
		public int Type2
		{
			[Token(Token = "0x6001AB8")]
			[Address(RVA = "0x20E83EC", Offset = "0x20E83EC", VA = "0x20E83EC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001AB9")]
			[Address(RVA = "0x20E83F4", Offset = "0x20E83F4", VA = "0x20E83F4")]
			set
			{
			}
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x0000A3E0 File Offset: 0x000085E0
		[Token(Token = "0x6001ABA")]
		[Address(RVA = "0x20E83FC", Offset = "0x20E83FC", VA = "0x20E83FC", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x0000A3F8 File Offset: 0x000085F8
		[Token(Token = "0x6001ABB")]
		[Address(RVA = "0x20E8460", Offset = "0x20E8460", VA = "0x20E8460", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ArmyUnitFormationBuff other)
		{
			return default(bool);
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x0000A410 File Offset: 0x00008610
		[Token(Token = "0x6001ABC")]
		[Address(RVA = "0x20E855C", Offset = "0x20E855C", VA = "0x20E855C", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ABD")]
		[Address(RVA = "0x20E8644", Offset = "0x20E8644", VA = "0x20E8644", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ABE")]
		[Address(RVA = "0x20E869C", Offset = "0x20E869C", VA = "0x20E869C", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x0000A428 File Offset: 0x00008628
		[Token(Token = "0x6001ABF")]
		[Address(RVA = "0x20E8838", Offset = "0x20E8838", VA = "0x20E8838", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC0")]
		[Address(RVA = "0x20E89E4", Offset = "0x20E89E4", VA = "0x20E89E4", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ArmyUnitFormationBuff other)
		{
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC1")]
		[Address(RVA = "0x20E8AC4", Offset = "0x20E8AC4", VA = "0x20E8AC4", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001C4B RID: 7243
		[Token(Token = "0x4001C4B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<ArmyUnitFormationBuff> _parser;

		// Token: 0x04001C4C RID: 7244
		[Token(Token = "0x4001C4C")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C4D RID: 7245
		[Token(Token = "0x4001C4D")]
		public const int BuffIdFieldNumber = 1;

		// Token: 0x04001C4E RID: 7246
		[Token(Token = "0x4001C4E")]
		[FieldOffset(Offset = "0x18")]
		private int buffId_;

		// Token: 0x04001C4F RID: 7247
		[Token(Token = "0x4001C4F")]
		public const int EffectIdFieldNumber = 2;

		// Token: 0x04001C50 RID: 7248
		[Token(Token = "0x4001C50")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<int> _repeated_effectId_codec;

		// Token: 0x04001C51 RID: 7249
		[Token(Token = "0x4001C51")]
		[FieldOffset(Offset = "0x20")]
		private readonly RepeatedField<int> effectId_;

		// Token: 0x04001C52 RID: 7250
		[Token(Token = "0x4001C52")]
		public const int ValueFieldNumber = 3;

		// Token: 0x04001C53 RID: 7251
		[Token(Token = "0x4001C53")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FieldCodec<float> _repeated_value_codec;

		// Token: 0x04001C54 RID: 7252
		[Token(Token = "0x4001C54")]
		[FieldOffset(Offset = "0x28")]
		private readonly RepeatedField<float> value_;

		// Token: 0x04001C55 RID: 7253
		[Token(Token = "0x4001C55")]
		public const int ExpireTimeFieldNumber = 4;

		// Token: 0x04001C56 RID: 7254
		[Token(Token = "0x4001C56")]
		[FieldOffset(Offset = "0x30")]
		private int expireTime_;

		// Token: 0x04001C57 RID: 7255
		[Token(Token = "0x4001C57")]
		public const int TimeTypeFieldNumber = 5;

		// Token: 0x04001C58 RID: 7256
		[Token(Token = "0x4001C58")]
		[FieldOffset(Offset = "0x34")]
		private int timeType_;

		// Token: 0x04001C59 RID: 7257
		[Token(Token = "0x4001C59")]
		public const int Type2FieldNumber = 6;

		// Token: 0x04001C5A RID: 7258
		[Token(Token = "0x4001C5A")]
		[FieldOffset(Offset = "0x38")]
		private int type2_;
	}
}
