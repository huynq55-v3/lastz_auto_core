using System;
using System.Reflection;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000BCD RID: 3021
	[Token(Token = "0x2000BCD")]
	internal abstract class FieldAccessorBase : IFieldAccessor
	{
		// Token: 0x060073F2 RID: 29682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073F2")]
		[Address(RVA = "0x31ADC40", Offset = "0x31ADC40", VA = "0x31ADC40")]
		internal FieldAccessorBase(PropertyInfo property, FieldDescriptor descriptor)
		{
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x060073F3 RID: 29683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D3")]
		public FieldDescriptor Descriptor
		{
			[Token(Token = "0x60073F3")]
			[Address(RVA = "0x31ADDFC", Offset = "0x31ADDFC", VA = "0x31ADDFC", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060073F4 RID: 29684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073F4")]
		[Address(RVA = "0x31ADE04", Offset = "0x31ADE04", VA = "0x31ADE04", Slot = "6")]
		public object GetValue(IMessage message)
		{
			return null;
		}

		// Token: 0x060073F5 RID: 29685
		[Token(Token = "0x60073F5")]
		public abstract bool HasValue(IMessage message);

		// Token: 0x060073F6 RID: 29686
		[Token(Token = "0x60073F6")]
		public abstract void Clear(IMessage message);

		// Token: 0x060073F7 RID: 29687
		[Token(Token = "0x60073F7")]
		public abstract void SetValue(IMessage message, object value);

		// Token: 0x04002F33 RID: 12083
		[Token(Token = "0x4002F33")]
		[FieldOffset(Offset = "0x10")]
		private readonly Func<IMessage, object> getValueDelegate;

		// Token: 0x04002F34 RID: 12084
		[Token(Token = "0x4002F34")]
		[FieldOffset(Offset = "0x18")]
		private readonly FieldDescriptor descriptor;
	}
}
