using System;
using Il2CppDummyDll;

namespace Google.Protobuf
{
	// Token: 0x02000B2C RID: 2860
	[Token(Token = "0x2000B2C")]
	public static class ProtoPreconditions
	{
		// Token: 0x06006D0D RID: 27917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D0D")]
		public static T CheckNotNull<T>(T value, string name) where T : class
		{
			return null;
		}

		// Token: 0x06006D0E RID: 27918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D0E")]
		internal static T CheckNotNullUnconstrained<T>(T value, string name)
		{
			return null;
		}
	}
}
