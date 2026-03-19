using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000012 RID: 18
[Token(Token = "0x2000012")]
public class TerrainLodConfig : MonoBehaviour
{
	// Token: 0x06000024 RID: 36 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000024")]
	[Address(RVA = "0x15DF63C", Offset = "0x15DF63C", VA = "0x15DF63C")]
	public TerrainLodConfig()
	{
	}

	// Token: 0x04000076 RID: 118
	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<TerrainLodConfigItem> configList;
}
