using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sfs2X.Logging;

namespace Sfs2X.Util
{
	// Token: 0x02000A52 RID: 2642
	[Token(Token = "0x2000A52")]
	public static class SFSErrorCodes
	{
		// Token: 0x06006441 RID: 25665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006441")]
		[Address(RVA = "0x2DFB3E0", Offset = "0x2DFB3E0", VA = "0x2DFB3E0")]
		public static void SetErrorMessage(int code, string message)
		{
		}

		// Token: 0x06006442 RID: 25666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006442")]
		[Address(RVA = "0x2DF7F58", Offset = "0x2DF7F58", VA = "0x2DF7F58")]
		public static string GetErrorMessage(int code, Logger log, params object[] args)
		{
			return null;
		}

		// Token: 0x04002863 RID: 10339
		[Token(Token = "0x4002863")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<int, string> errorsByCode;
	}
}
