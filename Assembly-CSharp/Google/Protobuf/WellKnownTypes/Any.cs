using System;
using System.Diagnostics;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Google.Protobuf.WellKnownTypes
{
	// Token: 0x02000B32 RID: 2866
	[Token(Token = "0x2000B32")]
	public sealed class Any : IMessage<Any>, IMessage, IEquatable<Any>, IDeepCloneable<Any>
	{
		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06006D2F RID: 27951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007EA")]
		[DebuggerNonUserCode]
		public static MessageParser<Any> Parser
		{
			[Token(Token = "0x6006D2F")]
			[Address(RVA = "0x36F40F4", Offset = "0x36F40F4", VA = "0x36F40F4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06006D30 RID: 27952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007EB")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6006D30")]
			[Address(RVA = "0x36E54D0", Offset = "0x36E54D0", VA = "0x36E54D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06006D31 RID: 27953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007EC")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6006D31")]
			[Address(RVA = "0x36F414C", Offset = "0x36F414C", VA = "0x36F414C", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006D32 RID: 27954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D32")]
		[Address(RVA = "0x36F4198", Offset = "0x36F4198", VA = "0x36F4198")]
		[DebuggerNonUserCode]
		public Any()
		{
		}

		// Token: 0x06006D33 RID: 27955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D33")]
		[Address(RVA = "0x36F4264", Offset = "0x36F4264", VA = "0x36F4264")]
		[DebuggerNonUserCode]
		public Any(Any other)
		{
		}

		// Token: 0x06006D34 RID: 27956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D34")]
		[Address(RVA = "0x36F42C0", Offset = "0x36F42C0", VA = "0x36F42C0", Slot = "10")]
		[DebuggerNonUserCode]
		public Any Clone()
		{
			return null;
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06006D35 RID: 27957 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006D36 RID: 27958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007ED")]
		[DebuggerNonUserCode]
		public string TypeUrl
		{
			[Token(Token = "0x6006D35")]
			[Address(RVA = "0x36F4320", Offset = "0x36F4320", VA = "0x36F4320")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006D36")]
			[Address(RVA = "0x36F4328", Offset = "0x36F4328", VA = "0x36F4328")]
			set
			{
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06006D37 RID: 27959 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006D38 RID: 27960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007EE")]
		[DebuggerNonUserCode]
		public ByteString Value
		{
			[Token(Token = "0x6006D37")]
			[Address(RVA = "0x36F43A4", Offset = "0x36F43A4", VA = "0x36F43A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006D38")]
			[Address(RVA = "0x36F43AC", Offset = "0x36F43AC", VA = "0x36F43AC")]
			set
			{
			}
		}

		// Token: 0x06006D39 RID: 27961 RVA: 0x0004EC60 File Offset: 0x0004CE60
		[Token(Token = "0x6006D39")]
		[Address(RVA = "0x36F4428", Offset = "0x36F4428", VA = "0x36F4428", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06006D3A RID: 27962 RVA: 0x0004EC78 File Offset: 0x0004CE78
		[Token(Token = "0x6006D3A")]
		[Address(RVA = "0x36F448C", Offset = "0x36F448C", VA = "0x36F448C", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Any other)
		{
			return default(bool);
		}

		// Token: 0x06006D3B RID: 27963 RVA: 0x0004EC90 File Offset: 0x0004CE90
		[Token(Token = "0x6006D3B")]
		[Address(RVA = "0x36F454C", Offset = "0x36F454C", VA = "0x36F454C", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006D3C RID: 27964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D3C")]
		[Address(RVA = "0x36F45D8", Offset = "0x36F45D8", VA = "0x36F45D8", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006D3D RID: 27965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D3D")]
		[Address(RVA = "0x36F462C", Offset = "0x36F462C", VA = "0x36F462C", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006D3E RID: 27966 RVA: 0x0004ECA8 File Offset: 0x0004CEA8
		[Token(Token = "0x6006D3E")]
		[Address(RVA = "0x36F46C0", Offset = "0x36F46C0", VA = "0x36F46C0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006D3F RID: 27967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D3F")]
		[Address(RVA = "0x36F4784", Offset = "0x36F4784", VA = "0x36F4784", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Any other)
		{
		}

		// Token: 0x06006D40 RID: 27968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D40")]
		[Address(RVA = "0x36F4804", Offset = "0x36F4804", VA = "0x36F4804", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006D41 RID: 27969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D41")]
		[Address(RVA = "0x36F48A4", Offset = "0x36F48A4", VA = "0x36F48A4")]
		private static string GetTypeUrl(MessageDescriptor descriptor, string prefix)
		{
			return null;
		}

		// Token: 0x06006D42 RID: 27970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D42")]
		[Address(RVA = "0x36E5F34", Offset = "0x36E5F34", VA = "0x36E5F34")]
		public static string GetTypeName(string typeUrl)
		{
			return null;
		}

		// Token: 0x06006D43 RID: 27971 RVA: 0x0004ECC0 File Offset: 0x0004CEC0
		[Token(Token = "0x6006D43")]
		[Address(RVA = "0x36F4930", Offset = "0x36F4930", VA = "0x36F4930")]
		public bool Is(MessageDescriptor descriptor)
		{
			return default(bool);
		}

		// Token: 0x06006D44 RID: 27972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D44")]
		public T Unpack<T>() where T : IMessage, new()
		{
			return null;
		}

		// Token: 0x06006D45 RID: 27973 RVA: 0x0004ECD8 File Offset: 0x0004CED8
		[Token(Token = "0x6006D45")]
		public bool TryUnpack<T>(out T result) where T : IMessage, new()
		{
			return default(bool);
		}

		// Token: 0x06006D46 RID: 27974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D46")]
		[Address(RVA = "0x36F49E8", Offset = "0x36F49E8", VA = "0x36F49E8")]
		public static Any Pack(IMessage message)
		{
			return null;
		}

		// Token: 0x06006D47 RID: 27975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D47")]
		[Address(RVA = "0x36F4A54", Offset = "0x36F4A54", VA = "0x36F4A54")]
		public static Any Pack(IMessage message, string typeUrlPrefix)
		{
			return null;
		}

		// Token: 0x04002BE8 RID: 11240
		[Token(Token = "0x4002BE8")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<Any> _parser;

		// Token: 0x04002BE9 RID: 11241
		[Token(Token = "0x4002BE9")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BEA RID: 11242
		[Token(Token = "0x4002BEA")]
		public const int TypeUrlFieldNumber = 1;

		// Token: 0x04002BEB RID: 11243
		[Token(Token = "0x4002BEB")]
		[FieldOffset(Offset = "0x18")]
		private string typeUrl_;

		// Token: 0x04002BEC RID: 11244
		[Token(Token = "0x4002BEC")]
		public const int ValueFieldNumber = 2;

		// Token: 0x04002BED RID: 11245
		[Token(Token = "0x4002BED")]
		[FieldOffset(Offset = "0x20")]
		private ByteString value_;

		// Token: 0x04002BEE RID: 11246
		[Token(Token = "0x4002BEE")]
		private const string DefaultPrefix = "type.googleapis.com";
	}
}
