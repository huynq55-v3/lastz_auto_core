using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BitBenderGames
{
	// Token: 0x02000AA8 RID: 2728
	[Token(Token = "0x2000AA8")]
	public class MobileTouchCameraDragMove
	{
		// Token: 0x06006829 RID: 26665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006829")]
		[Address(RVA = "0x33CD338", Offset = "0x33CD338", VA = "0x33CD338")]
		public MobileTouchCameraDragMove(MobileTouchCamera camera)
		{
		}

		// Token: 0x0600682A RID: 26666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600682A")]
		[Address(RVA = "0x33CD3DC", Offset = "0x33CD3DC", VA = "0x33CD3DC")]
		public void Reset()
		{
		}

		// Token: 0x0600682B RID: 26667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600682B")]
		[Address(RVA = "0x33CC584", Offset = "0x33CC584", VA = "0x33CC584")]
		public void ResetPosLastFrameToCameraPos()
		{
		}

		// Token: 0x0600682C RID: 26668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600682C")]
		[Address(RVA = "0x33CD488", Offset = "0x33CD488", VA = "0x33CD488")]
		public void OnFingerDown()
		{
		}

		// Token: 0x0600682D RID: 26669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600682D")]
		[Address(RVA = "0x33CD4E0", Offset = "0x33CD4E0", VA = "0x33CD4E0")]
		public void OnDragStart(Vector3 dragPosStart)
		{
		}

		// Token: 0x0600682E RID: 26670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600682E")]
		[Address(RVA = "0x33CD588", Offset = "0x33CD588", VA = "0x33CD588")]
		public void OnDragUpdate(Vector3 dragPosStart, Vector3 dragPosCurrent, Vector3 correctionOffset)
		{
		}

		// Token: 0x0600682F RID: 26671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600682F")]
		[Address(RVA = "0x33CD68C", Offset = "0x33CD68C", VA = "0x33CD68C")]
		public void OnDragStop()
		{
		}

		// Token: 0x06006830 RID: 26672 RVA: 0x0004CE30 File Offset: 0x0004B030
		[Token(Token = "0x6006830")]
		[Address(RVA = "0x33CD6E4", Offset = "0x33CD6E4", VA = "0x33CD6E4")]
		public bool UpdateAutoScroll()
		{
			return default(bool);
		}

		// Token: 0x06006831 RID: 26673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006831")]
		[Address(RVA = "0x33CDA34", Offset = "0x33CDA34", VA = "0x33CDA34")]
		public void UpdatePosition(float deltaTime)
		{
		}

		// Token: 0x06006832 RID: 26674 RVA: 0x0004CE48 File Offset: 0x0004B048
		[Token(Token = "0x6006832")]
		[Address(RVA = "0x33CD5E0", Offset = "0x33CD5E0", VA = "0x33CD5E0")]
		private Vector3 GetDragVector(Vector3 dragPosStart, Vector3 dragPosCurrent)
		{
			return default(Vector3);
		}

		// Token: 0x06006833 RID: 26675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006833")]
		[Address(RVA = "0x33CDB4C", Offset = "0x33CDB4C", VA = "0x33CDB4C")]
		private void SetTargetPosition(Vector3 newPositionClamped)
		{
		}

		// Token: 0x06006834 RID: 26676 RVA: 0x0004CE60 File Offset: 0x0004B060
		[Token(Token = "0x6006834")]
		[Address(RVA = "0x33CD9D0", Offset = "0x33CD9D0", VA = "0x33CD9D0")]
		private float EvaluateAutoScrollDampCurve(float t)
		{
			return 0f;
		}

		// Token: 0x06006835 RID: 26677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006835")]
		[Address(RVA = "0x33CDB58", Offset = "0x33CDB58", VA = "0x33CDB58")]
		public void StopCameraScroll()
		{
		}

		// Token: 0x040029BF RID: 10687
		[Token(Token = "0x40029BF")]
		[FieldOffset(Offset = "0x10")]
		private MobileTouchCamera _touchCamera;

		// Token: 0x040029C0 RID: 10688
		[Token(Token = "0x40029C0")]
		[FieldOffset(Offset = "0x18")]
		private Vector3 targetPositionClamped;

		// Token: 0x040029C1 RID: 10689
		[Token(Token = "0x40029C1")]
		[FieldOffset(Offset = "0x24")]
		private float timeRealDragStop;

		// Token: 0x040029C2 RID: 10690
		[Token(Token = "0x40029C2")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 cameraScrollVelocity;

		// Token: 0x040029C3 RID: 10691
		[Token(Token = "0x40029C3")]
		[FieldOffset(Offset = "0x34")]
		private Vector3 camVelocity;

		// Token: 0x040029C4 RID: 10692
		[Token(Token = "0x40029C4")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 posLastFrame;

		// Token: 0x040029C5 RID: 10693
		[Token(Token = "0x40029C5")]
		[FieldOffset(Offset = "0x4C")]
		private bool isDragging;

		// Token: 0x040029C6 RID: 10694
		[Token(Token = "0x40029C6")]
		[FieldOffset(Offset = "0x4D")]
		private bool canDrag;

		// Token: 0x040029C7 RID: 10695
		[Token(Token = "0x40029C7")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 dragStartCamPos;
	}
}
