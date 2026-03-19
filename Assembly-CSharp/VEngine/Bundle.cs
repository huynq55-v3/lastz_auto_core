using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace VEngine
{
	// Token: 0x020009D6 RID: 2518
	[Token(Token = "0x20009D6")]
	public class Bundle : Loadable
	{
		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06006071 RID: 24689 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006072 RID: 24690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000602")]
		protected internal AssetBundle assetBundle
		{
			[Token(Token = "0x6006071")]
			[Address(RVA = "0x1403EAC", Offset = "0x1403EAC", VA = "0x1403EAC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006072")]
			[Address(RVA = "0x1403EB4", Offset = "0x1403EB4", VA = "0x1403EB4")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06006073 RID: 24691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006073")]
		[Address(RVA = "0x1403EBC", Offset = "0x1403EBC", VA = "0x1403EBC")]
		public BundleInfo GetInfo()
		{
			return null;
		}

		// Token: 0x06006074 RID: 24692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006074")]
		[Address(RVA = "0x1403EC4", Offset = "0x1403EC4", VA = "0x1403EC4", Slot = "11")]
		protected override void OnUnused()
		{
		}

		// Token: 0x06006075 RID: 24693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006075")]
		[Address(RVA = "0x1402AC0", Offset = "0x1402AC0", VA = "0x1402AC0")]
		internal static Bundle LoadInternal(BundleInfo info, bool mustCompleteOnNextFrame)
		{
			return null;
		}

		// Token: 0x06006076 RID: 24694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006076")]
		[Address(RVA = "0x14042FC", Offset = "0x14042FC", VA = "0x14042FC")]
		internal static void UpdateBundles()
		{
		}

		// Token: 0x06006077 RID: 24695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006077")]
		[Address(RVA = "0x1401598", Offset = "0x1401598", VA = "0x1401598")]
		public static void UnloadUnusedBundles()
		{
		}

		// Token: 0x06006078 RID: 24696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006078")]
		[Address(RVA = "0x14045F4", Offset = "0x14045F4", VA = "0x14045F4")]
		public static void DebugOutputCache()
		{
		}

		// Token: 0x06006079 RID: 24697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006079")]
		[Address(RVA = "0x14045F8", Offset = "0x14045F8", VA = "0x14045F8", Slot = "7")]
		protected override void OnUnload()
		{
		}

		// Token: 0x0600607A RID: 24698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600607A")]
		[Address(RVA = "0x14047A4", Offset = "0x14047A4", VA = "0x14047A4")]
		public Bundle()
		{
		}

		// Token: 0x04002555 RID: 9557
		[Token(Token = "0x4002555")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Dictionary<string, Bundle> Cache;

		// Token: 0x04002556 RID: 9558
		[Token(Token = "0x4002556")]
		[FieldOffset(Offset = "0x8")]
		public static readonly List<Bundle> Unused;

		// Token: 0x04002557 RID: 9559
		[Token(Token = "0x4002557")]
		[FieldOffset(Offset = "0x40")]
		protected BundleInfo info;
	}
}
