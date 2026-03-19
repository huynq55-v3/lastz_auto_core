using System;
using Il2CppDummyDll;
using UnityEngine;

namespace usky
{
	// Token: 0x02000A1F RID: 2591
	[Token(Token = "0x2000A1F")]
	[Serializable]
	public struct NightSkySettings
	{
		// Token: 0x04002724 RID: 10020
		[Token(Token = "0x4002724")]
		[FieldOffset(Offset = "0x0")]
		public NightModes nightMode;

		// Token: 0x04002725 RID: 10021
		[Token(Token = "0x4002725")]
		[FieldOffset(Offset = "0x4")]
		[Range(0f, 5f)]
		[Tooltip("Control the intensity of the Star field in night sky.\nIf this value is at zero, stars rendering will be disabled")]
		public float starIntensity;

		// Token: 0x04002726 RID: 10022
		[Token(Token = "0x4002726")]
		[FieldOffset(Offset = "0x8")]
		[Range(0f, 2f)]
		[Tooltip("This controls the intensity of the Outer Space Cubemap in night sky.")]
		public float outerSpaceIntensity;

		// Token: 0x04002727 RID: 10023
		[Token(Token = "0x4002727")]
		[FieldOffset(Offset = "0xC")]
		[Tooltip("The color of the moon's inner corona.\n This Alpha value controls the size and blurriness corona.")]
		public Color moonInnerCorona;

		// Token: 0x04002728 RID: 10024
		[Token(Token = "0x4002728")]
		[FieldOffset(Offset = "0x1C")]
		[Tooltip("The color of the moon's outer corona.\nThis Alpha value controls the size and blurriness corona.")]
		public Color moonOuterCorona;

		// Token: 0x04002729 RID: 10025
		[Token(Token = "0x4002729")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 5f)]
		[Tooltip("This controls the moon texture size in the night sky.")]
		public float moonSize;
	}
}
