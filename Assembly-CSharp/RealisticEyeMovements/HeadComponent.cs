using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RealisticEyeMovements
{
	// Token: 0x02000C7A RID: 3194
	[Token(Token = "0x2000C7A")]
	[Serializable]
	public class HeadComponent
	{
		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06007987 RID: 31111 RVA: 0x00053520 File Offset: 0x00051720
		// (set) Token: 0x06007988 RID: 31112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AD8")]
		public Vector3 actualVelocity
		{
			[Token(Token = "0x6007987")]
			[Address(RVA = "0x1489788", Offset = "0x1489788", VA = "0x1489788")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6007988")]
			[Address(RVA = "0x1489794", Offset = "0x1489794", VA = "0x1489794")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x06007989 RID: 31113 RVA: 0x00053538 File Offset: 0x00051738
		// (set) Token: 0x0600798A RID: 31114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AD9")]
		public float maxHeadHorizSpeedSinceSaccadeStart
		{
			[Token(Token = "0x6007989")]
			[Address(RVA = "0x14897A0", Offset = "0x14897A0", VA = "0x14897A0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600798A")]
			[Address(RVA = "0x14897A8", Offset = "0x14897A8", VA = "0x14897A8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x0600798B RID: 31115 RVA: 0x00053550 File Offset: 0x00051750
		// (set) Token: 0x0600798C RID: 31116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ADA")]
		public float maxHeadVertSpeedSinceSaccadeStart
		{
			[Token(Token = "0x600798B")]
			[Address(RVA = "0x14897B0", Offset = "0x14897B0", VA = "0x14897B0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600798C")]
			[Address(RVA = "0x14897B8", Offset = "0x14897B8", VA = "0x14897B8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x0600798D RID: 31117 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600798E RID: 31118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ADB")]
		public Transform headXform
		{
			[Token(Token = "0x600798D")]
			[Address(RVA = "0x14897C0", Offset = "0x14897C0", VA = "0x14897C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600798E")]
			[Address(RVA = "0x14897C8", Offset = "0x14897C8", VA = "0x14897C8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x0600798F RID: 31119 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007990 RID: 31120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ADC")]
		public Transform headBaseXform
		{
			[Token(Token = "0x600798F")]
			[Address(RVA = "0x14897D0", Offset = "0x14897D0", VA = "0x14897D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6007990")]
			[Address(RVA = "0x14897D8", Offset = "0x14897D8", VA = "0x14897D8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06007991 RID: 31121 RVA: 0x00053568 File Offset: 0x00051768
		[Token(Token = "0x6007991")]
		[Address(RVA = "0x14897E0", Offset = "0x14897E0", VA = "0x14897E0")]
		private float ClampHorizontalHeadAngle(float headAngle)
		{
			return 0f;
		}

		// Token: 0x06007992 RID: 31122 RVA: 0x00053580 File Offset: 0x00051780
		[Token(Token = "0x6007992")]
		[Address(RVA = "0x14898F8", Offset = "0x14898F8", VA = "0x14898F8")]
		private float ClampVerticalHeadAngle(float headAngle)
		{
			return 0f;
		}

		// Token: 0x06007993 RID: 31123 RVA: 0x00053598 File Offset: 0x00051798
		[Token(Token = "0x6007993")]
		[Address(RVA = "0x1489A10", Offset = "0x1489A10", VA = "0x1489A10")]
		public Vector3 GetForwardRelativeToSpineToHeadAxis()
		{
			return default(Vector3);
		}

		// Token: 0x06007994 RID: 31124 RVA: 0x000535B0 File Offset: 0x000517B0
		[Token(Token = "0x6007994")]
		[Address(RVA = "0x1489B88", Offset = "0x1489B88", VA = "0x1489B88")]
		public Quaternion GetHeadBoneOrientationForLookingAt(Vector3 headTargetGlobal)
		{
			return default(Quaternion);
		}

		// Token: 0x06007995 RID: 31125 RVA: 0x000535C8 File Offset: 0x000517C8
		[Token(Token = "0x6007995")]
		[Address(RVA = "0x148A0B0", Offset = "0x148A0B0", VA = "0x148A0B0")]
		public Vector3 GetHeadDirection()
		{
			return default(Vector3);
		}

		// Token: 0x06007996 RID: 31126 RVA: 0x000535E0 File Offset: 0x000517E0
		[Token(Token = "0x6007996")]
		[Address(RVA = "0x1489D0C", Offset = "0x1489D0C", VA = "0x1489D0C")]
		private Vector3 GetHeadEffectorTargetLocalAngelsForHeadTarget(Vector3 headTargetGlobalPos)
		{
			return default(Vector3);
		}

		// Token: 0x06007997 RID: 31127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007997")]
		[Address(RVA = "0x148A3F0", Offset = "0x148A3F0", VA = "0x148A3F0")]
		public void Initialize(EyeAndHeadAnimator eyeAndHeadAnimator, Animator animator)
		{
		}

		// Token: 0x06007998 RID: 31128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007998")]
		[Address(RVA = "0x148AB50", Offset = "0x148AB50", VA = "0x148AB50")]
		private void InitializeHeadAnchor(Animator animator)
		{
		}

		// Token: 0x06007999 RID: 31129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007999")]
		[Address(RVA = "0x148A518", Offset = "0x148A518", VA = "0x148A518")]
		private void InitializeHeadXform(Animator animator)
		{
		}

		// Token: 0x0600799A RID: 31130 RVA: 0x000535F8 File Offset: 0x000517F8
		[Token(Token = "0x600799A")]
		[Address(RVA = "0x148B43C", Offset = "0x148B43C", VA = "0x148B43C")]
		private bool IsHeadMovementTotalAngleTooSmall()
		{
			return default(bool);
		}

		// Token: 0x0600799B RID: 31131 RVA: 0x00053610 File Offset: 0x00051810
		[Token(Token = "0x600799B")]
		[Address(RVA = "0x148B454", Offset = "0x148B454", VA = "0x148B454")]
		public bool IsSwitchingHeadTarget()
		{
			return default(bool);
		}

		// Token: 0x0600799C RID: 31132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600799C")]
		[Address(RVA = "0x148B494", Offset = "0x148B494", VA = "0x148B494")]
		public void LateUpdate(float deltaTime, float targetHeadWeight)
		{
		}

		// Token: 0x0600799D RID: 31133 RVA: 0x00053628 File Offset: 0x00051828
		[Token(Token = "0x600799D")]
		[Address(RVA = "0x148A2CC", Offset = "0x148A2CC", VA = "0x148A2CC")]
		public float LimitHorizontalHeadAngleSoftly(float headAngle)
		{
			return 0f;
		}

		// Token: 0x0600799E RID: 31134 RVA: 0x00053640 File Offset: 0x00051840
		[Token(Token = "0x600799E")]
		[Address(RVA = "0x148A1A8", Offset = "0x148A1A8", VA = "0x148A1A8")]
		public float LimitVerticalHeadAngleSoftly(float headAngle)
		{
			return 0f;
		}

		// Token: 0x0600799F RID: 31135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600799F")]
		[Address(RVA = "0x148D990", Offset = "0x148D990", VA = "0x148D990")]
		public void OnAnimatorIK(Animator animator)
		{
		}

		// Token: 0x060079A0 RID: 31136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079A0")]
		[Address(RVA = "0x148DA64", Offset = "0x148DA64", VA = "0x148DA64")]
		public void OnEnable()
		{
		}

		// Token: 0x060079A1 RID: 31137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079A1")]
		[Address(RVA = "0x148DA6C", Offset = "0x148DA6C", VA = "0x148DA6C")]
		public void SetEyeRootXform(Transform eyeRootXform)
		{
		}

		// Token: 0x060079A2 RID: 31138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079A2")]
		[Address(RVA = "0x148D214", Offset = "0x148D214", VA = "0x148D214")]
		private void SetHeadOrientationFromHeadEffector()
		{
		}

		// Token: 0x060079A3 RID: 31139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079A3")]
		[Address(RVA = "0x148DAB8", Offset = "0x148DAB8", VA = "0x148DAB8")]
		public void SetHeadSpeed(HeadComponent.HeadSpeed headSpeed)
		{
		}

		// Token: 0x060079A4 RID: 31140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079A4")]
		[Address(RVA = "0x148DAC0", Offset = "0x148DAC0", VA = "0x148DAC0")]
		public void StartHeadMovement()
		{
		}

		// Token: 0x060079A5 RID: 31141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079A5")]
		[Address(RVA = "0x148E2F0", Offset = "0x148E2F0", VA = "0x148E2F0")]
		public void TiltHead()
		{
		}

		// Token: 0x060079A6 RID: 31142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079A6")]
		[Address(RVA = "0x148E7E0", Offset = "0x148E7E0", VA = "0x148E7E0")]
		public void Update()
		{
		}

		// Token: 0x060079A7 RID: 31143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079A7")]
		[Address(RVA = "0x148B4E0", Offset = "0x148B4E0", VA = "0x148B4E0")]
		private void UpdateHeadEffector(float deltaTime)
		{
		}

		// Token: 0x060079A8 RID: 31144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079A8")]
		[Address(RVA = "0x148E9A4", Offset = "0x148E9A4", VA = "0x148E9A4")]
		public HeadComponent()
		{
		}

		// Token: 0x0400348C RID: 13452
		[Token(Token = "0x400348C")]
		[FieldOffset(Offset = "0x38")]
		private EyeAndHeadAnimator eyeAndHeadAnimator;

		// Token: 0x0400348D RID: 13453
		[Token(Token = "0x400348D")]
		public const float kMaxHorizHeadAngle = 65f;

		// Token: 0x0400348E RID: 13454
		[Token(Token = "0x400348E")]
		public const float kMaxVertHeadAngle = 65f;

		// Token: 0x0400348F RID: 13455
		[Token(Token = "0x400348F")]
		private const float hill_a1 = 1.75f;

		// Token: 0x04003490 RID: 13456
		[Token(Token = "0x4003490")]
		private const float hill_a2 = 2.05f;

		// Token: 0x04003491 RID: 13457
		[Token(Token = "0x4003491")]
		private const float hill_c = 4f;

		// Token: 0x04003492 RID: 13458
		[Token(Token = "0x4003492")]
		private const float hill_tMax = 7.5f;

		// Token: 0x04003493 RID: 13459
		[Token(Token = "0x4003493")]
		[FieldOffset(Offset = "0x40")]
		private readonly float hill_yMax;

		// Token: 0x04003494 RID: 13460
		[Token(Token = "0x4003494")]
		[FieldOffset(Offset = "0x44")]
		private readonly float hill_cToPowA1;

		// Token: 0x04003495 RID: 13461
		[Token(Token = "0x4003495")]
		[FieldOffset(Offset = "0x48")]
		private Transform headEffectorPivotXform;

		// Token: 0x04003496 RID: 13462
		[Token(Token = "0x4003496")]
		[FieldOffset(Offset = "0x50")]
		private Transform neckXform;

		// Token: 0x04003497 RID: 13463
		[Token(Token = "0x4003497")]
		[FieldOffset(Offset = "0x58")]
		private Transform spineXform;

		// Token: 0x04003498 RID: 13464
		[Token(Token = "0x4003498")]
		[FieldOffset(Offset = "0x60")]
		private Transform spineBaseXform;

		// Token: 0x04003499 RID: 13465
		[Token(Token = "0x4003499")]
		[FieldOffset(Offset = "0x68")]
		private readonly Vector3 headJitterRotationComponents;

		// Token: 0x0400349A RID: 13466
		[Token(Token = "0x400349A")]
		[FieldOffset(Offset = "0x78")]
		private Vector2[] headJitterNoiseVectors;

		// Token: 0x0400349B RID: 13467
		[Token(Token = "0x400349B")]
		private const int kHeadJitterOctave = 3;

		// Token: 0x0400349C RID: 13468
		[Token(Token = "0x400349C")]
		[FieldOffset(Offset = "0x80")]
		private float headJitterTime;

		// Token: 0x0400349D RID: 13469
		[Token(Token = "0x400349D")]
		[FieldOffset(Offset = "0x84")]
		private bool useHillIfPossible;

		// Token: 0x0400349E RID: 13470
		[Token(Token = "0x400349E")]
		[FieldOffset(Offset = "0x88")]
		private float currentHeadIKWeight;

		// Token: 0x0400349F RID: 13471
		[Token(Token = "0x400349F")]
		[FieldOffset(Offset = "0x8C")]
		private float timeOfHeadMovementStart;

		// Token: 0x040034A0 RID: 13472
		[Token(Token = "0x40034A0")]
		[FieldOffset(Offset = "0x90")]
		private float timeSinceEnabled;

		// Token: 0x040034A1 RID: 13473
		[Token(Token = "0x40034A1")]
		[FieldOffset(Offset = "0x94")]
		private float headMaxSpeed;

		// Token: 0x040034A2 RID: 13474
		[Token(Token = "0x40034A2")]
		[FieldOffset(Offset = "0x98")]
		private float headDuration;

		// Token: 0x040034A3 RID: 13475
		[Token(Token = "0x40034A3")]
		[FieldOffset(Offset = "0x9C")]
		private float startHeadDuration;

		// Token: 0x040034A4 RID: 13476
		[Token(Token = "0x40034A4")]
		[FieldOffset(Offset = "0xA0")]
		private Vector3 headMovementLocalToHeadBaseEulerDirection;

		// Token: 0x040034A5 RID: 13477
		[Token(Token = "0x40034A5")]
		[FieldOffset(Offset = "0xAC")]
		private Vector3 lastHillVelocity;

		// Token: 0x040034A6 RID: 13478
		[Token(Token = "0x40034A6")]
		[FieldOffset(Offset = "0xB8")]
		private float maxHillSmoothLerpDuringThisHeadMovement;

		// Token: 0x040034A7 RID: 13479
		[Token(Token = "0x40034A7")]
		[FieldOffset(Offset = "0xBC")]
		private Vector3 smoothDampVelocity;

		// Token: 0x040034A8 RID: 13480
		[Token(Token = "0x40034A8")]
		[FieldOffset(Offset = "0xC8")]
		private Quaternion lastHeadBaseFromHeadEffectorPivotQ;

		// Token: 0x040034A9 RID: 13481
		[Token(Token = "0x40034A9")]
		[FieldOffset(Offset = "0xD8")]
		private float headMovementTotalAngle;

		// Token: 0x040034AA RID: 13482
		[Token(Token = "0x40034AA")]
		[FieldOffset(Offset = "0xDC")]
		private Vector3 forwardInHeadSpace;

		// Token: 0x040034AB RID: 13483
		[Token(Token = "0x40034AB")]
		[FieldOffset(Offset = "0xE8")]
		private Quaternion character_From_Head_Q;

		// Token: 0x040034AC RID: 13484
		[Token(Token = "0x40034AC")]
		[FieldOffset(Offset = "0xF8")]
		private Quaternion head_From_Character_Q;

		// Token: 0x040034AD RID: 13485
		[Token(Token = "0x40034AD")]
		[FieldOffset(Offset = "0x108")]
		private Quaternion character_From_Neck_Q;

		// Token: 0x040034AE RID: 13486
		[Token(Token = "0x40034AE")]
		[FieldOffset(Offset = "0x118")]
		private Quaternion neck_From_Character_Q;

		// Token: 0x040034AF RID: 13487
		[Token(Token = "0x40034AF")]
		[FieldOffset(Offset = "0x128")]
		private Quaternion headBase_From_HeadEffectorPivot_Q;

		// Token: 0x040034B0 RID: 13488
		[Token(Token = "0x40034B0")]
		[FieldOffset(Offset = "0x138")]
		private Quaternion targetHeadBase_From_HeadEffector_Q;

		// Token: 0x040034B1 RID: 13489
		[Token(Token = "0x40034B1")]
		[FieldOffset(Offset = "0x148")]
		private Quaternion headBase_From_head_Q;

		// Token: 0x040034B2 RID: 13490
		[Token(Token = "0x40034B2")]
		[FieldOffset(Offset = "0x158")]
		private Vector3 eyeCenterOnHeadAxisInHeadPivotLocalCoords;

		// Token: 0x040034B3 RID: 13491
		[Token(Token = "0x40034B3")]
		[FieldOffset(Offset = "0x164")]
		private Vector3 lastHeadEuler;

		// Token: 0x040034B4 RID: 13492
		[Token(Token = "0x40034B4")]
		[FieldOffset(Offset = "0x170")]
		private HeadComponent.HeadSpeed headSpeed;

		// Token: 0x040034B5 RID: 13493
		[Token(Token = "0x40034B5")]
		[FieldOffset(Offset = "0x174")]
		public HeadComponent.HeadControl headControl;

		// Token: 0x040034B6 RID: 13494
		[Token(Token = "0x40034B6")]
		[FieldOffset(Offset = "0x178")]
		public HeadComponent.HeadAnimationType headAnimationType;

		// Token: 0x02000C7B RID: 3195
		[Token(Token = "0x2000C7B")]
		public enum HeadSpeed
		{
			// Token: 0x040034B8 RID: 13496
			[Token(Token = "0x40034B8")]
			Slow,
			// Token: 0x040034B9 RID: 13497
			[Token(Token = "0x40034B9")]
			Fast
		}

		// Token: 0x02000C7C RID: 3196
		[Token(Token = "0x2000C7C")]
		public enum HeadControl
		{
			// Token: 0x040034BB RID: 13499
			[Token(Token = "0x40034BB")]
			AnimatorIK,
			// Token: 0x040034BC RID: 13500
			[Token(Token = "0x40034BC")]
			Transform,
			// Token: 0x040034BD RID: 13501
			[Token(Token = "0x40034BD")]
			HeadTarget,
			// Token: 0x040034BE RID: 13502
			[Token(Token = "0x40034BE")]
			FinalIK,
			// Token: 0x040034BF RID: 13503
			[Token(Token = "0x40034BF")]
			None
		}

		// Token: 0x02000C7D RID: 3197
		[Token(Token = "0x2000C7D")]
		public enum HeadAnimationType
		{
			// Token: 0x040034C1 RID: 13505
			[Token(Token = "0x40034C1")]
			HillHybrid,
			// Token: 0x040034C2 RID: 13506
			[Token(Token = "0x40034C2")]
			SmoothDamping
		}
	}
}
