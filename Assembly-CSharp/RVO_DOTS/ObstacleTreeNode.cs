using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections.LowLevel.Unsafe;

namespace RVO_DOTS
{
	// Token: 0x020003C0 RID: 960
	[Token(Token = "0x20003C0")]
	[BurstCompile]
	public struct ObstacleTreeNode
	{
		// Token: 0x06001810 RID: 6160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001810")]
		[Address(RVA = "0x1DC0034", Offset = "0x1DC0034", VA = "0x1DC0034")]
		public unsafe ObstacleTreeNode([Optional] Obstacle* obstacle)
		{
		}

		// Token: 0x04001AD2 RID: 6866
		[Token(Token = "0x4001AD2")]
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		public unsafe Obstacle* obstacle_;

		// Token: 0x04001AD3 RID: 6867
		[Token(Token = "0x4001AD3")]
		[FieldOffset(Offset = "0x8")]
		public int left_;

		// Token: 0x04001AD4 RID: 6868
		[Token(Token = "0x4001AD4")]
		[FieldOffset(Offset = "0xC")]
		public int right_;
	}
}
