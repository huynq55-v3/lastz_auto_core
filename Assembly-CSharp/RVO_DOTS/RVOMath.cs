using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Mathematics;

namespace RVO_DOTS
{
	// Token: 0x020003C4 RID: 964
	[Token(Token = "0x20003C4")]
	public struct RVOMath
	{
		// Token: 0x06001820 RID: 6176 RVA: 0x00008E98 File Offset: 0x00007098
		[Token(Token = "0x6001820")]
		[Address(RVA = "0x1DC2DCC", Offset = "0x1DC2DCC", VA = "0x1DC2DCC")]
		public static float abs(Vector2 vector)
		{
			return 0f;
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x00008EB0 File Offset: 0x000070B0
		[Token(Token = "0x6001821")]
		[Address(RVA = "0x1DC2DE8", Offset = "0x1DC2DE8", VA = "0x1DC2DE8")]
		public static float absSq(Vector2 vector)
		{
			return 0f;
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x00008EC8 File Offset: 0x000070C8
		[Token(Token = "0x6001822")]
		[Address(RVA = "0x1DC2E54", Offset = "0x1DC2E54", VA = "0x1DC2E54")]
		public static Vector2 normalize(Vector2 vector)
		{
			return default(Vector2);
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x00008EE0 File Offset: 0x000070E0
		[Token(Token = "0x6001823")]
		[Address(RVA = "0x1DBEEEC", Offset = "0x1DBEEEC", VA = "0x1DBEEEC")]
		[BurstCompile]
		internal static float det(float2 vector1, float2 vector2)
		{
			return 0f;
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x00008EF8 File Offset: 0x000070F8
		[Token(Token = "0x6001824")]
		[Address(RVA = "0x1DBF940", Offset = "0x1DBF940", VA = "0x1DBF940")]
		[BurstCompile]
		internal static float distSqPointLineSegment(float2 vector1, float2 vector2, float2 vector3)
		{
			return 0f;
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x00008F10 File Offset: 0x00007110
		[Token(Token = "0x6001825")]
		[Address(RVA = "0x1DC2E94", Offset = "0x1DC2E94", VA = "0x1DC2E94")]
		internal static float fabs(float scalar)
		{
			return 0f;
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x00008F28 File Offset: 0x00007128
		[Token(Token = "0x6001826")]
		[Address(RVA = "0x1DC2D90", Offset = "0x1DC2D90", VA = "0x1DC2D90")]
		[BurstCompile]
		internal static float leftOf(float2 a, float2 b, float2 c)
		{
			return 0f;
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x00008F40 File Offset: 0x00007140
		[Token(Token = "0x6001827")]
		[Address(RVA = "0x1DC2EF0", Offset = "0x1DC2EF0", VA = "0x1DC2EF0")]
		internal static float sqr(float scalar)
		{
			return 0f;
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x00008F58 File Offset: 0x00007158
		[Token(Token = "0x6001828")]
		[Address(RVA = "0x1DC2DF8", Offset = "0x1DC2DF8", VA = "0x1DC2DF8")]
		internal static float sqrt(float scalar)
		{
			return 0f;
		}

		// Token: 0x04001ADF RID: 6879
		[Token(Token = "0x4001ADF")]
		internal const float RVO_EPSILON = 1E-05f;
	}
}
