using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000322 RID: 802
[Token(Token = "0x2000322")]
public class AutoMirrorPositionData
{
	// Token: 0x0600152A RID: 5418 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600152A")]
	[Address(RVA = "0x1992878", Offset = "0x1992878", VA = "0x1992878")]
	public AutoMirrorPositionData(GameObject gameObject)
	{
	}

	// Token: 0x0400182B RID: 6187
	[Token(Token = "0x400182B")]
	[FieldOffset(Offset = "0x10")]
	public int uid;

	// Token: 0x0400182C RID: 6188
	[Token(Token = "0x400182C")]
	[FieldOffset(Offset = "0x14")]
	public float width;

	// Token: 0x0400182D RID: 6189
	[Token(Token = "0x400182D")]
	[FieldOffset(Offset = "0x18")]
	public float height;

	// Token: 0x0400182E RID: 6190
	[Token(Token = "0x400182E")]
	[FieldOffset(Offset = "0x1C")]
	public Vector3 localPosition;

	// Token: 0x0400182F RID: 6191
	[Token(Token = "0x400182F")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 position;

	// Token: 0x04001830 RID: 6192
	[Token(Token = "0x4001830")]
	[FieldOffset(Offset = "0x34")]
	public Vector2 pivot;

	// Token: 0x04001831 RID: 6193
	[Token(Token = "0x4001831")]
	[FieldOffset(Offset = "0x3C")]
	public Quaternion localRotation;

	// Token: 0x04001832 RID: 6194
	[Token(Token = "0x4001832")]
	[FieldOffset(Offset = "0x50")]
	public string name;

	// Token: 0x04001833 RID: 6195
	[Token(Token = "0x4001833")]
	[FieldOffset(Offset = "0x58")]
	public Vector3 lossyScale;

	// Token: 0x04001834 RID: 6196
	[Token(Token = "0x4001834")]
	[FieldOffset(Offset = "0x64")]
	public Rect rect;

	// Token: 0x04001835 RID: 6197
	[Token(Token = "0x4001835")]
	[FieldOffset(Offset = "0x78")]
	public RectTransform parent;
}
