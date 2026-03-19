using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace Main.Scripts.Network
{
	// Token: 0x02000508 RID: 1288
	[Token(Token = "0x2000508")]
	[Preserve]
	public class FutureManager
	{
		// Token: 0x060026E8 RID: 9960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E8")]
		[Address(RVA = "0x2B65EF4", Offset = "0x2B65EF4", VA = "0x2B65EF4")]
		public void reset()
		{
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x0000EAD8 File Offset: 0x0000CCD8
		[Token(Token = "0x60026E9")]
		[Address(RVA = "0x2B65F5C", Offset = "0x2B65F5C", VA = "0x2B65F5C")]
		public int getFutureId()
		{
			return 0;
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x0000EAF0 File Offset: 0x0000CCF0
		[Token(Token = "0x60026EA")]
		[Address(RVA = "0x2B65F7C", Offset = "0x2B65F7C", VA = "0x2B65F7C")]
		public float getPing()
		{
			return 0f;
		}

		// Token: 0x060026EB RID: 9963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026EB")]
		[Address(RVA = "0x2B65F9C", Offset = "0x2B65F9C", VA = "0x2B65F9C")]
		public void onSendRequest(int fuid, string msgId)
		{
		}

		// Token: 0x060026EC RID: 9964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026EC")]
		[Address(RVA = "0x2B66074", Offset = "0x2B66074", VA = "0x2B66074")]
		public void onServerMsgCome(int fuid, int serverTime)
		{
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026ED")]
		[Address(RVA = "0x2B66200", Offset = "0x2B66200", VA = "0x2B66200")]
		public void update()
		{
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026EE")]
		[Address(RVA = "0x2B66394", Offset = "0x2B66394", VA = "0x2B66394")]
		public FutureManager()
		{
		}

		// Token: 0x0400231B RID: 8987
		[Token(Token = "0x400231B")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<int, msgSendInfo> _sendInfos;

		// Token: 0x0400231C RID: 8988
		[Token(Token = "0x400231C")]
		[FieldOffset(Offset = "0x18")]
		private int _futureId;

		// Token: 0x0400231D RID: 8989
		[Token(Token = "0x400231D")]
		private const long _timeOutTime = 500L;

		// Token: 0x0400231E RID: 8990
		[Token(Token = "0x400231E")]
		[FieldOffset(Offset = "0x20")]
		private long _totalCount;

		// Token: 0x0400231F RID: 8991
		[Token(Token = "0x400231F")]
		[FieldOffset(Offset = "0x28")]
		private float _totalTime;

		// Token: 0x04002320 RID: 8992
		[Token(Token = "0x4002320")]
		[FieldOffset(Offset = "0x30")]
		private long _minTime;

		// Token: 0x04002321 RID: 8993
		[Token(Token = "0x4002321")]
		[FieldOffset(Offset = "0x38")]
		private long _maxTime;
	}
}
