using System;
using FIMSpace.FProceduralAnimation;
using Il2CppDummyDll;
using UnityEngine;

namespace FIMSpace.RagdollAnimatorDemo
{
	// Token: 0x02000C26 RID: 3110
	[Token(Token = "0x2000C26")]
	[DefaultExecutionOrder(-2)]
	public class Demo_Ragd_PushAndGetUp : MonoBehaviour
	{
		// Token: 0x060076B6 RID: 30390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076B6")]
		[Address(RVA = "0x2EC997C", Offset = "0x2EC997C", VA = "0x2EC997C")]
		private void Update()
		{
		}

		// Token: 0x060076B7 RID: 30391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076B7")]
		[Address(RVA = "0x2EC9E9C", Offset = "0x2EC9E9C", VA = "0x2EC9E9C")]
		public void TriggerGetUp()
		{
		}

		// Token: 0x060076B8 RID: 30392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076B8")]
		[Address(RVA = "0x2ECA17C", Offset = "0x2ECA17C", VA = "0x2ECA17C")]
		private void TryPlayGetupAnimation()
		{
		}

		// Token: 0x060076B9 RID: 30393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076B9")]
		[Address(RVA = "0x2ECA2B0", Offset = "0x2ECA2B0", VA = "0x2ECA2B0")]
		public Demo_Ragd_PushAndGetUp()
		{
		}

		// Token: 0x04003077 RID: 12407
		[Token(Token = "0x4003077")]
		[FieldOffset(Offset = "0x18")]
		public RagdollAnimator ragdoll;

		// Token: 0x04003078 RID: 12408
		[Token(Token = "0x4003078")]
		[FieldOffset(Offset = "0x20")]
		public float PowerMul;

		// Token: 0x04003079 RID: 12409
		[Token(Token = "0x4003079")]
		[FieldOffset(Offset = "0x24")]
		[Range(0f, 0.65f)]
		public float ImpactDuration;

		// Token: 0x0400307A RID: 12410
		[Token(Token = "0x400307A")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public float FadeMusclesTo;

		// Token: 0x0400307B RID: 12411
		[Token(Token = "0x400307B")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 1.25f)]
		public float FadeMusclesDuration;

		// Token: 0x0400307C RID: 12412
		[Token(Token = "0x400307C")]
		[FieldOffset(Offset = "0x30")]
		public LayerMask snapToGroundLayer;

		// Token: 0x0400307D RID: 12413
		[Token(Token = "0x400307D")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("After ragdolled and stabilization, wait about second and then triggering get up")]
		public bool AutoGetUp;

		// Token: 0x0400307E RID: 12414
		[Token(Token = "0x400307E")]
		[FieldOffset(Offset = "0x35")]
		public bool GetUpVersion2;

		// Token: 0x0400307F RID: 12415
		[Token(Token = "0x400307F")]
		[FieldOffset(Offset = "0x38")]
		[FPD_Header("Debugging", 6f, 4f, 2)]
		public string TestPlayAnimOnRagdoll;

		// Token: 0x04003080 RID: 12416
		[Token(Token = "0x4003080")]
		[FieldOffset(Offset = "0x40")]
		public RagdollProcessor.EGetUpType CanGetUp;

		// Token: 0x04003081 RID: 12417
		[Token(Token = "0x4003081")]
		[FieldOffset(Offset = "0x44")]
		public Vector3 LimbsVelocity;

		// Token: 0x04003082 RID: 12418
		[Token(Token = "0x4003082")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 LimbsAngularVelocity;

		// Token: 0x04003083 RID: 12419
		[Token(Token = "0x4003083")]
		[FieldOffset(Offset = "0x5C")]
		public float LimbsVelocityMagn;

		// Token: 0x04003084 RID: 12420
		[Token(Token = "0x4003084")]
		[FieldOffset(Offset = "0x60")]
		private float LimbsAngularVelocityMagn;

		// Token: 0x04003085 RID: 12421
		[Token(Token = "0x4003085")]
		[FieldOffset(Offset = "0x64")]
		private float toGetUpElapsed;
	}
}
