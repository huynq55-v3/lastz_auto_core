using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace VEngine
{
	// Token: 0x020009EE RID: 2542
	[Token(Token = "0x20009EE")]
	public sealed class InitializeVersions : Operation
	{
		// Token: 0x06006153 RID: 24915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006153")]
		[Address(RVA = "0x1410E6C", Offset = "0x1410E6C", VA = "0x1410E6C", Slot = "8")]
		public override void Start()
		{
		}

		// Token: 0x06006154 RID: 24916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006154")]
		[Address(RVA = "0x1410FA4", Offset = "0x1410FA4", VA = "0x1410FA4", Slot = "7")]
		protected override void Update()
		{
		}

		// Token: 0x06006155 RID: 24917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006155")]
		[Address(RVA = "0x141137C", Offset = "0x141137C", VA = "0x141137C")]
		public InitializeVersions()
		{
		}

		// Token: 0x040025D4 RID: 9684
		[Token(Token = "0x40025D4")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<ManifestFile> assets;

		// Token: 0x040025D5 RID: 9685
		[Token(Token = "0x40025D5")]
		[FieldOffset(Offset = "0x38")]
		private readonly List<string> errors;

		// Token: 0x040025D6 RID: 9686
		[Token(Token = "0x40025D6")]
		[FieldOffset(Offset = "0x40")]
		public string[] manifests;

		// Token: 0x040025D7 RID: 9687
		[Token(Token = "0x40025D7")]
		[FieldOffset(Offset = "0x48")]
		public string bkgroundManifest;

		// Token: 0x040025D8 RID: 9688
		[Token(Token = "0x40025D8")]
		[FieldOffset(Offset = "0x50")]
		public string packageResManifest;
	}
}
