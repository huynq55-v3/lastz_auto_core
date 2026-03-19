using System;
using Il2CppDummyDll;
using LitJson;

// Token: 0x02000231 RID: 561
[Token(Token = "0x2000231")]
public class UploadImageManager
{
	// Token: 0x170001C6 RID: 454
	// (get) Token: 0x06000F3C RID: 3900 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001C6")]
	public static UploadImageManager Instance
	{
		[Token(Token = "0x6000F3C")]
		[Address(RVA = "0x122FD18", Offset = "0x122FD18", VA = "0x122FD18")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000F3D RID: 3901 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F3D")]
	[Address(RVA = "0x122FE48", Offset = "0x122FE48", VA = "0x122FE48")]
	public static void Purge()
	{
	}

	// Token: 0x170001C7 RID: 455
	// (get) Token: 0x06000F3E RID: 3902 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001C7")]
	private static string PHOTO_UPLOAD_URL
	{
		[Token(Token = "0x6000F3E")]
		[Address(RVA = "0x122FEAC", Offset = "0x122FEAC", VA = "0x122FEAC")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000F3F RID: 3903 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F3F")]
	[Address(RVA = "0x122FDD0", Offset = "0x122FDD0", VA = "0x122FDD0")]
	private UploadImageManager()
	{
	}

	// Token: 0x06000F40 RID: 3904 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F40")]
	[Address(RVA = "0x122FF24", Offset = "0x122FF24", VA = "0x122FF24")]
	public void OnUploadImage(int code, string uid, int picVer)
	{
	}

	// Token: 0x06000F41 RID: 3905 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F41")]
	[Address(RVA = "0x122FFE8", Offset = "0x122FFE8", VA = "0x122FFE8")]
	public void OnImagePathOk(string filePath)
	{
	}

	// Token: 0x06000F42 RID: 3906 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F42")]
	[Address(RVA = "0x12303B8", Offset = "0x12303B8", VA = "0x12303B8")]
	public void UploadHeadImage(string uri, string uid, string photo_seq, string filePath)
	{
	}

	// Token: 0x06000F43 RID: 3907 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F43")]
	[Address(RVA = "0x1230978", Offset = "0x1230978", VA = "0x1230978")]
	public static string GetHeadPath(string uid, string picVer)
	{
		return null;
	}

	// Token: 0x06000F44 RID: 3908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F44")]
	[Address(RVA = "0x1230A48", Offset = "0x1230A48", VA = "0x1230A48")]
	public void DownloadHeadImage(string uri, string uid, string picVer, Action<string, string> cb)
	{
	}

	// Token: 0x06000F45 RID: 3909 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F45")]
	[Address(RVA = "0x1230D5C", Offset = "0x1230D5C", VA = "0x1230D5C")]
	private string ToReqString(UploadImageManager.CHAT_REQ_TYPE status)
	{
		return null;
	}

	// Token: 0x06000F46 RID: 3910 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F46")]
	[Address(RVA = "0x1230DE8", Offset = "0x1230DE8", VA = "0x1230DE8")]
	private string ErrorJson(string error)
	{
		return null;
	}

	// Token: 0x06000F47 RID: 3911 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F47")]
	[Address(RVA = "0x1230E80", Offset = "0x1230E80", VA = "0x1230E80")]
	public static string GetChatImgUploadUrl()
	{
		return null;
	}

	// Token: 0x06000F48 RID: 3912 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F48")]
	[Address(RVA = "0x1230EF8", Offset = "0x1230EF8", VA = "0x1230EF8")]
	public void OnPickChatImage(int code, string uid, Action<int, string> action)
	{
	}

	// Token: 0x06000F49 RID: 3913 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F49")]
	[Address(RVA = "0x1231078", Offset = "0x1231078", VA = "0x1231078")]
	public void OnChatImagePathOk(string filePath, int width, int height)
	{
	}

	// Token: 0x06000F4A RID: 3914 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F4A")]
	[Address(RVA = "0x12312AC", Offset = "0x12312AC", VA = "0x12312AC")]
	public void UploadChatImage(string uid, string cacheKey, Action<int, string> action, string paramStr = "")
	{
	}

	// Token: 0x06000F4B RID: 3915 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F4B")]
	[Address(RVA = "0x12315A0", Offset = "0x12315A0", VA = "0x12315A0")]
	private string GetFileLocationByCacheKey(string cacheKey)
	{
		return null;
	}

	// Token: 0x06000F4C RID: 3916 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F4C")]
	[Address(RVA = "0x1231704", Offset = "0x1231704", VA = "0x1231704")]
	private string GetrReqTypeByParamStr(string paramStr)
	{
		return null;
	}

	// Token: 0x06000F4D RID: 3917 RVA: 0x00006BD0 File Offset: 0x00004DD0
	[Token(Token = "0x6000F4D")]
	[Address(RVA = "0x12317B0", Offset = "0x12317B0", VA = "0x12317B0")]
	private UploadImageManager.CHAT_REQ_TYPE GetrReqTypeByUrl(string url)
	{
		return UploadImageManager.CHAT_REQ_TYPE.Normal;
	}

	// Token: 0x06000F4E RID: 3918 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F4E")]
	[Address(RVA = "0x1231844", Offset = "0x1231844", VA = "0x1231844")]
	private JsonData UploadedChatImgSucessProcess(string srcCacheKey, JsonData data)
	{
		return null;
	}

	// Token: 0x06000F4F RID: 3919 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F4F")]
	[Address(RVA = "0x1232024", Offset = "0x1232024", VA = "0x1232024")]
	private JsonData UploadedChatImgFailProcess(string srcCacheKey, JsonData data)
	{
		return null;
	}

	// Token: 0x040011EA RID: 4586
	[Token(Token = "0x40011EA")]
	[FieldOffset(Offset = "0x0")]
	private static UploadImageManager _instance;

	// Token: 0x040011EB RID: 4587
	[Token(Token = "0x40011EB")]
	[FieldOffset(Offset = "0x10")]
	private string param_uid_;

	// Token: 0x040011EC RID: 4588
	[Token(Token = "0x40011EC")]
	[FieldOffset(Offset = "0x18")]
	private int param_picVer_;

	// Token: 0x040011ED RID: 4589
	[Token(Token = "0x40011ED")]
	[FieldOffset(Offset = "0x1C")]
	private bool hasCacheResult;

	// Token: 0x040011EE RID: 4590
	[Token(Token = "0x40011EE")]
	[FieldOffset(Offset = "0x20")]
	private string cacheRet;

	// Token: 0x040011EF RID: 4591
	[Token(Token = "0x40011EF")]
	[FieldOffset(Offset = "0x28")]
	private string cacheData;

	// Token: 0x040011F0 RID: 4592
	[Token(Token = "0x40011F0")]
	[FieldOffset(Offset = "0x8")]
	public static string PHOTO_UPLOAD_URL_DEBUG;

	// Token: 0x040011F1 RID: 4593
	[Token(Token = "0x40011F1")]
	[FieldOffset(Offset = "0x10")]
	public static string PHOTO_UPLOAD_URL_ONLINE;

	// Token: 0x040011F2 RID: 4594
	[Token(Token = "0x40011F2")]
	[FieldOffset(Offset = "0x30")]
	private Action<int, string> param_chat_callback_;

	// Token: 0x040011F3 RID: 4595
	[Token(Token = "0x40011F3")]
	private const int UPLOAD_TIMEOUT = 60;

	// Token: 0x040011F4 RID: 4596
	[Token(Token = "0x40011F4")]
	private const string param_callback_split = "\u001f";

	// Token: 0x040011F5 RID: 4597
	[Token(Token = "0x40011F5")]
	public const string CHAT_IMG_LOCAL_FOLDER = "LocalChatImg";

	// Token: 0x040011F6 RID: 4598
	[Token(Token = "0x40011F6")]
	public const int CHAT_IMG_MAX_SIZE = 2048;

	// Token: 0x040011F7 RID: 4599
	[Token(Token = "0x40011F7")]
	[FieldOffset(Offset = "0x18")]
	public static string CHAT_UPLAOD_URL_DEBUG;

	// Token: 0x040011F8 RID: 4600
	[Token(Token = "0x40011F8")]
	[FieldOffset(Offset = "0x20")]
	public static string CHAT_UPLAOD_URL;

	// Token: 0x02000232 RID: 562
	[Token(Token = "0x2000232")]
	public enum CHAT_UPLOAD_STATUS
	{
		// Token: 0x040011FA RID: 4602
		[Token(Token = "0x40011FA")]
		FAILED,
		// Token: 0x040011FB RID: 4603
		[Token(Token = "0x40011FB")]
		PICK_END,
		// Token: 0x040011FC RID: 4604
		[Token(Token = "0x40011FC")]
		UPLOAD_PROCESS,
		// Token: 0x040011FD RID: 4605
		[Token(Token = "0x40011FD")]
		UPLOAD_END,
		// Token: 0x040011FE RID: 4606
		[Token(Token = "0x40011FE")]
		VERIFY_END
	}

	// Token: 0x02000233 RID: 563
	[Token(Token = "0x2000233")]
	public enum CHAT_REQ_TYPE
	{
		// Token: 0x04001200 RID: 4608
		[Token(Token = "0x4001200")]
		Normal,
		// Token: 0x04001201 RID: 4609
		[Token(Token = "0x4001201")]
		Moment,
		// Token: 0x04001202 RID: 4610
		[Token(Token = "0x4001202")]
		AllianceAnnounment
	}
}
