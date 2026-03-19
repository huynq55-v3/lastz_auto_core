using System;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x02000555 RID: 1365
	[Token(Token = "0x2000555")]
	public class SignatureLoader
	{
		// Token: 0x060028C8 RID: 10440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C8")]
		[Address(RVA = "0x26BF618", Offset = "0x26BF618", VA = "0x26BF618")]
		public SignatureLoader(string publicKey, LuaEnv.CustomLoader loader)
		{
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x0000F540 File Offset: 0x0000D740
		[Token(Token = "0x60028C9")]
		[Address(RVA = "0x26BF73C", Offset = "0x26BF73C", VA = "0x26BF73C")]
		private LuaEnv.LuaFileInfo load_and_verify(ref string filepath)
		{
			return default(LuaEnv.LuaFileInfo);
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028CA")]
		[Address(RVA = "0x26BF900", Offset = "0x26BF900", VA = "0x26BF900")]
		public static implicit operator LuaEnv.CustomLoader(SignatureLoader signatureLoader)
		{
			return null;
		}

		// Token: 0x0400242F RID: 9263
		[Token(Token = "0x400242F")]
		[FieldOffset(Offset = "0x10")]
		private LuaEnv.CustomLoader userLoader;

		// Token: 0x04002430 RID: 9264
		[Token(Token = "0x4002430")]
		[FieldOffset(Offset = "0x18")]
		private RSACryptoServiceProvider rsa;

		// Token: 0x04002431 RID: 9265
		[Token(Token = "0x4002431")]
		[FieldOffset(Offset = "0x20")]
		private SHA1 sha;
	}
}
