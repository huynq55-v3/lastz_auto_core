using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace GameOldBoy.Rendering
{
	// Token: 0x02000A30 RID: 2608
	[Token(Token = "0x2000A30")]
	public class TAA : ScriptableRendererFeature
	{
		// Token: 0x06006320 RID: 25376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006320")]
		[Address(RVA = "0x303D6A0", Offset = "0x303D6A0", VA = "0x303D6A0", Slot = "5")]
		public override void Create()
		{
		}

		// Token: 0x06006321 RID: 25377 RVA: 0x0004BC78 File Offset: 0x00049E78
		[Token(Token = "0x6006321")]
		[Address(RVA = "0x303DA3C", Offset = "0x303DA3C", VA = "0x303DA3C")]
		private bool getMaterial()
		{
			return default(bool);
		}

		// Token: 0x06006322 RID: 25378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006322")]
		[Address(RVA = "0x303DB28", Offset = "0x303DB28", VA = "0x303DB28", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		// Token: 0x06006323 RID: 25379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006323")]
		[Address(RVA = "0x303E7EC", Offset = "0x303E7EC", VA = "0x303E7EC")]
		public TAA()
		{
		}

		// Token: 0x040027A7 RID: 10151
		[Token(Token = "0x40027A7")]
		[FieldOffset(Offset = "0x19")]
		public bool PreviewInSceneView;

		// Token: 0x040027A8 RID: 10152
		[Token(Token = "0x40027A8")]
		[FieldOffset(Offset = "0x1A")]
		public bool UseMotionVector;

		// Token: 0x040027A9 RID: 10153
		[Token(Token = "0x40027A9")]
		[FieldOffset(Offset = "0x1C")]
		public RenderingMode RenderingMode;

		// Token: 0x040027AA RID: 10154
		[Token(Token = "0x40027AA")]
		[FieldOffset(Offset = "0x20")]
		public bool WorkOnPrepass;

		// Token: 0x040027AB RID: 10155
		[Token(Token = "0x40027AB")]
		[FieldOffset(Offset = "0x21")]
		public bool IgonreTransparentObject;

		// Token: 0x040027AC RID: 10156
		[Token(Token = "0x40027AC")]
		[FieldOffset(Offset = "0x22")]
		public bool Use32Bit;

		// Token: 0x040027AD RID: 10157
		[Token(Token = "0x40027AD")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Shader Shader;

		// Token: 0x040027AE RID: 10158
		[Token(Token = "0x40027AE")]
		[FieldOffset(Offset = "0x30")]
		private Material material;

		// Token: 0x040027AF RID: 10159
		[Token(Token = "0x40027AF")]
		[FieldOffset(Offset = "0x38")]
		private TAA.TAACameraPass m_TAACameraPrepass;

		// Token: 0x040027B0 RID: 10160
		[Token(Token = "0x40027B0")]
		[FieldOffset(Offset = "0x40")]
		private TAA.TAACameraPass m_TAACameraPass;

		// Token: 0x040027B1 RID: 10161
		[Token(Token = "0x40027B1")]
		[FieldOffset(Offset = "0x48")]
		private TAA.TAAPass m_TAAPass;

		// Token: 0x040027B2 RID: 10162
		[Token(Token = "0x40027B2")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<int, TAA.HaltonSequence> haltonSequences;

		// Token: 0x02000A31 RID: 2609
		[Token(Token = "0x2000A31")]
		private class TAACameraPass : ScriptableRenderPass
		{
			// Token: 0x06006324 RID: 25380 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006324")]
			[Address(RVA = "0x303D820", Offset = "0x303D820", VA = "0x303D820")]
			public TAACameraPass(string profilerTag)
			{
			}

			// Token: 0x06006325 RID: 25381 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006325")]
			[Address(RVA = "0x303E87C", Offset = "0x303E87C", VA = "0x303E87C")]
			public void Setup(Matrix4x4 matrix)
			{
			}

			// Token: 0x06006326 RID: 25382 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006326")]
			[Address(RVA = "0x303E890", Offset = "0x303E890", VA = "0x303E890", Slot = "9")]
			public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
			{
			}

			// Token: 0x040027B3 RID: 10163
			[Token(Token = "0x40027B3")]
			[FieldOffset(Offset = "0xD8")]
			private ProfilingSampler m_ProfilingSampler;

			// Token: 0x040027B4 RID: 10164
			[Token(Token = "0x40027B4")]
			[FieldOffset(Offset = "0xE0")]
			private Matrix4x4 matrix;
		}

		// Token: 0x02000A32 RID: 2610
		[Token(Token = "0x2000A32")]
		private class TAAPass : ScriptableRenderPass
		{
			// Token: 0x06006327 RID: 25383 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006327")]
			[Address(RVA = "0x303D8A4", Offset = "0x303D8A4", VA = "0x303D8A4")]
			public TAAPass(string profilerTag)
			{
			}

			// Token: 0x06006328 RID: 25384 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006328")]
			[Address(RVA = "0x303E62C", Offset = "0x303E62C", VA = "0x303E62C")]
			public void Setup(ScriptableRenderer renderer, bool use32Bit, Material material, Matrix4x4 prevViewProj, Vector2 offset, TAAComponent taa, bool useMotionVector, RenderingMode renderingMode)
			{
			}

			// Token: 0x06006329 RID: 25385 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006329")]
			[Address(RVA = "0x303EA64", Offset = "0x303EA64", VA = "0x303EA64")]
			private void allocRT(out RenderTexture rt_a, out RenderTexture rt_b, RenderTextureDescriptor descriptor)
			{
			}

			// Token: 0x0600632A RID: 25386 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600632A")]
			[Address(RVA = "0x303EBA8", Offset = "0x303EBA8", VA = "0x303EBA8")]
			private void allocRT(out RenderTexture rt_a, out RenderTexture rt_b, CommandBuffer cmd, ScriptableRenderContext context, RenderTargetIdentifier rtid, RenderTextureDescriptor descriptor)
			{
			}

			// Token: 0x0600632B RID: 25387 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600632B")]
			[Address(RVA = "0x303EE0C", Offset = "0x303EE0C", VA = "0x303EE0C")]
			private void genRT(CommandBuffer cmd, ScriptableRenderContext context, RenderTargetIdentifier rtid, RenderTextureDescriptor descriptor, int hash)
			{
			}

			// Token: 0x0600632C RID: 25388 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600632C")]
			[Address(RVA = "0x303F3CC", Offset = "0x303F3CC", VA = "0x303F3CC", Slot = "9")]
			public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
			{
			}

			// Token: 0x0600632D RID: 25389 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600632D")]
			[Address(RVA = "0x303E72C", Offset = "0x303E72C", VA = "0x303E72C")]
			public void CleanUp(int hash)
			{
			}

			// Token: 0x040027B5 RID: 10165
			[Token(Token = "0x40027B5")]
			[FieldOffset(Offset = "0xD8")]
			private ProfilingSampler m_ProfilingSampler;

			// Token: 0x040027B6 RID: 10166
			[Token(Token = "0x40027B6")]
			[FieldOffset(Offset = "0xE0")]
			private ScriptableRenderer renderer;

			// Token: 0x040027B7 RID: 10167
			[Token(Token = "0x40027B7")]
			[FieldOffset(Offset = "0xE8")]
			private bool use32Bit;

			// Token: 0x040027B8 RID: 10168
			[Token(Token = "0x40027B8")]
			[FieldOffset(Offset = "0xF0")]
			private Material material;

			// Token: 0x040027B9 RID: 10169
			[Token(Token = "0x40027B9")]
			[FieldOffset(Offset = "0xF8")]
			private Matrix4x4 prevViewProj;

			// Token: 0x040027BA RID: 10170
			[Token(Token = "0x40027BA")]
			[FieldOffset(Offset = "0x138")]
			private Vector2 offset;

			// Token: 0x040027BB RID: 10171
			[Token(Token = "0x40027BB")]
			[FieldOffset(Offset = "0x140")]
			private float blend;

			// Token: 0x040027BC RID: 10172
			[Token(Token = "0x40027BC")]
			[FieldOffset(Offset = "0x144")]
			private bool antiGhosting;

			// Token: 0x040027BD RID: 10173
			[Token(Token = "0x40027BD")]
			[FieldOffset(Offset = "0x145")]
			private bool useSharpenFilter;

			// Token: 0x040027BE RID: 10174
			[Token(Token = "0x40027BE")]
			[FieldOffset(Offset = "0x146")]
			private bool useBicubicFilter;

			// Token: 0x040027BF RID: 10175
			[Token(Token = "0x40027BF")]
			[FieldOffset(Offset = "0x147")]
			private bool useClipAABB;

			// Token: 0x040027C0 RID: 10176
			[Token(Token = "0x40027C0")]
			[FieldOffset(Offset = "0x148")]
			private bool useDilation;

			// Token: 0x040027C1 RID: 10177
			[Token(Token = "0x40027C1")]
			[FieldOffset(Offset = "0x149")]
			private bool useTonemap;

			// Token: 0x040027C2 RID: 10178
			[Token(Token = "0x40027C2")]
			[FieldOffset(Offset = "0x14A")]
			private bool useVarianceClipping;

			// Token: 0x040027C3 RID: 10179
			[Token(Token = "0x40027C3")]
			[FieldOffset(Offset = "0x14B")]
			private bool useYCoCgSpace;

			// Token: 0x040027C4 RID: 10180
			[Token(Token = "0x40027C4")]
			[FieldOffset(Offset = "0x14C")]
			private float gamma;

			// Token: 0x040027C5 RID: 10181
			[Token(Token = "0x40027C5")]
			[FieldOffset(Offset = "0x150")]
			private float sharp;

			// Token: 0x040027C6 RID: 10182
			[Token(Token = "0x40027C6")]
			[FieldOffset(Offset = "0x154")]
			private float prevSharp;

			// Token: 0x040027C7 RID: 10183
			[Token(Token = "0x40027C7")]
			[FieldOffset(Offset = "0x158")]
			private bool useMotionVector;

			// Token: 0x040027C8 RID: 10184
			[Token(Token = "0x40027C8")]
			[FieldOffset(Offset = "0x159")]
			private bool use4Tap;

			// Token: 0x040027C9 RID: 10185
			[Token(Token = "0x40027C9")]
			[FieldOffset(Offset = "0x160")]
			private Dictionary<int, TAA.TAAPass.TAATextureSwap> taaTextures;

			// Token: 0x040027CA RID: 10186
			[Token(Token = "0x40027CA")]
			[FieldOffset(Offset = "0x168")]
			private int taaPrevViewProj;

			// Token: 0x040027CB RID: 10187
			[Token(Token = "0x40027CB")]
			[FieldOffset(Offset = "0x16C")]
			private int taaOffset;

			// Token: 0x040027CC RID: 10188
			[Token(Token = "0x40027CC")]
			[FieldOffset(Offset = "0x170")]
			private int taaParams0;

			// Token: 0x040027CD RID: 10189
			[Token(Token = "0x40027CD")]
			[FieldOffset(Offset = "0x174")]
			private int taaSourceTex;

			// Token: 0x040027CE RID: 10190
			[Token(Token = "0x40027CE")]
			[FieldOffset(Offset = "0x178")]
			private int taaTexture;

			// Token: 0x02000A33 RID: 2611
			[Token(Token = "0x2000A33")]
			private class TAATextureSwap
			{
				// Token: 0x17000672 RID: 1650
				// (get) Token: 0x0600632E RID: 25390 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000672")]
				public RenderTexture TAATextureA
				{
					[Token(Token = "0x600632E")]
					[Address(RVA = "0x303FE88", Offset = "0x303FE88", VA = "0x303FE88")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				// Token: 0x17000673 RID: 1651
				// (get) Token: 0x0600632F RID: 25391 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000673")]
				public RenderTexture TAATextureB
				{
					[Token(Token = "0x600632F")]
					[Address(RVA = "0x303FE90", Offset = "0x303FE90", VA = "0x303FE90")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				// Token: 0x17000674 RID: 1652
				// (get) Token: 0x06006330 RID: 25392 RVA: 0x0004BC90 File Offset: 0x00049E90
				[Token(Token = "0x17000674")]
				public RenderTextureDescriptor Descriptor
				{
					[Token(Token = "0x6006330")]
					[Address(RVA = "0x303FE98", Offset = "0x303FE98", VA = "0x303FE98")]
					[CompilerGenerated]
					get
					{
						return default(RenderTextureDescriptor);
					}
				}

				// Token: 0x06006331 RID: 25393 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006331")]
				[Address(RVA = "0x303F298", Offset = "0x303F298", VA = "0x303F298")]
				public TAATextureSwap(RenderTexture taaTextureA, RenderTexture taaTextureB, RenderTextureDescriptor descriptor)
				{
				}

				// Token: 0x06006332 RID: 25394 RVA: 0x0004BCA8 File Offset: 0x00049EA8
				[Token(Token = "0x6006332")]
				[Address(RVA = "0x303FE6C", Offset = "0x303FE6C", VA = "0x303FE6C")]
				public bool Swap()
				{
					return default(bool);
				}

				// Token: 0x06006333 RID: 25395 RVA: 0x0004BCC0 File Offset: 0x00049EC0
				[Token(Token = "0x6006333")]
				[Address(RVA = "0x303F200", Offset = "0x303F200", VA = "0x303F200")]
				public bool CheckTextureNull()
				{
					return default(bool);
				}

				// Token: 0x06006334 RID: 25396 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006334")]
				[Address(RVA = "0x303F310", Offset = "0x303F310", VA = "0x303F310")]
				public void Release()
				{
				}

				// Token: 0x040027D2 RID: 10194
				[Token(Token = "0x40027D2")]
				[FieldOffset(Offset = "0x54")]
				private bool swap;
			}
		}

		// Token: 0x02000A34 RID: 2612
		[Token(Token = "0x2000A34")]
		private struct HaltonSequence
		{
			// Token: 0x06006335 RID: 25397 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006335")]
			[Address(RVA = "0x303E3F8", Offset = "0x303E3F8", VA = "0x303E3F8")]
			public HaltonSequence(int count)
			{
			}

			// Token: 0x06006336 RID: 25398 RVA: 0x0004BCD8 File Offset: 0x00049ED8
			[Token(Token = "0x6006336")]
			[Address(RVA = "0x303FEB4", Offset = "0x303FEB4", VA = "0x303FEB4")]
			private float get(int index, int @base)
			{
				return 0f;
			}

			// Token: 0x06006337 RID: 25399 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006337")]
			[Address(RVA = "0x303E5BC", Offset = "0x303E5BC", VA = "0x303E5BC")]
			public void Get(out float x, out float y)
			{
			}

			// Token: 0x040027D3 RID: 10195
			[Token(Token = "0x40027D3")]
			[FieldOffset(Offset = "0x0")]
			private int count;

			// Token: 0x040027D4 RID: 10196
			[Token(Token = "0x40027D4")]
			[FieldOffset(Offset = "0x4")]
			private int index;

			// Token: 0x040027D5 RID: 10197
			[Token(Token = "0x40027D5")]
			[FieldOffset(Offset = "0x8")]
			private float[] arrX;

			// Token: 0x040027D6 RID: 10198
			[Token(Token = "0x40027D6")]
			[FieldOffset(Offset = "0x10")]
			private float[] arrY;

			// Token: 0x040027D7 RID: 10199
			[Token(Token = "0x40027D7")]
			[FieldOffset(Offset = "0x18")]
			public Matrix4x4 prevViewProj;

			// Token: 0x040027D8 RID: 10200
			[Token(Token = "0x40027D8")]
			[FieldOffset(Offset = "0x58")]
			public int frameCount;
		}
	}
}
