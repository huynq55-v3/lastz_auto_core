using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BitBenderGames
{
	// Token: 0x02000AA9 RID: 2729
	[Token(Token = "0x2000AA9")]
	public class MobileTouchCameraPinchZoom
	{
		// Token: 0x06006836 RID: 26678 RVA: 0x0004CE78 File Offset: 0x0004B078
		[Token(Token = "0x6006836")]
		[Address(RVA = "0x33CDBB0", Offset = "0x33CDBB0", VA = "0x33CDBB0")]
		public bool GetPinchingState()
		{
			return default(bool);
		}

		// Token: 0x06006837 RID: 26679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006837")]
		[Address(RVA = "0x33CDBB8", Offset = "0x33CDBB8", VA = "0x33CDBB8")]
		public MobileTouchCameraPinchZoom(MobileTouchCamera camera)
		{
		}

		// Token: 0x06006838 RID: 26680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006838")]
		[Address(RVA = "0x33CDBF0", Offset = "0x33CDBF0", VA = "0x33CDBF0")]
		public void OnPinchStart(Vector3 pinchCenter, float pinchDistance)
		{
		}

		// Token: 0x06006839 RID: 26681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006839")]
		[Address(RVA = "0x33CDC54", Offset = "0x33CDC54", VA = "0x33CDC54")]
		public void OnPinchUpdate(PinchUpdateData pinchUpdateData)
		{
		}

		// Token: 0x0600683A RID: 26682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600683A")]
		[Address(RVA = "0x33CDC88", Offset = "0x33CDC88", VA = "0x33CDC88")]
		public void OnPinchStop()
		{
		}

		// Token: 0x0600683B RID: 26683 RVA: 0x0004CE90 File Offset: 0x0004B090
		[Token(Token = "0x600683B")]
		[Address(RVA = "0x33CDC98", Offset = "0x33CDC98", VA = "0x33CDC98")]
		public bool UpdatePinch()
		{
			return default(bool);
		}

		// Token: 0x0600683C RID: 26684 RVA: 0x0004CEA8 File Offset: 0x0004B0A8
		[Token(Token = "0x600683C")]
		[Address(RVA = "0x33CDDFC", Offset = "0x33CDDFC", VA = "0x33CDDFC")]
		private bool DoEditorZoom()
		{
			return default(bool);
		}

		// Token: 0x040029C8 RID: 10696
		[Token(Token = "0x40029C8")]
		[FieldOffset(Offset = "0x10")]
		private MobileTouchCamera _touchCamera;

		// Token: 0x040029C9 RID: 10697
		[Token(Token = "0x40029C9")]
		[FieldOffset(Offset = "0x18")]
		private bool isPinching;

		// Token: 0x040029CA RID: 10698
		[Token(Token = "0x40029CA")]
		[FieldOffset(Offset = "0x19")]
		private bool canPinch;

		// Token: 0x040029CB RID: 10699
		[Token(Token = "0x40029CB")]
		[FieldOffset(Offset = "0x1C")]
		private Vector3 pinchCenterCurrent;

		// Token: 0x040029CC RID: 10700
		[Token(Token = "0x40029CC")]
		[FieldOffset(Offset = "0x28")]
		private float pinchDistanceCurrent;

		// Token: 0x040029CD RID: 10701
		[Token(Token = "0x40029CD")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 pinchCenterCurrentLerp;

		// Token: 0x040029CE RID: 10702
		[Token(Token = "0x40029CE")]
		[FieldOffset(Offset = "0x38")]
		private float pinchDistanceCurrentLerp;

		// Token: 0x040029CF RID: 10703
		[Token(Token = "0x40029CF")]
		[FieldOffset(Offset = "0x3C")]
		private float pinchDistanceLastLerp;

		// Token: 0x040029D0 RID: 10704
		[Token(Token = "0x40029D0")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 pinchStartIntersectionCenter;

		// Token: 0x040029D1 RID: 10705
		[Token(Token = "0x40029D1")]
		[FieldOffset(Offset = "0x4C")]
		private float pinchDistanceLast;
	}
}
