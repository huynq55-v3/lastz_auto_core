using System;
using Il2CppDummyDll;

// Token: 0x020001D6 RID: 470
[Token(Token = "0x20001D6")]
public interface IPlatformNative
{
	// Token: 0x17000183 RID: 387
	// (get) Token: 0x06000C52 RID: 3154
	// (set) Token: 0x06000C53 RID: 3155
	[Token(Token = "0x17000183")]
	bool HasSignedIn
	{
		[Token(Token = "0x6000C52")]
		get;
		[Token(Token = "0x6000C53")]
		set;
	}

	// Token: 0x17000184 RID: 388
	// (get) Token: 0x06000C54 RID: 3156
	// (set) Token: 0x06000C55 RID: 3157
	[Token(Token = "0x17000184")]
	string UID
	{
		[Token(Token = "0x6000C54")]
		get;
		[Token(Token = "0x6000C55")]
		set;
	}

	// Token: 0x17000185 RID: 389
	// (get) Token: 0x06000C56 RID: 3158
	[Token(Token = "0x17000185")]
	GamePlatform ID
	{
		[Token(Token = "0x6000C56")]
		get;
	}

	// Token: 0x17000186 RID: 390
	// (get) Token: 0x06000C57 RID: 3159
	[Token(Token = "0x17000186")]
	PaymentChannel PaymentChannel
	{
		[Token(Token = "0x6000C57")]
		get;
	}

	// Token: 0x17000187 RID: 391
	// (get) Token: 0x06000C58 RID: 3160
	// (set) Token: 0x06000C59 RID: 3161
	[Token(Token = "0x17000187")]
	LoginPlatform LoginPlatform
	{
		[Token(Token = "0x6000C58")]
		get;
		[Token(Token = "0x6000C59")]
		set;
	}

	// Token: 0x06000C5A RID: 3162
	[Token(Token = "0x6000C5A")]
	void InitPlatform(string proxyName);

	// Token: 0x06000C5B RID: 3163
	[Token(Token = "0x6000C5B")]
	void SignIn(string json);

	// Token: 0x06000C5C RID: 3164
	[Token(Token = "0x6000C5C")]
	void SignOut();

	// Token: 0x06000C5D RID: 3165
	[Token(Token = "0x6000C5D")]
	void Pay(int channelId, string json);

	// Token: 0x06000C5E RID: 3166
	[Token(Token = "0x6000C5E")]
	void QueryPurchaseOrder();

	// Token: 0x06000C5F RID: 3167
	[Token(Token = "0x6000C5F")]
	void ConsumeProduct(string orderId, int status);

	// Token: 0x06000C60 RID: 3168
	[Token(Token = "0x6000C60")]
	void SendDataToNative(string funcName, string data);

	// Token: 0x06000C61 RID: 3169
	[Token(Token = "0x6000C61")]
	string GetDataFromNative(string funcName, string data);

	// Token: 0x06000C62 RID: 3170
	[Token(Token = "0x6000C62")]
	string GetPermissionByType(string data);
}
