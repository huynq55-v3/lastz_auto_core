using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x0200053B RID: 1339
	[Token(Token = "0x200053B")]
	public class ObjectPool
	{
		// Token: 0x170005EA RID: 1514
		[Token(Token = "0x170005EA")]
		public object this[int i]
		{
			[Token(Token = "0x600281D")]
			[Address(RVA = "0x26B5DC4", Offset = "0x26B5DC4", VA = "0x26B5DC4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600281E RID: 10270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600281E")]
		[Address(RVA = "0x26B5E0C", Offset = "0x26B5E0C", VA = "0x26B5E0C")]
		public void Clear()
		{
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600281F")]
		[Address(RVA = "0x26B5E6C", Offset = "0x26B5E6C", VA = "0x26B5E6C")]
		private void extend_capacity()
		{
		}

		// Token: 0x06002820 RID: 10272 RVA: 0x0000F1F8 File Offset: 0x0000D3F8
		[Token(Token = "0x6002820")]
		[Address(RVA = "0x26B5F40", Offset = "0x26B5F40", VA = "0x26B5F40")]
		public int Add(object obj)
		{
			return 0;
		}

		// Token: 0x06002821 RID: 10273 RVA: 0x0000F210 File Offset: 0x0000D410
		[Token(Token = "0x6002821")]
		[Address(RVA = "0x26B605C", Offset = "0x26B605C", VA = "0x26B605C")]
		public bool TryGetValue(int index, out object obj)
		{
			return default(bool);
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002822")]
		[Address(RVA = "0x26B60D8", Offset = "0x26B60D8", VA = "0x26B60D8")]
		public object Get(int index)
		{
			return null;
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002823")]
		[Address(RVA = "0x26B6120", Offset = "0x26B6120", VA = "0x26B6120")]
		public object Remove(int index)
		{
			return null;
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002824")]
		[Address(RVA = "0x26B61C4", Offset = "0x26B61C4", VA = "0x26B61C4")]
		public object Replace(int index, object o)
		{
			return null;
		}

		// Token: 0x06002825 RID: 10277 RVA: 0x0000F228 File Offset: 0x0000D428
		[Token(Token = "0x6002825")]
		[Address(RVA = "0x26B621C", Offset = "0x26B621C", VA = "0x26B621C")]
		public int Check(int check_pos, int max_check, Func<object, bool> checker, Dictionary<object, int> reverse_map)
		{
			return 0;
		}

		// Token: 0x06002826 RID: 10278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002826")]
		[Address(RVA = "0x26B63B0", Offset = "0x26B63B0", VA = "0x26B63B0")]
		public ObjectPool()
		{
		}

		// Token: 0x040023C2 RID: 9154
		[Token(Token = "0x40023C2")]
		private const int LIST_END = -1;

		// Token: 0x040023C3 RID: 9155
		[Token(Token = "0x40023C3")]
		private const int ALLOCED = -2;

		// Token: 0x040023C4 RID: 9156
		[Token(Token = "0x40023C4")]
		[FieldOffset(Offset = "0x10")]
		private ObjectPool.Slot[] list;

		// Token: 0x040023C5 RID: 9157
		[Token(Token = "0x40023C5")]
		[FieldOffset(Offset = "0x18")]
		private int freelist;

		// Token: 0x040023C6 RID: 9158
		[Token(Token = "0x40023C6")]
		[FieldOffset(Offset = "0x1C")]
		private int count;

		// Token: 0x0200053C RID: 1340
		[Token(Token = "0x200053C")]
		private struct Slot
		{
			// Token: 0x06002827 RID: 10279 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002827")]
			[Address(RVA = "0x26B604C", Offset = "0x26B604C", VA = "0x26B604C")]
			public Slot(int next, object obj)
			{
			}

			// Token: 0x040023C7 RID: 9159
			[Token(Token = "0x40023C7")]
			[FieldOffset(Offset = "0x0")]
			public int next;

			// Token: 0x040023C8 RID: 9160
			[Token(Token = "0x40023C8")]
			[FieldOffset(Offset = "0x8")]
			public object obj;
		}
	}
}
