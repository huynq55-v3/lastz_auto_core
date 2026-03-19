using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace RealisticEyeMovements
{
	// Token: 0x02000C67 RID: 3175
	[Token(Token = "0x2000C67")]
	[Serializable]
	public class ControlData
	{
		// Token: 0x06007932 RID: 31026 RVA: 0x000533E8 File Offset: 0x000515E8
		[Token(Token = "0x6007932")]
		[Address(RVA = "0x157A090", Offset = "0x157A090", VA = "0x157A090")]
		public bool CanImport(ControlDataForSerialization import, Transform startXform, Transform usedHeadXform)
		{
			return default(bool);
		}

		// Token: 0x06007933 RID: 31027 RVA: 0x00053400 File Offset: 0x00051600
		[Token(Token = "0x6007933")]
		[Address(RVA = "0x1583D58", Offset = "0x1583D58", VA = "0x1583D58")]
		public float ClampLeftVertEyeAngle(float angle)
		{
			return 0f;
		}

		// Token: 0x06007934 RID: 31028 RVA: 0x00053418 File Offset: 0x00051618
		[Token(Token = "0x6007934")]
		[Address(RVA = "0x15799E8", Offset = "0x15799E8", VA = "0x15799E8")]
		public float ClampRightVertEyeAngle(float angle)
		{
			return 0f;
		}

		// Token: 0x06007935 RID: 31029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007935")]
		[Address(RVA = "0x158321C", Offset = "0x158321C", VA = "0x158321C")]
		public void ConvertLegacyIfNecessary()
		{
		}

		// Token: 0x06007936 RID: 31030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007936")]
		[Address(RVA = "0x1585BC4", Offset = "0x1585BC4", VA = "0x1585BC4")]
		private void CreateNewBlendshapeConfigs(Transform startXform)
		{
		}

		// Token: 0x06007937 RID: 31031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007937")]
		[Address(RVA = "0x157CEA8", Offset = "0x157CEA8", VA = "0x157CEA8")]
		public ControlDataForSerialization GetExport(Transform startXform, Transform usedHeadXform)
		{
			return null;
		}

		// Token: 0x06007938 RID: 31032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007938")]
		[Address(RVA = "0x157EDF0", Offset = "0x157EDF0", VA = "0x157EDF0")]
		public void Import(ControlDataForSerialization import, Transform startXform, Transform usedHeadXform)
		{
		}

		// Token: 0x06007939 RID: 31033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007939")]
		[Address(RVA = "0x1580CD4", Offset = "0x1580CD4", VA = "0x1580CD4")]
		public void Initialize(Transform startXform)
		{
		}

		// Token: 0x0600793A RID: 31034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600793A")]
		[Address(RVA = "0x1586008", Offset = "0x1586008", VA = "0x1586008")]
		private void LerpBlendshapeConfig(ControlData.EyelidPositionBlendshape[] blendshapes, float lerpValue, bool relativeToCurrentValueIfUsedInOtherConfig = false)
		{
		}

		// Token: 0x0600793B RID: 31035 RVA: 0x00053430 File Offset: 0x00051630
		[Token(Token = "0x600793B")]
		[Address(RVA = "0x157FFA8", Offset = "0x157FFA8", VA = "0x157FFA8")]
		public bool NeedsSaveDefaultBlendshapeConfig()
		{
			return default(bool);
		}

		// Token: 0x0600793C RID: 31036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600793C")]
		[Address(RVA = "0x1586134", Offset = "0x1586134", VA = "0x1586134")]
		private void ResetBlendshapeConfig(ControlData.EyelidPositionBlendshape[] blendshapes)
		{
		}

		// Token: 0x0600793D RID: 31037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600793D")]
		[Address(RVA = "0x1586204", Offset = "0x1586204", VA = "0x1586204")]
		public void ResetBlendshapes(bool eyelidsFollowEyesVertically)
		{
		}

		// Token: 0x0600793E RID: 31038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600793E")]
		[Address(RVA = "0x1586214", Offset = "0x1586214", VA = "0x1586214")]
		private void ResetAllBlendshapesToDefault()
		{
		}

		// Token: 0x0600793F RID: 31039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600793F")]
		[Address(RVA = "0x1586238", Offset = "0x1586238", VA = "0x1586238")]
		public void RestoreClosed()
		{
		}

		// Token: 0x06007940 RID: 31040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007940")]
		[Address(RVA = "0x157FFC8", Offset = "0x157FFC8", VA = "0x157FFC8")]
		public void RestoreDefault(bool withEyelids = true)
		{
		}

		// Token: 0x06007941 RID: 31041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007941")]
		[Address(RVA = "0x1586698", Offset = "0x1586698", VA = "0x1586698")]
		private void RestoreDefaultEyelids()
		{
		}

		// Token: 0x06007942 RID: 31042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007942")]
		[Address(RVA = "0x1586A48", Offset = "0x1586A48", VA = "0x1586A48")]
		public void RestoreLookDown()
		{
		}

		// Token: 0x06007943 RID: 31043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007943")]
		[Address(RVA = "0x1586EA8", Offset = "0x1586EA8", VA = "0x1586EA8")]
		public void RestoreLookUp()
		{
		}

		// Token: 0x06007944 RID: 31044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007944")]
		[Address(RVA = "0x1587308", Offset = "0x1587308", VA = "0x1587308")]
		private void SaveBlendshapesForEyelidPosition(out ControlData.EyelidPositionBlendshape[] blendshapesForPosition, Object rootObject)
		{
		}

		// Token: 0x06007945 RID: 31045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007945")]
		[Address(RVA = "0x1587760", Offset = "0x1587760", VA = "0x1587760")]
		public void SaveClosed(Object rootObject)
		{
		}

		// Token: 0x06007946 RID: 31046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007946")]
		[Address(RVA = "0x158004C", Offset = "0x158004C", VA = "0x158004C")]
		public void SaveDefault(Object rootObject)
		{
		}

		// Token: 0x06007947 RID: 31047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007947")]
		[Address(RVA = "0x1587B1C", Offset = "0x1587B1C", VA = "0x1587B1C")]
		public void SaveLookDown(Object rootObject)
		{
		}

		// Token: 0x06007948 RID: 31048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007948")]
		[Address(RVA = "0x1587F80", Offset = "0x1587F80", VA = "0x1587F80")]
		public void SaveLookUp(Object rootObject)
		{
		}

		// Token: 0x06007949 RID: 31049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007949")]
		[Address(RVA = "0x1585E30", Offset = "0x1585E30", VA = "0x1585E30")]
		public void StoreSetup()
		{
		}

		// Token: 0x0600794A RID: 31050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600794A")]
		[Address(RVA = "0x15883E4", Offset = "0x15883E4", VA = "0x15883E4")]
		private void UpdateEyelidBonesOfOneLid(float eyeAngle, float blink01, bool isUpper, List<Transform> lidBones, List<EyelidRotationLimiter> limiters, float finalEyelidWeight)
		{
		}

		// Token: 0x0600794B RID: 31051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600794B")]
		[Address(RVA = "0x1585094", Offset = "0x1585094", VA = "0x1585094")]
		public void UpdateEyelids(float leftEyeAngle, float rightEyeAngle, float blink01, bool eyelidsFollowEyesVertically, float finalEyelidWeight)
		{
		}

		// Token: 0x0600794C RID: 31052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600794C")]
		[Address(RVA = "0x15837D8", Offset = "0x15837D8", VA = "0x15837D8")]
		public void ValidateSetup()
		{
		}

		// Token: 0x0600794D RID: 31053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600794D")]
		[Address(RVA = "0x158542C", Offset = "0x158542C", VA = "0x158542C")]
		public ControlData()
		{
		}

		// Token: 0x04003372 RID: 13170
		[Token(Token = "0x4003372")]
		[FieldOffset(Offset = "0x10")]
		private bool wasSetupStored;

		// Token: 0x04003373 RID: 13171
		[Token(Token = "0x4003373")]
		[FieldOffset(Offset = "0x14")]
		private ControlData.EyeControl eyeControlStored;

		// Token: 0x04003374 RID: 13172
		[Token(Token = "0x4003374")]
		[FieldOffset(Offset = "0x18")]
		private ControlData.EyelidControl eyelidControlStored;

		// Token: 0x04003375 RID: 13173
		[Token(Token = "0x4003375")]
		[FieldOffset(Offset = "0x1C")]
		private ControlData.EyelidBoneMode eyelidBoneModeStored;

		// Token: 0x04003376 RID: 13174
		[Token(Token = "0x4003376")]
		[FieldOffset(Offset = "0x20")]
		private Transform leftEyeStored;

		// Token: 0x04003377 RID: 13175
		[Token(Token = "0x4003377")]
		[FieldOffset(Offset = "0x28")]
		private Transform rightEyeStored;

		// Token: 0x04003378 RID: 13176
		[Token(Token = "0x4003378")]
		[FieldOffset(Offset = "0x30")]
		private List<Transform> upperLeftEyelidBonesStored;

		// Token: 0x04003379 RID: 13177
		[Token(Token = "0x4003379")]
		[FieldOffset(Offset = "0x38")]
		private List<Transform> upperRightEyelidBonesStored;

		// Token: 0x0400337A RID: 13178
		[Token(Token = "0x400337A")]
		[FieldOffset(Offset = "0x40")]
		private List<Transform> lowerLeftEyelidBonesStored;

		// Token: 0x0400337B RID: 13179
		[Token(Token = "0x400337B")]
		[FieldOffset(Offset = "0x48")]
		private List<Transform> lowerRightEyelidBonesStored;

		// Token: 0x0400337C RID: 13180
		[Token(Token = "0x400337C")]
		[FieldOffset(Offset = "0x50")]
		private bool isEyeBoneDefaultSetStored;

		// Token: 0x0400337D RID: 13181
		[Token(Token = "0x400337D")]
		[FieldOffset(Offset = "0x51")]
		private bool isEyeBallDefaultSetStored;

		// Token: 0x0400337E RID: 13182
		[Token(Token = "0x400337E")]
		[FieldOffset(Offset = "0x52")]
		private bool isEyelidBonesDefaultSetStored;

		// Token: 0x0400337F RID: 13183
		[Token(Token = "0x400337F")]
		[FieldOffset(Offset = "0x53")]
		private bool isEyelidBlendshapeDefaultSetStored;

		// Token: 0x04003380 RID: 13184
		[Token(Token = "0x4003380")]
		[FieldOffset(Offset = "0x54")]
		private bool isEyelidBonesClosedSetStored;

		// Token: 0x04003381 RID: 13185
		[Token(Token = "0x4003381")]
		[FieldOffset(Offset = "0x55")]
		private bool isEyelidBlendshapeClosedSetStored;

		// Token: 0x04003382 RID: 13186
		[Token(Token = "0x4003382")]
		[FieldOffset(Offset = "0x56")]
		private bool isEyeBoneLookDownSetStored;

		// Token: 0x04003383 RID: 13187
		[Token(Token = "0x4003383")]
		[FieldOffset(Offset = "0x57")]
		private bool isEyeBallLookDownSetStored;

		// Token: 0x04003384 RID: 13188
		[Token(Token = "0x4003384")]
		[FieldOffset(Offset = "0x58")]
		private bool isEyelidBonesLookDownSetStored;

		// Token: 0x04003385 RID: 13189
		[Token(Token = "0x4003385")]
		[FieldOffset(Offset = "0x59")]
		private bool isEyelidBlendshapeLookDownSetStored;

		// Token: 0x04003386 RID: 13190
		[Token(Token = "0x4003386")]
		[FieldOffset(Offset = "0x5A")]
		private bool isEyeBoneLookUpSetStored;

		// Token: 0x04003387 RID: 13191
		[Token(Token = "0x4003387")]
		[FieldOffset(Offset = "0x5B")]
		private bool isEyeBallLookUpSetStored;

		// Token: 0x04003388 RID: 13192
		[Token(Token = "0x4003388")]
		[FieldOffset(Offset = "0x5C")]
		private bool isEyelidBonesLookUpSetStored;

		// Token: 0x04003389 RID: 13193
		[Token(Token = "0x4003389")]
		[FieldOffset(Offset = "0x5D")]
		private bool isEyelidBlendshapeLookUpSetStored;

		// Token: 0x0400338A RID: 13194
		[Token(Token = "0x400338A")]
		[FieldOffset(Offset = "0x60")]
		public ControlData.EyeControl eyeControl;

		// Token: 0x0400338B RID: 13195
		[Token(Token = "0x400338B")]
		[FieldOffset(Offset = "0x68")]
		public Transform leftEye;

		// Token: 0x0400338C RID: 13196
		[Token(Token = "0x400338C")]
		[FieldOffset(Offset = "0x70")]
		public Transform rightEye;

		// Token: 0x0400338D RID: 13197
		[Token(Token = "0x400338D")]
		[FieldOffset(Offset = "0x78")]
		public float maxEyeUpBoneAngle;

		// Token: 0x0400338E RID: 13198
		[Token(Token = "0x400338E")]
		[FieldOffset(Offset = "0x7C")]
		public float maxEyeDownBoneAngle;

		// Token: 0x0400338F RID: 13199
		[Token(Token = "0x400338F")]
		[FieldOffset(Offset = "0x80")]
		public float maxEyeUpEyeballAngle;

		// Token: 0x04003390 RID: 13200
		[Token(Token = "0x4003390")]
		[FieldOffset(Offset = "0x84")]
		public float maxEyeDownEyeballAngle;

		// Token: 0x04003391 RID: 13201
		[Token(Token = "0x4003391")]
		[FieldOffset(Offset = "0x88")]
		public bool isEyeBallDefaultSet;

		// Token: 0x04003392 RID: 13202
		[Token(Token = "0x4003392")]
		[FieldOffset(Offset = "0x89")]
		public bool isEyeBoneDefaultSet;

		// Token: 0x04003393 RID: 13203
		[Token(Token = "0x4003393")]
		[FieldOffset(Offset = "0x8A")]
		public bool isEyeBallLookUpSet;

		// Token: 0x04003394 RID: 13204
		[Token(Token = "0x4003394")]
		[FieldOffset(Offset = "0x8B")]
		public bool isEyeBoneLookUpSet;

		// Token: 0x04003395 RID: 13205
		[Token(Token = "0x4003395")]
		[FieldOffset(Offset = "0x8C")]
		public bool isEyeBallLookDownSet;

		// Token: 0x04003396 RID: 13206
		[Token(Token = "0x4003396")]
		[FieldOffset(Offset = "0x8D")]
		public bool isEyeBoneLookDownSet;

		// Token: 0x04003397 RID: 13207
		[Token(Token = "0x4003397")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private EyeRotationLimiter leftBoneEyeRotationLimiter;

		// Token: 0x04003398 RID: 13208
		[Token(Token = "0x4003398")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private EyeRotationLimiter rightBoneEyeRotationLimiter;

		// Token: 0x04003399 RID: 13209
		[Token(Token = "0x4003399")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private EyeRotationLimiter leftEyeballEyeRotationLimiter;

		// Token: 0x0400339A RID: 13210
		[Token(Token = "0x400339A")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private EyeRotationLimiter rightEyeballEyeRotationLimiter;

		// Token: 0x0400339B RID: 13211
		[Token(Token = "0x400339B")]
		[FieldOffset(Offset = "0xB0")]
		public ControlData.EyelidControl eyelidControl;

		// Token: 0x0400339C RID: 13212
		[Token(Token = "0x400339C")]
		[FieldOffset(Offset = "0xB4")]
		public ControlData.EyelidBoneMode eyelidBoneMode;

		// Token: 0x0400339D RID: 13213
		[Token(Token = "0x400339D")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Transform upperEyeLidLeft;

		// Token: 0x0400339E RID: 13214
		[Token(Token = "0x400339E")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Transform upperEyeLidRight;

		// Token: 0x0400339F RID: 13215
		[Token(Token = "0x400339F")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Transform lowerEyeLidLeft;

		// Token: 0x040033A0 RID: 13216
		[Token(Token = "0x40033A0")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Transform lowerEyeLidRight;

		// Token: 0x040033A1 RID: 13217
		[Token(Token = "0x40033A1")]
		[FieldOffset(Offset = "0xD8")]
		public List<Transform> upperLeftEyelidBones;

		// Token: 0x040033A2 RID: 13218
		[Token(Token = "0x40033A2")]
		[FieldOffset(Offset = "0xE0")]
		public List<Transform> upperRightEyelidBones;

		// Token: 0x040033A3 RID: 13219
		[Token(Token = "0x40033A3")]
		[FieldOffset(Offset = "0xE8")]
		public List<Transform> lowerLeftEyelidBones;

		// Token: 0x040033A4 RID: 13220
		[Token(Token = "0x40033A4")]
		[FieldOffset(Offset = "0xF0")]
		public List<Transform> lowerRightEyelidBones;

		// Token: 0x040033A5 RID: 13221
		[Token(Token = "0x40033A5")]
		[FieldOffset(Offset = "0xF8")]
		public bool isEyelidBonesDefaultSet;

		// Token: 0x040033A6 RID: 13222
		[Token(Token = "0x40033A6")]
		[FieldOffset(Offset = "0xF9")]
		public bool isEyelidBonesClosedSet;

		// Token: 0x040033A7 RID: 13223
		[Token(Token = "0x40033A7")]
		[FieldOffset(Offset = "0xFA")]
		public bool isEyelidBonesLookUpSet;

		// Token: 0x040033A8 RID: 13224
		[Token(Token = "0x40033A8")]
		[FieldOffset(Offset = "0xFB")]
		public bool isEyelidBonesLookDownSet;

		// Token: 0x040033A9 RID: 13225
		[Token(Token = "0x40033A9")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private EyelidRotationLimiter upperLeftLimiter;

		// Token: 0x040033AA RID: 13226
		[Token(Token = "0x40033AA")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private EyelidRotationLimiter upperRightLimiter;

		// Token: 0x040033AB RID: 13227
		[Token(Token = "0x40033AB")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private EyelidRotationLimiter lowerLeftLimiter;

		// Token: 0x040033AC RID: 13228
		[Token(Token = "0x40033AC")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private EyelidRotationLimiter lowerRightLimiter;

		// Token: 0x040033AD RID: 13229
		[Token(Token = "0x40033AD")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private List<EyelidRotationLimiter> upperLeftLimiters;

		// Token: 0x040033AE RID: 13230
		[Token(Token = "0x40033AE")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private List<EyelidRotationLimiter> upperRightLimiters;

		// Token: 0x040033AF RID: 13231
		[Token(Token = "0x40033AF")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private List<EyelidRotationLimiter> lowerLeftLimiters;

		// Token: 0x040033B0 RID: 13232
		[Token(Token = "0x40033B0")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private List<EyelidRotationLimiter> lowerRightLimiters;

		// Token: 0x040033B1 RID: 13233
		[Token(Token = "0x40033B1")]
		[FieldOffset(Offset = "0x140")]
		public float eyeWidenOrSquint;

		// Token: 0x040033B2 RID: 13234
		[Token(Token = "0x40033B2")]
		[FieldOffset(Offset = "0x144")]
		private bool wereEyelidsRestoredToDefaultSinceLastUpdate;

		// Token: 0x040033B3 RID: 13235
		[Token(Token = "0x40033B3")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private ControlData.EyelidPositionBlendshape[] blendshapesForBlinking;

		// Token: 0x040033B4 RID: 13236
		[Token(Token = "0x40033B4")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private ControlData.EyelidPositionBlendshape[] blendshapesForLookingUp;

		// Token: 0x040033B5 RID: 13237
		[Token(Token = "0x40033B5")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private ControlData.EyelidPositionBlendshape[] blendshapesForLookingDown;

		// Token: 0x040033B6 RID: 13238
		[Token(Token = "0x40033B6")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private ControlData.BlendshapesConfig[] blendshapesConfigs;

		// Token: 0x040033B7 RID: 13239
		[Token(Token = "0x40033B7")]
		[FieldOffset(Offset = "0x168")]
		public bool isEyelidBlendshapeDefaultSet;

		// Token: 0x040033B8 RID: 13240
		[Token(Token = "0x40033B8")]
		[FieldOffset(Offset = "0x169")]
		public bool isEyelidBlendshapeClosedSet;

		// Token: 0x040033B9 RID: 13241
		[Token(Token = "0x40033B9")]
		[FieldOffset(Offset = "0x16A")]
		public bool isEyelidBlendshapeLookUpSet;

		// Token: 0x040033BA RID: 13242
		[Token(Token = "0x40033BA")]
		[FieldOffset(Offset = "0x16B")]
		public bool isEyelidBlendshapeLookDownSet;

		// Token: 0x02000C68 RID: 3176
		[Token(Token = "0x2000C68")]
		public enum EyeControl
		{
			// Token: 0x040033BC RID: 13244
			[Token(Token = "0x40033BC")]
			None,
			// Token: 0x040033BD RID: 13245
			[Token(Token = "0x40033BD")]
			MecanimEyeBones,
			// Token: 0x040033BE RID: 13246
			[Token(Token = "0x40033BE")]
			SelectedObjects
		}

		// Token: 0x02000C69 RID: 3177
		[Token(Token = "0x2000C69")]
		public enum EyelidControl
		{
			// Token: 0x040033C0 RID: 13248
			[Token(Token = "0x40033C0")]
			None,
			// Token: 0x040033C1 RID: 13249
			[Token(Token = "0x40033C1")]
			Bones,
			// Token: 0x040033C2 RID: 13250
			[Token(Token = "0x40033C2")]
			Blendshapes
		}

		// Token: 0x02000C6A RID: 3178
		[Token(Token = "0x2000C6A")]
		public enum EyelidBoneMode
		{
			// Token: 0x040033C4 RID: 13252
			[Token(Token = "0x40033C4")]
			RotationAndPosition,
			// Token: 0x040033C5 RID: 13253
			[Token(Token = "0x40033C5")]
			Rotation,
			// Token: 0x040033C6 RID: 13254
			[Token(Token = "0x40033C6")]
			Position
		}

		// Token: 0x02000C6B RID: 3179
		[Token(Token = "0x2000C6B")]
		[Serializable]
		public class BlendshapesConfig
		{
			// Token: 0x0600794E RID: 31054 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600794E")]
			[Address(RVA = "0x1486014", Offset = "0x1486014", VA = "0x1486014")]
			public BlendshapesConfig()
			{
			}

			// Token: 0x040033C7 RID: 13255
			[Token(Token = "0x40033C7")]
			[FieldOffset(Offset = "0x10")]
			public SkinnedMeshRenderer skinnedMeshRenderer;

			// Token: 0x040033C8 RID: 13256
			[Token(Token = "0x40033C8")]
			[FieldOffset(Offset = "0x18")]
			public int blendShapeCount;

			// Token: 0x040033C9 RID: 13257
			[Token(Token = "0x40033C9")]
			[FieldOffset(Offset = "0x20")]
			public float[] blendshapeWeights;
		}

		// Token: 0x02000C6C RID: 3180
		[Token(Token = "0x2000C6C")]
		[Serializable]
		public class EyelidPositionBlendshapeForExport
		{
			// Token: 0x0600794F RID: 31055 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600794F")]
			[Address(RVA = "0x148601C", Offset = "0x148601C", VA = "0x148601C")]
			public EyelidPositionBlendshapeForExport()
			{
			}

			// Token: 0x040033CA RID: 13258
			[Token(Token = "0x40033CA")]
			[FieldOffset(Offset = "0x10")]
			public string skinnedMeshRendererPath;

			// Token: 0x040033CB RID: 13259
			[Token(Token = "0x40033CB")]
			[FieldOffset(Offset = "0x18")]
			public float defaultWeight;

			// Token: 0x040033CC RID: 13260
			[Token(Token = "0x40033CC")]
			[FieldOffset(Offset = "0x1C")]
			public float positionWeight;

			// Token: 0x040033CD RID: 13261
			[Token(Token = "0x40033CD")]
			[FieldOffset(Offset = "0x20")]
			public int index;

			// Token: 0x040033CE RID: 13262
			[Token(Token = "0x40033CE")]
			[FieldOffset(Offset = "0x28")]
			public string name;

			// Token: 0x040033CF RID: 13263
			[Token(Token = "0x40033CF")]
			[FieldOffset(Offset = "0x30")]
			public bool isUsedInEalierConfig;
		}

		// Token: 0x02000C6D RID: 3181
		[Token(Token = "0x2000C6D")]
		[Serializable]
		public class EyelidPositionBlendshape
		{
			// Token: 0x06007950 RID: 31056 RVA: 0x00053448 File Offset: 0x00051648
			[Token(Token = "0x6007950")]
			[Address(RVA = "0x1486024", Offset = "0x1486024", VA = "0x1486024")]
			public static bool CanImport(ControlData.EyelidPositionBlendshapeForExport import, Transform startXform)
			{
				return default(bool);
			}

			// Token: 0x06007951 RID: 31057 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007951")]
			[Address(RVA = "0x1486210", Offset = "0x1486210", VA = "0x1486210")]
			public ControlData.EyelidPositionBlendshapeForExport GetExport(Transform startXform)
			{
				return null;
			}

			// Token: 0x06007952 RID: 31058 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007952")]
			[Address(RVA = "0x1486598", Offset = "0x1486598", VA = "0x1486598")]
			public void Import(ControlData.EyelidPositionBlendshapeForExport export, Transform startXform)
			{
			}

			// Token: 0x06007953 RID: 31059 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007953")]
			[Address(RVA = "0x148673C", Offset = "0x148673C", VA = "0x148673C")]
			public EyelidPositionBlendshape()
			{
			}

			// Token: 0x040033D0 RID: 13264
			[Token(Token = "0x40033D0")]
			[FieldOffset(Offset = "0x10")]
			public SkinnedMeshRenderer skinnedMeshRenderer;

			// Token: 0x040033D1 RID: 13265
			[Token(Token = "0x40033D1")]
			[FieldOffset(Offset = "0x18")]
			public float defaultWeight;

			// Token: 0x040033D2 RID: 13266
			[Token(Token = "0x40033D2")]
			[FieldOffset(Offset = "0x1C")]
			public float positionWeight;

			// Token: 0x040033D3 RID: 13267
			[Token(Token = "0x40033D3")]
			[FieldOffset(Offset = "0x20")]
			public int index;

			// Token: 0x040033D4 RID: 13268
			[Token(Token = "0x40033D4")]
			[FieldOffset(Offset = "0x28")]
			public string name;

			// Token: 0x040033D5 RID: 13269
			[Token(Token = "0x40033D5")]
			[FieldOffset(Offset = "0x30")]
			public bool isUsedInEalierConfig;
		}

		// Token: 0x02000C6E RID: 3182
		[Token(Token = "0x2000C6E")]
		[Serializable]
		public class BlendshapesConfigForExport
		{
			// Token: 0x06007954 RID: 31060 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007954")]
			[Address(RVA = "0x1486744", Offset = "0x1486744", VA = "0x1486744")]
			public BlendshapesConfigForExport()
			{
			}

			// Token: 0x040033D6 RID: 13270
			[Token(Token = "0x40033D6")]
			[FieldOffset(Offset = "0x10")]
			public string skinnedMeshRendererPath;

			// Token: 0x040033D7 RID: 13271
			[Token(Token = "0x40033D7")]
			[FieldOffset(Offset = "0x18")]
			public int blendShapeCount;

			// Token: 0x040033D8 RID: 13272
			[Token(Token = "0x40033D8")]
			[FieldOffset(Offset = "0x20")]
			public string[] blendshapeNames;

			// Token: 0x040033D9 RID: 13273
			[Token(Token = "0x40033D9")]
			[FieldOffset(Offset = "0x28")]
			public float[] blendshapeWeights;
		}

		// Token: 0x02000C6F RID: 3183
		[Token(Token = "0x2000C6F")]
		[Serializable]
		public class ControlDataForExport
		{
			// Token: 0x06007955 RID: 31061 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007955")]
			[Address(RVA = "0x148674C", Offset = "0x148674C", VA = "0x148674C")]
			public ControlDataForExport()
			{
			}

			// Token: 0x040033DA RID: 13274
			[Token(Token = "0x40033DA")]
			[FieldOffset(Offset = "0x10")]
			public ControlData.EyeControl eyeControl;

			// Token: 0x040033DB RID: 13275
			[Token(Token = "0x40033DB")]
			[FieldOffset(Offset = "0x14")]
			public ControlData.EyelidBoneMode eyelidBoneMode;

			// Token: 0x040033DC RID: 13276
			[Token(Token = "0x40033DC")]
			[FieldOffset(Offset = "0x18")]
			public string leftEyePath;

			// Token: 0x040033DD RID: 13277
			[Token(Token = "0x40033DD")]
			[FieldOffset(Offset = "0x20")]
			public string rightEyePath;

			// Token: 0x040033DE RID: 13278
			[Token(Token = "0x40033DE")]
			[FieldOffset(Offset = "0x28")]
			public float maxEyeUpBoneAngle;

			// Token: 0x040033DF RID: 13279
			[Token(Token = "0x40033DF")]
			[FieldOffset(Offset = "0x2C")]
			public float maxEyeDownBoneAngle;

			// Token: 0x040033E0 RID: 13280
			[Token(Token = "0x40033E0")]
			[FieldOffset(Offset = "0x30")]
			public float maxEyeUpEyeballAngle;

			// Token: 0x040033E1 RID: 13281
			[Token(Token = "0x40033E1")]
			[FieldOffset(Offset = "0x34")]
			public float maxEyeDownEyeballAngle;

			// Token: 0x040033E2 RID: 13282
			[Token(Token = "0x40033E2")]
			[FieldOffset(Offset = "0x38")]
			public bool isEyeBallDefaultSet;

			// Token: 0x040033E3 RID: 13283
			[Token(Token = "0x40033E3")]
			[FieldOffset(Offset = "0x39")]
			public bool isEyeBoneDefaultSet;

			// Token: 0x040033E4 RID: 13284
			[Token(Token = "0x40033E4")]
			[FieldOffset(Offset = "0x3A")]
			public bool isEyeBallLookUpSet;

			// Token: 0x040033E5 RID: 13285
			[Token(Token = "0x40033E5")]
			[FieldOffset(Offset = "0x3B")]
			public bool isEyeBoneLookUpSet;

			// Token: 0x040033E6 RID: 13286
			[Token(Token = "0x40033E6")]
			[FieldOffset(Offset = "0x3C")]
			public bool isEyeBallLookDownSet;

			// Token: 0x040033E7 RID: 13287
			[Token(Token = "0x40033E7")]
			[FieldOffset(Offset = "0x3D")]
			public bool isEyeBoneLookDownSet;

			// Token: 0x040033E8 RID: 13288
			[Token(Token = "0x40033E8")]
			[FieldOffset(Offset = "0x40")]
			public EyeRotationLimiter.EyeRotationLimiterForExport leftBoneEyeRotationLimiter;

			// Token: 0x040033E9 RID: 13289
			[Token(Token = "0x40033E9")]
			[FieldOffset(Offset = "0x48")]
			public EyeRotationLimiter.EyeRotationLimiterForExport rightBoneEyeRotationLimiter;

			// Token: 0x040033EA RID: 13290
			[Token(Token = "0x40033EA")]
			[FieldOffset(Offset = "0x50")]
			public EyeRotationLimiter.EyeRotationLimiterForExport leftEyeballEyeRotationLimiter;

			// Token: 0x040033EB RID: 13291
			[Token(Token = "0x40033EB")]
			[FieldOffset(Offset = "0x58")]
			public EyeRotationLimiter.EyeRotationLimiterForExport rightEyeballEyeRotationLimiter;

			// Token: 0x040033EC RID: 13292
			[Token(Token = "0x40033EC")]
			[FieldOffset(Offset = "0x60")]
			public ControlData.EyelidControl eyelidControl;

			// Token: 0x040033ED RID: 13293
			[Token(Token = "0x40033ED")]
			[FieldOffset(Offset = "0x64")]
			public bool eyelidsFollowEyesVertically;

			// Token: 0x040033EE RID: 13294
			[Token(Token = "0x40033EE")]
			[FieldOffset(Offset = "0x68")]
			public string upperEyeLidLeftPath;

			// Token: 0x040033EF RID: 13295
			[Token(Token = "0x40033EF")]
			[FieldOffset(Offset = "0x70")]
			public string upperEyeLidRightPath;

			// Token: 0x040033F0 RID: 13296
			[Token(Token = "0x40033F0")]
			[FieldOffset(Offset = "0x78")]
			public string lowerEyeLidLeftPath;

			// Token: 0x040033F1 RID: 13297
			[Token(Token = "0x40033F1")]
			[FieldOffset(Offset = "0x80")]
			public string lowerEyeLidRightPath;

			// Token: 0x040033F2 RID: 13298
			[Token(Token = "0x40033F2")]
			[FieldOffset(Offset = "0x88")]
			public bool isEyelidBonesDefaultSet;

			// Token: 0x040033F3 RID: 13299
			[Token(Token = "0x40033F3")]
			[FieldOffset(Offset = "0x89")]
			public bool isEyelidBonesClosedSet;

			// Token: 0x040033F4 RID: 13300
			[Token(Token = "0x40033F4")]
			[FieldOffset(Offset = "0x8A")]
			public bool isEyelidBonesLookUpSet;

			// Token: 0x040033F5 RID: 13301
			[Token(Token = "0x40033F5")]
			[FieldOffset(Offset = "0x8B")]
			public bool isEyelidBonesLookDownSet;

			// Token: 0x040033F6 RID: 13302
			[Token(Token = "0x40033F6")]
			[FieldOffset(Offset = "0x90")]
			public EyelidRotationLimiter.EyelidRotationLimiterForExport upperLeftLimiter;

			// Token: 0x040033F7 RID: 13303
			[Token(Token = "0x40033F7")]
			[FieldOffset(Offset = "0x98")]
			public EyelidRotationLimiter.EyelidRotationLimiterForExport upperRightLimiter;

			// Token: 0x040033F8 RID: 13304
			[Token(Token = "0x40033F8")]
			[FieldOffset(Offset = "0xA0")]
			public EyelidRotationLimiter.EyelidRotationLimiterForExport lowerLeftLimiter;

			// Token: 0x040033F9 RID: 13305
			[Token(Token = "0x40033F9")]
			[FieldOffset(Offset = "0xA8")]
			public EyelidRotationLimiter.EyelidRotationLimiterForExport lowerRightLimiter;

			// Token: 0x040033FA RID: 13306
			[Token(Token = "0x40033FA")]
			[FieldOffset(Offset = "0xB0")]
			public float eyeWidenOrSquint;

			// Token: 0x040033FB RID: 13307
			[Token(Token = "0x40033FB")]
			[FieldOffset(Offset = "0xB8")]
			public ControlData.EyelidPositionBlendshapeForExport[] blendshapesForBlinking;

			// Token: 0x040033FC RID: 13308
			[Token(Token = "0x40033FC")]
			[FieldOffset(Offset = "0xC0")]
			public ControlData.EyelidPositionBlendshapeForExport[] blendshapesForLookingUp;

			// Token: 0x040033FD RID: 13309
			[Token(Token = "0x40033FD")]
			[FieldOffset(Offset = "0xC8")]
			public ControlData.EyelidPositionBlendshapeForExport[] blendshapesForLookingDown;

			// Token: 0x040033FE RID: 13310
			[Token(Token = "0x40033FE")]
			[FieldOffset(Offset = "0xD0")]
			public ControlData.BlendshapesConfigForExport[] blendshapesConfigs;

			// Token: 0x040033FF RID: 13311
			[Token(Token = "0x40033FF")]
			[FieldOffset(Offset = "0xD8")]
			public bool isEyelidBlendshapeDefaultSet;

			// Token: 0x04003400 RID: 13312
			[Token(Token = "0x4003400")]
			[FieldOffset(Offset = "0xD9")]
			public bool isEyelidBlendshapeClosedSet;

			// Token: 0x04003401 RID: 13313
			[Token(Token = "0x4003401")]
			[FieldOffset(Offset = "0xDA")]
			public bool isEyelidBlendshapeLookUpSet;

			// Token: 0x04003402 RID: 13314
			[Token(Token = "0x4003402")]
			[FieldOffset(Offset = "0xDB")]
			public bool isEyelidBlendshapeLookDownSet;
		}
	}
}
