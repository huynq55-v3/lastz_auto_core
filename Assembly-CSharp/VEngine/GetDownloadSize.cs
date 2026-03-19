using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace VEngine
{
	// Token: 0x020009EC RID: 2540
	[Token(Token = "0x20009EC")]
	public sealed class GetDownloadSize : Operation
	{
		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06006146 RID: 24902 RVA: 0x0004B4F8 File Offset: 0x000496F8
		[Token(Token = "0x1700061F")]
		public int count
		{
			[Token(Token = "0x6006146")]
			[Address(RVA = "0x1410890", Offset = "0x1410890", VA = "0x1410890")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06006147 RID: 24903 RVA: 0x0004B510 File Offset: 0x00049710
		// (set) Token: 0x06006148 RID: 24904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000620")]
		public int index
		{
			[Token(Token = "0x6006147")]
			[Address(RVA = "0x14108D8", Offset = "0x14108D8", VA = "0x14108D8")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006148")]
			[Address(RVA = "0x14108E0", Offset = "0x14108E0", VA = "0x14108E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06006149 RID: 24905 RVA: 0x0004B528 File Offset: 0x00049728
		// (set) Token: 0x0600614A RID: 24906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000621")]
		public ulong totalSize
		{
			[Token(Token = "0x6006149")]
			[Address(RVA = "0x14108E8", Offset = "0x14108E8", VA = "0x14108E8")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x600614A")]
			[Address(RVA = "0x14108F0", Offset = "0x14108F0", VA = "0x14108F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x0600614B RID: 24907 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600614C RID: 24908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000622")]
		public string[] items
		{
			[Token(Token = "0x600614B")]
			[Address(RVA = "0x14108F8", Offset = "0x14108F8", VA = "0x14108F8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600614C")]
			[Address(RVA = "0x1410900", Offset = "0x1410900", VA = "0x1410900")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x0600614D RID: 24909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000623")]
		public string current
		{
			[Token(Token = "0x600614D")]
			[Address(RVA = "0x1410908", Offset = "0x1410908", VA = "0x1410908")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600614E RID: 24910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600614E")]
		[Address(RVA = "0x14109A4", Offset = "0x14109A4", VA = "0x14109A4", Slot = "8")]
		public override void Start()
		{
		}

		// Token: 0x0600614F RID: 24911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600614F")]
		[Address(RVA = "0x1410A74", Offset = "0x1410A74", VA = "0x1410A74", Slot = "7")]
		protected override void Update()
		{
		}

		// Token: 0x06006150 RID: 24912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006150")]
		[Address(RVA = "0x1410D4C", Offset = "0x1410D4C", VA = "0x1410D4C")]
		public GetDownloadSize()
		{
		}

		// Token: 0x040025CC RID: 9676
		[Token(Token = "0x40025CC")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<BundleInfo> bundles;

		// Token: 0x040025CD RID: 9677
		[Token(Token = "0x40025CD")]
		[FieldOffset(Offset = "0x38")]
		public readonly List<DownloadInfo> result;

		// Token: 0x040025D1 RID: 9681
		[Token(Token = "0x40025D1")]
		[FieldOffset(Offset = "0x58")]
		public GetDownloadSizeMode mode;

		// Token: 0x040025D2 RID: 9682
		[Token(Token = "0x40025D2")]
		[FieldOffset(Offset = "0x60")]
		public Manifest[] manifests;
	}
}
