using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Google.Protobuf.WellKnownTypes
{
	// Token: 0x02000B4F RID: 2895
	[Token(Token = "0x2000B4F")]
	public sealed class ListValue : IMessage<ListValue>, IMessage, IEquatable<ListValue>, IDeepCloneable<ListValue>
	{
		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06006E55 RID: 28245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700082F")]
		[DebuggerNonUserCode]
		public static MessageParser<ListValue> Parser
		{
			[Token(Token = "0x6006E55")]
			[Address(RVA = "0x3675E24", Offset = "0x3675E24", VA = "0x3675E24")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06006E56 RID: 28246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000830")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6006E56")]
			[Address(RVA = "0x3675E7C", Offset = "0x3675E7C", VA = "0x3675E7C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06006E57 RID: 28247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000831")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6006E57")]
			[Address(RVA = "0x3675F80", Offset = "0x3675F80", VA = "0x3675F80", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006E58 RID: 28248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E58")]
		[Address(RVA = "0x3675548", Offset = "0x3675548", VA = "0x3675548")]
		[DebuggerNonUserCode]
		public ListValue()
		{
		}

		// Token: 0x06006E59 RID: 28249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E59")]
		[Address(RVA = "0x3675FCC", Offset = "0x3675FCC", VA = "0x3675FCC")]
		[DebuggerNonUserCode]
		public ListValue(ListValue other)
		{
		}

		// Token: 0x06006E5A RID: 28250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E5A")]
		[Address(RVA = "0x3674B00", Offset = "0x3674B00", VA = "0x3674B00", Slot = "10")]
		[DebuggerNonUserCode]
		public ListValue Clone()
		{
			return null;
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06006E5B RID: 28251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000832")]
		[DebuggerNonUserCode]
		public RepeatedField<Value> Values
		{
			[Token(Token = "0x6006E5B")]
			[Address(RVA = "0x3676058", Offset = "0x3676058", VA = "0x3676058")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006E5C RID: 28252 RVA: 0x0004F248 File Offset: 0x0004D448
		[Token(Token = "0x6006E5C")]
		[Address(RVA = "0x3676060", Offset = "0x3676060", VA = "0x3676060", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06006E5D RID: 28253 RVA: 0x0004F260 File Offset: 0x0004D460
		[Token(Token = "0x6006E5D")]
		[Address(RVA = "0x36760C4", Offset = "0x36760C4", VA = "0x36760C4", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ListValue other)
		{
			return default(bool);
		}

		// Token: 0x06006E5E RID: 28254 RVA: 0x0004F278 File Offset: 0x0004D478
		[Token(Token = "0x6006E5E")]
		[Address(RVA = "0x3676154", Offset = "0x3676154", VA = "0x3676154", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006E5F RID: 28255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E5F")]
		[Address(RVA = "0x36761A0", Offset = "0x36761A0", VA = "0x36761A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006E60 RID: 28256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E60")]
		[Address(RVA = "0x36761F8", Offset = "0x36761F8", VA = "0x36761F8", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006E61 RID: 28257 RVA: 0x0004F290 File Offset: 0x0004D490
		[Token(Token = "0x6006E61")]
		[Address(RVA = "0x36762B0", Offset = "0x36762B0", VA = "0x36762B0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006E62 RID: 28258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E62")]
		[Address(RVA = "0x36755D0", Offset = "0x36755D0", VA = "0x36755D0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ListValue other)
		{
		}

		// Token: 0x06006E63 RID: 28259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E63")]
		[Address(RVA = "0x3676358", Offset = "0x3676358", VA = "0x3676358", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04002C5F RID: 11359
		[Token(Token = "0x4002C5F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<ListValue> _parser;

		// Token: 0x04002C60 RID: 11360
		[Token(Token = "0x4002C60")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C61 RID: 11361
		[Token(Token = "0x4002C61")]
		public const int ValuesFieldNumber = 1;

		// Token: 0x04002C62 RID: 11362
		[Token(Token = "0x4002C62")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FieldCodec<Value> _repeated_values_codec;

		// Token: 0x04002C63 RID: 11363
		[Token(Token = "0x4002C63")]
		[FieldOffset(Offset = "0x18")]
		private readonly RepeatedField<Value> values_;
	}
}
