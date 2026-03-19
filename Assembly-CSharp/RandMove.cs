using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000098 RID: 152
[Token(Token = "0x2000098")]
public class RandMove : MonoBehaviour
{
	// Token: 0x06000396 RID: 918 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000396")]
	[Address(RVA = "0x3215FCC", Offset = "0x3215FCC", VA = "0x3215FCC")]
	public void StartFly(Vector3 startPos, GameObject target, Action onComplete)
	{
	}

	// Token: 0x06000397 RID: 919 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000397")]
	[Address(RVA = "0x3216058", Offset = "0x3216058", VA = "0x3216058")]
	private void Update()
	{
	}

	// Token: 0x06000398 RID: 920 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000398")]
	[Address(RVA = "0x32163C4", Offset = "0x32163C4", VA = "0x32163C4")]
	private Vector3[] Bezier2Path(Vector3 startPos, Vector3 controlPos, Vector3 endPos)
	{
		return null;
	}

	// Token: 0x06000399 RID: 921 RVA: 0x000030D8 File Offset: 0x000012D8
	[Token(Token = "0x6000399")]
	[Address(RVA = "0x3216514", Offset = "0x3216514", VA = "0x3216514")]
	public static Vector3 Bezier2(Vector3 startPos, Vector3 controlPos, Vector3 endPos, float t)
	{
		return default(Vector3);
	}

	// Token: 0x0600039A RID: 922 RVA: 0x000030F0 File Offset: 0x000012F0
	[Token(Token = "0x600039A")]
	[Address(RVA = "0x3216578", Offset = "0x3216578", VA = "0x3216578")]
	public static Vector3 Bezier3(Vector3 startPos, Vector3 controlPos1, Vector3 controlPos2, Vector3 endPos, float t)
	{
		return default(Vector3);
	}

	// Token: 0x0600039B RID: 923 RVA: 0x00003108 File Offset: 0x00001308
	[Token(Token = "0x600039B")]
	[Address(RVA = "0x3216364", Offset = "0x3216364", VA = "0x3216364")]
	private Vector3 CalculateCubicBezierPointfor2C(float t, Vector3 p0, Vector3 p1, Vector3 p2)
	{
		return default(Vector3);
	}

	// Token: 0x0600039C RID: 924 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600039C")]
	[Address(RVA = "0x3216614", Offset = "0x3216614", VA = "0x3216614")]
	public RandMove()
	{
	}

	// Token: 0x0400031A RID: 794
	[Token(Token = "0x400031A")]
	[FieldOffset(Offset = "0x0")]
	private static float _pointCount;

	// Token: 0x0400031B RID: 795
	[Token(Token = "0x400031B")]
	[FieldOffset(Offset = "0x4")]
	private static int SEGMENT_COUNT;

	// Token: 0x0400031C RID: 796
	[Token(Token = "0x400031C")]
	[FieldOffset(Offset = "0x8")]
	private static Vector3[] _paths;

	// Token: 0x0400031D RID: 797
	[Token(Token = "0x400031D")]
	[FieldOffset(Offset = "0x18")]
	public AnimationCurve firstCurve;

	// Token: 0x0400031E RID: 798
	[Token(Token = "0x400031E")]
	[FieldOffset(Offset = "0x20")]
	public AnimationCurve secondCurve;

	// Token: 0x0400031F RID: 799
	[Token(Token = "0x400031F")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 rotDir;

	// Token: 0x04000320 RID: 800
	[Token(Token = "0x4000320")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 startPos;

	// Token: 0x04000321 RID: 801
	[Token(Token = "0x4000321")]
	[FieldOffset(Offset = "0x40")]
	public float upTime;

	// Token: 0x04000322 RID: 802
	[Token(Token = "0x4000322")]
	[FieldOffset(Offset = "0x44")]
	public float rotSpeed;

	// Token: 0x04000323 RID: 803
	[Token(Token = "0x4000323")]
	[FieldOffset(Offset = "0x48")]
	public float moveHight;

	// Token: 0x04000324 RID: 804
	[Token(Token = "0x4000324")]
	[FieldOffset(Offset = "0x4C")]
	private float deltaTime;

	// Token: 0x04000325 RID: 805
	[Token(Token = "0x4000325")]
	[FieldOffset(Offset = "0x50")]
	private float deltaTime1;

	// Token: 0x04000326 RID: 806
	[Token(Token = "0x4000326")]
	[FieldOffset(Offset = "0x58")]
	public GameObject target;

	// Token: 0x04000327 RID: 807
	[Token(Token = "0x4000327")]
	[FieldOffset(Offset = "0x60")]
	public Vector3 controlPointOffset;

	// Token: 0x04000328 RID: 808
	[Token(Token = "0x4000328")]
	[FieldOffset(Offset = "0x6C")]
	public RandMove.FlyState flyState;

	// Token: 0x04000329 RID: 809
	[Token(Token = "0x4000329")]
	[FieldOffset(Offset = "0x70")]
	public float speed;

	// Token: 0x0400032A RID: 810
	[Token(Token = "0x400032A")]
	[FieldOffset(Offset = "0x78")]
	private Action onComplete;

	// Token: 0x0400032B RID: 811
	[Token(Token = "0x400032B")]
	[FieldOffset(Offset = "0x80")]
	public float closeDis;

	// Token: 0x0400032C RID: 812
	[Token(Token = "0x400032C")]
	[FieldOffset(Offset = "0x84")]
	public float middleValue;

	// Token: 0x02000099 RID: 153
	[Token(Token = "0x2000099")]
	public enum FlyState
	{
		// Token: 0x0400032E RID: 814
		[Token(Token = "0x400032E")]
		None,
		// Token: 0x0400032F RID: 815
		[Token(Token = "0x400032F")]
		Up,
		// Token: 0x04000330 RID: 816
		[Token(Token = "0x4000330")]
		Track
	}
}
