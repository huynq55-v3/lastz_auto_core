using System;
using Il2CppDummyDll;
using UnityEngine;

namespace usky
{
	// Token: 0x02000A24 RID: 2596
	[Token(Token = "0x2000A24")]
	[Serializable]
	public struct DayNightCycleSettings
	{
		// Token: 0x0400273B RID: 10043
		[Token(Token = "0x400273B")]
		[FieldOffset(Offset = "0x0")]
		public bool playAtRuntime;

		// Token: 0x0400273C RID: 10044
		[Token(Token = "0x400273C")]
		[FieldOffset(Offset = "0x8")]
		[Tooltip("Controls how fast the play speed during day and night cycles.\n\nDefault time curve keys have been set to 25% faster at night.\n\nCurve key value of 1 means no speed change, and if key value is higher means the play speed is faster, vice versa.")]
		public AnimationCurve cycleSpeedCurve;

		// Token: 0x0400273D RID: 10045
		[Token(Token = "0x400273D")]
		[FieldOffset(Offset = "0x10")]
		[Tooltip("Controls how much the distance when sun moves between Interval update.")]
		public float playSpeed;

		// Token: 0x0400273E RID: 10046
		[Token(Token = "0x400273E")]
		[FieldOffset(Offset = "0x14")]
		[Tooltip("Update Timeline per second.\n\nBy default the Reflection Probes \"RunTime Time Slicing\" is set to \"All Face At Once\" which spreads update over 9 frames. So the minimum value should be arround 0.3.\n\nIf this value is 0 means it will update everyframe, in this case the Reflection Probes Updater \"RunTime Time Slicing\" should set to \"No Time Slicing\"")]
		public float steppedInterval;
	}
}
