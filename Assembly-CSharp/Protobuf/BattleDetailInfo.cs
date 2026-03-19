using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000454 RID: 1108
	[Token(Token = "0x2000454")]
	public sealed class BattleDetailInfo : IMessage<BattleDetailInfo>, IMessage, IEquatable<BattleDetailInfo>, IDeepCloneable<BattleDetailInfo>
	{
		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06001EE2 RID: 7906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000405")]
		[DebuggerNonUserCode]
		public static MessageParser<BattleDetailInfo> Parser
		{
			[Token(Token = "0x6001EE2")]
			[Address(RVA = "0x25A1F9C", Offset = "0x25A1F9C", VA = "0x25A1F9C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06001EE3 RID: 7907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000406")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001EE3")]
			[Address(RVA = "0x25A1FF4", Offset = "0x25A1FF4", VA = "0x25A1FF4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06001EE4 RID: 7908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000407")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001EE4")]
			[Address(RVA = "0x25A20F8", Offset = "0x25A20F8", VA = "0x25A20F8", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EE5")]
		[Address(RVA = "0x25A2144", Offset = "0x25A2144", VA = "0x25A2144")]
		[DebuggerNonUserCode]
		public BattleDetailInfo()
		{
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EE6")]
		[Address(RVA = "0x25A226C", Offset = "0x25A226C", VA = "0x25A226C")]
		[DebuggerNonUserCode]
		public BattleDetailInfo(BattleDetailInfo other)
		{
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EE7")]
		[Address(RVA = "0x25A2360", Offset = "0x25A2360", VA = "0x25A2360", Slot = "10")]
		[DebuggerNonUserCode]
		public BattleDetailInfo Clone()
		{
			return null;
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06001EE8 RID: 7912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000408")]
		[DebuggerNonUserCode]
		public RepeatedField<BaseRoundReport> RoundReports
		{
			[Token(Token = "0x6001EE8")]
			[Address(RVA = "0x25A23C0", Offset = "0x25A23C0", VA = "0x25A23C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06001EE9 RID: 7913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000409")]
		[DebuggerNonUserCode]
		public RepeatedField<EffectRoundReport> EffectReports
		{
			[Token(Token = "0x6001EE9")]
			[Address(RVA = "0x25A23C8", Offset = "0x25A23C8", VA = "0x25A23C8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06001EEA RID: 7914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700040A")]
		[DebuggerNonUserCode]
		public RepeatedField<DetailReportPlayerInfo> PlayerInfos
		{
			[Token(Token = "0x6001EEA")]
			[Address(RVA = "0x25A23D0", Offset = "0x25A23D0", VA = "0x25A23D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x0000BC40 File Offset: 0x00009E40
		[Token(Token = "0x6001EEB")]
		[Address(RVA = "0x25A23D8", Offset = "0x25A23D8", VA = "0x25A23D8", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x0000BC58 File Offset: 0x00009E58
		[Token(Token = "0x6001EEC")]
		[Address(RVA = "0x25A243C", Offset = "0x25A243C", VA = "0x25A243C", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BattleDetailInfo other)
		{
			return default(bool);
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x0000BC70 File Offset: 0x00009E70
		[Token(Token = "0x6001EED")]
		[Address(RVA = "0x25A2524", Offset = "0x25A2524", VA = "0x25A2524", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EEE")]
		[Address(RVA = "0x25A25B4", Offset = "0x25A25B4", VA = "0x25A25B4", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001EEF RID: 7919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EEF")]
		[Address(RVA = "0x25A260C", Offset = "0x25A260C", VA = "0x25A260C", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001EF0 RID: 7920 RVA: 0x0000BC88 File Offset: 0x00009E88
		[Token(Token = "0x6001EF0")]
		[Address(RVA = "0x25A272C", Offset = "0x25A272C", VA = "0x25A272C", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EF1")]
		[Address(RVA = "0x25A2844", Offset = "0x25A2844", VA = "0x25A2844", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BattleDetailInfo other)
		{
		}

		// Token: 0x06001EF2 RID: 7922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EF2")]
		[Address(RVA = "0x25A291C", Offset = "0x25A291C", VA = "0x25A291C", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001E4B RID: 7755
		[Token(Token = "0x4001E4B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<BattleDetailInfo> _parser;

		// Token: 0x04001E4C RID: 7756
		[Token(Token = "0x4001E4C")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E4D RID: 7757
		[Token(Token = "0x4001E4D")]
		public const int RoundReportsFieldNumber = 1;

		// Token: 0x04001E4E RID: 7758
		[Token(Token = "0x4001E4E")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<BaseRoundReport> _repeated_roundReports_codec;

		// Token: 0x04001E4F RID: 7759
		[Token(Token = "0x4001E4F")]
		[FieldOffset(Offset = "0x18")]
		private readonly RepeatedField<BaseRoundReport> roundReports_;

		// Token: 0x04001E50 RID: 7760
		[Token(Token = "0x4001E50")]
		public const int EffectReportsFieldNumber = 2;

		// Token: 0x04001E51 RID: 7761
		[Token(Token = "0x4001E51")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FieldCodec<EffectRoundReport> _repeated_effectReports_codec;

		// Token: 0x04001E52 RID: 7762
		[Token(Token = "0x4001E52")]
		[FieldOffset(Offset = "0x20")]
		private readonly RepeatedField<EffectRoundReport> effectReports_;

		// Token: 0x04001E53 RID: 7763
		[Token(Token = "0x4001E53")]
		public const int PlayerInfosFieldNumber = 3;

		// Token: 0x04001E54 RID: 7764
		[Token(Token = "0x4001E54")]
		[FieldOffset(Offset = "0x18")]
		private static readonly FieldCodec<DetailReportPlayerInfo> _repeated_playerInfos_codec;

		// Token: 0x04001E55 RID: 7765
		[Token(Token = "0x4001E55")]
		[FieldOffset(Offset = "0x28")]
		private readonly RepeatedField<DetailReportPlayerInfo> playerInfos_;
	}
}
