using System;
using System.Reflection;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000BF3 RID: 3059
	[Token(Token = "0x2000BF3")]
	internal sealed class SingleFieldAccessor : FieldAccessorBase
	{
		// Token: 0x060074E7 RID: 29927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074E7")]
		[Address(RVA = "0x31AE3BC", Offset = "0x31AE3BC", VA = "0x31AE3BC")]
		internal SingleFieldAccessor(PropertyInfo property, FieldDescriptor descriptor)
		{
		}

		// Token: 0x060074E8 RID: 29928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074E8")]
		[Address(RVA = "0x31B6200", Offset = "0x31B6200", VA = "0x31B6200", Slot = "10")]
		public override void Clear(IMessage message)
		{
		}

		// Token: 0x060074E9 RID: 29929 RVA: 0x00051768 File Offset: 0x0004F968
		[Token(Token = "0x60074E9")]
		[Address(RVA = "0x31B6224", Offset = "0x31B6224", VA = "0x31B6224", Slot = "9")]
		public override bool HasValue(IMessage message)
		{
			return default(bool);
		}

		// Token: 0x060074EA RID: 29930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074EA")]
		[Address(RVA = "0x31B6248", Offset = "0x31B6248", VA = "0x31B6248", Slot = "11")]
		public override void SetValue(IMessage message, object value)
		{
		}

		// Token: 0x04002FAA RID: 12202
		[Token(Token = "0x4002FAA")]
		[FieldOffset(Offset = "0x20")]
		private readonly Action<IMessage, object> setValueDelegate;

		// Token: 0x04002FAB RID: 12203
		[Token(Token = "0x4002FAB")]
		[FieldOffset(Offset = "0x28")]
		private readonly Action<IMessage> clearDelegate;

		// Token: 0x04002FAC RID: 12204
		[Token(Token = "0x4002FAC")]
		[FieldOffset(Offset = "0x30")]
		private readonly Func<IMessage, bool> hasDelegate;
	}
}
