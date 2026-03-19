using System;
using Il2CppDummyDll;
using Unity.Burst;

namespace RVO_DOTS
{
	// Token: 0x020003BC RID: 956
	[Token(Token = "0x20003BC")]
	[BurstCompile]
	public readonly struct ObstaclePair
	{
		// Token: 0x060017FD RID: 6141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017FD")]
		[Address(RVA = "0x1DBDBEC", Offset = "0x1DBDBEC", VA = "0x1DBDBEC")]
		internal unsafe ObstaclePair(float key, Obstacle* value)
		{
		}

		// Token: 0x04001AB6 RID: 6838
		[Token(Token = "0x4001AB6")]
		[FieldOffset(Offset = "0x0")]
		internal readonly float Key;

		// Token: 0x04001AB7 RID: 6839
		[Token(Token = "0x4001AB7")]
		[FieldOffset(Offset = "0x8")]
		internal unsafe readonly Obstacle* Value;
	}
}
