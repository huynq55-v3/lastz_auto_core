using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Main.Scripts.Scene
{
	// Token: 0x02000501 RID: 1281
	[Token(Token = "0x2000501")]
	[CreateAssetMenu(fileName = "TerrainSetting", menuName = "APS - TerrainSetting", order = 0)]
	public class TerrainSetting : ScriptableObject
	{
		// Token: 0x060026BC RID: 9916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026BC")]
		[Address(RVA = "0x2B639F4", Offset = "0x2B639F4", VA = "0x2B639F4")]
		public TerrainSetting()
		{
		}

		// Token: 0x040022F5 RID: 8949
		[Token(Token = "0x40022F5")]
		[FieldOffset(Offset = "0x18")]
		public Texture2D control;

		// Token: 0x040022F6 RID: 8950
		[Token(Token = "0x40022F6")]
		[FieldOffset(Offset = "0x20")]
		public Texture2D splat0;

		// Token: 0x040022F7 RID: 8951
		[Token(Token = "0x40022F7")]
		[FieldOffset(Offset = "0x28")]
		public Texture2D splat1;

		// Token: 0x040022F8 RID: 8952
		[Token(Token = "0x40022F8")]
		[FieldOffset(Offset = "0x30")]
		public Vector4 control_st;

		// Token: 0x040022F9 RID: 8953
		[Token(Token = "0x40022F9")]
		[FieldOffset(Offset = "0x40")]
		public Vector4 splat0_st;

		// Token: 0x040022FA RID: 8954
		[Token(Token = "0x40022FA")]
		[FieldOffset(Offset = "0x50")]
		public Vector4 splat1_st;

		// Token: 0x040022FB RID: 8955
		[Token(Token = "0x40022FB")]
		[FieldOffset(Offset = "0x60")]
		public Vector4 terrainBounds;
	}
}
