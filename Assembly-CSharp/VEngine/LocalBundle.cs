using System;
using Il2CppDummyDll;
using UnityEngine;

namespace VEngine
{
	// Token: 0x020009D8 RID: 2520
	[Token(Token = "0x20009D8")]
	internal class LocalBundle : Bundle
	{
		// Token: 0x06006082 RID: 24706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006082")]
		[Address(RVA = "0x140504C", Offset = "0x140504C", VA = "0x140504C", Slot = "6")]
		protected override void OnLoad()
		{
		}

		// Token: 0x06006083 RID: 24707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006083")]
		[Address(RVA = "0x14052F8", Offset = "0x14052F8", VA = "0x14052F8")]
		private string GetOriginBundleName(string nameWithAppendHash)
		{
			return null;
		}

		// Token: 0x06006084 RID: 24708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006084")]
		[Address(RVA = "0x14053E0", Offset = "0x14053E0", VA = "0x14053E0", Slot = "9")]
		public override void LoadImmediate()
		{
		}

		// Token: 0x06006085 RID: 24709 RVA: 0x0004B2D0 File Offset: 0x000494D0
		[Token(Token = "0x6006085")]
		[Address(RVA = "0x14054E4", Offset = "0x14054E4", VA = "0x14054E4")]
		private bool IsLoaded(out string abName)
		{
			return default(bool);
		}

		// Token: 0x06006086 RID: 24710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006086")]
		[Address(RVA = "0x14058F0", Offset = "0x14058F0", VA = "0x14058F0")]
		private void OnLoaded()
		{
		}

		// Token: 0x06006087 RID: 24711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006087")]
		[Address(RVA = "0x1405A3C", Offset = "0x1405A3C", VA = "0x1405A3C", Slot = "5")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x06006088 RID: 24712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006088")]
		[Address(RVA = "0x1405AA4", Offset = "0x1405AA4", VA = "0x1405AA4", Slot = "4")]
		public override void SetPriority(int priority)
		{
		}

		// Token: 0x06006089 RID: 24713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006089")]
		[Address(RVA = "0x14054E0", Offset = "0x14054E0", VA = "0x14054E0")]
		private void ResetAllMaterials(AssetBundle bundle)
		{
		}

		// Token: 0x0600608A RID: 24714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600608A")]
		[Address(RVA = "0x1405AB8", Offset = "0x1405AB8", VA = "0x1405AB8", Slot = "12")]
		protected override void ForceStop()
		{
		}

		// Token: 0x0600608B RID: 24715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600608B")]
		[Address(RVA = "0x140420C", Offset = "0x140420C", VA = "0x140420C")]
		public LocalBundle()
		{
		}

		// Token: 0x0400255B RID: 9563
		[Token(Token = "0x400255B")]
		[FieldOffset(Offset = "0x50")]
		private AssetBundleCreateRequest request;
	}
}
