using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Google.Protobuf.WellKnownTypes
{
	// Token: 0x02000B5E RID: 2910
	[Token(Token = "0x2000B5E")]
	public sealed class Enum : IMessage<Enum>, IMessage, IEquatable<Enum>, IDeepCloneable<Enum>
	{
		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06006ED7 RID: 28375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000850")]
		[DebuggerNonUserCode]
		public static MessageParser<Enum> Parser
		{
			[Token(Token = "0x6006ED7")]
			[Address(RVA = "0x367CB54", Offset = "0x367CB54", VA = "0x367CB54")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06006ED8 RID: 28376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000851")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6006ED8")]
			[Address(RVA = "0x367CBAC", Offset = "0x367CBAC", VA = "0x367CBAC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06006ED9 RID: 28377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000852")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6006ED9")]
			[Address(RVA = "0x367CCB0", Offset = "0x367CCB0", VA = "0x367CCB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006EDA RID: 28378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EDA")]
		[Address(RVA = "0x367CCFC", Offset = "0x367CCFC", VA = "0x367CCFC")]
		[DebuggerNonUserCode]
		public Enum()
		{
		}

		// Token: 0x06006EDB RID: 28379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EDB")]
		[Address(RVA = "0x367CE00", Offset = "0x367CE00", VA = "0x367CE00")]
		[DebuggerNonUserCode]
		public Enum(Enum other)
		{
		}

		// Token: 0x06006EDC RID: 28380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EDC")]
		[Address(RVA = "0x367CEFC", Offset = "0x367CEFC", VA = "0x367CEFC", Slot = "10")]
		[DebuggerNonUserCode]
		public Enum Clone()
		{
			return null;
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06006EDD RID: 28381 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006EDE RID: 28382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000853")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Token(Token = "0x6006EDD")]
			[Address(RVA = "0x367CF5C", Offset = "0x367CF5C", VA = "0x367CF5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006EDE")]
			[Address(RVA = "0x367CF64", Offset = "0x367CF64", VA = "0x367CF64")]
			set
			{
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06006EDF RID: 28383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000854")]
		[DebuggerNonUserCode]
		public RepeatedField<EnumValue> Enumvalue
		{
			[Token(Token = "0x6006EDF")]
			[Address(RVA = "0x367CFE0", Offset = "0x367CFE0", VA = "0x367CFE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06006EE0 RID: 28384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000855")]
		[DebuggerNonUserCode]
		public RepeatedField<Option> Options
		{
			[Token(Token = "0x6006EE0")]
			[Address(RVA = "0x367CFE8", Offset = "0x367CFE8", VA = "0x367CFE8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06006EE1 RID: 28385 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006EE2 RID: 28386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000856")]
		[DebuggerNonUserCode]
		public SourceContext SourceContext
		{
			[Token(Token = "0x6006EE1")]
			[Address(RVA = "0x367CFF0", Offset = "0x367CFF0", VA = "0x367CFF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006EE2")]
			[Address(RVA = "0x367CFF8", Offset = "0x367CFF8", VA = "0x367CFF8")]
			set
			{
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06006EE3 RID: 28387 RVA: 0x0004F578 File Offset: 0x0004D778
		// (set) Token: 0x06006EE4 RID: 28388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000857")]
		[DebuggerNonUserCode]
		public Syntax Syntax
		{
			[Token(Token = "0x6006EE3")]
			[Address(RVA = "0x367D000", Offset = "0x367D000", VA = "0x367D000")]
			get
			{
				return Syntax.Proto2;
			}
			[Token(Token = "0x6006EE4")]
			[Address(RVA = "0x367D008", Offset = "0x367D008", VA = "0x367D008")]
			set
			{
			}
		}

		// Token: 0x06006EE5 RID: 28389 RVA: 0x0004F590 File Offset: 0x0004D790
		[Token(Token = "0x6006EE5")]
		[Address(RVA = "0x367D010", Offset = "0x367D010", VA = "0x367D010", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06006EE6 RID: 28390 RVA: 0x0004F5A8 File Offset: 0x0004D7A8
		[Token(Token = "0x6006EE6")]
		[Address(RVA = "0x367D074", Offset = "0x367D074", VA = "0x367D074", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Enum other)
		{
			return default(bool);
		}

		// Token: 0x06006EE7 RID: 28391 RVA: 0x0004F5C0 File Offset: 0x0004D7C0
		[Token(Token = "0x6006EE7")]
		[Address(RVA = "0x367D168", Offset = "0x367D168", VA = "0x367D168", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006EE8 RID: 28392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EE8")]
		[Address(RVA = "0x367D238", Offset = "0x367D238", VA = "0x367D238", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006EE9 RID: 28393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EE9")]
		[Address(RVA = "0x367D290", Offset = "0x367D290", VA = "0x367D290", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006EEA RID: 28394 RVA: 0x0004F5D8 File Offset: 0x0004D7D8
		[Token(Token = "0x6006EEA")]
		[Address(RVA = "0x367D408", Offset = "0x367D408", VA = "0x367D408", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006EEB RID: 28395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EEB")]
		[Address(RVA = "0x367D590", Offset = "0x367D590", VA = "0x367D590", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Enum other)
		{
		}

		// Token: 0x06006EEC RID: 28396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EEC")]
		[Address(RVA = "0x367D6CC", Offset = "0x367D6CC", VA = "0x367D6CC", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04002CB9 RID: 11449
		[Token(Token = "0x4002CB9")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<Enum> _parser;

		// Token: 0x04002CBA RID: 11450
		[Token(Token = "0x4002CBA")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CBB RID: 11451
		[Token(Token = "0x4002CBB")]
		public const int NameFieldNumber = 1;

		// Token: 0x04002CBC RID: 11452
		[Token(Token = "0x4002CBC")]
		[FieldOffset(Offset = "0x18")]
		private string name_;

		// Token: 0x04002CBD RID: 11453
		[Token(Token = "0x4002CBD")]
		public const int EnumvalueFieldNumber = 2;

		// Token: 0x04002CBE RID: 11454
		[Token(Token = "0x4002CBE")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<EnumValue> _repeated_enumvalue_codec;

		// Token: 0x04002CBF RID: 11455
		[Token(Token = "0x4002CBF")]
		[FieldOffset(Offset = "0x20")]
		private readonly RepeatedField<EnumValue> enumvalue_;

		// Token: 0x04002CC0 RID: 11456
		[Token(Token = "0x4002CC0")]
		public const int OptionsFieldNumber = 3;

		// Token: 0x04002CC1 RID: 11457
		[Token(Token = "0x4002CC1")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FieldCodec<Option> _repeated_options_codec;

		// Token: 0x04002CC2 RID: 11458
		[Token(Token = "0x4002CC2")]
		[FieldOffset(Offset = "0x28")]
		private readonly RepeatedField<Option> options_;

		// Token: 0x04002CC3 RID: 11459
		[Token(Token = "0x4002CC3")]
		public const int SourceContextFieldNumber = 4;

		// Token: 0x04002CC4 RID: 11460
		[Token(Token = "0x4002CC4")]
		[FieldOffset(Offset = "0x30")]
		private SourceContext sourceContext_;

		// Token: 0x04002CC5 RID: 11461
		[Token(Token = "0x4002CC5")]
		public const int SyntaxFieldNumber = 5;

		// Token: 0x04002CC6 RID: 11462
		[Token(Token = "0x4002CC6")]
		[FieldOffset(Offset = "0x38")]
		private Syntax syntax_;
	}
}
