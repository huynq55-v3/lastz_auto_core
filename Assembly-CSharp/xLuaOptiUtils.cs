using System;
using BitBenderGames;
using Il2CppDummyDll;
using SuperScrollView;
using TMPro;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020000CE RID: 206
[Token(Token = "0x20000CE")]
[Preserve]
[Il2CppSetOption(Option.NullChecks, false)]
public static class xLuaOptiUtils
{
	// Token: 0x0600052E RID: 1326 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600052E")]
	[Address(RVA = "0x2F79820", Offset = "0x2F79820", VA = "0x2F79820")]
	public static void Quaternion_LookRotation(float forwardX, float forwardY, float forwardZ, float upX, float upY, float upZ, out float x, out float y, out float z, out float w)
	{
	}

	// Token: 0x0600052F RID: 1327 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600052F")]
	[Address(RVA = "0x2F79950", Offset = "0x2F79950", VA = "0x2F79950")]
	public static void Quaternion_RotateTowards(float fromX, float fromY, float fromZ, float fromW, float toX, float toY, float toZ, float toW, float maxDegreesDelta, out float x, out float y, out float z, out float w)
	{
	}

	// Token: 0x06000530 RID: 1328 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000530")]
	[Address(RVA = "0x2F79A74", Offset = "0x2F79A74", VA = "0x2F79A74")]
	public static void Quaternion_ToEulerAngles(float qX, float qY, float qZ, float qW, out float x, out float y, out float z)
	{
	}

	// Token: 0x06000531 RID: 1329 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000531")]
	[Address(RVA = "0x2F79AA8", Offset = "0x2F79AA8", VA = "0x2F79AA8")]
	public static void Quaternion_EulerToQuat(float x, float y, float z, out float qx, out float qy, out float qz, out float qw)
	{
	}

	// Token: 0x06000532 RID: 1330 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000532")]
	[Address(RVA = "0x2F79B00", Offset = "0x2F79B00", VA = "0x2F79B00")]
	public static void ToEulerAngles(this Quaternion q, out float x, out float y, out float z)
	{
	}

	// Token: 0x06000533 RID: 1331 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000533")]
	[Address(RVA = "0x2F79B34", Offset = "0x2F79B34", VA = "0x2F79B34")]
	public static void Quaternion_MulVec3(float qX, float qY, float qZ, float qW, float vX, float vY, float vZ, out float x, out float y, out float z)
	{
	}

	// Token: 0x06000534 RID: 1332 RVA: 0x00003AF8 File Offset: 0x00001CF8
	[Token(Token = "0x6000534")]
	[Address(RVA = "0x2F79B68", Offset = "0x2F79B68", VA = "0x2F79B68")]
	public static bool SimpleMove(this CharacterController cc, float x, float y, float z)
	{
		return default(bool);
	}

	// Token: 0x06000535 RID: 1333 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000535")]
	[Address(RVA = "0x2F79B70", Offset = "0x2F79B70", VA = "0x2F79B70")]
	public static void Move(this CharacterController cc, float x, float y, float z)
	{
	}

	// Token: 0x06000536 RID: 1334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000536")]
	[Address(RVA = "0x2F79B78", Offset = "0x2F79B78", VA = "0x2F79B78")]
	public static void Set_offsetMax(this RectTransform rt, float x, float y)
	{
	}

	// Token: 0x06000537 RID: 1335 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000537")]
	[Address(RVA = "0x2F79B80", Offset = "0x2F79B80", VA = "0x2F79B80")]
	public static void Get_offsetMax(this RectTransform rt, out float x, out float y)
	{
	}

	// Token: 0x06000538 RID: 1336 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000538")]
	[Address(RVA = "0x2F79BAC", Offset = "0x2F79BAC", VA = "0x2F79BAC")]
	public static void Set_offsetMin(this RectTransform rt, float x, float y)
	{
	}

	// Token: 0x06000539 RID: 1337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000539")]
	[Address(RVA = "0x2F79BB4", Offset = "0x2F79BB4", VA = "0x2F79BB4")]
	public static void Get_offsetMin(this RectTransform rt, out float x, out float y)
	{
	}

	// Token: 0x0600053A RID: 1338 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600053A")]
	[Address(RVA = "0x2F79BE0", Offset = "0x2F79BE0", VA = "0x2F79BE0")]
	public static void Set_anchorMin(this RectTransform rt, float x, float y)
	{
	}

	// Token: 0x0600053B RID: 1339 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600053B")]
	[Address(RVA = "0x2F79BE8", Offset = "0x2F79BE8", VA = "0x2F79BE8")]
	public static void Get_anchorMin(this RectTransform rt, out float x, out float y)
	{
	}

	// Token: 0x0600053C RID: 1340 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600053C")]
	[Address(RVA = "0x2F79C14", Offset = "0x2F79C14", VA = "0x2F79C14")]
	public static void Set_anchorMax(this RectTransform rt, float x, float y)
	{
	}

	// Token: 0x0600053D RID: 1341 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600053D")]
	[Address(RVA = "0x2F79C1C", Offset = "0x2F79C1C", VA = "0x2F79C1C")]
	public static void Get_anchorMax(this RectTransform rt, out float x, out float y)
	{
	}

	// Token: 0x0600053E RID: 1342 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600053E")]
	[Address(RVA = "0x2F79C48", Offset = "0x2F79C48", VA = "0x2F79C48")]
	public static void Set_anchoredPosition(this RectTransform rt, float x, float y)
	{
	}

	// Token: 0x0600053F RID: 1343 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600053F")]
	[Address(RVA = "0x2F79C50", Offset = "0x2F79C50", VA = "0x2F79C50")]
	public static void Get_anchoredPosition(this RectTransform rt, out float x, out float y)
	{
	}

	// Token: 0x06000540 RID: 1344 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000540")]
	[Address(RVA = "0x2F79C7C", Offset = "0x2F79C7C", VA = "0x2F79C7C")]
	public static void Set_anchoredPosition3D(this RectTransform rt, float x, float y, float z)
	{
	}

	// Token: 0x06000541 RID: 1345 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000541")]
	[Address(RVA = "0x2F79C84", Offset = "0x2F79C84", VA = "0x2F79C84")]
	public static void Get_anchoredPosition3D(this RectTransform rt, out float x, out float y, out float z)
	{
	}

	// Token: 0x06000542 RID: 1346 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000542")]
	[Address(RVA = "0x2F79CB8", Offset = "0x2F79CB8", VA = "0x2F79CB8")]
	public static void Set_pivot(this RectTransform rt, float x, float y)
	{
	}

	// Token: 0x06000543 RID: 1347 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000543")]
	[Address(RVA = "0x2F79CC0", Offset = "0x2F79CC0", VA = "0x2F79CC0")]
	public static void Get_pivot(this RectTransform rt, out float x, out float y)
	{
	}

	// Token: 0x06000544 RID: 1348 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000544")]
	[Address(RVA = "0x2F79CEC", Offset = "0x2F79CEC", VA = "0x2F79CEC")]
	public static void Set_sizeDelta(this RectTransform rt, float x, float y)
	{
	}

	// Token: 0x06000545 RID: 1349 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000545")]
	[Address(RVA = "0x2F79CF4", Offset = "0x2F79CF4", VA = "0x2F79CF4")]
	public static void Set_sizeDelta_x(this RectTransform rt, float x)
	{
	}

	// Token: 0x06000546 RID: 1350 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000546")]
	[Address(RVA = "0x2F79D24", Offset = "0x2F79D24", VA = "0x2F79D24")]
	public static void Set_sizeDelta_y(this RectTransform rt, float y)
	{
	}

	// Token: 0x06000547 RID: 1351 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000547")]
	[Address(RVA = "0x2F79D54", Offset = "0x2F79D54", VA = "0x2F79D54")]
	public static void Get_sizeDelta(this RectTransform rt, out float x, out float y)
	{
	}

	// Token: 0x06000548 RID: 1352 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000548")]
	[Address(RVA = "0x2F79D80", Offset = "0x2F79D80", VA = "0x2F79D80")]
	public static void Get_sizeDelta_x(this RectTransform rt, out float x)
	{
	}

	// Token: 0x06000549 RID: 1353 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000549")]
	[Address(RVA = "0x2F79D9C", Offset = "0x2F79D9C", VA = "0x2F79D9C")]
	public static void Get_sizeDelta_y(this RectTransform rt, out float y)
	{
	}

	// Token: 0x0600054A RID: 1354 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054A")]
	[Address(RVA = "0x2F79DB8", Offset = "0x2F79DB8", VA = "0x2F79DB8")]
	public static void Set_position(this Transform t, float x, float y, float z)
	{
	}

	// Token: 0x0600054B RID: 1355 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054B")]
	[Address(RVA = "0x2F79DC0", Offset = "0x2F79DC0", VA = "0x2F79DC0")]
	public static void Set_positionX(this Transform t, float x)
	{
	}

	// Token: 0x0600054C RID: 1356 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054C")]
	[Address(RVA = "0x2F79DF0", Offset = "0x2F79DF0", VA = "0x2F79DF0")]
	public static void Set_positionY(this Transform t, float x, float y, float z)
	{
	}

	// Token: 0x0600054D RID: 1357 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054D")]
	[Address(RVA = "0x2F79E20", Offset = "0x2F79E20", VA = "0x2F79E20")]
	public static void Set_positionZ(this Transform t, float x, float y, float z)
	{
	}

	// Token: 0x0600054E RID: 1358 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054E")]
	[Address(RVA = "0x2F79E50", Offset = "0x2F79E50", VA = "0x2F79E50")]
	public static void Get_position(this Transform rt, out float x, out float y, out float z)
	{
	}

	// Token: 0x0600054F RID: 1359 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054F")]
	[Address(RVA = "0x2F79E84", Offset = "0x2F79E84", VA = "0x2F79E84")]
	public static void Set_localPosition(this Transform t, float x, float y, float z)
	{
	}

	// Token: 0x06000550 RID: 1360 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000550")]
	[Address(RVA = "0x2F79E8C", Offset = "0x2F79E8C", VA = "0x2F79E8C")]
	public static void Get_localPosition(this Transform rt, out float x, out float y, out float z)
	{
	}

	// Token: 0x06000551 RID: 1361 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000551")]
	[Address(RVA = "0x2F79EC0", Offset = "0x2F79EC0", VA = "0x2F79EC0")]
	public static void Set_localScale(this Transform t, float x, float y, float z)
	{
	}

	// Token: 0x06000552 RID: 1362 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000552")]
	[Address(RVA = "0x2F79EC8", Offset = "0x2F79EC8", VA = "0x2F79EC8")]
	public static void Get_localScale(this Transform rt, out float x, out float y, out float z)
	{
	}

	// Token: 0x06000553 RID: 1363 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000553")]
	[Address(RVA = "0x2F79EFC", Offset = "0x2F79EFC", VA = "0x2F79EFC")]
	public static void Get_lossyScale(this Transform rt, out float x, out float y, out float z)
	{
	}

	// Token: 0x06000554 RID: 1364 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000554")]
	[Address(RVA = "0x2F79F30", Offset = "0x2F79F30", VA = "0x2F79F30")]
	public static void Set_eulerAngles(this Transform t, float x, float y, float z)
	{
	}

	// Token: 0x06000555 RID: 1365 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000555")]
	[Address(RVA = "0x2F79F38", Offset = "0x2F79F38", VA = "0x2F79F38")]
	public static void Get_eulerAngles(this Transform rt, out float x, out float y, out float z)
	{
	}

	// Token: 0x06000556 RID: 1366 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000556")]
	[Address(RVA = "0x2F79F6C", Offset = "0x2F79F6C", VA = "0x2F79F6C")]
	public static void Set_localEulerAngles(this Transform t, float x, float y, float z)
	{
	}

	// Token: 0x06000557 RID: 1367 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000557")]
	[Address(RVA = "0x2F79F74", Offset = "0x2F79F74", VA = "0x2F79F74")]
	public static void Get_localEulerAngles(this Transform rt, out float x, out float y, out float z)
	{
	}

	// Token: 0x06000558 RID: 1368 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000558")]
	[Address(RVA = "0x2F79FA8", Offset = "0x2F79FA8", VA = "0x2F79FA8")]
	public static void Set_rotation(this Transform t, float x, float y, float z, float w)
	{
	}

	// Token: 0x06000559 RID: 1369 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000559")]
	[Address(RVA = "0x2F79FB0", Offset = "0x2F79FB0", VA = "0x2F79FB0")]
	public static void Get_rotation(this Transform t, out float x, out float y, out float z, out float w)
	{
	}

	// Token: 0x0600055A RID: 1370 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600055A")]
	[Address(RVA = "0x2F79FF4", Offset = "0x2F79FF4", VA = "0x2F79FF4")]
	public static void Set_localRotation(this Transform t, float x, float y, float z, float w)
	{
	}

	// Token: 0x0600055B RID: 1371 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600055B")]
	[Address(RVA = "0x2F79FFC", Offset = "0x2F79FFC", VA = "0x2F79FFC")]
	public static void Get_localRotation(this Transform t, out float x, out float y, out float z, out float w)
	{
	}

	// Token: 0x0600055C RID: 1372 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600055C")]
	[Address(RVA = "0x2F7A040", Offset = "0x2F7A040", VA = "0x2F7A040")]
	public static void Set_forward(this Transform t, float x, float y, float z)
	{
	}

	// Token: 0x0600055D RID: 1373 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600055D")]
	[Address(RVA = "0x2F7A048", Offset = "0x2F7A048", VA = "0x2F7A048")]
	public static void Get_forward(this Transform t, out float x, out float y, out float z)
	{
	}

	// Token: 0x0600055E RID: 1374 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600055E")]
	[Address(RVA = "0x2F7A07C", Offset = "0x2F7A07C", VA = "0x2F7A07C")]
	public static void Set_positionAndRotation(this Transform rt, float x, float y, float z, float rx, float ry, float rz, float rw)
	{
	}

	// Token: 0x0600055F RID: 1375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600055F")]
	[Address(RVA = "0x2F7A084", Offset = "0x2F7A084", VA = "0x2F7A084")]
	public static void Set_position(this GameObject go, float x, float y, float z)
	{
	}

	// Token: 0x06000560 RID: 1376 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000560")]
	[Address(RVA = "0x2F7A0C4", Offset = "0x2F7A0C4", VA = "0x2F7A0C4")]
	public static void Get_position(this GameObject go, out float x, out float y, out float z)
	{
	}

	// Token: 0x06000561 RID: 1377 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000561")]
	[Address(RVA = "0x2F7A100", Offset = "0x2F7A100", VA = "0x2F7A100")]
	public static void Set_localPosition(this GameObject go, float x, float y, float z)
	{
	}

	// Token: 0x06000562 RID: 1378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000562")]
	[Address(RVA = "0x2F7A140", Offset = "0x2F7A140", VA = "0x2F7A140")]
	public static void Get_localPosition(this GameObject go, out float x, out float y, out float z)
	{
	}

	// Token: 0x06000563 RID: 1379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000563")]
	[Address(RVA = "0x2F7A17C", Offset = "0x2F7A17C", VA = "0x2F7A17C")]
	public static void Set_localScale(this GameObject go, float x, float y, float z)
	{
	}

	// Token: 0x06000564 RID: 1380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000564")]
	[Address(RVA = "0x2F7A1BC", Offset = "0x2F7A1BC", VA = "0x2F7A1BC")]
	public static void Get_localScale(this GameObject go, out float x, out float y, out float z)
	{
	}

	// Token: 0x06000565 RID: 1381 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000565")]
	[Address(RVA = "0x2F7A1C0", Offset = "0x2F7A1C0", VA = "0x2F7A1C0")]
	public static void Set_eulerAngles(this GameObject go, float x, float y, float z)
	{
	}

	// Token: 0x06000566 RID: 1382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000566")]
	[Address(RVA = "0x2F7A200", Offset = "0x2F7A200", VA = "0x2F7A200")]
	public static void Get_eulerAngles(this GameObject go, out float x, out float y, out float z)
	{
	}

	// Token: 0x06000567 RID: 1383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000567")]
	[Address(RVA = "0x2F7A23C", Offset = "0x2F7A23C", VA = "0x2F7A23C")]
	public static void Set_localEulerAngles(this GameObject go, float x, float y, float z)
	{
	}

	// Token: 0x06000568 RID: 1384 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000568")]
	[Address(RVA = "0x2F7A27C", Offset = "0x2F7A27C", VA = "0x2F7A27C")]
	public static void Get_localEulerAngles(this GameObject go, out float x, out float y, out float z)
	{
	}

	// Token: 0x06000569 RID: 1385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000569")]
	[Address(RVA = "0x2F7A2B8", Offset = "0x2F7A2B8", VA = "0x2F7A2B8")]
	public static void Set_rotation(this GameObject go, float x, float y, float z, float w)
	{
	}

	// Token: 0x0600056A RID: 1386 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600056A")]
	[Address(RVA = "0x2F7A300", Offset = "0x2F7A300", VA = "0x2F7A300")]
	public static void Get_rotation(this GameObject go, out float x, out float y, out float z, out float w)
	{
	}

	// Token: 0x0600056B RID: 1387 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600056B")]
	[Address(RVA = "0x2F7A34C", Offset = "0x2F7A34C", VA = "0x2F7A34C")]
	public static void Set_localRotation(this GameObject go, float x, float y, float z, float w)
	{
	}

	// Token: 0x0600056C RID: 1388 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600056C")]
	[Address(RVA = "0x2F7A394", Offset = "0x2F7A394", VA = "0x2F7A394")]
	public static void Get_localRotation(this GameObject go, out float x, out float y, out float z, out float w)
	{
	}

	// Token: 0x0600056D RID: 1389 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600056D")]
	[Address(RVA = "0x2F7A3E0", Offset = "0x2F7A3E0", VA = "0x2F7A3E0")]
	public static void Set_forward(this GameObject go, float x, float y, float z)
	{
	}

	// Token: 0x0600056E RID: 1390 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600056E")]
	[Address(RVA = "0x2F7A420", Offset = "0x2F7A420", VA = "0x2F7A420")]
	public static void Get_forward(this GameObject go, out float x, out float y, out float z)
	{
	}

	// Token: 0x0600056F RID: 1391 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600056F")]
	[Address(RVA = "0x2F7A45C", Offset = "0x2F7A45C", VA = "0x2F7A45C")]
	public static void Set_positionAndRotation(this GameObject go, float x, float y, float z, float rx, float ry, float rz, float rw)
	{
	}

	// Token: 0x06000570 RID: 1392 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000570")]
	[Address(RVA = "0x2F7A4CC", Offset = "0x2F7A4CC", VA = "0x2F7A4CC")]
	public static void Reset_localPosition(this Transform rt)
	{
	}

	// Token: 0x06000571 RID: 1393 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000571")]
	[Address(RVA = "0x2F7A4E0", Offset = "0x2F7A4E0", VA = "0x2F7A4E0")]
	public static void Reset_localScale(this Transform rt)
	{
	}

	// Token: 0x06000572 RID: 1394 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000572")]
	[Address(RVA = "0x2F7A4F4", Offset = "0x2F7A4F4", VA = "0x2F7A4F4")]
	public static void Reset_localPosition(this GameObject go)
	{
	}

	// Token: 0x06000573 RID: 1395 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000573")]
	[Address(RVA = "0x2F7A518", Offset = "0x2F7A518", VA = "0x2F7A518")]
	public static void Reset_localScale(this GameObject go)
	{
	}

	// Token: 0x06000574 RID: 1396 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000574")]
	[Address(RVA = "0x2F7A53C", Offset = "0x2F7A53C", VA = "0x2F7A53C")]
	public static void Set_color(this Graphic graphic, float r, float g, float b, float a)
	{
	}

	// Token: 0x06000575 RID: 1397 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000575")]
	[Address(RVA = "0x2F7A54C", Offset = "0x2F7A54C", VA = "0x2F7A54C")]
	public static void Set_color_r(this Graphic graphic, float r)
	{
	}

	// Token: 0x06000576 RID: 1398 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000576")]
	[Address(RVA = "0x2F7A58C", Offset = "0x2F7A58C", VA = "0x2F7A58C")]
	public static void Set_color_g(this Graphic graphic, float g)
	{
	}

	// Token: 0x06000577 RID: 1399 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000577")]
	[Address(RVA = "0x2F7A5CC", Offset = "0x2F7A5CC", VA = "0x2F7A5CC")]
	public static void Set_color_b(this Graphic graphic, float b)
	{
	}

	// Token: 0x06000578 RID: 1400 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000578")]
	[Address(RVA = "0x2F7A60C", Offset = "0x2F7A60C", VA = "0x2F7A60C")]
	public static void Set_color_a(this Graphic graphic, float a)
	{
	}

	// Token: 0x06000579 RID: 1401 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000579")]
	[Address(RVA = "0x2F7A64C", Offset = "0x2F7A64C", VA = "0x2F7A64C")]
	public static void Get_color(this Graphic graphic, out float r, out float g, out float b, out float a)
	{
	}

	// Token: 0x0600057A RID: 1402 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057A")]
	[Address(RVA = "0x2F7A69C", Offset = "0x2F7A69C", VA = "0x2F7A69C")]
	public static void Get_color_r(this Graphic graphic, out float r)
	{
	}

	// Token: 0x0600057B RID: 1403 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057B")]
	[Address(RVA = "0x2F7A6C4", Offset = "0x2F7A6C4", VA = "0x2F7A6C4")]
	public static void Get_color_g(this Graphic graphic, out float g)
	{
	}

	// Token: 0x0600057C RID: 1404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057C")]
	[Address(RVA = "0x2F7A6EC", Offset = "0x2F7A6EC", VA = "0x2F7A6EC")]
	public static void Get_color_b(this Graphic graphic, out float b)
	{
	}

	// Token: 0x0600057D RID: 1405 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057D")]
	[Address(RVA = "0x2F7A714", Offset = "0x2F7A714", VA = "0x2F7A714")]
	public static void Get_color_a(this Graphic graphic, out float a)
	{
	}

	// Token: 0x0600057E RID: 1406 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057E")]
	[Address(RVA = "0x2F7A73C", Offset = "0x2F7A73C", VA = "0x2F7A73C")]
	public static void Set_size(this SpriteRenderer r, float x, float y)
	{
	}

	// Token: 0x0600057F RID: 1407 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057F")]
	[Address(RVA = "0x2F7A744", Offset = "0x2F7A744", VA = "0x2F7A744")]
	public static void Get_size(this SpriteRenderer r, out float x, out float y)
	{
	}

	// Token: 0x06000580 RID: 1408 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000580")]
	[Address(RVA = "0x2F7A770", Offset = "0x2F7A770", VA = "0x2F7A770")]
	public static void Set_color(this SpriteRenderer sr, float r, float g, float b, float a)
	{
	}

	// Token: 0x06000581 RID: 1409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000581")]
	[Address(RVA = "0x2F7A778", Offset = "0x2F7A778", VA = "0x2F7A778")]
	public static void Set_color_r(this SpriteRenderer sr, float r)
	{
	}

	// Token: 0x06000582 RID: 1410 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000582")]
	[Address(RVA = "0x2F7A7A8", Offset = "0x2F7A7A8", VA = "0x2F7A7A8")]
	public static void Set_color_g(this SpriteRenderer sr, float g)
	{
	}

	// Token: 0x06000583 RID: 1411 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000583")]
	[Address(RVA = "0x2F7A7D8", Offset = "0x2F7A7D8", VA = "0x2F7A7D8")]
	public static void Set_color_b(this SpriteRenderer sr, float b)
	{
	}

	// Token: 0x06000584 RID: 1412 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000584")]
	[Address(RVA = "0x2F7A808", Offset = "0x2F7A808", VA = "0x2F7A808")]
	public static void Set_color_a(this SpriteRenderer sr, float a)
	{
	}

	// Token: 0x06000585 RID: 1413 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000585")]
	[Address(RVA = "0x2F7A838", Offset = "0x2F7A838", VA = "0x2F7A838")]
	public static void Set_color_a(this SpriteMeshRenderer sr, float a)
	{
	}

	// Token: 0x06000586 RID: 1414 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000586")]
	[Address(RVA = "0x2F7A854", Offset = "0x2F7A854", VA = "0x2F7A854")]
	public static void Get_color(this SpriteRenderer sr, out float r, out float g, out float b, out float a)
	{
	}

	// Token: 0x06000587 RID: 1415 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000587")]
	[Address(RVA = "0x2F7A898", Offset = "0x2F7A898", VA = "0x2F7A898")]
	public static void Get_color_r(this SpriteRenderer sr, out float r)
	{
	}

	// Token: 0x06000588 RID: 1416 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000588")]
	[Address(RVA = "0x2F7A8B4", Offset = "0x2F7A8B4", VA = "0x2F7A8B4")]
	public static void Get_color_g(this SpriteRenderer sr, out float g)
	{
	}

	// Token: 0x06000589 RID: 1417 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000589")]
	[Address(RVA = "0x2F7A8D0", Offset = "0x2F7A8D0", VA = "0x2F7A8D0")]
	public static void Get_color_b(this SpriteRenderer sr, out float b)
	{
	}

	// Token: 0x0600058A RID: 1418 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600058A")]
	[Address(RVA = "0x2F7A8EC", Offset = "0x2F7A8EC", VA = "0x2F7A8EC")]
	public static void Get_color_a(this SpriteRenderer sr, out float a)
	{
	}

	// Token: 0x0600058B RID: 1419 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600058B")]
	[Address(RVA = "0x2F7A908", Offset = "0x2F7A908", VA = "0x2F7A908")]
	public static void Get_TargetPos(this MobileTouchCamera touchCamera, out float x, out float y, out float z)
	{
	}

	// Token: 0x0600058C RID: 1420 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600058C")]
	[Address(RVA = "0x2F7A93C", Offset = "0x2F7A93C", VA = "0x2F7A93C")]
	public static void Native_SetText(this TextMeshProUGUI text, string value)
	{
	}

	// Token: 0x0600058D RID: 1421 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600058D")]
	[Address(RVA = "0x2F7A9AC", Offset = "0x2F7A9AC", VA = "0x2F7A9AC")]
	public static void Native_SetText(this TextMeshProUGUI text, int value)
	{
	}

	// Token: 0x0600058E RID: 1422 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600058E")]
	[Address(RVA = "0x2F7A9D0", Offset = "0x2F7A9D0", VA = "0x2F7A9D0")]
	public static void SetTextCacheID(this TextMeshProUGUI text, int cacheID)
	{
	}

	// Token: 0x0600058F RID: 1423 RVA: 0x00003B10 File Offset: 0x00001D10
	[Token(Token = "0x600058F")]
	[Address(RVA = "0x2F7AA3C", Offset = "0x2F7AA3C", VA = "0x2F7AA3C")]
	public static int GetCharacterCount(this TextMeshProUGUI text)
	{
		return 0;
	}

	// Token: 0x06000590 RID: 1424 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000590")]
	[Address(RVA = "0x2F7AA54", Offset = "0x2F7AA54", VA = "0x2F7AA54")]
	public static void Native_SetText(this Text text, string value)
	{
	}

	// Token: 0x06000591 RID: 1425 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000591")]
	[Address(RVA = "0x2F7AABC", Offset = "0x2F7AABC", VA = "0x2F7AABC")]
	public static void Native_SetText(this Text text, int value)
	{
	}

	// Token: 0x06000592 RID: 1426 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000592")]
	[Address(RVA = "0x2F7AAE0", Offset = "0x2F7AAE0", VA = "0x2F7AAE0")]
	public static void SetTextCacheID(this Text text, int cacheID)
	{
	}

	// Token: 0x06000593 RID: 1427 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000593")]
	[Address(RVA = "0x2F7AB4C", Offset = "0x2F7AB4C", VA = "0x2F7AB4C")]
	public static void Native_SetText(this TMP_InputField text, string value)
	{
	}

	// Token: 0x06000594 RID: 1428 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000594")]
	[Address(RVA = "0x2F7ABAC", Offset = "0x2F7ABAC", VA = "0x2F7ABAC")]
	public static void Native_SetText(this TMP_InputField text, int value)
	{
	}

	// Token: 0x06000595 RID: 1429 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000595")]
	[Address(RVA = "0x2F7ABD0", Offset = "0x2F7ABD0", VA = "0x2F7ABD0")]
	public static void SetTextCacheID(this TMP_InputField text, int cacheID)
	{
	}

	// Token: 0x06000596 RID: 1430 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000596")]
	[Address(RVA = "0x2F7AC3C", Offset = "0x2F7AC3C", VA = "0x2F7AC3C")]
	public static void Native_SetText(this SuperTextMesh text, string value)
	{
	}

	// Token: 0x06000597 RID: 1431 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000597")]
	[Address(RVA = "0x2F7AC9C", Offset = "0x2F7AC9C", VA = "0x2F7AC9C")]
	public static void Native_SetText(this SuperTextMesh text, int value)
	{
	}

	// Token: 0x06000598 RID: 1432 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000598")]
	[Address(RVA = "0x2F7ACC0", Offset = "0x2F7ACC0", VA = "0x2F7ACC0")]
	public static void SetTextCacheID(this SuperTextMesh text, int cacheID)
	{
	}

	// Token: 0x06000599 RID: 1433 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000599")]
	[Address(RVA = "0x2F7AD2C", Offset = "0x2F7AD2C", VA = "0x2F7AD2C")]
	public static void SetDestinationXYZ(this NavMeshAgent agent, float x, float y, float z)
	{
	}

	// Token: 0x0600059A RID: 1434 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600059A")]
	[Address(RVA = "0x2F7AD34", Offset = "0x2F7AD34", VA = "0x2F7AD34")]
	public static void Get_velocity(this NavMeshAgent agent, out float x, out float y, out float z)
	{
	}

	// Token: 0x0600059B RID: 1435 RVA: 0x00003B28 File Offset: 0x00001D28
	[Token(Token = "0x600059B")]
	[Address(RVA = "0x2F7AD8C", Offset = "0x2F7AD8C", VA = "0x2F7AD8C")]
	public static bool IsVelocityZero(this NavMeshAgent agent)
	{
		return default(bool);
	}

	// Token: 0x0600059C RID: 1436 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600059C")]
	[Address(RVA = "0x2F7ADA4", Offset = "0x2F7ADA4", VA = "0x2F7ADA4")]
	public static void WorldToScreenPoint_opti(this Camera camera, float x, float y, float z, out float ox, out float oy, out float oz)
	{
	}

	// Token: 0x0600059D RID: 1437 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600059D")]
	[Address(RVA = "0x2F7ADD8", Offset = "0x2F7ADD8", VA = "0x2F7ADD8")]
	public static void WorldToViewportPoint_opti(this Camera camera, float x, float y, float z, out float ox, out float oy, out float oz)
	{
	}

	// Token: 0x0600059E RID: 1438 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600059E")]
	[Address(RVA = "0x2F7AE0C", Offset = "0x2F7AE0C", VA = "0x2F7AE0C")]
	public static void ViewportToWorldPoint_opti(this Camera camera, float x, float y, float z, out float ox, out float oy, out float oz)
	{
	}

	// Token: 0x0600059F RID: 1439 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600059F")]
	[Address(RVA = "0x2F7AE40", Offset = "0x2F7AE40", VA = "0x2F7AE40")]
	public static void ScreenToWorldPoint_opti(this Camera camera, float x, float y, float z, out float ox, out float oy, out float oz)
	{
	}

	// Token: 0x060005A0 RID: 1440 RVA: 0x00003B40 File Offset: 0x00001D40
	[Token(Token = "0x60005A0")]
	[Address(RVA = "0x2F7AE74", Offset = "0x2F7AE74", VA = "0x2F7AE74")]
	public static bool HasCsClass(int cacheId)
	{
		return default(bool);
	}

	// Token: 0x060005A1 RID: 1441 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005A1")]
	[Address(RVA = "0x2F7AF50", Offset = "0x2F7AF50", VA = "0x2F7AF50")]
	public static LoopListViewItem2 NewListViewItem(this LoopListView2 loopList, int itemPrefabNameCacheId)
	{
		return null;
	}

	// Token: 0x060005A2 RID: 1442 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005A2")]
	[Address(RVA = "0x2F7AFE4", Offset = "0x2F7AFE4", VA = "0x2F7AFE4")]
	public static LoopListLazyViewItem2 NewListViewItem(this LoopListLazyView2 loopList, int itemPrefabNameCacheId)
	{
		return null;
	}

	// Token: 0x060005A3 RID: 1443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A3")]
	[Address(RVA = "0x2F7B078", Offset = "0x2F7B078", VA = "0x2F7B078")]
	public static void GetCameraTargetXYZ(this MobileTouchCamera camera, out float x, out float y, out float z)
	{
	}

	// Token: 0x060005A4 RID: 1444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A4")]
	[Address(RVA = "0x2F7B0AC", Offset = "0x2F7B0AC", VA = "0x2F7B0AC")]
	public static void LookAtRotation(this Transform tf, float targetPosX, float targetPosY, float targetPosZ, float upX, float upY, float upZ, out float x, out float y, out float z, out float w)
	{
	}
}
