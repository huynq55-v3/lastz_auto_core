using System;
using Il2CppDummyDll;
using Sfs2X.Requests;

namespace GameKit.Base
{
	// Token: 0x020004EE RID: 1262
	[Token(Token = "0x20004EE")]
	public interface INetProxy
	{
		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x0600263B RID: 9787
		[Token(Token = "0x170005C0")]
		string proxyName
		{
			[Token(Token = "0x600263B")]
			get;
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x0600263C RID: 9788
		[Token(Token = "0x170005C1")]
		bool IsConnected
		{
			[Token(Token = "0x600263C")]
			get;
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x0600263D RID: 9789
		[Token(Token = "0x170005C2")]
		bool IsConnecting
		{
			[Token(Token = "0x600263D")]
			get;
		}

		// Token: 0x0600263E RID: 9790
		[Token(Token = "0x600263E")]
		void Connect();

		// Token: 0x0600263F RID: 9791
		[Token(Token = "0x600263F")]
		void Disconnect();

		// Token: 0x06002640 RID: 9792
		[Token(Token = "0x6002640")]
		void Send(IRequest request);

		// Token: 0x06002641 RID: 9793
		[Token(Token = "0x6002641")]
		void Send(byte[] data, int dataLen);

		// Token: 0x06002642 RID: 9794
		[Token(Token = "0x6002642")]
		void SyncPingPong(int time = -1);

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06002643 RID: 9795
		[Token(Token = "0x170005C3")]
		bool IsPingPongTimeOut
		{
			[Token(Token = "0x6002643")]
			get;
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06002644 RID: 9796
		[Token(Token = "0x170005C4")]
		ProxyStatus Status
		{
			[Token(Token = "0x6002644")]
			get;
		}

		// Token: 0x06002645 RID: 9797
		[Token(Token = "0x6002645")]
		void UpdateSmartFoxClient();

		// Token: 0x06002646 RID: 9798
		[Token(Token = "0x6002646")]
		string GetSessionToken();
	}
}
