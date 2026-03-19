using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;

namespace RVO_DOTS
{
	// Token: 0x020003C1 RID: 961
	[Token(Token = "0x20003C1")]
	[BurstCompile]
	public struct KdTree
	{
		// Token: 0x06001811 RID: 6161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001811")]
		[Address(RVA = "0x1DC0044", Offset = "0x1DC0044", VA = "0x1DC0044")]
		[BurstCompile]
		public void Destroy()
		{
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001812")]
		[Address(RVA = "0x1DC0048", Offset = "0x1DC0048", VA = "0x1DC0048")]
		internal unsafe void buildAgentTree(ref UnsafePtrList<Agent>* agents, ref UnsafeList<AgentTreeNode>* agentTree)
		{
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001813")]
		[Address(RVA = "0x1DC0420", Offset = "0x1DC0420", VA = "0x1DC0420")]
		[BurstCompile]
		internal unsafe ObstacleTreeNode* buildObstacleTree(ref UnsafePtrList<ObstacleTreeNode>* obstacleTreeList)
		{
			return null;
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001814")]
		[Address(RVA = "0x1DBDE90", Offset = "0x1DBDE90", VA = "0x1DBDE90")]
		[BurstCompile]
		internal unsafe void computeAgentNeighbors(Agent* agent, ref float rangeSq, ref UnsafeList<AgentTreeNode>* agentTree, ref UnsafeList<AgentPair>* agentNeighbors, ref UnsafePtrList<Agent>* agents)
		{
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001815")]
		[Address(RVA = "0x1DBDDFC", Offset = "0x1DBDDFC", VA = "0x1DBDDFC")]
		[BurstCompile]
		internal unsafe void computeObstacleNeighbors(Agent* agent, float rangeSq, ref ObstacleTreeNode* obstacleTree, ref UnsafePtrList<ObstacleTreeNode>* obstacleTreeList, ref UnsafeList<ObstaclePair>* obstacleNeighbors)
		{
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x00008E50 File Offset: 0x00007050
		[Token(Token = "0x6001816")]
		[Address(RVA = "0x1DC176C", Offset = "0x1DC176C", VA = "0x1DC176C")]
		[BurstCompile]
		internal unsafe int queryNearAgent(float2 point, float radius, ref UnsafeList<AgentTreeNode>* agentTree, ref UnsafePtrList<Agent>* agents)
		{
			return 0;
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001817")]
		[Address(RVA = "0x1DC031C", Offset = "0x1DC031C", VA = "0x1DC031C")]
		private unsafe void buildAgentTreeRecursive(int begin, int end, int node, ref UnsafeList<AgentTreeNode>* agentTree, ref UnsafePtrList<Agent>* agents)
		{
		}

		// Token: 0x06001818 RID: 6168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001818")]
		[Address(RVA = "0x1DC1CA0", Offset = "0x1DC1CA0", VA = "0x1DC1CA0")]
		private unsafe void buildAgentTreeRecursiveImpl(int begin, int end, int node, ref UnsafeList<AgentTreeNode>* agentTree, ref UnsafePtrList<Agent>* agents)
		{
		}

		// Token: 0x06001819 RID: 6169 RVA: 0x00008E68 File Offset: 0x00007068
		[Token(Token = "0x6001819")]
		[Address(RVA = "0x1DC2D40", Offset = "0x1DC2D40", VA = "0x1DC2D40")]
		public bool smaller(float ax, float ay, float bx, float by)
		{
			return default(bool);
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x00008E80 File Offset: 0x00007080
		[Token(Token = "0x600181A")]
		[Address(RVA = "0x1DC2D68", Offset = "0x1DC2D68", VA = "0x1DC2D68")]
		public bool largereq(float ax, float ay, float bx, float by)
		{
			return default(bool);
		}

		// Token: 0x0600181B RID: 6171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600181B")]
		[Address(RVA = "0x1DC05E0", Offset = "0x1DC05E0", VA = "0x1DC05E0")]
		[BurstCompile]
		private unsafe ObstacleTreeNode* buildObstacleTreeRecursive(ref UnsafePtrList<Obstacle> obstacles, ref UnsafePtrList<ObstacleTreeNode>* obstacleTreeList)
		{
			return null;
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600181C")]
		[Address(RVA = "0x1DC17C4", Offset = "0x1DC17C4", VA = "0x1DC17C4")]
		[BurstCompile]
		private unsafe void queryAgentTreeRecursive(float2 position, ref float rangeSq, ref int agentNo, int node, ref UnsafeList<AgentTreeNode>* agentTree, ref UnsafePtrList<Agent>* agents)
		{
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600181D")]
		[Address(RVA = "0x1DC0DD4", Offset = "0x1DC0DD4", VA = "0x1DC0DD4")]
		[BurstCompile]
		private unsafe void queryAgentTreeRecursive(Agent* agent, ref float rangeSq, int node, ref UnsafeList<AgentTreeNode>* agentTree, ref UnsafeList<AgentPair>* agentNeighbors, ref UnsafePtrList<Agent>* agents)
		{
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600181E")]
		[Address(RVA = "0x1DC1544", Offset = "0x1DC1544", VA = "0x1DC1544")]
		[BurstCompile]
		private unsafe void queryObstacleTreeRecursive(Agent* agent, float rangeSq, ref ObstacleTreeNode* node, ref UnsafePtrList<ObstacleTreeNode>* obstacleTreeList, ref UnsafeList<ObstaclePair>* obstacleNeighbors)
		{
		}

		// Token: 0x04001AD5 RID: 6869
		[Token(Token = "0x4001AD5")]
		private const int MAX_LEAF_SIZE = 10;

		// Token: 0x04001AD6 RID: 6870
		[Token(Token = "0x4001AD6")]
		[FieldOffset(Offset = "0x0")]
		private static bool isReport;
	}
}
