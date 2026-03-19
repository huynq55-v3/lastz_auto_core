using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000156 RID: 342
[Token(Token = "0x2000156")]
public static class BezierUtils
{
	// Token: 0x060009EB RID: 2539 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009EB")]
	[Address(RVA = "0x33B7A78", Offset = "0x33B7A78", VA = "0x33B7A78")]
	public static Vector3[] Bezier2Path(Vector3 startPos, Vector3 controlPos, Vector3 endPos)
	{
		return null;
	}

	// Token: 0x060009EC RID: 2540 RVA: 0x000050D0 File Offset: 0x000032D0
	[Token(Token = "0x60009EC")]
	[Address(RVA = "0x33B7BC8", Offset = "0x33B7BC8", VA = "0x33B7BC8")]
	private static Vector3 CalculateCubicBezierPointfor2C(float t, Vector3 p0, Vector3 p1, Vector3 p2)
	{
		return default(Vector3);
	}

	// Token: 0x04000755 RID: 1877
	[Token(Token = "0x4000755")]
	[FieldOffset(Offset = "0x0")]
	private static int SEGMENT_COUNT;

	// Token: 0x04000756 RID: 1878
	[Token(Token = "0x4000756")]
	[FieldOffset(Offset = "0x8")]
	private static Vector3[] _paths;
}
