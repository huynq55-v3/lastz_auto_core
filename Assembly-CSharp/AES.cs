using System;
using Il2CppDummyDll;

// Token: 0x02000148 RID: 328
[Token(Token = "0x2000148")]
public class AES
{
	// Token: 0x060009A1 RID: 2465 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A1")]
	[Address(RVA = "0x33B40B8", Offset = "0x33B40B8", VA = "0x33B40B8")]
	public AES(byte[] key)
	{
	}

	// Token: 0x060009A2 RID: 2466 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009A2")]
	[Address(RVA = "0x33B4508", Offset = "0x33B4508", VA = "0x33B4508")]
	public byte[,] toBit(int index)
	{
		return null;
	}

	// Token: 0x060009A3 RID: 2467 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A3")]
	[Address(RVA = "0x33B4614", Offset = "0x33B4614", VA = "0x33B4614")]
	public void Cipher(ref byte[] input)
	{
	}

	// Token: 0x060009A4 RID: 2468 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A4")]
	[Address(RVA = "0x33B4BE8", Offset = "0x33B4BE8", VA = "0x33B4BE8")]
	public void InvCipher(ref byte[] input)
	{
	}

	// Token: 0x060009A5 RID: 2469 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A5")]
	[Address(RVA = "0x33B41F4", Offset = "0x33B41F4", VA = "0x33B41F4")]
	public void KeyExpansion(byte[] key)
	{
	}

	// Token: 0x060009A6 RID: 2470 RVA: 0x00005010 File Offset: 0x00003210
	[Token(Token = "0x60009A6")]
	[Address(RVA = "0x33B5128", Offset = "0x33B5128", VA = "0x33B5128")]
	public byte FFmul(byte a, byte b)
	{
		return 0;
	}

	// Token: 0x060009A7 RID: 2471 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A7")]
	[Address(RVA = "0x33B487C", Offset = "0x33B487C", VA = "0x33B487C")]
	public void SubBytes(ref byte[,] state)
	{
	}

	// Token: 0x060009A8 RID: 2472 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A8")]
	[Address(RVA = "0x33B4900", Offset = "0x33B4900", VA = "0x33B4900")]
	public void ShiftRows(ref byte[,] state)
	{
	}

	// Token: 0x060009A9 RID: 2473 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A9")]
	[Address(RVA = "0x33B4A20", Offset = "0x33B4A20", VA = "0x33B4A20")]
	public void MixColumns(ref byte[,] state)
	{
	}

	// Token: 0x060009AA RID: 2474 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009AA")]
	[Address(RVA = "0x33B47E4", Offset = "0x33B47E4", VA = "0x33B47E4")]
	public void AddRoundKey(ref byte[,] state, byte[,] k)
	{
	}

	// Token: 0x060009AB RID: 2475 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009AB")]
	[Address(RVA = "0x33B4EDC", Offset = "0x33B4EDC", VA = "0x33B4EDC")]
	public void InvSubBytes(ref byte[,] state)
	{
	}

	// Token: 0x060009AC RID: 2476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009AC")]
	[Address(RVA = "0x33B4DB4", Offset = "0x33B4DB4", VA = "0x33B4DB4")]
	public void InvShiftRows(ref byte[,] state)
	{
	}

	// Token: 0x060009AD RID: 2477 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009AD")]
	[Address(RVA = "0x33B4F60", Offset = "0x33B4F60", VA = "0x33B4F60")]
	public void InvMixColumns(ref byte[,] state)
	{
	}

	// Token: 0x04000733 RID: 1843
	[Token(Token = "0x4000733")]
	[FieldOffset(Offset = "0x10")]
	private byte[] Sbox;

	// Token: 0x04000734 RID: 1844
	[Token(Token = "0x4000734")]
	[FieldOffset(Offset = "0x18")]
	private byte[] InvSbox;

	// Token: 0x04000735 RID: 1845
	[Token(Token = "0x4000735")]
	[FieldOffset(Offset = "0x20")]
	private byte[,,] w;
}
