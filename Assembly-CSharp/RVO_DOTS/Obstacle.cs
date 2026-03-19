using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Mathematics;

namespace RVO_DOTS
{
	// Token: 0x020003C3 RID: 963
	[Token(Token = "0x20003C3")]
	[BurstCompile]
	public struct Obstacle
	{
		// Token: 0x0600181F RID: 6175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600181F")]
		[Address(RVA = "0x1DC2DB0", Offset = "0x1DC2DB0", VA = "0x1DC2DB0")]
		public unsafe Obstacle(Obstacle* next, Obstacle* previous, float2 direction, float2 point, int id, bool convex)
		{
		}

		// Token: 0x04001AD9 RID: 6873
		[Token(Token = "0x4001AD9")]
		[FieldOffset(Offset = "0x0")]
		internal unsafe Obstacle* next_;

		// Token: 0x04001ADA RID: 6874
		[Token(Token = "0x4001ADA")]
		[FieldOffset(Offset = "0x8")]
		internal unsafe Obstacle* previous_;

		// Token: 0x04001ADB RID: 6875
		[Token(Token = "0x4001ADB")]
		[FieldOffset(Offset = "0x10")]
		internal float2 direction_;

		// Token: 0x04001ADC RID: 6876
		[Token(Token = "0x4001ADC")]
		[FieldOffset(Offset = "0x18")]
		internal float2 point_;

		// Token: 0x04001ADD RID: 6877
		[Token(Token = "0x4001ADD")]
		[FieldOffset(Offset = "0x20")]
		internal int id_;

		// Token: 0x04001ADE RID: 6878
		[Token(Token = "0x4001ADE")]
		[FieldOffset(Offset = "0x24")]
		internal bool convex_;
	}
}
