using System;
using FIMSpace.FProceduralAnimation;
using Il2CppDummyDll;
using UnityEngine;

namespace FIMSpace.RagdollAnimatorDemo
{
	// Token: 0x02000C22 RID: 3106
	[Token(Token = "0x2000C22")]
	public class Demo_Ragd_GoToRagdollCenter : MonoBehaviour
	{
		// Token: 0x060076A8 RID: 30376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076A8")]
		[Address(RVA = "0x2EC9328", Offset = "0x2EC9328", VA = "0x2EC9328")]
		private void LateUpdate()
		{
		}

		// Token: 0x060076A9 RID: 30377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076A9")]
		[Address(RVA = "0x2EC9524", Offset = "0x2EC9524", VA = "0x2EC9524")]
		public Demo_Ragd_GoToRagdollCenter()
		{
		}

		// Token: 0x0400306C RID: 12396
		[Token(Token = "0x400306C")]
		[FieldOffset(Offset = "0x18")]
		public RagdollAnimator Ragdoll;

		// Token: 0x0400306D RID: 12397
		[Token(Token = "0x400306D")]
		[FieldOffset(Offset = "0x20")]
		public float HeightOffset;

		// Token: 0x0400306E RID: 12398
		[Token(Token = "0x400306E")]
		[FieldOffset(Offset = "0x24")]
		public bool FollowRotation;
	}
}
