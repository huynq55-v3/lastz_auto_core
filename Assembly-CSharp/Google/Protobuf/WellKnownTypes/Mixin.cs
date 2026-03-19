using System;
using System.Diagnostics;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Google.Protobuf.WellKnownTypes
{
	// Token: 0x02000B39 RID: 2873
	[Token(Token = "0x2000B39")]
	public sealed class Mixin : IMessage<Mixin>, IMessage, IEquatable<Mixin>, IDeepCloneable<Mixin>
	{
		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06006D8A RID: 28042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000804")]
		[DebuggerNonUserCode]
		public static MessageParser<Mixin> Parser
		{
			[Token(Token = "0x6006D8A")]
			[Address(RVA = "0x366CFD8", Offset = "0x366CFD8", VA = "0x366CFD8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06006D8B RID: 28043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000805")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6006D8B")]
			[Address(RVA = "0x366D030", Offset = "0x366D030", VA = "0x366D030")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06006D8C RID: 28044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000806")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6006D8C")]
			[Address(RVA = "0x366D134", Offset = "0x366D134", VA = "0x366D134", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006D8D RID: 28045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D8D")]
		[Address(RVA = "0x366D180", Offset = "0x366D180", VA = "0x366D180")]
		[DebuggerNonUserCode]
		public Mixin()
		{
		}

		// Token: 0x06006D8E RID: 28046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D8E")]
		[Address(RVA = "0x366D1E8", Offset = "0x366D1E8", VA = "0x366D1E8")]
		[DebuggerNonUserCode]
		public Mixin(Mixin other)
		{
		}

		// Token: 0x06006D8F RID: 28047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D8F")]
		[Address(RVA = "0x366D248", Offset = "0x366D248", VA = "0x366D248", Slot = "10")]
		[DebuggerNonUserCode]
		public Mixin Clone()
		{
			return null;
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06006D90 RID: 28048 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006D91 RID: 28049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000807")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Token(Token = "0x6006D90")]
			[Address(RVA = "0x366D2A8", Offset = "0x366D2A8", VA = "0x366D2A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006D91")]
			[Address(RVA = "0x366D2B0", Offset = "0x366D2B0", VA = "0x366D2B0")]
			set
			{
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06006D92 RID: 28050 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006D93 RID: 28051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000808")]
		[DebuggerNonUserCode]
		public string Root
		{
			[Token(Token = "0x6006D92")]
			[Address(RVA = "0x366D32C", Offset = "0x366D32C", VA = "0x366D32C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006D93")]
			[Address(RVA = "0x366D334", Offset = "0x366D334", VA = "0x366D334")]
			set
			{
			}
		}

		// Token: 0x06006D94 RID: 28052 RVA: 0x0004EE10 File Offset: 0x0004D010
		[Token(Token = "0x6006D94")]
		[Address(RVA = "0x366D3B0", Offset = "0x366D3B0", VA = "0x366D3B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06006D95 RID: 28053 RVA: 0x0004EE28 File Offset: 0x0004D028
		[Token(Token = "0x6006D95")]
		[Address(RVA = "0x366D414", Offset = "0x366D414", VA = "0x366D414", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Mixin other)
		{
			return default(bool);
		}

		// Token: 0x06006D96 RID: 28054 RVA: 0x0004EE40 File Offset: 0x0004D040
		[Token(Token = "0x6006D96")]
		[Address(RVA = "0x366D488", Offset = "0x366D488", VA = "0x366D488", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006D97 RID: 28055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D97")]
		[Address(RVA = "0x366D508", Offset = "0x366D508", VA = "0x366D508", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006D98 RID: 28056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D98")]
		[Address(RVA = "0x366D560", Offset = "0x366D560", VA = "0x366D560", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006D99 RID: 28057 RVA: 0x0004EE58 File Offset: 0x0004D058
		[Token(Token = "0x6006D99")]
		[Address(RVA = "0x366D604", Offset = "0x366D604", VA = "0x366D604", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006D9A RID: 28058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D9A")]
		[Address(RVA = "0x366D6D4", Offset = "0x366D6D4", VA = "0x366D6D4", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Mixin other)
		{
		}

		// Token: 0x06006D9B RID: 28059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D9B")]
		[Address(RVA = "0x366D750", Offset = "0x366D750", VA = "0x366D750", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04002C17 RID: 11287
		[Token(Token = "0x4002C17")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<Mixin> _parser;

		// Token: 0x04002C18 RID: 11288
		[Token(Token = "0x4002C18")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C19 RID: 11289
		[Token(Token = "0x4002C19")]
		public const int NameFieldNumber = 1;

		// Token: 0x04002C1A RID: 11290
		[Token(Token = "0x4002C1A")]
		[FieldOffset(Offset = "0x18")]
		private string name_;

		// Token: 0x04002C1B RID: 11291
		[Token(Token = "0x4002C1B")]
		public const int RootFieldNumber = 2;

		// Token: 0x04002C1C RID: 11292
		[Token(Token = "0x4002C1C")]
		[FieldOffset(Offset = "0x20")]
		private string root_;
	}
}
