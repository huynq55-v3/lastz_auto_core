using System;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

// Token: 0x020002C2 RID: 706
[Token(Token = "0x20002C2")]
[Il2CppEagerStaticClassConstruction]
public static class TileCoord
{
	// Token: 0x06001239 RID: 4665 RVA: 0x000071A0 File Offset: 0x000053A0
	[Token(Token = "0x6001239")]
	[Address(RVA = "0x1C5AC8C", Offset = "0x1C5AC8C", VA = "0x1C5AC8C")]
	public static Vector3 TileToWorld(Vector2Int tilePos)
	{
		return default(Vector3);
	}

	// Token: 0x0600123A RID: 4666 RVA: 0x000071B8 File Offset: 0x000053B8
	[Token(Token = "0x600123A")]
	[Address(RVA = "0x1C5AD08", Offset = "0x1C5AD08", VA = "0x1C5AD08")]
	public static Vector3 TileToWorld(int tilePosX, int tilePosY)
	{
		return default(Vector3);
	}

	// Token: 0x0600123B RID: 4667 RVA: 0x000071D0 File Offset: 0x000053D0
	[Token(Token = "0x600123B")]
	[Address(RVA = "0x1C55878", Offset = "0x1C55878", VA = "0x1C55878")]
	public static Vector2Int WorldToTile(Vector3 worldPos)
	{
		return default(Vector2Int);
	}

	// Token: 0x0600123C RID: 4668 RVA: 0x000071E8 File Offset: 0x000053E8
	[Token(Token = "0x600123C")]
	[Address(RVA = "0x1C5AD84", Offset = "0x1C5AD84", VA = "0x1C5AD84")]
	public static Vector3 SnapToTileCenter(Vector3 worldPos)
	{
		return default(Vector3);
	}

	// Token: 0x0600123D RID: 4669 RVA: 0x00007200 File Offset: 0x00005400
	[Token(Token = "0x600123D")]
	[Address(RVA = "0x1C5AD94", Offset = "0x1C5AD94", VA = "0x1C5AD94")]
	public static Vector3 TileFloatToWorld(Vector2 tilePos)
	{
		return default(Vector3);
	}

	// Token: 0x0600123E RID: 4670 RVA: 0x00007218 File Offset: 0x00005418
	[Token(Token = "0x600123E")]
	[Address(RVA = "0x1C5ADF8", Offset = "0x1C5ADF8", VA = "0x1C5ADF8")]
	public static Vector3 TileFloatToWorld(float x, float y)
	{
		return default(Vector3);
	}

	// Token: 0x0600123F RID: 4671 RVA: 0x00007230 File Offset: 0x00005430
	[Token(Token = "0x600123F")]
	[Address(RVA = "0x1C5AE5C", Offset = "0x1C5AE5C", VA = "0x1C5AE5C")]
	public static Vector2 WorldToTileFloat(Vector3 worldPos)
	{
		return default(Vector2);
	}

	// Token: 0x06001240 RID: 4672 RVA: 0x00007248 File Offset: 0x00005448
	[Token(Token = "0x6001240")]
	[Address(RVA = "0x1C5AEBC", Offset = "0x1C5AEBC", VA = "0x1C5AEBC")]
	public static Vector2Int IndexToTilePos(int index, Vector2Int tileCount)
	{
		return default(Vector2Int);
	}

	// Token: 0x06001241 RID: 4673 RVA: 0x00007260 File Offset: 0x00005460
	[Token(Token = "0x6001241")]
	[Address(RVA = "0x1C5AF2C", Offset = "0x1C5AF2C", VA = "0x1C5AF2C")]
	public static int TilePosToIndex(Vector2Int tilePos, Vector2Int tileCount)
	{
		return 0;
	}

	// Token: 0x06001242 RID: 4674 RVA: 0x00007278 File Offset: 0x00005478
	[Token(Token = "0x6001242")]
	[Address(RVA = "0x1C5AF68", Offset = "0x1C5AF68", VA = "0x1C5AF68")]
	public static Vector3 TileIndexToWorld(int index, Vector2Int tileCount)
	{
		return default(Vector3);
	}

	// Token: 0x06001243 RID: 4675 RVA: 0x00007290 File Offset: 0x00005490
	[Token(Token = "0x6001243")]
	[Address(RVA = "0x1C5AF78", Offset = "0x1C5AF78", VA = "0x1C5AF78")]
	public static int WorldToTileIndex(Vector3 pos, Vector2Int tileCount)
	{
		return 0;
	}

	// Token: 0x06001244 RID: 4676 RVA: 0x000072A8 File Offset: 0x000054A8
	[Token(Token = "0x6001244")]
	[Address(RVA = "0x1C5AFC4", Offset = "0x1C5AFC4", VA = "0x1C5AFC4")]
	public static float TileDistance(Vector2Int a, Vector2Int b)
	{
		return 0f;
	}

	// Token: 0x04001526 RID: 5414
	[Token(Token = "0x4001526")]
	public const int MainCityTiles = 80;

	// Token: 0x04001527 RID: 5415
	[Token(Token = "0x4001527")]
	[FieldOffset(Offset = "0x0")]
	public static float TileSize;
}
