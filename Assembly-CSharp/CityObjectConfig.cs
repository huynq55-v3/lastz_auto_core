using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000009 RID: 9
[Token(Token = "0x2000009")]
[ExecuteInEditMode]
public class CityObjectConfig : MonoBehaviour
{
	// Token: 0x06000017 RID: 23 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000017")]
	[Address(RVA = "0x15DF180", Offset = "0x15DF180", VA = "0x15DF180")]
	public CityObjectConfig()
	{
	}

	// Token: 0x04000047 RID: 71
	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 sel_pos;

	// Token: 0x04000048 RID: 72
	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x24")]
	public float sel_radius;

	// Token: 0x04000049 RID: 73
	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x28")]
	public float circle_radius;

	// Token: 0x0400004A RID: 74
	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x30")]
	public string miniMapIcon;

	// Token: 0x0400004B RID: 75
	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x38")]
	public float height;

	// Token: 0x0400004C RID: 76
	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x3C")]
	public bool showSunShine;

	// Token: 0x0400004D RID: 77
	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x40")]
	public Vector2Int Tiles;
}
