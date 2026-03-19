using System;
using Il2CppDummyDll;
using UnityEngine;

namespace World.LFTerrain
{
	// Token: 0x020003B7 RID: 951
	[Token(Token = "0x20003B7")]
	[Serializable]
	public class TileData
	{
		// Token: 0x060017F5 RID: 6133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017F5")]
		[Address(RVA = "0x1DBD298", Offset = "0x1DBD298", VA = "0x1DBD298")]
		public TileData()
		{
		}

		// Token: 0x04001AA1 RID: 6817
		[Token(Token = "0x4001AA1")]
		[FieldOffset(Offset = "0x10")]
		public int resId;

		// Token: 0x04001AA2 RID: 6818
		[Token(Token = "0x4001AA2")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 pos;

		// Token: 0x04001AA3 RID: 6819
		[Token(Token = "0x4001AA3")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 euler;

		// Token: 0x04001AA4 RID: 6820
		[Token(Token = "0x4001AA4")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 scale;

		// Token: 0x04001AA5 RID: 6821
		[Token(Token = "0x4001AA5")]
		[FieldOffset(Offset = "0x38")]
		public Material material;
	}
}
