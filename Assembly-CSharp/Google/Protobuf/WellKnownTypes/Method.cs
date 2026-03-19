using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Google.Protobuf.WellKnownTypes
{
	// Token: 0x02000B37 RID: 2871
	[Token(Token = "0x2000B37")]
	public sealed class Method : IMessage<Method>, IMessage, IEquatable<Method>, IDeepCloneable<Method>
	{
		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06006D6B RID: 28011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007FA")]
		[DebuggerNonUserCode]
		public static MessageParser<Method> Parser
		{
			[Token(Token = "0x6006D6B")]
			[Address(RVA = "0x366BE4C", Offset = "0x366BE4C", VA = "0x366BE4C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06006D6C RID: 28012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007FB")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6006D6C")]
			[Address(RVA = "0x366BEA4", Offset = "0x366BEA4", VA = "0x366BEA4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06006D6D RID: 28013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007FC")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6006D6D")]
			[Address(RVA = "0x366BFA8", Offset = "0x366BFA8", VA = "0x366BFA8", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006D6E RID: 28014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D6E")]
		[Address(RVA = "0x366BFF4", Offset = "0x366BFF4", VA = "0x366BFF4")]
		[DebuggerNonUserCode]
		public Method()
		{
		}

		// Token: 0x06006D6F RID: 28015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D6F")]
		[Address(RVA = "0x366C0C8", Offset = "0x366C0C8", VA = "0x366C0C8")]
		[DebuggerNonUserCode]
		public Method(Method other)
		{
		}

		// Token: 0x06006D70 RID: 28016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D70")]
		[Address(RVA = "0x366C1A0", Offset = "0x366C1A0", VA = "0x366C1A0", Slot = "10")]
		[DebuggerNonUserCode]
		public Method Clone()
		{
			return null;
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06006D71 RID: 28017 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006D72 RID: 28018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007FD")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Token(Token = "0x6006D71")]
			[Address(RVA = "0x366C200", Offset = "0x366C200", VA = "0x366C200")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006D72")]
			[Address(RVA = "0x366C208", Offset = "0x366C208", VA = "0x366C208")]
			set
			{
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06006D73 RID: 28019 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006D74 RID: 28020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007FE")]
		[DebuggerNonUserCode]
		public string RequestTypeUrl
		{
			[Token(Token = "0x6006D73")]
			[Address(RVA = "0x366C284", Offset = "0x366C284", VA = "0x366C284")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006D74")]
			[Address(RVA = "0x366C28C", Offset = "0x366C28C", VA = "0x366C28C")]
			set
			{
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06006D75 RID: 28021 RVA: 0x0004ED68 File Offset: 0x0004CF68
		// (set) Token: 0x06006D76 RID: 28022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007FF")]
		[DebuggerNonUserCode]
		public bool RequestStreaming
		{
			[Token(Token = "0x6006D75")]
			[Address(RVA = "0x366C308", Offset = "0x366C308", VA = "0x366C308")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006D76")]
			[Address(RVA = "0x366C310", Offset = "0x366C310", VA = "0x366C310")]
			set
			{
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06006D77 RID: 28023 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006D78 RID: 28024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000800")]
		[DebuggerNonUserCode]
		public string ResponseTypeUrl
		{
			[Token(Token = "0x6006D77")]
			[Address(RVA = "0x366C31C", Offset = "0x366C31C", VA = "0x366C31C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006D78")]
			[Address(RVA = "0x366C324", Offset = "0x366C324", VA = "0x366C324")]
			set
			{
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06006D79 RID: 28025 RVA: 0x0004ED80 File Offset: 0x0004CF80
		// (set) Token: 0x06006D7A RID: 28026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000801")]
		[DebuggerNonUserCode]
		public bool ResponseStreaming
		{
			[Token(Token = "0x6006D79")]
			[Address(RVA = "0x366C3A0", Offset = "0x366C3A0", VA = "0x366C3A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006D7A")]
			[Address(RVA = "0x366C3A8", Offset = "0x366C3A8", VA = "0x366C3A8")]
			set
			{
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06006D7B RID: 28027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000802")]
		[DebuggerNonUserCode]
		public RepeatedField<Option> Options
		{
			[Token(Token = "0x6006D7B")]
			[Address(RVA = "0x366C3B4", Offset = "0x366C3B4", VA = "0x366C3B4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06006D7C RID: 28028 RVA: 0x0004ED98 File Offset: 0x0004CF98
		// (set) Token: 0x06006D7D RID: 28029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000803")]
		[DebuggerNonUserCode]
		public Syntax Syntax
		{
			[Token(Token = "0x6006D7C")]
			[Address(RVA = "0x366C3BC", Offset = "0x366C3BC", VA = "0x366C3BC")]
			get
			{
				return Syntax.Proto2;
			}
			[Token(Token = "0x6006D7D")]
			[Address(RVA = "0x366C3C4", Offset = "0x366C3C4", VA = "0x366C3C4")]
			set
			{
			}
		}

		// Token: 0x06006D7E RID: 28030 RVA: 0x0004EDB0 File Offset: 0x0004CFB0
		[Token(Token = "0x6006D7E")]
		[Address(RVA = "0x366C3CC", Offset = "0x366C3CC", VA = "0x366C3CC", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06006D7F RID: 28031 RVA: 0x0004EDC8 File Offset: 0x0004CFC8
		[Token(Token = "0x6006D7F")]
		[Address(RVA = "0x366C430", Offset = "0x366C430", VA = "0x366C430", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Method other)
		{
			return default(bool);
		}

		// Token: 0x06006D80 RID: 28032 RVA: 0x0004EDE0 File Offset: 0x0004CFE0
		[Token(Token = "0x6006D80")]
		[Address(RVA = "0x366C54C", Offset = "0x366C54C", VA = "0x366C54C", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006D81 RID: 28033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D81")]
		[Address(RVA = "0x366C6B8", Offset = "0x366C6B8", VA = "0x366C6B8", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006D82 RID: 28034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D82")]
		[Address(RVA = "0x366C710", Offset = "0x366C710", VA = "0x366C710", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006D83 RID: 28035 RVA: 0x0004EDF8 File Offset: 0x0004CFF8
		[Token(Token = "0x6006D83")]
		[Address(RVA = "0x366C8E8", Offset = "0x366C8E8", VA = "0x366C8E8", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006D84 RID: 28036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D84")]
		[Address(RVA = "0x366CA94", Offset = "0x366CA94", VA = "0x366CA94", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Method other)
		{
		}

		// Token: 0x06006D85 RID: 28037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D85")]
		[Address(RVA = "0x366CB88", Offset = "0x366CB88", VA = "0x366CB88", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04002C05 RID: 11269
		[Token(Token = "0x4002C05")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<Method> _parser;

		// Token: 0x04002C06 RID: 11270
		[Token(Token = "0x4002C06")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C07 RID: 11271
		[Token(Token = "0x4002C07")]
		public const int NameFieldNumber = 1;

		// Token: 0x04002C08 RID: 11272
		[Token(Token = "0x4002C08")]
		[FieldOffset(Offset = "0x18")]
		private string name_;

		// Token: 0x04002C09 RID: 11273
		[Token(Token = "0x4002C09")]
		public const int RequestTypeUrlFieldNumber = 2;

		// Token: 0x04002C0A RID: 11274
		[Token(Token = "0x4002C0A")]
		[FieldOffset(Offset = "0x20")]
		private string requestTypeUrl_;

		// Token: 0x04002C0B RID: 11275
		[Token(Token = "0x4002C0B")]
		public const int RequestStreamingFieldNumber = 3;

		// Token: 0x04002C0C RID: 11276
		[Token(Token = "0x4002C0C")]
		[FieldOffset(Offset = "0x28")]
		private bool requestStreaming_;

		// Token: 0x04002C0D RID: 11277
		[Token(Token = "0x4002C0D")]
		public const int ResponseTypeUrlFieldNumber = 4;

		// Token: 0x04002C0E RID: 11278
		[Token(Token = "0x4002C0E")]
		[FieldOffset(Offset = "0x30")]
		private string responseTypeUrl_;

		// Token: 0x04002C0F RID: 11279
		[Token(Token = "0x4002C0F")]
		public const int ResponseStreamingFieldNumber = 5;

		// Token: 0x04002C10 RID: 11280
		[Token(Token = "0x4002C10")]
		[FieldOffset(Offset = "0x38")]
		private bool responseStreaming_;

		// Token: 0x04002C11 RID: 11281
		[Token(Token = "0x4002C11")]
		public const int OptionsFieldNumber = 6;

		// Token: 0x04002C12 RID: 11282
		[Token(Token = "0x4002C12")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<Option> _repeated_options_codec;

		// Token: 0x04002C13 RID: 11283
		[Token(Token = "0x4002C13")]
		[FieldOffset(Offset = "0x40")]
		private readonly RepeatedField<Option> options_;

		// Token: 0x04002C14 RID: 11284
		[Token(Token = "0x4002C14")]
		public const int SyntaxFieldNumber = 7;

		// Token: 0x04002C15 RID: 11285
		[Token(Token = "0x4002C15")]
		[FieldOffset(Offset = "0x48")]
		private Syntax syntax_;
	}
}
