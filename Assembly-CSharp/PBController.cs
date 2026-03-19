using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using VEngine;

// Token: 0x0200022C RID: 556
[Token(Token = "0x200022C")]
public class PBController
{
	// Token: 0x170001BC RID: 444
	// (get) Token: 0x06000ED9 RID: 3801 RVA: 0x000068E8 File Offset: 0x00004AE8
	// (set) Token: 0x06000EDA RID: 3802 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001BC")]
	public bool IsInitDone
	{
		[Token(Token = "0x6000ED9")]
		[Address(RVA = "0x122D634", Offset = "0x122D634", VA = "0x122D634")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000EDA")]
		[Address(RVA = "0x122D63C", Offset = "0x122D63C", VA = "0x122D63C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170001BD RID: 445
	// (get) Token: 0x06000EDB RID: 3803 RVA: 0x00006900 File Offset: 0x00004B00
	// (set) Token: 0x06000EDC RID: 3804 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001BD")]
	public bool IsInitSuccess
	{
		[Token(Token = "0x6000EDB")]
		[Address(RVA = "0x122D648", Offset = "0x122D648", VA = "0x122D648")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000EDC")]
		[Address(RVA = "0x122D650", Offset = "0x122D650", VA = "0x122D650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170001BE RID: 446
	// (get) Token: 0x06000EDD RID: 3805 RVA: 0x00006918 File Offset: 0x00004B18
	// (set) Token: 0x06000EDE RID: 3806 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001BE")]
	public int loadSuccessCount
	{
		[Token(Token = "0x6000EDD")]
		[Address(RVA = "0x122D65C", Offset = "0x122D65C", VA = "0x122D65C")]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000EDE")]
		[Address(RVA = "0x122D664", Offset = "0x122D664", VA = "0x122D664")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170001BF RID: 447
	// (get) Token: 0x06000EDF RID: 3807 RVA: 0x00006930 File Offset: 0x00004B30
	// (set) Token: 0x06000EE0 RID: 3808 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001BF")]
	public int preloadCount
	{
		[Token(Token = "0x6000EDF")]
		[Address(RVA = "0x122D66C", Offset = "0x122D66C", VA = "0x122D66C")]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000EE0")]
		[Address(RVA = "0x122D674", Offset = "0x122D674", VA = "0x122D674")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06000EE1 RID: 3809 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE1")]
	[Address(RVA = "0x122D67C", Offset = "0x122D67C", VA = "0x122D67C")]
	public void Reload()
	{
	}

	// Token: 0x06000EE2 RID: 3810 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE2")]
	[Address(RVA = "0x122DD2C", Offset = "0x122DD2C", VA = "0x122DD2C")]
	private void OnLoadAssets(Asset request)
	{
	}

	// Token: 0x06000EE3 RID: 3811 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE3")]
	[Address(RVA = "0x122DF2C", Offset = "0x122DF2C", VA = "0x122DF2C")]
	public PBController()
	{
	}

	// Token: 0x040011CF RID: 4559
	[Token(Token = "0x40011CF")]
	[FieldOffset(Offset = "0x10")]
	private List<string> pbFiles;

	// Token: 0x040011D4 RID: 4564
	[Token(Token = "0x40011D4")]
	[FieldOffset(Offset = "0x28")]
	private List<Asset> preloadRequest;

	// Token: 0x040011D5 RID: 4565
	[Token(Token = "0x40011D5")]
	[FieldOffset(Offset = "0x30")]
	private List<Asset> loadRequest;
}
