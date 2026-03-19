using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace RockEngine
{
	// Token: 0x02000CE2 RID: 3298
	[Token(Token = "0x2000CE2")]
	public class SkyRenderPass : ScriptableRenderPass
	{
		// Token: 0x06007BEA RID: 31722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BEA")]
		[Address(RVA = "0x31969F0", Offset = "0x31969F0", VA = "0x31969F0")]
		public void SetPosition(Vector3 pos)
		{
		}

		// Token: 0x06007BEB RID: 31723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BEB")]
		[Address(RVA = "0x31968E4", Offset = "0x31968E4", VA = "0x31968E4")]
		public void Setup(RenderTargetIdentifier src, RenderTargetHandle dest, Camera camera)
		{
		}

		// Token: 0x06007BEC RID: 31724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BEC")]
		[Address(RVA = "0x3196A00", Offset = "0x3196A00", VA = "0x3196A00", Slot = "6")]
		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		// Token: 0x06007BED RID: 31725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BED")]
		[Address(RVA = "0x3196A38", Offset = "0x3196A38", VA = "0x3196A38", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		// Token: 0x06007BEE RID: 31726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BEE")]
		[Address(RVA = "0x3196BE8", Offset = "0x3196BE8", VA = "0x3196BE8", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}

		// Token: 0x06007BEF RID: 31727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BEF")]
		[Address(RVA = "0x31969E0", Offset = "0x31969E0", VA = "0x31969E0")]
		public SkyRenderPass()
		{
		}

		// Token: 0x040037E5 RID: 14309
		[Token(Token = "0x40037E5")]
		[FieldOffset(Offset = "0xD8")]
		private RenderTargetHandle m_temporaryColorTexture;

		// Token: 0x040037E6 RID: 14310
		[Token(Token = "0x40037E6")]
		[FieldOffset(Offset = "0x108")]
		private RenderTargetIdentifier source;

		// Token: 0x040037E7 RID: 14311
		[Token(Token = "0x40037E7")]
		[FieldOffset(Offset = "0x130")]
		private RenderTargetHandle destination;

		// Token: 0x040037E8 RID: 14312
		[Token(Token = "0x40037E8")]
		[FieldOffset(Offset = "0x160")]
		private Camera m_camera;

		// Token: 0x040037E9 RID: 14313
		[Token(Token = "0x40037E9")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int centerPosID;

		// Token: 0x040037EA RID: 14314
		[Token(Token = "0x40037EA")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string CUSTOM_PASS_TAG;

		// Token: 0x040037EB RID: 14315
		[Token(Token = "0x40037EB")]
		[FieldOffset(Offset = "0x168")]
		private Vector3 pos;
	}
}
