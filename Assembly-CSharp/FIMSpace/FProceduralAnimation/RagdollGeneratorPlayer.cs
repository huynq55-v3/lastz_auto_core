using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace FIMSpace.FProceduralAnimation
{
	// Token: 0x02000C48 RID: 3144
	[Token(Token = "0x2000C48")]
	public class RagdollGeneratorPlayer
	{
		// Token: 0x060077FB RID: 30715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077FB")]
		[Address(RVA = "0x2F957C0", Offset = "0x2F957C0", VA = "0x2F957C0")]
		public void UpdateOrGenerateRagdoll(RagdollProcessor proc, RagdollGeneratorParameters par, bool characterJoints = false, float bounciness = 0f, float damper = 0f, float spring = 0f, bool projection = true, float projAngle = 90f, float projDistance = 0.05f, bool enCollision = false, bool preProcessing = false)
		{
		}

		// Token: 0x060077FC RID: 30716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077FC")]
		[Address(RVA = "0x2F9AEEC", Offset = "0x2F9AEEC", VA = "0x2F9AEEC")]
		private void SetupPelvisBone(RagdollProcessor proc, float bounciness = 0f, float damper = 0f, float drag = 0.5f, float aDrag = 1f, float massToDistr = 65f, bool projection = true, float projAngle = 90f, float projDistance = 0.05f, bool enCollision = false, bool preProcessing = false, RigidbodyInterpolation interpolation = 1, CollisionDetectionMode collDetection = 0)
		{
		}

		// Token: 0x060077FD RID: 30717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077FD")]
		[Address(RVA = "0x2F9CC50", Offset = "0x2F9CC50", VA = "0x2F9CC50")]
		public void SetAllBoneReferences(RagdollProcessor proc)
		{
		}

		// Token: 0x060077FE RID: 30718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077FE")]
		[Address(RVA = "0x2F9CA04", Offset = "0x2F9CA04", VA = "0x2F9CA04")]
		public static void Ragdoll_ComputeArmAxis(Transform baseTransform, Transform bone, Transform child, ref Vector3 f, ref Vector3 r, ref Vector3 u)
		{
		}

		// Token: 0x060077FF RID: 30719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077FF")]
		[Address(RVA = "0x2F9BEB4", Offset = "0x2F9BEB4", VA = "0x2F9BEB4")]
		public static void Ragdoll_ComputeAxis(Transform baseTransform, Transform bone, ref Vector3 f, ref Vector3 r, ref Vector3 u)
		{
		}

		// Token: 0x06007800 RID: 30720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007800")]
		[Address(RVA = "0x2F9AD14", Offset = "0x2F9AD14", VA = "0x2F9AD14")]
		public static List<Transform> GetRagdollBonesAttachedWith(Transform target, RagdollProcessor proc)
		{
			return null;
		}

		// Token: 0x06007801 RID: 30721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007801")]
		[Address(RVA = "0x2F9C8FC", Offset = "0x2F9C8FC", VA = "0x2F9C8FC")]
		public static void Ragdoll_JointbodyConnect(Transform bone, Rigidbody connected)
		{
		}

		// Token: 0x06007802 RID: 30722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007802")]
		[Address(RVA = "0x2F9BF94", Offset = "0x2F9BF94", VA = "0x2F9BF94")]
		public static void Ragdoll_JointAxis(Transform bone, Vector3 axis, [Optional] Vector3? swingAxis, [Optional] Vector3? r, [Optional] Vector3? f, [Optional] Vector3? u)
		{
		}

		// Token: 0x06007803 RID: 30723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007803")]
		[Address(RVA = "0x2F9BB80", Offset = "0x2F9BB80", VA = "0x2F9BB80")]
		public static void Ragdoll_Joint(Transform bone, float lowTwist, float hightTwist, float lowSwing, float highSwing, float spring = 0f, float damp = 0f)
		{
		}

		// Token: 0x06007804 RID: 30724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007804")]
		[Address(RVA = "0x2F9C35C", Offset = "0x2F9C35C", VA = "0x2F9C35C")]
		public static void Ragdoll_RefreshComponents(bool characterJoint, Transform bone, Vector3 towards, bool addJoint = true, float bounciness = 0f, float damper = 0f, float drag = 1f, float angDrag = 1f, bool projection = true, float projAngle = 90f, float projDistance = 0.05f, bool enCollision = false, bool preProcessing = false, bool capsuleColl = true)
		{
		}

		// Token: 0x06007805 RID: 30725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007805")]
		[Address(RVA = "0x2F9B568", Offset = "0x2F9B568", VA = "0x2F9B568")]
		public static void Ragdoll_RefreshComponents(bool characterJoint, RagdollProcessor.RagdollBoneSetup bone, Vector3 towards, bool addJoint = true, float bounciness = 0f, float damper = 0f, float drag = 1f, float angDrag = 1f, bool projection = true, float projAngle = 90f, float projDistance = 0.05f, bool enCollision = false, bool preProcessing = false)
		{
		}

		// Token: 0x06007806 RID: 30726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007806")]
		[Address(RVA = "0x2F9DC24", Offset = "0x2F9DC24", VA = "0x2F9DC24")]
		public static void DestroyIfHave(Transform t, RagdollProcessor.RagdollBoneSetup.EColliderType toIgnore)
		{
		}

		// Token: 0x06007807 RID: 30727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007807")]
		[Address(RVA = "0x2F9DB44", Offset = "0x2F9DB44", VA = "0x2F9DB44")]
		public static void SetCapsuleAxis(CapsuleCollider coll, Vector3 swingDirection, bool chooseDominant = true)
		{
		}

		// Token: 0x06007808 RID: 30728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007808")]
		[Address(RVA = "0x2F9B098", Offset = "0x2F9B098", VA = "0x2F9B098")]
		public static void Ragdoll_AdjustCollider(RagdollProcessor.RagdollBoneSetup bone, Vector3 center, Vector3 localScale, float length, float radius, RigidbodyInterpolation interpolation, CollisionDetectionMode collDetection, bool debug = false)
		{
		}

		// Token: 0x06007809 RID: 30729 RVA: 0x00052F50 File Offset: 0x00051150
		[Token(Token = "0x6007809")]
		[Address(RVA = "0x2F9DAD0", Offset = "0x2F9DAD0", VA = "0x2F9DAD0")]
		public static Vector3 Prepare_ChooseDominantAxis(Vector3 axis)
		{
			return default(Vector3);
		}

		// Token: 0x0600780A RID: 30730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600780A")]
		[Address(RVA = "0x2F9C25C", Offset = "0x2F9C25C", VA = "0x2F9C25C")]
		public static void Ragdoll_RemoveFrom(Transform bone)
		{
		}

		// Token: 0x0600780B RID: 30731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600780B")]
		public static T AddIfDontHave<T>(Transform owner) where T : Component
		{
			return null;
		}

		// Token: 0x0600780C RID: 30732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600780C")]
		public static void DestroyIfHave<T>(Transform owner) where T : Component
		{
		}

		// Token: 0x0600780D RID: 30733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600780D")]
		public static void DestroyIfHaveIgnoreTriggers<T>(Transform owner) where T : Collider
		{
		}

		// Token: 0x0600780E RID: 30734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600780E")]
		[Address(RVA = "0x2F9DD20", Offset = "0x2F9DD20", VA = "0x2F9DD20")]
		public RagdollGeneratorPlayer()
		{
		}

		// Token: 0x0400322F RID: 12847
		[Token(Token = "0x400322F")]
		[FieldOffset(Offset = "0x10")]
		public List<Transform> bones;

		// Token: 0x04003230 RID: 12848
		[Token(Token = "0x4003230")]
		[FieldOffset(Offset = "0x18")]
		public Transform PelvisBone;

		// Token: 0x04003231 RID: 12849
		[Token(Token = "0x4003231")]
		[FieldOffset(Offset = "0x20")]
		public Transform SpineRoot;

		// Token: 0x04003232 RID: 12850
		[Token(Token = "0x4003232")]
		[FieldOffset(Offset = "0x28")]
		public Transform Chest;

		// Token: 0x04003233 RID: 12851
		[Token(Token = "0x4003233")]
		[FieldOffset(Offset = "0x30")]
		public Transform Head;

		// Token: 0x04003234 RID: 12852
		[Token(Token = "0x4003234")]
		[FieldOffset(Offset = "0x38")]
		public Transform LeftUpperArm;

		// Token: 0x04003235 RID: 12853
		[Token(Token = "0x4003235")]
		[FieldOffset(Offset = "0x40")]
		public Transform RightUpperArm;

		// Token: 0x04003236 RID: 12854
		[Token(Token = "0x4003236")]
		[FieldOffset(Offset = "0x48")]
		public Transform LeftForearm;

		// Token: 0x04003237 RID: 12855
		[Token(Token = "0x4003237")]
		[FieldOffset(Offset = "0x50")]
		public Transform RightForearm;

		// Token: 0x04003238 RID: 12856
		[Token(Token = "0x4003238")]
		[FieldOffset(Offset = "0x58")]
		public Transform LeftUpperLeg;

		// Token: 0x04003239 RID: 12857
		[Token(Token = "0x4003239")]
		[FieldOffset(Offset = "0x60")]
		public Transform LeftLowerLeg;

		// Token: 0x0400323A RID: 12858
		[Token(Token = "0x400323A")]
		[FieldOffset(Offset = "0x68")]
		public Transform RightUpperLeg;

		// Token: 0x0400323B RID: 12859
		[Token(Token = "0x400323B")]
		[FieldOffset(Offset = "0x70")]
		public Transform RightLowerLeg;

		// Token: 0x0400323C RID: 12860
		[Token(Token = "0x400323C")]
		[FieldOffset(Offset = "0x78")]
		public Transform RightHand;

		// Token: 0x0400323D RID: 12861
		[Token(Token = "0x400323D")]
		[FieldOffset(Offset = "0x80")]
		public Transform LeftHand;

		// Token: 0x0400323E RID: 12862
		[Token(Token = "0x400323E")]
		[FieldOffset(Offset = "0x88")]
		public Transform RightFoot;

		// Token: 0x0400323F RID: 12863
		[Token(Token = "0x400323F")]
		[FieldOffset(Offset = "0x90")]
		public Transform LeftFoot;

		// Token: 0x04003240 RID: 12864
		[Token(Token = "0x4003240")]
		[FieldOffset(Offset = "0x98")]
		public Transform RightShoulder;

		// Token: 0x04003241 RID: 12865
		[Token(Token = "0x4003241")]
		[FieldOffset(Offset = "0xA0")]
		public Transform LeftShoulder;

		// Token: 0x04003242 RID: 12866
		[Token(Token = "0x4003242")]
		[FieldOffset(Offset = "0xA8")]
		public List<RagdollProcessor.BonesChain> BoneChains;

		// Token: 0x04003243 RID: 12867
		[Token(Token = "0x4003243")]
		[FieldOffset(Offset = "0x0")]
		private static bool alignWithScale;
	}
}
