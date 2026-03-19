using System;
using Il2CppDummyDll;

namespace Google.Protobuf
{
	// Token: 0x02000B13 RID: 2835
	[Token(Token = "0x2000B13")]
	public interface IMessage<T> : IMessage, IEquatable<T>, IDeepCloneable<T> where T : IMessage<T>
	{
		// Token: 0x06006C2A RID: 27690
		[Token(Token = "0x6006C2A")]
		void MergeFrom(T message);
	}
}
