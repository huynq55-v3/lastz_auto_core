using System;
using Il2CppDummyDll;
using UnityEngine;

namespace usky
{
	// Token: 0x02000A25 RID: 2597
	[Token(Token = "0x2000A25")]
	[Serializable]
	public struct AmbientGradientSettings
	{
		// Token: 0x0400273F RID: 10047
		[Token(Token = "0x400273F")]
		[FieldOffset(Offset = "0x0")]
		[Tooltip("Enabled this toggle to switch RenderSettings ambient source to gradient mode.\n\nDisable it if using the skybox ambient lighting from Lighting window setting.\n(Currently skybox ambient lighting doesn't work correctly in this Beta version)")]
		public bool useGradientMode;

		// Token: 0x04002740 RID: 10048
		[Token(Token = "0x4002740")]
		[FieldOffset(Offset = "0x8")]
		[Tooltip("Ambient lighting coming from above.")]
		public Gradient SkyColor;

		// Token: 0x04002741 RID: 10049
		[Token(Token = "0x4002741")]
		[FieldOffset(Offset = "0x10")]
		[Tooltip("Ambient lighting coming from side.")]
		public Gradient EquatorColor;

		// Token: 0x04002742 RID: 10050
		[Token(Token = "0x4002742")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("Ambient lighting coming from below.")]
		public Gradient GroundColor;
	}
}
