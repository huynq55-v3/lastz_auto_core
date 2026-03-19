using System;
using Il2CppDummyDll;

namespace LW.CountBattle
{
	// Token: 0x020003D9 RID: 985
	[Token(Token = "0x20003D9")]
	public class SteerCollider
	{
		// Token: 0x060018E2 RID: 6370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018E2")]
		[Address(RVA = "0x2025314", Offset = "0x2025314", VA = "0x2025314")]
		public SteerCollider(int id, Shape shape)
		{
		}

		// Token: 0x04001B5C RID: 7004
		[Token(Token = "0x4001B5C")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x04001B5D RID: 7005
		[Token(Token = "0x4001B5D")]
		[FieldOffset(Offset = "0x18")]
		public Shape shape;
	}
}
