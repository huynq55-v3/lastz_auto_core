using System;
using Il2CppDummyDll;
using UnityEngine;

namespace usky
{
	// Token: 0x02000A20 RID: 2592
	[Token(Token = "0x2000A20")]
	[Serializable]
	public struct OtherSettings
	{
		// Token: 0x0400272A RID: 10026
		[Token(Token = "0x400272A")]
		[FieldOffset(Offset = "0x0")]
		[Range(0f, 10000f)]
		[Tooltip("This is a constant altitude offset for camera view position in Skybox.\nHigher the value means the height of the camera view position will offset to atmosphere level.")]
		public float groundOffset;

		// Token: 0x0400272B RID: 10027
		[Token(Token = "0x400272B")]
		[FieldOffset(Offset = "0x4")]
		[Range(0f, 20f)]
		[Tooltip("This is a current camera height position multiplier in Skybox.\nHigher the value means the camera height position will move faster to atmosphere level.\n\nIf the value is 0, the camera is always viewing at the sea level, and skybox horizion will not produce any curve effect.\nIf both ground offset and altitude scale are always set to 0 value, recommended just uses Altitude Sample X1 for better rendering performance.")]
		public float altitudeScale;

		// Token: 0x0400272C RID: 10028
		[Token(Token = "0x400272C")]
		[FieldOffset(Offset = "0x8")]
		[Tooltip("Disable the default ocean rendering effect on the Skybox.\nThere are no performance gain by disabled it.")]
		public bool disableSkyboxOcean;

		// Token: 0x0400272D RID: 10029
		[Token(Token = "0x400272D")]
		[FieldOffset(Offset = "0x9")]
		[Tooltip("Toggle it if the Main Camera is using HDR mode and Tonemapping image effect.")]
		public bool HDRMode;
	}
}
