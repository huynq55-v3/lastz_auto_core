using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200028E RID: 654
[Token(Token = "0x200028E")]
[Serializable]
public struct LevelScaleParam
{
	// Token: 0x0400140D RID: 5133
	[Token(Token = "0x400140D")]
	[FieldOffset(Offset = "0x0")]
	public int levelId;

	// Token: 0x0400140E RID: 5134
	[Token(Token = "0x400140E")]
	[FieldOffset(Offset = "0x4")]
	public Vector2 ZoomRange;

	// Token: 0x0400140F RID: 5135
	[Token(Token = "0x400140F")]
	[FieldOffset(Offset = "0xC")]
	public Vector2 ScaleRange;
}
