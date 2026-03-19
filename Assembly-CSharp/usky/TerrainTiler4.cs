using System;
using Il2CppDummyDll;
using UnityEngine;

namespace usky
{
	// Token: 0x02000A09 RID: 2569
	[Token(Token = "0x2000A09")]
	[AddComponentMenu("uSkyPro/Other/Terrain Tiler 4")]
	public class TerrainTiler4 : MonoBehaviour
	{
		// Token: 0x06006211 RID: 25105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006211")]
		[Address(RVA = "0x3030368", Offset = "0x3030368", VA = "0x3030368")]
		private void Awake()
		{
		}

		// Token: 0x06006212 RID: 25106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006212")]
		[Address(RVA = "0x30305B8", Offset = "0x30305B8", VA = "0x30305B8")]
		public TerrainTiler4()
		{
		}

		// Token: 0x04002651 RID: 9809
		[Token(Token = "0x4002651")]
		[FieldOffset(Offset = "0x18")]
		public Terrain[] terrains;
	}
}
