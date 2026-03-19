using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace RealisticEyeMovements
{
	// Token: 0x02000C70 RID: 3184
	[Token(Token = "0x2000C70")]
	[Serializable]
	public class ControlDataForSerialization
	{
		// Token: 0x06007956 RID: 31062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007956")]
		[Address(RVA = "0x1486754", Offset = "0x1486754", VA = "0x1486754")]
		public static ControlDataForSerialization CreateFromLegacy(ControlData.ControlDataForExport export)
		{
			return null;
		}

		// Token: 0x06007957 RID: 31063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007957")]
		[Address(RVA = "0x1486C78", Offset = "0x1486C78", VA = "0x1486C78")]
		public ControlDataForSerialization()
		{
		}

		// Token: 0x04003403 RID: 13315
		[Token(Token = "0x4003403")]
		[FieldOffset(Offset = "0x10")]
		public float eyeWidenOrSquint;

		// Token: 0x04003404 RID: 13316
		[Token(Token = "0x4003404")]
		[FieldOffset(Offset = "0x14")]
		public ControlData.EyeControl eyeControl;

		// Token: 0x04003405 RID: 13317
		[Token(Token = "0x4003405")]
		[FieldOffset(Offset = "0x18")]
		public ControlData.EyelidBoneMode eyelidBoneMode;

		// Token: 0x04003406 RID: 13318
		[Token(Token = "0x4003406")]
		[FieldOffset(Offset = "0x20")]
		public string leftEyePath;

		// Token: 0x04003407 RID: 13319
		[Token(Token = "0x4003407")]
		[FieldOffset(Offset = "0x28")]
		public string rightEyePath;

		// Token: 0x04003408 RID: 13320
		[Token(Token = "0x4003408")]
		[FieldOffset(Offset = "0x30")]
		public float maxEyeUpBoneAngle;

		// Token: 0x04003409 RID: 13321
		[Token(Token = "0x4003409")]
		[FieldOffset(Offset = "0x34")]
		public float maxEyeDownBoneAngle;

		// Token: 0x0400340A RID: 13322
		[Token(Token = "0x400340A")]
		[FieldOffset(Offset = "0x38")]
		public float maxEyeUpEyeballAngle;

		// Token: 0x0400340B RID: 13323
		[Token(Token = "0x400340B")]
		[FieldOffset(Offset = "0x3C")]
		public float maxEyeDownEyeballAngle;

		// Token: 0x0400340C RID: 13324
		[Token(Token = "0x400340C")]
		[FieldOffset(Offset = "0x40")]
		public bool isEyeBallDefaultSet;

		// Token: 0x0400340D RID: 13325
		[Token(Token = "0x400340D")]
		[FieldOffset(Offset = "0x41")]
		public bool isEyeBoneDefaultSet;

		// Token: 0x0400340E RID: 13326
		[Token(Token = "0x400340E")]
		[FieldOffset(Offset = "0x42")]
		public bool isEyeBallLookUpSet;

		// Token: 0x0400340F RID: 13327
		[Token(Token = "0x400340F")]
		[FieldOffset(Offset = "0x43")]
		public bool isEyeBoneLookUpSet;

		// Token: 0x04003410 RID: 13328
		[Token(Token = "0x4003410")]
		[FieldOffset(Offset = "0x44")]
		public bool isEyeBallLookDownSet;

		// Token: 0x04003411 RID: 13329
		[Token(Token = "0x4003411")]
		[FieldOffset(Offset = "0x45")]
		public bool isEyeBoneLookDownSet;

		// Token: 0x04003412 RID: 13330
		[Token(Token = "0x4003412")]
		[FieldOffset(Offset = "0x48")]
		public EyeRotationLimiter.EyeRotationLimiterForExport leftBoneEyeRotationLimiter;

		// Token: 0x04003413 RID: 13331
		[Token(Token = "0x4003413")]
		[FieldOffset(Offset = "0x50")]
		public EyeRotationLimiter.EyeRotationLimiterForExport rightBoneEyeRotationLimiter;

		// Token: 0x04003414 RID: 13332
		[Token(Token = "0x4003414")]
		[FieldOffset(Offset = "0x58")]
		public EyeRotationLimiter.EyeRotationLimiterForExport leftEyeballEyeRotationLimiter;

		// Token: 0x04003415 RID: 13333
		[Token(Token = "0x4003415")]
		[FieldOffset(Offset = "0x60")]
		public EyeRotationLimiter.EyeRotationLimiterForExport rightEyeballEyeRotationLimiter;

		// Token: 0x04003416 RID: 13334
		[Token(Token = "0x4003416")]
		[FieldOffset(Offset = "0x68")]
		public ControlData.EyelidControl eyelidControl;

		// Token: 0x04003417 RID: 13335
		[Token(Token = "0x4003417")]
		[FieldOffset(Offset = "0x70")]
		public List<string> upperLeftEyelidBonePaths;

		// Token: 0x04003418 RID: 13336
		[Token(Token = "0x4003418")]
		[FieldOffset(Offset = "0x78")]
		public List<string> upperRightEyelidBonePaths;

		// Token: 0x04003419 RID: 13337
		[Token(Token = "0x4003419")]
		[FieldOffset(Offset = "0x80")]
		public List<string> lowerLeftEyelidBonePaths;

		// Token: 0x0400341A RID: 13338
		[Token(Token = "0x400341A")]
		[FieldOffset(Offset = "0x88")]
		public List<string> lowerRightEyelidBonePaths;

		// Token: 0x0400341B RID: 13339
		[Token(Token = "0x400341B")]
		[FieldOffset(Offset = "0x90")]
		public bool isEyelidBonesDefaultSet;

		// Token: 0x0400341C RID: 13340
		[Token(Token = "0x400341C")]
		[FieldOffset(Offset = "0x91")]
		public bool isEyelidBonesClosedSet;

		// Token: 0x0400341D RID: 13341
		[Token(Token = "0x400341D")]
		[FieldOffset(Offset = "0x92")]
		public bool isEyelidBonesLookUpSet;

		// Token: 0x0400341E RID: 13342
		[Token(Token = "0x400341E")]
		[FieldOffset(Offset = "0x93")]
		public bool isEyelidBonesLookDownSet;

		// Token: 0x0400341F RID: 13343
		[Token(Token = "0x400341F")]
		[FieldOffset(Offset = "0x98")]
		public List<EyelidRotationLimiter.EyelidRotationLimiterForExport> upperLeftLimiters;

		// Token: 0x04003420 RID: 13344
		[Token(Token = "0x4003420")]
		[FieldOffset(Offset = "0xA0")]
		public List<EyelidRotationLimiter.EyelidRotationLimiterForExport> upperRightLimiters;

		// Token: 0x04003421 RID: 13345
		[Token(Token = "0x4003421")]
		[FieldOffset(Offset = "0xA8")]
		public List<EyelidRotationLimiter.EyelidRotationLimiterForExport> lowerLeftLimiters;

		// Token: 0x04003422 RID: 13346
		[Token(Token = "0x4003422")]
		[FieldOffset(Offset = "0xB0")]
		public List<EyelidRotationLimiter.EyelidRotationLimiterForExport> lowerRightLimiters;

		// Token: 0x04003423 RID: 13347
		[Token(Token = "0x4003423")]
		[FieldOffset(Offset = "0xB8")]
		public ControlData.EyelidPositionBlendshapeForExport[] blendshapesForBlinking;

		// Token: 0x04003424 RID: 13348
		[Token(Token = "0x4003424")]
		[FieldOffset(Offset = "0xC0")]
		public ControlData.EyelidPositionBlendshapeForExport[] blendshapesForLookingUp;

		// Token: 0x04003425 RID: 13349
		[Token(Token = "0x4003425")]
		[FieldOffset(Offset = "0xC8")]
		public ControlData.EyelidPositionBlendshapeForExport[] blendshapesForLookingDown;

		// Token: 0x04003426 RID: 13350
		[Token(Token = "0x4003426")]
		[FieldOffset(Offset = "0xD0")]
		public bool isEyelidBlendshapeDefaultSet;

		// Token: 0x04003427 RID: 13351
		[Token(Token = "0x4003427")]
		[FieldOffset(Offset = "0xD1")]
		public bool isEyelidBlendshapeClosedSet;

		// Token: 0x04003428 RID: 13352
		[Token(Token = "0x4003428")]
		[FieldOffset(Offset = "0xD2")]
		public bool isEyelidBlendshapeLookUpSet;

		// Token: 0x04003429 RID: 13353
		[Token(Token = "0x4003429")]
		[FieldOffset(Offset = "0xD3")]
		public bool isEyelidBlendshapeLookDownSet;

		// Token: 0x0400342A RID: 13354
		[Token(Token = "0x400342A")]
		[FieldOffset(Offset = "0xD4")]
		public bool arePathsRelativeToHead;
	}
}
