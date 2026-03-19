using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BitBenderGames.CameraState
{
	// Token: 0x02000AC7 RID: 2759
	[Token(Token = "0x2000AC7")]
	public class CameraStateFreeLook : CameraStateBase
	{
		// Token: 0x060068E1 RID: 26849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068E1")]
		[Address(RVA = "0x33CAD34", Offset = "0x33CAD34", VA = "0x33CAD34")]
		public CameraStateFreeLook(MobileTouchCamera touchCamera)
		{
		}

		// Token: 0x060068E2 RID: 26850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068E2")]
		[Address(RVA = "0x33D316C", Offset = "0x33D316C", VA = "0x33D316C", Slot = "4")]
		public override void OnEnter()
		{
		}

		// Token: 0x060068E3 RID: 26851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068E3")]
		[Address(RVA = "0x33D3448", Offset = "0x33D3448", VA = "0x33D3448", Slot = "5")]
		public override void OnUpdate()
		{
		}

		// Token: 0x060068E4 RID: 26852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068E4")]
		[Address(RVA = "0x33D34E8", Offset = "0x33D34E8", VA = "0x33D34E8")]
		public MobileTouchCameraDragMove GetMobileTouchCameraDragMove()
		{
			return null;
		}

		// Token: 0x060068E5 RID: 26853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068E5")]
		[Address(RVA = "0x33D34F0", Offset = "0x33D34F0", VA = "0x33D34F0", Slot = "6")]
		public override void OnLeave()
		{
		}

		// Token: 0x060068E6 RID: 26854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068E6")]
		[Address(RVA = "0x33D37C0", Offset = "0x33D37C0", VA = "0x33D37C0")]
		private void OnFingerDown(Vector3 pos)
		{
		}

		// Token: 0x060068E7 RID: 26855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068E7")]
		[Address(RVA = "0x33D37D8", Offset = "0x33D37D8", VA = "0x33D37D8")]
		private void OnDragStart(Vector3 dragPosStart, bool isLongTap)
		{
		}

		// Token: 0x060068E8 RID: 26856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068E8")]
		[Address(RVA = "0x33D37F0", Offset = "0x33D37F0", VA = "0x33D37F0")]
		private void OnDragUpdate(Vector3 dragPosStart, Vector3 dragPosCurrent, Vector3 correctionOffset)
		{
		}

		// Token: 0x060068E9 RID: 26857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068E9")]
		[Address(RVA = "0x33D3830", Offset = "0x33D3830", VA = "0x33D3830")]
		private void OnDragStop(Vector3 dragStopPos, Vector3 dragFinalMomentum)
		{
		}

		// Token: 0x060068EA RID: 26858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068EA")]
		[Address(RVA = "0x33D3848", Offset = "0x33D3848", VA = "0x33D3848")]
		public void OnPinchStart(Vector3 pinchCenter, float pinchDistance)
		{
		}

		// Token: 0x060068EB RID: 26859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068EB")]
		[Address(RVA = "0x33D3878", Offset = "0x33D3878", VA = "0x33D3878")]
		private void OnPinchUpdate(PinchUpdateData pinchUpdateData)
		{
		}

		// Token: 0x060068EC RID: 26860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068EC")]
		[Address(RVA = "0x33D38C4", Offset = "0x33D38C4", VA = "0x33D38C4")]
		private void OnPinchStop()
		{
		}

		// Token: 0x04002A37 RID: 10807
		[Token(Token = "0x4002A37")]
		[FieldOffset(Offset = "0x18")]
		private MobileTouchCameraDragMove _dragMove;

		// Token: 0x04002A38 RID: 10808
		[Token(Token = "0x4002A38")]
		[FieldOffset(Offset = "0x20")]
		private MobileTouchCameraPinchZoom _pinchZoom;
	}
}
