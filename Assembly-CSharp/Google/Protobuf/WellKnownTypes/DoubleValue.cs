using System;
using System.Diagnostics;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Google.Protobuf.WellKnownTypes
{
	// Token: 0x02000B65 RID: 2917
	[Token(Token = "0x2000B65")]
	public sealed class DoubleValue : IMessage<DoubleValue>, IMessage, IEquatable<DoubleValue>, IDeepCloneable<DoubleValue>
	{
		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06006F20 RID: 28448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000864")]
		[DebuggerNonUserCode]
		public static MessageParser<DoubleValue> Parser
		{
			[Token(Token = "0x6006F20")]
			[Address(RVA = "0x368041C", Offset = "0x368041C", VA = "0x368041C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06006F21 RID: 28449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000865")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6006F21")]
			[Address(RVA = "0x3680474", Offset = "0x3680474", VA = "0x3680474")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06006F22 RID: 28450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000866")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6006F22")]
			[Address(RVA = "0x3680578", Offset = "0x3680578", VA = "0x3680578", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006F23 RID: 28451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F23")]
		[Address(RVA = "0x36805C4", Offset = "0x36805C4", VA = "0x36805C4")]
		[DebuggerNonUserCode]
		public DoubleValue()
		{
		}

		// Token: 0x06006F24 RID: 28452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F24")]
		[Address(RVA = "0x36805CC", Offset = "0x36805CC", VA = "0x36805CC")]
		[DebuggerNonUserCode]
		public DoubleValue(DoubleValue other)
		{
		}

		// Token: 0x06006F25 RID: 28453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F25")]
		[Address(RVA = "0x3680618", Offset = "0x3680618", VA = "0x3680618", Slot = "10")]
		[DebuggerNonUserCode]
		public DoubleValue Clone()
		{
			return null;
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06006F26 RID: 28454 RVA: 0x0004F6C8 File Offset: 0x0004D8C8
		// (set) Token: 0x06006F27 RID: 28455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000867")]
		[DebuggerNonUserCode]
		public double Value
		{
			[Token(Token = "0x6006F26")]
			[Address(RVA = "0x3680678", Offset = "0x3680678", VA = "0x3680678")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6006F27")]
			[Address(RVA = "0x3680680", Offset = "0x3680680", VA = "0x3680680")]
			set
			{
			}
		}

		// Token: 0x06006F28 RID: 28456 RVA: 0x0004F6E0 File Offset: 0x0004D8E0
		[Token(Token = "0x6006F28")]
		[Address(RVA = "0x3680688", Offset = "0x3680688", VA = "0x3680688", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06006F29 RID: 28457 RVA: 0x0004F6F8 File Offset: 0x0004D8F8
		[Token(Token = "0x6006F29")]
		[Address(RVA = "0x36806EC", Offset = "0x36806EC", VA = "0x36806EC", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DoubleValue other)
		{
			return default(bool);
		}

		// Token: 0x06006F2A RID: 28458 RVA: 0x0004F710 File Offset: 0x0004D910
		[Token(Token = "0x6006F2A")]
		[Address(RVA = "0x36807D8", Offset = "0x36807D8", VA = "0x36807D8", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006F2B RID: 28459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F2B")]
		[Address(RVA = "0x36808B0", Offset = "0x36808B0", VA = "0x36808B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006F2C RID: 28460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F2C")]
		[Address(RVA = "0x3680908", Offset = "0x3680908", VA = "0x3680908", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006F2D RID: 28461 RVA: 0x0004F728 File Offset: 0x0004D928
		[Token(Token = "0x6006F2D")]
		[Address(RVA = "0x3680974", Offset = "0x3680974", VA = "0x3680974", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006F2E RID: 28462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F2E")]
		[Address(RVA = "0x36809A8", Offset = "0x36809A8", VA = "0x36809A8", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DoubleValue other)
		{
		}

		// Token: 0x06006F2F RID: 28463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F2F")]
		[Address(RVA = "0x36809EC", Offset = "0x36809EC", VA = "0x36809EC", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04002CDB RID: 11483
		[Token(Token = "0x4002CDB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<DoubleValue> _parser;

		// Token: 0x04002CDC RID: 11484
		[Token(Token = "0x4002CDC")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CDD RID: 11485
		[Token(Token = "0x4002CDD")]
		public const int ValueFieldNumber = 1;

		// Token: 0x04002CDE RID: 11486
		[Token(Token = "0x4002CDE")]
		[FieldOffset(Offset = "0x18")]
		private double value_;
	}
}
