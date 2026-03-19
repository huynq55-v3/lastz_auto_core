using System;
using Il2CppDummyDll;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace RVO_DOTS
{
	// Token: 0x020003C7 RID: 967
	[Token(Token = "0x20003C7")]
	public struct RVOPrepareJob : IJob
	{
		// Token: 0x0600182B RID: 6187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600182B")]
		[Address(RVA = "0x2012B94", Offset = "0x2012B94", VA = "0x2012B94", Slot = "4")]
		public void Execute()
		{
		}

		// Token: 0x04001AE2 RID: 6882
		[Token(Token = "0x4001AE2")]
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		public unsafe int* agentCount;

		// Token: 0x04001AE3 RID: 6883
		[Token(Token = "0x4001AE3")]
		[FieldOffset(Offset = "0x8")]
		[NativeDisableUnsafePtrRestriction]
		public unsafe UnsafePtrList<Agent>* agents;

		// Token: 0x04001AE4 RID: 6884
		[Token(Token = "0x4001AE4")]
		[FieldOffset(Offset = "0x10")]
		[NativeDisableUnsafePtrRestriction]
		public unsafe UnsafePtrList<Agent>* agentsCopy;

		// Token: 0x04001AE5 RID: 6885
		[Token(Token = "0x4001AE5")]
		[FieldOffset(Offset = "0x18")]
		[NativeDisableUnsafePtrRestriction]
		public unsafe UnsafeList<AgentTreeNode>* agentTree;

		// Token: 0x04001AE6 RID: 6886
		[Token(Token = "0x4001AE6")]
		[FieldOffset(Offset = "0x20")]
		[NativeDisableUnsafePtrRestriction]
		public unsafe UnsafeParallelHashMap<int, int>* agentNo2indexDict;

		// Token: 0x04001AE7 RID: 6887
		[Token(Token = "0x4001AE7")]
		[FieldOffset(Offset = "0x28")]
		[NativeDisableUnsafePtrRestriction]
		public unsafe UnsafeParallelHashMap<int, int>* index2agentNoDict;

		// Token: 0x04001AE8 RID: 6888
		[Token(Token = "0x4001AE8")]
		[FieldOffset(Offset = "0x30")]
		public KdTree kdTree;
	}
}
