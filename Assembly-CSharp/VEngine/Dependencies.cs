using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace VEngine
{
	// Token: 0x020009D9 RID: 2521
	[Token(Token = "0x20009D9")]
	public class Dependencies : Loadable
	{
		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x0600608C RID: 24716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000603")]
		internal AssetBundle assetBundle
		{
			[Token(Token = "0x600608C")]
			[Address(RVA = "0x14031E4", Offset = "0x14031E4", VA = "0x14031E4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600608D RID: 24717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600608D")]
		[Address(RVA = "0x1405B60", Offset = "0x1405B60", VA = "0x1405B60", Slot = "6")]
		protected override void OnLoad()
		{
		}

		// Token: 0x0600608E RID: 24718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600608E")]
		[Address(RVA = "0x1405E10", Offset = "0x1405E10", VA = "0x1405E10", Slot = "9")]
		public override void LoadImmediate()
		{
		}

		// Token: 0x0600608F RID: 24719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600608F")]
		[Address(RVA = "0x1405F70", Offset = "0x1405F70", VA = "0x1405F70", Slot = "10")]
		public override void KeepAliveOnLoad(bool keepAlive = true)
		{
		}

		// Token: 0x06006090 RID: 24720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006090")]
		[Address(RVA = "0x14060DC", Offset = "0x14060DC", VA = "0x14060DC", Slot = "7")]
		protected override void OnUnload()
		{
		}

		// Token: 0x06006091 RID: 24721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006091")]
		[Address(RVA = "0x14065E4", Offset = "0x14065E4", VA = "0x14065E4", Slot = "5")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x06006092 RID: 24722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006092")]
		[Address(RVA = "0x140687C", Offset = "0x140687C", VA = "0x140687C", Slot = "4")]
		public override void SetPriority(int priority)
		{
		}

		// Token: 0x06006093 RID: 24723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006093")]
		[Address(RVA = "0x1402E70", Offset = "0x1402E70", VA = "0x1402E70")]
		public Dependencies()
		{
		}

		// Token: 0x0400255C RID: 9564
		[Token(Token = "0x400255C")]
		[FieldOffset(Offset = "0x40")]
		internal readonly List<Bundle> bundles;

		// Token: 0x0400255D RID: 9565
		[Token(Token = "0x400255D")]
		[FieldOffset(Offset = "0x48")]
		internal Bundle bundle;
	}
}
