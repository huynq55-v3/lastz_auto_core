using System;
using Il2CppDummyDll;
using Unity.Burst;

namespace RVO_DOTS
{
	// Token: 0x020003C5 RID: 965
	[Token(Token = "0x20003C5")]
	[BurstCompile]
	public struct AgentPtr
	{
		// Token: 0x06001829 RID: 6185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001829")]
		[Address(RVA = "0x2012B84", Offset = "0x2012B84", VA = "0x2012B84")]
		public unsafe AgentPtr(Agent* agent)
		{
		}

		// Token: 0x04001AE0 RID: 6880
		[Token(Token = "0x4001AE0")]
		[FieldOffset(Offset = "0x0")]
		public unsafe Agent* Value;
	}
}
