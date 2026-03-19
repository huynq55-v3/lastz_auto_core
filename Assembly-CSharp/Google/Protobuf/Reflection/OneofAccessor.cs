using System;
using System.Reflection;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000BDD RID: 3037
	[Token(Token = "0x2000BDD")]
	public sealed class OneofAccessor
	{
		// Token: 0x0600748E RID: 29838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600748E")]
		[Address(RVA = "0x31B4E9C", Offset = "0x31B4E9C", VA = "0x31B4E9C")]
		internal OneofAccessor(PropertyInfo caseProperty, MethodInfo clearMethod, OneofDescriptor descriptor)
		{
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x0600748F RID: 29839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A18")]
		public OneofDescriptor Descriptor
		{
			[Token(Token = "0x600748F")]
			[Address(RVA = "0x31B5240", Offset = "0x31B5240", VA = "0x31B5240")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007490 RID: 29840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007490")]
		[Address(RVA = "0x31B5248", Offset = "0x31B5248", VA = "0x31B5248")]
		public void Clear(IMessage message)
		{
		}

		// Token: 0x06007491 RID: 29841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007491")]
		[Address(RVA = "0x31B526C", Offset = "0x31B526C", VA = "0x31B526C")]
		public FieldDescriptor GetCaseFieldDescriptor(IMessage message)
		{
			return null;
		}

		// Token: 0x04002F8D RID: 12173
		[Token(Token = "0x4002F8D")]
		[FieldOffset(Offset = "0x10")]
		private readonly Func<IMessage, int> caseDelegate;

		// Token: 0x04002F8E RID: 12174
		[Token(Token = "0x4002F8E")]
		[FieldOffset(Offset = "0x18")]
		private readonly Action<IMessage> clearDelegate;

		// Token: 0x04002F8F RID: 12175
		[Token(Token = "0x4002F8F")]
		[FieldOffset(Offset = "0x20")]
		private OneofDescriptor descriptor;
	}
}
