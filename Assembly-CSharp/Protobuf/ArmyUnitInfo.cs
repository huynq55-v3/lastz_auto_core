using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x020003F7 RID: 1015
	[Token(Token = "0x20003F7")]
	public sealed class ArmyUnitInfo : IMessage<ArmyUnitInfo>, IMessage, IEquatable<ArmyUnitInfo>, IDeepCloneable<ArmyUnitInfo>
	{
		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06001A29 RID: 6697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AA")]
		[DebuggerNonUserCode]
		public static MessageParser<ArmyUnitInfo> Parser
		{
			[Token(Token = "0x6001A29")]
			[Address(RVA = "0x20E301C", Offset = "0x20E301C", VA = "0x20E301C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06001A2A RID: 6698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AB")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001A2A")]
			[Address(RVA = "0x20E3074", Offset = "0x20E3074", VA = "0x20E3074")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06001A2B RID: 6699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AC")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001A2B")]
			[Address(RVA = "0x20E3178", Offset = "0x20E3178", VA = "0x20E3178", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A2C")]
		[Address(RVA = "0x20E31C4", Offset = "0x20E31C4", VA = "0x20E31C4")]
		[DebuggerNonUserCode]
		public ArmyUnitInfo()
		{
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A2D")]
		[Address(RVA = "0x20E33D8", Offset = "0x20E33D8", VA = "0x20E33D8")]
		[DebuggerNonUserCode]
		public ArmyUnitInfo(ArmyUnitInfo other)
		{
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A2E")]
		[Address(RVA = "0x20E357C", Offset = "0x20E357C", VA = "0x20E357C", Slot = "10")]
		[DebuggerNonUserCode]
		public ArmyUnitInfo Clone()
		{
			return null;
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06001A2F RID: 6703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AD")]
		[DebuggerNonUserCode]
		public RepeatedField<SoldierProto> Soldiers
		{
			[Token(Token = "0x6001A2F")]
			[Address(RVA = "0x20E35DC", Offset = "0x20E35DC", VA = "0x20E35DC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06001A30 RID: 6704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AE")]
		[DebuggerNonUserCode]
		public RepeatedField<HeroInfoProto> Heroes
		{
			[Token(Token = "0x6001A30")]
			[Address(RVA = "0x20E35E4", Offset = "0x20E35E4", VA = "0x20E35E4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06001A31 RID: 6705 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001A32 RID: 6706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002AF")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Token(Token = "0x6001A31")]
			[Address(RVA = "0x20E35EC", Offset = "0x20E35EC", VA = "0x20E35EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A32")]
			[Address(RVA = "0x20E35F4", Offset = "0x20E35F4", VA = "0x20E35F4")]
			set
			{
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06001A33 RID: 6707 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001A34 RID: 6708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002B0")]
		[DebuggerNonUserCode]
		public string AlAbbr
		{
			[Token(Token = "0x6001A33")]
			[Address(RVA = "0x20E3670", Offset = "0x20E3670", VA = "0x20E3670")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A34")]
			[Address(RVA = "0x20E3678", Offset = "0x20E3678", VA = "0x20E3678")]
			set
			{
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06001A35 RID: 6709 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001A36 RID: 6710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002B1")]
		[DebuggerNonUserCode]
		public string Pic
		{
			[Token(Token = "0x6001A35")]
			[Address(RVA = "0x20E36F4", Offset = "0x20E36F4", VA = "0x20E36F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A36")]
			[Address(RVA = "0x20E36FC", Offset = "0x20E36FC", VA = "0x20E36FC")]
			set
			{
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06001A37 RID: 6711 RVA: 0x0000A0B0 File Offset: 0x000082B0
		// (set) Token: 0x06001A38 RID: 6712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002B2")]
		[DebuggerNonUserCode]
		public int PicVer
		{
			[Token(Token = "0x6001A37")]
			[Address(RVA = "0x20E3778", Offset = "0x20E3778", VA = "0x20E3778")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001A38")]
			[Address(RVA = "0x20E3780", Offset = "0x20E3780", VA = "0x20E3780")]
			set
			{
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06001A39 RID: 6713 RVA: 0x0000A0C8 File Offset: 0x000082C8
		// (set) Token: 0x06001A3A RID: 6714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002B3")]
		[DebuggerNonUserCode]
		public int HeadFrame
		{
			[Token(Token = "0x6001A39")]
			[Address(RVA = "0x20E3788", Offset = "0x20E3788", VA = "0x20E3788")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001A3A")]
			[Address(RVA = "0x20E3790", Offset = "0x20E3790", VA = "0x20E3790")]
			set
			{
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06001A3B RID: 6715 RVA: 0x0000A0E0 File Offset: 0x000082E0
		// (set) Token: 0x06001A3C RID: 6716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002B4")]
		[DebuggerNonUserCode]
		public int CareerType
		{
			[Token(Token = "0x6001A3B")]
			[Address(RVA = "0x20E3798", Offset = "0x20E3798", VA = "0x20E3798")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001A3C")]
			[Address(RVA = "0x20E37A0", Offset = "0x20E37A0", VA = "0x20E37A0")]
			set
			{
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06001A3D RID: 6717 RVA: 0x0000A0F8 File Offset: 0x000082F8
		// (set) Token: 0x06001A3E RID: 6718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002B5")]
		[DebuggerNonUserCode]
		public int CareerLv
		{
			[Token(Token = "0x6001A3D")]
			[Address(RVA = "0x20E37A8", Offset = "0x20E37A8", VA = "0x20E37A8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001A3E")]
			[Address(RVA = "0x20E37B0", Offset = "0x20E37B0", VA = "0x20E37B0")]
			set
			{
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06001A3F RID: 6719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B6")]
		[DebuggerNonUserCode]
		public RepeatedField<ArmyUnitBuff> UnitBuffs
		{
			[Token(Token = "0x6001A3F")]
			[Address(RVA = "0x20E37B8", Offset = "0x20E37B8", VA = "0x20E37B8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06001A40 RID: 6720 RVA: 0x0000A110 File Offset: 0x00008310
		// (set) Token: 0x06001A41 RID: 6721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002B7")]
		[DebuggerNonUserCode]
		public int HeadSkinId
		{
			[Token(Token = "0x6001A40")]
			[Address(RVA = "0x20E37C0", Offset = "0x20E37C0", VA = "0x20E37C0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001A41")]
			[Address(RVA = "0x20E37C8", Offset = "0x20E37C8", VA = "0x20E37C8")]
			set
			{
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06001A42 RID: 6722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B8")]
		[DebuggerNonUserCode]
		public RepeatedField<UnitEffect> UnitEffects
		{
			[Token(Token = "0x6001A42")]
			[Address(RVA = "0x20E37D0", Offset = "0x20E37D0", VA = "0x20E37D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06001A43 RID: 6723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B9")]
		[DebuggerNonUserCode]
		public RepeatedField<SuitInfoProto> Suits
		{
			[Token(Token = "0x6001A43")]
			[Address(RVA = "0x20E37D8", Offset = "0x20E37D8", VA = "0x20E37D8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x0000A128 File Offset: 0x00008328
		[Token(Token = "0x6001A44")]
		[Address(RVA = "0x20E37E0", Offset = "0x20E37E0", VA = "0x20E37E0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x0000A140 File Offset: 0x00008340
		[Token(Token = "0x6001A45")]
		[Address(RVA = "0x20E3844", Offset = "0x20E3844", VA = "0x20E3844", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ArmyUnitInfo other)
		{
			return default(bool);
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x0000A158 File Offset: 0x00008358
		[Token(Token = "0x6001A46")]
		[Address(RVA = "0x20E3A10", Offset = "0x20E3A10", VA = "0x20E3A10", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A47")]
		[Address(RVA = "0x20E3BC4", Offset = "0x20E3BC4", VA = "0x20E3BC4", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A48")]
		[Address(RVA = "0x20E3C1C", Offset = "0x20E3C1C", VA = "0x20E3C1C", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x0000A170 File Offset: 0x00008370
		[Token(Token = "0x6001A49")]
		[Address(RVA = "0x20E3F44", Offset = "0x20E3F44", VA = "0x20E3F44", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A4A")]
		[Address(RVA = "0x20E4288", Offset = "0x20E4288", VA = "0x20E4288", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ArmyUnitInfo other)
		{
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A4B")]
		[Address(RVA = "0x20E4434", Offset = "0x20E4434", VA = "0x20E4434", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001BFB RID: 7163
		[Token(Token = "0x4001BFB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<ArmyUnitInfo> _parser;

		// Token: 0x04001BFC RID: 7164
		[Token(Token = "0x4001BFC")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001BFD RID: 7165
		[Token(Token = "0x4001BFD")]
		public const int SoldiersFieldNumber = 1;

		// Token: 0x04001BFE RID: 7166
		[Token(Token = "0x4001BFE")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<SoldierProto> _repeated_soldiers_codec;

		// Token: 0x04001BFF RID: 7167
		[Token(Token = "0x4001BFF")]
		[FieldOffset(Offset = "0x18")]
		private readonly RepeatedField<SoldierProto> soldiers_;

		// Token: 0x04001C00 RID: 7168
		[Token(Token = "0x4001C00")]
		public const int HeroesFieldNumber = 2;

		// Token: 0x04001C01 RID: 7169
		[Token(Token = "0x4001C01")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FieldCodec<HeroInfoProto> _repeated_heroes_codec;

		// Token: 0x04001C02 RID: 7170
		[Token(Token = "0x4001C02")]
		[FieldOffset(Offset = "0x20")]
		private readonly RepeatedField<HeroInfoProto> heroes_;

		// Token: 0x04001C03 RID: 7171
		[Token(Token = "0x4001C03")]
		public const int NameFieldNumber = 3;

		// Token: 0x04001C04 RID: 7172
		[Token(Token = "0x4001C04")]
		[FieldOffset(Offset = "0x28")]
		private string name_;

		// Token: 0x04001C05 RID: 7173
		[Token(Token = "0x4001C05")]
		public const int AlAbbrFieldNumber = 4;

		// Token: 0x04001C06 RID: 7174
		[Token(Token = "0x4001C06")]
		[FieldOffset(Offset = "0x30")]
		private string alAbbr_;

		// Token: 0x04001C07 RID: 7175
		[Token(Token = "0x4001C07")]
		public const int PicFieldNumber = 5;

		// Token: 0x04001C08 RID: 7176
		[Token(Token = "0x4001C08")]
		[FieldOffset(Offset = "0x38")]
		private string pic_;

		// Token: 0x04001C09 RID: 7177
		[Token(Token = "0x4001C09")]
		public const int PicVerFieldNumber = 6;

		// Token: 0x04001C0A RID: 7178
		[Token(Token = "0x4001C0A")]
		[FieldOffset(Offset = "0x40")]
		private int picVer_;

		// Token: 0x04001C0B RID: 7179
		[Token(Token = "0x4001C0B")]
		public const int HeadFrameFieldNumber = 7;

		// Token: 0x04001C0C RID: 7180
		[Token(Token = "0x4001C0C")]
		[FieldOffset(Offset = "0x44")]
		private int headFrame_;

		// Token: 0x04001C0D RID: 7181
		[Token(Token = "0x4001C0D")]
		public const int CareerTypeFieldNumber = 8;

		// Token: 0x04001C0E RID: 7182
		[Token(Token = "0x4001C0E")]
		[FieldOffset(Offset = "0x48")]
		private int careerType_;

		// Token: 0x04001C0F RID: 7183
		[Token(Token = "0x4001C0F")]
		public const int CareerLvFieldNumber = 9;

		// Token: 0x04001C10 RID: 7184
		[Token(Token = "0x4001C10")]
		[FieldOffset(Offset = "0x4C")]
		private int careerLv_;

		// Token: 0x04001C11 RID: 7185
		[Token(Token = "0x4001C11")]
		public const int UnitBuffsFieldNumber = 10;

		// Token: 0x04001C12 RID: 7186
		[Token(Token = "0x4001C12")]
		[FieldOffset(Offset = "0x18")]
		private static readonly FieldCodec<ArmyUnitBuff> _repeated_unitBuffs_codec;

		// Token: 0x04001C13 RID: 7187
		[Token(Token = "0x4001C13")]
		[FieldOffset(Offset = "0x50")]
		private readonly RepeatedField<ArmyUnitBuff> unitBuffs_;

		// Token: 0x04001C14 RID: 7188
		[Token(Token = "0x4001C14")]
		public const int HeadSkinIdFieldNumber = 11;

		// Token: 0x04001C15 RID: 7189
		[Token(Token = "0x4001C15")]
		[FieldOffset(Offset = "0x58")]
		private int headSkinId_;

		// Token: 0x04001C16 RID: 7190
		[Token(Token = "0x4001C16")]
		public const int UnitEffectsFieldNumber = 12;

		// Token: 0x04001C17 RID: 7191
		[Token(Token = "0x4001C17")]
		[FieldOffset(Offset = "0x20")]
		private static readonly FieldCodec<UnitEffect> _repeated_unitEffects_codec;

		// Token: 0x04001C18 RID: 7192
		[Token(Token = "0x4001C18")]
		[FieldOffset(Offset = "0x60")]
		private readonly RepeatedField<UnitEffect> unitEffects_;

		// Token: 0x04001C19 RID: 7193
		[Token(Token = "0x4001C19")]
		public const int SuitsFieldNumber = 13;

		// Token: 0x04001C1A RID: 7194
		[Token(Token = "0x4001C1A")]
		[FieldOffset(Offset = "0x28")]
		private static readonly FieldCodec<SuitInfoProto> _repeated_suits_codec;

		// Token: 0x04001C1B RID: 7195
		[Token(Token = "0x4001C1B")]
		[FieldOffset(Offset = "0x68")]
		private readonly RepeatedField<SuitInfoProto> suits_;
	}
}
