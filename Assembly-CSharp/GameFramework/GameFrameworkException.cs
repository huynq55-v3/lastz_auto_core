using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace GameFramework
{
	// Token: 0x020004FB RID: 1275
	[Token(Token = "0x20004FB")]
	[Serializable]
	public class GameFrameworkException : Exception
	{
		// Token: 0x060026A3 RID: 9891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A3")]
		[Address(RVA = "0x2B62AC0", Offset = "0x2B62AC0", VA = "0x2B62AC0")]
		public GameFrameworkException()
		{
		}

		// Token: 0x060026A4 RID: 9892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A4")]
		[Address(RVA = "0x2B62B18", Offset = "0x2B62B18", VA = "0x2B62B18")]
		public GameFrameworkException(string message)
		{
		}

		// Token: 0x060026A5 RID: 9893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A5")]
		[Address(RVA = "0x2B62B80", Offset = "0x2B62B80", VA = "0x2B62B80")]
		public GameFrameworkException(string message, Exception innerException)
		{
		}

		// Token: 0x060026A6 RID: 9894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A6")]
		[Address(RVA = "0x2B62BF0", Offset = "0x2B62BF0", VA = "0x2B62BF0")]
		protected GameFrameworkException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
