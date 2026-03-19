using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000292 RID: 658
[Token(Token = "0x2000292")]
[Serializable]
public class Item
{
	// Token: 0x06001159 RID: 4441 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001159")]
	[Address(RVA = "0x1C4FD58", Offset = "0x1C4FD58", VA = "0x1C4FD58")]
	public Item()
	{
	}

	// Token: 0x04001423 RID: 5155
	[Token(Token = "0x4001423")]
	[FieldOffset(Offset = "0x10")]
	public GameObject objHandler;

	// Token: 0x04001424 RID: 5156
	[Token(Token = "0x4001424")]
	[FieldOffset(Offset = "0x18")]
	public float minZoom;

	// Token: 0x04001425 RID: 5157
	[Token(Token = "0x4001425")]
	[FieldOffset(Offset = "0x1C")]
	public float maxZoom;

	// Token: 0x04001426 RID: 5158
	[Token(Token = "0x4001426")]
	[FieldOffset(Offset = "0x20")]
	public string prefabPath;
}
