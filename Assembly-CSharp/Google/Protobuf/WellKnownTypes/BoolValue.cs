using System;
using System.Diagnostics;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Google.Protobuf.WellKnownTypes
{
	// Token: 0x02000B71 RID: 2929
	[Token(Token = "0x2000B71")]
	public sealed class BoolValue : IMessage<BoolValue>, IMessage, IEquatable<BoolValue>, IDeepCloneable<BoolValue>
	{
		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06006F98 RID: 28568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700087C")]
		[DebuggerNonUserCode]
		public static MessageParser<BoolValue> Parser
		{
			[Token(Token = "0x6006F98")]
			[Address(RVA = "0x368319C", Offset = "0x368319C", VA = "0x368319C")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06006F99 RID: 28569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700087D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6006F99")]
			[Address(RVA = "0x36831F4", Offset = "0x36831F4", VA = "0x36831F4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06006F9A RID: 28570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700087E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6006F9A")]
			[Address(RVA = "0x36832F8", Offset = "0x36832F8", VA = "0x36832F8", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006F9B RID: 28571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F9B")]
		[Address(RVA = "0x3683344", Offset = "0x3683344", VA = "0x3683344")]
		[DebuggerNonUserCode]
		public BoolValue()
		{
		}

		// Token: 0x06006F9C RID: 28572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F9C")]
		[Address(RVA = "0x368334C", Offset = "0x368334C", VA = "0x368334C")]
		[DebuggerNonUserCode]
		public BoolValue(BoolValue other)
		{
		}

		// Token: 0x06006F9D RID: 28573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F9D")]
		[Address(RVA = "0x3683398", Offset = "0x3683398", VA = "0x3683398", Slot = "10")]
		[DebuggerNonUserCode]
		public BoolValue Clone()
		{
			return null;
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06006F9E RID: 28574 RVA: 0x0004F998 File Offset: 0x0004DB98
		// (set) Token: 0x06006F9F RID: 28575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700087F")]
		[DebuggerNonUserCode]
		public bool Value
		{
			[Token(Token = "0x6006F9E")]
			[Address(RVA = "0x36833F8", Offset = "0x36833F8", VA = "0x36833F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006F9F")]
			[Address(RVA = "0x3683400", Offset = "0x3683400", VA = "0x3683400")]
			set
			{
			}
		}

		// Token: 0x06006FA0 RID: 28576 RVA: 0x0004F9B0 File Offset: 0x0004DBB0
		[Token(Token = "0x6006FA0")]
		[Address(RVA = "0x368340C", Offset = "0x368340C", VA = "0x368340C", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06006FA1 RID: 28577 RVA: 0x0004F9C8 File Offset: 0x0004DBC8
		[Token(Token = "0x6006FA1")]
		[Address(RVA = "0x3683470", Offset = "0x3683470", VA = "0x3683470", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BoolValue other)
		{
			return default(bool);
		}

		// Token: 0x06006FA2 RID: 28578 RVA: 0x0004F9E0 File Offset: 0x0004DBE0
		[Token(Token = "0x6006FA2")]
		[Address(RVA = "0x36834BC", Offset = "0x36834BC", VA = "0x36834BC", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006FA3 RID: 28579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FA3")]
		[Address(RVA = "0x368354C", Offset = "0x368354C", VA = "0x368354C", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006FA4 RID: 28580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FA4")]
		[Address(RVA = "0x36835A4", Offset = "0x36835A4", VA = "0x36835A4", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006FA5 RID: 28581 RVA: 0x0004F9F8 File Offset: 0x0004DBF8
		[Token(Token = "0x6006FA5")]
		[Address(RVA = "0x368360C", Offset = "0x368360C", VA = "0x368360C", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006FA6 RID: 28582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FA6")]
		[Address(RVA = "0x3683638", Offset = "0x3683638", VA = "0x3683638", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BoolValue other)
		{
		}

		// Token: 0x06006FA7 RID: 28583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FA7")]
		[Address(RVA = "0x3683678", Offset = "0x3683678", VA = "0x3683678", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04002CF9 RID: 11513
		[Token(Token = "0x4002CF9")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<BoolValue> _parser;

		// Token: 0x04002CFA RID: 11514
		[Token(Token = "0x4002CFA")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CFB RID: 11515
		[Token(Token = "0x4002CFB")]
		public const int ValueFieldNumber = 1;

		// Token: 0x04002CFC RID: 11516
		[Token(Token = "0x4002CFC")]
		[FieldOffset(Offset = "0x18")]
		private bool value_;
	}
}
