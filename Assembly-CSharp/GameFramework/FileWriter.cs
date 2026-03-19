using System;
using Il2CppDummyDll;

namespace GameFramework
{
	// Token: 0x020004F8 RID: 1272
	[Token(Token = "0x20004F8")]
	public class FileWriter
	{
		// Token: 0x0600269F RID: 9887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269F")]
		[Address(RVA = "0x2B62160", Offset = "0x2B62160", VA = "0x2B62160")]
		public FileWriter(string filePath)
		{
		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A0")]
		[Address(RVA = "0x2B62458", Offset = "0x2B62458", VA = "0x2B62458")]
		public void WriteLine(string message)
		{
		}

		// Token: 0x060026A1 RID: 9889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A1")]
		[Address(RVA = "0x2B62804", Offset = "0x2B62804", VA = "0x2B62804")]
		public void ClearFile()
		{
		}

		// Token: 0x040022AF RID: 8879
		[Token(Token = "0x40022AF")]
		[FieldOffset(Offset = "0x10")]
		private readonly object _lock;

		// Token: 0x040022B0 RID: 8880
		[Token(Token = "0x40022B0")]
		[FieldOffset(Offset = "0x18")]
		private readonly string _filePath;
	}
}
