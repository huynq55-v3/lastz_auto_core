using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000172 RID: 370
[Token(Token = "0x2000172")]
public static class MonoUtils
{
	// Token: 0x06000A95 RID: 2709 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A95")]
	[Address(RVA = "0x3718BA8", Offset = "0x3718BA8", VA = "0x3718BA8")]
	public static void CacheCurModel(this GameObject gameObject)
	{
	}

	// Token: 0x06000A96 RID: 2710 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A96")]
	[Address(RVA = "0x3718DA4", Offset = "0x3718DA4", VA = "0x3718DA4")]
	public static void RecoverModel(this GameObject gameObject)
	{
	}

	// Token: 0x06000A97 RID: 2711 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A97")]
	[Address(RVA = "0x3718F94", Offset = "0x3718F94", VA = "0x3718F94")]
	public static void SetSkinMeshRenderUpdateOutScreen(this GameObject o, bool update)
	{
	}

	// Token: 0x06000A98 RID: 2712 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A98")]
	[Address(RVA = "0x371907C", Offset = "0x371907C", VA = "0x371907C")]
	public static void SetVolume_MotionBlur(this Volume volume, bool active)
	{
	}

	// Token: 0x06000A99 RID: 2713 RVA: 0x00005460 File Offset: 0x00003660
	[Token(Token = "0x6000A99")]
	[Address(RVA = "0x3719168", Offset = "0x3719168", VA = "0x3719168")]
	public static float FindAnimationClipEventTime(this Animator animator, int clipHash, string begin, string end)
	{
		return 0f;
	}

	// Token: 0x0400079C RID: 1948
	[Token(Token = "0x400079C")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<int, TransData> skinProperty;

	// Token: 0x0400079D RID: 1949
	[Token(Token = "0x400079D")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<int, float> dictAnim;
}
