using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BitBenderGames.CameraState
{
	// Token: 0x02000ACB RID: 2763
	[Token(Token = "0x2000ACB")]
	public class CameraStateQuitFocus : CameraStateBase
	{
		// Token: 0x060068F7 RID: 26871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068F7")]
		[Address(RVA = "0x34877D0", Offset = "0x34877D0", VA = "0x34877D0")]
		public CameraStateQuitFocus(MobileTouchCamera touchCamera)
		{
		}

		// Token: 0x060068F8 RID: 26872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068F8")]
		[Address(RVA = "0x34877D8", Offset = "0x34877D8", VA = "0x34877D8", Slot = "4")]
		public override void OnEnter()
		{
		}

		// Token: 0x060068F9 RID: 26873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068F9")]
		[Address(RVA = "0x3487BE8", Offset = "0x3487BE8", VA = "0x3487BE8", Slot = "5")]
		public override void OnUpdate()
		{
		}

		// Token: 0x060068FA RID: 26874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068FA")]
		[Address(RVA = "0x3487D68", Offset = "0x3487D68", VA = "0x3487D68", Slot = "6")]
		public override void OnLeave()
		{
		}

		// Token: 0x060068FB RID: 26875 RVA: 0x0004D028 File Offset: 0x0004B228
		[Token(Token = "0x60068FB")]
		[Address(RVA = "0x3487D14", Offset = "0x3487D14", VA = "0x3487D14")]
		private float EvaluateLerpCurve(float t)
		{
			return 0f;
		}

		// Token: 0x04002A4A RID: 10826
		[Token(Token = "0x4002A4A")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 _target;

		// Token: 0x04002A4B RID: 10827
		[Token(Token = "0x4002A4B")]
		[FieldOffset(Offset = "0x24")]
		public float _time;

		// Token: 0x04002A4C RID: 10828
		[Token(Token = "0x4002A4C")]
		[FieldOffset(Offset = "0x28")]
		public bool _focusToCenter;

		// Token: 0x04002A4D RID: 10829
		[Token(Token = "0x4002A4D")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 _startPos;

		// Token: 0x04002A4E RID: 10830
		[Token(Token = "0x4002A4E")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 _endPos;

		// Token: 0x04002A4F RID: 10831
		[Token(Token = "0x4002A4F")]
		[FieldOffset(Offset = "0x44")]
		private Quaternion _startRotation;

		// Token: 0x04002A50 RID: 10832
		[Token(Token = "0x4002A50")]
		[FieldOffset(Offset = "0x54")]
		private Quaternion _endRotation;

		// Token: 0x04002A51 RID: 10833
		[Token(Token = "0x4002A51")]
		[FieldOffset(Offset = "0x68")]
		private AnimationCurve _lerpCurve;

		// Token: 0x04002A52 RID: 10834
		[Token(Token = "0x4002A52")]
		[FieldOffset(Offset = "0x70")]
		private float _animTime;
	}
}
