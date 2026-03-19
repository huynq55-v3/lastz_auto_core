using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x020003E8 RID: 1000
	[Token(Token = "0x20003E8")]
	public sealed class AllianceCityOccupyInfo : IMessage<AllianceCityOccupyInfo>, IMessage, IEquatable<AllianceCityOccupyInfo>, IDeepCloneable<AllianceCityOccupyInfo>
	{
		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06001975 RID: 6517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000278")]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceCityOccupyInfo> Parser
		{
			[Token(Token = "0x6001975")]
			[Address(RVA = "0x20DA94C", Offset = "0x20DA94C", VA = "0x20DA94C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06001976 RID: 6518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000279")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001976")]
			[Address(RVA = "0x20DA9A4", Offset = "0x20DA9A4", VA = "0x20DA9A4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06001977 RID: 6519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001977")]
			[Address(RVA = "0x20DAAA8", Offset = "0x20DAAA8", VA = "0x20DAAA8", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001978")]
		[Address(RVA = "0x20DAAF4", Offset = "0x20DAAF4", VA = "0x20DAAF4")]
		[DebuggerNonUserCode]
		public AllianceCityOccupyInfo()
		{
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001979")]
		[Address(RVA = "0x20DAB4C", Offset = "0x20DAB4C", VA = "0x20DAB4C")]
		[DebuggerNonUserCode]
		public AllianceCityOccupyInfo(AllianceCityOccupyInfo other)
		{
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600197A")]
		[Address(RVA = "0x20DABA4", Offset = "0x20DABA4", VA = "0x20DABA4", Slot = "10")]
		[DebuggerNonUserCode]
		public AllianceCityOccupyInfo Clone()
		{
			return null;
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x0600197B RID: 6523 RVA: 0x00009C00 File Offset: 0x00007E00
		// (set) Token: 0x0600197C RID: 6524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700027B")]
		[DebuggerNonUserCode]
		public int CityId
		{
			[Token(Token = "0x600197B")]
			[Address(RVA = "0x20DAC04", Offset = "0x20DAC04", VA = "0x20DAC04")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600197C")]
			[Address(RVA = "0x20DAC0C", Offset = "0x20DAC0C", VA = "0x20DAC0C")]
			set
			{
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x0600197D RID: 6525 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600197E RID: 6526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700027C")]
		[DebuggerNonUserCode]
		public string Abbr
		{
			[Token(Token = "0x600197D")]
			[Address(RVA = "0x20DAC14", Offset = "0x20DAC14", VA = "0x20DAC14")]
			get
			{
				return null;
			}
			[Token(Token = "0x600197E")]
			[Address(RVA = "0x20DAC1C", Offset = "0x20DAC1C", VA = "0x20DAC1C")]
			set
			{
			}
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x00009C18 File Offset: 0x00007E18
		[Token(Token = "0x600197F")]
		[Address(RVA = "0x20DAC98", Offset = "0x20DAC98", VA = "0x20DAC98", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x00009C30 File Offset: 0x00007E30
		[Token(Token = "0x6001980")]
		[Address(RVA = "0x20DACFC", Offset = "0x20DACFC", VA = "0x20DACFC", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(AllianceCityOccupyInfo other)
		{
			return default(bool);
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x00009C48 File Offset: 0x00007E48
		[Token(Token = "0x6001981")]
		[Address(RVA = "0x20DAD6C", Offset = "0x20DAD6C", VA = "0x20DAD6C", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001982")]
		[Address(RVA = "0x20DADEC", Offset = "0x20DADEC", VA = "0x20DADEC", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001983")]
		[Address(RVA = "0x20DAE44", Offset = "0x20DAE44", VA = "0x20DAE44", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x00009C60 File Offset: 0x00007E60
		[Token(Token = "0x6001984")]
		[Address(RVA = "0x20DAEE0", Offset = "0x20DAEE0", VA = "0x20DAEE0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001985")]
		[Address(RVA = "0x20DAFA0", Offset = "0x20DAFA0", VA = "0x20DAFA0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(AllianceCityOccupyInfo other)
		{
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001986")]
		[Address(RVA = "0x20DB010", Offset = "0x20DB010", VA = "0x20DB010", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001BA9 RID: 7081
		[Token(Token = "0x4001BA9")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<AllianceCityOccupyInfo> _parser;

		// Token: 0x04001BAA RID: 7082
		[Token(Token = "0x4001BAA")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001BAB RID: 7083
		[Token(Token = "0x4001BAB")]
		public const int CityIdFieldNumber = 1;

		// Token: 0x04001BAC RID: 7084
		[Token(Token = "0x4001BAC")]
		[FieldOffset(Offset = "0x18")]
		private int cityId_;

		// Token: 0x04001BAD RID: 7085
		[Token(Token = "0x4001BAD")]
		public const int AbbrFieldNumber = 2;

		// Token: 0x04001BAE RID: 7086
		[Token(Token = "0x4001BAE")]
		[FieldOffset(Offset = "0x20")]
		private string abbr_;
	}
}
