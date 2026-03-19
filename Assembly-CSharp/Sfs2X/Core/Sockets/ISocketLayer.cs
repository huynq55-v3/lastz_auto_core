using System;
using Il2CppDummyDll;

namespace Sfs2X.Core.Sockets
{
	// Token: 0x02000A8C RID: 2700
	[Token(Token = "0x2000A8C")]
	public interface ISocketLayer
	{
		// Token: 0x060066F1 RID: 26353
		[Token(Token = "0x60066F1")]
		void Connect(string host, int port);

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x060066F2 RID: 26354
		[Token(Token = "0x170006DA")]
		bool IsConnected
		{
			[Token(Token = "0x60066F2")]
			get;
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x060066F3 RID: 26355
		[Token(Token = "0x170006DB")]
		bool RequiresConnection
		{
			[Token(Token = "0x60066F3")]
			get;
		}

		// Token: 0x060066F4 RID: 26356
		[Token(Token = "0x60066F4")]
		void Disconnect();

		// Token: 0x060066F5 RID: 26357
		[Token(Token = "0x60066F5")]
		void Disconnect(string reason);

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x060066F6 RID: 26358
		// (set) Token: 0x060066F7 RID: 26359
		[Token(Token = "0x170006DC")]
		ConnectionDelegate OnConnect
		{
			[Token(Token = "0x60066F6")]
			get;
			[Token(Token = "0x60066F7")]
			set;
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x060066F8 RID: 26360
		// (set) Token: 0x060066F9 RID: 26361
		[Token(Token = "0x170006DD")]
		ConnectionDelegate OnDisconnect
		{
			[Token(Token = "0x60066F8")]
			get;
			[Token(Token = "0x60066F9")]
			set;
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x060066FA RID: 26362
		// (set) Token: 0x060066FB RID: 26363
		[Token(Token = "0x170006DE")]
		OnCumstomDataDelegate OnCustomData
		{
			[Token(Token = "0x60066FA")]
			get;
			[Token(Token = "0x60066FB")]
			set;
		}

		// Token: 0x060066FC RID: 26364
		[Token(Token = "0x60066FC")]
		void Write(byte[] data, int offset, int length);

		// Token: 0x060066FD RID: 26365
		[Token(Token = "0x60066FD")]
		void Write(string data);

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x060066FE RID: 26366
		// (set) Token: 0x060066FF RID: 26367
		[Token(Token = "0x170006DF")]
		OnDataDelegate OnData
		{
			[Token(Token = "0x60066FE")]
			get;
			[Token(Token = "0x60066FF")]
			set;
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06006700 RID: 26368
		// (set) Token: 0x06006701 RID: 26369
		[Token(Token = "0x170006E0")]
		OnStringDataDelegate OnStringData
		{
			[Token(Token = "0x6006700")]
			get;
			[Token(Token = "0x6006701")]
			set;
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06006702 RID: 26370
		// (set) Token: 0x06006703 RID: 26371
		[Token(Token = "0x170006E1")]
		OnErrorDelegate OnError
		{
			[Token(Token = "0x6006702")]
			get;
			[Token(Token = "0x6006703")]
			set;
		}

		// Token: 0x06006704 RID: 26372
		[Token(Token = "0x6006704")]
		void Kill();
	}
}
