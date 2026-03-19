using System;
using Il2CppDummyDll;
using UnityEngine;

namespace usky
{
	// Token: 0x02000A15 RID: 2581
	[Token(Token = "0x2000A15")]
	[AddComponentMenu("uSkyPro/uSky LightShafts")]
	[ExecuteInEditMode]
	[ImageEffectAllowedInSceneView]
	[RequireComponent(typeof(Camera))]
	public class uSkyLightShafts : MonoBehaviour
	{
		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x0600627C RID: 25212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000658")]
		private uSkySun m_Sun
		{
			[Token(Token = "0x600627C")]
			[Address(RVA = "0x3035B70", Offset = "0x3035B70", VA = "0x3035B70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600627D RID: 25213 RVA: 0x0004BA20 File Offset: 0x00049C20
		[Token(Token = "0x600627D")]
		[Address(RVA = "0x3035BB8", Offset = "0x3035BB8", VA = "0x3035BB8")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		// Token: 0x0600627E RID: 25214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600627E")]
		[Address(RVA = "0x3035BE4", Offset = "0x3035BE4", VA = "0x3035BE4")]
		protected void OnEnable()
		{
		}

		// Token: 0x0600627F RID: 25215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600627F")]
		[Address(RVA = "0x3035D58", Offset = "0x3035D58", VA = "0x3035D58")]
		protected void OnDestroy()
		{
		}

		// Token: 0x06006280 RID: 25216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006280")]
		[Address(RVA = "0x3035DE4", Offset = "0x3035DE4", VA = "0x3035DE4")]
		protected void Start()
		{
		}

		// Token: 0x06006281 RID: 25217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006281")]
		[Address(RVA = "0x3035EA0", Offset = "0x3035EA0", VA = "0x3035EA0")]
		private void DownsampledViewSize()
		{
		}

		// Token: 0x06006282 RID: 25218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006282")]
		[Address(RVA = "0x3035ED0", Offset = "0x3035ED0", VA = "0x3035ED0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06006283 RID: 25219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006283")]
		[Address(RVA = "0x3036454", Offset = "0x3036454", VA = "0x3036454")]
		public void OnValidate()
		{
		}

		// Token: 0x06006284 RID: 25220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006284")]
		[Address(RVA = "0x3036494", Offset = "0x3036494", VA = "0x3036494")]
		public uSkyLightShafts()
		{
		}

		// Token: 0x040026F6 RID: 9974
		[Token(Token = "0x40026F6")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("Debug View Mode")]
		public uSkyLightShafts.DebugViewMode DebugMode;

		// Token: 0x040026F7 RID: 9975
		[Token(Token = "0x40026F7")]
		[FieldOffset(Offset = "0x1C")]
		[Tooltip("\"Low\" is Quarter-Resolution. \r\n\"Normal\" is Half-Resolution: Default setting. \r\n\"High\" is Full-Resolution.")]
		public uSkyLightShafts.LightShaftsResolution resolution;

		// Token: 0x040026F8 RID: 9976
		[Token(Token = "0x40026F8")]
		[FieldOffset(Offset = "0x20")]
		private Transform LightShaftsTransform;

		// Token: 0x040026F9 RID: 9977
		[Token(Token = "0x40026F9")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Scales additive color near the light source, A value of 0 will result in no additive term.")]
		[Range(0f, 10f)]
		[Header("Light Shaft Bloom")]
		public float BloomScale;

		// Token: 0x040026FA RID: 9978
		[Token(Token = "0x40026FA")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 10f)]
		[Tooltip("Control the Bloom's radius size. 1 is the default value, higher value will create larger shafts' radius")]
		public float BloomRadius;

		// Token: 0x040026FB RID: 9979
		[Token(Token = "0x40026FB")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[Tooltip("Scene (RGB) color luminance must be larger than this to create bloom in light shafts.")]
		public float BloomThreshold;

		// Token: 0x040026FC RID: 9980
		[Token(Token = "0x40026FC")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("Multiplies against scene color to create the bloom color.")]
		public Color BloomTint;

		// Token: 0x040026FD RID: 9981
		[Token(Token = "0x40026FD")]
		[FieldOffset(Offset = "0x44")]
		[Header("Light Shaft Occlusion")]
		[Tooltip("Everything closer to the camera than this distance will occlude light shafts.\r\n\nSet this value to halve of the camera far clipping plane will be a good default value.")]
		public float OcclusionDepthRange;

		// Token: 0x040026FE RID: 9982
		[Token(Token = "0x40026FE")]
		[FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		[Tooltip("Control how dark is the occlusion masking is, a value of 1 result in no darking term.")]
		public float OcclusionMaskDarkness;

		// Token: 0x040026FF RID: 9983
		[Token(Token = "0x40026FF")]
		[FieldOffset(Offset = "0x50")]
		private Camera cam;

		// Token: 0x04002700 RID: 9984
		[Token(Token = "0x4002700")]
		[FieldOffset(Offset = "0x58")]
		private bool isSupported;

		// Token: 0x04002701 RID: 9985
		[Token(Token = "0x4002701")]
		[FieldOffset(Offset = "0x5C")]
		private int DownsampleFactor;

		// Token: 0x04002702 RID: 9986
		[Token(Token = "0x4002702")]
		[FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public Shader m_LightShaftsComposite;

		// Token: 0x04002703 RID: 9987
		[Token(Token = "0x4002703")]
		[FieldOffset(Offset = "0x68")]
		private Material m_LightShaftsMaterial;

		// Token: 0x02000A16 RID: 2582
		[Token(Token = "0x2000A16")]
		public enum LightShaftsResolution
		{
			// Token: 0x04002705 RID: 9989
			[Token(Token = "0x4002705")]
			Low,
			// Token: 0x04002706 RID: 9990
			[Token(Token = "0x4002706")]
			Normal,
			// Token: 0x04002707 RID: 9991
			[Token(Token = "0x4002707")]
			High
		}

		// Token: 0x02000A17 RID: 2583
		[Token(Token = "0x2000A17")]
		public enum DebugViewMode
		{
			// Token: 0x04002709 RID: 9993
			[Token(Token = "0x4002709")]
			None,
			// Token: 0x0400270A RID: 9994
			[Token(Token = "0x400270A")]
			ShaftMask,
			// Token: 0x0400270B RID: 9995
			[Token(Token = "0x400270B")]
			OcclusionMask,
			// Token: 0x0400270C RID: 9996
			[Token(Token = "0x400270C")]
			OcclusionDepthRange
		}
	}
}
