using System;
using Il2CppDummyDll;

namespace SDK
{
	// Token: 0x02000CE5 RID: 3301
	[Token(Token = "0x2000CE5")]
	public class TikTokLogger
	{
		// Token: 0x06007C21 RID: 31777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C21")]
		[Address(RVA = "0x3198F14", Offset = "0x3198F14", VA = "0x3198F14")]
		public static void Verbose(string message)
		{
		}

		// Token: 0x06007C22 RID: 31778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C22")]
		[Address(RVA = "0x3198FE4", Offset = "0x3198FE4", VA = "0x3198FE4")]
		public TikTokLogger()
		{
		}

		// Token: 0x040037F1 RID: 14321
		[Token(Token = "0x40037F1")]
		[FieldOffset(Offset = "0x0")]
		public static string TikTokiOSLog;

		// Token: 0x040037F2 RID: 14322
		[Token(Token = "0x40037F2")]
		[FieldOffset(Offset = "0x8")]
		public static string TikTokAndroidLog;

		// Token: 0x040037F3 RID: 14323
		[Token(Token = "0x40037F3")]
		[FieldOffset(Offset = "0x10")]
		public static string TikTokEditorLog;

		// Token: 0x040037F4 RID: 14324
		[Token(Token = "0x40037F4")]
		[FieldOffset(Offset = "0x18")]
		public static bool IsLogOpen;
	}
}
