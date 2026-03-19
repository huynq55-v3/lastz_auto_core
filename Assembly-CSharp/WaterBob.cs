using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000B6 RID: 182
[Token(Token = "0x20000B6")]
public class WaterBob : MonoBehaviour
{
	// Token: 0x06000430 RID: 1072 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000430")]
	[Address(RVA = "0x2F6B4FC", Offset = "0x2F6B4FC", VA = "0x2F6B4FC")]
	private void Awake()
	{
	}

	// Token: 0x06000431 RID: 1073 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000431")]
	[Address(RVA = "0x2F6B560", Offset = "0x2F6B560", VA = "0x2F6B560")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000432 RID: 1074 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000432")]
	[Address(RVA = "0x2F6B618", Offset = "0x2F6B618", VA = "0x2F6B618")]
	public WaterBob()
	{
	}

	// Token: 0x040003E7 RID: 999
	[Token(Token = "0x40003E7")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float height;

	// Token: 0x040003E8 RID: 1000
	[Token(Token = "0x40003E8")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float period;

	// Token: 0x040003E9 RID: 1001
	[Token(Token = "0x40003E9")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 initialPosition;

	// Token: 0x040003EA RID: 1002
	[Token(Token = "0x40003EA")]
	[FieldOffset(Offset = "0x2C")]
	private float offset;

	// Token: 0x040003EB RID: 1003
	[Token(Token = "0x40003EB")]
	[FieldOffset(Offset = "0x30")]
	private Transform tran;
}
