using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace VEngine
{
	// Token: 0x020009EA RID: 2538
	[Token(Token = "0x20009EA")]
	public sealed class DownloadVersions : Operation
	{
		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x0600613E RID: 24894 RVA: 0x0004B4C8 File Offset: 0x000496C8
		// (set) Token: 0x0600613F RID: 24895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700061D")]
		public ulong totalSize
		{
			[Token(Token = "0x600613E")]
			[Address(RVA = "0x14101A4", Offset = "0x14101A4", VA = "0x14101A4")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x600613F")]
			[Address(RVA = "0x14101AC", Offset = "0x14101AC", VA = "0x14101AC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06006140 RID: 24896 RVA: 0x0004B4E0 File Offset: 0x000496E0
		// (set) Token: 0x06006141 RID: 24897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700061E")]
		public ulong downloadedBytes
		{
			[Token(Token = "0x6006140")]
			[Address(RVA = "0x14101B4", Offset = "0x14101B4", VA = "0x14101B4")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6006141")]
			[Address(RVA = "0x14101BC", Offset = "0x14101BC", VA = "0x14101BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006142 RID: 24898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006142")]
		[Address(RVA = "0x14101C4", Offset = "0x14101C4", VA = "0x14101C4", Slot = "8")]
		public override void Start()
		{
		}

		// Token: 0x06006143 RID: 24899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006143")]
		[Address(RVA = "0x1410380", Offset = "0x1410380", VA = "0x1410380")]
		public void Stop()
		{
		}

		// Token: 0x06006144 RID: 24900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006144")]
		[Address(RVA = "0x1410504", Offset = "0x1410504", VA = "0x1410504", Slot = "7")]
		protected override void Update()
		{
		}

		// Token: 0x06006145 RID: 24901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006145")]
		[Address(RVA = "0x14107E4", Offset = "0x14107E4", VA = "0x14107E4")]
		public DownloadVersions()
		{
		}

		// Token: 0x040025C4 RID: 9668
		[Token(Token = "0x40025C4")]
		[FieldOffset(Offset = "0x30")]
		private List<Download> downloads;

		// Token: 0x040025C5 RID: 9669
		[Token(Token = "0x40025C5")]
		[FieldOffset(Offset = "0x38")]
		public DownloadInfo[] groups;

		// Token: 0x040025C8 RID: 9672
		[Token(Token = "0x40025C8")]
		[FieldOffset(Offset = "0x50")]
		public bool highestPriority;
	}
}
