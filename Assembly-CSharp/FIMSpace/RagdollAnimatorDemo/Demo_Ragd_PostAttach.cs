using System;
using System.Collections;
using FIMSpace.FProceduralAnimation;
using Il2CppDummyDll;
using UnityEngine;

namespace FIMSpace.RagdollAnimatorDemo
{
	// Token: 0x02000C24 RID: 3108
	[Token(Token = "0x2000C24")]
	public class Demo_Ragd_PostAttach : MonoBehaviour
	{
		// Token: 0x060076AC RID: 30380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076AC")]
		[Address(RVA = "0x2EC9584", Offset = "0x2EC9584", VA = "0x2EC9584")]
		private void Awake()
		{
		}

		// Token: 0x060076AD RID: 30381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076AD")]
		[Address(RVA = "0x2EC96A0", Offset = "0x2EC96A0", VA = "0x2EC96A0")]
		private void Start()
		{
		}

		// Token: 0x060076AE RID: 30382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076AE")]
		[Address(RVA = "0x2EC96C0", Offset = "0x2EC96C0", VA = "0x2EC96C0")]
		private IEnumerator DelayedStart()
		{
			return null;
		}

		// Token: 0x060076AF RID: 30383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076AF")]
		[Address(RVA = "0x2EC975C", Offset = "0x2EC975C", VA = "0x2EC975C")]
		public Demo_Ragd_PostAttach()
		{
		}

		// Token: 0x04003071 RID: 12401
		[Token(Token = "0x4003071")]
		[FieldOffset(Offset = "0x18")]
		public Joint joint;

		// Token: 0x04003072 RID: 12402
		[Token(Token = "0x4003072")]
		[FieldOffset(Offset = "0x20")]
		public RagdollAnimator ragdoll;

		// Token: 0x04003073 RID: 12403
		[Token(Token = "0x4003073")]
		[FieldOffset(Offset = "0x28")]
		private Transform tr;
	}
}
