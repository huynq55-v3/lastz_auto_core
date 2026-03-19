using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000038 RID: 56
[Token(Token = "0x2000038")]
public interface ITouchObject
{
	// Token: 0x1700000C RID: 12
	// (get) Token: 0x060000C0 RID: 192
	[Token(Token = "0x1700000C")]
	float Priority
	{
		[Token(Token = "0x60000C0")]
		get;
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x060000C1 RID: 193
	[Token(Token = "0x1700000D")]
	float Distance
	{
		[Token(Token = "0x60000C1")]
		get;
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x060000C2 RID: 194
	[Token(Token = "0x1700000E")]
	Vector2Int TilePos
	{
		[Token(Token = "0x60000C2")]
		get;
	}
}
