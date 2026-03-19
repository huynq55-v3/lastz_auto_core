using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace FIMSpace.FProceduralAnimation
{
	// Token: 0x02000C59 RID: 3161
	[Token(Token = "0x2000C59")]
	public class Demo_Ragd_BonesPoseRotator : MonoBehaviour
	{
		// Token: 0x060078B1 RID: 30897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078B1")]
		[Address(RVA = "0x1577D6C", Offset = "0x1577D6C", VA = "0x1577D6C")]
		private void Start()
		{
		}

		// Token: 0x060078B2 RID: 30898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078B2")]
		[Address(RVA = "0x1577F94", Offset = "0x1577F94", VA = "0x1577F94")]
		private void Update()
		{
		}

		// Token: 0x060078B3 RID: 30899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078B3")]
		[Address(RVA = "0x15783A0", Offset = "0x15783A0", VA = "0x15783A0")]
		public Demo_Ragd_BonesPoseRotator()
		{
		}

		// Token: 0x0400328F RID: 12943
		[Token(Token = "0x400328F")]
		[FieldOffset(Offset = "0x18")]
		public RagdollAnimator Ragdoll;

		// Token: 0x04003290 RID: 12944
		[Token(Token = "0x4003290")]
		[FieldOffset(Offset = "0x20")]
		[Space(2f)]
		public LayerMask RaycastMask;

		// Token: 0x04003291 RID: 12945
		[Token(Token = "0x4003291")]
		[FieldOffset(Offset = "0x24")]
		[Space(5f)]
		public float RotationSensitivty;

		// Token: 0x04003292 RID: 12946
		[Token(Token = "0x4003292")]
		[FieldOffset(Offset = "0x28")]
		[Space(2f)]
		[Tooltip("Limiting controlled rotation accordingly to the joints limits")]
		public bool LimitRotation;

		// Token: 0x04003293 RID: 12947
		[Token(Token = "0x4003293")]
		[FieldOffset(Offset = "0x30")]
		[Space(5f)]
		public List<Demo_Ragd_BonesPoseRotator.BoneController> BoneControl;

		// Token: 0x04003294 RID: 12948
		[Token(Token = "0x4003294")]
		[FieldOffset(Offset = "0x38")]
		private Demo_Ragd_BonesPoseRotator.BoneController isPressed;

		// Token: 0x02000C5A RID: 3162
		[Token(Token = "0x2000C5A")]
		[Serializable]
		public class BoneController
		{
			// Token: 0x060078B4 RID: 30900 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078B4")]
			[Address(RVA = "0x1577DF8", Offset = "0x1577DF8", VA = "0x1577DF8")]
			public void Init(RagdollAnimator ragdoll)
			{
			}

			// Token: 0x060078B5 RID: 30901 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078B5")]
			[Address(RVA = "0x157825C", Offset = "0x157825C", VA = "0x157825C")]
			public void Update(bool limit)
			{
			}

			// Token: 0x060078B6 RID: 30902 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078B6")]
			[Address(RVA = "0x15783B8", Offset = "0x15783B8", VA = "0x15783B8")]
			public BoneController()
			{
			}

			// Token: 0x04003295 RID: 12949
			[Token(Token = "0x4003295")]
			[FieldOffset(Offset = "0x10")]
			public Transform bone;

			// Token: 0x04003296 RID: 12950
			[Token(Token = "0x4003296")]
			[FieldOffset(Offset = "0x18")]
			[Tooltip("Depending on local rotation in skeleton, adjust manually")]
			public Vector3 RotationAxis;

			// Token: 0x04003297 RID: 12951
			[Token(Token = "0x4003297")]
			[FieldOffset(Offset = "0x24")]
			[Tooltip("It depends on the ragdoll setup which limits are correct to the bone, test it manually and find correct ones")]
			public Demo_Ragd_BonesPoseRotator.BoneController.ELimit LimitGuide;

			// Token: 0x04003298 RID: 12952
			[Token(Token = "0x4003298")]
			[FieldOffset(Offset = "0x28")]
			[NonSerialized]
			public float Rotated;

			// Token: 0x04003299 RID: 12953
			[Token(Token = "0x4003299")]
			[FieldOffset(Offset = "0x2C")]
			private Quaternion initialLocalRotation;

			// Token: 0x0400329A RID: 12954
			[Token(Token = "0x400329A")]
			[FieldOffset(Offset = "0x3C")]
			private Vector3 limits;

			// Token: 0x0400329B RID: 12955
			[Token(Token = "0x400329B")]
			[FieldOffset(Offset = "0x48")]
			private float highXLimit;

			// Token: 0x02000C5B RID: 3163
			[Token(Token = "0x2000C5B")]
			public enum ELimit
			{
				// Token: 0x0400329D RID: 12957
				[Token(Token = "0x400329D")]
				None,
				// Token: 0x0400329E RID: 12958
				[Token(Token = "0x400329E")]
				XLimits,
				// Token: 0x0400329F RID: 12959
				[Token(Token = "0x400329F")]
				YLimits,
				// Token: 0x040032A0 RID: 12960
				[Token(Token = "0x40032A0")]
				ZLimits
			}
		}
	}
}
