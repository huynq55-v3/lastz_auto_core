using System;
using Il2CppDummyDll;

namespace Main.Scripts.Network
{
	// Token: 0x02000507 RID: 1287
	[Token(Token = "0x2000507")]
	internal struct msgSendInfo
	{
		// Token: 0x060026E5 RID: 9957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E5")]
		[Address(RVA = "0x2B65E48", Offset = "0x2B65E48", VA = "0x2B65E48")]
		public msgSendInfo(int fuid, string msgId)
		{
		}

		// Token: 0x060026E6 RID: 9958 RVA: 0x0000EAC0 File Offset: 0x0000CCC0
		[Token(Token = "0x60026E6")]
		[Address(RVA = "0x2B65EE4", Offset = "0x2B65EE4", VA = "0x2B65EE4")]
		public long getSendTime()
		{
			return 0L;
		}

		// Token: 0x060026E7 RID: 9959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026E7")]
		[Address(RVA = "0x2B65EEC", Offset = "0x2B65EEC", VA = "0x2B65EEC")]
		public string getMsgId()
		{
			return null;
		}

		// Token: 0x04002318 RID: 8984
		[Token(Token = "0x4002318")]
		[FieldOffset(Offset = "0x0")]
		private int _futureId;

		// Token: 0x04002319 RID: 8985
		[Token(Token = "0x4002319")]
		[FieldOffset(Offset = "0x8")]
		private string _msgId;

		// Token: 0x0400231A RID: 8986
		[Token(Token = "0x400231A")]
		[FieldOffset(Offset = "0x10")]
		private long _sendTime;
	}
}
