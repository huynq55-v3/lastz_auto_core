using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace VEngine
{
	// Token: 0x020009DA RID: 2522
	[Token(Token = "0x20009DA")]
	public class Loadable
	{
		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06006094 RID: 24724 RVA: 0x0004B2E8 File Offset: 0x000494E8
		// (set) Token: 0x06006095 RID: 24725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000604")]
		public LoadableStatus status
		{
			[Token(Token = "0x6006094")]
			[Address(RVA = "0x14069D4", Offset = "0x14069D4", VA = "0x14069D4")]
			[CompilerGenerated]
			get
			{
				return LoadableStatus.Wait;
			}
			[Token(Token = "0x6006095")]
			[Address(RVA = "0x14069DC", Offset = "0x14069DC", VA = "0x14069DC")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06006096 RID: 24726 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006097 RID: 24727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000605")]
		public string pathOrURL
		{
			[Token(Token = "0x6006096")]
			[Address(RVA = "0x14069E4", Offset = "0x14069E4", VA = "0x14069E4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006097")]
			[Address(RVA = "0x14069EC", Offset = "0x14069EC", VA = "0x14069EC")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06006098 RID: 24728 RVA: 0x0004B300 File Offset: 0x00049500
		// (set) Token: 0x06006099 RID: 24729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000606")]
		protected bool mustCompleteOnNextFrame
		{
			[Token(Token = "0x6006098")]
			[Address(RVA = "0x14069F4", Offset = "0x14069F4", VA = "0x14069F4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006099")]
			[Address(RVA = "0x14069FC", Offset = "0x14069FC", VA = "0x14069FC")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x0600609A RID: 24730 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600609B RID: 24731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000607")]
		public string error
		{
			[Token(Token = "0x600609A")]
			[Address(RVA = "0x1406A08", Offset = "0x1406A08", VA = "0x1406A08")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600609B")]
			[Address(RVA = "0x1406A10", Offset = "0x1406A10", VA = "0x1406A10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x0600609C RID: 24732 RVA: 0x0004B318 File Offset: 0x00049518
		[Token(Token = "0x17000608")]
		public bool isError
		{
			[Token(Token = "0x600609C")]
			[Address(RVA = "0x1406A18", Offset = "0x1406A18", VA = "0x1406A18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x0600609D RID: 24733 RVA: 0x0004B330 File Offset: 0x00049530
		[Token(Token = "0x17000609")]
		public bool isDone
		{
			[Token(Token = "0x600609D")]
			[Address(RVA = "0x14004CC", Offset = "0x14004CC", VA = "0x14004CC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x0600609E RID: 24734 RVA: 0x0004B348 File Offset: 0x00049548
		// (set) Token: 0x0600609F RID: 24735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700060A")]
		protected internal bool keepAliveOnLoad
		{
			[Token(Token = "0x600609E")]
			[Address(RVA = "0x1406A38", Offset = "0x1406A38", VA = "0x1406A38")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600609F")]
			[Address(RVA = "0x1406A40", Offset = "0x1406A40", VA = "0x1406A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x060060A0 RID: 24736 RVA: 0x0004B360 File Offset: 0x00049560
		// (set) Token: 0x060060A1 RID: 24737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700060B")]
		public float progress
		{
			[Token(Token = "0x60060A0")]
			[Address(RVA = "0x1406A4C", Offset = "0x1406A4C", VA = "0x1406A4C")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60060A1")]
			[Address(RVA = "0x1406A54", Offset = "0x1406A54", VA = "0x1406A54")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060060A2 RID: 24738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060A2")]
		[Address(RVA = "0x1406A5C", Offset = "0x1406A5C", VA = "0x1406A5C", Slot = "4")]
		public virtual void SetPriority(int priority)
		{
		}

		// Token: 0x060060A3 RID: 24739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060A3")]
		[Address(RVA = "0x14029FC", Offset = "0x14029FC", VA = "0x14029FC")]
		protected void Finish([Optional] string errorCode)
		{
		}

		// Token: 0x060060A4 RID: 24740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060A4")]
		[Address(RVA = "0x1406A60", Offset = "0x1406A60", VA = "0x1406A60")]
		public static void UpdateLoadables()
		{
		}

		// Token: 0x060060A5 RID: 24741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060A5")]
		[Address(RVA = "0x1407034", Offset = "0x1407034", VA = "0x1407034")]
		internal static void ClearAll()
		{
		}

		// Token: 0x060060A6 RID: 24742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060A6")]
		[Address(RVA = "0x1407178", Offset = "0x1407178", VA = "0x1407178")]
		internal static void Add(Loadable loadable)
		{
		}

		// Token: 0x060060A7 RID: 24743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060A7")]
		[Address(RVA = "0x1406E98", Offset = "0x1406E98", VA = "0x1406E98")]
		internal void Update()
		{
		}

		// Token: 0x060060A8 RID: 24744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060A8")]
		[Address(RVA = "0x1406EA4", Offset = "0x1406EA4", VA = "0x1406EA4")]
		internal void Complete()
		{
		}

		// Token: 0x060060A9 RID: 24745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060A9")]
		[Address(RVA = "0x140732C", Offset = "0x140732C", VA = "0x140732C", Slot = "5")]
		protected virtual void OnUpdate()
		{
		}

		// Token: 0x060060AA RID: 24746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060AA")]
		[Address(RVA = "0x1407330", Offset = "0x1407330", VA = "0x1407330", Slot = "6")]
		protected virtual void OnLoad()
		{
		}

		// Token: 0x060060AB RID: 24747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060AB")]
		[Address(RVA = "0x1407334", Offset = "0x1407334", VA = "0x1407334", Slot = "7")]
		protected virtual void OnUnload()
		{
		}

		// Token: 0x060060AC RID: 24748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060AC")]
		[Address(RVA = "0x1407338", Offset = "0x1407338", VA = "0x1407338", Slot = "8")]
		protected virtual void OnComplete()
		{
		}

		// Token: 0x060060AD RID: 24749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060AD")]
		[Address(RVA = "0x140733C", Offset = "0x140733C", VA = "0x140733C", Slot = "9")]
		public virtual void LoadImmediate()
		{
		}

		// Token: 0x060060AE RID: 24750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060AE")]
		[Address(RVA = "0x140737C", Offset = "0x140737C", VA = "0x140737C", Slot = "10")]
		public virtual void KeepAliveOnLoad(bool keepAlive = true)
		{
		}

		// Token: 0x060060AF RID: 24751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060AF")]
		[Address(RVA = "0x1400B48", Offset = "0x1400B48", VA = "0x1400B48")]
		protected internal void Load()
		{
		}

		// Token: 0x060060B0 RID: 24752 RVA: 0x0004B378 File Offset: 0x00049578
		[Token(Token = "0x60060B0")]
		[Address(RVA = "0x14011DC", Offset = "0x14011DC", VA = "0x14011DC")]
		protected internal bool Unload()
		{
			return default(bool);
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x060060B1 RID: 24753 RVA: 0x0004B390 File Offset: 0x00049590
		[Token(Token = "0x1700060C")]
		public int referenceCount
		{
			[Token(Token = "0x60060B1")]
			[Address(RVA = "0x1401DAC", Offset = "0x1401DAC", VA = "0x1401DAC")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060060B2 RID: 24754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060B2")]
		[Address(RVA = "0x14062B4", Offset = "0x14062B4", VA = "0x14062B4")]
		public void Release()
		{
		}

		// Token: 0x060060B3 RID: 24755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060B3")]
		[Address(RVA = "0x14073DC", Offset = "0x14073DC", VA = "0x14073DC", Slot = "11")]
		protected virtual void OnUnused()
		{
		}

		// Token: 0x060060B4 RID: 24756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060B4")]
		[Address(RVA = "0x14073E0", Offset = "0x14073E0", VA = "0x14073E0", Slot = "12")]
		protected virtual void ForceStop()
		{
		}

		// Token: 0x060060B5 RID: 24757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060B5")]
		[Address(RVA = "0x14073E4", Offset = "0x14073E4", VA = "0x14073E4")]
		public static void ForceUnloadLoading()
		{
		}

		// Token: 0x060060B6 RID: 24758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060B6")]
		[Address(RVA = "0x1402258", Offset = "0x1402258", VA = "0x1402258")]
		public Loadable()
		{
		}

		// Token: 0x0400255E RID: 9566
		[Token(Token = "0x400255E")]
		[FieldOffset(Offset = "0x0")]
		public static uint BundleEncodeOffset;

		// Token: 0x0400255F RID: 9567
		[Token(Token = "0x400255F")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly List<Loadable> Loading;

		// Token: 0x04002560 RID: 9568
		[Token(Token = "0x4002560")]
		[FieldOffset(Offset = "0x10")]
		public static ThreadPriority CurPriority;

		// Token: 0x04002561 RID: 9569
		[Token(Token = "0x4002561")]
		[FieldOffset(Offset = "0x18")]
		public static double CurSetTime;

		// Token: 0x04002562 RID: 9570
		[Token(Token = "0x4002562")]
		[FieldOffset(Offset = "0x10")]
		protected readonly Reference reference;
	}
}
