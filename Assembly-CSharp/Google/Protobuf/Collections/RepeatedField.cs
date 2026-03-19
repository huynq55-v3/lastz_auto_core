using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Google.Protobuf.Collections
{
	// Token: 0x02000C09 RID: 3081
	[Token(Token = "0x2000C09")]
	public sealed class RepeatedField<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IDeepCloneable<RepeatedField<T>>, IEquatable<RepeatedField<T>>, IReadOnlyList<T>, IReadOnlyCollection<T>
	{
		// Token: 0x06007580 RID: 30080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007580")]
		public RepeatedField<T> Clone()
		{
			return null;
		}

		// Token: 0x06007581 RID: 30081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007581")]
		public void AddEntriesFrom(CodedInputStream input, FieldCodec<T> codec)
		{
		}

		// Token: 0x06007582 RID: 30082 RVA: 0x00051BE8 File Offset: 0x0004FDE8
		[Token(Token = "0x6007582")]
		public int CalculateSize(FieldCodec<T> codec)
		{
			return 0;
		}

		// Token: 0x06007583 RID: 30083 RVA: 0x00051C00 File Offset: 0x0004FE00
		[Token(Token = "0x6007583")]
		private int CalculatePackedDataSize(FieldCodec<T> codec)
		{
			return 0;
		}

		// Token: 0x06007584 RID: 30084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007584")]
		public void WriteTo(CodedOutputStream output, FieldCodec<T> codec)
		{
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06007585 RID: 30085 RVA: 0x00051C18 File Offset: 0x0004FE18
		// (set) Token: 0x06007586 RID: 30086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A4B")]
		public int Capacity
		{
			[Token(Token = "0x6007585")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6007586")]
			set
			{
			}
		}

		// Token: 0x06007587 RID: 30087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007587")]
		private void EnsureSize(int size)
		{
		}

		// Token: 0x06007588 RID: 30088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007588")]
		private void SetSize(int size)
		{
		}

		// Token: 0x06007589 RID: 30089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007589")]
		public void Add(T item)
		{
		}

		// Token: 0x0600758A RID: 30090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600758A")]
		public void Clear()
		{
		}

		// Token: 0x0600758B RID: 30091 RVA: 0x00051C30 File Offset: 0x0004FE30
		[Token(Token = "0x600758B")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		// Token: 0x0600758C RID: 30092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600758C")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		// Token: 0x0600758D RID: 30093 RVA: 0x00051C48 File Offset: 0x0004FE48
		[Token(Token = "0x600758D")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x0600758E RID: 30094 RVA: 0x00051C60 File Offset: 0x0004FE60
		[Token(Token = "0x17000A4C")]
		public int Count
		{
			[Token(Token = "0x600758E")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x0600758F RID: 30095 RVA: 0x00051C78 File Offset: 0x0004FE78
		[Token(Token = "0x17000A4D")]
		public bool IsReadOnly
		{
			[Token(Token = "0x600758F")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007590 RID: 30096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007590")]
		public void AddRange(IEnumerable<T> values)
		{
		}

		// Token: 0x06007591 RID: 30097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007591")]
		public void Add(IEnumerable<T> values)
		{
		}

		// Token: 0x06007592 RID: 30098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007592")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06007593 RID: 30099 RVA: 0x00051C90 File Offset: 0x0004FE90
		[Token(Token = "0x6007593")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06007594 RID: 30100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007594")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x06007595 RID: 30101 RVA: 0x00051CA8 File Offset: 0x0004FEA8
		[Token(Token = "0x6007595")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007596 RID: 30102 RVA: 0x00051CC0 File Offset: 0x0004FEC0
		[Token(Token = "0x6007596")]
		public bool Equals(RepeatedField<T> other)
		{
			return default(bool);
		}

		// Token: 0x06007597 RID: 30103 RVA: 0x00051CD8 File Offset: 0x0004FED8
		[Token(Token = "0x6007597")]
		public int IndexOf(T item)
		{
			return 0;
		}

		// Token: 0x06007598 RID: 30104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007598")]
		public void Insert(int index, T item)
		{
		}

		// Token: 0x06007599 RID: 30105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007599")]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x0600759A RID: 30106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600759A")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x17000A4E RID: 2638
		[Token(Token = "0x17000A4E")]
		public T this[int index]
		{
			[Token(Token = "0x600759B")]
			get
			{
				return null;
			}
			[Token(Token = "0x600759C")]
			set
			{
			}
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x0600759D RID: 30109 RVA: 0x00051CF0 File Offset: 0x0004FEF0
		[Token(Token = "0x17000A4F")]
		private bool System.Collections.IList.IsFixedSize
		{
			[Token(Token = "0x600759D")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600759E RID: 30110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600759E")]
		private void System.Collections.ICollection.CopyTo(Array array, int index)
		{
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x0600759F RID: 30111 RVA: 0x00051D08 File Offset: 0x0004FF08
		[Token(Token = "0x17000A50")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[Token(Token = "0x600759F")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x060075A0 RID: 30112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A51")]
		private object System.Collections.ICollection.SyncRoot
		{
			[Token(Token = "0x60075A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x060075A1 RID: 30113 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060075A2 RID: 30114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A52")]
		private object System.Collections.IList.Item
		{
			[Token(Token = "0x60075A1")]
			get
			{
				return null;
			}
			[Token(Token = "0x60075A2")]
			set
			{
			}
		}

		// Token: 0x060075A3 RID: 30115 RVA: 0x00051D20 File Offset: 0x0004FF20
		[Token(Token = "0x60075A3")]
		private int System.Collections.IList.Add(object value)
		{
			return 0;
		}

		// Token: 0x060075A4 RID: 30116 RVA: 0x00051D38 File Offset: 0x0004FF38
		[Token(Token = "0x60075A4")]
		private bool System.Collections.IList.Contains(object value)
		{
			return default(bool);
		}

		// Token: 0x060075A5 RID: 30117 RVA: 0x00051D50 File Offset: 0x0004FF50
		[Token(Token = "0x60075A5")]
		private int System.Collections.IList.IndexOf(object value)
		{
			return 0;
		}

		// Token: 0x060075A6 RID: 30118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075A6")]
		private void System.Collections.IList.Insert(int index, object value)
		{
		}

		// Token: 0x060075A7 RID: 30119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075A7")]
		private void System.Collections.IList.Remove(object value)
		{
		}

		// Token: 0x060075A8 RID: 30120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075A8")]
		public RepeatedField()
		{
		}

		// Token: 0x04002FD0 RID: 12240
		[Token(Token = "0x4002FD0")]
		[FieldOffset(Offset = "0x0")]
		private static readonly EqualityComparer<T> EqualityComparer;

		// Token: 0x04002FD1 RID: 12241
		[Token(Token = "0x4002FD1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly T[] EmptyArray;

		// Token: 0x04002FD2 RID: 12242
		[Token(Token = "0x4002FD2")]
		private const int MinArraySize = 8;

		// Token: 0x04002FD3 RID: 12243
		[Token(Token = "0x4002FD3")]
		[FieldOffset(Offset = "0x0")]
		private T[] array;

		// Token: 0x04002FD4 RID: 12244
		[Token(Token = "0x4002FD4")]
		[FieldOffset(Offset = "0x0")]
		private int count;
	}
}
