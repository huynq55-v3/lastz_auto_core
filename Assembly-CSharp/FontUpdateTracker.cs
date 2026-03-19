using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200012F RID: 303
[Token(Token = "0x200012F")]
internal static class FontUpdateTracker
{
	// Token: 0x060008DC RID: 2268 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008DC")]
	[Address(RVA = "0x33A7158", Offset = "0x33A7158", VA = "0x33A7158")]
	public static void TrackText(SuperTextMesh t)
	{
	}

	// Token: 0x060008DD RID: 2269 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008DD")]
	[Address(RVA = "0x33AB45C", Offset = "0x33AB45C", VA = "0x33AB45C")]
	private static void RebuildForFont(Font f)
	{
	}

	// Token: 0x060008DE RID: 2270 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008DE")]
	[Address(RVA = "0x33AA808", Offset = "0x33AA808", VA = "0x33AA808")]
	public static Material GetMaterial(SuperTextMesh t)
	{
		return null;
	}

	// Token: 0x060008DF RID: 2271 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008DF")]
	[Address(RVA = "0x33A75BC", Offset = "0x33A75BC", VA = "0x33A75BC")]
	public static void UntrackText(SuperTextMesh t)
	{
	}

	// Token: 0x060008E0 RID: 2272 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E0")]
	[Address(RVA = "0x33AB5FC", Offset = "0x33AB5FC", VA = "0x33AB5FC")]
	private static void DestroyImmediate(Object obj)
	{
	}

	// Token: 0x040006A0 RID: 1696
	[Token(Token = "0x40006A0")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<Font, HashSet<SuperTextMesh>> m_Tracked;

	// Token: 0x040006A1 RID: 1697
	[Token(Token = "0x40006A1")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<Font, FontUpdateTracker.FontMaterial> m_FontMaterial;

	// Token: 0x02000130 RID: 304
	[Token(Token = "0x2000130")]
	private class FontMaterial
	{
		// Token: 0x060008E2 RID: 2274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x33AB454", Offset = "0x33AB454", VA = "0x33AB454")]
		public FontMaterial()
		{
		}

		// Token: 0x040006A2 RID: 1698
		[Token(Token = "0x40006A2")]
		[FieldOffset(Offset = "0x10")]
		public Font font;

		// Token: 0x040006A3 RID: 1699
		[Token(Token = "0x40006A3")]
		[FieldOffset(Offset = "0x18")]
		public Material matZTestOn;

		// Token: 0x040006A4 RID: 1700
		[Token(Token = "0x40006A4")]
		[FieldOffset(Offset = "0x20")]
		public Material matZTestOff;
	}
}
