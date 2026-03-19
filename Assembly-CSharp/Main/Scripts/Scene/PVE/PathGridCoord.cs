using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Main.Scripts.Scene.PVE
{
	// Token: 0x02000504 RID: 1284
	[Token(Token = "0x2000504")]
	public static class PathGridCoord
	{
		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x060026CE RID: 9934 RVA: 0x0000E988 File Offset: 0x0000CB88
		[Token(Token = "0x170005CD")]
		public static float PathGridUnitSize
		{
			[Token(Token = "0x60026CE")]
			[Address(RVA = "0x2B65340", Offset = "0x2B65340", VA = "0x2B65340")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x060026CF RID: 9935 RVA: 0x0000E9A0 File Offset: 0x0000CBA0
		[Token(Token = "0x170005CE")]
		public static int PathGridSizeWidth
		{
			[Token(Token = "0x60026CF")]
			[Address(RVA = "0x2B651E8", Offset = "0x2B651E8", VA = "0x2B651E8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x060026D0 RID: 9936 RVA: 0x0000E9B8 File Offset: 0x0000CBB8
		[Token(Token = "0x170005CF")]
		public static int PathGridSizeHeight
		{
			[Token(Token = "0x60026D0")]
			[Address(RVA = "0x2B653C8", Offset = "0x2B653C8", VA = "0x2B653C8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x0000E9D0 File Offset: 0x0000CBD0
		[Token(Token = "0x60026D1")]
		[Address(RVA = "0x2B65428", Offset = "0x2B65428", VA = "0x2B65428")]
		public static Vector2Int PathGrid_IndexToGridPos(int gridIndex)
		{
			return default(Vector2Int);
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x0000E9E8 File Offset: 0x0000CBE8
		[Token(Token = "0x60026D2")]
		[Address(RVA = "0x2B654FC", Offset = "0x2B654FC", VA = "0x2B654FC")]
		public static int PathGrid_GridPosToIndex(Vector2Int pathGridPos)
		{
			return 0;
		}

		// Token: 0x060026D3 RID: 9939 RVA: 0x0000EA00 File Offset: 0x0000CC00
		[Token(Token = "0x60026D3")]
		[Address(RVA = "0x2B65078", Offset = "0x2B65078", VA = "0x2B65078")]
		public static Vector3 PathGrid_GridIndexToWorld(int gridIndexFromZero)
		{
			return default(Vector3);
		}

		// Token: 0x060026D4 RID: 9940 RVA: 0x0000EA18 File Offset: 0x0000CC18
		[Token(Token = "0x60026D4")]
		[Address(RVA = "0x2B655A0", Offset = "0x2B655A0", VA = "0x2B655A0")]
		public static Vector3 PathGrid_GridPosToWorld(Vector2Int pathGridPos)
		{
			return default(Vector3);
		}

		// Token: 0x060026D5 RID: 9941 RVA: 0x0000EA30 File Offset: 0x0000CC30
		[Token(Token = "0x60026D5")]
		[Address(RVA = "0x2B65248", Offset = "0x2B65248", VA = "0x2B65248")]
		public static Vector2Int PathGrid_WorldToGridPos(Vector3 worldPos)
		{
			return default(Vector2Int);
		}

		// Token: 0x060026D6 RID: 9942 RVA: 0x0000EA48 File Offset: 0x0000CC48
		[Token(Token = "0x60026D6")]
		[Address(RVA = "0x2B65000", Offset = "0x2B65000", VA = "0x2B65000")]
		public static int PathGrid_WorldToGridIndex(Vector3 worldPos)
		{
			return 0;
		}

		// Token: 0x060026D7 RID: 9943 RVA: 0x0000EA60 File Offset: 0x0000CC60
		[Token(Token = "0x60026D7")]
		[Address(RVA = "0x2B65634", Offset = "0x2B65634", VA = "0x2B65634")]
		public static Vector3 PathGrid_GridFloatToWorld(Vector2 pathGridPos)
		{
			return default(Vector3);
		}

		// Token: 0x0400230D RID: 8973
		[Token(Token = "0x400230D")]
		[FieldOffset(Offset = "0x0")]
		public static Vector2Int TileMapSize;

		// Token: 0x0400230E RID: 8974
		[Token(Token = "0x400230E")]
		[FieldOffset(Offset = "0x8")]
		public static int PathGridScale;
	}
}
