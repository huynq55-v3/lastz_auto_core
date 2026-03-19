using System;
using BitBenderGames;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200026F RID: 623
[Token(Token = "0x200026F")]
public class CameraRoundControl : MonoBehaviour
{
	// Token: 0x06001078 RID: 4216 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001078")]
	[Address(RVA = "0x1BEE6E8", Offset = "0x1BEE6E8", VA = "0x1BEE6E8")]
	private void Start()
	{
	}

	// Token: 0x06001079 RID: 4217 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001079")]
	[Address(RVA = "0x1BEEB00", Offset = "0x1BEEB00", VA = "0x1BEEB00")]
	public void SetTargetTransform(Transform tran)
	{
	}

	// Token: 0x0600107A RID: 4218 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600107A")]
	[Address(RVA = "0x1BEEBE4", Offset = "0x1BEEBE4", VA = "0x1BEEBE4")]
	public void SetTargetPosition(float x, float y, float z)
	{
	}

	// Token: 0x0600107B RID: 4219 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600107B")]
	[Address(RVA = "0x1BEECA8", Offset = "0x1BEECA8", VA = "0x1BEECA8")]
	private void OnFingerDown(Vector3 pos)
	{
	}

	// Token: 0x0600107C RID: 4220 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600107C")]
	[Address(RVA = "0x1BEECEC", Offset = "0x1BEECEC", VA = "0x1BEECEC")]
	private void OnDragStart(Vector3 dragPosStart, bool isLongTap)
	{
	}

	// Token: 0x0600107D RID: 4221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600107D")]
	[Address(RVA = "0x1BEED68", Offset = "0x1BEED68", VA = "0x1BEED68")]
	private void OnDragUpdate(Vector3 dragPosStart, Vector3 dragPosCurrent, Vector3 correctionOffset)
	{
	}

	// Token: 0x0600107E RID: 4222 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600107E")]
	[Address(RVA = "0x1BEEE20", Offset = "0x1BEEE20", VA = "0x1BEEE20")]
	private void OnDragStop(Vector3 dragStopPos, Vector3 dragFinalMomentum)
	{
	}

	// Token: 0x0600107F RID: 4223 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600107F")]
	[Address(RVA = "0x1BEEE28", Offset = "0x1BEEE28", VA = "0x1BEEE28")]
	public void OnPinchStart(Vector3 pinchCenter, float pinchDistance)
	{
	}

	// Token: 0x06001080 RID: 4224 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001080")]
	[Address(RVA = "0x1BEEEB4", Offset = "0x1BEEEB4", VA = "0x1BEEEB4")]
	private void OnPinchUpdate(PinchUpdateData pinchUpdateData)
	{
	}

	// Token: 0x06001081 RID: 4225 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001081")]
	[Address(RVA = "0x1BEEF18", Offset = "0x1BEEF18", VA = "0x1BEEF18")]
	private void OnPinchStop()
	{
	}

	// Token: 0x06001082 RID: 4226 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001082")]
	[Address(RVA = "0x1BEEF20", Offset = "0x1BEEF20", VA = "0x1BEEF20")]
	private void OnEnable()
	{
	}

	// Token: 0x06001083 RID: 4227 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001083")]
	[Address(RVA = "0x1BEF0AC", Offset = "0x1BEF0AC", VA = "0x1BEF0AC")]
	private void LateUpdate()
	{
	}

	// Token: 0x06001084 RID: 4228 RVA: 0x00006DE0 File Offset: 0x00004FE0
	[Token(Token = "0x6001084")]
	[Address(RVA = "0x1BEEA84", Offset = "0x1BEEA84", VA = "0x1BEEA84")]
	private static float ClampAngle(float angle, float min, float max)
	{
		return 0f;
	}

	// Token: 0x06001085 RID: 4229 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001085")]
	[Address(RVA = "0x1BEF270", Offset = "0x1BEF270", VA = "0x1BEF270")]
	private void DestroyTouchCamera()
	{
	}

	// Token: 0x06001086 RID: 4230 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001086")]
	[Address(RVA = "0x1BEF608", Offset = "0x1BEF608", VA = "0x1BEF608")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001087 RID: 4231 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001087")]
	[Address(RVA = "0x1BEF628", Offset = "0x1BEF628", VA = "0x1BEF628")]
	public CameraRoundControl()
	{
	}

	// Token: 0x0400132E RID: 4910
	[Token(Token = "0x400132E")]
	[FieldOffset(Offset = "0x18")]
	public float xSpeed;

	// Token: 0x0400132F RID: 4911
	[Token(Token = "0x400132F")]
	[FieldOffset(Offset = "0x1C")]
	public float ySpeed;

	// Token: 0x04001330 RID: 4912
	[Token(Token = "0x4001330")]
	[FieldOffset(Offset = "0x20")]
	public float mSpeed;

	// Token: 0x04001331 RID: 4913
	[Token(Token = "0x4001331")]
	[FieldOffset(Offset = "0x24")]
	public float xMinLimit;

	// Token: 0x04001332 RID: 4914
	[Token(Token = "0x4001332")]
	[FieldOffset(Offset = "0x28")]
	public float xMaxLimit;

	// Token: 0x04001333 RID: 4915
	[Token(Token = "0x4001333")]
	[FieldOffset(Offset = "0x2C")]
	public float yMinLimit;

	// Token: 0x04001334 RID: 4916
	[Token(Token = "0x4001334")]
	[FieldOffset(Offset = "0x30")]
	public float yMaxLimit;

	// Token: 0x04001335 RID: 4917
	[Token(Token = "0x4001335")]
	[FieldOffset(Offset = "0x34")]
	public float distance;

	// Token: 0x04001336 RID: 4918
	[Token(Token = "0x4001336")]
	[FieldOffset(Offset = "0x38")]
	public float minDistance;

	// Token: 0x04001337 RID: 4919
	[Token(Token = "0x4001337")]
	[FieldOffset(Offset = "0x3C")]
	public float maxDistance;

	// Token: 0x04001338 RID: 4920
	[Token(Token = "0x4001338")]
	[FieldOffset(Offset = "0x40")]
	public float damping;

	// Token: 0x04001339 RID: 4921
	[Token(Token = "0x4001339")]
	[FieldOffset(Offset = "0x44")]
	public float x;

	// Token: 0x0400133A RID: 4922
	[Token(Token = "0x400133A")]
	[FieldOffset(Offset = "0x48")]
	public float y;

	// Token: 0x0400133B RID: 4923
	[Token(Token = "0x400133B")]
	[FieldOffset(Offset = "0x50")]
	private Transform _targetTransform;

	// Token: 0x0400133C RID: 4924
	[Token(Token = "0x400133C")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 _targetPos;

	// Token: 0x0400133D RID: 4925
	[Token(Token = "0x400133D")]
	[FieldOffset(Offset = "0x68")]
	private MobileTouchCamera _touchCamera;

	// Token: 0x0400133E RID: 4926
	[Token(Token = "0x400133E")]
	[FieldOffset(Offset = "0x70")]
	private bool _canDrag;

	// Token: 0x0400133F RID: 4927
	[Token(Token = "0x400133F")]
	[FieldOffset(Offset = "0x71")]
	private bool _canPinch;

	// Token: 0x04001340 RID: 4928
	[Token(Token = "0x4001340")]
	[FieldOffset(Offset = "0x74")]
	private Vector3 _dragPosStart;

	// Token: 0x04001341 RID: 4929
	[Token(Token = "0x4001341")]
	[FieldOffset(Offset = "0x80")]
	private float _pinchDistanceLast;

	// Token: 0x04001342 RID: 4930
	[Token(Token = "0x4001342")]
	[FieldOffset(Offset = "0x84")]
	private float _pinchDistanceCurrent;
}
