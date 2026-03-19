using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000A7 RID: 167
[Token(Token = "0x20000A7")]
public class UIGoodsFly : MonoBehaviour
{
	// Token: 0x060003E8 RID: 1000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x2F675D8", Offset = "0x2F675D8", VA = "0x2F675D8")]
	private void Awake()
	{
	}

	// Token: 0x060003E9 RID: 1001 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x2F675DC", Offset = "0x2F675DC", VA = "0x2F675DC")]
	private void OnEnable()
	{
	}

	// Token: 0x060003EA RID: 1002 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003EA")]
	[Address(RVA = "0x2F675E0", Offset = "0x2F675E0", VA = "0x2F675E0")]
	private void OnDisable()
	{
	}

	// Token: 0x060003EB RID: 1003 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x2F675E4", Offset = "0x2F675E4", VA = "0x2F675E4")]
	private void ClearTrailRenderPoint()
	{
	}

	// Token: 0x060003EC RID: 1004 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x2F67790", Offset = "0x2F67790", VA = "0x2F67790")]
	private void Update()
	{
	}

	// Token: 0x060003ED RID: 1005 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x2F67858", Offset = "0x2F67858", VA = "0x2F67858")]
	public void DoAnimForLua(float minRange, float maxRange, int rewardType, string pic, int num, Vector3 destPos, Action onComplete)
	{
	}

	// Token: 0x060003EE RID: 1006 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x2F6785C", Offset = "0x2F6785C", VA = "0x2F6785C")]
	public void DoAnim(float minRange, float maxRange, int rewardType, string pic, int num, Vector3 destPos, Action onComplete)
	{
	}

	// Token: 0x060003EF RID: 1007 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x2F681FC", Offset = "0x2F681FC", VA = "0x2F681FC")]
	public void DoAnimBox(float minRange, float maxRange, Vector3 startPos, Vector3 destPos, Action onComplete)
	{
	}

	// Token: 0x060003F0 RID: 1008 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x2F68628", Offset = "0x2F68628", VA = "0x2F68628")]
	public void DoAnim(float minRange, float maxRange, Vector3 destPos, Vector3 startPos, Action onComplete)
	{
	}

	// Token: 0x060003F1 RID: 1009 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x2F689F4", Offset = "0x2F689F4", VA = "0x2F689F4")]
	private IEnumerator DelayComplete(Action onComplete)
	{
		return null;
	}

	// Token: 0x060003F2 RID: 1010 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x2F679A8", Offset = "0x2F679A8", VA = "0x2F679A8")]
	public void DoAnim(float minRange, float maxRange, int rewardType, string pic, Vector3 destPos, Action onComplete)
	{
	}

	// Token: 0x060003F3 RID: 1011 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x2F684D8", Offset = "0x2F684D8", VA = "0x2F684D8")]
	private Vector3[] Bezier2Path(Vector3 startPos, Vector3 controlPos, Vector3 endPos)
	{
		return null;
	}

	// Token: 0x060003F4 RID: 1012 RVA: 0x000033A8 File Offset: 0x000015A8
	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x2F68B14", Offset = "0x2F68B14", VA = "0x2F68B14")]
	public static Vector3 Bezier2(Vector3 startPos, Vector3 controlPos, Vector3 endPos, float t)
	{
		return default(Vector3);
	}

	// Token: 0x060003F5 RID: 1013 RVA: 0x000033C0 File Offset: 0x000015C0
	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x2F68B78", Offset = "0x2F68B78", VA = "0x2F68B78")]
	public static Vector3 Bezier3(Vector3 startPos, Vector3 controlPos1, Vector3 controlPos2, Vector3 endPos, float t)
	{
		return default(Vector3);
	}

	// Token: 0x060003F6 RID: 1014 RVA: 0x000033D8 File Offset: 0x000015D8
	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x2F68AB4", Offset = "0x2F68AB4", VA = "0x2F68AB4")]
	private Vector3 CalculateCubicBezierPointfor2C(float t, Vector3 p0, Vector3 p1, Vector3 p2)
	{
		return default(Vector3);
	}

	// Token: 0x060003F7 RID: 1015 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x2F68C14", Offset = "0x2F68C14", VA = "0x2F68C14")]
	public UIGoodsFly()
	{
	}

	// Token: 0x0400037C RID: 892
	[Token(Token = "0x400037C")]
	[FieldOffset(Offset = "0x18")]
	public bool isRun;

	// Token: 0x0400037D RID: 893
	[Token(Token = "0x400037D")]
	[FieldOffset(Offset = "0x1C")]
	public Vector3 targetPos;

	// Token: 0x0400037E RID: 894
	[Token(Token = "0x400037E")]
	[FieldOffset(Offset = "0x28")]
	public float minSize;

	// Token: 0x0400037F RID: 895
	[Token(Token = "0x400037F")]
	[FieldOffset(Offset = "0x2C")]
	public float maxSize;

	// Token: 0x04000380 RID: 896
	[Token(Token = "0x4000380")]
	[FieldOffset(Offset = "0x30")]
	public bool isReset;

	// Token: 0x04000381 RID: 897
	[Token(Token = "0x4000381")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 oldPos;

	// Token: 0x04000382 RID: 898
	[Token(Token = "0x4000382")]
	[FieldOffset(Offset = "0x40")]
	public Vector3 customPosOffset;

	// Token: 0x04000383 RID: 899
	[Token(Token = "0x4000383")]
	[FieldOffset(Offset = "0x4C")]
	public float moveTime;

	// Token: 0x04000384 RID: 900
	[Token(Token = "0x4000384")]
	[FieldOffset(Offset = "0x0")]
	private static float _pointCount;

	// Token: 0x04000385 RID: 901
	[Token(Token = "0x4000385")]
	[FieldOffset(Offset = "0x4")]
	private static int SEGMENT_COUNT;

	// Token: 0x04000386 RID: 902
	[Token(Token = "0x4000386")]
	[FieldOffset(Offset = "0x50")]
	public AnimationCurve firstCurve;

	// Token: 0x04000387 RID: 903
	[Token(Token = "0x4000387")]
	[FieldOffset(Offset = "0x58")]
	public AnimationCurve secondCurve;

	// Token: 0x04000388 RID: 904
	[Token(Token = "0x4000388")]
	[FieldOffset(Offset = "0x60")]
	public AnimationCurve thirdCurve;

	// Token: 0x04000389 RID: 905
	[Token(Token = "0x4000389")]
	[FieldOffset(Offset = "0x68")]
	public Vector3 controlPointOffset;

	// Token: 0x0400038A RID: 906
	[Token(Token = "0x400038A")]
	[FieldOffset(Offset = "0x74")]
	private int SearchFlyType;

	// Token: 0x0400038B RID: 907
	[Token(Token = "0x400038B")]
	[FieldOffset(Offset = "0x78")]
	public bool isDisableRangeStartPos;

	// Token: 0x0400038C RID: 908
	[Token(Token = "0x400038C")]
	[FieldOffset(Offset = "0x7C")]
	public float doMoveTime;

	// Token: 0x0400038D RID: 909
	[Token(Token = "0x400038D")]
	private const string diamondsPath = "Assets/Main/Sprites/UI/Common/Common_icon_gold.png";

	// Token: 0x0400038E RID: 910
	[Token(Token = "0x400038E")]
	private const string coinPath = "Assets/Main/Sprites/UI/Common/Common_icon_money.png";

	// Token: 0x0400038F RID: 911
	[Token(Token = "0x400038F")]
	private const string waterPath = "Assets/Main/Sprites/UI/Common/Common_icon_water.png";

	// Token: 0x04000390 RID: 912
	[Token(Token = "0x4000390")]
	private const string electricityPath = "Assets/Main/Sprites/UI/Common/Common_icon_electricity.png";

	// Token: 0x04000391 RID: 913
	[Token(Token = "0x4000391")]
	private const string metalPath = "Assets/Main/Sprites/UI/Common/Common_icon_metal.png";

	// Token: 0x04000392 RID: 914
	[Token(Token = "0x4000392")]
	private const string gasPath = "Assets/Main/Sprites/UI/Common/Common_icon_gas.png";

	// Token: 0x04000393 RID: 915
	[Token(Token = "0x4000393")]
	private const string coinRootPath = "UIResource/UIMain/safeArea/topLayer/ResourceBar/{0}/root/resourceIcon";

	// Token: 0x04000394 RID: 916
	[Token(Token = "0x4000394")]
	private const string goldRootPath = "UIResource/UIMain/safeArea/topLayer/ResourceBar/goldObj/goldIcon";

	// Token: 0x04000395 RID: 917
	[Token(Token = "0x4000395")]
	private const string resourceRootPath = "UIResource/UIMain/safeArea/showObj/GoodsIcon";

	// Token: 0x04000396 RID: 918
	[Token(Token = "0x4000396")]
	private const string powerRootPath = "UIResource/UIMain/safeArea/showObj/PowerIcon";

	// Token: 0x04000397 RID: 919
	[Token(Token = "0x4000397")]
	private const string energyRootPath = "UIResource/UIMain/safeArea/topLayer/ResourceBar/UIEnergySlider/Icon";

	// Token: 0x04000398 RID: 920
	[Token(Token = "0x4000398")]
	private const string searchPath = "UIResource/UIMain/safeArea/leftLayer/playerObj/SearchBtn/SearchIcon";

	// Token: 0x04000399 RID: 921
	[Token(Token = "0x4000399")]
	[FieldOffset(Offset = "0x80")]
	public Image img;

	// Token: 0x0400039A RID: 922
	[Token(Token = "0x400039A")]
	[FieldOffset(Offset = "0x88")]
	public Text txt;

	// Token: 0x0400039B RID: 923
	[Token(Token = "0x400039B")]
	[FieldOffset(Offset = "0x90")]
	private Transform targetRoot;

	// Token: 0x0400039C RID: 924
	[Token(Token = "0x400039C")]
	[FieldOffset(Offset = "0x8")]
	private static List<TrailRenderer> _listTrail;

	// Token: 0x0400039D RID: 925
	[Token(Token = "0x400039D")]
	[FieldOffset(Offset = "0x10")]
	private static Vector3[] _paths;

	// Token: 0x0400039E RID: 926
	[Token(Token = "0x400039E")]
	[FieldOffset(Offset = "0x98")]
	private WaitForSeconds tt1;

	// Token: 0x0400039F RID: 927
	[Token(Token = "0x400039F")]
	[FieldOffset(Offset = "0xA0")]
	public float middleValue;
}
