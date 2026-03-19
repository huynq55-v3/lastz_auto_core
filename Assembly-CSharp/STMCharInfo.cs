using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200012E RID: 302
[Token(Token = "0x200012E")]
public class STMCharInfo
{
	// Token: 0x17000136 RID: 310
	// (get) Token: 0x060008D0 RID: 2256 RVA: 0x00004D28 File Offset: 0x00002F28
	[Token(Token = "0x17000136")]
	public Vector3 TopLeftVert
	{
		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x33A96C8", Offset = "0x33A96C8", VA = "0x33A96C8")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x17000137 RID: 311
	// (get) Token: 0x060008D1 RID: 2257 RVA: 0x00004D40 File Offset: 0x00002F40
	[Token(Token = "0x17000137")]
	public Vector3 TopRightVert
	{
		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x33A9654", Offset = "0x33A9654", VA = "0x33A9654")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x17000138 RID: 312
	// (get) Token: 0x060008D2 RID: 2258 RVA: 0x00004D58 File Offset: 0x00002F58
	[Token(Token = "0x17000138")]
	public Vector3 BottomRightVert
	{
		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x33A95E0", Offset = "0x33A95E0", VA = "0x33A95E0")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x17000139 RID: 313
	// (get) Token: 0x060008D3 RID: 2259 RVA: 0x00004D70 File Offset: 0x00002F70
	[Token(Token = "0x17000139")]
	public Vector3 BottomLeftVert
	{
		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x33A973C", Offset = "0x33A973C", VA = "0x33A973C")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x1700013A RID: 314
	// (get) Token: 0x060008D4 RID: 2260 RVA: 0x00004D88 File Offset: 0x00002F88
	[Token(Token = "0x1700013A")]
	public Vector3 Middle
	{
		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x33AB37C", Offset = "0x33AB37C", VA = "0x33AB37C")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x060008D5 RID: 2261 RVA: 0x00004DA0 File Offset: 0x00002FA0
	[Token(Token = "0x60008D5")]
	[Address(RVA = "0x33AB348", Offset = "0x33AB348", VA = "0x33AB348")]
	public Vector3 RelativePos(Vector3 yeah)
	{
		return default(Vector3);
	}

	// Token: 0x060008D6 RID: 2262 RVA: 0x00004DB8 File Offset: 0x00002FB8
	[Token(Token = "0x60008D6")]
	[Address(RVA = "0x33AB42C", Offset = "0x33AB42C", VA = "0x33AB42C")]
	public Vector3 RelativePos2(Vector3 yeah)
	{
		return default(Vector3);
	}

	// Token: 0x060008D7 RID: 2263 RVA: 0x00004DD0 File Offset: 0x00002FD0
	[Token(Token = "0x60008D7")]
	[Address(RVA = "0x33A9590", Offset = "0x33A9590", VA = "0x33A9590")]
	public Vector3 Advance(float extraSpacing, float myQuality)
	{
		return default(Vector3);
	}

	// Token: 0x060008D8 RID: 2264 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008D8")]
	[Address(RVA = "0x33A6BB8", Offset = "0x33A6BB8", VA = "0x33A6BB8")]
	public STMCharInfo(SuperTextMesh stm)
	{
	}

	// Token: 0x060008D9 RID: 2265 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008D9")]
	[Address(RVA = "0x33A6E30", Offset = "0x33A6E30", VA = "0x33A6E30")]
	public STMCharInfo(STMCharInfo clone, CharacterInfo ch)
	{
	}

	// Token: 0x060008DA RID: 2266 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008DA")]
	[Address(RVA = "0x33A6E98", Offset = "0x33A6E98", VA = "0x33A6E98")]
	public void Reset(STMCharInfo clone, CharacterInfo ch)
	{
	}

	// Token: 0x060008DB RID: 2267 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008DB")]
	[Address(RVA = "0x33A6C10", Offset = "0x33A6C10", VA = "0x33A6C10")]
	public void Reset(SuperTextMesh stm)
	{
	}

	// Token: 0x0400069B RID: 1691
	[Token(Token = "0x400069B")]
	[FieldOffset(Offset = "0x10")]
	public CharacterInfo ch;

	// Token: 0x0400069C RID: 1692
	[Token(Token = "0x400069C")]
	[FieldOffset(Offset = "0x44")]
	public Vector3 pos;

	// Token: 0x0400069D RID: 1693
	[Token(Token = "0x400069D")]
	[FieldOffset(Offset = "0x50")]
	public int line;

	// Token: 0x0400069E RID: 1694
	[Token(Token = "0x400069E")]
	[FieldOffset(Offset = "0x54")]
	public float indent;

	// Token: 0x0400069F RID: 1695
	[Token(Token = "0x400069F")]
	[FieldOffset(Offset = "0x58")]
	public float size;
}
