using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200007F RID: 127
[Token(Token = "0x200007F")]
public class AutoDestroy : MonoBehaviour
{
	// Token: 0x0600030E RID: 782 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600030E")]
	[Address(RVA = "0x3210328", Offset = "0x3210328", VA = "0x3210328")]
	private void OnEnable()
	{
	}

	// Token: 0x0600030F RID: 783 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600030F")]
	[Address(RVA = "0x3210330", Offset = "0x3210330", VA = "0x3210330")]
	private void Update()
	{
	}

	// Token: 0x06000310 RID: 784 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000310")]
	[Address(RVA = "0x3210448", Offset = "0x3210448", VA = "0x3210448")]
	public AutoDestroy()
	{
	}

	// Token: 0x04000297 RID: 663
	[Token(Token = "0x4000297")]
	[FieldOffset(Offset = "0x18")]
	public float time;

	// Token: 0x04000298 RID: 664
	[Token(Token = "0x4000298")]
	[FieldOffset(Offset = "0x20")]
	public InstanceRequest handle;

	// Token: 0x04000299 RID: 665
	[Token(Token = "0x4000299")]
	[FieldOffset(Offset = "0x28")]
	public bool realDestroy;

	// Token: 0x0400029A RID: 666
	[Token(Token = "0x400029A")]
	[FieldOffset(Offset = "0x29")]
	public bool removeSelf;

	// Token: 0x0400029B RID: 667
	[Token(Token = "0x400029B")]
	[FieldOffset(Offset = "0x2C")]
	private float _timer;
}
