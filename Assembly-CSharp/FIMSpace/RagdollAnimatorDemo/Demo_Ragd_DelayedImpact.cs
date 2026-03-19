using System;
using System.Collections;
using FIMSpace.FProceduralAnimation;
using Il2CppDummyDll;
using UnityEngine;

namespace FIMSpace.RagdollAnimatorDemo
{
	// Token: 0x02000C1D RID: 3101
	[Token(Token = "0x2000C1D")]
	public class Demo_Ragd_DelayedImpact : MonoBehaviour
	{
		// Token: 0x06007689 RID: 30345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007689")]
		[Address(RVA = "0x2EC6AC8", Offset = "0x2EC6AC8", VA = "0x2EC6AC8")]
		private void Start()
		{
		}

		// Token: 0x0600768A RID: 30346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600768A")]
		[Address(RVA = "0x2EC6AE8", Offset = "0x2EC6AE8", VA = "0x2EC6AE8")]
		private IEnumerator DelayedImpact()
		{
			return null;
		}

		// Token: 0x0600768B RID: 30347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600768B")]
		[Address(RVA = "0x2EC6B84", Offset = "0x2EC6B84", VA = "0x2EC6B84")]
		public Demo_Ragd_DelayedImpact()
		{
		}

		// Token: 0x04003035 RID: 12341
		[Token(Token = "0x4003035")]
		[FieldOffset(Offset = "0x18")]
		public RagdollAnimator ragdoll;

		// Token: 0x04003036 RID: 12342
		[Token(Token = "0x4003036")]
		[FieldOffset(Offset = "0x20")]
		public float Delay;

		// Token: 0x04003037 RID: 12343
		[Token(Token = "0x4003037")]
		[FieldOffset(Offset = "0x24")]
		public float Power;
	}
}
