using System;
using System.IO;
using Il2CppDummyDll;

// Token: 0x02000165 RID: 357
[Token(Token = "0x2000165")]
public static class FileUtils
{
	// Token: 0x06000A54 RID: 2644 RVA: 0x000052B0 File Offset: 0x000034B0
	[Token(Token = "0x6000A54")]
	[Address(RVA = "0x371337C", Offset = "0x371337C", VA = "0x371337C")]
	public static bool ExistDirectory(string path)
	{
		return default(bool);
	}

	// Token: 0x06000A55 RID: 2645 RVA: 0x000052C8 File Offset: 0x000034C8
	[Token(Token = "0x6000A55")]
	[Address(RVA = "0x3713384", Offset = "0x3713384", VA = "0x3713384")]
	public static bool ExistFile(string path)
	{
		return default(bool);
	}

	// Token: 0x06000A56 RID: 2646 RVA: 0x000052E0 File Offset: 0x000034E0
	[Token(Token = "0x6000A56")]
	[Address(RVA = "0x371338C", Offset = "0x371338C", VA = "0x371338C")]
	public static bool Copy(string srcPath, string dstPath, bool overwrite = true)
	{
		return default(bool);
	}

	// Token: 0x06000A57 RID: 2647 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A57")]
	[Address(RVA = "0x371341C", Offset = "0x371341C", VA = "0x371341C")]
	public static void DeleteDirectoryIfExists(string path, bool recursive = true)
	{
	}

	// Token: 0x06000A58 RID: 2648 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A58")]
	[Address(RVA = "0x371345C", Offset = "0x371345C", VA = "0x371345C")]
	public static void DeleteFileIfExists(string path)
	{
	}

	// Token: 0x06000A59 RID: 2649 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A59")]
	[Address(RVA = "0x3713488", Offset = "0x3713488", VA = "0x3713488")]
	public static void CreateFileDirectoryIfNotExists(string path)
	{
	}

	// Token: 0x06000A5A RID: 2650 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A5A")]
	[Address(RVA = "0x3713518", Offset = "0x3713518", VA = "0x3713518")]
	public static FileStream CreateFile(string path)
	{
		return null;
	}

	// Token: 0x06000A5B RID: 2651 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A5B")]
	[Address(RVA = "0x3713550", Offset = "0x3713550", VA = "0x3713550")]
	public static StreamWriter CreateText(string path)
	{
		return null;
	}

	// Token: 0x06000A5C RID: 2652 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A5C")]
	[Address(RVA = "0x3713588", Offset = "0x3713588", VA = "0x3713588")]
	public static void WriteFile(string path, byte[] bytedata, bool overwrite = true)
	{
	}

	// Token: 0x06000A5D RID: 2653 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A5D")]
	[Address(RVA = "0x37135D8", Offset = "0x37135D8", VA = "0x37135D8")]
	public static void CopyFile(string srcPath, string dstPath, bool overwrite = true)
	{
	}

	// Token: 0x06000A5E RID: 2654 RVA: 0x000052F8 File Offset: 0x000034F8
	[Token(Token = "0x6000A5E")]
	[Address(RVA = "0x37136FC", Offset = "0x37136FC", VA = "0x37136FC")]
	public static long GetFileSize(string path)
	{
		return 0L;
	}

	// Token: 0x06000A5F RID: 2655 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A5F")]
	[Address(RVA = "0x371388C", Offset = "0x371388C", VA = "0x371388C")]
	public static void CopyFilesRecursively(string sourcePath, string targetPath)
	{
	}
}
