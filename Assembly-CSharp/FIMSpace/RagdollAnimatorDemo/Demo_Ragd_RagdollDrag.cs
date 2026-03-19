using System;
using System.Collections;
using System.Runtime.InteropServices;
using FIMSpace.FProceduralAnimation;
using Il2CppDummyDll;
using UnityEngine;

namespace FIMSpace.RagdollAnimatorDemo
{
	// Token: 0x02000C27 RID: 3111
	[Token(Token = "0x2000C27")]
	public class Demo_Ragd_RagdollDrag : MonoBehaviour
	{
		// Token: 0x060076BA RID: 30394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076BA")]
		[Address(RVA = "0x2ECA32C", Offset = "0x2ECA32C", VA = "0x2ECA32C")]
		private IEnumerator Start()
		{
			return null;
		}

		// Token: 0x060076BB RID: 30395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076BB")]
		[Address(RVA = "0x2ECA3C8", Offset = "0x2ECA3C8", VA = "0x2ECA3C8")]
		private void Update()
		{
		}

		// Token: 0x060076BC RID: 30396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076BC")]
		[Address(RVA = "0x2ECA5D0", Offset = "0x2ECA5D0", VA = "0x2ECA5D0")]
		private void ComputeGetUp()
		{
		}

		// Token: 0x060076BD RID: 30397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076BD")]
		[Address(RVA = "0x2ECA4C8", Offset = "0x2ECA4C8", VA = "0x2ECA4C8")]
		private void ComputeAnimate()
		{
		}

		// Token: 0x060076BE RID: 30398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076BE")]
		[Address(RVA = "0x2ECA96C", Offset = "0x2ECA96C", VA = "0x2ECA96C")]
		public Demo_Ragd_RagdollDrag()
		{
		}

		// Token: 0x04003086 RID: 12422
		[Token(Token = "0x4003086")]
		[FieldOffset(Offset = "0x18")]
		public RagdollAnimator toDrag;

		// Token: 0x04003087 RID: 12423
		[Token(Token = "0x4003087")]
		[FieldOffset(Offset = "0x20")]
		public float DragPower;

		// Token: 0x04003088 RID: 12424
		[Token(Token = "0x4003088")]
		[FieldOffset(Offset = "0x24")]
		[Space(4f)]
		public bool ChangeMusclesPower;

		// Token: 0x04003089 RID: 12425
		[Token(Token = "0x4003089")]
		[FieldOffset(Offset = "0x25")]
		[Tooltip("Most universal is Bottom Center mode")]
		[Header("Switch Repose Mode in RagdollAnim")]
		public bool AutoGetUp;

		// Token: 0x0400308A RID: 12426
		[Token(Token = "0x400308A")]
		[FieldOffset(Offset = "0x28")]
		public LayerMask GroundMaskForGetup;

		// Token: 0x0400308B RID: 12427
		[Token(Token = "0x400308B")]
		[FieldOffset(Offset = "0x2C")]
		public bool Animate;

		// Token: 0x0400308C RID: 12428
		[Token(Token = "0x400308C")]
		[FieldOffset(Offset = "0x30")]
		private float toGetUpElapsed;

		// Token: 0x0400308D RID: 12429
		[Token(Token = "0x400308D")]
		[FieldOffset(Offset = "0x34")]
		private float initialMuscles;

		// Token: 0x0400308E RID: 12430
		[Token(Token = "0x400308E")]
		[FieldOffset(Offset = "0x38")]
		private bool dragging;

		// Token: 0x02000C28 RID: 3112
		[Token(Token = "0x2000C28")]
		private class Dragger : MonoBehaviour
		{
			// Token: 0x060076BF RID: 30399 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60076BF")]
			[Address(RVA = "0x2ECA98C", Offset = "0x2ECA98C", VA = "0x2ECA98C")]
			internal void Initialize(Demo_Ragd_RagdollDrag ragdollCatchDrag, RagdollProcessor.PosingBone ragdollBone)
			{
			}

			// Token: 0x060076C0 RID: 30400 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60076C0")]
			[Address(RVA = "0x2ECA9D8", Offset = "0x2ECA9D8", VA = "0x2ECA9D8")]
			private void FixedUpdate()
			{
			}

			// Token: 0x060076C1 RID: 30401 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60076C1")]
			[Address(RVA = "0x2ECACD0", Offset = "0x2ECACD0", VA = "0x2ECACD0")]
			private void OnMouseDrag()
			{
			}

			// Token: 0x060076C2 RID: 30402 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60076C2")]
			[Address(RVA = "0x2ECADE0", Offset = "0x2ECADE0", VA = "0x2ECADE0")]
			private void StartDrag(RaycastHit hit)
			{
			}

			// Token: 0x060076C3 RID: 30403 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60076C3")]
			[Address(RVA = "0x2ECACB0", Offset = "0x2ECACB0", VA = "0x2ECACB0")]
			private void EndDragging()
			{
			}

			// Token: 0x060076C4 RID: 30404 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60076C4")]
			[Address(RVA = "0x2ECAB38", Offset = "0x2ECAB38", VA = "0x2ECAB38")]
			private void DragRigidbodyTo(Vector3 wPos, Rigidbody rig, float power, [Optional] Vector3? rigLocalPos)
			{
			}

			// Token: 0x060076C5 RID: 30405 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60076C5")]
			[Address(RVA = "0x2ECAF14", Offset = "0x2ECAF14", VA = "0x2ECAF14")]
			public Dragger()
			{
			}

			// Token: 0x0400308F RID: 12431
			[Token(Token = "0x400308F")]
			[FieldOffset(Offset = "0x18")]
			public Demo_Ragd_RagdollDrag Parent;

			// Token: 0x04003090 RID: 12432
			[Token(Token = "0x4003090")]
			[FieldOffset(Offset = "0x20")]
			public RagdollAnimator toDrag;

			// Token: 0x04003091 RID: 12433
			[Token(Token = "0x4003091")]
			[FieldOffset(Offset = "0x28")]
			private RagdollProcessor.PosingBone bone;

			// Token: 0x04003092 RID: 12434
			[Token(Token = "0x4003092")]
			[FieldOffset(Offset = "0x30")]
			private bool wasDragging;

			// Token: 0x04003093 RID: 12435
			[Token(Token = "0x4003093")]
			[FieldOffset(Offset = "0x34")]
			private Vector3 dragStartPos;

			// Token: 0x04003094 RID: 12436
			[Token(Token = "0x4003094")]
			[FieldOffset(Offset = "0x40")]
			private Vector3 limbLocalHitPos;

			// Token: 0x04003095 RID: 12437
			[Token(Token = "0x4003095")]
			[FieldOffset(Offset = "0x4C")]
			private Vector3 dragStartScreenWPos;
		}
	}
}
