using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace FIMSpace.FProceduralAnimation
{
	// Token: 0x02000C56 RID: 3158
	[Token(Token = "0x2000C56")]
	[AddComponentMenu("FImpossible Creations/Ragdoll Dummy Post Attach")]
	public class RagdollDummy_PostAttach : MonoBehaviour
	{
		// Token: 0x06007893 RID: 30867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007893")]
		[Address(RVA = "0x15777C0", Offset = "0x15777C0", VA = "0x15777C0")]
		private void Reset()
		{
		}

		// Token: 0x06007894 RID: 30868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007894")]
		[Address(RVA = "0x1577818", Offset = "0x1577818", VA = "0x1577818")]
		private void Awake()
		{
		}

		// Token: 0x06007895 RID: 30869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007895")]
		[Address(RVA = "0x1577934", Offset = "0x1577934", VA = "0x1577934")]
		private void Start()
		{
		}

		// Token: 0x06007896 RID: 30870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007896")]
		[Address(RVA = "0x1577A64", Offset = "0x1577A64", VA = "0x1577A64")]
		private IEnumerator DelayedStart()
		{
			return null;
		}

		// Token: 0x06007897 RID: 30871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007897")]
		[Address(RVA = "0x1577B00", Offset = "0x1577B00", VA = "0x1577B00")]
		public RagdollDummy_PostAttach()
		{
		}

		// Token: 0x04003282 RID: 12930
		[Token(Token = "0x4003282")]
		[FieldOffset(Offset = "0x18")]
		public Joint joint;

		// Token: 0x04003283 RID: 12931
		[Token(Token = "0x4003283")]
		[FieldOffset(Offset = "0x20")]
		public RagdollAnimator ragdoll;

		// Token: 0x04003284 RID: 12932
		[Token(Token = "0x4003284")]
		[FieldOffset(Offset = "0x28")]
		private Transform tr;
	}
}
