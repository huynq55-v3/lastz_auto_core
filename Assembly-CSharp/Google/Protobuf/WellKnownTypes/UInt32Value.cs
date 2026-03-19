using System;
using System.Diagnostics;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Google.Protobuf.WellKnownTypes
{
	// Token: 0x02000B6F RID: 2927
	[Token(Token = "0x2000B6F")]
	public sealed class UInt32Value : IMessage<UInt32Value>, IMessage, IEquatable<UInt32Value>, IDeepCloneable<UInt32Value>
	{
		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06006F84 RID: 28548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000878")]
		[DebuggerNonUserCode]
		public static MessageParser<UInt32Value> Parser
		{
			[Token(Token = "0x6006F84")]
			[Address(RVA = "0x3682A54", Offset = "0x3682A54", VA = "0x3682A54")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06006F85 RID: 28549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000879")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6006F85")]
			[Address(RVA = "0x3682AAC", Offset = "0x3682AAC", VA = "0x3682AAC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06006F86 RID: 28550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700087A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6006F86")]
			[Address(RVA = "0x3682BB0", Offset = "0x3682BB0", VA = "0x3682BB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006F87 RID: 28551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F87")]
		[Address(RVA = "0x3682BFC", Offset = "0x3682BFC", VA = "0x3682BFC")]
		[DebuggerNonUserCode]
		public UInt32Value()
		{
		}

		// Token: 0x06006F88 RID: 28552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F88")]
		[Address(RVA = "0x3682C04", Offset = "0x3682C04", VA = "0x3682C04")]
		[DebuggerNonUserCode]
		public UInt32Value(UInt32Value other)
		{
		}

		// Token: 0x06006F89 RID: 28553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F89")]
		[Address(RVA = "0x3682C50", Offset = "0x3682C50", VA = "0x3682C50", Slot = "10")]
		[DebuggerNonUserCode]
		public UInt32Value Clone()
		{
			return null;
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06006F8A RID: 28554 RVA: 0x0004F920 File Offset: 0x0004DB20
		// (set) Token: 0x06006F8B RID: 28555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700087B")]
		[DebuggerNonUserCode]
		public uint Value
		{
			[Token(Token = "0x6006F8A")]
			[Address(RVA = "0x3682CB0", Offset = "0x3682CB0", VA = "0x3682CB0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6006F8B")]
			[Address(RVA = "0x3682CB8", Offset = "0x3682CB8", VA = "0x3682CB8")]
			set
			{
			}
		}

		// Token: 0x06006F8C RID: 28556 RVA: 0x0004F938 File Offset: 0x0004DB38
		[Token(Token = "0x6006F8C")]
		[Address(RVA = "0x3682CC0", Offset = "0x3682CC0", VA = "0x3682CC0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06006F8D RID: 28557 RVA: 0x0004F950 File Offset: 0x0004DB50
		[Token(Token = "0x6006F8D")]
		[Address(RVA = "0x3682D24", Offset = "0x3682D24", VA = "0x3682D24", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(UInt32Value other)
		{
			return default(bool);
		}

		// Token: 0x06006F8E RID: 28558 RVA: 0x0004F968 File Offset: 0x0004DB68
		[Token(Token = "0x6006F8E")]
		[Address(RVA = "0x3682D60", Offset = "0x3682D60", VA = "0x3682D60", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006F8F RID: 28559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F8F")]
		[Address(RVA = "0x3682DBC", Offset = "0x3682DBC", VA = "0x3682DBC", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006F90 RID: 28560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F90")]
		[Address(RVA = "0x3682E14", Offset = "0x3682E14", VA = "0x3682E14", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006F91 RID: 28561 RVA: 0x0004F980 File Offset: 0x0004DB80
		[Token(Token = "0x6006F91")]
		[Address(RVA = "0x3682E7C", Offset = "0x3682E7C", VA = "0x3682E7C", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006F92 RID: 28562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F92")]
		[Address(RVA = "0x3682EFC", Offset = "0x3682EFC", VA = "0x3682EFC", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(UInt32Value other)
		{
		}

		// Token: 0x06006F93 RID: 28563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F93")]
		[Address(RVA = "0x3682F3C", Offset = "0x3682F3C", VA = "0x3682F3C", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04002CF4 RID: 11508
		[Token(Token = "0x4002CF4")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<UInt32Value> _parser;

		// Token: 0x04002CF5 RID: 11509
		[Token(Token = "0x4002CF5")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CF6 RID: 11510
		[Token(Token = "0x4002CF6")]
		public const int ValueFieldNumber = 1;

		// Token: 0x04002CF7 RID: 11511
		[Token(Token = "0x4002CF7")]
		[FieldOffset(Offset = "0x18")]
		private uint value_;
	}
}
