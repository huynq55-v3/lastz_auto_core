using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GEgineRunTime
{
	// Token: 0x020004FE RID: 1278
	[Token(Token = "0x20004FE")]
	public class WorldTerrainUVScaleScriptableObject : ScriptableObject
	{
		// Token: 0x060026AC RID: 9900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026AC")]
		[Address(RVA = "0x2B6317C", Offset = "0x2B6317C", VA = "0x2B6317C")]
		public WorldTerrainUVScaleScriptableObject()
		{
		}

		// Token: 0x040022ED RID: 8941
		[Token(Token = "0x40022ED")]
		[FieldOffset(Offset = "0x18")]
		public float[] uvs;

		// Token: 0x040022EE RID: 8942
		[Token(Token = "0x40022EE")]
		[FieldOffset(Offset = "0x20")]
		public float lowUVScale;

		// Token: 0x040022EF RID: 8943
		[Token(Token = "0x40022EF")]
		[FieldOffset(Offset = "0x24")]
		public Vector4 LightDir;
	}
}
