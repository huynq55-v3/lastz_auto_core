using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Google.Protobuf.WellKnownTypes
{
	// Token: 0x02000B60 RID: 2912
	[Token(Token = "0x2000B60")]
	public sealed class EnumValue : IMessage<EnumValue>, IMessage, IEquatable<EnumValue>, IDeepCloneable<EnumValue>
	{
		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06006EF1 RID: 28401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000858")]
		[DebuggerNonUserCode]
		public static MessageParser<EnumValue> Parser
		{
			[Token(Token = "0x6006EF1")]
			[Address(RVA = "0x367DBD4", Offset = "0x367DBD4", VA = "0x367DBD4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06006EF2 RID: 28402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000859")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6006EF2")]
			[Address(RVA = "0x367DC2C", Offset = "0x367DC2C", VA = "0x367DC2C")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06006EF3 RID: 28403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700085A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6006EF3")]
			[Address(RVA = "0x367DD30", Offset = "0x367DD30", VA = "0x367DD30", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006EF4 RID: 28404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EF4")]
		[Address(RVA = "0x367DD7C", Offset = "0x367DD7C", VA = "0x367DD7C")]
		[DebuggerNonUserCode]
		public EnumValue()
		{
		}

		// Token: 0x06006EF5 RID: 28405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EF5")]
		[Address(RVA = "0x367DE30", Offset = "0x367DE30", VA = "0x367DE30")]
		[DebuggerNonUserCode]
		public EnumValue(EnumValue other)
		{
		}

		// Token: 0x06006EF6 RID: 28406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EF6")]
		[Address(RVA = "0x367DED8", Offset = "0x367DED8", VA = "0x367DED8", Slot = "10")]
		[DebuggerNonUserCode]
		public EnumValue Clone()
		{
			return null;
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06006EF7 RID: 28407 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006EF8 RID: 28408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700085B")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Token(Token = "0x6006EF7")]
			[Address(RVA = "0x367DF38", Offset = "0x367DF38", VA = "0x367DF38")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006EF8")]
			[Address(RVA = "0x367DF40", Offset = "0x367DF40", VA = "0x367DF40")]
			set
			{
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06006EF9 RID: 28409 RVA: 0x0004F5F0 File Offset: 0x0004D7F0
		// (set) Token: 0x06006EFA RID: 28410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700085C")]
		[DebuggerNonUserCode]
		public int Number
		{
			[Token(Token = "0x6006EF9")]
			[Address(RVA = "0x367DFBC", Offset = "0x367DFBC", VA = "0x367DFBC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006EFA")]
			[Address(RVA = "0x367DFC4", Offset = "0x367DFC4", VA = "0x367DFC4")]
			set
			{
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06006EFB RID: 28411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700085D")]
		[DebuggerNonUserCode]
		public RepeatedField<Option> Options
		{
			[Token(Token = "0x6006EFB")]
			[Address(RVA = "0x367DFCC", Offset = "0x367DFCC", VA = "0x367DFCC")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006EFC RID: 28412 RVA: 0x0004F608 File Offset: 0x0004D808
		[Token(Token = "0x6006EFC")]
		[Address(RVA = "0x367DFD4", Offset = "0x367DFD4", VA = "0x367DFD4", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06006EFD RID: 28413 RVA: 0x0004F620 File Offset: 0x0004D820
		[Token(Token = "0x6006EFD")]
		[Address(RVA = "0x367E038", Offset = "0x367E038", VA = "0x367E038", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(EnumValue other)
		{
			return default(bool);
		}

		// Token: 0x06006EFE RID: 28414 RVA: 0x0004F638 File Offset: 0x0004D838
		[Token(Token = "0x6006EFE")]
		[Address(RVA = "0x367E0EC", Offset = "0x367E0EC", VA = "0x367E0EC", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006EFF RID: 28415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EFF")]
		[Address(RVA = "0x367E188", Offset = "0x367E188", VA = "0x367E188", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006F00 RID: 28416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F00")]
		[Address(RVA = "0x367E1E0", Offset = "0x367E1E0", VA = "0x367E1E0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006F01 RID: 28417 RVA: 0x0004F650 File Offset: 0x0004D850
		[Token(Token = "0x6006F01")]
		[Address(RVA = "0x367E2F8", Offset = "0x367E2F8", VA = "0x367E2F8", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006F02 RID: 28418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F02")]
		[Address(RVA = "0x367E420", Offset = "0x367E420", VA = "0x367E420", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(EnumValue other)
		{
		}

		// Token: 0x06006F03 RID: 28419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F03")]
		[Address(RVA = "0x367E4CC", Offset = "0x367E4CC", VA = "0x367E4CC", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04002CC8 RID: 11464
		[Token(Token = "0x4002CC8")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<EnumValue> _parser;

		// Token: 0x04002CC9 RID: 11465
		[Token(Token = "0x4002CC9")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CCA RID: 11466
		[Token(Token = "0x4002CCA")]
		public const int NameFieldNumber = 1;

		// Token: 0x04002CCB RID: 11467
		[Token(Token = "0x4002CCB")]
		[FieldOffset(Offset = "0x18")]
		private string name_;

		// Token: 0x04002CCC RID: 11468
		[Token(Token = "0x4002CCC")]
		public const int NumberFieldNumber = 2;

		// Token: 0x04002CCD RID: 11469
		[Token(Token = "0x4002CCD")]
		[FieldOffset(Offset = "0x20")]
		private int number_;

		// Token: 0x04002CCE RID: 11470
		[Token(Token = "0x4002CCE")]
		public const int OptionsFieldNumber = 3;

		// Token: 0x04002CCF RID: 11471
		[Token(Token = "0x4002CCF")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<Option> _repeated_options_codec;

		// Token: 0x04002CD0 RID: 11472
		[Token(Token = "0x4002CD0")]
		[FieldOffset(Offset = "0x28")]
		private readonly RepeatedField<Option> options_;
	}
}
