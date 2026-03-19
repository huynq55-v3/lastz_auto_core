using System;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace VEngine
{
	// Token: 0x020009DE RID: 2526
	[Token(Token = "0x20009DE")]
	public class BuiltinManifestFile : ManifestFile
	{
		// Token: 0x060060C7 RID: 24775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060C7")]
		[Address(RVA = "0x1407F68", Offset = "0x1407F68", VA = "0x1407F68")]
		private void DownloadAsync(string url, string savePath)
		{
		}

		// Token: 0x060060C8 RID: 24776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060C8")]
		[Address(RVA = "0x1408034", Offset = "0x1408034", VA = "0x1408034")]
		private static string GetTemporaryPath(string filename)
		{
			return null;
		}

		// Token: 0x060060C9 RID: 24777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060C9")]
		[Address(RVA = "0x140814C", Offset = "0x140814C", VA = "0x140814C", Slot = "13")]
		public override void Override()
		{
		}

		// Token: 0x060060CA RID: 24778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060CA")]
		[Address(RVA = "0x1408A88", Offset = "0x1408A88", VA = "0x1408A88", Slot = "6")]
		protected override void OnLoad()
		{
		}

		// Token: 0x060060CB RID: 24779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060CB")]
		[Address(RVA = "0x1408BE4", Offset = "0x1408BE4", VA = "0x1408BE4", Slot = "5")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x060060CC RID: 24780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060CC")]
		[Address(RVA = "0x1408FE8", Offset = "0x1408FE8", VA = "0x1408FE8")]
		private void UpdateDownloading()
		{
		}

		// Token: 0x060060CD RID: 24781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060CD")]
		[Address(RVA = "0x1408C14", Offset = "0x1408C14", VA = "0x1408C14")]
		private void UpdateVersion()
		{
		}

		// Token: 0x060060CE RID: 24782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060CE")]
		[Address(RVA = "0x1407D60", Offset = "0x1407D60", VA = "0x1407D60")]
		public BuiltinManifestFile()
		{
		}

		// Token: 0x0400257A RID: 9594
		[Token(Token = "0x400257A")]
		[FieldOffset(Offset = "0x58")]
		private UnityWebRequest request;
	}
}
