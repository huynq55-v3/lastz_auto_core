using System;
using Il2CppDummyDll;
using Sfs2X.Core;

namespace Sfs2X.Logging
{
	// Token: 0x02000A68 RID: 2664
	[Token(Token = "0x2000A68")]
	public class Logger
	{
		// Token: 0x06006520 RID: 25888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006520")]
		[Address(RVA = "0x2DF4CD0", Offset = "0x2DF4CD0", VA = "0x2DF4CD0")]
		public Logger(SmartFox smartFox)
		{
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06006521 RID: 25889 RVA: 0x0004C200 File Offset: 0x0004A400
		[Token(Token = "0x170006AF")]
		public bool IsDebug
		{
			[Token(Token = "0x6006521")]
			[Address(RVA = "0x2E0AE60", Offset = "0x2E0AE60", VA = "0x2E0AE60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06006522 RID: 25890 RVA: 0x0004C218 File Offset: 0x0004A418
		// (set) Token: 0x06006523 RID: 25891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006B0")]
		public bool EnableConsoleTrace
		{
			[Token(Token = "0x6006522")]
			[Address(RVA = "0x2E0AE7C", Offset = "0x2E0AE7C", VA = "0x2E0AE7C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006523")]
			[Address(RVA = "0x2E0AE84", Offset = "0x2E0AE84", VA = "0x2E0AE84")]
			set
			{
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06006524 RID: 25892 RVA: 0x0004C230 File Offset: 0x0004A430
		// (set) Token: 0x06006525 RID: 25893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006B1")]
		public bool EnableEventDispatching
		{
			[Token(Token = "0x6006524")]
			[Address(RVA = "0x2E0AE90", Offset = "0x2E0AE90", VA = "0x2E0AE90")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006525")]
			[Address(RVA = "0x2E0AE98", Offset = "0x2E0AE98", VA = "0x2E0AE98")]
			set
			{
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06006526 RID: 25894 RVA: 0x0004C248 File Offset: 0x0004A448
		// (set) Token: 0x06006527 RID: 25895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006B2")]
		public LogLevel LoggingLevel
		{
			[Token(Token = "0x6006526")]
			[Address(RVA = "0x2E0AEA4", Offset = "0x2E0AEA4", VA = "0x2E0AEA4")]
			get
			{
				return (LogLevel)0;
			}
			[Token(Token = "0x6006527")]
			[Address(RVA = "0x2E0AEAC", Offset = "0x2E0AEAC", VA = "0x2E0AEAC")]
			set
			{
			}
		}

		// Token: 0x06006528 RID: 25896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006528")]
		[Address(RVA = "0x2DF7EF0", Offset = "0x2DF7EF0", VA = "0x2DF7EF0")]
		public void Debug(params string[] messages)
		{
		}

		// Token: 0x06006529 RID: 25897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006529")]
		[Address(RVA = "0x2DF5E78", Offset = "0x2DF5E78", VA = "0x2DF5E78")]
		public void Info(params string[] messages)
		{
		}

		// Token: 0x0600652A RID: 25898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600652A")]
		[Address(RVA = "0x2DF5538", Offset = "0x2DF5538", VA = "0x2DF5538")]
		public void Warn(params string[] messages)
		{
		}

		// Token: 0x0600652B RID: 25899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600652B")]
		[Address(RVA = "0x2DFB470", Offset = "0x2DFB470", VA = "0x2DFB470")]
		public void Error(params string[] messages)
		{
		}

		// Token: 0x0600652C RID: 25900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600652C")]
		[Address(RVA = "0x2E0AEB4", Offset = "0x2E0AEB4", VA = "0x2E0AEB4")]
		private void Log(LogLevel level, string message)
		{
		}

		// Token: 0x0600652D RID: 25901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600652D")]
		[Address(RVA = "0x2E0B0C0", Offset = "0x2E0B0C0", VA = "0x2E0B0C0")]
		public void AddEventListener(LogLevel level, EventListenerDelegate listener)
		{
		}

		// Token: 0x0600652E RID: 25902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600652E")]
		[Address(RVA = "0x2E0B110", Offset = "0x2E0B110", VA = "0x2E0B110")]
		public void RemoveEventListener(LogLevel logLevel, EventListenerDelegate listener)
		{
		}

		// Token: 0x040028A8 RID: 10408
		[Token(Token = "0x40028A8")]
		[FieldOffset(Offset = "0x10")]
		private bool enableConsoleTrace;

		// Token: 0x040028A9 RID: 10409
		[Token(Token = "0x40028A9")]
		[FieldOffset(Offset = "0x11")]
		private bool enableEventDispatching;

		// Token: 0x040028AA RID: 10410
		[Token(Token = "0x40028AA")]
		[FieldOffset(Offset = "0x18")]
		private SmartFox smartFox;

		// Token: 0x040028AB RID: 10411
		[Token(Token = "0x40028AB")]
		[FieldOffset(Offset = "0x20")]
		private LogLevel loggingLevel;
	}
}
