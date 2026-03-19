using System;
using System.Diagnostics;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Google.Protobuf.WellKnownTypes
{
	// Token: 0x02000B6D RID: 2925
	[Token(Token = "0x2000B6D")]
	public sealed class Int32Value : IMessage<Int32Value>, IMessage, IEquatable<Int32Value>, IDeepCloneable<Int32Value>
	{
		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06006F70 RID: 28528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000874")]
		[DebuggerNonUserCode]
		public static MessageParser<Int32Value> Parser
		{
			[Token(Token = "0x6006F70")]
			[Address(RVA = "0x368230C", Offset = "0x368230C", VA = "0x368230C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06006F71 RID: 28529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000875")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6006F71")]
			[Address(RVA = "0x3682364", Offset = "0x3682364", VA = "0x3682364")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06006F72 RID: 28530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000876")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6006F72")]
			[Address(RVA = "0x3682468", Offset = "0x3682468", VA = "0x3682468", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006F73 RID: 28531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F73")]
		[Address(RVA = "0x36824B4", Offset = "0x36824B4", VA = "0x36824B4")]
		[DebuggerNonUserCode]
		public Int32Value()
		{
		}

		// Token: 0x06006F74 RID: 28532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F74")]
		[Address(RVA = "0x36824BC", Offset = "0x36824BC", VA = "0x36824BC")]
		[DebuggerNonUserCode]
		public Int32Value(Int32Value other)
		{
		}

		// Token: 0x06006F75 RID: 28533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F75")]
		[Address(RVA = "0x3682508", Offset = "0x3682508", VA = "0x3682508", Slot = "10")]
		[DebuggerNonUserCode]
		public Int32Value Clone()
		{
			return null;
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06006F76 RID: 28534 RVA: 0x0004F8A8 File Offset: 0x0004DAA8
		// (set) Token: 0x06006F77 RID: 28535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000877")]
		[DebuggerNonUserCode]
		public int Value
		{
			[Token(Token = "0x6006F76")]
			[Address(RVA = "0x3682568", Offset = "0x3682568", VA = "0x3682568")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006F77")]
			[Address(RVA = "0x3682570", Offset = "0x3682570", VA = "0x3682570")]
			set
			{
			}
		}

		// Token: 0x06006F78 RID: 28536 RVA: 0x0004F8C0 File Offset: 0x0004DAC0
		[Token(Token = "0x6006F78")]
		[Address(RVA = "0x3682578", Offset = "0x3682578", VA = "0x3682578", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06006F79 RID: 28537 RVA: 0x0004F8D8 File Offset: 0x0004DAD8
		[Token(Token = "0x6006F79")]
		[Address(RVA = "0x36825DC", Offset = "0x36825DC", VA = "0x36825DC", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Int32Value other)
		{
			return default(bool);
		}

		// Token: 0x06006F7A RID: 28538 RVA: 0x0004F8F0 File Offset: 0x0004DAF0
		[Token(Token = "0x6006F7A")]
		[Address(RVA = "0x3682618", Offset = "0x3682618", VA = "0x3682618", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006F7B RID: 28539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F7B")]
		[Address(RVA = "0x3682674", Offset = "0x3682674", VA = "0x3682674", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006F7C RID: 28540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F7C")]
		[Address(RVA = "0x36826CC", Offset = "0x36826CC", VA = "0x36826CC", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006F7D RID: 28541 RVA: 0x0004F908 File Offset: 0x0004DB08
		[Token(Token = "0x6006F7D")]
		[Address(RVA = "0x3682734", Offset = "0x3682734", VA = "0x3682734", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006F7E RID: 28542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F7E")]
		[Address(RVA = "0x36827B4", Offset = "0x36827B4", VA = "0x36827B4", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Int32Value other)
		{
		}

		// Token: 0x06006F7F RID: 28543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F7F")]
		[Address(RVA = "0x36827F4", Offset = "0x36827F4", VA = "0x36827F4", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04002CEF RID: 11503
		[Token(Token = "0x4002CEF")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<Int32Value> _parser;

		// Token: 0x04002CF0 RID: 11504
		[Token(Token = "0x4002CF0")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CF1 RID: 11505
		[Token(Token = "0x4002CF1")]
		public const int ValueFieldNumber = 1;

		// Token: 0x04002CF2 RID: 11506
		[Token(Token = "0x4002CF2")]
		[FieldOffset(Offset = "0x18")]
		private int value_;
	}
}
