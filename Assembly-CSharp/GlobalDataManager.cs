using System;
using Il2CppDummyDll;
using Sfs2X.Entities.Data;

// Token: 0x02000223 RID: 547
[Token(Token = "0x2000223")]
public class GlobalDataManager
{
	// Token: 0x06000E9D RID: 3741 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E9D")]
	[Address(RVA = "0x1229860", Offset = "0x1229860", VA = "0x1229860")]
	public GlobalDataManager()
	{
	}

	// Token: 0x06000E9E RID: 3742 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E9E")]
	[Address(RVA = "0x122996C", Offset = "0x122996C", VA = "0x122996C")]
	public void Init(ISFSObject dict)
	{
	}

	// Token: 0x06000E9F RID: 3743 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E9F")]
	[Address(RVA = "0x1229ABC", Offset = "0x1229ABC", VA = "0x1229ABC")]
	public void SetAnalyticID()
	{
	}

	// Token: 0x06000EA0 RID: 3744 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EA0")]
	[Address(RVA = "0x1229B24", Offset = "0x1229B24", VA = "0x1229B24")]
	public void recordGaid()
	{
	}

	// Token: 0x06000EA1 RID: 3745 RVA: 0x00006738 File Offset: 0x00004938
	[Token(Token = "0x6000EA1")]
	[Address(RVA = "0x1229CC0", Offset = "0x1229CC0", VA = "0x1229CC0")]
	public bool isGoogle()
	{
		return default(bool);
	}

	// Token: 0x06000EA2 RID: 3746 RVA: 0x00006750 File Offset: 0x00004950
	[Token(Token = "0x6000EA2")]
	[Address(RVA = "0x1229D0C", Offset = "0x1229D0C", VA = "0x1229D0C")]
	public bool isGoogleOnlyCheckAnalyticID()
	{
		return default(bool);
	}

	// Token: 0x06000EA3 RID: 3747 RVA: 0x00006768 File Offset: 0x00004968
	[Token(Token = "0x6000EA3")]
	[Address(RVA = "0x1229D14", Offset = "0x1229D14", VA = "0x1229D14")]
	public bool isChina()
	{
		return default(bool);
	}

	// Token: 0x06000EA4 RID: 3748 RVA: 0x00006780 File Offset: 0x00004980
	[Token(Token = "0x6000EA4")]
	[Address(RVA = "0x1229D1C", Offset = "0x1229D1C", VA = "0x1229D1C")]
	public bool isMiddleEast()
	{
		return default(bool);
	}

	// Token: 0x06000EA5 RID: 3749 RVA: 0x00006798 File Offset: 0x00004998
	[Token(Token = "0x6000EA5")]
	[Address(RVA = "0x1229D24", Offset = "0x1229D24", VA = "0x1229D24")]
	public bool isTencent()
	{
		return default(bool);
	}

	// Token: 0x06000EA6 RID: 3750 RVA: 0x000067B0 File Offset: 0x000049B0
	[Token(Token = "0x6000EA6")]
	[Address(RVA = "0x1229D2C", Offset = "0x1229D2C", VA = "0x1229D2C")]
	public bool isAmazon()
	{
		return default(bool);
	}

	// Token: 0x06000EA7 RID: 3751 RVA: 0x000067C8 File Offset: 0x000049C8
	[Token(Token = "0x6000EA7")]
	[Address(RVA = "0x1229D34", Offset = "0x1229D34", VA = "0x1229D34")]
	public bool isMol()
	{
		return default(bool);
	}

	// Token: 0x06000EA8 RID: 3752 RVA: 0x000067E0 File Offset: 0x000049E0
	[Token(Token = "0x6000EA8")]
	[Address(RVA = "0x1229D3C", Offset = "0x1229D3C", VA = "0x1229D3C")]
	public bool isMycard()
	{
		return default(bool);
	}

	// Token: 0x06000EA9 RID: 3753 RVA: 0x000067F8 File Offset: 0x000049F8
	[Token(Token = "0x6000EA9")]
	[Address(RVA = "0x1229D44", Offset = "0x1229D44", VA = "0x1229D44")]
	public bool isOnestore()
	{
		return default(bool);
	}

	// Token: 0x040011AF RID: 4527
	[Token(Token = "0x40011AF")]
	[FieldOffset(Offset = "0x10")]
	public bool isCN;

	// Token: 0x040011B0 RID: 4528
	[Token(Token = "0x40011B0")]
	[FieldOffset(Offset = "0x14")]
	public GlobalDataManager.LoginServerInfo loginServerInfo;

	// Token: 0x040011B1 RID: 4529
	[Token(Token = "0x40011B1")]
	[FieldOffset(Offset = "0x20")]
	public string gcmRegisterId;

	// Token: 0x040011B2 RID: 4530
	[Token(Token = "0x40011B2")]
	[FieldOffset(Offset = "0x28")]
	public string referrer;

	// Token: 0x040011B3 RID: 4531
	[Token(Token = "0x40011B3")]
	[FieldOffset(Offset = "0x30")]
	public string deeplinkParams;

	// Token: 0x040011B4 RID: 4532
	[Token(Token = "0x40011B4")]
	[FieldOffset(Offset = "0x38")]
	public string analyticID;

	// Token: 0x040011B5 RID: 4533
	[Token(Token = "0x40011B5")]
	[FieldOffset(Offset = "0x40")]
	public bool s_isGooglePlayAvailable;

	// Token: 0x040011B6 RID: 4534
	[Token(Token = "0x40011B6")]
	[FieldOffset(Offset = "0x48")]
	public string platformUID;

	// Token: 0x040011B7 RID: 4535
	[Token(Token = "0x40011B7")]
	[FieldOffset(Offset = "0x50")]
	public string parseRegisterId;

	// Token: 0x040011B8 RID: 4536
	[Token(Token = "0x40011B8")]
	[FieldOffset(Offset = "0x58")]
	public string fromCountry;

	// Token: 0x040011B9 RID: 4537
	[Token(Token = "0x40011B9")]
	[FieldOffset(Offset = "0x60")]
	public string gaid;

	// Token: 0x040011BA RID: 4538
	[Token(Token = "0x40011BA")]
	[FieldOffset(Offset = "0x68")]
	public string sysLang;

	// Token: 0x040011BB RID: 4539
	[Token(Token = "0x40011BB")]
	[FieldOffset(Offset = "0x70")]
	public string version;

	// Token: 0x040011BC RID: 4540
	[Token(Token = "0x40011BC")]
	[FieldOffset(Offset = "0x78")]
	public string uuid;

	// Token: 0x040011BD RID: 4541
	[Token(Token = "0x40011BD")]
	[FieldOffset(Offset = "0x80")]
	public string gaidCache;

	// Token: 0x040011BE RID: 4542
	[Token(Token = "0x40011BE")]
	[FieldOffset(Offset = "0x88")]
	public bool isUploadPic;

	// Token: 0x040011BF RID: 4543
	[Token(Token = "0x40011BF")]
	[FieldOffset(Offset = "0x8C")]
	public int serverType;

	// Token: 0x040011C0 RID: 4544
	[Token(Token = "0x40011C0")]
	[FieldOffset(Offset = "0x90")]
	public int serverMax;

	// Token: 0x040011C1 RID: 4545
	[Token(Token = "0x40011C1")]
	[FieldOffset(Offset = "0x94")]
	public int curSeasonPlayType;

	// Token: 0x040011C2 RID: 4546
	[Token(Token = "0x40011C2")]
	[FieldOffset(Offset = "0x98")]
	public bool pushOffWithQuitGame;

	// Token: 0x040011C3 RID: 4547
	[Token(Token = "0x40011C3")]
	[FieldOffset(Offset = "0x99")]
	public bool isInBackGround;

	// Token: 0x02000224 RID: 548
	[Token(Token = "0x2000224")]
	public struct LoginServerInfo
	{
		// Token: 0x040011C4 RID: 4548
		[Token(Token = "0x40011C4")]
		[FieldOffset(Offset = "0x0")]
		public int country;

		// Token: 0x040011C5 RID: 4549
		[Token(Token = "0x40011C5")]
		[FieldOffset(Offset = "0x4")]
		public int recommandCountry;
	}
}
