using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace VEngine
{
	// Token: 0x020009F3 RID: 2547
	[Token(Token = "0x20009F3")]
	public sealed class UpdateVersions : Operation
	{
		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06006177 RID: 24951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700062C")]
		public List<Manifest> Manifests
		{
			[Token(Token = "0x6006177")]
			[Address(RVA = "0x14121B0", Offset = "0x14121B0", VA = "0x14121B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06006178 RID: 24952 RVA: 0x0004B5D0 File Offset: 0x000497D0
		[Token(Token = "0x1700062D")]
		public bool isRetry
		{
			[Token(Token = "0x6006178")]
			[Address(RVA = "0x14122D0", Offset = "0x14122D0", VA = "0x14122D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006179 RID: 24953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006179")]
		[Address(RVA = "0x14124A0", Offset = "0x14124A0", VA = "0x14124A0")]
		public Manifest GetManifest(string name)
		{
			return null;
		}

		// Token: 0x0600617A RID: 24954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600617A")]
		[Address(RVA = "0x141259C", Offset = "0x141259C", VA = "0x141259C", Slot = "8")]
		public override void Start()
		{
		}

		// Token: 0x0600617B RID: 24955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600617B")]
		[Address(RVA = "0x14126AC", Offset = "0x14126AC", VA = "0x14126AC")]
		public void Override()
		{
		}

		// Token: 0x0600617C RID: 24956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600617C")]
		[Address(RVA = "0x1412824", Offset = "0x1412824", VA = "0x1412824")]
		public void Dispose()
		{
		}

		// Token: 0x0600617D RID: 24957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600617D")]
		[Address(RVA = "0x14129B4", Offset = "0x14129B4", VA = "0x14129B4", Slot = "7")]
		protected override void Update()
		{
		}

		// Token: 0x0600617E RID: 24958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600617E")]
		[Address(RVA = "0x1412F28", Offset = "0x1412F28", VA = "0x1412F28")]
		private void SplitVersionFile(string versionPath)
		{
		}

		// Token: 0x0600617F RID: 24959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600617F")]
		[Address(RVA = "0x14131CC", Offset = "0x14131CC", VA = "0x14131CC")]
		public UpdateVersions()
		{
		}

		// Token: 0x040025EB RID: 9707
		[Token(Token = "0x40025EB")]
		[FieldOffset(Offset = "0x30")]
		public string[] manifests;

		// Token: 0x040025EC RID: 9708
		[Token(Token = "0x40025EC")]
		[FieldOffset(Offset = "0x38")]
		public readonly List<ManifestFile> assets;

		// Token: 0x040025ED RID: 9709
		[Token(Token = "0x40025ED")]
		[FieldOffset(Offset = "0x40")]
		private Download downloadVersion;
	}
}
