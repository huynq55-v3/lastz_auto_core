using System;
using Il2CppDummyDll;

namespace EPOOutline
{
	// Token: 0x02000CA7 RID: 3239
	[Token(Token = "0x2000CA7")]
	public class SerializedPassInfoAttribute : Attribute
	{
		// Token: 0x06007AB0 RID: 31408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AB0")]
		[Address(RVA = "0x321B584", Offset = "0x321B584", VA = "0x321B584")]
		public SerializedPassInfoAttribute(string title, string shadersFolder)
		{
		}

		// Token: 0x040035F7 RID: 13815
		[Token(Token = "0x40035F7")]
		[FieldOffset(Offset = "0x10")]
		public readonly string Title;

		// Token: 0x040035F8 RID: 13816
		[Token(Token = "0x40035F8")]
		[FieldOffset(Offset = "0x18")]
		public readonly string ShadersFolder;
	}
}
