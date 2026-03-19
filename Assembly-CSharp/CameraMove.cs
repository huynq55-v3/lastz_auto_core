using System;
using BitBenderGames;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200026D RID: 621
[Token(Token = "0x200026D")]
public class CameraMove : MonoBehaviour
{
	// Token: 0x0600106B RID: 4203 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600106B")]
	[Address(RVA = "0x1BEDE78", Offset = "0x1BEDE78", VA = "0x1BEDE78")]
	private void OnEnable()
	{
	}

	// Token: 0x0600106C RID: 4204 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600106C")]
	[Address(RVA = "0x1BEDED0", Offset = "0x1BEDED0", VA = "0x1BEDED0")]
	private void Update()
	{
	}

	// Token: 0x0600106D RID: 4205 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600106D")]
	[Address(RVA = "0x1BEE43C", Offset = "0x1BEE43C", VA = "0x1BEE43C")]
	public void SetMoveToNpc(Vector3 targetPos, Vector3 npcPos, Action callback1, Action callback2)
	{
	}

	// Token: 0x0600106E RID: 4206 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600106E")]
	[Address(RVA = "0x1BEE0AC", Offset = "0x1BEE0AC", VA = "0x1BEE0AC")]
	private void Update_MoveToNpc()
	{
	}

	// Token: 0x0600106F RID: 4207 RVA: 0x00006D98 File Offset: 0x00004F98
	[Token(Token = "0x600106F")]
	[Address(RVA = "0x1BEDFB4", Offset = "0x1BEDFB4", VA = "0x1BEDFB4")]
	private bool Update_CheckDone_MoveToNpc()
	{
		return default(bool);
	}

	// Token: 0x06001070 RID: 4208 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001070")]
	[Address(RVA = "0x1BEE4DC", Offset = "0x1BEE4DC", VA = "0x1BEE4DC")]
	private void Update_MidCallback2()
	{
	}

	// Token: 0x06001071 RID: 4209 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001071")]
	[Address(RVA = "0x1BEE534", Offset = "0x1BEE534", VA = "0x1BEE534")]
	public void MoveToTarget(float posY, float rotateX, Action callback)
	{
	}

	// Token: 0x06001072 RID: 4210 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001072")]
	[Address(RVA = "0x1BEE65C", Offset = "0x1BEE65C", VA = "0x1BEE65C")]
	public void ResumeFromTargetView(Action callback)
	{
	}

	// Token: 0x06001073 RID: 4211 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001073")]
	[Address(RVA = "0x1BEE1CC", Offset = "0x1BEE1CC", VA = "0x1BEE1CC")]
	private void Update_MoveToTarget()
	{
	}

	// Token: 0x06001074 RID: 4212 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001074")]
	[Address(RVA = "0x1BEE304", Offset = "0x1BEE304", VA = "0x1BEE304")]
	private void Update_ResumeFromTargetView()
	{
	}

	// Token: 0x06001075 RID: 4213 RVA: 0x00006DB0 File Offset: 0x00004FB0
	[Token(Token = "0x6001075")]
	[Address(RVA = "0x1BEE00C", Offset = "0x1BEE00C", VA = "0x1BEE00C")]
	private bool Update_CheckDone_MoveToTarget()
	{
		return default(bool);
	}

	// Token: 0x06001076 RID: 4214 RVA: 0x00006DC8 File Offset: 0x00004FC8
	[Token(Token = "0x6001076")]
	[Address(RVA = "0x1BEE05C", Offset = "0x1BEE05C", VA = "0x1BEE05C")]
	private bool Update_CheckDone_ResumeFromTarget()
	{
		return default(bool);
	}

	// Token: 0x06001077 RID: 4215 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001077")]
	[Address(RVA = "0x1BEE6D4", Offset = "0x1BEE6D4", VA = "0x1BEE6D4")]
	public CameraMove()
	{
	}

	// Token: 0x04001307 RID: 4871
	[Token(Token = "0x4001307")]
	[FieldOffset(Offset = "0x18")]
	private float m_deltaTime;

	// Token: 0x04001308 RID: 4872
	[Token(Token = "0x4001308")]
	[FieldOffset(Offset = "0x1C")]
	private Vector3 m_startPos;

	// Token: 0x04001309 RID: 4873
	[Token(Token = "0x4001309")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 m_endPos;

	// Token: 0x0400130A RID: 4874
	[Token(Token = "0x400130A")]
	[FieldOffset(Offset = "0x34")]
	private bool m_start;

	// Token: 0x0400130B RID: 4875
	[Token(Token = "0x400130B")]
	[FieldOffset(Offset = "0x38")]
	private MobileTouchCamera _mobileTouchCamera;

	// Token: 0x0400130C RID: 4876
	[Token(Token = "0x400130C")]
	[FieldOffset(Offset = "0x40")]
	private float m_percent;

	// Token: 0x0400130D RID: 4877
	[Token(Token = "0x400130D")]
	[FieldOffset(Offset = "0x48")]
	private Action m_callback;

	// Token: 0x0400130E RID: 4878
	[Token(Token = "0x400130E")]
	[FieldOffset(Offset = "0x50")]
	private CameraMove.MoveType m_moveType;

	// Token: 0x0400130F RID: 4879
	[Token(Token = "0x400130F")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private AnimationCurve m_curve_moveToNpc;

	// Token: 0x04001310 RID: 4880
	[Token(Token = "0x4001310")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private AnimationCurve m_curve_moveToNpcYOffset;

	// Token: 0x04001311 RID: 4881
	[Token(Token = "0x4001311")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float TotalTime_MoveToNpc;

	// Token: 0x04001312 RID: 4882
	[Token(Token = "0x4001312")]
	[FieldOffset(Offset = "0x6C")]
	private Vector3 m_npcPos;

	// Token: 0x04001313 RID: 4883
	[Token(Token = "0x4001313")]
	[FieldOffset(Offset = "0x78")]
	private float m_percentPos_MoveToNpc;

	// Token: 0x04001314 RID: 4884
	[Token(Token = "0x4001314")]
	[FieldOffset(Offset = "0x7C")]
	private float m_percentPosY_MoveToNpc;

	// Token: 0x04001315 RID: 4885
	[Token(Token = "0x4001315")]
	[FieldOffset(Offset = "0x80")]
	private Action m_callback2;

	// Token: 0x04001316 RID: 4886
	[Token(Token = "0x4001316")]
	[FieldOffset(Offset = "0x88")]
	private bool m_isCallback2Act;

	// Token: 0x04001317 RID: 4887
	[Token(Token = "0x4001317")]
	private const string GroupName = "相机移动到指定位置";

	// Token: 0x04001318 RID: 4888
	[Token(Token = "0x4001318")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private AnimationCurve curve_MoveLine;

	// Token: 0x04001319 RID: 4889
	[Token(Token = "0x4001319")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private AnimationCurve curve_Rotation;

	// Token: 0x0400131A RID: 4890
	[Token(Token = "0x400131A")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private float m_dt_MoveTo;

	// Token: 0x0400131B RID: 4891
	[Token(Token = "0x400131B")]
	[FieldOffset(Offset = "0xA4")]
	[SerializeField]
	private float m_dt_Resume;

	// Token: 0x0400131C RID: 4892
	[Token(Token = "0x400131C")]
	[FieldOffset(Offset = "0xA8")]
	private Vector3 m_lastRaycastPos;

	// Token: 0x0400131D RID: 4893
	[Token(Token = "0x400131D")]
	[FieldOffset(Offset = "0xB4")]
	private Vector3 m_lastForward;

	// Token: 0x0400131E RID: 4894
	[Token(Token = "0x400131E")]
	[FieldOffset(Offset = "0xC0")]
	private Vector3 m_tmpVec3;

	// Token: 0x0400131F RID: 4895
	[Token(Token = "0x400131F")]
	[FieldOffset(Offset = "0xCC")]
	private Quaternion m_startQua;

	// Token: 0x04001320 RID: 4896
	[Token(Token = "0x4001320")]
	[FieldOffset(Offset = "0xDC")]
	private Quaternion m_endQua;

	// Token: 0x04001321 RID: 4897
	[Token(Token = "0x4001321")]
	[FieldOffset(Offset = "0xEC")]
	private float m_ratioMove;

	// Token: 0x04001322 RID: 4898
	[Token(Token = "0x4001322")]
	[FieldOffset(Offset = "0xF0")]
	private float m_ratioRotate;

	// Token: 0x0200026E RID: 622
	[Token(Token = "0x200026E")]
	private enum MoveType
	{
		// Token: 0x04001324 RID: 4900
		[Token(Token = "0x4001324")]
		None,
		// Token: 0x04001325 RID: 4901
		[Token(Token = "0x4001325")]
		MoveToNpc,
		// Token: 0x04001326 RID: 4902
		[Token(Token = "0x4001326")]
		MoveToTarget,
		// Token: 0x04001327 RID: 4903
		[Token(Token = "0x4001327")]
		ResumeFromTarget,
		// Token: 0x04001328 RID: 4904
		[Token(Token = "0x4001328")]
		EnterRoom,
		// Token: 0x04001329 RID: 4905
		[Token(Token = "0x4001329")]
		ExitRoom,
		// Token: 0x0400132A RID: 4906
		[Token(Token = "0x400132A")]
		MoveToFirstView,
		// Token: 0x0400132B RID: 4907
		[Token(Token = "0x400132B")]
		ResumeFromFirstView,
		// Token: 0x0400132C RID: 4908
		[Token(Token = "0x400132C")]
		EnterBorfire,
		// Token: 0x0400132D RID: 4909
		[Token(Token = "0x400132D")]
		ExitBorfire
	}
}
