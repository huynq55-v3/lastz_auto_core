using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200008A RID: 138
[Token(Token = "0x200008A")]
public class GaussianBlur : MonoBehaviour
{
	// Token: 0x06000353 RID: 851 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000353")]
	[Address(RVA = "0x3212214", Offset = "0x3212214", VA = "0x3212214")]
	private void Start()
	{
	}

	// Token: 0x06000354 RID: 852 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000354")]
	[Address(RVA = "0x321226C", Offset = "0x321226C", VA = "0x321226C")]
	public void Blur()
	{
	}

	// Token: 0x06000355 RID: 853 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000355")]
	[Address(RVA = "0x321264C", Offset = "0x321264C", VA = "0x321264C")]
	private void ReleaseRT(RenderTexture rt)
	{
	}

	// Token: 0x06000356 RID: 854 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000356")]
	[Address(RVA = "0x32126CC", Offset = "0x32126CC", VA = "0x32126CC")]
	private void OnDisable()
	{
	}

	// Token: 0x06000357 RID: 855 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000357")]
	[Address(RVA = "0x32126E8", Offset = "0x32126E8", VA = "0x32126E8")]
	public GaussianBlur()
	{
	}

	// Token: 0x040002D1 RID: 721
	[Token(Token = "0x40002D1")]
	[FieldOffset(Offset = "0x18")]
	private Texture myTexture;

	// Token: 0x040002D2 RID: 722
	[Token(Token = "0x40002D2")]
	[FieldOffset(Offset = "0x20")]
	public Material mat;

	// Token: 0x040002D3 RID: 723
	[Token(Token = "0x40002D3")]
	[FieldOffset(Offset = "0x28")]
	private RenderTexture buffer0;

	// Token: 0x040002D4 RID: 724
	[Token(Token = "0x40002D4")]
	[FieldOffset(Offset = "0x30")]
	private RenderTexture buffer1;

	// Token: 0x040002D5 RID: 725
	[Token(Token = "0x40002D5")]
	[FieldOffset(Offset = "0x38")]
	private RenderTexture buffer2;

	// Token: 0x040002D6 RID: 726
	[Token(Token = "0x40002D6")]
	[FieldOffset(Offset = "0x40")]
	private RawImage rawImage;

	// Token: 0x040002D7 RID: 727
	[Token(Token = "0x40002D7")]
	[FieldOffset(Offset = "0x48")]
	public float blurRaius;

	// Token: 0x040002D8 RID: 728
	[Token(Token = "0x40002D8")]
	[FieldOffset(Offset = "0x4C")]
	public int blurTimes;

	// Token: 0x040002D9 RID: 729
	[Token(Token = "0x40002D9")]
	[FieldOffset(Offset = "0x50")]
	public int downloadTimes;

	// Token: 0x040002DA RID: 730
	[Token(Token = "0x40002DA")]
	[FieldOffset(Offset = "0x54")]
	private int width;

	// Token: 0x040002DB RID: 731
	[Token(Token = "0x40002DB")]
	[FieldOffset(Offset = "0x58")]
	private int heigh;

	// Token: 0x040002DC RID: 732
	[Token(Token = "0x40002DC")]
	[FieldOffset(Offset = "0x5C")]
	private bool capter;
}
