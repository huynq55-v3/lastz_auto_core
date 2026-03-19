using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000321 RID: 801
[Token(Token = "0x2000321")]
[Serializable]
public class MirrorPositionData
{
	// Token: 0x06001529 RID: 5417 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001529")]
	[Address(RVA = "0x1992790", Offset = "0x1992790", VA = "0x1992790")]
	public MirrorPositionData(GameObject gameObject)
	{
	}

	// Token: 0x04001825 RID: 6181
	[Token(Token = "0x4001825")]
	[FieldOffset(Offset = "0x10")]
	public Vector2 anchoredPosition;

	// Token: 0x04001826 RID: 6182
	[Token(Token = "0x4001826")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 anchorMin;

	// Token: 0x04001827 RID: 6183
	[Token(Token = "0x4001827")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 anchorMax;

	// Token: 0x04001828 RID: 6184
	[Token(Token = "0x4001828")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 pivot;

	// Token: 0x04001829 RID: 6185
	[Token(Token = "0x4001829")]
	[FieldOffset(Offset = "0x30")]
	public Quaternion localRotation;

	// Token: 0x0400182A RID: 6186
	[Token(Token = "0x400182A")]
	[FieldOffset(Offset = "0x40")]
	public Vector3 localScale;
}
