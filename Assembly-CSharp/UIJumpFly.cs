using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000AC RID: 172
[Token(Token = "0x20000AC")]
public class UIJumpFly : MonoBehaviour
{
	// Token: 0x06000405 RID: 1029 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000405")]
	[Address(RVA = "0x2F68FE0", Offset = "0x2F68FE0", VA = "0x2F68FE0")]
	private void Awake()
	{
	}

	// Token: 0x06000406 RID: 1030 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000406")]
	[Address(RVA = "0x2F69038", Offset = "0x2F69038", VA = "0x2F69038")]
	private Vector3[] Bezier2Path(Vector3 startPos, Vector3 controlPos, Vector3 endPos)
	{
		return null;
	}

	// Token: 0x06000407 RID: 1031 RVA: 0x00003408 File Offset: 0x00001608
	[Token(Token = "0x6000407")]
	[Address(RVA = "0x2F6917C", Offset = "0x2F6917C", VA = "0x2F6917C")]
	private Vector3 CalculateCubicBezierPointfor2C(float t, Vector3 p0, Vector3 p1, Vector3 p2)
	{
		return default(Vector3);
	}

	// Token: 0x06000408 RID: 1032 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000408")]
	[Address(RVA = "0x2F691DC", Offset = "0x2F691DC", VA = "0x2F691DC")]
	public void DoJump()
	{
	}

	// Token: 0x06000409 RID: 1033 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000409")]
	[Address(RVA = "0x2F69420", Offset = "0x2F69420", VA = "0x2F69420")]
	public void DoFly(Vector3 targetPos, [Optional] Action onComplete, bool isLeft = false)
	{
	}

	// Token: 0x0600040A RID: 1034 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040A")]
	[Address(RVA = "0x2F694D4", Offset = "0x2F694D4", VA = "0x2F694D4")]
	public void DoFlyNew(Vector3 targetPos, [Optional] Action onComplete, bool isLeft = false, double delayTime = 0.0)
	{
	}

	// Token: 0x0600040B RID: 1035 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040B")]
	[Address(RVA = "0x2F69590", Offset = "0x2F69590", VA = "0x2F69590")]
	private void OnDisable()
	{
	}

	// Token: 0x0600040C RID: 1036 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040C")]
	[Address(RVA = "0x2F695BC", Offset = "0x2F695BC", VA = "0x2F695BC")]
	private void OnEnable()
	{
	}

	// Token: 0x0600040D RID: 1037 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040D")]
	[Address(RVA = "0x2F695E8", Offset = "0x2F695E8", VA = "0x2F695E8")]
	private void Update()
	{
	}

	// Token: 0x0600040E RID: 1038 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040E")]
	[Address(RVA = "0x2F6964C", Offset = "0x2F6964C", VA = "0x2F6964C")]
	public UIJumpFly()
	{
	}

	// Token: 0x040003A8 RID: 936
	[Token(Token = "0x40003A8")]
	[FieldOffset(Offset = "0x18")]
	private Animator anim;

	// Token: 0x040003A9 RID: 937
	[Token(Token = "0x40003A9")]
	[FieldOffset(Offset = "0x0")]
	private static int SEGMENT_COUNT;

	// Token: 0x040003AA RID: 938
	[Token(Token = "0x40003AA")]
	[FieldOffset(Offset = "0x20")]
	private Vector3[] _paths;

	// Token: 0x040003AB RID: 939
	[Token(Token = "0x40003AB")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve firstCurve;

	// Token: 0x040003AC RID: 940
	[Token(Token = "0x40003AC")]
	[FieldOffset(Offset = "0x30")]
	public bool isRun;

	// Token: 0x040003AD RID: 941
	[Token(Token = "0x40003AD")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 controlPointOffset;

	// Token: 0x040003AE RID: 942
	[Token(Token = "0x40003AE")]
	[FieldOffset(Offset = "0x40")]
	public float middlePos;

	// Token: 0x040003AF RID: 943
	[Token(Token = "0x40003AF")]
	[FieldOffset(Offset = "0x44")]
	public float moveTime;

	// Token: 0x040003B0 RID: 944
	[Token(Token = "0x40003B0")]
	[FieldOffset(Offset = "0x48")]
	public Vector3 targetPos;

	// Token: 0x040003B1 RID: 945
	[Token(Token = "0x40003B1")]
	[FieldOffset(Offset = "0x54")]
	private bool isFinish;

	// Token: 0x040003B2 RID: 946
	[Token(Token = "0x40003B2")]
	[FieldOffset(Offset = "0x58")]
	private double delayTime;

	// Token: 0x040003B3 RID: 947
	[Token(Token = "0x40003B3")]
	[FieldOffset(Offset = "0x60")]
	private Action onComplete;
}
