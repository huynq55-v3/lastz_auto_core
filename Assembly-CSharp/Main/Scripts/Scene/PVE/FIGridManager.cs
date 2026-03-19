using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Main.Scripts.Scene.PVE
{
	// Token: 0x02000502 RID: 1282
	[Token(Token = "0x2000502")]
	public class FIGridManager
	{
		// Token: 0x060026BD RID: 9917 RVA: 0x0000E8E0 File Offset: 0x0000CAE0
		[Token(Token = "0x60026BD")]
		[Address(RVA = "0x2B639FC", Offset = "0x2B639FC", VA = "0x2B639FC")]
		private bool IsValidNode(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x060026BE RID: 9918 RVA: 0x0000E8F8 File Offset: 0x0000CAF8
		[Token(Token = "0x60026BE")]
		[Address(RVA = "0x2B63AE8", Offset = "0x2B63AE8", VA = "0x2B63AE8")]
		private bool IsInOpenSet(FIGridManager.Node p)
		{
			return default(bool);
		}

		// Token: 0x060026BF RID: 9919 RVA: 0x0000E910 File Offset: 0x0000CB10
		[Token(Token = "0x60026BF")]
		[Address(RVA = "0x2B63C70", Offset = "0x2B63C70", VA = "0x2B63C70")]
		private bool IsInCloseSet(FIGridManager.Node p)
		{
			return default(bool);
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C0")]
		[Address(RVA = "0x2B63DF8", Offset = "0x2B63DF8", VA = "0x2B63DF8")]
		private void ProcessNode(int x, int y, FIGridManager.Node parent)
		{
		}

		// Token: 0x060026C1 RID: 9921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026C1")]
		[Address(RVA = "0x2B64204", Offset = "0x2B64204", VA = "0x2B64204")]
		private List<int> BuildPath(FIGridManager.Node p)
		{
			return null;
		}

		// Token: 0x060026C2 RID: 9922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026C2")]
		[Address(RVA = "0x2B642F8", Offset = "0x2B642F8", VA = "0x2B642F8")]
		private FIGridManager.Node SelectPointInOpenList()
		{
			return null;
		}

		// Token: 0x060026C3 RID: 9923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C3")]
		[Address(RVA = "0x2B64464", Offset = "0x2B64464", VA = "0x2B64464")]
		public FIGridManager(WorldSceneDesc.GridDesc gridDesc)
		{
		}

		// Token: 0x060026C4 RID: 9924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026C4")]
		[Address(RVA = "0x2B6462C", Offset = "0x2B6462C", VA = "0x2B6462C")]
		public List<int> FindPath(int startIdx, int dstIdx)
		{
			return null;
		}

		// Token: 0x060026C5 RID: 9925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C5")]
		[Address(RVA = "0x2B649F8", Offset = "0x2B649F8", VA = "0x2B649F8")]
		public void FindPathForLua(Vector3 startPos, Vector3 dstPos, LuaTable t)
		{
		}

		// Token: 0x060026C6 RID: 9926 RVA: 0x0000E928 File Offset: 0x0000CB28
		[Token(Token = "0x60026C6")]
		[Address(RVA = "0x2B64D68", Offset = "0x2B64D68", VA = "0x2B64D68")]
		private bool IsInClosed(Vector2Int tilePos)
		{
			return default(bool);
		}

		// Token: 0x060026C7 RID: 9927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C7")]
		[Address(RVA = "0x2B64E5C", Offset = "0x2B64E5C", VA = "0x2B64E5C")]
		public void SetWalkable(int tilePosX, int tilePosY, int value)
		{
		}

		// Token: 0x060026C8 RID: 9928 RVA: 0x0000E940 File Offset: 0x0000CB40
		[Token(Token = "0x60026C8")]
		[Address(RVA = "0x2B65170", Offset = "0x2B65170", VA = "0x2B65170")]
		private bool IsValidTilePos(Vector2Int tilePos)
		{
			return default(bool);
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x0000E958 File Offset: 0x0000CB58
		[Token(Token = "0x60026C9")]
		[Address(RVA = "0x2B64F78", Offset = "0x2B64F78", VA = "0x2B64F78")]
		public bool IsValidPos(Vector3 worldPos)
		{
			return default(bool);
		}

		// Token: 0x040022FC RID: 8956
		[Token(Token = "0x40022FC")]
		[FieldOffset(Offset = "0x0")]
		private static int _width;

		// Token: 0x040022FD RID: 8957
		[Token(Token = "0x40022FD")]
		[FieldOffset(Offset = "0x4")]
		private static int _height;

		// Token: 0x040022FE RID: 8958
		[Token(Token = "0x40022FE")]
		[FieldOffset(Offset = "0x10")]
		public readonly byte[] WalkableInfo;

		// Token: 0x040022FF RID: 8959
		[Token(Token = "0x40022FF")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<FIGridManager.Node> _openSet;

		// Token: 0x04002300 RID: 8960
		[Token(Token = "0x4002300")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<FIGridManager.Node> _closeSet;

		// Token: 0x04002301 RID: 8961
		[Token(Token = "0x4002301")]
		[FieldOffset(Offset = "0x8")]
		private static FIGridManager.Node _startNode;

		// Token: 0x04002302 RID: 8962
		[Token(Token = "0x4002302")]
		[FieldOffset(Offset = "0x10")]
		private static FIGridManager.Node _dstNode;

		// Token: 0x04002303 RID: 8963
		[Token(Token = "0x4002303")]
		[FieldOffset(Offset = "0x18")]
		private static readonly float Sqrt2;

		// Token: 0x04002304 RID: 8964
		[Token(Token = "0x4002304")]
		[FieldOffset(Offset = "0x28")]
		public List<int> CachePath;

		// Token: 0x04002305 RID: 8965
		[Token(Token = "0x4002305")]
		[FieldOffset(Offset = "0x30")]
		private long _lastTimeStamp;

		// Token: 0x04002306 RID: 8966
		[Token(Token = "0x4002306")]
		[FieldOffset(Offset = "0x38")]
		private readonly DateTime _originTime;

		// Token: 0x02000503 RID: 1283
		[Token(Token = "0x2000503")]
		private class Node
		{
			// Token: 0x060026CB RID: 9931 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60026CB")]
			[Address(RVA = "0x2B63FE4", Offset = "0x2B63FE4", VA = "0x2B63FE4")]
			public Node(int index)
			{
			}

			// Token: 0x060026CC RID: 9932 RVA: 0x0000E970 File Offset: 0x0000CB70
			[Token(Token = "0x60026CC")]
			[Address(RVA = "0x2B6411C", Offset = "0x2B6411C", VA = "0x2B6411C")]
			public float Distance(FIGridManager.Node other)
			{
				return 0f;
			}

			// Token: 0x060026CD RID: 9933 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60026CD")]
			[Address(RVA = "0x2B64074", Offset = "0x2B64074", VA = "0x2B64074")]
			public void SetParent(FIGridManager.Node parent)
			{
			}

			// Token: 0x04002307 RID: 8967
			[Token(Token = "0x4002307")]
			[FieldOffset(Offset = "0x10")]
			public readonly int Index;

			// Token: 0x04002308 RID: 8968
			[Token(Token = "0x4002308")]
			[FieldOffset(Offset = "0x14")]
			public readonly int X;

			// Token: 0x04002309 RID: 8969
			[Token(Token = "0x4002309")]
			[FieldOffset(Offset = "0x18")]
			public readonly int Y;

			// Token: 0x0400230A RID: 8970
			[Token(Token = "0x400230A")]
			[FieldOffset(Offset = "0x1C")]
			public float G;

			// Token: 0x0400230B RID: 8971
			[Token(Token = "0x400230B")]
			[FieldOffset(Offset = "0x20")]
			public float Cost;

			// Token: 0x0400230C RID: 8972
			[Token(Token = "0x400230C")]
			[FieldOffset(Offset = "0x28")]
			public FIGridManager.Node Parent;
		}
	}
}
