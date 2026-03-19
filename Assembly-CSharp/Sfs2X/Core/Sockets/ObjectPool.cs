using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sfs2X.Core.Sockets
{
	// Token: 0x02000A86 RID: 2694
	[Token(Token = "0x2000A86")]
	public class ObjectPool<T> where T : new()
	{
		// Token: 0x060066C3 RID: 26307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066C3")]
		public ObjectPool(Func<T> objectGenerator)
		{
		}

		// Token: 0x060066C4 RID: 26308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066C4")]
		public T GetObject()
		{
			return null;
		}

		// Token: 0x060066C5 RID: 26309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066C5")]
		public void ReturnObject(T item)
		{
		}

		// Token: 0x04002916 RID: 10518
		[Token(Token = "0x4002916")]
		[FieldOffset(Offset = "0x0")]
		private Queue<T> pool;

		// Token: 0x04002917 RID: 10519
		[Token(Token = "0x4002917")]
		[FieldOffset(Offset = "0x0")]
		private Func<T> objectGenerator;
	}
}
