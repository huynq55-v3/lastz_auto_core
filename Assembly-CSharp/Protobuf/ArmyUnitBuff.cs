using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x020003FF RID: 1023
	[Token(Token = "0x20003FF")]
	public sealed class ArmyUnitBuff : IMessage<ArmyUnitBuff>, IMessage, IEquatable<ArmyUnitBuff>, IDeepCloneable<ArmyUnitBuff>
	{
		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06001A92 RID: 6802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002CC")]
		[DebuggerNonUserCode]
		public static MessageParser<ArmyUnitBuff> Parser
		{
			[Token(Token = "0x6001A92")]
			[Address(RVA = "0x20E72A8", Offset = "0x20E72A8", VA = "0x20E72A8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06001A93 RID: 6803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002CD")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001A93")]
			[Address(RVA = "0x20E7300", Offset = "0x20E7300", VA = "0x20E7300")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06001A94 RID: 6804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002CE")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001A94")]
			[Address(RVA = "0x20E7404", Offset = "0x20E7404", VA = "0x20E7404", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A95")]
		[Address(RVA = "0x20E7450", Offset = "0x20E7450", VA = "0x20E7450")]
		[DebuggerNonUserCode]
		public ArmyUnitBuff()
		{
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A96")]
		[Address(RVA = "0x20E7528", Offset = "0x20E7528", VA = "0x20E7528")]
		[DebuggerNonUserCode]
		public ArmyUnitBuff(ArmyUnitBuff other)
		{
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A97")]
		[Address(RVA = "0x20E75F8", Offset = "0x20E75F8", VA = "0x20E75F8", Slot = "10")]
		[DebuggerNonUserCode]
		public ArmyUnitBuff Clone()
		{
			return null;
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06001A98 RID: 6808 RVA: 0x0000A2F0 File Offset: 0x000084F0
		// (set) Token: 0x06001A99 RID: 6809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002CF")]
		[DebuggerNonUserCode]
		public int BuffId
		{
			[Token(Token = "0x6001A98")]
			[Address(RVA = "0x20E7658", Offset = "0x20E7658", VA = "0x20E7658")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001A99")]
			[Address(RVA = "0x20E7660", Offset = "0x20E7660", VA = "0x20E7660")]
			set
			{
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06001A9A RID: 6810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D0")]
		[DebuggerNonUserCode]
		public RepeatedField<int> EffectId
		{
			[Token(Token = "0x6001A9A")]
			[Address(RVA = "0x20E7668", Offset = "0x20E7668", VA = "0x20E7668")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06001A9B RID: 6811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D1")]
		[DebuggerNonUserCode]
		public RepeatedField<float> Value
		{
			[Token(Token = "0x6001A9B")]
			[Address(RVA = "0x20E7670", Offset = "0x20E7670", VA = "0x20E7670")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06001A9C RID: 6812 RVA: 0x0000A308 File Offset: 0x00008508
		// (set) Token: 0x06001A9D RID: 6813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002D2")]
		[DebuggerNonUserCode]
		public int ExpireTime
		{
			[Token(Token = "0x6001A9C")]
			[Address(RVA = "0x20E7678", Offset = "0x20E7678", VA = "0x20E7678")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001A9D")]
			[Address(RVA = "0x20E7680", Offset = "0x20E7680", VA = "0x20E7680")]
			set
			{
			}
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x0000A320 File Offset: 0x00008520
		[Token(Token = "0x6001A9E")]
		[Address(RVA = "0x20E7688", Offset = "0x20E7688", VA = "0x20E7688", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x0000A338 File Offset: 0x00008538
		[Token(Token = "0x6001A9F")]
		[Address(RVA = "0x20E76EC", Offset = "0x20E76EC", VA = "0x20E76EC", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ArmyUnitBuff other)
		{
			return default(bool);
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x0000A350 File Offset: 0x00008550
		[Token(Token = "0x6001AA0")]
		[Address(RVA = "0x20E77C8", Offset = "0x20E77C8", VA = "0x20E77C8", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA1")]
		[Address(RVA = "0x20E7878", Offset = "0x20E7878", VA = "0x20E7878", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA2")]
		[Address(RVA = "0x20E78D0", Offset = "0x20E78D0", VA = "0x20E78D0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x0000A368 File Offset: 0x00008568
		[Token(Token = "0x6001AA3")]
		[Address(RVA = "0x20E7A14", Offset = "0x20E7A14", VA = "0x20E7A14", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA4")]
		[Address(RVA = "0x20E7B68", Offset = "0x20E7B68", VA = "0x20E7B68", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ArmyUnitBuff other)
		{
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA5")]
		[Address(RVA = "0x20E7C30", Offset = "0x20E7C30", VA = "0x20E7C30", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001C3E RID: 7230
		[Token(Token = "0x4001C3E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<ArmyUnitBuff> _parser;

		// Token: 0x04001C3F RID: 7231
		[Token(Token = "0x4001C3F")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C40 RID: 7232
		[Token(Token = "0x4001C40")]
		public const int BuffIdFieldNumber = 1;

		// Token: 0x04001C41 RID: 7233
		[Token(Token = "0x4001C41")]
		[FieldOffset(Offset = "0x18")]
		private int buffId_;

		// Token: 0x04001C42 RID: 7234
		[Token(Token = "0x4001C42")]
		public const int EffectIdFieldNumber = 2;

		// Token: 0x04001C43 RID: 7235
		[Token(Token = "0x4001C43")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<int> _repeated_effectId_codec;

		// Token: 0x04001C44 RID: 7236
		[Token(Token = "0x4001C44")]
		[FieldOffset(Offset = "0x20")]
		private readonly RepeatedField<int> effectId_;

		// Token: 0x04001C45 RID: 7237
		[Token(Token = "0x4001C45")]
		public const int ValueFieldNumber = 3;

		// Token: 0x04001C46 RID: 7238
		[Token(Token = "0x4001C46")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FieldCodec<float> _repeated_value_codec;

		// Token: 0x04001C47 RID: 7239
		[Token(Token = "0x4001C47")]
		[FieldOffset(Offset = "0x28")]
		private readonly RepeatedField<float> value_;

		// Token: 0x04001C48 RID: 7240
		[Token(Token = "0x4001C48")]
		public const int ExpireTimeFieldNumber = 4;

		// Token: 0x04001C49 RID: 7241
		[Token(Token = "0x4001C49")]
		[FieldOffset(Offset = "0x30")]
		private int expireTime_;
	}
}
