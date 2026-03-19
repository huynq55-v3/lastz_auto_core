using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Mathematics;

namespace RVO_DOTS
{
	// Token: 0x020003C2 RID: 962
	[Token(Token = "0x20003C2")]
	[BurstCompile]
	public struct Line
	{
		// Token: 0x04001AD7 RID: 6871
		[Token(Token = "0x4001AD7")]
		[FieldOffset(Offset = "0x0")]
		public float2 direction;

		// Token: 0x04001AD8 RID: 6872
		[Token(Token = "0x4001AD8")]
		[FieldOffset(Offset = "0x8")]
		public float2 point;
	}
}
