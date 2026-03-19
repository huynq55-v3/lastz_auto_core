using System;
using Il2CppDummyDll;
using UnityEngine;

namespace FIMSpace.Basics
{
	// Token: 0x02000C17 RID: 3095
	[Token(Token = "0x2000C17")]
	[DefaultExecutionOrder(10000)]
	public class Demo_Ragd_UpdateSkinnedBounds : MonoBehaviour
	{
		// Token: 0x06007652 RID: 30290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007652")]
		[Address(RVA = "0x2EC3738", Offset = "0x2EC3738", VA = "0x2EC3738")]
		private void Start()
		{
		}

		// Token: 0x06007653 RID: 30291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007653")]
		[Address(RVA = "0x2EC3914", Offset = "0x2EC3914", VA = "0x2EC3914")]
		private void LateUpdate()
		{
		}

		// Token: 0x06007654 RID: 30292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007654")]
		[Address(RVA = "0x2EC3A40", Offset = "0x2EC3A40", VA = "0x2EC3A40")]
		public Demo_Ragd_UpdateSkinnedBounds()
		{
		}

		// Token: 0x0400300F RID: 12303
		[Token(Token = "0x400300F")]
		[FieldOffset(Offset = "0x18")]
		public SkinnedMeshRenderer skinnedMesh;

		// Token: 0x04003010 RID: 12304
		[Token(Token = "0x4003010")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Some bone of the skinned mesh (try using some child bones of root bone), when left empty then child of skinned mesh root bone is used")]
		public Transform boundsFollows;

		// Token: 0x04003011 RID: 12305
		[Token(Token = "0x4003011")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 off;
	}
}
