using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

// Token: 0x02000202 RID: 514
[Token(Token = "0x2000202")]
public static class BitSet
{
	// Token: 0x06000DD5 RID: 3541 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DD5")]
	[Address(RVA = "0x121917C", Offset = "0x121917C", VA = "0x121917C")]
	public static void LoadAsync(string key, string path, bool force, [Optional] Action<bool> callback)
	{
	}

	// Token: 0x06000DD6 RID: 3542 RVA: 0x00006348 File Offset: 0x00004548
	[Token(Token = "0x6000DD6")]
	[Address(RVA = "0x12194C8", Offset = "0x12194C8", VA = "0x12194C8")]
	public static bool Load(string key, string path, bool force)
	{
		return default(bool);
	}

	// Token: 0x06000DD7 RID: 3543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DD7")]
	[Address(RVA = "0x12199D0", Offset = "0x12199D0", VA = "0x12199D0")]
	public static void Remove(string key)
	{
	}

	// Token: 0x06000DD8 RID: 3544 RVA: 0x00006360 File Offset: 0x00004560
	[Token(Token = "0x6000DD8")]
	[Address(RVA = "0x1219A50", Offset = "0x1219A50", VA = "0x1219A50")]
	public static bool Set(string key, int index, bool t)
	{
		return default(bool);
	}

	// Token: 0x06000DD9 RID: 3545 RVA: 0x00006378 File Offset: 0x00004578
	[Token(Token = "0x6000DD9")]
	[Address(RVA = "0x1219C88", Offset = "0x1219C88", VA = "0x1219C88")]
	public static bool Get(string key, int index)
	{
		return default(bool);
	}

	// Token: 0x06000DDA RID: 3546 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DDA")]
	[Address(RVA = "0x1219EAC", Offset = "0x1219EAC", VA = "0x1219EAC")]
	public static void LoadAsync(int keyId, int pathId, bool force, [Optional] Action<bool> callback)
	{
	}

	// Token: 0x06000DDB RID: 3547 RVA: 0x00006390 File Offset: 0x00004590
	[Token(Token = "0x6000DDB")]
	[Address(RVA = "0x1219F70", Offset = "0x1219F70", VA = "0x1219F70")]
	public static bool Load(int keyId, int pathId, bool force, [Optional] Action<bool> callback)
	{
		return default(bool);
	}

	// Token: 0x06000DDC RID: 3548 RVA: 0x000063A8 File Offset: 0x000045A8
	[Token(Token = "0x6000DDC")]
	[Address(RVA = "0x121A024", Offset = "0x121A024", VA = "0x121A024")]
	public static bool Set(int keyId, int index, bool t)
	{
		return default(bool);
	}

	// Token: 0x06000DDD RID: 3549 RVA: 0x000063C0 File Offset: 0x000045C0
	[Token(Token = "0x6000DDD")]
	[Address(RVA = "0x121A0C8", Offset = "0x121A0C8", VA = "0x121A0C8")]
	public static bool Get(int keyId, int index)
	{
		return default(bool);
	}

	// Token: 0x06000DDE RID: 3550 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DDE")]
	[Address(RVA = "0x121A164", Offset = "0x121A164", VA = "0x121A164")]
	public static void ClearAll()
	{
	}

	// Token: 0x04001144 RID: 4420
	[Token(Token = "0x4001144")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<string, BitSet.BitSpan> BitArrayDict;

	// Token: 0x02000203 RID: 515
	[Token(Token = "0x2000203")]
	public readonly struct BitSpan
	{
		// Token: 0x06000DE0 RID: 3552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DE0")]
		[Address(RVA = "0x1219968", Offset = "0x1219968", VA = "0x1219968")]
		public BitSpan(byte[] bytes)
		{
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x000063D8 File Offset: 0x000045D8
		[Token(Token = "0x6000DE1")]
		[Address(RVA = "0x1219DFC", Offset = "0x1219DFC", VA = "0x1219DFC")]
		public bool GetBit(int index)
		{
			return default(bool);
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DE2")]
		[Address(RVA = "0x1219BCC", Offset = "0x1219BCC", VA = "0x1219BCC")]
		public void SetBit(int index, bool value)
		{
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000DE3 RID: 3555 RVA: 0x000063F0 File Offset: 0x000045F0
		[Token(Token = "0x170001AE")]
		public int Length
		{
			[Token(Token = "0x6000DE3")]
			[Address(RVA = "0x121A278", Offset = "0x121A278", VA = "0x121A278")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04001145 RID: 4421
		[Token(Token = "0x4001145")]
		[FieldOffset(Offset = "0x0")]
		private readonly byte[] _bytes;
	}
}
