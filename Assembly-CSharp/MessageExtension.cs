using System;
using Il2CppDummyDll;
using Sfs2X.Entities.Data;
using Unity.IL2CPP.CompilerServices;

// Token: 0x02000170 RID: 368
[Token(Token = "0x2000170")]
[Il2CppEagerStaticClassConstruction]
[Il2CppSetOption(Option.NullChecks, false)]
public static class MessageExtension
{
	// Token: 0x06000A88 RID: 2696 RVA: 0x000053A0 File Offset: 0x000035A0
	[Token(Token = "0x6000A88")]
	[Address(RVA = "0x3717794", Offset = "0x3717794", VA = "0x3717794")]
	public static int TryGetInt(this ISFSObject obj, string key)
	{
		return 0;
	}

	// Token: 0x06000A89 RID: 2697 RVA: 0x000053B8 File Offset: 0x000035B8
	[Token(Token = "0x6000A89")]
	[Address(RVA = "0x3717BF0", Offset = "0x3717BF0", VA = "0x3717BF0")]
	public static float TryGetFloat(this ISFSObject obj, string key)
	{
		return 0f;
	}

	// Token: 0x06000A8A RID: 2698 RVA: 0x000053D0 File Offset: 0x000035D0
	[Token(Token = "0x6000A8A")]
	[Address(RVA = "0x3717C04", Offset = "0x3717C04", VA = "0x3717C04")]
	public static long TryGetLong(this ISFSObject obj, string key)
	{
		return 0L;
	}

	// Token: 0x06000A8B RID: 2699 RVA: 0x000053E8 File Offset: 0x000035E8
	[Token(Token = "0x6000A8B")]
	[Address(RVA = "0x371804C", Offset = "0x371804C", VA = "0x371804C")]
	public static double TryGetDouble(this ISFSObject obj, string key)
	{
		return 0.0;
	}

	// Token: 0x06000A8C RID: 2700 RVA: 0x00005400 File Offset: 0x00003600
	[Token(Token = "0x6000A8C")]
	[Address(RVA = "0x37177BC", Offset = "0x37177BC", VA = "0x37177BC")]
	public static double TryGetNumber(this ISFSObject obj, string key)
	{
		return 0.0;
	}

	// Token: 0x06000A8D RID: 2701 RVA: 0x00005418 File Offset: 0x00003618
	[Token(Token = "0x6000A8D")]
	[Address(RVA = "0x3718050", Offset = "0x3718050", VA = "0x3718050")]
	public static bool TryGetBool(this ISFSObject obj, string key)
	{
		return default(bool);
	}

	// Token: 0x06000A8E RID: 2702 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A8E")]
	[Address(RVA = "0x37181F4", Offset = "0x37181F4", VA = "0x37181F4")]
	public static string TryGetString(this ISFSObject obj, string key)
	{
		return null;
	}

	// Token: 0x06000A8F RID: 2703 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A8F")]
	[Address(RVA = "0x37183B4", Offset = "0x37183B4", VA = "0x37183B4")]
	public static string TryMergeString(this ISFSObject obj, string key)
	{
		return null;
	}

	// Token: 0x06000A90 RID: 2704 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A90")]
	[Address(RVA = "0x371862C", Offset = "0x371862C", VA = "0x371862C")]
	public static ISFSObject TryGetObj(this ISFSObject obj, string key)
	{
		return null;
	}

	// Token: 0x06000A91 RID: 2705 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A91")]
	[Address(RVA = "0x37187B0", Offset = "0x37187B0", VA = "0x37187B0")]
	public static ISFSArray TryGetArray(this ISFSObject obj, string key)
	{
		return null;
	}

	// Token: 0x06000A92 RID: 2706 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A92")]
	[Address(RVA = "0x37188C8", Offset = "0x37188C8", VA = "0x37188C8")]
	public static int[] TryGetIntArray(this ISFSObject obj, string key)
	{
		return null;
	}

	// Token: 0x06000A93 RID: 2707 RVA: 0x00005430 File Offset: 0x00003630
	[Token(Token = "0x6000A93")]
	[Address(RVA = "0x37189E0", Offset = "0x37189E0", VA = "0x37189E0")]
	public static long GetLong(this ISFSObject obj, string key)
	{
		return 0L;
	}

	// Token: 0x06000A94 RID: 2708 RVA: 0x00005448 File Offset: 0x00003648
	[Token(Token = "0x6000A94")]
	[Address(RVA = "0x3718AF8", Offset = "0x3718AF8", VA = "0x3718AF8")]
	public static bool IsNullOrEmpty(this ISFSArray obj)
	{
		return default(bool);
	}
}
