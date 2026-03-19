using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000BC8 RID: 3016
	[Token(Token = "0x2000BC8")]
	internal sealed class ExtensionAccessor : IFieldAccessor
	{
		// Token: 0x060073DB RID: 29659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073DB")]
		[Address(RVA = "0x31ABE94", Offset = "0x31ABE94", VA = "0x31ABE94")]
		internal ExtensionAccessor(FieldDescriptor descriptor)
		{
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x060073DC RID: 29660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D1")]
		public FieldDescriptor Descriptor
		{
			[Token(Token = "0x60073DC")]
			[Address(RVA = "0x31AC168", Offset = "0x31AC168", VA = "0x31AC168", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060073DD RID: 29661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073DD")]
		[Address(RVA = "0x31AC170", Offset = "0x31AC170", VA = "0x31AC170", Slot = "5")]
		public void Clear(IMessage message)
		{
		}

		// Token: 0x060073DE RID: 29662 RVA: 0x00051468 File Offset: 0x0004F668
		[Token(Token = "0x60073DE")]
		[Address(RVA = "0x31AC21C", Offset = "0x31AC21C", VA = "0x31AC21C", Slot = "7")]
		public bool HasValue(IMessage message)
		{
			return default(bool);
		}

		// Token: 0x060073DF RID: 29663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073DF")]
		[Address(RVA = "0x31AC2C8", Offset = "0x31AC2C8", VA = "0x31AC2C8", Slot = "6")]
		public object GetValue(IMessage message)
		{
			return null;
		}

		// Token: 0x060073E0 RID: 29664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073E0")]
		[Address(RVA = "0x31AC370", Offset = "0x31AC370", VA = "0x31AC370", Slot = "8")]
		public void SetValue(IMessage message, object value)
		{
		}

		// Token: 0x04002F23 RID: 12067
		[Token(Token = "0x4002F23")]
		[FieldOffset(Offset = "0x10")]
		private readonly Extension extension;

		// Token: 0x04002F24 RID: 12068
		[Token(Token = "0x4002F24")]
		[FieldOffset(Offset = "0x18")]
		private readonly ReflectionUtil.IExtensionReflectionHelper helper;
	}
}
