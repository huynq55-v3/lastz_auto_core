using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace FIMSpace.FProceduralAnimation
{
	// Token: 0x02000C5C RID: 3164
	[Token(Token = "0x2000C5C")]
	[AddComponentMenu("FImpossible Creations/Ragdoll Animator Stabilizer")]
	public class RagdollAnimatorStabilizer : MonoBehaviour
	{
		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x060078B7 RID: 30903 RVA: 0x000530D0 File Offset: 0x000512D0
		// (set) Token: 0x060078B8 RID: 30904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AC9")]
		public RagdollAnimatorStabilizer.EStandingState StandingState
		{
			[Token(Token = "0x60078B7")]
			[Address(RVA = "0x1578454", Offset = "0x1578454", VA = "0x1578454")]
			[CompilerGenerated]
			get
			{
				return RagdollAnimatorStabilizer.EStandingState.Fall;
			}
			[Token(Token = "0x60078B8")]
			[Address(RVA = "0x157845C", Offset = "0x157845C", VA = "0x157845C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060078B9 RID: 30905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078B9")]
		[Address(RVA = "0x1578464", Offset = "0x1578464", VA = "0x1578464")]
		private void Start()
		{
		}

		// Token: 0x060078BA RID: 30906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078BA")]
		[Address(RVA = "0x15788EC", Offset = "0x15788EC", VA = "0x15788EC")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060078BB RID: 30907 RVA: 0x000530E8 File Offset: 0x000512E8
		[Token(Token = "0x60078BB")]
		[Address(RVA = "0x1579190", Offset = "0x1579190", VA = "0x1579190")]
		private Vector3 ToRagdollLocal(Vector3 pos)
		{
			return default(Vector3);
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x060078BC RID: 30908 RVA: 0x00053100 File Offset: 0x00051300
		// (set) Token: 0x060078BD RID: 30909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ACA")]
		public bool hipsTooLow
		{
			[Token(Token = "0x60078BC")]
			[Address(RVA = "0x15791BC", Offset = "0x15791BC", VA = "0x15791BC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60078BD")]
			[Address(RVA = "0x15791C4", Offset = "0x15791C4", VA = "0x15791C4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060078BE RID: 30910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078BE")]
		[Address(RVA = "0x15791D0", Offset = "0x15791D0", VA = "0x15791D0")]
		public RagdollAnimatorStabilizer()
		{
		}

		// Token: 0x040032A1 RID: 12961
		[Token(Token = "0x40032A1")]
		[FieldOffset(Offset = "0x18")]
		public RagdollAnimator Ragdoll;

		// Token: 0x040032A2 RID: 12962
		[Token(Token = "0x40032A2")]
		[FieldOffset(Offset = "0x20")]
		public Transform StabilizeTowards;

		// Token: 0x040032A3 RID: 12963
		[Token(Token = "0x40032A3")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("If null then using hips. You can assign there animator bone or pre-generated ragdoll dummy bone.")]
		public Transform OptionalToPush;

		// Token: 0x040032A4 RID: 12964
		[Token(Token = "0x40032A4")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[Space(4f)]
		public float StabilizePower;

		// Token: 0x040032A5 RID: 12965
		[Token(Token = "0x40032A5")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		public float StabilizeRotationPower;

		// Token: 0x040032A6 RID: 12966
		[Token(Token = "0x40032A6")]
		[FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float StabilizeReactionSpeed;

		// Token: 0x040032A7 RID: 12967
		[Token(Token = "0x40032A7")]
		[FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		[Space(8f)]
		public float PowerBoost;

		// Token: 0x040032A8 RID: 12968
		[Token(Token = "0x40032A8")]
		[FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float HardForceStability;

		// Token: 0x040032A9 RID: 12969
		[Token(Token = "0x40032A9")]
		[FieldOffset(Offset = "0x44")]
		public bool ForceStabilityIsKinematic;

		// Token: 0x040032AA RID: 12970
		[Token(Token = "0x40032AA")]
		[FieldOffset(Offset = "0x45")]
		[Tooltip("Checking legs stand state to make character fall or stick towards stability position")]
		[Space(10f)]
		public bool UseStabilityCheck;

		// Token: 0x040032AB RID: 12971
		[Token(Token = "0x40032AB")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("Foot bones if using ragdoll feets, lower legs if not using ragdoll foot bones")]
		public List<Transform> StandingCheckBones;

		// Token: 0x040032AC RID: 12972
		[Token(Token = "0x40032AC")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("Higher value = easier to standing detect")]
		[Range(0f, 1f)]
		public float StandingCheckTolerance;

		// Token: 0x040032AD RID: 12973
		[Token(Token = "0x40032AD")]
		[FieldOffset(Offset = "0x54")]
		[Tooltip("Disable to call stabilize behaviour even if character lies on the ground")]
		public bool StandOnlyIfHipsUp;

		// Token: 0x040032AE RID: 12974
		[Token(Token = "0x40032AE")]
		[FieldOffset(Offset = "0x58")]
		[Tooltip("Only if enabled StandOnlyIfHipsUp")]
		[Range(0.1f, 0.5f)]
		public float FallOnHipsHeight;

		// Token: 0x040032B0 RID: 12976
		[Token(Token = "0x40032B0")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 hipsHeight;

		// Token: 0x040032B1 RID: 12977
		[Token(Token = "0x40032B1")]
		[FieldOffset(Offset = "0x70")]
		private List<RagdollAnimatorStabilizer.StabilityBoneControl> stabilityBones;

		// Token: 0x040032B2 RID: 12978
		[Token(Token = "0x40032B2")]
		[FieldOffset(Offset = "0x78")]
		private float stabilizingSmoother;

		// Token: 0x040032B3 RID: 12979
		[Token(Token = "0x40032B3")]
		[FieldOffset(Offset = "0x7C")]
		private float sd_stabSmoother;

		// Token: 0x040032B4 RID: 12980
		[Token(Token = "0x40032B4")]
		[FieldOffset(Offset = "0x80")]
		private bool wasForceStab;

		// Token: 0x040032B5 RID: 12981
		[Token(Token = "0x40032B5")]
		[FieldOffset(Offset = "0x88")]
		private Transform _toPushFlag;

		// Token: 0x040032B6 RID: 12982
		[Token(Token = "0x40032B6")]
		[FieldOffset(Offset = "0x90")]
		private RagdollProcessor.PosingBone toStabilize;

		// Token: 0x02000C5D RID: 3165
		[Token(Token = "0x2000C5D")]
		public enum EStandingState
		{
			// Token: 0x040032B9 RID: 12985
			[Token(Token = "0x40032B9")]
			Fall,
			// Token: 0x040032BA RID: 12986
			[Token(Token = "0x40032BA")]
			BarelyStands,
			// Token: 0x040032BB RID: 12987
			[Token(Token = "0x40032BB")]
			StableStanding
		}

		// Token: 0x02000C5E RID: 3166
		[Token(Token = "0x2000C5E")]
		private class StabilityBoneControl
		{
			// Token: 0x060078BF RID: 30911 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078BF")]
			[Address(RVA = "0x1578744", Offset = "0x1578744", VA = "0x1578744")]
			public StabilityBoneControl(Transform b, RagdollAnimator rag)
			{
			}

			// Token: 0x060078C0 RID: 30912 RVA: 0x00053118 File Offset: 0x00051318
			[Token(Token = "0x60078C0")]
			[Address(RVA = "0x1579160", Offset = "0x1579160", VA = "0x1579160")]
			public Vector3 GetHeelPosition()
			{
				return default(Vector3);
			}

			// Token: 0x17000ACB RID: 2763
			// (get) Token: 0x060078C1 RID: 30913 RVA: 0x00053130 File Offset: 0x00051330
			// (set) Token: 0x060078C2 RID: 30914 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000ACB")]
			public float Stability
			{
				[Token(Token = "0x60078C1")]
				[Address(RVA = "0x1579210", Offset = "0x1579210", VA = "0x1579210")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60078C2")]
				[Address(RVA = "0x1579218", Offset = "0x1579218", VA = "0x1579218")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060078C3 RID: 30915 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078C3")]
			[Address(RVA = "0x1579020", Offset = "0x1579020", VA = "0x1579020")]
			public void Update()
			{
			}

			// Token: 0x060078C4 RID: 30916 RVA: 0x00053148 File Offset: 0x00051348
			[Token(Token = "0x60078C4")]
			[Address(RVA = "0x1579148", Offset = "0x1579148", VA = "0x1579148")]
			public bool IsStanding(float tolerance)
			{
				return default(bool);
			}

			// Token: 0x040032BC RID: 12988
			[Token(Token = "0x40032BC")]
			[FieldOffset(Offset = "0x10")]
			public Transform bone;

			// Token: 0x040032BD RID: 12989
			[Token(Token = "0x40032BD")]
			[FieldOffset(Offset = "0x18")]
			public RagdollProcessor.PosingBone ragdollBone;

			// Token: 0x040032BE RID: 12990
			[Token(Token = "0x40032BE")]
			[FieldOffset(Offset = "0x20")]
			private RagdollAnimatorStabilizer.StabilityBoneControl.CollisionStayHelper coll;

			// Token: 0x040032BF RID: 12991
			[Token(Token = "0x40032BF")]
			[FieldOffset(Offset = "0x28")]
			private Vector3 localUp;

			// Token: 0x040032C0 RID: 12992
			[Token(Token = "0x40032C0")]
			[FieldOffset(Offset = "0x34")]
			private Vector3 floorVector;

			// Token: 0x02000C5F RID: 3167
			[Token(Token = "0x2000C5F")]
			[DefaultExecutionOrder(1)]
			private class CollisionStayHelper : MonoBehaviour
			{
				// Token: 0x060078C5 RID: 30917 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60078C5")]
				[Address(RVA = "0x1579220", Offset = "0x1579220", VA = "0x1579220")]
				private void OnCollisionStay(Collision collision)
				{
				}

				// Token: 0x060078C6 RID: 30918 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60078C6")]
				[Address(RVA = "0x1579228", Offset = "0x1579228", VA = "0x1579228")]
				public CollisionStayHelper()
				{
				}

				// Token: 0x040032C2 RID: 12994
				[Token(Token = "0x40032C2")]
				[FieldOffset(Offset = "0x18")]
				public Collision lastCollision;
			}
		}
	}
}
