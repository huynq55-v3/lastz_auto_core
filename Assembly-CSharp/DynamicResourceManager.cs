using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;

// Token: 0x0200021E RID: 542
[Token(Token = "0x200021E")]
public class DynamicResourceManager : MonoBehaviour
{
	// Token: 0x170001BA RID: 442
	// (get) Token: 0x06000E82 RID: 3714 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001BA")]
	public static DynamicResourceManager Instance
	{
		[Token(Token = "0x6000E82")]
		[Address(RVA = "0x1226F30", Offset = "0x1226F30", VA = "0x1226F30")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000E83 RID: 3715 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E83")]
	[Address(RVA = "0x122735C", Offset = "0x122735C", VA = "0x122735C")]
	public void LoadTextureFromURL(string url, string cacheKey, DynamicResourceManager.OnLoadComplete action, string cacheFolder = "Images", [Optional] object userdata, int width = 0, int height = 0)
	{
	}

	// Token: 0x06000E84 RID: 3716 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E84")]
	[Address(RVA = "0x122766C", Offset = "0x122766C", VA = "0x122766C")]
	private void LoadRawTextureASTCFromURL(string url, string cacheKey, DynamicResourceManager.OnLoadComplete action, int width, int height, string cacheFolder = "Images", [Optional] object userdata)
	{
	}

	// Token: 0x06000E85 RID: 3717 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E85")]
	[Address(RVA = "0x12278E0", Offset = "0x12278E0", VA = "0x12278E0")]
	private void RegistCallback(string key, Delegate callback)
	{
	}

	// Token: 0x06000E86 RID: 3718 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E86")]
	[Address(RVA = "0x1227AC8", Offset = "0x1227AC8", VA = "0x1227AC8")]
	public void RemoveCallBack(DynamicResourceManager.OnLoadComplete callback)
	{
	}

	// Token: 0x06000E87 RID: 3719 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E87")]
	[Address(RVA = "0x1227C4C", Offset = "0x1227C4C", VA = "0x1227C4C")]
	public void ModifyRequestPriority(string url, string cacheKey, int value)
	{
	}

	// Token: 0x06000E88 RID: 3720 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E88")]
	[Address(RVA = "0x1227CB4", Offset = "0x1227CB4", VA = "0x1227CB4")]
	private void Callback(string key, DynamicAsset obj, object userdata)
	{
	}

	// Token: 0x06000E89 RID: 3721 RVA: 0x00006708 File Offset: 0x00004908
	[Token(Token = "0x6000E89")]
	[Address(RVA = "0x1227F70", Offset = "0x1227F70", VA = "0x1227F70")]
	private static bool CacheAssetInLocal(UnityWebRequest request, string cacheKey, string cacheFolder)
	{
		return default(bool);
	}

	// Token: 0x06000E8A RID: 3722 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E8A")]
	[Address(RVA = "0x1228304", Offset = "0x1228304", VA = "0x1228304")]
	public void SwapCacheAssetLocalCacheKey(string srcCacheKey, string dstCacheKey)
	{
	}

	// Token: 0x06000E8B RID: 3723 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E8B")]
	[Address(RVA = "0x12283F8", Offset = "0x12283F8", VA = "0x12283F8")]
	public void Update()
	{
	}

	// Token: 0x06000E8C RID: 3724 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E8C")]
	[Address(RVA = "0x122887C", Offset = "0x122887C", VA = "0x122887C")]
	public DynamicResourceManager()
	{
	}

	// Token: 0x0400119D RID: 4509
	[Token(Token = "0x400119D")]
	[FieldOffset(Offset = "0x0")]
	private static DynamicResourceManager _instance;

	// Token: 0x0400119E RID: 4510
	[Token(Token = "0x400119E")]
	[FieldOffset(Offset = "0x8")]
	private static readonly object _lock;

	// Token: 0x0400119F RID: 4511
	[Token(Token = "0x400119F")]
	[FieldOffset(Offset = "0x18")]
	private readonly Dictionary<string, List<Delegate>> m_CallbackStack;

	// Token: 0x040011A0 RID: 4512
	[Token(Token = "0x40011A0")]
	[FieldOffset(Offset = "0x20")]
	private readonly Dictionary<string, DynamicAsset> m_CachedAssetFromUrl;

	// Token: 0x040011A1 RID: 4513
	[Token(Token = "0x40011A1")]
	[FieldOffset(Offset = "0x28")]
	private List<string> ToRemoveList;

	// Token: 0x0200021F RID: 543
	// (Invoke) Token: 0x06000E8F RID: 3727
	[Token(Token = "0x200021F")]
	public delegate void OnLoadComplete(string key, DynamicAsset asset, object userdata);
}
