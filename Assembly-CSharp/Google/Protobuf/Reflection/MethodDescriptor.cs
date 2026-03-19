using System;
using Google.Protobuf.Collections;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000BDC RID: 3036
	[Token(Token = "0x2000BDC")]
	public sealed class MethodDescriptor : DescriptorBase
	{
		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06007482 RID: 29826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A10")]
		public ServiceDescriptor Service
		{
			[Token(Token = "0x6007482")]
			[Address(RVA = "0x31B4B04", Offset = "0x31B4B04", VA = "0x31B4B04")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06007483 RID: 29827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A11")]
		public MessageDescriptor InputType
		{
			[Token(Token = "0x6007483")]
			[Address(RVA = "0x31B4B0C", Offset = "0x31B4B0C", VA = "0x31B4B0C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06007484 RID: 29828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A12")]
		public MessageDescriptor OutputType
		{
			[Token(Token = "0x6007484")]
			[Address(RVA = "0x31B4B14", Offset = "0x31B4B14", VA = "0x31B4B14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06007485 RID: 29829 RVA: 0x00051648 File Offset: 0x0004F848
		[Token(Token = "0x17000A13")]
		public bool IsClientStreaming
		{
			[Token(Token = "0x6007485")]
			[Address(RVA = "0x31B4B1C", Offset = "0x31B4B1C", VA = "0x31B4B1C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06007486 RID: 29830 RVA: 0x00051660 File Offset: 0x0004F860
		[Token(Token = "0x17000A14")]
		public bool IsServerStreaming
		{
			[Token(Token = "0x6007486")]
			[Address(RVA = "0x31B4B38", Offset = "0x31B4B38", VA = "0x31B4B38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06007487 RID: 29831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A15")]
		[Obsolete("CustomOptions are obsolete. Use GetOption")]
		public CustomOptions CustomOptions
		{
			[Token(Token = "0x6007487")]
			[Address(RVA = "0x31B4B54", Offset = "0x31B4B54", VA = "0x31B4B54")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007488 RID: 29832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007488")]
		public T GetOption<T>(Extension<MethodOptions, T> extension)
		{
			return null;
		}

		// Token: 0x06007489 RID: 29833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007489")]
		public RepeatedField<T> GetOption<T>(RepeatedExtension<MethodOptions, T> extension)
		{
			return null;
		}

		// Token: 0x0600748A RID: 29834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600748A")]
		[Address(RVA = "0x31B4BE8", Offset = "0x31B4BE8", VA = "0x31B4BE8")]
		internal MethodDescriptor(MethodDescriptorProto proto, FileDescriptor file, ServiceDescriptor parent, int index)
		{
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x0600748B RID: 29835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A16")]
		internal MethodDescriptorProto Proto
		{
			[Token(Token = "0x600748B")]
			[Address(RVA = "0x31B4CBC", Offset = "0x31B4CBC", VA = "0x31B4CBC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x0600748C RID: 29836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A17")]
		public override string Name
		{
			[Token(Token = "0x600748C")]
			[Address(RVA = "0x31B4CC4", Offset = "0x31B4CC4", VA = "0x31B4CC4", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600748D RID: 29837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600748D")]
		[Address(RVA = "0x31B4CE0", Offset = "0x31B4CE0", VA = "0x31B4CE0")]
		internal void CrossLink()
		{
		}

		// Token: 0x04002F89 RID: 12169
		[Token(Token = "0x4002F89")]
		[FieldOffset(Offset = "0x28")]
		private readonly MethodDescriptorProto proto;

		// Token: 0x04002F8A RID: 12170
		[Token(Token = "0x4002F8A")]
		[FieldOffset(Offset = "0x30")]
		private readonly ServiceDescriptor service;

		// Token: 0x04002F8B RID: 12171
		[Token(Token = "0x4002F8B")]
		[FieldOffset(Offset = "0x38")]
		private MessageDescriptor inputType;

		// Token: 0x04002F8C RID: 12172
		[Token(Token = "0x4002F8C")]
		[FieldOffset(Offset = "0x40")]
		private MessageDescriptor outputType;
	}
}
