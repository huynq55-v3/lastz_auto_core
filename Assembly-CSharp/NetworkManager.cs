using System;
using GameKit.Base;
using Il2CppDummyDll;
using Main.Scripts.Network;
using Sfs2X.Core;
using Sfs2X.Requests;

// Token: 0x0200022B RID: 555
[Token(Token = "0x200022B")]
public class NetworkManager : IGameController, INetManager
{
	// Token: 0x06000EC0 RID: 3776 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EC0")]
	[Address(RVA = "0x122B3B8", Offset = "0x122B3B8", VA = "0x122B3B8")]
	public NetworkManager()
	{
	}

	// Token: 0x06000EC1 RID: 3777 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EC1")]
	[Address(RVA = "0x122B470", Offset = "0x122B470", VA = "0x122B470")]
	public string GetGameServerUrl()
	{
		return null;
	}

	// Token: 0x06000EC2 RID: 3778 RVA: 0x00006840 File Offset: 0x00004A40
	[Token(Token = "0x6000EC2")]
	[Address(RVA = "0x122B4FC", Offset = "0x122B4FC", VA = "0x122B4FC")]
	public int GetGameServerPort()
	{
		return 0;
	}

	// Token: 0x06000EC3 RID: 3779 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EC3")]
	[Address(RVA = "0x122B588", Offset = "0x122B588", VA = "0x122B588")]
	public string GetUid()
	{
		return null;
	}

	// Token: 0x06000EC4 RID: 3780 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EC4")]
	[Address(RVA = "0x122B614", Offset = "0x122B614", VA = "0x122B614", Slot = "4")]
	public void OnUpdate(float elapseSeconds)
	{
	}

	// Token: 0x06000EC5 RID: 3781 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EC5")]
	[Address(RVA = "0x122B68C", Offset = "0x122B68C", VA = "0x122B68C", Slot = "5")]
	public void Shutdown()
	{
	}

	// Token: 0x06000EC6 RID: 3782 RVA: 0x00006858 File Offset: 0x00004A58
	[Token(Token = "0x6000EC6")]
	[Address(RVA = "0x122B6F4", Offset = "0x122B6F4", VA = "0x122B6F4")]
	public int GetWorldParseVersion()
	{
		return 0;
	}

	// Token: 0x06000EC7 RID: 3783 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EC7")]
	[Address(RVA = "0x122B6FC", Offset = "0x122B6FC", VA = "0x122B6FC")]
	public void StartWorldParseThread(string parseCodeStr)
	{
	}

	// Token: 0x06000EC8 RID: 3784 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EC8")]
	[Address(RVA = "0x122B790", Offset = "0x122B790", VA = "0x122B790")]
	public FutureManager getFutureManager()
	{
		return null;
	}

	// Token: 0x06000EC9 RID: 3785 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EC9")]
	[Address(RVA = "0x122B798", Offset = "0x122B798", VA = "0x122B798")]
	public string getCurLine()
	{
		return null;
	}

	// Token: 0x06000ECA RID: 3786 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ECA")]
	[Address(RVA = "0x122B858", Offset = "0x122B858", VA = "0x122B858")]
	public string GetSessionToken()
	{
		return null;
	}

	// Token: 0x06000ECB RID: 3787 RVA: 0x00006870 File Offset: 0x00004A70
	[Token(Token = "0x6000ECB")]
	[Address(RVA = "0x122B924", Offset = "0x122B924", VA = "0x122B924")]
	public static bool GetTcpNoDelay()
	{
		return default(bool);
	}

	// Token: 0x06000ECC RID: 3788 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ECC")]
	[Address(RVA = "0x122B9AC", Offset = "0x122B9AC", VA = "0x122B9AC")]
	public static void SetTcpNoDelay(bool b)
	{
	}

	// Token: 0x06000ECD RID: 3789 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ECD")]
	[Address(RVA = "0x122BA3C", Offset = "0x122BA3C", VA = "0x122BA3C")]
	public static void SetUseAsyncTcp(int t)
	{
	}

	// Token: 0x06000ECE RID: 3790 RVA: 0x00006888 File Offset: 0x00004A88
	[Token(Token = "0x6000ECE")]
	[Address(RVA = "0x122BAC8", Offset = "0x122BAC8", VA = "0x122BAC8")]
	public static int GetUseAsyncTcp()
	{
		return 0;
	}

	// Token: 0x06000ECF RID: 3791 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ECF")]
	[Address(RVA = "0x122BB50", Offset = "0x122BB50", VA = "0x122BB50")]
	public void SetCurProxy(INetProxy curProxy)
	{
	}

	// Token: 0x06000ED0 RID: 3792 RVA: 0x000068A0 File Offset: 0x00004AA0
	[Token(Token = "0x6000ED0")]
	[Address(RVA = "0x122BCC0", Offset = "0x122BCC0", VA = "0x122BCC0")]
	public bool IsConnected()
	{
		return default(bool);
	}

	// Token: 0x06000ED1 RID: 3793 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED1")]
	[Address(RVA = "0x122BD70", Offset = "0x122BD70", VA = "0x122BD70")]
	public void Send(IRequest request)
	{
	}

	// Token: 0x06000ED2 RID: 3794 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED2")]
	[Address(RVA = "0x122BE64", Offset = "0x122BE64", VA = "0x122BE64")]
	public void SendLuaMessage(string msgId, byte[] sfsObjBinary)
	{
	}

	// Token: 0x06000ED3 RID: 3795 RVA: 0x000068B8 File Offset: 0x00004AB8
	[Token(Token = "0x6000ED3")]
	[Address(RVA = "0x122BF90", Offset = "0x122BF90", VA = "0x122BF90")]
	public bool SendLuaMessageEx()
	{
		return default(bool);
	}

	// Token: 0x06000ED4 RID: 3796 RVA: 0x000068D0 File Offset: 0x00004AD0
	[Token(Token = "0x6000ED4")]
	[Address(RVA = "0x122C41C", Offset = "0x122C41C", VA = "0x122C41C", Slot = "6")]
	public bool OnConnection(INetProxy proxy, BaseEvent e)
	{
		return default(bool);
	}

	// Token: 0x06000ED5 RID: 3797 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED5")]
	[Address(RVA = "0x122CC50", Offset = "0x122CC50", VA = "0x122CC50", Slot = "7")]
	public void OnConnectionLost(string reason, INetProxy proxy)
	{
	}

	// Token: 0x06000ED6 RID: 3798 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED6")]
	[Address(RVA = "0x122CEA4", Offset = "0x122CEA4", VA = "0x122CEA4", Slot = "9")]
	public void OnLogin(BaseEvent e)
	{
	}

	// Token: 0x06000ED7 RID: 3799 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED7")]
	[Address(RVA = "0x122D158", Offset = "0x122D158", VA = "0x122D158", Slot = "10")]
	public void OnLoginError(BaseEvent e)
	{
	}

	// Token: 0x06000ED8 RID: 3800 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED8")]
	[Address(RVA = "0x122D5BC", Offset = "0x122D5BC", VA = "0x122D5BC", Slot = "8")]
	public void OnLogout(BaseEvent e)
	{
	}

	// Token: 0x040011CB RID: 4555
	[Token(Token = "0x40011CB")]
	[FieldOffset(Offset = "0x10")]
	private byte[] send_buffer;

	// Token: 0x040011CC RID: 4556
	[Token(Token = "0x40011CC")]
	[FieldOffset(Offset = "0x18")]
	private bool worldParseThreadStart;

	// Token: 0x040011CD RID: 4557
	[Token(Token = "0x40011CD")]
	[FieldOffset(Offset = "0x20")]
	private readonly FutureManager _futureManager;

	// Token: 0x040011CE RID: 4558
	[Token(Token = "0x40011CE")]
	[FieldOffset(Offset = "0x28")]
	private INetProxy _curProxyCache;
}
