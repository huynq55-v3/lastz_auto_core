using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.U2D;
using VEngine;

// Token: 0x020001CC RID: 460
[Token(Token = "0x20001CC")]
public class ResourceManager
{
	// Token: 0x1700017C RID: 380
	// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000BF1 RID: 3057 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700017C")]
	public string DownloadURL
	{
		[Token(Token = "0x6000BF2")]
		[Address(RVA = "0x12BD99C", Offset = "0x12BD99C", VA = "0x12BD99C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000BF1")]
		[Address(RVA = "0x12BD954", Offset = "0x12BD954", VA = "0x12BD954")]
		set
		{
		}
	}

	// Token: 0x1700017D RID: 381
	// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x00005A30 File Offset: 0x00003C30
	// (set) Token: 0x06000BF4 RID: 3060 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700017D")]
	public bool Loggable
	{
		[Token(Token = "0x6000BF3")]
		[Address(RVA = "0x12BD9C8", Offset = "0x12BD9C8", VA = "0x12BD9C8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000BF4")]
		[Address(RVA = "0x12BDA10", Offset = "0x12BDA10", VA = "0x12BDA10")]
		set
		{
		}
	}

	// Token: 0x06000BF5 RID: 3061 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BF5")]
	[Address(RVA = "0x12BDA5C", Offset = "0x12BDA5C", VA = "0x12BDA5C")]
	public static void SetABBudget(uint kb)
	{
	}

	// Token: 0x06000BF6 RID: 3062 RVA: 0x00005A48 File Offset: 0x00003C48
	[Token(Token = "0x6000BF6")]
	[Address(RVA = "0x12BDA64", Offset = "0x12BDA64", VA = "0x12BDA64")]
	public static uint GetABBudget()
	{
		return 0U;
	}

	// Token: 0x06000BF7 RID: 3063 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BF7")]
	[Address(RVA = "0x12BDA6C", Offset = "0x12BDA6C", VA = "0x12BDA6C")]
	public static void ClearVersions()
	{
	}

	// Token: 0x06000BF8 RID: 3064 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BF8")]
	[Address(RVA = "0x12BDB68", Offset = "0x12BDB68", VA = "0x12BDB68")]
	public void Initialize(Action<bool> onComplete)
	{
	}

	// Token: 0x06000BF9 RID: 3065 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BF9")]
	[Address(RVA = "0x12BDF48", Offset = "0x12BDF48", VA = "0x12BDF48")]
	private string GetDownloadURL(string filename)
	{
		return null;
	}

	// Token: 0x06000BFA RID: 3066 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BFA")]
	[Address(RVA = "0x12BE240", Offset = "0x12BE240", VA = "0x12BE240")]
	public string[] GetManifestNames()
	{
		return null;
	}

	// Token: 0x06000BFB RID: 3067 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BFB")]
	[Address(RVA = "0x12BE248", Offset = "0x12BE248", VA = "0x12BE248")]
	public string GetBkgroundManifestName()
	{
		return null;
	}

	// Token: 0x06000BFC RID: 3068 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BFC")]
	[Address(RVA = "0x12BE250", Offset = "0x12BE250", VA = "0x12BE250")]
	public string GetPackageResManifestName()
	{
		return null;
	}

	// Token: 0x06000BFD RID: 3069 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BFD")]
	[Address(RVA = "0x12BE258", Offset = "0x12BE258", VA = "0x12BE258")]
	public string GetTempDownloadPath(string file)
	{
		return null;
	}

	// Token: 0x06000BFE RID: 3070 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BFE")]
	[Address(RVA = "0x12BE320", Offset = "0x12BE320", VA = "0x12BE320")]
	public string GetDownloadDataRootPath()
	{
		return null;
	}

	// Token: 0x06000BFF RID: 3071 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BFF")]
	[Address(RVA = "0x12BE360", Offset = "0x12BE360", VA = "0x12BE360")]
	public void OverrideManifest(Manifest manifest)
	{
	}

	// Token: 0x06000C00 RID: 3072 RVA: 0x00005A60 File Offset: 0x00003C60
	[Token(Token = "0x6000C00")]
	[Address(RVA = "0x12BE4AC", Offset = "0x12BE4AC", VA = "0x12BE4AC")]
	public ulong GetDownloadSize(DownloadType downloadType, List<Manifest> manifests, List<DownloadInfo> downloadInfos)
	{
		return 0UL;
	}

	// Token: 0x06000C01 RID: 3073 RVA: 0x00005A78 File Offset: 0x00003C78
	[Token(Token = "0x6000C01")]
	[Address(RVA = "0x12BEBB4", Offset = "0x12BEBB4", VA = "0x12BEBB4")]
	public bool GetBundleInfosOfAsset(string assetPath, List<BundleInfo> needDownloadBundleInfos, out ulong totalSize, out ulong needDownloadSize)
	{
		return default(bool);
	}

	// Token: 0x06000C02 RID: 3074 RVA: 0x00005A90 File Offset: 0x00003C90
	[Token(Token = "0x6000C02")]
	[Address(RVA = "0x12BEE5C", Offset = "0x12BEE5C", VA = "0x12BEE5C")]
	public bool GetNeedDownloadSize(string assetPath, out ulong size)
	{
		return default(bool);
	}

	// Token: 0x06000C03 RID: 3075 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C03")]
	[Address(RVA = "0x12BEF60", Offset = "0x12BEF60", VA = "0x12BEF60")]
	public DownloadVersions StartHighestPriorityDownload(List<BundleInfo> downloadBundleList)
	{
		return null;
	}

	// Token: 0x06000C04 RID: 3076 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C04")]
	[Address(RVA = "0x12BF264", Offset = "0x12BF264", VA = "0x12BF264")]
	public DownloadVersions DownloadUpdates(List<DownloadInfo> downloadInfos)
	{
		return null;
	}

	// Token: 0x06000C05 RID: 3077 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C05")]
	[Address(RVA = "0x12BF440", Offset = "0x12BF440", VA = "0x12BF440")]
	public void StartBkgroundDownload_Lua()
	{
	}

	// Token: 0x06000C06 RID: 3078 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C06")]
	[Address(RVA = "0x12BF95C", Offset = "0x12BF95C", VA = "0x12BF95C")]
	public void SetBkgroundDownloadThread(uint thread_count)
	{
	}

	// Token: 0x06000C07 RID: 3079 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C07")]
	[Address(RVA = "0x12BF544", Offset = "0x12BF544", VA = "0x12BF544")]
	public void StartBkgroundDownload(List<string> manifestNames)
	{
	}

	// Token: 0x06000C08 RID: 3080 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C08")]
	[Address(RVA = "0x12BFA30", Offset = "0x12BFA30", VA = "0x12BFA30")]
	public void BeginWhiteListCheck()
	{
	}

	// Token: 0x06000C09 RID: 3081 RVA: 0x00005AA8 File Offset: 0x00003CA8
	[Token(Token = "0x6000C09")]
	[Address(RVA = "0x12BFA7C", Offset = "0x12BFA7C", VA = "0x12BFA7C")]
	public bool EndWhiteListCheck()
	{
		return default(bool);
	}

	// Token: 0x06000C0A RID: 3082 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C0A")]
	[Address(RVA = "0x12BFC4C", Offset = "0x12BFC4C", VA = "0x12BFC4C")]
	public void Clear(bool now = false)
	{
	}

	// Token: 0x06000C0B RID: 3083 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C0B")]
	[Address(RVA = "0x12C010C", Offset = "0x12C010C", VA = "0x12C010C")]
	public Asset LoadAsset(string path, Type type)
	{
		return null;
	}

	// Token: 0x06000C0C RID: 3084 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C0C")]
	[Address(RVA = "0x12C0174", Offset = "0x12C0174", VA = "0x12C0174")]
	public Asset LoadAssetAsync(string path, Type type)
	{
		return null;
	}

	// Token: 0x06000C0D RID: 3085 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C0D")]
	[Address(RVA = "0x12C01E0", Offset = "0x12C01E0", VA = "0x12C01E0")]
	public Asset LoadAllAssetsAsync(string bundle_path, [Optional] Action<Asset> completed)
	{
		return null;
	}

	// Token: 0x06000C0E RID: 3086 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C0E")]
	[Address(RVA = "0x12C0248", Offset = "0x12C0248", VA = "0x12C0248")]
	public void PreloadAsset(string path, Type type, ResourceManager.PreloadType preloadType = ResourceManager.PreloadType.Cache)
	{
	}

	// Token: 0x06000C0F RID: 3087 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C0F")]
	[Address(RVA = "0x12C03B8", Offset = "0x12C03B8", VA = "0x12C03B8")]
	public void UnloadAsset(Asset asset)
	{
	}

	// Token: 0x06000C10 RID: 3088 RVA: 0x00005AC0 File Offset: 0x00003CC0
	[Token(Token = "0x6000C10")]
	[Address(RVA = "0x12C03CC", Offset = "0x12C03CC", VA = "0x12C03CC")]
	public bool HasAsset(string path)
	{
		return default(bool);
	}

	// Token: 0x06000C11 RID: 3089 RVA: 0x00005AD8 File Offset: 0x00003CD8
	[Token(Token = "0x6000C11")]
	[Address(RVA = "0x12BEF54", Offset = "0x12BEF54", VA = "0x12BEF54")]
	public bool IsAssetDownloaded(string path)
	{
		return default(bool);
	}

	// Token: 0x06000C12 RID: 3090 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C12")]
	[Address(RVA = "0x12C0070", Offset = "0x12C0070", VA = "0x12C0070")]
	public void UnloadUnusedAssets(bool now = false)
	{
	}

	// Token: 0x06000C13 RID: 3091 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C13")]
	[Address(RVA = "0x12C03F8", Offset = "0x12C03F8", VA = "0x12C03F8")]
	public ObjectPoolMgr GetPoolManager()
	{
		return null;
	}

	// Token: 0x06000C14 RID: 3092 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C14")]
	[Address(RVA = "0x12C0400", Offset = "0x12C0400", VA = "0x12C0400")]
	public void ClearObjectPool()
	{
	}

	// Token: 0x06000C15 RID: 3093 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C15")]
	[Address(RVA = "0x12C0420", Offset = "0x12C0420", VA = "0x12C0420")]
	public void DumpBundleDetail()
	{
	}

	// Token: 0x06000C16 RID: 3094 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C16")]
	[Address(RVA = "0x12C1010", Offset = "0x12C1010", VA = "0x12C1010")]
	public void ReleaseCacheResource(bool force = false)
	{
	}

	// Token: 0x06000C17 RID: 3095 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C17")]
	[Address(RVA = "0x12C11D4", Offset = "0x12C11D4", VA = "0x12C11D4")]
	public void CollectGarbage()
	{
	}

	// Token: 0x06000C18 RID: 3096 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C18")]
	[Address(RVA = "0x12C1308", Offset = "0x12C1308", VA = "0x12C1308")]
	public void DebugOutput()
	{
	}

	// Token: 0x06000C19 RID: 3097 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C19")]
	[Address(RVA = "0x12C139C", Offset = "0x12C139C", VA = "0x12C139C")]
	public void DebugLoadCount()
	{
	}

	// Token: 0x06000C1A RID: 3098 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C1A")]
	[Address(RVA = "0x12C13EC", Offset = "0x12C13EC", VA = "0x12C13EC")]
	public void RemoveCachedUnusedAssets()
	{
	}

	// Token: 0x06000C1B RID: 3099 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C1B")]
	[Address(RVA = "0x12C143C", Offset = "0x12C143C", VA = "0x12C143C")]
	public string GetResVersion()
	{
		return null;
	}

	// Token: 0x1700017E RID: 382
	// (get) Token: 0x06000C1C RID: 3100 RVA: 0x00005AF0 File Offset: 0x00003CF0
	[Token(Token = "0x1700017E")]
	public bool IsSimulation
	{
		[Token(Token = "0x6000C1C")]
		[Address(RVA = "0x12C1444", Offset = "0x12C1444", VA = "0x12C1444")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700017F RID: 383
	// (get) Token: 0x06000C1D RID: 3101 RVA: 0x00005B08 File Offset: 0x00003D08
	// (set) Token: 0x06000C1E RID: 3102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700017F")]
	public bool SkipUpdate
	{
		[Token(Token = "0x6000C1D")]
		[Address(RVA = "0x12C148C", Offset = "0x12C148C", VA = "0x12C148C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000C1E")]
		[Address(RVA = "0x12C14D4", Offset = "0x12C14D4", VA = "0x12C14D4")]
		set
		{
		}
	}

	// Token: 0x17000180 RID: 384
	// (get) Token: 0x06000C1F RID: 3103 RVA: 0x00005B20 File Offset: 0x00003D20
	[Token(Token = "0x17000180")]
	public bool SplitApk
	{
		[Token(Token = "0x6000C1F")]
		[Address(RVA = "0x12C1520", Offset = "0x12C1520", VA = "0x12C1520")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000C20 RID: 3104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C20")]
	[Address(RVA = "0x12C1528", Offset = "0x12C1528", VA = "0x12C1528")]
	public void Update()
	{
	}

	// Token: 0x06000C21 RID: 3105 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C21")]
	[Address(RVA = "0x12C1CC8", Offset = "0x12C1CC8", VA = "0x12C1CC8")]
	private void UpdatePoolClean()
	{
	}

	// Token: 0x06000C22 RID: 3106 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C22")]
	[Address(RVA = "0x12C1CE4", Offset = "0x12C1CE4", VA = "0x12C1CE4")]
	private void UpdatePreloadRelease()
	{
	}

	// Token: 0x06000C23 RID: 3107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C23")]
	[Address(RVA = "0x12C21C4", Offset = "0x12C21C4", VA = "0x12C21C4")]
	private void OnAtlasRegistered(SpriteAtlas sa)
	{
	}

	// Token: 0x06000C24 RID: 3108 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C24")]
	[Address(RVA = "0x12C21C8", Offset = "0x12C21C8", VA = "0x12C21C8")]
	private void OnAtlasRequested(string atlasName, Action<SpriteAtlas> callback)
	{
	}

	// Token: 0x06000C25 RID: 3109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C25")]
	[Address(RVA = "0x12C1608", Offset = "0x12C1608", VA = "0x12C1608")]
	private void UpdateInstance()
	{
	}

	// Token: 0x06000C26 RID: 3110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C26")]
	[Address(RVA = "0x12BFE5C", Offset = "0x12BFE5C", VA = "0x12BFE5C")]
	private void ClearInstance()
	{
	}

	// Token: 0x06000C27 RID: 3111 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C27")]
	[Address(RVA = "0x12C2A14", Offset = "0x12C2A14", VA = "0x12C2A14")]
	public ObjectPool GetObjectPool(string prefabPath)
	{
		return null;
	}

	// Token: 0x06000C28 RID: 3112 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C28")]
	[Address(RVA = "0x12C2A34", Offset = "0x12C2A34", VA = "0x12C2A34")]
	public void SetMainLevel(bool isMainLevel, int levelid)
	{
	}

	// Token: 0x06000C29 RID: 3113 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C29")]
	[Address(RVA = "0x12C2A44", Offset = "0x12C2A44", VA = "0x12C2A44")]
	private string GetRealPath_Native(string prefabPath)
	{
		return null;
	}

	// Token: 0x06000C2A RID: 3114 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C2A")]
	[Address(RVA = "0x12C2A4C", Offset = "0x12C2A4C", VA = "0x12C2A4C")]
	private string GetRealPath_AB(string prefabPath)
	{
		return null;
	}

	// Token: 0x06000C2B RID: 3115 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C2B")]
	[Address(RVA = "0x12C2C88", Offset = "0x12C2C88", VA = "0x12C2C88")]
	public string GetRealPath(string prefabPath)
	{
		return null;
	}

	// Token: 0x06000C2C RID: 3116 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C2C")]
	[Address(RVA = "0x12C2D0C", Offset = "0x12C2D0C", VA = "0x12C2D0C")]
	public InstanceRequest InstantiateAsync(string prefabPath, [Optional] Transform parent)
	{
		return null;
	}

	// Token: 0x06000C2D RID: 3117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C2D")]
	[Address(RVA = "0x12C2E5C", Offset = "0x12C2E5C", VA = "0x12C2E5C")]
	public ResourceManager()
	{
	}

	// Token: 0x04001026 RID: 4134
	[Token(Token = "0x4001026")]
	[FieldOffset(Offset = "0x10")]
	private string debugDownloadURL_;

	// Token: 0x04001027 RID: 4135
	[Token(Token = "0x4001027")]
	[FieldOffset(Offset = "0x18")]
	private string onlineDownloadURL_;

	// Token: 0x04001028 RID: 4136
	[Token(Token = "0x4001028")]
	[FieldOffset(Offset = "0x20")]
	private string[] manifests;

	// Token: 0x04001029 RID: 4137
	[Token(Token = "0x4001029")]
	[FieldOffset(Offset = "0x28")]
	private string bkgroundManifest;

	// Token: 0x0400102A RID: 4138
	[Token(Token = "0x400102A")]
	[FieldOffset(Offset = "0x30")]
	private string packageResManifest;

	// Token: 0x0400102B RID: 4139
	[Token(Token = "0x400102B")]
	[FieldOffset(Offset = "0x38")]
	private float lastTimePerSecondUpdate;

	// Token: 0x0400102C RID: 4140
	[Token(Token = "0x400102C")]
	[FieldOffset(Offset = "0x40")]
	private DownloadUpdateBkground _updateBkground;

	// Token: 0x0400102D RID: 4141
	[Token(Token = "0x400102D")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<string, string> swapPrefabPathCache;

	// Token: 0x0400102E RID: 4142
	[Token(Token = "0x400102E")]
	[FieldOffset(Offset = "0x50")]
	private readonly Stopwatch stopwatch;

	// Token: 0x0400102F RID: 4143
	[Token(Token = "0x400102F")]
	[FieldOffset(Offset = "0x58")]
	private float lastUnloadResourceTime;

	// Token: 0x04001030 RID: 4144
	[Token(Token = "0x4001030")]
	private const float CacheTime = 300f;

	// Token: 0x04001031 RID: 4145
	[Token(Token = "0x4001031")]
	[FieldOffset(Offset = "0x60")]
	private Dictionary<string, ResourceManager.PreloadCache> preloadCache;

	// Token: 0x04001032 RID: 4146
	[Token(Token = "0x4001032")]
	[FieldOffset(Offset = "0x68")]
	private List<string> keysRemove;

	// Token: 0x04001033 RID: 4147
	[Token(Token = "0x4001033")]
	private const string AtlasRootPath = "Assets/Main/Atlas/{0}.spriteatlas";

	// Token: 0x04001034 RID: 4148
	[Token(Token = "0x4001034")]
	[FieldOffset(Offset = "0x0")]
	public static int MaxInstancePerFrame;

	// Token: 0x04001035 RID: 4149
	[Token(Token = "0x4001035")]
	[FieldOffset(Offset = "0x4")]
	public static float MaxInstanceTime;

	// Token: 0x04001036 RID: 4150
	[Token(Token = "0x4001036")]
	[FieldOffset(Offset = "0x70")]
	private ObjectPoolMgr objectPoolMgr;

	// Token: 0x04001037 RID: 4151
	[Token(Token = "0x4001037")]
	[FieldOffset(Offset = "0x78")]
	private List<InstanceRequest> toInstanceList;

	// Token: 0x04001038 RID: 4152
	[Token(Token = "0x4001038")]
	[FieldOffset(Offset = "0x80")]
	private List<InstanceRequest> instancingList;

	// Token: 0x04001039 RID: 4153
	[Token(Token = "0x4001039")]
	[FieldOffset(Offset = "0x8")]
	public static string PVEPrefab;

	// Token: 0x0400103A RID: 4154
	[Token(Token = "0x400103A")]
	[FieldOffset(Offset = "0x10")]
	public static string PVELevel_Download;

	// Token: 0x0400103B RID: 4155
	[Token(Token = "0x400103B")]
	[FieldOffset(Offset = "0x88")]
	private bool m_isMainLevel;

	// Token: 0x0400103C RID: 4156
	[Token(Token = "0x400103C")]
	[FieldOffset(Offset = "0x8C")]
	private int m_levelId;

	// Token: 0x020001CD RID: 461
	[Token(Token = "0x20001CD")]
	public enum PreloadType
	{
		// Token: 0x0400103E RID: 4158
		[Token(Token = "0x400103E")]
		Cache,
		// Token: 0x0400103F RID: 4159
		[Token(Token = "0x400103F")]
		KeepAlive
	}

	// Token: 0x020001CE RID: 462
	[Token(Token = "0x20001CE")]
	public class PreloadCache
	{
		// Token: 0x06000C2F RID: 3119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C2F")]
		[Address(RVA = "0x12C03B0", Offset = "0x12C03B0", VA = "0x12C03B0")]
		public PreloadCache()
		{
		}

		// Token: 0x04001040 RID: 4160
		[Token(Token = "0x4001040")]
		[FieldOffset(Offset = "0x10")]
		public Asset asset;

		// Token: 0x04001041 RID: 4161
		[Token(Token = "0x4001041")]
		[FieldOffset(Offset = "0x18")]
		public float expiredTime;
	}
}
