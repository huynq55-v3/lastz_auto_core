using System;
using Il2CppDummyDll;
using UnityEngine;

namespace usky
{
	// Token: 0x02000A22 RID: 2594
	[Token(Token = "0x2000A22")]
	[Serializable]
	public struct DefaultTimelineSettings
	{
		// Token: 0x04002732 RID: 10034
		[Token(Token = "0x4002732")]
		[FieldOffset(Offset = "0x0")]
		[Range(-180f, 180f)]
		[Tooltip("Controls the sun light direction align horizionally.")]
		public float sunDirection;

		// Token: 0x04002733 RID: 10035
		[Token(Token = "0x4002733")]
		[FieldOffset(Offset = "0x4")]
		[Range(-60f, 60f)]
		[Tooltip("Controls sun path offset")]
		public float sunEquatorOffset;

		// Token: 0x04002734 RID: 10036
		[Token(Token = "0x4002734")]
		[FieldOffset(Offset = "0x8")]
		[Range(-60f, 60f)]
		[Tooltip("Controls the moon position in \"Rotation\" night mode\n\nIf night sky is \"Static\", the moon can be rotate freely with rotation tool in Editor.")]
		public float moonPositionOffset;
	}
}
