using System;
using FIMSpace.FProceduralAnimation;
using Il2CppDummyDll;
using UnityEngine;

namespace FIMSpace.Basics
{
	// Token: 0x02000C16 RID: 3094
	[Token(Token = "0x2000C16")]
	public class Demo_Ragd_BlendLegsOnHit : MonoBehaviour, RagdollProcessor.IRagdollAnimatorReceiver
	{
		// Token: 0x0600764E RID: 30286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600764E")]
		[Address(RVA = "0x2EC3564", Offset = "0x2EC3564", VA = "0x2EC3564")]
		private void Update()
		{
		}

		// Token: 0x0600764F RID: 30287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600764F")]
		[Address(RVA = "0x2EC3654", Offset = "0x2EC3654", VA = "0x2EC3654", Slot = "5")]
		public void RagdAnim_OnCollisionEnterEvent(RagdollCollisionHelper c)
		{
		}

		// Token: 0x06007650 RID: 30288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007650")]
		[Address(RVA = "0x2EC36D0", Offset = "0x2EC36D0", VA = "0x2EC36D0", Slot = "4")]
		public void RagdAnim_OnCollisionExitEvent(RagdollCollisionHelper c)
		{
		}

		// Token: 0x06007651 RID: 30289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007651")]
		[Address(RVA = "0x2EC36D4", Offset = "0x2EC36D4", VA = "0x2EC36D4")]
		public Demo_Ragd_BlendLegsOnHit()
		{
		}

		// Token: 0x0400300B RID: 12299
		[Token(Token = "0x400300B")]
		[FieldOffset(Offset = "0x18")]
		public string TriggerBlendOnTagged;

		// Token: 0x0400300C RID: 12300
		[Token(Token = "0x400300C")]
		[FieldOffset(Offset = "0x20")]
		public float RestoreCulldown;

		// Token: 0x0400300D RID: 12301
		[Token(Token = "0x400300D")]
		[FieldOffset(Offset = "0x28")]
		private RagdollAnimator ragdoll;

		// Token: 0x0400300E RID: 12302
		[Token(Token = "0x400300E")]
		[FieldOffset(Offset = "0x30")]
		private float blendInTimer;
	}
}
