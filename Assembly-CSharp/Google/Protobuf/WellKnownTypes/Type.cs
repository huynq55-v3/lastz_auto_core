using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Google.Protobuf.WellKnownTypes
{
	// Token: 0x02000B57 RID: 2903
	[Token(Token = "0x2000B57")]
	public sealed class Type : IMessage<Type>, IMessage, IEquatable<Type>, IDeepCloneable<Type>
	{
		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06006E97 RID: 28311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700083A")]
		[DebuggerNonUserCode]
		public static MessageParser<Type> Parser
		{
			[Token(Token = "0x6006E97")]
			[Address(RVA = "0x367A458", Offset = "0x367A458", VA = "0x367A458")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06006E98 RID: 28312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700083B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6006E98")]
			[Address(RVA = "0x367A4B0", Offset = "0x367A4B0", VA = "0x367A4B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06006E99 RID: 28313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700083C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6006E99")]
			[Address(RVA = "0x367A5B4", Offset = "0x367A5B4", VA = "0x367A5B4", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006E9A RID: 28314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E9A")]
		[Address(RVA = "0x367A600", Offset = "0x367A600", VA = "0x367A600")]
		[DebuggerNonUserCode]
		public Type()
		{
		}

		// Token: 0x06006E9B RID: 28315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E9B")]
		[Address(RVA = "0x367A754", Offset = "0x367A754", VA = "0x367A754")]
		[DebuggerNonUserCode]
		public Type(Type other)
		{
		}

		// Token: 0x06006E9C RID: 28316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E9C")]
		[Address(RVA = "0x367A884", Offset = "0x367A884", VA = "0x367A884", Slot = "10")]
		[DebuggerNonUserCode]
		public Type Clone()
		{
			return null;
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06006E9D RID: 28317 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006E9E RID: 28318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700083D")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Token(Token = "0x6006E9D")]
			[Address(RVA = "0x367A8E4", Offset = "0x367A8E4", VA = "0x367A8E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E9E")]
			[Address(RVA = "0x367A8EC", Offset = "0x367A8EC", VA = "0x367A8EC")]
			set
			{
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06006E9F RID: 28319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700083E")]
		[DebuggerNonUserCode]
		public RepeatedField<Field> Fields
		{
			[Token(Token = "0x6006E9F")]
			[Address(RVA = "0x367A968", Offset = "0x367A968", VA = "0x367A968")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06006EA0 RID: 28320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700083F")]
		[DebuggerNonUserCode]
		public RepeatedField<string> Oneofs
		{
			[Token(Token = "0x6006EA0")]
			[Address(RVA = "0x367A970", Offset = "0x367A970", VA = "0x367A970")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06006EA1 RID: 28321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000840")]
		[DebuggerNonUserCode]
		public RepeatedField<Option> Options
		{
			[Token(Token = "0x6006EA1")]
			[Address(RVA = "0x367A978", Offset = "0x367A978", VA = "0x367A978")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06006EA2 RID: 28322 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006EA3 RID: 28323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000841")]
		[DebuggerNonUserCode]
		public SourceContext SourceContext
		{
			[Token(Token = "0x6006EA2")]
			[Address(RVA = "0x367A980", Offset = "0x367A980", VA = "0x367A980")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006EA3")]
			[Address(RVA = "0x367A988", Offset = "0x367A988", VA = "0x367A988")]
			set
			{
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06006EA4 RID: 28324 RVA: 0x0004F428 File Offset: 0x0004D628
		// (set) Token: 0x06006EA5 RID: 28325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000842")]
		[DebuggerNonUserCode]
		public Syntax Syntax
		{
			[Token(Token = "0x6006EA4")]
			[Address(RVA = "0x367A990", Offset = "0x367A990", VA = "0x367A990")]
			get
			{
				return Syntax.Proto2;
			}
			[Token(Token = "0x6006EA5")]
			[Address(RVA = "0x367A998", Offset = "0x367A998", VA = "0x367A998")]
			set
			{
			}
		}

		// Token: 0x06006EA6 RID: 28326 RVA: 0x0004F440 File Offset: 0x0004D640
		[Token(Token = "0x6006EA6")]
		[Address(RVA = "0x367A9A0", Offset = "0x367A9A0", VA = "0x367A9A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06006EA7 RID: 28327 RVA: 0x0004F458 File Offset: 0x0004D658
		[Token(Token = "0x6006EA7")]
		[Address(RVA = "0x367AA04", Offset = "0x367AA04", VA = "0x367AA04", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Type other)
		{
			return default(bool);
		}

		// Token: 0x06006EA8 RID: 28328 RVA: 0x0004F470 File Offset: 0x0004D670
		[Token(Token = "0x6006EA8")]
		[Address(RVA = "0x367AB24", Offset = "0x367AB24", VA = "0x367AB24", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006EA9 RID: 28329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EA9")]
		[Address(RVA = "0x367AC1C", Offset = "0x367AC1C", VA = "0x367AC1C", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006EAA RID: 28330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EAA")]
		[Address(RVA = "0x367AC74", Offset = "0x367AC74", VA = "0x367AC74", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006EAB RID: 28331 RVA: 0x0004F488 File Offset: 0x0004D688
		[Token(Token = "0x6006EAB")]
		[Address(RVA = "0x367AE20", Offset = "0x367AE20", VA = "0x367AE20", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006EAC RID: 28332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EAC")]
		[Address(RVA = "0x367AFE4", Offset = "0x367AFE4", VA = "0x367AFE4", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Type other)
		{
		}

		// Token: 0x06006EAD RID: 28333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EAD")]
		[Address(RVA = "0x367B148", Offset = "0x367B148", VA = "0x367B148", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04002C76 RID: 11382
		[Token(Token = "0x4002C76")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<Type> _parser;

		// Token: 0x04002C77 RID: 11383
		[Token(Token = "0x4002C77")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C78 RID: 11384
		[Token(Token = "0x4002C78")]
		public const int NameFieldNumber = 1;

		// Token: 0x04002C79 RID: 11385
		[Token(Token = "0x4002C79")]
		[FieldOffset(Offset = "0x18")]
		private string name_;

		// Token: 0x04002C7A RID: 11386
		[Token(Token = "0x4002C7A")]
		public const int FieldsFieldNumber = 2;

		// Token: 0x04002C7B RID: 11387
		[Token(Token = "0x4002C7B")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<Field> _repeated_fields_codec;

		// Token: 0x04002C7C RID: 11388
		[Token(Token = "0x4002C7C")]
		[FieldOffset(Offset = "0x20")]
		private readonly RepeatedField<Field> fields_;

		// Token: 0x04002C7D RID: 11389
		[Token(Token = "0x4002C7D")]
		public const int OneofsFieldNumber = 3;

		// Token: 0x04002C7E RID: 11390
		[Token(Token = "0x4002C7E")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FieldCodec<string> _repeated_oneofs_codec;

		// Token: 0x04002C7F RID: 11391
		[Token(Token = "0x4002C7F")]
		[FieldOffset(Offset = "0x28")]
		private readonly RepeatedField<string> oneofs_;

		// Token: 0x04002C80 RID: 11392
		[Token(Token = "0x4002C80")]
		public const int OptionsFieldNumber = 4;

		// Token: 0x04002C81 RID: 11393
		[Token(Token = "0x4002C81")]
		[FieldOffset(Offset = "0x18")]
		private static readonly FieldCodec<Option> _repeated_options_codec;

		// Token: 0x04002C82 RID: 11394
		[Token(Token = "0x4002C82")]
		[FieldOffset(Offset = "0x30")]
		private readonly RepeatedField<Option> options_;

		// Token: 0x04002C83 RID: 11395
		[Token(Token = "0x4002C83")]
		public const int SourceContextFieldNumber = 5;

		// Token: 0x04002C84 RID: 11396
		[Token(Token = "0x4002C84")]
		[FieldOffset(Offset = "0x38")]
		private SourceContext sourceContext_;

		// Token: 0x04002C85 RID: 11397
		[Token(Token = "0x4002C85")]
		public const int SyntaxFieldNumber = 6;

		// Token: 0x04002C86 RID: 11398
		[Token(Token = "0x4002C86")]
		[FieldOffset(Offset = "0x40")]
		private Syntax syntax_;
	}
}
