using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;

namespace RVO_DOTS
{
	// Token: 0x020003BD RID: 957
	[Token(Token = "0x20003BD")]
	[BurstCompile]
	public struct Agent
	{
		// Token: 0x060017FE RID: 6142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017FE")]
		[Address(RVA = "0x1DBDBF8", Offset = "0x1DBDBF8", VA = "0x1DBDBF8")]
		internal Agent(int id, float2 position, float2 prefVelocity, float2 velocity, int maxNeighbors, float maxSpeed, float speed, float neighborDist, float radius, float timeHorizon, float timeHorizonObst, bool hasTargetPosition, float2 targetPosition, Random random)
		{
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017FF")]
		[Address(RVA = "0x1DBDC38", Offset = "0x1DBDC38", VA = "0x1DBDC38")]
		internal void init()
		{
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001800")]
		[Address(RVA = "0x1DBDC6C", Offset = "0x1DBDC6C", VA = "0x1DBDC6C")]
		[BurstCompile]
		internal unsafe void computeNeighbors(Agent* agent, KdTree kdTree, ref UnsafeList<AgentPair>* agentNeighbors, ref UnsafeList<ObstaclePair>* obstacleNeighbors, ref ObstacleTreeNode* obstacleTree, ref UnsafePtrList<ObstacleTreeNode>* obstacleTreeList, ref UnsafeList<AgentTreeNode>* agentTree, ref UnsafePtrList<Agent>* agents)
		{
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001801")]
		[Address(RVA = "0x1DBDEA4", Offset = "0x1DBDEA4", VA = "0x1DBDEA4")]
		[BurstCompile]
		public void SetSpeed(float speed)
		{
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x00008DA8 File Offset: 0x00006FA8
		[Token(Token = "0x6001802")]
		[Address(RVA = "0x1DBDEAC", Offset = "0x1DBDEAC", VA = "0x1DBDEAC")]
		[BurstCompile]
		public float GetSpeed()
		{
			return 0f;
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001803")]
		[Address(RVA = "0x1DBDEB4", Offset = "0x1DBDEB4", VA = "0x1DBDEB4")]
		internal void computePrefVelocity()
		{
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001804")]
		[Address(RVA = "0x1DBE08C", Offset = "0x1DBE08C", VA = "0x1DBE08C")]
		[BurstCompile]
		internal unsafe void computeNewVelocity(float timeStep, ref UnsafeList<AgentPair>* agentNeighbors, ref UnsafeList<ObstaclePair>* obstacleNeighbors)
		{
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001805")]
		[Address(RVA = "0x1DBF5E0", Offset = "0x1DBF5E0", VA = "0x1DBF5E0")]
		[BurstCompile]
		internal unsafe void insertAgentNeighbor(Agent* agent, ref float rangeSq, ref UnsafeList<AgentPair>* agentNeighbors)
		{
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001806")]
		[Address(RVA = "0x1DBF7B4", Offset = "0x1DBF7B4", VA = "0x1DBF7B4")]
		[BurstCompile]
		internal unsafe void insertObstacleNeighbor(Obstacle* obstacle, float rangeSq, ref UnsafeList<ObstaclePair>* obstacleNeighbors)
		{
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001807")]
		[Address(RVA = "0x1DBF9C0", Offset = "0x1DBF9C0", VA = "0x1DBF9C0")]
		[BurstCompile]
		internal void update(float timeStep)
		{
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x00008DC0 File Offset: 0x00006FC0
		[Token(Token = "0x6001808")]
		[Address(RVA = "0x1DBFAD8", Offset = "0x1DBFAD8", VA = "0x1DBFAD8")]
		[BurstCompile]
		private bool linearProgram1(NativeList<Line> lines, int lineNo, float radius, float2 optVelocity, bool directionOpt, ref float2 result)
		{
			return default(bool);
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x00008DD8 File Offset: 0x00006FD8
		[Token(Token = "0x6001809")]
		[Address(RVA = "0x1DBEEFC", Offset = "0x1DBEEFC", VA = "0x1DBEEFC")]
		[BurstCompile]
		private int linearProgram2(NativeList<Line> lines, float radius, float2 optVelocity, bool directionOpt, ref float2 result)
		{
			return 0;
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600180A")]
		[Address(RVA = "0x1DBF124", Offset = "0x1DBF124", VA = "0x1DBF124")]
		[BurstCompile]
		private void linearProgram3(NativeList<Line> lines, int numObstLines, int beginLine, float radius, ref float2 result)
		{
		}

		// Token: 0x04001AB8 RID: 6840
		[Token(Token = "0x4001AB8")]
		[FieldOffset(Offset = "0x0")]
		internal float2 position_;

		// Token: 0x04001AB9 RID: 6841
		[Token(Token = "0x4001AB9")]
		[FieldOffset(Offset = "0x8")]
		internal float2 prefVelocity_;

		// Token: 0x04001ABA RID: 6842
		[Token(Token = "0x4001ABA")]
		[FieldOffset(Offset = "0x10")]
		internal float2 targetPosition_;

		// Token: 0x04001ABB RID: 6843
		[Token(Token = "0x4001ABB")]
		[FieldOffset(Offset = "0x18")]
		internal bool hasTargetPosition_;

		// Token: 0x04001ABC RID: 6844
		[Token(Token = "0x4001ABC")]
		[FieldOffset(Offset = "0x1C")]
		internal float2 velocity_;

		// Token: 0x04001ABD RID: 6845
		[Token(Token = "0x4001ABD")]
		[FieldOffset(Offset = "0x24")]
		internal int id_;

		// Token: 0x04001ABE RID: 6846
		[Token(Token = "0x4001ABE")]
		[FieldOffset(Offset = "0x28")]
		internal int maxNeighbors_;

		// Token: 0x04001ABF RID: 6847
		[Token(Token = "0x4001ABF")]
		[FieldOffset(Offset = "0x2C")]
		internal float maxSpeed_;

		// Token: 0x04001AC0 RID: 6848
		[Token(Token = "0x4001AC0")]
		[FieldOffset(Offset = "0x30")]
		internal float speed_;

		// Token: 0x04001AC1 RID: 6849
		[Token(Token = "0x4001AC1")]
		[FieldOffset(Offset = "0x34")]
		internal float neighborDist_;

		// Token: 0x04001AC2 RID: 6850
		[Token(Token = "0x4001AC2")]
		[FieldOffset(Offset = "0x38")]
		internal float radius_;

		// Token: 0x04001AC3 RID: 6851
		[Token(Token = "0x4001AC3")]
		[FieldOffset(Offset = "0x3C")]
		internal float timeHorizon_;

		// Token: 0x04001AC4 RID: 6852
		[Token(Token = "0x4001AC4")]
		[FieldOffset(Offset = "0x40")]
		internal float timeHorizonObst_;

		// Token: 0x04001AC5 RID: 6853
		[Token(Token = "0x4001AC5")]
		[FieldOffset(Offset = "0x44")]
		internal bool needDelete_;

		// Token: 0x04001AC6 RID: 6854
		[Token(Token = "0x4001AC6")]
		[FieldOffset(Offset = "0x48")]
		internal Random random_;

		// Token: 0x04001AC7 RID: 6855
		[Token(Token = "0x4001AC7")]
		[FieldOffset(Offset = "0x4C")]
		private float2 newVelocity_;
	}
}
