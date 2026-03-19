using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Google.Protobuf.WellKnownTypes
{
	// Token: 0x02000B4A RID: 2890
	[Token(Token = "0x2000B4A")]
	public sealed class Struct : IMessage<Struct>, IMessage, IEquatable<Struct>, IDeepCloneable<Struct>
	{
		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06006E1C RID: 28188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000821")]
		[DebuggerNonUserCode]
		public static MessageParser<Struct> Parser
		{
			[Token(Token = "0x6006E1C")]
			[Address(RVA = "0x36738B8", Offset = "0x36738B8", VA = "0x36738B8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06006E1D RID: 28189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000822")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6006E1D")]
			[Address(RVA = "0x3673910", Offset = "0x3673910", VA = "0x3673910")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06006E1E RID: 28190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000823")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6006E1E")]
			[Address(RVA = "0x3673A14", Offset = "0x3673A14", VA = "0x3673A14", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006E1F RID: 28191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E1F")]
		[Address(RVA = "0x3673A60", Offset = "0x3673A60", VA = "0x3673A60")]
		[DebuggerNonUserCode]
		public Struct()
		{
		}

		// Token: 0x06006E20 RID: 28192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E20")]
		[Address(RVA = "0x3673AE8", Offset = "0x3673AE8", VA = "0x3673AE8")]
		[DebuggerNonUserCode]
		public Struct(Struct other)
		{
		}

		// Token: 0x06006E21 RID: 28193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E21")]
		[Address(RVA = "0x3673B74", Offset = "0x3673B74", VA = "0x3673B74", Slot = "10")]
		[DebuggerNonUserCode]
		public Struct Clone()
		{
			return null;
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06006E22 RID: 28194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000824")]
		[DebuggerNonUserCode]
		public MapField<string, Value> Fields
		{
			[Token(Token = "0x6006E22")]
			[Address(RVA = "0x3673BD4", Offset = "0x3673BD4", VA = "0x3673BD4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006E23 RID: 28195 RVA: 0x0004F128 File Offset: 0x0004D328
		[Token(Token = "0x6006E23")]
		[Address(RVA = "0x3673BDC", Offset = "0x3673BDC", VA = "0x3673BDC", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06006E24 RID: 28196 RVA: 0x0004F140 File Offset: 0x0004D340
		[Token(Token = "0x6006E24")]
		[Address(RVA = "0x3673C40", Offset = "0x3673C40", VA = "0x3673C40", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Struct other)
		{
			return default(bool);
		}

		// Token: 0x06006E25 RID: 28197 RVA: 0x0004F158 File Offset: 0x0004D358
		[Token(Token = "0x6006E25")]
		[Address(RVA = "0x3673CD0", Offset = "0x3673CD0", VA = "0x3673CD0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006E26 RID: 28198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E26")]
		[Address(RVA = "0x3673D1C", Offset = "0x3673D1C", VA = "0x3673D1C", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006E27 RID: 28199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E27")]
		[Address(RVA = "0x3673D74", Offset = "0x3673D74", VA = "0x3673D74", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006E28 RID: 28200 RVA: 0x0004F170 File Offset: 0x0004D370
		[Token(Token = "0x6006E28")]
		[Address(RVA = "0x3673E2C", Offset = "0x3673E2C", VA = "0x3673E2C", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006E29 RID: 28201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E29")]
		[Address(RVA = "0x3673ED4", Offset = "0x3673ED4", VA = "0x3673ED4", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Struct other)
		{
		}

		// Token: 0x06006E2A RID: 28202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E2A")]
		[Address(RVA = "0x3673F5C", Offset = "0x3673F5C", VA = "0x3673F5C", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04002C46 RID: 11334
		[Token(Token = "0x4002C46")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<Struct> _parser;

		// Token: 0x04002C47 RID: 11335
		[Token(Token = "0x4002C47")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C48 RID: 11336
		[Token(Token = "0x4002C48")]
		public const int FieldsFieldNumber = 1;

		// Token: 0x04002C49 RID: 11337
		[Token(Token = "0x4002C49")]
		[FieldOffset(Offset = "0x8")]
		private static readonly MapField<string, Value>.Codec _map_fields_codec;

		// Token: 0x04002C4A RID: 11338
		[Token(Token = "0x4002C4A")]
		[FieldOffset(Offset = "0x18")]
		private readonly MapField<string, Value> fields_;
	}
}
