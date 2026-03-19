using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000B97 RID: 2967
	[Token(Token = "0x2000B97")]
	public sealed class MethodDescriptorProto : IMessage<MethodDescriptorProto>, IMessage, IEquatable<MethodDescriptorProto>, IDeepCloneable<MethodDescriptorProto>
	{
		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06007166 RID: 29030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000905")]
		[DebuggerNonUserCode]
		public static MessageParser<MethodDescriptorProto> Parser
		{
			[Token(Token = "0x6007166")]
			[Address(RVA = "0x31F98F8", Offset = "0x31F98F8", VA = "0x31F98F8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06007167 RID: 29031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000906")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6007167")]
			[Address(RVA = "0x31F9950", Offset = "0x31F9950", VA = "0x31F9950")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06007168 RID: 29032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000907")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6007168")]
			[Address(RVA = "0x31F9A54", Offset = "0x31F9A54", VA = "0x31F9A54", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007169 RID: 29033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007169")]
		[Address(RVA = "0x31F9AA0", Offset = "0x31F9AA0", VA = "0x31F9AA0")]
		[DebuggerNonUserCode]
		public MethodDescriptorProto()
		{
		}

		// Token: 0x0600716A RID: 29034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600716A")]
		[Address(RVA = "0x31F9AA8", Offset = "0x31F9AA8", VA = "0x31F9AA8")]
		[DebuggerNonUserCode]
		public MethodDescriptorProto(MethodDescriptorProto other)
		{
		}

		// Token: 0x0600716B RID: 29035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600716B")]
		[Address(RVA = "0x31F9B6C", Offset = "0x31F9B6C", VA = "0x31F9B6C", Slot = "10")]
		[DebuggerNonUserCode]
		public MethodDescriptorProto Clone()
		{
			return null;
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x0600716C RID: 29036 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600716D RID: 29037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000908")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Token(Token = "0x600716C")]
			[Address(RVA = "0x31F9BCC", Offset = "0x31F9BCC", VA = "0x31F9BCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600716D")]
			[Address(RVA = "0x31F9C30", Offset = "0x31F9C30", VA = "0x31F9C30")]
			set
			{
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x0600716E RID: 29038 RVA: 0x00050520 File Offset: 0x0004E720
		[Token(Token = "0x17000909")]
		[DebuggerNonUserCode]
		public bool HasName
		{
			[Token(Token = "0x600716E")]
			[Address(RVA = "0x31F9CAC", Offset = "0x31F9CAC", VA = "0x31F9CAC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600716F RID: 29039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600716F")]
		[Address(RVA = "0x31F9CBC", Offset = "0x31F9CBC", VA = "0x31F9CBC")]
		[DebuggerNonUserCode]
		public void ClearName()
		{
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06007170 RID: 29040 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007171 RID: 29041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700090A")]
		[DebuggerNonUserCode]
		public string InputType
		{
			[Token(Token = "0x6007170")]
			[Address(RVA = "0x31F9CC8", Offset = "0x31F9CC8", VA = "0x31F9CC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007171")]
			[Address(RVA = "0x31F9D2C", Offset = "0x31F9D2C", VA = "0x31F9D2C")]
			set
			{
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06007172 RID: 29042 RVA: 0x00050538 File Offset: 0x0004E738
		[Token(Token = "0x1700090B")]
		[DebuggerNonUserCode]
		public bool HasInputType
		{
			[Token(Token = "0x6007172")]
			[Address(RVA = "0x31F9DA8", Offset = "0x31F9DA8", VA = "0x31F9DA8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007173 RID: 29043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007173")]
		[Address(RVA = "0x31F9DB8", Offset = "0x31F9DB8", VA = "0x31F9DB8")]
		[DebuggerNonUserCode]
		public void ClearInputType()
		{
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06007174 RID: 29044 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007175 RID: 29045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700090C")]
		[DebuggerNonUserCode]
		public string OutputType
		{
			[Token(Token = "0x6007174")]
			[Address(RVA = "0x31F9DC4", Offset = "0x31F9DC4", VA = "0x31F9DC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007175")]
			[Address(RVA = "0x31F9E28", Offset = "0x31F9E28", VA = "0x31F9E28")]
			set
			{
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06007176 RID: 29046 RVA: 0x00050550 File Offset: 0x0004E750
		[Token(Token = "0x1700090D")]
		[DebuggerNonUserCode]
		public bool HasOutputType
		{
			[Token(Token = "0x6007176")]
			[Address(RVA = "0x31F9EA4", Offset = "0x31F9EA4", VA = "0x31F9EA4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007177 RID: 29047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007177")]
		[Address(RVA = "0x31F9EB4", Offset = "0x31F9EB4", VA = "0x31F9EB4")]
		[DebuggerNonUserCode]
		public void ClearOutputType()
		{
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06007178 RID: 29048 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007179 RID: 29049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700090E")]
		[DebuggerNonUserCode]
		public MethodOptions Options
		{
			[Token(Token = "0x6007178")]
			[Address(RVA = "0x31F9EC0", Offset = "0x31F9EC0", VA = "0x31F9EC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007179")]
			[Address(RVA = "0x31F9EC8", Offset = "0x31F9EC8", VA = "0x31F9EC8")]
			set
			{
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x0600717A RID: 29050 RVA: 0x00050568 File Offset: 0x0004E768
		[Token(Token = "0x1700090F")]
		[DebuggerNonUserCode]
		public bool HasOptions
		{
			[Token(Token = "0x600717A")]
			[Address(RVA = "0x31F9B5C", Offset = "0x31F9B5C", VA = "0x31F9B5C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600717B RID: 29051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600717B")]
		[Address(RVA = "0x31F9ED0", Offset = "0x31F9ED0", VA = "0x31F9ED0")]
		[DebuggerNonUserCode]
		public void ClearOptions()
		{
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x0600717C RID: 29052 RVA: 0x00050580 File Offset: 0x0004E780
		// (set) Token: 0x0600717D RID: 29053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000910")]
		[DebuggerNonUserCode]
		public bool ClientStreaming
		{
			[Token(Token = "0x600717C")]
			[Address(RVA = "0x31F9EDC", Offset = "0x31F9EDC", VA = "0x31F9EDC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600717D")]
			[Address(RVA = "0x31F9F4C", Offset = "0x31F9F4C", VA = "0x31F9F4C")]
			set
			{
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x0600717E RID: 29054 RVA: 0x00050598 File Offset: 0x0004E798
		[Token(Token = "0x17000911")]
		[DebuggerNonUserCode]
		public bool HasClientStreaming
		{
			[Token(Token = "0x600717E")]
			[Address(RVA = "0x31F9F64", Offset = "0x31F9F64", VA = "0x31F9F64")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600717F RID: 29055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600717F")]
		[Address(RVA = "0x31F9F70", Offset = "0x31F9F70", VA = "0x31F9F70")]
		[DebuggerNonUserCode]
		public void ClearClientStreaming()
		{
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06007180 RID: 29056 RVA: 0x000505B0 File Offset: 0x0004E7B0
		// (set) Token: 0x06007181 RID: 29057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000912")]
		[DebuggerNonUserCode]
		public bool ServerStreaming
		{
			[Token(Token = "0x6007180")]
			[Address(RVA = "0x31F9F80", Offset = "0x31F9F80", VA = "0x31F9F80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007181")]
			[Address(RVA = "0x31F9FF0", Offset = "0x31F9FF0", VA = "0x31F9FF0")]
			set
			{
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06007182 RID: 29058 RVA: 0x000505C8 File Offset: 0x0004E7C8
		[Token(Token = "0x17000913")]
		[DebuggerNonUserCode]
		public bool HasServerStreaming
		{
			[Token(Token = "0x6007182")]
			[Address(RVA = "0x31FA008", Offset = "0x31FA008", VA = "0x31FA008")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007183 RID: 29059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007183")]
		[Address(RVA = "0x31FA014", Offset = "0x31FA014", VA = "0x31FA014")]
		[DebuggerNonUserCode]
		public void ClearServerStreaming()
		{
		}

		// Token: 0x06007184 RID: 29060 RVA: 0x000505E0 File Offset: 0x0004E7E0
		[Token(Token = "0x6007184")]
		[Address(RVA = "0x31FA024", Offset = "0x31FA024", VA = "0x31FA024", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06007185 RID: 29061 RVA: 0x000505F8 File Offset: 0x0004E7F8
		[Token(Token = "0x6007185")]
		[Address(RVA = "0x31FA088", Offset = "0x31FA088", VA = "0x31FA088", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MethodDescriptorProto other)
		{
			return default(bool);
		}

		// Token: 0x06007186 RID: 29062 RVA: 0x00050610 File Offset: 0x0004E810
		[Token(Token = "0x6007186")]
		[Address(RVA = "0x31FA198", Offset = "0x31FA198", VA = "0x31FA198", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007187 RID: 29063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007187")]
		[Address(RVA = "0x31FA308", Offset = "0x31FA308", VA = "0x31FA308", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007188 RID: 29064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007188")]
		[Address(RVA = "0x31FA360", Offset = "0x31FA360", VA = "0x31FA360", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007189 RID: 29065 RVA: 0x00050628 File Offset: 0x0004E828
		[Token(Token = "0x6007189")]
		[Address(RVA = "0x31FA4CC", Offset = "0x31FA4CC", VA = "0x31FA4CC", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600718A RID: 29066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600718A")]
		[Address(RVA = "0x31FA62C", Offset = "0x31FA62C", VA = "0x31FA62C", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MethodDescriptorProto other)
		{
		}

		// Token: 0x0600718B RID: 29067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600718B")]
		[Address(RVA = "0x31FA798", Offset = "0x31FA798", VA = "0x31FA798", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04002DE8 RID: 11752
		[Token(Token = "0x4002DE8")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<MethodDescriptorProto> _parser;

		// Token: 0x04002DE9 RID: 11753
		[Token(Token = "0x4002DE9")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DEA RID: 11754
		[Token(Token = "0x4002DEA")]
		[FieldOffset(Offset = "0x18")]
		private int _hasBits0;

		// Token: 0x04002DEB RID: 11755
		[Token(Token = "0x4002DEB")]
		public const int NameFieldNumber = 1;

		// Token: 0x04002DEC RID: 11756
		[Token(Token = "0x4002DEC")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string NameDefaultValue;

		// Token: 0x04002DED RID: 11757
		[Token(Token = "0x4002DED")]
		[FieldOffset(Offset = "0x20")]
		private string name_;

		// Token: 0x04002DEE RID: 11758
		[Token(Token = "0x4002DEE")]
		public const int InputTypeFieldNumber = 2;

		// Token: 0x04002DEF RID: 11759
		[Token(Token = "0x4002DEF")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string InputTypeDefaultValue;

		// Token: 0x04002DF0 RID: 11760
		[Token(Token = "0x4002DF0")]
		[FieldOffset(Offset = "0x28")]
		private string inputType_;

		// Token: 0x04002DF1 RID: 11761
		[Token(Token = "0x4002DF1")]
		public const int OutputTypeFieldNumber = 3;

		// Token: 0x04002DF2 RID: 11762
		[Token(Token = "0x4002DF2")]
		[FieldOffset(Offset = "0x18")]
		private static readonly string OutputTypeDefaultValue;

		// Token: 0x04002DF3 RID: 11763
		[Token(Token = "0x4002DF3")]
		[FieldOffset(Offset = "0x30")]
		private string outputType_;

		// Token: 0x04002DF4 RID: 11764
		[Token(Token = "0x4002DF4")]
		public const int OptionsFieldNumber = 4;

		// Token: 0x04002DF5 RID: 11765
		[Token(Token = "0x4002DF5")]
		[FieldOffset(Offset = "0x38")]
		private MethodOptions options_;

		// Token: 0x04002DF6 RID: 11766
		[Token(Token = "0x4002DF6")]
		public const int ClientStreamingFieldNumber = 5;

		// Token: 0x04002DF7 RID: 11767
		[Token(Token = "0x4002DF7")]
		[FieldOffset(Offset = "0x20")]
		private static readonly bool ClientStreamingDefaultValue;

		// Token: 0x04002DF8 RID: 11768
		[Token(Token = "0x4002DF8")]
		[FieldOffset(Offset = "0x40")]
		private bool clientStreaming_;

		// Token: 0x04002DF9 RID: 11769
		[Token(Token = "0x4002DF9")]
		public const int ServerStreamingFieldNumber = 6;

		// Token: 0x04002DFA RID: 11770
		[Token(Token = "0x4002DFA")]
		[FieldOffset(Offset = "0x21")]
		private static readonly bool ServerStreamingDefaultValue;

		// Token: 0x04002DFB RID: 11771
		[Token(Token = "0x4002DFB")]
		[FieldOffset(Offset = "0x41")]
		private bool serverStreaming_;
	}
}
