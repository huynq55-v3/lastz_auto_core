using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000CC3 RID: 3267
	[Token(Token = "0x2000CC3")]
	internal class DOFUrpPass : ScriptableRenderPass
	{
		// Token: 0x06007B64 RID: 31588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B64")]
		[Address(RVA = "0x3226A84", Offset = "0x3226A84", VA = "0x3226A84")]
		public DOFUrpPass(RenderPassEvent renderPassEvent, Material material, DOFUrp.DepthMethod depthCalculationMetod, float blurAmount, float focus, float aperture, string tag)
		{
		}

		// Token: 0x06007B65 RID: 31589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B65")]
		[Address(RVA = "0x3226D68", Offset = "0x3226D68", VA = "0x3226D68")]
		public void Setup(RenderTargetIdentifier source)
		{
		}

		// Token: 0x06007B66 RID: 31590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B66")]
		[Address(RVA = "0x3226D84", Offset = "0x3226D84", VA = "0x3226D84", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		// Token: 0x06007B67 RID: 31591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B67")]
		[Address(RVA = "0x32278C4", Offset = "0x32278C4", VA = "0x32278C4", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}

		// Token: 0x0400367C RID: 13948
		[Token(Token = "0x400367C")]
		[FieldOffset(Offset = "0xD8")]
		private readonly Material material;

		// Token: 0x0400367D RID: 13949
		[Token(Token = "0x400367D")]
		[FieldOffset(Offset = "0xE0")]
		private readonly string tag;

		// Token: 0x0400367E RID: 13950
		[Token(Token = "0x400367E")]
		[FieldOffset(Offset = "0xE8")]
		private readonly DOFUrp.DepthMethod depthCalculationMetod;

		// Token: 0x0400367F RID: 13951
		[Token(Token = "0x400367F")]
		[FieldOffset(Offset = "0xEC")]
		private readonly float blurAmount;

		// Token: 0x04003680 RID: 13952
		[Token(Token = "0x4003680")]
		[FieldOffset(Offset = "0xF0")]
		private readonly float focus;

		// Token: 0x04003681 RID: 13953
		[Token(Token = "0x4003681")]
		[FieldOffset(Offset = "0xF4")]
		private readonly float aperture;

		// Token: 0x04003682 RID: 13954
		[Token(Token = "0x4003682")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int blurAmountString;

		// Token: 0x04003683 RID: 13955
		[Token(Token = "0x4003683")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int focusAmountString;

		// Token: 0x04003684 RID: 13956
		[Token(Token = "0x4003684")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int apertureAmountString;

		// Token: 0x04003685 RID: 13957
		[Token(Token = "0x4003685")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int blurTexString;

		// Token: 0x04003686 RID: 13958
		[Token(Token = "0x4003686")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int blurTempString;

		// Token: 0x04003687 RID: 13959
		[Token(Token = "0x4003687")]
		[FieldOffset(Offset = "0x14")]
		private static readonly int blurTemp1String;

		// Token: 0x04003688 RID: 13960
		[Token(Token = "0x4003688")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int tempCopyString;

		// Token: 0x04003689 RID: 13961
		[Token(Token = "0x4003689")]
		[FieldOffset(Offset = "0x20")]
		private static readonly string isDepthKeyword;

		// Token: 0x0400368A RID: 13962
		[Token(Token = "0x400368A")]
		[FieldOffset(Offset = "0xF8")]
		private RenderTargetIdentifier source;

		// Token: 0x0400368B RID: 13963
		[Token(Token = "0x400368B")]
		[FieldOffset(Offset = "0x120")]
		private RenderTargetIdentifier blurTemp;

		// Token: 0x0400368C RID: 13964
		[Token(Token = "0x400368C")]
		[FieldOffset(Offset = "0x148")]
		private RenderTargetIdentifier blurTemp1;

		// Token: 0x0400368D RID: 13965
		[Token(Token = "0x400368D")]
		[FieldOffset(Offset = "0x170")]
		private RenderTargetIdentifier blurTex;

		// Token: 0x0400368E RID: 13966
		[Token(Token = "0x400368E")]
		[FieldOffset(Offset = "0x198")]
		private RenderTargetIdentifier tempCopy;

		// Token: 0x0400368F RID: 13967
		[Token(Token = "0x400368F")]
		[FieldOffset(Offset = "0x1C0")]
		private RenderTextureDescriptor opaqueDesc;

		// Token: 0x04003690 RID: 13968
		[Token(Token = "0x4003690")]
		[FieldOffset(Offset = "0x1F4")]
		private RenderTextureDescriptor half;

		// Token: 0x04003691 RID: 13969
		[Token(Token = "0x4003691")]
		[FieldOffset(Offset = "0x228")]
		private RenderTextureDescriptor quarter;

		// Token: 0x04003692 RID: 13970
		[Token(Token = "0x4003692")]
		[FieldOffset(Offset = "0x25C")]
		private RenderTextureDescriptor eighths;

		// Token: 0x04003693 RID: 13971
		[Token(Token = "0x4003693")]
		[FieldOffset(Offset = "0x290")]
		private RenderTextureDescriptor sixths;

		// Token: 0x04003694 RID: 13972
		[Token(Token = "0x4003694")]
		[FieldOffset(Offset = "0x2C4")]
		private int numberOfPasses;
	}
}
