using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002C3 RID: 707
[Token(Token = "0x20002C3")]
public static class TileCoordWorld
{
	// Token: 0x06001246 RID: 4678 RVA: 0x000072C0 File Offset: 0x000054C0
	[Token(Token = "0x6001246")]
	[Address(RVA = "0x1C5B09C", Offset = "0x1C5B09C", VA = "0x1C5B09C")]
	public static Vector3 TileFloatToWorld(Vector2 tilePos)
	{
		return default(Vector3);
	}

	// Token: 0x06001247 RID: 4679 RVA: 0x000072D8 File Offset: 0x000054D8
	[Token(Token = "0x6001247")]
	[Address(RVA = "0x1C5B180", Offset = "0x1C5B180", VA = "0x1C5B180")]
	public static Vector3 TileFloatToWorld(float x, float y)
	{
		return default(Vector3);
	}

	// Token: 0x06001248 RID: 4680 RVA: 0x000072F0 File Offset: 0x000054F0
	[Token(Token = "0x6001248")]
	[Address(RVA = "0x1C5B210", Offset = "0x1C5B210", VA = "0x1C5B210")]
	public static Vector2 WorldToTileFloat(Vector3 worldPos)
	{
		return default(Vector2);
	}

	// Token: 0x06001249 RID: 4681 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001249")]
	[Address(RVA = "0x1C5B2A0", Offset = "0x1C5B2A0", VA = "0x1C5B2A0")]
	public static void WorldXYZToTileFloatXY(float x, float y, float z, out float wx, out float wy)
	{
	}

	// Token: 0x0600124A RID: 4682 RVA: 0x00007308 File Offset: 0x00005508
	[Token(Token = "0x600124A")]
	[Address(RVA = "0x1C5B2D4", Offset = "0x1C5B2D4", VA = "0x1C5B2D4")]
	public static Vector2Int IndexToTilePos(int index, Vector2Int tileCount)
	{
		return default(Vector2Int);
	}

	// Token: 0x0600124B RID: 4683 RVA: 0x00007320 File Offset: 0x00005520
	[Token(Token = "0x600124B")]
	[Address(RVA = "0x1C5B344", Offset = "0x1C5B344", VA = "0x1C5B344")]
	public static int TilePosToIndex(Vector2Int tilePos, Vector2Int tileCount)
	{
		return 0;
	}

	// Token: 0x0600124C RID: 4684 RVA: 0x00007338 File Offset: 0x00005538
	[Token(Token = "0x600124C")]
	[Address(RVA = "0x1C5B380", Offset = "0x1C5B380", VA = "0x1C5B380")]
	public static Vector3 TileIndexToWorld(int index, Vector2Int tileCount)
	{
		return default(Vector3);
	}

	// Token: 0x0600124D RID: 4685 RVA: 0x00007350 File Offset: 0x00005550
	[Token(Token = "0x600124D")]
	[Address(RVA = "0x1C5B390", Offset = "0x1C5B390", VA = "0x1C5B390")]
	public static int WorldToTileIndex(Vector3 pos, Vector2Int tileCount)
	{
		return 0;
	}

	// Token: 0x0600124E RID: 4686 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600124E")]
	[Address(RVA = "0x1C5B3DC", Offset = "0x1C5B3DC", VA = "0x1C5B3DC")]
	public static void ForEachTile(Vector2Int centerPos, int tileRange, Action<Vector2Int> action)
	{
	}

	// Token: 0x0600124F RID: 4687 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600124F")]
	[Address(RVA = "0x1C5B5D0", Offset = "0x1C5B5D0", VA = "0x1C5B5D0")]
	public static List<Vector2Int> GetAllNeighborsPos(Vector2Int pos, int radius)
	{
		return null;
	}

	// Token: 0x06001250 RID: 4688 RVA: 0x00007368 File Offset: 0x00005568
	[Token(Token = "0x6001250")]
	[Address(RVA = "0x1C5B12C", Offset = "0x1C5B12C", VA = "0x1C5B12C")]
	public static Vector3 TileToWorld(Vector2Int tilePos)
	{
		return default(Vector3);
	}

	// Token: 0x06001251 RID: 4689 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001251")]
	[Address(RVA = "0x1C5BA70", Offset = "0x1C5BA70", VA = "0x1C5BA70")]
	public static void TileXYToWorldXYZ(int tilePosX, int tilePosY, out float x, out float y, out float z)
	{
	}

	// Token: 0x06001252 RID: 4690 RVA: 0x00007380 File Offset: 0x00005580
	[Token(Token = "0x6001252")]
	[Address(RVA = "0x1C5BAF8", Offset = "0x1C5BAF8", VA = "0x1C5BAF8")]
	public static Vector3 TileToWorld(int tilePosX, int tilePosY)
	{
		return default(Vector3);
	}

	// Token: 0x06001253 RID: 4691 RVA: 0x00007398 File Offset: 0x00005598
	[Token(Token = "0x6001253")]
	[Address(RVA = "0x1C5B22C", Offset = "0x1C5B22C", VA = "0x1C5B22C")]
	public static Vector2Int WorldToTile(Vector3 worldPos)
	{
		return default(Vector2Int);
	}

	// Token: 0x06001254 RID: 4692 RVA: 0x000073B0 File Offset: 0x000055B0
	[Token(Token = "0x6001254")]
	[Address(RVA = "0x1C5BBA8", Offset = "0x1C5BBA8", VA = "0x1C5BBA8")]
	public static Vector2Int IndexToTilePos(int index)
	{
		return default(Vector2Int);
	}

	// Token: 0x06001255 RID: 4693 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001255")]
	[Address(RVA = "0x1C5BC7C", Offset = "0x1C5BC7C", VA = "0x1C5BC7C")]
	public static void IndexToTilePosXY(int index, out int x, out int y)
	{
	}

	// Token: 0x06001256 RID: 4694 RVA: 0x000073C8 File Offset: 0x000055C8
	[Token(Token = "0x6001256")]
	[Address(RVA = "0x1C5BD38", Offset = "0x1C5BD38", VA = "0x1C5BD38")]
	public static int TilePosToIndex(Vector2Int tilePos)
	{
		return 0;
	}

	// Token: 0x06001257 RID: 4695 RVA: 0x000073E0 File Offset: 0x000055E0
	[Token(Token = "0x6001257")]
	[Address(RVA = "0x1C5BDF8", Offset = "0x1C5BDF8", VA = "0x1C5BDF8")]
	public static int TileXYToIndex(int tilePosX, int tilePosY)
	{
		return 0;
	}

	// Token: 0x06001258 RID: 4696 RVA: 0x000073F8 File Offset: 0x000055F8
	[Token(Token = "0x6001258")]
	[Address(RVA = "0x1C5BEB8", Offset = "0x1C5BEB8", VA = "0x1C5BEB8")]
	public static Vector3 TileIndexToWorld(int index)
	{
		return default(Vector3);
	}

	// Token: 0x06001259 RID: 4697 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001259")]
	[Address(RVA = "0x1C5BF90", Offset = "0x1C5BF90", VA = "0x1C5BF90")]
	public static void TileIndexToWorldXYZ(int index, out float x, out float y, out float z)
	{
	}

	// Token: 0x0600125A RID: 4698 RVA: 0x00007410 File Offset: 0x00005610
	[Token(Token = "0x600125A")]
	[Address(RVA = "0x1C5C078", Offset = "0x1C5C078", VA = "0x1C5C078")]
	public static int WorldToTileIndex(Vector3 pos)
	{
		return 0;
	}

	// Token: 0x0600125B RID: 4699 RVA: 0x00007428 File Offset: 0x00005628
	[Token(Token = "0x600125B")]
	[Address(RVA = "0x1C5C088", Offset = "0x1C5C088", VA = "0x1C5C088")]
	public static int WorldXYZToTileIndex(float x, float y, float z)
	{
		return 0;
	}

	// Token: 0x0600125C RID: 4700 RVA: 0x00007440 File Offset: 0x00005640
	[Token(Token = "0x600125C")]
	[Address(RVA = "0x1C5C098", Offset = "0x1C5C098", VA = "0x1C5C098")]
	public static Vector3 SnapToTileCenter(Vector3 worldPos)
	{
		return default(Vector3);
	}

	// Token: 0x0600125D RID: 4701 RVA: 0x00007458 File Offset: 0x00005658
	[Token(Token = "0x600125D")]
	[Address(RVA = "0x1C5C0A8", Offset = "0x1C5C0A8", VA = "0x1C5C0A8")]
	public static int TileDistance(Vector2Int a, Vector2Int b)
	{
		return 0;
	}

	// Token: 0x0600125E RID: 4702 RVA: 0x00007470 File Offset: 0x00005670
	[Token(Token = "0x600125E")]
	[Address(RVA = "0x1C5C184", Offset = "0x1C5C184", VA = "0x1C5C184")]
	public static int TileXYDistance(int ax, int ay, int bx, int by)
	{
		return 0;
	}

	// Token: 0x0600125F RID: 4703 RVA: 0x00007488 File Offset: 0x00005688
	[Token(Token = "0x600125F")]
	[Address(RVA = "0x1C5C19C", Offset = "0x1C5C19C", VA = "0x1C5C19C")]
	public static int TileDistance(int a, int b)
	{
		return 0;
	}

	// Token: 0x06001260 RID: 4704 RVA: 0x000074A0 File Offset: 0x000056A0
	[Token(Token = "0x6001260")]
	[Address(RVA = "0x1C5C1CC", Offset = "0x1C5C1CC", VA = "0x1C5C1CC")]
	public static float Vector2IntDistance(Vector2Int a, Vector2Int b)
	{
		return 0f;
	}

	// Token: 0x06001261 RID: 4705 RVA: 0x000074B8 File Offset: 0x000056B8
	[Token(Token = "0x6001261")]
	[Address(RVA = "0x1C5B944", Offset = "0x1C5B944", VA = "0x1C5B944")]
	public static Vector2Int GetNeighborPos(Vector2Int pos, int dir)
	{
		return default(Vector2Int);
	}

	// Token: 0x06001262 RID: 4706 RVA: 0x000074D0 File Offset: 0x000056D0
	[Token(Token = "0x6001262")]
	[Address(RVA = "0x1C5C2C0", Offset = "0x1C5C2C0", VA = "0x1C5C2C0")]
	public static int GetNeighborPos(int pointIndex, int dir)
	{
		return 0;
	}

	// Token: 0x06001263 RID: 4707 RVA: 0x000074E8 File Offset: 0x000056E8
	[Token(Token = "0x6001263")]
	[Address(RVA = "0x1C5C338", Offset = "0x1C5C338", VA = "0x1C5C338")]
	public static bool IsInMap(int x, int y)
	{
		return default(bool);
	}

	// Token: 0x06001264 RID: 4708 RVA: 0x00007500 File Offset: 0x00005700
	[Token(Token = "0x6001264")]
	[Address(RVA = "0x1C5C3D8", Offset = "0x1C5C3D8", VA = "0x1C5C3D8")]
	public static bool IsInMap(Vector2Int pt)
	{
		return default(bool);
	}

	// Token: 0x06001265 RID: 4709 RVA: 0x00007518 File Offset: 0x00005718
	[Token(Token = "0x6001265")]
	[Address(RVA = "0x1C5C3E0", Offset = "0x1C5C3E0", VA = "0x1C5C3E0")]
	public static bool IsInEdge(int x, int y)
	{
		return default(bool);
	}

	// Token: 0x06001266 RID: 4710 RVA: 0x00007530 File Offset: 0x00005730
	[Token(Token = "0x6001266")]
	[Address(RVA = "0x1C5C48C", Offset = "0x1C5C48C", VA = "0x1C5C48C")]
	public static bool IsInEdge(Vector2Int pt)
	{
		return default(bool);
	}

	// Token: 0x06001267 RID: 4711 RVA: 0x00007548 File Offset: 0x00005748
	[Token(Token = "0x6001267")]
	[Address(RVA = "0x1C5C494", Offset = "0x1C5C494", VA = "0x1C5C494")]
	public static Vector2Int ClampTilePos(Vector2Int tilePos)
	{
		return default(Vector2Int);
	}

	// Token: 0x06001268 RID: 4712 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001268")]
	[Address(RVA = "0x1C5C578", Offset = "0x1C5C578", VA = "0x1C5C578")]
	public static void GetRectTiles(Vector2Int pt, int rowNum, int colNum, List<int> tiles)
	{
	}
}
