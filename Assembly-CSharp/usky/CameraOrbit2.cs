using System;
using Il2CppDummyDll;
using UnityEngine;

namespace usky
{
	// Token: 0x02000A03 RID: 2563
	[Token(Token = "0x2000A03")]
	[AddComponentMenu("uSkyPro/Other/CameraOrbit 2")]
	public class CameraOrbit2 : MonoBehaviour
	{
		// Token: 0x060061F9 RID: 25081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061F9")]
		[Address(RVA = "0x1418864", Offset = "0x1418864", VA = "0x1418864")]
		private void Start()
		{
		}

		// Token: 0x060061FA RID: 25082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061FA")]
		[Address(RVA = "0x141889C", Offset = "0x141889C", VA = "0x141889C")]
		private void LateUpdate()
		{
		}

		// Token: 0x060061FB RID: 25083 RVA: 0x0004B810 File Offset: 0x00049A10
		[Token(Token = "0x60061FB")]
		[Address(RVA = "0x1418DCC", Offset = "0x1418DCC", VA = "0x1418DCC")]
		private static float ClampAngle(float angle, float min, float max)
		{
			return 0f;
		}

		// Token: 0x060061FC RID: 25084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061FC")]
		[Address(RVA = "0x1418E08", Offset = "0x1418E08", VA = "0x1418E08")]
		public void SetCameraHeightOffset(float value)
		{
		}

		// Token: 0x060061FD RID: 25085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061FD")]
		[Address(RVA = "0x1418E10", Offset = "0x1418E10", VA = "0x1418E10")]
		public CameraOrbit2()
		{
		}

		// Token: 0x04002634 RID: 9780
		[Token(Token = "0x4002634")]
		[FieldOffset(Offset = "0x18")]
		public Transform target;

		// Token: 0x04002635 RID: 9781
		[Token(Token = "0x4002635")]
		[FieldOffset(Offset = "0x20")]
		public float targetHeight;

		// Token: 0x04002636 RID: 9782
		[Token(Token = "0x4002636")]
		[FieldOffset(Offset = "0x24")]
		public float distance;

		// Token: 0x04002637 RID: 9783
		[Token(Token = "0x4002637")]
		[FieldOffset(Offset = "0x28")]
		public float maxDistance;

		// Token: 0x04002638 RID: 9784
		[Token(Token = "0x4002638")]
		[FieldOffset(Offset = "0x2C")]
		public float minDistance;

		// Token: 0x04002639 RID: 9785
		[Token(Token = "0x4002639")]
		[FieldOffset(Offset = "0x30")]
		public float xSpeed;

		// Token: 0x0400263A RID: 9786
		[Token(Token = "0x400263A")]
		[FieldOffset(Offset = "0x34")]
		public float ySpeed;

		// Token: 0x0400263B RID: 9787
		[Token(Token = "0x400263B")]
		[FieldOffset(Offset = "0x38")]
		public int yMinLimit;

		// Token: 0x0400263C RID: 9788
		[Token(Token = "0x400263C")]
		[FieldOffset(Offset = "0x3C")]
		public int yMaxLimit;

		// Token: 0x0400263D RID: 9789
		[Token(Token = "0x400263D")]
		[FieldOffset(Offset = "0x40")]
		public int zoomRate;

		// Token: 0x0400263E RID: 9790
		[Token(Token = "0x400263E")]
		[FieldOffset(Offset = "0x44")]
		public float rotationDampening;

		// Token: 0x0400263F RID: 9791
		[Token(Token = "0x400263F")]
		[FieldOffset(Offset = "0x48")]
		public float zoomDampening;

		// Token: 0x04002640 RID: 9792
		[Token(Token = "0x4002640")]
		[FieldOffset(Offset = "0x4C")]
		private float xDeg;

		// Token: 0x04002641 RID: 9793
		[Token(Token = "0x4002641")]
		[FieldOffset(Offset = "0x50")]
		private float yDeg;

		// Token: 0x04002642 RID: 9794
		[Token(Token = "0x4002642")]
		[FieldOffset(Offset = "0x54")]
		private float currentDistance;

		// Token: 0x04002643 RID: 9795
		[Token(Token = "0x4002643")]
		[FieldOffset(Offset = "0x58")]
		private float desiredDistance;

		// Token: 0x04002644 RID: 9796
		[Token(Token = "0x4002644")]
		[FieldOffset(Offset = "0x5C")]
		private float correctedDistance;
	}
}
