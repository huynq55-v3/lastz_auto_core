using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x020003F9 RID: 1017
	[Token(Token = "0x20003F9")]
	public sealed class ArmyUnitEffectInfoProto : IMessage<ArmyUnitEffectInfoProto>, IMessage, IEquatable<ArmyUnitEffectInfoProto>, IDeepCloneable<ArmyUnitEffectInfoProto>
	{
		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06001A50 RID: 6736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BA")]
		[DebuggerNonUserCode]
		public static MessageParser<ArmyUnitEffectInfoProto> Parser
		{
			[Token(Token = "0x6001A50")]
			[Address(RVA = "0x20E4C54", Offset = "0x20E4C54", VA = "0x20E4C54")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06001A51 RID: 6737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BB")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001A51")]
			[Address(RVA = "0x20E4CAC", Offset = "0x20E4CAC", VA = "0x20E4CAC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06001A52 RID: 6738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BC")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001A52")]
			[Address(RVA = "0x20E4DB0", Offset = "0x20E4DB0", VA = "0x20E4DB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A53")]
		[Address(RVA = "0x20E4DFC", Offset = "0x20E4DFC", VA = "0x20E4DFC")]
		[DebuggerNonUserCode]
		public ArmyUnitEffectInfoProto()
		{
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A54")]
		[Address(RVA = "0x20E4FA4", Offset = "0x20E4FA4", VA = "0x20E4FA4")]
		[DebuggerNonUserCode]
		public ArmyUnitEffectInfoProto(ArmyUnitEffectInfoProto other)
		{
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A55")]
		[Address(RVA = "0x20E50EC", Offset = "0x20E50EC", VA = "0x20E50EC", Slot = "10")]
		[DebuggerNonUserCode]
		public ArmyUnitEffectInfoProto Clone()
		{
			return null;
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06001A56 RID: 6742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BD")]
		[DebuggerNonUserCode]
		public RepeatedField<float> PlayerEffect
		{
			[Token(Token = "0x6001A56")]
			[Address(RVA = "0x20E514C", Offset = "0x20E514C", VA = "0x20E514C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06001A57 RID: 6743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BE")]
		[DebuggerNonUserCode]
		public RepeatedField<float> FormationEffect
		{
			[Token(Token = "0x6001A57")]
			[Address(RVA = "0x20E5154", Offset = "0x20E5154", VA = "0x20E5154")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06001A58 RID: 6744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BF")]
		[DebuggerNonUserCode]
		public RepeatedField<UnitEffectReason> UnitEffectReasons
		{
			[Token(Token = "0x6001A58")]
			[Address(RVA = "0x20E515C", Offset = "0x20E515C", VA = "0x20E515C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06001A59 RID: 6745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C0")]
		[DebuggerNonUserCode]
		public RepeatedField<ArmyUnitBuff> UnitBuffs
		{
			[Token(Token = "0x6001A59")]
			[Address(RVA = "0x20E5164", Offset = "0x20E5164", VA = "0x20E5164")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06001A5A RID: 6746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C1")]
		[DebuggerNonUserCode]
		public RepeatedField<ArmyUnitFormationBuff> FormationBuffs
		{
			[Token(Token = "0x6001A5A")]
			[Address(RVA = "0x20E516C", Offset = "0x20E516C", VA = "0x20E516C")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x0000A188 File Offset: 0x00008388
		[Token(Token = "0x6001A5B")]
		[Address(RVA = "0x20E5174", Offset = "0x20E5174", VA = "0x20E5174", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x0000A1A0 File Offset: 0x000083A0
		[Token(Token = "0x6001A5C")]
		[Address(RVA = "0x20E51D8", Offset = "0x20E51D8", VA = "0x20E51D8", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ArmyUnitEffectInfoProto other)
		{
			return default(bool);
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x0000A1B8 File Offset: 0x000083B8
		[Token(Token = "0x6001A5D")]
		[Address(RVA = "0x20E5304", Offset = "0x20E5304", VA = "0x20E5304", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A5E")]
		[Address(RVA = "0x20E53DC", Offset = "0x20E53DC", VA = "0x20E53DC", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A5F")]
		[Address(RVA = "0x20E5434", Offset = "0x20E5434", VA = "0x20E5434", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x0000A1D0 File Offset: 0x000083D0
		[Token(Token = "0x6001A60")]
		[Address(RVA = "0x20E55A8", Offset = "0x20E55A8", VA = "0x20E55A8", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A61")]
		[Address(RVA = "0x20E572C", Offset = "0x20E572C", VA = "0x20E572C", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ArmyUnitEffectInfoProto other)
		{
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A62")]
		[Address(RVA = "0x20E5840", Offset = "0x20E5840", VA = "0x20E5840", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001C1D RID: 7197
		[Token(Token = "0x4001C1D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<ArmyUnitEffectInfoProto> _parser;

		// Token: 0x04001C1E RID: 7198
		[Token(Token = "0x4001C1E")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C1F RID: 7199
		[Token(Token = "0x4001C1F")]
		public const int PlayerEffectFieldNumber = 1;

		// Token: 0x04001C20 RID: 7200
		[Token(Token = "0x4001C20")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<float> _repeated_playerEffect_codec;

		// Token: 0x04001C21 RID: 7201
		[Token(Token = "0x4001C21")]
		[FieldOffset(Offset = "0x18")]
		private readonly RepeatedField<float> playerEffect_;

		// Token: 0x04001C22 RID: 7202
		[Token(Token = "0x4001C22")]
		public const int FormationEffectFieldNumber = 2;

		// Token: 0x04001C23 RID: 7203
		[Token(Token = "0x4001C23")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FieldCodec<float> _repeated_formationEffect_codec;

		// Token: 0x04001C24 RID: 7204
		[Token(Token = "0x4001C24")]
		[FieldOffset(Offset = "0x20")]
		private readonly RepeatedField<float> formationEffect_;

		// Token: 0x04001C25 RID: 7205
		[Token(Token = "0x4001C25")]
		public const int UnitEffectReasonsFieldNumber = 3;

		// Token: 0x04001C26 RID: 7206
		[Token(Token = "0x4001C26")]
		[FieldOffset(Offset = "0x18")]
		private static readonly FieldCodec<UnitEffectReason> _repeated_unitEffectReasons_codec;

		// Token: 0x04001C27 RID: 7207
		[Token(Token = "0x4001C27")]
		[FieldOffset(Offset = "0x28")]
		private readonly RepeatedField<UnitEffectReason> unitEffectReasons_;

		// Token: 0x04001C28 RID: 7208
		[Token(Token = "0x4001C28")]
		public const int UnitBuffsFieldNumber = 4;

		// Token: 0x04001C29 RID: 7209
		[Token(Token = "0x4001C29")]
		[FieldOffset(Offset = "0x20")]
		private static readonly FieldCodec<ArmyUnitBuff> _repeated_unitBuffs_codec;

		// Token: 0x04001C2A RID: 7210
		[Token(Token = "0x4001C2A")]
		[FieldOffset(Offset = "0x30")]
		private readonly RepeatedField<ArmyUnitBuff> unitBuffs_;

		// Token: 0x04001C2B RID: 7211
		[Token(Token = "0x4001C2B")]
		public const int FormationBuffsFieldNumber = 5;

		// Token: 0x04001C2C RID: 7212
		[Token(Token = "0x4001C2C")]
		[FieldOffset(Offset = "0x28")]
		private static readonly FieldCodec<ArmyUnitFormationBuff> _repeated_formationBuffs_codec;

		// Token: 0x04001C2D RID: 7213
		[Token(Token = "0x4001C2D")]
		[FieldOffset(Offset = "0x38")]
		private readonly RepeatedField<ArmyUnitFormationBuff> formationBuffs_;
	}
}
