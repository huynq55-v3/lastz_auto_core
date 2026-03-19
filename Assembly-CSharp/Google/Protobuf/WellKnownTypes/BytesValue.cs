using System;
using System.Diagnostics;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Google.Protobuf.WellKnownTypes
{
	// Token: 0x02000B75 RID: 2933
	[Token(Token = "0x2000B75")]
	public sealed class BytesValue : IMessage<BytesValue>, IMessage, IEquatable<BytesValue>, IDeepCloneable<BytesValue>
	{
		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06006FC0 RID: 28608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000884")]
		[DebuggerNonUserCode]
		public static MessageParser<BytesValue> Parser
		{
			[Token(Token = "0x6006FC0")]
			[Address(RVA = "0x3684158", Offset = "0x3684158", VA = "0x3684158")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06006FC1 RID: 28609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000885")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6006FC1")]
			[Address(RVA = "0x36841B0", Offset = "0x36841B0", VA = "0x36841B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06006FC2 RID: 28610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000886")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6006FC2")]
			[Address(RVA = "0x36842B4", Offset = "0x36842B4", VA = "0x36842B4", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006FC3 RID: 28611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FC3")]
		[Address(RVA = "0x3684300", Offset = "0x3684300", VA = "0x3684300")]
		[DebuggerNonUserCode]
		public BytesValue()
		{
		}

		// Token: 0x06006FC4 RID: 28612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FC4")]
		[Address(RVA = "0x36843A0", Offset = "0x36843A0", VA = "0x36843A0")]
		[DebuggerNonUserCode]
		public BytesValue(BytesValue other)
		{
		}

		// Token: 0x06006FC5 RID: 28613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FC5")]
		[Address(RVA = "0x36843F0", Offset = "0x36843F0", VA = "0x36843F0", Slot = "10")]
		[DebuggerNonUserCode]
		public BytesValue Clone()
		{
			return null;
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06006FC6 RID: 28614 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006FC7 RID: 28615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000887")]
		[DebuggerNonUserCode]
		public ByteString Value
		{
			[Token(Token = "0x6006FC6")]
			[Address(RVA = "0x3684450", Offset = "0x3684450", VA = "0x3684450")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006FC7")]
			[Address(RVA = "0x3684458", Offset = "0x3684458", VA = "0x3684458")]
			set
			{
			}
		}

		// Token: 0x06006FC8 RID: 28616 RVA: 0x0004FA70 File Offset: 0x0004DC70
		[Token(Token = "0x6006FC8")]
		[Address(RVA = "0x36844D4", Offset = "0x36844D4", VA = "0x36844D4", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06006FC9 RID: 28617 RVA: 0x0004FA88 File Offset: 0x0004DC88
		[Token(Token = "0x6006FC9")]
		[Address(RVA = "0x3684538", Offset = "0x3684538", VA = "0x3684538", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BytesValue other)
		{
			return default(bool);
		}

		// Token: 0x06006FCA RID: 28618 RVA: 0x0004FAA0 File Offset: 0x0004DCA0
		[Token(Token = "0x6006FCA")]
		[Address(RVA = "0x36845E4", Offset = "0x36845E4", VA = "0x36845E4", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006FCB RID: 28619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FCB")]
		[Address(RVA = "0x3684650", Offset = "0x3684650", VA = "0x3684650", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006FCC RID: 28620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FCC")]
		[Address(RVA = "0x36846A8", Offset = "0x36846A8", VA = "0x36846A8", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006FCD RID: 28621 RVA: 0x0004FAB8 File Offset: 0x0004DCB8
		[Token(Token = "0x6006FCD")]
		[Address(RVA = "0x368471C", Offset = "0x368471C", VA = "0x368471C", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006FCE RID: 28622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FCE")]
		[Address(RVA = "0x36847B8", Offset = "0x36847B8", VA = "0x36847B8", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BytesValue other)
		{
		}

		// Token: 0x06006FCF RID: 28623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FCF")]
		[Address(RVA = "0x3684824", Offset = "0x3684824", VA = "0x3684824", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04002D03 RID: 11523
		[Token(Token = "0x4002D03")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<BytesValue> _parser;

		// Token: 0x04002D04 RID: 11524
		[Token(Token = "0x4002D04")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D05 RID: 11525
		[Token(Token = "0x4002D05")]
		public const int ValueFieldNumber = 1;

		// Token: 0x04002D06 RID: 11526
		[Token(Token = "0x4002D06")]
		[FieldOffset(Offset = "0x18")]
		private ByteString value_;
	}
}
