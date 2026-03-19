using System;
using Il2CppDummyDll;

namespace Google.Protobuf
{
	// Token: 0x02000AF6 RID: 2806
	[Token(Token = "0x2000AF6")]
	internal interface IExtensionValue : IEquatable<IExtensionValue>, IDeepCloneable<IExtensionValue>
	{
		// Token: 0x06006B64 RID: 27492
		[Token(Token = "0x6006B64")]
		void MergeFrom(CodedInputStream input);

		// Token: 0x06006B65 RID: 27493
		[Token(Token = "0x6006B65")]
		void MergeFrom(IExtensionValue value);

		// Token: 0x06006B66 RID: 27494
		[Token(Token = "0x6006B66")]
		void WriteTo(CodedOutputStream output);

		// Token: 0x06006B67 RID: 27495
		[Token(Token = "0x6006B67")]
		int CalculateSize();

		// Token: 0x06006B68 RID: 27496
		[Token(Token = "0x6006B68")]
		bool IsInitialized();
	}
}
