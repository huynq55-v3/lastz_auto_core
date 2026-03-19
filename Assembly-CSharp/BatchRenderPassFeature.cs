using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

// Token: 0x0200027F RID: 639
[Token(Token = "0x200027F")]
public class BatchRenderPassFeature : ScriptableRendererFeature
{
	// Token: 0x06001102 RID: 4354 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001102")]
	[Address(RVA = "0x1BF356C", Offset = "0x1BF356C", VA = "0x1BF356C", Slot = "7")]
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}

	// Token: 0x06001103 RID: 4355 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001103")]
	[Address(RVA = "0x1BF368C", Offset = "0x1BF368C", VA = "0x1BF368C", Slot = "5")]
	public override void Create()
	{
	}

	// Token: 0x06001104 RID: 4356 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001104")]
	[Address(RVA = "0x1BF371C", Offset = "0x1BF371C", VA = "0x1BF371C", Slot = "9")]
	protected override void Dispose(bool disposing)
	{
	}

	// Token: 0x06001105 RID: 4357 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001105")]
	[Address(RVA = "0x1BF3728", Offset = "0x1BF3728", VA = "0x1BF3728")]
	public BatchRenderPassFeature()
	{
	}

	// Token: 0x040013AC RID: 5036
	[Token(Token = "0x40013AC")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private BatchRenderPassFeature.BlurSettings settings;

	// Token: 0x040013AD RID: 5037
	[Token(Token = "0x40013AD")]
	[FieldOffset(Offset = "0x28")]
	private BatchRenderPassFeature.CustomRenderPass scriptablePass;

	// Token: 0x040013AE RID: 5038
	[Token(Token = "0x40013AE")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<int, BatchRenderPassFeature.CustomRenderPass> BlurFeatureDic;

	// Token: 0x02000280 RID: 640
	[Token(Token = "0x2000280")]
	[Serializable]
	public class BlurSettings
	{
		// Token: 0x06001107 RID: 4359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001107")]
		[Address(RVA = "0x1BF37A4", Offset = "0x1BF37A4", VA = "0x1BF37A4")]
		public BlurSettings()
		{
		}

		// Token: 0x040013AF RID: 5039
		[Token(Token = "0x40013AF")]
		[FieldOffset(Offset = "0x10")]
		public RenderPassEvent renderPassEvent;
	}

	// Token: 0x02000281 RID: 641
	[Token(Token = "0x2000281")]
	private class CustomRenderPass : ScriptableRenderPass
	{
		// Token: 0x06001108 RID: 4360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001108")]
		[Address(RVA = "0x1BF36FC", Offset = "0x1BF36FC", VA = "0x1BF36FC")]
		public CustomRenderPass()
		{
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001109")]
		[Address(RVA = "0x1BF3688", Offset = "0x1BF3688", VA = "0x1BF3688")]
		public void Setup(RenderTargetIdentifier source)
		{
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600110A")]
		[Address(RVA = "0x1BF384C", Offset = "0x1BF384C", VA = "0x1BF384C", Slot = "5")]
		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600110B")]
		[Address(RVA = "0x1BF3850", Offset = "0x1BF3850", VA = "0x1BF3850", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600110C")]
		[Address(RVA = "0x1BF3854", Offset = "0x1BF3854", VA = "0x1BF3854", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600110D")]
		[Address(RVA = "0x1BF4534", Offset = "0x1BF4534", VA = "0x1BF4534", Slot = "7")]
		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}

		// Token: 0x040013B0 RID: 5040
		[Token(Token = "0x40013B0")]
		[FieldOffset(Offset = "0xD8")]
		public int id_1;

		// Token: 0x040013B1 RID: 5041
		[Token(Token = "0x40013B1")]
		[FieldOffset(Offset = "0xDC")]
		public int id_2;

		// Token: 0x040013B2 RID: 5042
		[Token(Token = "0x40013B2")]
		[FieldOffset(Offset = "0xE0")]
		public int id_0;

		// Token: 0x040013B3 RID: 5043
		[Token(Token = "0x40013B3")]
		[FieldOffset(Offset = "0xE4")]
		private int width;

		// Token: 0x040013B4 RID: 5044
		[Token(Token = "0x40013B4")]
		[FieldOffset(Offset = "0xE8")]
		private int height;

		// Token: 0x040013B5 RID: 5045
		[Token(Token = "0x40013B5")]
		[FieldOffset(Offset = "0x0")]
		private static string profilerTag;
	}
}
