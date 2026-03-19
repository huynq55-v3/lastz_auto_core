using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000BF1 RID: 3057
	[Token(Token = "0x2000BF1")]
	public sealed class ServiceDescriptor : DescriptorBase
	{
		// Token: 0x060074DB RID: 29915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074DB")]
		[Address(RVA = "0x31B2E68", Offset = "0x31B2E68", VA = "0x31B2E68")]
		internal ServiceDescriptor(ServiceDescriptorProto proto, FileDescriptor file, int index)
		{
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x060074DC RID: 29916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A24")]
		public override string Name
		{
			[Token(Token = "0x60074DC")]
			[Address(RVA = "0x31B5FB4", Offset = "0x31B5FB4", VA = "0x31B5FB4", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x060074DD RID: 29917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074DD")]
		[Address(RVA = "0x31B5FD0", Offset = "0x31B5FD0", VA = "0x31B5FD0", Slot = "8")]
		internal override IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber)
		{
			return null;
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x060074DE RID: 29918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A25")]
		internal ServiceDescriptorProto Proto
		{
			[Token(Token = "0x60074DE")]
			[Address(RVA = "0x31B6048", Offset = "0x31B6048", VA = "0x31B6048")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x060074DF RID: 29919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A26")]
		public IList<MethodDescriptor> Methods
		{
			[Token(Token = "0x60074DF")]
			[Address(RVA = "0x31B6050", Offset = "0x31B6050", VA = "0x31B6050")]
			get
			{
				return null;
			}
		}

		// Token: 0x060074E0 RID: 29920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074E0")]
		[Address(RVA = "0x31B6058", Offset = "0x31B6058", VA = "0x31B6058")]
		public MethodDescriptor FindMethodByName(string name)
		{
			return null;
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x060074E1 RID: 29921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A27")]
		[Obsolete("CustomOptions are obsolete. Use GetOption")]
		public CustomOptions CustomOptions
		{
			[Token(Token = "0x60074E1")]
			[Address(RVA = "0x31B60E4", Offset = "0x31B60E4", VA = "0x31B60E4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060074E2 RID: 29922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074E2")]
		public T GetOption<T>(Extension<ServiceOptions, T> extension)
		{
			return null;
		}

		// Token: 0x060074E3 RID: 29923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074E3")]
		public RepeatedField<T> GetOption<T>(RepeatedExtension<ServiceOptions, T> extension)
		{
			return null;
		}

		// Token: 0x060074E4 RID: 29924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074E4")]
		[Address(RVA = "0x31B0AEC", Offset = "0x31B0AEC", VA = "0x31B0AEC")]
		internal void CrossLink()
		{
		}

		// Token: 0x04002FA6 RID: 12198
		[Token(Token = "0x4002FA6")]
		[FieldOffset(Offset = "0x28")]
		private readonly ServiceDescriptorProto proto;

		// Token: 0x04002FA7 RID: 12199
		[Token(Token = "0x4002FA7")]
		[FieldOffset(Offset = "0x30")]
		private readonly IList<MethodDescriptor> methods;
	}
}
