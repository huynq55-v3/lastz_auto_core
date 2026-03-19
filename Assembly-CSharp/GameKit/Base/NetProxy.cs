using System;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sfs2X;
using Sfs2X.Core;
using Sfs2X.Requests;

namespace GameKit.Base
{
	// Token: 0x020004F0 RID: 1264
	[Token(Token = "0x20004F0")]
	public class NetProxy : INetProxy
	{
		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06002647 RID: 9799 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002648 RID: 9800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005C5")]
		public string proxyName
		{
			[Token(Token = "0x6002647")]
			[Address(RVA = "0x2B5DC9C", Offset = "0x2B5DC9C", VA = "0x2B5DC9C", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002648")]
			[Address(RVA = "0x2B5DCA4", Offset = "0x2B5DCA4", VA = "0x2B5DCA4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06002649 RID: 9801 RVA: 0x0000E778 File Offset: 0x0000C978
		// (set) Token: 0x0600264A RID: 9802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005C6")]
		public ProxyStatus Status
		{
			[Token(Token = "0x6002649")]
			[Address(RVA = "0x2B5DCAC", Offset = "0x2B5DCAC", VA = "0x2B5DCAC", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return ProxyStatus.init;
			}
			[Token(Token = "0x600264A")]
			[Address(RVA = "0x2B5DCB4", Offset = "0x2B5DCB4", VA = "0x2B5DCB4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600264B RID: 9803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600264B")]
		[Address(RVA = "0x2B5DCBC", Offset = "0x2B5DCBC", VA = "0x2B5DCBC")]
		public NetProxy(string name, string h, int p, INetManager net)
		{
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x0600264C RID: 9804 RVA: 0x0000E790 File Offset: 0x0000C990
		[Token(Token = "0x170005C7")]
		public bool IsConnected
		{
			[Token(Token = "0x600264C")]
			[Address(RVA = "0x2B5DD94", Offset = "0x2B5DD94", VA = "0x2B5DD94", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x0600264D RID: 9805 RVA: 0x0000E7A8 File Offset: 0x0000C9A8
		[Token(Token = "0x170005C8")]
		public bool IsConnecting
		{
			[Token(Token = "0x600264D")]
			[Address(RVA = "0x2B5DDA8", Offset = "0x2B5DDA8", VA = "0x2B5DDA8", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600264E RID: 9806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600264E")]
		[Address(RVA = "0x2B5DDC8", Offset = "0x2B5DDC8", VA = "0x2B5DDC8")]
		private void initSmartFox()
		{
		}

		// Token: 0x0600264F RID: 9807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600264F")]
		[Address(RVA = "0x2B5E444", Offset = "0x2B5E444", VA = "0x2B5E444", Slot = "14")]
		public void UpdateSmartFoxClient()
		{
		}

		// Token: 0x06002650 RID: 9808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002650")]
		[Address(RVA = "0x2B5E684", Offset = "0x2B5E684", VA = "0x2B5E684", Slot = "7")]
		public void Connect()
		{
		}

		// Token: 0x06002651 RID: 9809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002651")]
		[Address(RVA = "0x2B5E878", Offset = "0x2B5E878", VA = "0x2B5E878")]
		private void OnConnection(BaseEvent e)
		{
		}

		// Token: 0x06002652 RID: 9810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002652")]
		[Address(RVA = "0x2B5EA0C", Offset = "0x2B5EA0C", VA = "0x2B5EA0C")]
		private void OnConnectionLost(BaseEvent evt)
		{
		}

		// Token: 0x06002653 RID: 9811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002653")]
		[Address(RVA = "0x2B5EB98", Offset = "0x2B5EB98", VA = "0x2B5EB98")]
		private void OnLogout(BaseEvent e)
		{
		}

		// Token: 0x06002654 RID: 9812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002654")]
		[Address(RVA = "0x2B5EC44", Offset = "0x2B5EC44", VA = "0x2B5EC44")]
		private void OnExtensionResponse(BaseEvent e)
		{
		}

		// Token: 0x06002655 RID: 9813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002655")]
		[Address(RVA = "0x2B5EC84", Offset = "0x2B5EC84", VA = "0x2B5EC84")]
		private void OnLogin(BaseEvent e)
		{
		}

		// Token: 0x06002656 RID: 9814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002656")]
		[Address(RVA = "0x2B5ED3C", Offset = "0x2B5ED3C", VA = "0x2B5ED3C")]
		private void OnLoginError(BaseEvent e)
		{
		}

		// Token: 0x06002657 RID: 9815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002657")]
		[Address(RVA = "0x2B5EDE8", Offset = "0x2B5EDE8", VA = "0x2B5EDE8")]
		private void OnPublicMessage(BaseEvent e)
		{
		}

		// Token: 0x06002658 RID: 9816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002658")]
		[Address(RVA = "0x2B5EDEC", Offset = "0x2B5EDEC", VA = "0x2B5EDEC")]
		private void OnLogError(BaseEvent e)
		{
		}

		// Token: 0x06002659 RID: 9817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002659")]
		[Address(RVA = "0x2B5EF98", Offset = "0x2B5EF98", VA = "0x2B5EF98")]
		private void OnRawSocketError(string error, SocketError se)
		{
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600265A")]
		[Address(RVA = "0x2B5F094", Offset = "0x2B5F094", VA = "0x2B5F094")]
		private void OnPingPong(BaseEvent evt)
		{
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600265B")]
		[Address(RVA = "0x2B5F0B0", Offset = "0x2B5F0B0", VA = "0x2B5F0B0")]
		private void OnSocketException(BaseEvent evt)
		{
		}

		// Token: 0x0600265C RID: 9820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600265C")]
		[Address(RVA = "0x2B5E780", Offset = "0x2B5E780", VA = "0x2B5E780", Slot = "11")]
		public void SyncPingPong(int time = -1)
		{
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x0600265D RID: 9821 RVA: 0x0000E7C0 File Offset: 0x0000C9C0
		[Token(Token = "0x170005C9")]
		public bool IsPingPongTimeOut
		{
			[Token(Token = "0x600265D")]
			[Address(RVA = "0x2B5F370", Offset = "0x2B5F370", VA = "0x2B5F370", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600265E RID: 9822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600265E")]
		[Address(RVA = "0x2B5F3C0", Offset = "0x2B5F3C0", VA = "0x2B5F3C0", Slot = "8")]
		public void Disconnect()
		{
		}

		// Token: 0x0600265F RID: 9823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600265F")]
		[Address(RVA = "0x2B5F78C", Offset = "0x2B5F78C", VA = "0x2B5F78C", Slot = "9")]
		public void Send(IRequest request)
		{
		}

		// Token: 0x06002660 RID: 9824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002660")]
		[Address(RVA = "0x2B5F7A0", Offset = "0x2B5F7A0", VA = "0x2B5F7A0", Slot = "10")]
		public void Send(byte[] data, int dataLen)
		{
		}

		// Token: 0x06002661 RID: 9825 RVA: 0x0000E7D8 File Offset: 0x0000C9D8
		[Token(Token = "0x6002661")]
		[Address(RVA = "0x2B5F7B4", Offset = "0x2B5F7B4", VA = "0x2B5F7B4")]
		public bool SendPingpong()
		{
			return default(bool);
		}

		// Token: 0x06002662 RID: 9826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002662")]
		[Address(RVA = "0x2B5F7E0", Offset = "0x2B5F7E0", VA = "0x2B5F7E0")]
		public void KillConnection()
		{
		}

		// Token: 0x06002663 RID: 9827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002663")]
		[Address(RVA = "0x2B5F7F4", Offset = "0x2B5F7F4", VA = "0x2B5F7F4", Slot = "15")]
		public string GetSessionToken()
		{
			return null;
		}

		// Token: 0x04002295 RID: 8853
		[Token(Token = "0x4002295")]
		[FieldOffset(Offset = "0x10")]
		private PingPongRequest _pingPongRequest;

		// Token: 0x04002296 RID: 8854
		[Token(Token = "0x4002296")]
		[FieldOffset(Offset = "0x18")]
		private float _sendPingPongCounter;

		// Token: 0x04002297 RID: 8855
		[Token(Token = "0x4002297")]
		[FieldOffset(Offset = "0x1C")]
		private float lastPingPongTime;

		// Token: 0x04002298 RID: 8856
		[Token(Token = "0x4002298")]
		[FieldOffset(Offset = "0x20")]
		public float _sendPingPongInterval;

		// Token: 0x04002299 RID: 8857
		[Token(Token = "0x4002299")]
		[FieldOffset(Offset = "0x24")]
		public int offMaxTime;

		// Token: 0x0400229B RID: 8859
		[Token(Token = "0x400229B")]
		[FieldOffset(Offset = "0x30")]
		private string host;

		// Token: 0x0400229C RID: 8860
		[Token(Token = "0x400229C")]
		[FieldOffset(Offset = "0x38")]
		private int port;

		// Token: 0x0400229D RID: 8861
		[Token(Token = "0x400229D")]
		[FieldOffset(Offset = "0x40")]
		private SmartFox m_Client;

		// Token: 0x0400229E RID: 8862
		[Token(Token = "0x400229E")]
		[FieldOffset(Offset = "0x48")]
		private INetManager parent;

		// Token: 0x0400229F RID: 8863
		[Token(Token = "0x400229F")]
		[FieldOffset(Offset = "0x50")]
		public bool sendToServer;
	}
}
