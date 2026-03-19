using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace RockEngine
{
	// Token: 0x02000CE1 RID: 3297
	[Token(Token = "0x2000CE1")]
	public class SkyRenderFeature : ScriptableRendererFeature
	{
		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06007BE5 RID: 31717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B34")]
		public static SkyRenderFeature Instance
		{
			[Token(Token = "0x6007BE5")]
			[Address(RVA = "0x3196774", Offset = "0x3196774", VA = "0x3196774")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007BE6 RID: 31718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BE6")]
		[Address(RVA = "0x31967BC", Offset = "0x31967BC", VA = "0x31967BC", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		// Token: 0x06007BE7 RID: 31719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BE7")]
		[Address(RVA = "0x3196924", Offset = "0x3196924", VA = "0x3196924")]
		public void SetPosition(Vector3 pos)
		{
		}

		// Token: 0x06007BE8 RID: 31720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BE8")]
		[Address(RVA = "0x3196948", Offset = "0x3196948", VA = "0x3196948", Slot = "5")]
		public override void Create()
		{
		}

		// Token: 0x06007BE9 RID: 31721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BE9")]
		[Address(RVA = "0x31969E8", Offset = "0x31969E8", VA = "0x31969E8")]
		public SkyRenderFeature()
		{
		}

		// Token: 0x040037E3 RID: 14307
		[Token(Token = "0x40037E3")]
		[FieldOffset(Offset = "0x20")]
		private SkyRenderPass postRenderPass;

		// Token: 0x040037E4 RID: 14308
		[Token(Token = "0x40037E4")]
		[FieldOffset(Offset = "0x0")]
		private static SkyRenderFeature instance;
	}
}
