using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

// Token: 0x0200001A RID: 26
[Token(Token = "0x200001A")]
public class ClearDepthPass : ScriptableRenderPass
{
	// Token: 0x06000039 RID: 57 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000039")]
	[Address(RVA = "0x15E1B88", Offset = "0x15E1B88", VA = "0x15E1B88")]
	public void SetEvent(RenderPassEvent passEvent)
	{
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600003A")]
	[Address(RVA = "0x15E1B98", Offset = "0x15E1B98", VA = "0x15E1B98", Slot = "9")]
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600003B")]
	[Address(RVA = "0x15E1B9C", Offset = "0x15E1B9C", VA = "0x15E1B9C", Slot = "6")]
	public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
	{
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600003C")]
	[Address(RVA = "0x15E1B48", Offset = "0x15E1B48", VA = "0x15E1B48")]
	public ClearDepthPass()
	{
	}
}
