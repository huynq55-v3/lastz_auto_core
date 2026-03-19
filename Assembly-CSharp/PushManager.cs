using System;
using Il2CppDummyDll;

// Token: 0x0200022E RID: 558
[Token(Token = "0x200022E")]
public class PushManager
{
	// Token: 0x170001C0 RID: 448
	// (get) Token: 0x06000EEC RID: 3820 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001C0")]
	public static PushManager Instance
	{
		[Token(Token = "0x6000EEC")]
		[Address(RVA = "0x122E75C", Offset = "0x122E75C", VA = "0x122E75C")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000EED RID: 3821 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EED")]
	[Address(RVA = "0x122E848", Offset = "0x122E848", VA = "0x122E848")]
	public static void Purge()
	{
	}

	// Token: 0x06000EEE RID: 3822 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EEE")]
	[Address(RVA = "0x122E7E8", Offset = "0x122E7E8", VA = "0x122E7E8")]
	private PushManager()
	{
	}

	// Token: 0x06000EEF RID: 3823 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EEF")]
	[Address(RVA = "0x122E89C", Offset = "0x122E89C", VA = "0x122E89C")]
	public void reqFcmTokenMessage(string regParseId)
	{
	}

	// Token: 0x06000EF0 RID: 3824 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF0")]
	[Address(RVA = "0x122EA44", Offset = "0x122EA44", VA = "0x122EA44")]
	public void registerdAccount(string strPlatform, string strUserId, string strChannelId)
	{
	}

	// Token: 0x06000EF1 RID: 3825 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF1")]
	[Address(RVA = "0x122EB50", Offset = "0x122EB50", VA = "0x122EB50")]
	public void registerdParseAccount(string strParseId, string strPlatform)
	{
	}

	// Token: 0x06000EF2 RID: 3826 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF2")]
	[Address(RVA = "0x122EB88", Offset = "0x122EB88", VA = "0x122EB88")]
	public void SetFireBaseId(string firebaseId)
	{
	}

	// Token: 0x06000EF3 RID: 3827 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF3")]
	[Address(RVA = "0x122EBA4", Offset = "0x122EBA4", VA = "0x122EBA4")]
	public void onLoginComplete()
	{
	}

	// Token: 0x06000EF4 RID: 3828 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF4")]
	[Address(RVA = "0x122EA90", Offset = "0x122EA90", VA = "0x122EA90")]
	private void asyncAccount()
	{
	}

	// Token: 0x06000EF5 RID: 3829 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF5")]
	[Address(RVA = "0x122EBB0", Offset = "0x122EBB0", VA = "0x122EBB0")]
	public void pushFirMessaging()
	{
	}

	// Token: 0x06000EF6 RID: 3830 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF6")]
	[Address(RVA = "0x122EC50", Offset = "0x122EC50", VA = "0x122EC50")]
	public void CancelNotice(int type)
	{
	}

	// Token: 0x06000EF7 RID: 3831 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF7")]
	[Address(RVA = "0x122EC54", Offset = "0x122EC54", VA = "0x122EC54")]
	public void recordPushData()
	{
	}

	// Token: 0x06000EF8 RID: 3832 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF8")]
	[Address(RVA = "0x122EE00", Offset = "0x122EE00", VA = "0x122EE00")]
	public void clearPushCache()
	{
	}

	// Token: 0x06000EF9 RID: 3833 RVA: 0x00006960 File Offset: 0x00004B60
	[Token(Token = "0x6000EF9")]
	[Address(RVA = "0x122EEF8", Offset = "0x122EEF8", VA = "0x122EEF8")]
	public long GetCurrentTimeUnix()
	{
		return 0L;
	}

	// Token: 0x06000EFA RID: 3834 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EFA")]
	[Address(RVA = "0x122F000", Offset = "0x122F000", VA = "0x122F000")]
	public void pushDataToHttpServer()
	{
	}

	// Token: 0x040011DC RID: 4572
	[Token(Token = "0x40011DC")]
	[FieldOffset(Offset = "0x10")]
	private bool connected;

	// Token: 0x040011DD RID: 4573
	[Token(Token = "0x40011DD")]
	[FieldOffset(Offset = "0x18")]
	private string platform;

	// Token: 0x040011DE RID: 4574
	[Token(Token = "0x40011DE")]
	[FieldOffset(Offset = "0x20")]
	private string userId;

	// Token: 0x040011DF RID: 4575
	[Token(Token = "0x40011DF")]
	[FieldOffset(Offset = "0x28")]
	private string channelId;

	// Token: 0x040011E0 RID: 4576
	[Token(Token = "0x40011E0")]
	[FieldOffset(Offset = "0x30")]
	private string parseId;

	// Token: 0x040011E1 RID: 4577
	[Token(Token = "0x40011E1")]
	[FieldOffset(Offset = "0x38")]
	private bool openGiftPage;

	// Token: 0x040011E2 RID: 4578
	[Token(Token = "0x40011E2")]
	[FieldOffset(Offset = "0x39")]
	private bool initFlag;

	// Token: 0x040011E3 RID: 4579
	[Token(Token = "0x40011E3")]
	[FieldOffset(Offset = "0x40")]
	public string firebaseAppId;

	// Token: 0x040011E4 RID: 4580
	[Token(Token = "0x40011E4")]
	[FieldOffset(Offset = "0x0")]
	private static PushManager _instance;
}
