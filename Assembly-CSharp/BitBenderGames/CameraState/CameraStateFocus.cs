using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BitBenderGames.CameraState
{
	// Token: 0x02000AC5 RID: 2757
	[Token(Token = "0x2000AC5")]
	public class CameraStateFocus : CameraStateBase
	{
		// Token: 0x060068D2 RID: 26834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068D2")]
		[Address(RVA = "0x33CAE14", Offset = "0x33CAE14", VA = "0x33CAE14")]
		public CameraStateFocus(MobileTouchCamera touchCamera)
		{
		}

		// Token: 0x060068D3 RID: 26835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068D3")]
		[Address(RVA = "0x33D24B0", Offset = "0x33D24B0", VA = "0x33D24B0", Slot = "4")]
		public override void OnEnter()
		{
		}

		// Token: 0x060068D4 RID: 26836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068D4")]
		[Address(RVA = "0x33D2A28", Offset = "0x33D2A28", VA = "0x33D2A28", Slot = "5")]
		public override void OnUpdate()
		{
		}

		// Token: 0x060068D5 RID: 26837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068D5")]
		[Address(RVA = "0x33D2BFC", Offset = "0x33D2BFC", VA = "0x33D2BFC")]
		public MobileTouchCameraDragMove GetMobileTouchCameraDragMove()
		{
			return null;
		}

		// Token: 0x060068D6 RID: 26838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068D6")]
		[Address(RVA = "0x33D2C04", Offset = "0x33D2C04", VA = "0x33D2C04", Slot = "6")]
		public override void OnLeave()
		{
		}

		// Token: 0x060068D7 RID: 26839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068D7")]
		[Address(RVA = "0x33D2DC0", Offset = "0x33D2DC0", VA = "0x33D2DC0")]
		private void OnFingerDown(Vector3 pos)
		{
		}

		// Token: 0x060068D8 RID: 26840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068D8")]
		[Address(RVA = "0x33D2DF4", Offset = "0x33D2DF4", VA = "0x33D2DF4")]
		private void OnDragStart(Vector3 dragPosStart, bool isLongTap)
		{
		}

		// Token: 0x060068D9 RID: 26841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068D9")]
		[Address(RVA = "0x33D2E34", Offset = "0x33D2E34", VA = "0x33D2E34")]
		private void OnDragUpdate(Vector3 dragPosStart, Vector3 dragPosCurrent, Vector3 correctionOffset)
		{
		}

		// Token: 0x060068DA RID: 26842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068DA")]
		[Address(RVA = "0x33D2E84", Offset = "0x33D2E84", VA = "0x33D2E84")]
		private void OnDragStop(Vector3 dragStopPos, Vector3 dragFinalMomentum)
		{
		}

		// Token: 0x060068DB RID: 26843 RVA: 0x0004D010 File Offset: 0x0004B210
		[Token(Token = "0x60068DB")]
		[Address(RVA = "0x33D2BA8", Offset = "0x33D2BA8", VA = "0x33D2BA8")]
		private float EvaluateLerpCurve(float t)
		{
			return 0f;
		}

		// Token: 0x04002A22 RID: 10786
		[Token(Token = "0x4002A22")]
		[FieldOffset(Offset = "0x18")]
		private MobileTouchCameraDragMove _dragMove;

		// Token: 0x04002A23 RID: 10787
		[Token(Token = "0x4002A23")]
		[FieldOffset(Offset = "0x20")]
		private bool _inputDonwOnUI;

		// Token: 0x04002A24 RID: 10788
		[Token(Token = "0x4002A24")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 _target;

		// Token: 0x04002A25 RID: 10789
		[Token(Token = "0x4002A25")]
		[FieldOffset(Offset = "0x30")]
		public float _time;

		// Token: 0x04002A26 RID: 10790
		[Token(Token = "0x4002A26")]
		[FieldOffset(Offset = "0x34")]
		public float _zoom;

		// Token: 0x04002A27 RID: 10791
		[Token(Token = "0x4002A27")]
		[FieldOffset(Offset = "0x38")]
		public float _rotation;

		// Token: 0x04002A28 RID: 10792
		[Token(Token = "0x4002A28")]
		[FieldOffset(Offset = "0x40")]
		public AnimationCurve _lerpCurve;

		// Token: 0x04002A29 RID: 10793
		[Token(Token = "0x4002A29")]
		[FieldOffset(Offset = "0x48")]
		public bool _focusToCenter;

		// Token: 0x04002A2A RID: 10794
		[Token(Token = "0x4002A2A")]
		[FieldOffset(Offset = "0x49")]
		public bool _lockView;

		// Token: 0x04002A2B RID: 10795
		[Token(Token = "0x4002A2B")]
		[FieldOffset(Offset = "0x50")]
		public Action _onComplete;

		// Token: 0x04002A2C RID: 10796
		[Token(Token = "0x4002A2C")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 _startPos;

		// Token: 0x04002A2D RID: 10797
		[Token(Token = "0x4002A2D")]
		[FieldOffset(Offset = "0x64")]
		private Vector3 _endPos;

		// Token: 0x04002A2E RID: 10798
		[Token(Token = "0x4002A2E")]
		[FieldOffset(Offset = "0x70")]
		private Quaternion _startRotation;

		// Token: 0x04002A2F RID: 10799
		[Token(Token = "0x4002A2F")]
		[FieldOffset(Offset = "0x80")]
		private Quaternion _endRotation;

		// Token: 0x04002A30 RID: 10800
		[Token(Token = "0x4002A30")]
		private const int AnimFocus = 0;

		// Token: 0x04002A31 RID: 10801
		[Token(Token = "0x4002A31")]
		private const int AnimEnd = 1;

		// Token: 0x04002A32 RID: 10802
		[Token(Token = "0x4002A32")]
		[FieldOffset(Offset = "0x90")]
		private int _anim;

		// Token: 0x04002A33 RID: 10803
		[Token(Token = "0x4002A33")]
		[FieldOffset(Offset = "0x94")]
		private float _animTime;
	}
}
