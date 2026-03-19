using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020000BF RID: 191
[Token(Token = "0x20000BF")]
[Preserve]
[Il2CppSetOption(Option.NullChecks, false)]
public static class OptiUtils
{
	// Token: 0x06000463 RID: 1123 RVA: 0x000034C8 File Offset: 0x000016C8
	[Token(Token = "0x6000463")]
	[Address(RVA = "0x2F715DC", Offset = "0x2F715DC", VA = "0x2F715DC")]
	public static float Vector3_Angle(float fx, float fy, float fz, float tx, float ty, float tz)
	{
		return 0f;
	}

	// Token: 0x06000464 RID: 1124 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000464")]
	[Address(RVA = "0x2F71828", Offset = "0x2F71828", VA = "0x2F71828")]
	public static void Vector3_MoveTowards(float current_x, float current_y, float current_z, float target_x, float target_y, float target_z, float maxDistanceDelta, out float x, out float y, out float z)
	{
	}

	// Token: 0x06000465 RID: 1125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000465")]
	[Address(RVA = "0x2F71958", Offset = "0x2F71958", VA = "0x2F71958")]
	public static void EnableAllChildren_TrailRenderer(Transform transform, bool includeInactive, bool enable)
	{
	}

	// Token: 0x06000466 RID: 1126 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000466")]
	[Address(RVA = "0x2F71ADC", Offset = "0x2F71ADC", VA = "0x2F71ADC")]
	public static void CalcConstructMilePointer(float yOffset, float leftPadding, float topPadding, float mainWorldPosX, float mainWorldPosY, float mainWorldPosZ, float targetWorldPosX, float targetWorldPosY, float targetWorldPosZ, float uiWorldGoHomeBtnBottomOffset, out bool show, out float dist, out float PosX, out float PosY, out float eulerAngleZ)
	{
	}

	// Token: 0x06000467 RID: 1127 RVA: 0x000034E0 File Offset: 0x000016E0
	[Token(Token = "0x6000467")]
	[Address(RVA = "0x2F71FF8", Offset = "0x2F71FF8", VA = "0x2F71FF8")]
	public static Vector2 GetRobustScreenPoint(Vector3 worldPosition, Camera camera, float margin)
	{
		return default(Vector2);
	}

	// Token: 0x04000438 RID: 1080
	[Token(Token = "0x4000438")]
	[FieldOffset(Offset = "0x0")]
	private static List<TrailRenderer> trailList;

	// Token: 0x04000439 RID: 1081
	[Token(Token = "0x4000439")]
	[FieldOffset(Offset = "0x8")]
	private static Vector3 tmpMainWorldPos;

	// Token: 0x0400043A RID: 1082
	[Token(Token = "0x400043A")]
	[FieldOffset(Offset = "0x14")]
	private static Vector3 tmpTargetWorldPos;

	// Token: 0x0400043B RID: 1083
	[Token(Token = "0x400043B")]
	[FieldOffset(Offset = "0x20")]
	private static Vector3 tmpMile;
}
