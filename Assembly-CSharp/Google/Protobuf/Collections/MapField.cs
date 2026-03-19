using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Google.Protobuf.Collections
{
	// Token: 0x02000BFC RID: 3068
	[Token(Token = "0x2000BFC")]
	public sealed class MapField<TKey, TValue> : IDeepCloneable<MapField<TKey, TValue>>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IEquatable<MapField<TKey, TValue>>, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>
	{
		// Token: 0x06007506 RID: 29958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007506")]
		public MapField<TKey, TValue> Clone()
		{
			return null;
		}

		// Token: 0x06007507 RID: 29959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007507")]
		public void Add(TKey key, TValue value)
		{
		}

		// Token: 0x06007508 RID: 29960 RVA: 0x000517E0 File Offset: 0x0004F9E0
		[Token(Token = "0x6007508")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		// Token: 0x06007509 RID: 29961 RVA: 0x000517F8 File Offset: 0x0004F9F8
		[Token(Token = "0x6007509")]
		private bool ContainsValue(TValue value)
		{
			return default(bool);
		}

		// Token: 0x0600750A RID: 29962 RVA: 0x00051810 File Offset: 0x0004FA10
		[Token(Token = "0x600750A")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		// Token: 0x0600750B RID: 29963 RVA: 0x00051828 File Offset: 0x0004FA28
		[Token(Token = "0x600750B")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		// Token: 0x17000A29 RID: 2601
		[Token(Token = "0x17000A29")]
		public TValue this[TKey key]
		{
			[Token(Token = "0x600750C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600750D")]
			set
			{
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x0600750E RID: 29966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A2A")]
		public ICollection<TKey> Keys
		{
			[Token(Token = "0x600750E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x0600750F RID: 29967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A2B")]
		public ICollection<TValue> Values
		{
			[Token(Token = "0x600750F")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007510 RID: 29968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007510")]
		public void Add(IDictionary<TKey, TValue> entries)
		{
		}

		// Token: 0x06007511 RID: 29969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007511")]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06007512 RID: 29970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007512")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x06007513 RID: 29971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007513")]
		private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> item)
		{
		}

		// Token: 0x06007514 RID: 29972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007514")]
		public void Clear()
		{
		}

		// Token: 0x06007515 RID: 29973 RVA: 0x00051840 File Offset: 0x0004FA40
		[Token(Token = "0x6007515")]
		private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		// Token: 0x06007516 RID: 29974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007516")]
		private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
		}

		// Token: 0x06007517 RID: 29975 RVA: 0x00051858 File Offset: 0x0004FA58
		[Token(Token = "0x6007517")]
		private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06007518 RID: 29976 RVA: 0x00051870 File Offset: 0x0004FA70
		[Token(Token = "0x17000A2C")]
		public int Count
		{
			[Token(Token = "0x6007518")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06007519 RID: 29977 RVA: 0x00051888 File Offset: 0x0004FA88
		[Token(Token = "0x17000A2D")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6007519")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600751A RID: 29978 RVA: 0x000518A0 File Offset: 0x0004FAA0
		[Token(Token = "0x600751A")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x0600751B RID: 29979 RVA: 0x000518B8 File Offset: 0x0004FAB8
		[Token(Token = "0x600751B")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600751C RID: 29980 RVA: 0x000518D0 File Offset: 0x0004FAD0
		[Token(Token = "0x600751C")]
		public bool Equals(MapField<TKey, TValue> other)
		{
			return default(bool);
		}

		// Token: 0x0600751D RID: 29981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600751D")]
		public void AddEntriesFrom(CodedInputStream input, MapField<TKey, TValue>.Codec codec)
		{
		}

		// Token: 0x0600751E RID: 29982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600751E")]
		public void WriteTo(CodedOutputStream output, MapField<TKey, TValue>.Codec codec)
		{
		}

		// Token: 0x0600751F RID: 29983 RVA: 0x000518E8 File Offset: 0x0004FAE8
		[Token(Token = "0x600751F")]
		public int CalculateSize(MapField<TKey, TValue>.Codec codec)
		{
			return 0;
		}

		// Token: 0x06007520 RID: 29984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007520")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007521 RID: 29985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007521")]
		private void System.Collections.IDictionary.Add(object key, object value)
		{
		}

		// Token: 0x06007522 RID: 29986 RVA: 0x00051900 File Offset: 0x0004FB00
		[Token(Token = "0x6007522")]
		private bool System.Collections.IDictionary.Contains(object key)
		{
			return default(bool);
		}

		// Token: 0x06007523 RID: 29987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007523")]
		private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator()
		{
			return null;
		}

		// Token: 0x06007524 RID: 29988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007524")]
		private void System.Collections.IDictionary.Remove(object key)
		{
		}

		// Token: 0x06007525 RID: 29989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007525")]
		private void System.Collections.ICollection.CopyTo(Array array, int index)
		{
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06007526 RID: 29990 RVA: 0x00051918 File Offset: 0x0004FB18
		[Token(Token = "0x17000A2E")]
		private bool System.Collections.IDictionary.IsFixedSize
		{
			[Token(Token = "0x6007526")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06007527 RID: 29991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A2F")]
		private ICollection System.Collections.IDictionary.Keys
		{
			[Token(Token = "0x6007527")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06007528 RID: 29992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A30")]
		private ICollection System.Collections.IDictionary.Values
		{
			[Token(Token = "0x6007528")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06007529 RID: 29993 RVA: 0x00051930 File Offset: 0x0004FB30
		[Token(Token = "0x17000A31")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[Token(Token = "0x6007529")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x0600752A RID: 29994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A32")]
		private object System.Collections.ICollection.SyncRoot
		{
			[Token(Token = "0x600752A")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x0600752B RID: 29995 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600752C RID: 29996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A33")]
		private object System.Collections.IDictionary.Item
		{
			[Token(Token = "0x600752B")]
			get
			{
				return null;
			}
			[Token(Token = "0x600752C")]
			set
			{
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x0600752D RID: 29997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A34")]
		private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys
		{
			[Token(Token = "0x600752D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x0600752E RID: 29998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A35")]
		private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values
		{
			[Token(Token = "0x600752E")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600752F RID: 29999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600752F")]
		public MapField()
		{
		}

		// Token: 0x04002FB7 RID: 12215
		[Token(Token = "0x4002FB7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly EqualityComparer<TValue> ValueEqualityComparer;

		// Token: 0x04002FB8 RID: 12216
		[Token(Token = "0x4002FB8")]
		[FieldOffset(Offset = "0x0")]
		private static readonly EqualityComparer<TKey> KeyEqualityComparer;

		// Token: 0x04002FB9 RID: 12217
		[Token(Token = "0x4002FB9")]
		[FieldOffset(Offset = "0x0")]
		private readonly Dictionary<TKey, LinkedListNode<KeyValuePair<TKey, TValue>>> map;

		// Token: 0x04002FBA RID: 12218
		[Token(Token = "0x4002FBA")]
		[FieldOffset(Offset = "0x0")]
		private readonly LinkedList<KeyValuePair<TKey, TValue>> list;

		// Token: 0x02000BFD RID: 3069
		[Token(Token = "0x2000BFD")]
		private class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x06007531 RID: 30001 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007531")]
			internal DictionaryEnumerator(IEnumerator<KeyValuePair<TKey, TValue>> enumerator)
			{
			}

			// Token: 0x06007532 RID: 30002 RVA: 0x00051948 File Offset: 0x0004FB48
			[Token(Token = "0x6007532")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06007533 RID: 30003 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007533")]
			public void Reset()
			{
			}

			// Token: 0x17000A36 RID: 2614
			// (get) Token: 0x06007534 RID: 30004 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A36")]
			public object Current
			{
				[Token(Token = "0x6007534")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A37 RID: 2615
			// (get) Token: 0x06007535 RID: 30005 RVA: 0x00051960 File Offset: 0x0004FB60
			[Token(Token = "0x17000A37")]
			public DictionaryEntry Entry
			{
				[Token(Token = "0x6007535")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			// Token: 0x17000A38 RID: 2616
			// (get) Token: 0x06007536 RID: 30006 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A38")]
			public object Key
			{
				[Token(Token = "0x6007536")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A39 RID: 2617
			// (get) Token: 0x06007537 RID: 30007 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A39")]
			public object Value
			{
				[Token(Token = "0x6007537")]
				get
				{
					return null;
				}
			}

			// Token: 0x04002FBB RID: 12219
			[Token(Token = "0x4002FBB")]
			[FieldOffset(Offset = "0x0")]
			private readonly IEnumerator<KeyValuePair<TKey, TValue>> enumerator;
		}

		// Token: 0x02000BFE RID: 3070
		[Token(Token = "0x2000BFE")]
		public sealed class Codec
		{
			// Token: 0x06007538 RID: 30008 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007538")]
			public Codec(FieldCodec<TKey> keyCodec, FieldCodec<TValue> valueCodec, uint mapTag)
			{
			}

			// Token: 0x17000A3A RID: 2618
			// (get) Token: 0x06007539 RID: 30009 RVA: 0x00051978 File Offset: 0x0004FB78
			[Token(Token = "0x17000A3A")]
			internal uint MapTag
			{
				[Token(Token = "0x6007539")]
				get
				{
					return 0U;
				}
			}

			// Token: 0x04002FBC RID: 12220
			[Token(Token = "0x4002FBC")]
			[FieldOffset(Offset = "0x0")]
			private readonly FieldCodec<TKey> keyCodec;

			// Token: 0x04002FBD RID: 12221
			[Token(Token = "0x4002FBD")]
			[FieldOffset(Offset = "0x0")]
			private readonly FieldCodec<TValue> valueCodec;

			// Token: 0x04002FBE RID: 12222
			[Token(Token = "0x4002FBE")]
			[FieldOffset(Offset = "0x0")]
			private readonly uint mapTag;

			// Token: 0x02000BFF RID: 3071
			[Token(Token = "0x2000BFF")]
			internal class MessageAdapter : IMessage
			{
				// Token: 0x17000A3B RID: 2619
				// (get) Token: 0x0600753A RID: 30010 RVA: 0x00002050 File Offset: 0x00000250
				// (set) Token: 0x0600753B RID: 30011 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x17000A3B")]
				internal TKey Key
				{
					[Token(Token = "0x600753A")]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[Token(Token = "0x600753B")]
					[CompilerGenerated]
					set
					{
					}
				}

				// Token: 0x17000A3C RID: 2620
				// (get) Token: 0x0600753C RID: 30012 RVA: 0x00002050 File Offset: 0x00000250
				// (set) Token: 0x0600753D RID: 30013 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x17000A3C")]
				internal TValue Value
				{
					[Token(Token = "0x600753C")]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[Token(Token = "0x600753D")]
					[CompilerGenerated]
					set
					{
					}
				}

				// Token: 0x0600753E RID: 30014 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600753E")]
				internal MessageAdapter(MapField<TKey, TValue>.Codec codec)
				{
				}

				// Token: 0x0600753F RID: 30015 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600753F")]
				internal void Reset()
				{
				}

				// Token: 0x06007540 RID: 30016 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007540")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06007541 RID: 30017 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007541")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06007542 RID: 30018 RVA: 0x00051990 File Offset: 0x0004FB90
				[Token(Token = "0x6007542")]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x17000A3D RID: 2621
				// (get) Token: 0x06007543 RID: 30019 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000A3D")]
				private MessageDescriptor Google.Protobuf.IMessage.Descriptor
				{
					[Token(Token = "0x6007543")]
					get
					{
						return null;
					}
				}

				// Token: 0x04002FBF RID: 12223
				[Token(Token = "0x4002FBF")]
				[FieldOffset(Offset = "0x0")]
				private static readonly byte[] ZeroLengthMessageStreamData;

				// Token: 0x04002FC0 RID: 12224
				[Token(Token = "0x4002FC0")]
				[FieldOffset(Offset = "0x0")]
				private readonly MapField<TKey, TValue>.Codec codec;
			}
		}

		// Token: 0x02000C00 RID: 3072
		[Token(Token = "0x2000C00")]
		private class MapView<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ICollection
		{
			// Token: 0x06007545 RID: 30021 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007545")]
			internal MapView(MapField<TKey, TValue> parent, Func<KeyValuePair<TKey, TValue>, T> projection, Func<T, bool> containsCheck)
			{
			}

			// Token: 0x17000A3E RID: 2622
			// (get) Token: 0x06007546 RID: 30022 RVA: 0x000519A8 File Offset: 0x0004FBA8
			[Token(Token = "0x17000A3E")]
			public int Count
			{
				[Token(Token = "0x6007546")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000A3F RID: 2623
			// (get) Token: 0x06007547 RID: 30023 RVA: 0x000519C0 File Offset: 0x0004FBC0
			[Token(Token = "0x17000A3F")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6007547")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000A40 RID: 2624
			// (get) Token: 0x06007548 RID: 30024 RVA: 0x000519D8 File Offset: 0x0004FBD8
			[Token(Token = "0x17000A40")]
			public bool IsSynchronized
			{
				[Token(Token = "0x6007548")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000A41 RID: 2625
			// (get) Token: 0x06007549 RID: 30025 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A41")]
			public object SyncRoot
			{
				[Token(Token = "0x6007549")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600754A RID: 30026 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600754A")]
			public void Add(T item)
			{
			}

			// Token: 0x0600754B RID: 30027 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600754B")]
			public void Clear()
			{
			}

			// Token: 0x0600754C RID: 30028 RVA: 0x000519F0 File Offset: 0x0004FBF0
			[Token(Token = "0x600754C")]
			public bool Contains(T item)
			{
				return default(bool);
			}

			// Token: 0x0600754D RID: 30029 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600754D")]
			public void CopyTo(T[] array, int arrayIndex)
			{
			}

			// Token: 0x0600754E RID: 30030 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600754E")]
			public IEnumerator<T> GetEnumerator()
			{
				return null;
			}

			// Token: 0x0600754F RID: 30031 RVA: 0x00051A08 File Offset: 0x0004FC08
			[Token(Token = "0x600754F")]
			public bool Remove(T item)
			{
				return default(bool);
			}

			// Token: 0x06007550 RID: 30032 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007550")]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007551 RID: 30033 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007551")]
			public void CopyTo(Array array, int index)
			{
			}

			// Token: 0x04002FC3 RID: 12227
			[Token(Token = "0x4002FC3")]
			[FieldOffset(Offset = "0x0")]
			private readonly MapField<TKey, TValue> parent;

			// Token: 0x04002FC4 RID: 12228
			[Token(Token = "0x4002FC4")]
			[FieldOffset(Offset = "0x0")]
			private readonly Func<KeyValuePair<TKey, TValue>, T> projection;

			// Token: 0x04002FC5 RID: 12229
			[Token(Token = "0x4002FC5")]
			[FieldOffset(Offset = "0x0")]
			private readonly Func<T, bool> containsCheck;
		}
	}
}
