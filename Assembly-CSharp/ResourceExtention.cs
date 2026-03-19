using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000178 RID: 376
[Token(Token = "0x2000178")]
[Il2CppEagerStaticClassConstruction]
[Il2CppSetOption(Option.NullChecks, false)]
public static class ResourceExtention
{
	// Token: 0x06000AAC RID: 2732 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AAC")]
	[Address(RVA = "0x371A6E8", Offset = "0x371A6E8", VA = "0x371A6E8")]
	public static void LoadHeadEx(this Image image, string uid, string pic, int picVer)
	{
	}

	// Token: 0x06000AAD RID: 2733 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AAD")]
	[Address(RVA = "0x371AC58", Offset = "0x371AC58", VA = "0x371AC58")]
	public static string GetChatImgUrl(UploadImageManager.CHAT_REQ_TYPE type = UploadImageManager.CHAT_REQ_TYPE.Normal)
	{
		return null;
	}

	// Token: 0x06000AAE RID: 2734 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AAE")]
	[Address(RVA = "0x371AD04", Offset = "0x371AD04", VA = "0x371AD04")]
	private static void ReleaseChatImg(Image img)
	{
	}

	// Token: 0x06000AAF RID: 2735 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AAF")]
	[Address(RVA = "0x371B1DC", Offset = "0x371B1DC", VA = "0x371B1DC")]
	private static void RefChatImg(Image img, DynamicAsset asset)
	{
	}

	// Token: 0x06000AB0 RID: 2736 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB0")]
	[Address(RVA = "0x371B25C", Offset = "0x371B25C", VA = "0x371B25C")]
	public static void LoadChatImgURLEx(this Image image, string cacheKey, string smallCacheKey, string default_sprite, [Optional] Action<string, string> callBack, int width = 0, int height = 0, int widthSmall = 0, int heightSmall = 0, int reqType = 0)
	{
	}

	// Token: 0x06000AB1 RID: 2737 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB1")]
	[Address(RVA = "0x371B768", Offset = "0x371B768", VA = "0x371B768")]
	public static void ClearChatImgURlEx(this Image image, string default_sprite)
	{
	}

	// Token: 0x06000AB2 RID: 2738 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB2")]
	[Address(RVA = "0x371B32C", Offset = "0x371B32C", VA = "0x371B32C")]
	public static void LoadURLEx(this Image image, string url, string cacheKey, string defaultSprite, string cacheFolder, string smallCacheKey, Action<string, string> callBack, int width = 0, int height = 0, int widthSmall = 0, int heightSmall = 0)
	{
	}

	// Token: 0x06000AB3 RID: 2739 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB3")]
	[Address(RVA = "0x371B824", Offset = "0x371B824", VA = "0x371B824")]
	public static void SwapChatImgCacheKey(string srcCacheKey, string dstCacheKey)
	{
	}

	// Token: 0x040007AA RID: 1962
	[Token(Token = "0x40007AA")]
	private const string UserHeadPath = "Assets/Main/Sprites/UI/UIHeadIcon/";

	// Token: 0x040007AB RID: 1963
	[Token(Token = "0x40007AB")]
	private const string DefaultUserHead = "Assets/Main/Sprites/UI/UIHeadIcon/g044.png";

	// Token: 0x040007AC RID: 1964
	[Token(Token = "0x40007AC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<Object, string> m_UrlInLoading;

	// Token: 0x040007AD RID: 1965
	[Token(Token = "0x40007AD")]
	[FieldOffset(Offset = "0x8")]
	private static readonly Dictionary<Image, DynamicAsset> m_ChatImgRefDict;

	// Token: 0x040007AE RID: 1966
	[Token(Token = "0x40007AE")]
	[FieldOffset(Offset = "0x10")]
	private static readonly HashSet<Sprite> m_ChatAllSprSet;

	// Token: 0x040007AF RID: 1967
	[Token(Token = "0x40007AF")]
	private const string C_Success = "Success";

	// Token: 0x040007B0 RID: 1968
	[Token(Token = "0x40007B0")]
	private const string C_Failed = "Failed";

	// Token: 0x040007B1 RID: 1969
	[Token(Token = "0x40007B1")]
	private const string c_SmallSucess = "Small_Success";

	// Token: 0x040007B2 RID: 1970
	[Token(Token = "0x40007B2")]
	[FieldOffset(Offset = "0x18")]
	public static string CHAT_URL_DEBUG;

	// Token: 0x040007B3 RID: 1971
	[Token(Token = "0x40007B3")]
	[FieldOffset(Offset = "0x20")]
	public static string CHAT_IMG_URL;

	// Token: 0x040007B4 RID: 1972
	[Token(Token = "0x40007B4")]
	[FieldOffset(Offset = "0x28")]
	public static string MOMENT_URL_DEBUG;

	// Token: 0x040007B5 RID: 1973
	[Token(Token = "0x40007B5")]
	[FieldOffset(Offset = "0x30")]
	public static string MOMENT_IMG_URL;

	// Token: 0x040007B6 RID: 1974
	[Token(Token = "0x40007B6")]
	[FieldOffset(Offset = "0x38")]
	public static string ALANMT_URL_DEBUG;

	// Token: 0x040007B7 RID: 1975
	[Token(Token = "0x40007B7")]
	[FieldOffset(Offset = "0x40")]
	public static string ALANMT_IMG_URL;

	// Token: 0x040007B8 RID: 1976
	[Token(Token = "0x40007B8")]
	[FieldOffset(Offset = "0x48")]
	private static List<Image> ToBeRemove;
}
