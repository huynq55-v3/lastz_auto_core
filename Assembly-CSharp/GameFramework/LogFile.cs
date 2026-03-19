using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameFramework
{
	// Token: 0x020004F7 RID: 1271
	[Token(Token = "0x20004F7")]
	public class LogFile
	{
		// Token: 0x0600269C RID: 9884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269C")]
		[Address(RVA = "0x2B62054", Offset = "0x2B62054", VA = "0x2B62054")]
		public LogFile()
		{
		}

		// Token: 0x0600269D RID: 9885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269D")]
		[Address(RVA = "0x2B621F0", Offset = "0x2B621F0", VA = "0x2B621F0")]
		public void Write(LogType logType, string trace, string message)
		{
		}

		// Token: 0x0600269E RID: 9886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269E")]
		[Address(RVA = "0x2B626A4", Offset = "0x2B626A4", VA = "0x2B626A4")]
		public void ClearOld()
		{
		}

		// Token: 0x040022AD RID: 8877
		[Token(Token = "0x40022AD")]
		[FieldOffset(Offset = "0x10")]
		private FileWriter _fileWriter;

		// Token: 0x040022AE RID: 8878
		[Token(Token = "0x40022AE")]
		private const int MaxLogLevelLength = 9;
	}
}
