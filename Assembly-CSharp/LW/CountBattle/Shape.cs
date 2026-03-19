using System;
using Il2CppDummyDll;
using UnityEngine;

namespace LW.CountBattle
{
	// Token: 0x020003DA RID: 986
	[Token(Token = "0x20003DA")]
	public abstract class Shape
	{
		// Token: 0x060018E3 RID: 6371
		[Token(Token = "0x60018E3")]
		public abstract Vector2 World2Local(Vector2 worldPoint);

		// Token: 0x060018E4 RID: 6372
		[Token(Token = "0x60018E4")]
		public abstract Vector2 Local2World(Vector2 worldPoint);

		// Token: 0x060018E5 RID: 6373
		[Token(Token = "0x60018E5")]
		public abstract bool Contains(Vector2 point);

		// Token: 0x060018E6 RID: 6374
		[Token(Token = "0x60018E6")]
		public abstract bool Overlap(Shape other);

		// Token: 0x060018E7 RID: 6375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018E7")]
		[Address(RVA = "0x202534C", Offset = "0x202534C", VA = "0x202534C")]
		public Shape(Vector2 pos, float angle)
		{
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018E8")]
		[Address(RVA = "0x2025388", Offset = "0x2025388", VA = "0x2025388")]
		public void SetPos(float x, float y)
		{
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018E9")]
		[Address(RVA = "0x2025390", Offset = "0x2025390", VA = "0x2025390")]
		public void Get_pos(out float x, out float y)
		{
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018EA")]
		[Address(RVA = "0x20253A4", Offset = "0x20253A4", VA = "0x20253A4")]
		public void Set_pos(float x, float y)
		{
		}

		// Token: 0x04001B5E RID: 7006
		[Token(Token = "0x4001B5E")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 pos;

		// Token: 0x04001B5F RID: 7007
		[Token(Token = "0x4001B5F")]
		[FieldOffset(Offset = "0x18")]
		public float angle;
	}
}
