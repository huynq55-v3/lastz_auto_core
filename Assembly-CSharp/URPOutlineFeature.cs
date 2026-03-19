using System;
using System.Collections.Generic;
using System.Reflection;
using EPOOutline;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

// Token: 0x02000025 RID: 37
[Token(Token = "0x2000025")]
public class URPOutlineFeature : ScriptableRendererFeature
{
	// Token: 0x06000065 RID: 101 RVA: 0x00002130 File Offset: 0x00000330
	[Token(Token = "0x6000065")]
	[Address(RVA = "0x15E4828", Offset = "0x15E4828", VA = "0x15E4828")]
	private bool GetOutlinersToRenderWith(RenderingData renderingData, List<Outliner> outliners)
	{
		return default(bool);
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000066")]
	[Address(RVA = "0x15E4908", Offset = "0x15E4908", VA = "0x15E4908", Slot = "7")]
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000067")]
	[Address(RVA = "0x15E4FC4", Offset = "0x15E4FC4", VA = "0x15E4FC4", Slot = "5")]
	public override void Create()
	{
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000068")]
	[Address(RVA = "0x15E5184", Offset = "0x15E5184", VA = "0x15E5184")]
	public URPOutlineFeature()
	{
	}

	// Token: 0x040000BD RID: 189
	[Token(Token = "0x40000BD")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private URPOutlineFeature.OutLineSettings settings;

	// Token: 0x040000BE RID: 190
	[Token(Token = "0x40000BE")]
	[FieldOffset(Offset = "0x28")]
	private GameObject lastSelectedCamera;

	// Token: 0x040000BF RID: 191
	[Token(Token = "0x40000BF")]
	[FieldOffset(Offset = "0x30")]
	private URPOutlineFeature.Pool outlinePool;

	// Token: 0x040000C0 RID: 192
	[Token(Token = "0x40000C0")]
	[FieldOffset(Offset = "0x38")]
	private List<Outliner> outliners;

	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	[Serializable]
	public class OutLineSettings
	{
		// Token: 0x06000069 RID: 105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x15E5280", Offset = "0x15E5280", VA = "0x15E5280")]
		public OutLineSettings()
		{
		}

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x10")]
		public Material PartialBlitMaterial;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x18")]
		public Material ObstacleMaterial;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x20")]
		public Material OutlineMaterial;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x28")]
		public Material TransparentBlitMaterial;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x30")]
		public Material ZPrepassMaterial;

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x38")]
		public Material OutlineMaskMaterial;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x40")]
		public Material DilateMaterial;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x48")]
		public Material BlurMaterial;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x50")]
		public Material FinalBlitMaterial;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x58")]
		public Material BasicBlitMaterial;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x60")]
		public Material EmptyFillMaterial;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x68")]
		public Material FillMaskMaterial;

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x70")]
		public Material ClearStencilMaterial;
	}

	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	private class SRPOutline : ScriptableRenderPass
	{
		// Token: 0x0600006A RID: 106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x15E5360", Offset = "0x15E5360", VA = "0x15E5360")]
		public SRPOutline()
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x15E54C4", Offset = "0x15E54C4", VA = "0x15E54C4")]
		private bool IsDepthTextureAvailable(ScriptableRenderer renderer)
		{
			return default(bool);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x15E55A0", Offset = "0x15E55A0", VA = "0x15E55A0")]
		private RenderTargetIdentifier GetDepthTarget(ScriptableRenderer renderer)
		{
			return default(RenderTargetIdentifier);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x15E55E4", Offset = "0x15E55E4", VA = "0x15E55E4")]
		private RenderTargetIdentifier GetColorTarget(ScriptableRenderer renderer)
		{
			return default(RenderTargetIdentifier);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x15E5628", Offset = "0x15E5628", VA = "0x15E5628", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x0")]
		private static List<Outlinable> temporaryOutlinables;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0xD8")]
		public ScriptableRenderer Renderer;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0xE0")]
		public bool UseColorTargetForDepth;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0xE8")]
		public Outliner Outliner;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0xF0")]
		public OutlineParameters Parameters;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0xF8")]
		private List<Outliner> outliners;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x100")]
		public URPOutlineFeature.OutLineSettings settings;

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x108")]
		private FieldInfo nameId;
	}

	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	private class Pool
	{
		// Token: 0x06000070 RID: 112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x15E4CD8", Offset = "0x15E4CD8", VA = "0x15E4CD8")]
		public URPOutlineFeature.SRPOutline Get()
		{
			return null;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x15E4E34", Offset = "0x15E4E34", VA = "0x15E4E34")]
		public void ReleaseAll()
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x15E5288", Offset = "0x15E5288", VA = "0x15E5288")]
		public Pool()
		{
		}

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x10")]
		private Stack<URPOutlineFeature.SRPOutline> outlines;

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x18")]
		private List<URPOutlineFeature.SRPOutline> createdOutlines;
	}
}
