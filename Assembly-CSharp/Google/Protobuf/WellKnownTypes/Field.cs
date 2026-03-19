using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Google.Protobuf.WellKnownTypes
{
	// Token: 0x02000B59 RID: 2905
	[Token(Token = "0x2000B59")]
	public sealed class Field : IMessage<Field>, IMessage, IEquatable<Field>, IDeepCloneable<Field>
	{
		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06006EB2 RID: 28338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000843")]
		[DebuggerNonUserCode]
		public static MessageParser<Field> Parser
		{
			[Token(Token = "0x6006EB2")]
			[Address(RVA = "0x367B6C4", Offset = "0x367B6C4", VA = "0x367B6C4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06006EB3 RID: 28339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000844")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6006EB3")]
			[Address(RVA = "0x367B71C", Offset = "0x367B71C", VA = "0x367B71C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06006EB4 RID: 28340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000845")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6006EB4")]
			[Address(RVA = "0x367B820", Offset = "0x367B820", VA = "0x367B820", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006EB5 RID: 28341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EB5")]
		[Address(RVA = "0x367B86C", Offset = "0x367B86C", VA = "0x367B86C")]
		[DebuggerNonUserCode]
		public Field()
		{
		}

		// Token: 0x06006EB6 RID: 28342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EB6")]
		[Address(RVA = "0x367B950", Offset = "0x367B950", VA = "0x367B950")]
		[DebuggerNonUserCode]
		public Field(Field other)
		{
		}

		// Token: 0x06006EB7 RID: 28343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EB7")]
		[Address(RVA = "0x367BA40", Offset = "0x367BA40", VA = "0x367BA40", Slot = "10")]
		[DebuggerNonUserCode]
		public Field Clone()
		{
			return null;
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06006EB8 RID: 28344 RVA: 0x0004F4A0 File Offset: 0x0004D6A0
		// (set) Token: 0x06006EB9 RID: 28345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000846")]
		[DebuggerNonUserCode]
		public Field.Types.Kind Kind
		{
			[Token(Token = "0x6006EB8")]
			[Address(RVA = "0x367BAA0", Offset = "0x367BAA0", VA = "0x367BAA0")]
			get
			{
				return Field.Types.Kind.TypeUnknown;
			}
			[Token(Token = "0x6006EB9")]
			[Address(RVA = "0x367BAA8", Offset = "0x367BAA8", VA = "0x367BAA8")]
			set
			{
			}
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06006EBA RID: 28346 RVA: 0x0004F4B8 File Offset: 0x0004D6B8
		// (set) Token: 0x06006EBB RID: 28347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000847")]
		[DebuggerNonUserCode]
		public Field.Types.Cardinality Cardinality
		{
			[Token(Token = "0x6006EBA")]
			[Address(RVA = "0x367BAB0", Offset = "0x367BAB0", VA = "0x367BAB0")]
			get
			{
				return Field.Types.Cardinality.Unknown;
			}
			[Token(Token = "0x6006EBB")]
			[Address(RVA = "0x367BAB8", Offset = "0x367BAB8", VA = "0x367BAB8")]
			set
			{
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06006EBC RID: 28348 RVA: 0x0004F4D0 File Offset: 0x0004D6D0
		// (set) Token: 0x06006EBD RID: 28349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000848")]
		[DebuggerNonUserCode]
		public int Number
		{
			[Token(Token = "0x6006EBC")]
			[Address(RVA = "0x367BAC0", Offset = "0x367BAC0", VA = "0x367BAC0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006EBD")]
			[Address(RVA = "0x367BAC8", Offset = "0x367BAC8", VA = "0x367BAC8")]
			set
			{
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06006EBE RID: 28350 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006EBF RID: 28351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000849")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Token(Token = "0x6006EBE")]
			[Address(RVA = "0x367BAD0", Offset = "0x367BAD0", VA = "0x367BAD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006EBF")]
			[Address(RVA = "0x367BAD8", Offset = "0x367BAD8", VA = "0x367BAD8")]
			set
			{
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06006EC0 RID: 28352 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006EC1 RID: 28353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700084A")]
		[DebuggerNonUserCode]
		public string TypeUrl
		{
			[Token(Token = "0x6006EC0")]
			[Address(RVA = "0x367BB54", Offset = "0x367BB54", VA = "0x367BB54")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006EC1")]
			[Address(RVA = "0x367BB5C", Offset = "0x367BB5C", VA = "0x367BB5C")]
			set
			{
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06006EC2 RID: 28354 RVA: 0x0004F4E8 File Offset: 0x0004D6E8
		// (set) Token: 0x06006EC3 RID: 28355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700084B")]
		[DebuggerNonUserCode]
		public int OneofIndex
		{
			[Token(Token = "0x6006EC2")]
			[Address(RVA = "0x367BBD8", Offset = "0x367BBD8", VA = "0x367BBD8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006EC3")]
			[Address(RVA = "0x367BBE0", Offset = "0x367BBE0", VA = "0x367BBE0")]
			set
			{
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06006EC4 RID: 28356 RVA: 0x0004F500 File Offset: 0x0004D700
		// (set) Token: 0x06006EC5 RID: 28357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700084C")]
		[DebuggerNonUserCode]
		public bool Packed
		{
			[Token(Token = "0x6006EC4")]
			[Address(RVA = "0x367BBE8", Offset = "0x367BBE8", VA = "0x367BBE8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006EC5")]
			[Address(RVA = "0x367BBF0", Offset = "0x367BBF0", VA = "0x367BBF0")]
			set
			{
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06006EC6 RID: 28358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700084D")]
		[DebuggerNonUserCode]
		public RepeatedField<Option> Options
		{
			[Token(Token = "0x6006EC6")]
			[Address(RVA = "0x367BBFC", Offset = "0x367BBFC", VA = "0x367BBFC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06006EC7 RID: 28359 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006EC8 RID: 28360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700084E")]
		[DebuggerNonUserCode]
		public string JsonName
		{
			[Token(Token = "0x6006EC7")]
			[Address(RVA = "0x367BC04", Offset = "0x367BC04", VA = "0x367BC04")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006EC8")]
			[Address(RVA = "0x367BC0C", Offset = "0x367BC0C", VA = "0x367BC0C")]
			set
			{
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06006EC9 RID: 28361 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006ECA RID: 28362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700084F")]
		[DebuggerNonUserCode]
		public string DefaultValue
		{
			[Token(Token = "0x6006EC9")]
			[Address(RVA = "0x367BC88", Offset = "0x367BC88", VA = "0x367BC88")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006ECA")]
			[Address(RVA = "0x367BC90", Offset = "0x367BC90", VA = "0x367BC90")]
			set
			{
			}
		}

		// Token: 0x06006ECB RID: 28363 RVA: 0x0004F518 File Offset: 0x0004D718
		[Token(Token = "0x6006ECB")]
		[Address(RVA = "0x367BD0C", Offset = "0x367BD0C", VA = "0x367BD0C", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06006ECC RID: 28364 RVA: 0x0004F530 File Offset: 0x0004D730
		[Token(Token = "0x6006ECC")]
		[Address(RVA = "0x367BD70", Offset = "0x367BD70", VA = "0x367BD70", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Field other)
		{
			return default(bool);
		}

		// Token: 0x06006ECD RID: 28365 RVA: 0x0004F548 File Offset: 0x0004D748
		[Token(Token = "0x6006ECD")]
		[Address(RVA = "0x367BEB0", Offset = "0x367BEB0", VA = "0x367BEB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006ECE RID: 28366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006ECE")]
		[Address(RVA = "0x367C068", Offset = "0x367C068", VA = "0x367C068", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006ECF RID: 28367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ECF")]
		[Address(RVA = "0x367C0C0", Offset = "0x367C0C0", VA = "0x367C0C0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006ED0 RID: 28368 RVA: 0x0004F560 File Offset: 0x0004D760
		[Token(Token = "0x6006ED0")]
		[Address(RVA = "0x367C324", Offset = "0x367C324", VA = "0x367C324", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006ED1 RID: 28369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ED1")]
		[Address(RVA = "0x367C580", Offset = "0x367C580", VA = "0x367C580", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Field other)
		{
		}

		// Token: 0x06006ED2 RID: 28370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ED2")]
		[Address(RVA = "0x367C6A4", Offset = "0x367C6A4", VA = "0x367C6A4", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04002C88 RID: 11400
		[Token(Token = "0x4002C88")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<Field> _parser;

		// Token: 0x04002C89 RID: 11401
		[Token(Token = "0x4002C89")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C8A RID: 11402
		[Token(Token = "0x4002C8A")]
		public const int KindFieldNumber = 1;

		// Token: 0x04002C8B RID: 11403
		[Token(Token = "0x4002C8B")]
		[FieldOffset(Offset = "0x18")]
		private Field.Types.Kind kind_;

		// Token: 0x04002C8C RID: 11404
		[Token(Token = "0x4002C8C")]
		public const int CardinalityFieldNumber = 2;

		// Token: 0x04002C8D RID: 11405
		[Token(Token = "0x4002C8D")]
		[FieldOffset(Offset = "0x1C")]
		private Field.Types.Cardinality cardinality_;

		// Token: 0x04002C8E RID: 11406
		[Token(Token = "0x4002C8E")]
		public const int NumberFieldNumber = 3;

		// Token: 0x04002C8F RID: 11407
		[Token(Token = "0x4002C8F")]
		[FieldOffset(Offset = "0x20")]
		private int number_;

		// Token: 0x04002C90 RID: 11408
		[Token(Token = "0x4002C90")]
		public const int NameFieldNumber = 4;

		// Token: 0x04002C91 RID: 11409
		[Token(Token = "0x4002C91")]
		[FieldOffset(Offset = "0x28")]
		private string name_;

		// Token: 0x04002C92 RID: 11410
		[Token(Token = "0x4002C92")]
		public const int TypeUrlFieldNumber = 6;

		// Token: 0x04002C93 RID: 11411
		[Token(Token = "0x4002C93")]
		[FieldOffset(Offset = "0x30")]
		private string typeUrl_;

		// Token: 0x04002C94 RID: 11412
		[Token(Token = "0x4002C94")]
		public const int OneofIndexFieldNumber = 7;

		// Token: 0x04002C95 RID: 11413
		[Token(Token = "0x4002C95")]
		[FieldOffset(Offset = "0x38")]
		private int oneofIndex_;

		// Token: 0x04002C96 RID: 11414
		[Token(Token = "0x4002C96")]
		public const int PackedFieldNumber = 8;

		// Token: 0x04002C97 RID: 11415
		[Token(Token = "0x4002C97")]
		[FieldOffset(Offset = "0x3C")]
		private bool packed_;

		// Token: 0x04002C98 RID: 11416
		[Token(Token = "0x4002C98")]
		public const int OptionsFieldNumber = 9;

		// Token: 0x04002C99 RID: 11417
		[Token(Token = "0x4002C99")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<Option> _repeated_options_codec;

		// Token: 0x04002C9A RID: 11418
		[Token(Token = "0x4002C9A")]
		[FieldOffset(Offset = "0x40")]
		private readonly RepeatedField<Option> options_;

		// Token: 0x04002C9B RID: 11419
		[Token(Token = "0x4002C9B")]
		public const int JsonNameFieldNumber = 10;

		// Token: 0x04002C9C RID: 11420
		[Token(Token = "0x4002C9C")]
		[FieldOffset(Offset = "0x48")]
		private string jsonName_;

		// Token: 0x04002C9D RID: 11421
		[Token(Token = "0x4002C9D")]
		public const int DefaultValueFieldNumber = 11;

		// Token: 0x04002C9E RID: 11422
		[Token(Token = "0x4002C9E")]
		[FieldOffset(Offset = "0x50")]
		private string defaultValue_;

		// Token: 0x02000B5A RID: 2906
		[Token(Token = "0x2000B5A")]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02000B5B RID: 2907
			[Token(Token = "0x2000B5B")]
			public enum Kind
			{
				// Token: 0x04002CA0 RID: 11424
				[Token(Token = "0x4002CA0")]
				[OriginalName("TYPE_UNKNOWN")]
				TypeUnknown,
				// Token: 0x04002CA1 RID: 11425
				[Token(Token = "0x4002CA1")]
				[OriginalName("TYPE_DOUBLE")]
				TypeDouble,
				// Token: 0x04002CA2 RID: 11426
				[Token(Token = "0x4002CA2")]
				[OriginalName("TYPE_FLOAT")]
				TypeFloat,
				// Token: 0x04002CA3 RID: 11427
				[Token(Token = "0x4002CA3")]
				[OriginalName("TYPE_INT64")]
				TypeInt64,
				// Token: 0x04002CA4 RID: 11428
				[Token(Token = "0x4002CA4")]
				[OriginalName("TYPE_UINT64")]
				TypeUint64,
				// Token: 0x04002CA5 RID: 11429
				[Token(Token = "0x4002CA5")]
				[OriginalName("TYPE_INT32")]
				TypeInt32,
				// Token: 0x04002CA6 RID: 11430
				[Token(Token = "0x4002CA6")]
				[OriginalName("TYPE_FIXED64")]
				TypeFixed64,
				// Token: 0x04002CA7 RID: 11431
				[Token(Token = "0x4002CA7")]
				[OriginalName("TYPE_FIXED32")]
				TypeFixed32,
				// Token: 0x04002CA8 RID: 11432
				[Token(Token = "0x4002CA8")]
				[OriginalName("TYPE_BOOL")]
				TypeBool,
				// Token: 0x04002CA9 RID: 11433
				[Token(Token = "0x4002CA9")]
				[OriginalName("TYPE_STRING")]
				TypeString,
				// Token: 0x04002CAA RID: 11434
				[Token(Token = "0x4002CAA")]
				[OriginalName("TYPE_GROUP")]
				TypeGroup,
				// Token: 0x04002CAB RID: 11435
				[Token(Token = "0x4002CAB")]
				[OriginalName("TYPE_MESSAGE")]
				TypeMessage,
				// Token: 0x04002CAC RID: 11436
				[Token(Token = "0x4002CAC")]
				[OriginalName("TYPE_BYTES")]
				TypeBytes,
				// Token: 0x04002CAD RID: 11437
				[Token(Token = "0x4002CAD")]
				[OriginalName("TYPE_UINT32")]
				TypeUint32,
				// Token: 0x04002CAE RID: 11438
				[Token(Token = "0x4002CAE")]
				[OriginalName("TYPE_ENUM")]
				TypeEnum,
				// Token: 0x04002CAF RID: 11439
				[Token(Token = "0x4002CAF")]
				[OriginalName("TYPE_SFIXED32")]
				TypeSfixed32,
				// Token: 0x04002CB0 RID: 11440
				[Token(Token = "0x4002CB0")]
				[OriginalName("TYPE_SFIXED64")]
				TypeSfixed64,
				// Token: 0x04002CB1 RID: 11441
				[Token(Token = "0x4002CB1")]
				[OriginalName("TYPE_SINT32")]
				TypeSint32,
				// Token: 0x04002CB2 RID: 11442
				[Token(Token = "0x4002CB2")]
				[OriginalName("TYPE_SINT64")]
				TypeSint64
			}

			// Token: 0x02000B5C RID: 2908
			[Token(Token = "0x2000B5C")]
			public enum Cardinality
			{
				// Token: 0x04002CB4 RID: 11444
				[Token(Token = "0x4002CB4")]
				[OriginalName("CARDINALITY_UNKNOWN")]
				Unknown,
				// Token: 0x04002CB5 RID: 11445
				[Token(Token = "0x4002CB5")]
				[OriginalName("CARDINALITY_OPTIONAL")]
				Optional,
				// Token: 0x04002CB6 RID: 11446
				[Token(Token = "0x4002CB6")]
				[OriginalName("CARDINALITY_REQUIRED")]
				Required,
				// Token: 0x04002CB7 RID: 11447
				[Token(Token = "0x4002CB7")]
				[OriginalName("CARDINALITY_REPEATED")]
				Repeated
			}
		}
	}
}
