using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace RVO_DOTS
{
	// Token: 0x020003C9 RID: 969
	[Token(Token = "0x20003C9")]
	[BurstCompile]
	public struct RVOUpdateJob : IJobParallelForBatch
	{
		// Token: 0x0600182D RID: 6189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600182D")]
		[Address(RVA = "0x2013210", Offset = "0x2013210", VA = "0x2013210", Slot = "4")]
		public void Execute(int startIndex, int count)
		{
		}

		// Token: 0x04001AF0 RID: 6896
		[Token(Token = "0x4001AF0")]
		[FieldOffset(Offset = "0x0")]
		public float timeStep;

		// Token: 0x04001AF1 RID: 6897
		[Token(Token = "0x4001AF1")]
		[FieldOffset(Offset = "0x8")]
		[NativeDisableUnsafePtrRestriction]
		public unsafe UnsafePtrList<Agent>* agents;
	}
}
