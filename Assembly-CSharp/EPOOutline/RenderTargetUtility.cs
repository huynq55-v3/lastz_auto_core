using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace EPOOutline
{
	// Token: 0x02000CA5 RID: 3237
	[Token(Token = "0x2000CA5")]
	public static class RenderTargetUtility
	{
		// Token: 0x06007AA9 RID: 31401 RVA: 0x00053E50 File Offset: 0x00052050
		[Token(Token = "0x6007AA9")]
		[Address(RVA = "0x321B184", Offset = "0x321B184", VA = "0x321B184")]
		public static int GetDepthSliceForEye(StereoTargetEyeMask mask)
		{
			return 0;
		}

		// Token: 0x06007AAA RID: 31402 RVA: 0x00053E68 File Offset: 0x00052068
		[Token(Token = "0x6007AAA")]
		[Address(RVA = "0x321A50C", Offset = "0x321A50C", VA = "0x321A50C")]
		public static RenderTargetIdentifier ComposeTarget(OutlineParameters parameters, RenderTargetIdentifier target)
		{
			return default(RenderTargetIdentifier);
		}

		// Token: 0x06007AAB RID: 31403 RVA: 0x00053E80 File Offset: 0x00052080
		[Token(Token = "0x6007AAB")]
		[Address(RVA = "0x321B1F0", Offset = "0x321B1F0", VA = "0x321B1F0")]
		public static bool IsUsingVR(OutlineParameters parameters)
		{
			return default(bool);
		}

		// Token: 0x06007AAC RID: 31404 RVA: 0x00053E98 File Offset: 0x00052098
		[Token(Token = "0x6007AAC")]
		[Address(RVA = "0x321B1F8", Offset = "0x321B1F8", VA = "0x321B1F8")]
		public static RenderTargetUtility.RenderTextureInfo GetTargetInfo(OutlineParameters parameters, int width, int height, int depthBuffer, bool forceNoAA, bool noFiltering)
		{
			return default(RenderTargetUtility.RenderTextureInfo);
		}

		// Token: 0x06007AAD RID: 31405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AAD")]
		[Address(RVA = "0x321B420", Offset = "0x321B420", VA = "0x321B420")]
		public static void GetTemporaryRT(OutlineParameters parameters, int id, int width, int height, int depthBuffer, bool clear, bool forceNoAA, bool noFiltering)
		{
		}

		// Token: 0x06007AAE RID: 31406 RVA: 0x00053EB0 File Offset: 0x000520B0
		[Token(Token = "0x6007AAE")]
		[Address(RVA = "0x321B2C8", Offset = "0x321B2C8", VA = "0x321B2C8")]
		private static RenderTextureFormat GetHDRFormat()
		{
			return default(RenderTextureFormat);
		}

		// Token: 0x040035F4 RID: 13812
		[Token(Token = "0x40035F4")]
		[FieldOffset(Offset = "0x0")]
		private static RenderTextureFormat? hdrFormat;

		// Token: 0x02000CA6 RID: 3238
		[Token(Token = "0x2000CA6")]
		public struct RenderTextureInfo
		{
			// Token: 0x06007AAF RID: 31407 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AAF")]
			[Address(RVA = "0x321B404", Offset = "0x321B404", VA = "0x321B404")]
			public RenderTextureInfo(RenderTextureDescriptor descriptor, FilterMode filterMode)
			{
			}

			// Token: 0x040035F5 RID: 13813
			[Token(Token = "0x40035F5")]
			[FieldOffset(Offset = "0x0")]
			public readonly RenderTextureDescriptor Descriptor;

			// Token: 0x040035F6 RID: 13814
			[Token(Token = "0x40035F6")]
			[FieldOffset(Offset = "0x34")]
			public readonly FilterMode FilterMode;
		}
	}
}
