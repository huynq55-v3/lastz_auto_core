using System;
using System.Diagnostics;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Google.Protobuf.WellKnownTypes
{
	// Token: 0x02000B62 RID: 2914
	[Token(Token = "0x2000B62")]
	public sealed class Option : IMessage<Option>, IMessage, IEquatable<Option>, IDeepCloneable<Option>
	{
		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06006F08 RID: 28424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700085E")]
		[DebuggerNonUserCode]
		public static MessageParser<Option> Parser
		{
			[Token(Token = "0x6006F08")]
			[Address(RVA = "0x367E880", Offset = "0x367E880", VA = "0x367E880")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06006F09 RID: 28425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700085F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6006F09")]
			[Address(RVA = "0x367E8D8", Offset = "0x367E8D8", VA = "0x367E8D8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06006F0A RID: 28426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000860")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6006F0A")]
			[Address(RVA = "0x367E9DC", Offset = "0x367E9DC", VA = "0x367E9DC", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006F0B RID: 28427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F0B")]
		[Address(RVA = "0x367EA28", Offset = "0x367EA28", VA = "0x367EA28")]
		[DebuggerNonUserCode]
		public Option()
		{
		}

		// Token: 0x06006F0C RID: 28428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F0C")]
		[Address(RVA = "0x367EA80", Offset = "0x367EA80", VA = "0x367EA80")]
		[DebuggerNonUserCode]
		public Option(Option other)
		{
		}

		// Token: 0x06006F0D RID: 28429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F0D")]
		[Address(RVA = "0x367EAF8", Offset = "0x367EAF8", VA = "0x367EAF8", Slot = "10")]
		[DebuggerNonUserCode]
		public Option Clone()
		{
			return null;
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06006F0E RID: 28430 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006F0F RID: 28431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000861")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Token(Token = "0x6006F0E")]
			[Address(RVA = "0x367EB58", Offset = "0x367EB58", VA = "0x367EB58")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006F0F")]
			[Address(RVA = "0x367EB60", Offset = "0x367EB60", VA = "0x367EB60")]
			set
			{
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06006F10 RID: 28432 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006F11 RID: 28433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000862")]
		[DebuggerNonUserCode]
		public Any Value
		{
			[Token(Token = "0x6006F10")]
			[Address(RVA = "0x367EBDC", Offset = "0x367EBDC", VA = "0x367EBDC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006F11")]
			[Address(RVA = "0x367EBE4", Offset = "0x367EBE4", VA = "0x367EBE4")]
			set
			{
			}
		}

		// Token: 0x06006F12 RID: 28434 RVA: 0x0004F668 File Offset: 0x0004D868
		[Token(Token = "0x6006F12")]
		[Address(RVA = "0x367EBEC", Offset = "0x367EBEC", VA = "0x367EBEC", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06006F13 RID: 28435 RVA: 0x0004F680 File Offset: 0x0004D880
		[Token(Token = "0x6006F13")]
		[Address(RVA = "0x367EC50", Offset = "0x367EC50", VA = "0x367EC50", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Option other)
		{
			return default(bool);
		}

		// Token: 0x06006F14 RID: 28436 RVA: 0x0004F698 File Offset: 0x0004D898
		[Token(Token = "0x6006F14")]
		[Address(RVA = "0x367ECC4", Offset = "0x367ECC4", VA = "0x367ECC4", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006F15 RID: 28437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F15")]
		[Address(RVA = "0x367ED3C", Offset = "0x367ED3C", VA = "0x367ED3C", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006F16 RID: 28438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F16")]
		[Address(RVA = "0x367ED94", Offset = "0x367ED94", VA = "0x367ED94", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006F17 RID: 28439 RVA: 0x0004F6B0 File Offset: 0x0004D8B0
		[Token(Token = "0x6006F17")]
		[Address(RVA = "0x367EE30", Offset = "0x367EE30", VA = "0x367EE30", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006F18 RID: 28440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F18")]
		[Address(RVA = "0x367EEF8", Offset = "0x367EEF8", VA = "0x367EEF8", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Option other)
		{
		}

		// Token: 0x06006F19 RID: 28441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F19")]
		[Address(RVA = "0x367EFE0", Offset = "0x367EFE0", VA = "0x367EFE0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04002CD2 RID: 11474
		[Token(Token = "0x4002CD2")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<Option> _parser;

		// Token: 0x04002CD3 RID: 11475
		[Token(Token = "0x4002CD3")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CD4 RID: 11476
		[Token(Token = "0x4002CD4")]
		public const int NameFieldNumber = 1;

		// Token: 0x04002CD5 RID: 11477
		[Token(Token = "0x4002CD5")]
		[FieldOffset(Offset = "0x18")]
		private string name_;

		// Token: 0x04002CD6 RID: 11478
		[Token(Token = "0x4002CD6")]
		public const int ValueFieldNumber = 2;

		// Token: 0x04002CD7 RID: 11479
		[Token(Token = "0x4002CD7")]
		[FieldOffset(Offset = "0x20")]
		private Any value_;
	}
}
