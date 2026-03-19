using System;
using Il2CppDummyDll;
using UnityEngine;

namespace FIMSpace.RagdollAnimatorDemo
{
	// Token: 0x02000C23 RID: 3107
	[Token(Token = "0x2000C23")]
	public class Demo_Ragd_Move : MonoBehaviour
	{
		// Token: 0x060076AA RID: 30378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076AA")]
		[Address(RVA = "0x2EC9534", Offset = "0x2EC9534", VA = "0x2EC9534")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060076AB RID: 30379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076AB")]
		[Address(RVA = "0x2EC957C", Offset = "0x2EC957C", VA = "0x2EC957C")]
		public Demo_Ragd_Move()
		{
		}

		// Token: 0x0400306F RID: 12399
		[Token(Token = "0x400306F")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 LocalVelocity;

		// Token: 0x04003070 RID: 12400
		[Token(Token = "0x4003070")]
		[FieldOffset(Offset = "0x28")]
		public Rigidbody rig;
	}
}
