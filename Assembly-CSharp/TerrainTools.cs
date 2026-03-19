using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002C1 RID: 705
[Token(Token = "0x20002C1")]
public class TerrainTools : MonoBehaviour
{
	// Token: 0x06001238 RID: 4664 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001238")]
	[Address(RVA = "0x1C5AC84", Offset = "0x1C5AC84", VA = "0x1C5AC84")]
	public TerrainTools()
	{
	}

	// Token: 0x04001523 RID: 5411
	[Token(Token = "0x4001523")]
	[FieldOffset(Offset = "0x18")]
	public Terrain Terrain;

	// Token: 0x04001524 RID: 5412
	[Token(Token = "0x4001524")]
	[FieldOffset(Offset = "0x20")]
	public GameObject[] ExportCollitionRoots;

	// Token: 0x04001525 RID: 5413
	[Token(Token = "0x4001525")]
	[FieldOffset(Offset = "0x28")]
	public GameObject[] ExportDecalRoots;
}
