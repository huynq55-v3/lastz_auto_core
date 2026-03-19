using System;
using Il2CppDummyDll;
using UnityEngine.Rendering.Universal;

// Token: 0x02000019 RID: 25
[Token(Token = "0x2000019")]
public class ClearDepthFeature : ScriptableRendererFeature
{
	// Token: 0x06000036 RID: 54 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000036")]
	[Address(RVA = "0x15E1AE0", Offset = "0x15E1AE0", VA = "0x15E1AE0", Slot = "5")]
	public override void Create()
	{
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000037")]
	[Address(RVA = "0x15E1B50", Offset = "0x15E1B50", VA = "0x15E1B50", Slot = "7")]
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000038")]
	[Address(RVA = "0x15E1B90", Offset = "0x15E1B90", VA = "0x15E1B90")]
	public ClearDepthFeature()
	{
	}

	// Token: 0x04000084 RID: 132
	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x20")]
	private ClearDepthPass _clearColorPass;

	// Token: 0x04000085 RID: 133
	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0x28")]
	public RenderPassEvent _passEvent;

	// Token: 0x04000086 RID: 134
	[Token(Token = "0x4000086")]
	[FieldOffset(Offset = "0x2C")]
	public int offset;
}
