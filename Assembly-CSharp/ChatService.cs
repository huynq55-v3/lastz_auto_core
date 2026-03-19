using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200020A RID: 522
[Token(Token = "0x200020A")]
public class ChatService
{
	// Token: 0x06000E02 RID: 3586 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E02")]
	[Address(RVA = "0x121BD60", Offset = "0x121BD60", VA = "0x121BD60")]
	private ChatService()
	{
	}

	// Token: 0x170001AF RID: 431
	// (get) Token: 0x06000E03 RID: 3587 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001AF")]
	public static ChatService Instance
	{
		[Token(Token = "0x6000E03")]
		[Address(RVA = "0x121BDB8", Offset = "0x121BDB8", VA = "0x121BDB8")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000E04 RID: 3588 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E04")]
	[Address(RVA = "0x121BF4C", Offset = "0x121BF4C", VA = "0x121BF4C")]
	public void Init(string chat_app_id, string playerUid, Action<string, string, int> callback)
	{
	}

	// Token: 0x06000E05 RID: 3589 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E05")]
	[Address(RVA = "0x121C088", Offset = "0x121C088", VA = "0x121C088")]
	public void Uninit()
	{
	}

	// Token: 0x06000E06 RID: 3590 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E06")]
	[Address(RVA = "0x121C0EC", Offset = "0x121C0EC", VA = "0x121C0EC")]
	public void SetMinMaxThreads(int min, int max)
	{
	}

	// Token: 0x06000E07 RID: 3591 RVA: 0x00006450 File Offset: 0x00004650
	[Token(Token = "0x6000E07")]
	[Address(RVA = "0x121C1FC", Offset = "0x121C1FC", VA = "0x121C1FC")]
	public bool RequestServerList(string url, int ud)
	{
		return default(bool);
	}

	// Token: 0x06000E08 RID: 3592 RVA: 0x00006468 File Offset: 0x00004668
	[Token(Token = "0x6000E08")]
	[Address(RVA = "0x121C550", Offset = "0x121C550", VA = "0x121C550")]
	public bool Connect(string protocol, string ip, int port)
	{
		return default(bool);
	}

	// Token: 0x06000E09 RID: 3593 RVA: 0x00006480 File Offset: 0x00004680
	[Token(Token = "0x6000E09")]
	[Address(RVA = "0x121C630", Offset = "0x121C630", VA = "0x121C630")]
	public bool ConnectWithCode(string protocol, string ip, int port, int code)
	{
		return default(bool);
	}

	// Token: 0x06000E0A RID: 3594 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E0A")]
	[Address(RVA = "0x121C0A8", Offset = "0x121C0A8", VA = "0x121C0A8")]
	public void Disconnect()
	{
	}

	// Token: 0x06000E0B RID: 3595 RVA: 0x00006498 File Offset: 0x00004698
	[Token(Token = "0x6000E0B")]
	[Address(RVA = "0x121C714", Offset = "0x121C714", VA = "0x121C714")]
	public bool IsConnected()
	{
		return default(bool);
	}

	// Token: 0x06000E0C RID: 3596 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E0C")]
	[Address(RVA = "0x121C744", Offset = "0x121C744", VA = "0x121C744")]
	public void OnUpdate()
	{
	}

	// Token: 0x06000E0D RID: 3597 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E0D")]
	[Address(RVA = "0x121C75C", Offset = "0x121C75C", VA = "0x121C75C")]
	public void SendLuaMessage(string jsonMsg)
	{
	}

	// Token: 0x06000E0E RID: 3598 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E0E")]
	[Address(RVA = "0x121C774", Offset = "0x121C774", VA = "0x121C774")]
	public void RequestTranslate(string uri, string postParams, Action<string, string> cb)
	{
	}

	// Token: 0x06000E0F RID: 3599 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E0F")]
	[Address(RVA = "0x121C8E4", Offset = "0x121C8E4", VA = "0x121C8E4")]
	public void RequestTranslate(string uri, Dictionary<string, string> postParams, Action<string, string> cb)
	{
	}

	// Token: 0x04001155 RID: 4437
	[Token(Token = "0x4001155")]
	[FieldOffset(Offset = "0x0")]
	private static ChatService _instance;

	// Token: 0x04001156 RID: 4438
	[Token(Token = "0x4001156")]
	[FieldOffset(Offset = "0x8")]
	private static readonly object _lock;

	// Token: 0x04001157 RID: 4439
	[Token(Token = "0x4001157")]
	[FieldOffset(Offset = "0x10")]
	private int WSItemCount;

	// Token: 0x04001158 RID: 4440
	[Token(Token = "0x4001158")]
	[FieldOffset(Offset = "0x18")]
	private WebSocketItemBase curWebSocket;

	// Token: 0x04001159 RID: 4441
	[Token(Token = "0x4001159")]
	[FieldOffset(Offset = "0x20")]
	private string CHAT_APP_ID;

	// Token: 0x0400115A RID: 4442
	[Token(Token = "0x400115A")]
	[FieldOffset(Offset = "0x28")]
	private Action<string, string, int> callback_;

	// Token: 0x0400115B RID: 4443
	[Token(Token = "0x400115B")]
	[FieldOffset(Offset = "0x30")]
	private string cur_player_uid_;

	// Token: 0x0400115C RID: 4444
	[Token(Token = "0x400115C")]
	[FieldOffset(Offset = "0x10")]
	public static int USE_BESTHTTP_3;
}
