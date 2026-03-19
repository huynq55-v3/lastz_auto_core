using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200036C RID: 876
[Token(Token = "0x200036C")]
public class MeteoriteCollider : MonoBehaviour
{
	// Token: 0x06001669 RID: 5737 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001669")]
	[Address(RVA = "0x1EDF148", Offset = "0x1EDF148", VA = "0x1EDF148")]
	private void OnEnable()
	{
	}

	// Token: 0x0600166A RID: 5738 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600166A")]
	[Address(RVA = "0x1EDF1A4", Offset = "0x1EDF1A4", VA = "0x1EDF1A4")]
	private void OnDisable()
	{
	}

	// Token: 0x0600166B RID: 5739 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600166B")]
	[Address(RVA = "0x1EDF268", Offset = "0x1EDF268", VA = "0x1EDF268")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x0600166C RID: 5740 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600166C")]
	[Address(RVA = "0x1EDF470", Offset = "0x1EDF470", VA = "0x1EDF470")]
	public MeteoriteCollider()
	{
	}

	// Token: 0x04001997 RID: 6551
	[Token(Token = "0x4001997")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform _effect;

	// Token: 0x04001998 RID: 6552
	[Token(Token = "0x4001998")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Animator _anim;

	// Token: 0x04001999 RID: 6553
	[Token(Token = "0x4001999")]
	[FieldOffset(Offset = "0x28")]
	private ITimer hideTimer;

	// Token: 0x0400199A RID: 6554
	[Token(Token = "0x400199A")]
	[FieldOffset(Offset = "0x0")]
	private static float hideTime;
}
