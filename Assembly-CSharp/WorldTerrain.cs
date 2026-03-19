using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000314 RID: 788
[Token(Token = "0x2000314")]
public class WorldTerrain : MonoBehaviour
{
	// Token: 0x060014E7 RID: 5351 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014E7")]
	[Address(RVA = "0x198C4A0", Offset = "0x198C4A0", VA = "0x198C4A0")]
	public void Create(int tileRange)
	{
	}

	// Token: 0x060014E8 RID: 5352 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014E8")]
	[Address(RVA = "0x198D4A0", Offset = "0x198D4A0", VA = "0x198D4A0")]
	private void Awake()
	{
	}

	// Token: 0x060014E9 RID: 5353 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014E9")]
	[Address(RVA = "0x198C4C8", Offset = "0x198C4C8", VA = "0x198C4C8")]
	private Mesh CreateMesh(int tileRange)
	{
		return null;
	}

	// Token: 0x060014EA RID: 5354 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014EA")]
	[Address(RVA = "0x198D574", Offset = "0x198D574", VA = "0x198D574")]
	public WorldTerrain()
	{
	}

	// Token: 0x040017C4 RID: 6084
	[Token(Token = "0x40017C4")]
	private const float MeshGridSize = 1.8101934f;

	// Token: 0x040017C5 RID: 6085
	[Token(Token = "0x40017C5")]
	[FieldOffset(Offset = "0x18")]
	private Mesh mesh;

	// Token: 0x040017C6 RID: 6086
	[Token(Token = "0x40017C6")]
	[FieldOffset(Offset = "0x20")]
	private MeshFilter filter;

	// Token: 0x040017C7 RID: 6087
	[Token(Token = "0x40017C7")]
	[FieldOffset(Offset = "0x28")]
	private MeshRenderer meshRenderer;

	// Token: 0x040017C8 RID: 6088
	[Token(Token = "0x40017C8")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private int sortingOrder;

	// Token: 0x040017C9 RID: 6089
	[Token(Token = "0x40017C9")]
	[FieldOffset(Offset = "0x38")]
	private int[] triangles;
}
