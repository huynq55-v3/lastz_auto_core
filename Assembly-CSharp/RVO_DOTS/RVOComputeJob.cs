using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace RVO_DOTS
{
	// Token: 0x020003C8 RID: 968
	[Token(Token = "0x20003C8")]
	[BurstCompile]
	public struct RVOComputeJob : IJobParallelForBatch
	{
		// Token: 0x0600182C RID: 6188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600182C")]
		[Address(RVA = "0x2012ED0", Offset = "0x2012ED0", VA = "0x2012ED0", Slot = "4")]
		public void Execute(int startIndex, int count)
		{
		}

		// Token: 0x04001AE9 RID: 6889
		[Token(Token = "0x4001AE9")]
		[FieldOffset(Offset = "0x0")]
		public float timeStep;

		// Token: 0x04001AEA RID: 6890
		[Token(Token = "0x4001AEA")]
		[FieldOffset(Offset = "0x8")]
		[NativeDisableUnsafePtrRestriction]
		public unsafe UnsafePtrList<Agent>* agents;

		// Token: 0x04001AEB RID: 6891
		[Token(Token = "0x4001AEB")]
		[FieldOffset(Offset = "0x10")]
		[NativeDisableUnsafePtrRestriction]
		public unsafe UnsafePtrList<Agent>* agentsCopy;

		// Token: 0x04001AEC RID: 6892
		[Token(Token = "0x4001AEC")]
		[FieldOffset(Offset = "0x18")]
		public KdTree kdTree;

		// Token: 0x04001AED RID: 6893
		[Token(Token = "0x4001AED")]
		[FieldOffset(Offset = "0x20")]
		[NativeDisableUnsafePtrRestriction]
		public unsafe ObstacleTreeNode* obstacleTree;

		// Token: 0x04001AEE RID: 6894
		[Token(Token = "0x4001AEE")]
		[FieldOffset(Offset = "0x28")]
		[NativeDisableUnsafePtrRestriction]
		public unsafe UnsafePtrList<ObstacleTreeNode>* obstacleTreeList;

		// Token: 0x04001AEF RID: 6895
		[Token(Token = "0x4001AEF")]
		[FieldOffset(Offset = "0x30")]
		[NativeDisableUnsafePtrRestriction]
		public unsafe UnsafeList<AgentTreeNode>* agentTree;
	}
}
