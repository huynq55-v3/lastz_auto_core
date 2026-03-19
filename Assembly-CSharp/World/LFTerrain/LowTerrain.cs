using System;
using Il2CppDummyDll;
using UnityEngine;

namespace World.LFTerrain
{
	// Token: 0x020003B8 RID: 952
	[Token(Token = "0x20003B8")]
	[Serializable]
	public class LowTerrain
	{
		// Token: 0x060017F6 RID: 6134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017F6")]
		[Address(RVA = "0x1DBD2A0", Offset = "0x1DBD2A0", VA = "0x1DBD2A0")]
		public LowTerrain()
		{
		}

		// Token: 0x04001AA6 RID: 6822
		[Token(Token = "0x4001AA6")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 pos;

		// Token: 0x04001AA7 RID: 6823
		[Token(Token = "0x4001AA7")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 euler;

		// Token: 0x04001AA8 RID: 6824
		[Token(Token = "0x4001AA8")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 scale;

		// Token: 0x04001AA9 RID: 6825
		[Token(Token = "0x4001AA9")]
		[FieldOffset(Offset = "0x38")]
		public Material material;
	}
}
