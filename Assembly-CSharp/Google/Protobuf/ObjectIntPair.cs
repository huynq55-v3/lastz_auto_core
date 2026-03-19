using System;
using Il2CppDummyDll;

namespace Google.Protobuf
{
	// Token: 0x02000B2B RID: 2859
	[Token(Token = "0x2000B2B")]
	internal struct ObjectIntPair<T> : IEquatable<ObjectIntPair<T>> where T : class
	{
		// Token: 0x06006D09 RID: 27913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D09")]
		internal ObjectIntPair(T obj, int number)
		{
		}

		// Token: 0x06006D0A RID: 27914 RVA: 0x0004EB10 File Offset: 0x0004CD10
		[Token(Token = "0x6006D0A")]
		public bool Equals(ObjectIntPair<T> other)
		{
			return default(bool);
		}

		// Token: 0x06006D0B RID: 27915 RVA: 0x0004EB28 File Offset: 0x0004CD28
		[Token(Token = "0x6006D0B")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06006D0C RID: 27916 RVA: 0x0004EB40 File Offset: 0x0004CD40
		[Token(Token = "0x6006D0C")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04002BD4 RID: 11220
		[Token(Token = "0x4002BD4")]
		[FieldOffset(Offset = "0x0")]
		private readonly int number;

		// Token: 0x04002BD5 RID: 11221
		[Token(Token = "0x4002BD5")]
		[FieldOffset(Offset = "0x0")]
		private readonly T obj;
	}
}
