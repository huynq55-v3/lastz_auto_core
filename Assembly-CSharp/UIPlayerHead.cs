using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200013C RID: 316
[Token(Token = "0x200013C")]
[AddComponentMenu("UI/UIPlayerHead")]
public class UIPlayerHead : MonoBehaviour
{
	// Token: 0x06000937 RID: 2359 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000937")]
	[Address(RVA = "0x33B1018", Offset = "0x33B1018", VA = "0x33B1018")]
	private void Awake()
	{
	}

	// Token: 0x06000938 RID: 2360 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000938")]
	[Address(RVA = "0x33B10A8", Offset = "0x33B10A8", VA = "0x33B10A8")]
	public void SetData(string uid, string pic, int picVer, bool useBig = false)
	{
	}

	// Token: 0x06000939 RID: 2361 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000939")]
	[Address(RVA = "0x33B1510", Offset = "0x33B1510", VA = "0x33B1510")]
	public void SetCustomLoadCallback(Action action)
	{
	}

	// Token: 0x0600093A RID: 2362 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600093A")]
	[Address(RVA = "0x33B1518", Offset = "0x33B1518", VA = "0x33B1518")]
	public void SetCustomBigLoadCallback(Action action)
	{
	}

	// Token: 0x0600093B RID: 2363 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600093B")]
	[Address(RVA = "0x33B11F8", Offset = "0x33B11F8", VA = "0x33B11F8")]
	private void LoadHeadInternal()
	{
	}

	// Token: 0x0600093C RID: 2364 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600093C")]
	[Address(RVA = "0x33B1BF4", Offset = "0x33B1BF4", VA = "0x33B1BF4")]
	private void OnLoadCallBack(string key, DynamicAsset asset, object userdata)
	{
	}

	// Token: 0x0600093D RID: 2365 RVA: 0x00004F08 File Offset: 0x00003108
	[Token(Token = "0x600093D")]
	[Address(RVA = "0x33B2020", Offset = "0x33B2020", VA = "0x33B2020")]
	private bool IsBigHeadLoaded(string key)
	{
		return default(bool);
	}

	// Token: 0x0600093E RID: 2366 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600093E")]
	[Address(RVA = "0x33B1F30", Offset = "0x33B1F30", VA = "0x33B1F30")]
	private void ReleaseCurrentSprite()
	{
	}

	// Token: 0x0600093F RID: 2367 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600093F")]
	[Address(RVA = "0x33B20A8", Offset = "0x33B20A8", VA = "0x33B20A8")]
	private string GetFullPath(string inputPath)
	{
		return null;
	}

	// Token: 0x06000940 RID: 2368 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000940")]
	[Address(RVA = "0x33B1984", Offset = "0x33B1984", VA = "0x33B1984")]
	public void UseSystemHead()
	{
	}

	// Token: 0x06000941 RID: 2369 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000941")]
	[Address(RVA = "0x33B2174", Offset = "0x33B2174", VA = "0x33B2174")]
	public void LoadSprite(string pic)
	{
	}

	// Token: 0x06000942 RID: 2370 RVA: 0x00004F20 File Offset: 0x00003120
	[Token(Token = "0x6000942")]
	[Address(RVA = "0x33B1520", Offset = "0x33B1520", VA = "0x33B1520")]
	private bool IsSystemHead()
	{
		return default(bool);
	}

	// Token: 0x06000943 RID: 2371 RVA: 0x00004F38 File Offset: 0x00003138
	[Token(Token = "0x6000943")]
	[Address(RVA = "0x33B1564", Offset = "0x33B1564", VA = "0x33B1564")]
	public static bool GenCustomPicUrl(string uid, int picVer, out string url, out string key, bool useBig = false)
	{
		return default(bool);
	}

	// Token: 0x06000944 RID: 2372 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000944")]
	[Address(RVA = "0x33B23C0", Offset = "0x33B23C0", VA = "0x33B23C0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000945 RID: 2373 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000945")]
	[Address(RVA = "0x33B23C4", Offset = "0x33B23C4", VA = "0x33B23C4")]
	private void OnDisable()
	{
	}

	// Token: 0x06000946 RID: 2374 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000946")]
	[Address(RVA = "0x33B23C8", Offset = "0x33B23C8", VA = "0x33B23C8")]
	private void OnHeadInfoChanged(object userData)
	{
	}

	// Token: 0x06000947 RID: 2375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000947")]
	[Address(RVA = "0x33B24A4", Offset = "0x33B24A4", VA = "0x33B24A4")]
	public UIPlayerHead()
	{
	}

	// Token: 0x040006E8 RID: 1768
	[Token(Token = "0x40006E8")]
	[FieldOffset(Offset = "0x0")]
	public static string UserHeadPath;

	// Token: 0x040006E9 RID: 1769
	[Token(Token = "0x40006E9")]
	[FieldOffset(Offset = "0x8")]
	public static string DefaultUserHead;

	// Token: 0x040006EA RID: 1770
	[Token(Token = "0x40006EA")]
	[FieldOffset(Offset = "0x10")]
	public static string CACHE_FOLDER;

	// Token: 0x040006EB RID: 1771
	[Token(Token = "0x40006EB")]
	[FieldOffset(Offset = "0x18")]
	public static string HEAD_URL;

	// Token: 0x040006EC RID: 1772
	[Token(Token = "0x40006EC")]
	[FieldOffset(Offset = "0x18")]
	private CircleImage _circleImage;

	// Token: 0x040006ED RID: 1773
	[Token(Token = "0x40006ED")]
	[FieldOffset(Offset = "0x20")]
	private SpriteRenderer _spriteRenderer;

	// Token: 0x040006EE RID: 1774
	[Token(Token = "0x40006EE")]
	[FieldOffset(Offset = "0x28")]
	private string playerUid;

	// Token: 0x040006EF RID: 1775
	[Token(Token = "0x40006EF")]
	[FieldOffset(Offset = "0x30")]
	private string playerPic;

	// Token: 0x040006F0 RID: 1776
	[Token(Token = "0x40006F0")]
	[FieldOffset(Offset = "0x38")]
	private int playerPicVer;

	// Token: 0x040006F1 RID: 1777
	[Token(Token = "0x40006F1")]
	[FieldOffset(Offset = "0x3C")]
	private bool useBig;

	// Token: 0x040006F2 RID: 1778
	[Token(Token = "0x40006F2")]
	[FieldOffset(Offset = "0x3D")]
	private bool needRelease;

	// Token: 0x040006F3 RID: 1779
	[Token(Token = "0x40006F3")]
	[FieldOffset(Offset = "0x40")]
	private Action customLoadCallback;

	// Token: 0x040006F4 RID: 1780
	[Token(Token = "0x40006F4")]
	[FieldOffset(Offset = "0x48")]
	private Action customBigLoadCallback;
}
