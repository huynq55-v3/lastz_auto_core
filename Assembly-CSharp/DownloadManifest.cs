using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Main.Scripts.Application.LoadingState;
using UnityEngine.Scripting;
using VEngine;

// Token: 0x0200006F RID: 111
[Token(Token = "0x200006F")]
[Preserve]
public class DownloadManifest
{
	// Token: 0x17000076 RID: 118
	// (get) Token: 0x060002BE RID: 702 RVA: 0x00002FA0 File Offset: 0x000011A0
	[Token(Token = "0x17000076")]
	public bool isDone
	{
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x3209D9C", Offset = "0x3209D9C", VA = "0x3209D9C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000077 RID: 119
	// (get) Token: 0x060002BF RID: 703 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000077")]
	public string error
	{
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x3209DB0", Offset = "0x3209DB0", VA = "0x3209DB0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000078 RID: 120
	// (get) Token: 0x060002C0 RID: 704 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000078")]
	public Manifest manifest
	{
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x3209DB8", Offset = "0x3209DB8", VA = "0x3209DB8")]
		get
		{
			return null;
		}
	}

	// Token: 0x060002C1 RID: 705 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x3209DC0", Offset = "0x3209DC0", VA = "0x3209DC0")]
	public DownloadManifest(string name)
	{
	}

	// Token: 0x060002C2 RID: 706 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x3209EB8", Offset = "0x3209EB8", VA = "0x3209EB8", Slot = "1")]
	protected override void Finalize()
	{
	}

	// Token: 0x060002C3 RID: 707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x3209FA0", Offset = "0x3209FA0", VA = "0x3209FA0")]
	public void Dispose()
	{
	}

	// Token: 0x060002C4 RID: 708 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x320A02C", Offset = "0x320A02C", VA = "0x320A02C")]
	public static DownloadManifest LoadAsync(string name)
	{
		return null;
	}

	// Token: 0x060002C5 RID: 709 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x320A094", Offset = "0x320A094", VA = "0x320A094")]
	private void Load()
	{
	}

	// Token: 0x060002C6 RID: 710 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x320A2A8", Offset = "0x320A2A8", VA = "0x320A2A8")]
	public void OnUpdate()
	{
	}

	// Token: 0x060002C7 RID: 711 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x320A3A8", Offset = "0x320A3A8", VA = "0x320A3A8")]
	private void UpdateVersion()
	{
	}

	// Token: 0x060002C8 RID: 712 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x320AAA0", Offset = "0x320AAA0", VA = "0x320AAA0")]
	private void UpdateDownloading()
	{
	}

	// Token: 0x060002C9 RID: 713 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x320A25C", Offset = "0x320A25C", VA = "0x320A25C")]
	private void Finish([Optional] string error)
	{
	}

	// Token: 0x060002CA RID: 714 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x320B5CC", Offset = "0x320B5CC", VA = "0x320B5CC")]
	private void Unzip(byte[] data, string path)
	{
	}

	// Token: 0x060002CB RID: 715 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x320AD94", Offset = "0x320AD94", VA = "0x320AD94")]
	private void UnzipToFile(byte[] data, string filename)
	{
	}

	// Token: 0x0400025E RID: 606
	[Token(Token = "0x400025E")]
	[FieldOffset(Offset = "0x10")]
	private Manifest _manifest;

	// Token: 0x0400025F RID: 607
	[Token(Token = "0x400025F")]
	[FieldOffset(Offset = "0x18")]
	private ManifestVersionFile _versionFile;

	// Token: 0x04000260 RID: 608
	[Token(Token = "0x4000260")]
	[FieldOffset(Offset = "0x20")]
	private string _versionName;

	// Token: 0x04000261 RID: 609
	[Token(Token = "0x4000261")]
	[FieldOffset(Offset = "0x28")]
	private string _pathOrURL;

	// Token: 0x04000262 RID: 610
	[Token(Token = "0x4000262")]
	[FieldOffset(Offset = "0x30")]
	private DownloadManifest.Status _status;

	// Token: 0x04000263 RID: 611
	[Token(Token = "0x4000263")]
	[FieldOffset(Offset = "0x38")]
	private HttpRequest _httpRequest;

	// Token: 0x04000264 RID: 612
	[Token(Token = "0x4000264")]
	[FieldOffset(Offset = "0x40")]
	private string _error;

	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	private enum Status
	{
		// Token: 0x04000266 RID: 614
		[Token(Token = "0x4000266")]
		Loading,
		// Token: 0x04000267 RID: 615
		[Token(Token = "0x4000267")]
		CheckVersion,
		// Token: 0x04000268 RID: 616
		[Token(Token = "0x4000268")]
		Downloading,
		// Token: 0x04000269 RID: 617
		[Token(Token = "0x4000269")]
		Success,
		// Token: 0x0400026A RID: 618
		[Token(Token = "0x400026A")]
		Failed
	}
}
