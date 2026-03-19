using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace EPOOutline
{
	// Token: 0x02000C8A RID: 3210
	[Token(Token = "0x2000C8A")]
	public static class KeywordsUtility
	{
		// Token: 0x060079F2 RID: 31218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60079F2")]
		[Address(RVA = "0x14954C0", Offset = "0x14954C0", VA = "0x14954C0")]
		public static string GetBackKeyword(ComplexMaskingMode mode)
		{
			return null;
		}

		// Token: 0x060079F3 RID: 31219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60079F3")]
		[Address(RVA = "0x149559C", Offset = "0x149559C", VA = "0x149559C")]
		public static string GetTextureArrayCutoutKeyword()
		{
			return null;
		}

		// Token: 0x060079F4 RID: 31220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60079F4")]
		[Address(RVA = "0x14955DC", Offset = "0x14955DC", VA = "0x14955DC")]
		public static string GetDilateQualityKeyword(DilateQuality quality)
		{
			return null;
		}

		// Token: 0x060079F5 RID: 31221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60079F5")]
		[Address(RVA = "0x1495690", Offset = "0x1495690", VA = "0x1495690")]
		public static string GetEnabledInfoBufferKeyword()
		{
			return null;
		}

		// Token: 0x060079F6 RID: 31222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60079F6")]
		[Address(RVA = "0x14956D0", Offset = "0x14956D0", VA = "0x14956D0")]
		public static string GetEdgeMaskKeyword()
		{
			return null;
		}

		// Token: 0x060079F7 RID: 31223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60079F7")]
		[Address(RVA = "0x1495710", Offset = "0x1495710", VA = "0x1495710")]
		public static string GetInfoBufferStageKeyword()
		{
			return null;
		}

		// Token: 0x060079F8 RID: 31224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60079F8")]
		[Address(RVA = "0x1495750", Offset = "0x1495750", VA = "0x1495750")]
		public static string GetBlurKeyword(BlurType type)
		{
			return null;
		}

		// Token: 0x060079F9 RID: 31225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60079F9")]
		[Address(RVA = "0x14957D0", Offset = "0x14957D0", VA = "0x14957D0")]
		public static string GetCutoutKeyword()
		{
			return null;
		}

		// Token: 0x060079FA RID: 31226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079FA")]
		[Address(RVA = "0x1495810", Offset = "0x1495810", VA = "0x1495810")]
		public static void GetAllBlurKeywords(List<string> list)
		{
		}

		// Token: 0x060079FB RID: 31227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079FB")]
		[Address(RVA = "0x1495A2C", Offset = "0x1495A2C", VA = "0x1495A2C")]
		public static void GetAllDilateKeywords(List<string> list)
		{
		}

		// Token: 0x04003520 RID: 13600
		[Token(Token = "0x4003520")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<BlurType, string> BlurTypes;

		// Token: 0x04003521 RID: 13601
		[Token(Token = "0x4003521")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<DilateQuality, string> DilateQualityKeywords;
	}
}
