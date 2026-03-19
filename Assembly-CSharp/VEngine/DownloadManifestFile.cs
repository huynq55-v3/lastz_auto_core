using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace VEngine
{
	// Token: 0x020009DF RID: 2527
	[Token(Token = "0x20009DF")]
	public class DownloadManifestFile : ManifestFile
	{
		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x060060CF RID: 24783 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060060D0 RID: 24784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700060F")]
		public string versionName
		{
			[Token(Token = "0x60060CF")]
			[Address(RVA = "0x1409130", Offset = "0x1409130", VA = "0x1409130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60060D0")]
			[Address(RVA = "0x1409138", Offset = "0x1409138", VA = "0x1409138")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x060060D1 RID: 24785 RVA: 0x0004B3A8 File Offset: 0x000495A8
		[Token(Token = "0x17000610")]
		public bool isRetry
		{
			[Token(Token = "0x60060D1")]
			[Address(RVA = "0x1409140", Offset = "0x1409140", VA = "0x1409140")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060060D2 RID: 24786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060D2")]
		[Address(RVA = "0x1409160", Offset = "0x1409160", VA = "0x1409160")]
		public static string GetTemporaryPath(string filename)
		{
			return null;
		}

		// Token: 0x060060D3 RID: 24787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060D3")]
		[Address(RVA = "0x14091B0", Offset = "0x14091B0", VA = "0x14091B0", Slot = "6")]
		protected override void OnLoad()
		{
		}

		// Token: 0x060060D4 RID: 24788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060D4")]
		[Address(RVA = "0x1409440", Offset = "0x1409440", VA = "0x1409440", Slot = "5")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x060060D5 RID: 24789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060D5")]
		[Address(RVA = "0x1409D54", Offset = "0x1409D54", VA = "0x1409D54", Slot = "13")]
		public override void Override()
		{
		}

		// Token: 0x060060D6 RID: 24790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060D6")]
		[Address(RVA = "0x14099E8", Offset = "0x14099E8", VA = "0x14099E8")]
		private void UpdateDownloading()
		{
		}

		// Token: 0x060060D7 RID: 24791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060D7")]
		[Address(RVA = "0x14094B4", Offset = "0x14094B4", VA = "0x14094B4")]
		private void UpdateVersion()
		{
		}

		// Token: 0x060060D8 RID: 24792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060D8")]
		[Address(RVA = "0x1407DB4", Offset = "0x1407DB4", VA = "0x1407DB4")]
		public DownloadManifestFile()
		{
		}

		// Token: 0x0400257B RID: 9595
		[Token(Token = "0x400257B")]
		[FieldOffset(Offset = "0x58")]
		private Download download;
	}
}
