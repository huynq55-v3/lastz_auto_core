using System;
using Il2CppDummyDll;
using Main.Scripts.Application.LoadingState;

// Token: 0x02000079 RID: 121
[Token(Token = "0x2000079")]
public class ZipDataTable
{
	// Token: 0x060002F7 RID: 759 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x320E594", Offset = "0x320E594", VA = "0x320E594")]
	public void StartZipDownLoad(Action callBack1, Action callBack2)
	{
	}

	// Token: 0x060002F8 RID: 760 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x320EA00", Offset = "0x320EA00", VA = "0x320EA00")]
	public void UnzipDatabase(byte[] data)
	{
	}

	// Token: 0x060002F9 RID: 761 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x320F150", Offset = "0x320F150", VA = "0x320F150")]
	public void DisposeZipDownloadRequest()
	{
	}

	// Token: 0x060002FA RID: 762 RVA: 0x00003018 File Offset: 0x00001218
	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x320F184", Offset = "0x320F184", VA = "0x320F184")]
	public int ExecuteUnzipDatabase(Action callBack)
	{
		return 0;
	}

	// Token: 0x060002FB RID: 763 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x320F234", Offset = "0x320F234", VA = "0x320F234")]
	public byte[] LoadZipFile(string filepath)
	{
		return null;
	}

	// Token: 0x060002FC RID: 764 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x3208978", Offset = "0x3208978", VA = "0x3208978")]
	public ZipDataTable()
	{
	}

	// Token: 0x0400028D RID: 653
	[Token(Token = "0x400028D")]
	[FieldOffset(Offset = "0x10")]
	private HttpRequest _zipDownloadRequest;

	// Token: 0x0400028E RID: 654
	[Token(Token = "0x400028E")]
	[FieldOffset(Offset = "0x18")]
	public ConfigStatus _ConfigStatus;

	// Token: 0x0400028F RID: 655
	[Token(Token = "0x400028F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string LuaDataTableRootPath;
}
