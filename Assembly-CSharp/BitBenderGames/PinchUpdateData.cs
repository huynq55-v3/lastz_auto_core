using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BitBenderGames
{
	// Token: 0x02000AAD RID: 2733
	[Token(Token = "0x2000AAD")]
	public class PinchUpdateData
	{
		// Token: 0x0600684D RID: 26701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600684D")]
		[Address(RVA = "0x33CE300", Offset = "0x33CE300", VA = "0x33CE300")]
		public PinchUpdateData()
		{
		}

		// Token: 0x040029DA RID: 10714
		[Token(Token = "0x40029DA")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 pinchCenter;

		// Token: 0x040029DB RID: 10715
		[Token(Token = "0x40029DB")]
		[FieldOffset(Offset = "0x1C")]
		public float pinchDistance;

		// Token: 0x040029DC RID: 10716
		[Token(Token = "0x40029DC")]
		[FieldOffset(Offset = "0x20")]
		public float pinchStartDistance;

		// Token: 0x040029DD RID: 10717
		[Token(Token = "0x40029DD")]
		[FieldOffset(Offset = "0x24")]
		public float pinchAngleDelta;

		// Token: 0x040029DE RID: 10718
		[Token(Token = "0x40029DE")]
		[FieldOffset(Offset = "0x28")]
		public float pinchAngleDeltaNormalized;

		// Token: 0x040029DF RID: 10719
		[Token(Token = "0x40029DF")]
		[FieldOffset(Offset = "0x2C")]
		public float pinchTiltDelta;

		// Token: 0x040029E0 RID: 10720
		[Token(Token = "0x40029E0")]
		[FieldOffset(Offset = "0x30")]
		public float pinchTotalFingerMovement;
	}
}
