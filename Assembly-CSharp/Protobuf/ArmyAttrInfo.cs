using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000442 RID: 1090
	[Token(Token = "0x2000442")]
	public sealed class ArmyAttrInfo : IMessage<ArmyAttrInfo>, IMessage, IEquatable<ArmyAttrInfo>, IDeepCloneable<ArmyAttrInfo>
	{
		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06001E04 RID: 7684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C9")]
		[DebuggerNonUserCode]
		public static MessageParser<ArmyAttrInfo> Parser
		{
			[Token(Token = "0x6001E04")]
			[Address(RVA = "0x259B7EC", Offset = "0x259B7EC", VA = "0x259B7EC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001E05 RID: 7685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003CA")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001E05")]
			[Address(RVA = "0x259B844", Offset = "0x259B844", VA = "0x259B844")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001E06 RID: 7686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003CB")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001E06")]
			[Address(RVA = "0x259B948", Offset = "0x259B948", VA = "0x259B948", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E07")]
		[Address(RVA = "0x259B994", Offset = "0x259B994", VA = "0x259B994")]
		[DebuggerNonUserCode]
		public ArmyAttrInfo()
		{
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E08")]
		[Address(RVA = "0x259B99C", Offset = "0x259B99C", VA = "0x259B99C")]
		[DebuggerNonUserCode]
		public ArmyAttrInfo(ArmyAttrInfo other)
		{
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E09")]
		[Address(RVA = "0x259B9E8", Offset = "0x259B9E8", VA = "0x259B9E8", Slot = "10")]
		[DebuggerNonUserCode]
		public ArmyAttrInfo Clone()
		{
			return null;
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06001E0A RID: 7690 RVA: 0x0000B6E8 File Offset: 0x000098E8
		// (set) Token: 0x06001E0B RID: 7691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003CC")]
		[DebuggerNonUserCode]
		public int Reason
		{
			[Token(Token = "0x6001E0A")]
			[Address(RVA = "0x259BA48", Offset = "0x259BA48", VA = "0x259BA48")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001E0B")]
			[Address(RVA = "0x259BA50", Offset = "0x259BA50", VA = "0x259BA50")]
			set
			{
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06001E0C RID: 7692 RVA: 0x0000B700 File Offset: 0x00009900
		// (set) Token: 0x06001E0D RID: 7693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003CD")]
		[DebuggerNonUserCode]
		public float Value
		{
			[Token(Token = "0x6001E0C")]
			[Address(RVA = "0x259BA58", Offset = "0x259BA58", VA = "0x259BA58")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001E0D")]
			[Address(RVA = "0x259BA60", Offset = "0x259BA60", VA = "0x259BA60")]
			set
			{
			}
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x0000B718 File Offset: 0x00009918
		[Token(Token = "0x6001E0E")]
		[Address(RVA = "0x259BA68", Offset = "0x259BA68", VA = "0x259BA68", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x0000B730 File Offset: 0x00009930
		[Token(Token = "0x6001E0F")]
		[Address(RVA = "0x259BACC", Offset = "0x259BACC", VA = "0x259BACC", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ArmyAttrInfo other)
		{
			return default(bool);
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x0000B748 File Offset: 0x00009948
		[Token(Token = "0x6001E10")]
		[Address(RVA = "0x259BBC8", Offset = "0x259BBC8", VA = "0x259BBC8", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E11")]
		[Address(RVA = "0x259BCC8", Offset = "0x259BCC8", VA = "0x259BCC8", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E12")]
		[Address(RVA = "0x259BD20", Offset = "0x259BD20", VA = "0x259BD20", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001E13 RID: 7699 RVA: 0x0000B760 File Offset: 0x00009960
		[Token(Token = "0x6001E13")]
		[Address(RVA = "0x259BDB8", Offset = "0x259BDB8", VA = "0x259BDB8", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E14")]
		[Address(RVA = "0x259BE50", Offset = "0x259BE50", VA = "0x259BE50", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ArmyAttrInfo other)
		{
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E15")]
		[Address(RVA = "0x259BEA0", Offset = "0x259BEA0", VA = "0x259BEA0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001DE8 RID: 7656
		[Token(Token = "0x4001DE8")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<ArmyAttrInfo> _parser;

		// Token: 0x04001DE9 RID: 7657
		[Token(Token = "0x4001DE9")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DEA RID: 7658
		[Token(Token = "0x4001DEA")]
		public const int ReasonFieldNumber = 1;

		// Token: 0x04001DEB RID: 7659
		[Token(Token = "0x4001DEB")]
		[FieldOffset(Offset = "0x18")]
		private int reason_;

		// Token: 0x04001DEC RID: 7660
		[Token(Token = "0x4001DEC")]
		public const int ValueFieldNumber = 2;

		// Token: 0x04001DED RID: 7661
		[Token(Token = "0x4001DED")]
		[FieldOffset(Offset = "0x1C")]
		private float value_;
	}
}
