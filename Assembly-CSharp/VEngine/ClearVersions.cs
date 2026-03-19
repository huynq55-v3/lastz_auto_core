using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace VEngine
{
	// Token: 0x020009E9 RID: 2537
	[Token(Token = "0x20009E9")]
	public sealed class ClearVersions : Operation
	{
		// Token: 0x0600613B RID: 24891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600613B")]
		[Address(RVA = "0x140F9A4", Offset = "0x140F9A4", VA = "0x140F9A4", Slot = "8")]
		public override void Start()
		{
		}

		// Token: 0x0600613C RID: 24892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600613C")]
		[Address(RVA = "0x140FF54", Offset = "0x140FF54", VA = "0x140FF54", Slot = "7")]
		protected override void Update()
		{
		}

		// Token: 0x0600613D RID: 24893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600613D")]
		[Address(RVA = "0x14100F0", Offset = "0x14100F0", VA = "0x14100F0")]
		public ClearVersions()
		{
		}

		// Token: 0x040025C1 RID: 9665
		[Token(Token = "0x40025C1")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<string> usedFiles;

		// Token: 0x040025C2 RID: 9666
		[Token(Token = "0x40025C2")]
		[FieldOffset(Offset = "0x38")]
		private string[] allFiles;

		// Token: 0x040025C3 RID: 9667
		[Token(Token = "0x40025C3")]
		[FieldOffset(Offset = "0x40")]
		private int index;
	}
}
