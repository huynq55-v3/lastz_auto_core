using System;
using Il2CppDummyDll;

namespace VEngine
{
	// Token: 0x020009DC RID: 2524
	[Token(Token = "0x20009DC")]
	public class ManifestVersionFile
	{
		// Token: 0x060060B8 RID: 24760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060B8")]
		[Address(RVA = "0x140760C", Offset = "0x140760C", VA = "0x140760C")]
		public static ManifestVersionFile Load(string path)
		{
			return null;
		}

		// Token: 0x060060B9 RID: 24761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060B9")]
		[Address(RVA = "0x1407700", Offset = "0x1407700", VA = "0x1407700")]
		public ManifestVersionFile()
		{
		}

		// Token: 0x04002572 RID: 9586
		[Token(Token = "0x4002572")]
		[FieldOffset(Offset = "0x10")]
		public uint crc;

		// Token: 0x04002573 RID: 9587
		[Token(Token = "0x4002573")]
		[FieldOffset(Offset = "0x14")]
		public int version;
	}
}
