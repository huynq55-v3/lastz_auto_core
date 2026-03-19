using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Google.Protobuf.Collections
{
	// Token: 0x02000C08 RID: 3080
	[Token(Token = "0x2000C08")]
	internal sealed class ReadOnlyDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
	{
		// Token: 0x0600756B RID: 30059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600756B")]
		public ReadOnlyDictionary(IDictionary<TKey, TValue> wrapped)
		{
		}

		// Token: 0x0600756C RID: 30060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600756C")]
		public void Add(TKey key, TValue value)
		{
		}

		// Token: 0x0600756D RID: 30061 RVA: 0x00051B10 File Offset: 0x0004FD10
		[Token(Token = "0x600756D")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x0600756E RID: 30062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A46")]
		public ICollection<TKey> Keys
		{
			[Token(Token = "0x600756E")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600756F RID: 30063 RVA: 0x00051B28 File Offset: 0x0004FD28
		[Token(Token = "0x600756F")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		// Token: 0x06007570 RID: 30064 RVA: 0x00051B40 File Offset: 0x0004FD40
		[Token(Token = "0x6007570")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06007571 RID: 30065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A47")]
		public ICollection<TValue> Values
		{
			[Token(Token = "0x6007571")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A48 RID: 2632
		[Token(Token = "0x17000A48")]
		public TValue this[TKey key]
		{
			[Token(Token = "0x6007572")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007573")]
			set
			{
			}
		}

		// Token: 0x06007574 RID: 30068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007574")]
		public void Add(KeyValuePair<TKey, TValue> item)
		{
		}

		// Token: 0x06007575 RID: 30069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007575")]
		public void Clear()
		{
		}

		// Token: 0x06007576 RID: 30070 RVA: 0x00051B58 File Offset: 0x0004FD58
		[Token(Token = "0x6007576")]
		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		// Token: 0x06007577 RID: 30071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007577")]
		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06007578 RID: 30072 RVA: 0x00051B70 File Offset: 0x0004FD70
		[Token(Token = "0x17000A49")]
		public int Count
		{
			[Token(Token = "0x6007578")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06007579 RID: 30073 RVA: 0x00051B88 File Offset: 0x0004FD88
		[Token(Token = "0x17000A4A")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6007579")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600757A RID: 30074 RVA: 0x00051BA0 File Offset: 0x0004FDA0
		[Token(Token = "0x600757A")]
		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		// Token: 0x0600757B RID: 30075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600757B")]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600757C RID: 30076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600757C")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600757D RID: 30077 RVA: 0x00051BB8 File Offset: 0x0004FDB8
		[Token(Token = "0x600757D")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600757E RID: 30078 RVA: 0x00051BD0 File Offset: 0x0004FDD0
		[Token(Token = "0x600757E")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600757F RID: 30079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600757F")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04002FCF RID: 12239
		[Token(Token = "0x4002FCF")]
		[FieldOffset(Offset = "0x0")]
		private readonly IDictionary<TKey, TValue> wrapped;
	}
}
