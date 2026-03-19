using System;
using Il2CppDummyDll;
using UnityEngine;

namespace usky
{
	// Token: 0x02000A27 RID: 2599
	[Token(Token = "0x2000A27")]
	[Serializable]
	public struct ScatterOcclusionSettings
	{
		// Token: 0x04002748 RID: 10056
		[Token(Token = "0x4002748")]
		[FieldOffset(Offset = "0x0")]
		[Tooltip("This flag enables scatter occlusion")]
		public bool useOcclusion;

		// Token: 0x04002749 RID: 10057
		[Token(Token = "0x4002749")]
		[FieldOffset(Offset = "0x4")]
		[Tooltip("Controls how dark the occlusion on earth.\nA value of 0 results full occlusion darkening.\nA value of 1 results no darkening term.")]
		[Range(0f, 1f)]
		public float occlusionDarkness;

		// Token: 0x0400274A RID: 10058
		[Token(Token = "0x400274A")]
		[FieldOffset(Offset = "0x8")]
		[Tooltip("Controls the down sample scale of the screen resolution for occlusion gathering.")]
		public OcclusionDownscaleMode occlusionDownscale;

		// Token: 0x0400274B RID: 10059
		[Token(Token = "0x400274B")]
		[FieldOffset(Offset = "0xC")]
		[Tooltip("The number of samples to use in occlusion gathering.")]
		public OcclusionSamplesMode occlusionSamples;

		// Token: 0x0400274C RID: 10060
		[Token(Token = "0x400274C")]
		[FieldOffset(Offset = "0x10")]
		[Tooltip("Draw occlusion pass only.")]
		public bool occlusionDebug;
	}
}
