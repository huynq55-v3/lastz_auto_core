using System;
using Il2CppDummyDll;

// Token: 0x02000149 RID: 329
[Token(Token = "0x2000149")]
public class AesEncryptor
{
	// Token: 0x060009AE RID: 2478 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009AE")]
	[Address(RVA = "0x33B5220", Offset = "0x33B5220", VA = "0x33B5220")]
	public AesEncryptor(byte[] key)
	{
	}

	// Token: 0x060009AF RID: 2479 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009AF")]
	[Address(RVA = "0x33B52A0", Offset = "0x33B52A0", VA = "0x33B52A0")]
	public AesEncryptor(string AESkey)
	{
	}

	// Token: 0x060009B0 RID: 2480 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009B0")]
	[Address(RVA = "0x33B53E4", Offset = "0x33B53E4", VA = "0x33B53E4")]
	public void Dispose()
	{
	}

	// Token: 0x060009B1 RID: 2481 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009B1")]
	[Address(RVA = "0x33B53F0", Offset = "0x33B53F0", VA = "0x33B53F0")]
	public string EncryptString(string strInfor)
	{
		return null;
	}

	// Token: 0x060009B2 RID: 2482 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009B2")]
	[Address(RVA = "0x33B5508", Offset = "0x33B5508", VA = "0x33B5508")]
	public string DecryptString(string strMessage)
	{
		return null;
	}

	// Token: 0x060009B3 RID: 2483 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009B3")]
	[Address(RVA = "0x33B56D4", Offset = "0x33B56D4", VA = "0x33B56D4")]
	public void Byte2Hex(byte[] src, int len, ref string dest)
	{
	}

	// Token: 0x060009B4 RID: 2484 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009B4")]
	[Address(RVA = "0x33B55C0", Offset = "0x33B55C0", VA = "0x33B55C0")]
	public void Hex2Byte(string src, int len, ref byte[] dest)
	{
	}

	// Token: 0x060009B5 RID: 2485 RVA: 0x00005028 File Offset: 0x00003228
	[Token(Token = "0x60009B5")]
	[Address(RVA = "0x33B57F4", Offset = "0x33B57F4", VA = "0x33B57F4")]
	public int Char2Int(char c)
	{
		return 0;
	}

	// Token: 0x04000736 RID: 1846
	[Token(Token = "0x4000736")]
	[FieldOffset(Offset = "0x10")]
	private AES m_pEncryptor;
}
