using System;
using Il2CppDummyDll;

namespace EnhancedUI
{
	// Token: 0x020004C7 RID: 1223
	[Token(Token = "0x20004C7")]
	public class SmallList<T>
	{
		// Token: 0x170005A0 RID: 1440
		[Token(Token = "0x170005A0")]
		public T this[int i]
		{
			[Token(Token = "0x60024E7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024E8")]
			set
			{
			}
		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E9")]
		private void ResizeArray()
		{
		}

		// Token: 0x060024EA RID: 9450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024EA")]
		public void Clear()
		{
		}

		// Token: 0x060024EB RID: 9451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024EB")]
		public T First()
		{
			return null;
		}

		// Token: 0x060024EC RID: 9452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024EC")]
		public T Last()
		{
			return null;
		}

		// Token: 0x060024ED RID: 9453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024ED")]
		public void Add(T item)
		{
		}

		// Token: 0x060024EE RID: 9454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024EE")]
		public void AddStart(T item)
		{
		}

		// Token: 0x060024EF RID: 9455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024EF")]
		public void Insert(T item, int index)
		{
		}

		// Token: 0x060024F0 RID: 9456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F0")]
		public T RemoveStart()
		{
			return null;
		}

		// Token: 0x060024F1 RID: 9457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F1")]
		public T RemoveAt(int index)
		{
			return null;
		}

		// Token: 0x060024F2 RID: 9458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F2")]
		public T Remove(T item)
		{
			return null;
		}

		// Token: 0x060024F3 RID: 9459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F3")]
		public T RemoveEnd()
		{
			return null;
		}

		// Token: 0x060024F4 RID: 9460 RVA: 0x0000DFC8 File Offset: 0x0000C1C8
		[Token(Token = "0x60024F4")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		// Token: 0x060024F5 RID: 9461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F5")]
		public SmallList()
		{
		}

		// Token: 0x040021EC RID: 8684
		[Token(Token = "0x40021EC")]
		[FieldOffset(Offset = "0x0")]
		public T[] data;

		// Token: 0x040021ED RID: 8685
		[Token(Token = "0x40021ED")]
		[FieldOffset(Offset = "0x0")]
		public int Count;
	}
}
