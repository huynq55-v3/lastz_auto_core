using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace EPOOutline
{
	// Token: 0x02000C95 RID: 3221
	[Token(Token = "0x2000C95")]
	public static class OutlineEffect
	{
		// Token: 0x06007A32 RID: 31282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007A32")]
		[Address(RVA = "0x1497944", Offset = "0x1497944", VA = "0x1497944")]
		public static Material LoadMaterial(string shaderName)
		{
			return null;
		}

		// Token: 0x06007A33 RID: 31283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A33")]
		[Address(RVA = "0x1497A14", Offset = "0x1497A14", VA = "0x1497A14")]
		private static void InitMaterials()
		{
		}

		// Token: 0x06007A34 RID: 31284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A34")]
		[Address(RVA = "0x1498154", Offset = "0x1498154", VA = "0x1498154")]
		private static void Postprocess(OutlineParameters parameters, int first, int second, Material material, int iterations, bool additionalShift, float shiftValue, ref int stencil, Rect viewport, float scale)
		{
		}

		// Token: 0x06007A35 RID: 31285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A35")]
		[Address(RVA = "0x1498600", Offset = "0x1498600", VA = "0x1498600")]
		private static void Blit(OutlineParameters parameters, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier destinationDepth, Material material, float effectSize, CommandBuffer buffer, int pass = -1, [Optional] Rect? viewport)
		{
		}

		// Token: 0x06007A36 RID: 31286 RVA: 0x000539D0 File Offset: 0x00051BD0
		[Token(Token = "0x6007A36")]
		[Address(RVA = "0x1498794", Offset = "0x1498794", VA = "0x1498794")]
		private static float GetBlurShift(BlurType blurType, int iterrationsCount)
		{
			return 0f;
		}

		// Token: 0x06007A37 RID: 31287 RVA: 0x000539E8 File Offset: 0x00051BE8
		[Token(Token = "0x6007A37")]
		[Address(RVA = "0x1498850", Offset = "0x1498850", VA = "0x1498850")]
		private static float GetMaskingValueForMode(OutlinableDrawingMode mode)
		{
			return 0f;
		}

		// Token: 0x06007A38 RID: 31288 RVA: 0x00053A00 File Offset: 0x00051C00
		[Token(Token = "0x6007A38")]
		[Address(RVA = "0x1498874", Offset = "0x1498874", VA = "0x1498874")]
		private static float ComputeEffectShift(OutlineParameters parameters)
		{
			return 0f;
		}

		// Token: 0x06007A39 RID: 31289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A39")]
		[Address(RVA = "0x1498904", Offset = "0x1498904", VA = "0x1498904")]
		private static void PrepareTargets(OutlineParameters parameters)
		{
		}

		// Token: 0x06007A3A RID: 31290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A3A")]
		[Address(RVA = "0x1498EC0", Offset = "0x1498EC0", VA = "0x1498EC0")]
		public static void SetupOutline(OutlineParameters parameters)
		{
		}

		// Token: 0x06007A3B RID: 31291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A3B")]
		[Address(RVA = "0x149B9E4", Offset = "0x149B9E4", VA = "0x149B9E4")]
		private static void SetupDilateKeyword(OutlineParameters parameters)
		{
		}

		// Token: 0x06007A3C RID: 31292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A3C")]
		[Address(RVA = "0x149C068", Offset = "0x149C068", VA = "0x149C068")]
		private static void SetupBlurKeyword(OutlineParameters parameters)
		{
		}

		// Token: 0x06007A3D RID: 31293 RVA: 0x00053A18 File Offset: 0x00051C18
		[Token(Token = "0x6007A3D")]
		[Address(RVA = "0x149BBF8", Offset = "0x149BBF8", VA = "0x149BBF8")]
		private static int DrawOutlineables(OutlineParameters parameters, CompareFunction function, Func<Outlinable, bool> shouldRender, Func<Outlinable, Color> colorProvider, Func<Outlinable, Material> materialProvider, RenderStyle styleMask, OutlinableDrawingMode modeMask = OutlinableDrawingMode.Normal)
		{
			return 0;
		}

		// Token: 0x06007A3E RID: 31294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A3E")]
		[Address(RVA = "0x149C27C", Offset = "0x149C27C", VA = "0x149C27C")]
		private static void DrawFill(OutlineParameters parameters, RenderTargetIdentifier targetSurface)
		{
		}

		// Token: 0x06007A3F RID: 31295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A3F")]
		[Address(RVA = "0x149DED8", Offset = "0x149DED8", VA = "0x149DED8")]
		private static void SetupCutout(OutlineParameters parameters, OutlineTarget target)
		{
		}

		// Token: 0x06007A40 RID: 31296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A40")]
		[Address(RVA = "0x149E4CC", Offset = "0x149E4CC", VA = "0x149E4CC")]
		private static void SetupCull(OutlineParameters parameters, OutlineTarget target)
		{
		}

		// Token: 0x04003553 RID: 13651
		[Token(Token = "0x4003553")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int FillRefHash;

		// Token: 0x04003554 RID: 13652
		[Token(Token = "0x4003554")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int DilateShiftHash;

		// Token: 0x04003555 RID: 13653
		[Token(Token = "0x4003555")]
		[FieldOffset(Offset = "0x8")]
		public static readonly int ColorMaskHash;

		// Token: 0x04003556 RID: 13654
		[Token(Token = "0x4003556")]
		[FieldOffset(Offset = "0xC")]
		public static readonly int OutlineRefHash;

		// Token: 0x04003557 RID: 13655
		[Token(Token = "0x4003557")]
		[FieldOffset(Offset = "0x10")]
		public static readonly int RefHash;

		// Token: 0x04003558 RID: 13656
		[Token(Token = "0x4003558")]
		[FieldOffset(Offset = "0x14")]
		public static readonly int ZWriteHash;

		// Token: 0x04003559 RID: 13657
		[Token(Token = "0x4003559")]
		[FieldOffset(Offset = "0x18")]
		public static readonly int EffectSizeHash;

		// Token: 0x0400355A RID: 13658
		[Token(Token = "0x400355A")]
		[FieldOffset(Offset = "0x1C")]
		public static readonly int CullHash;

		// Token: 0x0400355B RID: 13659
		[Token(Token = "0x400355B")]
		[FieldOffset(Offset = "0x20")]
		public static readonly int ZTestHash;

		// Token: 0x0400355C RID: 13660
		[Token(Token = "0x400355C")]
		[FieldOffset(Offset = "0x24")]
		public static readonly int ColorHash;

		// Token: 0x0400355D RID: 13661
		[Token(Token = "0x400355D")]
		[FieldOffset(Offset = "0x28")]
		public static readonly int ScaleHash;

		// Token: 0x0400355E RID: 13662
		[Token(Token = "0x400355E")]
		[FieldOffset(Offset = "0x2C")]
		public static readonly int ShiftHash;

		// Token: 0x0400355F RID: 13663
		[Token(Token = "0x400355F")]
		[FieldOffset(Offset = "0x30")]
		public static readonly int InitialTexHash;

		// Token: 0x04003560 RID: 13664
		[Token(Token = "0x4003560")]
		[FieldOffset(Offset = "0x34")]
		public static readonly int InfoBufferHash;

		// Token: 0x04003561 RID: 13665
		[Token(Token = "0x4003561")]
		[FieldOffset(Offset = "0x38")]
		public static readonly int ComparisonHash;

		// Token: 0x04003562 RID: 13666
		[Token(Token = "0x4003562")]
		[FieldOffset(Offset = "0x3C")]
		public static readonly int ReadMaskHash;

		// Token: 0x04003563 RID: 13667
		[Token(Token = "0x4003563")]
		[FieldOffset(Offset = "0x40")]
		public static readonly int WriteMaskHash;

		// Token: 0x04003564 RID: 13668
		[Token(Token = "0x4003564")]
		[FieldOffset(Offset = "0x44")]
		public static readonly int OperationHash;

		// Token: 0x04003565 RID: 13669
		[Token(Token = "0x4003565")]
		[FieldOffset(Offset = "0x48")]
		public static readonly int CutoutThresholdHash;

		// Token: 0x04003566 RID: 13670
		[Token(Token = "0x4003566")]
		[FieldOffset(Offset = "0x4C")]
		public static readonly int CutoutMaskHash;

		// Token: 0x04003567 RID: 13671
		[Token(Token = "0x4003567")]
		[FieldOffset(Offset = "0x50")]
		public static readonly int TextureIndexHash;

		// Token: 0x04003568 RID: 13672
		[Token(Token = "0x4003568")]
		[FieldOffset(Offset = "0x54")]
		public static readonly int CutoutTextureHash;

		// Token: 0x04003569 RID: 13673
		[Token(Token = "0x4003569")]
		[FieldOffset(Offset = "0x58")]
		public static readonly int CutoutTextureSTHash;

		// Token: 0x0400356A RID: 13674
		[Token(Token = "0x400356A")]
		[FieldOffset(Offset = "0x5C")]
		public static readonly int SrcBlendHash;

		// Token: 0x0400356B RID: 13675
		[Token(Token = "0x400356B")]
		[FieldOffset(Offset = "0x60")]
		public static readonly int DstBlendHash;

		// Token: 0x0400356C RID: 13676
		[Token(Token = "0x400356C")]
		[FieldOffset(Offset = "0x64")]
		public static readonly int TargetHash;

		// Token: 0x0400356D RID: 13677
		[Token(Token = "0x400356D")]
		[FieldOffset(Offset = "0x68")]
		public static readonly int InfoTargetHash;

		// Token: 0x0400356E RID: 13678
		[Token(Token = "0x400356E")]
		[FieldOffset(Offset = "0x6C")]
		public static readonly int PrimaryBufferHash;

		// Token: 0x0400356F RID: 13679
		[Token(Token = "0x400356F")]
		[FieldOffset(Offset = "0x70")]
		public static readonly int HelperBufferHash;

		// Token: 0x04003570 RID: 13680
		[Token(Token = "0x4003570")]
		[FieldOffset(Offset = "0x74")]
		public static readonly int PrimaryInfoBufferHash;

		// Token: 0x04003571 RID: 13681
		[Token(Token = "0x4003571")]
		[FieldOffset(Offset = "0x78")]
		public static readonly int HelperInfoBufferHash;

		// Token: 0x04003572 RID: 13682
		[Token(Token = "0x4003572")]
		[FieldOffset(Offset = "0x80")]
		public static Material TransparentBlitMaterial;

		// Token: 0x04003573 RID: 13683
		[Token(Token = "0x4003573")]
		[FieldOffset(Offset = "0x88")]
		public static Material EmptyFillMaterial;

		// Token: 0x04003574 RID: 13684
		[Token(Token = "0x4003574")]
		[FieldOffset(Offset = "0x90")]
		public static Material OutlineMaterial;

		// Token: 0x04003575 RID: 13685
		[Token(Token = "0x4003575")]
		[FieldOffset(Offset = "0x98")]
		public static Material PartialBlitMaterial;

		// Token: 0x04003576 RID: 13686
		[Token(Token = "0x4003576")]
		[FieldOffset(Offset = "0xA0")]
		public static Material ObstacleMaterial;

		// Token: 0x04003577 RID: 13687
		[Token(Token = "0x4003577")]
		[FieldOffset(Offset = "0xA8")]
		public static Material FillMaskMaterial;

		// Token: 0x04003578 RID: 13688
		[Token(Token = "0x4003578")]
		[FieldOffset(Offset = "0xB0")]
		public static Material ZPrepassMaterial;

		// Token: 0x04003579 RID: 13689
		[Token(Token = "0x4003579")]
		[FieldOffset(Offset = "0xB8")]
		public static Material OutlineMaskMaterial;

		// Token: 0x0400357A RID: 13690
		[Token(Token = "0x400357A")]
		[FieldOffset(Offset = "0xC0")]
		public static Material DilateMaterial;

		// Token: 0x0400357B RID: 13691
		[Token(Token = "0x400357B")]
		[FieldOffset(Offset = "0xC8")]
		public static Material BlurMaterial;

		// Token: 0x0400357C RID: 13692
		[Token(Token = "0x400357C")]
		[FieldOffset(Offset = "0xD0")]
		public static Material FinalBlitMaterial;

		// Token: 0x0400357D RID: 13693
		[Token(Token = "0x400357D")]
		[FieldOffset(Offset = "0xD8")]
		public static Material BasicBlitMaterial;

		// Token: 0x0400357E RID: 13694
		[Token(Token = "0x400357E")]
		[FieldOffset(Offset = "0xE0")]
		public static Material ClearStencilMaterial;

		// Token: 0x0400357F RID: 13695
		[Token(Token = "0x400357F")]
		[FieldOffset(Offset = "0xE8")]
		private static List<OutlineEffect.OutlineTargetGroup> targets;

		// Token: 0x04003580 RID: 13696
		[Token(Token = "0x4003580")]
		[FieldOffset(Offset = "0xF0")]
		private static List<string> keywords;

		// Token: 0x02000C96 RID: 3222
		[Token(Token = "0x2000C96")]
		private struct OutlineTargetGroup
		{
			// Token: 0x06007A42 RID: 31298 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A42")]
			[Address(RVA = "0x32186C8", Offset = "0x32186C8", VA = "0x32186C8")]
			public OutlineTargetGroup(Outlinable outlinable, OutlineTarget target)
			{
			}

			// Token: 0x04003581 RID: 13697
			[Token(Token = "0x4003581")]
			[FieldOffset(Offset = "0x0")]
			public readonly Outlinable Outlinable;

			// Token: 0x04003582 RID: 13698
			[Token(Token = "0x4003582")]
			[FieldOffset(Offset = "0x8")]
			public readonly OutlineTarget Target;
		}
	}
}
