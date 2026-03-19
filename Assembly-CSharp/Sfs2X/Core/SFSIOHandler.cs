using System;
using Il2CppDummyDll;
using Sfs2X.Bitswarm;
using Sfs2X.FSM;
using Sfs2X.Logging;
using Sfs2X.Protocol;
using Sfs2X.Util;

namespace Sfs2X.Core
{
	// Token: 0x02000A83 RID: 2691
	[Token(Token = "0x2000A83")]
	public class SFSIOHandler : IoHandler
	{
		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x060066A6 RID: 26278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006CE")]
		public IProtocolCodec Codec
		{
			[Token(Token = "0x60066A6")]
			[Address(RVA = "0x33BE1F4", Offset = "0x33BE1F4", VA = "0x33BE1F4", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x060066A7 RID: 26279 RVA: 0x0004C7A0 File Offset: 0x0004A9A0
		[Token(Token = "0x170006CF")]
		private PacketReadState ReadState
		{
			[Token(Token = "0x60066A7")]
			[Address(RVA = "0x33BE1FC", Offset = "0x33BE1FC", VA = "0x33BE1FC")]
			get
			{
				return PacketReadState.WAIT_NEW_PACKET;
			}
		}

		// Token: 0x060066A8 RID: 26280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066A8")]
		[Address(RVA = "0x33BE218", Offset = "0x33BE218", VA = "0x33BE218")]
		public SFSIOHandler(ISocketClient bitSwarm)
		{
		}

		// Token: 0x060066A9 RID: 26281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066A9")]
		[Address(RVA = "0x33BE50C", Offset = "0x33BE50C", VA = "0x33BE50C")]
		private void InitStates()
		{
		}

		// Token: 0x060066AA RID: 26282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066AA")]
		[Address(RVA = "0x33BE6B4", Offset = "0x33BE6B4", VA = "0x33BE6B4", Slot = "4")]
		public void OnDataRead(ByteArray array)
		{
		}

		// Token: 0x060066AB RID: 26283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066AB")]
		[Address(RVA = "0x33BFC0C", Offset = "0x33BFC0C", VA = "0x33BFC0C", Slot = "5")]
		public void OnDataRead(string jsonData)
		{
		}

		// Token: 0x060066AC RID: 26284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066AC")]
		[Address(RVA = "0x33BE994", Offset = "0x33BE994", VA = "0x33BE994")]
		private ByteArray HandleNewPacket(ByteArray data)
		{
			return null;
		}

		// Token: 0x060066AD RID: 26285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066AD")]
		[Address(RVA = "0x33BEB54", Offset = "0x33BEB54", VA = "0x33BEB54")]
		private ByteArray HandleDataSize(ByteArray data)
		{
			return null;
		}

		// Token: 0x060066AE RID: 26286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066AE")]
		[Address(RVA = "0x33BF020", Offset = "0x33BF020", VA = "0x33BF020")]
		private ByteArray HandleDataSizeFragment(ByteArray data)
		{
			return null;
		}

		// Token: 0x060066AF RID: 26287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066AF")]
		[Address(RVA = "0x33BF378", Offset = "0x33BF378", VA = "0x33BF378")]
		private ByteArray HandlePacketData(ByteArray data)
		{
			return null;
		}

		// Token: 0x060066B0 RID: 26288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066B0")]
		[Address(RVA = "0x33BFB48", Offset = "0x33BFB48", VA = "0x33BFB48")]
		private ByteArray HandleInvalidData(ByteArray data)
		{
			return null;
		}

		// Token: 0x060066B1 RID: 26289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066B1")]
		[Address(RVA = "0x33BFC30", Offset = "0x33BFC30", VA = "0x33BFC30")]
		private ByteArray ResizeByteArray(ByteArray array, int pos, int len)
		{
			return null;
		}

		// Token: 0x060066B2 RID: 26290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066B2")]
		[Address(RVA = "0x33BFCF8", Offset = "0x33BFCF8", VA = "0x33BFCF8")]
		private void WriteBinaryData(PacketHeader header, byte[] Data, int DataLength)
		{
		}

		// Token: 0x060066B3 RID: 26291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066B3")]
		[Address(RVA = "0x33BFF78", Offset = "0x33BFF78", VA = "0x33BFF78", Slot = "6")]
		public void OnDataWrite(IMessage message)
		{
		}

		// Token: 0x060066B4 RID: 26292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066B4")]
		[Address(RVA = "0x33C0248", Offset = "0x33C0248", VA = "0x33C0248", Slot = "7")]
		public void OnDataWrite(byte[] data, int dataLen)
		{
		}

		// Token: 0x060066B5 RID: 26293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066B5")]
		[Address(RVA = "0x33BFEB0", Offset = "0x33BFEB0", VA = "0x33BFEB0")]
		private void WriteTCP(ByteArray writeBuffer)
		{
		}

		// Token: 0x04002901 RID: 10497
		[Token(Token = "0x4002901")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int SHORT_BYTE_SIZE;

		// Token: 0x04002902 RID: 10498
		[Token(Token = "0x4002902")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int INT_BYTE_SIZE;

		// Token: 0x04002903 RID: 10499
		[Token(Token = "0x4002903")]
		[FieldOffset(Offset = "0x10")]
		private int skipBytes;

		// Token: 0x04002904 RID: 10500
		[Token(Token = "0x4002904")]
		[FieldOffset(Offset = "0x18")]
		private BitSwarmClient bitSwarm;

		// Token: 0x04002905 RID: 10501
		[Token(Token = "0x4002905")]
		[FieldOffset(Offset = "0x20")]
		private Logger log;

		// Token: 0x04002906 RID: 10502
		[Token(Token = "0x4002906")]
		[FieldOffset(Offset = "0x28")]
		private PendingPacket pendingPacket;

		// Token: 0x04002907 RID: 10503
		[Token(Token = "0x4002907")]
		[FieldOffset(Offset = "0x38")]
		private IProtocolCodec protocolCodec;

		// Token: 0x04002908 RID: 10504
		[Token(Token = "0x4002908")]
		[FieldOffset(Offset = "0x40")]
		private IPacketEncrypter packetEncrypter;

		// Token: 0x04002909 RID: 10505
		[Token(Token = "0x4002909")]
		[FieldOffset(Offset = "0x48")]
		private FiniteStateMachine fsm;

		// Token: 0x0400290A RID: 10506
		[Token(Token = "0x400290A")]
		[FieldOffset(Offset = "0x50")]
		private readonly ByteArray _arrayForSend;

		// Token: 0x0400290B RID: 10507
		[Token(Token = "0x400290B")]
		[FieldOffset(Offset = "0x58")]
		private readonly ByteArray _tempArray;
	}
}
