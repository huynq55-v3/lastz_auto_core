using System;
using Il2CppDummyDll;

// Token: 0x0200014A RID: 330
[Token(Token = "0x200014A")]
public static class CryptoUtils
{
	// Token: 0x060009B7 RID: 2487 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009B7")]
	[Address(RVA = "0x33B59B8", Offset = "0x33B59B8", VA = "0x33B59B8")]
	public static string EncryptAES(string plainText)
	{
		return null;
	}

	// Token: 0x060009B8 RID: 2488 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009B8")]
	[Address(RVA = "0x33B60F0", Offset = "0x33B60F0", VA = "0x33B60F0")]
	public static string DecryptAES(string cipherTextBase64)
	{
		return null;
	}

	// Token: 0x04000737 RID: 1847
	[Token(Token = "0x4000737")]
	[FieldOffset(Offset = "0x0")]
	private static readonly byte[] SECRET_KEY_BYTES;

	// Token: 0x04000738 RID: 1848
	[Token(Token = "0x4000738")]
	[FieldOffset(Offset = "0x8")]
	private static readonly byte[] IV_BYTES;
}
