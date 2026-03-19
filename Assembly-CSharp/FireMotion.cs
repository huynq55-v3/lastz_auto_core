using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200001E RID: 30
[Token(Token = "0x200001E")]
public class FireMotion : MonoBehaviour
{
	// Token: 0x06000050 RID: 80 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000050")]
	[Address(RVA = "0x15E3B54", Offset = "0x15E3B54", VA = "0x15E3B54")]
	private void Start()
	{
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000051")]
	[Address(RVA = "0x15E3BA4", Offset = "0x15E3BA4", VA = "0x15E3BA4")]
	private void Update()
	{
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000052")]
	[Address(RVA = "0x15E3D88", Offset = "0x15E3D88", VA = "0x15E3D88")]
	public FireMotion()
	{
	}

	// Token: 0x040000A4 RID: 164
	[Token(Token = "0x40000A4")]
	[FieldOffset(Offset = "0x18")]
	public Material material;

	// Token: 0x040000A5 RID: 165
	[Token(Token = "0x40000A5")]
	[FieldOffset(Offset = "0x20")]
	public float revelspeed;

	// Token: 0x040000A6 RID: 166
	[Token(Token = "0x40000A6")]
	[FieldOffset(Offset = "0x24")]
	public float SafeDistance;

	// Token: 0x040000A7 RID: 167
	[Token(Token = "0x40000A7")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 prePos;

	// Token: 0x040000A8 RID: 168
	[Token(Token = "0x40000A8")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 curPos;
}
