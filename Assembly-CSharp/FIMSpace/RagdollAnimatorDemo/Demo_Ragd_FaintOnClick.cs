using System;
using FIMSpace.FProceduralAnimation;
using Il2CppDummyDll;
using UnityEngine;

namespace FIMSpace.RagdollAnimatorDemo
{
	// Token: 0x02000C1F RID: 3103
	[Token(Token = "0x2000C1F")]
	public class Demo_Ragd_FaintOnClick : MonoBehaviour
	{
		// Token: 0x06007692 RID: 30354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007692")]
		[Address(RVA = "0x2EC6DC0", Offset = "0x2EC6DC0", VA = "0x2EC6DC0")]
		private void Update()
		{
		}

		// Token: 0x06007693 RID: 30355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007693")]
		[Address(RVA = "0x2EC6F7C", Offset = "0x2EC6F7C", VA = "0x2EC6F7C")]
		public Demo_Ragd_FaintOnClick()
		{
		}

		// Token: 0x0400303B RID: 12347
		[Token(Token = "0x400303B")]
		[FieldOffset(Offset = "0x18")]
		[Header("If using 'Repose Mode' requires 'Full Ragdoll Only' enabed for seamless transition")]
		public RagdollAnimator ragdoll;
	}
}
