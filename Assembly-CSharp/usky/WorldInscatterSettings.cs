using System;
using Il2CppDummyDll;
using UnityEngine;

namespace usky
{
	// Token: 0x02000A26 RID: 2598
	[Token(Token = "0x2000A26")]
	[Serializable]
	public struct WorldInscatterSettings
	{
		// Token: 0x04002743 RID: 10051
		[Token(Token = "0x4002743")]
		[FieldOffset(Offset = "0x0")]
		[Tooltip("Enable World Atmospheric Scattering Image Effect")]
		public bool enableScattering;

		// Token: 0x04002744 RID: 10052
		[Token(Token = "0x4002744")]
		[FieldOffset(Offset = "0x4")]
		[Tooltip("Control the inscattering intensity on the earth")]
		[Range(0f, 5f)]
		public float scatteringIntensity;

		// Token: 0x04002745 RID: 10053
		[Token(Token = "0x4002745")]
		[FieldOffset(Offset = "0x8")]
		[Tooltip("How much light is out-scattered or absorbed on the earth. Basically how much to darken the shaded pixel.")]
		[Range(0f, 1f)]
		public float scatterExtinction;

		// Token: 0x04002746 RID: 10054
		[Token(Token = "0x4002746")]
		[FieldOffset(Offset = "0xC")]
		[Tooltip("Control the world scale factor for the scattering on the earth")]
		public float worldScatterScale;

		// Token: 0x04002747 RID: 10055
		[Token(Token = "0x4002747")]
		[FieldOffset(Offset = "0x10")]
		[Tooltip("Allows the scattering to be pushed out to have no scattering directly in front of the camera, or pulled in to have more scattering close to the camera.")]
		public float nearScatterPush;
	}
}
