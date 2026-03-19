using System;
using Il2CppDummyDll;
using UnityEngine;

namespace LW.CountBattle
{
	// Token: 0x020003DC RID: 988
	[Token(Token = "0x20003DC")]
	public class Box : Shape
	{
		// Token: 0x060018F1 RID: 6385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018F1")]
		[Address(RVA = "0x20257C8", Offset = "0x20257C8", VA = "0x20257C8")]
		public Box(Vector2 pos, float angle, Vector2 size)
		{
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018F2")]
		[Address(RVA = "0x2025818", Offset = "0x2025818", VA = "0x2025818")]
		public void Get_size(out float x, out float y)
		{
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018F3")]
		[Address(RVA = "0x202582C", Offset = "0x202582C", VA = "0x202582C")]
		public void Set_size(float x, float y)
		{
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018F4")]
		[Address(RVA = "0x2025834", Offset = "0x2025834", VA = "0x2025834")]
		public Vector2[] GetLocalCorners()
		{
			return null;
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018F5")]
		[Address(RVA = "0x20258F4", Offset = "0x20258F4", VA = "0x20258F4")]
		public Vector2[] GetWorldCorners()
		{
			return null;
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x00009870 File Offset: 0x00007A70
		[Token(Token = "0x60018F6")]
		[Address(RVA = "0x2025980", Offset = "0x2025980", VA = "0x2025980", Slot = "4")]
		public override Vector2 World2Local(Vector2 worldPoint)
		{
			return default(Vector2);
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x00009888 File Offset: 0x00007A88
		[Token(Token = "0x60018F7")]
		[Address(RVA = "0x20259DC", Offset = "0x20259DC", VA = "0x20259DC", Slot = "5")]
		public override Vector2 Local2World(Vector2 localPoint)
		{
			return default(Vector2);
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x000098A0 File Offset: 0x00007AA0
		[Token(Token = "0x60018F8")]
		[Address(RVA = "0x2025A3C", Offset = "0x2025A3C", VA = "0x2025A3C", Slot = "6")]
		public override bool Contains(Vector2 point)
		{
			return default(bool);
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x000098B8 File Offset: 0x00007AB8
		[Token(Token = "0x60018F9")]
		[Address(RVA = "0x2025A8C", Offset = "0x2025A8C", VA = "0x2025A8C", Slot = "7")]
		public override bool Overlap(Shape other)
		{
			return default(bool);
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x000098D0 File Offset: 0x00007AD0
		[Token(Token = "0x60018FA")]
		[Address(RVA = "0x2025C54", Offset = "0x2025C54", VA = "0x2025C54")]
		private bool OverlapOnAxis(Vector2[] worldCornersA, Vector2[] worldCornersB, Vector2 axis)
		{
			return default(bool);
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018FB")]
		[Address(RVA = "0x2025D78", Offset = "0x2025D78", VA = "0x2025D78", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04001B61 RID: 7009
		[Token(Token = "0x4001B61")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 size;
	}
}
