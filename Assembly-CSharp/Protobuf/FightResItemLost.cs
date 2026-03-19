using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Protobuf
{
	// Token: 0x02000448 RID: 1096
	[Token(Token = "0x2000448")]
	public sealed class FightResItemLost : IMessage<FightResItemLost>, IMessage, IEquatable<FightResItemLost>, IDeepCloneable<FightResItemLost>
	{
		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06001E4A RID: 7754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003DA")]
		[DebuggerNonUserCode]
		public static MessageParser<FightResItemLost> Parser
		{
			[Token(Token = "0x6001E4A")]
			[Address(RVA = "0x259D2C0", Offset = "0x259D2C0", VA = "0x259D2C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06001E4B RID: 7755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003DB")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6001E4B")]
			[Address(RVA = "0x259D318", Offset = "0x259D318", VA = "0x259D318")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06001E4C RID: 7756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003DC")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6001E4C")]
			[Address(RVA = "0x259D41C", Offset = "0x259D41C", VA = "0x259D41C", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E4D")]
		[Address(RVA = "0x259D468", Offset = "0x259D468", VA = "0x259D468")]
		[DebuggerNonUserCode]
		public FightResItemLost()
		{
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E4E")]
		[Address(RVA = "0x259D470", Offset = "0x259D470", VA = "0x259D470")]
		[DebuggerNonUserCode]
		public FightResItemLost(FightResItemLost other)
		{
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E4F")]
		[Address(RVA = "0x259D4BC", Offset = "0x259D4BC", VA = "0x259D4BC", Slot = "10")]
		[DebuggerNonUserCode]
		public FightResItemLost Clone()
		{
			return null;
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06001E50 RID: 7760 RVA: 0x0000B8C8 File Offset: 0x00009AC8
		// (set) Token: 0x06001E51 RID: 7761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003DD")]
		[DebuggerNonUserCode]
		public int ItemId
		{
			[Token(Token = "0x6001E50")]
			[Address(RVA = "0x259D51C", Offset = "0x259D51C", VA = "0x259D51C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001E51")]
			[Address(RVA = "0x259D524", Offset = "0x259D524", VA = "0x259D524")]
			set
			{
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06001E52 RID: 7762 RVA: 0x0000B8E0 File Offset: 0x00009AE0
		// (set) Token: 0x06001E53 RID: 7763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003DE")]
		[DebuggerNonUserCode]
		public int Value
		{
			[Token(Token = "0x6001E52")]
			[Address(RVA = "0x259D52C", Offset = "0x259D52C", VA = "0x259D52C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001E53")]
			[Address(RVA = "0x259D534", Offset = "0x259D534", VA = "0x259D534")]
			set
			{
			}
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x0000B8F8 File Offset: 0x00009AF8
		[Token(Token = "0x6001E54")]
		[Address(RVA = "0x259D53C", Offset = "0x259D53C", VA = "0x259D53C", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x0000B910 File Offset: 0x00009B10
		[Token(Token = "0x6001E55")]
		[Address(RVA = "0x259D5A0", Offset = "0x259D5A0", VA = "0x259D5A0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FightResItemLost other)
		{
			return default(bool);
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x0000B928 File Offset: 0x00009B28
		[Token(Token = "0x6001E56")]
		[Address(RVA = "0x259D5EC", Offset = "0x259D5EC", VA = "0x259D5EC", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E57")]
		[Address(RVA = "0x259D664", Offset = "0x259D664", VA = "0x259D664", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E58")]
		[Address(RVA = "0x259D6BC", Offset = "0x259D6BC", VA = "0x259D6BC", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x0000B940 File Offset: 0x00009B40
		[Token(Token = "0x6001E59")]
		[Address(RVA = "0x259D750", Offset = "0x259D750", VA = "0x259D750", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E5A")]
		[Address(RVA = "0x259D804", Offset = "0x259D804", VA = "0x259D804", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FightResItemLost other)
		{
		}

		// Token: 0x06001E5B RID: 7771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E5B")]
		[Address(RVA = "0x259D850", Offset = "0x259D850", VA = "0x259D850", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04001E01 RID: 7681
		[Token(Token = "0x4001E01")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<FightResItemLost> _parser;

		// Token: 0x04001E02 RID: 7682
		[Token(Token = "0x4001E02")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E03 RID: 7683
		[Token(Token = "0x4001E03")]
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04001E04 RID: 7684
		[Token(Token = "0x4001E04")]
		[FieldOffset(Offset = "0x18")]
		private int itemId_;

		// Token: 0x04001E05 RID: 7685
		[Token(Token = "0x4001E05")]
		public const int ValueFieldNumber = 2;

		// Token: 0x04001E06 RID: 7686
		[Token(Token = "0x4001E06")]
		[FieldOffset(Offset = "0x1C")]
		private int value_;
	}
}
