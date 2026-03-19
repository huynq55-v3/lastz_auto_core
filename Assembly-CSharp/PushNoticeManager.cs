using System;
using Il2CppDummyDll;

// Token: 0x02000173 RID: 371
[Token(Token = "0x2000173")]
public class PushNoticeManager
{
	// Token: 0x06000A9B RID: 2715 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A9B")]
	[Address(RVA = "0x37194D0", Offset = "0x37194D0", VA = "0x37194D0")]
	public static void PushNotice(string noticeJson)
	{
	}

	// Token: 0x06000A9C RID: 2716 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A9C")]
	[Address(RVA = "0x371957C", Offset = "0x371957C", VA = "0x371957C")]
	public static void CancelNotice(string typeJson)
	{
	}

	// Token: 0x06000A9D RID: 2717 RVA: 0x00005478 File Offset: 0x00003678
	[Token(Token = "0x6000A9D")]
	[Address(RVA = "0x3719620", Offset = "0x3719620", VA = "0x3719620")]
	public static int GetPushCountById(string pushId)
	{
		return 0;
	}

	// Token: 0x06000A9E RID: 2718 RVA: 0x00005490 File Offset: 0x00003690
	[Token(Token = "0x6000A9E")]
	[Address(RVA = "0x37197DC", Offset = "0x37197DC", VA = "0x37197DC")]
	public static int GetPushSecondTimeById(string pushId)
	{
		return 0;
	}

	// Token: 0x06000A9F RID: 2719 RVA: 0x000054A8 File Offset: 0x000036A8
	[Token(Token = "0x6000A9F")]
	[Address(RVA = "0x37199DC", Offset = "0x37199DC", VA = "0x37199DC")]
	public static bool GetIsNotifyOpen()
	{
		return default(bool);
	}

	// Token: 0x06000AA0 RID: 2720 RVA: 0x000054C0 File Offset: 0x000036C0
	[Token(Token = "0x6000AA0")]
	[Address(RVA = "0x3719B38", Offset = "0x3719B38", VA = "0x3719B38")]
	public static bool GetIsLocalNotifyOpen()
	{
		return default(bool);
	}

	// Token: 0x06000AA1 RID: 2721 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA1")]
	[Address(RVA = "0x3719C94", Offset = "0x3719C94", VA = "0x3719C94")]
	public static void RequestLocalNotifyPermit()
	{
	}

	// Token: 0x06000AA2 RID: 2722 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA2")]
	[Address(RVA = "0x3719DC0", Offset = "0x3719DC0", VA = "0x3719DC0")]
	public static void RequestNotifyPermit()
	{
	}

	// Token: 0x06000AA3 RID: 2723 RVA: 0x000054D8 File Offset: 0x000036D8
	[Token(Token = "0x6000AA3")]
	[Address(RVA = "0x3719EF0", Offset = "0x3719EF0", VA = "0x3719EF0")]
	public static long GetCurrentTimeUnix()
	{
		return 0L;
	}

	// Token: 0x06000AA4 RID: 2724 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA4")]
	[Address(RVA = "0x3719FF8", Offset = "0x3719FF8", VA = "0x3719FF8")]
	public static void pushDataToHttpServer()
	{
	}

	// Token: 0x06000AA5 RID: 2725 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA5")]
	[Address(RVA = "0x371A5D4", Offset = "0x371A5D4", VA = "0x371A5D4")]
	public PushNoticeManager()
	{
	}
}
