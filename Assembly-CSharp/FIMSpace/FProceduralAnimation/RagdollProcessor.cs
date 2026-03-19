using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace FIMSpace.FProceduralAnimation
{
	// Token: 0x02000C2C RID: 3116
	[Token(Token = "0x2000C2C")]
	[Serializable]
	public class RagdollProcessor
	{
		// Token: 0x060076D1 RID: 30417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076D1")]
		[Address(RVA = "0x2ECB8A4", Offset = "0x2ECB8A4", VA = "0x2ECB8A4")]
		internal void OnCollisionEnterEvent(RagdollCollisionHelper c)
		{
		}

		// Token: 0x060076D2 RID: 30418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076D2")]
		[Address(RVA = "0x2ECBA28", Offset = "0x2ECBA28", VA = "0x2ECBA28")]
		internal void OnCollisionExitEvent(RagdollCollisionHelper c)
		{
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x060076D3 RID: 30419 RVA: 0x00052A28 File Offset: 0x00050C28
		[Token(Token = "0x17000A7A")]
		public float FinalRagdollBlend
		{
			[Token(Token = "0x60076D3")]
			[Address(RVA = "0x2ECBBA8", Offset = "0x2ECBBA8", VA = "0x2ECBBA8")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x060076D4 RID: 30420 RVA: 0x00052A40 File Offset: 0x00050C40
		// (set) Token: 0x060076D5 RID: 30421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A7B")]
		public RagdollProcessor.EAnimatePelvis AnimatePelvis
		{
			[Token(Token = "0x60076D4")]
			[Address(RVA = "0x2ECBBB4", Offset = "0x2ECBBB4", VA = "0x2ECBBB4")]
			get
			{
				return RagdollProcessor.EAnimatePelvis.None;
			}
			[Token(Token = "0x60076D5")]
			[Address(RVA = "0x2ECBBBC", Offset = "0x2ECBBBC", VA = "0x2ECBBBC")]
			set
			{
			}
		}

		// Token: 0x060076D6 RID: 30422 RVA: 0x00052A58 File Offset: 0x00050C58
		[Token(Token = "0x60076D6")]
		[Address(RVA = "0x2ECBBC4", Offset = "0x2ECBBC4", VA = "0x2ECBBC4")]
		public bool ContainsTransformInSetup(Transform t)
		{
			return default(bool);
		}

		// Token: 0x060076D7 RID: 30423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076D7")]
		[Address(RVA = "0x2ECBD4C", Offset = "0x2ECBD4C", VA = "0x2ECBD4C")]
		public void ConvertHumanoidLimbsToCustomLimbs()
		{
		}

		// Token: 0x060076D8 RID: 30424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076D8")]
		[Address(RVA = "0x2ECBD50", Offset = "0x2ECBD50", VA = "0x2ECBD50")]
		public RagdollProcessor.RagdollBoneSetup GetPelvisSetupBone()
		{
			return null;
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x060076D9 RID: 30425 RVA: 0x00052A70 File Offset: 0x00050C70
		// (set) Token: 0x060076DA RID: 30426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A7C")]
		public bool Initialized
		{
			[Token(Token = "0x60076D9")]
			[Address(RVA = "0x2ECBDE0", Offset = "0x2ECBDE0", VA = "0x2ECBDE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60076DA")]
			[Address(RVA = "0x2ECBDE8", Offset = "0x2ECBDE8", VA = "0x2ECBDE8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x060076DB RID: 30427 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060076DC RID: 30428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A7D")]
		public List<Rigidbody> RagdollLimbs
		{
			[Token(Token = "0x60076DB")]
			[Address(RVA = "0x2ECBDF4", Offset = "0x2ECBDF4", VA = "0x2ECBDF4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60076DC")]
			[Address(RVA = "0x2ECBDFC", Offset = "0x2ECBDFC", VA = "0x2ECBDFC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x060076DD RID: 30429 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060076DE RID: 30430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A7E")]
		public List<Transform> Limbs
		{
			[Token(Token = "0x60076DD")]
			[Address(RVA = "0x2ECBE0C", Offset = "0x2ECBE0C", VA = "0x2ECBE0C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60076DE")]
			[Address(RVA = "0x2ECBE14", Offset = "0x2ECBE14", VA = "0x2ECBE14")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x060076DF RID: 30431 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060076E0 RID: 30432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A7F")]
		public List<RagdollProcessor.PosingBone> RagdollSetup
		{
			[Token(Token = "0x60076DF")]
			[Address(RVA = "0x2ECBE24", Offset = "0x2ECBE24", VA = "0x2ECBE24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60076E0")]
			[Address(RVA = "0x2ECBE2C", Offset = "0x2ECBE2C", VA = "0x2ECBE2C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x060076E1 RID: 30433 RVA: 0x00052A88 File Offset: 0x00050C88
		// (set) Token: 0x060076E2 RID: 30434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A80")]
		public float LastestFreeFallStartTime
		{
			[Token(Token = "0x60076E1")]
			[Address(RVA = "0x2ECBE3C", Offset = "0x2ECBE3C", VA = "0x2ECBE3C")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60076E2")]
			[Address(RVA = "0x2ECBE44", Offset = "0x2ECBE44", VA = "0x2ECBE44")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x060076E3 RID: 30435 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060076E4 RID: 30436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A81")]
		public RagdollAnimator OwnerRagdollAnimatorComponent
		{
			[Token(Token = "0x60076E3")]
			[Address(RVA = "0x2ECBE4C", Offset = "0x2ECBE4C", VA = "0x2ECBE4C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60076E4")]
			[Address(RVA = "0x2ECBE54", Offset = "0x2ECBE54", VA = "0x2ECBE54")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060076E5 RID: 30437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076E5")]
		[Address(RVA = "0x2ECBE64", Offset = "0x2ECBE64", VA = "0x2ECBE64")]
		internal void Initialize(MonoBehaviour caller, Transform objectWithAnimator, [Optional] Transform customRagdollAnimator, [Optional] Transform rootBone, [Optional] Transform containerForDummy)
		{
		}

		// Token: 0x060076E6 RID: 30438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076E6")]
		[Address(RVA = "0x2ECC2C8", Offset = "0x2ECC2C8", VA = "0x2ECC2C8")]
		private IEnumerator DelayedInitialize(MonoBehaviour caller, Transform objectWithAnimator, [Optional] Transform customRagdollAnimator, [Optional] Transform rootBone)
		{
			return null;
		}

		// Token: 0x060076E7 RID: 30439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076E7")]
		[Address(RVA = "0x2ECCC3C", Offset = "0x2ECCC3C", VA = "0x2ECCC3C")]
		public void EnsureCollisionHelpersAdded()
		{
		}

		// Token: 0x060076E8 RID: 30440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076E8")]
		[Address(RVA = "0x2ECC39C", Offset = "0x2ECC39C", VA = "0x2ECC39C")]
		private void Initialization(MonoBehaviour caller, Transform objectWithAnimator, [Optional] Transform customRagdollAnimator, [Optional] Transform rootBone)
		{
		}

		// Token: 0x060076E9 RID: 30441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076E9")]
		[Address(RVA = "0x2ED06F0", Offset = "0x2ED06F0", VA = "0x2ED06F0")]
		public void SwitchAllExtendedAnimatorSync(RagdollProcessor.ESyncMode mode)
		{
		}

		// Token: 0x060076EA RID: 30442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076EA")]
		[Address(RVA = "0x2ED0014", Offset = "0x2ED0014", VA = "0x2ED0014")]
		public void CaptureAnimation(bool force = false)
		{
		}

		// Token: 0x060076EB RID: 30443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076EB")]
		[Address(RVA = "0x2ED07FC", Offset = "0x2ED07FC", VA = "0x2ED07FC")]
		public void User_BlendOnCollisionSetCulldown_Spine(float culldown)
		{
		}

		// Token: 0x060076EC RID: 30444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076EC")]
		[Address(RVA = "0x2ED0804", Offset = "0x2ED0804", VA = "0x2ED0804")]
		public void User_BlendOnCollisionSetCulldown_Chest(float culldown)
		{
		}

		// Token: 0x060076ED RID: 30445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076ED")]
		[Address(RVA = "0x2ED080C", Offset = "0x2ED080C", VA = "0x2ED080C")]
		public void User_BlendOnCollisionSetCulldown_LeftArm(float culldown)
		{
		}

		// Token: 0x060076EE RID: 30446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076EE")]
		[Address(RVA = "0x2ED0814", Offset = "0x2ED0814", VA = "0x2ED0814")]
		public void User_BlendOnCollisionSetCulldown_RightArm(float culldown)
		{
		}

		// Token: 0x060076EF RID: 30447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076EF")]
		[Address(RVA = "0x2ED081C", Offset = "0x2ED081C", VA = "0x2ED081C")]
		public void User_BlendOnCollisionSetCulldown_Head(float culldown)
		{
		}

		// Token: 0x060076F0 RID: 30448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076F0")]
		[Address(RVA = "0x2ED0824", Offset = "0x2ED0824", VA = "0x2ED0824")]
		private void AnimateMinBlend(ref float val, ref float sd, float target, float tgtMul = 1f)
		{
		}

		// Token: 0x060076F1 RID: 30449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076F1")]
		[Address(RVA = "0x2ED087C", Offset = "0x2ED087C", VA = "0x2ED087C")]
		internal void LateUpdate(bool captureAnimation = true)
		{
		}

		// Token: 0x060076F2 RID: 30450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076F2")]
		[Address(RVA = "0x2ED1DB0", Offset = "0x2ED1DB0", VA = "0x2ED1DB0")]
		public void UpdateBonesToRagdollPose()
		{
		}

		// Token: 0x060076F3 RID: 30451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076F3")]
		[Address(RVA = "0x2ED2128", Offset = "0x2ED2128", VA = "0x2ED2128")]
		private void QLerp(Transform a, Quaternion b, float blend)
		{
		}

		// Token: 0x060076F4 RID: 30452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076F4")]
		[Address(RVA = "0x2ED21F0", Offset = "0x2ED21F0", VA = "0x2ED21F0")]
		private void QLerpLocal(Transform a, Quaternion b, float blend)
		{
		}

		// Token: 0x060076F5 RID: 30453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076F5")]
		[Address(RVA = "0x2ED22B8", Offset = "0x2ED22B8", VA = "0x2ED22B8")]
		private void ReposeHipsCalculations()
		{
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x060076F6 RID: 30454 RVA: 0x00052AA0 File Offset: 0x00050CA0
		[Token(Token = "0x17000A82")]
		private bool UpdatePhysics
		{
			[Token(Token = "0x60076F6")]
			[Address(RVA = "0x2ED26C0", Offset = "0x2ED26C0", VA = "0x2ED26C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060076F7 RID: 30455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076F7")]
		[Address(RVA = "0x2ED26C8", Offset = "0x2ED26C8", VA = "0x2ED26C8")]
		internal void Update()
		{
		}

		// Token: 0x060076F8 RID: 30456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076F8")]
		[Address(RVA = "0x2ED2708", Offset = "0x2ED2708", VA = "0x2ED2708")]
		private void Calibration()
		{
		}

		// Token: 0x060076F9 RID: 30457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076F9")]
		[Address(RVA = "0x2ED27B8", Offset = "0x2ED27B8", VA = "0x2ED27B8")]
		internal void FixedUpdate()
		{
		}

		// Token: 0x060076FA RID: 30458 RVA: 0x00052AB8 File Offset: 0x00050CB8
		[Token(Token = "0x60076FA")]
		[Address(RVA = "0x2EC94CC", Offset = "0x2EC94CC", VA = "0x2EC94CC")]
		public Vector3 User_GetRagdollBonesBoundsCenterBottom(bool fast = true)
		{
			return default(Vector3);
		}

		// Token: 0x060076FB RID: 30459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076FB")]
		[Address(RVA = "0x2ED1BF0", Offset = "0x2ED1BF0", VA = "0x2ED1BF0")]
		private void UpdateReposing()
		{
		}

		// Token: 0x060076FC RID: 30460 RVA: 0x00052AD0 File Offset: 0x00050CD0
		[Token(Token = "0x60076FC")]
		[Address(RVA = "0x2ED34A0", Offset = "0x2ED34A0", VA = "0x2ED34A0")]
		public Vector3 GetStoredHipsRootOffset()
		{
			return default(Vector3);
		}

		// Token: 0x060076FD RID: 30461 RVA: 0x00052AE8 File Offset: 0x00050CE8
		[Token(Token = "0x60076FD")]
		[Address(RVA = "0x2ED3594", Offset = "0x2ED3594", VA = "0x2ED3594")]
		public Quaternion GetStoredHipsRootOffsetRot()
		{
			return default(Quaternion);
		}

		// Token: 0x060076FE RID: 30462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076FE")]
		[Address(RVA = "0x2ED0708", Offset = "0x2ED0708", VA = "0x2ED0708")]
		public void StoreHipsRootOffset()
		{
		}

		// Token: 0x060076FF RID: 30463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076FF")]
		[Address(RVA = "0x2ED3688", Offset = "0x2ED3688", VA = "0x2ED3688")]
		public void SwitchFreeFallRagdoll(bool freeFall, float delay = 0f)
		{
		}

		// Token: 0x06007700 RID: 30464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007700")]
		[Address(RVA = "0x2ED36D0", Offset = "0x2ED36D0", VA = "0x2ED36D0")]
		public void ResetLatestFreeFallStartTime()
		{
		}

		// Token: 0x06007701 RID: 30465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007701")]
		[Address(RVA = "0x2EC989C", Offset = "0x2EC989C", VA = "0x2EC989C")]
		public Transform GetRagdollDummyBoneByAnimatorBone(Transform tr)
		{
			return null;
		}

		// Token: 0x06007702 RID: 30466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007702")]
		[Address(RVA = "0x2ED36EC", Offset = "0x2ED36EC", VA = "0x2ED36EC")]
		public RagdollProcessor.PosingBone GetRagdollDummyBoneControllerByAnimatorBone(Transform tr)
		{
			return null;
		}

		// Token: 0x06007703 RID: 30467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007703")]
		[Address(RVA = "0x2ED3774", Offset = "0x2ED3774", VA = "0x2ED3774")]
		public RagdollProcessor.PosingBone GetRagdollDummyBoneControllerByDummyTransform(Transform tr)
		{
			return null;
		}

		// Token: 0x06007704 RID: 30468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007704")]
		[Address(RVA = "0x2ED37FC", Offset = "0x2ED37FC", VA = "0x2ED37FC")]
		public RagdollProcessor.PosingBone TryGetCustomLimbChainsBone(HumanBodyBones bone)
		{
			return null;
		}

		// Token: 0x06007705 RID: 30469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007705")]
		[Address(RVA = "0x2ED3D10", Offset = "0x2ED3D10", VA = "0x2ED3D10")]
		public RagdollProcessor.PosingBone GetRagdollBoneControllerUsingName(string name, bool caseSensitive)
		{
			return null;
		}

		// Token: 0x06007706 RID: 30470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007706")]
		[Address(RVA = "0x2ED3AA4", Offset = "0x2ED3AA4", VA = "0x2ED3AA4")]
		public RagdollProcessor.BonesChain GetCustomLimbChainUsingName(string name, bool caseSensitive)
		{
			return null;
		}

		// Token: 0x06007707 RID: 30471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007707")]
		[Address(RVA = "0x2ED3DBC", Offset = "0x2ED3DBC", VA = "0x2ED3DBC")]
		public RagdollProcessor.RagdollBoneSetup GetCustomLimbChainBoneSetup(string chainName, int chainBoneIndex, bool caseSensitive = false)
		{
			return null;
		}

		// Token: 0x06007708 RID: 30472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007708")]
		[Address(RVA = "0x2ED3A88", Offset = "0x2ED3A88", VA = "0x2ED3A88")]
		public RagdollProcessor.PosingBone GetCustomLimbChainBoneController(string chainName, int chainBoneIndex, bool caseSensitive = false)
		{
			return null;
		}

		// Token: 0x06007709 RID: 30473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007709")]
		[Address(RVA = "0x2ED3E68", Offset = "0x2ED3E68", VA = "0x2ED3E68")]
		public RagdollProcessor.PosingBone GetRagdollDummyBoneByAnimatorBoneDict(Transform animatorTransform)
		{
			return null;
		}

		// Token: 0x0600770A RID: 30474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600770A")]
		[Address(RVA = "0x2ED3F78", Offset = "0x2ED3F78", VA = "0x2ED3F78")]
		public RagdollProcessor.PosingBone GetRagdollBoneControllerByHumanoidBone(HumanBodyBones bone)
		{
			return null;
		}

		// Token: 0x0600770B RID: 30475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600770B")]
		[Address(RVA = "0x2ECD000", Offset = "0x2ECD000", VA = "0x2ECD000")]
		private void PrepareRagdollDummy(Transform objectWithAnimator, Transform rootBone)
		{
		}

		// Token: 0x0600770C RID: 30476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600770C")]
		[Address(RVA = "0x2ED5840", Offset = "0x2ED5840", VA = "0x2ED5840")]
		private void CheckDummyHide()
		{
		}

		// Token: 0x0600770D RID: 30477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600770D")]
		[Address(RVA = "0x2ED58DC", Offset = "0x2ED58DC", VA = "0x2ED58DC")]
		internal void AlignRagdollBonesWithAnimatorBones()
		{
		}

		// Token: 0x0600770E RID: 30478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600770E")]
		[Address(RVA = "0x2ED4E2C", Offset = "0x2ED4E2C", VA = "0x2ED4E2C")]
		private void IgnoreCollisionsBetweenRagdollBones()
		{
		}

		// Token: 0x0600770F RID: 30479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600770F")]
		[Address(RVA = "0x2ED5984", Offset = "0x2ED5984", VA = "0x2ED5984")]
		public void User_SetIgnoreCollisionWith(Collider coll)
		{
		}

		// Token: 0x06007710 RID: 30480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007710")]
		[Address(RVA = "0x2ED5A98", Offset = "0x2ED5A98", VA = "0x2ED5A98")]
		public void User_SetPhysicalMaterialAll(PhysicMaterial material)
		{
		}

		// Token: 0x06007711 RID: 30481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007711")]
		[Address(RVA = "0x2ED405C", Offset = "0x2ED405C", VA = "0x2ED405C")]
		private void DestroyObj(Object obj)
		{
		}

		// Token: 0x06007712 RID: 30482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007712")]
		[Address(RVA = "0x2ED5790", Offset = "0x2ED5790", VA = "0x2ED5790")]
		public void Ragdoll_IgnoreCollision(Collider a, Collider b)
		{
		}

		// Token: 0x06007713 RID: 30483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007713")]
		[Address(RVA = "0x2ED4D80", Offset = "0x2ED4D80", VA = "0x2ED4D80")]
		private void DestroyChildren(Transform parent)
		{
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06007714 RID: 30484 RVA: 0x00052B00 File Offset: 0x00050D00
		[Token(Token = "0x17000A83")]
		public bool IsPreGeneratedDummy
		{
			[Token(Token = "0x6007714")]
			[Address(RVA = "0x2ED5BB8", Offset = "0x2ED5BB8", VA = "0x2ED5BB8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007715 RID: 30485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007715")]
		[Address(RVA = "0x2ED5BC0", Offset = "0x2ED5BC0", VA = "0x2ED5BC0")]
		public void PreGenerateDummy(Transform objectWithAnimator, Transform rootBone)
		{
		}

		// Token: 0x06007716 RID: 30486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007716")]
		[Address(RVA = "0x2ED5BCC", Offset = "0x2ED5BCC", VA = "0x2ED5BCC")]
		public void RemovePreGeneratedDummy()
		{
		}

		// Token: 0x06007717 RID: 30487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007717")]
		[Address(RVA = "0x2ED5C58", Offset = "0x2ED5C58", VA = "0x2ED5C58")]
		public void TryAutoFindReferences(Transform root)
		{
		}

		// Token: 0x06007718 RID: 30488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007718")]
		[Address(RVA = "0x2ED019C", Offset = "0x2ED019C", VA = "0x2ED019C")]
		private void RefreshPelvisGuides()
		{
		}

		// Token: 0x06007719 RID: 30489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007719")]
		[Address(RVA = "0x2ED6348", Offset = "0x2ED6348", VA = "0x2ED6348")]
		public RagdollProcessor.PosingBone GetPelvisBone()
		{
			return null;
		}

		// Token: 0x0600771A RID: 30490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600771A")]
		[Address(RVA = "0x2ED6350", Offset = "0x2ED6350", VA = "0x2ED6350")]
		public RagdollProcessor.PosingBone GetHeadBone()
		{
			return null;
		}

		// Token: 0x0600771B RID: 30491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600771B")]
		[Address(RVA = "0x2ED6358", Offset = "0x2ED6358", VA = "0x2ED6358")]
		public RagdollProcessor.PosingBone GetSpineStartBone()
		{
			return null;
		}

		// Token: 0x0600771C RID: 30492 RVA: 0x00052B18 File Offset: 0x00050D18
		[Token(Token = "0x600771C")]
		[Address(RVA = "0x2ED6360", Offset = "0x2ED6360", VA = "0x2ED6360")]
		public bool HasChest()
		{
			return default(bool);
		}

		// Token: 0x0600771D RID: 30493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600771D")]
		[Address(RVA = "0x2ED4040", Offset = "0x2ED4040", VA = "0x2ED4040")]
		public RagdollProcessor.PosingBone GetChestBone()
		{
			return null;
		}

		// Token: 0x0600771E RID: 30494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600771E")]
		[Address(RVA = "0x2ED6370", Offset = "0x2ED6370", VA = "0x2ED6370")]
		public RagdollProcessor.PosingBone GetRightForeArm()
		{
			return null;
		}

		// Token: 0x0600771F RID: 30495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600771F")]
		[Address(RVA = "0x2ED6378", Offset = "0x2ED6378", VA = "0x2ED6378")]
		public RagdollProcessor.PosingBone GetLeftUpperArm()
		{
			return null;
		}

		// Token: 0x06007720 RID: 30496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007720")]
		[Address(RVA = "0x2ED6380", Offset = "0x2ED6380", VA = "0x2ED6380")]
		public RagdollProcessor.PosingBone GetRightUpperArm()
		{
			return null;
		}

		// Token: 0x06007721 RID: 30497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007721")]
		[Address(RVA = "0x2ED6388", Offset = "0x2ED6388", VA = "0x2ED6388")]
		public RagdollProcessor.PosingBone GetLeftForeArm()
		{
			return null;
		}

		// Token: 0x06007722 RID: 30498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007722")]
		[Address(RVA = "0x2ED6390", Offset = "0x2ED6390", VA = "0x2ED6390")]
		public RagdollProcessor.PosingBone GetLeftLowerLeg()
		{
			return null;
		}

		// Token: 0x06007723 RID: 30499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007723")]
		[Address(RVA = "0x2ED6398", Offset = "0x2ED6398", VA = "0x2ED6398")]
		public RagdollProcessor.PosingBone GetLeftUpperLeg()
		{
			return null;
		}

		// Token: 0x06007724 RID: 30500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007724")]
		[Address(RVA = "0x2ED63A0", Offset = "0x2ED63A0", VA = "0x2ED63A0")]
		public RagdollProcessor.PosingBone GetRightUpperLeg()
		{
			return null;
		}

		// Token: 0x06007725 RID: 30501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007725")]
		[Address(RVA = "0x2ED63A8", Offset = "0x2ED63A8", VA = "0x2ED63A8")]
		public RagdollProcessor.PosingBone GetRightLowerLeg()
		{
			return null;
		}

		// Token: 0x06007726 RID: 30502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007726")]
		[Address(RVA = "0x2ED3578", Offset = "0x2ED3578", VA = "0x2ED3578")]
		public Transform GetRagdolledPelvis()
		{
			return null;
		}

		// Token: 0x06007727 RID: 30503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007727")]
		[Address(RVA = "0x2ED366C", Offset = "0x2ED366C", VA = "0x2ED366C")]
		public Transform GetAnimatorPelvis()
		{
			return null;
		}

		// Token: 0x06007728 RID: 30504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007728")]
		[Address(RVA = "0x2ED63B0", Offset = "0x2ED63B0", VA = "0x2ED63B0")]
		public RagdollProcessor.PosingBone GetRightShoulder()
		{
			return null;
		}

		// Token: 0x06007729 RID: 30505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007729")]
		[Address(RVA = "0x2ED63B8", Offset = "0x2ED63B8", VA = "0x2ED63B8")]
		public RagdollProcessor.PosingBone GetLeftShoulder()
		{
			return null;
		}

		// Token: 0x0600772A RID: 30506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600772A")]
		[Address(RVA = "0x2ED63C0", Offset = "0x2ED63C0", VA = "0x2ED63C0")]
		public RagdollProcessor.PosingBone GetRightHand()
		{
			return null;
		}

		// Token: 0x0600772B RID: 30507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600772B")]
		[Address(RVA = "0x2ED63C8", Offset = "0x2ED63C8", VA = "0x2ED63C8")]
		public RagdollProcessor.PosingBone GetLeftHand()
		{
			return null;
		}

		// Token: 0x0600772C RID: 30508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600772C")]
		[Address(RVA = "0x2ED63D0", Offset = "0x2ED63D0", VA = "0x2ED63D0")]
		public RagdollProcessor.PosingBone GetRightFoot()
		{
			return null;
		}

		// Token: 0x0600772D RID: 30509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600772D")]
		[Address(RVA = "0x2ED63D8", Offset = "0x2ED63D8", VA = "0x2ED63D8")]
		public RagdollProcessor.PosingBone GetLeftFoot()
		{
			return null;
		}

		// Token: 0x0600772E RID: 30510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600772E")]
		[Address(RVA = "0x2ED40B4", Offset = "0x2ED40B4", VA = "0x2ED40B4")]
		public void SetRagdollTargetBones(Transform dummy, [Optional] Transform pelvis, [Optional] Transform spineStart, [Optional] Transform chest, [Optional] Transform head, [Optional] Transform leftUpperArm, [Optional] Transform leftForeArm, [Optional] Transform rightUpperArm, [Optional] Transform rightForeArm, [Optional] Transform leftUpperLeg, [Optional] Transform leftLowerLeg, [Optional] Transform rightUpperLeg, [Optional] Transform rightLowerLeg, [Optional] Transform leftShoulder, [Optional] Transform rightShoulder)
		{
		}

		// Token: 0x0600772F RID: 30511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600772F")]
		[Address(RVA = "0x2ED045C", Offset = "0x2ED045C", VA = "0x2ED045C")]
		public static Transform FindChildByNameInDepth(string name, Transform transform, bool findInDeactivated = true, [Optional] string[] additionalContains, bool fullName = false)
		{
			return null;
		}

		// Token: 0x06007730 RID: 30512 RVA: 0x00052B30 File Offset: 0x00050D30
		[Token(Token = "0x6007730")]
		[Address(RVA = "0x2ED63E0", Offset = "0x2ED63E0", VA = "0x2ED63E0")]
		public static bool CheckName(Transform child, string target, bool fullName)
		{
			return default(bool);
		}

		// Token: 0x06007731 RID: 30513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007731")]
		[Address(RVA = "0x2ED4BCC", Offset = "0x2ED4BCC", VA = "0x2ED4BCC")]
		public void SetAnimationPoseBones([Optional] Transform pelvis, [Optional] Transform spineStart, [Optional] Transform chest, [Optional] Transform head, [Optional] Transform leftUpperArm, [Optional] Transform leftForeArm, [Optional] Transform rightUpperArm, [Optional] Transform rightForeArm, [Optional] Transform leftUpperLeg, [Optional] Transform leftLowerLeg, [Optional] Transform rightUpperLeg, [Optional] Transform rightLowerLeg)
		{
		}

		// Token: 0x06007732 RID: 30514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007732")]
		[Address(RVA = "0x2ED059C", Offset = "0x2ED059C", VA = "0x2ED059C")]
		public void SetAnimationRefBones([Optional] Transform pelvis, [Optional] Transform spineStart, [Optional] Transform chest, [Optional] Transform head, [Optional] Transform leftUpperArm, [Optional] Transform leftForeArm, [Optional] Transform rightUpperArm, [Optional] Transform rightForeArm, [Optional] Transform leftUpperLeg, [Optional] Transform leftLowerLeg, [Optional] Transform rightUpperLeg, [Optional] Transform rightLowerLeg)
		{
		}

		// Token: 0x06007733 RID: 30515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007733")]
		[Address(RVA = "0x2ED6454", Offset = "0x2ED6454", VA = "0x2ED6454")]
		internal void BackCompabilityCheck()
		{
		}

		// Token: 0x06007734 RID: 30516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007734")]
		[Address(RVA = "0x2ED6824", Offset = "0x2ED6824", VA = "0x2ED6824")]
		private Joint _BackComp_FindChildJoint(Transform parent)
		{
			return null;
		}

		// Token: 0x06007735 RID: 30517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007735")]
		[Address(RVA = "0x2ECCB98", Offset = "0x2ECCB98", VA = "0x2ECCB98")]
		public void User_SetAllKinematic(bool kinematic = true)
		{
		}

		// Token: 0x06007736 RID: 30518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007736")]
		[Address(RVA = "0x2ED690C", Offset = "0x2ED690C", VA = "0x2ED690C")]
		public void User_SetAllAngularSpeedLimit(float angularSpeedLimit)
		{
		}

		// Token: 0x06007737 RID: 30519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007737")]
		[Address(RVA = "0x2ED69AC", Offset = "0x2ED69AC", VA = "0x2ED69AC")]
		public void User_SetAllIterpolation(RigidbodyInterpolation interpolation)
		{
		}

		// Token: 0x06007738 RID: 30520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007738")]
		[Address(RVA = "0x2ED6B00", Offset = "0x2ED6B00", VA = "0x2ED6B00")]
		public static IEnumerator User_SetPhysicalImpact(Rigidbody limb, Vector3 powerDirection, float duration, ForceMode forceMode = 1)
		{
			return null;
		}

		// Token: 0x06007739 RID: 30521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007739")]
		[Address(RVA = "0x2ED6BB0", Offset = "0x2ED6BB0", VA = "0x2ED6BB0")]
		internal static void ApplyLimbImpact(Rigidbody limb, Vector3 powerDirection, ForceMode forceMode = 1)
		{
		}

		// Token: 0x0600773A RID: 30522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600773A")]
		[Address(RVA = "0x2ED6BC4", Offset = "0x2ED6BC4", VA = "0x2ED6BC4")]
		public IEnumerator User_SetLimbImpact(Rigidbody limb, Vector3 powerDirection, float duration, ForceMode forceMode = 1)
		{
			return null;
		}

		// Token: 0x0600773B RID: 30523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600773B")]
		[Address(RVA = "0x2ED6C70", Offset = "0x2ED6C70", VA = "0x2ED6C70")]
		public IEnumerator User_SetPhysicalImpactAll(Vector3 powerDirection, float duration, ForceMode forceMode = 1)
		{
			return null;
		}

		// Token: 0x0600773C RID: 30524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600773C")]
		[Address(RVA = "0x2ED6D20", Offset = "0x2ED6D20", VA = "0x2ED6D20")]
		public IEnumerator User_SetPhysicalTorque(Vector3 rotationPower, float duration, bool relativeSpace = true, ForceMode forceMode = 1)
		{
			return null;
		}

		// Token: 0x0600773D RID: 30525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600773D")]
		[Address(RVA = "0x2ED6DDC", Offset = "0x2ED6DDC", VA = "0x2ED6DDC")]
		public IEnumerator User_SetPhysicalTorque(Rigidbody limb, Vector3 rotationPower, float duration, bool relativeSpace = true, ForceMode forceMode = 1)
		{
			return null;
		}

		// Token: 0x0600773E RID: 30526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600773E")]
		[Address(RVA = "0x2ED6E98", Offset = "0x2ED6E98", VA = "0x2ED6E98")]
		public IEnumerator User_SwitchAnimator(Animator animator, bool enable, float delay)
		{
			return null;
		}

		// Token: 0x0600773F RID: 30527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600773F")]
		[Address(RVA = "0x2ED6F30", Offset = "0x2ED6F30", VA = "0x2ED6F30")]
		public IEnumerator User_FadeMuscles(float forcePoseEnd = 0f, float duration = 0.75f, float delay = 0f)
		{
			return null;
		}

		// Token: 0x06007740 RID: 30528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007740")]
		[Address(RVA = "0x2ED6FC8", Offset = "0x2ED6FC8", VA = "0x2ED6FC8")]
		public IEnumerator User_ForceRagdollToAnimatorFor(float duration, float forcingFullDelay = 0.2f)
		{
			return null;
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06007741 RID: 30529 RVA: 0x00052B48 File Offset: 0x00050D48
		// (set) Token: 0x06007742 RID: 30530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A84")]
		public bool IsFadeRagdollCoroutineRunning
		{
			[Token(Token = "0x6007741")]
			[Address(RVA = "0x2ED7050", Offset = "0x2ED7050", VA = "0x2ED7050")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007742")]
			[Address(RVA = "0x2ED7058", Offset = "0x2ED7058", VA = "0x2ED7058")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06007743 RID: 30531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007743")]
		[Address(RVA = "0x2ED7064", Offset = "0x2ED7064", VA = "0x2ED7064")]
		public IEnumerator User_FadeRagdolledBlend(float targetBlend = 0f, float duration = 0.75f, float delay = 0f)
		{
			return null;
		}

		// Token: 0x06007744 RID: 30532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007744")]
		[Address(RVA = "0x2ED70FC", Offset = "0x2ED70FC", VA = "0x2ED70FC")]
		public void User_SetAllLimbsVelocity(Vector3 velocity)
		{
		}

		// Token: 0x06007745 RID: 30533 RVA: 0x00052B60 File Offset: 0x00050D60
		[Token(Token = "0x6007745")]
		[Address(RVA = "0x2ECB7A4", Offset = "0x2ECB7A4", VA = "0x2ECB7A4")]
		public Vector3 User_GetAllLimbsVelocity()
		{
			return default(Vector3);
		}

		// Token: 0x06007746 RID: 30534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007746")]
		[Address(RVA = "0x2ED71B4", Offset = "0x2ED71B4", VA = "0x2ED71B4")]
		public IEnumerator User_TransitionToNonFreeFallRagdoll(float duration, float delay = 0f)
		{
			return null;
		}

		// Token: 0x06007747 RID: 30535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007747")]
		[Address(RVA = "0x2EC8A30", Offset = "0x2EC8A30", VA = "0x2EC8A30")]
		public void SafetyResetAfterCouroutinesStop()
		{
		}

		// Token: 0x06007748 RID: 30536 RVA: 0x00052B78 File Offset: 0x00050D78
		[Token(Token = "0x6007748")]
		[Address(RVA = "0x2ED7240", Offset = "0x2ED7240", VA = "0x2ED7240")]
		public Vector3 User_GetAllLimbsMaxVelocity()
		{
			return default(Vector3);
		}

		// Token: 0x06007749 RID: 30537 RVA: 0x00052B90 File Offset: 0x00050D90
		[Token(Token = "0x6007749")]
		[Address(RVA = "0x2EC84C4", Offset = "0x2EC84C4", VA = "0x2EC84C4")]
		public Vector3 User_GetSpineLimbsVelocity(bool withChest = false)
		{
			return default(Vector3);
		}

		// Token: 0x0600774A RID: 30538 RVA: 0x00052BA8 File Offset: 0x00050DA8
		[Token(Token = "0x600774A")]
		[Address(RVA = "0x2ECA0BC", Offset = "0x2ECA0BC", VA = "0x2ECA0BC")]
		public Vector3 User_GetSpineLimbsAngularVelocity(bool withChest = false)
		{
			return default(Vector3);
		}

		// Token: 0x0600774B RID: 30539 RVA: 0x00052BC0 File Offset: 0x00050DC0
		[Token(Token = "0x600774B")]
		[Address(RVA = "0x2ED7370", Offset = "0x2ED7370", VA = "0x2ED7370")]
		public Vector3 User_PelvisWorldForward()
		{
			return default(Vector3);
		}

		// Token: 0x0600774C RID: 30540 RVA: 0x00052BD8 File Offset: 0x00050DD8
		[Token(Token = "0x600774C")]
		[Address(RVA = "0x2ED73AC", Offset = "0x2ED73AC", VA = "0x2ED73AC")]
		public Vector3 User_PelvisWorldUp()
		{
			return default(Vector3);
		}

		// Token: 0x0600774D RID: 30541 RVA: 0x00052BF0 File Offset: 0x00050DF0
		[Token(Token = "0x600774D")]
		[Address(RVA = "0x2ED73E8", Offset = "0x2ED73E8", VA = "0x2ED73E8")]
		public Vector3 User_PelvisWorldRight()
		{
			return default(Vector3);
		}

		// Token: 0x0600774E RID: 30542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600774E")]
		[Address(RVA = "0x2EC8A3C", Offset = "0x2EC8A3C", VA = "0x2EC8A3C")]
		public void _User_GetUpResetProbe()
		{
		}

		// Token: 0x0600774F RID: 30543 RVA: 0x00052C08 File Offset: 0x00050E08
		[Token(Token = "0x600774F")]
		[Address(RVA = "0x2ED7424", Offset = "0x2ED7424", VA = "0x2ED7424")]
		public RagdollProcessor.EGetUpType ProbeGetUpStatePer(float maxVelocityToAllow = 0.7f, float delayPerProbe = 0.1f, float minimumStabilityTime = 0.5f, [Optional] Vector3? worldUp, bool canBeNone = true)
		{
			return RagdollProcessor.EGetUpType.None;
		}

		// Token: 0x06007750 RID: 30544 RVA: 0x00052C20 File Offset: 0x00050E20
		[Token(Token = "0x6007750")]
		[Address(RVA = "0x2ED75E4", Offset = "0x2ED75E4", VA = "0x2ED75E4")]
		public bool RecognizeRagdollIsStandingOnLegs(float tolerance = 0.75f, [Optional] Vector3? worldUp)
		{
			return default(bool);
		}

		// Token: 0x06007751 RID: 30545 RVA: 0x00052C38 File Offset: 0x00050E38
		[Token(Token = "0x6007751")]
		[Address(RVA = "0x2EC621C", Offset = "0x2EC621C", VA = "0x2EC621C")]
		public Vector3 User_GetMiddleFootPos()
		{
			return default(Vector3);
		}

		// Token: 0x06007752 RID: 30546 RVA: 0x00052C50 File Offset: 0x00050E50
		[Token(Token = "0x6007752")]
		[Address(RVA = "0x2EC5768", Offset = "0x2EC5768", VA = "0x2EC5768")]
		public float User_ReferenceLength()
		{
			return 0f;
		}

		// Token: 0x06007753 RID: 30547 RVA: 0x00052C68 File Offset: 0x00050E68
		[Token(Token = "0x6007753")]
		[Address(RVA = "0x2EC59AC", Offset = "0x2EC59AC", VA = "0x2EC59AC")]
		public RagdollProcessor.EGetUpType User_CanGetUp([Optional] Vector3? worldUp, bool canBeNone = true, bool includeLeftRightSide = false, float tolerance = 0.35f, bool quadroped = false)
		{
			return RagdollProcessor.EGetUpType.None;
		}

		// Token: 0x06007754 RID: 30548 RVA: 0x00052C80 File Offset: 0x00050E80
		[Token(Token = "0x6007754")]
		[Address(RVA = "0x2EC5B2C", Offset = "0x2EC5B2C", VA = "0x2EC5B2C")]
		public RagdollProcessor.EGetUpType User_LayingOnSide([Optional] Vector3? worldUp, bool canBeNone = true, float tolerance = 0.35f)
		{
			return RagdollProcessor.EGetUpType.None;
		}

		// Token: 0x06007755 RID: 30549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007755")]
		[Address(RVA = "0x2ED7874", Offset = "0x2ED7874", VA = "0x2ED7874")]
		public IEnumerator User_AnchorPelvis(bool anchor = true, float duration = 0f)
		{
			return null;
		}

		// Token: 0x06007756 RID: 30550 RVA: 0x00052C98 File Offset: 0x00050E98
		[Token(Token = "0x6007756")]
		[Address(RVA = "0x2ED790C", Offset = "0x2ED790C", VA = "0x2ED790C")]
		public Vector3 User_ComputeGetUpPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06007757 RID: 30551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007757")]
		[Address(RVA = "0x2ED79A0", Offset = "0x2ED79A0", VA = "0x2ED79A0")]
		public void User_RepositionRoot([Optional] Transform root, [Optional] Vector3? getUpPosition, [Optional] Vector3? worldUp, RagdollProcessor.EGetUpType getupType = RagdollProcessor.EGetUpType.None, [Optional] LayerMask? snapToGround)
		{
		}

		// Token: 0x06007758 RID: 30552 RVA: 0x00052CB0 File Offset: 0x00050EB0
		[Token(Token = "0x6007758")]
		[Address(RVA = "0x2EC859C", Offset = "0x2EC859C", VA = "0x2EC859C")]
		public RaycastHit ProbeGroundBelowHips(LayerMask mask, float distance = 10f, [Optional] Vector3? worldUp)
		{
			return default(RaycastHit);
		}

		// Token: 0x06007759 RID: 30553 RVA: 0x00052CC8 File Offset: 0x00050EC8
		[Token(Token = "0x6007759")]
		[Address(RVA = "0x2ED7F58", Offset = "0x2ED7F58", VA = "0x2ED7F58")]
		public bool User_GetUpPossible(Vector3 up)
		{
			return default(bool);
		}

		// Token: 0x0600775A RID: 30554 RVA: 0x00052CE0 File Offset: 0x00050EE0
		[Token(Token = "0x600775A")]
		[Address(RVA = "0x2ED8000", Offset = "0x2ED8000", VA = "0x2ED8000")]
		public bool User_GetUpPossible(RagdollProcessor.EGetUpType getup)
		{
			return default(bool);
		}

		// Token: 0x0600775B RID: 30555 RVA: 0x00052CF8 File Offset: 0x00050EF8
		[Token(Token = "0x600775B")]
		[Address(RVA = "0x2ED800C", Offset = "0x2ED800C", VA = "0x2ED800C")]
		public bool User_IsOnBack(Vector3 up)
		{
			return default(bool);
		}

		// Token: 0x0600775C RID: 30556 RVA: 0x00052D10 File Offset: 0x00050F10
		[Token(Token = "0x600775C")]
		[Address(RVA = "0x2EC87EC", Offset = "0x2EC87EC", VA = "0x2EC87EC")]
		public Quaternion User_GetMappedRotationHipsToHead(Vector3 up, bool checkIfOnBack = true)
		{
			return default(Quaternion);
		}

		// Token: 0x0600775D RID: 30557 RVA: 0x00052D28 File Offset: 0x00050F28
		[Token(Token = "0x600775D")]
		[Address(RVA = "0x2EC5838", Offset = "0x2EC5838", VA = "0x2EC5838")]
		public Quaternion User_GetMappedRotation(Vector3 up)
		{
			return default(Quaternion);
		}

		// Token: 0x0600775E RID: 30558 RVA: 0x00052D40 File Offset: 0x00050F40
		[Token(Token = "0x600775E")]
		[Address(RVA = "0x2ED7E24", Offset = "0x2ED7E24", VA = "0x2ED7E24")]
		public Quaternion User_GetMappedRotationFor(RagdollProcessor.EGetUpType getupType, Vector3 up)
		{
			return default(Quaternion);
		}

		// Token: 0x0600775F RID: 30559 RVA: 0x00052D58 File Offset: 0x00050F58
		[Token(Token = "0x600775F")]
		[Address(RVA = "0x2ED80B4", Offset = "0x2ED80B4", VA = "0x2ED80B4")]
		public bool User_IsPelvisKinematic()
		{
			return default(bool);
		}

		// Token: 0x06007760 RID: 30560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007760")]
		[Address(RVA = "0x2ED80D8", Offset = "0x2ED80D8", VA = "0x2ED80D8")]
		private void SetPosingParams(RagdollProcessor.PosingBone bone, float muscleAmount = 1f, float muscleMultiplier = 1f, float onRagdoll = 1f)
		{
		}

		// Token: 0x06007761 RID: 30561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007761")]
		[Address(RVA = "0x2ED80F4", Offset = "0x2ED80F4", VA = "0x2ED80F4")]
		public void User_SetAllParams(float muscleAmount = 1f, float muscleMultiplier = 1f, float onRagdoll = 1f)
		{
		}

		// Token: 0x06007762 RID: 30562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007762")]
		[Address(RVA = "0x2ED8220", Offset = "0x2ED8220", VA = "0x2ED8220")]
		public void User_OverrideRagdollStateWithCurrentAnimationState()
		{
		}

		// Token: 0x06007763 RID: 30563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007763")]
		[Address(RVA = "0x2ED8170", Offset = "0x2ED8170", VA = "0x2ED8170")]
		public void User_SetArmsParams(float muscleAmount = 1f, float muscleMultiplier = 1f, float onRagdoll = 1f)
		{
		}

		// Token: 0x06007764 RID: 30564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007764")]
		[Address(RVA = "0x2ED8228", Offset = "0x2ED8228", VA = "0x2ED8228")]
		public void User_SetLeftArmParams(float muscleAmount = 1f, float muscleMultiplier = 1f, float onRagdoll = 1f)
		{
		}

		// Token: 0x06007765 RID: 30565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007765")]
		[Address(RVA = "0x2ED8258", Offset = "0x2ED8258", VA = "0x2ED8258")]
		public void User_SetRightArmParams(float muscleAmount = 1f, float muscleMultiplier = 1f, float onRagdoll = 1f)
		{
		}

		// Token: 0x06007766 RID: 30566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007766")]
		[Address(RVA = "0x2ED81B0", Offset = "0x2ED81B0", VA = "0x2ED81B0")]
		public void User_SetLegsParams(float muscleAmount = 1f, float muscleMultiplier = 1f, float onRagdoll = 1f)
		{
		}

		// Token: 0x06007767 RID: 30567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007767")]
		[Address(RVA = "0x2ED82E8", Offset = "0x2ED82E8", VA = "0x2ED82E8")]
		public IEnumerator IE_User_FadeLegsParams(float muscleAmount = 1f, float muscleMultiplier = 1f, float onRagdoll = 1f, float duration = 0.5f)
		{
			return null;
		}

		// Token: 0x06007768 RID: 30568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007768")]
		[Address(RVA = "0x2ED8388", Offset = "0x2ED8388", VA = "0x2ED8388")]
		public IEnumerator IE_User_FadePelvisParams(float muscleAmount = 1f, float muscleMultiplier = 1f, float onRagdoll = 1f, float duration = 0.5f)
		{
			return null;
		}

		// Token: 0x06007769 RID: 30569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007769")]
		[Address(RVA = "0x2ED8288", Offset = "0x2ED8288", VA = "0x2ED8288")]
		public void User_SetLeftLegParams(float muscleAmount = 1f, float muscleMultiplier = 1f, float onRagdoll = 1f)
		{
		}

		// Token: 0x0600776A RID: 30570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600776A")]
		[Address(RVA = "0x2ED82B8", Offset = "0x2ED82B8", VA = "0x2ED82B8")]
		public void User_SetRightLegParams(float muscleAmount = 1f, float muscleMultiplier = 1f, float onRagdoll = 1f)
		{
		}

		// Token: 0x0600776B RID: 30571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600776B")]
		[Address(RVA = "0x2ED81F0", Offset = "0x2ED81F0", VA = "0x2ED81F0")]
		public void User_SetSpineParams(float muscleAmount = 1f, float muscleMultiplier = 1f, float onRagdoll = 1f)
		{
		}

		// Token: 0x0600776C RID: 30572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600776C")]
		[Address(RVA = "0x2ED8428", Offset = "0x2ED8428", VA = "0x2ED8428")]
		public void User_SetPelvisParams(float muscleAmount = 1f, float muscleMultiplier = 1f, float onRagdoll = 1f)
		{
		}

		// Token: 0x0600776D RID: 30573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600776D")]
		[Address(RVA = "0x2ED8448", Offset = "0x2ED8448", VA = "0x2ED8448")]
		public void User_PoseAsInitalPose()
		{
		}

		// Token: 0x0600776E RID: 30574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600776E")]
		[Address(RVA = "0x2ED8504", Offset = "0x2ED8504", VA = "0x2ED8504")]
		public void User_PoseAsAnimator()
		{
		}

		// Token: 0x0600776F RID: 30575 RVA: 0x00052D70 File Offset: 0x00050F70
		[Token(Token = "0x600776F")]
		[Address(RVA = "0x2ED3184", Offset = "0x2ED3184", VA = "0x2ED3184")]
		internal Bounds User_GetRagdollBonesStateBounds(bool fast = true)
		{
			return default(Bounds);
		}

		// Token: 0x06007770 RID: 30576 RVA: 0x00052D88 File Offset: 0x00050F88
		[Token(Token = "0x6007770")]
		[Address(RVA = "0x2ED85C0", Offset = "0x2ED85C0", VA = "0x2ED85C0")]
		private bool IsSpinePosingBone(RagdollProcessor.PosingBone b)
		{
			return default(bool);
		}

		// Token: 0x06007771 RID: 30577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007771")]
		[Address(RVA = "0x2ED85FC", Offset = "0x2ED85FC", VA = "0x2ED85FC")]
		public RagdollProcessor.PosingBone User_GetPosingBoneWithRagdollDummyBone(Transform ragdollBone)
		{
			return null;
		}

		// Token: 0x06007772 RID: 30578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007772")]
		[Address(RVA = "0x2ED8684", Offset = "0x2ED8684", VA = "0x2ED8684")]
		public RagdollProcessor.PosingBone User_GetPosingBoneByAnimatorBone(Transform animatorBone)
		{
			return null;
		}

		// Token: 0x06007773 RID: 30579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007773")]
		[Address(RVA = "0x2ED870C", Offset = "0x2ED870C", VA = "0x2ED870C")]
		public RagdollProcessor.PosingBone User_GetNearestPosingBoneToPosition(Vector3 pos, bool fast = true, bool justSpine = false)
		{
			return null;
		}

		// Token: 0x06007774 RID: 30580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007774")]
		[Address(RVA = "0x2ED8938", Offset = "0x2ED8938", VA = "0x2ED8938")]
		public Collider User_GetNearestRagdollColliderToPosition(Vector3 pos, bool fast = true, bool justSpine = false)
		{
			return null;
		}

		// Token: 0x06007775 RID: 30581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007775")]
		[Address(RVA = "0x2ED895C", Offset = "0x2ED895C", VA = "0x2ED895C")]
		public Rigidbody User_GetNearestRagdollRigidbodyToPosition(Vector3 pos, bool fast = true, bool justSpine = false)
		{
			return null;
		}

		// Token: 0x06007776 RID: 30582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007776")]
		[Address(RVA = "0x2ED8980", Offset = "0x2ED8980", VA = "0x2ED8980")]
		public Transform User_GetNearestAnimatorTransformBoneToPosition(Vector3 pos, bool fast = true, bool justSpine = false)
		{
			return null;
		}

		// Token: 0x06007777 RID: 30583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007777")]
		[Address(RVA = "0x2ED89A4", Offset = "0x2ED89A4", VA = "0x2ED89A4")]
		public void User_FreezeAndDestroyRagdollDummy(bool disableAnimator = true)
		{
		}

		// Token: 0x06007778 RID: 30584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007778")]
		[Address(RVA = "0x2ED8AC0", Offset = "0x2ED8AC0", VA = "0x2ED8AC0")]
		public List<Rigidbody> User_GetAllRigidbodies()
		{
			return null;
		}

		// Token: 0x06007779 RID: 30585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007779")]
		[Address(RVA = "0x2ED8BF8", Offset = "0x2ED8BF8", VA = "0x2ED8BF8")]
		public List<RagdollProcessor.PosingBone> User_GetAllRagdollDummyControlBones()
		{
			return null;
		}

		// Token: 0x0600777A RID: 30586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600777A")]
		[Address(RVA = "0x2ED8D54", Offset = "0x2ED8D54", VA = "0x2ED8D54")]
		public RagdollProcessor()
		{
		}

		// Token: 0x0400309F RID: 12447
		[Token(Token = "0x400309F")]
		[FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public RagdollGeneratorParameters GeneratorParameters;

		// Token: 0x040030A0 RID: 12448
		[Token(Token = "0x40030A0")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("Game object which has component with 'IRagdollAnimatorReceiver' interface implented   OR  has public methods like 'ERagColl(RagdollCollisionHelper c)' or 'ERagCollExit(RagdollCollisionHelper c)' to handle collisions (gameObject.SendMessage approach)")]
		public GameObject SendCollisionEventsTo;

		// Token: 0x040030A1 RID: 12449
		[Token(Token = "0x40030A1")]
		[FieldOffset(Offset = "0x20")]
		public bool SendOnlyOnFreeFall;

		// Token: 0x040030A2 RID: 12450
		[Token(Token = "0x40030A2")]
		[FieldOffset(Offset = "0x21")]
		[Tooltip("Adding extra - helper components to each ragdoll collider. (it's added anyway if using collision events or blend on collision but if you don't use mentioned features, you can force adding helper enabling this toggle)")]
		public bool AlwaysAddCollisionHelpers;

		// Token: 0x040030A3 RID: 12451
		[Token(Token = "0x40030A3")]
		[FieldOffset(Offset = "0x22")]
		[Space(3f)]
		[Tooltip("Not destroying colliders on the original animator skeleton")]
		public bool KeepCollidersOnAnimator;

		// Token: 0x040030A4 RID: 12452
		[Token(Token = "0x40030A4")]
		[FieldOffset(Offset = "0x24")]
		[FPD_Layers]
		public int ChangeAnimatorCollidersLayerTo;

		// Token: 0x040030A5 RID: 12453
		[Token(Token = "0x40030A5")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Removing colliders on only ragdoll representation bones on the animator")]
		public bool RemoveOnlyTargetRagdollCollidersOnAnimator;

		// Token: 0x040030A6 RID: 12454
		[Token(Token = "0x40030A6")]
		[FieldOffset(Offset = "0x29")]
		[Tooltip("Triggering physics collision ignore between the bones left on the animator and ragdoll bones")]
		public bool IgnoreAnimatorToRagdollCollision;

		// Token: 0x040030A7 RID: 12455
		[Token(Token = "0x40030A7")]
		[FieldOffset(Offset = "0x2A")]
		[Tooltip("By default search is checking if some bones names starts with target name, but you can switch it to check full name to prevent issues (probably will be enabled by default in the future)")]
		public bool CheckFullBoneNamesWhenSearching;

		// Token: 0x040030A8 RID: 12456
		[Token(Token = "0x40030A8")]
		[FieldOffset(Offset = "0x2B")]
		[Tooltip("Ragdoll animator calculations are required even if blend is zero, but for performance rasons you can try disabling it (it's switching ragdoll dummy colliders isKinematic!)\nNot Working with 'Blend On Collision' feature!")]
		public bool AllowDisableCalculationsOnZeroBlend;

		// Token: 0x040030A9 RID: 12457
		[Token(Token = "0x40030A9")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Extra algorithm for syncing main ragdoll dummy rigidbodies (spine, upper arms) to animator pose on collision happening.")]
		public bool HardSyncOnCollision;

		// Token: 0x040030AA RID: 12458
		[Token(Token = "0x40030AA")]
		[FieldOffset(Offset = "0x2D")]
		private bool triedFindingReceiver;

		// Token: 0x040030AB RID: 12459
		[Token(Token = "0x40030AB")]
		[FieldOffset(Offset = "0x30")]
		private RagdollProcessor.IRagdollAnimatorReceiver receiveDetected;

		// Token: 0x040030AC RID: 12460
		[Token(Token = "0x40030AC")]
		[FieldOffset(Offset = "0x38")]
		internal RotationDriveMode RotationMode;

		// Token: 0x040030AD RID: 12461
		[Token(Token = "0x40030AD")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("With FreeFallRagdoll enabled you should put ragdoll amount to 100% to make character fall on ground.\n\nWith FreeFallRagdoll disabled you can blend ragdoll with animator in few different ways.")]
		public bool FreeFallRagdoll;

		// Token: 0x040030AE RID: 12462
		[Token(Token = "0x40030AE")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Constant amount of ragdoll on model.\n\nWith FreeFallRagdoll enabled you should put ragdoll amount to 100% to make character fall on ground.")]
		[FPD_Suffix(0f, 1f, FPD_SuffixAttribute.SuffixMode.From0to100, "%", true, 0)]
		public float RagdolledBlend;

		// Token: 0x040030AF RID: 12463
		[Token(Token = "0x40030AF")]
		[FieldOffset(Offset = "0x44")]
		[NonSerialized]
		public float User_BlendMultiplier;

		// Token: 0x040030B0 RID: 12464
		[Token(Token = "0x40030B0")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("How much strength should be used to rotate towards target pose")]
		[Range(0f, 1f)]
		public float RotateToPoseForce;

		// Token: 0x040030B1 RID: 12465
		[Token(Token = "0x40030B1")]
		[FieldOffset(Offset = "0x4C")]
		[Range(1f, 16f)]
		[Tooltip("Quality of unity physical iterations")]
		public int UnitySolverIterations;

		// Token: 0x040030B2 RID: 12466
		[Token(Token = "0x40030B2")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("If you want to smoothly enable partial ragdoll on bone collision (when ragdoll is NOT during free-fall state)")]
		public bool BlendOnCollision;

		// Token: 0x040030B3 RID: 12467
		[Token(Token = "0x40030B3")]
		[FieldOffset(Offset = "0x51")]
		private bool wasBlendOnCollision;

		// Token: 0x040030B4 RID: 12468
		[Token(Token = "0x40030B4")]
		[FieldOffset(Offset = "0x52")]
		private bool wasSensitiveColliding;

		// Token: 0x040030B5 RID: 12469
		[Token(Token = "0x40030B5")]
		[FieldOffset(Offset = "0x54")]
		[Space(4f)]
		[Tooltip("Partial ragdoll amount - making arms always ragdolled with certain amount")]
		[Range(0f, 1f)]
		public float ConstantArmsRagdoll;

		// Token: 0x040030B6 RID: 12470
		[Token(Token = "0x40030B6")]
		[FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		[Tooltip("Partial ragdoll amount - making head always ragdolled with certain amount")]
		public float ConstantHeadRagdoll;

		// Token: 0x040030B7 RID: 12471
		[Token(Token = "0x40030B7")]
		[FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		[Tooltip("Partial ragdoll amount - making spine always ragdolled with certain amount")]
		public float ConstantSpineRagdoll;

		// Token: 0x040030B8 RID: 12472
		[Token(Token = "0x40030B8")]
		[FieldOffset(Offset = "0x60")]
		[Tooltip("How sudden should be auto-blending to ragdoll on collisions when using partial ragdoll")]
		[Range(0f, 1f)]
		public float BlendingSpeed;

		// Token: 0x040030B9 RID: 12473
		[Token(Token = "0x40030B9")]
		[FieldOffset(Offset = "0x64")]
		[Tooltip("If arms collision should trigger blending for upper spine to keep bones rotation more synced")]
		public bool SensitiveCollision;

		// Token: 0x040030BA RID: 12474
		[Token(Token = "0x40030BA")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("Spring applies more power towards target pose")]
		[FPD_Header("Spring and damp only with configurable joints", 6f, 4f, 2)]
		public float ConfigurableSpring;

		// Token: 0x040030BB RID: 12475
		[Token(Token = "0x40030BB")]
		[FieldOffset(Offset = "0x6C")]
		[NonSerialized]
		public float OutConfigurableSpring;

		// Token: 0x040030BC RID: 12476
		[Token(Token = "0x40030BC")]
		[FieldOffset(Offset = "0x70")]
		[Tooltip("Damp power for physical joints - can reduce bouncy effect but require more spring")]
		public float ConfigurableDamp;

		// Token: 0x040030BD RID: 12477
		[Token(Token = "0x40030BD")]
		[FieldOffset(Offset = "0x74")]
		[Tooltip("If using Hips Pin feature - spring power for hips")]
		public float HipsPinSpring;

		// Token: 0x040030BE RID: 12478
		[Token(Token = "0x40030BE")]
		[FieldOffset(Offset = "0x78")]
		[Tooltip("Additional Custom hips offset when using Hips Pin Feature (local/configurable space offset)")]
		public Vector3 HipsPositionOffset;

		// Token: 0x040030BF RID: 12479
		[Token(Token = "0x40030BF")]
		[FieldOffset(Offset = "0x84")]
		[Tooltip("Boosting animator influence on the different axis of the hips pin")]
		public Vector3 HipsBoostMul;

		// Token: 0x040030C0 RID: 12480
		[Token(Token = "0x40030C0")]
		[FieldOffset(Offset = "0x90")]
		[Tooltip("Experimental different way to animate hips pin")]
		public bool HipsPinV2;

		// Token: 0x040030C1 RID: 12481
		[Token(Token = "0x40030C1")]
		[FieldOffset(Offset = "0x94")]
		[Tooltip("Used only when performing Stad Up animation from ragdolled state!\n\nUsing method User_RepositionRoot() will move model to ragdoll position, it depends on your Stand Up animations - if stand up animation is placed fully in model center, set this slider to zero: then object will be positioned to start in model center\nIf stand up animation origin is placed in foots position (bottom of body) then set slider to 1: so model will be fitted to foot position")]
		[Range(0f, 1f)]
		[FPD_Header("More custom settings", 6f, 4f, 2)]
		public float StandUpInFootPoint;

		// Token: 0x040030C2 RID: 12482
		[Token(Token = "0x40030C2")]
		[FieldOffset(Offset = "0x98")]
		[Range(0f, 1f)]
		[Space(6f)]
		[Tooltip("If this limbs should have different muscle power than others")]
		public float HeadForce;

		// Token: 0x040030C3 RID: 12483
		[Token(Token = "0x40030C3")]
		[FieldOffset(Offset = "0x9C")]
		[Range(0f, 1f)]
		[Tooltip("If this limbs should have different muscle power than others")]
		public float SpineForce;

		// Token: 0x040030C4 RID: 12484
		[Token(Token = "0x40030C4")]
		[FieldOffset(Offset = "0xA0")]
		[Range(0f, 1f)]
		[Tooltip("If this limbs should have different muscle power than others")]
		public float RightArmForce;

		// Token: 0x040030C5 RID: 12485
		[Token(Token = "0x40030C5")]
		[FieldOffset(Offset = "0xA4")]
		[Range(0f, 1f)]
		[Tooltip("If this limbs should have different muscle power than others")]
		public float LeftArmForce;

		// Token: 0x040030C6 RID: 12486
		[Token(Token = "0x40030C6")]
		[FieldOffset(Offset = "0xA8")]
		[Tooltip("If this limbs should have different muscle power than others")]
		[Range(0f, 1f)]
		public float LeftLegForce;

		// Token: 0x040030C7 RID: 12487
		[Token(Token = "0x40030C7")]
		[FieldOffset(Offset = "0xAC")]
		[Tooltip("If this limbs should have different muscle power than others")]
		[Range(0f, 1f)]
		public float RightLegForce;

		// Token: 0x040030C8 RID: 12488
		[Token(Token = "0x40030C8")]
		[FieldOffset(Offset = "0xB0")]
		[Tooltip("Use SwitchAllExtendedAnimatorSync() method if you want to switch this feature through code!\n\nTrying to sync shoulder and additional spine bones on ragdoll to make ragdoll animated pose synced more precisely with animator.")]
		public RagdollProcessor.ESyncMode ExtendedAnimatorSync;

		// Token: 0x040030C9 RID: 12489
		[Token(Token = "0x40030C9")]
		[FieldOffset(Offset = "0xB4")]
		[Tooltip("If character gets free-fall ragdolled and you want the BaseTransform to follow ragdoll dummy position, use this parameter")]
		public RagdollProcessor.EBaseTransformRepose ReposeMode;

		// Token: 0x040030CA RID: 12490
		[Token(Token = "0x40030CA")]
		[FieldOffset(Offset = "0xB8")]
		[Tooltip("Allow reposing only when ragdoll blend is >99%")]
		public bool ReposeOnlyOnFullRagdoll;

		// Token: 0x040030CB RID: 12491
		[Token(Token = "0x40030CB")]
		[FieldOffset(Offset = "0xB9")]
		[Tooltip("Ignore all self skeleton colliders collision")]
		public bool IgnoreSelfCollision;

		// Token: 0x040030CC RID: 12492
		[Token(Token = "0x40030CC")]
		[FieldOffset(Offset = "0xBC")]
		[Tooltip("Multiply mass (using initial mass) of the rigidbody (updated on start and on FreeFall Switching)")]
		public float MassMultiplier;

		// Token: 0x040030CD RID: 12493
		[Token(Token = "0x40030CD")]
		[FieldOffset(Offset = "0xC0")]
		[Tooltip("If not null, applying on start this physical material to all of the ragdoll dummy colliders")]
		public PhysicMaterial SetPhysicalMaterial;

		// Token: 0x040030CE RID: 12494
		[Token(Token = "0x40030CE")]
		[FieldOffset(Offset = "0xC8")]
		[Tooltip("(only for configurable joints) Removing rotation limits from ConfigurableJoints when not using 'Free Fall' mode: it can help animation matching to allow bones rotate as animator demands.")]
		public bool RemoveLimitsWhenNonFreeFall;

		// Token: 0x040030CF RID: 12495
		[Token(Token = "0x40030CF")]
		[FieldOffset(Offset = "0xC9")]
		[Tooltip("If you want to hide generated ragdoll dummy in hierarchy view for more clarity insight during playmode")]
		public bool HideDummy;

		// Token: 0x040030D0 RID: 12496
		[Token(Token = "0x40030D0")]
		[FieldOffset(Offset = "0xD0")]
		[Tooltip("Ignoring collision with provided colliders (called just on start)")]
		public List<Collider> IgnoreCollisionWith;

		// Token: 0x040030D1 RID: 12497
		[Token(Token = "0x40030D1")]
		[FieldOffset(Offset = "0xD8")]
		[Tooltip("(Experimental) Enabling feature of keeping pelvis with physics instead of making it kinematic")]
		public bool HipsPin;

		// Token: 0x040030D2 RID: 12498
		[Token(Token = "0x40030D2")]
		[FieldOffset(Offset = "0xDC")]
		[Tooltip("Apply pelvis animation with the keyframe animation (not free fall mode).\nV2 is applying more spring force to the muscles when non-free-fall.")]
		public RagdollProcessor.EAnimatePelvis TryAnimatePelvis;

		// Token: 0x040030D3 RID: 12499
		[Token(Token = "0x40030D3")]
		[FieldOffset(Offset = "0xE0")]
		[Tooltip("Initializing component after few frames")]
		public bool StartAfterTPose;

		// Token: 0x040030D4 RID: 12500
		[Token(Token = "0x40030D4")]
		[FieldOffset(Offset = "0xE1")]
		[Tooltip("If you use plugin which is resetting automatically some rigidbody settings, you can enable it to avoid glitches")]
		public bool ResetIsKinematic;

		// Token: 0x040030D5 RID: 12501
		[Token(Token = "0x40030D5")]
		[FieldOffset(Offset = "0xE2")]
		[Tooltip("Calling 'DontDestroyOnLoad, useful if you change scenes wich player character and you want to keep the same ragdoll animator")]
		public bool Persistent;

		// Token: 0x040030D6 RID: 12502
		[Token(Token = "0x40030D6")]
		[FieldOffset(Offset = "0xE3")]
		[Tooltip("If your animator have enabled 'AnimatePhysics' update mode, you should enable it here too")]
		public bool AnimatePhysics;

		// Token: 0x040030D7 RID: 12503
		[Token(Token = "0x40030D7")]
		[FieldOffset(Offset = "0xE4")]
		[Tooltip("If you want to add 'R_' name prefix to generated dummy transforms. It can be helpful to avoid errors of the animation rigging unity plugin naming conflicts.")]
		public bool AddNamePrefix;

		// Token: 0x040030D8 RID: 12504
		[Token(Token = "0x40030D8")]
		[FieldOffset(Offset = "0xE5")]
		[Tooltip("If you encounter error with skeleton hips placed in foot position of the skeleton")]
		public bool FixRootInPelvis;

		// Token: 0x040030D9 RID: 12505
		[Token(Token = "0x40030D9")]
		[FieldOffset(Offset = "0xE6")]
		[Tooltip("If some bones of your characters seems to fall without physical power, you can try enabling this")]
		public bool Calibrate;

		// Token: 0x040030DA RID: 12506
		[Token(Token = "0x40030DA")]
		[FieldOffset(Offset = "0xE8")]
		public RagdollProcessor.EBonesSetupMode BonesSetupMode;

		// Token: 0x040030DB RID: 12507
		[Token(Token = "0x40030DB")]
		[FieldOffset(Offset = "0xF0")]
		public List<RagdollProcessor.BonesChain> CustomLimbsBonesChains;

		// Token: 0x040030DC RID: 12508
		[Token(Token = "0x40030DC")]
		[FieldOffset(Offset = "0xF8")]
		[HideInInspector]
		[SerializeField]
		private RagdollProcessor.RagdollBoneSetup _pelvisSetupBone;

		// Token: 0x040030E2 RID: 12514
		[Token(Token = "0x40030E2")]
		[FieldOffset(Offset = "0x128")]
		private Transform containerForDummy;

		// Token: 0x040030E4 RID: 12516
		[Token(Token = "0x40030E4")]
		[FieldOffset(Offset = "0x138")]
		private bool collisionHelpersAdded;

		// Token: 0x040030E5 RID: 12517
		[Token(Token = "0x40030E5")]
		[FieldOffset(Offset = "0x140")]
		private MonoBehaviour parentCaller;

		// Token: 0x040030E6 RID: 12518
		[Token(Token = "0x40030E6")]
		[FieldOffset(Offset = "0x148")]
		private Vector3 pelvisAnimatorPosition;

		// Token: 0x040030E7 RID: 12519
		[Token(Token = "0x40030E7")]
		[FieldOffset(Offset = "0x154")]
		private Vector3 pelvisAnimatorLocalPosition;

		// Token: 0x040030E8 RID: 12520
		[Token(Token = "0x40030E8")]
		[FieldOffset(Offset = "0x160")]
		private Quaternion pelvisAnimatorRotation;

		// Token: 0x040030E9 RID: 12521
		[Token(Token = "0x40030E9")]
		[FieldOffset(Offset = "0x170")]
		private Quaternion pelvisAnimatorLocalRotation;

		// Token: 0x040030EA RID: 12522
		[Token(Token = "0x40030EA")]
		[FieldOffset(Offset = "0x180")]
		private float spineCulldown;

		// Token: 0x040030EB RID: 12523
		[Token(Token = "0x40030EB")]
		[FieldOffset(Offset = "0x184")]
		private float chestCulldown;

		// Token: 0x040030EC RID: 12524
		[Token(Token = "0x40030EC")]
		[FieldOffset(Offset = "0x188")]
		private float minChestAnim;

		// Token: 0x040030ED RID: 12525
		[Token(Token = "0x40030ED")]
		[FieldOffset(Offset = "0x18C")]
		private float sd_minChestAnim;

		// Token: 0x040030EE RID: 12526
		[Token(Token = "0x40030EE")]
		[FieldOffset(Offset = "0x190")]
		private float minSpineAnim;

		// Token: 0x040030EF RID: 12527
		[Token(Token = "0x40030EF")]
		[FieldOffset(Offset = "0x194")]
		private float sd_minSpineAnim;

		// Token: 0x040030F0 RID: 12528
		[Token(Token = "0x40030F0")]
		[FieldOffset(Offset = "0x198")]
		private float larmCulldown;

		// Token: 0x040030F1 RID: 12529
		[Token(Token = "0x40030F1")]
		[FieldOffset(Offset = "0x19C")]
		private float rarmCulldown;

		// Token: 0x040030F2 RID: 12530
		[Token(Token = "0x40030F2")]
		[FieldOffset(Offset = "0x1A0")]
		private float minRArmsAnim;

		// Token: 0x040030F3 RID: 12531
		[Token(Token = "0x40030F3")]
		[FieldOffset(Offset = "0x1A4")]
		private float lminArmsAnim;

		// Token: 0x040030F4 RID: 12532
		[Token(Token = "0x40030F4")]
		[FieldOffset(Offset = "0x1A8")]
		private float sd_lminArmsAnim;

		// Token: 0x040030F5 RID: 12533
		[Token(Token = "0x40030F5")]
		[FieldOffset(Offset = "0x1AC")]
		private float sd_minRArmsAnim;

		// Token: 0x040030F6 RID: 12534
		[Token(Token = "0x40030F6")]
		[FieldOffset(Offset = "0x1B0")]
		private float headCulldown;

		// Token: 0x040030F7 RID: 12535
		[Token(Token = "0x40030F7")]
		[FieldOffset(Offset = "0x1B4")]
		private float minHeadAnim;

		// Token: 0x040030F8 RID: 12536
		[Token(Token = "0x40030F8")]
		[FieldOffset(Offset = "0x1B8")]
		private float sd_minHeadAnim;

		// Token: 0x040030F9 RID: 12537
		[Token(Token = "0x40030F9")]
		[FieldOffset(Offset = "0x1BC")]
		private float fadeOutSpd;

		// Token: 0x040030FA RID: 12538
		[Token(Token = "0x40030FA")]
		[FieldOffset(Offset = "0x1C0")]
		private float fadeInSpd;

		// Token: 0x040030FB RID: 12539
		[Token(Token = "0x40030FB")]
		[FieldOffset(Offset = "0x1C4")]
		[NonSerialized]
		public float constantLeftArmRagdoll;

		// Token: 0x040030FC RID: 12540
		[Token(Token = "0x40030FC")]
		[FieldOffset(Offset = "0x1C8")]
		[NonSerialized]
		public float constantRightArmRagdoll;

		// Token: 0x040030FD RID: 12541
		[Token(Token = "0x40030FD")]
		[FieldOffset(Offset = "0x1CC")]
		private float latestHipsBlend;

		// Token: 0x040030FE RID: 12542
		[Token(Token = "0x40030FE")]
		[FieldOffset(Offset = "0x1D0")]
		private float _transitionNonFreeFall_OverrideMaxBlend;

		// Token: 0x040030FF RID: 12543
		[Token(Token = "0x40030FF")]
		[FieldOffset(Offset = "0x1D4")]
		private bool fixedUpdated;

		// Token: 0x04003100 RID: 12544
		[Token(Token = "0x4003100")]
		[FieldOffset(Offset = "0x1D5")]
		private bool lastFreeFall;

		// Token: 0x04003101 RID: 12545
		[Token(Token = "0x4003101")]
		[FieldOffset(Offset = "0x1D8")]
		private int fixedFrames;

		// Token: 0x04003102 RID: 12546
		[Token(Token = "0x4003102")]
		[FieldOffset(Offset = "0x1DC")]
		private float delta;

		// Token: 0x04003103 RID: 12547
		[Token(Token = "0x4003103")]
		[FieldOffset(Offset = "0x1E0")]
		private bool canDisableCalculations;

		// Token: 0x04003104 RID: 12548
		[Token(Token = "0x4003104")]
		[FieldOffset(Offset = "0x1E4")]
		private Vector3 hipsToRootLocal;

		// Token: 0x04003105 RID: 12549
		[Token(Token = "0x4003105")]
		[FieldOffset(Offset = "0x1F0")]
		private Quaternion hipsToRootLocalRot;

		// Token: 0x04003106 RID: 12550
		[Token(Token = "0x4003106")]
		[FieldOffset(Offset = "0x200")]
		private Dictionary<Transform, RagdollProcessor.PosingBone> _GetBoneDict;

		// Token: 0x04003107 RID: 12551
		[Token(Token = "0x4003107")]
		[FieldOffset(Offset = "0x208")]
		private List<RagdollProcessor.ToAnimateBone> toReanimateBones;

		// Token: 0x04003108 RID: 12552
		[Token(Token = "0x4003108")]
		[FieldOffset(Offset = "0x210")]
		public Vector3 DebugV3;

		// Token: 0x04003109 RID: 12553
		[Token(Token = "0x4003109")]
		[FieldOffset(Offset = "0x220")]
		internal Behaviour animator;

		// Token: 0x0400310A RID: 12554
		[Token(Token = "0x400310A")]
		[FieldOffset(Offset = "0x228")]
		internal Animator mecanim;

		// Token: 0x0400310B RID: 12555
		[Token(Token = "0x400310B")]
		[FieldOffset(Offset = "0x230")]
		internal Animation legacyAnim;

		// Token: 0x0400310C RID: 12556
		[Token(Token = "0x400310C")]
		[FieldOffset(Offset = "0x238")]
		[HideInInspector]
		public Transform ObjectWithAnimator;

		// Token: 0x0400310D RID: 12557
		[Token(Token = "0x400310D")]
		[FieldOffset(Offset = "0x240")]
		public Transform RagdollDummyBase;

		// Token: 0x0400310E RID: 12558
		[Token(Token = "0x400310E")]
		[FieldOffset(Offset = "0x248")]
		[HideInInspector]
		public Transform RagdollDummyRoot;

		// Token: 0x0400310F RID: 12559
		[Token(Token = "0x400310F")]
		[FieldOffset(Offset = "0x250")]
		[HideInInspector]
		public Transform RagdollDummySkeleton;

		// Token: 0x04003110 RID: 12560
		[Token(Token = "0x4003110")]
		[FieldOffset(Offset = "0x258")]
		[HideInInspector]
		public Transform RootInParent;

		// Token: 0x04003111 RID: 12561
		[Token(Token = "0x4003111")]
		[FieldOffset(Offset = "0x260")]
		[HideInInspector]
		public Transform PelvisInDummy;

		// Token: 0x04003112 RID: 12562
		[Token(Token = "0x4003112")]
		[FieldOffset(Offset = "0x268")]
		[HideInInspector]
		public Transform RagdollDummyAnimator;

		// Token: 0x04003113 RID: 12563
		[Token(Token = "0x4003113")]
		[FieldOffset(Offset = "0x270")]
		[SerializeField]
		[HideInInspector]
		private string _helpChestName;

		// Token: 0x04003114 RID: 12564
		[Token(Token = "0x4003114")]
		[FieldOffset(Offset = "0x278")]
		public List<Type> moveCompsToDummy;

		// Token: 0x04003115 RID: 12565
		[Token(Token = "0x4003115")]
		[FieldOffset(Offset = "0x280")]
		[HideInInspector]
		[SerializeField]
		private bool usePreGeneratedDummy;

		// Token: 0x04003116 RID: 12566
		[Token(Token = "0x4003116")]
		[FieldOffset(Offset = "0x288")]
		public Transform BaseTransform;

		// Token: 0x04003117 RID: 12567
		[Token(Token = "0x4003117")]
		[FieldOffset(Offset = "0x290")]
		public Transform Pelvis;

		// Token: 0x04003118 RID: 12568
		[Token(Token = "0x4003118")]
		[FieldOffset(Offset = "0x298")]
		public Transform SpineStart;

		// Token: 0x04003119 RID: 12569
		[Token(Token = "0x4003119")]
		[FieldOffset(Offset = "0x2A0")]
		[Tooltip("Chest is optional bone, you can leave this field empty if you have small amount of spine bones")]
		public Transform Chest;

		// Token: 0x0400311A RID: 12570
		[Token(Token = "0x400311A")]
		[FieldOffset(Offset = "0x2A8")]
		public Transform Head;

		// Token: 0x0400311B RID: 12571
		[Token(Token = "0x400311B")]
		[FieldOffset(Offset = "0x2B0")]
		public Transform LeftUpperArm;

		// Token: 0x0400311C RID: 12572
		[Token(Token = "0x400311C")]
		[FieldOffset(Offset = "0x2B8")]
		public Transform LeftForeArm;

		// Token: 0x0400311D RID: 12573
		[Token(Token = "0x400311D")]
		[FieldOffset(Offset = "0x2C0")]
		public Transform RightUpperArm;

		// Token: 0x0400311E RID: 12574
		[Token(Token = "0x400311E")]
		[FieldOffset(Offset = "0x2C8")]
		public Transform RightForeArm;

		// Token: 0x0400311F RID: 12575
		[Token(Token = "0x400311F")]
		[FieldOffset(Offset = "0x2D0")]
		public Transform LeftUpperLeg;

		// Token: 0x04003120 RID: 12576
		[Token(Token = "0x4003120")]
		[FieldOffset(Offset = "0x2D8")]
		public Transform LeftLowerLeg;

		// Token: 0x04003121 RID: 12577
		[Token(Token = "0x4003121")]
		[FieldOffset(Offset = "0x2E0")]
		public Transform RightUpperLeg;

		// Token: 0x04003122 RID: 12578
		[Token(Token = "0x4003122")]
		[FieldOffset(Offset = "0x2E8")]
		public Transform RightLowerLeg;

		// Token: 0x04003123 RID: 12579
		[Token(Token = "0x4003123")]
		[FieldOffset(Offset = "0x2F0")]
		public Transform LeftFist;

		// Token: 0x04003124 RID: 12580
		[Token(Token = "0x4003124")]
		[FieldOffset(Offset = "0x2F8")]
		public Transform RightFist;

		// Token: 0x04003125 RID: 12581
		[Token(Token = "0x4003125")]
		[FieldOffset(Offset = "0x300")]
		public Transform LeftFoot;

		// Token: 0x04003126 RID: 12582
		[Token(Token = "0x4003126")]
		[FieldOffset(Offset = "0x308")]
		public Transform RightFoot;

		// Token: 0x04003127 RID: 12583
		[Token(Token = "0x4003127")]
		[FieldOffset(Offset = "0x310")]
		public Transform LeftShoulder;

		// Token: 0x04003128 RID: 12584
		[Token(Token = "0x4003128")]
		[FieldOffset(Offset = "0x318")]
		public Transform RightShoulder;

		// Token: 0x04003129 RID: 12585
		[Token(Token = "0x4003129")]
		[FieldOffset(Offset = "0x320")]
		public Vector3 PelvisLocalRight;

		// Token: 0x0400312A RID: 12586
		[Token(Token = "0x400312A")]
		[FieldOffset(Offset = "0x32C")]
		public Vector3 PelvisLocalUp;

		// Token: 0x0400312B RID: 12587
		[Token(Token = "0x400312B")]
		[FieldOffset(Offset = "0x338")]
		public Vector3 PelvisLocalForward;

		// Token: 0x0400312C RID: 12588
		[Token(Token = "0x400312C")]
		[FieldOffset(Offset = "0x344")]
		public Vector3 PelvisToBase;

		// Token: 0x0400312D RID: 12589
		[Token(Token = "0x400312D")]
		[FieldOffset(Offset = "0x350")]
		public Vector3 LForearmToHand;

		// Token: 0x0400312E RID: 12590
		[Token(Token = "0x400312E")]
		[FieldOffset(Offset = "0x35C")]
		public Vector3 RForearmToHand;

		// Token: 0x0400312F RID: 12591
		[Token(Token = "0x400312F")]
		[FieldOffset(Offset = "0x368")]
		public Vector3 HeadToTip;

		// Token: 0x04003130 RID: 12592
		[Token(Token = "0x4003130")]
		[FieldOffset(Offset = "0x374")]
		private Vector3 _previousPelvisFixedPosition;

		// Token: 0x04003131 RID: 12593
		[Token(Token = "0x4003131")]
		[FieldOffset(Offset = "0x380")]
		private Vector3 _pelvisVelocityReference;

		// Token: 0x04003132 RID: 12594
		[Token(Token = "0x4003132")]
		[FieldOffset(Offset = "0x38C")]
		private float _initialPelvisToHeadDistanceSqrt;

		// Token: 0x04003133 RID: 12595
		[Token(Token = "0x4003133")]
		[FieldOffset(Offset = "0x390")]
		private RagdollProcessor.PosingBone posingPelvis;

		// Token: 0x04003134 RID: 12596
		[Token(Token = "0x4003134")]
		[FieldOffset(Offset = "0x398")]
		private RagdollProcessor.PosingBone posingSpineStart;

		// Token: 0x04003135 RID: 12597
		[Token(Token = "0x4003135")]
		[FieldOffset(Offset = "0x3A0")]
		private RagdollProcessor.PosingBone posingChest;

		// Token: 0x04003136 RID: 12598
		[Token(Token = "0x4003136")]
		[FieldOffset(Offset = "0x3A8")]
		private RagdollProcessor.PosingBone posingHead;

		// Token: 0x04003137 RID: 12599
		[Token(Token = "0x4003137")]
		[FieldOffset(Offset = "0x3B0")]
		private RagdollProcessor.PosingBone posingLeftUpperArm;

		// Token: 0x04003138 RID: 12600
		[Token(Token = "0x4003138")]
		[FieldOffset(Offset = "0x3B8")]
		private RagdollProcessor.PosingBone posingLeftForeArm;

		// Token: 0x04003139 RID: 12601
		[Token(Token = "0x4003139")]
		[FieldOffset(Offset = "0x3C0")]
		private RagdollProcessor.PosingBone posingRightUpperArm;

		// Token: 0x0400313A RID: 12602
		[Token(Token = "0x400313A")]
		[FieldOffset(Offset = "0x3C8")]
		private RagdollProcessor.PosingBone posingRightForeArm;

		// Token: 0x0400313B RID: 12603
		[Token(Token = "0x400313B")]
		[FieldOffset(Offset = "0x3D0")]
		private RagdollProcessor.PosingBone posingLeftUpperLeg;

		// Token: 0x0400313C RID: 12604
		[Token(Token = "0x400313C")]
		[FieldOffset(Offset = "0x3D8")]
		private RagdollProcessor.PosingBone posingLeftLowerLeg;

		// Token: 0x0400313D RID: 12605
		[Token(Token = "0x400313D")]
		[FieldOffset(Offset = "0x3E0")]
		private RagdollProcessor.PosingBone posingRightUpperLeg;

		// Token: 0x0400313E RID: 12606
		[Token(Token = "0x400313E")]
		[FieldOffset(Offset = "0x3E8")]
		private RagdollProcessor.PosingBone posingRightLowerLeg;

		// Token: 0x0400313F RID: 12607
		[Token(Token = "0x400313F")]
		[FieldOffset(Offset = "0x3F0")]
		private RagdollProcessor.PosingBone posingLeftFist;

		// Token: 0x04003140 RID: 12608
		[Token(Token = "0x4003140")]
		[FieldOffset(Offset = "0x3F8")]
		private RagdollProcessor.PosingBone posingLeftFoot;

		// Token: 0x04003141 RID: 12609
		[Token(Token = "0x4003141")]
		[FieldOffset(Offset = "0x400")]
		private RagdollProcessor.PosingBone posingRightFist;

		// Token: 0x04003142 RID: 12610
		[Token(Token = "0x4003142")]
		[FieldOffset(Offset = "0x408")]
		private RagdollProcessor.PosingBone posingRightFoot;

		// Token: 0x04003143 RID: 12611
		[Token(Token = "0x4003143")]
		[FieldOffset(Offset = "0x410")]
		private RagdollProcessor.PosingBone posingLeftShoulder;

		// Token: 0x04003144 RID: 12612
		[Token(Token = "0x4003144")]
		[FieldOffset(Offset = "0x418")]
		private RagdollProcessor.PosingBone posingRightShoulder;

		// Token: 0x04003146 RID: 12614
		[Token(Token = "0x4003146")]
		[FieldOffset(Offset = "0x424")]
		private float _getUp_latestProbeTime;

		// Token: 0x04003147 RID: 12615
		[Token(Token = "0x4003147")]
		[FieldOffset(Offset = "0x428")]
		private float _getUp_latestVeloProbeTime;

		// Token: 0x04003148 RID: 12616
		[Token(Token = "0x4003148")]
		[FieldOffset(Offset = "0x42C")]
		private RagdollProcessor.EGetUpType _getUp_latestGetUpType;

		// Token: 0x04003149 RID: 12617
		[Token(Token = "0x4003149")]
		[FieldOffset(Offset = "0x430")]
		private Vector3 _getUp_latestSpineLimbsVelocity;

		// Token: 0x0400314A RID: 12618
		[Token(Token = "0x400314A")]
		[FieldOffset(Offset = "0x43C")]
		private float _getUp_latestSpineLimbsVelocityMagn;

		// Token: 0x0400314B RID: 12619
		[Token(Token = "0x400314B")]
		[FieldOffset(Offset = "0x440")]
		private float _getUp_stabilityTimer;

		// Token: 0x02000C2D RID: 3117
		[Token(Token = "0x2000C2D")]
		public interface IRagdollAnimatorReceiver
		{
			// Token: 0x0600777B RID: 30587
			[Token(Token = "0x600777B")]
			void RagdAnim_OnCollisionExitEvent(RagdollCollisionHelper c);

			// Token: 0x0600777C RID: 30588
			[Token(Token = "0x600777C")]
			void RagdAnim_OnCollisionEnterEvent(RagdollCollisionHelper c);
		}

		// Token: 0x02000C2E RID: 3118
		[Token(Token = "0x2000C2E")]
		public enum EBaseTransformRepose
		{
			// Token: 0x0400314D RID: 12621
			[Token(Token = "0x400314D")]
			None,
			// Token: 0x0400314E RID: 12622
			[Token(Token = "0x400314E")]
			BonesBoundsBottomCenter,
			// Token: 0x0400314F RID: 12623
			[Token(Token = "0x400314F")]
			HipsToFootPosition
		}

		// Token: 0x02000C2F RID: 3119
		[Token(Token = "0x2000C2F")]
		public enum EAnimatePelvis
		{
			// Token: 0x04003151 RID: 12625
			[Token(Token = "0x4003151")]
			None,
			// Token: 0x04003152 RID: 12626
			[Token(Token = "0x4003152")]
			V1,
			// Token: 0x04003153 RID: 12627
			[Token(Token = "0x4003153")]
			V2
		}

		// Token: 0x02000C30 RID: 3120
		[Token(Token = "0x2000C30")]
		public enum EBonesSetupMode
		{
			// Token: 0x04003155 RID: 12629
			[Token(Token = "0x4003155")]
			HumanoidLimbs,
			// Token: 0x04003156 RID: 12630
			[Token(Token = "0x4003156")]
			CustomLimbs
		}

		// Token: 0x02000C31 RID: 3121
		[Token(Token = "0x2000C31")]
		[Serializable]
		public class BonesChain
		{
			// Token: 0x0600777D RID: 30589 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600777D")]
			[Address(RVA = "0x2F907D8", Offset = "0x2F907D8", VA = "0x2F907D8")]
			public Transform GetAttachTransform(RagdollProcessor ragdollProcessor)
			{
				return null;
			}

			// Token: 0x0600777E RID: 30590 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600777E")]
			[Address(RVA = "0x2F908FC", Offset = "0x2F908FC", VA = "0x2F908FC")]
			public RagdollProcessor.RagdollBoneSetup GetNext(RagdollProcessor.RagdollBoneSetup bone, bool forward)
			{
				return null;
			}

			// Token: 0x0600777F RID: 30591 RVA: 0x00052DA0 File Offset: 0x00050FA0
			[Token(Token = "0x600777F")]
			[Address(RVA = "0x2F909C4", Offset = "0x2F909C4", VA = "0x2F909C4")]
			public int GetIndex(RagdollProcessor.RagdollBoneSetup bone)
			{
				return 0;
			}

			// Token: 0x06007780 RID: 30592 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007780")]
			[Address(RVA = "0x2F90A60", Offset = "0x2F90A60", VA = "0x2F90A60")]
			internal void InitializeForDummy(RagdollProcessor ragdollProcessor, Transform dummyRoot)
			{
			}

			// Token: 0x17000A85 RID: 2693
			// (get) Token: 0x06007781 RID: 30593 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06007782 RID: 30594 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000A85")]
			public static RagdollProcessor.BonesChain CopyFrom
			{
				[Token(Token = "0x6007781")]
				[Address(RVA = "0x2F90EB0", Offset = "0x2F90EB0", VA = "0x2F90EB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6007782")]
				[Address(RVA = "0x2F90EF8", Offset = "0x2F90EF8", VA = "0x2F90EF8")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06007783 RID: 30595 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007783")]
			[Address(RVA = "0x2F90F50", Offset = "0x2F90F50", VA = "0x2F90F50")]
			public static void PasteMainSettingsTo(RagdollProcessor.BonesChain to, bool symmetry = false)
			{
			}

			// Token: 0x06007784 RID: 30596 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007784")]
			[Address(RVA = "0x2F90FC8", Offset = "0x2F90FC8", VA = "0x2F90FC8")]
			public static void PasteMainSettingsTo(RagdollProcessor.BonesChain to, RagdollProcessor.BonesChain from, bool symmetry)
			{
			}

			// Token: 0x06007785 RID: 30597 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007785")]
			[Address(RVA = "0x2F90FF4", Offset = "0x2F90FF4", VA = "0x2F90FF4")]
			public static void PasteColliderSettingsTo(RagdollProcessor.BonesChain to, RagdollProcessor.BonesChain from, bool symmetry)
			{
			}

			// Token: 0x06007786 RID: 30598 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007786")]
			[Address(RVA = "0x2F91164", Offset = "0x2F91164", VA = "0x2F91164")]
			public static void PastePhysicsSettingsTo(RagdollProcessor.BonesChain to, RagdollProcessor.BonesChain from)
			{
			}

			// Token: 0x06007787 RID: 30599 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007787")]
			[Address(RVA = "0x2F90DBC", Offset = "0x2F90DBC", VA = "0x2F90DBC")]
			public void DetachBoneChainsIfDetachEnabled()
			{
			}

			// Token: 0x06007788 RID: 30600 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007788")]
			[Address(RVA = "0x2F91250", Offset = "0x2F91250", VA = "0x2F91250")]
			internal void ApplyCollisionHelperInfo()
			{
			}

			// Token: 0x06007789 RID: 30601 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007789")]
			[Address(RVA = "0x2F91398", Offset = "0x2F91398", VA = "0x2F91398")]
			public void RefreshJointsLimitsPlaymode()
			{
			}

			// Token: 0x0600778A RID: 30602 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600778A")]
			[Address(RVA = "0x2F91604", Offset = "0x2F91604", VA = "0x2F91604")]
			public BonesChain()
			{
			}

			// Token: 0x04003157 RID: 12631
			[Token(Token = "0x4003157")]
			[FieldOffset(Offset = "0x10")]
			public string ChainName;

			// Token: 0x04003158 RID: 12632
			[Token(Token = "0x4003158")]
			[FieldOffset(Offset = "0x18")]
			public List<RagdollProcessor.RagdollBoneSetup> BoneSetups;

			// Token: 0x04003159 RID: 12633
			[Token(Token = "0x4003159")]
			[FieldOffset(Offset = "0x20")]
			public bool BlendOnCollisions;

			// Token: 0x0400315A RID: 12634
			[Token(Token = "0x400315A")]
			[FieldOffset(Offset = "0x21")]
			public bool Detach;

			// Token: 0x0400315B RID: 12635
			[Token(Token = "0x400315B")]
			[FieldOffset(Offset = "0x24")]
			public float ConstantRagdoll;

			// Token: 0x0400315C RID: 12636
			[Token(Token = "0x400315C")]
			[FieldOffset(Offset = "0x28")]
			public float MusclesForce;

			// Token: 0x0400315D RID: 12637
			[Token(Token = "0x400315D")]
			[FieldOffset(Offset = "0x2C")]
			[Tooltip("Bypassing configurable joint limits")]
			public bool UnlimitedRotations;

			// Token: 0x0400315E RID: 12638
			[Token(Token = "0x400315E")]
			[FieldOffset(Offset = "0x30")]
			[Range(0f, 2f)]
			public float ChainScaleMultiplier;

			// Token: 0x0400315F RID: 12639
			[Token(Token = "0x400315F")]
			[FieldOffset(Offset = "0x34")]
			[Range(0.1f, 1f)]
			public float AxisLimitRange;

			// Token: 0x04003160 RID: 12640
			[Token(Token = "0x4003160")]
			[FieldOffset(Offset = "0x38")]
			[NonSerialized]
			public float blendOnCollisionCulldown;

			// Token: 0x04003161 RID: 12641
			[Token(Token = "0x4003161")]
			[FieldOffset(Offset = "0x3C")]
			[NonSerialized]
			public float blendOnCollisionMin;

			// Token: 0x04003162 RID: 12642
			[Token(Token = "0x4003162")]
			[FieldOffset(Offset = "0x40")]
			[NonSerialized]
			public float sd_blendVelo;

			// Token: 0x04003163 RID: 12643
			[Token(Token = "0x4003163")]
			[FieldOffset(Offset = "0x44")]
			private bool playmodeDetached;
		}

		// Token: 0x02000C32 RID: 3122
		[Token(Token = "0x2000C32")]
		[Serializable]
		public class RagdollBoneSetup
		{
			// Token: 0x0600778B RID: 30603 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600778B")]
			[Address(RVA = "0x2F916C8", Offset = "0x2F916C8", VA = "0x2F916C8")]
			public RagdollBoneSetup()
			{
			}

			// Token: 0x0600778C RID: 30604 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600778C")]
			[Address(RVA = "0x2F91780", Offset = "0x2F91780", VA = "0x2F91780")]
			public RagdollBoneSetup(Transform t, RagdollProcessor.RagdollBoneSetup.EColliderType collType, float mass = 0.1f)
			{
			}

			// Token: 0x17000A86 RID: 2694
			// (get) Token: 0x0600778D RID: 30605 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A86")]
			public Transform DummyBone
			{
				[Token(Token = "0x600778D")]
				[Address(RVA = "0x2F91870", Offset = "0x2F91870", VA = "0x2F91870")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600778E RID: 30606 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600778E")]
			[Address(RVA = "0x2F90C68", Offset = "0x2F90C68", VA = "0x2F90C68")]
			internal void SetPosingBone(Transform dummyBone, RagdollProcessor ragdollProcessor)
			{
			}

			// Token: 0x0600778F RID: 30607 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600778F")]
			[Address(RVA = "0x2F92070", Offset = "0x2F92070", VA = "0x2F92070")]
			public void PasteFrom(RagdollProcessor.RagdollBoneSetup refSett)
			{
			}

			// Token: 0x06007790 RID: 30608 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007790")]
			[Address(RVA = "0x2F91424", Offset = "0x2F91424", VA = "0x2F91424")]
			public void ApplyJointLimitsPlaymode(float multiplier = 1f)
			{
			}

			// Token: 0x04003165 RID: 12645
			[Token(Token = "0x4003165")]
			[FieldOffset(Offset = "0x10")]
			public Transform t;

			// Token: 0x04003166 RID: 12646
			[Token(Token = "0x4003166")]
			[FieldOffset(Offset = "0x18")]
			public RagdollProcessor.RagdollBoneSetup.EColliderType ColliderType;

			// Token: 0x04003167 RID: 12647
			[Token(Token = "0x4003167")]
			[FieldOffset(Offset = "0x20")]
			public Mesh ColliderMesh;

			// Token: 0x04003168 RID: 12648
			[Token(Token = "0x4003168")]
			[FieldOffset(Offset = "0x28")]
			[Tooltip("Percentage amount for the bone weight using 'Target Mass' value for ragdoll generator")]
			public float MassPercentage;

			// Token: 0x04003169 RID: 12649
			[Token(Token = "0x4003169")]
			[FieldOffset(Offset = "0x2C")]
			public float MuscleForceMultiplier;

			// Token: 0x0400316A RID: 12650
			[Token(Token = "0x400316A")]
			[FieldOffset(Offset = "0x30")]
			public RagdollProcessor.PosingBone Posing;

			// Token: 0x0400316B RID: 12651
			[Token(Token = "0x400316B")]
			[FieldOffset(Offset = "0x38")]
			public float Generator_ScaleMul;

			// Token: 0x0400316C RID: 12652
			[Token(Token = "0x400316C")]
			[FieldOffset(Offset = "0x3C")]
			public float Generator_LengthMul;

			// Token: 0x0400316D RID: 12653
			[Token(Token = "0x400316D")]
			[FieldOffset(Offset = "0x40")]
			public float Generator_LengthOffset;

			// Token: 0x0400316E RID: 12654
			[Token(Token = "0x400316E")]
			[FieldOffset(Offset = "0x44")]
			public Vector3 Generator_BoxScale;

			// Token: 0x0400316F RID: 12655
			[Token(Token = "0x400316F")]
			[FieldOffset(Offset = "0x50")]
			public Vector3 Generator_Offset;

			// Token: 0x04003170 RID: 12656
			[Token(Token = "0x4003170")]
			[FieldOffset(Offset = "0x5C")]
			public RagdollProcessor.RagdollBoneSetup.ECapsDirOverride Generator_OverrideCapsuleDir;

			// Token: 0x04003171 RID: 12657
			[Token(Token = "0x4003171")]
			[FieldOffset(Offset = "0x60")]
			public bool Generator_Extra;

			// Token: 0x04003172 RID: 12658
			[Token(Token = "0x4003172")]
			[FieldOffset(Offset = "0x64")]
			public float LowTwistAngleLimit;

			// Token: 0x04003173 RID: 12659
			[Token(Token = "0x4003173")]
			[FieldOffset(Offset = "0x68")]
			public float HighTwistAngleLimit;

			// Token: 0x04003174 RID: 12660
			[Token(Token = "0x4003174")]
			[FieldOffset(Offset = "0x6C")]
			public float LowSwingAngleLimit;

			// Token: 0x04003175 RID: 12661
			[Token(Token = "0x4003175")]
			[FieldOffset(Offset = "0x70")]
			public float HighSwingAngleLimit;

			// Token: 0x02000C33 RID: 3123
			[Token(Token = "0x2000C33")]
			public enum EColliderType
			{
				// Token: 0x04003177 RID: 12663
				[Token(Token = "0x4003177")]
				Capsule,
				// Token: 0x04003178 RID: 12664
				[Token(Token = "0x4003178")]
				Sphere,
				// Token: 0x04003179 RID: 12665
				[Token(Token = "0x4003179")]
				Box,
				// Token: 0x0400317A RID: 12666
				[Token(Token = "0x400317A")]
				Mesh,
				// Token: 0x0400317B RID: 12667
				[Token(Token = "0x400317B")]
				NoCollider_CustomColliderAsChild
			}

			// Token: 0x02000C34 RID: 3124
			[Token(Token = "0x2000C34")]
			public enum ECapsDirOverride
			{
				// Token: 0x0400317D RID: 12669
				[Token(Token = "0x400317D")]
				None = -1,
				// Token: 0x0400317E RID: 12670
				[Token(Token = "0x400317E")]
				X_Axis,
				// Token: 0x0400317F RID: 12671
				[Token(Token = "0x400317F")]
				Y_Axis,
				// Token: 0x04003180 RID: 12672
				[Token(Token = "0x4003180")]
				Z_Axis
			}
		}

		// Token: 0x02000C35 RID: 3125
		[Token(Token = "0x2000C35")]
		public enum ESyncMode
		{
			// Token: 0x04003182 RID: 12674
			[Token(Token = "0x4003182")]
			None,
			// Token: 0x04003183 RID: 12675
			[Token(Token = "0x4003183")]
			RagdollToAnimator,
			// Token: 0x04003184 RID: 12676
			[Token(Token = "0x4003184")]
			AnimatorToRagdoll,
			// Token: 0x04003185 RID: 12677
			[Token(Token = "0x4003185")]
			SyncRagdollWithParentBones
		}

		// Token: 0x02000C36 RID: 3126
		[Token(Token = "0x2000C36")]
		public class PosingBone
		{
			// Token: 0x17000A87 RID: 2695
			// (get) Token: 0x06007791 RID: 30609 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A87")]
			public Transform DummyBone
			{
				[Token(Token = "0x6007791")]
				[Address(RVA = "0x2F920EC", Offset = "0x2F920EC", VA = "0x2F920EC")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A88 RID: 2696
			// (get) Token: 0x06007792 RID: 30610 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A88")]
			public Transform AnimatorBone
			{
				[Token(Token = "0x6007792")]
				[Address(RVA = "0x2F920F4", Offset = "0x2F920F4", VA = "0x2F920F4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A89 RID: 2697
			// (get) Token: 0x06007793 RID: 30611 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06007794 RID: 30612 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000A89")]
			public ConfigurableJoint ConfigurableJoint
			{
				[Token(Token = "0x6007793")]
				[Address(RVA = "0x2F920FC", Offset = "0x2F920FC", VA = "0x2F920FC")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6007794")]
				[Address(RVA = "0x2F92104", Offset = "0x2F92104", VA = "0x2F92104")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000A8A RID: 2698
			// (get) Token: 0x06007795 RID: 30613 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06007796 RID: 30614 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000A8A")]
			public CharacterJoint CharacterJoint
			{
				[Token(Token = "0x6007795")]
				[Address(RVA = "0x2F9210C", Offset = "0x2F9210C", VA = "0x2F9210C")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6007796")]
				[Address(RVA = "0x2F92114", Offset = "0x2F92114", VA = "0x2F92114")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000A8B RID: 2699
			// (get) Token: 0x06007797 RID: 30615 RVA: 0x00052DB8 File Offset: 0x00050FB8
			[Token(Token = "0x17000A8B")]
			public bool Colliding
			{
				[Token(Token = "0x6007797")]
				[Address(RVA = "0x2F9211C", Offset = "0x2F9211C", VA = "0x2F9211C")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000A8C RID: 2700
			// (get) Token: 0x06007798 RID: 30616 RVA: 0x00052DD0 File Offset: 0x00050FD0
			[Token(Token = "0x17000A8C")]
			public bool CollidingOnlyWithSelf
			{
				[Token(Token = "0x6007798")]
				[Address(RVA = "0x2F92174", Offset = "0x2F92174", VA = "0x2F92174")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06007799 RID: 30617 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007799")]
			[Address(RVA = "0x2F9188C", Offset = "0x2F9188C", VA = "0x2F9188C")]
			public PosingBone(Transform tr, RagdollProcessor owner, bool requireRigidbody = true)
			{
			}

			// Token: 0x0600779A RID: 30618 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600779A")]
			[Address(RVA = "0x2F921E0", Offset = "0x2F921E0", VA = "0x2F921E0")]
			private void JointInit()
			{
			}

			// Token: 0x0600779B RID: 30619 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600779B")]
			[Address(RVA = "0x2F927E4", Offset = "0x2F927E4", VA = "0x2F927E4")]
			public void StoreAnchor()
			{
			}

			// Token: 0x0600779C RID: 30620 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600779C")]
			[Address(RVA = "0x2F90CE8", Offset = "0x2F90CE8", VA = "0x2F90CE8")]
			internal void SetVisibleBone(Transform visBone)
			{
			}

			// Token: 0x0600779D RID: 30621 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600779D")]
			[Address(RVA = "0x2F928CC", Offset = "0x2F928CC", VA = "0x2F928CC")]
			internal void CaptureAnimator()
			{
			}

			// Token: 0x0600779E RID: 30622 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600779E")]
			[Address(RVA = "0x2F92B34", Offset = "0x2F92B34", VA = "0x2F92B34")]
			public void FixedUpdate()
			{
			}

			// Token: 0x0600779F RID: 30623 RVA: 0x00052DE8 File Offset: 0x00050FE8
			[Token(Token = "0x600779F")]
			[Address(RVA = "0x2F93450", Offset = "0x2F93450", VA = "0x2F93450")]
			private Quaternion ToConfigurableSpaceRotation(Quaternion local)
			{
				return default(Quaternion);
			}

			// Token: 0x060077A0 RID: 30624 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077A0")]
			[Address(RVA = "0x2F935F4", Offset = "0x2F935F4", VA = "0x2F935F4")]
			internal void SyncAnimatorToRagdoll(float blend)
			{
			}

			// Token: 0x060077A1 RID: 30625 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077A1")]
			[Address(RVA = "0x2F9388C", Offset = "0x2F9388C", VA = "0x2F9388C")]
			public void AlignDummyBoneWithAnimatorPose(bool local = true)
			{
			}

			// Token: 0x04003186 RID: 12678
			[Token(Token = "0x4003186")]
			[FieldOffset(Offset = "0x10")]
			public Transform transform;

			// Token: 0x04003187 RID: 12679
			[Token(Token = "0x4003187")]
			[FieldOffset(Offset = "0x18")]
			public Transform visibleBone;

			// Token: 0x04003188 RID: 12680
			[Token(Token = "0x4003188")]
			[FieldOffset(Offset = "0x20")]
			public Transform customRefBone;

			// Token: 0x04003189 RID: 12681
			[Token(Token = "0x4003189")]
			[FieldOffset(Offset = "0x28")]
			public Transform riggedParent;

			// Token: 0x0400318A RID: 12682
			[Token(Token = "0x400318A")]
			[FieldOffset(Offset = "0x30")]
			public Transform transportHelper;

			// Token: 0x0400318B RID: 12683
			[Token(Token = "0x400318B")]
			[FieldOffset(Offset = "0x38")]
			public RagdollProcessor.ToAnimateBone parentFixer;

			// Token: 0x0400318C RID: 12684
			[Token(Token = "0x400318C")]
			[FieldOffset(Offset = "0x40")]
			public RagdollProcessor.ESyncMode FullAnimatorSync;

			// Token: 0x0400318D RID: 12685
			[Token(Token = "0x400318D")]
			[FieldOffset(Offset = "0x44")]
			public Quaternion animatorLocalRotation;

			// Token: 0x0400318E RID: 12686
			[Token(Token = "0x400318E")]
			[FieldOffset(Offset = "0x54")]
			public Vector3 animatorLocalPosition;

			// Token: 0x0400318F RID: 12687
			[Token(Token = "0x400318F")]
			[FieldOffset(Offset = "0x60")]
			public Collider collider;

			// Token: 0x04003190 RID: 12688
			[Token(Token = "0x4003190")]
			[FieldOffset(Offset = "0x68")]
			[NonSerialized]
			public List<Collider> extraColliders;

			// Token: 0x04003191 RID: 12689
			[Token(Token = "0x4003191")]
			[FieldOffset(Offset = "0x70")]
			public Rigidbody rigidbody;

			// Token: 0x04003192 RID: 12690
			[Token(Token = "0x4003192")]
			[FieldOffset(Offset = "0x78")]
			public RagdollCollisionHelper collisions;

			// Token: 0x04003193 RID: 12691
			[Token(Token = "0x4003193")]
			[FieldOffset(Offset = "0x80")]
			public RagdollProcessor owner;

			// Token: 0x04003194 RID: 12692
			[Token(Token = "0x4003194")]
			[FieldOffset(Offset = "0x88")]
			public RagdollProcessor.PosingBone child;

			// Token: 0x04003195 RID: 12693
			[Token(Token = "0x4003195")]
			[FieldOffset(Offset = "0x90")]
			public float user_internalMusclePower;

			// Token: 0x04003196 RID: 12694
			[Token(Token = "0x4003196")]
			[FieldOffset(Offset = "0x94")]
			public float user_internalRagdollBlend;

			// Token: 0x04003197 RID: 12695
			[Token(Token = "0x4003197")]
			[FieldOffset(Offset = "0x98")]
			public float user_internalMuscleMultiplier;

			// Token: 0x04003198 RID: 12696
			[Token(Token = "0x4003198")]
			[FieldOffset(Offset = "0x9C")]
			public float internalMusclePower;

			// Token: 0x04003199 RID: 12697
			[Token(Token = "0x4003199")]
			[FieldOffset(Offset = "0xA0")]
			public float internalRagdollBlend;

			// Token: 0x0400319A RID: 12698
			[Token(Token = "0x400319A")]
			[FieldOffset(Offset = "0xA4")]
			public float targetMass;

			// Token: 0x0400319D RID: 12701
			[Token(Token = "0x400319D")]
			[FieldOffset(Offset = "0xB8")]
			[NonSerialized]
			public bool BrokenJoint;

			// Token: 0x0400319E RID: 12702
			[Token(Token = "0x400319E")]
			[FieldOffset(Offset = "0xC0")]
			[NonSerialized]
			public Transform DetachParent;

			// Token: 0x0400319F RID: 12703
			[Token(Token = "0x400319F")]
			[FieldOffset(Offset = "0xC8")]
			[NonSerialized]
			public bool PositionAlign;

			// Token: 0x040031A0 RID: 12704
			[Token(Token = "0x40031A0")]
			[FieldOffset(Offset = "0xC9")]
			[NonSerialized]
			public bool UnlimitedRotationJoint;

			// Token: 0x040031A1 RID: 12705
			[Token(Token = "0x40031A1")]
			[FieldOffset(Offset = "0xCC")]
			internal Quaternion initialParentLocalRotation;

			// Token: 0x040031A2 RID: 12706
			[Token(Token = "0x40031A2")]
			[FieldOffset(Offset = "0xDC")]
			internal Vector3 initialLocalPosition;

			// Token: 0x040031A3 RID: 12707
			[Token(Token = "0x40031A3")]
			[FieldOffset(Offset = "0xE8")]
			internal Quaternion initialLocalRotation;

			// Token: 0x040031A4 RID: 12708
			[Token(Token = "0x40031A4")]
			[FieldOffset(Offset = "0xF8")]
			private Quaternion localConvert;

			// Token: 0x040031A5 RID: 12709
			[Token(Token = "0x40031A5")]
			[FieldOffset(Offset = "0x108")]
			private Quaternion jointAxisConversion;

			// Token: 0x040031A6 RID: 12710
			[Token(Token = "0x40031A6")]
			[FieldOffset(Offset = "0x118")]
			private Quaternion initialAxisCorrection;

			// Token: 0x040031A7 RID: 12711
			[Token(Token = "0x40031A7")]
			[FieldOffset(Offset = "0x128")]
			private Rigidbody parentHasRigidbody;

			// Token: 0x040031A8 RID: 12712
			[Token(Token = "0x40031A8")]
			[FieldOffset(Offset = "0x130")]
			private Vector3 animWorldPos;

			// Token: 0x040031A9 RID: 12713
			[Token(Token = "0x40031A9")]
			[FieldOffset(Offset = "0x13C")]
			private Quaternion animWorldRot;

			// Token: 0x040031AA RID: 12714
			[Token(Token = "0x40031AA")]
			[FieldOffset(Offset = "0x14C")]
			public float internalForceMultiplier;
		}

		// Token: 0x02000C37 RID: 3127
		[Token(Token = "0x2000C37")]
		public class ToAnimateBone
		{
			// Token: 0x060077A2 RID: 30626 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077A2")]
			[Address(RVA = "0x2F93934", Offset = "0x2F93934", VA = "0x2F93934")]
			public ToAnimateBone(Transform animatorVisibleBone, Transform ragdollBone, RagdollProcessor.PosingBone child)
			{
			}

			// Token: 0x060077A3 RID: 30627 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077A3")]
			[Address(RVA = "0x2F92B08", Offset = "0x2F92B08", VA = "0x2F92B08")]
			public void CaptureAnimation()
			{
			}

			// Token: 0x060077A4 RID: 30628 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077A4")]
			[Address(RVA = "0x2F939CC", Offset = "0x2F939CC", VA = "0x2F939CC")]
			internal void SyncRagdollBone(float ragdolledBlend, bool animatorEnabled)
			{
			}

			// Token: 0x060077A5 RID: 30629 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077A5")]
			[Address(RVA = "0x2F93CC8", Offset = "0x2F93CC8", VA = "0x2F93CC8")]
			internal void SyncAnimatorBone(float ragdollBlend)
			{
			}

			// Token: 0x040031AB RID: 12715
			[Token(Token = "0x40031AB")]
			[FieldOffset(Offset = "0x10")]
			public Transform animatorVisibleBone;

			// Token: 0x040031AC RID: 12716
			[Token(Token = "0x40031AC")]
			[FieldOffset(Offset = "0x18")]
			public Transform dummyBone;

			// Token: 0x040031AD RID: 12717
			[Token(Token = "0x40031AD")]
			[FieldOffset(Offset = "0x20")]
			public RagdollProcessor.PosingBone childRagdollBone;

			// Token: 0x040031AE RID: 12718
			[Token(Token = "0x40031AE")]
			[FieldOffset(Offset = "0x28")]
			public float InternalRagdollToAnimatorOverride;

			// Token: 0x040031AF RID: 12719
			[Token(Token = "0x40031AF")]
			[FieldOffset(Offset = "0x2C")]
			private Quaternion latestAnimatorBoneLocalRot;

			// Token: 0x040031B0 RID: 12720
			[Token(Token = "0x40031B0")]
			[FieldOffset(Offset = "0x3C")]
			internal bool wasSyncing;
		}

		// Token: 0x02000C38 RID: 3128
		[Token(Token = "0x2000C38")]
		public enum EGetUpType
		{
			// Token: 0x040031B2 RID: 12722
			[Token(Token = "0x40031B2")]
			None,
			// Token: 0x040031B3 RID: 12723
			[Token(Token = "0x40031B3")]
			FromBack,
			// Token: 0x040031B4 RID: 12724
			[Token(Token = "0x40031B4")]
			FromFacedown,
			// Token: 0x040031B5 RID: 12725
			[Token(Token = "0x40031B5")]
			FromLeftSide,
			// Token: 0x040031B6 RID: 12726
			[Token(Token = "0x40031B6")]
			FromRightSide
		}
	}
}
