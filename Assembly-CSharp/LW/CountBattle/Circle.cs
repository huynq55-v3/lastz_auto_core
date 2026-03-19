using System;
using Il2CppDummyDll;
using UnityEngine;

namespace LW.CountBattle
{
	// Token: 0x020003DB RID: 987
	[Token(Token = "0x20003DB")]
	public class Circle : Shape
	{
		// Token: 0x060018EB RID: 6379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018EB")]
		[Address(RVA = "0x20253AC", Offset = "0x20253AC", VA = "0x20253AC")]
		public Circle(Vector2 pos, float angle, float radius)
		{
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x00009810 File Offset: 0x00007A10
		[Token(Token = "0x60018EC")]
		[Address(RVA = "0x20253EC", Offset = "0x20253EC", VA = "0x20253EC", Slot = "4")]
		public override Vector2 World2Local(Vector2 worldPoint)
		{
			return default(Vector2);
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x00009828 File Offset: 0x00007A28
		[Token(Token = "0x60018ED")]
		[Address(RVA = "0x20253FC", Offset = "0x20253FC", VA = "0x20253FC", Slot = "5")]
		public override Vector2 Local2World(Vector2 localPoint)
		{
			return default(Vector2);
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x00009840 File Offset: 0x00007A40
		[Token(Token = "0x60018EE")]
		[Address(RVA = "0x202540C", Offset = "0x202540C", VA = "0x202540C", Slot = "6")]
		public override bool Contains(Vector2 point)
		{
			return default(bool);
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x00009858 File Offset: 0x00007A58
		[Token(Token = "0x60018EF")]
		[Address(RVA = "0x2025438", Offset = "0x2025438", VA = "0x2025438", Slot = "7")]
		public override bool Overlap(Shape other)
		{
			return default(bool);
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018F0")]
		[Address(RVA = "0x2025564", Offset = "0x2025564", VA = "0x2025564", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04001B60 RID: 7008
		[Token(Token = "0x4001B60")]
		[FieldOffset(Offset = "0x1C")]
		public float radius;
	}
}
