using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace VEngine
{
	// Token: 0x020009D1 RID: 2513
	[Token(Token = "0x20009D1")]
	public class Asset : Loadable, IEnumerator
	{
		// Token: 0x1400000E RID: 14
		// (add) Token: 0x0600603E RID: 24638 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600603F RID: 24639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000E")]
		public event Action<Asset> completed
		{
			[Token(Token = "0x600603E")]
			[Address(RVA = "0x140032C", Offset = "0x140032C", VA = "0x140032C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600603F")]
			[Address(RVA = "0x14003DC", Offset = "0x14003DC", VA = "0x14003DC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06006040 RID: 24640 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006041 RID: 24641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005FE")]
		public Object asset
		{
			[Token(Token = "0x6006040")]
			[Address(RVA = "0x140048C", Offset = "0x140048C", VA = "0x140048C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006041")]
			[Address(RVA = "0x1400494", Offset = "0x1400494", VA = "0x1400494")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06006042 RID: 24642 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006043 RID: 24643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005FF")]
		protected Type type
		{
			[Token(Token = "0x6006042")]
			[Address(RVA = "0x140049C", Offset = "0x140049C", VA = "0x140049C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006043")]
			[Address(RVA = "0x14004A4", Offset = "0x14004A4", VA = "0x14004A4")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06006044 RID: 24644 RVA: 0x0004B270 File Offset: 0x00049470
		[Token(Token = "0x6006044")]
		[Address(RVA = "0x14004AC", Offset = "0x14004AC", VA = "0x14004AC", Slot = "13")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06006045 RID: 24645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006045")]
		[Address(RVA = "0x14004F0", Offset = "0x14004F0", VA = "0x14004F0", Slot = "15")]
		public void Reset()
		{
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06006046 RID: 24646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000600")]
		public object Current
		{
			[Token(Token = "0x6006046")]
			[Address(RVA = "0x14004F4", Offset = "0x14004F4", VA = "0x14004F4", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006047 RID: 24647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006047")]
		public T Get<T>() where T : Object
		{
			return null;
		}

		// Token: 0x06006048 RID: 24648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006048")]
		[Address(RVA = "0x14004FC", Offset = "0x14004FC", VA = "0x14004FC", Slot = "8")]
		protected override void OnComplete()
		{
		}

		// Token: 0x06006049 RID: 24649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006049")]
		[Address(RVA = "0x1400624", Offset = "0x1400624", VA = "0x1400624", Slot = "11")]
		protected override void OnUnused()
		{
		}

		// Token: 0x0600604A RID: 24650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600604A")]
		[Address(RVA = "0x140070C", Offset = "0x140070C", VA = "0x140070C")]
		public static Asset LoadAsync(string path, Type type, [Optional] Action<Asset> completed)
		{
			return null;
		}

		// Token: 0x0600604B RID: 24651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600604B")]
		[Address(RVA = "0x1400A8C", Offset = "0x1400A8C", VA = "0x1400A8C")]
		public static Asset LoadAllAssetsAsync(string bundle_path, [Optional] Action<Asset> completed)
		{
			return null;
		}

		// Token: 0x0600604C RID: 24652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600604C")]
		[Address(RVA = "0x1400BE4", Offset = "0x1400BE4", VA = "0x1400BE4")]
		public static Asset Load(string path, Type type)
		{
			return null;
		}

		// Token: 0x0600604D RID: 24653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600604D")]
		[Address(RVA = "0x140077C", Offset = "0x140077C", VA = "0x140077C")]
		internal static Asset LoadInternal(string path, Type type, bool mustCompleteOnNextFrame, [Optional] Action<Asset> completed)
		{
			return null;
		}

		// Token: 0x0600604E RID: 24654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600604E")]
		[Address(RVA = "0x1400EC4", Offset = "0x1400EC4", VA = "0x1400EC4")]
		public static void UpdateAssets()
		{
		}

		// Token: 0x0600604F RID: 24655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600604F")]
		[Address(RVA = "0x1401218", Offset = "0x1401218", VA = "0x1401218")]
		public static void RemoveCachedUnusedAssets()
		{
		}

		// Token: 0x06006050 RID: 24656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006050")]
		[Address(RVA = "0x14013C0", Offset = "0x14013C0", VA = "0x14013C0")]
		public static void UnloadUnusedAssets()
		{
		}

		// Token: 0x06006051 RID: 24657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006051")]
		[Address(RVA = "0x140196C", Offset = "0x140196C", VA = "0x140196C")]
		public static void DebutOutputCache()
		{
		}

		// Token: 0x06006052 RID: 24658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006052")]
		[Address(RVA = "0x1401DC8", Offset = "0x1401DC8", VA = "0x1401DC8")]
		public static void DebugLoadCount()
		{
		}

		// Token: 0x06006053 RID: 24659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006053")]
		[Address(RVA = "0x14021FC", Offset = "0x14021FC", VA = "0x14021FC", Slot = "16")]
		public virtual Bundle GetOwnerBundle()
		{
			return null;
		}

		// Token: 0x06006054 RID: 24660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006054")]
		[Address(RVA = "0x1402204", Offset = "0x1402204", VA = "0x1402204")]
		public Asset()
		{
		}

		// Token: 0x04002546 RID: 9542
		[Token(Token = "0x4002546")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Dictionary<string, Asset> Cache;

		// Token: 0x04002547 RID: 9543
		[Token(Token = "0x4002547")]
		[FieldOffset(Offset = "0x8")]
		protected internal static readonly List<Asset> Unused;

		// Token: 0x0400254B RID: 9547
		[Token(Token = "0x400254B")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Dictionary<string, int> AssetLoadCountDict;
	}
}
