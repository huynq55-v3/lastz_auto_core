using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000015 RID: 21
[Token(Token = "0x2000015")]
public class TerrainObjectMatSet : MonoBehaviour
{
	// Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x15DF6C4", Offset = "0x15DF6C4", VA = "0x15DF6C4")]
	public Material GetMatByType(E_TerrainObjectMatSet eType)
	{
		return null;
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000026")]
	[Address(RVA = "0x15DF778", Offset = "0x15DF778", VA = "0x15DF778")]
	private void Awake()
	{
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000027")]
	[Address(RVA = "0x15DF7D0", Offset = "0x15DF7D0", VA = "0x15DF7D0")]
	public void SetState(int type)
	{
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000028")]
	[Address(RVA = "0x15DF878", Offset = "0x15DF878", VA = "0x15DF878")]
	public TerrainObjectMatSet()
	{
	}

	// Token: 0x0400007C RID: 124
	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0x18")]
	public List<MatSetItem> matSetList;

	// Token: 0x0400007D RID: 125
	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0x20")]
	private MeshRenderer _meshRenderer;
}
