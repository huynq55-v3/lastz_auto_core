using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace FIMSpace.FProceduralAnimation
{
	// Token: 0x02000C4A RID: 3146
	[Token(Token = "0x2000C4A")]
	[DefaultExecutionOrder(-1)]
	[AddComponentMenu("FImpossible Creations/Ragdoll Animator")]
	public class RagdollAnimator : MonoBehaviour
	{
		// Token: 0x06007810 RID: 30736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007810")]
		[Address(RVA = "0x2F9DDA8", Offset = "0x2F9DDA8", VA = "0x2F9DDA8")]
		public Rigidbody User_GetRagdollBone(HumanBodyBones humanoidBone)
		{
			return null;
		}

		// Token: 0x06007811 RID: 30737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007811")]
		[Address(RVA = "0x2F9DDD0", Offset = "0x2F9DDD0", VA = "0x2F9DDD0")]
		public Rigidbody User_GetRagdollBoneUsingCharacterBone(Transform characterBone)
		{
			return null;
		}

		// Token: 0x06007812 RID: 30738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007812")]
		[Address(RVA = "0x2F9DDF8", Offset = "0x2F9DDF8", VA = "0x2F9DDF8")]
		public Rigidbody User_GetRagdollBoneUsingName(string boneName, bool caseSensitive = false)
		{
			return null;
		}

		// Token: 0x06007813 RID: 30739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007813")]
		[Address(RVA = "0x2F9DE24", Offset = "0x2F9DE24", VA = "0x2F9DE24")]
		public RagdollProcessor.PosingBone User_GetRagdollBoneController(HumanBodyBones humanoidBone)
		{
			return null;
		}

		// Token: 0x06007814 RID: 30740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007814")]
		[Address(RVA = "0x2F9DE40", Offset = "0x2F9DE40", VA = "0x2F9DE40")]
		public RagdollProcessor.PosingBone User_GetRagdollBoneControllerUsingCharacterBone(Transform characterBone)
		{
			return null;
		}

		// Token: 0x06007815 RID: 30741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007815")]
		[Address(RVA = "0x2F9DE5C", Offset = "0x2F9DE5C", VA = "0x2F9DE5C")]
		public RagdollProcessor.PosingBone User_GetRagdollBoneControllerUsingName(string boneName, bool caseSensitive = false)
		{
			return null;
		}

		// Token: 0x06007816 RID: 30742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007816")]
		[Address(RVA = "0x2F9DE7C", Offset = "0x2F9DE7C", VA = "0x2F9DE7C")]
		public RagdollProcessor.PosingBone User_TryGetCustomLimbChainsBone(HumanBodyBones humanoidBone)
		{
			return null;
		}

		// Token: 0x06007817 RID: 30743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007817")]
		[Address(RVA = "0x2F9DE98", Offset = "0x2F9DE98", VA = "0x2F9DE98")]
		public RagdollProcessor.BonesChain User_GetCustomLimbChainUsingName(string chainName, bool caseSensitive = false)
		{
			return null;
		}

		// Token: 0x06007818 RID: 30744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007818")]
		[Address(RVA = "0x2F9DEB8", Offset = "0x2F9DEB8", VA = "0x2F9DEB8")]
		public RagdollProcessor.RagdollBoneSetup User_GetCustomLimbChainBoneSetup(string chainName, int chainBoneIndex, bool caseSensitive = false)
		{
			return null;
		}

		// Token: 0x06007819 RID: 30745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007819")]
		[Address(RVA = "0x2F9DED8", Offset = "0x2F9DED8", VA = "0x2F9DED8")]
		public RagdollProcessor.PosingBone User_GetCustomLimbChainBoneController(string chainName, int chainBoneIndex, bool caseSensitive = false)
		{
			return null;
		}

		// Token: 0x0600781A RID: 30746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600781A")]
		[Address(RVA = "0x2F9DF04", Offset = "0x2F9DF04", VA = "0x2F9DF04")]
		public Rigidbody User_GetCustomLimbChainBone(string chainName, int chainBoneIndex, bool caseSensitive = false)
		{
			return null;
		}

		// Token: 0x0600781B RID: 30747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600781B")]
		[Address(RVA = "0x2F9DF20", Offset = "0x2F9DF20", VA = "0x2F9DF20")]
		public void User_SetLimbImpact(Rigidbody limb, Vector3 powerDirection, float duration, ForceMode forceMode = 1)
		{
		}

		// Token: 0x0600781C RID: 30748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600781C")]
		[Address(RVA = "0x2F9DF6C", Offset = "0x2F9DF6C", VA = "0x2F9DF6C")]
		public void User_SetAllLimbsVelocity(Vector3 velocity, float delay = 0f, bool waitExtraFixedStep = true)
		{
		}

		// Token: 0x0600781D RID: 30749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600781D")]
		[Address(RVA = "0x2F9E144", Offset = "0x2F9E144", VA = "0x2F9E144")]
		public void User_SetFallAndLimbImpact(float? fadeMusclesTo, Rigidbody limb, Vector3 powerDirection, float duration, ForceMode forceMode = 1)
		{
		}

		// Token: 0x0600781E RID: 30750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600781E")]
		[Address(RVA = "0x2F9E2C0", Offset = "0x2F9E2C0", VA = "0x2F9E2C0")]
		public void User_SetPhysicalImpactAll(Vector3 powerDirection, float duration, ForceMode forceMode = 1)
		{
		}

		// Token: 0x0600781F RID: 30751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600781F")]
		[Address(RVA = "0x2F9E3D8", Offset = "0x2F9E3D8", VA = "0x2F9E3D8")]
		public void User_SetFallAndPhysicalImpactAll(float? fadeMusclesTo, Vector3 powerDirection, float duration, ForceMode forceMode = 1)
		{
		}

		// Token: 0x06007820 RID: 30752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007820")]
		[Address(RVA = "0x2F9E4AC", Offset = "0x2F9E4AC", VA = "0x2F9E4AC")]
		public void User_SetPhysicalTorque(Vector3 rotationPower, float duration, bool relativeSpace = false, ForceMode forceMode = 1, bool deltaScale = false)
		{
		}

		// Token: 0x06007821 RID: 30753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007821")]
		[Address(RVA = "0x2F9E604", Offset = "0x2F9E604", VA = "0x2F9E604")]
		public void User_SetPhysicalTorque(Rigidbody limb, Vector3 rotationPower, float duration, bool relativeSpace = false, ForceMode forceMode = 1, bool deltaScale = false)
		{
		}

		// Token: 0x06007822 RID: 30754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007822")]
		[Address(RVA = "0x2F9E70C", Offset = "0x2F9E70C", VA = "0x2F9E70C")]
		public void User_SetPhysicalTorqueFromLocal(Vector3 localEuler, Transform localOf, float duration, [Optional] Vector3? power)
		{
		}

		// Token: 0x06007823 RID: 30755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007823")]
		[Address(RVA = "0x2F9E89C", Offset = "0x2F9E89C", VA = "0x2F9E89C")]
		public void User_SetVelocityAll(Vector3 newVelocity)
		{
		}

		// Token: 0x06007824 RID: 30756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007824")]
		[Address(RVA = "0x2F9E8B8", Offset = "0x2F9E8B8", VA = "0x2F9E8B8")]
		public void User_SetHumanoidLimbImpact(HumanBodyBones limb, Vector3 powerDirection, float duration, ForceMode forceMode = 1)
		{
		}

		// Token: 0x06007825 RID: 30757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007825")]
		[Address(RVA = "0x2F9E93C", Offset = "0x2F9E93C", VA = "0x2F9E93C")]
		public void User_ChangeReposeAndRestore(RagdollProcessor.EBaseTransformRepose set, float restoreAfter)
		{
		}

		// Token: 0x06007826 RID: 30758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007826")]
		[Address(RVA = "0x2F9E9F0", Offset = "0x2F9E9F0", VA = "0x2F9E9F0")]
		public void User_ChangeBlendOnCollisionAndRestore(bool temporaryBlend, float delay)
		{
		}

		// Token: 0x06007827 RID: 30759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007827")]
		[Address(RVA = "0x2F9E25C", Offset = "0x2F9E25C", VA = "0x2F9E25C")]
		public void User_SwitchFreeFallRagdoll(bool freeFall, float delay = 0f)
		{
		}

		// Token: 0x06007828 RID: 30760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007828")]
		[Address(RVA = "0x2F9EB44", Offset = "0x2F9EB44", VA = "0x2F9EB44")]
		public void User_TransitionToNonFreeFallRagdoll(float duration, float delay = 0f)
		{
		}

		// Token: 0x06007829 RID: 30761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007829")]
		[Address(RVA = "0x2F9EB84", Offset = "0x2F9EB84", VA = "0x2F9EB84")]
		public void User_EnableFreeRagdoll(float blend = 1f, float transitionDuration = 0.2f)
		{
		}

		// Token: 0x0600782A RID: 30762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600782A")]
		[Address(RVA = "0x2F9EC00", Offset = "0x2F9EC00", VA = "0x2F9EC00")]
		public void User_SwitchAnimator([Optional] Transform unityAnimator, bool enabled = false, float delay = 0f)
		{
		}

		// Token: 0x0600782B RID: 30763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600782B")]
		[Address(RVA = "0x2F9ED60", Offset = "0x2F9ED60", VA = "0x2F9ED60")]
		public void User_GetUpStack(RagdollProcessor.EGetUpType getUpType, LayerMask groundMask, float targetRagdollBlend = 0f, float targetMusclesPower = 0.85f, float duration = 1.1f)
		{
		}

		// Token: 0x0600782C RID: 30764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600782C")]
		[Address(RVA = "0x2F9EF08", Offset = "0x2F9EF08", VA = "0x2F9EF08")]
		public void User_GetUpStackV2(float targetRagdollBlend = 0f, float targetMusclesPower = 0.85f, float duration = 1.1f, [Optional] float? enableBackCollisionAfter)
		{
		}

		// Token: 0x0600782D RID: 30765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600782D")]
		[Address(RVA = "0x2F9F058", Offset = "0x2F9F058", VA = "0x2F9F058")]
		public void User_OverrideRagdollStateWithCurrentAnimationState()
		{
		}

		// Token: 0x0600782E RID: 30766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600782E")]
		[Address(RVA = "0x2F9F074", Offset = "0x2F9F074", VA = "0x2F9F074")]
		public void User_UpdateBonesToRagdollPose()
		{
		}

		// Token: 0x0600782F RID: 30767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600782F")]
		[Address(RVA = "0x2F9E22C", Offset = "0x2F9E22C", VA = "0x2F9E22C")]
		public void User_FadeMuscles(float forcePoseEnd = 0f, float duration = 0.75f, float delay = 0f)
		{
		}

		// Token: 0x06007830 RID: 30768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007830")]
		[Address(RVA = "0x2F9EE98", Offset = "0x2F9EE98", VA = "0x2F9EE98")]
		public void User_ForceRagdollToAnimatorFor(float duration = 1f, float forcingFullDelay = 0.2f)
		{
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06007831 RID: 30769 RVA: 0x00052F68 File Offset: 0x00051168
		[Token(Token = "0x17000AA9")]
		public bool IsFadeRagdollCoroutineRunning
		{
			[Token(Token = "0x6007831")]
			[Address(RVA = "0x2F9F090", Offset = "0x2F9F090", VA = "0x2F9F090")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007832 RID: 30770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007832")]
		[Address(RVA = "0x2F9EBD0", Offset = "0x2F9EBD0", VA = "0x2F9EBD0")]
		public void User_FadeRagdolledBlend(float targetBlend = 0f, float duration = 0.75f, float delay = 0f)
		{
		}

		// Token: 0x06007833 RID: 30771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007833")]
		[Address(RVA = "0x2F9F0AC", Offset = "0x2F9F0AC", VA = "0x2F9F0AC")]
		public void User_HardSwitchOffRagdollAnimator(bool turnOn = false, bool disableCollisions = true)
		{
		}

		// Token: 0x06007834 RID: 30772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007834")]
		[Address(RVA = "0x2F9F260", Offset = "0x2F9F260", VA = "0x2F9F260")]
		public void User_DestroyRagdollAnimatorAndKeepPhysics(float removeAfter = 0f, float removeOnlyWhenLowVelocity = 0f, bool destroyAndFreeze = false)
		{
		}

		// Token: 0x06007835 RID: 30773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007835")]
		[Address(RVA = "0x2F9F408", Offset = "0x2F9F408", VA = "0x2F9F408")]
		public void User_DestroyRagdollAnimatorAndFreeze(float destroyAfter = 0f, bool disableAnimator = true)
		{
		}

		// Token: 0x06007836 RID: 30774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007836")]
		[Address(RVA = "0x2F9F60C", Offset = "0x2F9F60C", VA = "0x2F9F60C")]
		public IEnumerator User_Coroutine_DisableAnimatingAndKeepPose(Animator animatorToDisable)
		{
			return null;
		}

		// Token: 0x06007837 RID: 30775 RVA: 0x00052F80 File Offset: 0x00051180
		[Token(Token = "0x6007837")]
		[Address(RVA = "0x2F9F69C", Offset = "0x2F9F69C", VA = "0x2F9F69C")]
		public Bounds User_GetRagdollBonesStateBounds(bool fast = true)
		{
			return default(Bounds);
		}

		// Token: 0x06007838 RID: 30776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007838")]
		[Address(RVA = "0x2F9F6E0", Offset = "0x2F9F6E0", VA = "0x2F9F6E0")]
		public void User_Teleport(Vector3 newWorldPos)
		{
		}

		// Token: 0x06007839 RID: 30777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007839")]
		[Address(RVA = "0x2F9F7C4", Offset = "0x2F9F7C4", VA = "0x2F9F7C4")]
		public void User_SetAllKinematic(bool kinematic = true)
		{
		}

		// Token: 0x0600783A RID: 30778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600783A")]
		[Address(RVA = "0x2F9F7E4", Offset = "0x2F9F7E4", VA = "0x2F9F7E4")]
		public void User_SetAllAngularSpeedLimit(float angularLimit)
		{
		}

		// Token: 0x0600783B RID: 30779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600783B")]
		[Address(RVA = "0x2F9F800", Offset = "0x2F9F800", VA = "0x2F9F800")]
		public void User_AnchorPelvis(bool anchor = true, float duration = 0f)
		{
		}

		// Token: 0x0600783C RID: 30780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600783C")]
		[Address(RVA = "0x2F9EEC8", Offset = "0x2F9EEC8", VA = "0x2F9EEC8")]
		public void User_RepositionRoot([Optional] Transform root, [Optional] Vector3? worldUp, RagdollProcessor.EGetUpType getupType = RagdollProcessor.EGetUpType.None, [Optional] LayerMask? snapToGround)
		{
		}

		// Token: 0x0600783D RID: 30781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600783D")]
		[Address(RVA = "0x2F9E95C", Offset = "0x2F9E95C", VA = "0x2F9E95C")]
		private IEnumerator IEChangeReposeAndRestore(RagdollProcessor.EBaseTransformRepose set, float restoreAfter)
		{
			return null;
		}

		// Token: 0x0600783E RID: 30782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600783E")]
		[Address(RVA = "0x2F9EA14", Offset = "0x2F9EA14", VA = "0x2F9EA14")]
		private IEnumerator IEChangeBlendOnCollAndRestore(bool temporaryBlend, float delay)
		{
			return null;
		}

		// Token: 0x0600783F RID: 30783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600783F")]
		[Address(RVA = "0x2F9EAAC", Offset = "0x2F9EAAC", VA = "0x2F9EAAC")]
		private IEnumerator IESwitchFreeFallRagdoll(bool freeFall, float delay)
		{
			return null;
		}

		// Token: 0x06007840 RID: 30784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007840")]
		[Address(RVA = "0x2F9F2A4", Offset = "0x2F9F2A4", VA = "0x2F9F2A4")]
		private void _User_DestroyRagdollAnimatorAndKeepPhysics_Proceed()
		{
		}

		// Token: 0x06007841 RID: 30785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007841")]
		[Address(RVA = "0x2F9F834", Offset = "0x2F9F834", VA = "0x2F9F834")]
		private void CopyPhysicsBackToAnimatorSkeleton()
		{
		}

		// Token: 0x06007842 RID: 30786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007842")]
		[Address(RVA = "0x2F9F36C", Offset = "0x2F9F36C", VA = "0x2F9F36C")]
		private IEnumerator IEDestroyRagdollAnimatorAndKeepPhysics(float removeAfter = 0f, float velocityBelowToRemove = 0f, bool destroyAndFreeze = false)
		{
			return null;
		}

		// Token: 0x06007843 RID: 30787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007843")]
		[Address(RVA = "0x2F9F520", Offset = "0x2F9F520", VA = "0x2F9F520")]
		private void _User_DestroyAndFreeze(bool disableAnimator = true)
		{
		}

		// Token: 0x06007844 RID: 30788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007844")]
		[Address(RVA = "0x2F9E0AC", Offset = "0x2F9E0AC", VA = "0x2F9E0AC")]
		private IEnumerator IECallAfter(float delay, Action act, bool waitExtraFixedStep = false)
		{
			return null;
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06007845 RID: 30789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AAA")]
		public RagdollProcessor Parameters
		{
			[Token(Token = "0x6007845")]
			[Address(RVA = "0x2FA0400", Offset = "0x2FA0400", VA = "0x2FA0400")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007846 RID: 30790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007846")]
		[Address(RVA = "0x2FA0408", Offset = "0x2FA0408", VA = "0x2FA0408")]
		public void Reset()
		{
		}

		// Token: 0x06007847 RID: 30791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007847")]
		[Address(RVA = "0x2FA0544", Offset = "0x2FA0544", VA = "0x2FA0544")]
		public void Start()
		{
		}

		// Token: 0x06007848 RID: 30792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007848")]
		[Address(RVA = "0x2FA0680", Offset = "0x2FA0680", VA = "0x2FA0680")]
		private IEnumerator IEAutoDestroyAfterTPose()
		{
			return null;
		}

		// Token: 0x06007849 RID: 30793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007849")]
		[Address(RVA = "0x2FA05DC", Offset = "0x2FA05DC", VA = "0x2FA05DC")]
		private void SetAutoDestroy()
		{
		}

		// Token: 0x0600784A RID: 30794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600784A")]
		[Address(RVA = "0x2FA06F4", Offset = "0x2FA06F4", VA = "0x2FA06F4")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600784B RID: 30795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600784B")]
		[Address(RVA = "0x2FA0710", Offset = "0x2FA0710", VA = "0x2FA0710")]
		private void Update()
		{
		}

		// Token: 0x0600784C RID: 30796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600784C")]
		[Address(RVA = "0x2FA072C", Offset = "0x2FA072C", VA = "0x2FA072C")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600784D RID: 30797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600784D")]
		[Address(RVA = "0x2FA074C", Offset = "0x2FA074C", VA = "0x2FA074C")]
		private void OnDisable()
		{
		}

		// Token: 0x0600784E RID: 30798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600784E")]
		[Address(RVA = "0x2FA07F4", Offset = "0x2FA07F4", VA = "0x2FA07F4")]
		private void OnEnable()
		{
		}

		// Token: 0x0600784F RID: 30799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600784F")]
		[Address(RVA = "0x2FA0984", Offset = "0x2FA0984", VA = "0x2FA0984")]
		private void OnValidate()
		{
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06007850 RID: 30800 RVA: 0x00052F98 File Offset: 0x00051198
		// (set) Token: 0x06007851 RID: 30801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AAB")]
		public RagdollProcessor.EBaseTransformRepose _initialReposeMode
		{
			[Token(Token = "0x6007850")]
			[Address(RVA = "0x2FA0A20", Offset = "0x2FA0A20", VA = "0x2FA0A20")]
			[CompilerGenerated]
			get
			{
				return RagdollProcessor.EBaseTransformRepose.None;
			}
			[Token(Token = "0x6007851")]
			[Address(RVA = "0x2FA0A28", Offset = "0x2FA0A28", VA = "0x2FA0A28")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06007852 RID: 30802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007852")]
		[Address(RVA = "0x2FA0A30", Offset = "0x2FA0A30", VA = "0x2FA0A30")]
		private void OnDestroy()
		{
		}

		// Token: 0x06007853 RID: 30803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007853")]
		[Address(RVA = "0x2FA0AB4", Offset = "0x2FA0AB4", VA = "0x2FA0AB4")]
		public RagdollAnimator()
		{
		}

		// Token: 0x04003244 RID: 12868
		[Token(Token = "0x4003244")]
		[FieldOffset(Offset = "0x18")]
		private float _User_HardSwitchOffRagdollAnimator_blend;

		// Token: 0x04003245 RID: 12869
		[Token(Token = "0x4003245")]
		[FieldOffset(Offset = "0x1C")]
		private Vector3 _User_HardSwitchOffRagdollAnimator_HipsAnchor;

		// Token: 0x04003246 RID: 12870
		[Token(Token = "0x4003246")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RagdollProcessor Processor;

		// Token: 0x04003247 RID: 12871
		[Token(Token = "0x4003247")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("! REQUIRED ! Just object with Animator and skeleton as child transforms")]
		public Transform ObjectWithAnimator;

		// Token: 0x04003248 RID: 12872
		[Token(Token = "0x4003248")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("If null then it will be found automatically - do manual if you encounter some errors after entering playmode")]
		public Transform RootBone;

		// Token: 0x04003249 RID: 12873
		[Token(Token = "0x4003249")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("! OPTIONAL ! Leave here nothing to not use the feature! \n\nObject with bones structure to which ragdoll should try fit with it's pose.\nUseful only if you want to animate ragdoll with other animations than the model body animator.")]
		[Space(2f)]
		public Transform CustomRagdollAnimator;

		// Token: 0x0400324A RID: 12874
		[Token(Token = "0x400324A")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("If generated ragdoll should be destroyed when main skeleton root object stops existing")]
		public bool AutoDestroy;

		// Token: 0x0400324B RID: 12875
		[Token(Token = "0x400324B")]
		[FieldOffset(Offset = "0x49")]
		[Tooltip("When false, then ragdoll dummy skeleton will be generated in playmode, when true, it will be generated in edit mode")]
		[HideInInspector]
		public bool PreGenerateDummy;

		// Token: 0x0400324C RID: 12876
		[Token(Token = "0x400324C")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("Generated ragdoll dummy will be put inside this transform as child object.\n\nAssign main character object for ragdoll to react with character movement rigidbody motion, set other for no motion reaction.")]
		public Transform TargetParentForRagdollDummy;

		// Token: 0x0400324D RID: 12877
		[Token(Token = "0x400324D")]
		[FieldOffset(Offset = "0x58")]
		private bool wasDisabled;

		// Token: 0x0400324F RID: 12879
		[Token(Token = "0x400324F")]
		[FieldOffset(Offset = "0x60")]
		private RagdollAnimator.RagdollAutoDestroy autoDestroy;

		// Token: 0x02000C4B RID: 3147
		[Token(Token = "0x2000C4B")]
		private class RagdollAutoDestroy : MonoBehaviour
		{
			// Token: 0x06007855 RID: 30805 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007855")]
			[Address(RVA = "0x1576308", Offset = "0x1576308", VA = "0x1576308")]
			public void StartChecking()
			{
			}

			// Token: 0x06007856 RID: 30806 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007856")]
			[Address(RVA = "0x15763B0", Offset = "0x15763B0", VA = "0x15763B0")]
			private void Check()
			{
			}

			// Token: 0x06007857 RID: 30807 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007857")]
			[Address(RVA = "0x1576450", Offset = "0x1576450", VA = "0x1576450")]
			public RagdollAutoDestroy()
			{
			}

			// Token: 0x04003250 RID: 12880
			[Token(Token = "0x4003250")]
			[FieldOffset(Offset = "0x18")]
			public GameObject Parent;
		}
	}
}
