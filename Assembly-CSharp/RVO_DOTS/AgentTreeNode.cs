using System;
using Il2CppDummyDll;
using Unity.Burst;

namespace RVO_DOTS
{
	// Token: 0x020003BE RID: 958
	[Token(Token = "0x20003BE")]
	[BurstCompile]
	public struct AgentTreeNode
	{
		// Token: 0x04001AC8 RID: 6856
		[Token(Token = "0x4001AC8")]
		[FieldOffset(Offset = "0x0")]
		public int begin_;

		// Token: 0x04001AC9 RID: 6857
		[Token(Token = "0x4001AC9")]
		[FieldOffset(Offset = "0x4")]
		public int end_;

		// Token: 0x04001ACA RID: 6858
		[Token(Token = "0x4001ACA")]
		[FieldOffset(Offset = "0x8")]
		public int left_;

		// Token: 0x04001ACB RID: 6859
		[Token(Token = "0x4001ACB")]
		[FieldOffset(Offset = "0xC")]
		public int right_;

		// Token: 0x04001ACC RID: 6860
		[Token(Token = "0x4001ACC")]
		[FieldOffset(Offset = "0x10")]
		public float maxX_;

		// Token: 0x04001ACD RID: 6861
		[Token(Token = "0x4001ACD")]
		[FieldOffset(Offset = "0x14")]
		public float maxY_;

		// Token: 0x04001ACE RID: 6862
		[Token(Token = "0x4001ACE")]
		[FieldOffset(Offset = "0x18")]
		public float minX_;

		// Token: 0x04001ACF RID: 6863
		[Token(Token = "0x4001ACF")]
		[FieldOffset(Offset = "0x1C")]
		public float minY_;
	}
}
