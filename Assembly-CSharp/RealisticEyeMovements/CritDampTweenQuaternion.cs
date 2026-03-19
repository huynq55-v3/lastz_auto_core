using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RealisticEyeMovements
{
	// Token: 0x02000C71 RID: 3185
	[Token(Token = "0x2000C71")]
	internal struct CritDampTweenQuaternion
	{
		// Token: 0x06007958 RID: 31064 RVA: 0x00053460 File Offset: 0x00051660
		[Token(Token = "0x6007958")]
		[Address(RVA = "0x1486E48", Offset = "0x1486E48", VA = "0x1486E48")]
		private static Vector4 q2v(Quaternion q)
		{
			return default(Vector4);
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x06007959 RID: 31065 RVA: 0x00053478 File Offset: 0x00051678
		// (set) Token: 0x0600795A RID: 31066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AD7")]
		public Quaternion rotation
		{
			[Token(Token = "0x6007959")]
			[Address(RVA = "0x1486E4C", Offset = "0x1486E4C", VA = "0x1486E4C")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600795A")]
			[Address(RVA = "0x1486E58", Offset = "0x1486E58", VA = "0x1486E58")]
			set
			{
			}
		}

		// Token: 0x0600795B RID: 31067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600795B")]
		[Address(RVA = "0x1486E64", Offset = "0x1486E64", VA = "0x1486E64")]
		public CritDampTweenQuaternion(Quaternion rotation, float omega, float maxSpeed)
		{
		}

		// Token: 0x0600795C RID: 31068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600795C")]
		[Address(RVA = "0x1486EF0", Offset = "0x1486EF0", VA = "0x1486EF0")]
		public void Step(Quaternion target)
		{
		}

		// Token: 0x0600795D RID: 31069 RVA: 0x00053490 File Offset: 0x00051690
		[Token(Token = "0x600795D")]
		[Address(RVA = "0x1487124", Offset = "0x1487124", VA = "0x1487124")]
		public static implicit operator Quaternion(CritDampTweenQuaternion m)
		{
			return default(Quaternion);
		}

		// Token: 0x0400342B RID: 13355
		[Token(Token = "0x400342B")]
		[FieldOffset(Offset = "0x0")]
		private CritDampTweenQuaternion.QVUnion _rotation;

		// Token: 0x0400342C RID: 13356
		[Token(Token = "0x400342C")]
		[FieldOffset(Offset = "0x10")]
		public Vector4 velocity;

		// Token: 0x0400342D RID: 13357
		[Token(Token = "0x400342D")]
		[FieldOffset(Offset = "0x20")]
		public float omega;

		// Token: 0x0400342E RID: 13358
		[Token(Token = "0x400342E")]
		[FieldOffset(Offset = "0x24")]
		private readonly float maxSpeed;

		// Token: 0x02000C72 RID: 3186
		[Token(Token = "0x2000C72")]
		[StructLayout(LayoutKind.Explicit)]
		private struct QVUnion
		{
			// Token: 0x0400342F RID: 13359
			[Token(Token = "0x400342F")]
			[FieldOffset(Offset = "0x0")]
			public Vector4 v;

			// Token: 0x04003430 RID: 13360
			[Token(Token = "0x4003430")]
			[FieldOffset(Offset = "0x0")]
			public Quaternion q;
		}
	}
}
