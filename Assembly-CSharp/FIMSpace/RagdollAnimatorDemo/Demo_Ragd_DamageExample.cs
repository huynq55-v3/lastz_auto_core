using System;
using FIMSpace.FProceduralAnimation;
using Il2CppDummyDll;
using UnityEngine;

namespace FIMSpace.RagdollAnimatorDemo
{
	// Token: 0x02000C1C RID: 3100
	[Token(Token = "0x2000C1C")]
	public class Demo_Ragd_DamageExample : MonoBehaviour, RagdollProcessor.IRagdollAnimatorReceiver
	{
		// Token: 0x06007686 RID: 30342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007686")]
		[Address(RVA = "0x2EC6484", Offset = "0x2EC6484", VA = "0x2EC6484", Slot = "5")]
		public void RagdAnim_OnCollisionEnterEvent(RagdollCollisionHelper c)
		{
		}

		// Token: 0x06007687 RID: 30343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007687")]
		[Address(RVA = "0x2EC6AA4", Offset = "0x2EC6AA4", VA = "0x2EC6AA4", Slot = "4")]
		public void RagdAnim_OnCollisionExitEvent(RagdollCollisionHelper c)
		{
		}

		// Token: 0x06007688 RID: 30344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007688")]
		[Address(RVA = "0x2EC6AA8", Offset = "0x2EC6AA8", VA = "0x2EC6AA8")]
		public Demo_Ragd_DamageExample()
		{
		}

		// Token: 0x04003032 RID: 12338
		[Token(Token = "0x4003032")]
		[FieldOffset(Offset = "0x18")]
		public float ImpactPower;

		// Token: 0x04003033 RID: 12339
		[Token(Token = "0x4003033")]
		[FieldOffset(Offset = "0x1C")]
		public float FallAtPower;

		// Token: 0x04003034 RID: 12340
		[Token(Token = "0x4003034")]
		[FieldOffset(Offset = "0x20")]
		public float DismemberAtPower;
	}
}
