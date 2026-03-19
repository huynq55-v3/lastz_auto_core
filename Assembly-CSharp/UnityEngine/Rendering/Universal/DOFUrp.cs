using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000CC0 RID: 3264
	[Token(Token = "0x2000CC0")]
	public class DOFUrp : ScriptableRendererFeature
	{
		// Token: 0x06007B60 RID: 31584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B60")]
		[Address(RVA = "0x32269B8", Offset = "0x32269B8", VA = "0x32269B8", Slot = "5")]
		public override void Create()
		{
		}

		// Token: 0x06007B61 RID: 31585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B61")]
		[Address(RVA = "0x3226C3C", Offset = "0x3226C3C", VA = "0x3226C3C", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		// Token: 0x06007B62 RID: 31586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B62")]
		[Address(RVA = "0x3226CBC", Offset = "0x3226CBC", VA = "0x3226CBC")]
		public DOFUrp()
		{
		}

		// Token: 0x04003671 RID: 13937
		[Token(Token = "0x4003671")]
		[FieldOffset(Offset = "0x20")]
		public DOFUrp.DOFSettings settings;

		// Token: 0x04003672 RID: 13938
		[Token(Token = "0x4003672")]
		[FieldOffset(Offset = "0x28")]
		private DOFUrpPass dofUrpPass;

		// Token: 0x02000CC1 RID: 3265
		[Token(Token = "0x2000CC1")]
		public enum DepthMethod
		{
			// Token: 0x04003674 RID: 13940
			[Token(Token = "0x4003674")]
			CustomMaterials,
			// Token: 0x04003675 RID: 13941
			[Token(Token = "0x4003675")]
			Depth
		}

		// Token: 0x02000CC2 RID: 3266
		[Token(Token = "0x2000CC2")]
		[Serializable]
		public class DOFSettings
		{
			// Token: 0x06007B63 RID: 31587 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B63")]
			[Address(RVA = "0x3226D48", Offset = "0x3226D48", VA = "0x3226D48")]
			public DOFSettings()
			{
			}

			// Token: 0x04003676 RID: 13942
			[Token(Token = "0x4003676")]
			[FieldOffset(Offset = "0x10")]
			public RenderPassEvent Event;

			// Token: 0x04003677 RID: 13943
			[Token(Token = "0x4003677")]
			[FieldOffset(Offset = "0x14")]
			public DOFUrp.DepthMethod DepthCalculationMetod;

			// Token: 0x04003678 RID: 13944
			[Token(Token = "0x4003678")]
			[FieldOffset(Offset = "0x18")]
			public Material blitMaterial;

			// Token: 0x04003679 RID: 13945
			[Token(Token = "0x4003679")]
			[FieldOffset(Offset = "0x20")]
			[Range(0f, 1f)]
			public float BlurAmount;

			// Token: 0x0400367A RID: 13946
			[Token(Token = "0x400367A")]
			[FieldOffset(Offset = "0x24")]
			public float Focus;

			// Token: 0x0400367B RID: 13947
			[Token(Token = "0x400367B")]
			[FieldOffset(Offset = "0x28")]
			public float Aperture;
		}
	}
}
