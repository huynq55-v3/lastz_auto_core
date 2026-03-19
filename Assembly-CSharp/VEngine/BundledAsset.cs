using System;
using Il2CppDummyDll;
using UnityEngine;

namespace VEngine
{
	// Token: 0x020009D5 RID: 2517
	[Token(Token = "0x20009D5")]
	public class BundledAsset : Asset
	{
		// Token: 0x06006066 RID: 24678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006066")]
		[Address(RVA = "0x1403404", Offset = "0x1403404", VA = "0x1403404")]
		internal static BundledAsset Create(string path, Type type)
		{
			return null;
		}

		// Token: 0x06006067 RID: 24679 RVA: 0x0004B2B8 File Offset: 0x000494B8
		[Token(Token = "0x6006067")]
		[Address(RVA = "0x14034E0", Offset = "0x14034E0", VA = "0x14034E0")]
		internal static bool IsAssetDownloaded(string path)
		{
			return default(bool);
		}

		// Token: 0x06006068 RID: 24680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006068")]
		[Address(RVA = "0x1403830", Offset = "0x1403830", VA = "0x1403830", Slot = "6")]
		protected override void OnLoad()
		{
		}

		// Token: 0x06006069 RID: 24681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006069")]
		[Address(RVA = "0x14038C0", Offset = "0x14038C0", VA = "0x14038C0", Slot = "7")]
		protected override void OnUnload()
		{
		}

		// Token: 0x0600606A RID: 24682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600606A")]
		[Address(RVA = "0x1403934", Offset = "0x1403934", VA = "0x1403934", Slot = "9")]
		public override void LoadImmediate()
		{
		}

		// Token: 0x0600606B RID: 24683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600606B")]
		[Address(RVA = "0x1403C14", Offset = "0x1403C14", VA = "0x1403C14", Slot = "5")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x0600606C RID: 24684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600606C")]
		[Address(RVA = "0x1403C34", Offset = "0x1403C34", VA = "0x1403C34")]
		private void UpdateLoading()
		{
		}

		// Token: 0x0600606D RID: 24685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600606D")]
		[Address(RVA = "0x1403D44", Offset = "0x1403D44", VA = "0x1403D44")]
		private void UpdateDependencies()
		{
		}

		// Token: 0x0600606E RID: 24686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600606E")]
		[Address(RVA = "0x1403E74", Offset = "0x1403E74", VA = "0x1403E74", Slot = "16")]
		public override Bundle GetOwnerBundle()
		{
			return null;
		}

		// Token: 0x0600606F RID: 24687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600606F")]
		[Address(RVA = "0x1403E8C", Offset = "0x1403E8C", VA = "0x1403E8C", Slot = "4")]
		public override void SetPriority(int priority)
		{
		}

		// Token: 0x06006070 RID: 24688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006070")]
		[Address(RVA = "0x140348C", Offset = "0x140348C", VA = "0x140348C")]
		public BundledAsset()
		{
		}

		// Token: 0x04002552 RID: 9554
		[Token(Token = "0x4002552")]
		[FieldOffset(Offset = "0x58")]
		private Dependencies dependencies;

		// Token: 0x04002553 RID: 9555
		[Token(Token = "0x4002553")]
		[FieldOffset(Offset = "0x60")]
		private AssetBundleRequest request;

		// Token: 0x04002554 RID: 9556
		[Token(Token = "0x4002554")]
		[FieldOffset(Offset = "0x68")]
		private int priority_;
	}
}
