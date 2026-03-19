using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;
using LitJson;

// Token: 0x020001DC RID: 476
[Token(Token = "0x20001DC")]
public class SDKManager : IGameController
{
	// Token: 0x06000C80 RID: 3200 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C80")]
	[Address(RVA = "0x12C534C", Offset = "0x12C534C", VA = "0x12C534C")]
	public SDKManager()
	{
	}

	// Token: 0x06000C81 RID: 3201 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C81")]
	[Address(RVA = "0x12C5460", Offset = "0x12C5460", VA = "0x12C5460")]
	public void Initialize()
	{
	}

	// Token: 0x06000C82 RID: 3202 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C82")]
	[Address(RVA = "0x12C572C", Offset = "0x12C572C", VA = "0x12C572C", Slot = "5")]
	public void Shutdown()
	{
	}

	// Token: 0x06000C83 RID: 3203 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C83")]
	[Address(RVA = "0x12C5738", Offset = "0x12C5738", VA = "0x12C5738")]
	public void SetPayMangerCallback(Action<string, string> action)
	{
	}

	// Token: 0x1700018E RID: 398
	// (get) Token: 0x06000C84 RID: 3204 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000C85 RID: 3205 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700018E")]
	public IPlatformNative Platform
	{
		[Token(Token = "0x6000C84")]
		[Address(RVA = "0x12C5740", Offset = "0x12C5740", VA = "0x12C5740")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000C85")]
		[Address(RVA = "0x12C5748", Offset = "0x12C5748", VA = "0x12C5748")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x1700018F RID: 399
	// (get) Token: 0x06000C86 RID: 3206 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700018F")]
	public PlatformAndroid Android
	{
		[Token(Token = "0x6000C86")]
		[Address(RVA = "0x12C5750", Offset = "0x12C5750", VA = "0x12C5750")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000190 RID: 400
	// (get) Token: 0x06000C87 RID: 3207 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000C88 RID: 3208 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000190")]
	public string Version
	{
		[Token(Token = "0x6000C87")]
		[Address(RVA = "0x12C57E0", Offset = "0x12C57E0", VA = "0x12C57E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000C88")]
		[Address(RVA = "0x12C57E8", Offset = "0x12C57E8", VA = "0x12C57E8")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000191 RID: 401
	// (get) Token: 0x06000C89 RID: 3209 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000C8A RID: 3210 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000191")]
	public string VersionCode
	{
		[Token(Token = "0x6000C89")]
		[Address(RVA = "0x12C57F0", Offset = "0x12C57F0", VA = "0x12C57F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000C8A")]
		[Address(RVA = "0x12C57F8", Offset = "0x12C57F8", VA = "0x12C57F8")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000192 RID: 402
	// (get) Token: 0x06000C8B RID: 3211 RVA: 0x00005BF8 File Offset: 0x00003DF8
	// (set) Token: 0x06000C8C RID: 3212 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000192")]
	public bool IsGoogleAvailable
	{
		[Token(Token = "0x6000C8B")]
		[Address(RVA = "0x12C5800", Offset = "0x12C5800", VA = "0x12C5800")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000C8C")]
		[Address(RVA = "0x12C5808", Offset = "0x12C5808", VA = "0x12C5808")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000193 RID: 403
	// (get) Token: 0x06000C8D RID: 3213 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000C8E RID: 3214 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000193")]
	public string AndroidScreenNotch
	{
		[Token(Token = "0x6000C8D")]
		[Address(RVA = "0x12C5814", Offset = "0x12C5814", VA = "0x12C5814")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000C8E")]
		[Address(RVA = "0x12C581C", Offset = "0x12C581C", VA = "0x12C581C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06000C8F RID: 3215 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C8F")]
	[Address(RVA = "0x12C5824", Offset = "0x12C5824", VA = "0x12C5824")]
	public string GetPublishRegion()
	{
		return null;
	}

	// Token: 0x06000C90 RID: 3216 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C90")]
	[Address(RVA = "0x12BE1C8", Offset = "0x12BE1C8", VA = "0x12BE1C8")]
	public string GetGPPackageName()
	{
		return null;
	}

	// Token: 0x06000C91 RID: 3217 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C91")]
	[Address(RVA = "0x12C59B4", Offset = "0x12C59B4", VA = "0x12C59B4")]
	public string GetPackageName()
	{
		return null;
	}

	// Token: 0x06000C92 RID: 3218 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C92")]
	[Address(RVA = "0x12C59BC", Offset = "0x12C59BC", VA = "0x12C59BC")]
	public string GetPackageSign()
	{
		return null;
	}

	// Token: 0x06000C93 RID: 3219 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C93")]
	[Address(RVA = "0x12C58D8", Offset = "0x12C58D8", VA = "0x12C58D8")]
	public string getChannel()
	{
		return null;
	}

	// Token: 0x06000C94 RID: 3220 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C94")]
	[Address(RVA = "0x12C5AD8", Offset = "0x12C5AD8", VA = "0x12C5AD8")]
	public string GetBuildTime()
	{
		return null;
	}

	// Token: 0x06000C95 RID: 3221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C95")]
	[Address(RVA = "0x12C5BE8", Offset = "0x12C5BE8", VA = "0x12C5BE8")]
	public void saveDataToSdcard(string data, string path)
	{
	}

	// Token: 0x06000C96 RID: 3222 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C96")]
	[Address(RVA = "0x12C5D68", Offset = "0x12C5D68", VA = "0x12C5D68")]
	public void RequestSdCardPermission()
	{
	}

	// Token: 0x06000C97 RID: 3223 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C97")]
	[Address(RVA = "0x12C5E44", Offset = "0x12C5E44", VA = "0x12C5E44")]
	public string GetZoneIdFromNative()
	{
		return null;
	}

	// Token: 0x06000C98 RID: 3224 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C98")]
	[Address(RVA = "0x12C5F20", Offset = "0x12C5F20", VA = "0x12C5F20")]
	public void DoInitGooglePay()
	{
	}

	// Token: 0x06000C99 RID: 3225 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C99")]
	[Address(RVA = "0x12C5FFC", Offset = "0x12C5FFC", VA = "0x12C5FFC")]
	public void CheckDownloadGoogleApk()
	{
	}

	// Token: 0x06000C9A RID: 3226 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C9A")]
	[Address(RVA = "0x12C60D8", Offset = "0x12C60D8", VA = "0x12C60D8")]
	public string GetDeviceUDID()
	{
		return null;
	}

	// Token: 0x06000C9B RID: 3227 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C9B")]
	[Address(RVA = "0x12C61B4", Offset = "0x12C61B4", VA = "0x12C61B4")]
	public string GetSerialID()
	{
		return null;
	}

	// Token: 0x06000C9C RID: 3228 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C9C")]
	[Address(RVA = "0x12C6290", Offset = "0x12C6290", VA = "0x12C6290")]
	public string GetDeviceInfo()
	{
		return null;
	}

	// Token: 0x06000C9D RID: 3229 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C9D")]
	[Address(RVA = "0x12C5638", Offset = "0x12C5638", VA = "0x12C5638")]
	public void SetAndroidScreenNotch()
	{
	}

	// Token: 0x06000C9E RID: 3230 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C9E")]
	[Address(RVA = "0x12C636C", Offset = "0x12C636C", VA = "0x12C636C")]
	public string GetHandSetInfo()
	{
		return null;
	}

	// Token: 0x06000C9F RID: 3231 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C9F")]
	[Address(RVA = "0x12C6448", Offset = "0x12C6448", VA = "0x12C6448")]
	public string GenerateHighVersionUUID()
	{
		return null;
	}

	// Token: 0x06000CA0 RID: 3232 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CA0")]
	[Address(RVA = "0x12C6524", Offset = "0x12C6524", VA = "0x12C6524")]
	public string GetSimOperator()
	{
		return null;
	}

	// Token: 0x06000CA1 RID: 3233 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CA1")]
	[Address(RVA = "0x12C6600", Offset = "0x12C6600", VA = "0x12C6600")]
	public string GetSimOperatorName()
	{
		return null;
	}

	// Token: 0x06000CA2 RID: 3234 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CA2")]
	[Address(RVA = "0x12C66DC", Offset = "0x12C66DC", VA = "0x12C66DC")]
	public string getClickPushTag()
	{
		return null;
	}

	// Token: 0x06000CA3 RID: 3235 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CA3")]
	[Address(RVA = "0x12C67B8", Offset = "0x12C67B8", VA = "0x12C67B8")]
	public string getClickPushId()
	{
		return null;
	}

	// Token: 0x06000CA4 RID: 3236 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CA4")]
	[Address(RVA = "0x12C6894", Offset = "0x12C6894", VA = "0x12C6894")]
	public string getClickPushTime()
	{
		return null;
	}

	// Token: 0x06000CA5 RID: 3237 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA5")]
	[Address(RVA = "0x12C6970", Offset = "0x12C6970", VA = "0x12C6970")]
	public void ClearAllPushData()
	{
	}

	// Token: 0x06000CA6 RID: 3238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA6")]
	[Address(RVA = "0x12C6A4C", Offset = "0x12C6A4C", VA = "0x12C6A4C")]
	public void CopyTextToClipboard(string _content)
	{
	}

	// Token: 0x06000CA7 RID: 3239 RVA: 0x00005C10 File Offset: 0x00003E10
	[Token(Token = "0x6000CA7")]
	[Address(RVA = "0x12C6DB0", Offset = "0x12C6DB0", VA = "0x12C6DB0")]
	public bool GetIsNotifyOpen()
	{
		return default(bool);
	}

	// Token: 0x06000CA8 RID: 3240 RVA: 0x00005C28 File Offset: 0x00003E28
	[Token(Token = "0x6000CA8")]
	[Address(RVA = "0x12C6DB8", Offset = "0x12C6DB8", VA = "0x12C6DB8")]
	public bool IsTrackingEnabled()
	{
		return default(bool);
	}

	// Token: 0x06000CA9 RID: 3241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA9")]
	[Address(RVA = "0x12C6E14", Offset = "0x12C6E14", VA = "0x12C6E14")]
	public void OpenSettings()
	{
	}

	// Token: 0x06000CAA RID: 3242 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CAA")]
	[Address(RVA = "0x12C6EF0", Offset = "0x12C6EF0", VA = "0x12C6EF0")]
	private void RequestTrackingAuthorization()
	{
	}

	// Token: 0x06000CAB RID: 3243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CAB")]
	[Address(RVA = "0x12C6F74", Offset = "0x12C6F74", VA = "0x12C6F74")]
	public void LogEvent(string eventName, params object[] datas)
	{
	}

	// Token: 0x06000CAC RID: 3244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CAC")]
	[Address(RVA = "0x12C73A8", Offset = "0x12C73A8", VA = "0x12C73A8")]
	public void AppsFlyerPurchaseCustom(string eventName, string cost, string itemId)
	{
	}

	// Token: 0x06000CAD RID: 3245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CAD")]
	[Address(RVA = "0x12C7594", Offset = "0x12C7594", VA = "0x12C7594")]
	public void FacebookPurchaseCustom(string eventName, string cost, string itemId)
	{
	}

	// Token: 0x06000CAE RID: 3246 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CAE")]
	[Address(RVA = "0x12C7780", Offset = "0x12C7780", VA = "0x12C7780")]
	public void Send_FireBase_LogCustomEvent(string dataString)
	{
	}

	// Token: 0x06000CAF RID: 3247 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CAF")]
	[Address(RVA = "0x12C784C", Offset = "0x12C784C", VA = "0x12C784C")]
	public void LogEventLevelUp(int lv)
	{
	}

	// Token: 0x06000CB0 RID: 3248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB0")]
	[Address(RVA = "0x12C79A8", Offset = "0x12C79A8", VA = "0x12C79A8")]
	public void Login(LoginPlatform loginPF, bool changeAccount = false, bool isBind = false)
	{
	}

	// Token: 0x06000CB1 RID: 3249 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB1")]
	[Address(RVA = "0x12C7C2C", Offset = "0x12C7C2C", VA = "0x12C7C2C")]
	public void Logout()
	{
	}

	// Token: 0x06000CB2 RID: 3250 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB2")]
	[Address(RVA = "0x12C7CD0", Offset = "0x12C7CD0", VA = "0x12C7CD0")]
	public void Pay(string data)
	{
	}

	// Token: 0x06000CB3 RID: 3251 RVA: 0x00005C40 File Offset: 0x00003E40
	[Token(Token = "0x6000CB3")]
	[Address(RVA = "0x12C7DE0", Offset = "0x12C7DE0", VA = "0x12C7DE0")]
	public int CheckPayEnv()
	{
		return 0;
	}

	// Token: 0x06000CB4 RID: 3252 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CB4")]
	[Address(RVA = "0x12C7EC4", Offset = "0x12C7EC4", VA = "0x12C7EC4")]
	public string Get_PF_DisplayName()
	{
		return null;
	}

	// Token: 0x06000CB5 RID: 3253 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB5")]
	[Address(RVA = "0x12C7FA0", Offset = "0x12C7FA0", VA = "0x12C7FA0")]
	public void ConsumeProduct(string orderId, int state)
	{
	}

	// Token: 0x06000CB6 RID: 3254 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB6")]
	[Address(RVA = "0x12C805C", Offset = "0x12C805C", VA = "0x12C805C")]
	public void GotoMarket(string url, string urlCDN)
	{
	}

	// Token: 0x06000CB7 RID: 3255 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB7")]
	[Address(RVA = "0x12C4594", Offset = "0x12C4594", VA = "0x12C4594")]
	public void SendDataToGame(string funcName, string data)
	{
	}

	// Token: 0x06000CB8 RID: 3256 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB8")]
	[Address(RVA = "0x12C8178", Offset = "0x12C8178", VA = "0x12C8178", Slot = "4")]
	public void OnUpdate(float elapseSeconds)
	{
	}

	// Token: 0x06000CB9 RID: 3257 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB9")]
	[Address(RVA = "0x12C8390", Offset = "0x12C8390", VA = "0x12C8390")]
	public void HandleEvent(string funcName, string data)
	{
	}

	// Token: 0x06000CBA RID: 3258 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CBA")]
	[Address(RVA = "0x12C70E4", Offset = "0x12C70E4", VA = "0x12C70E4")]
	public void SendDataToNative(string funcName, string data)
	{
	}

	// Token: 0x06000CBB RID: 3259 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CBB")]
	[Address(RVA = "0x12CAE40", Offset = "0x12CAE40", VA = "0x12CAE40")]
	public string GetDataFromNative(string funcName, string data)
	{
		return null;
	}

	// Token: 0x06000CBC RID: 3260 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CBC")]
	[Address(RVA = "0x12CAEFC", Offset = "0x12CAEFC", VA = "0x12CAEFC")]
	public string GetPermissionByType(string data)
	{
		return null;
	}

	// Token: 0x06000CBD RID: 3261 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CBD")]
	[Address(RVA = "0x12C6C44", Offset = "0x12C6C44", VA = "0x12C6C44")]
	private string FastToJson(JsonData data)
	{
		return null;
	}

	// Token: 0x06000CBE RID: 3262 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CBE")]
	[Address(RVA = "0x12C9F54", Offset = "0x12C9F54", VA = "0x12C9F54")]
	private void OnLoginCallBack(JsonData result)
	{
	}

	// Token: 0x06000CBF RID: 3263 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CBF")]
	[Address(RVA = "0x12CAFA8", Offset = "0x12CAFA8", VA = "0x12CAFA8")]
	private void OnAgeSignalCallback(JsonData result)
	{
	}

	// Token: 0x06000CC0 RID: 3264 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CC0")]
	[Address(RVA = "0x12CB13C", Offset = "0x12CB13C", VA = "0x12CB13C")]
	public void HideSplash()
	{
	}

	// Token: 0x06000CC1 RID: 3265 RVA: 0x00005C58 File Offset: 0x00003E58
	[Token(Token = "0x6000CC1")]
	[Address(RVA = "0x12CB1F4", Offset = "0x12CB1F4", VA = "0x12CB1F4")]
	public bool IsShowLogoOk()
	{
		return default(bool);
	}

	// Token: 0x06000CC2 RID: 3266 RVA: 0x00005C70 File Offset: 0x00003E70
	[Token(Token = "0x6000CC2")]
	[Address(RVA = "0x12CB33C", Offset = "0x12CB33C", VA = "0x12CB33C")]
	public bool IsShowEuropeanUnionPrivacy()
	{
		return default(bool);
	}

	// Token: 0x06000CC3 RID: 3267 RVA: 0x00005C88 File Offset: 0x00003E88
	[Token(Token = "0x6000CC3")]
	[Address(RVA = "0x12CB344", Offset = "0x12CB344", VA = "0x12CB344")]
	public static bool IS_UNITY_ANDROID()
	{
		return default(bool);
	}

	// Token: 0x06000CC4 RID: 3268 RVA: 0x00005CA0 File Offset: 0x00003EA0
	[Token(Token = "0x6000CC4")]
	[Address(RVA = "0x12CB34C", Offset = "0x12CB34C", VA = "0x12CB34C")]
	public static bool IS_UNITY_IOS()
	{
		return default(bool);
	}

	// Token: 0x06000CC5 RID: 3269 RVA: 0x00005CB8 File Offset: 0x00003EB8
	[Token(Token = "0x6000CC5")]
	[Address(RVA = "0x12CB354", Offset = "0x12CB354", VA = "0x12CB354")]
	public static bool IS_UNITY_IPHONE()
	{
		return default(bool);
	}

	// Token: 0x06000CC6 RID: 3270 RVA: 0x00005CD0 File Offset: 0x00003ED0
	[Token(Token = "0x6000CC6")]
	[Address(RVA = "0x12CB35C", Offset = "0x12CB35C", VA = "0x12CB35C")]
	public static bool IS_UNITY_EDITOR()
	{
		return default(bool);
	}

	// Token: 0x06000CC7 RID: 3271 RVA: 0x00005CE8 File Offset: 0x00003EE8
	[Token(Token = "0x6000CC7")]
	[Address(RVA = "0x12CB364", Offset = "0x12CB364", VA = "0x12CB364")]
	public static bool IS_UNITY_EDITOR_WINDOWS()
	{
		return default(bool);
	}

	// Token: 0x06000CC8 RID: 3272 RVA: 0x00005D00 File Offset: 0x00003F00
	[Token(Token = "0x6000CC8")]
	[Address(RVA = "0x12CB36C", Offset = "0x12CB36C", VA = "0x12CB36C")]
	public static bool IS_UNITY_PC()
	{
		return default(bool);
	}

	// Token: 0x06000CC9 RID: 3273 RVA: 0x00005D18 File Offset: 0x00003F18
	[Token(Token = "0x6000CC9")]
	[Address(RVA = "0x12CB374", Offset = "0x12CB374", VA = "0x12CB374")]
	public static bool IS_UNITY_PC_WINDOWS()
	{
		return default(bool);
	}

	// Token: 0x06000CCA RID: 3274 RVA: 0x00005D30 File Offset: 0x00003F30
	[Token(Token = "0x6000CCA")]
	[Address(RVA = "0x12CB37C", Offset = "0x12CB37C", VA = "0x12CB37C")]
	public static bool IS_MacOSEditor()
	{
		return default(bool);
	}

	// Token: 0x06000CCB RID: 3275 RVA: 0x00005D48 File Offset: 0x00003F48
	[Token(Token = "0x6000CCB")]
	[Address(RVA = "0x12CB398", Offset = "0x12CB398", VA = "0x12CB398")]
	public static bool IS_IPhonePlayer()
	{
		return default(bool);
	}

	// Token: 0x06000CCC RID: 3276 RVA: 0x00005D60 File Offset: 0x00003F60
	[Token(Token = "0x6000CCC")]
	[Address(RVA = "0x12CB3B4", Offset = "0x12CB3B4", VA = "0x12CB3B4")]
	public static bool IS_Android()
	{
		return default(bool);
	}

	// Token: 0x06000CCD RID: 3277 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CCD")]
	[Address(RVA = "0x12CB3D0", Offset = "0x12CB3D0", VA = "0x12CB3D0")]
	public void requestFCMToken()
	{
	}

	// Token: 0x06000CCE RID: 3278 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CCE")]
	[Address(RVA = "0x12CB438", Offset = "0x12CB438", VA = "0x12CB438")]
	public void CrashlyticsSetCustomValue(string key, string value)
	{
	}

	// Token: 0x06000CCF RID: 3279 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CCF")]
	[Address(RVA = "0x12CB540", Offset = "0x12CB540", VA = "0x12CB540")]
	public void CrashlyticsAddLog(string log)
	{
	}

	// Token: 0x06000CD0 RID: 3280 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CD0")]
	[Address(RVA = "0x12CB598", Offset = "0x12CB598", VA = "0x12CB598")]
	public void CrashlyticsSetUserId(string userId)
	{
	}

	// Token: 0x06000CD1 RID: 3281 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CD1")]
	[Address(RVA = "0x12CB5F0", Offset = "0x12CB5F0", VA = "0x12CB5F0")]
	public void initAppsFlyer(string gameUid)
	{
	}

	// Token: 0x06000CD2 RID: 3282 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CD2")]
	[Address(RVA = "0x12C71A0", Offset = "0x12C71A0", VA = "0x12C71A0")]
	public void RecordAppsflyer(string key)
	{
	}

	// Token: 0x06000CD3 RID: 3283 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CD3")]
	[Address(RVA = "0x12CB770", Offset = "0x12CB770", VA = "0x12CB770")]
	public void SetAppsFlyerPurchase(string cost, string itemId)
	{
	}

	// Token: 0x06000CD4 RID: 3284 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CD4")]
	[Address(RVA = "0x12CB940", Offset = "0x12CB940", VA = "0x12CB940")]
	public void SetFacebookPurchaseEvent(string cost, string itemId)
	{
	}

	// Token: 0x06000CD5 RID: 3285 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CD5")]
	[Address(RVA = "0x12CBB08", Offset = "0x12CBB08", VA = "0x12CBB08")]
	public string GetValueFromCSharp(string key)
	{
		return null;
	}

	// Token: 0x06000CD6 RID: 3286 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CD6")]
	[Address(RVA = "0x12CBBB0", Offset = "0x12CBBB0", VA = "0x12CBBB0")]
	public void SetValueToCSharp(string key, string value)
	{
	}

	// Token: 0x06000CD7 RID: 3287 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CD7")]
	[Address(RVA = "0x12CBC5C", Offset = "0x12CBC5C", VA = "0x12CBC5C")]
	public void OpenKidAuth(string id, string url)
	{
	}

	// Token: 0x06000CD8 RID: 3288 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CD8")]
	[Address(RVA = "0x12CBE68", Offset = "0x12CBE68", VA = "0x12CBE68")]
	public void OpenUrl(string url)
	{
	}

	// Token: 0x06000CD9 RID: 3289 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CD9")]
	[Address(RVA = "0x12CBE74", Offset = "0x12CBE74", VA = "0x12CBE74")]
	public void OpenAppReview(string url)
	{
	}

	// Token: 0x06000CDA RID: 3290 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CDA")]
	[Address(RVA = "0x12CBE80", Offset = "0x12CBE80", VA = "0x12CBE80")]
	public string GetAppsFlyerUid()
	{
		return null;
	}

	// Token: 0x06000CDB RID: 3291 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CDB")]
	[Address(RVA = "0x12CBEE8", Offset = "0x12CBEE8", VA = "0x12CBEE8")]
	public void OnUploadPhoto(string uid, int code, int idx)
	{
	}

	// Token: 0x06000CDC RID: 3292 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CDC")]
	[Address(RVA = "0x12CC0EC", Offset = "0x12CC0EC", VA = "0x12CC0EC")]
	public void OnPickChatImage(int code, string cacheFolder)
	{
	}

	// Token: 0x06000CDD RID: 3293 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CDD")]
	[Address(RVA = "0x12CC304", Offset = "0x12CC304", VA = "0x12CC304")]
	public void SetGameUidToNative(string uid)
	{
	}

	// Token: 0x06000CDE RID: 3294 RVA: 0x00005D78 File Offset: 0x00003F78
	[Token(Token = "0x6000CDE")]
	[Address(RVA = "0x12CC484", Offset = "0x12CC484", VA = "0x12CC484")]
	public int GetDeviceVolume()
	{
		return 0;
	}

	// Token: 0x06000CDF RID: 3295 RVA: 0x00005D90 File Offset: 0x00003F90
	[Token(Token = "0x6000CDF")]
	[Address(RVA = "0x12CC5EC", Offset = "0x12CC5EC", VA = "0x12CC5EC")]
	public bool IsDeviceSilent()
	{
		return default(bool);
	}

	// Token: 0x06000CE0 RID: 3296 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CE0")]
	[Address(RVA = "0x12CC6F4", Offset = "0x12CC6F4", VA = "0x12CC6F4")]
	public void ReqAgeSignal()
	{
	}

	// Token: 0x04001073 RID: 4211
	[Token(Token = "0x4001073")]
	[FieldOffset(Offset = "0x10")]
	private Action<string, string> payCallback_;

	// Token: 0x04001074 RID: 4212
	[Token(Token = "0x4001074")]
	[FieldOffset(Offset = "0x18")]
	public string pf_displayname;

	// Token: 0x04001075 RID: 4213
	[Token(Token = "0x4001075")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<string, string> m_persistentData;

	// Token: 0x04001076 RID: 4214
	[Token(Token = "0x4001076")]
	[FieldOffset(Offset = "0x28")]
	private string m_buildTime;

	// Token: 0x0400107C RID: 4220
	[Token(Token = "0x400107C")]
	[FieldOffset(Offset = "0x58")]
	private readonly Dictionary<string, List<string>> m_Events;

	// Token: 0x0400107D RID: 4221
	[Token(Token = "0x400107D")]
	[FieldOffset(Offset = "0x60")]
	private StringWriter sw;

	// Token: 0x0400107E RID: 4222
	[Token(Token = "0x400107E")]
	[FieldOffset(Offset = "0x68")]
	private JsonWriter writer;

	// Token: 0x0400107F RID: 4223
	[Token(Token = "0x400107F")]
	[FieldOffset(Offset = "0x70")]
	private StringBuilder sb;
}
