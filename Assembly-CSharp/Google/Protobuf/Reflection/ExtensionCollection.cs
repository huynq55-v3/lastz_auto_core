using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000BC9 RID: 3017
	[Token(Token = "0x2000BC9")]
	public sealed class ExtensionCollection
	{
		// Token: 0x060073E1 RID: 29665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073E1")]
		[Address(RVA = "0x31AC42C", Offset = "0x31AC42C", VA = "0x31AC42C")]
		internal ExtensionCollection(FileDescriptor file, Extension[] extensions)
		{
		}

		// Token: 0x060073E2 RID: 29666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073E2")]
		[Address(RVA = "0x31AC55C", Offset = "0x31AC55C", VA = "0x31AC55C")]
		internal ExtensionCollection(MessageDescriptor message, Extension[] extensions)
		{
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x060073E3 RID: 29667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D2")]
		public IList<FieldDescriptor> UnorderedExtensions
		{
			[Token(Token = "0x60073E3")]
			[Address(RVA = "0x31AC68C", Offset = "0x31AC68C", VA = "0x31AC68C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060073E4 RID: 29668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073E4")]
		[Address(RVA = "0x31AC694", Offset = "0x31AC694", VA = "0x31AC694")]
		public IList<FieldDescriptor> GetExtensionsInDeclarationOrder(MessageDescriptor descriptor)
		{
			return null;
		}

		// Token: 0x060073E5 RID: 29669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073E5")]
		[Address(RVA = "0x31AC73C", Offset = "0x31AC73C", VA = "0x31AC73C")]
		public IList<FieldDescriptor> GetExtensionsInNumberOrder(MessageDescriptor descriptor)
		{
			return null;
		}

		// Token: 0x060073E6 RID: 29670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073E6")]
		[Address(RVA = "0x31AC7E4", Offset = "0x31AC7E4", VA = "0x31AC7E4")]
		internal void CrossLink()
		{
		}

		// Token: 0x04002F26 RID: 12070
		[Token(Token = "0x4002F26")]
		[FieldOffset(Offset = "0x10")]
		private IDictionary<MessageDescriptor, IList<FieldDescriptor>> extensionsByTypeInDeclarationOrder;

		// Token: 0x04002F27 RID: 12071
		[Token(Token = "0x4002F27")]
		[FieldOffset(Offset = "0x18")]
		private IDictionary<MessageDescriptor, IList<FieldDescriptor>> extensionsByTypeInNumberOrder;
	}
}
