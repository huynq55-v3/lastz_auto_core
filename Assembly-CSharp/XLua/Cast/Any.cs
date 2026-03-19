using System;
using Il2CppDummyDll;

namespace XLua.Cast
{
	// Token: 0x020009BE RID: 2494
	[Token(Token = "0x20009BE")]
	public class Any<T> : RawObject
	{
		// Token: 0x06005F4D RID: 24397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F4D")]
		public Any(T i)
		{
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06005F4E RID: 24398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005F1")]
		public object Target
		{
			[Token(Token = "0x6005F4E")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400251E RID: 9502
		[Token(Token = "0x400251E")]
		[FieldOffset(Offset = "0x0")]
		private T mTarget;
	}
}
