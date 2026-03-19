using System;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000BD6 RID: 3030
	[Token(Token = "0x2000BD6")]
	public interface IFieldAccessor
	{
		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06007453 RID: 29779
		[Token(Token = "0x17000A00")]
		FieldDescriptor Descriptor
		{
			[Token(Token = "0x6007453")]
			get;
		}

		// Token: 0x06007454 RID: 29780
		[Token(Token = "0x6007454")]
		void Clear(IMessage message);

		// Token: 0x06007455 RID: 29781
		[Token(Token = "0x6007455")]
		object GetValue(IMessage message);

		// Token: 0x06007456 RID: 29782
		[Token(Token = "0x6007456")]
		bool HasValue(IMessage message);

		// Token: 0x06007457 RID: 29783
		[Token(Token = "0x6007457")]
		void SetValue(IMessage message, object value);
	}
}
