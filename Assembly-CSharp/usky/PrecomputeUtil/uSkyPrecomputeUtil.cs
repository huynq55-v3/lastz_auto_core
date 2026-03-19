using System;
using Il2CppDummyDll;
using UnityEngine;

namespace usky.PrecomputeUtil
{
	// Token: 0x02000A2D RID: 2605
	[Token(Token = "0x2000A2D")]
	public sealed class uSkyPrecomputeUtil
	{
		// Token: 0x060062EB RID: 25323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062EB")]
		[Address(RVA = "0x303B11C", Offset = "0x303B11C", VA = "0x303B11C")]
		private static void PrecomputeTextureResource(int TotalInscatterTextureHeight)
		{
		}

		// Token: 0x060062EC RID: 25324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062EC")]
		[Address(RVA = "0x303B318", Offset = "0x303B318", VA = "0x303B318")]
		private static void InitPrecomputeUniform(int sample, Vector4 lambda)
		{
		}

		// Token: 0x060062ED RID: 25325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062ED")]
		[Address(RVA = "0x303B3EC", Offset = "0x303B3EC", VA = "0x303B3EC")]
		public static void StartPrecompute(Material pMaterial, PrecomputeSettings pSetting)
		{
		}

		// Token: 0x060062EE RID: 25326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062EE")]
		[Address(RVA = "0x303B788", Offset = "0x303B788", VA = "0x303B788")]
		public static void StartPrecomputeRT(Material pMaterial, PrecomputeSettings pSetting)
		{
		}

		// Token: 0x060062EF RID: 25327 RVA: 0x0004BC48 File Offset: 0x00049E48
		[Token(Token = "0x60062EF")]
		[Address(RVA = "0x303B5F8", Offset = "0x303B5F8", VA = "0x303B5F8")]
		private static Vector4 Lambda(Vector3 Wavelengths, Color SkyTint, float AtmosphereThickness)
		{
			return default(Vector4);
		}

		// Token: 0x060062F0 RID: 25328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062F0")]
		[Address(RVA = "0x303BBE4", Offset = "0x303BBE4", VA = "0x303BBE4")]
		public uSkyPrecomputeUtil()
		{
		}

		// Token: 0x04002776 RID: 10102
		[Token(Token = "0x4002776")]
		private const int TRANSMITTANCE_WIDTH = 256;

		// Token: 0x04002777 RID: 10103
		[Token(Token = "0x4002777")]
		private const int TRANSMITTANCE_HEIGHT = 64;

		// Token: 0x04002778 RID: 10104
		[Token(Token = "0x4002778")]
		private const int INSCATTER_WIDTH = 256;

		// Token: 0x04002779 RID: 10105
		[Token(Token = "0x4002779")]
		private const int INSCATTER_HEIGHT = 128;

		// Token: 0x0400277A RID: 10106
		[Token(Token = "0x400277A")]
		[FieldOffset(Offset = "0x0")]
		public static Texture2D Inscatter2D;

		// Token: 0x0400277B RID: 10107
		[Token(Token = "0x400277B")]
		[FieldOffset(Offset = "0x8")]
		public static RenderTexture m_TransmittanceRT;

		// Token: 0x0400277C RID: 10108
		[Token(Token = "0x400277C")]
		[FieldOffset(Offset = "0x10")]
		public static RenderTexture m_InscatterRT;

		// Token: 0x0400277D RID: 10109
		[Token(Token = "0x400277D")]
		[FieldOffset(Offset = "0x18")]
		private static bool isInit;
	}
}
