using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001DB RID: 475
[Token(Token = "0x20001DB")]
public class PlatformAndroid : AndroidJavaProxy, IPlatformNative
{
	// Token: 0x17000188 RID: 392
	// (get) Token: 0x06000C64 RID: 3172 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000188")]
	private AndroidJavaObject currentActivity
	{
		[Token(Token = "0x6000C64")]
		[Address(RVA = "0x12C4000", Offset = "0x12C4000", VA = "0x12C4000")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000C65 RID: 3173 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C65")]
	[Address(RVA = "0x12C4250", Offset = "0x12C4250", VA = "0x12C4250")]
	public PlatformAndroid(string listenerClassName)
	{
	}

	// Token: 0x06000C66 RID: 3174 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C66")]
	[Address(RVA = "0x12C42E8", Offset = "0x12C42E8", VA = "0x12C42E8")]
	public void Call(string funcName, params object[] args)
	{
	}

	// Token: 0x06000C67 RID: 3175 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C67")]
	[Address(RVA = "0x12C440C", Offset = "0x12C440C", VA = "0x12C440C")]
	public void SaveToCache(string key)
	{
	}

	// Token: 0x06000C68 RID: 3176 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C68")]
	public T Call<T>(string funcName, params object[] args)
	{
		return null;
	}

	// Token: 0x06000C69 RID: 3177 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C69")]
	[Address(RVA = "0x12C4410", Offset = "0x12C4410", VA = "0x12C4410")]
	public void CallStatic(string funcName, params object[] args)
	{
	}

	// Token: 0x06000C6A RID: 3178 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C6A")]
	public T CallStatic<T>(string funcName, params object[] args)
	{
		return null;
	}

	// Token: 0x06000C6B RID: 3179 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C6B")]
	public T Get<T>(string fieldName)
	{
		return null;
	}

	// Token: 0x06000C6C RID: 3180 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C6C")]
	public T GetStatic<T>(string fieldName)
	{
		return null;
	}

	// Token: 0x06000C6D RID: 3181 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C6D")]
	[Address(RVA = "0x12C4534", Offset = "0x12C4534", VA = "0x12C4534")]
	public void SendDataToGame(string funcName, string data)
	{
	}

	// Token: 0x06000C6E RID: 3182 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C6E")]
	[Address(RVA = "0x12C4828", Offset = "0x12C4828", VA = "0x12C4828")]
	public object GetDataFromGame(string funcName, string data)
	{
		return null;
	}

	// Token: 0x17000189 RID: 393
	// (get) Token: 0x06000C6F RID: 3183 RVA: 0x00005B98 File Offset: 0x00003D98
	// (set) Token: 0x06000C70 RID: 3184 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000189")]
	public bool HasSignedIn
	{
		[Token(Token = "0x6000C6F")]
		[Address(RVA = "0x12C4A8C", Offset = "0x12C4A8C", VA = "0x12C4A8C", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000C70")]
		[Address(RVA = "0x12C4A94", Offset = "0x12C4A94", VA = "0x12C4A94", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x1700018A RID: 394
	// (get) Token: 0x06000C71 RID: 3185 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000C72 RID: 3186 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700018A")]
	public string UID
	{
		[Token(Token = "0x6000C71")]
		[Address(RVA = "0x12C4AA0", Offset = "0x12C4AA0", VA = "0x12C4AA0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000C72")]
		[Address(RVA = "0x12C4AA8", Offset = "0x12C4AA8", VA = "0x12C4AA8", Slot = "12")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x1700018B RID: 395
	// (get) Token: 0x06000C73 RID: 3187 RVA: 0x00005BB0 File Offset: 0x00003DB0
	[Token(Token = "0x1700018B")]
	public GamePlatform ID
	{
		[Token(Token = "0x6000C73")]
		[Address(RVA = "0x12C4A84", Offset = "0x12C4A84", VA = "0x12C4A84", Slot = "13")]
		get
		{
			return GamePlatform.Default;
		}
	}

	// Token: 0x1700018C RID: 396
	// (get) Token: 0x06000C74 RID: 3188 RVA: 0x00005BC8 File Offset: 0x00003DC8
	[Token(Token = "0x1700018C")]
	public PaymentChannel PaymentChannel
	{
		[Token(Token = "0x6000C74")]
		[Address(RVA = "0x12C4AB0", Offset = "0x12C4AB0", VA = "0x12C4AB0", Slot = "14")]
		get
		{
			return PaymentChannel.Default;
		}
	}

	// Token: 0x1700018D RID: 397
	// (get) Token: 0x06000C75 RID: 3189 RVA: 0x00005BE0 File Offset: 0x00003DE0
	// (set) Token: 0x06000C76 RID: 3190 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700018D")]
	public LoginPlatform LoginPlatform
	{
		[Token(Token = "0x6000C75")]
		[Address(RVA = "0x12C4AB8", Offset = "0x12C4AB8", VA = "0x12C4AB8", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return LoginPlatform.GameCenter;
		}
		[Token(Token = "0x6000C76")]
		[Address(RVA = "0x12C4AC0", Offset = "0x12C4AC0", VA = "0x12C4AC0", Slot = "16")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x06000C77 RID: 3191 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C77")]
	[Address(RVA = "0x12C4AC8", Offset = "0x12C4AC8", VA = "0x12C4AC8", Slot = "23")]
	public void SendDataToNative(string funcName, string data)
	{
	}

	// Token: 0x06000C78 RID: 3192 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C78")]
	[Address(RVA = "0x12C4C18", Offset = "0x12C4C18", VA = "0x12C4C18", Slot = "24")]
	public string GetDataFromNative(string funcName, string data)
	{
		return null;
	}

	// Token: 0x06000C79 RID: 3193 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C79")]
	[Address(RVA = "0x12C4DD4", Offset = "0x12C4DD4", VA = "0x12C4DD4", Slot = "25")]
	public string GetPermissionByType(string data)
	{
		return null;
	}

	// Token: 0x06000C7A RID: 3194 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C7A")]
	[Address(RVA = "0x12C4E2C", Offset = "0x12C4E2C", VA = "0x12C4E2C", Slot = "17")]
	public void InitPlatform(string proxyName)
	{
	}

	// Token: 0x06000C7B RID: 3195 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C7B")]
	[Address(RVA = "0x12C4F24", Offset = "0x12C4F24", VA = "0x12C4F24", Slot = "18")]
	public void SignIn(string json)
	{
	}

	// Token: 0x06000C7C RID: 3196 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C7C")]
	[Address(RVA = "0x12C4FE8", Offset = "0x12C4FE8", VA = "0x12C4FE8", Slot = "19")]
	public void SignOut()
	{
	}

	// Token: 0x06000C7D RID: 3197 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C7D")]
	[Address(RVA = "0x12C5084", Offset = "0x12C5084", VA = "0x12C5084", Slot = "20")]
	public void Pay(int channelId, string json)
	{
	}

	// Token: 0x06000C7E RID: 3198 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C7E")]
	[Address(RVA = "0x12C51B4", Offset = "0x12C51B4", VA = "0x12C51B4", Slot = "21")]
	public void QueryPurchaseOrder()
	{
	}

	// Token: 0x06000C7F RID: 3199 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C7F")]
	[Address(RVA = "0x12C521C", Offset = "0x12C521C", VA = "0x12C521C", Slot = "22")]
	public void ConsumeProduct(string orderId, int status)
	{
	}

	// Token: 0x0400106C RID: 4204
	[Token(Token = "0x400106C")]
	[FieldOffset(Offset = "0x20")]
	private AndroidJavaObject currentActivity_;

	// Token: 0x0400106D RID: 4205
	[Token(Token = "0x400106D")]
	public const string GOOGLE_PUBLIC_KEY = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAjnC2tvJsZyHzXlAg5RpiBEHso5k3BRcAp42K2PMgNAB0ebz4vt8VPbO+Uuj45jwLVobVusdmEOmCM8N65IrHdkP0/5x9bLy0KpNH3Efik+wjEglj+xwrAotX106emktjT+iXnIMTdPzwT3TnzsRv3R5ny9klJHhr7G/BlLjFCx6a7EJt40UEqMHXUQXBN8FaXGXCpI0UVAEkmBxoG2WYA+jlO5yEpoaUdupl65VElj/LiUtPHdXRa9hKMDvx/ti6EJI8CDQgGgS6O8OcighhBrk8WI39bcnkYtHk3Y1S2HgLwdwALM6ITBQHyDst/ZDMOexR5bGKX/k+eiOE3QDnFQIDAQAB";

	// Token: 0x0400106E RID: 4206
	[Token(Token = "0x400106E")]
	public const string BUGLY_KEY = "f550d68ac8";

	// Token: 0x0400106F RID: 4207
	[Token(Token = "0x400106F")]
	[FieldOffset(Offset = "0x28")]
	private object[] args_;
}
