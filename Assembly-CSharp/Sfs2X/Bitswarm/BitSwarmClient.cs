using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Timers;
using Il2CppDummyDll;
using Sfs2X.Controllers;
using Sfs2X.Core;
using Sfs2X.Core.Sockets;
using Sfs2X.Logging;
using Sfs2X.Util;

namespace Sfs2X.Bitswarm
{
	// Token: 0x02000A97 RID: 2711
	[Token(Token = "0x2000A97")]
	public class BitSwarmClient : ISocketClient, IDispatchable
	{
		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06006730 RID: 26416 RVA: 0x0004C830 File Offset: 0x0004AA30
		// (set) Token: 0x06006731 RID: 26417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006E3")]
		public bool SendLog
		{
			[Token(Token = "0x6006730")]
			[Address(RVA = "0x33C6314", Offset = "0x33C6314", VA = "0x33C6314", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006731")]
			[Address(RVA = "0x33C631C", Offset = "0x33C631C", VA = "0x33C631C", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06006732 RID: 26418 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006733 RID: 26419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006E4")]
		public string ConnectionMode
		{
			[Token(Token = "0x6006732")]
			[Address(RVA = "0x33C6328", Offset = "0x33C6328", VA = "0x33C6328", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006733")]
			[Address(RVA = "0x33C6330", Offset = "0x33C6330", VA = "0x33C6330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06006734 RID: 26420 RVA: 0x0004C848 File Offset: 0x0004AA48
		[Token(Token = "0x170006E5")]
		public bool Debug
		{
			[Token(Token = "0x6006734")]
			[Address(RVA = "0x33BFC10", Offset = "0x33BFC10", VA = "0x33BFC10", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06006735 RID: 26421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006E6")]
		public SmartFox Sfs
		{
			[Token(Token = "0x6006735")]
			[Address(RVA = "0x33C6338", Offset = "0x33C6338", VA = "0x33C6338", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06006736 RID: 26422 RVA: 0x0004C860 File Offset: 0x0004AA60
		[Token(Token = "0x170006E7")]
		public bool Connected
		{
			[Token(Token = "0x6006736")]
			[Address(RVA = "0x33C6340", Offset = "0x33C6340", VA = "0x33C6340", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06006737 RID: 26423 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006738 RID: 26424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006E8")]
		public IoHandler IoHandler
		{
			[Token(Token = "0x6006737")]
			[Address(RVA = "0x33C63F0", Offset = "0x33C63F0", VA = "0x33C63F0", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006738")]
			[Address(RVA = "0x33C63F8", Offset = "0x33C63F8", VA = "0x33C63F8", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06006739 RID: 26425 RVA: 0x0004C878 File Offset: 0x0004AA78
		// (set) Token: 0x0600673A RID: 26426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006E9")]
		public int CompressionThreshold
		{
			[Token(Token = "0x6006739")]
			[Address(RVA = "0x33C645C", Offset = "0x33C645C", VA = "0x33C645C", Slot = "12")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600673A")]
			[Address(RVA = "0x33C6464", Offset = "0x33C6464", VA = "0x33C6464", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x0600673B RID: 26427 RVA: 0x0004C890 File Offset: 0x0004AA90
		// (set) Token: 0x0600673C RID: 26428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006EA")]
		public int MaxMessageSize
		{
			[Token(Token = "0x600673B")]
			[Address(RVA = "0x33C64C8", Offset = "0x33C64C8", VA = "0x33C64C8", Slot = "14")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600673C")]
			[Address(RVA = "0x33C64D0", Offset = "0x33C64D0", VA = "0x33C64D0", Slot = "15")]
			set
			{
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x0600673D RID: 26429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006EB")]
		public SystemController SysController
		{
			[Token(Token = "0x600673D")]
			[Address(RVA = "0x33C64D8", Offset = "0x33C64D8", VA = "0x33C64D8", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x0600673E RID: 26430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006EC")]
		public ExtensionController ExtController
		{
			[Token(Token = "0x600673E")]
			[Address(RVA = "0x33C64E0", Offset = "0x33C64E0", VA = "0x33C64E0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x0600673F RID: 26431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006ED")]
		public ISocketLayer Socket
		{
			[Token(Token = "0x600673F")]
			[Address(RVA = "0x33C64E8", Offset = "0x33C64E8", VA = "0x33C64E8", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06006740 RID: 26432 RVA: 0x0004C8A8 File Offset: 0x0004AAA8
		// (set) Token: 0x06006741 RID: 26433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006EE")]
		public bool IsReconnecting
		{
			[Token(Token = "0x6006740")]
			[Address(RVA = "0x33C64F0", Offset = "0x33C64F0", VA = "0x33C64F0", Slot = "19")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006741")]
			[Address(RVA = "0x33C64F8", Offset = "0x33C64F8", VA = "0x33C64F8", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06006742 RID: 26434 RVA: 0x0004C8C0 File Offset: 0x0004AAC0
		// (set) Token: 0x06006743 RID: 26435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006EF")]
		public int ReconnectionSeconds
		{
			[Token(Token = "0x6006742")]
			[Address(RVA = "0x33C6504", Offset = "0x33C6504", VA = "0x33C6504", Slot = "21")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006743")]
			[Address(RVA = "0x33C650C", Offset = "0x33C650C", VA = "0x33C650C", Slot = "22")]
			set
			{
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06006744 RID: 26436 RVA: 0x0004C8D8 File Offset: 0x0004AAD8
		[Token(Token = "0x170006F0")]
		public bool IsBinProtocol
		{
			[Token(Token = "0x6006744")]
			[Address(RVA = "0x33C6528", Offset = "0x33C6528", VA = "0x33C6528", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06006745 RID: 26437 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006746 RID: 26438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006F1")]
		public EventDispatcher Dispatcher
		{
			[Token(Token = "0x6006745")]
			[Address(RVA = "0x33C6530", Offset = "0x33C6530", VA = "0x33C6530", Slot = "41")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006746")]
			[Address(RVA = "0x33C6538", Offset = "0x33C6538", VA = "0x33C6538", Slot = "24")]
			set
			{
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06006747 RID: 26439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006F2")]
		public Logger Log
		{
			[Token(Token = "0x6006747")]
			[Address(RVA = "0x33C1A10", Offset = "0x33C1A10", VA = "0x33C1A10", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006748 RID: 26440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006748")]
		[Address(RVA = "0x33C6540", Offset = "0x33C6540", VA = "0x33C6540")]
		public BitSwarmClient()
		{
		}

		// Token: 0x06006749 RID: 26441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006749")]
		[Address(RVA = "0x33C6648", Offset = "0x33C6648", VA = "0x33C6648")]
		public BitSwarmClient(SmartFox sfs)
		{
		}

		// Token: 0x0600674A RID: 26442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600674A")]
		[Address(RVA = "0x33C6758", Offset = "0x33C6758", VA = "0x33C6758", Slot = "26")]
		public void Init()
		{
		}

		// Token: 0x0600674B RID: 26443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600674B")]
		[Address(RVA = "0x33C6F44", Offset = "0x33C6F44", VA = "0x33C6F44", Slot = "27")]
		public void Destroy()
		{
		}

		// Token: 0x0600674C RID: 26444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600674C")]
		[Address(RVA = "0x33C768C", Offset = "0x33C768C", VA = "0x33C768C", Slot = "28")]
		public IController GetController(int id)
		{
			return null;
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x0600674D RID: 26445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006F3")]
		public string ConnectionHost
		{
			[Token(Token = "0x600674D")]
			[Address(RVA = "0x33C76E4", Offset = "0x33C76E4", VA = "0x33C76E4", Slot = "29")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x0600674E RID: 26446 RVA: 0x0004C8F0 File Offset: 0x0004AAF0
		[Token(Token = "0x170006F4")]
		public int ConnectionPort
		{
			[Token(Token = "0x600674E")]
			[Address(RVA = "0x33C773C", Offset = "0x33C773C", VA = "0x33C773C", Slot = "30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600674F RID: 26447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600674F")]
		[Address(RVA = "0x33C7760", Offset = "0x33C7760", VA = "0x33C7760")]
		private void AddController(int id, IController controller)
		{
		}

		// Token: 0x06006750 RID: 26448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006750")]
		[Address(RVA = "0x33C78FC", Offset = "0x33C78FC", VA = "0x33C78FC")]
		private void AddCustomController(int id, Type controllerType)
		{
		}

		// Token: 0x06006751 RID: 26449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006751")]
		[Address(RVA = "0x33C796C", Offset = "0x33C796C", VA = "0x33C796C", Slot = "31")]
		public void Connect()
		{
		}

		// Token: 0x06006752 RID: 26450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006752")]
		[Address(RVA = "0x33C79B8", Offset = "0x33C79B8", VA = "0x33C79B8", Slot = "32")]
		public void Connect(string host, int port)
		{
		}

		// Token: 0x06006753 RID: 26451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006753")]
		[Address(RVA = "0x33C7AD8", Offset = "0x33C7AD8", VA = "0x33C7AD8", Slot = "33")]
		public void Send(IMessage message)
		{
		}

		// Token: 0x06006754 RID: 26452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006754")]
		[Address(RVA = "0x33C7BFC", Offset = "0x33C7BFC", VA = "0x33C7BFC", Slot = "34")]
		public void SendBinary(byte[] data, int dataLen)
		{
		}

		// Token: 0x06006755 RID: 26453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006755")]
		[Address(RVA = "0x33C7D30", Offset = "0x33C7D30", VA = "0x33C7D30", Slot = "35")]
		public void Disconnect()
		{
		}

		// Token: 0x06006756 RID: 26454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006756")]
		[Address(RVA = "0x33C7D38", Offset = "0x33C7D38", VA = "0x33C7D38", Slot = "36")]
		public void Disconnect(string reason)
		{
		}

		// Token: 0x06006757 RID: 26455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006757")]
		[Address(RVA = "0x33C6E7C", Offset = "0x33C6E7C", VA = "0x33C6E7C")]
		private void InitControllers()
		{
		}

		// Token: 0x06006758 RID: 26456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006758")]
		[Address(RVA = "0x33C7ED4", Offset = "0x33C7ED4", VA = "0x33C7ED4")]
		public void SendToServer(string action, string param0)
		{
		}

		// Token: 0x06006759 RID: 26457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006759")]
		[Address(RVA = "0x33C7FB8", Offset = "0x33C7FB8", VA = "0x33C7FB8")]
		private void OnSocketConnect()
		{
		}

		// Token: 0x0600675A RID: 26458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600675A")]
		[Address(RVA = "0x33C8224", Offset = "0x33C8224", VA = "0x33C8224", Slot = "37")]
		public void StopReconnection()
		{
		}

		// Token: 0x0600675B RID: 26459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600675B")]
		[Address(RVA = "0x33C8498", Offset = "0x33C8498", VA = "0x33C8498")]
		private void OnSocketClose()
		{
		}

		// Token: 0x0600675C RID: 26460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600675C")]
		[Address(RVA = "0x33C8A4C", Offset = "0x33C8A4C", VA = "0x33C8A4C")]
		private void SetTimeout(ElapsedEventHandler handler, double timeout)
		{
		}

		// Token: 0x0600675D RID: 26461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600675D")]
		[Address(RVA = "0x33C8B1C", Offset = "0x33C8B1C", VA = "0x33C8B1C")]
		private void OnRetryConnectionEvent(object source, ElapsedEventArgs e)
		{
		}

		// Token: 0x0600675E RID: 26462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600675E")]
		[Address(RVA = "0x33C8634", Offset = "0x33C8634", VA = "0x33C8634")]
		private void Reconnect()
		{
		}

		// Token: 0x0600675F RID: 26463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600675F")]
		[Address(RVA = "0x33C8370", Offset = "0x33C8370", VA = "0x33C8370")]
		private void ExecuteDisconnection()
		{
		}

		// Token: 0x06006760 RID: 26464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006760")]
		[Address(RVA = "0x33C7E00", Offset = "0x33C7E00", VA = "0x33C7E00")]
		private void ReleaseResources()
		{
		}

		// Token: 0x06006761 RID: 26465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006761")]
		[Address(RVA = "0x33C8BF4", Offset = "0x33C8BF4", VA = "0x33C8BF4")]
		private void OnSocketData(ByteArray data)
		{
		}

		// Token: 0x06006762 RID: 26466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006762")]
		[Address(RVA = "0x33C8C9C", Offset = "0x33C8C9C", VA = "0x33C8C9C")]
		private void OnCustomEvent(string message)
		{
		}

		// Token: 0x06006763 RID: 26467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006763")]
		[Address(RVA = "0x33C8D18", Offset = "0x33C8D18", VA = "0x33C8D18")]
		private void OnSocketError(string message, SocketError se)
		{
		}

		// Token: 0x06006764 RID: 26468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006764")]
		[Address(RVA = "0x33C8F80", Offset = "0x33C8F80", VA = "0x33C8F80", Slot = "38")]
		public void KillConnection()
		{
		}

		// Token: 0x06006765 RID: 26469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006765")]
		[Address(RVA = "0x33C902C", Offset = "0x33C902C", VA = "0x33C902C", Slot = "42")]
		public void AddEventListener(string eventType, EventListenerDelegate listener)
		{
		}

		// Token: 0x06006766 RID: 26470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006766")]
		[Address(RVA = "0x33C8A24", Offset = "0x33C8A24", VA = "0x33C8A24")]
		private void DispatchEvent(BitSwarmEvent evt)
		{
		}

		// Token: 0x04002941 RID: 10561
		[Token(Token = "0x4002941")]
		[FieldOffset(Offset = "0x10")]
		private readonly double reconnectionDelayMillis;

		// Token: 0x04002942 RID: 10562
		[Token(Token = "0x4002942")]
		[FieldOffset(Offset = "0x18")]
		private ISocketLayer socket;

		// Token: 0x04002943 RID: 10563
		[Token(Token = "0x4002943")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<int, IController> controllers;

		// Token: 0x04002944 RID: 10564
		[Token(Token = "0x4002944")]
		[FieldOffset(Offset = "0x28")]
		private int compressionThreshold;

		// Token: 0x04002945 RID: 10565
		[Token(Token = "0x4002945")]
		[FieldOffset(Offset = "0x2C")]
		private int maxMessageSize;

		// Token: 0x04002946 RID: 10566
		[Token(Token = "0x4002946")]
		[FieldOffset(Offset = "0x30")]
		private int reconnectionSeconds;

		// Token: 0x04002947 RID: 10567
		[Token(Token = "0x4002947")]
		[FieldOffset(Offset = "0x34")]
		private bool attemptingReconnection;

		// Token: 0x04002948 RID: 10568
		[Token(Token = "0x4002948")]
		[FieldOffset(Offset = "0x38")]
		private DateTime firstReconnAttempt;

		// Token: 0x04002949 RID: 10569
		[Token(Token = "0x4002949")]
		[FieldOffset(Offset = "0x40")]
		private int reconnCounter;

		// Token: 0x0400294A RID: 10570
		[Token(Token = "0x400294A")]
		[FieldOffset(Offset = "0x44")]
		private bool controllersInited;

		// Token: 0x0400294B RID: 10571
		[Token(Token = "0x400294B")]
		[FieldOffset(Offset = "0x45")]
		private bool manualDisconnection;

		// Token: 0x0400294C RID: 10572
		[Token(Token = "0x400294C")]
		[FieldOffset(Offset = "0x48")]
		private Timer retryTimer;

		// Token: 0x0400294D RID: 10573
		[Token(Token = "0x400294D")]
		[FieldOffset(Offset = "0x50")]
		private IoHandler ioHandler;

		// Token: 0x0400294E RID: 10574
		[Token(Token = "0x400294E")]
		[FieldOffset(Offset = "0x58")]
		private SmartFox sfs;

		// Token: 0x0400294F RID: 10575
		[Token(Token = "0x400294F")]
		[FieldOffset(Offset = "0x60")]
		private string lastHost;

		// Token: 0x04002950 RID: 10576
		[Token(Token = "0x4002950")]
		[FieldOffset(Offset = "0x68")]
		private int lastTcpPort;

		// Token: 0x04002951 RID: 10577
		[Token(Token = "0x4002951")]
		[FieldOffset(Offset = "0x70")]
		private Logger log;

		// Token: 0x04002952 RID: 10578
		[Token(Token = "0x4002952")]
		[FieldOffset(Offset = "0x78")]
		private SystemController sysController;

		// Token: 0x04002953 RID: 10579
		[Token(Token = "0x4002953")]
		[FieldOffset(Offset = "0x80")]
		private ExtensionController extController;

		// Token: 0x04002954 RID: 10580
		[Token(Token = "0x4002954")]
		[FieldOffset(Offset = "0x88")]
		private EventDispatcher dispatcher;

		// Token: 0x04002955 RID: 10581
		[Token(Token = "0x4002955")]
		[FieldOffset(Offset = "0x90")]
		private string disconnectReason;

		// Token: 0x04002956 RID: 10582
		[Token(Token = "0x4002956")]
		[FieldOffset(Offset = "0x98")]
		public bool sendLog;
	}
}
