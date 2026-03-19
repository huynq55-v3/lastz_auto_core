using System;
using Google.Protobuf.Collections;
using Il2CppDummyDll;

namespace Google.Protobuf
{
	// Token: 0x02000B11 RID: 2833
	[Token(Token = "0x2000B11")]
	public interface IExtendableMessage<T> : IMessage<T>, IMessage, IEquatable<T>, IDeepCloneable<T> where T : IExtendableMessage<T>
	{
		// Token: 0x06006C1F RID: 27679
		[Token(Token = "0x6006C1F")]
		TValue GetExtension<TValue>(Extension<T, TValue> extension);

		// Token: 0x06006C20 RID: 27680
		[Token(Token = "0x6006C20")]
		RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<T, TValue> extension);

		// Token: 0x06006C21 RID: 27681
		[Token(Token = "0x6006C21")]
		RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<T, TValue> extension);

		// Token: 0x06006C22 RID: 27682
		[Token(Token = "0x6006C22")]
		void SetExtension<TValue>(Extension<T, TValue> extension, TValue value);

		// Token: 0x06006C23 RID: 27683
		[Token(Token = "0x6006C23")]
		bool HasExtension<TValue>(Extension<T, TValue> extension);

		// Token: 0x06006C24 RID: 27684
		[Token(Token = "0x6006C24")]
		void ClearExtension<TValue>(Extension<T, TValue> extension);

		// Token: 0x06006C25 RID: 27685
		[Token(Token = "0x6006C25")]
		void ClearExtension<TValue>(RepeatedExtension<T, TValue> extension);
	}
}
