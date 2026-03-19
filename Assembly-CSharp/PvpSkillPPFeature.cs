using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

// Token: 0x02000022 RID: 34
[Token(Token = "0x2000022")]
public class PvpSkillPPFeature : ScriptableRendererFeature
{
	// Token: 0x0600005C RID: 92 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005C")]
	[Address(RVA = "0x15E41E4", Offset = "0x15E41E4", VA = "0x15E41E4", Slot = "5")]
	public override void Create()
	{
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005D")]
	[Address(RVA = "0x15E42A0", Offset = "0x15E42A0", VA = "0x15E42A0", Slot = "7")]
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005E")]
	[Address(RVA = "0x15E42C4", Offset = "0x15E42C4", VA = "0x15E42C4")]
	public PvpSkillPPFeature()
	{
	}

	// Token: 0x040000B1 RID: 177
	[Token(Token = "0x40000B1")]
	[FieldOffset(Offset = "0x20")]
	public PvpSkillPPFeature.PostSettings settings;

	// Token: 0x040000B2 RID: 178
	[Token(Token = "0x40000B2")]
	[FieldOffset(Offset = "0x28")]
	private PvpSkillPPFeature.CustomRenderPass m_ScriptablePass;

	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	[Serializable]
	public class PostSettings
	{
		// Token: 0x0600005F RID: 95 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x15E4354", Offset = "0x15E4354", VA = "0x15E4354")]
		public PostSettings()
		{
		}

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x10")]
		public RenderPassEvent renderPassEvent;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x18")]
		public Material material;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x20")]
		public float Dark;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x24")]
		public float Gray;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x28")]
		public float GrayLerp;
	}

	// Token: 0x02000024 RID: 36
	[Token(Token = "0x2000024")]
	private class CustomRenderPass : ScriptableRenderPass
	{
		// Token: 0x06000060 RID: 96 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x15E4378", Offset = "0x15E4378", VA = "0x15E4378", Slot = "5")]
		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x15E447C", Offset = "0x15E447C", VA = "0x15E447C", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x15E4754", Offset = "0x15E4754", VA = "0x15E4754", Slot = "7")]
		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x15E4298", Offset = "0x15E4298", VA = "0x15E4298")]
		public CustomRenderPass()
		{
		}

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0xD8")]
		public Material material;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0xE0")]
		public float dark;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0xE4")]
		public float gray;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0xE8")]
		public float grayLerp;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int _TempRTID;
	}
}
