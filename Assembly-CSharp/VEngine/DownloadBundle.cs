using System;
using Il2CppDummyDll;
using UnityEngine;

namespace VEngine
{
	// Token: 0x020009D7 RID: 2519
	[Token(Token = "0x20009D7")]
	internal class DownloadBundle : Bundle
	{
		// Token: 0x0600607C RID: 24700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600607C")]
		[Address(RVA = "0x14048E4", Offset = "0x14048E4", VA = "0x14048E4", Slot = "9")]
		public override void LoadImmediate()
		{
		}

		// Token: 0x0600607D RID: 24701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600607D")]
		[Address(RVA = "0x1404AE8", Offset = "0x1404AE8", VA = "0x1404AE8", Slot = "6")]
		protected override void OnLoad()
		{
		}

		// Token: 0x0600607E RID: 24702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600607E")]
		[Address(RVA = "0x1404CC0", Offset = "0x1404CC0", VA = "0x1404CC0")]
		private void OnDownloaded(Download obj)
		{
		}

		// Token: 0x0600607F RID: 24703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600607F")]
		[Address(RVA = "0x1404DEC", Offset = "0x1404DEC", VA = "0x1404DEC", Slot = "5")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x06006080 RID: 24704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006080")]
		[Address(RVA = "0x1404F88", Offset = "0x1404F88", VA = "0x1404F88", Slot = "12")]
		protected override void ForceStop()
		{
		}

		// Token: 0x06006081 RID: 24705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006081")]
		[Address(RVA = "0x14041B8", Offset = "0x14041B8", VA = "0x14041B8")]
		public DownloadBundle()
		{
		}

		// Token: 0x04002559 RID: 9561
		[Token(Token = "0x4002559")]
		[FieldOffset(Offset = "0x50")]
		private Download download;

		// Token: 0x0400255A RID: 9562
		[Token(Token = "0x400255A")]
		[FieldOffset(Offset = "0x58")]
		private AssetBundleCreateRequest request;
	}
}
