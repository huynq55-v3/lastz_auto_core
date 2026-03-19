using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200007C RID: 124
[Token(Token = "0x200007C")]
public class CatmullRomUtils
{
	// Token: 0x06000304 RID: 772 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000304")]
	[Address(RVA = "0x320F4B4", Offset = "0x320F4B4", VA = "0x320F4B4")]
	public static List<Vector3> CalcCatmullRomCurve(List<Vector3> ctrlPoints, bool loop)
	{
		return null;
	}

	// Token: 0x06000305 RID: 773 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000305")]
	[Address(RVA = "0x320F764", Offset = "0x320F764", VA = "0x320F764")]
	private static void GetCatmullRomSplinePos(List<Vector3> pos, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
	{
	}

	// Token: 0x06000306 RID: 774 RVA: 0x00003030 File Offset: 0x00001230
	[Token(Token = "0x6000306")]
	[Address(RVA = "0x320F900", Offset = "0x320F900", VA = "0x320F900")]
	private static Vector3 GetCatmullRomPosition(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
	{
		return default(Vector3);
	}

	// Token: 0x06000307 RID: 775 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000307")]
	[Address(RVA = "0x320FA08", Offset = "0x320FA08", VA = "0x320FA08")]
	public static List<Vector3> CalcCurve(Vector3 start, Vector3 end, float hwRatio)
	{
		return null;
	}

	// Token: 0x06000308 RID: 776 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000308")]
	[Address(RVA = "0x320FC64", Offset = "0x320FC64", VA = "0x320FC64")]
	public static List<Vector3> CalcCatmullRomCurve(List<Vector3> ctrlPoints, int frameCount)
	{
		return null;
	}

	// Token: 0x06000309 RID: 777 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000309")]
	[Address(RVA = "0x3210148", Offset = "0x3210148", VA = "0x3210148")]
	private static void GetCatmullRomSplinePos(List<Vector3> pos, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, int frame)
	{
	}

	// Token: 0x0600030A RID: 778 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600030A")]
	[Address(RVA = "0x3210284", Offset = "0x3210284", VA = "0x3210284")]
	public CatmullRomUtils()
	{
	}

	// Token: 0x04000294 RID: 660
	[Token(Token = "0x4000294")]
	private const int SIMPLE_POINT_PRE_UNIT = 50;
}
