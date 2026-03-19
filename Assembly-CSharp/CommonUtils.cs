using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.Networking;
using UnityEngine.Rendering.Universal;
using VEngine;
using XLua;

// Token: 0x0200015C RID: 348
[Token(Token = "0x200015C")]
[Hotfix(HotfixFlag.Stateless)]
public class CommonUtils
{
	// Token: 0x060009FF RID: 2559 RVA: 0x00005118 File Offset: 0x00003318
	[Token(Token = "0x60009FF")]
	[Address(RVA = "0x33B8A40", Offset = "0x33B8A40", VA = "0x33B8A40")]
	public static int GetUnityMode()
	{
		return 0;
	}

	// Token: 0x06000A00 RID: 2560 RVA: 0x00005130 File Offset: 0x00003330
	[Token(Token = "0x6000A00")]
	public static bool Is<T>(object o)
	{
		return default(bool);
	}

	// Token: 0x06000A01 RID: 2561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A01")]
	[Address(RVA = "0x33B8A48", Offset = "0x33B8A48", VA = "0x33B8A48")]
	public static void OpenURL(string url)
	{
	}

	// Token: 0x06000A02 RID: 2562 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A02")]
	[Address(RVA = "0x33B8AA4", Offset = "0x33B8AA4", VA = "0x33B8AA4")]
	public static void OpenAppReview(string url)
	{
	}

	// Token: 0x06000A03 RID: 2563 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A03")]
	[Address(RVA = "0x33B8B00", Offset = "0x33B8B00", VA = "0x33B8B00")]
	public static string GetWindowsGameVer()
	{
		return null;
	}

	// Token: 0x06000A04 RID: 2564 RVA: 0x00005148 File Offset: 0x00003348
	[Token(Token = "0x6000A04")]
	[Address(RVA = "0x33B23B8", Offset = "0x33B23B8", VA = "0x33B23B8")]
	public static bool IsDebug()
	{
		return default(bool);
	}

	// Token: 0x06000A05 RID: 2565 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A05")]
	[Address(RVA = "0x33B8DBC", Offset = "0x33B8DBC", VA = "0x33B8DBC")]
	public static UnityWebRequest PostJson(string url, string jsonBody)
	{
		return null;
	}

	// Token: 0x06000A06 RID: 2566 RVA: 0x00005160 File Offset: 0x00003360
	[Token(Token = "0x6000A06")]
	[Address(RVA = "0x33B8F24", Offset = "0x33B8F24", VA = "0x33B8F24")]
	public static bool IsEditor()
	{
		return default(bool);
	}

	// Token: 0x06000A07 RID: 2567 RVA: 0x00005178 File Offset: 0x00003378
	[Token(Token = "0x6000A07")]
	[Address(RVA = "0x33B8F2C", Offset = "0x33B8F2C", VA = "0x33B8F2C")]
	public static bool IsWriteLog()
	{
		return default(bool);
	}

	// Token: 0x06000A08 RID: 2568 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A08")]
	[Address(RVA = "0x33B8FBC", Offset = "0x33B8FBC", VA = "0x33B8FBC")]
	public static string GenerateUUID()
	{
		return null;
	}

	// Token: 0x06000A09 RID: 2569 RVA: 0x00005190 File Offset: 0x00003390
	[Token(Token = "0x6000A09")]
	[Address(RVA = "0x33B8FE8", Offset = "0x33B8FE8", VA = "0x33B8FE8")]
	public long GetCurrentTime()
	{
		return 0L;
	}

	// Token: 0x06000A0A RID: 2570 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A0A")]
	[Address(RVA = "0x33B9058", Offset = "0x33B9058", VA = "0x33B9058")]
	public static void ToggleBlendDepth(bool b)
	{
	}

	// Token: 0x06000A0B RID: 2571 RVA: 0x000051A8 File Offset: 0x000033A8
	[Token(Token = "0x6000A0B")]
	[Address(RVA = "0x33B946C", Offset = "0x33B946C", VA = "0x33B946C")]
	public static bool FindPathByNavMesh(NavMeshPath navMeshPath, Vector3 startPos, Vector3 dstPos, float sampleDistance = 6f)
	{
		return default(bool);
	}

	// Token: 0x06000A0C RID: 2572 RVA: 0x000051C0 File Offset: 0x000033C0
	[Token(Token = "0x6000A0C")]
	[Address(RVA = "0x33B9554", Offset = "0x33B9554", VA = "0x33B9554")]
	public static bool CheckIsOverridePackage()
	{
		return default(bool);
	}

	// Token: 0x06000A0D RID: 2573 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A0D")]
	[Address(RVA = "0x33B9650", Offset = "0x33B9650", VA = "0x33B9650")]
	public static void DeleteCache()
	{
	}

	// Token: 0x06000A0E RID: 2574 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A0E")]
	[Address(RVA = "0x33B9888", Offset = "0x33B9888", VA = "0x33B9888")]
	public static void WriteVersion()
	{
	}

	// Token: 0x06000A0F RID: 2575 RVA: 0x000051D8 File Offset: 0x000033D8
	[Token(Token = "0x6000A0F")]
	[Address(RVA = "0x33B9954", Offset = "0x33B9954", VA = "0x33B9954")]
	public static bool IS_FINAL_RELEASE()
	{
		return default(bool);
	}

	// Token: 0x06000A10 RID: 2576 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A10")]
	[Address(RVA = "0x33B995C", Offset = "0x33B995C", VA = "0x33B995C")]
	public static void Execute_beginDrag(GameObject obj, BaseEventData eventData)
	{
	}

	// Token: 0x06000A11 RID: 2577 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A11")]
	[Address(RVA = "0x33B9A14", Offset = "0x33B9A14", VA = "0x33B9A14")]
	public static void Execute_drag(GameObject obj, BaseEventData eventData)
	{
	}

	// Token: 0x06000A12 RID: 2578 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A12")]
	[Address(RVA = "0x33B9ACC", Offset = "0x33B9ACC", VA = "0x33B9ACC")]
	public static void Execute_endDrag(GameObject obj, BaseEventData eventData)
	{
	}

	// Token: 0x06000A13 RID: 2579 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A13")]
	[Address(RVA = "0x33B9B84", Offset = "0x33B9B84", VA = "0x33B9B84")]
	public static void BeginSample(int id)
	{
	}

	// Token: 0x06000A14 RID: 2580 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A14")]
	[Address(RVA = "0x33B9BDC", Offset = "0x33B9BDC", VA = "0x33B9BDC")]
	public static void EndSample()
	{
	}

	// Token: 0x06000A15 RID: 2581 RVA: 0x000051F0 File Offset: 0x000033F0
	[Token(Token = "0x6000A15")]
	[Address(RVA = "0x33B9BE0", Offset = "0x33B9BE0", VA = "0x33B9BE0")]
	public static long TextAssetRequestSaveToFile(Asset request, string filepath)
	{
		return 0L;
	}

	// Token: 0x06000A16 RID: 2582 RVA: 0x00005208 File Offset: 0x00003408
	[Token(Token = "0x6000A16")]
	[Address(RVA = "0x33B9E58", Offset = "0x33B9E58", VA = "0x33B9E58")]
	public static int GetButtonSoundEffect(GameObject obj)
	{
		return 0;
	}

	// Token: 0x06000A17 RID: 2583 RVA: 0x00005220 File Offset: 0x00003420
	[Token(Token = "0x6000A17")]
	[Address(RVA = "0x33B9EFC", Offset = "0x33B9EFC", VA = "0x33B9EFC")]
	public static int ClearTouchObjectEventTrigger(GameObject gameObject)
	{
		return 0;
	}

	// Token: 0x06000A18 RID: 2584 RVA: 0x00005238 File Offset: 0x00003438
	[Token(Token = "0x6000A18")]
	[Address(RVA = "0x33BA01C", Offset = "0x33BA01C", VA = "0x33BA01C")]
	public static int ClearTouchObjectEventTrigger(Transform tf)
	{
		return 0;
	}

	// Token: 0x06000A19 RID: 2585 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A19")]
	[Address(RVA = "0x33BA038", Offset = "0x33BA038", VA = "0x33BA038")]
	public static void LogErrorWithPost(string str)
	{
	}

	// Token: 0x06000A1A RID: 2586 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A1A")]
	[Address(RVA = "0x33BA0A0", Offset = "0x33BA0A0", VA = "0x33BA0A0")]
	public static byte[] UnCompress(byte[] buffer, int dataLength, int realDataLength)
	{
		return null;
	}

	// Token: 0x06000A1B RID: 2587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A1B")]
	[Address(RVA = "0x33BA1B4", Offset = "0x33BA1B4", VA = "0x33BA1B4")]
	public CommonUtils()
	{
	}

	// Token: 0x04000766 RID: 1894
	[Token(Token = "0x4000766")]
	[FieldOffset(Offset = "0x0")]
	private static ScriptableRendererData _scriptableRendererData;
}
