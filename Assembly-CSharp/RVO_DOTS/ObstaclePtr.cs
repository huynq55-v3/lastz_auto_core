using System;
using Il2CppDummyDll;
using Unity.Burst;

namespace RVO_DOTS
{
	// Token: 0x020003C6 RID: 966
	[Token(Token = "0x20003C6")]
	[BurstCompile]
	public struct ObstaclePtr
	{
		// Token: 0x0600182A RID: 6186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600182A")]
		[Address(RVA = "0x2012B8C", Offset = "0x2012B8C", VA = "0x2012B8C")]
		public unsafe ObstaclePtr(Obstacle* obstacle)
		{
		}

		// Token: 0x04001AE1 RID: 6881
		[Token(Token = "0x4001AE1")]
		[FieldOffset(Offset = "0x0")]
		public unsafe Obstacle* Value;
	}
}
