using System;
using Il2CppDummyDll;

namespace VEngine
{
	// Token: 0x020009E3 RID: 2531
	[Token(Token = "0x20009E3")]
	public class BundledScene : Scene
	{
		// Token: 0x06006115 RID: 24853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006115")]
		[Address(RVA = "0x140D124", Offset = "0x140D124", VA = "0x140D124", Slot = "5")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x06006116 RID: 24854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006116")]
		[Address(RVA = "0x140D144", Offset = "0x140D144", VA = "0x140D144")]
		private void UpdateDependencies()
		{
		}

		// Token: 0x06006117 RID: 24855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006117")]
		[Address(RVA = "0x140D278", Offset = "0x140D278", VA = "0x140D278", Slot = "7")]
		protected override void OnUnload()
		{
		}

		// Token: 0x06006118 RID: 24856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006118")]
		[Address(RVA = "0x140D2D8", Offset = "0x140D2D8", VA = "0x140D2D8", Slot = "6")]
		protected override void OnLoad()
		{
		}

		// Token: 0x06006119 RID: 24857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006119")]
		[Address(RVA = "0x140D370", Offset = "0x140D370", VA = "0x140D370")]
		internal static Scene Create(string assetPath, bool additive = false)
		{
			return null;
		}

		// Token: 0x0600611A RID: 24858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600611A")]
		[Address(RVA = "0x140D42C", Offset = "0x140D42C", VA = "0x140D42C")]
		public BundledScene()
		{
		}

		// Token: 0x0400259D RID: 9629
		[Token(Token = "0x400259D")]
		[FieldOffset(Offset = "0x70")]
		protected Dependencies dependencies;
	}
}
