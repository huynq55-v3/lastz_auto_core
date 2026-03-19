using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using VEngine;

// Token: 0x020001D5 RID: 469
[Token(Token = "0x20001D5")]
internal class DownloadUpdateBkground
{
	// Token: 0x06000C4F RID: 3151 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C4F")]
	[Address(RVA = "0x12BF9C0", Offset = "0x12BF9C0", VA = "0x12BF9C0")]
	public void Start(List<DownloadInfo> downloadInfos)
	{
	}

	// Token: 0x06000C50 RID: 3152 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C50")]
	[Address(RVA = "0x12C20A0", Offset = "0x12C20A0", VA = "0x12C20A0")]
	public void Update()
	{
	}

	// Token: 0x06000C51 RID: 3153 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C51")]
	[Address(RVA = "0x12BF9B8", Offset = "0x12BF9B8", VA = "0x12BF9B8")]
	public DownloadUpdateBkground()
	{
	}

	// Token: 0x0400105B RID: 4187
	[Token(Token = "0x400105B")]
	[FieldOffset(Offset = "0x10")]
	public List<Manifest> manifests;

	// Token: 0x0400105C RID: 4188
	[Token(Token = "0x400105C")]
	[FieldOffset(Offset = "0x18")]
	private DownloadVersions _downloadVersions;
}
