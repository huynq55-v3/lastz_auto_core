using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace VEngine
{
	// Token: 0x020009DD RID: 2525
	[Token(Token = "0x20009DD")]
	public class ManifestFile : Loadable
	{
		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x060060BA RID: 24762 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060060BB RID: 24763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700060D")]
		public Manifest target
		{
			[Token(Token = "0x60060BA")]
			[Address(RVA = "0x1407748", Offset = "0x1407748", VA = "0x1407748")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60060BB")]
			[Address(RVA = "0x1407750", Offset = "0x1407750", VA = "0x1407750")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x060060BC RID: 24764 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060060BD RID: 24765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700060E")]
		protected string name
		{
			[Token(Token = "0x60060BC")]
			[Address(RVA = "0x1407758", Offset = "0x1407758", VA = "0x1407758")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60060BD")]
			[Address(RVA = "0x1407760", Offset = "0x1407760", VA = "0x1407760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060060BE RID: 24766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060BE")]
		[Address(RVA = "0x1407768", Offset = "0x1407768", VA = "0x1407768", Slot = "6")]
		protected override void OnLoad()
		{
		}

		// Token: 0x060060BF RID: 24767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060BF")]
		[Address(RVA = "0x1407A84", Offset = "0x1407A84", VA = "0x1407A84", Slot = "11")]
		protected override void OnUnused()
		{
		}

		// Token: 0x060060C0 RID: 24768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060C0")]
		[Address(RVA = "0x1407B5C", Offset = "0x1407B5C", VA = "0x1407B5C", Slot = "13")]
		public virtual void Override()
		{
		}

		// Token: 0x060060C1 RID: 24769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060C1")]
		[Address(RVA = "0x1407B60", Offset = "0x1407B60", VA = "0x1407B60")]
		public static ManifestFile LoadAsync(string name, bool builtin = false)
		{
			return null;
		}

		// Token: 0x060060C2 RID: 24770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060C2")]
		[Address(RVA = "0x1407C5C", Offset = "0x1407C5C", VA = "0x1407C5C")]
		internal static ManifestFile Create(string name, bool builtin)
		{
			return null;
		}

		// Token: 0x060060C3 RID: 24771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060C3")]
		[Address(RVA = "0x1406EB0", Offset = "0x1406EB0", VA = "0x1406EB0")]
		public static void UpdateFiles()
		{
		}

		// Token: 0x060060C4 RID: 24772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060C4")]
		[Address(RVA = "0x1407E08", Offset = "0x1407E08", VA = "0x1407E08")]
		public static string GetManifestVersion(string appVersion, string gm)
		{
			return null;
		}

		// Token: 0x060060C5 RID: 24773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060C5")]
		[Address(RVA = "0x1407E7C", Offset = "0x1407E7C", VA = "0x1407E7C")]
		public ManifestFile()
		{
		}

		// Token: 0x04002574 RID: 9588
		[Token(Token = "0x4002574")]
		public const string ManifestVersion = "manifest.version";

		// Token: 0x04002575 RID: 9589
		[Token(Token = "0x4002575")]
		public const string CompressPosfix = "_small";

		// Token: 0x04002576 RID: 9590
		[Token(Token = "0x4002576")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<ManifestFile> Unused;

		// Token: 0x04002578 RID: 9592
		[Token(Token = "0x4002578")]
		[FieldOffset(Offset = "0x48")]
		protected ManifestVersionFile versionFile;
	}
}
