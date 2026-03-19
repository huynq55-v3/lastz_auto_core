using System;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000BD5 RID: 3029
	[Token(Token = "0x2000BD5")]
	public interface IDescriptor
	{
		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06007450 RID: 29776
		[Token(Token = "0x170009FD")]
		string Name
		{
			[Token(Token = "0x6007450")]
			get;
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06007451 RID: 29777
		[Token(Token = "0x170009FE")]
		string FullName
		{
			[Token(Token = "0x6007451")]
			get;
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06007452 RID: 29778
		[Token(Token = "0x170009FF")]
		FileDescriptor File
		{
			[Token(Token = "0x6007452")]
			get;
		}
	}
}
