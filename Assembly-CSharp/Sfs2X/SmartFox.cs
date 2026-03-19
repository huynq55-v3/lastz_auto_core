using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sfs2X.Bitswarm;
using Sfs2X.Core;
using Sfs2X.Logging;
using Sfs2X.Requests;

namespace Sfs2X
{
	// Token: 0x02000A4B RID: 2635
	[Token(Token = "0x2000A4B")]
	public class SmartFox : IDispatchable
	{
		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x060063C0 RID: 25536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000686")]
		public ISocketClient SocketClient
		{
			[Token(Token = "0x60063C0")]
			[Address(RVA = "0x2DF41F4", Offset = "0x2DF41F4", VA = "0x2DF41F4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x060063C1 RID: 25537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000687")]
		public Logger Log
		{
			[Token(Token = "0x60063C1")]
			[Address(RVA = "0x2DF41FC", Offset = "0x2DF41FC", VA = "0x2DF41FC")]
			get
			{
				return null;
			}
		}

		// Token: 0x060063C2 RID: 25538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063C2")]
		[Address(RVA = "0x2DF4204", Offset = "0x2DF4204", VA = "0x2DF4204")]
		public SmartFox()
		{
		}

		// Token: 0x060063C3 RID: 25539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063C3")]
		[Address(RVA = "0x2DF4A9C", Offset = "0x2DF4A9C", VA = "0x2DF4A9C")]
		public SmartFox(bool debug, string name)
		{
		}

		// Token: 0x060063C4 RID: 25540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063C4")]
		[Address(RVA = "0x2DF4C08", Offset = "0x2DF4C08", VA = "0x2DF4C08")]
		public void SetSendLogFlag(bool flag)
		{
		}

		// Token: 0x060063C5 RID: 25541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063C5")]
		[Address(RVA = "0x2DF4350", Offset = "0x2DF4350", VA = "0x2DF4350")]
		private void Initialize(bool debug)
		{
		}

		// Token: 0x060063C6 RID: 25542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063C6")]
		[Address(RVA = "0x2DF4D14", Offset = "0x2DF4D14", VA = "0x2DF4D14")]
		private void Reset()
		{
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x060063C7 RID: 25543 RVA: 0x0004BF00 File Offset: 0x0004A100
		[Token(Token = "0x17000688")]
		public bool IsConnecting
		{
			[Token(Token = "0x60063C7")]
			[Address(RVA = "0x2DF4D50", Offset = "0x2DF4D50", VA = "0x2DF4D50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060063C8 RID: 25544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063C8")]
		[Address(RVA = "0x2DF4D58", Offset = "0x2DF4D58", VA = "0x2DF4D58")]
		public ISocketClient GetSocketEngine()
		{
			return null;
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x060063C9 RID: 25545 RVA: 0x0004BF18 File Offset: 0x0004A118
		[Token(Token = "0x17000689")]
		public bool IsConnected
		{
			[Token(Token = "0x60063C9")]
			[Address(RVA = "0x2DF4D60", Offset = "0x2DF4D60", VA = "0x2DF4D60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x060063CA RID: 25546 RVA: 0x0004BF30 File Offset: 0x0004A130
		// (set) Token: 0x060063CB RID: 25547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700068A")]
		public static bool TcpNoDelay
		{
			[Token(Token = "0x60063CA")]
			[Address(RVA = "0x2DF4E10", Offset = "0x2DF4E10", VA = "0x2DF4E10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60063CB")]
			[Address(RVA = "0x2DF4E68", Offset = "0x2DF4E68", VA = "0x2DF4E68")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x060063CC RID: 25548 RVA: 0x0004BF48 File Offset: 0x0004A148
		// (set) Token: 0x060063CD RID: 25549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700068B")]
		public static int UseAsyncTcp
		{
			[Token(Token = "0x60063CC")]
			[Address(RVA = "0x2DF4EC4", Offset = "0x2DF4EC4", VA = "0x2DF4EC4")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60063CD")]
			[Address(RVA = "0x2DF4F1C", Offset = "0x2DF4F1C", VA = "0x2DF4F1C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x060063CE RID: 25550 RVA: 0x0004BF60 File Offset: 0x0004A160
		[Token(Token = "0x1700068C")]
		public int CompressionThreshold
		{
			[Token(Token = "0x60063CE")]
			[Address(RVA = "0x2DF4F78", Offset = "0x2DF4F78", VA = "0x2DF4F78")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x060063CF RID: 25551 RVA: 0x0004BF78 File Offset: 0x0004A178
		[Token(Token = "0x1700068D")]
		public int MaxMessageSize
		{
			[Token(Token = "0x60063CF")]
			[Address(RVA = "0x2DF501C", Offset = "0x2DF501C", VA = "0x2DF501C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060063D0 RID: 25552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063D0")]
		[Address(RVA = "0x2DF50C0", Offset = "0x2DF50C0", VA = "0x2DF50C0")]
		public void KillConnection()
		{
		}

		// Token: 0x060063D1 RID: 25553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063D1")]
		[Address(RVA = "0x2DF5164", Offset = "0x2DF5164", VA = "0x2DF5164")]
		public void Connect(string host, int port)
		{
		}

		// Token: 0x060063D2 RID: 25554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063D2")]
		[Address(RVA = "0x2DF5454", Offset = "0x2DF5454", VA = "0x2DF5454")]
		public void SendToServer(string action, string param0)
		{
		}

		// Token: 0x060063D3 RID: 25555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063D3")]
		[Address(RVA = "0x2DF55A0", Offset = "0x2DF55A0", VA = "0x2DF55A0")]
		public void Disconnect()
		{
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x060063D4 RID: 25556 RVA: 0x0004BF90 File Offset: 0x0004A190
		// (set) Token: 0x060063D5 RID: 25557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700068E")]
		public bool Debug
		{
			[Token(Token = "0x60063D4")]
			[Address(RVA = "0x2DF5EE0", Offset = "0x2DF5EE0", VA = "0x2DF5EE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60063D5")]
			[Address(RVA = "0x2DF5EE8", Offset = "0x2DF5EE8", VA = "0x2DF5EE8")]
			set
			{
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x060063D6 RID: 25558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700068F")]
		public string CurrentIp
		{
			[Token(Token = "0x60063D6")]
			[Address(RVA = "0x2DF5EF4", Offset = "0x2DF5EF4", VA = "0x2DF5EF4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x060063D7 RID: 25559 RVA: 0x0004BFA8 File Offset: 0x0004A1A8
		[Token(Token = "0x17000690")]
		public int CurrentPort
		{
			[Token(Token = "0x60063D7")]
			[Address(RVA = "0x2DF5F98", Offset = "0x2DF5F98", VA = "0x2DF5F98")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x060063D8 RID: 25560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000691")]
		public string CurrentZone
		{
			[Token(Token = "0x60063D8")]
			[Address(RVA = "0x2DF603C", Offset = "0x2DF603C", VA = "0x2DF603C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x060063D9 RID: 25561 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060063DA RID: 25562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000692")]
		public string MySelf
		{
			[Token(Token = "0x60063D9")]
			[Address(RVA = "0x2DF6044", Offset = "0x2DF6044", VA = "0x2DF6044")]
			get
			{
				return null;
			}
			[Token(Token = "0x60063DA")]
			[Address(RVA = "0x2DF604C", Offset = "0x2DF604C", VA = "0x2DF604C")]
			set
			{
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x060063DB RID: 25563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000693")]
		public Logger Logger
		{
			[Token(Token = "0x60063DB")]
			[Address(RVA = "0x2DF6054", Offset = "0x2DF6054", VA = "0x2DF6054")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x060063DC RID: 25564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000694")]
		public string SessionToken
		{
			[Token(Token = "0x60063DC")]
			[Address(RVA = "0x2DF605C", Offset = "0x2DF605C", VA = "0x2DF605C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x060063DD RID: 25565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000695")]
		public EventDispatcher Dispatcher
		{
			[Token(Token = "0x60063DD")]
			[Address(RVA = "0x2DF6064", Offset = "0x2DF6064", VA = "0x2DF6064", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x060063DE RID: 25566 RVA: 0x0004BFC0 File Offset: 0x0004A1C0
		// (set) Token: 0x060063DF RID: 25567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000696")]
		public bool ThreadSafeMode
		{
			[Token(Token = "0x60063DE")]
			[Address(RVA = "0x2DF606C", Offset = "0x2DF606C", VA = "0x2DF606C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60063DF")]
			[Address(RVA = "0x2DF6074", Offset = "0x2DF6074", VA = "0x2DF6074")]
			set
			{
			}
		}

		// Token: 0x060063E0 RID: 25568 RVA: 0x0004BFD8 File Offset: 0x0004A1D8
		[Token(Token = "0x60063E0")]
		[Address(RVA = "0x2DF6080", Offset = "0x2DF6080", VA = "0x2DF6080")]
		public int GetReconnectionSeconds()
		{
			return 0;
		}

		// Token: 0x060063E1 RID: 25569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063E1")]
		[Address(RVA = "0x2DF6124", Offset = "0x2DF6124", VA = "0x2DF6124")]
		public void SetReconnectionSeconds(int seconds)
		{
		}

		// Token: 0x060063E2 RID: 25570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063E2")]
		[Address(RVA = "0x2DF57D4", Offset = "0x2DF57D4", VA = "0x2DF57D4")]
		public void Send(IRequest request)
		{
		}

		// Token: 0x060063E3 RID: 25571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063E3")]
		[Address(RVA = "0x2DF61D0", Offset = "0x2DF61D0", VA = "0x2DF61D0")]
		public void Send(byte[] data, int dataLen)
		{
		}

		// Token: 0x060063E4 RID: 25572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063E4")]
		[Address(RVA = "0x2DF6464", Offset = "0x2DF6464", VA = "0x2DF6464")]
		public void AddLogListener(LogLevel logLevel, EventListenerDelegate eventListener)
		{
		}

		// Token: 0x060063E5 RID: 25573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063E5")]
		[Address(RVA = "0x2DF6568", Offset = "0x2DF6568", VA = "0x2DF6568")]
		public void RemoveLogListener(LogLevel logLevel, EventListenerDelegate eventListener)
		{
		}

		// Token: 0x060063E6 RID: 25574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063E6")]
		[Address(RVA = "0x2DF65C4", Offset = "0x2DF65C4", VA = "0x2DF65C4")]
		public void OnSocketConnect(BaseEvent e)
		{
		}

		// Token: 0x060063E7 RID: 25575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063E7")]
		[Address(RVA = "0x2DF6650", Offset = "0x2DF6650", VA = "0x2DF6650")]
		private void SocketConnect_SendHandshake(BaseEvent e)
		{
		}

		// Token: 0x060063E8 RID: 25576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063E8")]
		[Address(RVA = "0x2DF6CE8", Offset = "0x2DF6CE8", VA = "0x2DF6CE8")]
		private void OnSocketClose(BaseEvent e)
		{
		}

		// Token: 0x060063E9 RID: 25577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063E9")]
		[Address(RVA = "0x2DF702C", Offset = "0x2DF702C", VA = "0x2DF702C")]
		private void OnSocketReconnectionTry(BaseEvent e)
		{
		}

		// Token: 0x060063EA RID: 25578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063EA")]
		[Address(RVA = "0x2DF70AC", Offset = "0x2DF70AC", VA = "0x2DF70AC")]
		private void OnSocketDataError(BaseEvent e)
		{
		}

		// Token: 0x060063EB RID: 25579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063EB")]
		[Address(RVA = "0x2DF723C", Offset = "0x2DF723C", VA = "0x2DF723C")]
		private void OnSocketIOError(BaseEvent e)
		{
		}

		// Token: 0x060063EC RID: 25580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063EC")]
		[Address(RVA = "0x2DF72D0", Offset = "0x2DF72D0", VA = "0x2DF72D0")]
		private void OnSocketSecurityError(BaseEvent e)
		{
		}

		// Token: 0x060063ED RID: 25581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063ED")]
		[Address(RVA = "0x2DF7364", Offset = "0x2DF7364", VA = "0x2DF7364")]
		public void HandleHandShake(BaseEvent evt)
		{
		}

		// Token: 0x060063EE RID: 25582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063EE")]
		[Address(RVA = "0x2DF8174", Offset = "0x2DF8174", VA = "0x2DF8174")]
		public void HandleLogin(BaseEvent evt)
		{
		}

		// Token: 0x060063EF RID: 25583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063EF")]
		[Address(RVA = "0x2DF5BC0", Offset = "0x2DF5BC0", VA = "0x2DF5BC0")]
		public void HandleClientDisconnection(string reason)
		{
		}

		// Token: 0x060063F0 RID: 25584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063F0")]
		[Address(RVA = "0x2DF8284", Offset = "0x2DF8284", VA = "0x2DF8284")]
		public void HandleLogout()
		{
		}

		// Token: 0x060063F1 RID: 25585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063F1")]
		[Address(RVA = "0x2DF6A1C", Offset = "0x2DF6A1C", VA = "0x2DF6A1C")]
		private void HandleConnectionProblem(BaseEvent e)
		{
		}

		// Token: 0x060063F2 RID: 25586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063F2")]
		[Address(RVA = "0x2DF82B0", Offset = "0x2DF82B0", VA = "0x2DF82B0")]
		public void HandleReconnectionFailure()
		{
		}

		// Token: 0x060063F3 RID: 25587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063F3")]
		[Address(RVA = "0x2DF6978", Offset = "0x2DF6978", VA = "0x2DF6978")]
		private void SendHandshakeRequest(bool isReconnection)
		{
		}

		// Token: 0x060063F4 RID: 25588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063F4")]
		[Address(RVA = "0x2DF7028", Offset = "0x2DF7028", VA = "0x2DF7028")]
		internal void DispatchEvent(BaseEvent evt)
		{
		}

		// Token: 0x060063F5 RID: 25589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063F5")]
		[Address(RVA = "0x2DF85AC", Offset = "0x2DF85AC", VA = "0x2DF85AC")]
		private void EnqueueEvent(BaseEvent evt)
		{
		}

		// Token: 0x060063F6 RID: 25590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063F6")]
		[Address(RVA = "0x2DF86A8", Offset = "0x2DF86A8", VA = "0x2DF86A8")]
		public void ProcessEvents()
		{
		}

		// Token: 0x060063F7 RID: 25591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063F7")]
		[Address(RVA = "0x2DF654C", Offset = "0x2DF654C", VA = "0x2DF654C", Slot = "5")]
		public void AddEventListener(string eventType, EventListenerDelegate listener)
		{
		}

		// Token: 0x060063F8 RID: 25592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063F8")]
		[Address(RVA = "0x2DF65A8", Offset = "0x2DF65A8", VA = "0x2DF65A8")]
		public void RemoveEventListener(string eventType, EventListenerDelegate listener)
		{
		}

		// Token: 0x060063F9 RID: 25593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063F9")]
		[Address(RVA = "0x2DF8920", Offset = "0x2DF8920", VA = "0x2DF8920")]
		public void RemoveAllEventListeners()
		{
		}

		// Token: 0x04002839 RID: 10297
		[Token(Token = "0x4002839")]
		[FieldOffset(Offset = "0x10")]
		public bool sendLog;

		// Token: 0x0400283A RID: 10298
		[Token(Token = "0x400283A")]
		[FieldOffset(Offset = "0x18")]
		public string lineName;

		// Token: 0x0400283B RID: 10299
		[Token(Token = "0x400283B")]
		[FieldOffset(Offset = "0x20")]
		private int majVersion;

		// Token: 0x0400283C RID: 10300
		[Token(Token = "0x400283C")]
		[FieldOffset(Offset = "0x24")]
		private int minVersion;

		// Token: 0x0400283D RID: 10301
		[Token(Token = "0x400283D")]
		[FieldOffset(Offset = "0x28")]
		private int subVersion;

		// Token: 0x0400283E RID: 10302
		[Token(Token = "0x400283E")]
		[FieldOffset(Offset = "0x30")]
		private string clientDetails;

		// Token: 0x0400283F RID: 10303
		[Token(Token = "0x400283F")]
		[FieldOffset(Offset = "0x38")]
		private bool isJoining;

		// Token: 0x04002840 RID: 10304
		[Token(Token = "0x4002840")]
		[FieldOffset(Offset = "0x39")]
		private bool inited;

		// Token: 0x04002841 RID: 10305
		[Token(Token = "0x4002841")]
		[FieldOffset(Offset = "0x3A")]
		private bool debug;

		// Token: 0x04002842 RID: 10306
		[Token(Token = "0x4002842")]
		[FieldOffset(Offset = "0x3B")]
		private bool threadSafeMode;

		// Token: 0x04002843 RID: 10307
		[Token(Token = "0x4002843")]
		[FieldOffset(Offset = "0x3C")]
		private bool isConnecting;

		// Token: 0x04002844 RID: 10308
		[Token(Token = "0x4002844")]
		[FieldOffset(Offset = "0x40")]
		private object eventsLocker;

		// Token: 0x04002845 RID: 10309
		[Token(Token = "0x4002845")]
		[FieldOffset(Offset = "0x48")]
		private Queue<BaseEvent> eventsQueue;

		// Token: 0x04002846 RID: 10310
		[Token(Token = "0x4002846")]
		[FieldOffset(Offset = "0x50")]
		private BaseEvent onSocketConnectEvent;

		// Token: 0x04002847 RID: 10311
		[Token(Token = "0x4002847")]
		[FieldOffset(Offset = "0x58")]
		private BaseEvent[] processEventsArray;

		// Token: 0x04002848 RID: 10312
		[Token(Token = "0x4002848")]
		[FieldOffset(Offset = "0x60")]
		private ISocketClient socketClient;

		// Token: 0x04002849 RID: 10313
		[Token(Token = "0x4002849")]
		[FieldOffset(Offset = "0x68")]
		private string mySelf;

		// Token: 0x0400284A RID: 10314
		[Token(Token = "0x400284A")]
		[FieldOffset(Offset = "0x70")]
		private string sessionToken;

		// Token: 0x0400284B RID: 10315
		[Token(Token = "0x400284B")]
		[FieldOffset(Offset = "0x78")]
		private Logger log;

		// Token: 0x0400284C RID: 10316
		[Token(Token = "0x400284C")]
		[FieldOffset(Offset = "0x80")]
		private string currentZone;

		// Token: 0x0400284D RID: 10317
		[Token(Token = "0x400284D")]
		[FieldOffset(Offset = "0x88")]
		private string lastHost;

		// Token: 0x0400284E RID: 10318
		[Token(Token = "0x400284E")]
		[FieldOffset(Offset = "0x90")]
		private EventDispatcher dispatcher;
	}
}
