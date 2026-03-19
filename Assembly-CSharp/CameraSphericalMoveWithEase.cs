using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200006A RID: 106
[Token(Token = "0x200006A")]
public class CameraSphericalMoveWithEase : MonoBehaviour
{
	// Token: 0x060002A7 RID: 679 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x3208CE8", Offset = "0x3208CE8", VA = "0x3208CE8")]
	private void OnGUI()
	{
	}

	// Token: 0x060002A8 RID: 680 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x3208FE4", Offset = "0x3208FE4", VA = "0x3208FE4")]
	public void MoveToFront()
	{
	}

	// Token: 0x060002A9 RID: 681 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x3208FEC", Offset = "0x3208FEC", VA = "0x3208FEC")]
	public void MoveToLF()
	{
	}

	// Token: 0x060002AA RID: 682 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x3208FF4", Offset = "0x3208FF4", VA = "0x3208FF4")]
	public void MoveToLB()
	{
	}

	// Token: 0x060002AB RID: 683 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x3208FFC", Offset = "0x3208FFC", VA = "0x3208FFC")]
	public void MoveToRF()
	{
	}

	// Token: 0x060002AC RID: 684 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x3209004", Offset = "0x3209004", VA = "0x3209004")]
	public void MoveToRB()
	{
	}

	// Token: 0x060002AD RID: 685 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x32091A4", Offset = "0x32091A4", VA = "0x32091A4")]
	public void InitPoint()
	{
	}

	// Token: 0x060002AE RID: 686 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x32093E8", Offset = "0x32093E8", VA = "0x32093E8")]
	private void Start()
	{
	}

	// Token: 0x060002AF RID: 687 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x320900C", Offset = "0x320900C", VA = "0x320900C")]
	public void MoveCameraToPoint(CameraSphericalMoveWithEase.Dir dirPos)
	{
	}

	// Token: 0x060002B0 RID: 688 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x320955C", Offset = "0x320955C", VA = "0x320955C")]
	private void Update()
	{
	}

	// Token: 0x060002B1 RID: 689 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x32094B8", Offset = "0x32094B8", VA = "0x32094B8")]
	private void ConvertToSpherical(Vector3 cartesian, out float theta, out float phi)
	{
	}

	// Token: 0x060002B2 RID: 690 RVA: 0x00002F88 File Offset: 0x00001188
	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x3209780", Offset = "0x3209780", VA = "0x3209780")]
	private Vector3 ConvertToCartesian(float theta, float phi)
	{
		return default(Vector3);
	}

	// Token: 0x060002B3 RID: 691 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x32097D8", Offset = "0x32097D8", VA = "0x32097D8")]
	public CameraSphericalMoveWithEase()
	{
	}

	// Token: 0x0400023C RID: 572
	[Token(Token = "0x400023C")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 centerPos;

	// Token: 0x0400023D RID: 573
	[Token(Token = "0x400023D")]
	[FieldOffset(Offset = "0x24")]
	public float Radius;

	// Token: 0x0400023E RID: 574
	[Token(Token = "0x400023E")]
	[FieldOffset(Offset = "0x28")]
	public float InitRadius;

	// Token: 0x0400023F RID: 575
	[Token(Token = "0x400023F")]
	[FieldOffset(Offset = "0x30")]
	public Transform cameraTransform;

	// Token: 0x04000240 RID: 576
	[Token(Token = "0x4000240")]
	[FieldOffset(Offset = "0x38")]
	public float duration;

	// Token: 0x04000241 RID: 577
	[Token(Token = "0x4000241")]
	[FieldOffset(Offset = "0x3C")]
	public CameraSphericalMoveWithEase.Dir curDir;

	// Token: 0x04000242 RID: 578
	[Token(Token = "0x4000242")]
	[FieldOffset(Offset = "0x40")]
	public Transform targetNode;

	// Token: 0x04000243 RID: 579
	[Token(Token = "0x4000243")]
	[FieldOffset(Offset = "0x48")]
	public List<Vector3> spherePoint;

	// Token: 0x04000244 RID: 580
	[Token(Token = "0x4000244")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 startSlerpPos;

	// Token: 0x04000245 RID: 581
	[Token(Token = "0x4000245")]
	[FieldOffset(Offset = "0x5C")]
	private bool slerpLock;

	// Token: 0x04000246 RID: 582
	[Token(Token = "0x4000246")]
	[FieldOffset(Offset = "0x60")]
	private float m_dt;

	// Token: 0x04000247 RID: 583
	[Token(Token = "0x4000247")]
	[FieldOffset(Offset = "0x64")]
	private Vector3 m_targetPos;

	// Token: 0x04000248 RID: 584
	[Token(Token = "0x4000248")]
	[FieldOffset(Offset = "0x70")]
	private float startTime;

	// Token: 0x04000249 RID: 585
	[Token(Token = "0x4000249")]
	[FieldOffset(Offset = "0x74")]
	private float m_difThetaRad;

	// Token: 0x0400024A RID: 586
	[Token(Token = "0x400024A")]
	[FieldOffset(Offset = "0x78")]
	private float m_startThetaRad;

	// Token: 0x0400024B RID: 587
	[Token(Token = "0x400024B")]
	[FieldOffset(Offset = "0x7C")]
	private float m_difPhiRad;

	// Token: 0x0400024C RID: 588
	[Token(Token = "0x400024C")]
	[FieldOffset(Offset = "0x80")]
	private float m_startPhiRad;

	// Token: 0x0400024D RID: 589
	[Token(Token = "0x400024D")]
	[FieldOffset(Offset = "0x84")]
	private float m_curRadius;

	// Token: 0x0400024E RID: 590
	[Token(Token = "0x400024E")]
	[FieldOffset(Offset = "0x88")]
	private float m_tarRadius;

	// Token: 0x0200006B RID: 107
	[Token(Token = "0x200006B")]
	public enum Dir
	{
		// Token: 0x04000250 RID: 592
		[Token(Token = "0x4000250")]
		Front,
		// Token: 0x04000251 RID: 593
		[Token(Token = "0x4000251")]
		LF,
		// Token: 0x04000252 RID: 594
		[Token(Token = "0x4000252")]
		LB,
		// Token: 0x04000253 RID: 595
		[Token(Token = "0x4000253")]
		RF,
		// Token: 0x04000254 RID: 596
		[Token(Token = "0x4000254")]
		RB,
		// Token: 0x04000255 RID: 597
		[Token(Token = "0x4000255")]
		Init
	}
}
