using System;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Google.Protobuf
{
	// Token: 0x02000B12 RID: 2834
	[Token(Token = "0x2000B12")]
	public interface IMessage
	{
		// Token: 0x06006C26 RID: 27686
		[Token(Token = "0x6006C26")]
		void MergeFrom(CodedInputStream input);

		// Token: 0x06006C27 RID: 27687
		[Token(Token = "0x6006C27")]
		void WriteTo(CodedOutputStream output);

		// Token: 0x06006C28 RID: 27688
		[Token(Token = "0x6006C28")]
		int CalculateSize();

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06006C29 RID: 27689
		[Token(Token = "0x170007CA")]
		MessageDescriptor Descriptor
		{
			[Token(Token = "0x6006C29")]
			get;
		}
	}
}
