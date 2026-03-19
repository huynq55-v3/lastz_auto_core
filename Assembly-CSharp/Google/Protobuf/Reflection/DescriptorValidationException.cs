using System;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000BC4 RID: 3012
	[Token(Token = "0x2000BC4")]
	public sealed class DescriptorValidationException : Exception
	{
		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x060073C1 RID: 29633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009C4")]
		public string ProblemSymbolName
		{
			[Token(Token = "0x60073C1")]
			[Address(RVA = "0x31AB5F8", Offset = "0x31AB5F8", VA = "0x31AB5F8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x060073C2 RID: 29634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009C5")]
		public string Description
		{
			[Token(Token = "0x60073C2")]
			[Address(RVA = "0x31AB600", Offset = "0x31AB600", VA = "0x31AB600")]
			get
			{
				return null;
			}
		}

		// Token: 0x060073C3 RID: 29635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073C3")]
		[Address(RVA = "0x31A9F08", Offset = "0x31A9F08", VA = "0x31A9F08")]
		internal DescriptorValidationException(IDescriptor problemDescriptor, string description)
		{
		}

		// Token: 0x060073C4 RID: 29636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073C4")]
		[Address(RVA = "0x31AB608", Offset = "0x31AB608", VA = "0x31AB608")]
		internal DescriptorValidationException(IDescriptor problemDescriptor, string description, Exception cause)
		{
		}

		// Token: 0x04002F19 RID: 12057
		[Token(Token = "0x4002F19")]
		[FieldOffset(Offset = "0x90")]
		private readonly string name;

		// Token: 0x04002F1A RID: 12058
		[Token(Token = "0x4002F1A")]
		[FieldOffset(Offset = "0x98")]
		private readonly string description;
	}
}
