using System;
using Il2CppDummyDll;
using Unity.Burst;

namespace RVO_DOTS
{
	// Token: 0x020003BF RID: 959
	[Token(Token = "0x20003BF")]
	[BurstCompile]
	public struct FloatPair
	{
		// Token: 0x0600180B RID: 6155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600180B")]
		[Address(RVA = "0x1DBFF54", Offset = "0x1DBFF54", VA = "0x1DBFF54")]
		internal FloatPair(float a, float b)
		{
		}

		// Token: 0x0600180C RID: 6156 RVA: 0x00008DF0 File Offset: 0x00006FF0
		[Token(Token = "0x600180C")]
		[Address(RVA = "0x1DBFF5C", Offset = "0x1DBFF5C", VA = "0x1DBFF5C")]
		public static bool operator <(FloatPair pair1, FloatPair pair2)
		{
			return default(bool);
		}

		// Token: 0x0600180D RID: 6157 RVA: 0x00008E08 File Offset: 0x00007008
		[Token(Token = "0x600180D")]
		[Address(RVA = "0x1DBFF84", Offset = "0x1DBFF84", VA = "0x1DBFF84")]
		public static bool operator <=(FloatPair pair1, FloatPair pair2)
		{
			return default(bool);
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x00008E20 File Offset: 0x00007020
		[Token(Token = "0x600180E")]
		[Address(RVA = "0x1DBFFC8", Offset = "0x1DBFFC8", VA = "0x1DBFFC8")]
		public static bool operator >(FloatPair pair1, FloatPair pair2)
		{
			return default(bool);
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x00008E38 File Offset: 0x00007038
		[Token(Token = "0x600180F")]
		[Address(RVA = "0x1DC000C", Offset = "0x1DC000C", VA = "0x1DC000C")]
		public static bool operator >=(FloatPair pair1, FloatPair pair2)
		{
			return default(bool);
		}

		// Token: 0x04001AD0 RID: 6864
		[Token(Token = "0x4001AD0")]
		[FieldOffset(Offset = "0x0")]
		private float a_;

		// Token: 0x04001AD1 RID: 6865
		[Token(Token = "0x4001AD1")]
		[FieldOffset(Offset = "0x4")]
		private float b_;
	}
}
