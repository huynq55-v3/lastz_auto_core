using System;
using System.Diagnostics;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Google.Protobuf.WellKnownTypes
{
	// Token: 0x02000B69 RID: 2921
	[Token(Token = "0x2000B69")]
	public sealed class Int64Value : IMessage<Int64Value>, IMessage, IEquatable<Int64Value>, IDeepCloneable<Int64Value>
	{
		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06006F48 RID: 28488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700086C")]
		[DebuggerNonUserCode]
		public static MessageParser<Int64Value> Parser
		{
			[Token(Token = "0x6006F48")]
			[Address(RVA = "0x368147C", Offset = "0x368147C", VA = "0x368147C")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06006F49 RID: 28489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700086D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6006F49")]
			[Address(RVA = "0x36814D4", Offset = "0x36814D4", VA = "0x36814D4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06006F4A RID: 28490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700086E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6006F4A")]
			[Address(RVA = "0x36815D8", Offset = "0x36815D8", VA = "0x36815D8", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006F4B RID: 28491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F4B")]
		[Address(RVA = "0x3681624", Offset = "0x3681624", VA = "0x3681624")]
		[DebuggerNonUserCode]
		public Int64Value()
		{
		}

		// Token: 0x06006F4C RID: 28492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F4C")]
		[Address(RVA = "0x368162C", Offset = "0x368162C", VA = "0x368162C")]
		[DebuggerNonUserCode]
		public Int64Value(Int64Value other)
		{
		}

		// Token: 0x06006F4D RID: 28493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F4D")]
		[Address(RVA = "0x3681678", Offset = "0x3681678", VA = "0x3681678", Slot = "10")]
		[DebuggerNonUserCode]
		public Int64Value Clone()
		{
			return null;
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06006F4E RID: 28494 RVA: 0x0004F7B8 File Offset: 0x0004D9B8
		// (set) Token: 0x06006F4F RID: 28495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700086F")]
		[DebuggerNonUserCode]
		public long Value
		{
			[Token(Token = "0x6006F4E")]
			[Address(RVA = "0x36816D8", Offset = "0x36816D8", VA = "0x36816D8")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6006F4F")]
			[Address(RVA = "0x36816E0", Offset = "0x36816E0", VA = "0x36816E0")]
			set
			{
			}
		}

		// Token: 0x06006F50 RID: 28496 RVA: 0x0004F7D0 File Offset: 0x0004D9D0
		[Token(Token = "0x6006F50")]
		[Address(RVA = "0x36816E8", Offset = "0x36816E8", VA = "0x36816E8", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06006F51 RID: 28497 RVA: 0x0004F7E8 File Offset: 0x0004D9E8
		[Token(Token = "0x6006F51")]
		[Address(RVA = "0x368174C", Offset = "0x368174C", VA = "0x368174C", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Int64Value other)
		{
			return default(bool);
		}

		// Token: 0x06006F52 RID: 28498 RVA: 0x0004F800 File Offset: 0x0004DA00
		[Token(Token = "0x6006F52")]
		[Address(RVA = "0x3681788", Offset = "0x3681788", VA = "0x3681788", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006F53 RID: 28499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F53")]
		[Address(RVA = "0x36817E4", Offset = "0x36817E4", VA = "0x36817E4", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006F54 RID: 28500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F54")]
		[Address(RVA = "0x368183C", Offset = "0x368183C", VA = "0x368183C", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006F55 RID: 28501 RVA: 0x0004F818 File Offset: 0x0004DA18
		[Token(Token = "0x6006F55")]
		[Address(RVA = "0x36818A4", Offset = "0x36818A4", VA = "0x36818A4", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006F56 RID: 28502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F56")]
		[Address(RVA = "0x3681924", Offset = "0x3681924", VA = "0x3681924", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Int64Value other)
		{
		}

		// Token: 0x06006F57 RID: 28503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F57")]
		[Address(RVA = "0x3681964", Offset = "0x3681964", VA = "0x3681964", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04002CE5 RID: 11493
		[Token(Token = "0x4002CE5")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<Int64Value> _parser;

		// Token: 0x04002CE6 RID: 11494
		[Token(Token = "0x4002CE6")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CE7 RID: 11495
		[Token(Token = "0x4002CE7")]
		public const int ValueFieldNumber = 1;

		// Token: 0x04002CE8 RID: 11496
		[Token(Token = "0x4002CE8")]
		[FieldOffset(Offset = "0x18")]
		private long value_;
	}
}
