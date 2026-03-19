using System;
using Il2CppDummyDll;
using Sfs2X.Controllers;
using Sfs2X.Core;
using Sfs2X.Core.Sockets;
using Sfs2X.Logging;

namespace Sfs2X.Bitswarm
{
	// Token: 0x02000A9D RID: 2717
	[Token(Token = "0x2000A9D")]
	public interface ISocketClient
	{
		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06006784 RID: 26500
		// (set) Token: 0x06006785 RID: 26501
		[Token(Token = "0x170006FF")]
		bool SendLog
		{
			[Token(Token = "0x6006784")]
			get;
			[Token(Token = "0x6006785")]
			set;
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06006786 RID: 26502
		[Token(Token = "0x17000700")]
		string ConnectionMode
		{
			[Token(Token = "0x6006786")]
			get;
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06006787 RID: 26503
		[Token(Token = "0x17000701")]
		bool Debug
		{
			[Token(Token = "0x6006787")]
			get;
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06006788 RID: 26504
		[Token(Token = "0x17000702")]
		SmartFox Sfs
		{
			[Token(Token = "0x6006788")]
			get;
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06006789 RID: 26505
		[Token(Token = "0x17000703")]
		bool Connected
		{
			[Token(Token = "0x6006789")]
			get;
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x0600678A RID: 26506
		// (set) Token: 0x0600678B RID: 26507
		[Token(Token = "0x17000704")]
		IoHandler IoHandler
		{
			[Token(Token = "0x600678A")]
			get;
			[Token(Token = "0x600678B")]
			set;
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x0600678C RID: 26508
		// (set) Token: 0x0600678D RID: 26509
		[Token(Token = "0x17000705")]
		int CompressionThreshold
		{
			[Token(Token = "0x600678C")]
			get;
			[Token(Token = "0x600678D")]
			set;
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x0600678E RID: 26510
		// (set) Token: 0x0600678F RID: 26511
		[Token(Token = "0x17000706")]
		int MaxMessageSize
		{
			[Token(Token = "0x600678E")]
			get;
			[Token(Token = "0x600678F")]
			set;
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06006790 RID: 26512
		[Token(Token = "0x17000707")]
		SystemController SysController
		{
			[Token(Token = "0x6006790")]
			get;
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06006791 RID: 26513
		[Token(Token = "0x17000708")]
		ExtensionController ExtController
		{
			[Token(Token = "0x6006791")]
			get;
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06006792 RID: 26514
		[Token(Token = "0x17000709")]
		ISocketLayer Socket
		{
			[Token(Token = "0x6006792")]
			get;
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06006793 RID: 26515
		// (set) Token: 0x06006794 RID: 26516
		[Token(Token = "0x1700070A")]
		bool IsReconnecting
		{
			[Token(Token = "0x6006793")]
			get;
			[Token(Token = "0x6006794")]
			set;
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06006795 RID: 26517
		// (set) Token: 0x06006796 RID: 26518
		[Token(Token = "0x1700070B")]
		int ReconnectionSeconds
		{
			[Token(Token = "0x6006795")]
			get;
			[Token(Token = "0x6006796")]
			set;
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06006797 RID: 26519
		// (set) Token: 0x06006798 RID: 26520
		[Token(Token = "0x1700070C")]
		EventDispatcher Dispatcher
		{
			[Token(Token = "0x6006797")]
			get;
			[Token(Token = "0x6006798")]
			set;
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06006799 RID: 26521
		[Token(Token = "0x1700070D")]
		Logger Log
		{
			[Token(Token = "0x6006799")]
			get;
		}

		// Token: 0x0600679A RID: 26522
		[Token(Token = "0x600679A")]
		void Init();

		// Token: 0x0600679B RID: 26523
		[Token(Token = "0x600679B")]
		void Destroy();

		// Token: 0x0600679C RID: 26524
		[Token(Token = "0x600679C")]
		IController GetController(int id);

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x0600679D RID: 26525
		[Token(Token = "0x1700070E")]
		string ConnectionHost
		{
			[Token(Token = "0x600679D")]
			get;
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x0600679E RID: 26526
		[Token(Token = "0x1700070F")]
		int ConnectionPort
		{
			[Token(Token = "0x600679E")]
			get;
		}

		// Token: 0x0600679F RID: 26527
		[Token(Token = "0x600679F")]
		void Connect();

		// Token: 0x060067A0 RID: 26528
		[Token(Token = "0x60067A0")]
		void Connect(string host, int port);

		// Token: 0x060067A1 RID: 26529
		[Token(Token = "0x60067A1")]
		void Send(IMessage message);

		// Token: 0x060067A2 RID: 26530
		[Token(Token = "0x60067A2")]
		void SendBinary(byte[] data, int dataLen);

		// Token: 0x060067A3 RID: 26531
		[Token(Token = "0x60067A3")]
		void Disconnect();

		// Token: 0x060067A4 RID: 26532
		[Token(Token = "0x60067A4")]
		void Disconnect(string reason);

		// Token: 0x060067A5 RID: 26533
		[Token(Token = "0x60067A5")]
		void StopReconnection();

		// Token: 0x060067A6 RID: 26534
		[Token(Token = "0x60067A6")]
		void KillConnection();

		// Token: 0x060067A7 RID: 26535
		[Token(Token = "0x60067A7")]
		void AddEventListener(string eventType, EventListenerDelegate listener);

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x060067A8 RID: 26536
		[Token(Token = "0x17000710")]
		bool IsBinProtocol
		{
			[Token(Token = "0x60067A8")]
			get;
		}
	}
}
