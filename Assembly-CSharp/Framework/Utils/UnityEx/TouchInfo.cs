using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Framework.Utils.UnityEx
{
	// Token: 0x020003D7 RID: 983
	[Token(Token = "0x20003D7")]
	[GCOptimize(OptimizeFlag.Default)]
	[LuaCallCSharp(GenFlag.No)]
	public struct TouchInfo
	{
		// Token: 0x060018D2 RID: 6354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018D2")]
		[Address(RVA = "0x2024180", Offset = "0x2024180", VA = "0x2024180")]
		public TouchInfo(int pointerId, Vector2 pointerPos, Vector2 deltaPos)
		{
		}

		// Token: 0x04001B54 RID: 6996
		[Token(Token = "0x4001B54")]
		[FieldOffset(Offset = "0x0")]
		public int pointerId;

		// Token: 0x04001B55 RID: 6997
		[Token(Token = "0x4001B55")]
		[FieldOffset(Offset = "0x4")]
		public Vector2 pointerPos;

		// Token: 0x04001B56 RID: 6998
		[Token(Token = "0x4001B56")]
		[FieldOffset(Offset = "0xC")]
		public Vector2 deltaPos;
	}
}
