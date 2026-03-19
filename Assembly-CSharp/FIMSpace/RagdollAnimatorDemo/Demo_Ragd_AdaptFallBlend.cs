using System;
using FIMSpace.FProceduralAnimation;
using Il2CppDummyDll;
using UnityEngine;

namespace FIMSpace.RagdollAnimatorDemo
{
	// Token: 0x02000C1A RID: 3098
	[Token(Token = "0x2000C1A")]
	public class Demo_Ragd_AdaptFallBlend : MonoBehaviour
	{
		// Token: 0x06007671 RID: 30321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007671")]
		[Address(RVA = "0x2EC4904", Offset = "0x2EC4904", VA = "0x2EC4904", Slot = "4")]
		protected virtual void PrepareHashes()
		{
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06007672 RID: 30322 RVA: 0x00052908 File Offset: 0x00050B08
		// (set) Token: 0x06007673 RID: 30323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A65")]
		public float ExtraX
		{
			[Token(Token = "0x6007672")]
			[Address(RVA = "0x2EC49D0", Offset = "0x2EC49D0", VA = "0x2EC49D0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6007673")]
			[Address(RVA = "0x2EC49F4", Offset = "0x2EC49F4", VA = "0x2EC49F4")]
			protected set
			{
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06007674 RID: 30324 RVA: 0x00052920 File Offset: 0x00050B20
		// (set) Token: 0x06007675 RID: 30325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A66")]
		public float ExtraZ
		{
			[Token(Token = "0x6007674")]
			[Address(RVA = "0x2EC4A18", Offset = "0x2EC4A18", VA = "0x2EC4A18")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6007675")]
			[Address(RVA = "0x2EC4A3C", Offset = "0x2EC4A3C", VA = "0x2EC4A3C")]
			protected set
			{
			}
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06007676 RID: 30326 RVA: 0x00052938 File Offset: 0x00050B38
		// (set) Token: 0x06007677 RID: 30327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A67")]
		public float ExtraW
		{
			[Token(Token = "0x6007676")]
			[Address(RVA = "0x2EC4A60", Offset = "0x2EC4A60", VA = "0x2EC4A60")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6007677")]
			[Address(RVA = "0x2EC4A84", Offset = "0x2EC4A84", VA = "0x2EC4A84")]
			protected set
			{
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06007678 RID: 30328 RVA: 0x00052950 File Offset: 0x00050B50
		[Token(Token = "0x17000A68")]
		public bool AnimatorRagdolled
		{
			[Token(Token = "0x6007678")]
			[Address(RVA = "0x2EC4AA8", Offset = "0x2EC4AA8", VA = "0x2EC4AA8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007679 RID: 30329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007679")]
		[Address(RVA = "0x2EC4AEC", Offset = "0x2EC4AEC", VA = "0x2EC4AEC")]
		private void Start()
		{
		}

		// Token: 0x0600767A RID: 30330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600767A")]
		[Address(RVA = "0x2EC4B64", Offset = "0x2EC4B64", VA = "0x2EC4B64")]
		private void Update()
		{
		}

		// Token: 0x0600767B RID: 30331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600767B")]
		[Address(RVA = "0x2EC5C58", Offset = "0x2EC5C58", VA = "0x2EC5C58")]
		private void DoExtraRaycasts(ref float groundAngle)
		{
		}

		// Token: 0x0600767C RID: 30332 RVA: 0x00052968 File Offset: 0x00050B68
		[Token(Token = "0x600767C")]
		[Address(RVA = "0x2EC61D0", Offset = "0x2EC61D0", VA = "0x2EC61D0")]
		private float MaxVeloVal(float magnitude)
		{
			return 0f;
		}

		// Token: 0x17000A69 RID: 2665
		// (set) Token: 0x0600767D RID: 30333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A69")]
		private float SetX
		{
			[Token(Token = "0x600767D")]
			[Address(RVA = "0x2EC60F8", Offset = "0x2EC60F8", VA = "0x2EC60F8")]
			set
			{
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (set) Token: 0x0600767E RID: 30334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A6A")]
		private float SetZ
		{
			[Token(Token = "0x600767E")]
			[Address(RVA = "0x2EC6164", Offset = "0x2EC6164", VA = "0x2EC6164")]
			set
			{
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x0600767F RID: 30335 RVA: 0x00052980 File Offset: 0x00050B80
		[Token(Token = "0x17000A6B")]
		private float GetAdditive
		{
			[Token(Token = "0x600767F")]
			[Address(RVA = "0x2EC56E0", Offset = "0x2EC56E0", VA = "0x2EC56E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000A6C RID: 2668
		// (set) Token: 0x06007680 RID: 30336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A6C")]
		private float SetAdditive
		{
			[Token(Token = "0x6007680")]
			[Address(RVA = "0x2EC5704", Offset = "0x2EC5704", VA = "0x2EC5704")]
			set
			{
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (set) Token: 0x06007681 RID: 30337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A6D")]
		private float SetAdditiveW
		{
			[Token(Token = "0x6007681")]
			[Address(RVA = "0x2EC62B8", Offset = "0x2EC62B8", VA = "0x2EC62B8")]
			set
			{
			}
		}

		// Token: 0x06007682 RID: 30338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007682")]
		[Address(RVA = "0x2EC62DC", Offset = "0x2EC62DC", VA = "0x2EC62DC")]
		public Demo_Ragd_AdaptFallBlend()
		{
		}

		// Token: 0x0400301A RID: 12314
		[Token(Token = "0x400301A")]
		[FieldOffset(Offset = "0x18")]
		public Animator TargetAnimator;

		// Token: 0x0400301B RID: 12315
		[Token(Token = "0x400301B")]
		[FieldOffset(Offset = "0x20")]
		public RagdollAnimator ragd;

		// Token: 0x0400301C RID: 12316
		[Token(Token = "0x400301C")]
		[FieldOffset(Offset = "0x28")]
		public LayerMask GroundMask;

		// Token: 0x0400301D RID: 12317
		[Token(Token = "0x400301D")]
		[FieldOffset(Offset = "0x30")]
		public string AdditiveLayerName;

		// Token: 0x0400301E RID: 12318
		[Token(Token = "0x400301E")]
		[FieldOffset(Offset = "0x38")]
		public bool IsHumanoid;

		// Token: 0x0400301F RID: 12319
		[Token(Token = "0x400301F")]
		[FieldOffset(Offset = "0x3C")]
		private float ragdTime;

		// Token: 0x04003020 RID: 12320
		[Token(Token = "0x4003020")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 safeUpOffset;

		// Token: 0x04003021 RID: 12321
		[Token(Token = "0x4003021")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 lastAppliedImpact;

		// Token: 0x04003022 RID: 12322
		[Token(Token = "0x4003022")]
		[FieldOffset(Offset = "0x58")]
		internal float veloMagn;

		// Token: 0x04003023 RID: 12323
		[Token(Token = "0x4003023")]
		[FieldOffset(Offset = "0x5C")]
		private int _hash_ExtraX;

		// Token: 0x04003024 RID: 12324
		[Token(Token = "0x4003024")]
		[FieldOffset(Offset = "0x60")]
		private int _hash_ExtraZ;

		// Token: 0x04003025 RID: 12325
		[Token(Token = "0x4003025")]
		[FieldOffset(Offset = "0x64")]
		private int _hash_ExtraW;

		// Token: 0x04003026 RID: 12326
		[Token(Token = "0x4003026")]
		[FieldOffset(Offset = "0x68")]
		private int _hash_Ragdolled;

		// Token: 0x04003027 RID: 12327
		[Token(Token = "0x4003027")]
		[FieldOffset(Offset = "0x6C")]
		private int _additiveLayer;

		// Token: 0x04003028 RID: 12328
		[Token(Token = "0x4003028")]
		[FieldOffset(Offset = "0x70")]
		private float smoothDampSpd;

		// Token: 0x04003029 RID: 12329
		[Token(Token = "0x4003029")]
		[FieldOffset(Offset = "0x74")]
		private float sd_extraX;

		// Token: 0x0400302A RID: 12330
		[Token(Token = "0x400302A")]
		[FieldOffset(Offset = "0x78")]
		private float sd_extraZ;

		// Token: 0x0400302B RID: 12331
		[Token(Token = "0x400302B")]
		[FieldOffset(Offset = "0x7C")]
		private float sd_layer;

		// Token: 0x0400302C RID: 12332
		[Token(Token = "0x400302C")]
		[FieldOffset(Offset = "0x80")]
		internal Vector3 localVelo;

		// Token: 0x0400302D RID: 12333
		[Token(Token = "0x400302D")]
		[FieldOffset(Offset = "0x8C")]
		internal RagdollProcessor.EGetUpType backLay;

		// Token: 0x0400302E RID: 12334
		[Token(Token = "0x400302E")]
		[FieldOffset(Offset = "0x90")]
		internal RagdollProcessor.EGetUpType sideLay;
	}
}
