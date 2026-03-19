using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

// Token: 0x0200020D RID: 525
[Token(Token = "0x200020D")]
public class CustomDataManager
{
	// Token: 0x06000E16 RID: 3606 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E16")]
	private T AddData<T>() where T : BaseDataContainer
	{
		return null;
	}

	// Token: 0x06000E17 RID: 3607 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E17")]
	[Address(RVA = "0x121D3F0", Offset = "0x121D3F0", VA = "0x121D3F0")]
	public CustomDataManager()
	{
	}

	// Token: 0x06000E18 RID: 3608 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E18")]
	[Address(RVA = "0x121D510", Offset = "0x121D510", VA = "0x121D510")]
	public void Release()
	{
	}

	// Token: 0x06000E19 RID: 3609 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E19")]
	[Address(RVA = "0x121D480", Offset = "0x121D480", VA = "0x121D480")]
	public void Reset()
	{
	}

	// Token: 0x170001B0 RID: 432
	// (get) Token: 0x06000E1A RID: 3610 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000E1B RID: 3611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001B0")]
	public DCPlayer Player
	{
		[Token(Token = "0x6000E1A")]
		[Address(RVA = "0x121D6AC", Offset = "0x121D6AC", VA = "0x121D6AC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000E1B")]
		[Address(RVA = "0x121D6B4", Offset = "0x121D6B4", VA = "0x121D6B4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170001B1 RID: 433
	// (get) Token: 0x06000E1C RID: 3612 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000E1D RID: 3613 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001B1")]
	public DCBuilding Building
	{
		[Token(Token = "0x6000E1C")]
		[Address(RVA = "0x121D6BC", Offset = "0x121D6BC", VA = "0x121D6BC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000E1D")]
		[Address(RVA = "0x121D6C4", Offset = "0x121D6C4", VA = "0x121D6C4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x0400115F RID: 4447
	[Token(Token = "0x400115F")]
	[FieldOffset(Offset = "0x10")]
	private readonly Dictionary<string, BaseDataContainer> m_Datas;
}
