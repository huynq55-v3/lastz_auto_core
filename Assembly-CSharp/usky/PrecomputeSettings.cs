using System;
using Il2CppDummyDll;
using UnityEngine;

namespace usky
{
	// Token: 0x02000A21 RID: 2593
	[Token(Token = "0x2000A21")]
	[Serializable]
	public struct PrecomputeSettings
	{
		// Token: 0x0400272E RID: 10030
		[Token(Token = "0x400272E")]
		[FieldOffset(Offset = "0x0")]
		[Range(0f, 1.8f)]
		[Tooltip("Rayleigh scattering density scale. Increase this value produces typical earth-like sky colors (reddish/yellowish colors at sun set, and the like).")]
		public float atmosphereThickness;

		// Token: 0x0400272F RID: 10031
		[Token(Token = "0x400272F")]
		[FieldOffset(Offset = "0x4")]
		[Tooltip("It is visible spectrum light waves (range 380 to 780).\n\nTweaking these values will shift the colors of the resulting gradients and produce different kinds of atmospheres.")]
		public Vector3 wavelengths;

		// Token: 0x04002730 RID: 10032
		[Token(Token = "0x4002730")]
		[FieldOffset(Offset = "0x10")]
		[Tooltip("Tweaking this color value is simular to change the Wavelengths value to shift the colors of the sky.\nThis is just for more artist friendly control of wavelengths.")]
		public Color skyTint;

		// Token: 0x04002731 RID: 10033
		[Token(Token = "0x4002731")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Number of different altitudes at which to sample inscatter color.\n\nX1 is a single inscatter sample for ground level only.\nIt uses also less calculation in the shader for better rendering performance. (Texture Memory: 256KB)\n\nX4 includes atmosphere level inscatter samples that divided into four layers, which allows camera to travel nearby atmosphere on the earth with correct inscatter color. (Texture Memory: 1.0MB)")]
		public DepthSample inscatterAltitudeSample;
	}
}
