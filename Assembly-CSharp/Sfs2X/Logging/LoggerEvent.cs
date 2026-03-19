using System;
using System.Collections;
using Il2CppDummyDll;
using Sfs2X.Core;

namespace Sfs2X.Logging
{
	// Token: 0x02000A69 RID: 2665
	[Token(Token = "0x2000A69")]
	public class LoggerEvent : BaseEvent, ICloneable
	{
		// Token: 0x0600652F RID: 25903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600652F")]
		[Address(RVA = "0x2E0B080", Offset = "0x2E0B080", VA = "0x2E0B080")]
		public LoggerEvent(LogLevel level, Hashtable parameters)
		{
		}

		// Token: 0x06006530 RID: 25904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006530")]
		[Address(RVA = "0x2DF64B8", Offset = "0x2DF64B8", VA = "0x2DF64B8")]
		public static string LogEventType(LogLevel level)
		{
			return null;
		}

		// Token: 0x06006531 RID: 25905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006531")]
		[Address(RVA = "0x2E0B160", Offset = "0x2E0B160", VA = "0x2E0B160", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006532 RID: 25906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006532")]
		[Address(RVA = "0x2E0B224", Offset = "0x2E0B224", VA = "0x2E0B224", Slot = "4")]
		public new object Clone()
		{
			return null;
		}

		// Token: 0x040028AC RID: 10412
		[Token(Token = "0x40028AC")]
		[FieldOffset(Offset = "0x28")]
		private LogLevel level;
	}
}
