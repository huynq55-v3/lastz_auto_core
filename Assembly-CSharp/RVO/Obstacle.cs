using System;
using Il2CppDummyDll;

namespace RVO
{
	// Token: 0x020003D2 RID: 978
	[Token(Token = "0x20003D2")]
	internal class Obstacle
	{
		// Token: 0x06001886 RID: 6278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001886")]
		[Address(RVA = "0x201F370", Offset = "0x201F370", VA = "0x201F370")]
		public Obstacle()
		{
		}

		// Token: 0x04001B39 RID: 6969
		[Token(Token = "0x4001B39")]
		[FieldOffset(Offset = "0x10")]
		internal Obstacle next_;

		// Token: 0x04001B3A RID: 6970
		[Token(Token = "0x4001B3A")]
		[FieldOffset(Offset = "0x18")]
		internal Obstacle previous_;

		// Token: 0x04001B3B RID: 6971
		[Token(Token = "0x4001B3B")]
		[FieldOffset(Offset = "0x20")]
		internal Vector2 direction_;

		// Token: 0x04001B3C RID: 6972
		[Token(Token = "0x4001B3C")]
		[FieldOffset(Offset = "0x28")]
		internal Vector2 point_;

		// Token: 0x04001B3D RID: 6973
		[Token(Token = "0x4001B3D")]
		[FieldOffset(Offset = "0x30")]
		internal int id_;

		// Token: 0x04001B3E RID: 6974
		[Token(Token = "0x4001B3E")]
		[FieldOffset(Offset = "0x34")]
		internal bool convex_;
	}
}
