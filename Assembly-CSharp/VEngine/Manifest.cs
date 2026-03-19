using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;

namespace VEngine
{
	// Token: 0x020009E7 RID: 2535
	[Token(Token = "0x20009E7")]
	public class Manifest
	{
		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x0600611F RID: 24863 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006120 RID: 24864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700061B")]
		public string name
		{
			[Token(Token = "0x600611F")]
			[Address(RVA = "0x140D570", Offset = "0x140D570", VA = "0x140D570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006120")]
			[Address(RVA = "0x140D578", Offset = "0x140D578", VA = "0x140D578")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06006121 RID: 24865 RVA: 0x0004B450 File Offset: 0x00049650
		// (set) Token: 0x06006122 RID: 24866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700061C")]
		public int id
		{
			[Token(Token = "0x6006121")]
			[Address(RVA = "0x140D580", Offset = "0x140D580", VA = "0x140D580")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006122")]
			[Address(RVA = "0x140D588", Offset = "0x140D588", VA = "0x140D588")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06006123 RID: 24867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006123")]
		[Address(RVA = "0x140D590", Offset = "0x140D590", VA = "0x140D590")]
		public void LoadEx(string name1)
		{
		}

		// Token: 0x06006124 RID: 24868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006124")]
		[Address(RVA = "0x14088CC", Offset = "0x14088CC", VA = "0x14088CC")]
		public void Load(string path)
		{
		}

		// Token: 0x06006125 RID: 24869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006125")]
		[Address(RVA = "0x140D624", Offset = "0x140D624", VA = "0x140D624")]
		private void ParseManifest(string path)
		{
		}

		// Token: 0x06006126 RID: 24870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006126")]
		[Address(RVA = "0x140E050", Offset = "0x140E050", VA = "0x140E050")]
		private void SetContainerCapacity(ReadOnlySpan<char> line, string parseType)
		{
		}

		// Token: 0x06006127 RID: 24871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006127")]
		[Address(RVA = "0x140DAAC", Offset = "0x140DAAC", VA = "0x140DAAC")]
		private void ParseManifestLine(ReadOnlySpan<char> line, ref string parseType)
		{
		}

		// Token: 0x06006128 RID: 24872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006128")]
		[Address(RVA = "0x140E47C", Offset = "0x140E47C", VA = "0x140E47C")]
		private void ReadVersion(ReadOnlySpan<char> line)
		{
		}

		// Token: 0x06006129 RID: 24873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006129")]
		[Address(RVA = "0x140EB6C", Offset = "0x140EB6C", VA = "0x140EB6C")]
		private void ReadDirectory(ReadOnlySpan<char> line)
		{
		}

		// Token: 0x0600612A RID: 24874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600612A")]
		[Address(RVA = "0x140EDE8", Offset = "0x140EDE8", VA = "0x140EDE8")]
		private void ReadDependencies(ReadOnlySpan<char> line)
		{
		}

		// Token: 0x0600612B RID: 24875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600612B")]
		[Address(RVA = "0x140E5B8", Offset = "0x140E5B8", VA = "0x140E5B8")]
		private void ReadBundle(ReadOnlySpan<char> line)
		{
		}

		// Token: 0x0600612C RID: 24876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600612C")]
		[Address(RVA = "0x140EEE4", Offset = "0x140EEE4", VA = "0x140EEE4")]
		private void ReadPath(int dir, ReadOnlySpan<char> asset_name)
		{
		}

		// Token: 0x0600612D RID: 24877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600612D")]
		[Address(RVA = "0x140E90C", Offset = "0x140E90C", VA = "0x140E90C")]
		private void ReadAsset(ReadOnlySpan<char> line)
		{
		}

		// Token: 0x0600612E RID: 24878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600612E")]
		[Address(RVA = "0x1408820", Offset = "0x1408820", VA = "0x1408820")]
		public static string GetVersionFile(string name)
		{
			return null;
		}

		// Token: 0x0600612F RID: 24879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600612F")]
		[Address(RVA = "0x140F124", Offset = "0x140F124", VA = "0x140F124")]
		public BundleInfo GetBundle(string assetBundleName)
		{
			return null;
		}

		// Token: 0x06006130 RID: 24880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006130")]
		[Address(RVA = "0x140F194", Offset = "0x140F194", VA = "0x140F194")]
		public string GetBundleNameAppendHash(string nameWithoutHash)
		{
			return null;
		}

		// Token: 0x06006131 RID: 24881 RVA: 0x0004B468 File Offset: 0x00049668
		[Token(Token = "0x6006131")]
		[Address(RVA = "0x140F2B4", Offset = "0x140F2B4", VA = "0x140F2B4")]
		public bool ContainsBundle(string assetBundleName)
		{
			return default(bool);
		}

		// Token: 0x06006132 RID: 24882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006132")]
		[Address(RVA = "0x140F30C", Offset = "0x140F30C", VA = "0x140F30C")]
		public BundleInfo GetBundle(int bundleId)
		{
			return null;
		}

		// Token: 0x06006133 RID: 24883 RVA: 0x0004B480 File Offset: 0x00049680
		[Token(Token = "0x6006133")]
		[Address(RVA = "0x140F390", Offset = "0x140F390", VA = "0x140F390")]
		public bool GetAsset(string path, out AssetInfo asset)
		{
			return default(bool);
		}

		// Token: 0x06006134 RID: 24884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006134")]
		[Address(RVA = "0x140F504", Offset = "0x140F504", VA = "0x140F504")]
		public void SetAllAssetPaths(IEnumerable<string> assetPaths)
		{
		}

		// Token: 0x06006135 RID: 24885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006135")]
		[Address(RVA = "0x140F594", Offset = "0x140F594", VA = "0x140F594")]
		public BundleInfo[] GetDependencies(BundleInfo info)
		{
			return null;
		}

		// Token: 0x06006136 RID: 24886 RVA: 0x0004B498 File Offset: 0x00049698
		[Token(Token = "0x6006136")]
		[Address(RVA = "0x140F640", Offset = "0x140F640", VA = "0x140F640")]
		public int GetAllBundlsSize()
		{
			return 0;
		}

		// Token: 0x06006137 RID: 24887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006137")]
		[Address(RVA = "0x1407834", Offset = "0x1407834", VA = "0x1407834")]
		public Manifest()
		{
		}

		// Token: 0x040025A8 RID: 9640
		[Token(Token = "0x40025A8")]
		private const string key_version = "[Version]";

		// Token: 0x040025A9 RID: 9641
		[Token(Token = "0x40025A9")]
		private const string key_app_version = "[AppVersion]";

		// Token: 0x040025AA RID: 9642
		[Token(Token = "0x40025AA")]
		private const string key_groups = "[Groups]";

		// Token: 0x040025AB RID: 9643
		[Token(Token = "0x40025AB")]
		private const string key_paths = "[Paths]";

		// Token: 0x040025AC RID: 9644
		[Token(Token = "0x40025AC")]
		private const string key_directories = "[Directories]";

		// Token: 0x040025AD RID: 9645
		[Token(Token = "0x40025AD")]
		private const string key_bundles = "[Bundles]";

		// Token: 0x040025AE RID: 9646
		[Token(Token = "0x40025AE")]
		private const string key_assets = "[Assets]";

		// Token: 0x040025AF RID: 9647
		[Token(Token = "0x40025AF")]
		private const string key_dependencies = "[Dependencies]";

		// Token: 0x040025B0 RID: 9648
		[Token(Token = "0x40025B0")]
		private const string key_count = "#Count=";

		// Token: 0x040025B1 RID: 9649
		[Token(Token = "0x40025B1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly HashSet<string> all_keys;

		// Token: 0x040025B2 RID: 9650
		[Token(Token = "0x40025B2")]
		[FieldOffset(Offset = "0x10")]
		public Action<string> onReadAsset;

		// Token: 0x040025B3 RID: 9651
		[Token(Token = "0x40025B3")]
		[FieldOffset(Offset = "0x18")]
		internal readonly List<string> allAssetPaths;

		// Token: 0x040025B4 RID: 9652
		[Token(Token = "0x40025B4")]
		[FieldOffset(Offset = "0x20")]
		private List<string> directories;

		// Token: 0x040025B5 RID: 9653
		[Token(Token = "0x40025B5")]
		[FieldOffset(Offset = "0x28")]
		private readonly Dictionary<string, BundleInfo> nameWithBundles;

		// Token: 0x040025B6 RID: 9654
		[Token(Token = "0x40025B6")]
		[FieldOffset(Offset = "0x30")]
		internal readonly Dictionary<string, int> pathWithAssets;

		// Token: 0x040025B7 RID: 9655
		[Token(Token = "0x40025B7")]
		[FieldOffset(Offset = "0x38")]
		public List<AssetInfo> assets;

		// Token: 0x040025B8 RID: 9656
		[Token(Token = "0x40025B8")]
		[FieldOffset(Offset = "0x40")]
		public List<BundleInfo> bundles;

		// Token: 0x040025B9 RID: 9657
		[Token(Token = "0x40025B9")]
		[FieldOffset(Offset = "0x48")]
		public List<int[]> dep_bundles;

		// Token: 0x040025BA RID: 9658
		[Token(Token = "0x40025BA")]
		[FieldOffset(Offset = "0x50")]
		public int version;

		// Token: 0x040025BB RID: 9659
		[Token(Token = "0x40025BB")]
		[FieldOffset(Offset = "0x58")]
		public long unix_timestamp;

		// Token: 0x040025BC RID: 9660
		[Token(Token = "0x40025BC")]
		[FieldOffset(Offset = "0x60")]
		public string appVersion;

		// Token: 0x040025BF RID: 9663
		[Token(Token = "0x40025BF")]
		[FieldOffset(Offset = "0x78")]
		private StringBuilder sb;
	}
}
