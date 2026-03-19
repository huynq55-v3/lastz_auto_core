using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

// Token: 0x02000263 RID: 611
[Token(Token = "0x2000263")]
public class PlaneShadowBlurFeature : ScriptableRendererFeature
{
	// Token: 0x0600103F RID: 4159 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600103F")]
	[Address(RVA = "0x1BEC384", Offset = "0x1BEC384", VA = "0x1BEC384", Slot = "5")]
	public override void Create()
	{
	}

	// Token: 0x06001040 RID: 4160 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001040")]
	[Address(RVA = "0x1BEC51C", Offset = "0x1BEC51C", VA = "0x1BEC51C", Slot = "7")]
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}

	// Token: 0x06001041 RID: 4161 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001041")]
	[Address(RVA = "0x1BEC5A4", Offset = "0x1BEC5A4", VA = "0x1BEC5A4")]
	public PlaneShadowBlurFeature()
	{
	}

	// Token: 0x040012B3 RID: 4787
	[Token(Token = "0x40012B3")]
	[FieldOffset(Offset = "0x20")]
	public PlaneShadowBlurFeature.RenderObjectsSettings settings;

	// Token: 0x040012B4 RID: 4788
	[Token(Token = "0x40012B4")]
	[FieldOffset(Offset = "0x28")]
	private PlaneShadowBlurFeature.PlaneShadowBlurPass renderObjectsPass;

	// Token: 0x02000264 RID: 612
	[Token(Token = "0x2000264")]
	[Serializable]
	public class RenderObjectsSettings
	{
		// Token: 0x06001042 RID: 4162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001042")]
		[Address(RVA = "0x1BEC614", Offset = "0x1BEC614", VA = "0x1BEC614")]
		public RenderObjectsSettings()
		{
		}

		// Token: 0x040012B5 RID: 4789
		[Token(Token = "0x40012B5")]
		[FieldOffset(Offset = "0x10")]
		public string passTag;

		// Token: 0x040012B6 RID: 4790
		[Token(Token = "0x40012B6")]
		[FieldOffset(Offset = "0x18")]
		public CameraType cameraType;

		// Token: 0x040012B7 RID: 4791
		[Token(Token = "0x40012B7")]
		[FieldOffset(Offset = "0x1C")]
		public RenderPassEvent Event;

		// Token: 0x040012B8 RID: 4792
		[Token(Token = "0x40012B8")]
		[FieldOffset(Offset = "0x20")]
		public uint eventOffset;

		// Token: 0x040012B9 RID: 4793
		[Token(Token = "0x40012B9")]
		[FieldOffset(Offset = "0x28")]
		public PlaneShadowBlurFeature.FilterSettings filterSettings;

		// Token: 0x040012BA RID: 4794
		[Token(Token = "0x40012BA")]
		[FieldOffset(Offset = "0x30")]
		public int width;

		// Token: 0x040012BB RID: 4795
		[Token(Token = "0x40012BB")]
		[FieldOffset(Offset = "0x34")]
		public int height;

		// Token: 0x040012BC RID: 4796
		[Token(Token = "0x40012BC")]
		[FieldOffset(Offset = "0x38")]
		public string rtName;

		// Token: 0x040012BD RID: 4797
		[Token(Token = "0x40012BD")]
		[FieldOffset(Offset = "0x40")]
		public string dstName;

		// Token: 0x040012BE RID: 4798
		[Token(Token = "0x40012BE")]
		[FieldOffset(Offset = "0x48")]
		[Range(0f, 8f)]
		public int blurIterations;

		// Token: 0x040012BF RID: 4799
		[Token(Token = "0x40012BF")]
		[FieldOffset(Offset = "0x4C")]
		public float blureSize;

		// Token: 0x040012C0 RID: 4800
		[Token(Token = "0x40012C0")]
		[FieldOffset(Offset = "0x50")]
		public Material mat;
	}

	// Token: 0x02000265 RID: 613
	[Token(Token = "0x2000265")]
	[Serializable]
	public class RenderTargetSettings
	{
		// Token: 0x06001043 RID: 4163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001043")]
		[Address(RVA = "0x1BEC74C", Offset = "0x1BEC74C", VA = "0x1BEC74C")]
		public RenderTargetSettings()
		{
		}

		// Token: 0x040012C1 RID: 4801
		[Token(Token = "0x40012C1")]
		[FieldOffset(Offset = "0x10")]
		public bool overrideTarget;

		// Token: 0x040012C2 RID: 4802
		[Token(Token = "0x40012C2")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x040012C3 RID: 4803
		[Token(Token = "0x40012C3")]
		[FieldOffset(Offset = "0x20")]
		public float scale;

		// Token: 0x040012C4 RID: 4804
		[Token(Token = "0x40012C4")]
		[FieldOffset(Offset = "0x24")]
		public Vector2 size;

		// Token: 0x040012C5 RID: 4805
		[Token(Token = "0x40012C5")]
		[FieldOffset(Offset = "0x2C")]
		public int depth;

		// Token: 0x040012C6 RID: 4806
		[Token(Token = "0x40012C6")]
		[FieldOffset(Offset = "0x30")]
		public RenderTextureFormat format;

		// Token: 0x040012C7 RID: 4807
		[Token(Token = "0x40012C7")]
		[FieldOffset(Offset = "0x34")]
		public ClearFlag clearFlag;

		// Token: 0x040012C8 RID: 4808
		[Token(Token = "0x40012C8")]
		[FieldOffset(Offset = "0x38")]
		public Color clearColor;

		// Token: 0x040012C9 RID: 4809
		[Token(Token = "0x40012C9")]
		[FieldOffset(Offset = "0x48")]
		public FilterMode filterMode;
	}

	// Token: 0x02000266 RID: 614
	[Token(Token = "0x2000266")]
	[Serializable]
	public class FilterSettings
	{
		// Token: 0x06001044 RID: 4164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001044")]
		[Address(RVA = "0x1BEC718", Offset = "0x1BEC718", VA = "0x1BEC718")]
		public FilterSettings()
		{
		}

		// Token: 0x040012CA RID: 4810
		[Token(Token = "0x40012CA")]
		[FieldOffset(Offset = "0x10")]
		public RenderQueueType RenderQueueType;

		// Token: 0x040012CB RID: 4811
		[Token(Token = "0x40012CB")]
		[FieldOffset(Offset = "0x14")]
		public LayerMask LayerMask;

		// Token: 0x040012CC RID: 4812
		[Token(Token = "0x40012CC")]
		[FieldOffset(Offset = "0x18")]
		public string[] PassNames;

		// Token: 0x040012CD RID: 4813
		[Token(Token = "0x40012CD")]
		[FieldOffset(Offset = "0x20")]
		public int RenderingLayerMask;
	}

	// Token: 0x02000267 RID: 615
	[Token(Token = "0x2000267")]
	public class PlaneShadowBlurPass : ScriptableRenderPass
	{
		// Token: 0x06001045 RID: 4165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001045")]
		[Address(RVA = "0x1BEC3F0", Offset = "0x1BEC3F0", VA = "0x1BEC3F0")]
		public PlaneShadowBlurPass(PlaneShadowBlurFeature.RenderObjectsSettings settings)
		{
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001046")]
		[Address(RVA = "0x1BEC764", Offset = "0x1BEC764", VA = "0x1BEC764")]
		public void SetCameraTargets(RenderTargetIdentifier colorTarget)
		{
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001047")]
		[Address(RVA = "0x1BEC77C", Offset = "0x1BEC77C", VA = "0x1BEC77C", Slot = "6")]
		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001048")]
		[Address(RVA = "0x1BEC79C", Offset = "0x1BEC79C", VA = "0x1BEC79C", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001049")]
		[Address(RVA = "0x1BECADC", Offset = "0x1BECADC", VA = "0x1BECADC", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}

		// Token: 0x040012CE RID: 4814
		[Token(Token = "0x40012CE")]
		[FieldOffset(Offset = "0xD8")]
		private PlaneShadowBlurFeature.RenderObjectsSettings settings;

		// Token: 0x040012CF RID: 4815
		[Token(Token = "0x40012CF")]
		[FieldOffset(Offset = "0xE0")]
		private int rtA;

		// Token: 0x040012D0 RID: 4816
		[Token(Token = "0x40012D0")]
		[FieldOffset(Offset = "0xE4")]
		private int rtB;

		// Token: 0x040012D1 RID: 4817
		[Token(Token = "0x40012D1")]
		[FieldOffset(Offset = "0xE8")]
		private int BlurSize;

		// Token: 0x040012D2 RID: 4818
		[Token(Token = "0x40012D2")]
		[FieldOffset(Offset = "0xEC")]
		private int int_PlaneBlurShadowMap;

		// Token: 0x040012D3 RID: 4819
		[Token(Token = "0x40012D3")]
		[FieldOffset(Offset = "0xF0")]
		private Material mat;

		// Token: 0x040012D4 RID: 4820
		[Token(Token = "0x40012D4")]
		[FieldOffset(Offset = "0xF8")]
		private int blurIterations;

		// Token: 0x040012D5 RID: 4821
		[Token(Token = "0x40012D5")]
		[FieldOffset(Offset = "0xFC")]
		private int rtID;

		// Token: 0x040012D6 RID: 4822
		[Token(Token = "0x40012D6")]
		[FieldOffset(Offset = "0x100")]
		private int sourceID;

		// Token: 0x040012D7 RID: 4823
		[Token(Token = "0x40012D7")]
		[FieldOffset(Offset = "0x104")]
		private int dstID;

		// Token: 0x040012D8 RID: 4824
		[Token(Token = "0x40012D8")]
		[FieldOffset(Offset = "0x108")]
		private RenderTargetIdentifier _cameraColorTarget;

		// Token: 0x040012D9 RID: 4825
		[Token(Token = "0x40012D9")]
		[FieldOffset(Offset = "0x130")]
		private RenderTargetIdentifier _cameraDepthTarget;
	}
}
