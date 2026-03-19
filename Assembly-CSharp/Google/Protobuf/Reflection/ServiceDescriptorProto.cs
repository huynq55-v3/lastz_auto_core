using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000B95 RID: 2965
	[Token(Token = "0x2000B95")]
	public sealed class ServiceDescriptorProto : IMessage<ServiceDescriptorProto>, IMessage, IEquatable<ServiceDescriptorProto>, IDeepCloneable<ServiceDescriptorProto>
	{
		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x0600714B RID: 29003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008FD")]
		[DebuggerNonUserCode]
		public static MessageParser<ServiceDescriptorProto> Parser
		{
			[Token(Token = "0x600714B")]
			[Address(RVA = "0x31F8AD0", Offset = "0x31F8AD0", VA = "0x31F8AD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x0600714C RID: 29004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008FE")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x600714C")]
			[Address(RVA = "0x31F8B28", Offset = "0x31F8B28", VA = "0x31F8B28")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x0600714D RID: 29005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008FF")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x600714D")]
			[Address(RVA = "0x31F8C2C", Offset = "0x31F8C2C", VA = "0x31F8C2C", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600714E RID: 29006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600714E")]
		[Address(RVA = "0x31F8C78", Offset = "0x31F8C78", VA = "0x31F8C78")]
		[DebuggerNonUserCode]
		public ServiceDescriptorProto()
		{
		}

		// Token: 0x0600714F RID: 29007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600714F")]
		[Address(RVA = "0x31F8D00", Offset = "0x31F8D00", VA = "0x31F8D00")]
		[DebuggerNonUserCode]
		public ServiceDescriptorProto(ServiceDescriptorProto other)
		{
		}

		// Token: 0x06007150 RID: 29008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007150")]
		[Address(RVA = "0x31F8DD4", Offset = "0x31F8DD4", VA = "0x31F8DD4", Slot = "10")]
		[DebuggerNonUserCode]
		public ServiceDescriptorProto Clone()
		{
			return null;
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06007151 RID: 29009 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007152 RID: 29010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000900")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Token(Token = "0x6007151")]
			[Address(RVA = "0x31F8E34", Offset = "0x31F8E34", VA = "0x31F8E34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007152")]
			[Address(RVA = "0x31F8E98", Offset = "0x31F8E98", VA = "0x31F8E98")]
			set
			{
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06007153 RID: 29011 RVA: 0x00050490 File Offset: 0x0004E690
		[Token(Token = "0x17000901")]
		[DebuggerNonUserCode]
		public bool HasName
		{
			[Token(Token = "0x6007153")]
			[Address(RVA = "0x31F8F14", Offset = "0x31F8F14", VA = "0x31F8F14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007154 RID: 29012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007154")]
		[Address(RVA = "0x31F8F24", Offset = "0x31F8F24", VA = "0x31F8F24")]
		[DebuggerNonUserCode]
		public void ClearName()
		{
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06007155 RID: 29013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000902")]
		[DebuggerNonUserCode]
		public RepeatedField<MethodDescriptorProto> Method
		{
			[Token(Token = "0x6007155")]
			[Address(RVA = "0x31F8F30", Offset = "0x31F8F30", VA = "0x31F8F30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06007156 RID: 29014 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007157 RID: 29015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000903")]
		[DebuggerNonUserCode]
		public ServiceOptions Options
		{
			[Token(Token = "0x6007156")]
			[Address(RVA = "0x31F8F38", Offset = "0x31F8F38", VA = "0x31F8F38")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007157")]
			[Address(RVA = "0x31F8F40", Offset = "0x31F8F40", VA = "0x31F8F40")]
			set
			{
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06007158 RID: 29016 RVA: 0x000504A8 File Offset: 0x0004E6A8
		[Token(Token = "0x17000904")]
		[DebuggerNonUserCode]
		public bool HasOptions
		{
			[Token(Token = "0x6007158")]
			[Address(RVA = "0x31F8DC4", Offset = "0x31F8DC4", VA = "0x31F8DC4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007159 RID: 29017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007159")]
		[Address(RVA = "0x31F8F48", Offset = "0x31F8F48", VA = "0x31F8F48")]
		[DebuggerNonUserCode]
		public void ClearOptions()
		{
		}

		// Token: 0x0600715A RID: 29018 RVA: 0x000504C0 File Offset: 0x0004E6C0
		[Token(Token = "0x600715A")]
		[Address(RVA = "0x31F8F54", Offset = "0x31F8F54", VA = "0x31F8F54", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x0600715B RID: 29019 RVA: 0x000504D8 File Offset: 0x0004E6D8
		[Token(Token = "0x600715B")]
		[Address(RVA = "0x31F8FB8", Offset = "0x31F8FB8", VA = "0x31F8FB8", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ServiceDescriptorProto other)
		{
			return default(bool);
		}

		// Token: 0x0600715C RID: 29020 RVA: 0x000504F0 File Offset: 0x0004E6F0
		[Token(Token = "0x600715C")]
		[Address(RVA = "0x31F9084", Offset = "0x31F9084", VA = "0x31F9084", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600715D RID: 29021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600715D")]
		[Address(RVA = "0x31F911C", Offset = "0x31F911C", VA = "0x31F911C", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600715E RID: 29022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600715E")]
		[Address(RVA = "0x31F9174", Offset = "0x31F9174", VA = "0x31F9174", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600715F RID: 29023 RVA: 0x00050508 File Offset: 0x0004E708
		[Token(Token = "0x600715F")]
		[Address(RVA = "0x31F928C", Offset = "0x31F928C", VA = "0x31F928C", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007160 RID: 29024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007160")]
		[Address(RVA = "0x31F93B8", Offset = "0x31F93B8", VA = "0x31F93B8", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ServiceDescriptorProto other)
		{
		}

		// Token: 0x06007161 RID: 29025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007161")]
		[Address(RVA = "0x31F94CC", Offset = "0x31F94CC", VA = "0x31F94CC", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x04002DDD RID: 11741
		[Token(Token = "0x4002DDD")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<ServiceDescriptorProto> _parser;

		// Token: 0x04002DDE RID: 11742
		[Token(Token = "0x4002DDE")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DDF RID: 11743
		[Token(Token = "0x4002DDF")]
		public const int NameFieldNumber = 1;

		// Token: 0x04002DE0 RID: 11744
		[Token(Token = "0x4002DE0")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string NameDefaultValue;

		// Token: 0x04002DE1 RID: 11745
		[Token(Token = "0x4002DE1")]
		[FieldOffset(Offset = "0x18")]
		private string name_;

		// Token: 0x04002DE2 RID: 11746
		[Token(Token = "0x4002DE2")]
		public const int MethodFieldNumber = 2;

		// Token: 0x04002DE3 RID: 11747
		[Token(Token = "0x4002DE3")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FieldCodec<MethodDescriptorProto> _repeated_method_codec;

		// Token: 0x04002DE4 RID: 11748
		[Token(Token = "0x4002DE4")]
		[FieldOffset(Offset = "0x20")]
		private readonly RepeatedField<MethodDescriptorProto> method_;

		// Token: 0x04002DE5 RID: 11749
		[Token(Token = "0x4002DE5")]
		public const int OptionsFieldNumber = 3;

		// Token: 0x04002DE6 RID: 11750
		[Token(Token = "0x4002DE6")]
		[FieldOffset(Offset = "0x28")]
		private ServiceOptions options_;
	}
}
