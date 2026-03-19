using System;
using Il2CppDummyDll;
using Unity.Burst;

namespace RVO_DOTS
{
	// Token: 0x020003BB RID: 955
	[Token(Token = "0x20003BB")]
	[BurstCompile]
	public struct AgentPair
	{
		// Token: 0x060017FC RID: 6140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017FC")]
		[Address(RVA = "0x1DBDBE0", Offset = "0x1DBDBE0", VA = "0x1DBDBE0")]
		internal unsafe AgentPair(float key, Agent* value)
		{
		}

		// Token: 0x04001AB4 RID: 6836
		[Token(Token = "0x4001AB4")]
		[FieldOffset(Offset = "0x0")]
		internal readonly float Key;

		// Token: 0x04001AB5 RID: 6837
		[Token(Token = "0x4001AB5")]
		[FieldOffset(Offset = "0x8")]
		internal unsafe readonly Agent* Value;
	}
}
