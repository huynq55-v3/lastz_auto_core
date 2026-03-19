using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace RealisticEyeMovements
{
	// Token: 0x02000C83 RID: 3203
	[Token(Token = "0x2000C83")]
	public class LookTargetController : MonoBehaviour
	{
		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x060079C5 RID: 31173 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060079C6 RID: 31174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ADD")]
		public Transform playerLeftEyeXform
		{
			[Token(Token = "0x60079C5")]
			[Address(RVA = "0x148FD40", Offset = "0x148FD40", VA = "0x148FD40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60079C6")]
			[Address(RVA = "0x148FD48", Offset = "0x148FD48", VA = "0x148FD48")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x060079C7 RID: 31175 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060079C8 RID: 31176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ADE")]
		public Transform playerRightEyeXform
		{
			[Token(Token = "0x60079C7")]
			[Address(RVA = "0x148FD50", Offset = "0x148FD50", VA = "0x148FD50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60079C8")]
			[Address(RVA = "0x148FD58", Offset = "0x148FD58", VA = "0x148FD58")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x060079C9 RID: 31177 RVA: 0x00053760 File Offset: 0x00051960
		// (set) Token: 0x060079CA RID: 31178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ADF")]
		public float DistanceToPlayer
		{
			[Token(Token = "0x60079C9")]
			[Address(RVA = "0x148FD60", Offset = "0x148FD60", VA = "0x148FD60")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60079CA")]
			[Address(RVA = "0x148FD68", Offset = "0x148FD68", VA = "0x148FD68")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060079CB RID: 31179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079CB")]
		[Address(RVA = "0x148FD70", Offset = "0x148FD70", VA = "0x148FD70")]
		private void Awake()
		{
		}

		// Token: 0x060079CC RID: 31180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079CC")]
		[Address(RVA = "0x148FE38", Offset = "0x148FE38", VA = "0x148FE38")]
		public void Blink()
		{
		}

		// Token: 0x060079CD RID: 31181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079CD")]
		[Address(RVA = "0x148FE58", Offset = "0x148FE58", VA = "0x148FE58")]
		private void ChangeStateTo(LookTargetController.State newState)
		{
		}

		// Token: 0x060079CE RID: 31182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60079CE")]
		[Address(RVA = "0x148FEB0", Offset = "0x148FEB0", VA = "0x148FEB0")]
		private Transform ChooseNextHeadTargetPOI()
		{
			return null;
		}

		// Token: 0x060079CF RID: 31183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079CF")]
		[Address(RVA = "0x14902E8", Offset = "0x14902E8", VA = "0x14902E8")]
		public void ClearLookTarget()
		{
		}

		// Token: 0x060079D0 RID: 31184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60079D0")]
		[Address(RVA = "0x14902C8", Offset = "0x14902C8", VA = "0x14902C8")]
		private List<Transform> CurrentPOIs()
		{
			return null;
		}

		// Token: 0x060079D1 RID: 31185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60079D1")]
		[Address(RVA = "0x1490314", Offset = "0x1490314", VA = "0x1490314")]
		private Transform FindPlayer()
		{
			return null;
		}

		// Token: 0x060079D2 RID: 31186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079D2")]
		[Address(RVA = "0x14904D0", Offset = "0x14904D0", VA = "0x14904D0")]
		public void Initialize()
		{
		}

		// Token: 0x060079D3 RID: 31187 RVA: 0x00053778 File Offset: 0x00051978
		[Token(Token = "0x60079D3")]
		[Address(RVA = "0x1490C50", Offset = "0x1490C50", VA = "0x1490C50")]
		public bool IsLookingAtPlayer()
		{
			return default(bool);
		}

		// Token: 0x060079D4 RID: 31188 RVA: 0x00053790 File Offset: 0x00051990
		[Token(Token = "0x60079D4")]
		[Address(RVA = "0x1490C60", Offset = "0x1490C60", VA = "0x1490C60")]
		public bool IsPlayerInView()
		{
			return default(bool);
		}

		// Token: 0x060079D5 RID: 31189 RVA: 0x000537A8 File Offset: 0x000519A8
		[Token(Token = "0x60079D5")]
		[Address(RVA = "0x1490D68", Offset = "0x1490D68", VA = "0x1490D68")]
		public bool IsPlayerLookingAtMe()
		{
			return default(bool);
		}

		// Token: 0x060079D6 RID: 31190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079D6")]
		[Address(RVA = "0x1490E24", Offset = "0x1490E24", VA = "0x1490E24")]
		public void LookAtPlayer(float duration = -1f, float headLatency = 0.075f)
		{
		}

		// Token: 0x060079D7 RID: 31191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079D7")]
		[Address(RVA = "0x1490FC8", Offset = "0x1490FC8", VA = "0x1490FC8")]
		public void LookAroundIdly()
		{
		}

		// Token: 0x060079D8 RID: 31192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079D8")]
		[Address(RVA = "0x1491164", Offset = "0x1491164", VA = "0x1491164")]
		public void LookAtPoiDirectly(Transform poiXform, float duration = -1f, float headLatency = 0.075f)
		{
		}

		// Token: 0x060079D9 RID: 31193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079D9")]
		[Address(RVA = "0x1491250", Offset = "0x1491250", VA = "0x1491250")]
		public void LookAtPoiDirectly(Vector3 poi, float duration = -1f, float headLatency = 0.075f)
		{
		}

		// Token: 0x060079DA RID: 31194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079DA")]
		[Address(RVA = "0x1491300", Offset = "0x1491300", VA = "0x1491300")]
		private void LookAwayFromPlayer()
		{
		}

		// Token: 0x060079DB RID: 31195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079DB")]
		[Address(RVA = "0x1491538", Offset = "0x1491538", VA = "0x1491538")]
		private void OnCannotGetTargetIntoView()
		{
		}

		// Token: 0x060079DC RID: 31196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079DC")]
		[Address(RVA = "0x14916C0", Offset = "0x14916C0", VA = "0x14916C0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060079DD RID: 31197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079DD")]
		[Address(RVA = "0x1491930", Offset = "0x1491930", VA = "0x1491930")]
		private void OnPlayerCameraDisabled()
		{
		}

		// Token: 0x060079DE RID: 31198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079DE")]
		[Address(RVA = "0x14919C4", Offset = "0x14919C4", VA = "0x14919C4")]
		private void OnPlayerEyesParentDestroyed(DestroyNotifier destroyNotifier)
		{
		}

		// Token: 0x060079DF RID: 31199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079DF")]
		[Address(RVA = "0x1491B30", Offset = "0x1491B30", VA = "0x1491B30")]
		private void OnTargetDestroyed()
		{
		}

		// Token: 0x060079E0 RID: 31200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079E0")]
		[Address(RVA = "0x1491660", Offset = "0x1491660", VA = "0x1491660")]
		private void OnTargetLost()
		{
		}

		// Token: 0x060079E1 RID: 31201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079E1")]
		[Address(RVA = "0x1491B34", Offset = "0x1491B34", VA = "0x1491B34")]
		private void Start()
		{
		}

		// Token: 0x060079E2 RID: 31202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079E2")]
		[Address(RVA = "0x1491B44", Offset = "0x1491B44", VA = "0x1491B44")]
		private void UpdateLookTarget(bool shouldLookAwayFromPlayer = false)
		{
		}

		// Token: 0x060079E3 RID: 31203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079E3")]
		[Address(RVA = "0x1490988", Offset = "0x1490988", VA = "0x1490988")]
		private void UpdateNativeVREyePositions()
		{
		}

		// Token: 0x060079E4 RID: 31204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079E4")]
		[Address(RVA = "0x149098C", Offset = "0x149098C", VA = "0x149098C")]
		private void UpdatePlayerEyeTransformReferences()
		{
		}

		// Token: 0x060079E5 RID: 31205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079E5")]
		[Address(RVA = "0x1491BB4", Offset = "0x1491BB4", VA = "0x1491BB4")]
		private void VeryLateUpdate()
		{
		}

		// Token: 0x060079E6 RID: 31206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079E6")]
		[Address(RVA = "0x1492328", Offset = "0x1492328", VA = "0x1492328")]
		public LookTargetController()
		{
		}

		// Token: 0x040034DB RID: 13531
		[Token(Token = "0x40034DB")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("Drag objects here for the actor to look at. If empty, actor will look in random directions.")]
		public List<Transform> pointsOfInterest;

		// Token: 0x040034DC RID: 13532
		[Token(Token = "0x40034DC")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Ratio of how often to look at player vs elsewhere. 0: never, 1: always")]
		[Range(0f, 1f)]
		public float lookAtPlayerRatio;

		// Token: 0x040034DD RID: 13533
		[Token(Token = "0x40034DD")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("How likely the actor is to look back at the player when player stares at actor.")]
		[Range(0f, 1f)]
		public float stareBackFactor;

		// Token: 0x040034DE RID: 13534
		[Token(Token = "0x40034DE")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 100f)]
		[Tooltip("If player is closer than this, notice him")]
		public float noticePlayerDistance;

		// Token: 0x040034DF RID: 13535
		[Token(Token = "0x40034DF")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 4f)]
		[Tooltip("If player is closer than this, look away (overrides noticing him)")]
		public float personalSpaceDistance;

		// Token: 0x040034E0 RID: 13536
		[Token(Token = "0x40034E0")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Minimum time to look at a target")]
		[Range(0.1f, 100f)]
		public float minLookTime;

		// Token: 0x040034E1 RID: 13537
		[Token(Token = "0x40034E1")]
		[FieldOffset(Offset = "0x34")]
		[Range(0.1f, 100f)]
		[Tooltip("Maximum time to look at a target")]
		public float maxLookTime;

		// Token: 0x040034E2 RID: 13538
		[Token(Token = "0x40034E2")]
		[FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("playerEyeCenter")]
		[Tooltip("For 3rd person games, set this to the player's eye center transform")]
		public Transform thirdPersonPlayerEyeCenter;

		// Token: 0x040034E3 RID: 13539
		[Token(Token = "0x40034E3")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Keep trying to track target even when it moves out of sight")]
		public bool keepTargetEvenWhenLost;

		// Token: 0x040034E7 RID: 13543
		[Token(Token = "0x40034E7")]
		[FieldOffset(Offset = "0x60")]
		[Header("Events")]
		public UnityEvent OnStartLookingAtPlayer;

		// Token: 0x040034E8 RID: 13544
		[Token(Token = "0x40034E8")]
		[FieldOffset(Offset = "0x68")]
		public UnityEvent OnStopLookingAtPlayer;

		// Token: 0x040034E9 RID: 13545
		[Token(Token = "0x40034E9")]
		[FieldOffset(Offset = "0x70")]
		public UnityEvent OnPlayerEntersPersonalSpace;

		// Token: 0x040034EA RID: 13546
		[Token(Token = "0x40034EA")]
		[FieldOffset(Offset = "0x78")]
		public UnityEvent OnLookAwayFromShyness;

		// Token: 0x040034EB RID: 13547
		[Token(Token = "0x40034EB")]
		[FieldOffset(Offset = "0x80")]
		public Func<List<Transform>> GetPOIsDelegate;

		// Token: 0x040034EC RID: 13548
		[Token(Token = "0x40034EC")]
		[FieldOffset(Offset = "0x88")]
		public Func<Transform, bool> IsPlayerInViewDelegate;

		// Token: 0x040034ED RID: 13549
		[Token(Token = "0x40034ED")]
		[FieldOffset(Offset = "0x90")]
		public Func<Transform, bool> IsPlayerLookingAtMeDelegate;

		// Token: 0x040034EE RID: 13550
		[Token(Token = "0x40034EE")]
		[FieldOffset(Offset = "0x98")]
		private EyeAndHeadAnimator eyeAndHeadAnimator;

		// Token: 0x040034EF RID: 13551
		[Token(Token = "0x40034EF")]
		private const float minLookAtMeTimeToReact = 4f;

		// Token: 0x040034F0 RID: 13552
		[Token(Token = "0x40034F0")]
		[FieldOffset(Offset = "0xA0")]
		private Transform targetPOI;

		// Token: 0x040034F1 RID: 13553
		[Token(Token = "0x40034F1")]
		[FieldOffset(Offset = "0xA8")]
		private Transform mainCameraXform;

		// Token: 0x040034F2 RID: 13554
		[Token(Token = "0x40034F2")]
		[FieldOffset(Offset = "0xB0")]
		private Transform mainCameraParentXform;

		// Token: 0x040034F3 RID: 13555
		[Token(Token = "0x40034F3")]
		[FieldOffset(Offset = "0xB8")]
		private Transform playerEyeCenterXform;

		// Token: 0x040034F4 RID: 13556
		[Token(Token = "0x40034F4")]
		[FieldOffset(Offset = "0xC0")]
		private Transform usedThirdPersonPlayerEyeCenter;

		// Token: 0x040034F5 RID: 13557
		[Token(Token = "0x40034F5")]
		[FieldOffset(Offset = "0xC8")]
		private Camera playerCamera;

		// Token: 0x040034F6 RID: 13558
		[Token(Token = "0x40034F6")]
		[FieldOffset(Offset = "0xD0")]
		private GameObject createdVRParentGO;

		// Token: 0x040034F7 RID: 13559
		[Token(Token = "0x40034F7")]
		[FieldOffset(Offset = "0xD8")]
		private GameObject createdPlayerEyeCenterGO;

		// Token: 0x040034F8 RID: 13560
		[Token(Token = "0x40034F8")]
		[FieldOffset(Offset = "0xE0")]
		private GameObject createdPlayerLeftEyeGO;

		// Token: 0x040034F9 RID: 13561
		[Token(Token = "0x40034F9")]
		[FieldOffset(Offset = "0xE8")]
		private GameObject createdPlayerRightEyeGO;

		// Token: 0x040034FA RID: 13562
		[Token(Token = "0x40034FA")]
		[FieldOffset(Offset = "0xF0")]
		private float lastDistanceToPlayer;

		// Token: 0x040034FB RID: 13563
		[Token(Token = "0x40034FB")]
		[FieldOffset(Offset = "0xF4")]
		private float smoothedPlayerApproachSpeed;

		// Token: 0x040034FC RID: 13564
		[Token(Token = "0x40034FC")]
		[FieldOffset(Offset = "0xF8")]
		private float playerLookingAtMeTime;

		// Token: 0x040034FD RID: 13565
		[Token(Token = "0x40034FD")]
		[FieldOffset(Offset = "0xFC")]
		private float nextChangePOITime;

		// Token: 0x040034FE RID: 13566
		[Token(Token = "0x40034FE")]
		[FieldOffset(Offset = "0x100")]
		private float stareBackDeadtime;

		// Token: 0x040034FF RID: 13567
		[Token(Token = "0x40034FF")]
		[FieldOffset(Offset = "0x104")]
		private float timeOfLastNoticeCheck;

		// Token: 0x04003500 RID: 13568
		[Token(Token = "0x4003500")]
		[FieldOffset(Offset = "0x108")]
		private float timeOfLastLookBackCheck;

		// Token: 0x04003501 RID: 13569
		[Token(Token = "0x4003501")]
		[FieldOffset(Offset = "0x10C")]
		private float timeOutsideOfAwarenessZone;

		// Token: 0x04003502 RID: 13570
		[Token(Token = "0x4003502")]
		[FieldOffset(Offset = "0x110")]
		private float timeInsidePersonalSpace;

		// Token: 0x04003503 RID: 13571
		[Token(Token = "0x4003503")]
		[FieldOffset(Offset = "0x114")]
		private bool useNativeVRSupport;

		// Token: 0x04003504 RID: 13572
		[Token(Token = "0x4003504")]
		[FieldOffset(Offset = "0x115")]
		private bool useVR;

		// Token: 0x04003505 RID: 13573
		[Token(Token = "0x4003505")]
		[FieldOffset(Offset = "0x116")]
		private bool isInitialized;

		// Token: 0x04003506 RID: 13574
		[Token(Token = "0x4003506")]
		[FieldOffset(Offset = "0x117")]
		private bool wasInPersonalSpaceLastFrame;

		// Token: 0x04003507 RID: 13575
		[Token(Token = "0x4003507")]
		[FieldOffset(Offset = "0x118")]
		private LookTargetController.State state;

		// Token: 0x02000C84 RID: 3204
		[Token(Token = "0x2000C84")]
		private enum State
		{
			// Token: 0x04003509 RID: 13577
			[Token(Token = "0x4003509")]
			LookingAtPlayer,
			// Token: 0x0400350A RID: 13578
			[Token(Token = "0x400350A")]
			LookingAroundIdly,
			// Token: 0x0400350B RID: 13579
			[Token(Token = "0x400350B")]
			LookingAtPoiDirectly,
			// Token: 0x0400350C RID: 13580
			[Token(Token = "0x400350C")]
			LookingAwayFromPlayer
		}
	}
}
