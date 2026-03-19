using System;
using Il2CppDummyDll;

namespace RealisticEyeMovements
{
	// Token: 0x02000C82 RID: 3202
	[Token(Token = "0x2000C82")]
	[Serializable]
	public class EyeAndHeadAnimatorForExport
	{
		// Token: 0x060079C4 RID: 31172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079C4")]
		[Address(RVA = "0x148FD38", Offset = "0x148FD38", VA = "0x148FD38")]
		public EyeAndHeadAnimatorForExport()
		{
		}

		// Token: 0x040034CC RID: 13516
		[Token(Token = "0x40034CC")]
		[FieldOffset(Offset = "0x10")]
		public string headBonePath;

		// Token: 0x040034CD RID: 13517
		[Token(Token = "0x40034CD")]
		[FieldOffset(Offset = "0x18")]
		public float headSpeedModifier;

		// Token: 0x040034CE RID: 13518
		[Token(Token = "0x40034CE")]
		[FieldOffset(Offset = "0x1C")]
		public float headWeight;

		// Token: 0x040034CF RID: 13519
		[Token(Token = "0x40034CF")]
		[FieldOffset(Offset = "0x20")]
		public bool useMicroSaccades;

		// Token: 0x040034D0 RID: 13520
		[Token(Token = "0x40034D0")]
		[FieldOffset(Offset = "0x21")]
		public bool useMacroSaccades;

		// Token: 0x040034D1 RID: 13521
		[Token(Token = "0x40034D1")]
		[FieldOffset(Offset = "0x22")]
		public bool kDrawSightlinesInEditor;

		// Token: 0x040034D2 RID: 13522
		[Token(Token = "0x40034D2")]
		[FieldOffset(Offset = "0x28")]
		public ControlData.ControlDataForExport controlData;

		// Token: 0x040034D3 RID: 13523
		[Token(Token = "0x40034D3")]
		[FieldOffset(Offset = "0x30")]
		public float kMinNextBlinkTime;

		// Token: 0x040034D4 RID: 13524
		[Token(Token = "0x40034D4")]
		[FieldOffset(Offset = "0x34")]
		public float kMaxNextBlinkTime;

		// Token: 0x040034D5 RID: 13525
		[Token(Token = "0x40034D5")]
		[FieldOffset(Offset = "0x38")]
		public bool eyelidsFollowEyesVertically;

		// Token: 0x040034D6 RID: 13526
		[Token(Token = "0x40034D6")]
		[FieldOffset(Offset = "0x3C")]
		public float maxEyeHorizAngle;

		// Token: 0x040034D7 RID: 13527
		[Token(Token = "0x40034D7")]
		[FieldOffset(Offset = "0x40")]
		public float maxEyeHorizAngleTowardsNose;

		// Token: 0x040034D8 RID: 13528
		[Token(Token = "0x40034D8")]
		[FieldOffset(Offset = "0x44")]
		public float crossEyeCorrection;

		// Token: 0x040034D9 RID: 13529
		[Token(Token = "0x40034D9")]
		[FieldOffset(Offset = "0x48")]
		public float nervousness;

		// Token: 0x040034DA RID: 13530
		[Token(Token = "0x40034DA")]
		[FieldOffset(Offset = "0x4C")]
		public float limitHeadAngle;
	}
}
