using System;
using System.Net;
using System.Net.Sockets;
using Il2CppDummyDll;
using Sfs2X.Bitswarm;
using Sfs2X.Util;

namespace Sfs2X.Core.Sockets
{
	// Token: 0x02000A87 RID: 2695
	[Token(Token = "0x2000A87")]
	public class AsyncTCPSocketLayer : BaseSocketLayer, ISocketLayer
	{
		// Token: 0x060066C6 RID: 26310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066C6")]
		[Address(RVA = "0x33C1820", Offset = "0x33C1820", VA = "0x33C1820")]
		public AsyncTCPSocketLayer(BitSwarmClient bs)
		{
		}

		// Token: 0x060066C7 RID: 26311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066C7")]
		[Address(RVA = "0x33C1BD8", Offset = "0x33C1BD8", VA = "0x33C1BD8")]
		private void LogError(string msg)
		{
		}

		// Token: 0x060066C8 RID: 26312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066C8")]
		[Address(RVA = "0x33C1C64", Offset = "0x33C1C64", VA = "0x33C1C64")]
		private void HandleError(string err, SocketError se = 10038)
		{
		}

		// Token: 0x060066C9 RID: 26313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066C9")]
		[Address(RVA = "0x33C1ED0", Offset = "0x33C1ED0", VA = "0x33C1ED0")]
		private void HandleDisconnection(string reason)
		{
		}

		// Token: 0x060066CA RID: 26314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066CA")]
		[Address(RVA = "0x33C1F58", Offset = "0x33C1F58", VA = "0x33C1F58")]
		private void HandleBinaryData(byte[] buf, int size)
		{
		}

		// Token: 0x060066CB RID: 26315 RVA: 0x0004C7B8 File Offset: 0x0004A9B8
		[Token(Token = "0x60066CB")]
		[Address(RVA = "0x33C203C", Offset = "0x33C203C", VA = "0x33C203C")]
		public static bool IsIPv6Address(string host)
		{
			return default(bool);
		}

		// Token: 0x060066CC RID: 26316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066CC")]
		[Address(RVA = "0x33C20D8", Offset = "0x33C20D8", VA = "0x33C20D8", Slot = "4")]
		public void Connect(string host, int port)
		{
		}

		// Token: 0x060066CD RID: 26317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066CD")]
		[Address(RVA = "0x33C239C", Offset = "0x33C239C", VA = "0x33C239C")]
		private void ConnectInternal(string host, int port)
		{
		}

		// Token: 0x060066CE RID: 26318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066CE")]
		[Address(RVA = "0x33C26DC", Offset = "0x33C26DC", VA = "0x33C26DC")]
		private void ConnectInternal(IPAddress ipAddress, int port)
		{
		}

		// Token: 0x060066CF RID: 26319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066CF")]
		[Address(RVA = "0x33C2A08", Offset = "0x33C2A08", VA = "0x33C2A08")]
		private void ConnectCallback(IAsyncResult result)
		{
		}

		// Token: 0x060066D0 RID: 26320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066D0")]
		[Address(RVA = "0x33C2EE8", Offset = "0x33C2EE8", VA = "0x33C2EE8")]
		private void ReceiveCallback(IAsyncResult ar)
		{
		}

		// Token: 0x060066D1 RID: 26321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066D1")]
		[Address(RVA = "0x33C32A8", Offset = "0x33C32A8", VA = "0x33C32A8")]
		private void OnDnsResolvedForIPV6(IAsyncResult ar)
		{
		}

		// Token: 0x060066D2 RID: 26322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066D2")]
		[Address(RVA = "0x33C2394", Offset = "0x33C2394", VA = "0x33C2394", Slot = "7")]
		public void Disconnect()
		{
		}

		// Token: 0x060066D3 RID: 26323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066D3")]
		[Address(RVA = "0x33C34DC", Offset = "0x33C34DC", VA = "0x33C34DC", Slot = "8")]
		public void Disconnect(string reason)
		{
		}

		// Token: 0x060066D4 RID: 26324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066D4")]
		[Address(RVA = "0x33C3674", Offset = "0x33C3674", VA = "0x33C3674", Slot = "23")]
		public void Kill()
		{
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x060066D5 RID: 26325 RVA: 0x0004C7D0 File Offset: 0x0004A9D0
		[Token(Token = "0x170006D1")]
		public bool IsConnected
		{
			[Token(Token = "0x60066D5")]
			[Address(RVA = "0x33C36A8", Offset = "0x33C36A8", VA = "0x33C36A8", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x060066D6 RID: 26326 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060066D7 RID: 26327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006D2")]
		public OnDataDelegate OnData
		{
			[Token(Token = "0x60066D6")]
			[Address(RVA = "0x33C36D0", Offset = "0x33C36D0", VA = "0x33C36D0", Slot = "17")]
			get
			{
				return null;
			}
			[Token(Token = "0x60066D7")]
			[Address(RVA = "0x33C36D8", Offset = "0x33C36D8", VA = "0x33C36D8", Slot = "18")]
			set
			{
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x060066D8 RID: 26328 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060066D9 RID: 26329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006D3")]
		public OnStringDataDelegate OnStringData
		{
			[Token(Token = "0x60066D8")]
			[Address(RVA = "0x33C36E0", Offset = "0x33C36E0", VA = "0x33C36E0", Slot = "19")]
			get
			{
				return null;
			}
			[Token(Token = "0x60066D9")]
			[Address(RVA = "0x33C36E8", Offset = "0x33C36E8", VA = "0x33C36E8", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x060066DA RID: 26330 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060066DB RID: 26331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006D4")]
		public OnErrorDelegate OnError
		{
			[Token(Token = "0x60066DA")]
			[Address(RVA = "0x33C36EC", Offset = "0x33C36EC", VA = "0x33C36EC", Slot = "21")]
			get
			{
				return null;
			}
			[Token(Token = "0x60066DB")]
			[Address(RVA = "0x33C36F4", Offset = "0x33C36F4", VA = "0x33C36F4", Slot = "22")]
			set
			{
			}
		}

		// Token: 0x060066DC RID: 26332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066DC")]
		[Address(RVA = "0x33C36FC", Offset = "0x33C36FC", VA = "0x33C36FC")]
		private void CallOnError(string msg, SocketError se)
		{
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x060066DD RID: 26333 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060066DE RID: 26334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006D5")]
		public ConnectionDelegate OnConnect
		{
			[Token(Token = "0x60066DD")]
			[Address(RVA = "0x33C3718", Offset = "0x33C3718", VA = "0x33C3718", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60066DE")]
			[Address(RVA = "0x33C3720", Offset = "0x33C3720", VA = "0x33C3720", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x060066DF RID: 26335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066DF")]
		[Address(RVA = "0x33C2ECC", Offset = "0x33C2ECC", VA = "0x33C2ECC")]
		private void CallOnConnect()
		{
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x060066E0 RID: 26336 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060066E1 RID: 26337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006D6")]
		public ConnectionDelegate OnDisconnect
		{
			[Token(Token = "0x60066E0")]
			[Address(RVA = "0x33C3728", Offset = "0x33C3728", VA = "0x33C3728", Slot = "11")]
			get
			{
				return null;
			}
			[Token(Token = "0x60066E1")]
			[Address(RVA = "0x33C3730", Offset = "0x33C3730", VA = "0x33C3730", Slot = "12")]
			set
			{
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x060066E2 RID: 26338 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060066E3 RID: 26339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006D7")]
		public OnCumstomDataDelegate OnCustomData
		{
			[Token(Token = "0x60066E2")]
			[Address(RVA = "0x33C3738", Offset = "0x33C3738", VA = "0x33C3738", Slot = "13")]
			get
			{
				return null;
			}
			[Token(Token = "0x60066E3")]
			[Address(RVA = "0x33C3740", Offset = "0x33C3740", VA = "0x33C3740", Slot = "14")]
			set
			{
			}
		}

		// Token: 0x060066E4 RID: 26340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066E4")]
		[Address(RVA = "0x33C1F3C", Offset = "0x33C1F3C", VA = "0x33C1F3C")]
		private void CallOnDisconnect()
		{
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x060066E5 RID: 26341 RVA: 0x0004C7E8 File Offset: 0x0004A9E8
		[Token(Token = "0x170006D8")]
		public bool RequiresConnection
		{
			[Token(Token = "0x60066E5")]
			[Address(RVA = "0x33C3748", Offset = "0x33C3748", VA = "0x33C3748", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060066E6 RID: 26342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066E6")]
		[Address(RVA = "0x33C3750", Offset = "0x33C3750", VA = "0x33C3750")]
		private void ReturnWriteInfo(WriteInfo writeInfo)
		{
		}

		// Token: 0x060066E7 RID: 26343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066E7")]
		[Address(RVA = "0x33C3870", Offset = "0x33C3870", VA = "0x33C3870", Slot = "15")]
		public void Write(byte[] data, int offset, int len)
		{
		}

		// Token: 0x060066E8 RID: 26344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066E8")]
		[Address(RVA = "0x33C3B98", Offset = "0x33C3B98", VA = "0x33C3B98")]
		private void SendCallback(IAsyncResult ar)
		{
		}

		// Token: 0x060066E9 RID: 26345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066E9")]
		[Address(RVA = "0x33C3E64", Offset = "0x33C3E64", VA = "0x33C3E64", Slot = "16")]
		public void Write(string data)
		{
		}

		// Token: 0x04002918 RID: 10520
		[Token(Token = "0x4002918")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int READ_BUFFER_SIZE;

		// Token: 0x04002919 RID: 10521
		[Token(Token = "0x4002919")]
		[FieldOffset(Offset = "0x30")]
		private OnDataDelegate onData;

		// Token: 0x0400291A RID: 10522
		[Token(Token = "0x400291A")]
		[FieldOffset(Offset = "0x38")]
		private OnErrorDelegate onError;

		// Token: 0x0400291B RID: 10523
		[Token(Token = "0x400291B")]
		[FieldOffset(Offset = "0x40")]
		private string curHost;

		// Token: 0x0400291C RID: 10524
		[Token(Token = "0x400291C")]
		[FieldOffset(Offset = "0x48")]
		private int socketNumber;

		// Token: 0x0400291D RID: 10525
		[Token(Token = "0x400291D")]
		[FieldOffset(Offset = "0x50")]
		private TcpClient connection;

		// Token: 0x0400291E RID: 10526
		[Token(Token = "0x400291E")]
		[FieldOffset(Offset = "0x58")]
		private NetworkStream networkStream;

		// Token: 0x0400291F RID: 10527
		[Token(Token = "0x400291F")]
		[FieldOffset(Offset = "0x60")]
		private ConnectionDelegate onConnect;

		// Token: 0x04002920 RID: 10528
		[Token(Token = "0x4002920")]
		[FieldOffset(Offset = "0x68")]
		private ConnectionDelegate onDisconnect;

		// Token: 0x04002921 RID: 10529
		[Token(Token = "0x4002921")]
		[FieldOffset(Offset = "0x70")]
		private OnCumstomDataDelegate onCustomCallback;

		// Token: 0x04002922 RID: 10530
		[Token(Token = "0x4002922")]
		[FieldOffset(Offset = "0x78")]
		private ObjectPool<WriteInfo> Pool;

		// Token: 0x04002923 RID: 10531
		[Token(Token = "0x4002923")]
		[FieldOffset(Offset = "0x80")]
		private ByteArray recvByteArray;

		// Token: 0x04002924 RID: 10532
		[Token(Token = "0x4002924")]
		[FieldOffset(Offset = "0x8")]
		public static string V6Pix;
	}
}
