using System;
using Il2CppDummyDll;

namespace RealisticEyeMovements
{
	// Token: 0x02000C75 RID: 3189
	[Token(Token = "0x2000C75")]
	[Serializable]
	public class EyeAndHeadAnimatorForSerialization
	{
		// Token: 0x06007967 RID: 31079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007967")]
		[Address(RVA = "0x1487420", Offset = "0x1487420", VA = "0x1487420")]
		public static EyeAndHeadAnimatorForSerialization CreateFromLegacy(EyeAndHeadAnimatorForExport export)
		{
			return null;
		}

		// Token: 0x06007968 RID: 31080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007968")]
		[Address(RVA = "0x1487504", Offset = "0x1487504", VA = "0x1487504")]
		public EyeAndHeadAnimatorForSerialization()
		{
		}

		// Token: 0x04003433 RID: 13363
		[Token(Token = "0x4003433")]
		[FieldOffset(Offset = "0x10")]
		public float mainWeight;

		// Token: 0x04003434 RID: 13364
		[Token(Token = "0x4003434")]
		[FieldOffset(Offset = "0x14")]
		public float eyesWeight;

		// Token: 0x04003435 RID: 13365
		[Token(Token = "0x4003435")]
		[FieldOffset(Offset = "0x18")]
		public float eyelidsWeight;

		// Token: 0x04003436 RID: 13366
		[Token(Token = "0x4003436")]
		[FieldOffset(Offset = "0x1C")]
		public HeadComponent.HeadControl headControl;

		// Token: 0x04003437 RID: 13367
		[Token(Token = "0x4003437")]
		[FieldOffset(Offset = "0x20")]
		public HeadComponent.HeadAnimationType headAnimationType;

		// Token: 0x04003438 RID: 13368
		[Token(Token = "0x4003438")]
		[FieldOffset(Offset = "0x24")]
		public EyeAndHeadAnimator.UpdateType updateType;

		// Token: 0x04003439 RID: 13369
		[Token(Token = "0x4003439")]
		[FieldOffset(Offset = "0x28")]
		public string headBonePath;

		// Token: 0x0400343A RID: 13370
		[Token(Token = "0x400343A")]
		[FieldOffset(Offset = "0x30")]
		public string neckBonePath;

		// Token: 0x0400343B RID: 13371
		[Token(Token = "0x400343B")]
		[FieldOffset(Offset = "0x38")]
		public string spineBonePath;

		// Token: 0x0400343C RID: 13372
		[Token(Token = "0x400343C")]
		[FieldOffset(Offset = "0x40")]
		public float headChangeToNewTargetSpeed;

		// Token: 0x0400343D RID: 13373
		[Token(Token = "0x400343D")]
		[FieldOffset(Offset = "0x44")]
		public float headTrackTargetSpeed;

		// Token: 0x0400343E RID: 13374
		[Token(Token = "0x400343E")]
		[FieldOffset(Offset = "0x48")]
		public float headWeight;

		// Token: 0x0400343F RID: 13375
		[Token(Token = "0x400343F")]
		[FieldOffset(Offset = "0x4C")]
		public float bodyWeight;

		// Token: 0x04003440 RID: 13376
		[Token(Token = "0x4003440")]
		[FieldOffset(Offset = "0x50")]
		public float neckHorizWeight;

		// Token: 0x04003441 RID: 13377
		[Token(Token = "0x4003441")]
		[FieldOffset(Offset = "0x54")]
		public float neckVertWeight;

		// Token: 0x04003442 RID: 13378
		[Token(Token = "0x4003442")]
		[FieldOffset(Offset = "0x58")]
		public bool resetHeadAtFrameStart;

		// Token: 0x04003443 RID: 13379
		[Token(Token = "0x4003443")]
		[FieldOffset(Offset = "0x59")]
		public bool useMicroSaccades;

		// Token: 0x04003444 RID: 13380
		[Token(Token = "0x4003444")]
		[FieldOffset(Offset = "0x5A")]
		public bool useMacroSaccades;

		// Token: 0x04003445 RID: 13381
		[Token(Token = "0x4003445")]
		[FieldOffset(Offset = "0x5B")]
		public bool useHeadJitter;

		// Token: 0x04003446 RID: 13382
		[Token(Token = "0x4003446")]
		[FieldOffset(Offset = "0x5C")]
		public float headJitterFrequency;

		// Token: 0x04003447 RID: 13383
		[Token(Token = "0x4003447")]
		[FieldOffset(Offset = "0x60")]
		public float headJitterAmplitude;

		// Token: 0x04003448 RID: 13384
		[Token(Token = "0x4003448")]
		[FieldOffset(Offset = "0x64")]
		public bool kDrawSightlinesInEditor;

		// Token: 0x04003449 RID: 13385
		[Token(Token = "0x4003449")]
		[FieldOffset(Offset = "0x68")]
		public ControlDataForSerialization controlData;

		// Token: 0x0400344A RID: 13386
		[Token(Token = "0x400344A")]
		[FieldOffset(Offset = "0x70")]
		public float kMinNextBlinkTime;

		// Token: 0x0400344B RID: 13387
		[Token(Token = "0x400344B")]
		[FieldOffset(Offset = "0x74")]
		public float kMaxNextBlinkTime;

		// Token: 0x0400344C RID: 13388
		[Token(Token = "0x400344C")]
		[FieldOffset(Offset = "0x78")]
		public float blinkSpeed;

		// Token: 0x0400344D RID: 13389
		[Token(Token = "0x400344D")]
		[FieldOffset(Offset = "0x7C")]
		public bool eyelidsFollowEyesVertically;

		// Token: 0x0400344E RID: 13390
		[Token(Token = "0x400344E")]
		[FieldOffset(Offset = "0x80")]
		public float maxEyeHorizAngle;

		// Token: 0x0400344F RID: 13391
		[Token(Token = "0x400344F")]
		[FieldOffset(Offset = "0x84")]
		public float maxEyeHorizAngleTowardsNose;

		// Token: 0x04003450 RID: 13392
		[Token(Token = "0x4003450")]
		[FieldOffset(Offset = "0x88")]
		public float idleTargetHorizAngle;

		// Token: 0x04003451 RID: 13393
		[Token(Token = "0x4003451")]
		[FieldOffset(Offset = "0x8C")]
		public float crossEyeCorrection;

		// Token: 0x04003452 RID: 13394
		[Token(Token = "0x4003452")]
		[FieldOffset(Offset = "0x90")]
		public float saccadeSpeed;

		// Token: 0x04003453 RID: 13395
		[Token(Token = "0x4003453")]
		[FieldOffset(Offset = "0x94")]
		public float macroSaccadesPerMinute;

		// Token: 0x04003454 RID: 13396
		[Token(Token = "0x4003454")]
		[FieldOffset(Offset = "0x98")]
		public float microSaccadesPerMinuteLookingIdle;

		// Token: 0x04003455 RID: 13397
		[Token(Token = "0x4003455")]
		[FieldOffset(Offset = "0x9C")]
		public float microSaccadesPerMinuteLookingAtPOI;

		// Token: 0x04003456 RID: 13398
		[Token(Token = "0x4003456")]
		[FieldOffset(Offset = "0xA0")]
		public float limitHeadAngle;
	}
}
