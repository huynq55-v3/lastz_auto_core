using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BitBenderGames.CameraState
{
	// Token: 0x02000AC9 RID: 2761
	[Token(Token = "0x2000AC9")]
	public class CameraStateMoveTo : CameraStateBase
	{
		// Token: 0x060068F3 RID: 26867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068F3")]
		[Address(RVA = "0x3487220", Offset = "0x3487220", VA = "0x3487220")]
		public CameraStateMoveTo(MobileTouchCamera touchCamera)
		{
		}

		// Token: 0x060068F4 RID: 26868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068F4")]
		[Address(RVA = "0x3487228", Offset = "0x3487228", VA = "0x3487228", Slot = "4")]
		public override void OnEnter()
		{
		}

		// Token: 0x060068F5 RID: 26869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068F5")]
		[Address(RVA = "0x3487544", Offset = "0x3487544", VA = "0x3487544", Slot = "5")]
		public override void OnUpdate()
		{
		}

		// Token: 0x060068F6 RID: 26870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068F6")]
		[Address(RVA = "0x348773C", Offset = "0x348773C", VA = "0x348773C", Slot = "6")]
		public override void OnLeave()
		{
		}

		// Token: 0x04002A39 RID: 10809
		[Token(Token = "0x4002A39")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 _target;

		// Token: 0x04002A3A RID: 10810
		[Token(Token = "0x4002A3A")]
		[FieldOffset(Offset = "0x24")]
		public float _time;

		// Token: 0x04002A3B RID: 10811
		[Token(Token = "0x4002A3B")]
		[FieldOffset(Offset = "0x28")]
		public float _zoom;

		// Token: 0x04002A3C RID: 10812
		[Token(Token = "0x4002A3C")]
		[FieldOffset(Offset = "0x30")]
		public Action _onComplete;

		// Token: 0x04002A3D RID: 10813
		[Token(Token = "0x4002A3D")]
		[FieldOffset(Offset = "0x38")]
		public CameraStateMoveTo.MoveType _moveType;

		// Token: 0x04002A3E RID: 10814
		[Token(Token = "0x4002A3E")]
		[FieldOffset(Offset = "0x3C")]
		private bool _needAlwaysLookAtTarget;

		// Token: 0x04002A3F RID: 10815
		[Token(Token = "0x4002A3F")]
		[FieldOffset(Offset = "0x40")]
		private Quaternion _startRot;

		// Token: 0x04002A40 RID: 10816
		[Token(Token = "0x4002A40")]
		[FieldOffset(Offset = "0x50")]
		private Quaternion _endRot;

		// Token: 0x04002A41 RID: 10817
		[Token(Token = "0x4002A41")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 _startPos;

		// Token: 0x04002A42 RID: 10818
		[Token(Token = "0x4002A42")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 _endPos;

		// Token: 0x04002A43 RID: 10819
		[Token(Token = "0x4002A43")]
		[FieldOffset(Offset = "0x78")]
		private float _startZoom;

		// Token: 0x04002A44 RID: 10820
		[Token(Token = "0x4002A44")]
		[FieldOffset(Offset = "0x7C")]
		private float _endZoom;

		// Token: 0x04002A45 RID: 10821
		[Token(Token = "0x4002A45")]
		[FieldOffset(Offset = "0x80")]
		private int _anim;

		// Token: 0x04002A46 RID: 10822
		[Token(Token = "0x4002A46")]
		[FieldOffset(Offset = "0x84")]
		private float _animTime;

		// Token: 0x02000ACA RID: 2762
		[Token(Token = "0x2000ACA")]
		public enum MoveType
		{
			// Token: 0x04002A48 RID: 10824
			[Token(Token = "0x4002A48")]
			ZoomOnly,
			// Token: 0x04002A49 RID: 10825
			[Token(Token = "0x4002A49")]
			MoveAndZoom
		}
	}
}
