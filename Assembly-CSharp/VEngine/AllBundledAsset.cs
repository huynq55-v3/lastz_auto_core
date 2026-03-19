using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace VEngine
{
	// Token: 0x020009D4 RID: 2516
	[Token(Token = "0x20009D4")]
	public class AllBundledAsset : Asset
	{
		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x0600605C RID: 24668 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600605D RID: 24669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000601")]
		public Object[] assets
		{
			[Token(Token = "0x600605C")]
			[Address(RVA = "0x1402F18", Offset = "0x1402F18", VA = "0x1402F18")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600605D")]
			[Address(RVA = "0x1402F20", Offset = "0x1402F20", VA = "0x1402F20")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600605E RID: 24670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600605E")]
		[Address(RVA = "0x1400ADC", Offset = "0x1400ADC", VA = "0x1400ADC")]
		internal static AllBundledAsset Create(string bundle_path)
		{
			return null;
		}

		// Token: 0x0600605F RID: 24671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600605F")]
		[Address(RVA = "0x1402F7C", Offset = "0x1402F7C", VA = "0x1402F7C", Slot = "6")]
		protected override void OnLoad()
		{
		}

		// Token: 0x06006060 RID: 24672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006060")]
		[Address(RVA = "0x140300C", Offset = "0x140300C", VA = "0x140300C", Slot = "7")]
		protected override void OnUnload()
		{
		}

		// Token: 0x06006061 RID: 24673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006061")]
		[Address(RVA = "0x1403090", Offset = "0x1403090", VA = "0x1403090", Slot = "9")]
		public override void LoadImmediate()
		{
		}

		// Token: 0x06006062 RID: 24674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006062")]
		[Address(RVA = "0x14031FC", Offset = "0x14031FC", VA = "0x14031FC", Slot = "5")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x06006063 RID: 24675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006063")]
		[Address(RVA = "0x140321C", Offset = "0x140321C", VA = "0x140321C")]
		private void UpdateLoading()
		{
		}

		// Token: 0x06006064 RID: 24676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006064")]
		[Address(RVA = "0x14032F8", Offset = "0x14032F8", VA = "0x14032F8")]
		private void UpdateDependencies()
		{
		}

		// Token: 0x06006065 RID: 24677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006065")]
		[Address(RVA = "0x1402F28", Offset = "0x1402F28", VA = "0x1402F28")]
		public AllBundledAsset()
		{
		}

		// Token: 0x0400254F RID: 9551
		[Token(Token = "0x400254F")]
		[FieldOffset(Offset = "0x58")]
		private AllBundledDependencies dependencies;

		// Token: 0x04002550 RID: 9552
		[Token(Token = "0x4002550")]
		[FieldOffset(Offset = "0x60")]
		private AssetBundleRequest request;
	}
}
