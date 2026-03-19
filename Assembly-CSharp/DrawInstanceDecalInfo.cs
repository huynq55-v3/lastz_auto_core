using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200001C RID: 28
[Token(Token = "0x200001C")]
[Serializable]
public class DrawInstanceDecalInfo
{
	// Token: 0x06000043 RID: 67 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000043")]
	[Address(RVA = "0x15E2AC0", Offset = "0x15E2AC0", VA = "0x15E2AC0")]
	public DrawInstanceDecalInfo()
	{
	}

	// Token: 0x04000089 RID: 137
	[Token(Token = "0x4000089")]
	[FieldOffset(Offset = "0x10")]
	public Material mat;

	// Token: 0x0400008A RID: 138
	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 position;

	// Token: 0x0400008B RID: 139
	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 rotation;

	// Token: 0x0400008C RID: 140
	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 scale;

	// Token: 0x0400008D RID: 141
	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x3C")]
	public float radius;

	// Token: 0x0400008E RID: 142
	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x40")]
	[NonSerialized]
	public Matrix4x4 matrix;

	// Token: 0x0400008F RID: 143
	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x80")]
	[NonSerialized]
	public Bounds bounds;
}
