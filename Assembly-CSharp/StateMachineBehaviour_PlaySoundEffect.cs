using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000A4 RID: 164
[Token(Token = "0x20000A4")]
public class StateMachineBehaviour_PlaySoundEffect : StateMachineBehaviour
{
	// Token: 0x060003CC RID: 972 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x2F66E70", Offset = "0x2F66E70", VA = "0x2F66E70", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060003CD RID: 973 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x2F66F40", Offset = "0x2F66F40", VA = "0x2F66F40", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060003CE RID: 974 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x2F66EC0", Offset = "0x2F66EC0", VA = "0x2F66EC0")]
	private void PlaySoundEffect(Animator animator)
	{
	}

	// Token: 0x060003CF RID: 975 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x2F6700C", Offset = "0x2F6700C", VA = "0x2F6700C")]
	public StateMachineBehaviour_PlaySoundEffect()
	{
	}

	// Token: 0x04000366 RID: 870
	[Token(Token = "0x4000366")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string _soundPath;

	// Token: 0x04000367 RID: 871
	[Token(Token = "0x4000367")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _volume;

	// Token: 0x04000368 RID: 872
	[Token(Token = "0x4000368")]
	[FieldOffset(Offset = "0x24")]
	private int _loop;
}
