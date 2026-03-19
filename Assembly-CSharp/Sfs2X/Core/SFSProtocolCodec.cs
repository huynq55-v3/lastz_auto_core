using System;
using Il2CppDummyDll;
using Sfs2X.Bitswarm;
using Sfs2X.Entities.Data;
using Sfs2X.Logging;
using Sfs2X.Protocol;
using Sfs2X.Util;

namespace Sfs2X.Core
{
	// Token: 0x02000A84 RID: 2692
	[Token(Token = "0x2000A84")]
	public class SFSProtocolCodec : IProtocolCodec
	{
		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x060066B7 RID: 26295 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060066B8 RID: 26296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006D0")]
		public IoHandler IOHandler
		{
			[Token(Token = "0x60066B7")]
			[Address(RVA = "0x33C0478", Offset = "0x33C0478", VA = "0x33C0478", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60066B8")]
			[Address(RVA = "0x33C0480", Offset = "0x33C0480", VA = "0x33C0480", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x060066B9 RID: 26297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066B9")]
		[Address(RVA = "0x33BE420", Offset = "0x33BE420", VA = "0x33BE420")]
		public SFSProtocolCodec(IoHandler ioHandler, ISocketClient bitSwarm)
		{
		}

		// Token: 0x060066BA RID: 26298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066BA")]
		[Address(RVA = "0x33C052C", Offset = "0x33C052C", VA = "0x33C052C", Slot = "5")]
		public void OnPacketRead(ByteArray packet)
		{
		}

		// Token: 0x060066BB RID: 26299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066BB")]
		[Address(RVA = "0x33C06B4", Offset = "0x33C06B4", VA = "0x33C06B4", Slot = "4")]
		public void OnPacketRead(ISFSObject packet)
		{
		}

		// Token: 0x060066BC RID: 26300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066BC")]
		[Address(RVA = "0x33C0EBC", Offset = "0x33C0EBC", VA = "0x33C0EBC", Slot = "6")]
		public void OnPacketWrite(IMessage message)
		{
		}

		// Token: 0x060066BD RID: 26301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066BD")]
		[Address(RVA = "0x33C1568", Offset = "0x33C1568", VA = "0x33C1568", Slot = "7")]
		public void OnPacketWrite(byte[] data, int dataLen)
		{
		}

		// Token: 0x060066BE RID: 26302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066BE")]
		[Address(RVA = "0x33C11FC", Offset = "0x33C11FC", VA = "0x33C11FC")]
		private ISFSObject PrepareTCPPacket(IMessage message)
		{
			return null;
		}

		// Token: 0x060066BF RID: 26303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066BF")]
		[Address(RVA = "0x33C06B8", Offset = "0x33C06B8", VA = "0x33C06B8")]
		private void DispatchRequest(ISFSObject requestObject)
		{
		}

		// Token: 0x060066C0 RID: 26304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066C0")]
		[Address(RVA = "0x33C0530", Offset = "0x33C0530", VA = "0x33C0530")]
		private void DispatchRequest(ByteArray requestBuff)
		{
		}

		// Token: 0x0400290C RID: 10508
		[Token(Token = "0x400290C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string CONTROLLER_ID;

		// Token: 0x0400290D RID: 10509
		[Token(Token = "0x400290D")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string ACTION_ID;

		// Token: 0x0400290E RID: 10510
		[Token(Token = "0x400290E")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string PARAM_ID;

		// Token: 0x0400290F RID: 10511
		[Token(Token = "0x400290F")]
		[FieldOffset(Offset = "0x18")]
		private static readonly string USER_ID;

		// Token: 0x04002910 RID: 10512
		[Token(Token = "0x4002910")]
		[FieldOffset(Offset = "0x20")]
		private static readonly string UDP_PACKET_ID;

		// Token: 0x04002911 RID: 10513
		[Token(Token = "0x4002911")]
		[FieldOffset(Offset = "0x10")]
		private IoHandler ioHandler;

		// Token: 0x04002912 RID: 10514
		[Token(Token = "0x4002912")]
		[FieldOffset(Offset = "0x18")]
		private Logger log;

		// Token: 0x04002913 RID: 10515
		[Token(Token = "0x4002913")]
		[FieldOffset(Offset = "0x20")]
		private ISocketClient bitSwarm;
	}
}
