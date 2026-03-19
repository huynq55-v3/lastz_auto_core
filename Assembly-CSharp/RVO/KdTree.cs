using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace RVO
{
	// Token: 0x020003CD RID: 973
	[Token(Token = "0x20003CD")]
	internal class KdTree
	{
		// Token: 0x06001873 RID: 6259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001873")]
		[Address(RVA = "0x201CB34", Offset = "0x201CB34", VA = "0x201CB34")]
		internal void buildAgentTree()
		{
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001874")]
		[Address(RVA = "0x201D400", Offset = "0x201D400", VA = "0x201D400")]
		internal void buildObstacleTree()
		{
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001875")]
		[Address(RVA = "0x2019544", Offset = "0x2019544", VA = "0x2019544")]
		internal void computeAgentNeighbors(Agent agent, ref float rangeSq)
		{
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001876")]
		[Address(RVA = "0x201953C", Offset = "0x201953C", VA = "0x201953C")]
		internal void computeObstacleNeighbors(Agent agent, float rangeSq)
		{
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x000092A0 File Offset: 0x000074A0
		[Token(Token = "0x6001877")]
		[Address(RVA = "0x201EC30", Offset = "0x201EC30", VA = "0x201EC30")]
		internal bool queryVisibility(Vector2 q1, Vector2 q2, float radius)
		{
			return default(bool);
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x000092B8 File Offset: 0x000074B8
		[Token(Token = "0x6001878")]
		[Address(RVA = "0x201EE68", Offset = "0x201EE68", VA = "0x201EE68")]
		internal int queryNearAgent(Vector2 point, float radius)
		{
			return 0;
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001879")]
		[Address(RVA = "0x201CF30", Offset = "0x201CF30", VA = "0x201CF30")]
		private void buildAgentTreeRecursive(int begin, int end, int node)
		{
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600187A")]
		[Address(RVA = "0x201D7B0", Offset = "0x201D7B0", VA = "0x201D7B0")]
		private KdTree.ObstacleTreeNode buildObstacleTreeRecursive(IList<Obstacle> obstacles)
		{
			return null;
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600187B")]
		[Address(RVA = "0x201EEB8", Offset = "0x201EEB8", VA = "0x201EEB8")]
		private void queryAgentTreeRecursive(Vector2 position, ref float rangeSq, ref int agentNo, int node)
		{
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600187C")]
		[Address(RVA = "0x201E710", Offset = "0x201E710", VA = "0x201E710")]
		private void queryAgentTreeRecursive(Agent agent, ref float rangeSq, int node)
		{
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600187D")]
		[Address(RVA = "0x201EB40", Offset = "0x201EB40", VA = "0x201EB40")]
		private void queryObstacleTreeRecursive(Agent agent, float rangeSq, KdTree.ObstacleTreeNode node)
		{
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x000092D0 File Offset: 0x000074D0
		[Token(Token = "0x600187E")]
		[Address(RVA = "0x201EC38", Offset = "0x201EC38", VA = "0x201EC38")]
		private bool queryVisibilityRecursive(Vector2 q1, Vector2 q2, float radius, KdTree.ObstacleTreeNode node)
		{
			return default(bool);
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600187F")]
		[Address(RVA = "0x201F378", Offset = "0x201F378", VA = "0x201F378")]
		public KdTree()
		{
		}

		// Token: 0x04001B26 RID: 6950
		[Token(Token = "0x4001B26")]
		private const int MAX_LEAF_SIZE = 10;

		// Token: 0x04001B27 RID: 6951
		[Token(Token = "0x4001B27")]
		[FieldOffset(Offset = "0x10")]
		private Agent[] agents_;

		// Token: 0x04001B28 RID: 6952
		[Token(Token = "0x4001B28")]
		[FieldOffset(Offset = "0x18")]
		private KdTree.AgentTreeNode[] agentTree_;

		// Token: 0x04001B29 RID: 6953
		[Token(Token = "0x4001B29")]
		[FieldOffset(Offset = "0x20")]
		private KdTree.ObstacleTreeNode obstacleTree_;

		// Token: 0x020003CE RID: 974
		[Token(Token = "0x20003CE")]
		private struct AgentTreeNode
		{
			// Token: 0x04001B2A RID: 6954
			[Token(Token = "0x4001B2A")]
			[FieldOffset(Offset = "0x0")]
			internal int begin_;

			// Token: 0x04001B2B RID: 6955
			[Token(Token = "0x4001B2B")]
			[FieldOffset(Offset = "0x4")]
			internal int end_;

			// Token: 0x04001B2C RID: 6956
			[Token(Token = "0x4001B2C")]
			[FieldOffset(Offset = "0x8")]
			internal int left_;

			// Token: 0x04001B2D RID: 6957
			[Token(Token = "0x4001B2D")]
			[FieldOffset(Offset = "0xC")]
			internal int right_;

			// Token: 0x04001B2E RID: 6958
			[Token(Token = "0x4001B2E")]
			[FieldOffset(Offset = "0x10")]
			internal float maxX_;

			// Token: 0x04001B2F RID: 6959
			[Token(Token = "0x4001B2F")]
			[FieldOffset(Offset = "0x14")]
			internal float maxY_;

			// Token: 0x04001B30 RID: 6960
			[Token(Token = "0x4001B30")]
			[FieldOffset(Offset = "0x18")]
			internal float minX_;

			// Token: 0x04001B31 RID: 6961
			[Token(Token = "0x4001B31")]
			[FieldOffset(Offset = "0x1C")]
			internal float minY_;
		}

		// Token: 0x020003CF RID: 975
		[Token(Token = "0x20003CF")]
		private struct FloatPair
		{
			// Token: 0x06001880 RID: 6272 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001880")]
			[Address(RVA = "0x201F318", Offset = "0x201F318", VA = "0x201F318")]
			internal FloatPair(float a, float b)
			{
			}

			// Token: 0x06001881 RID: 6273 RVA: 0x000092E8 File Offset: 0x000074E8
			[Token(Token = "0x6001881")]
			[Address(RVA = "0x201F348", Offset = "0x201F348", VA = "0x201F348")]
			public static bool operator <(KdTree.FloatPair pair1, KdTree.FloatPair pair2)
			{
				return default(bool);
			}

			// Token: 0x06001882 RID: 6274 RVA: 0x00009300 File Offset: 0x00007500
			[Token(Token = "0x6001882")]
			[Address(RVA = "0x201F380", Offset = "0x201F380", VA = "0x201F380")]
			public static bool operator <=(KdTree.FloatPair pair1, KdTree.FloatPair pair2)
			{
				return default(bool);
			}

			// Token: 0x06001883 RID: 6275 RVA: 0x00009318 File Offset: 0x00007518
			[Token(Token = "0x6001883")]
			[Address(RVA = "0x201F3C4", Offset = "0x201F3C4", VA = "0x201F3C4")]
			public static bool operator >(KdTree.FloatPair pair1, KdTree.FloatPair pair2)
			{
				return default(bool);
			}

			// Token: 0x06001884 RID: 6276 RVA: 0x00009330 File Offset: 0x00007530
			[Token(Token = "0x6001884")]
			[Address(RVA = "0x201F320", Offset = "0x201F320", VA = "0x201F320")]
			public static bool operator >=(KdTree.FloatPair pair1, KdTree.FloatPair pair2)
			{
				return default(bool);
			}

			// Token: 0x04001B32 RID: 6962
			[Token(Token = "0x4001B32")]
			[FieldOffset(Offset = "0x0")]
			private float a_;

			// Token: 0x04001B33 RID: 6963
			[Token(Token = "0x4001B33")]
			[FieldOffset(Offset = "0x4")]
			private float b_;
		}

		// Token: 0x020003D0 RID: 976
		[Token(Token = "0x20003D0")]
		private class ObstacleTreeNode
		{
			// Token: 0x06001885 RID: 6277 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001885")]
			[Address(RVA = "0x201D7A8", Offset = "0x201D7A8", VA = "0x201D7A8")]
			public ObstacleTreeNode()
			{
			}

			// Token: 0x04001B34 RID: 6964
			[Token(Token = "0x4001B34")]
			[FieldOffset(Offset = "0x10")]
			internal Obstacle obstacle_;

			// Token: 0x04001B35 RID: 6965
			[Token(Token = "0x4001B35")]
			[FieldOffset(Offset = "0x18")]
			internal KdTree.ObstacleTreeNode left_;

			// Token: 0x04001B36 RID: 6966
			[Token(Token = "0x4001B36")]
			[FieldOffset(Offset = "0x20")]
			internal KdTree.ObstacleTreeNode right_;
		}
	}
}
