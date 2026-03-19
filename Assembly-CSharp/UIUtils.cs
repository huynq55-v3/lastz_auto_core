using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000181 RID: 385
[Token(Token = "0x2000181")]
public static class UIUtils
{
	// Token: 0x06000AFC RID: 2812 RVA: 0x00005628 File Offset: 0x00003828
	[Token(Token = "0x6000AFC")]
	[Address(RVA = "0x3722CEC", Offset = "0x3722CEC", VA = "0x3722CEC")]
	public static float GetSpecialScreenWidth()
	{
		return 0f;
	}

	// Token: 0x06000AFD RID: 2813 RVA: 0x00005640 File Offset: 0x00003840
	[Token(Token = "0x6000AFD")]
	[Address(RVA = "0x3722DD8", Offset = "0x3722DD8", VA = "0x3722DD8")]
	public static bool IsPhone()
	{
		return default(bool);
	}

	// Token: 0x06000AFE RID: 2814 RVA: 0x00005658 File Offset: 0x00003858
	[Token(Token = "0x6000AFE")]
	[Address(RVA = "0x3722E10", Offset = "0x3722E10", VA = "0x3722E10")]
	public static bool CheckGuiRaycastObjects()
	{
		return default(bool);
	}

	// Token: 0x06000AFF RID: 2815 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AFF")]
	[Address(RVA = "0x372301C", Offset = "0x372301C", VA = "0x372301C")]
	public static void ShowMessage(string message, int buttonCount = 1, string confirmText = "110006", string cancelText = "110106", [Optional] Action confirmAction, [Optional] Action cancelAction, bool isChangeImg = false)
	{
	}

	// Token: 0x06000B00 RID: 2816 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B00")]
	[Address(RVA = "0x3723104", Offset = "0x3723104", VA = "0x3723104")]
	public static void ShowMessages(string message, int buttonCount, string cancelText, string confirmText, [Optional] Action confirmAction, [Optional] Action cancelAction, bool isChangeImg = true)
	{
	}

	// Token: 0x06000B01 RID: 2817 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B01")]
	[Address(RVA = "0x37231EC", Offset = "0x37231EC", VA = "0x37231EC")]
	public static void ShowMessage(string message, Action confirmAction, [Optional] Action cancelAction, bool isChangeImg = false)
	{
	}

	// Token: 0x06000B02 RID: 2818 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B02")]
	[Address(RVA = "0x37232E8", Offset = "0x37232E8", VA = "0x37232E8")]
	public static void NewShowMessage(string message, Action confirmAction, [Optional] Action cancelAction, bool isChangeImg = false)
	{
	}

	// Token: 0x06000B03 RID: 2819 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B03")]
	[Address(RVA = "0x37233E4", Offset = "0x37233E4", VA = "0x37233E4")]
	public static void ShowReloadMessage(string message, Action confirmAction, Action cancelAction, string rTxt = "", float countTime = 0f)
	{
	}

	// Token: 0x06000B04 RID: 2820 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B04")]
	[Address(RVA = "0x37234C0", Offset = "0x37234C0", VA = "0x37234C0")]
	public static void ShowTips(string msgKey, float closeTime = 3f, params object[] args)
	{
	}

	// Token: 0x06000B05 RID: 2821 RVA: 0x00005670 File Offset: 0x00003870
	[Token(Token = "0x6000B05")]
	[Address(RVA = "0x372382C", Offset = "0x372382C", VA = "0x372382C")]
	public static Vector2 ScreenPointToLocalPointInRectangle(Transform transform, Vector2 screenPos)
	{
		return default(Vector2);
	}

	// Token: 0x06000B06 RID: 2822 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B06")]
	[Address(RVA = "0x372395C", Offset = "0x372395C", VA = "0x372395C")]
	public static Transform GetFirstChild(Transform parent, string name)
	{
		return null;
	}

	// Token: 0x06000B07 RID: 2823 RVA: 0x00005688 File Offset: 0x00003888
	[Token(Token = "0x6000B07")]
	[Address(RVA = "0x3723A7C", Offset = "0x3723A7C", VA = "0x3723A7C")]
	public static float PlayAnimationReturnTime(SimpleAnimation anim, string animName)
	{
		return 0f;
	}

	// Token: 0x06000B08 RID: 2824 RVA: 0x000056A0 File Offset: 0x000038A0
	[Token(Token = "0x6000B08")]
	[Address(RVA = "0x3723B70", Offset = "0x3723B70", VA = "0x3723B70")]
	public static float PlayAnimationReturnTime(Animator anim, string animName)
	{
		return 0f;
	}

	// Token: 0x06000B09 RID: 2825 RVA: 0x000056B8 File Offset: 0x000038B8
	[Token(Token = "0x6000B09")]
	[Address(RVA = "0x3723C50", Offset = "0x3723C50", VA = "0x3723C50")]
	public static float PlayAnimationReturnTime(GPUSkinningAnimator anim, string animName)
	{
		return 0f;
	}

	// Token: 0x06000B0A RID: 2826 RVA: 0x000056D0 File Offset: 0x000038D0
	[Token(Token = "0x6000B0A")]
	[Address(RVA = "0x3723C90", Offset = "0x3723C90", VA = "0x3723C90")]
	public static Vector2Int GetCurScreenMaxRadiusSize()
	{
		return default(Vector2Int);
	}

	// Token: 0x040007D5 RID: 2005
	[Token(Token = "0x40007D5")]
	[FieldOffset(Offset = "0x0")]
	public static float tmpWidth;
}
