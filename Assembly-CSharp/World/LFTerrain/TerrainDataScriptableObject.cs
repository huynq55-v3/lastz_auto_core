using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace World.LFTerrain
{
	// Token: 0x020003B9 RID: 953
	[Token(Token = "0x20003B9")]
	public class TerrainDataScriptableObject : ScriptableObject
	{
		// Token: 0x060017F7 RID: 6135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017F7")]
		[Address(RVA = "0x1DBD2A8", Offset = "0x1DBD2A8", VA = "0x1DBD2A8")]
		public TerrainDataScriptableObject()
		{
		}

		// Token: 0x04001AAA RID: 6826
		[Token(Token = "0x4001AAA")]
		[FieldOffset(Offset = "0x18")]
		public List<TileData> tileDataList;

		// Token: 0x04001AAB RID: 6827
		[Token(Token = "0x4001AAB")]
		[FieldOffset(Offset = "0x20")]
		public LowTerrain lowTerrain;
	}
}
