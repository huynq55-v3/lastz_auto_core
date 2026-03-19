using System;
using Il2CppDummyDll;

namespace Sfs2X.Requests
{
	// Token: 0x02000A55 RID: 2645
	[Token(Token = "0x2000A55")]
	public class HandshakeRequest : BaseRequest
	{
		// Token: 0x06006459 RID: 25689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006459")]
		[Address(RVA = "0x2DF8360", Offset = "0x2DF8360", VA = "0x2DF8360")]
		public HandshakeRequest(string apiVersion, string reconnectionToken, string clientDetails)
		{
		}

		// Token: 0x04002870 RID: 10352
		[Token(Token = "0x4002870")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string KEY_SESSION_TOKEN;

		// Token: 0x04002871 RID: 10353
		[Token(Token = "0x4002871")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string KEY_API;

		// Token: 0x04002872 RID: 10354
		[Token(Token = "0x4002872")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string KEY_COMPRESSION_THRESHOLD;

		// Token: 0x04002873 RID: 10355
		[Token(Token = "0x4002873")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string KEY_RECONNECTION_TOKEN;

		// Token: 0x04002874 RID: 10356
		[Token(Token = "0x4002874")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string KEY_CLIENT_TYPE;

		// Token: 0x04002875 RID: 10357
		[Token(Token = "0x4002875")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string KEY_MAX_MESSAGE_SIZE;
	}
}
